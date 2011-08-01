using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace COM.Com_Form
{
	public class Pop_Work_Info : APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_eventid;
		private System.Windows.Forms.Label lbl_eventdesc;
		private System.Windows.Forms.TextBox txt_eventid;
		private System.Windows.Forms.TextBox txt_eventdesc;
		private System.Windows.Forms.Label lbl_registid;
		private System.Windows.Forms.TextBox txt_registid;
		private System.Windows.Forms.Label lbl_eventitle;
		private System.Windows.Forms.Label lbl_eventcontents;
		private System.Windows.Forms.TextBox txt_eventcontents;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Receive;
		private System.Windows.Forms.Label lbl_use;
		private System.Windows.Forms.Label lbl_open;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.CheckBox chk_useyn;
		private System.Windows.Forms.CheckBox chk_openyn;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_jobdc;


		private COM.OraDB oraDB = null;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_list;
		public System.Windows.Forms.TextBox txt_idlist;
		private System.Windows.Forms.TextBox txt_eventitle;
		private bool new_check = false;
		private string event_id = "";



		private int row_num = 0;

		private int col_event_id       = 0;
		private int col_event_desc     = 1;
		private int col_event_title    = 2;
		private int col_event_contents = 3;
		private int col_event_registid = 4;
		private int col_event_jobcd    = 5;
		//private int col_event_email    = 6;
		private int col_event_use      = 7;
		private int col_event_open     = 8;
		private System.Windows.Forms.Label btn_close;

		private string division = "U";

		//private Pop_Work_Info_List popworkinfo = null;


		public Pop_Work_Info(string arg_event_id)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			event_id = arg_event_id;
		}

		public Pop_Work_Info(string arg_event_id, bool arg_new_check)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			new_check = arg_new_check;
			event_id = arg_event_id;
		}

		public Pop_Work_Info()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Work_Info));
			this.lbl_eventid = new System.Windows.Forms.Label();
			this.lbl_eventdesc = new System.Windows.Forms.Label();
			this.txt_eventid = new System.Windows.Forms.TextBox();
			this.txt_eventdesc = new System.Windows.Forms.TextBox();
			this.lbl_registid = new System.Windows.Forms.Label();
			this.txt_registid = new System.Windows.Forms.TextBox();
			this.lbl_eventitle = new System.Windows.Forms.Label();
			this.txt_eventitle = new System.Windows.Forms.TextBox();
			this.lbl_eventcontents = new System.Windows.Forms.Label();
			this.txt_eventcontents = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_jobdc = new C1.Win.C1List.C1Combo();
			this.lbl_Receive = new System.Windows.Forms.Label();
			this.txt_idlist = new System.Windows.Forms.TextBox();
			this.lbl_use = new System.Windows.Forms.Label();
			this.lbl_open = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.chk_useyn = new System.Windows.Forms.CheckBox();
			this.chk_openyn = new System.Windows.Forms.CheckBox();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_list = new System.Windows.Forms.Label();
			this.btn_close = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobdc)).BeginInit();
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
			// lbl_eventid
			// 
			this.lbl_eventid.ImageIndex = 0;
			this.lbl_eventid.ImageList = this.img_Label;
			this.lbl_eventid.Location = new System.Drawing.Point(8, 64);
			this.lbl_eventid.Name = "lbl_eventid";
			this.lbl_eventid.Size = new System.Drawing.Size(100, 21);
			this.lbl_eventid.TabIndex = 100;
			this.lbl_eventid.Text = "Event ID";
			this.lbl_eventid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_eventdesc
			// 
			this.lbl_eventdesc.ImageIndex = 0;
			this.lbl_eventdesc.ImageList = this.img_Label;
			this.lbl_eventdesc.Location = new System.Drawing.Point(8, 86);
			this.lbl_eventdesc.Name = "lbl_eventdesc";
			this.lbl_eventdesc.Size = new System.Drawing.Size(100, 21);
			this.lbl_eventdesc.TabIndex = 101;
			this.lbl_eventdesc.Text = "Event DESC";
			this.lbl_eventdesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_eventid
			// 
			this.txt_eventid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventid.Location = new System.Drawing.Point(109, 64);
			this.txt_eventid.Name = "txt_eventid";
			this.txt_eventid.Size = new System.Drawing.Size(184, 21);
			this.txt_eventid.TabIndex = 102;
			this.txt_eventid.Text = "";
			// 
			// txt_eventdesc
			// 
			this.txt_eventdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventdesc.Location = new System.Drawing.Point(109, 86);
			this.txt_eventdesc.Multiline = true;
			this.txt_eventdesc.Name = "txt_eventdesc";
			this.txt_eventdesc.Size = new System.Drawing.Size(579, 42);
			this.txt_eventdesc.TabIndex = 103;
			this.txt_eventdesc.Text = "";
			// 
			// lbl_registid
			// 
			this.lbl_registid.ImageIndex = 0;
			this.lbl_registid.ImageList = this.img_Label;
			this.lbl_registid.Location = new System.Drawing.Point(403, 64);
			this.lbl_registid.Name = "lbl_registid";
			this.lbl_registid.Size = new System.Drawing.Size(100, 21);
			this.lbl_registid.TabIndex = 104;
			this.lbl_registid.Text = "Regist ID";
			this.lbl_registid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_registid
			// 
			this.txt_registid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_registid.Location = new System.Drawing.Point(504, 64);
			this.txt_registid.Name = "txt_registid";
			this.txt_registid.ReadOnly = true;
			this.txt_registid.Size = new System.Drawing.Size(184, 21);
			this.txt_registid.TabIndex = 105;
			this.txt_registid.Text = "";
			// 
			// lbl_eventitle
			// 
			this.lbl_eventitle.ImageIndex = 0;
			this.lbl_eventitle.ImageList = this.img_Label;
			this.lbl_eventitle.Location = new System.Drawing.Point(8, 151);
			this.lbl_eventitle.Name = "lbl_eventitle";
			this.lbl_eventitle.Size = new System.Drawing.Size(100, 21);
			this.lbl_eventitle.TabIndex = 107;
			this.lbl_eventitle.Text = "Event Title";
			this.lbl_eventitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_eventitle
			// 
			this.txt_eventitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventitle.Location = new System.Drawing.Point(109, 151);
			this.txt_eventitle.Name = "txt_eventitle";
			this.txt_eventitle.Size = new System.Drawing.Size(579, 21);
			this.txt_eventitle.TabIndex = 108;
			this.txt_eventitle.Text = "";
			// 
			// lbl_eventcontents
			// 
			this.lbl_eventcontents.ImageIndex = 0;
			this.lbl_eventcontents.ImageList = this.img_Label;
			this.lbl_eventcontents.Location = new System.Drawing.Point(8, 173);
			this.lbl_eventcontents.Name = "lbl_eventcontents";
			this.lbl_eventcontents.Size = new System.Drawing.Size(100, 21);
			this.lbl_eventcontents.TabIndex = 109;
			this.lbl_eventcontents.Text = "Event Contents";
			this.lbl_eventcontents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_eventcontents
			// 
			this.txt_eventcontents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventcontents.Location = new System.Drawing.Point(109, 173);
			this.txt_eventcontents.Multiline = true;
			this.txt_eventcontents.Name = "txt_eventcontents";
			this.txt_eventcontents.Size = new System.Drawing.Size(579, 219);
			this.txt_eventcontents.TabIndex = 110;
			this.txt_eventcontents.Text = "";
			// 
			// label1
			// 
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 111;
			this.label1.Text = "Job Code";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_jobdc
			// 
			this.cmb_jobdc.AddItemCols = 0;
			this.cmb_jobdc.AddItemSeparator = ';';
			//this.cmb_jobdc.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_jobdc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_jobdc.Caption = "";
			this.cmb_jobdc.CaptionHeight = 17;
			this.cmb_jobdc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_jobdc.ColumnCaptionHeight = 18;
			this.cmb_jobdc.ColumnFooterHeight = 18;
			this.cmb_jobdc.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_jobdc.ContentHeight = 17;
			this.cmb_jobdc.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_jobdc.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_jobdc.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobdc.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_jobdc.EditorHeight = 17;
			this.cmb_jobdc.Enabled = false;
			this.cmb_jobdc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobdc.GapHeight = 2;
			this.cmb_jobdc.ItemHeight = 15;
			this.cmb_jobdc.Location = new System.Drawing.Point(109, 129);
			this.cmb_jobdc.MatchEntryTimeout = ((long)(2000));
			this.cmb_jobdc.MaxDropDownItems = ((short)(5));
			this.cmb_jobdc.MaxLength = 32767;
			this.cmb_jobdc.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_jobdc.Name = "cmb_jobdc";
			//this.cmb_jobdc.PartialRightColumn = false;
			this.cmb_jobdc.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_jobdc.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_jobdc.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_jobdc.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_jobdc.Size = new System.Drawing.Size(184, 21);
			this.cmb_jobdc.TabIndex = 112;
			// 
			// lbl_Receive
			// 
			this.lbl_Receive.ImageIndex = 0;
			this.lbl_Receive.ImageList = this.img_Label;
			this.lbl_Receive.Location = new System.Drawing.Point(8, 393);
			this.lbl_Receive.Name = "lbl_Receive";
			this.lbl_Receive.Size = new System.Drawing.Size(100, 21);
			this.lbl_Receive.TabIndex = 113;
			this.lbl_Receive.Text = "Receive User";
			this.lbl_Receive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_idlist
			// 
			this.txt_idlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_idlist.Location = new System.Drawing.Point(109, 393);
			this.txt_idlist.Name = "txt_idlist";
			this.txt_idlist.Size = new System.Drawing.Size(579, 21);
			this.txt_idlist.TabIndex = 114;
			this.txt_idlist.Text = "";
			// 
			// lbl_use
			// 
			this.lbl_use.ImageIndex = 0;
			this.lbl_use.ImageList = this.img_Label;
			this.lbl_use.Location = new System.Drawing.Point(8, 415);
			this.lbl_use.Name = "lbl_use";
			this.lbl_use.Size = new System.Drawing.Size(100, 21);
			this.lbl_use.TabIndex = 115;
			this.lbl_use.Text = "Event Use";
			this.lbl_use.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_use.Visible = false;
			// 
			// lbl_open
			// 
			this.lbl_open.ImageIndex = 0;
			this.lbl_open.ImageList = this.img_Label;
			this.lbl_open.Location = new System.Drawing.Point(403, 415);
			this.lbl_open.Name = "lbl_open";
			this.lbl_open.Size = new System.Drawing.Size(100, 21);
			this.lbl_open.TabIndex = 116;
			this.lbl_open.Text = "Alway Open";
			this.lbl_open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_open.Visible = false;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(80, 23);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imageList1;
			this.btn_save.Location = new System.Drawing.Point(8, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 118;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// chk_useyn
			// 
			this.chk_useyn.BackColor = System.Drawing.Color.Transparent;
			this.chk_useyn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_useyn.Checked = true;
			this.chk_useyn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_useyn.Enabled = false;
			this.chk_useyn.Location = new System.Drawing.Point(108, 415);
			this.chk_useyn.Name = "chk_useyn";
			this.chk_useyn.Size = new System.Drawing.Size(21, 21);
			this.chk_useyn.TabIndex = 120;
			this.chk_useyn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_useyn.Visible = false;
			// 
			// chk_openyn
			// 
			this.chk_openyn.BackColor = System.Drawing.Color.Transparent;
			this.chk_openyn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_openyn.Checked = true;
			this.chk_openyn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_openyn.Enabled = false;
			this.chk_openyn.Location = new System.Drawing.Point(504, 415);
			this.chk_openyn.Name = "chk_openyn";
			this.chk_openyn.Size = new System.Drawing.Size(21, 21);
			this.chk_openyn.TabIndex = 121;
			this.chk_openyn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_openyn.Visible = false;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Turquoise;
			// 
			// btn_list
			// 
			this.btn_list.ImageIndex = 8;
			this.btn_list.ImageList = this.img_MiniButton;
			this.btn_list.Location = new System.Drawing.Point(667, 393);
			this.btn_list.Name = "btn_list";
			this.btn_list.Size = new System.Drawing.Size(21, 21);
			this.btn_list.TabIndex = 231;
			this.btn_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_list.Visible = false;
			// 
			// btn_close
			// 
			this.btn_close.ImageIndex = 10;
			this.btn_close.ImageList = this.imageList1;
			this.btn_close.Location = new System.Drawing.Point(608, 416);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(80, 23);
			this.btn_close.TabIndex = 232;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// Pop_Work_Info
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_list);
			this.Controls.Add(this.chk_openyn);
			this.Controls.Add(this.chk_useyn);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.lbl_open);
			this.Controls.Add(this.lbl_use);
			this.Controls.Add(this.txt_idlist);
			this.Controls.Add(this.lbl_Receive);
			this.Controls.Add(this.cmb_jobdc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_eventcontents);
			this.Controls.Add(this.lbl_eventcontents);
			this.Controls.Add(this.txt_eventitle);
			this.Controls.Add(this.lbl_eventitle);
			this.Controls.Add(this.txt_registid);
			this.Controls.Add(this.lbl_registid);
			this.Controls.Add(this.txt_eventdesc);
			this.Controls.Add(this.txt_eventid);
			this.Controls.Add(this.lbl_eventdesc);
			this.Controls.Add(this.lbl_eventid);
			this.Name = "Pop_Work_Info";
			this.Load += new System.EventHandler(this.Pop_Work_Info_Load);
			this.Controls.SetChildIndex(this.lbl_eventid, 0);
			this.Controls.SetChildIndex(this.lbl_eventdesc, 0);
			this.Controls.SetChildIndex(this.txt_eventid, 0);
			this.Controls.SetChildIndex(this.txt_eventdesc, 0);
			this.Controls.SetChildIndex(this.lbl_registid, 0);
			this.Controls.SetChildIndex(this.txt_registid, 0);
			this.Controls.SetChildIndex(this.lbl_eventitle, 0);
			this.Controls.SetChildIndex(this.txt_eventitle, 0);
			this.Controls.SetChildIndex(this.lbl_eventcontents, 0);
			this.Controls.SetChildIndex(this.txt_eventcontents, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.cmb_jobdc, 0);
			this.Controls.SetChildIndex(this.lbl_Receive, 0);
			this.Controls.SetChildIndex(this.txt_idlist, 0);
			this.Controls.SetChildIndex(this.lbl_use, 0);
			this.Controls.SetChildIndex(this.lbl_open, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.chk_useyn, 0);
			this.Controls.SetChildIndex(this.chk_openyn, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_list, 0);
			this.Controls.SetChildIndex(this.btn_close, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobdc)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Work_Info_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.Text = "Please Do It!!";
			this.lbl_MainTitle.Text = "Registration Event";

			ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();


			

			DataTable dt = Show_JobCD_CD();
			ComCtl.Set_ComboList(dt, cmb_jobdc, 0, 1, false, false);
			cmb_jobdc.SelectedValue = ComVar.This_JobCdoe;

			dt = Select_Workinfo(event_id);

			txt_eventid.Text        = dt.Rows[row_num].ItemArray[col_event_id].ToString();
			txt_registid.Text       = dt.Rows[row_num].ItemArray[col_event_registid].ToString();
			txt_eventdesc.Text      = dt.Rows[row_num].ItemArray[col_event_desc].ToString();
			cmb_jobdc.SelectedValue = dt.Rows[row_num].ItemArray[col_event_jobcd].ToString();

			if(!new_check)
			{
				txt_eventitle.Text      = dt.Rows[row_num].ItemArray[col_event_title].ToString();
				txt_eventcontents.Text  = dt.Rows[row_num].ItemArray[col_event_contents].ToString();
			}
			chk_useyn.Checked       = bool.Parse((dt.Rows[row_num].ItemArray[col_event_use].ToString() == "Y") ? "true" : "false");
			chk_openyn.Checked      = bool.Parse((dt.Rows[row_num].ItemArray[col_event_open].ToString() == "Y") ? "true" : "false");


			dt = Select_Workinfo_Ruser(event_id);

			for(int i=0; i<dt.Rows.Count; i++)
			{
				if(txt_idlist.Text.Length < 1)
				{
					txt_idlist.Text += dt.Rows[i].ItemArray[0].ToString();
				}
				else
				{
					txt_idlist.Text += "," + dt.Rows[i].ItemArray[0].ToString();
				}
			}


			txt_eventid.Enabled = false;
			txt_registid.Enabled = false;
			txt_eventdesc.Enabled = false;
			txt_eventcontents.Focus();
		}


		private DataTable Show_JobCD_CD()
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_JOB_CD";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private bool Save_Workinfo(string arg_division)
		{
			string Proc_Name = "PKG_SPS_HOME.SAVE_WORKINFO";

			oraDB.ReDim_Parameter(14);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_EVENT_ID";
			oraDB.Parameter_Name[3] = "ARG_EVENT_DESC";
			oraDB.Parameter_Name[4] = "ARG_TITLE";
			oraDB.Parameter_Name[5] = "ARG_CONTENTS";
			oraDB.Parameter_Name[6] = "ARG_REGIST_ID";
			oraDB.Parameter_Name[7] = "ARG_JOB_CD";
			oraDB.Parameter_Name[8] = "ARG_EMAIL_YN";
			oraDB.Parameter_Name[9] = "ARG_USE_YN";
			oraDB.Parameter_Name[10] = "ARG_OPEN_YN";
			oraDB.Parameter_Name[11] = "ARG_COMM_YN";
			oraDB.Parameter_Name[12] = "ARG_UPD_USER";
			oraDB.Parameter_Name[13] = "OUT_CURSOR"; 
 

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
			oraDB.Parameter_Type[13] = (int)OracleType.Cursor;


			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = ComVar.This_Factory;
			oraDB.Parameter_Values[2] = txt_eventid.Text.Trim();
			oraDB.Parameter_Values[3] = txt_eventdesc.Text;
			oraDB.Parameter_Values[4] = txt_eventitle.Text;
			oraDB.Parameter_Values[5] = txt_eventcontents.Text;
			oraDB.Parameter_Values[6] = txt_registid.Text;
			oraDB.Parameter_Values[7] = cmb_jobdc.SelectedValue.ToString();
			oraDB.Parameter_Values[8] = "N";//email_yn
			oraDB.Parameter_Values[9] = (chk_useyn.Checked == true) ? "Y" : "N";
			oraDB.Parameter_Values[10] = (chk_openyn.Checked == true) ? "Y" : "N";
			oraDB.Parameter_Values[11] = "Y";
			oraDB.Parameter_Values[12] = ComVar.This_User;
			oraDB.Parameter_Values[13] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			return  bool.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());
		}


		private void Save_Workinfo_Ruser(string arg_ruser)
		{
			string Proc_Name = "PKG_SPS_HOME.SAVE_WORKINFO_RUSER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_EVENT_ID";
			oraDB.Parameter_Name[2] = "ARG_RUSER_ID";
			oraDB.Parameter_Name[3] = "ARG_UPD_USER";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = txt_eventid.Text;
			oraDB.Parameter_Values[2] = arg_ruser;
			oraDB.Parameter_Values[3] = ComVar.This_User;


			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		private DataTable Select_Workinfo(string arg_even_id)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_WORKINFO";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_EVENT_ID";
			oraDB.Parameter_Name[2] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_even_id;
			oraDB.Parameter_Values[2] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		private DataTable Select_Workinfo_Ruser(string arg_even_id)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_WORKINFO_RUSER";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_EVENT_ID";
			oraDB.Parameter_Name[2] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_even_id;
			oraDB.Parameter_Values[2] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if(!Save_Workinfo(division))
			{
				string ruser = txt_idlist.Text.Trim();
				if(ruser.Length > 0)
				{
					string div = ",";
					string[] ruser_list = ruser.Split(div.ToCharArray());

					for(int i=0; i<ruser_list.Length; i++)
					{
						Save_Workinfo_Ruser(ruser_list[i]);
					}
				}
			}

			this.Close();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			ComVar.event_use = false;
			this.Close();
		}
	}
}

