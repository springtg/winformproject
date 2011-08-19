using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace ERP.ErpCom
{
	public class Form_CM_Code : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.Panel pnl_Bottom;
		public System.Windows.Forms.Panel pnl_BottomImage;
		public System.Windows.Forms.PictureBox picb_DTR;
		public System.Windows.Forms.PictureBox picb_DTM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_DMR;
		public System.Windows.Forms.PictureBox picb_DMM;
		public System.Windows.Forms.PictureBox picb_DBR;
		public System.Windows.Forms.PictureBox picb_DBM;
		public System.Windows.Forms.PictureBox picb_DBL;
		public System.Windows.Forms.PictureBox picb_DML;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label lbl_SFactory;
		private C1.Win.C1List.C1Combo cmb_Code;
		private System.Windows.Forms.Label btn_PopMajorCd;
		private System.Windows.Forms.Label lbl_SCode;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.TextBox txt_Value4;
		private System.Windows.Forms.CheckBox chk_SystemYN;
		private System.Windows.Forms.Label lbl_Desc4;
		private System.Windows.Forms.TextBox txt_Desc4;
		private System.Windows.Forms.Label lbl_SystemYN;
		private System.Windows.Forms.Label lbl_Code;
		private System.Windows.Forms.TextBox txt_Desc2;
		private System.Windows.Forms.Label lbl_CodeSeq;
		private System.Windows.Forms.Label lbl_Value1;
		private System.Windows.Forms.Label lbl_Desc1;
		private System.Windows.Forms.Label lbl_Desc3;
		private System.Windows.Forms.Label lbl_Value2;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.Label lbl_Value4;
		private System.Windows.Forms.Label lbl_Desc2;
		private System.Windows.Forms.TextBox txt_Value1;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.TextBox txt_Desc3;
		private System.Windows.Forms.TextBox txt_Desc1;
		private System.Windows.Forms.TextBox txt_Value3;
		private System.Windows.Forms.TextBox txt_CodeSeq;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.Label lbl_Value3;
		private System.Windows.Forms.TextBox txt_Value2;
		private System.ComponentModel.IContainer components = null;

		public Form_CM_Code()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_CM_Code));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_PopMajorCd = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.lbl_SCode = new System.Windows.Forms.Label();
			this.cmb_Code = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_SFactory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Bottom = new System.Windows.Forms.Panel();
			this.pnl_BottomImage = new System.Windows.Forms.Panel();
			this.txt_Value1 = new System.Windows.Forms.TextBox();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.lbl_Value4 = new System.Windows.Forms.Label();
			this.lbl_Value1 = new System.Windows.Forms.Label();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_Desc3 = new System.Windows.Forms.TextBox();
			this.lbl_Code = new System.Windows.Forms.Label();
			this.lbl_Desc4 = new System.Windows.Forms.Label();
			this.lbl_Remarks = new System.Windows.Forms.Label();
			this.lbl_Desc3 = new System.Windows.Forms.Label();
			this.chk_SystemYN = new System.Windows.Forms.CheckBox();
			this.txt_Desc1 = new System.Windows.Forms.TextBox();
			this.lbl_Desc2 = new System.Windows.Forms.Label();
			this.lbl_Desc1 = new System.Windows.Forms.Label();
			this.txt_CodeSeq = new System.Windows.Forms.TextBox();
			this.lbl_Value3 = new System.Windows.Forms.Label();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.txt_Value3 = new System.Windows.Forms.TextBox();
			this.txt_Desc2 = new System.Windows.Forms.TextBox();
			this.lbl_Value2 = new System.Windows.Forms.Label();
			this.txt_Value4 = new System.Windows.Forms.TextBox();
			this.lbl_SystemYN = new System.Windows.Forms.Label();
			this.txt_Desc4 = new System.Windows.Forms.TextBox();
			this.txt_Value2 = new System.Windows.Forms.TextBox();
			this.lbl_CodeSeq = new System.Windows.Forms.Label();
			this.picb_DTR = new System.Windows.Forms.PictureBox();
			this.picb_DTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_DMR = new System.Windows.Forms.PictureBox();
			this.picb_DMM = new System.Windows.Forms.PictureBox();
			this.picb_DBR = new System.Windows.Forms.PictureBox();
			this.picb_DBM = new System.Windows.Forms.PictureBox();
			this.picb_DBL = new System.Windows.Forms.PictureBox();
			this.picb_DML = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Code)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Bottom.SuspendLayout();
			this.pnl_BottomImage.SuspendLayout();
			this.pnl_Body.SuspendLayout();
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
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
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
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 105);
			this.pnl_Search.TabIndex = 32;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_PopMajorCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_SCode);
			this.pnl_SearchImage.Controls.Add(this.cmb_Code);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_SFactory);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 89);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_PopMajorCd
			// 
			this.btn_PopMajorCd.ImageIndex = 0;
			this.btn_PopMajorCd.ImageList = this.img_MiniButton;
			this.btn_PopMajorCd.Location = new System.Drawing.Point(322, 58);
			this.btn_PopMajorCd.Name = "btn_PopMajorCd";
			this.btn_PopMajorCd.Size = new System.Drawing.Size(21, 21);
			this.btn_PopMajorCd.TabIndex = 38;
			this.btn_PopMajorCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_PopMajorCd.Click += new System.EventHandler(this.btn_PopMajorCd_Click);
			this.btn_PopMajorCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PopMajorCd_MouseUp);
			this.btn_PopMajorCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PopMajorCd_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_SCode
			// 
			this.lbl_SCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SCode.ImageIndex = 0;
			this.lbl_SCode.ImageList = this.img_Label;
			this.lbl_SCode.Location = new System.Drawing.Point(10, 58);
			this.lbl_SCode.Name = "lbl_SCode";
			this.lbl_SCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_SCode.TabIndex = 34;
			this.lbl_SCode.Text = "코드 아이디";
			this.lbl_SCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Code
			// 
			this.cmb_Code.AddItemCols = 0;
			this.cmb_Code.AddItemSeparator = ';';
			this.cmb_Code.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Code.Caption = "";
			this.cmb_Code.CaptionHeight = 17;
			this.cmb_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Code.ColumnCaptionHeight = 18;
			this.cmb_Code.ColumnFooterHeight = 18;
			this.cmb_Code.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Code.ContentHeight = 17;
			this.cmb_Code.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Code.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Code.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Code.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Code.EditorHeight = 17;
			this.cmb_Code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Code.GapHeight = 2;
			this.cmb_Code.ItemHeight = 15;
			this.cmb_Code.Location = new System.Drawing.Point(111, 58);
			this.cmb_Code.MatchEntryTimeout = ((long)(2000));
			this.cmb_Code.MaxDropDownItems = ((short)(5));
			this.cmb_Code.MaxLength = 32767;
			this.cmb_Code.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Code.Name = "cmb_Code";
			this.cmb_Code.PartialRightColumn = false;
			this.cmb_Code.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Code.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Code.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Code.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Code.Size = new System.Drawing.Size(210, 21);
			this.cmb_Code.TabIndex = 37;
			this.cmb_Code.SelectedValueChanged += new System.EventHandler(this.cmb_Code_SelectedValueChanged);
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 35;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_SFactory
			// 
			this.lbl_SFactory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_SFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SFactory.ImageIndex = 0;
			this.lbl_SFactory.ImageList = this.img_Label;
			this.lbl_SFactory.Location = new System.Drawing.Point(10, 36);
			this.lbl_SFactory.Name = "lbl_SFactory";
			this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_SFactory.TabIndex = 36;
			this.lbl_SFactory.Text = "공장";
			this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(899, 25);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 49);
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
			this.lbl_SubTitle1.Text = "      Common Code Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 74);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 73);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 74);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 56);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 49);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Bottom
			// 
			this.pnl_Bottom.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Bottom.Controls.Add(this.pnl_BottomImage);
			this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_Bottom.DockPadding.All = 8;
			this.pnl_Bottom.Location = new System.Drawing.Point(0, 504);
			this.pnl_Bottom.Name = "pnl_Bottom";
			this.pnl_Bottom.Size = new System.Drawing.Size(1016, 140);
			this.pnl_Bottom.TabIndex = 34;
			// 
			// pnl_BottomImage
			// 
			this.pnl_BottomImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BottomImage.Controls.Add(this.txt_Value1);
			this.pnl_BottomImage.Controls.Add(this.txt_Code);
			this.pnl_BottomImage.Controls.Add(this.lbl_Value4);
			this.pnl_BottomImage.Controls.Add(this.lbl_Value1);
			this.pnl_BottomImage.Controls.Add(this.txt_Name);
			this.pnl_BottomImage.Controls.Add(this.txt_Desc3);
			this.pnl_BottomImage.Controls.Add(this.lbl_Code);
			this.pnl_BottomImage.Controls.Add(this.lbl_Desc4);
			this.pnl_BottomImage.Controls.Add(this.lbl_Remarks);
			this.pnl_BottomImage.Controls.Add(this.lbl_Desc3);
			this.pnl_BottomImage.Controls.Add(this.chk_SystemYN);
			this.pnl_BottomImage.Controls.Add(this.txt_Desc1);
			this.pnl_BottomImage.Controls.Add(this.lbl_Desc2);
			this.pnl_BottomImage.Controls.Add(this.lbl_Desc1);
			this.pnl_BottomImage.Controls.Add(this.txt_CodeSeq);
			this.pnl_BottomImage.Controls.Add(this.lbl_Value3);
			this.pnl_BottomImage.Controls.Add(this.txt_Remarks);
			this.pnl_BottomImage.Controls.Add(this.txt_Value3);
			this.pnl_BottomImage.Controls.Add(this.txt_Desc2);
			this.pnl_BottomImage.Controls.Add(this.lbl_Value2);
			this.pnl_BottomImage.Controls.Add(this.txt_Value4);
			this.pnl_BottomImage.Controls.Add(this.lbl_SystemYN);
			this.pnl_BottomImage.Controls.Add(this.txt_Desc4);
			this.pnl_BottomImage.Controls.Add(this.txt_Value2);
			this.pnl_BottomImage.Controls.Add(this.lbl_CodeSeq);
			this.pnl_BottomImage.Controls.Add(this.picb_DTR);
			this.pnl_BottomImage.Controls.Add(this.picb_DTM);
			this.pnl_BottomImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_BottomImage.Controls.Add(this.picb_DMR);
			this.pnl_BottomImage.Controls.Add(this.picb_DMM);
			this.pnl_BottomImage.Controls.Add(this.picb_DBR);
			this.pnl_BottomImage.Controls.Add(this.picb_DBM);
			this.pnl_BottomImage.Controls.Add(this.picb_DBL);
			this.pnl_BottomImage.Controls.Add(this.picb_DML);
			this.pnl_BottomImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_BottomImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_BottomImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_BottomImage.Name = "pnl_BottomImage";
			this.pnl_BottomImage.Size = new System.Drawing.Size(1000, 124);
			this.pnl_BottomImage.TabIndex = 0;
			// 
			// txt_Value1
			// 
			this.txt_Value1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Value1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value1.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value1.Location = new System.Drawing.Point(445, 32);
			this.txt_Value1.MaxLength = 20;
			this.txt_Value1.Name = "txt_Value1";
			this.txt_Value1.ReadOnly = true;
			this.txt_Value1.Size = new System.Drawing.Size(210, 21);
			this.txt_Value1.TabIndex = 131;
			this.txt_Value1.Text = "";
			// 
			// txt_Code
			// 
			this.txt_Code.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Code.Location = new System.Drawing.Point(111, 32);
			this.txt_Code.MaxLength = 100;
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.ReadOnly = true;
			this.txt_Code.Size = new System.Drawing.Size(210, 21);
			this.txt_Code.TabIndex = 143;
			this.txt_Code.Text = "";
			// 
			// lbl_Value4
			// 
			this.lbl_Value4.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value4.ImageIndex = 0;
			this.lbl_Value4.ImageList = this.img_Label;
			this.lbl_Value4.Location = new System.Drawing.Point(680, 76);
			this.lbl_Value4.Name = "lbl_Value4";
			this.lbl_Value4.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value4.TabIndex = 128;
			this.lbl_Value4.Text = "코드값4";
			this.lbl_Value4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Value1
			// 
			this.lbl_Value1.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value1.ImageIndex = 0;
			this.lbl_Value1.ImageList = this.img_Label;
			this.lbl_Value1.Location = new System.Drawing.Point(344, 32);
			this.lbl_Value1.Name = "lbl_Value1";
			this.lbl_Value1.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value1.TabIndex = 122;
			this.lbl_Value1.Text = "코드값1";
			this.lbl_Value1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Name
			// 
			this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Name.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Name.Location = new System.Drawing.Point(162, 54);
			this.txt_Name.MaxLength = 60;
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.ReadOnly = true;
			this.txt_Name.Size = new System.Drawing.Size(159, 21);
			this.txt_Name.TabIndex = 140;
			this.txt_Name.Text = "";
			// 
			// txt_Desc3
			// 
			this.txt_Desc3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Desc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc3.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc3.Location = new System.Drawing.Point(781, 54);
			this.txt_Desc3.MaxLength = 50;
			this.txt_Desc3.Name = "txt_Desc3";
			this.txt_Desc3.ReadOnly = true;
			this.txt_Desc3.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc3.TabIndex = 135;
			this.txt_Desc3.Text = "";
			// 
			// lbl_Code
			// 
			this.lbl_Code.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Code.ImageIndex = 0;
			this.lbl_Code.ImageList = this.img_Label;
			this.lbl_Code.Location = new System.Drawing.Point(10, 32);
			this.lbl_Code.Name = "lbl_Code";
			this.lbl_Code.Size = new System.Drawing.Size(100, 21);
			this.lbl_Code.TabIndex = 120;
			this.lbl_Code.Text = "코드 아이디";
			this.lbl_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc4
			// 
			this.lbl_Desc4.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc4.ImageIndex = 0;
			this.lbl_Desc4.ImageList = this.img_Label;
			this.lbl_Desc4.Location = new System.Drawing.Point(680, 98);
			this.lbl_Desc4.Name = "lbl_Desc4";
			this.lbl_Desc4.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc4.TabIndex = 129;
			this.lbl_Desc4.Text = "코드 설명4";
			this.lbl_Desc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Remarks
			// 
			this.lbl_Remarks.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Remarks.ImageIndex = 0;
			this.lbl_Remarks.ImageList = this.img_Label;
			this.lbl_Remarks.Location = new System.Drawing.Point(10, 98);
			this.lbl_Remarks.Name = "lbl_Remarks";
			this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
			this.lbl_Remarks.TabIndex = 130;
			this.lbl_Remarks.Text = "비고";
			this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc3
			// 
			this.lbl_Desc3.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc3.ImageIndex = 0;
			this.lbl_Desc3.ImageList = this.img_Label;
			this.lbl_Desc3.Location = new System.Drawing.Point(680, 54);
			this.lbl_Desc3.Name = "lbl_Desc3";
			this.lbl_Desc3.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc3.TabIndex = 127;
			this.lbl_Desc3.Text = "코드 설명3";
			this.lbl_Desc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_SystemYN
			// 
			this.chk_SystemYN.Enabled = false;
			this.chk_SystemYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_SystemYN.Location = new System.Drawing.Point(111, 76);
			this.chk_SystemYN.Name = "chk_SystemYN";
			this.chk_SystemYN.Size = new System.Drawing.Size(16, 21);
			this.chk_SystemYN.TabIndex = 141;
			// 
			// txt_Desc1
			// 
			this.txt_Desc1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Desc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc1.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc1.Location = new System.Drawing.Point(445, 54);
			this.txt_Desc1.MaxLength = 50;
			this.txt_Desc1.Name = "txt_Desc1";
			this.txt_Desc1.ReadOnly = true;
			this.txt_Desc1.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc1.TabIndex = 132;
			this.txt_Desc1.Text = "";
			// 
			// lbl_Desc2
			// 
			this.lbl_Desc2.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc2.ImageIndex = 0;
			this.lbl_Desc2.ImageList = this.img_Label;
			this.lbl_Desc2.Location = new System.Drawing.Point(344, 98);
			this.lbl_Desc2.Name = "lbl_Desc2";
			this.lbl_Desc2.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc2.TabIndex = 125;
			this.lbl_Desc2.Text = "코드 설명2";
			this.lbl_Desc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc1
			// 
			this.lbl_Desc1.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc1.ImageIndex = 0;
			this.lbl_Desc1.ImageList = this.img_Label;
			this.lbl_Desc1.Location = new System.Drawing.Point(344, 54);
			this.lbl_Desc1.Name = "lbl_Desc1";
			this.lbl_Desc1.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc1.TabIndex = 123;
			this.lbl_Desc1.Text = "코드 설명1";
			this.lbl_Desc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_CodeSeq
			// 
			this.txt_CodeSeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_CodeSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CodeSeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_CodeSeq.Location = new System.Drawing.Point(111, 54);
			this.txt_CodeSeq.MaxLength = 60;
			this.txt_CodeSeq.Name = "txt_CodeSeq";
			this.txt_CodeSeq.ReadOnly = true;
			this.txt_CodeSeq.Size = new System.Drawing.Size(50, 21);
			this.txt_CodeSeq.TabIndex = 142;
			this.txt_CodeSeq.Text = "";
			// 
			// lbl_Value3
			// 
			this.lbl_Value3.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value3.ImageIndex = 0;
			this.lbl_Value3.ImageList = this.img_Label;
			this.lbl_Value3.Location = new System.Drawing.Point(680, 32);
			this.lbl_Value3.Name = "lbl_Value3";
			this.lbl_Value3.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value3.TabIndex = 126;
			this.lbl_Value3.Text = "코드값3";
			this.lbl_Value3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Remarks.Location = new System.Drawing.Point(111, 98);
			this.txt_Remarks.MaxLength = 100;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.ReadOnly = true;
			this.txt_Remarks.Size = new System.Drawing.Size(210, 21);
			this.txt_Remarks.TabIndex = 138;
			this.txt_Remarks.Text = "";
			// 
			// txt_Value3
			// 
			this.txt_Value3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Value3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value3.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value3.Location = new System.Drawing.Point(781, 32);
			this.txt_Value3.MaxLength = 20;
			this.txt_Value3.Name = "txt_Value3";
			this.txt_Value3.ReadOnly = true;
			this.txt_Value3.Size = new System.Drawing.Size(210, 21);
			this.txt_Value3.TabIndex = 139;
			this.txt_Value3.Text = "";
			// 
			// txt_Desc2
			// 
			this.txt_Desc2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Desc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc2.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc2.Location = new System.Drawing.Point(445, 98);
			this.txt_Desc2.MaxLength = 50;
			this.txt_Desc2.Name = "txt_Desc2";
			this.txt_Desc2.ReadOnly = true;
			this.txt_Desc2.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc2.TabIndex = 134;
			this.txt_Desc2.Text = "";
			// 
			// lbl_Value2
			// 
			this.lbl_Value2.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value2.ImageIndex = 0;
			this.lbl_Value2.ImageList = this.img_Label;
			this.lbl_Value2.Location = new System.Drawing.Point(344, 76);
			this.lbl_Value2.Name = "lbl_Value2";
			this.lbl_Value2.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value2.TabIndex = 124;
			this.lbl_Value2.Text = "코드값2";
			this.lbl_Value2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Value4
			// 
			this.txt_Value4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Value4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value4.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value4.Location = new System.Drawing.Point(781, 76);
			this.txt_Value4.MaxLength = 20;
			this.txt_Value4.Name = "txt_Value4";
			this.txt_Value4.ReadOnly = true;
			this.txt_Value4.Size = new System.Drawing.Size(210, 21);
			this.txt_Value4.TabIndex = 136;
			this.txt_Value4.Text = "";
			// 
			// lbl_SystemYN
			// 
			this.lbl_SystemYN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_SystemYN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SystemYN.ImageIndex = 0;
			this.lbl_SystemYN.ImageList = this.img_Label;
			this.lbl_SystemYN.Location = new System.Drawing.Point(10, 76);
			this.lbl_SystemYN.Name = "lbl_SystemYN";
			this.lbl_SystemYN.Size = new System.Drawing.Size(100, 21);
			this.lbl_SystemYN.TabIndex = 121;
			this.lbl_SystemYN.Text = "시스템 코드";
			this.lbl_SystemYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Desc4
			// 
			this.txt_Desc4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Desc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc4.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc4.Location = new System.Drawing.Point(781, 98);
			this.txt_Desc4.MaxLength = 50;
			this.txt_Desc4.Name = "txt_Desc4";
			this.txt_Desc4.ReadOnly = true;
			this.txt_Desc4.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc4.TabIndex = 137;
			this.txt_Desc4.Text = "";
			// 
			// txt_Value2
			// 
			this.txt_Value2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Value2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value2.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value2.Location = new System.Drawing.Point(445, 76);
			this.txt_Value2.MaxLength = 20;
			this.txt_Value2.Name = "txt_Value2";
			this.txt_Value2.ReadOnly = true;
			this.txt_Value2.Size = new System.Drawing.Size(210, 21);
			this.txt_Value2.TabIndex = 133;
			this.txt_Value2.Text = "";
			// 
			// lbl_CodeSeq
			// 
			this.lbl_CodeSeq.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_CodeSeq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CodeSeq.ImageIndex = 0;
			this.lbl_CodeSeq.ImageList = this.img_Label;
			this.lbl_CodeSeq.Location = new System.Drawing.Point(10, 54);
			this.lbl_CodeSeq.Name = "lbl_CodeSeq";
			this.lbl_CodeSeq.Size = new System.Drawing.Size(100, 21);
			this.lbl_CodeSeq.TabIndex = 119;
			this.lbl_CodeSeq.Text = "코드 순번/ 명";
			this.lbl_CodeSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DTR
			// 
			this.picb_DTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTR.Image")));
			this.picb_DTR.Location = new System.Drawing.Point(984, 0);
			this.picb_DTR.Name = "picb_DTR";
			this.picb_DTR.Size = new System.Drawing.Size(16, 32);
			this.picb_DTR.TabIndex = 21;
			this.picb_DTR.TabStop = false;
			// 
			// picb_DTM
			// 
			this.picb_DTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTM.Image")));
			this.picb_DTM.Location = new System.Drawing.Point(224, 0);
			this.picb_DTM.Name = "picb_DTM";
			this.picb_DTM.Size = new System.Drawing.Size(770, 39);
			this.picb_DTM.TabIndex = 0;
			this.picb_DTM.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Display Common Code";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DMR
			// 
			this.picb_DMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMR.Image")));
			this.picb_DMR.Location = new System.Drawing.Point(985, 24);
			this.picb_DMR.Name = "picb_DMR";
			this.picb_DMR.Size = new System.Drawing.Size(15, 80);
			this.picb_DMR.TabIndex = 26;
			this.picb_DMR.TabStop = false;
			// 
			// picb_DMM
			// 
			this.picb_DMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMM.Image")));
			this.picb_DMM.Location = new System.Drawing.Point(160, 24);
			this.picb_DMM.Name = "picb_DMM";
			this.picb_DMM.Size = new System.Drawing.Size(832, 84);
			this.picb_DMM.TabIndex = 27;
			this.picb_DMM.TabStop = false;
			// 
			// picb_DBR
			// 
			this.picb_DBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBR.Image")));
			this.picb_DBR.Location = new System.Drawing.Point(984, 108);
			this.picb_DBR.Name = "picb_DBR";
			this.picb_DBR.Size = new System.Drawing.Size(16, 16);
			this.picb_DBR.TabIndex = 23;
			this.picb_DBR.TabStop = false;
			// 
			// picb_DBM
			// 
			this.picb_DBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBM.Image")));
			this.picb_DBM.Location = new System.Drawing.Point(144, 106);
			this.picb_DBM.Name = "picb_DBM";
			this.picb_DBM.Size = new System.Drawing.Size(840, 18);
			this.picb_DBM.TabIndex = 24;
			this.picb_DBM.TabStop = false;
			// 
			// picb_DBL
			// 
			this.picb_DBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBL.Image")));
			this.picb_DBL.Location = new System.Drawing.Point(0, 104);
			this.picb_DBL.Name = "picb_DBL";
			this.picb_DBL.Size = new System.Drawing.Size(168, 20);
			this.picb_DBL.TabIndex = 22;
			this.picb_DBL.TabStop = false;
			// 
			// picb_DML
			// 
			this.picb_DML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DML.Image = ((System.Drawing.Image)(resources.GetObject("picb_DML.Image")));
			this.picb_DML.Location = new System.Drawing.Point(0, 24);
			this.picb_DML.Name = "picb_DML";
			this.picb_DML.Size = new System.Drawing.Size(168, 84);
			this.picb_DML.TabIndex = 25;
			this.picb_DML.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 167);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 337);
			this.pnl_Body.TabIndex = 35;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 337);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// Form_CM_Code
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Bottom);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_CM_Code";
			this.Text = "Common Code Information";
			this.Load += new System.EventHandler(this.Form_CM_Code_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Bottom, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Code)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Bottom.ResumeLayout(false);
			this.pnl_BottomImage.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의
  
		private COM.OraDB MyOraDB = new COM.OraDB();

		private string _Code;
 

		#endregion 

		#region 멤버 메서드

		 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			//Title
			this.Text = "Common Code Information";
			this.lbl_MainTitle.Text = "Common Code Information";
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

			DataTable dt_list;


			//COM.ComFunction comfunc = new COM.ComFunction();
			//comfunc.SetLangDic(this);

			// 그리드 설정
			//fgrid_Main.Set_Grid_Comm("SCM_CODE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Main.Set_Grid("SCM_CODE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 

			// 그리드 상에서 Insert, Delete, Update 이미지로 표시해주기 위한 작업
			fgrid_Main.Set_Action_Image(img_Action); 


			// Factory Combobox Add Items
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;



		}


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			CellRange cellrg;
 
			try
			{
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
				arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";

					if(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSCM_CODE.IxCOM_SEQ].ToString() == "0")
					{
						cellrg = arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1);
						cellrg.StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;

						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = false;
					}

				} 

				arg_fgrid.AutoSizeCols(); 
			}
			catch
			{
			}
			
		}

 

		
		#endregion 

		#region 이벤트 처리

 


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{
				cmb_Factory.SelectedIndex = -1;
				cmb_Code.SelectedIndex = -1;
				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

				txt_Code.Text = "";
				txt_CodeSeq.Text = "";
				txt_Name.Text = "";
				chk_SystemYN.Checked = false;
				txt_Value1.Text = "";
				txt_Desc1.Text = "";
				txt_Value2.Text = "";
				txt_Desc2.Text = "";
				txt_Value3.Text = "";
				txt_Desc3.Text = "";
				txt_Value4.Text = "";
				txt_Desc4.Text = "";
				txt_Remarks.Text = "";
			}
			catch
			{
			}

		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_Code.SelectedIndex == -1) return;

				dt_ret = Select_Data_List();
				Display_Grid(dt_ret, fgrid_Main); 
			}
			catch
			{
			}
 
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);
   
				MyOraDB.Save_FlexGird("PKG_SCM_CODE.SAVE_CODE_LIST", fgrid_Main);
 
				dt_ret = Select_CdList();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Code, 0, 1); 

				cmb_Code.SelectedValue = _Code;
			}
			catch
			{
			}
		
		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_Code.SelectedIndex == -1) return;

				fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);

                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSCM_CODE.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSCM_CODE.IxCOM_CD] = cmb_Code.SelectedValue.ToString();
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSCM_CODE.IxCOM_NAME] = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSCM_CODE.IxCOM_NAME].ToString();
			}
			catch
			{
			}

		}

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_Code.SelectedIndex == -1) return;
 
				fgrid_Main.Add_Row(fgrid_Main.Selection.r1);

                fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSCM_CODE.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
                fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSCM_CODE.IxCOM_CD] = cmb_Code.SelectedValue.ToString();
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSCM_CODE.IxCOM_NAME] = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSCM_CODE.IxCOM_NAME].ToString();
			}
			catch
			{
			}

		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_Code.SelectedIndex == -1) return;

				//대표코드 삭제 불가능하도록.. 팝업창에서만 삭제 가능
                if (fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSCM_CODE.IxCOM_SEQ].ToString() == "0") return;
  
				fgrid_Main.Delete_Row();
			}
			catch
			{
			}

		}	

		 

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;

				dt_ret = Select_CdList();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Code, 0, 1, false);
			}
			catch
			{
			}


		}

		

		private void cmb_Code_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_Code.SelectedIndex == -1) return;

				_Code = cmb_Code.SelectedValue.ToString();

				dt_ret = Select_Data_List();
				Display_Grid(dt_ret, fgrid_Main);
			}
			catch
			{
			}
 
		}


  
		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
				{
					if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool)) 
						fgrid_Main.Buffer_CellData = ""; 
					else 
						fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			}
			catch
			{
			}
		}



		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				fgrid_Main.Update_Row();
				fgrid_Main.AutoSizeCols();
			}
			catch
			{
			}
		}



		 
		private void btn_PopMajorCd_Click(object sender, System.EventArgs e)
		{
			 
			DataTable dt_ret;
			Pop_SetMajorCd pop_form = new Pop_SetMajorCd();

			try
			{
				if(cmb_Factory.SelectedIndex == -1)
				{
					MessageBox.Show("공장 선택");
				}
				else
				{
 			

					ClassLib.ComVar.Parameter_PopUp = new string[fgrid_Main.Cols.Count - 3];

					if(cmb_Code.SelectedIndex == -1)
					{
						ClassLib.ComVar.Parameter_PopUp[0] = cmb_Factory.SelectedValue.ToString();

						for(int i = 2; i < fgrid_Main.Cols.Count - 2; i++)
						{
							ClassLib.ComVar.Parameter_PopUp[i - 1] = "";
						}
					}
					else
					{
						for(int i = 1; i < fgrid_Main.Cols.Count - 2; i++)
						{
							ClassLib.ComVar.Parameter_PopUp[i - 1] = fgrid_Main[fgrid_Main.Rows.Fixed, i].ToString();
						}
					}
				

					pop_form.ShowDialog(); 

					/////////////////////////////////////////////////////////////////
					if(cmb_Factory.SelectedIndex != -1)
					{
						dt_ret = Select_CdList();
						ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Code, 0, 1, true);
					}

					fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
					//				tbtn_New_Click(null, null);
					cmb_Code.SelectedValue = COM.ComVar.Parameter_PopUp[0];
				}
			}
			catch
			{
			} 

		}

		private void btn_PopMajorCd_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopMajorCd.ImageIndex = 1;
		}



		private void btn_PopMajorCd_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopMajorCd.ImageIndex = 0;
		}



		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			try
			{
				int sel_row = fgrid_Main.Selection.r1;
 
				if(sel_row >= fgrid_Main.Rows.Fixed)
				{
                    txt_Code.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_CD].ToString();
                    txt_CodeSeq.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_SEQ].ToString();
                    txt_Name.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_NAME].ToString();
                    chk_SystemYN.Checked = Convert.ToBoolean(fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxSYSTEM_YN]);
                    txt_Value1.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_VALUE1].ToString();
                    txt_Desc1.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_DESC1].ToString();
                    txt_Value2.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_VALUE2].ToString();
                    txt_Desc2.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_DESC2].ToString();
                    txt_Value3.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_VALUE3].ToString();
                    txt_Desc3.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_DESC3].ToString();
                    txt_Value4.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_VALUE4].ToString();
                    txt_Desc4.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxCOM_DESC4].ToString();
                    txt_Remarks.Text = fgrid_Main[sel_row, (int)ClassLib.TBSCM_CODE.IxREMARKS].ToString(); 
				}
			}
			catch
			{
			}

		}
 




		#endregion 

		#region DB Connect


	 
 
		/// <summary>
		/// Select_CdList : 공통코드 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_CdList()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_CODE.SELECT_COM_CODE_LIST";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, " ");
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}

		

		/// <summary>
		/// Select_Data_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private DataTable Select_Data_List()
		{
			DataSet ds_ret;
			string process_name = "PKG_SCM_CODE.SELECT_CODE_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, " ");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Code, " ");
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
  

		}



		


		#endregion



		private void Form_CM_Code_Load(object sender, System.EventArgs e)
		{
			Init_Form();   
		}
 
		

	}
}

