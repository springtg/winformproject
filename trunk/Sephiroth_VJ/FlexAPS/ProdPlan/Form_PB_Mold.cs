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
	public class Form_PB_Mold : COM.APSWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Search;
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
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_mold_type;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label btn_sct;
		public COM.FSP fgrid_Mold;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_mold_type;
		public COM.FSP fgrid_Multi;
		private System.Windows.Forms.ContextMenu cMenu;



		private COM.OraDB oraDB = null;
		private int _IxGen_Value, _IxStart_Size, _IxTotal;
		private int _Ix_gen_s = 1;
		private int _Ix_gen_e = 6;
		private int _Ix_size_s = 11;
		private int _Ix_size_e = 0;
		private int col_width = 40;
		private int gen_width = 25;
		private MenuItem mitem = null;

		private int sct_start = 0;
		private int sct_stop  = 0;
		private string arg_sct_yn = "Y";
		private string sct_type = "";
		private string tem_YN = "";
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_condition;
		private System.Windows.Forms.Label lbl_subject;
		private System.Windows.Forms.TextBox txt_subject;
		private C1.Win.C1List.C1Combo cmb_condition;
		private int size_ea = 1;



		public Form_PB_Mold()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.txt_subject = new System.Windows.Forms.TextBox();
			this.lbl_subject = new System.Windows.Forms.Label();
			this.lbl_condition = new System.Windows.Forms.Label();
			this.cmb_condition = new C1.Win.C1List.C1Combo();
			this.btn_sct = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_status = new System.Windows.Forms.TextBox();
			this.lbl_status = new System.Windows.Forms.Label();
			this.cmb_mold_type = new C1.Win.C1List.C1Combo();
			this.lbl_mold_type = new System.Windows.Forms.Label();
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
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.fgrid_Multi = new COM.FSP();
			this.cMenu = new System.Windows.Forms.ContextMenu();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_condition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_mold_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Multi)).BeginInit();
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
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
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
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.txt_subject);
			this.pnl_Search.Controls.Add(this.lbl_subject);
			this.pnl_Search.Controls.Add(this.lbl_condition);
			this.pnl_Search.Controls.Add(this.cmb_condition);
			this.pnl_Search.Controls.Add(this.btn_sct);
			this.pnl_Search.Controls.Add(this.txt_status);
			this.pnl_Search.Controls.Add(this.lbl_status);
			this.pnl_Search.Controls.Add(this.cmb_mold_type);
			this.pnl_Search.Controls.Add(this.lbl_mold_type);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.lbl_Factory);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 10;
			this.pnl_Search.DockPadding.Right = 10;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 88);
			this.pnl_Search.TabIndex = 44;
			// 
			// txt_subject
			// 
			this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_subject.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_subject.Location = new System.Drawing.Point(397, 57);
			this.txt_subject.Name = "txt_subject";
			this.txt_subject.Size = new System.Drawing.Size(150, 22);
			this.txt_subject.TabIndex = 106;
			this.txt_subject.Text = "";
			// 
			// lbl_subject
			// 
			this.lbl_subject.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_subject.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_subject.ImageIndex = 0;
			this.lbl_subject.ImageList = this.img_Label;
			this.lbl_subject.Location = new System.Drawing.Point(296, 58);
			this.lbl_subject.Name = "lbl_subject";
			this.lbl_subject.Size = new System.Drawing.Size(100, 21);
			this.lbl_subject.TabIndex = 105;
			this.lbl_subject.Text = "Subject";
			this.lbl_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_condition
			// 
			this.lbl_condition.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_condition.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_condition.ImageIndex = 0;
			this.lbl_condition.ImageList = this.img_Label;
			this.lbl_condition.Location = new System.Drawing.Point(18, 58);
			this.lbl_condition.Name = "lbl_condition";
			this.lbl_condition.Size = new System.Drawing.Size(100, 21);
			this.lbl_condition.TabIndex = 104;
			this.lbl_condition.Text = "Condition";
			this.lbl_condition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_condition
			// 
			this.cmb_condition.AddItemCols = 0;
			this.cmb_condition.AddItemSeparator = ';';
			this.cmb_condition.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_condition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_condition.Caption = "";
			this.cmb_condition.CaptionHeight = 17;
			this.cmb_condition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_condition.ColumnCaptionHeight = 18;
			this.cmb_condition.ColumnFooterHeight = 18;
			this.cmb_condition.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_condition.ContentHeight = 17;
			this.cmb_condition.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_condition.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_condition.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_condition.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_condition.EditorHeight = 17;
			this.cmb_condition.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_condition.GapHeight = 2;
			this.cmb_condition.ItemHeight = 15;
			this.cmb_condition.Location = new System.Drawing.Point(119, 58);
			this.cmb_condition.MatchEntryTimeout = ((long)(2000));
			this.cmb_condition.MaxDropDownItems = ((short)(5));
			this.cmb_condition.MaxLength = 32767;
			this.cmb_condition.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_condition.Name = "cmb_condition";
			this.cmb_condition.PartialRightColumn = false;
			this.cmb_condition.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_condition.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_condition.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_condition.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_condition.Size = new System.Drawing.Size(150, 21);
			this.cmb_condition.TabIndex = 103;
			// 
			// btn_sct
			// 
			this.btn_sct.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_sct.ImageIndex = 6;
			this.btn_sct.ImageList = this.img_MiniButton;
			this.btn_sct.Location = new System.Drawing.Point(860, 36);
			this.btn_sct.Name = "btn_sct";
			this.btn_sct.Size = new System.Drawing.Size(21, 21);
			this.btn_sct.TabIndex = 102;
			this.btn_sct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_sct.Visible = false;
			this.btn_sct.Click += new System.EventHandler(this.btn_sct_Click);
			this.btn_sct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_sct_MouseUp);
			this.btn_sct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_sct_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// txt_status
			// 
			this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_status.Location = new System.Drawing.Point(669, 35);
			this.txt_status.Name = "txt_status";
			this.txt_status.Size = new System.Drawing.Size(190, 22);
			this.txt_status.TabIndex = 40;
			this.txt_status.Text = "GOOD";
			// 
			// lbl_status
			// 
			this.lbl_status.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(568, 36);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(100, 21);
			this.lbl_status.TabIndex = 39;
			this.lbl_status.Text = "Tooling Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_mold_type
			// 
			this.cmb_mold_type.AddItemCols = 0;
			this.cmb_mold_type.AddItemSeparator = ';';
			this.cmb_mold_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_mold_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_mold_type.Caption = "";
			this.cmb_mold_type.CaptionHeight = 17;
			this.cmb_mold_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_mold_type.ColumnCaptionHeight = 18;
			this.cmb_mold_type.ColumnFooterHeight = 18;
			this.cmb_mold_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_mold_type.ContentHeight = 17;
			this.cmb_mold_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_mold_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_mold_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_mold_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_mold_type.EditorHeight = 17;
			this.cmb_mold_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_mold_type.GapHeight = 2;
			this.cmb_mold_type.ItemHeight = 15;
			this.cmb_mold_type.Location = new System.Drawing.Point(397, 36);
			this.cmb_mold_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_mold_type.MaxDropDownItems = ((short)(5));
			this.cmb_mold_type.MaxLength = 32767;
			this.cmb_mold_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_mold_type.Name = "cmb_mold_type";
			this.cmb_mold_type.PartialRightColumn = false;
			this.cmb_mold_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_mold_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_mold_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_mold_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_mold_type.Size = new System.Drawing.Size(150, 21);
			this.cmb_mold_type.TabIndex = 38;
			// 
			// lbl_mold_type
			// 
			this.lbl_mold_type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_mold_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_mold_type.ImageIndex = 0;
			this.lbl_mold_type.ImageList = this.img_Label;
			this.lbl_mold_type.Location = new System.Drawing.Point(296, 36);
			this.lbl_mold_type.Name = "lbl_mold_type";
			this.lbl_mold_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_mold_type.TabIndex = 37;
			this.lbl_mold_type.Text = "Mold Type";
			this.lbl_mold_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
			this.cmb_Factory.TabIndex = 36;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(996, 83);
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
			this.picb_MR.Size = new System.Drawing.Size(15, 40);
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
			this.lbl_SubTitle1.Text = "      Search Mold Conditions";
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
			this.picb_BM.Size = new System.Drawing.Size(836, 24);
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
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 40);
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
			this.picb_MM.Size = new System.Drawing.Size(828, 48);
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
			this.fgrid_Mold.ContextMenu = this.contextMenu1;
			this.fgrid_Mold.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mold.Location = new System.Drawing.Point(8, 152);
			this.fgrid_Mold.Name = "fgrid_Mold";
			this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mold.Size = new System.Drawing.Size(998, 384);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 47;
			this.fgrid_Mold.Click += new System.EventHandler(this.fgrid_Mold_Click);
			this.fgrid_Mold.DoubleClick += new System.EventHandler(this.fgrid_Mold_DoubleClick);
			this.fgrid_Mold.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Mold_AfterEdit);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem2});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Insert Mold Status";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = -1;
			this.menuItem1.Text = "";
			// 
			// fgrid_Multi
			// 
			this.fgrid_Multi.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Multi.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Multi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Multi.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Multi.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Multi.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Multi.ContextMenu = this.cMenu;
			this.fgrid_Multi.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Multi.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Multi.Location = new System.Drawing.Point(8, 544);
			this.fgrid_Multi.Name = "fgrid_Multi";
			this.fgrid_Multi.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Multi.Size = new System.Drawing.Size(998, 96);
			this.fgrid_Multi.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Multi.TabIndex = 48;
			this.fgrid_Multi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Multi_MouseUp);
			this.fgrid_Multi.DoubleClick += new System.EventHandler(this.fgrid_Multi_DoubleClick);
			this.fgrid_Multi.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Multi_AfterEdit);
			// 
			// Form_PB_Mold
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Multi);
			this.Controls.Add(this.fgrid_Mold);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PB_Mold";
			this.Load += new System.EventHandler(this.From_PB_Mold_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Mold, 0);
			this.Controls.SetChildIndex(this.fgrid_Multi, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_condition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_mold_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Multi)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트

		private void From_PB_Mold_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		/// <summary>
		/// Status Select 버튼 클릭시 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_sct_Click(object sender, System.EventArgs e)
		{
			//Pop_Check_MoldStatus show_MoldStatus = new Pop_Check_MoldStatus(this);
			//show_MoldStatus.ShowDialog();
		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Mold.Select(fgrid_Mold.Selection.r1, 0, fgrid_Mold.Selection.r1, fgrid_Mold.Cols.Count-1, false);
			
			Set_Grid_Data();

			//임시 로우
			fgrid_Mold.Rows.Add();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = "Y";
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD.IxGR_FACTORY] = cmb_Factory.SelectedValue.ToString();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "";
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].Height = 0;



			Sum_Qty();


			if(fgrid_Mold.Rows.Count > _Ix_gen_e)
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			else
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
			}


			




			
		}


		private void fgrid_Mold_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int sct_row = fgrid_Mold.Selection.r1;
			int sct_col = fgrid_Mold.Selection.c1;


			if(fgrid_Mold[sct_row, 0].ToString() == "Y")
			{
				return;
			}

			if(fgrid_Mold[sct_row, 0].ToString() == "S")
			{
				return;
			}





			if(fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() != "I")
				fgrid_Mold[sct_row,0] = "U"; 



			if(sct_col <= _Ix_gen_e) return;

			if(fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "I")
			{
				if(fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString().Trim().Substring(0,1) != "N")
				{
					if(fgrid_Mold[sct_row-1, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString().Trim().Substring(0,1) != "N")
					{
						int height_qty = 0;
						try
						{
							height_qty = int.Parse(fgrid_Mold[sct_row-1, sct_col].ToString());
						}
						catch
						{
						}
						
						
						
						int low_qty    = 0;

						try
						{
							low_qty    = int.Parse(fgrid_Mold[sct_row, sct_col].ToString());
						}
						catch
						{
						}

						fgrid_Mold[sct_row-1, sct_col] = (height_qty - low_qty).ToString();
					}
					else if(fgrid_Mold[sct_row+1, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString().Trim().Substring(0,1) != "N")
					{
						MessageBox.Show("아래");
					}
					else
					{
						MessageBox.Show("없음");
					}
				}
			}


			//fgrid_Mold.AutoSizeCols();
			fgrid_Mold.AutoSizeRow(sct_row);
		}


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Mold.Rows.Count = _Ix_gen_e;
			fgrid_Multi.Rows.Count = _Ix_gen_e;
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Mold.Select(fgrid_Mold.Selection.r1, 0, fgrid_Mold.Selection.r1, fgrid_Mold.Cols.Count-1, false);
			Fgrid_Data_Save();
			Save_SBP_Mold();
			Set_Grid_Data();
			
			
			Sum_Qty();


			ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
		}


		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Insert_SPB_MOLD();
		}


		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sct_row = fgrid_Mold.Selection.r1;

			if(fgrid_Mold[sct_row, 0].ToString() == "S") return;

			fgrid_Mold[sct_row, 0] = "D";
			fgrid_Mold.AutoSizeRows();
		}

		private void fgrid_Mold_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_Mold.Selection.r1;
			int sct_col = fgrid_Mold.Selection.c1;


			//if(fgrid_Mold[sct_row, 0].ToString() == "Y")
			//{
			//	ClassLib.ComFunction.User_Message("Can not Modify!!");
			//	return;
			//}

			//합계를 표시하는 row는 제외
			if(fgrid_Mold[sct_row, 0].ToString() == "S") return;
			
			fgrid_Multi.Rows.Count = _Ix_gen_e;

			string[] ArrayItem = new string[fgrid_Mold.Cols.Count-1];

			
			//if(sct_col == (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN)//Muse_YN 컬럼 클릭시
			//{
			//	Edit_Row_Data("MUSEYN", sct_row, sct_col );
			//}
			//else if(sct_col == (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN)//Msize_YN 컬럼 클릭시 
			//{
				Edit_Row_Data("MSIZEYN", sct_row, sct_col );
			//}



			int row_fst_size = fgrid_Multi.Rows.Count-4;
			int row_pairs    = fgrid_Multi.Rows.Count-3;
			int row_onpress  = fgrid_Multi.Rows.Count-2;
			int row_mold_qty = fgrid_Multi.Rows.Count-1;


			fgrid_Multi[row_fst_size-1, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "MOLD SIZE";

			fgrid_Multi.Rows[row_fst_size].AllowEditing = false;
			fgrid_Multi.GetCellRange(row_fst_size,0, row_fst_size, fgrid_Multi.Cols.Count-1).StyleNew.TextAlign = TextAlignEnum.CenterCenter;
			fgrid_Multi.GetCellRange(row_fst_size,0,row_fst_size, fgrid_Multi.Cols.Count-1).StyleNew.BackColor = Color.FromArgb(217, 250, 216);


			fgrid_Multi.Rows[row_pairs].AllowEditing = true;
			
			fgrid_Multi.Rows[row_onpress].AllowEditing = true;


			//fgrid_Multi[row_mold_qty,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "MOLD QTY";
			fgrid_Multi.Rows[row_mold_qty].AllowEditing = true;
			fgrid_Multi.Rows[row_mold_qty].TextAlign = TextAlignEnum.RightCenter;


			
			fgrid_Multi.GetCellRange(row_mold_qty,0, row_mold_qty, fgrid_Multi.Cols.Count-1).StyleNew.BackColor = Color.FromArgb(251, 248, 185);
			fgrid_Multi.GetCellRange(row_mold_qty,10, row_mold_qty, fgrid_Multi.Cols.Count-1).StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);
			fgrid_Multi.GetCellRange(row_mold_qty,10, row_mold_qty, fgrid_Multi.Cols.Count-1).StyleNew.ForeColor = Color.FromArgb(203, 73, 203);




			
			if(fgrid_Mold[sct_row, 0].ToString() == "Y")
			{
				fgrid_Multi.AllowEditing = false;
			}
			else
			{
				fgrid_Multi.AllowEditing = true;
			}
	
		}



		private void Edit_Row_Data(string arg_col_name,int arg_row, int arg_col )
		{
			sct_type = arg_col_name;
			arg_sct_yn = fgrid_Mold[arg_row, arg_col].ToString();

			string[] ArrayItem = new string[fgrid_Mold.Cols.Count-1];

			for(int i=0; i<fgrid_Mold.Cols.Count-1; i++)
			{
				try
				{
					ArrayItem[i] = fgrid_Mold[arg_row, i].ToString();
				}
				catch
				{
					ArrayItem[i] = "";
				}
			}

			Show_Gen_Size(fgrid_Mold[arg_row, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString());

			
			fgrid_Multi.Rows.Add();
			fgrid_Multi.Rows.Add();
			fgrid_Multi.Rows.Add();


			
			int fst_size_row      = _Ix_gen_e;
			int pairs_row         = _Ix_gen_e + 1;
			int avail_onpress_row = _Ix_gen_e + 2;
			int cs_size_row       = _Ix_gen_e + 3;
			
			fgrid_Multi.AddItem(ArrayItem,cs_size_row, 0);


			fgrid_Multi[cs_size_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = "";
			fgrid_Multi[fst_size_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = ""; 
			fgrid_Multi[pairs_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = ""; 
			fgrid_Multi[avail_onpress_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = ""; 


			fgrid_Multi[fst_size_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "CS SIZE";
			fgrid_Multi[pairs_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "PAIRS";
			fgrid_Multi[avail_onpress_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "ON_PRESS";





			string arg_factory = ArrayItem[(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY];
			string arg_mold_cd = ArrayItem[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD];
			string half_code   = ArrayItem[(int)ClassLib.TBSPB_MOLD.IxGR_HALF];
			string div = ":";
			string[] arg_half  = half_code.Split(div.ToCharArray());
			string arg_status  = ArrayItem[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS];
			string arg_div = ":";
			string[] arg_code = arg_status.Split(arg_div.ToCharArray());

			string status = arg_code[0].Trim();

			



			#region 몰드 FST_SIZE 표시


			//int _DBcol_Mold_cd  = 0;
			int _DBcol_Gen      = 1;
			int _DBcol_Cs_size  = 2;
			int _DBcol_Fst_size = 3;
			int _DBcol_Pairs    = 4;



			DataTable dt = Select_Mold_Inven_Fst(arg_factory, arg_mold_cd, status);

			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;

			string gen = dt.Rows[0].ItemArray[_DBcol_Gen].ToString();

			int m;
			for(m=_Ix_gen_s; m<_Ix_gen_e; m++)
			{
				if(fgrid_Multi[m, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == gen)
				{
					break;
				}

			}

			for(int j=0; j<dt_row; j++)
			{
				for(int k=_Ix_size_s; k<_Ix_size_e; k++)
				{
					if(fgrid_Multi[m, k].ToString() == dt.Rows[j].ItemArray[_DBcol_Cs_size].ToString())
					{
						if(fgrid_Multi[fst_size_row,k] == null)
						{
							fgrid_Multi[fst_size_row,k] = dt.Rows[j].ItemArray[_DBcol_Fst_size].ToString();
							fgrid_Multi[pairs_row, k] = dt.Rows[j].ItemArray[_DBcol_Pairs].ToString();
						}
						else
						{
							fgrid_Multi[fst_size_row,k] = fgrid_Multi[fst_size_row,k].ToString() + "/" + dt.Rows[j].ItemArray[_DBcol_Fst_size].ToString();
							fgrid_Multi[pairs_row, k] = (int.Parse(fgrid_Multi[pairs_row, k].ToString()) + int.Parse(dt.Rows[j].ItemArray[_DBcol_Pairs].ToString())).ToString();
						}
						break;
					}
				}
			}






			#endregion













//			string aa = arg_code[0].Trim();
//				
//			DataTable dt = Select_SPB_Mold_FstSize(arg_factory, arg_mold_cd, arg_half[0].Trim(), arg_code[0].Trim());
//				
//			int dt_row = dt.Rows.Count;
//			int st_col = dt.Rows.Count;
//
//
//			int l;
//
//			string dt_gen = dt.Rows[0].ItemArray[0].ToString();
//
//			for(int j=0; j<dt.Rows.Count; j++)
//			{
//				string dt_cs_size = dt.Rows[j].ItemArray[1].ToString();
//				string dt_fst_size = dt.Rows[j].ItemArray[2].ToString();
//				string dt_pairs = dt.Rows[j].ItemArray[3].ToString();
//				string dt_avail_onpress = dt.Rows[j].ItemArray[4].ToString();
//
//				for(l=_Ix_gen_s; l<_Ix_gen_e; l++)
//				{
//					if(fgrid_Multi[l,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == dt_gen)
//					{
//						break;
//					}
//				}
//				for(int k=_Ix_size_s; k<_Ix_size_e; k++)
//				{
//					if(fgrid_Multi[l, k].ToString() == dt_cs_size)
//					{
//						fgrid_Multi[fst_size_row, k] = dt_fst_size;
//						fgrid_Multi[pairs_row, k] = dt_pairs;
//						fgrid_Multi[avail_onpress_row, k] = dt_avail_onpress;
//						break;
//					}
//				}
//			}

			if(sct_type == "MSIZEYN")
			{
				tem_YN = fgrid_Mold[arg_row, (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString();
				fgrid_Multi.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].Visible = true;
				fgrid_Multi.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].Visible = false;
			}
			else if(sct_type == "MUSEYN")
			{
				tem_YN = fgrid_Mold[arg_row, (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString();
				fgrid_Multi.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].Visible = false;
				fgrid_Multi.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].Visible = true;
			}


			CellStyle cellst = fgrid_Multi.Styles.Add("FST_ROW");
			cellst.TextAlign = TextAlignEnum.RightCenter;
			fgrid_Multi.Rows[_Ix_gen_e ].Style = fgrid_Multi.Styles["FST_ROW"];
			fgrid_Multi.Rows[_Ix_gen_e + 1].Style = fgrid_Multi.Styles["FST_ROW"];
			fgrid_Multi.Rows[_Ix_gen_e + 2].Style = fgrid_Multi.Styles["FST_ROW"];
			fgrid_Multi.Rows[_Ix_gen_e + 3].Style = fgrid_Multi.Styles["FST_ROW"];

		    fgrid_Multi.Rows[avail_onpress_row].Height = 0;
		}


		private void fgrid_Multi_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			int sct_row = fgrid_Multi.Selection.r1;
			int sct_col = fgrid_Multi.Selection.c1;

			try
			{
				Auto_Set_Data(sct_col);
			}
			catch
			{
			}

		}

		private void Auto_Set_Data(int arg_col)
		{
			string col_num ="";
			if(arg_col <= (int)ClassLib.TBSPB_MOLD.IxGR_GEN) return;

			fgrid_Multi[_Ix_gen_e,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = "U";

			string fst_size = fgrid_Multi[_Ix_gen_e, arg_col].ToString();
			string user_pairs = fgrid_Multi[_Ix_gen_e + 1, arg_col].ToString();

			if(fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString() == "Y" 
				|| fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString() == "N")
			{
				for(int i=_Ix_size_s; i<_Ix_size_e; i++)
				{
					if(fgrid_Multi[_Ix_gen_e,i] != null)
					{
						if(fgrid_Multi[_Ix_gen_e,i].ToString() == fst_size)
						{
							col_num = col_num + i.ToString() +"/";
						}
					}
				}
			

				string div = "/";

				string[] col_nums = col_num.Split(div.ToCharArray());


				for(int k=0; k<col_nums.Length-1; k++)
				{
					fgrid_Multi[_Ix_gen_e+1,int.Parse(col_nums[k])] = user_pairs;
					fgrid_Multi[_Ix_gen_e+2,int.Parse(col_nums[k])] = Math.Round((decimal.Parse(user_pairs)/(col_nums.Length-1)),2).ToString();
				}
			}
			else
			{
				fgrid_Multi[_Ix_gen_e+1,arg_col] = user_pairs;
				fgrid_Multi[_Ix_gen_e+2,arg_col] = user_pairs;

			}
		}


		/// <summary>
		/// fgrid_Multi_MouseUp : fgrid_Multi에서 마우스를 up했을때 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_Multi_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				cMenu.MenuItems.Clear();

			

				int index = 0;

				sct_start = fgrid_Multi.Selection.c1;
				sct_stop  = fgrid_Multi.Selection.c2;

				size_ea = (sct_stop+1) - sct_start;

				if(sct_start <= (int)ClassLib.TBSPB_MOLD.IxGR_GEN) return;
				string gen = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();

				for(int i=sct_start; i<= sct_stop; i++)
				{

					mitem = new MenuItem();
					mitem.Index = i;
					mitem.Text = Bring_CS_Size(gen, i);
					if(i != sct_start)
					{
						mitem.Enabled = false;
					}
					cMenu.MenuItems.Add(mitem);
					mitem.Click +=new EventHandler(Set_Grid_FstSize);

					index++;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void fgrid_Multi_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_Multi.Selection.r1;
			int sct_col = fgrid_Multi.Selection.c1;


			fgrid_Multi[_Ix_gen_e, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = "U";	


			if( sct_row == 9 && sct_col == 7 )
			{
				if(fgrid_Multi[9, 7].ToString() == "Y")
				{
					fgrid_Multi[9, 7] = "N";
				}
				else
				{
					fgrid_Multi[9, 7] = "Y";
					
					// MUSE_YN, MSIZE_YN 동시에 "Y"를 할 수 없음
					if(tem_YN == "Y" && fgrid_Multi[6, 7].ToString() == "Y")
					{
						ClassLib.ComFunction.User_Message("MSIZE_YN 과 MUSE_YN 항목을 'Y'로 할 수 없습니다.");
						fgrid_Multi[9, 7] = "N";
						return;
					}
				}
			}
			else if( sct_row == 9 && sct_col == 6 )
			{
				if(fgrid_Multi[9, 6].ToString() == "Y")
				{
					fgrid_Multi[9, 6] = "N";
				}
				else
				{
					fgrid_Multi[9, 6] = "Y";

					// MUSE_YN, MSIZE_YN 동시에 "Y"를 할 수 없음
					if(tem_YN == "Y" && fgrid_Multi[9, 6].ToString() == "Y")
					{
						ClassLib.ComFunction.User_Message("MSIZE_YN 과 MUSE_YN 항목을 'Y'로 할 수 없습니다.");
						fgrid_Multi[9, 6] = "N";
						return;
					}
				}
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_Mold_Click(object sender, System.EventArgs e)
		{

			if(fgrid_Mold.Rows.Count < _Ix_gen_e) return;

			int sct_row = fgrid_Mold.Selection.r1;
			int sct_col = fgrid_Mold.Selection.r1;


			if(fgrid_Mold[sct_row, 0].ToString() == "N")
				fgrid_Mold.Rows[sct_row].AllowEditing = true;





			int row_num = 0;

			try
			{

				string sct_gen = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();

				int i;
				for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
				{
					fgrid_Mold.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;
					fgrid_Mold.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.ForeColor = Color.White;

					if(fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == sct_gen)
					{
						row_num = i;
					}
				}

				fgrid_Mold.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.BackColor = Color.FromArgb(251, 248, 185);//COM.ComVar.GridDarkFixed_Color;
				fgrid_Mold.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.ForeColor = Color.Black;



				if(fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "I")
					fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].AllowEditing = true; 
				else
					fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].AllowEditing = false; 





				fgrid_Mold_DoubleClick(null, null);
			}
			catch
			{
			}
		}

		#endregion

		#region 메소드
		
		private void Init_Form()
		{
			this.Text = "Mold Information";
			this.lbl_MainTitle.Text = "Mold Information";
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






			//Factroy ComboBox Setting
			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false,COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 


			//Mold Type ComboBox Setting 
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),ClassLib.ComVar.CxMoldType);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_mold_type, 1,2 ,true);
			cmb_mold_type.SelectedIndex = 0;


			Show_Mold_Status();


			//스타일 그리드
			fgrid_Mold.Set_Grid("SPB_MOLD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold);
			fgrid_Mold.Cols.Frozen = (int)ClassLib.TBSPB_MOLD.IxGR_GEN+1;
			fgrid_Mold.Font = new Font("Verdana", 7);


			fgrid_Multi.Set_Grid("SPB_MOLD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Multi.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Multi);
			fgrid_Multi.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			fgrid_Multi.Cols.Frozen = (int)ClassLib.TBSPB_MOLD.IxGR_GEN;
			fgrid_Multi.Font = new Font("Verdana", 7);



			//Mold Type ComboBox Setting 
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),ClassLib.ComVar.CxMoldCondition);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_condition, 1,2 ,false);
			cmb_condition.SelectedIndex = 0;


			//mold inventory 가져오기
			btn_Run_Click(null, null);

			

			
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

			arg_fgrid.AutoSizeCols();

 			

			//------------------------------------------------
			//젠더 입력

			_IxGen_Value = (int)ClassLib.TBSPB_MOLD.IxGR_GEN;

			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
					arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();

				//------------------------------------------------------------------

				if(arg_fgrid.Name == "fgrid_Multi")
				{
					if(arg_fgrid[i + 1, _IxGen_Value].ToString() == "ME" )continue;
						//|| arg_fgrid[i + 1, _IxGen_Value].ToString() == "WO") continue;

					arg_fgrid.Rows[i + 1].Visible = false;
				}
 
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

			arg_fgrid.Cols[_IxTotal].Visible = false;

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


			if(arg_fgrid.Name == "fgrid_Multi")
			{
				for(int l=0; l<=(int)ClassLib.TBSPB_MOLD.IxGR_GEN; l++)
				{
					arg_fgrid.Cols[l].Visible = false;
				}


				#region 그리드 헤드 변경

				for(int i=_Ix_gen_s; i<_Ix_gen_e; i++)
				{
					arg_fgrid[i, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "MOLD SIZE";
				}

				#endregion

				
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].Visible = true;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].Width = 80;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].Visible =true;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].Visible =true;
			}
			else
			{
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_TYPE].Width = 95;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_HALF].Width = 30;
			}



		}


		private void Set_Grid_Data()
		{
			this.Cursor = Cursors.WaitCursor;
			fgrid_Mold.Rows.Count = _Ix_gen_e;
			
			string arg_division = "ALL";

			if( cmb_mold_type.SelectedIndex > 0 )
				arg_division = "SCT";


			  

			string arg_factory = cmb_Factory.SelectedValue.ToString();
			string arg_mold_type = cmb_mold_type.SelectedValue.ToString();

			DataTable dt = Select_SPB_Mold(arg_division);


			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;


			string rowcheck = "";
			string newrow = "";
			
			

			for(int i=0; i<rowcount; i++)
			{
				newrow = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_FACTORY].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_STATUS].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_TYPE].ToString()
				    + dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_HALF].ToString();

				if(rowcheck != newrow)
				{
					int fgrid_row = fgrid_Mold.Rows.Count;
					
					fgrid_Mold.Rows.Add();

					

					//Factory
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_FACTORY] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_FACTORY].ToString();
					
					//MOLD_CD
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_CD].ToString();

					//SPEC_CD
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SPEC_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SPEC_CD].ToString();

					//HALF
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_HALF] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_HALF].ToString();

					//MOLD_STATUS

					string mold_type = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_STATUS].ToString();
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS] 
						= mold_type;



					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SYSTEM_YN].ToString();


					//MOLD_TYPE
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_STATUS_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MTYPE].ToString();

					//MOLD_TYPE
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_TYPE] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_TYPE].ToString();

					//MSIZE_YN
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MSIZE_YN].ToString();

					//MUSE_YN
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MUSE_YN].ToString();

					//SUM_QTY
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SUM_QTY] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();

					//GEN
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_GEN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_GEN].ToString();

					//HALF_DIV code
					fgrid_Mold[fgrid_row, fgrid_Mold.Cols.Count-1] 
						=  dt.Rows[i].ItemArray[10].ToString();

					string arg_gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_GEN].ToString();
					string arg_cs_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_CS_SIZE].ToString();
					string arg_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();

					Set_Mold_Size(arg_gen, arg_cs_size, fgrid_row, arg_qty);

					rowcheck = newrow;
				}
				else
				{
					int fgrid_row = fgrid_Mold.Rows.Count-1;

					int sum_qty = 0;
					
					try
					{
						sum_qty = int.Parse(fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SUM_QTY].ToString());
					}
					catch
					{
						sum_qty = 0;
					}
					
					string aa = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();

					try
					{
						sum_qty = sum_qty + int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString());	
					}
					catch{}
					
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SUM_QTY] = sum_qty.ToString();

					string arg_gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_GEN].ToString();
					string arg_cs_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_CS_SIZE].ToString();
					string arg_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();


					Set_Mold_Size(arg_gen, arg_cs_size, fgrid_row, arg_qty);
				}




				for(int j=_Ix_gen_e; j<fgrid_Mold.Rows.Count;j++)
				{
					if(fgrid_Mold[j,(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString() == "Y" || fgrid_Mold[j,(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString() == "Y")
					{
						fgrid_Mold.Rows[j].AllowEditing = false;
					}
				}


			}


			this.Cursor = Cursors.Default;


		}


		private void Set_Mold_Size(string arg_gen, string arg_cs_size, int arg_row, string arg_qty)
		{
			_Ix_size_e = fgrid_Mold.Cols.Count-1;

			int i;

			for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
			{
				if(fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == arg_gen)
				{
					break;
				}
			}

			for(int j=_Ix_size_s; j<_Ix_size_e; j++)
			{
				if( fgrid_Mold[i,j].ToString() == arg_cs_size )
				{
					fgrid_Mold[arg_row, j] = arg_qty;
				}
				else
				{
					if(fgrid_Mold[arg_row, j] == null || fgrid_Mold[arg_row, j].ToString() == "")
					{
						fgrid_Mold[arg_row, j] = "";
					}
				}
			}
		}


		public void Show_Mold_Status()
		{
			txt_status.Text = "";
			DataTable dt = Select_Status_Name(cmb_Factory.SelectedValue.ToString());
			int rowcount = dt.Rows.Count;

			string status = "";

			for(int i=0; i<rowcount; i++)
			{
				if(i==0)
				{
					status = dt.Rows[i].ItemArray[0].ToString();
				}
				else
				{
					status += ", " + dt.Rows[i].ItemArray[0].ToString();
				}
			}

			txt_status.Text = status;

			fgrid_Mold.Set_Grid("SPB_MOLD", "1", 1, ClassLib.ComVar.This_Lang, false);
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold);

			//fgrid_Mold.Cols.Frozen = 11;
 
			fgrid_Multi.Rows.Count = _Ix_gen_e;

		}


		private void Save_SBP_Mold()
		{
			_Ix_size_e = fgrid_Mold.Cols.Count-1;

			int row_count = fgrid_Mold.Rows.Count;

			for(int i=_Ix_gen_e; i<row_count; i++)
			{
				if(fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "U" 
					|| fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "I"
					|| fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "D")
				{

					for(int j=_Ix_size_s; j<_Ix_size_e; j++)
					{
						if(fgrid_Mold[i,j].ToString() != "")
						{
						
							string[] ArrayItem = new string[13];
							ArrayItem[0] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString();
							ArrayItem[1] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString();
							ArrayItem[2] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
							ArrayItem[3] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();
							ArrayItem[4] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString();
							ArrayItem[5] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString();

							string gen = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();
							ArrayItem[6] = Bring_CS_Size(gen, j);

							//string half_div = fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString();
							string div = ":";
							//string[] half_divs = half_div.Split(div.ToCharArray());
							//ArrayItem[7] = half_divs[0].Trim();
							ArrayItem[7] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString();

							string status = fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].ToString();
							string[] status_split = status.Split(div.ToCharArray());
							ArrayItem[8] = status_split[0].Trim();
							//ArrayItem[8] = fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_STATUS_CD].ToString();

							//string type = fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxIxGR_STATUS_CD].ToString();
							//string[] type_split = type.Split(div.ToCharArray());
							ArrayItem[9] = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_STATUS_CD].ToString();

							ArrayItem[10] = fgrid_Mold[i, j].ToString();
							ArrayItem[11] = fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString();
							ArrayItem[12] = ClassLib.ComVar.This_User;

							

							Save_SPB_Mold(ArrayItem);
						}
					}
				}
			}
		}


		private string Bring_CS_Size(string arg_gen, int arg_sct_col)
		{
			int i;

			for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == arg_gen)
				{
					break;
				}
			}

			return fgrid_Mold[i, arg_sct_col].ToString();
		}


		private void Insert_SPB_MOLD()
		{
			try
			{
				int sct_row = fgrid_Mold.Selection.r1;

				if(fgrid_Mold[sct_row, 0].ToString() == "S")
					return;

				string[] InsertItem = new string[11];
				InsertItem[0] = "I";
				InsertItem[1] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString();
				InsertItem[2] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
				InsertItem[3] = Select_Mold_Status_User(ClassLib.ComVar.This_Factory);//fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].ToString();
				InsertItem[4] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_STATUS_CD].ToString();
				InsertItem[5] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_TYPE].ToString();
				InsertItem[6] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString();
				InsertItem[7] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString();
				InsertItem[8] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString();
				InsertItem[9] = "0";
				InsertItem[10] = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();


				fgrid_Mold.AddItem(InsertItem,sct_row+1,0);

				fgrid_Mold[sct_row+1, fgrid_Mold.Cols.Count-1] = "";

			

				for(int i=_Ix_size_s; i<_Ix_size_e; i++)
				{
					fgrid_Mold[sct_row+1, i] = "";
				}

				fgrid_Mold.Rows[sct_row].AllowEditing = false;
				fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].AllowEditing = true;

				fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].AllowEditing = true;

				fgrid_Mold.AutoSizeRow(sct_row+1);
				fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].AllowEditing = false;
			}
			catch
			{
				ClassLib.ComFunction.User_Message("You can not add Users Mold Status");
			}
		}


		private void Sum_Qty()
		{
			Cursor = Cursors.WaitCursor;

			string new_check = "";
			string old_check = "";


			int check=0;

			string insert_row = "";

			for(int i=_Ix_gen_e; i<fgrid_Mold.Rows.Count; i++)
			{
				new_check = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString() + fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString(); 
				
				if(old_check != new_check)
				{
					check++;

					if(check > 1)
					{
						insert_row = insert_row + i.ToString() + "/";
					}

					old_check = new_check;
					check = 0;

				}
				else
				{
					check++;
				}
			}




			string div = "/";
			string[] insert_rows = insert_row.Split(div.ToCharArray());
			int row = 0;

			for(int i = 0; i<insert_rows.Length; i++)
			{
				if(insert_rows[i] != "")
				{
					int new_row = int.Parse(insert_rows[i].Trim()) + row;
					string[] ArrayItem = new string[11];
					ArrayItem[0] = "S";
					ArrayItem[1] = fgrid_Mold[new_row-1,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString();
					ArrayItem[2] = fgrid_Mold[new_row-1,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
					ArrayItem[3] = "Status Sum";
					ArrayItem[4] = "";
					ArrayItem[5] = "";
					ArrayItem[6] = "";
					ArrayItem[7] = "";
					ArrayItem[8] = "";
					ArrayItem[9] = Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, 9);
					ArrayItem[10] = fgrid_Mold[new_row-1,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();

					fgrid_Mold.AddItem(ArrayItem, new_row, 0);
					fgrid_Mold.Rows[new_row].StyleNew.BackColor = Color.FromArgb(251, 248, 185);


					for(int k=_Ix_size_s; k<_Ix_size_e; k++)
					{
						if(Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, k) != "0")
						{
							fgrid_Mold[new_row, k] = Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, k);
						}
					}
					row++;
				}
			}

			Cursor = Cursors.Default;

			for(int i=_Ix_gen_e; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i,0].ToString() != "N")
				{
					fgrid_Mold.Rows[i].AllowEditing = false;
				}
			}
		}


		private string Mold_Type_Sum_Qty(string arg_code, int arg_row, int arg_col)
		{
			int i = 1;
			string old_code = "";

			int sum_qty = 0;
			while(true)
			{
				old_code = fgrid_Mold[arg_row - i,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString() + fgrid_Mold[arg_row - i,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
				

				if(old_code == arg_code)
				{
					fgrid_Mold.Rows[arg_row - i].StyleNew.BackColor = Color.FromArgb(217, 250, 216);
					try
					{
						sum_qty = sum_qty + int.Parse(fgrid_Mold[arg_row - i,arg_col].ToString());
					}
					catch
					{
					}

					i++;
				}
				else
				{
					break;
				}
			}

			return sum_qty.ToString();
		}


		private void Set_Grid_FstSize (object sender , EventArgs e)
		{
			fgrid_Multi[_Ix_gen_e, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = "U";	
			string arg_fst_size = ((MenuItem)sender).Text;

			for(int i=sct_start; i<= sct_stop;i++)
			{
				fgrid_Multi[_Ix_gen_e, i] = arg_fst_size;
				fgrid_Multi[_Ix_gen_e+1, i] = 0;
				fgrid_Multi[_Ix_gen_e+2, i] = 0;

				
			}
			for(int j=_Ix_size_s; j<_Ix_size_e; j++)
			{
				if(fgrid_Multi[_Ix_gen_e, j] != null)
				{
					Auto_Set_Data(j);
				}
			}
		}


		/// <summary>
		/// Show_Gen_Size : 선택된 GEN의 사이즈만 그리드여 보여줌(fgrid_Multi)
		/// </summary>
		/// <param name="arg_gen"></param>
		private void Show_Gen_Size(string arg_gen)
		{
			for(int i=_Ix_gen_s; i<_Ix_gen_e; i++)
			{
				if(fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == arg_gen)
				{
					fgrid_Multi.Rows[i].Visible = true;
				}
				else
				{
					fgrid_Multi.Rows[i].Visible = false;
				}
			}
		}




		private void Fgrid_Data_Save()
		{
			fgrid_Multi.Select(fgrid_Multi.Selection.r1, 0, fgrid_Multi.Selection.r1, fgrid_Multi.Cols.Count-1, false);

			string col_name = "";

			try
			{
				//MessageBox.Show(fgrid_Multi[_Ix_gen_e,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString());
				if(fgrid_Multi[_Ix_gen_e,(int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "U")
				{
					int row = fgrid_Multi.Rows.Count-1;

					string arg_yn_check = "Y";
//					string col_name = "";


					try
					{
						string div = ":";
						string arg_factory = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString();
						string arg_mold_cd = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
						string arg_cs_size = "";
						string arg_half = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_HALF].ToString();
						//string[] arg_half_div = arg_half.Split(div.ToCharArray());


						string arg_status = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].ToString();
						
						string[] arg_code = arg_status.Split(div.ToCharArray());
					

						string arg_type  =  fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_STATUS_CD].ToString();
						string[] arg_typecode = arg_type.Split(div.ToCharArray());


						string arg_gen = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();
						string arg_fst_size = "";
						string arg_msize_yn = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString();
						string arg_muse_yn = fgrid_Multi[_Ix_gen_e+3, (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString();
						string arg_pairs = "";
						string arg_sum_qty = "0";
						string arg_avail_onpress = "";
					
					



						if(sct_type == "MSIZEYN")
						{
							arg_yn_check = arg_msize_yn;
							col_name = "MSIZE_YN";
						}
						else
						{
							arg_yn_check = arg_muse_yn;
							col_name = "MUSE_YN";
						}



						for(int i=_Ix_size_s; i<_Ix_size_e; i++)
						{
							if(fgrid_Multi[_Ix_gen_e+3, i].ToString() != "" && fgrid_Multi[_Ix_gen_e+3, i]!= null)
							{
								
								arg_cs_size = Bring_CS_Size(arg_gen, i);
								arg_sum_qty = fgrid_Multi[_Ix_gen_e+3,i].ToString();
								
								try
								{
									arg_fst_size = fgrid_Multi[_Ix_gen_e, i].ToString();
									arg_pairs    = fgrid_Multi[_Ix_gen_e+1,i].ToString();
									arg_avail_onpress = fgrid_Multi[_Ix_gen_e+2,i].ToString();
								}
								catch
								{
									arg_fst_size = "0";
									arg_pairs    = "0";
									arg_avail_onpress = "0";
								}
								Save_SPB_Mold_FstSize(arg_factory,            arg_mold_cd,  arg_cs_size,  arg_half, arg_code[0].Trim(),
									arg_type, arg_gen,      arg_fst_size, arg_msize_yn, arg_muse_yn,
									arg_pairs,              arg_sum_qty,  arg_avail_onpress );
							}
						}

					}
					catch
					{
					}
				}
			}
			catch
			{
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
		/// Select_SPB_Mold : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_select_ymd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_Mold(string arg_division)
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_SPB_MOLD";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIVISION";
			oraDB.Parameter_Name[2] = "ARG_MOLD_TYPE";
			oraDB.Parameter_Name[3] = "ARG_CONDITION";
			oraDB.Parameter_Name[4] = "ARG_SUBJECT";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_division;
			oraDB.Parameter_Values[2] = cmb_mold_type.SelectedValue.ToString();
			oraDB.Parameter_Values[3] = cmb_condition.SelectedValue.ToString();


			string subject = txt_subject.Text.Trim();

			if(subject.Length == 0)
			{
				subject = "ALL";
			}

			oraDB.Parameter_Values[4] = subject;
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}




		/// <summary>
		/// Select_Status_Name : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private DataTable Select_Status_Name(string arg_factory)
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_SPB_MOLD_STATUS_NAME";

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


		private void Save_SPB_Mold(string[] arg_arrayitem)
		{
			string Proc_Name = "PKG_SPB_MOLD.SAVE_SPB_MOLD";

			oraDB.ReDim_Parameter(arg_arrayitem.Length);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[3] = "ARG_GEN";
			oraDB.Parameter_Name[4] = "ARG_MSIZE_YN";
			oraDB.Parameter_Name[5] = "ARG_MUSE_YN";
			oraDB.Parameter_Name[6] = "ARG_CS_SIZE";
			oraDB.Parameter_Name[7] = "ARG_HALF";
			oraDB.Parameter_Name[8] = "ARG_MOLD_STATUS";
			oraDB.Parameter_Name[9] = "ARG_MOLD_TYPE";
			oraDB.Parameter_Name[10] = "ARG_SUM_QTY";
			oraDB.Parameter_Name[11] = "ARG_TEMP_HALF";
			oraDB.Parameter_Name[12] = "ARG_UPD_USER";

			for(int i=0; i<arg_arrayitem.Length; i++)
			{
				oraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}

			for(int j=0; j<arg_arrayitem.Length; j++)
			{
				oraDB.Parameter_Values[j] = arg_arrayitem[j];
			}

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}



		/// <summary>
		/// Select_SPB_Mold_FstSize : 특정 Mold의 FST_SIZE 가져오기
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_mold_cd"></param>
		/// <param name="arg_half"></param>
		/// <param name="arg_Mold_status"></param>
		/// <returns></returns>
		private DataTable Select_SPB_Mold_FstSize(string arg_factory, string arg_mold_cd, string arg_half, string arg_Mold_status)
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_SPB_MOLD_FST_SIZE";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[2] = "ARG_HALF";
			oraDB.Parameter_Name[3] = "ARG_MOLD_STATUS";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_mold_cd;
			oraDB.Parameter_Values[2] = arg_half;
			oraDB.Parameter_Values[3] = arg_Mold_status;
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		/// <summary>
		/// Save_SPB_Mold_FstSize : 특정 Mold의 FST_SIZE 저장하기
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_mold_cd"></param>
		/// <param name="arg_half"></param>
		/// <param name="arg_Mold_status"></param>
		/// <returns></returns>
		private void Save_SPB_Mold_FstSize( string arg_factory,  string arg_mold_cd,     string arg_cs_size,
											string arg_half_div, string arg_mold_status, string arg_mold_type,
											string arg_gen,      string arg_fst_size,    string arg_msize_yn,
											string arg_muse_yn,  string arg_pairs,       string arg_sum_qty,
											string arg_avail_onpress )
		{
			string Proc_Name = "PKG_SPB_MOLD.SAVE_SPB_MOLD_FSTSIZE";

			oraDB.ReDim_Parameter(14);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[2] = "ARG_CS_SIZE";
			oraDB.Parameter_Name[3] = "ARG_HALF_DIV";
			oraDB.Parameter_Name[4] = "ARG_MOLD_STATUS";

			oraDB.Parameter_Name[5] = "ARG_MOLD_TYPE";
			oraDB.Parameter_Name[6] = "ARG_GEN";
			oraDB.Parameter_Name[7] = "ARG_FST_SIZE";
			oraDB.Parameter_Name[8] = "ARG_MSIZE_YN";
			oraDB.Parameter_Name[9] = "ARG_MUSE_YN";
			oraDB.Parameter_Name[10] = "ARG_PAIRS";
			oraDB.Parameter_Name[11] = "ARG_SUM_QTY";
			oraDB.Parameter_Name[12] = "ARG_AVAIL_ONPRESS";
			oraDB.Parameter_Name[13] = "ARG_UPD_USER";



			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[9] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[12] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[13] = (int)OracleType.VarChar;



			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_mold_cd;
			oraDB.Parameter_Values[2] = arg_cs_size;
			oraDB.Parameter_Values[3] = arg_half_div;
			oraDB.Parameter_Values[4] = arg_mold_status;

			oraDB.Parameter_Values[5] = arg_mold_type;
			oraDB.Parameter_Values[6] = arg_gen;
			oraDB.Parameter_Values[7] = arg_fst_size;
			oraDB.Parameter_Values[8] = arg_msize_yn;
			oraDB.Parameter_Values[9] = arg_muse_yn;
			oraDB.Parameter_Values[10] = arg_pairs;
			oraDB.Parameter_Values[11] = arg_sum_qty;
			oraDB.Parameter_Values[12] = arg_avail_onpress;
			oraDB.Parameter_Values[13] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}



		private string Select_Mold_Status_User(string arg_factory)
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_MOLD_STATUS_USER";

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
			
			return  DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
		}



		/// <summary>
		/// Select_Mold_System_YN : 몰드의 상태중 수정 여부 결정
		/// </summary>
		/// <param name="arg_mold_type_code">몰드 타입 코드</param>
		/// <returns>Y:병경 불가능 N:변경 가능</returns>
		private string Select_Mold_System_YN(string arg_factory, string arg_mold_type_code)
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_MOLD_SYSTEM_YN";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MOLDSTATUS";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_mold_type_code;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
		}



		private DataTable Select_Mold_Inven_Fst(string arg_factory, string arg_mold_cd, string arg_mold_status)
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_SPB_MOLD_INVEN_FST";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[2] = "ARG_MOLD_STATUS";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_mold_cd;
			oraDB.Parameter_Values[2] = arg_mold_status;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private bool Run_Proc(string arg_factory)
		{

			string Proc_Name = "SP_SPB_MOLD";

			oraDB.ReDim_Parameter(1);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "AEG_FACTORY";
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Values[0] = arg_factory;

			oraDB.Add_Run_Parameter(true);

			if(oraDB.Exe_Run_Procedure() == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}


		#endregion

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Show_Mold_Status();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			if(fgrid_Mold.Rows.Count < _Ix_gen_e+1) return;


			fgrid_Mold.Rows.Remove(fgrid_Mold.Rows.Count-1);

			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

			fgrid_Mold.SaveGrid(filename, FileFormatEnum.TextComma);

			string mold_type = cmb_mold_type.Columns[1].Text;

			string mold_status = txt_status.Text;

			//Form_Report_Mold report = new Form_Report_Mold(filename, mold_type, mold_status);
			//report.ShowDialog();

			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_MTYPE[" +mold_type
				+ "] V_MSTATUS[" + mold_status + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("MOLD INVENTORY", this.Name +".mrd", para);
			report.ShowDialog();
		}

		private void btn_Run_Click(object sender, System.EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			if(Run_Proc(ClassLib.ComVar.This_Factory))
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
			}
			else
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
			}
			this.Cursor = Cursors.Default;


			fgrid_Mold.Rows.Count = _Ix_gen_e;
			fgrid_Multi.Rows.Count = _Ix_gen_e;

		}

		private void btn_sct_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopPgId.ImageIndex = 7;
		}

		private void btn_sct_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopPgId.ImageIndex = 6;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Insert_SPB_MOLD();
		}

		
	}
}

