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
	public class Form_PO_MoldCapa_1 : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.ComponentModel.IContainer components = null;

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.Label lbl_Model;
		private C1.Win.C1List.C1Combo cmb_ToNo;
		private C1.Win.C1List.C1Combo cmb_FromNo;


		#region 사용자 변수

		private COM.OraDB oraDB = null;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1List.C1Combo cmb_Model;
		private C1.Win.C1List.C1Combo cmb_gen;
		private System.Windows.Forms.Label lbl_gen;
		private System.Windows.Forms.TextBox txt_plancapa;
		private System.Windows.Forms.CheckBox chk_rowshow;
		private System.Windows.Forms.Label lbl_rowshow;
		private System.Windows.Forms.Label lbl_plancapa;
		public COM.FSP fgrid_Style;
		public COM.FSP fgrid_Mold;
		private bool show_row = false;

		#endregion


		public Form_PO_MoldCapa_1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_MoldCapa_1));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.chk_rowshow = new System.Windows.Forms.CheckBox();
			this.lbl_rowshow = new System.Windows.Forms.Label();
			this.txt_plancapa = new System.Windows.Forms.TextBox();
			this.lbl_plancapa = new System.Windows.Forms.Label();
			this.lbl_gen = new System.Windows.Forms.Label();
			this.cmb_gen = new C1.Win.C1List.C1Combo();
			this.cmb_Model = new C1.Win.C1List.C1Combo();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_ToNo = new C1.Win.C1List.C1Combo();
			this.cmb_FromNo = new C1.Win.C1List.C1Combo();
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
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.fgrid_Style = new COM.FSP();
			this.fgrid_Mold = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_gen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).BeginInit();
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
			this.pnl_Search.Controls.Add(this.chk_rowshow);
			this.pnl_Search.Controls.Add(this.lbl_rowshow);
			this.pnl_Search.Controls.Add(this.txt_plancapa);
			this.pnl_Search.Controls.Add(this.lbl_plancapa);
			this.pnl_Search.Controls.Add(this.lbl_gen);
			this.pnl_Search.Controls.Add(this.cmb_gen);
			this.pnl_Search.Controls.Add(this.cmb_Model);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 10;
			this.pnl_Search.DockPadding.Right = 10;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 88);
			this.pnl_Search.TabIndex = 42;
			// 
			// chk_rowshow
			// 
			this.chk_rowshow.BackColor = System.Drawing.Color.Transparent;
			this.chk_rowshow.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_rowshow.Location = new System.Drawing.Point(949, 58);
			this.chk_rowshow.Name = "chk_rowshow";
			this.chk_rowshow.Size = new System.Drawing.Size(21, 21);
			this.chk_rowshow.TabIndex = 60;
			this.chk_rowshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_rowshow.CheckedChanged += new System.EventHandler(this.chk_rowshow_CheckedChanged);
			// 
			// lbl_rowshow
			// 
			this.lbl_rowshow.ImageIndex = 0;
			this.lbl_rowshow.ImageList = this.img_Label;
			this.lbl_rowshow.Location = new System.Drawing.Point(848, 58);
			this.lbl_rowshow.Name = "lbl_rowshow";
			this.lbl_rowshow.Size = new System.Drawing.Size(100, 21);
			this.lbl_rowshow.TabIndex = 59;
			this.lbl_rowshow.Text = "More Info";
			this.lbl_rowshow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_plancapa
			// 
			this.txt_plancapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_plancapa.Location = new System.Drawing.Point(701, 57);
			this.txt_plancapa.Name = "txt_plancapa";
			this.txt_plancapa.Size = new System.Drawing.Size(120, 22);
			this.txt_plancapa.TabIndex = 58;
			this.txt_plancapa.Text = "";
			this.txt_plancapa.TextChanged += new System.EventHandler(this.txt_plancapa_TextChanged);
			// 
			// lbl_plancapa
			// 
			this.lbl_plancapa.ImageIndex = 0;
			this.lbl_plancapa.ImageList = this.img_Label;
			this.lbl_plancapa.Location = new System.Drawing.Point(600, 58);
			this.lbl_plancapa.Name = "lbl_plancapa";
			this.lbl_plancapa.Size = new System.Drawing.Size(100, 21);
			this.lbl_plancapa.TabIndex = 57;
			this.lbl_plancapa.Text = "Daily Plan";
			this.lbl_plancapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_gen
			// 
			this.lbl_gen.ImageIndex = 0;
			this.lbl_gen.ImageList = this.img_Label;
			this.lbl_gen.Location = new System.Drawing.Point(298, 58);
			this.lbl_gen.Name = "lbl_gen";
			this.lbl_gen.Size = new System.Drawing.Size(100, 21);
			this.lbl_gen.TabIndex = 56;
			this.lbl_gen.Text = "Gender";
			this.lbl_gen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_gen
			// 
			this.cmb_gen.AddItemCols = 0;
			this.cmb_gen.AddItemSeparator = ';';
			this.cmb_gen.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_gen.Caption = "";
			this.cmb_gen.CaptionHeight = 17;
			this.cmb_gen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_gen.ColumnCaptionHeight = 18;
			this.cmb_gen.ColumnFooterHeight = 18;
			this.cmb_gen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_gen.ContentHeight = 17;
			this.cmb_gen.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_gen.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_gen.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_gen.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_gen.EditorHeight = 17;
			this.cmb_gen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_gen.GapHeight = 2;
			this.cmb_gen.ItemHeight = 15;
			this.cmb_gen.Location = new System.Drawing.Point(399, 58);
			this.cmb_gen.MatchEntryTimeout = ((long)(2000));
			this.cmb_gen.MaxDropDownItems = ((short)(5));
			this.cmb_gen.MaxLength = 32767;
			this.cmb_gen.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_gen.Name = "cmb_gen";
			this.cmb_gen.PartialRightColumn = false;
			this.cmb_gen.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_gen.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_gen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_gen.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_gen.Size = new System.Drawing.Size(176, 21);
			this.cmb_gen.TabIndex = 55;
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
			this.cmb_Model.Location = new System.Drawing.Point(121, 58);
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
			this.cmb_Model.Size = new System.Drawing.Size(150, 21);
			this.cmb_Model.TabIndex = 54;
			this.cmb_Model.SelectedValueChanged += new System.EventHandler(this.cmb_Model_SelectedValueChanged);
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.cmb_ToNo);
			this.pnl_SearchImage.Controls.Add(this.cmb_FromNo);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(10, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(996, 83);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// lbl_Model
			// 
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.Location = new System.Drawing.Point(10, 58);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 44;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(469, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 21);
			this.label1.TabIndex = 42;
			this.label1.Text = "~";
			// 
			// cmb_ToNo
			// 
			this.cmb_ToNo.AddItemCols = 0;
			this.cmb_ToNo.AddItemSeparator = ';';
			this.cmb_ToNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ToNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ToNo.Caption = "";
			this.cmb_ToNo.CaptionHeight = 17;
			this.cmb_ToNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ToNo.ColumnCaptionHeight = 18;
			this.cmb_ToNo.ColumnFooterHeight = 18;
			this.cmb_ToNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ToNo.ContentHeight = 17;
			this.cmb_ToNo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ToNo.EditorBackColor = System.Drawing.Color.White;
			this.cmb_ToNo.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ToNo.EditorHeight = 17;
			this.cmb_ToNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToNo.GapHeight = 2;
			this.cmb_ToNo.ItemHeight = 15;
			this.cmb_ToNo.Location = new System.Drawing.Point(485, 36);
			this.cmb_ToNo.MatchEntryTimeout = ((long)(2000));
			this.cmb_ToNo.MaxDropDownItems = ((short)(5));
			this.cmb_ToNo.MaxLength = 32767;
			this.cmb_ToNo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ToNo.Name = "cmb_ToNo";
			this.cmb_ToNo.PartialRightColumn = false;
			this.cmb_ToNo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_ToNo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ToNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ToNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ToNo.Size = new System.Drawing.Size(80, 21);
			this.cmb_ToNo.TabIndex = 38;
			this.cmb_ToNo.SelectedValueChanged += new System.EventHandler(this.cmb_ToNo_SelectedValueChanged);
			// 
			// cmb_FromNo
			// 
			this.cmb_FromNo.AddItemCols = 0;
			this.cmb_FromNo.AddItemSeparator = ';';
			this.cmb_FromNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_FromNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_FromNo.Caption = "";
			this.cmb_FromNo.CaptionHeight = 17;
			this.cmb_FromNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_FromNo.ColumnCaptionHeight = 18;
			this.cmb_FromNo.ColumnFooterHeight = 18;
			this.cmb_FromNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_FromNo.ContentHeight = 17;
			this.cmb_FromNo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_FromNo.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_FromNo.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_FromNo.EditorHeight = 17;
			this.cmb_FromNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromNo.GapHeight = 2;
			this.cmb_FromNo.ItemHeight = 15;
			this.cmb_FromNo.Location = new System.Drawing.Point(389, 36);
			this.cmb_FromNo.MatchEntryTimeout = ((long)(2000));
			this.cmb_FromNo.MaxDropDownItems = ((short)(5));
			this.cmb_FromNo.MaxLength = 32767;
			this.cmb_FromNo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_FromNo.Name = "cmb_FromNo";
			this.cmb_FromNo.PartialRightColumn = false;
			this.cmb_FromNo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_FromNo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_FromNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_FromNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_FromNo.Size = new System.Drawing.Size(80, 21);
			this.cmb_FromNo.TabIndex = 36;
			this.cmb_FromNo.SelectedValueChanged += new System.EventHandler(this.cmb_FromNo_SelectedValueChanged);
			// 
			// lbl_Date
			// 
			this.lbl_Date.ImageIndex = 0;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(288, 36);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 35;
			this.lbl_Date.Text = "Req. No";
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
			this.picb_MR.Location = new System.Drawing.Point(981, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 43);
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
			this.lbl_SubTitle1.Text = "      Order Request NO Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(980, 67);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 65);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 63);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 43);
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
			this.picb_MM.Size = new System.Drawing.Size(828, 43);
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
			// fgrid_Style
			// 
			this.fgrid_Style.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Style.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Style.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Style.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Style.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Style.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Style.Font = new System.Drawing.Font("Verdana", 6.75F);
			this.fgrid_Style.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Style.Location = new System.Drawing.Point(10, 152);
			this.fgrid_Style.Name = "fgrid_Style";
			this.fgrid_Style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Style.Size = new System.Drawing.Size(996, 168);
			this.fgrid_Style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Style.TabIndex = 46;
			this.fgrid_Style.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Style_AfterResizeColumn);
			this.fgrid_Style.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_AfterScroll);
			this.fgrid_Style.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Style_AfterEdit);
			// 
			// fgrid_Mold
			// 
			this.fgrid_Mold.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Mold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Mold.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Mold.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Mold.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mold.Location = new System.Drawing.Point(10, 328);
			this.fgrid_Mold.Name = "fgrid_Mold";
			this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mold.Size = new System.Drawing.Size(996, 312);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 47;
			this.fgrid_Mold.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_AfterScroll);
			this.fgrid_Mold.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Mold_AfterEdit);
			// 
			// Form_PO_MoldCapa_1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Mold);
			this.Controls.Add(this.fgrid_Style);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PO_MoldCapa_1";
			this.Text = "Mold Capacity";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PO_MoldCapa_1_Closing);
			this.Load += new System.EventHandler(this.Form_PO_MoldCapa_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Style, 0);
			this.Controls.SetChildIndex(this.fgrid_Mold, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_gen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
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

		#region 스크롤 동기화 작업

		// synchronize grid scrolling
		bool _synchronizing = false;

		private void fgrid_AfterScroll(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
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
				}
				 

				// done
				_synchronizing = false;

			} // end if
			 
		}


		#endregion

		#region 속성 정의 

 
		public int _IxGen_Value, _IxStart_Size, _IxTotal;
 
		public int _BeforeSelCol = -1;

		private int _Ix_Gen_S = 1;
		private int _Ix_Gen_E = 6;
		private int _lx_Size_S = 5;
		private int _lx_Size_E = 0;
		private int col_width = 40;
		private int gen_width = 25;


		//private int total_MEWO = 0;
		//private int total_GS   = 0;
		//private int total_PS   = 0;
		//private int total_IN   = 0;


		private bool show_check = false;


		#endregion

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			
			this.Text = "Mold Forcast";
			this.lbl_MainTitle.Text = "Mold Forcast"; 
			ClassLib.ComFunction.SetLangDic(this);

			
			oraDB = new COM.OraDB();

			DataTable dt_list; 
			CellStyle cellst; 


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



			tbtn_Color.Enabled  = false;
			tbtn_Save.Enabled   = false;
			tbtn_Append.Enabled = false;
			tbtn_Create.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Insert.Enabled = false;
			//tbtn_Print.Enabled  = false;



 

			fgrid_Style.Set_Grid("SPO_MOLD_CAPA", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
			Set_Gender_Grid(fgrid_Style);
			fgrid_Style.Font = new Font("Verdana", 7);

			//--------------------------------------------------------
			//CHECKBOX
			cellst = fgrid_Style.Styles.Add("CHECKBOX");
			cellst.DataType = Type.GetType("System.Boolean"); 
			fgrid_Style.Cols[(int)ClassLib.TBSPO_STYLE_SIZE.IxCHECK_FLAG].Style = fgrid_Style.Styles["CHECKBOX"];
 
			fgrid_Style.Cols.Frozen = 5; 

			for(int i = (int)ClassLib.TBSPO_STYLE_SIZE.IxSTYLE_CD; i < fgrid_Style.Cols.Count; i++)
			{
				fgrid_Style.Cols[i].AllowEditing = false;
			}


			fgrid_Style.Cols[0].Visible = false;


			fgrid_Mold.Set_Grid("SPO_MOLD_CAPA", "2", 1, ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForSearch, false); 
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold); 
			fgrid_Mold.Font = new Font("Verdana", 7);

			fgrid_Mold.Cols.Frozen = 5; 

			fgrid_Mold.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;

			fgrid_Mold.Cols[0].Visible = false;

			for(int i = 0; i < fgrid_Mold.Rows.Fixed; i++)
			{
				fgrid_Mold.Rows[i].Visible = false;
			}

			//--------------------------------------------------------
 
			dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false,COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 



			if(COM.ComVar.ToolingCheckList_From_DPO.Trim().Length > 0 && COM.ComVar.ToolingCheckList_To_DPO.Trim().Length > 0)
			{
				cmb_FromNo.SelectedValue = COM.ComVar.ToolingCheckList_From_DPO.Trim();
				cmb_ToNo.SelectedValue = COM.ComVar.ToolingCheckList_To_DPO.Trim();

				try
				{

					cmb_Model.SelectedIndex = 0;
					Set_Grid_Data();
				}
				catch
				{
				}
			}


			Run_Proc(cmb_Factory.SelectedValue.ToString());
   
 
		}


		/// <summary>
		/// Set_Gender_Grid : 
		/// </summary>
		/// <param name="arg_fgrid"></param>
		private void Set_Gender_Grid1(C1FlexGrid arg_fgrid)
		{
			
			DataTable dt_list;
			DataTable dt_size_list;

			string[] new_data = new string[arg_fgrid.Cols.Count]; 
			
			//int size_count = 0;

			

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

			//arg_fgrid.AutoSizeCols();

 			

			//------------------------------------------------
			//젠더 입력

			_IxGen_Value = 4;








			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();
			}


			arg_fgrid.Rows.Add();

			DataTable dt = Select_Test();

			int dt_row = dt.Rows.Count;

			for(int i=0; i<dt_row; i++)
			{
				arg_fgrid.Cols.Add();

				arg_fgrid[arg_fgrid.Rows.Count-1, arg_fgrid.Cols.Count-1] = dt.Rows[i].ItemArray[0].ToString();
			}



			//------------------------------------------------
			//사이즈 문대 표시
			
			_IxStart_Size = _IxGen_Value + 1;

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{

				dt_size_list = Select_Gen_Size(dt_list.Rows[i].ItemArray[3].ToString());

				for(int j=0; j<dt_size_list.Rows.Count; j++)
				{
					string gen = dt_list.Rows[i].ItemArray[3].ToString();
					string cs_size = dt_size_list.Rows[j].ItemArray[0].ToString();
					string cm_size = dt_size_list.Rows[j].ItemArray[1].ToString();

					int k;
					int l;
					
					for(l=1; l<6; l++)
					{
						if(arg_fgrid[l, _IxGen_Value].ToString() == gen)
						{
							break;
						}
					}


					for(k=_IxStart_Size;  k<arg_fgrid.Cols.Count; k++)
					{
						if(arg_fgrid[arg_fgrid.Rows.Count-1, k].ToString() == cm_size)
						{
							arg_fgrid[l,k] = cs_size;
						}
					}

					
				}
			}
			
			//------------------------------------------------


			for(int i = 0; i < arg_fgrid.Rows.Count; i++)
			{
				arg_fgrid.Rows[i].TextAlign = TextAlignEnum.CenterCenter; 
			}
			
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


			arg_fgrid.Rows[arg_fgrid.Rows.Count-1].Visible = false;

			for(int j=_Ix_Gen_S; j<_Ix_Gen_E; j++)
			{
				if(fgrid_Style[j, 4].ToString() == "ME")
				{
					fgrid_Style.Rows[j].Visible = true;
				}
				else
				{
					fgrid_Style.Rows[j].Visible = false;
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
				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[(int)COM.TBSCM_CODE.IxCOM_VALUE2].ToString();

				//------------------------------------------------------------------
				if(arg_fgrid[i + 1, _IxGen_Value].ToString() == "ME" 
					|| arg_fgrid[i + 1, _IxGen_Value].ToString() == "WO") continue;

				arg_fgrid.Rows[i + 1].Visible = false;
 
				//------------------------------------------------------------------


			}


			//------------------------------------------------
			//사이즈 문대 표시
			
			_IxStart_Size = _IxGen_Value + 1;

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				dt_size_list = Select_Gen_Size(dt_list.Rows[i].ItemArray[(int)COM.TBSCM_CODE.IxCOM_VALUE2].ToString());

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

			for(int i = 0; i < arg_fgrid.Rows.Count; i++)
			{
				arg_fgrid.Rows[i].TextAlign = TextAlignEnum.CenterCenter; 
			}

			//------------------------------------------------
		 
			for(int i = _IxGen_Value; i < arg_fgrid.Cols.Count; i++)
			{
				

				arg_fgrid.Cols[i].Width = 45; 
				
				if(i == _IxGen_Value)
				{
					arg_fgrid.Cols[i].Width = 30; 
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
		}




//		/// <summary>
//		/// Select_Gen_Size : 
//		/// </summary>
//		/// <param name="arg_gen"></param>
//		/// <returns></returns>
//		private DataTable Select_Gen_Size(string arg_gen)
//		{
//			DataTable dt_list;
// 
//		 
//			ClassLib.ComVar.ReDim_Parameter(3); 
//
//			ClassLib.ComVar.Process_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE1";
//
//			ClassLib.ComVar.Parameter_Name[1] = "ARG_FACTORY";
//			ClassLib.ComVar.Parameter_Name[2] = "ARG_GEN"; 
//			ClassLib.ComVar.Parameter_Name[3] = "OUT_CURSOR"; 
//
//			ClassLib.ComVar.Parameter_Type[1] = 1;
//			ClassLib.ComVar.Parameter_Type[2] = 1; 
//			ClassLib.ComVar.Parameter_Type[3] = 9; 
//
//			ClassLib.ComVar.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
//			ClassLib.ComVar.Parameter_Values[2] = arg_gen;
//			ClassLib.ComVar.Parameter_Values[3] = ""; 
//
//			dt_list = ClassLib.ComVar.WebService.Oracle_Select_Procedure(ClassLib.ComVar.Process_Name, ClassLib.ComVar.Parameter_Name, ClassLib.ComVar.Parameter_Type, ClassLib.ComVar.Parameter_Values).Tables[0];
// 
//			 
//			return dt_list; 
//
//
//
//
//		}


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

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_gen;
			oraDB.Parameter_Values[2] = "";

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
//			DataTable dt_list;
//
//			ClassLib.ComVar.ReDim_Parameter(2); 
//
//			ClassLib.ComVar.Process_Name = "PKG_SPO_ORDER_BSC.SELECT_DPO_CMBLIST";
//
//			ClassLib.ComVar.Parameter_Name[1] = "ARG_FACTORY"; 
//			ClassLib.ComVar.Parameter_Name[2] = "OUT_CURSOR";
//
//			ClassLib.ComVar.Parameter_Type[1] = 1; 
//			ClassLib.ComVar.Parameter_Type[2] = 9;
//
//			ClassLib.ComVar.Parameter_Values[1] = arg_factory ; 
//			ClassLib.ComVar.Parameter_Values[2] = "";
//
//			dt_list = ClassLib.ComVar.WebService.Oracle_Select_Procedure(ClassLib.ComVar.Process_Name, ClassLib.ComVar.Parameter_Name, ClassLib.ComVar.Parameter_Type, ClassLib.ComVar.Parameter_Values).Tables[0];
//			
//			return dt_list; 



			string Proc_Name = "PKG_SPO_ORDER_BSC.SELECT_DPO_CMBLIST";

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
			
			return DS_Ret.Tables[Proc_Name];
 
			
		}



		/// <summary>
		/// Select_Model_CmbList : req_no 범위 내의 스타일에 대한 모델 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Model_CmbList()
		{
			//DataTable dt_list;

			string fromdate, todate;

			fromdate = ClassLib.ComFunction.Empty_Combo(cmb_FromNo, " ");
			todate = ClassLib.ComFunction.Empty_Combo(cmb_ToNo, " "); 
		 
//			ClassLib.ComVar.ReDim_Parameter(4); 
//
//			ClassLib.ComVar.Process_Name = "PKG_SPO_ORDER_BSC.SELECT_MODEL_CMBLIST";
//
//			ClassLib.ComVar.Parameter_Name[1] = "ARG_FACTORY";
//			ClassLib.ComVar.Parameter_Name[2] = "ARG_FROM_DATE";
//			ClassLib.ComVar.Parameter_Name[3] = "ARG_TO_DATE";
//			ClassLib.ComVar.Parameter_Name[4] = "OUT_CURSOR"; 
//
//			ClassLib.ComVar.Parameter_Type[1] = 1;
//			ClassLib.ComVar.Parameter_Type[2] = 1;
//			ClassLib.ComVar.Parameter_Type[3] = 1;
//			ClassLib.ComVar.Parameter_Type[4] = 9; 
//
//			ClassLib.ComVar.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[2] = cmb_FromNo.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[3] = cmb_ToNo.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[4] = ""; 
//
//			dt_list = ClassLib.ComVar.WebService.Oracle_Select_Procedure(ClassLib.ComVar.Process_Name, ClassLib.ComVar.Parameter_Name, ClassLib.ComVar.Parameter_Type, ClassLib.ComVar.Parameter_Values).Tables[0];
// 
//			 
//			return dt_list; 


			string Proc_Name = "PKG_SPO_ORDER_BSC.SELECT_MODEL_CMBLIST";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM_DATE";
			oraDB.Parameter_Name[2] = "ARG_TO_DATE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_FromNo.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = cmb_ToNo.SelectedValue.ToString();
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}




		/// <summary>
		/// Select_Style_Size : 
		/// </summary>
		private void Select_Style_Size()
		{
			DataTable dt_list;
			
			string before_item = "", now_item = "";
 
			int gen_row = 0; 
			string sel_gen = "";
		 
		 
//			ClassLib.ComVar.ReDim_Parameter(6); 
//
//			ClassLib.ComVar.Process_Name = "PKG_SPO_ORDER_MOLD.SELECT_STYLE_SIZE";
//
//			ClassLib.ComVar.Parameter_Name[1] = "ARG_FACTORY";
//			ClassLib.ComVar.Parameter_Name[2] = "ARG_FROM_DATE"; 
//			ClassLib.ComVar.Parameter_Name[3] = "ARG_TO_DATE"; 
//			ClassLib.ComVar.Parameter_Name[4] = "ARG_MODEL_CD";
//			ClassLib.ComVar.Parameter_Name[5] = "ARG_MODEL_GEN"; 
//			ClassLib.ComVar.Parameter_Name[6] = "OUT_CURSOR"; 
//
//			ClassLib.ComVar.Parameter_Type[1] = 1;
//			ClassLib.ComVar.Parameter_Type[2] = 1; 
//			ClassLib.ComVar.Parameter_Type[3] = 1;
//			ClassLib.ComVar.Parameter_Type[4] = 1;
//			ClassLib.ComVar.Parameter_Type[5] = 1;
//			ClassLib.ComVar.Parameter_Type[6] = 9; 
//
//			ClassLib.ComVar.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[2] = cmb_FromNo.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[3] = cmb_ToNo.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[4] = cmb_Model.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[5] = cmb_gen.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[6] = ""; 
//
//			dt_list = ClassLib.ComVar.WebService.Oracle_Select_Procedure(ClassLib.ComVar.Process_Name, ClassLib.ComVar.Parameter_Name, ClassLib.ComVar.Parameter_Type, ClassLib.ComVar.Parameter_Values).Tables[0];
 


			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_STYLE_SIZE";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM_DATE"; 
			oraDB.Parameter_Name[2] = "ARG_TO_DATE"; 
			oraDB.Parameter_Name[3] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[4] = "ARG_MODEL_GEN"; 
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_FromNo.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = cmb_ToNo.SelectedValue.ToString();
			oraDB.Parameter_Values[3] = cmb_Model.SelectedValue.ToString();
			oraDB.Parameter_Values[4] = cmb_gen.SelectedValue.ToString();
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();
			
			dt_list = DS_Ret.Tables[Proc_Name];





			//---------------------------------------------------

			fgrid_Style.Rows.Count = fgrid_Style.Rows.Fixed;



			if(dt_list.Rows.Count > 0)
			{
				for(int k=_Ix_Gen_S; k<_Ix_Gen_E; k++)
				{
					fgrid_Style.Rows[k].Visible = false;
				}
			}
  
			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
     
				 
				now_item = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxREQ_NO - 1].ToString()
					+ dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxSTYLE_CD - 1].ToString()
					+ dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxGEN - 1].ToString();


				if(before_item != now_item)
				{
					fgrid_Style.Rows.Add();
					fgrid_Style[fgrid_Style.Rows.Count - 1, 0] = dt_list.Rows[i].ItemArray[0].ToString();
					fgrid_Style[fgrid_Style.Rows.Count - 1, 1] = dt_list.Rows[i].ItemArray[1].ToString();
					fgrid_Style[fgrid_Style.Rows.Count - 1, 2] = dt_list.Rows[i].ItemArray[2].ToString();
					fgrid_Style[fgrid_Style.Rows.Count - 1, 4] = dt_list.Rows[i].ItemArray[3].ToString();


					before_item = now_item;

					for(int j = 1; j <= fgrid_Style.Rows.Fixed; j++)
					{
						if(fgrid_Style[j, _IxGen_Value].ToString() == dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_Style[gen_row, _IxGen_Value].ToString();

							for(int k=_Ix_Gen_S; k<_Ix_Gen_E; k++)
							{
								if(fgrid_Style[k, 4].ToString() == fgrid_Style[gen_row, _IxGen_Value].ToString())
								{
									fgrid_Style.Rows[k].Visible = true;
								}
							}

							break;
						} 
					}
				}
 

				// 사이즈별 합계
				for(int j = _IxStart_Size; j < fgrid_Style.Cols.Count; j++)
				{
					if(fgrid_Style[gen_row, j].ToString() == dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxCS_SIZE - 1].ToString())
					{
						if(fgrid_Style[fgrid_Style.Rows.Count - 1, j] !=  null)
						{
							fgrid_Style[fgrid_Style.Rows.Count - 1, j] = fgrid_Style[fgrid_Style.Rows.Count - 1, j].ToString() + dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxORD_QTY - 1].ToString();
						}
						else
						{
							fgrid_Style[fgrid_Style.Rows.Count - 1, j] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_STYLE_SIZE.IxORD_QTY - 1].ToString();
						}
						break; 
						
					} 
				}
			} 


			
  
			Set_SubTotals(fgrid_Style, _IxStart_Size, fgrid_Style.Cols.Count); 




			


		//	fgrid_Style.Rows[fgrid_Style.Rows.Fixed - 1].Height = 18;
		//	pnl_Top.Size = new Size(pnl_Top.Width, (fgrid_Style.Rows.Count - 3) * fgrid_Style.Rows[fgrid_Style.Rows.Fixed - 1].Height);

			

  
		}


		private string Low_qty(int arg_colnum)
		{
			bool first_input = true;
			int low_qty=0;

			for(int i=5+7; i<fgrid_Mold.Rows.Count-2; i=i+9)
			{
				if(fgrid_Mold[i,arg_colnum]!=null)
				{
					if(first_input)
					{
						low_qty = int.Parse(fgrid_Mold[i,arg_colnum].ToString());
						first_input = false;
					}


					if(low_qty > int.Parse(fgrid_Mold[i,arg_colnum].ToString()))
					{
						low_qty = int.Parse(fgrid_Mold[i,arg_colnum].ToString());
					}
				}
			}

			return low_qty.ToString();
		}



		/// <summary>
		/// Select_Mold_Size : 
		/// </summary>
		private void Select_Mold_Size()
		{
			DataTable dt_list;
			string fromdate, todate;
 
			string before_item = "", now_item = "";
 
			int gen_row = 0; 
			string sel_gen = "";
			int sum_row = 0;

			CellStyle cellst; 
			Font font;


			fromdate = ClassLib.ComFunction.Empty_Combo(cmb_FromNo, " ");
			todate = ClassLib.ComFunction.Empty_Combo(cmb_ToNo, " "); 
		 
		 
//			ClassLib.ComVar.ReDim_Parameter(3); 
//
//			ClassLib.ComVar.Process_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE_TEST";
//
//			ClassLib.ComVar.Parameter_Name[1] = "ARG_FACTORY";
//			ClassLib.ComVar.Parameter_Name[2] = "ARG_MODEL_CD"; 
//			ClassLib.ComVar.Parameter_Name[3] = "OUT_CURSOR"; 
//
//			ClassLib.ComVar.Parameter_Type[1] = 1;
//			ClassLib.ComVar.Parameter_Type[2] = 1;  
//			ClassLib.ComVar.Parameter_Type[3] = 9; 
//
//			ClassLib.ComVar.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[2] = cmb_Model.SelectedValue.ToString();
//			ClassLib.ComVar.Parameter_Values[3] = ""; 
//
//			
//			
//			
//			dt_list = ClassLib.ComVar.WebService.Oracle_Select_Procedure(ClassLib.ComVar.Process_Name, ClassLib.ComVar.Parameter_Name, ClassLib.ComVar.Parameter_Type, ClassLib.ComVar.Parameter_Values).Tables[0];
 





			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE_TEST";

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
			
			dt_list = DS_Ret.Tables[Proc_Name];

			//--------------------------------------------------- 
			font = new System.Drawing.Font("Verdana", 9, FontStyle.Bold);
			cellst = fgrid_Mold.Styles.Add("BOLD");
			cellst.Font = font;
			//---------------------------------------------------  
			 
			fgrid_Mold.Rows.Count = fgrid_Style.Rows.Fixed;

			int sum_qty = 0;
			string one_pair = "1";
  
			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
     
				 
				now_item = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxDATA - 1].ToString()
					+ dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxGEN - 1].ToString();


				if(before_item != now_item)
				{
					sum_row = 0;
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();


					for(int k=4; k<fgrid_Mold.Cols.Count; k++)
					{
						fgrid_Mold[fgrid_Mold.Rows.Count - 5, k] = "";
					}

								
					  
					
					fgrid_Mold[fgrid_Mold.Rows.Count - 9, 0] = "";
					fgrid_Mold[fgrid_Mold.Rows.Count - 8, 0] = "E";
					fgrid_Mold[fgrid_Mold.Rows.Count - 7, 0] = "";
					fgrid_Mold[fgrid_Mold.Rows.Count - 6, 0] = "";
					fgrid_Mold[fgrid_Mold.Rows.Count - 5, 0] = "";
					fgrid_Mold[fgrid_Mold.Rows.Count - 4, 0] = "C";
					fgrid_Mold[fgrid_Mold.Rows.Count - 3, 0] = "";
					fgrid_Mold[fgrid_Mold.Rows.Count - 2, 0] = "";
					fgrid_Mold[fgrid_Mold.Rows.Count - 1, 0] = "";
					
					
					for(int j = 1; j <= (int)ClassLib.TBSPO_MOLD_SIZE.IxGEN; j++)
					{
						fgrid_Mold[fgrid_Mold.Rows.Count - 9, j] = dt_list.Rows[i].ItemArray[j].ToString();
					} 


					fgrid_Mold[fgrid_Mold.Rows.Count - 8, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "MOLD +/-";
					fgrid_Mold[fgrid_Mold.Rows.Count - 7, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "MOLD/SIZE";
					fgrid_Mold[fgrid_Mold.Rows.Count - 6, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "PAIRS in MOLD";
					fgrid_Mold[fgrid_Mold.Rows.Count - 5, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "PAIRS/PRESS";
					fgrid_Mold[fgrid_Mold.Rows.Count - 4, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "Cycle";
					fgrid_Mold[fgrid_Mold.Rows.Count - 3, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "TOTAL QTY";
					fgrid_Mold[fgrid_Mold.Rows.Count - 2, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "Prod. Days";


					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 8].StyleNew.BackColor = Color.Lavender;
					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 8].StyleNew.ForeColor = Color.Blue;


					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 4].StyleNew.BackColor = Color.Lavender;
					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 4].StyleNew.ForeColor = Color.Blue;


					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 2].Style = fgrid_Mold.Styles["BOLD"];
					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 2].StyleNew.BackColor = Color.Lavender;
					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 2].StyleNew.ForeColor = Color.Blue;

					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 1].StyleNew.BackColor = Color.Black;
					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 1].StyleNew.ForeColor = Color.Black;
					fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 1].Height = 3;




					before_item = now_item;

					for(int j = 1; j <= fgrid_Mold.Rows.Fixed; j++)
					{
						if(fgrid_Mold[j, _IxGen_Value].ToString() == dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_Mold[gen_row, _IxGen_Value].ToString();
							break;
						} 
					}

				}
 

				//--------------------------------------------------------------
				
				

				

				for(int j = _IxStart_Size; j < _IxTotal; j++)
				{
					if(fgrid_Mold[gen_row, j].ToString() == dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxCS_SIZE - 1].ToString())
					{
						
						
						if(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxMSIZE].ToString() == "Y")   //혼족 여부
						{

							string cs_size = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxCS_SIZE-1].ToString();
							string fst_size =  dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IXFSTSIZE].ToString();


							//대표 사이즈 찾기
							if(cs_size == fst_size)
							{
								fgrid_Mold[fgrid_Mold.Rows.Count - 9, j] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxORD_QTY - 1].ToString();
								fgrid_Mold[fgrid_Mold.Rows.Count - 8, j] = "0";
								sum_qty = int.Parse(fgrid_Mold[fgrid_Mold.Rows.Count - 9, j].ToString());
								sum_row = sum_row + int.Parse(fgrid_Mold[fgrid_Mold.Rows.Count - 9, j].ToString());
								
							}
							else
							{
								fgrid_Mold[fgrid_Mold.Rows.Count - 9, j] = "M("+ dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IXFSTSIZE].ToString()+")";
							}




							
							int size_order_qty = int.Parse(fgrid_Style[fgrid_Style.Rows.Count-1, j].ToString());


							//사이즈 별 주문 량
