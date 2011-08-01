using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace COM.Com_Form
{
	public class Form_PS_NoticeAuto : COM.APSWinForm.Pop_Large
	{
		public System.Windows.Forms.Panel pnl_Set_Event;
		private System.Windows.Forms.Label btn_add_pgid;
		private C1.Win.C1List.C1Combo cmb_pg_id;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_pg_id;
		private System.Windows.Forms.Label lbl_factory;
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
		private System.Windows.Forms.Label lbl_event;
		private C1.Win.C1List.C1Combo cmb_event;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label lbl_ruser;
		public System.Windows.Forms.TextBox txt_ruser;
		private System.Windows.Forms.Label lbl_body_h;
		private System.Windows.Forms.TextBox txt_body_h;
		private System.Windows.Forms.TextBox txt_body_t;
		private System.Windows.Forms.Label lbl_body_t;
		private System.Windows.Forms.Label lbl_useyn;
		private System.Windows.Forms.CheckBox chk_useyn;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_add;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_desc;
		private System.Windows.Forms.TextBox txt_desc;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1Command tbtn_search;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1Command tbtn_modify;
		private System.Windows.Forms.Label lbl_mail;
		private System.Windows.Forms.TextBox txt_title;


		#region 사용자 변수

		private COM.OraDB oraDB = null;
		private System.Windows.Forms.CheckBox chk_mail;
		private string User_ID = "system";
		private bool modiyfy_mode = false;


		private string pg_id = null;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private string event_cd = null;


		#endregion

		public Form_PS_NoticeAuto()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Form_PS_NoticeAuto(string arg_pg_id, string arg_event_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			pg_id = arg_pg_id;
			event_cd = arg_event_cd;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PS_NoticeAuto));
			this.pnl_Set_Event = new System.Windows.Forms.Panel();
			this.txt_desc = new System.Windows.Forms.TextBox();
			this.lbl_desc = new System.Windows.Forms.Label();
			this.cmb_event = new C1.Win.C1List.C1Combo();
			this.lbl_event = new System.Windows.Forms.Label();
			this.btn_add_pgid = new System.Windows.Forms.Label();
			this.cmb_pg_id = new C1.Win.C1List.C1Combo();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_pg_id = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.chk_mail = new System.Windows.Forms.CheckBox();
			this.lbl_mail = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.lbl_useyn = new System.Windows.Forms.Label();
			this.lbl_body_t = new System.Windows.Forms.Label();
			this.txt_body_t = new System.Windows.Forms.TextBox();
			this.txt_body_h = new System.Windows.Forms.TextBox();
			this.txt_ruser = new System.Windows.Forms.TextBox();
			this.lbl_body_h = new System.Windows.Forms.Label();
			this.txt_title = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_title = new System.Windows.Forms.Label();
			this.lbl_ruser = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chk_useyn = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_search = new C1.Win.C1Command.C1Command();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_modify = new C1.Win.C1Command.C1Command();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.pnl_Set_Event.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_event)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pg_id)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			// pnl_Set_Event
			// 
			this.pnl_Set_Event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Set_Event.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Set_Event.Controls.Add(this.txt_desc);
			this.pnl_Set_Event.Controls.Add(this.lbl_desc);
			this.pnl_Set_Event.Controls.Add(this.cmb_event);
			this.pnl_Set_Event.Controls.Add(this.lbl_event);
			this.pnl_Set_Event.Controls.Add(this.btn_add_pgid);
			this.pnl_Set_Event.Controls.Add(this.cmb_pg_id);
			this.pnl_Set_Event.Controls.Add(this.cmb_factory);
			this.pnl_Set_Event.Controls.Add(this.lbl_pg_id);
			this.pnl_Set_Event.Controls.Add(this.lbl_factory);
			this.pnl_Set_Event.Controls.Add(this.pnl_SearchImage);
			this.pnl_Set_Event.DockPadding.All = 8;
			this.pnl_Set_Event.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Set_Event.Location = new System.Drawing.Point(0, 40);
			this.pnl_Set_Event.Name = "pnl_Set_Event";
			this.pnl_Set_Event.Size = new System.Drawing.Size(696, 120);
			this.pnl_Set_Event.TabIndex = 35;
			// 
			// txt_desc
			// 
			this.txt_desc.BackColor = System.Drawing.Color.White;
			this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_desc.Enabled = false;
			this.txt_desc.Location = new System.Drawing.Point(119, 80);
			this.txt_desc.Name = "txt_desc";
			this.txt_desc.Size = new System.Drawing.Size(544, 21);
			this.txt_desc.TabIndex = 234;
			this.txt_desc.Text = "";
			// 
			// lbl_desc
			// 
			this.lbl_desc.ImageIndex = 0;
			this.lbl_desc.ImageList = this.img_Label;
			this.lbl_desc.Location = new System.Drawing.Point(18, 80);
			this.lbl_desc.Name = "lbl_desc";
			this.lbl_desc.Size = new System.Drawing.Size(100, 21);
			this.lbl_desc.TabIndex = 232;
			this.lbl_desc.Text = "이벤트 설명";
			this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_event
			// 
			this.cmb_event.AddItemCols = 0;
			this.cmb_event.AddItemSeparator = ';';
			//this.cmb_event.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_event.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_event.Caption = "";
			this.cmb_event.CaptionHeight = 17;
			this.cmb_event.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_event.ColumnCaptionHeight = 18;
			this.cmb_event.ColumnFooterHeight = 18;
			this.cmb_event.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_event.ContentHeight = 17;
			this.cmb_event.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_event.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_event.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_event.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_event.EditorHeight = 17;
			this.cmb_event.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_event.GapHeight = 2;
			this.cmb_event.ItemHeight = 15;
			this.cmb_event.Location = new System.Drawing.Point(453, 58);
			this.cmb_event.MatchEntryTimeout = ((long)(2000));
			this.cmb_event.MaxDropDownItems = ((short)(5));
			this.cmb_event.MaxLength = 32767;
			this.cmb_event.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_event.Name = "cmb_event";
			//this.cmb_event.PartialRightColumn = false;
			this.cmb_event.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_event.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_event.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_event.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_event.Size = new System.Drawing.Size(210, 21);
			this.cmb_event.TabIndex = 231;
			// 
			// lbl_event
			// 
			this.lbl_event.ImageIndex = 0;
			this.lbl_event.ImageList = this.img_Label;
			this.lbl_event.Location = new System.Drawing.Point(352, 58);
			this.lbl_event.Name = "lbl_event";
			this.lbl_event.Size = new System.Drawing.Size(100, 21);
			this.lbl_event.TabIndex = 230;
			this.lbl_event.Text = "적용 Event";
			this.lbl_event.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_add_pgid
			// 
			this.btn_add_pgid.Location = new System.Drawing.Point(330, 58);
			this.btn_add_pgid.Name = "btn_add_pgid";
			this.btn_add_pgid.Size = new System.Drawing.Size(21, 21);
			this.btn_add_pgid.TabIndex = 229;
			this.btn_add_pgid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_pg_id
			// 
			this.cmb_pg_id.AddItemCols = 0;
			this.cmb_pg_id.AddItemSeparator = ';';
			//this.cmb_pg_id.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
			this.cmb_pg_id.Location = new System.Drawing.Point(119, 58);
			this.cmb_pg_id.MatchEntryTimeout = ((long)(2000));
			this.cmb_pg_id.MaxDropDownItems = ((short)(5));
			this.cmb_pg_id.MaxLength = 32767;
			this.cmb_pg_id.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_pg_id.Name = "cmb_pg_id";
			//this.cmb_pg_id.PartialRightColumn = false;
			this.cmb_pg_id.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_pg_id.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_pg_id.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_pg_id.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_pg_id.Size = new System.Drawing.Size(210, 21);
			this.cmb_pg_id.TabIndex = 75;
			this.cmb_pg_id.SelectedValueChanged += new System.EventHandler(this.cmb_pg_id_SelectedValueChanged);
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			//this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
			this.cmb_factory.Location = new System.Drawing.Point(119, 36);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			//this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_factory.TabIndex = 74;
			// 
			// lbl_pg_id
			// 
			this.lbl_pg_id.ImageIndex = 0;
			this.lbl_pg_id.ImageList = this.img_Label;
			this.lbl_pg_id.Location = new System.Drawing.Point(18, 58);
			this.lbl_pg_id.Name = "lbl_pg_id";
			this.lbl_pg_id.Size = new System.Drawing.Size(100, 21);
			this.lbl_pg_id.TabIndex = 71;
			this.lbl_pg_id.Text = "적용 Program";
			this.lbl_pg_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_factory
			// 
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(18, 36);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 70;
			this.lbl_factory.Text = "공장";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(680, 104);
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
			this.picb_MR.Location = new System.Drawing.Point(665, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 64);
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
			this.lbl_SubTitle1.Text = "      Search Work Event";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(664, 88);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 86);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 84);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 64);
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
			this.picb_MM.Size = new System.Drawing.Size(512, 64);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.chk_mail);
			this.panel1.Controls.Add(this.lbl_mail);
			this.panel1.Controls.Add(this.btn_add);
			this.panel1.Controls.Add(this.lbl_useyn);
			this.panel1.Controls.Add(this.lbl_body_t);
			this.panel1.Controls.Add(this.txt_body_t);
			this.panel1.Controls.Add(this.txt_body_h);
			this.panel1.Controls.Add(this.txt_ruser);
			this.panel1.Controls.Add(this.lbl_body_h);
			this.panel1.Controls.Add(this.txt_title);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lbl_title);
			this.panel1.Controls.Add(this.lbl_ruser);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.DockPadding.Bottom = 8;
			this.panel1.DockPadding.Left = 8;
			this.panel1.DockPadding.Right = 8;
			this.panel1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 160);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 296);
			this.panel1.TabIndex = 36;
			// 
			// chk_mail
			// 
			this.chk_mail.BackColor = System.Drawing.Color.White;
			this.chk_mail.Enabled = false;
			this.chk_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_mail.Location = new System.Drawing.Point(256, 256);
			this.chk_mail.Name = "chk_mail";
			this.chk_mail.Size = new System.Drawing.Size(21, 21);
			this.chk_mail.TabIndex = 241;
			this.chk_mail.Visible = false;
			// 
			// lbl_mail
			// 
			this.lbl_mail.ImageIndex = 0;
			this.lbl_mail.ImageList = this.img_Label;
			this.lbl_mail.Location = new System.Drawing.Point(144, 256);
			this.lbl_mail.Name = "lbl_mail";
			this.lbl_mail.Size = new System.Drawing.Size(100, 21);
			this.lbl_mail.TabIndex = 240;
			this.lbl_mail.Text = "메일사용";
			this.lbl_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_mail.Visible = false;
			// 
			// btn_add
			// 
			this.btn_add.ImageIndex = 14;
			this.btn_add.ImageList = this.img_MiniButton;
			this.btn_add.Location = new System.Drawing.Point(643, 36);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(21, 21);
			this.btn_add.TabIndex = 239;
			this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_add.Visible = false;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			this.btn_add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_add_MouseUp);
			this.btn_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_add_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// lbl_useyn
			// 
			this.lbl_useyn.ImageIndex = 0;
			this.lbl_useyn.ImageList = this.img_Label;
			this.lbl_useyn.Location = new System.Drawing.Point(18, 256);
			this.lbl_useyn.Name = "lbl_useyn";
			this.lbl_useyn.Size = new System.Drawing.Size(100, 21);
			this.lbl_useyn.TabIndex = 238;
			this.lbl_useyn.Text = "사용유무";
			this.lbl_useyn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_body_t
			// 
			this.lbl_body_t.ImageIndex = 0;
			this.lbl_body_t.ImageList = this.img_Label;
			this.lbl_body_t.Location = new System.Drawing.Point(18, 169);
			this.lbl_body_t.Name = "lbl_body_t";
			this.lbl_body_t.Size = new System.Drawing.Size(100, 21);
			this.lbl_body_t.TabIndex = 237;
			this.lbl_body_t.Text = "내용(하단)";
			this.lbl_body_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_body_t
			// 
			this.txt_body_t.BackColor = System.Drawing.Color.White;
			this.txt_body_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_body_t.Enabled = false;
			this.txt_body_t.Location = new System.Drawing.Point(119, 169);
			this.txt_body_t.Multiline = true;
			this.txt_body_t.Name = "txt_body_t";
			this.txt_body_t.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_body_t.Size = new System.Drawing.Size(545, 88);
			this.txt_body_t.TabIndex = 236;
			this.txt_body_t.Text = "";
			// 
			// txt_body_h
			// 
			this.txt_body_h.BackColor = System.Drawing.Color.White;
			this.txt_body_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_body_h.Enabled = false;
			this.txt_body_h.Location = new System.Drawing.Point(119, 80);
			this.txt_body_h.Multiline = true;
			this.txt_body_h.Name = "txt_body_h";
			this.txt_body_h.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_body_h.Size = new System.Drawing.Size(545, 88);
			this.txt_body_h.TabIndex = 235;
			this.txt_body_h.Text = "";
			// 
			// txt_ruser
			// 
			this.txt_ruser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ruser.Location = new System.Drawing.Point(119, 36);
			this.txt_ruser.Name = "txt_ruser";
			this.txt_ruser.Size = new System.Drawing.Size(545, 21);
			this.txt_ruser.TabIndex = 0;
			this.txt_ruser.Text = "";
			// 
			// lbl_body_h
			// 
			this.lbl_body_h.ImageIndex = 0;
			this.lbl_body_h.ImageList = this.img_Label;
			this.lbl_body_h.Location = new System.Drawing.Point(18, 80);
			this.lbl_body_h.Name = "lbl_body_h";
			this.lbl_body_h.Size = new System.Drawing.Size(100, 21);
			this.lbl_body_h.TabIndex = 234;
			this.lbl_body_h.Text = "내용(상단)";
			this.lbl_body_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_title
			// 
			this.txt_title.BackColor = System.Drawing.Color.White;
			this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_title.Enabled = false;
			this.txt_title.Location = new System.Drawing.Point(119, 58);
			this.txt_title.Name = "txt_title";
			this.txt_title.Size = new System.Drawing.Size(545, 21);
			this.txt_title.TabIndex = 233;
			this.txt_title.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(330, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 21);
			this.label2.TabIndex = 229;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(18, 58);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 71;
			this.lbl_title.Text = "제목";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_ruser
			// 
			this.lbl_ruser.ImageIndex = 0;
			this.lbl_ruser.ImageList = this.img_Label;
			this.lbl_ruser.Location = new System.Drawing.Point(18, 36);
			this.lbl_ruser.Name = "lbl_ruser";
			this.lbl_ruser.Size = new System.Drawing.Size(100, 21);
			this.lbl_ruser.TabIndex = 70;
			this.lbl_ruser.Text = "받는 아이디";
			this.lbl_ruser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.chk_useyn);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(8, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(680, 288);
			this.panel2.TabIndex = 18;
			// 
			// chk_useyn
			// 
			this.chk_useyn.BackColor = System.Drawing.Color.White;
			this.chk_useyn.Enabled = false;
			this.chk_useyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_useyn.Location = new System.Drawing.Point(111, 256);
			this.chk_useyn.Name = "chk_useyn";
			this.chk_useyn.Size = new System.Drawing.Size(21, 21);
			this.chk_useyn.TabIndex = 35;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(412, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 21);
			this.label5.TabIndex = 34;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(665, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(15, 248);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(664, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(456, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Window;
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(231, 30);
			this.label6.TabIndex = 28;
			this.label6.Text = "      Event Information";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(664, 272);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(144, 270);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(520, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 268);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 248);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(160, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(512, 248);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_search);
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_modify);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_search
			// 
			this.tbtn_search.Name = "tbtn_search";
			// 
			// tbtn_save
			// 
			this.tbtn_save.Name = "tbtn_save";
			// 
			// tbtn_modify
			// 
			this.tbtn_modify.Name = "tbtn_modify";
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
			this.btn_save.Location = new System.Drawing.Point(8, 464);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 111;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// Form_PS_NoticeAuto
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 496);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_Set_Event);
			this.Name = "Form_PS_NoticeAuto";
			this.Text = "Auto Notice Setting";
			this.Load += new System.EventHandler(this.Form_PS_NoticeAuto_Load);
			this.Controls.SetChildIndex(this.pnl_Set_Event, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.pnl_Set_Event.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_event)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pg_id)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		private void Form_PS_NoticeAuto_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text =  "Auto Notice Setting";
			this.lbl_MainTitle.Text = "Auto Notice Setting";

			oraDB = new COM.OraDB();


			//Factory 설정
			DataTable dt = ComFunction.Select_Factory_List();
			ComCtl.Set_ComboList(dt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ComVar.This_Factory;
			


			//PG_ID 설정
			dt = Select_PG_ID(cmb_factory.SelectedValue.ToString(), User_ID);
			ComCtl.Set_ComboList(dt, cmb_pg_id, 0, 0, true);
			

			cmb_factory.Enabled =  false;
			cmb_pg_id.Enabled   =  false;
			cmb_event.Enabled   =  false;
			
			
			if(pg_id == null || event_cd == null)
			{
				
				cmb_pg_id.SelectedIndex = 0;
			}
			else
			{
				cmb_factory.SelectedValue = ComVar.This_Factory;
				cmb_pg_id.SelectedValue = pg_id;
				cmb_pg_id_SelectedValueChanged(null, null);
				cmb_event.SelectedValue = event_cd;


				//Search
				btn_search_Click(null, null);

				//수정 가능 모드
				btn_modify_Click(null, null);


			}

		}

		
		private bool Check_YN(string arg_YN)
		{
			if(arg_YN == "Y")
				return true;
			else
				return false;
		}

		private string Check_TrueFalse(bool arg_TrueFalse)
		{
			if(arg_TrueFalse)
				return "Y";
			else
				return "N";
		}

		/// <summary>
		/// Modify_Mode : 수정 가능/불가능 모드 Setting 
		/// </summary>
		/// <param name="arg_TrueFalse">가능/불가능 첵크</param>
		private void Modify_Mode(bool arg_TrueFalse)
		{
			modiyfy_mode = arg_TrueFalse;

			

			txt_desc.Enabled    = arg_TrueFalse;
			txt_ruser.Enabled   = arg_TrueFalse;
			//btn_add.Enabled     = arg_TrueFalse;
			txt_title.Enabled   = arg_TrueFalse;
			txt_body_h.Enabled  = arg_TrueFalse;
			txt_body_t.Enabled  = arg_TrueFalse;
			chk_useyn.Enabled   = arg_TrueFalse;
			chk_mail.Enabled    = arg_TrueFalse;
		}

		/// <summary>
		/// Modify_Mode1 : 수정 가능/불가능 모드 Setting 
		/// </summary>
		/// <param name="arg_TrueFalse"></param>
