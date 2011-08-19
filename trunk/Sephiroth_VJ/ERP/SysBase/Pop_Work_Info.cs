using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_Work_Info : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_eventid;
		private System.Windows.Forms.Label lbl_eventdesc;
		private System.Windows.Forms.TextBox txt_eventid;
		private System.Windows.Forms.TextBox txt_eventdesc;
		private System.Windows.Forms.Label lbl_registid;
		private System.Windows.Forms.TextBox txt_registid;
		private System.Windows.Forms.Label lbl_eventitle;
		private System.Windows.Forms.TextBox txt_eventcontents;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Receive;
		private System.Windows.Forms.Label lbl_use;
		private System.Windows.Forms.Label lbl_open;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.CheckBox chk_useyn;
		private System.Windows.Forms.CheckBox chk_openyn;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_jobdc;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_list;
		public System.Windows.Forms.TextBox txt_idlist;
		private System.Windows.Forms.TextBox txt_eventitle;


		private COM.OraDB oraDB = null;
		private bool new_check = true;
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

		private string division = "I";
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;

		private Pop_Work_Info_List popworkinfo = null;


		public Pop_Work_Info(Pop_Work_Info_List arg_frm, bool arg_new_check, string arg_event_id)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			popworkinfo = arg_frm;
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
			this.btn_delete = new System.Windows.Forms.Label();
			this.chk_useyn = new System.Windows.Forms.CheckBox();
			this.chk_openyn = new System.Windows.Forms.CheckBox();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_list = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobdc)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.lbl_eventid.Location = new System.Drawing.Point(5, 14);
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
			this.lbl_eventdesc.Location = new System.Drawing.Point(5, 36);
			this.lbl_eventdesc.Name = "lbl_eventdesc";
			this.lbl_eventdesc.Size = new System.Drawing.Size(100, 21);
			this.lbl_eventdesc.TabIndex = 101;
			this.lbl_eventdesc.Text = "Event DESC";
			this.lbl_eventdesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_eventid
			// 
			this.txt_eventid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventid.Location = new System.Drawing.Point(106, 14);
			this.txt_eventid.Name = "txt_eventid";
			this.txt_eventid.Size = new System.Drawing.Size(184, 21);
			this.txt_eventid.TabIndex = 102;
			this.txt_eventid.Text = "";
			// 
			// txt_eventdesc
			// 
			this.txt_eventdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventdesc.Location = new System.Drawing.Point(106, 36);
			this.txt_eventdesc.Name = "txt_eventdesc";
			this.txt_eventdesc.Size = new System.Drawing.Size(572, 21);
			this.txt_eventdesc.TabIndex = 103;
			this.txt_eventdesc.Text = "";
			this.txt_eventdesc.Enter += new System.EventHandler(this.txt_eventdesc_Enter);
			// 
			// lbl_registid
			// 
			this.lbl_registid.ImageIndex = 0;
			this.lbl_registid.ImageList = this.img_Label;
			this.lbl_registid.Location = new System.Drawing.Point(393, 14);
			this.lbl_registid.Name = "lbl_registid";
			this.lbl_registid.Size = new System.Drawing.Size(100, 21);
			this.lbl_registid.TabIndex = 104;
			this.lbl_registid.Text = "Regist ID";
			this.lbl_registid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_registid
			// 
			this.txt_registid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_registid.Location = new System.Drawing.Point(494, 14);
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
			this.lbl_eventitle.Location = new System.Drawing.Point(5, 36);
			this.lbl_eventitle.Name = "lbl_eventitle";
			this.lbl_eventitle.Size = new System.Drawing.Size(100, 21);
			this.lbl_eventitle.TabIndex = 107;
			this.lbl_eventitle.Text = "Title";
			this.lbl_eventitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_eventitle
			// 
			this.txt_eventitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventitle.Location = new System.Drawing.Point(106, 36);
			this.txt_eventitle.Name = "txt_eventitle";
			this.txt_eventitle.Size = new System.Drawing.Size(572, 21);
			this.txt_eventitle.TabIndex = 108;
			this.txt_eventitle.Text = "";
			// 
			// txt_eventcontents
			// 
			this.txt_eventcontents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_eventcontents.Location = new System.Drawing.Point(5, 58);
			this.txt_eventcontents.Multiline = true;
			this.txt_eventcontents.Name = "txt_eventcontents";
			this.txt_eventcontents.Size = new System.Drawing.Size(673, 215);
			this.txt_eventcontents.TabIndex = 110;
			this.txt_eventcontents.Text = "";
			// 
			// label1
			// 
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(5, 58);
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
			this.cmb_jobdc.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
			this.cmb_jobdc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobdc.GapHeight = 2;
			this.cmb_jobdc.ItemHeight = 15;
			this.cmb_jobdc.Location = new System.Drawing.Point(106, 58);
			this.cmb_jobdc.MatchEntryTimeout = ((long)(2000));
			this.cmb_jobdc.MaxDropDownItems = ((short)(5));
			this.cmb_jobdc.MaxLength = 32767;
			this.cmb_jobdc.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_jobdc.Name = "cmb_jobdc";
			this.cmb_jobdc.PartialRightColumn = false;
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
			this.lbl_Receive.Location = new System.Drawing.Point(5, 14);
			this.lbl_Receive.Name = "lbl_Receive";
			this.lbl_Receive.Size = new System.Drawing.Size(100, 21);
			this.lbl_Receive.TabIndex = 113;
			this.lbl_Receive.Text = "Receive User";
			this.lbl_Receive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_idlist
			// 
			this.txt_idlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_idlist.Location = new System.Drawing.Point(106, 14);
			this.txt_idlist.Name = "txt_idlist";
			this.txt_idlist.Size = new System.Drawing.Size(549, 21);
			this.txt_idlist.TabIndex = 114;
			this.txt_idlist.Text = "";
			// 
			// lbl_use
			// 
			this.lbl_use.ImageIndex = 0;
			this.lbl_use.ImageList = this.img_Label;
			this.lbl_use.Location = new System.Drawing.Point(5, 80);
			this.lbl_use.Name = "lbl_use";
			this.lbl_use.Size = new System.Drawing.Size(100, 21);
			this.lbl_use.TabIndex = 115;
			this.lbl_use.Text = "Event Use";
			this.lbl_use.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_open
			// 
			this.lbl_open.ImageIndex = 0;
			this.lbl_open.ImageList = this.img_Label;
			this.lbl_open.Location = new System.Drawing.Point(393, 80);
			this.lbl_open.Name = "lbl_open";
			this.lbl_open.Size = new System.Drawing.Size(100, 21);
			this.lbl_open.TabIndex = 116;
			this.lbl_open.Text = "Alway Open";
			this.lbl_open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.btn_save.Location = new System.Drawing.Point(610, 432);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 118;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imageList1;
			this.btn_delete.Location = new System.Drawing.Point(529, 432);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 117;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// chk_useyn
			// 
			this.chk_useyn.BackColor = System.Drawing.Color.Transparent;
			this.chk_useyn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_useyn.Checked = true;
			this.chk_useyn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_useyn.Location = new System.Drawing.Point(104, 80);
			this.chk_useyn.Name = "chk_useyn";
			this.chk_useyn.Size = new System.Drawing.Size(21, 21);
			this.chk_useyn.TabIndex = 120;
			this.chk_useyn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_openyn
			// 
			this.chk_openyn.BackColor = System.Drawing.Color.Transparent;
			this.chk_openyn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_openyn.Checked = true;
			this.chk_openyn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_openyn.Location = new System.Drawing.Point(493, 80);
			this.chk_openyn.Name = "chk_openyn";
			this.chk_openyn.Size = new System.Drawing.Size(21, 21);
			this.chk_openyn.TabIndex = 121;
			this.chk_openyn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.btn_list.Location = new System.Drawing.Point(656, 14);
			this.btn_list.Name = "btn_list";
			this.btn_list.Size = new System.Drawing.Size(21, 21);
			this.btn_list.TabIndex = 231;
			this.btn_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
			this.btn_list.MouseHover += new System.EventHandler(this.btn_list_MouseHover);
			this.btn_list.MouseLeave += new System.EventHandler(this.btn_list_MouseLeave);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_eventdesc);
			this.groupBox1.Controls.Add(this.txt_eventid);
			this.groupBox1.Controls.Add(this.lbl_eventid);
			this.groupBox1.Controls.Add(this.txt_eventdesc);
			this.groupBox1.Controls.Add(this.lbl_registid);
			this.groupBox1.Controls.Add(this.txt_registid);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmb_jobdc);
			this.groupBox1.Controls.Add(this.chk_useyn);
			this.groupBox1.Controls.Add(this.lbl_use);
			this.groupBox1.Controls.Add(this.chk_openyn);
			this.groupBox1.Controls.Add(this.lbl_open);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 107);
			this.groupBox1.TabIndex = 232;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.btn_list);
			this.groupBox2.Controls.Add(this.txt_idlist);
			this.groupBox2.Controls.Add(this.lbl_Receive);
			this.groupBox2.Controls.Add(this.lbl_eventitle);
			this.groupBox2.Controls.Add(this.txt_eventitle);
			this.groupBox2.Controls.Add(this.txt_eventcontents);
			this.groupBox2.Location = new System.Drawing.Point(5, 146);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(685, 280);
			this.groupBox2.TabIndex = 233;
			this.groupBox2.TabStop = false;
			// 
			// Pop_Work_Info
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 464);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Name = "Pop_Work_Info";
			this.Load += new System.EventHandler(this.Pop_Work_Info_Load);
			this.Closed += new System.EventHandler(this.Pop_Work_Info_Closed);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobdc)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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

			ClassLib.ComFunction.SetLangDic(this); 

			oraDB = new COM.OraDB();

			DataTable dt = Show_JobCD_CD();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_jobdc, 0, 1, false, false);
			cmb_jobdc.SelectedValue = ClassLib.ComVar.This_JobCdoe;


			if(new_check)
			{
				division = "I";
				txt_eventdesc.Text = "[이벤트의 설명과 적용 될 폼이름을 상세히 적어 주세요]";
				txt_registid.Text  = ClassLib.ComVar.This_User;

				btn_delete.Enabled = false;

				

			}
			else
			{
				division = "U";
				txt_eventid.Enabled = false;

				dt = Select_Workinfo(event_id);

				txt_eventid.Text  = dt.Rows[row_num].ItemArray[col_event_id].ToString();
				txt_registid.Text = dt.Rows[row_num].ItemArray[col_event_registid].ToString();
				txt_eventdesc.Text = dt.Rows[row_num].ItemArray[col_event_desc].ToString();
				cmb_jobdc.SelectedValue = dt.Rows[row_num].ItemArray[col_event_jobcd].ToString();
				txt_eventitle.Text = dt.Rows[row_num].ItemArray[col_event_title].ToString();
				txt_eventcontents.Text = dt.Rows[row_num].ItemArray[col_event_contents].ToString();
				chk_useyn.Checked = bool.Parse((dt.Rows[row_num].ItemArray[col_event_use].ToString() == "Y") ? "true" : "false");
				chk_openyn.Checked = bool.Parse((dt.Rows[row_num].ItemArray[col_event_open].ToString() == "Y") ? "true" : "false");


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



				btn_delete.Enabled = true;
			}
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

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
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
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
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
			oraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;
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

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = txt_eventid.Text;
			oraDB.Parameter_Values[2] = arg_ruser;
			oraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;


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

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
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

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_even_id;
			oraDB.Parameter_Values[2] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void txt_eventdesc_Enter(object sender, System.EventArgs e)
		{
			if(new_check)
			{
				txt_eventdesc.Text = "";
			}
		}

		private void btn_list_Click(object sender, System.EventArgs e)
		{
//			//Pop_PS_NoticeUser_UserList userList = new Pop_PS_NoticeUser_UserList(this, txt_ruser);
//
//			ErpCom.Form_PS_User userlist = new ERP.ErpCom.Form_PS_User(this);
//			userlist.ShowDialog();


			Pop_Work_Info_RUser pop_form = new Pop_Work_Info_RUser(txt_idlist.Text.Trim() );
			pop_form.ShowDialog();

			if(ClassLib.ComVar.Parameter_PopUp[0].Trim().Equals("") ) return;

			txt_idlist.Text = ClassLib.ComVar.Parameter_PopUp[0].Trim();



		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if(txt_eventid.Text.Length < 1)
			{
				ClassLib.ComFunction.User_Message("이벤트 아이디를 입력 해 주세요");
			}
			else if(txt_eventdesc.Text == "[이벤트의 설명과 적용 될 폼이름을 상세히 적어 주세요]" || txt_eventcontents.Text.Length < 1)
			{
				ClassLib.ComFunction.User_Message("이벤트 설명을 상세히 적어 주세요");
			}
			else
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
							Save_Workinfo_Ruser(ruser_list[i].Replace(ClassLib.ComVar.This_Domain, "") );
						}
					}

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave);
				}
				else
				{
					ClassLib.ComFunction.User_Message("이미 같은 이벤트 아이디가 있습니다.");
				}
			}

		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			DialogResult rs = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete);
			if(DialogResult.Yes == rs)
			{
				Save_Workinfo("D");
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete);
				this.Close();
			}


		}

		private void Pop_Work_Info_Closed(object sender, System.EventArgs e)
		{
			if(popworkinfo != null)
			{
				popworkinfo.Search();
			}
		}

		private void btn_list_MouseHover(object sender, System.EventArgs e)
		{
			btn_list.ImageIndex = 9;
		}

		private void btn_list_MouseLeave(object sender, System.EventArgs e)
		{
			btn_list.ImageIndex = 8;
		}



	}
}

