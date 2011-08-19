using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.ErpCom
{
	public class Form_PS_Message_Regist : COM.APSWinForm.Pop_Large
	{
		public System.Windows.Forms.Panel pnl_Semlpe;
		private System.Windows.Forms.Label lbl_msg_code;
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
		private System.Windows.Forms.TextBox txt_mgs_text_k;
		private System.Windows.Forms.Label lbl_mgs_text_k;
		private System.Windows.Forms.TextBox txt_mgs_text_e;
		private System.Windows.Forms.Label lbl_mgs_text_e;
		public C1.Win.C1List.C1Combo cmb_msg_button;
		private System.Windows.Forms.Label lbl_msg_icon;
		public C1.Win.C1List.C1Combo cmb_mgs_icon;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1CommandLink c1CommandLink2;
		private C1.Win.C1Command.C1Command tbtn_clear;
		private System.Windows.Forms.TextBox txt_mgs_code;
		private System.Windows.Forms.Label lbl_mgs_button;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;



		#region 사용자 변수

		private COM.OraDB oraDB = null;
		private System.Windows.Forms.Label lbl_k_caption;
		private System.Windows.Forms.TextBox txt_k_caption;
		private System.Windows.Forms.Label lbl_e_caption;
		private System.Windows.Forms.TextBox txt_e_caption;
		private System.Windows.Forms.Label lbl_msg_button;
		private Form_PS_Message_List frm = null;
		#endregion

		public Form_PS_Message_Regist(Form_PS_Message_List arg_frm)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			frm = arg_frm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PS_Message_Regist));
			this.pnl_Semlpe = new System.Windows.Forms.Panel();
			this.txt_e_caption = new System.Windows.Forms.TextBox();
			this.lbl_e_caption = new System.Windows.Forms.Label();
			this.txt_k_caption = new System.Windows.Forms.TextBox();
			this.lbl_k_caption = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_mgs_button = new System.Windows.Forms.Label();
			this.cmb_mgs_icon = new C1.Win.C1List.C1Combo();
			this.lbl_msg_icon = new System.Windows.Forms.Label();
			this.lbl_msg_button = new System.Windows.Forms.Label();
			this.cmb_msg_button = new C1.Win.C1List.C1Combo();
			this.lbl_mgs_text_e = new System.Windows.Forms.Label();
			this.txt_mgs_text_e = new System.Windows.Forms.TextBox();
			this.txt_mgs_text_k = new System.Windows.Forms.TextBox();
			this.txt_mgs_code = new System.Windows.Forms.TextBox();
			this.lbl_mgs_text_k = new System.Windows.Forms.Label();
			this.lbl_msg_code = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
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
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_clear = new C1.Win.C1Command.C1Command();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
			this.pnl_Semlpe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_mgs_icon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_msg_button)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_Semlpe
			// 
			this.pnl_Semlpe.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Semlpe.Controls.Add(this.txt_e_caption);
			this.pnl_Semlpe.Controls.Add(this.lbl_e_caption);
			this.pnl_Semlpe.Controls.Add(this.txt_k_caption);
			this.pnl_Semlpe.Controls.Add(this.lbl_k_caption);
			this.pnl_Semlpe.Controls.Add(this.label1);
			this.pnl_Semlpe.Controls.Add(this.lbl_mgs_button);
			this.pnl_Semlpe.Controls.Add(this.cmb_mgs_icon);
			this.pnl_Semlpe.Controls.Add(this.lbl_msg_icon);
			this.pnl_Semlpe.Controls.Add(this.lbl_msg_button);
			this.pnl_Semlpe.Controls.Add(this.cmb_msg_button);
			this.pnl_Semlpe.Controls.Add(this.lbl_mgs_text_e);
			this.pnl_Semlpe.Controls.Add(this.txt_mgs_text_e);
			this.pnl_Semlpe.Controls.Add(this.txt_mgs_text_k);
			this.pnl_Semlpe.Controls.Add(this.txt_mgs_code);
			this.pnl_Semlpe.Controls.Add(this.lbl_mgs_text_k);
			this.pnl_Semlpe.Controls.Add(this.lbl_msg_code);
			this.pnl_Semlpe.Controls.Add(this.pnl_SearchImage);
			this.pnl_Semlpe.DockPadding.All = 8;
			this.pnl_Semlpe.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Semlpe.Location = new System.Drawing.Point(0, 64);
			this.pnl_Semlpe.Name = "pnl_Semlpe";
			this.pnl_Semlpe.Size = new System.Drawing.Size(696, 240);
			this.pnl_Semlpe.TabIndex = 35;
			// 
			// txt_e_caption
			// 
			this.txt_e_caption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_e_caption.Location = new System.Drawing.Point(119, 119);
			this.txt_e_caption.Name = "txt_e_caption";
			this.txt_e_caption.Size = new System.Drawing.Size(544, 21);
			this.txt_e_caption.TabIndex = 91;
			this.txt_e_caption.Text = "";
			// 
			// lbl_e_caption
			// 
			this.lbl_e_caption.ImageIndex = 0;
			this.lbl_e_caption.ImageList = this.img_Label;
			this.lbl_e_caption.Location = new System.Drawing.Point(18, 119);
			this.lbl_e_caption.Name = "lbl_e_caption";
			this.lbl_e_caption.Size = new System.Drawing.Size(100, 21);
			this.lbl_e_caption.TabIndex = 90;
			this.lbl_e_caption.Text = "메시지 제목(영)";
			this.lbl_e_caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_k_caption
			// 
			this.txt_k_caption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_k_caption.Location = new System.Drawing.Point(119, 58);
			this.txt_k_caption.Name = "txt_k_caption";
			this.txt_k_caption.Size = new System.Drawing.Size(544, 21);
			this.txt_k_caption.TabIndex = 89;
			this.txt_k_caption.Text = "";
			// 
			// lbl_k_caption
			// 
			this.lbl_k_caption.ImageIndex = 0;
			this.lbl_k_caption.ImageList = this.img_Label;
			this.lbl_k_caption.Location = new System.Drawing.Point(18, 58);
			this.lbl_k_caption.Name = "lbl_k_caption";
			this.lbl_k_caption.Size = new System.Drawing.Size(100, 21);
			this.lbl_k_caption.TabIndex = 88;
			this.lbl_k_caption.Text = "메시지 제목(한)";
			this.lbl_k_caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(119, 202);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 21);
			this.label1.TabIndex = 87;
			this.label1.Text = "MessageBoxIcon.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_mgs_button
			// 
			this.lbl_mgs_button.Location = new System.Drawing.Point(119, 180);
			this.lbl_mgs_button.Name = "lbl_mgs_button";
			this.lbl_mgs_button.Size = new System.Drawing.Size(129, 21);
			this.lbl_mgs_button.TabIndex = 86;
			this.lbl_mgs_button.Text = "MessageBoxButtons.";
			this.lbl_mgs_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_mgs_icon
			// 
			this.cmb_mgs_icon.AddItemCols = 0;
			this.cmb_mgs_icon.AddItemSeparator = ';';
			this.cmb_mgs_icon.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_mgs_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_mgs_icon.Caption = "";
			this.cmb_mgs_icon.CaptionHeight = 17;
			this.cmb_mgs_icon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_mgs_icon.ColumnCaptionHeight = 18;
			this.cmb_mgs_icon.ColumnFooterHeight = 18;
			this.cmb_mgs_icon.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_mgs_icon.ContentHeight = 17;
			this.cmb_mgs_icon.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_mgs_icon.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_mgs_icon.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_mgs_icon.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_mgs_icon.EditorHeight = 17;
			this.cmb_mgs_icon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_mgs_icon.GapHeight = 2;
			this.cmb_mgs_icon.ItemHeight = 15;
			this.cmb_mgs_icon.Location = new System.Drawing.Point(249, 202);
			this.cmb_mgs_icon.MatchEntryTimeout = ((long)(2000));
			this.cmb_mgs_icon.MaxDropDownItems = ((short)(5));
			this.cmb_mgs_icon.MaxLength = 32767;
			this.cmb_mgs_icon.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_mgs_icon.Name = "cmb_mgs_icon";
			this.cmb_mgs_icon.PartialRightColumn = false;
			this.cmb_mgs_icon.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_mgs_icon.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_mgs_icon.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_mgs_icon.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_mgs_icon.Size = new System.Drawing.Size(200, 21);
			this.cmb_mgs_icon.TabIndex = 85;
			// 
			// lbl_msg_icon
			// 
			this.lbl_msg_icon.ImageIndex = 0;
			this.lbl_msg_icon.ImageList = this.img_Label;
			this.lbl_msg_icon.Location = new System.Drawing.Point(18, 202);
			this.lbl_msg_icon.Name = "lbl_msg_icon";
			this.lbl_msg_icon.Size = new System.Drawing.Size(100, 21);
			this.lbl_msg_icon.TabIndex = 84;
			this.lbl_msg_icon.Text = "메시지 아이콘";
			this.lbl_msg_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_msg_button
			// 
			this.lbl_msg_button.ImageIndex = 0;
			this.lbl_msg_button.ImageList = this.img_Label;
			this.lbl_msg_button.Location = new System.Drawing.Point(18, 180);
			this.lbl_msg_button.Name = "lbl_msg_button";
			this.lbl_msg_button.Size = new System.Drawing.Size(100, 21);
			this.lbl_msg_button.TabIndex = 83;
			this.lbl_msg_button.Text = "메시지 버튼";
			this.lbl_msg_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_msg_button
			// 
			this.cmb_msg_button.AddItemCols = 0;
			this.cmb_msg_button.AddItemSeparator = ';';
			this.cmb_msg_button.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_msg_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_msg_button.Caption = "";
			this.cmb_msg_button.CaptionHeight = 17;
			this.cmb_msg_button.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_msg_button.ColumnCaptionHeight = 18;
			this.cmb_msg_button.ColumnFooterHeight = 18;
			this.cmb_msg_button.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_msg_button.ContentHeight = 17;
			this.cmb_msg_button.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_msg_button.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_msg_button.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_msg_button.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_msg_button.EditorHeight = 17;
			this.cmb_msg_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_msg_button.GapHeight = 2;
			this.cmb_msg_button.ItemHeight = 15;
			this.cmb_msg_button.Location = new System.Drawing.Point(249, 180);
			this.cmb_msg_button.MatchEntryTimeout = ((long)(2000));
			this.cmb_msg_button.MaxDropDownItems = ((short)(5));
			this.cmb_msg_button.MaxLength = 32767;
			this.cmb_msg_button.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_msg_button.Name = "cmb_msg_button";
			this.cmb_msg_button.PartialRightColumn = false;
			this.cmb_msg_button.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_msg_button.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_msg_button.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_msg_button.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_msg_button.Size = new System.Drawing.Size(200, 21);
			this.cmb_msg_button.TabIndex = 82;
			// 
			// lbl_mgs_text_e
			// 
			this.lbl_mgs_text_e.ImageIndex = 0;
			this.lbl_mgs_text_e.ImageList = this.img_Label;
			this.lbl_mgs_text_e.Location = new System.Drawing.Point(18, 141);
			this.lbl_mgs_text_e.Name = "lbl_mgs_text_e";
			this.lbl_mgs_text_e.Size = new System.Drawing.Size(100, 21);
			this.lbl_mgs_text_e.TabIndex = 77;
			this.lbl_mgs_text_e.Text = "메시지 내용(영)";
			this.lbl_mgs_text_e.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_mgs_text_e
			// 
			this.txt_mgs_text_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mgs_text_e.Location = new System.Drawing.Point(119, 141);
			this.txt_mgs_text_e.Multiline = true;
			this.txt_mgs_text_e.Name = "txt_mgs_text_e";
			this.txt_mgs_text_e.Size = new System.Drawing.Size(544, 38);
			this.txt_mgs_text_e.TabIndex = 76;
			this.txt_mgs_text_e.Text = "";
			// 
			// txt_mgs_text_k
			// 
			this.txt_mgs_text_k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mgs_text_k.Location = new System.Drawing.Point(119, 80);
			this.txt_mgs_text_k.Multiline = true;
			this.txt_mgs_text_k.Name = "txt_mgs_text_k";
			this.txt_mgs_text_k.Size = new System.Drawing.Size(544, 38);
			this.txt_mgs_text_k.TabIndex = 75;
			this.txt_mgs_text_k.Text = "";
			// 
			// txt_mgs_code
			// 
			this.txt_mgs_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mgs_code.Location = new System.Drawing.Point(119, 36);
			this.txt_mgs_code.Name = "txt_mgs_code";
			this.txt_mgs_code.Size = new System.Drawing.Size(210, 21);
			this.txt_mgs_code.TabIndex = 72;
			this.txt_mgs_code.Text = "";
			// 
			// lbl_mgs_text_k
			// 
			this.lbl_mgs_text_k.ImageIndex = 0;
			this.lbl_mgs_text_k.ImageList = this.img_Label;
			this.lbl_mgs_text_k.Location = new System.Drawing.Point(18, 80);
			this.lbl_mgs_text_k.Name = "lbl_mgs_text_k";
			this.lbl_mgs_text_k.Size = new System.Drawing.Size(100, 21);
			this.lbl_mgs_text_k.TabIndex = 71;
			this.lbl_mgs_text_k.Text = "메시지 내용(한)";
			this.lbl_mgs_text_k.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_msg_code
			// 
			this.lbl_msg_code.ImageIndex = 0;
			this.lbl_msg_code.ImageList = this.img_Label;
			this.lbl_msg_code.Location = new System.Drawing.Point(18, 36);
			this.lbl_msg_code.Name = "lbl_msg_code";
			this.lbl_msg_code.Size = new System.Drawing.Size(100, 21);
			this.lbl_msg_code.TabIndex = 70;
			this.lbl_msg_code.Text = "코드";
			this.lbl_msg_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
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
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(680, 224);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(665, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 184);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(664, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(456, 32);
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
			this.lbl_SubTitle1.Text = "      Message Box Registration";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(664, 208);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 206);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(520, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 204);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 184);
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
			this.picb_MM.Size = new System.Drawing.Size(512, 184);
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
			// c1ToolBar1
			// 
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink2);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(628, 8);
			this.c1ToolBar1.MinButtonSize = 30;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(60, 30);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_clear);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_save
			// 
			this.tbtn_save.ImageIndex = 6;
			this.tbtn_save.Name = "tbtn_save";
			this.tbtn_save.Text = "Save";
			this.tbtn_save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_save_Click);
			// 
			// tbtn_clear
			// 
			this.tbtn_clear.ImageIndex = 12;
			this.tbtn_clear.Name = "tbtn_clear";
			this.tbtn_clear.Text = "Clear";
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.tbtn_save;
			// 
			// c1CommandLink2
			// 
			this.c1CommandLink2.Command = this.tbtn_clear;
			// 
			// Form_PS_Message_Regist
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 304);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.pnl_Semlpe);
			this.Name = "Form_PS_Message_Regist";
			this.Text = "Message Box Regist";
			this.Load += new System.EventHandler(this.Form_Message_Regist_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_Semlpe, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.pnl_Semlpe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_mgs_icon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_msg_button)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Message_Regist_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{

			this.Text = "Message Box Regist";
			this.lbl_MainTitle.Text = "Message Box Regist";
			ClassLib.ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();
			cmb_list_mgs_button(cmb_msg_button);
			cmb_msg_button.SelectedIndex = 0;

			cmb_list_mgs_icon(cmb_mgs_icon);
			cmb_mgs_icon.SelectedIndex = 0;
		}

		private void cmb_list_mgs_button(C1.Win.C1List.C1Combo arg_cmb)
		{
			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
			temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
			temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

			newrow = temp_datatable.NewRow();
			newrow["Code"] = MessageBoxButtons.AbortRetryIgnore.GetHashCode().ToString();
			newrow["Name"] = "AbortRetryIgnore";
			temp_datatable.Rows.Add(newrow);


			newrow = temp_datatable.NewRow();
			newrow["Code"] = MessageBoxButtons.OK.GetHashCode().ToString();
			newrow["Name"] = "OK";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = MessageBoxButtons.OKCancel.GetHashCode().ToString();
			newrow["Name"] = "OKCancel";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = MessageBoxButtons.RetryCancel.GetHashCode().ToString();
			newrow["Name"] = "RetryCancel";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = MessageBoxButtons.YesNo.GetHashCode().ToString();
			newrow["Name"] = "YesNo";
			temp_datatable.Rows.Add(newrow);


			newrow = temp_datatable.NewRow();
			newrow["Code"] = MessageBoxButtons.YesNoCancel.GetHashCode().ToString();
			newrow["Name"] = "YesNoCancel";
			temp_datatable.Rows.Add(newrow);



			arg_cmb.DataSource = null; 
			arg_cmb.DataSource = temp_datatable;
			
			arg_cmb.ValueMember = "Code";
			arg_cmb.DisplayMember = "Name"; 

			arg_cmb.SelectedIndex = -1;
			arg_cmb.MaxDropDownItems = 10;
			arg_cmb.Splits[0].DisplayColumns["Code"].Width = 50;
			arg_cmb.Splits[0].DisplayColumns["Name"].Width = 150;
			arg_cmb.ExtendRightColumn = true; 
		}

		private void cmb_list_mgs_icon(C1.Win.C1List.C1Combo arg_cmb)
		{
			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
			temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
			temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
			
			newrow = temp_datatable.NewRow();
			newrow["Code"] = "0";
			newrow["Name"] = "None";
			temp_datatable.Rows.Add(newrow);
			
			newrow = temp_datatable.NewRow();
			newrow["Code"] = "1";
			newrow["Name"] = "Information";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "2";
			newrow["Name"] = "Error";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "3";
			newrow["Name"] = "Warning";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "4";
			newrow["Name"] = "Question";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "5";
			newrow["Name"] = "Hand";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "6";
			newrow["Name"] = "Stop";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "7";
			newrow["Name"] = "Asterisk";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "8";
			newrow["Name"] = "Exclamation";
			temp_datatable.Rows.Add(newrow);

			arg_cmb.DataSource = null; 
			arg_cmb.DataSource = temp_datatable;
			
			arg_cmb.ValueMember = "Code";
			arg_cmb.DisplayMember = "Name"; 

			arg_cmb.SelectedIndex = -1;
			arg_cmb.MaxDropDownItems = 10;
			arg_cmb.Splits[0].DisplayColumns["Code"].Width = 50;
			arg_cmb.Splits[0].DisplayColumns["Name"].Width = 150;
			arg_cmb.ExtendRightColumn = true; 
		}

		#region 이벤트


		private void tbtn_save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(txt_mgs_code.Text.Length == 0)
			{
				MessageBox.Show("코드를 입력 하셔야 합니다.");
				txt_mgs_code.Focus();
				return;
			}

			string arg_code   = txt_mgs_code.Text;
			string arg_k_cap  = txt_k_caption.Text;
			string arg_k_mess = txt_mgs_text_k.Text;
			string arg_e_cap  = txt_e_caption.Text;
			string arg_e_mess = txt_mgs_text_e.Text;
			string arg_button = cmb_msg_button.SelectedValue.ToString();
			string arg_icon   = cmb_mgs_icon.SelectedValue.ToString();

			Insert_SPC_Message("I", arg_code, arg_k_cap, arg_k_mess, arg_e_cap, arg_e_mess, arg_button, arg_icon);

			frm.Get_Grid_List("U","");

			Close();

		}
		#endregion


		#region DB접속

		private void Insert_SPC_Message(string arg_division, string arg_msg_code, string arg_k_cap, string arg_msg_k_mess, string arg_e_cap, string arg_msg_e_mess, string arg_msg_button, string arg_msg_icon)
		{
			string Proc_Name = "PKG_SPC_MESSAGE.SAVE_SPC_MESSAGE";
			
					
			oraDB.ReDim_Parameter(9);
			oraDB.Process_Name = Proc_Name;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_MSG_CODE";
			oraDB.Parameter_Name[2] = "ARG_MSG_K_CAPTION";
			oraDB.Parameter_Name[3] = "ARG_MSG_K_STRING";
			oraDB.Parameter_Name[4] = "ARG_MSG_E_CAPTION";
			oraDB.Parameter_Name[5] = "ARG_MSG_E_STRING";
			oraDB.Parameter_Name[6] = "ARG_MSG_BUTTON";
			oraDB.Parameter_Name[7] = "ARG_MSG_ICON";
			oraDB.Parameter_Name[8] = "ARG_UPD_USER";


			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[8] = (int)OracleType.VarChar;


			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = arg_msg_code;
			oraDB.Parameter_Values[2] = arg_k_cap;
			oraDB.Parameter_Values[3] = arg_msg_k_mess;
			oraDB.Parameter_Values[4] = arg_e_cap;
			oraDB.Parameter_Values[5] = arg_msg_e_mess;
			oraDB.Parameter_Values[6] = arg_msg_button;
			oraDB.Parameter_Values[7] = arg_msg_icon;
			oraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();

		}

		#endregion
	}
}

