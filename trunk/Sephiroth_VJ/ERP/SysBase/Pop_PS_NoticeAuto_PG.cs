using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeAuto_PG : COM.APSWinForm.Pop_Small
	{
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1Command tbtn_save;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 변수

		private COM.OraDB oraDB = null;
		private Pop_PS_NoticeAuto_Admin frm = null;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_proj;
		private System.Windows.Forms.Label lbl_proj;
		private C1.Win.C1List.C1Combo cmb_pg_id;
		private System.Windows.Forms.Label lbl_pg_id;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_cencal;
		private string factroy;

		#endregion

		public Pop_PS_NoticeAuto_PG(Pop_PS_NoticeAuto_Admin arg_frm, string arg_factory)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			frm = arg_frm;
			factroy = arg_factory;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeAuto_PG));
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.cmb_proj = new C1.Win.C1List.C1Combo();
			this.lbl_proj = new System.Windows.Forms.Label();
			this.cmb_pg_id = new C1.Win.C1List.C1Combo();
			this.lbl_pg_id = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_cencal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_proj)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pg_id)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_save
			// 
			this.tbtn_save.Name = "tbtn_save";
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(275, 21);
			this.cmb_factory.TabIndex = 234;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 233;
			this.lbl_factory.Text = "공장";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_proj
			// 
			this.cmb_proj.AddItemCols = 0;
			this.cmb_proj.AddItemSeparator = ';';
			this.cmb_proj.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_proj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_proj.Caption = "";
			this.cmb_proj.CaptionHeight = 17;
			this.cmb_proj.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_proj.ColumnCaptionHeight = 18;
			this.cmb_proj.ColumnFooterHeight = 18;
			this.cmb_proj.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_proj.ContentHeight = 17;
			this.cmb_proj.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_proj.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_proj.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_proj.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_proj.EditorHeight = 17;
			this.cmb_proj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_proj.GapHeight = 2;
			this.cmb_proj.ItemHeight = 15;
			this.cmb_proj.Location = new System.Drawing.Point(109, 62);
			this.cmb_proj.MatchEntryTimeout = ((long)(2000));
			this.cmb_proj.MaxDropDownItems = ((short)(5));
			this.cmb_proj.MaxLength = 32767;
			this.cmb_proj.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_proj.Name = "cmb_proj";
			this.cmb_proj.PartialRightColumn = false;
			this.cmb_proj.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_proj.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_proj.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_proj.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_proj.Size = new System.Drawing.Size(275, 21);
			this.cmb_proj.TabIndex = 238;
			this.cmb_proj.SelectedValueChanged += new System.EventHandler(this.cmb_proj_SelectedValueChanged);
			// 
			// lbl_proj
			// 
			this.lbl_proj.ImageIndex = 0;
			this.lbl_proj.ImageList = this.img_Label;
			this.lbl_proj.Location = new System.Drawing.Point(8, 62);
			this.lbl_proj.Name = "lbl_proj";
			this.lbl_proj.Size = new System.Drawing.Size(100, 21);
			this.lbl_proj.TabIndex = 237;
			this.lbl_proj.Text = "소속 프로잭트";
			this.lbl_proj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_pg_id
			// 
			this.cmb_pg_id.AddItemCols = 0;
			this.cmb_pg_id.AddItemSeparator = ';';
			this.cmb_pg_id.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_pg_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_pg_id.Caption = "";
			this.cmb_pg_id.CaptionHeight = 17;
			this.cmb_pg_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_pg_id.ColumnCaptionHeight = 18;
			this.cmb_pg_id.ColumnFooterHeight = 18;
			this.cmb_pg_id.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_pg_id.ContentHeight = 17;
			this.cmb_pg_id.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_pg_id.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_pg_id.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pg_id.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_pg_id.EditorHeight = 17;
			this.cmb_pg_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pg_id.GapHeight = 2;
			this.cmb_pg_id.ItemHeight = 15;
			this.cmb_pg_id.Location = new System.Drawing.Point(109, 84);
			this.cmb_pg_id.MatchEntryTimeout = ((long)(2000));
			this.cmb_pg_id.MaxDropDownItems = ((short)(5));
			this.cmb_pg_id.MaxLength = 32767;
			this.cmb_pg_id.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_pg_id.Name = "cmb_pg_id";
			this.cmb_pg_id.PartialRightColumn = false;
			this.cmb_pg_id.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_pg_id.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_pg_id.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_pg_id.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_pg_id.Size = new System.Drawing.Size(275, 21);
			this.cmb_pg_id.TabIndex = 240;
			// 
			// lbl_pg_id
			// 
			this.lbl_pg_id.ImageIndex = 0;
			this.lbl_pg_id.ImageList = this.img_Label;
			this.lbl_pg_id.Location = new System.Drawing.Point(8, 84);
			this.lbl_pg_id.Name = "lbl_pg_id";
			this.lbl_pg_id.Size = new System.Drawing.Size(100, 21);
			this.lbl_pg_id.TabIndex = 239;
			this.lbl_pg_id.Text = "적용 Program";
			this.lbl_pg_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(8, 112);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 241;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_cencal
			// 
			this.btn_cencal.ImageIndex = 10;
			this.btn_cencal.ImageList = this.imgs_new_btn;
			this.btn_cencal.Location = new System.Drawing.Point(304, 112);
			this.btn_cencal.Name = "btn_cencal";
			this.btn_cencal.Size = new System.Drawing.Size(80, 23);
			this.btn_cencal.TabIndex = 254;
			this.btn_cencal.Click += new System.EventHandler(this.btn_cencal_Click);
			// 
			// Pop_PS_NoticeAuto_PG
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 144);
			this.Controls.Add(this.btn_cencal);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.cmb_pg_id);
			this.Controls.Add(this.lbl_pg_id);
			this.Controls.Add(this.cmb_proj);
			this.Controls.Add(this.lbl_proj);
			this.Controls.Add(this.cmb_factory);
			this.Controls.Add(this.lbl_factory);
			this.Name = "Pop_PS_NoticeAuto_PG";
			this.Text = "Auto Notice Setting";
			this.Load += new System.EventHandler(this.Pop_PS_NoticeAuto_PG_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_factory, 0);
			this.Controls.SetChildIndex(this.cmb_factory, 0);
			this.Controls.SetChildIndex(this.lbl_proj, 0);
			this.Controls.SetChildIndex(this.cmb_proj, 0);
			this.Controls.SetChildIndex(this.lbl_pg_id, 0);
			this.Controls.SetChildIndex(this.cmb_pg_id, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.btn_cencal, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_proj)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pg_id)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_PS_NoticeAuto_PG_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text = "Auto Message For Job";
			this.lbl_MainTitle.Text = "Event Form Setting";

			ClassLib.ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();

			//Factory 설정
			DataTable dt = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = factroy;

			//소속프로잭트 설정
			dt = Select_PROJ_PGID(cmb_factory.SelectedValue.ToString(), "N");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_proj,0,0, true);
			cmb_proj.SelectedIndex = 0;
		}


		#region 이벤트

		private void cmb_proj_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//실행 프로그램 설정
			DataTable dt = Select_PROJ_PGID(cmb_factory.SelectedValue.ToString(), cmb_proj.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt,cmb_pg_id,0,0, false);
			//cmb_pg_id.SelectedIndex = 0;
		}
		
		private void btn_save_Click(object sender, System.EventArgs e)
		{
			string arg_factory    = cmb_factory.SelectedValue.ToString();
			string arg_user_id    = "system";                           //항상 고정
			string arg_pg_id      = cmb_pg_id.SelectedValue.ToString();
			string arg_work_event = "Default_Event";                    //PG_ID가 생성되면서 만들어지는 기본 이벤트
			string arg_work_desc  = "Default Event";                    //이벤트 설명
			string arg_useryn	  = "N";
			string arg_mail_yn    = "N";

			Save_Proj_Pgid(arg_factory, arg_user_id, arg_pg_id, arg_work_event, arg_work_desc, arg_useryn, arg_mail_yn);

			frm.New_PG_ID(arg_pg_id);

			Close();
		}
		
		private void btn_cencal_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		#endregion


		#region DB접속

		/// <summary>
		/// Select_PROJ_PGID : 소속 프로젝트와 적용폼 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_lang">언어</param>
		/// <param name="arg_pg_proj">소속프로잭트(소속 프로잭트를 자져올때 'N'을 넣음)</param>
		/// <returns>정상:DataTable, 오류:null</returns>
		private DataTable Select_PROJ_PGID(string arg_factory, string arg_pg_proj)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_DATA_DIC_PROJ_PGID";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_PG_PROJ";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_pg_proj;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		
		/// <summary>
		/// Save_PROJ_PGID : PG_ID를 저장
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_user_id">사용자 아이디('admin'으로 고정)</param>
		/// <param name="arg_pg_id">실행 프로그램</param>
		/// <param name="arg_work_event">이벤트</param>
		/// <param name="arg_work_desc">이벤트 설명</param>
		private void Save_Proj_Pgid(string arg_factory, string arg_user_id, string arg_pg_id, string arg_work_event, string arg_work_desc, string arg_use_yn, string arg_mail_yn)
		{
			string Proc_Name = "PKG_SPS_HOME.SAVE_PROJ_PGID";

			oraDB.ReDim_Parameter(8);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_PG_ID";
			oraDB.Parameter_Name[3] = "ARG_WORK_EVENT";
			oraDB.Parameter_Name[4] = "ARG_WORK_DESC";
			oraDB.Parameter_Name[5] = "ARG_USE_YN";
			oraDB.Parameter_Name[6] = "ARG_MAIL_YN";
			oraDB.Parameter_Name[7] = "ARG_UPD_USER";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[7] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = arg_pg_id;
			oraDB.Parameter_Values[3] = arg_work_event;
			oraDB.Parameter_Values[4] = arg_work_desc;
			oraDB.Parameter_Values[5] = arg_use_yn;
			oraDB.Parameter_Values[6] = arg_mail_yn;
			oraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		#endregion

		

		

		
	}
}