//							if(size_order_qty == 0)
//							{
//								fgrid_Mold[fgrid_Mold.Rows.Count - 7, j] = "0.00";
//							}
//							else
//							{
//								string arg_mold_cd = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxDATA-1].ToString();
//								string arg_fst_size = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IXFSTSIZE].ToString();
//								decimal rate = (size_order_qty/decimal.Parse(Msize_Y(arg_mold_cd, arg_fst_size).ToString())) * sum_qty;
//								fgrid_Mold[fgrid_Mold.Rows.Count - 7, j] = Math.Round(rate,2).ToString();
//							}



							fgrid_Mold[fgrid_Mold.Rows.Count - 6, j] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxPRS - 1].ToString();


							decimal Mrate = decimal.Parse(fgrid_Mold[fgrid_Mold.Rows.Count - 7, j].ToString());
							int pairs	 = int.Parse(fgrid_Mold[fgrid_Mold.Rows.Count - 6, j].ToString());

							fgrid_Mold[fgrid_Mold.Rows.Count - 5, j] = Math.Round(Mrate*pairs,2).ToString();


							


						}
						else
						{
							fgrid_Mold[fgrid_Mold.Rows.Count - 9, j] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxORD_QTY - 1].ToString();
							fgrid_Mold[fgrid_Mold.Rows.Count - 7, j] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxORD_QTY - 1].ToString() + ".00";							
							fgrid_Mold[fgrid_Mold.Rows.Count - 6, j] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxPRS - 1].ToString();
							fgrid_Mold[fgrid_Mold.Rows.Count - 5, j] = dt_list.Rows[i].ItemArray[11].ToString(); 
							fgrid_Mold[fgrid_Mold.Rows.Count - 8, j] = "0";
							fgrid_Mold[fgrid_Mold.Rows.Count - 7, 0] = "H";


							sum_row = sum_row + int.Parse(fgrid_Mold[fgrid_Mold.Rows.Count - 9, j].ToString());
						}
						
						
						
						if(one_pair != fgrid_Mold[fgrid_Mold.Rows.Count - 6,j].ToString())
						{
							one_pair = fgrid_Mold[fgrid_Mold.Rows.Count - 6,j].ToString();
						}
						break; 
					} 

				}
 
				

				fgrid_Mold[fgrid_Mold.Rows.Count - 9, _IxTotal] = Convert.ToString(sum_row);
				fgrid_Mold[fgrid_Mold.Rows.Count - 8, _IxTotal] = "0";
				
				if(one_pair == "1")
				{
					fgrid_Mold[fgrid_Mold.Rows.Count - 6, 0] = "H";
					fgrid_Mold[fgrid_Mold.Rows.Count - 5, 0] = "H";
				}
			}

		 

			//그리드 하단 최종 정보
			fgrid_Mold.Rows.Add();
			fgrid_Mold.Rows.Add();

			fgrid_Mold[fgrid_Mold.Rows.Count - 2,0] = "";
			fgrid_Mold[fgrid_Mold.Rows.Count - 1,0] = "";

			fgrid_Mold[fgrid_Mold.Rows.Count - 2, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "Plan/Day"; 
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 2].StyleNew.ForeColor = Color.Red;
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 2].StyleNew.BackColor = Color.LightSteelBlue;

			fgrid_Mold[fgrid_Mold.Rows.Count - 1, (int)ClassLib.TBSPO_MOLD_SIZE.IxMOLD_CAPA] = "Prod. of Days";
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 1].Style = fgrid_Mold.Styles["BOLD"];
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 1].StyleNew.ForeColor = Color.Blue; 
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count - 1].StyleNew.BackColor = Color.LightSteelBlue;

			
			//------------------------------------------------------------------//

			for(int i = 0; i < fgrid_Mold.Cols.Count; i++)
			{
				if(i == 2)
					fgrid_Mold.Cols[i].AllowEditing = true;
				else
					fgrid_Mold.Cols[i].AllowEditing = false;


			} 


			for(int i = fgrid_Mold.Rows.Fixed; i < fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i, 0].ToString() == "C")
				{
					fgrid_Mold.Rows[i].AllowEditing = true;
				}
				else if(fgrid_Mold[i, 0].ToString() == "E")
				{
					for(int j=_IxStart_Size; j<_IxTotal-1; j++)
					{
						fgrid_Mold.Cols[j].AllowEditing = true;
					}
				}
				else
				{
					fgrid_Mold.Rows[i].AllowEditing = false;
				}
				   
			}  

			//------------------------------------------------------------------//

		}



		
		/// <summary>
		/// Set_SubTotals : 
		/// </summary>
		private void Set_SubTotals(C1FlexGrid arg_grid, int arg_startsize, int arg_total)
		{
			int sum_row = 0;

			arg_grid.Subtotal(AggregateEnum.Clear); 
			arg_grid.SubtotalPosition = SubtotalPositionEnum.BelowData;
			
			for(int i = arg_startsize; i < arg_total; i++)
			{
				arg_grid.Subtotal(AggregateEnum.Sum, 0 , 0, i, "");
			}
 

			for(int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
			{
				for(int j = arg_startsize; j < arg_total; j++)
				{
					if(arg_grid[i, j] == null) continue;    //.ToString() == "") continue;
					sum_row = sum_row + Convert.ToInt32(arg_grid[i, j].ToString()); 
				}  

				arg_grid[i, 3/*arg_total*/] = Convert.ToString(sum_row);
				sum_row = 0;
			}
 
			//arg_grid.AutoSizeCols(arg_startsize, arg_total-1, 0);
			//arg_grid.AutoSizeCols();


		}

		

 
		/// <summary>
		/// Set_Change_Capa : 
		/// </summary>
		private void Set_Change_Capacity()
		{


			_lx_Size_E = fgrid_Mold.Cols.Count-1;


			



			int select_row = fgrid_Mold.Selection.r1;
			int select_col = fgrid_Mold.Selection.c1;


			//MessageBox.Show(fgrid_Mold[select_row,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION].ToString());

			if(fgrid_Mold[select_row, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION].ToString() == "A" && select_col == (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD)
			{
				fgrid_Mold[select_row, select_col] = "";
					return;
			}

			
			string day_div;


			

			

			if(select_col >= _lx_Size_S && select_col < _lx_Size_E)
			{
				int mold_qty   = select_row-1;
				int pairs      = select_row+1;
				int onpress    = select_row+2;
				int mold_cycle = select_row+3;
				int day_capa   = select_row+4;
				int ord_qty    = select_row+5;
				int day_count  = select_row+6;
				int line       = select_row+7;
				int daily_plan = select_row+8;
				int plan_count = select_row+9;
				
				

				if(fgrid_Mold[mold_qty, select_col] == null)
				{
					fgrid_Mold[mold_qty, select_col]   = "0";
					fgrid_Mold[pairs, select_col]      = "0";
					fgrid_Mold[onpress, select_col]    = "0";
					fgrid_Mold[mold_cycle, select_col] = "0";
					fgrid_Mold[day_capa, select_col]   = "0";
					fgrid_Mold[ord_qty, select_col]    = "0";
					fgrid_Mold[day_count, select_col]  = "0";
				}

				try
				{
					fgrid_Mold[day_capa, select_col] = Math.Round((int.Parse(fgrid_Mold[select_row, select_col].ToString()) + 
						int.Parse(fgrid_Mold[mold_qty, select_col].ToString())) * 
						decimal.Parse(fgrid_Mold[pairs, select_col].ToString()) * 
						int.Parse(fgrid_Mold[mold_cycle, select_col].ToString()),0).ToString();
				}
				catch
				{
					ClassLib.ComFunction.User_Message("You can not edit only one size mold cycle!");
				}



				try
				{
					day_div = (Math.Round((decimal.Parse(fgrid_Mold[ord_qty, select_col].ToString())/decimal.Parse(fgrid_Mold[day_capa, select_col].ToString())),0)).ToString();
					string day_decimal = (Math.Round((decimal.Parse(fgrid_Mold[ord_qty, select_col].ToString())/decimal.Parse(fgrid_Mold[day_capa, select_col].ToString())),4)).ToString();
								
					if(decimal.Parse(day_div) < decimal.Parse(day_decimal) )
					{
						day_div = (int.Parse(day_div) + 1).ToString();
					}
					
					fgrid_Mold[day_count,select_col] = day_div;
				}
				catch
				{
				}

				
			}
			//몰드 사이클 변경
			else if(select_col == (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD && fgrid_Mold[select_row,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION].ToString() == "S")
			{

				int mold_qty   = select_row-4;
				int mold_add   = select_row-3;
				int pairs      = select_row-2;
				int onpress    = select_row-1;
				int mold_cycle = select_row;
				int day_capa   = select_row+1;
				int ord_qty    = select_row+2;
				int day_count  = select_row+3;
				int line       = select_row+4;
				int daily_plan = select_row+5;
				int plan_count = select_row+6;


				string cycle = fgrid_Mold[select_row, select_col].ToString();

				for(int k=_lx_Size_S; k<_lx_Size_E; k++)
				{
					if(fgrid_Mold[select_row, k] != null)
					{
						fgrid_Mold[select_row, k] = cycle;

						int mold_sum = int.Parse(fgrid_Mold[mold_qty, k].ToString()) + int.Parse(fgrid_Mold[mold_add, k].ToString());


						fgrid_Mold[day_capa, k] = Math.Round((mold_sum * decimal.Parse(fgrid_Mold[pairs, k].ToString()) *  int.Parse(cycle)),2).ToString();



						try
						{
							day_div = (Math.Round((decimal.Parse(fgrid_Mold[ord_qty, k].ToString())/decimal.Parse(fgrid_Mold[day_capa, k].ToString())),0)).ToString();
							string day_decimal = (Math.Round((decimal.Parse(fgrid_Mold[ord_qty, k].ToString())/decimal.Parse(fgrid_Mold[day_capa, k].ToString())),4)).ToString();
								
							if(decimal.Parse(day_div) < decimal.Parse(day_decimal) )
							{
								day_div = (int.Parse(day_div) + 1).ToString();
							}
						}
						catch
						{
							day_div = "0";
						}

						fgrid_Mold[day_count,k] = day_div;

					}
				}

				txt_plancapa_TextChanged(null, null);
			}
			//하루 생산량 변경
			else if(select_col == (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD && fgrid_Mold[select_row,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION].ToString() == "P")
			{
				int mold_qty   = select_row-8;
				int pairs      = select_row-7;
				int onpress    = select_row-6;
				int mold_cycle = select_row-5;
				int day_capa   = select_row-4;
				int ord_qty    = select_row-3;
				int day_count  = select_row-2;
				int line       = select_row-1;
				int daily_plan = select_row;
				int plan_count = select_row+1;
				
				decimal order_qty = decimal.Parse(fgrid_Mold[ord_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_TOTAL].ToString());
				decimal line_capa = decimal.Parse(fgrid_Mold[select_row, select_col].ToString());
				string planday;
				try
				{
					planday = Math.Ceiling(double.Parse((order_qty/line_capa).ToString())).ToString();
				}
				catch
				{
					planday = "0";
				}



				fgrid_Mold[select_row, select_col+1] = planday; 

				decimal order_rate = Math.Round(line_capa/order_qty,10);

				for(int i=_lx_Size_S; i<_lx_Size_E; i++)
				{
					if(fgrid_Mold[ord_qty, i].ToString() != "0")
					{
						fgrid_Mold[daily_plan, i] = (Math.Round((int.Parse(fgrid_Mold[ord_qty, i].ToString())*order_rate),0)).ToString();
						try
						{
							System.Drawing.Color font_color = Color.Blue;
							fgrid_Mold[plan_count, i] = (int.Parse(fgrid_Mold[day_capa, i].ToString()) - int.Parse(fgrid_Mold[daily_plan, i].ToString())).ToString();


							if(int.Parse(fgrid_Mold[plan_count, i].ToString()) < 0)
							{
								font_color = Color.Red;
							}

							fgrid_Mold.GetCellRange(plan_count,i).StyleNew.ForeColor =  font_color;
						}
						catch
						{
						}
					}
				}

			}

 
		}


		private void total_grid_data(int arg_colnum, decimal arg_plan, decimal arg_prod)
		{
			
			int plan_day_row = fgrid_Mold.Rows.Count-2;
			int prod_day_row = fgrid_Mold.Rows.Count-1;
			
			decimal day_qty;
			decimal for_day;

			try
			{ 
				day_qty = decimal.Parse(fgrid_Mold[plan_day_row, arg_colnum].ToString());
			}
			catch
			{
				day_qty = arg_plan;
				fgrid_Mold[plan_day_row, arg_colnum] = arg_plan;
			}


			try
			{
				for_day = Decimal.Parse(fgrid_Mold[prod_day_row, arg_colnum].ToString());
			}
			catch
			{
				for_day = arg_prod;
				fgrid_Mold[prod_day_row, arg_colnum] = arg_prod;
			}

			if(day_qty > arg_plan)
			{
				fgrid_Mold[plan_day_row, arg_colnum] = arg_plan.ToString();
			}

			if(for_day < arg_prod)
			{
				fgrid_Mold[prod_day_row, arg_colnum] = arg_prod.ToString();
			}
		}


		private void total_grid_data_sum()
		{
			int plan_day_row = fgrid_Mold.Rows.Count-2;
			int prod_day_row = fgrid_Mold.Rows.Count-1;



			int total_qty = 0;
			decimal total_day = 0;

			for(int i=4; i<fgrid_Mold.Cols.Count-1; i++)
			{
				try
				{
					total_qty = total_qty + int.Parse(fgrid_Mold[plan_day_row, i].ToString());
					
					if(total_day < decimal.Parse(fgrid_Mold[prod_day_row, i].ToString()))
					{
						total_day = decimal.Parse(fgrid_Mold[prod_day_row, i].ToString());
					}
				}
				catch
				{
				}
			}

			fgrid_Mold[plan_day_row, fgrid_Mold.Cols.Count-1] = total_qty.ToString();
			fgrid_Mold[prod_day_row, fgrid_Mold.Cols.Count-1] = Math.Round(total_day,2).ToString();
		}



		private int Muse_Y_Sum_Qty(string arg_mold_cd, string arg_fst_size)
		{
			DataTable dt = Select_Fst_size(arg_mold_cd, arg_fst_size);
			string gen = dt.Rows[0].ItemArray[0].ToString();

			int gen_num;

			for(gen_num=1; gen_num<6; gen_num++)
			{
				if(fgrid_Mold[gen_num,3].ToString() == gen)
				{
					break;
				}
			}



			int sum_order =0;
			for(int i=0; i<dt.Rows.Count; i++)
			{
				string cs_size = dt.Rows[i].ItemArray[1].ToString();
				
				for(int j=4; j<fgrid_Style.Cols.Count; j++)
				{
					if(fgrid_Style[gen_num,j].ToString() == cs_size)
					{
						//MessageBox.Show(fgrid_Style[fgrid_Style.Rows.Count-1, j].ToString());
						sum_order = sum_order + int.Parse(fgrid_Style[fgrid_Style.Rows.Count-1, j].ToString());
					}
				}
			}

			return sum_order;
		}



		private void Mold_Info_Model()
		{
			fgrid_Mold.Rows.Count = _Ix_Gen_E;
			DataTable dt = Select_Mold_Info_Model();

			int rowCount = dt.Rows.Count;
			int colCount = dt.Columns.Count;

			string old_data = "";
			string new_data = "";


			for(int i=0; i<rowCount; i++)
			{
				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_TYPE].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CD].ToString();

				if(old_data != new_data)
				{
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();



					//추가 기능
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();

					int mold_qty = fgrid_Mold.Rows.Count-13;
					int mold_add = fgrid_Mold.Rows.Count-12;
					int inmold   = fgrid_Mold.Rows.Count-11;
					int onpress  = fgrid_Mold.Rows.Count-10;
					int cycle    = fgrid_Mold.Rows.Count-9;
					int day_capa = fgrid_Mold.Rows.Count-8;
					int ord_capa = fgrid_Mold.Rows.Count-7;
					int day_count= fgrid_Mold.Rows.Count-6;
					int line2    = fgrid_Mold.Rows.Count-5;
					int a        = fgrid_Mold.Rows.Count-4;
					int b        = fgrid_Mold.Rows.Count-3;
					int c        = fgrid_Mold.Rows.Count-2;
					int line     = fgrid_Mold.Rows.Count-1;


					fgrid_Mold[mold_qty,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_TYPE].ToString();
					fgrid_Mold[mold_qty,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CD].ToString()+ "[" +dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_SPEC_CD].ToString() + "]";
					fgrid_Mold[mold_qty,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_GEN] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_GEN].ToString();


					if(dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MUSE_YN].ToString() == "Y")
					{
						fgrid_Mold[mold_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = fgrid_Mold[mold_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD].ToString() + " [MUSE]";
					}


					fgrid_Mold[mold_add,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "MOLD +/-";
					fgrid_Mold.Rows[mold_add].Height = 0;
					fgrid_Mold[mold_add,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "A";
					fgrid_Mold[inmold, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "PRS/SET";
					fgrid_Mold[onpress, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "PAIRS/PRESS";
					fgrid_Mold.Rows[onpress].Height = 0;


					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "H";
					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Cycle";
					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CYCLE].ToString();

					fgrid_Mold[day_capa, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Mold Capacity";

					fgrid_Mold[ord_capa, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Order QTY";

					fgrid_Mold[day_count, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Working Days";

					fgrid_Mold[a,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "P";
					fgrid_Mold[a,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Daily Prod";
					fgrid_Mold[a,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = "0";

					fgrid_Mold[b,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Spare Capa";
					fgrid_Mold[c,(int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Short Mold";



					fgrid_Mold.Rows[mold_qty].StyleNew.BackColor =  Color.FromArgb(230, 230, 250);
					fgrid_Mold.Rows[mold_add].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					fgrid_Mold.Rows[cycle].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					fgrid_Mold.Rows[day_count].StyleNew.BackColor = Color.FromArgb(217, 250, 216);
					fgrid_Mold.Rows[a].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					fgrid_Mold.Rows[b].StyleNew.BackColor = Color.FromArgb(217, 250, 216);


					fgrid_Mold.Rows[line2].Height = 2;
					fgrid_Mold.Rows[line2].StyleNew.BackColor = Color.FromArgb(39, 132, 152);
					fgrid_Mold.Rows[line].Height = 4;
					fgrid_Mold.Rows[line].StyleNew.BackColor = Color.FromArgb(28, 31, 140);




					fgrid_Mold[mold_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";
					fgrid_Mold[day_capa, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";
					fgrid_Mold[ord_capa, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";
					fgrid_Mold[day_count, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";
					fgrid_Mold[a, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";
					fgrid_Mold[c, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";

					fgrid_Mold[inmold, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "S";
					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "S";
					fgrid_Mold[b, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "S";

//					fgrid_Mold[line2, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "L";
					fgrid_Mold[line, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "V";
					
					old_data = new_data;



					_lx_Size_E = fgrid_Style.Cols.Count-1;
					int order_total = 0;
					for(int k=_lx_Size_S; k<_lx_Size_E+1; k++)
					{
						fgrid_Mold[ord_capa, k] = fgrid_Style[fgrid_Style.Rows.Count-1, k].ToString();

						fgrid_Mold.GetCellRange(ord_capa, k).StyleNew.ForeColor = Color.Red;
						order_total += int.Parse(fgrid_Style[fgrid_Style.Rows.Count-1, k].ToString());

					}

					fgrid_Mold[ord_capa, 3] = order_total;


					Show_Mold_Gender(fgrid_Mold,dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_GEN].ToString());
				}



				string gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_GEN].ToString();
				string size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_SIZE].ToString();
				string sum_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_QTY].ToString();
				
				
				
				string in_mold  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_PAIRS].ToString();

				string muse_yn  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MUSE_YN].ToString();
				string on_press = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_AVAIL_ONPRESS].ToString();
				string mold_cycle = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CYCLE].ToString();
				string mold_day_capa = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_DAY_CAPA].ToString();
				

				string ord_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_ORD_QTY].ToString();

				string mold_cd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CD].ToString();
				string fst_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_FST_SIZE].ToString();
				string fst_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_FST_QTY].ToString();
				
				
				if(sum_qty.Trim().Length == 0) sum_qty = "0";
				if(mold_day_capa.Trim().Length == 0) mold_day_capa = "0";
				if(fst_qty.Trim().Length == 0) fst_qty = "0";


			
				
				Set_Grid_Mold_Info_Model(gen, size, sum_qty, in_mold, muse_yn, on_press, mold_cd, fst_size, mold_cycle, mold_day_capa, ord_qty, fst_qty);
			}
			

			Day_prod();




		}



		private void Show_Mold_Gender(C1FlexGrid arg_fgrid,  string gen)
		{
			int mgen;

			//헤드 부분 동일 gen만 보여줌
			for(mgen = _Ix_Gen_S; mgen<_Ix_Gen_E; mgen++)
			{
				if(gen == arg_fgrid[mgen, _lx_Size_S-1].ToString())
				{
					arg_fgrid.Rows[mgen].Visible = true;
				}
			}
		}

		private void Mold_Info_Style()
		{
			fgrid_Mold.Rows.Count = _Ix_Gen_E;
			DataTable dt = Select_Mold_Info();

			int rowCount = dt.Rows.Count;
			int colCount = dt.Columns.Count;

			string old_data = "";
			string new_data = "";


			for(int i=0; i<rowCount; i++)
			{
				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_TYPE].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CD].ToString();

				if(old_data != new_data)
				{
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();

					//추가기능
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();

					int mold_qty = fgrid_Mold.Rows.Count-11;
					int mold_add = fgrid_Mold.Rows.Count-10;
					int inmold   = fgrid_Mold.Rows.Count-9;
					int onpress  = fgrid_Mold.Rows.Count-8;
					int cycle    = fgrid_Mold.Rows.Count-7;
					int day_capa = fgrid_Mold.Rows.Count-6;
					int ord_capa = fgrid_Mold.Rows.Count-5;
					int day_count= fgrid_Mold.Rows.Count-4;
					int a        = fgrid_Mold.Rows.Count-3;
					int b        = fgrid_Mold.Rows.Count-2;
					int line     = fgrid_Mold.Rows.Count-1;


					fgrid_Mold[mold_qty,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_TYPE].ToString();
					fgrid_Mold[mold_qty,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CD].ToString();
					fgrid_Mold[mold_qty,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_GEN] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_GEN].ToString();

					if(dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MUSE_YN].ToString() == "Y")
					{
						fgrid_Mold[mold_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = fgrid_Mold[mold_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD].ToString() + " [MUSE]";
					}
					



					fgrid_Mold[mold_add,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "MOLD +/-";
					fgrid_Mold[mold_add,  (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "H";
					fgrid_Mold[inmold, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "PAIRS IN MOLD";
					fgrid_Mold[onpress, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "PAIRS/PRESS";


					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] = "H";
					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "CYCLE";


					

					fgrid_Mold[cycle, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CYCLE].ToString();

					

					fgrid_Mold[day_capa, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "DAY QTY";
					

					fgrid_Mold[ord_capa, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "ORDER QTY";

					fgrid_Mold[day_count, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Prod. Days";




					fgrid_Mold.Rows[mold_qty].StyleNew.BackColor =  Color.FromArgb(230, 230, 250);
					fgrid_Mold.Rows[mold_add].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					fgrid_Mold.Rows[cycle].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					fgrid_Mold.Rows[day_count].StyleNew.BackColor = Color.FromArgb(217, 250, 216);

					fgrid_Mold.Rows[line].Height = 3;
					fgrid_Mold.Rows[line].StyleNew.BackColor = Color.FromArgb(194, 194, 194);
					
					old_data = new_data;
				}



				string gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_GEN].ToString();
				string size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_SIZE].ToString();
				string sum_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_QTY].ToString();
				string in_mold  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_PAIRS].ToString();

				string muse_yn  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MUSE_YN].ToString();
				string on_press = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_AVAIL_ONPRESS].ToString();
				string mold_cycle = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CYCLE].ToString();
				string mold_day_capa = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_DAY_CAPA].ToString();
				string ord_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_ORD_QTY].ToString();

				string mold_cd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_MOLD_CD].ToString();
				string fst_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_FST_SIZE].ToString();
				string fst_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MOLD_SIZE.IxSTY_FST_QTY].ToString();


				if(sum_qty.Trim().Length == 0) sum_qty = "0";
				if(mold_day_capa.Trim().Length == 0) mold_day_capa = "0";
				if(fst_qty.Trim().Length == 0) fst_qty = "0";
				
				Set_Grid_Mold_Info(gen, size, sum_qty, in_mold, muse_yn, on_press, mold_cd, fst_size, mold_cycle, mold_day_capa, ord_qty, fst_qty);
			}
		}



		private void Set_Grid_Mold_Info(string arg_gen, string arg_size, string arg_mold_qty, 
			string arg_inmold, string arg_muse_yn, string arg_onpress, string arg_mold_cd, string arg_fst_size, string arg_cycle, string arg_day_capa, string arg_ord_qty, string arg_fst_qty)
		{
			_lx_Size_E = fgrid_Mold.Cols.Count-2;



			int mold_qty = fgrid_Mold.Rows.Count-9;
			int mold_add = fgrid_Mold.Rows.Count-8;
			int inmold   = fgrid_Mold.Rows.Count-7;
			int onpress  = fgrid_Mold.Rows.Count-6;
			int cycle    = fgrid_Mold.Rows.Count-5;
			int day_capa = fgrid_Mold.Rows.Count-4;
			int ord_capa = fgrid_Mold.Rows.Count-3;
			int day_count= fgrid_Mold.Rows.Count-2;
			int line     = fgrid_Mold.Rows.Count-1;


			string day_div;


			int i;
			for(i=1; i<_Ix_Gen_E; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_GEN].ToString()  == arg_gen)
				{
					for(int j=_lx_Size_S; j<_lx_Size_E; j++)
					{
						if(fgrid_Mold[i,j].ToString() == arg_size)
						{
							fgrid_Mold[mold_qty,j] = arg_fst_qty;//arg_mold_qty;
							fgrid_Mold[mold_add,j] = "0";
							fgrid_Mold[inmold,  j] = arg_inmold;
							fgrid_Mold[day_capa, j] = arg_day_capa;




							if(arg_muse_yn != "Y")
							{
								fgrid_Mold[onpress, j] = arg_onpress;
							}
							else
							{
								decimal on_press = Math.Round(((decimal.Parse(arg_ord_qty)/Select_Fst_size_Ord(arg_mold_cd, arg_fst_size))*decimal.Parse(arg_inmold)),2);
								fgrid_Mold[onpress, j] = on_press.ToString();
								fgrid_Mold[day_capa,j] = Math.Round((int.Parse(arg_fst_qty) * on_press * int.Parse(arg_cycle)),0).ToString();
							}
							
							
							
							
							fgrid_Mold[cycle,   j] = arg_cycle;
							
							fgrid_Mold[ord_capa,j] = arg_ord_qty;

							try
							{
								day_div = (Math.Round((decimal.Parse(arg_ord_qty)/decimal.Parse(fgrid_Mold[day_capa, j].ToString())),0)).ToString();
								string day_decimal = (Math.Round((decimal.Parse(arg_ord_qty)/decimal.Parse(fgrid_Mold[day_capa, j].ToString())),4)).ToString();
								
								if(decimal.Parse(day_div) < decimal.Parse(day_decimal) )
								{
									day_div = (int.Parse(day_div) + 1).ToString();
								}
							}
							catch
							{
								day_div = "0";
							}

							fgrid_Mold[day_count,j] = day_div;
							break;
						}
					}
				}
			}
		}



		private void Set_Grid_Mold_Info_Model(string arg_gen, string arg_size, string arg_mold_qty, 
			string arg_inmold, string arg_muse_yn, string arg_onpress, string arg_mold_cd, string arg_fst_size, string arg_cycle, string arg_day_capa, string arg_ord_qty, string arg_fst_qty)
		{
			_lx_Size_E = fgrid_Mold.Cols.Count-2;


			int order_qty_row = fgrid_Style.Rows.Count-1; 


			int mold_qty = fgrid_Mold.Rows.Count-13;
			int mold_add = fgrid_Mold.Rows.Count-12;
			int inmold   = fgrid_Mold.Rows.Count-11;
			int onpress  = fgrid_Mold.Rows.Count-10;
			int cycle    = fgrid_Mold.Rows.Count-9;
			int day_capa = fgrid_Mold.Rows.Count-8;
			int ord_capa = fgrid_Mold.Rows.Count-7;
			int day_count= fgrid_Mold.Rows.Count-6;
			int line2    = fgrid_Mold.Rows.Count-5;
			int a        = fgrid_Mold.Rows.Count-4;
			int b        = fgrid_Mold.Rows.Count-3;
			int c        = fgrid_Mold.Rows.Count-2;
			int line     = fgrid_Mold.Rows.Count-1;


			string day_div;


			int i;
			for(i=1; i<_Ix_Gen_E; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_GEN].ToString()  == arg_gen)
				{
					for(int j=_lx_Size_S; j<_lx_Size_E; j++)
					{
						if(fgrid_Mold[i,j].ToString() == arg_size)
						{
							arg_ord_qty = fgrid_Style[order_qty_row, j].ToString();
							if(fgrid_Style[order_qty_row, j].ToString() != "0")
							{
								fgrid_Mold[mold_qty,j] = arg_mold_qty;
								fgrid_Mold[mold_add,j] = "0";
								fgrid_Mold[inmold,  j] = arg_inmold;
								fgrid_Mold[day_capa, j] = arg_day_capa;




								fgrid_Mold[day_capa,j] = ((int.Parse(arg_mold_qty) * (int.Parse(arg_inmold)) * int.Parse(arg_cycle))).ToString();

							
							
							
							
								fgrid_Mold[cycle,   j] = arg_cycle;
							

								
								fgrid_Mold[ord_capa,j] = arg_ord_qty;
								fgrid_Mold.GetCellRange(ord_capa, j).StyleNew.ForeColor = Color.Black;

								try
								{
									day_div = (Math.Round((decimal.Parse(arg_ord_qty)/decimal.Parse(fgrid_Mold[day_capa, j].ToString())),0)).ToString();
									string day_decimal = (Math.Round((decimal.Parse(arg_ord_qty)/decimal.Parse(fgrid_Mold[day_capa, j].ToString())),4)).ToString();
								
									if(decimal.Parse(day_div) < decimal.Parse(day_decimal) )
									{
										day_div = (int.Parse(day_div) + 1).ToString();
									}
								}
								catch
								{
									day_div = "0";
								}

								fgrid_Mold[day_count,j] = day_div;
								
								fgrid_Mold[a, j] = "0";
								fgrid_Mold[b, j] = "0";
								//fgrid_Mold[c, j] = (int.Parse(arg_inmold) * int.Parse(arg_cycle)).ToString();
								
								break;


								
							}
						}
					}
				}
			}
		}



		private void Day_prod()
		{

			//_lx_Size_E = fgrid_Mold.Cols.Count-1;
			int prod_day;
			for(int l=_Ix_Gen_E+7; l<fgrid_Mold.Rows.Count; l+= 13)
			{
				prod_day = 0;
				for(int n=_lx_Size_S; n<_lx_Size_E; n++)
				{
					if(fgrid_Mold[l,n] != null)
					{
						if(prod_day < int.Parse(fgrid_Mold[l,n].ToString()))
						{
							prod_day = int.Parse(fgrid_Mold[l,n].ToString());
						}
					}
				}
				fgrid_Mold[l,3] = prod_day.ToString();
			}
		}




		private void Mold_Info_Result()
		{
			_lx_Size_E = fgrid_Mold.Cols.Count-1;

			if(fgrid_Mold[fgrid_Mold.Rows.Count-1, 0].ToString() != "R")
			{

				//fgrid_Mold.Rows.Add();
				fgrid_Mold.Rows.Add();

				fgrid_Mold[fgrid_Mold.Rows.Count-1, 0] = "R";
				fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_MODEL_CD] = "Prod. Days(Max)";
				fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(230, 230, 250);
			}


			int prod_days = fgrid_Mold.Rows.Count-1;
			int limit_day;
			int total_day = 0;

			for(int i=_lx_Size_S; i<_lx_Size_E; i++)
			{
				limit_day = 0;

				for(int j=_Ix_Gen_E+7; j<fgrid_Mold.Rows.Count; j+=13)
				{
					if(fgrid_Mold[j,i] != null)
					{
						if(fgrid_Mold[j,i].ToString() != "0")
						{
							if(limit_day < int.Parse(fgrid_Mold[j,i].ToString()))
							{
								limit_day = int.Parse(fgrid_Mold[j,i].ToString());
							}

							if(total_day < limit_day)
							{
								total_day = limit_day;
							}
						}
					}
				}
				fgrid_Mold[prod_days,i] = limit_day.ToString();
			}

			fgrid_Mold[fgrid_Mold.Rows.Count-1,3] = total_day.ToString();
			fgrid_Mold.Rows[prod_days].AllowEditing = false;



			Show_Mold_Info(show_check);

		}



		private string Height_prod(int arg_colnum)
		{
			bool first_input = true;
			decimal height_prod=0;

			for(int i=5+8; i<fgrid_Mold.Rows.Count-1; i=i+9)
			{
				if(fgrid_Mold[i,arg_colnum]!=null)
				{
					if(first_input)
					{
						height_prod = decimal.Parse(fgrid_Mold[i,arg_colnum].ToString());
						first_input = false;
					}


					if(height_prod < decimal.Parse(fgrid_Mold[i,arg_colnum].ToString()))
					{
						height_prod = decimal.Parse(fgrid_Mold[i,arg_colnum].ToString());
					}
				}
			}

			return height_prod.ToString();
		}


		private void Show_Row()
		{
			if(!show_row)
			{
				for(int i=7; i<fgrid_Mold.Rows.Count; i++)
				{
					if(fgrid_Mold[i,0].ToString() == "H" || fgrid_Mold[i,0].ToString() == "E")
						if(fgrid_Mold[i,0] != null)
						{
							fgrid_Mold.Rows[i].Visible = false;
						}
				}

				show_row = true;
			}
			else
			{
				for(int i=7; i<fgrid_Mold.Rows.Count; i++)
				{
					if(!fgrid_Mold.Rows[i].Visible)
					{
						fgrid_Mold.Rows[i].Visible = true;
					}
				}

				show_row = false;
			}
		}









		public void Set_Grid_Data()
		{
			if(cmb_Factory.SelectedIndex == -1 
				|| cmb_FromNo.SelectedIndex == -1 
				|| cmb_Model.SelectedIndex == -1) return;

			_BeforeSelCol = -1;

			fgrid_Mold.Focus();

			Select_Style_Size();

			fgrid_Mold.Rows.Count = _Ix_Gen_E;

			if(fgrid_Style.Rows.Count <= _Ix_Gen_E) return;


			//fgrid_Mold 헤드 부분 초기화
			for(int mgen=_Ix_Gen_S; mgen<_Ix_Gen_E; mgen++)
			{
				fgrid_Mold.Rows[mgen].Visible = false;
			}

			Mold_Info_Model();

			Mold_Info_Result();


			for(int i=_lx_Size_S; i<fgrid_Style.Cols.Count; i++)
			{
				fgrid_Mold.Cols[i].Visible = true;
				fgrid_Style.Cols[i].Visible = true;
			}


			for(int i=_lx_Size_S; i<fgrid_Style.Cols.Count; i++)
			{
				if(fgrid_Style[fgrid_Style.Rows.Count-1, i].ToString() == "0")
				{
					fgrid_Mold.Cols[i].Visible = false;
					fgrid_Style.Cols[i].Visible = false;
				}
				else
				{
					break;
				}
			}

			ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);	
		}

		private DataTable Select_Test()
		{
			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_TEST";

			oraDB.ReDim_Parameter(1);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "OUT_CURSOR";
			oraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			oraDB.Parameter_Values[0] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}





		#endregion

		#region 이벤트 처리


		private void Form_PO_MoldCapa_Load(object sender, System.EventArgs e)
		{ 
			Init_Form();
		}


		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return;

			DataTable dt_list = Select_ReqNo_CmbList(cmb_Factory.SelectedValue.ToString()); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_FromNo, 0, 0, false);
			cmb_FromNo.Splits[0].DisplayColumns[1].Visible = false; 
			cmb_FromNo.SelectedIndex = 0;

			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_ToNo, 0, 0, false);
			cmb_ToNo.Splits[0].DisplayColumns[1].Visible = false;  
			cmb_ToNo.SelectedIndex = 0;
  
		}


		private void cmb_ToNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_ToNo.SelectedIndex == -1) return;

			DataTable dt_list;

			
			dt_list = Select_Model_CmbList();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Model, 0, 1);

			cmb_gen.SelectedIndex = -1;


		}

		 
	  

		private void fgrid_Style_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			//check, uncheck 정렬 -> 실제 capa 분석시에는 check된 스타일에 대해서만 적용
			fgrid_Style.Sort(new MyComparer(fgrid_Style));
 
			Set_SubTotals(fgrid_Style, _IxStart_Size, _IxTotal);

			Mold_Info_Model();

			Mold_Info_Result();

		}

 

		private void fgrid_Mold_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			bool digit_flag;

			digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Mold[e.Row, e.Col].ToString());

			if(digit_flag == false) 
			{
				fgrid_Mold[e.Row, e.Col] = "";
				return;
			}

			Set_Change_Capacity(); 
			Mold_Info_Result();


			Day_prod();
  
		}
 

		private void fgrid_Style_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			fgrid_Mold.Cols[e.Col].Width = fgrid_Style.Cols[e.Col].Width;

		}

	 


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Style.Rows.Count = fgrid_Style.Rows.Fixed;
			fgrid_Mold.Rows.Count = fgrid_Mold.Rows.Fixed;

		}



		private void btn_showrow_Click(object sender, System.EventArgs e)
		{
			Show_Row();
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			txt_plancapa.Text ="";
			Set_Grid_Data();
		}


		private void Order_Qty_Total(string arg_gen, int cs_size, int qty)
		{
			for(int i = _Ix_Gen_E; i<fgrid_Mold.Rows.Count; i+=12)
			{try
				{

				if(fgrid_Mold[i, (int)ClassLib.TBSPO_MOLD_SIZE.IxGEN].ToString() == arg_gen)
				{
					fgrid_Mold[i+4, cs_size] = (int.Parse(fgrid_Mold[i, cs_size].ToString()) + qty).ToString();
				}

				}
				catch
				{
				}
			}
		}

		private void btn_sct_Click(object sender, System.EventArgs e)
		{
//			ProdPlan.Pop_Check_MoldStatus show_MoldStatus = new ProdPlan.Pop_Check_MoldStatus(this);
//			show_MoldStatus.ShowDialog();
		}


		private void btn_Run_Click(object sender, System.EventArgs e)
		{
//			ProdPlan.Pop_Check_MoldStatus show_MoldStatus = new ProdPlan.Pop_Check_MoldStatus(this);
//			show_MoldStatus.ShowDialog();
		}

		private void Form_PO_MoldCapa_1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			COM.ComVar.ToolingCheckList_From_DPO = "";
			COM.ComVar.ToolingCheckList_To_DPO = "";
		}


		private void cmb_Model_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Model.SelectedIndex == -1) return;


			DataTable dt_list= Select_Model_gen();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_gen, 0, 0, false);
			cmb_gen.Splits[0].DisplayColumns[1].Visible = false;  
			cmb_gen.SelectedIndex = 0;

		}

		private void cmb_FromNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_ToNo.SelectedIndex == -1) return;

			DataTable dt_list = Select_Model_CmbList();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Model, 0, 1);

			cmb_gen.SelectedIndex = -1;
		}




		#endregion

		#region DB접속

		private DataTable Select_Mold_Info_Model()
		{


			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE_TEST";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[2] = "ARG_MODEL_GEN";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_Model.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = cmb_gen.SelectedValue.ToString();
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_Mold_Info()
		{

			string fromdate, todate;


			fromdate = ClassLib.ComFunction.Empty_Combo(cmb_FromNo, " ");
			todate = ClassLib.ComFunction.Empty_Combo(cmb_ToNo, " "); 


			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE_TEST1";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM_DATE";
			oraDB.Parameter_Name[2] = "ARG_TO_DATE";
			oraDB.Parameter_Name[3] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_FromNo.SelectedValue.ToString();//ClassLib.ComFunction.Empty_String(fromdate, " ") + ClassLib.ComFunction.Empty_TextBox(txt_FromNo, " ");
			oraDB.Parameter_Values[2] = cmb_ToNo.SelectedValue.ToString();//ClassLib.ComFunction.Empty_String(todate, " ") + ClassLib.ComFunction.Empty_TextBox(txt_ToNo, " ");
			oraDB.Parameter_Values[3] = cmb_Model.SelectedValue.ToString();
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_Fst_size(string arg_mold_cd, string arg_fst_size)
		{

			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_INV_SIZE";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[2] = "ARG_FST_SIZE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_mold_cd;
			oraDB.Parameter_Values[2] = arg_fst_size;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private bool Select_Msize_Check(string arg_mold_cd)
		{

			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_MSIZE_CHECK";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = "VJ"; // 공장 코드 고정
			oraDB.Parameter_Values[1] = arg_mold_cd;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();
			
			if(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString() == "0")
				return false;
			else
				return true;
		}


		private decimal Select_Fst_size_Ord(string arg_mold_cd, string arg_fst_size)
		{

			string fromdate, todate;


			fromdate = ClassLib.ComFunction.Empty_Combo(cmb_FromNo, " ");
			todate = ClassLib.ComFunction.Empty_Combo(cmb_ToNo, " "); 

			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_FST_SIZE_ORD";

			oraDB.ReDim_Parameter(7);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM_DATE";
			oraDB.Parameter_Name[2] = "ARG_TO_DATE";
			oraDB.Parameter_Name[3] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[4] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[5] = "ARG_FST_SIZE";
			oraDB.Parameter_Name[6] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); // 공장 코드 고정
			oraDB.Parameter_Values[1] = cmb_FromNo.SelectedValue.ToString();//ClassLib.ComFunction.Empty_String(fromdate, " ") + ClassLib.ComFunction.Empty_TextBox(txt_FromNo, " ");
			oraDB.Parameter_Values[2] = cmb_ToNo.SelectedValue.ToString();//.ComFunction.Empty_String(todate, " ") + ClassLib.ComFunction.Empty_TextBox(txt_ToNo, " ");
			oraDB.Parameter_Values[3] = cmb_Model.SelectedValue.ToString();
			oraDB.Parameter_Values[4] = arg_mold_cd;
			oraDB.Parameter_Values[5] = arg_fst_size;
			oraDB.Parameter_Values[6] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return 0 ;
			
			return  decimal.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());
		}


		private DataTable Select_Model_gen()
		{
			string Proc_Name = "PKG_SPO_ORDER_BSC.SELECT_MODEL_GEN";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM_DATE";
			oraDB.Parameter_Name[2] = "ARG_TO_DATE";
			oraDB.Parameter_Name[3] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = cmb_FromNo.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = cmb_ToNo.SelectedValue.ToString();
			oraDB.Parameter_Values[3] = cmb_Model.SelectedValue.ToString();
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private void Run_Proc(string arg_factory)
		{

			string Proc_Name = "SP_SPB_MOLD";

			oraDB.ReDim_Parameter(1);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "AEG_FACTORY";
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Values[0] = arg_factory;

			oraDB.Add_Run_Parameter(true);
			oraDB.Exe_Run_Procedure();
		}

		#endregion

		private void txt_plancapa_TextChanged(object sender, System.EventArgs e)
		{
			string daily_value = txt_plancapa.Text;
			if(!ClassLib.ComFunction.Check_Digit(daily_value))
			{
				return;
			}

			for(int i=_Ix_Gen_E; i<fgrid_Mold.Rows.Count; i+=13)
			{
				try
				{
					fgrid_Mold[i+9, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_STYLE_CD] = daily_value;


					int mold_qty   = i+9-8;
					int pairs      = i+9-7;
					int onpress    = i+9-6;
					int mold_cycle = i+9-5;
					int day_capa   = i+9-4;
					int ord_qty    = i+9-3;
					int day_count  = i+9-2;
					int line       = i+9-1;
					int daily_plan = i+9-0;
					int plan_count = i+9+1;
					int short_mold = i+9+2;
				
					decimal order_qty = decimal.Parse(fgrid_Mold[ord_qty, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_TOTAL].ToString());
					decimal line_capa = decimal.Parse(daily_value);
					string planday;
					try
					{
						planday = Math.Ceiling(double.Parse((order_qty/line_capa).ToString())).ToString();
					}
					catch
					{
						planday = "0";
					}



					fgrid_Mold[i+9, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_TOTAL] = planday; 

					decimal order_rate = Math.Round(line_capa/order_qty,10);

					for(int j=_lx_Size_S; j<_lx_Size_E; j++)
					{
						if(fgrid_Mold[ord_qty, j].ToString() != "0")
						{
							fgrid_Mold[daily_plan, j] = (Math.Round((int.Parse(fgrid_Mold[ord_qty, j].ToString())*order_rate),0)).ToString();
							try
							{
								System.Drawing.Color font_color = Color.Blue;
								fgrid_Mold[plan_count, j] = (int.Parse(fgrid_Mold[day_capa, j].ToString()) - int.Parse(fgrid_Mold[daily_plan, j].ToString())).ToString();


								if(int.Parse(fgrid_Mold[plan_count, j].ToString()) < 0)
								{
									font_color = Color.Red;

									fgrid_Mold[short_mold, j] = Math.Floor((double.Parse(fgrid_Mold[plan_count, j].ToString())/(double.Parse(fgrid_Mold[pairs, j].ToString()) * double.Parse(fgrid_Mold[mold_cycle, j].ToString())))).ToString();
								}
								else
								{
									font_color = Color.Blue;
									fgrid_Mold[short_mold, j] = Math.Floor((double.Parse(fgrid_Mold[plan_count, j].ToString())/(double.Parse(fgrid_Mold[pairs, j].ToString()) * double.Parse(fgrid_Mold[mold_cycle, j].ToString())))).ToString();
								}

								fgrid_Mold.GetCellRange(plan_count,j).StyleNew.ForeColor =  font_color;
								fgrid_Mold.GetCellRange(short_mold,j).StyleNew.ForeColor =  font_color;
							}
							catch
							{
							}
						}
					}
				}
				catch
				{
				}
			}


			


			Mold_Info_Result();


			Day_prod();
		}


		private void Show_Mold_Info(bool arg_bool)
		{
			for(int i=_Ix_Gen_E; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION] != null)
				{
					if(fgrid_Mold[i, (int)ClassLib.TBSPO_MOLD_SIZE.IxGR_DIVISION].ToString() == "S")
					{
						fgrid_Mold.Rows[i].Visible = arg_bool;
					}
				}
			}
		}

		private void chk_rowshow_CheckedChanged(object sender, System.EventArgs e)
		{
			show_check = chk_rowshow.Checked;

			Show_Mold_Info(show_check);
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			if(fgrid_Mold.Rows.Count < _Ix_Gen_E) return;


			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

			string message = "";




			for(int i=_Ix_Gen_E; i<fgrid_Style.Rows.Count; i++)
			{
				for(int j=1; j<fgrid_Style.Cols.Count; j++)
				{
					if(fgrid_Style[i,j] != null)
					{
						if(j == 1)
						{
							message += "Style Information @";
						}
						else
						{
							message += fgrid_Style[i,j].ToString() + " @";

						}
					}
					else
					{

						if(j == 1)
						{
							message += "Style Total @";
						}
						else
						{
							message += " @";

						}
					}
				}
				message +="\r\n";
			}


			message += " @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @\r\n";
			message += " @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @\r\n";



			for(int i=_Ix_Gen_E-1; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i,0] != null)
				{
					if(!show_check)
					{
						if(fgrid_Mold[i, 0].ToString() == "V" || fgrid_Mold[i, 0].ToString() == "R")
						{
							for(int j= 1; j<fgrid_Mold.Cols.Count; j++)
							{
								if(fgrid_Mold[i,j] != null)
								{
									message += fgrid_Mold[i,j].ToString() + " @";
								}
								else
								{
									message += " @";
								}
							}
							message +="\r\n";
						}
					}
					else
					{
						if(fgrid_Mold[i, 0].ToString() == "V" || fgrid_Mold[i, 0].ToString() == "R" || fgrid_Mold[i, 0].ToString() == "S")
						{
							for(int j= 1; j<fgrid_Mold.Cols.Count; j++)
							{
								if(fgrid_Mold[i,j] != null)
								{
									message += fgrid_Mold[i,j].ToString() + " @";
								}
								else
								{
									message += " @";
								}
							}
							message +="\r\n";
						}

					}
				}
			}


			FileStream Message = new FileStream(filename, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(Message);

			sw.Write(message);
			sw.Flush();

			sw.Close();
			Message.Close();


			string prod = txt_plancapa.Text;

			if(txt_plancapa.Text.Trim().Length == 0)
			{
				prod = "0";
			}



			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_FROMDPO[" 
				+ cmb_FromNo.SelectedValue.ToString() + "] V_TODPO["
				+ cmb_ToNo.SelectedValue.ToString() + "] V_MODEL["
				+ cmb_Model.Columns[1].Text + "] V_GEN[" 
				+ cmb_gen.Columns[1].Text + "] V_PROD["
				+ prod + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("MOLD INVENTORY", this.Name +".mrd", para);
			report.ShowDialog();
		}
		

		

		

		


	
	} 
}