//		private void Modify_Mode1(bool arg_TrueFalse)
//		{
//			cmb_factory.Enabled = arg_TrueFalse;
//			cmb_pg_id.Enabled = arg_TrueFalse;
//			cmb_event.Enabled = arg_TrueFalse;
//		}

		/// <summary>
		/// Clear_Compo : 콤포넌트 초기화
		/// </summary>
		private void Clear_Compo()
		{
			txt_desc.Text = "";
			txt_ruser.Text = "";
			txt_title.Text = "";
			txt_body_h.Text = "";
			txt_body_t.Text = "";
			chk_useyn.Checked = false;
			chk_mail.Checked = false;
		}


		#region 이벤트

		private void btn_add_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_add.ImageIndex = 15;
		}
		private void btn_add_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_add.ImageIndex = 14;
		}

		private void cmb_pg_id_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt = Select_Event_List(cmb_factory.SelectedValue.ToString(), User_ID, cmb_pg_id.SelectedValue.ToString());
			ComCtl.Set_ComboList(dt, cmb_event, 0, 1, true);
			cmb_event.SelectedIndex = 0;

			Clear_Compo();
		}

		private void btn_add_Click(object sender, System.EventArgs e)
		{

			//txt_ru
//			Pop_PS_NoticeUser_UserList userList = new Pop_PS_NoticeUser_UserList(this, txt_ruser);
//			userList.MdiParent = ComVar.static_form;
//			ComVar.MenuClick_Flag = true;
//			userList.Show();'


//			ComVar.static_form.Activate().
//			for(int i=0; i<ComVar.static_form.OwnedForms.Length; i++)
//			{
//				if(ComVar.static_form.OwnedForms[i].Name == "Pop_PS_NoticeUser_UserList")
//				{
//					ComVar.static_form.OwnedForms[i].ShowDialog();
//					//userl
//				}
//			}


//			ComVar.aaa bbb = new ComVar.aaa(this);
//			bbb.ShowDialog();
		}

		#endregion

		#region DB접속

		/// <summary>
		/// Select_PG_ID : 적용될 프로그램 폼 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_user_id">사용자 아이디('admin' 으로 고정)</param>
		/// <returns>정상 : DataTable, 오류 : null</returns>
		private DataTable Select_PG_ID(string arg_factory, string arg_user_id)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_PG_ID";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Select_Event_List :  특정 폼의 이벤트 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_user_id">사용자 아이디('admin'으로 고정)</param>
		/// <param name="arg_pg_id">실행 프로그램</param>
		/// <returns>정상:DataTable 오류:null</returns>
		private DataTable Select_Event_List(string arg_factory, string arg_user_id, string arg_pg_id)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_EVENT_LIST";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_PG_ID";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = arg_pg_id;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Select_SPS_Notice_Work : 이벤트 상세 정보 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_user_id">사용자아이디('system'고정)</param>
		/// <param name="arg_pg_id">실행 프로그램</param>
		/// <param name="arg_seq">이벤트 고유번호</param>
		/// <returns>정상:DataTable,오류:null</returns>
		private DataTable Select_SPS_Notice_Work(string arg_factory, string arg_user_id, string arg_pg_id, string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_WORK";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_PG_ID";
			oraDB.Parameter_Name[3] = "ARG_SEQ";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = arg_pg_id;
			oraDB.Parameter_Values[3] = arg_seq;
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Save_Notice_Datil : 상세정보 저장
		/// </summary>
		/// <param name="arg_ArrayItem">데이터 배열(12개)</param>
		private void Save_Notice_Datil(string[] arg_ArrayItem)
		{
			string Proc_Name = "PKG_SPS_HOME.SAVE_SPS_NOTICE_WORK_DETAIL";

			oraDB.ReDim_Parameter(12);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_USER_ID";
			oraDB.Parameter_Name[2]  = "ARG_PG_ID";
			oraDB.Parameter_Name[3]  = "ARG_SEQ";

			oraDB.Parameter_Name[4]  = "ARG_WORK_DESC";
			oraDB.Parameter_Name[5]  = "ARG_RUSER_ID";
			oraDB.Parameter_Name[6]  = "ARG_TITLE";
			oraDB.Parameter_Name[7]  = "ARG_MESSAGE_HEAD";
			oraDB.Parameter_Name[8]  = "ARG_MESSAGE_TAIL";
			oraDB.Parameter_Name[9]  = "ARG_USE_YN";
			oraDB.Parameter_Name[10] = "ARG_MAIL_YN";

			oraDB.Parameter_Name[11] = "ARG_UPD_USER";


			for(int i=0; i<arg_ArrayItem.Length; i++)
			{
				oraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}


			for(int i=0; i<arg_ArrayItem.Length; i++)
			{
				oraDB.Parameter_Values[i] = arg_ArrayItem[i];
			}

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		#endregion

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			if(cmb_pg_id.SelectedIndex != 0 && cmb_event.SelectedIndex != 0)
			{
				string arg_factory = cmb_factory.SelectedValue.ToString();
				string arg_user_id = User_ID;
				string arg_pg_id   = cmb_pg_id.SelectedValue.ToString();
				string arg_seq	   = cmb_event.SelectedValue.ToString();

				DataTable dt = Select_SPS_Notice_Work(arg_factory, arg_user_id, arg_pg_id, arg_seq);

				txt_desc.Text     = dt.Rows[0].ItemArray[5].ToString();
				txt_ruser.Text    = dt.Rows[0].ItemArray[6].ToString();
				txt_title.Text    = dt.Rows[0].ItemArray[7].ToString();
				txt_body_h.Text   = dt.Rows[0].ItemArray[8].ToString();
				txt_body_t.Text   = dt.Rows[0].ItemArray[9].ToString();
				chk_useyn.Checked = Check_YN(dt.Rows[0].ItemArray[10].ToString());
				chk_mail.Checked  = Check_YN(dt.Rows[0].ItemArray[11].ToString());
			}
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if(modiyfy_mode)
			{
				string[] ArrayItem = new string[12];
				ArrayItem[0] = cmb_factory.SelectedValue.ToString();
				ArrayItem[1] = User_ID;
				ArrayItem[2] = cmb_pg_id.SelectedValue.ToString();
				ArrayItem[3] = cmb_event.SelectedValue.ToString();

				ArrayItem[4] = txt_desc.Text;
				ArrayItem[5] = txt_ruser.Text;
				ArrayItem[6] = txt_title.Text;
				ArrayItem[7] = txt_body_h.Text;
				ArrayItem[8] = txt_body_t.Text;
				ArrayItem[9] = Check_TrueFalse(chk_useyn.Checked);
				ArrayItem[10] = Check_TrueFalse(chk_mail.Checked);

				ArrayItem[11]= ComVar.This_User;

				Save_Notice_Datil(ArrayItem);
				
				//Modify_Mode(false); //수정 불가능 모드
				//Modify_Mode1(true);
				
				btn_search_Click(sender, e);
			}
		}

		private void btn_modify_Click(object sender, System.EventArgs e)
		{
			if(cmb_event.SelectedIndex != 0)
			{
				Modify_Mode(true); //수정 가능 모드
				//Modify_Mode1(false);
			}
		}

		
	}
}

