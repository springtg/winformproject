using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace COM.PCHWinForm
{
	public class Pop_Menu_SOS : COM.PCHWinForm.Pop_Medium
	{
		private C1.Win.C1List.C1Combo cmb_Type;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.DateTimePicker cmb_GetDate;
		private System.Windows.Forms.Label lbl_User;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.TextBox txt_Req_Contents;
		private System.Windows.Forms.TextBox txt_Maint_User;
		private System.Windows.Forms.TextBox txt_Dev_User;
		private System.Windows.Forms.Label lbl_Maint_User;
		private System.Windows.Forms.Label lbl_Dev_User;
		private System.Windows.Forms.Label lbl_Req_Contents;
		private System.Windows.Forms.Label lbl_Type;
		private System.Windows.Forms.Label lbl_GetDate;
		private System.Windows.Forms.Label lbl_Menu_Pg;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_Menu_Pg;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.ComponentModel.IContainer components = null;

		public Pop_Menu_SOS()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Menu_SOS));
			this.cmb_Type = new C1.Win.C1List.C1Combo();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.cmb_GetDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_User = new System.Windows.Forms.Label();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.txt_Req_Contents = new System.Windows.Forms.TextBox();
			this.txt_Maint_User = new System.Windows.Forms.TextBox();
			this.txt_Dev_User = new System.Windows.Forms.TextBox();
			this.lbl_Maint_User = new System.Windows.Forms.Label();
			this.lbl_Dev_User = new System.Windows.Forms.Label();
			this.lbl_Req_Contents = new System.Windows.Forms.Label();
			this.lbl_Type = new System.Windows.Forms.Label();
			this.lbl_GetDate = new System.Windows.Forms.Label();
			this.lbl_Menu_Pg = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Menu_Pg = new System.Windows.Forms.TextBox();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.btn_Save = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).BeginInit();
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
			this.lbl_MainTitle.Text = "Program Request";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// cmb_Type
			// 
			this.cmb_Type.AddItemCols = 0;
			this.cmb_Type.AddItemSeparator = ';';
			//this.cmb_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Type.Caption = "";
			this.cmb_Type.CaptionHeight = 17;
			this.cmb_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Type.ColumnCaptionHeight = 18;
			this.cmb_Type.ColumnFooterHeight = 18;
			this.cmb_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Type.ContentHeight = 17;
			this.cmb_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Type.EditorHeight = 17;
			this.cmb_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Type.GapHeight = 2;
			this.cmb_Type.ItemHeight = 15;
			this.cmb_Type.Location = new System.Drawing.Point(125, 170);
			this.cmb_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_Type.MaxDropDownItems = ((short)(5));
			this.cmb_Type.MaxLength = 10;
			this.cmb_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Type.Name = "cmb_Type";
			//this.cmb_Type.PartialRightColumn = false;
			this.cmb_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Type.Size = new System.Drawing.Size(128, 21);
			this.cmb_Type.TabIndex = 0;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory.Location = new System.Drawing.Point(125, 69);
			this.txt_Factory.MaxLength = 10;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(128, 21);
			this.txt_Factory.TabIndex = 278;
			this.txt_Factory.TabStop = false;
			this.txt_Factory.Text = "";
			// 
			// cmb_GetDate
			// 
			this.cmb_GetDate.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
			this.cmb_GetDate.CalendarMonthBackground = System.Drawing.Color.Yellow;
			this.cmb_GetDate.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
			this.cmb_GetDate.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.cmb_GetDate.CalendarTrailingForeColor = System.Drawing.Color.Green;
			this.cmb_GetDate.CustomFormat = "";
			this.cmb_GetDate.Enabled = false;
			this.cmb_GetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmb_GetDate.Location = new System.Drawing.Point(125, 91);
			this.cmb_GetDate.Name = "cmb_GetDate";
			this.cmb_GetDate.Size = new System.Drawing.Size(128, 21);
			this.cmb_GetDate.TabIndex = 280;
			// 
			// lbl_User
			// 
			this.lbl_User.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_User.ImageIndex = 1;
			this.lbl_User.ImageList = this.img_Label;
			this.lbl_User.Location = new System.Drawing.Point(272, 91);
			this.lbl_User.Name = "lbl_User";
			this.lbl_User.Size = new System.Drawing.Size(100, 21);
			this.lbl_User.TabIndex = 292;
			this.lbl_User.Text = "요청사용자";
			this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_User
			// 
			this.txt_User.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_User.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_User.Location = new System.Drawing.Point(373, 91);
			this.txt_User.MaxLength = 10;
			this.txt_User.Name = "txt_User";
			this.txt_User.ReadOnly = true;
			this.txt_User.Size = new System.Drawing.Size(128, 21);
			this.txt_User.TabIndex = 281;
			this.txt_User.TabStop = false;
			this.txt_User.Text = "";
			// 
			// txt_Req_Contents
			// 
			this.txt_Req_Contents.BackColor = System.Drawing.Color.White;
			this.txt_Req_Contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Req_Contents.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Req_Contents.ForeColor = System.Drawing.Color.Black;
			this.txt_Req_Contents.Location = new System.Drawing.Point(125, 192);
			this.txt_Req_Contents.MaxLength = 500;
			this.txt_Req_Contents.Multiline = true;
			this.txt_Req_Contents.Name = "txt_Req_Contents";
			this.txt_Req_Contents.Size = new System.Drawing.Size(371, 98);
			this.txt_Req_Contents.TabIndex = 1;
			this.txt_Req_Contents.Text = "";
			// 
			// txt_Maint_User
			// 
			this.txt_Maint_User.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Maint_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Maint_User.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Maint_User.Location = new System.Drawing.Point(373, 113);
			this.txt_Maint_User.MaxLength = 10;
			this.txt_Maint_User.Name = "txt_Maint_User";
			this.txt_Maint_User.ReadOnly = true;
			this.txt_Maint_User.Size = new System.Drawing.Size(128, 21);
			this.txt_Maint_User.TabIndex = 283;
			this.txt_Maint_User.TabStop = false;
			this.txt_Maint_User.Text = "";
			// 
			// txt_Dev_User
			// 
			this.txt_Dev_User.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Dev_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dev_User.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Dev_User.Location = new System.Drawing.Point(125, 113);
			this.txt_Dev_User.MaxLength = 10;
			this.txt_Dev_User.Name = "txt_Dev_User";
			this.txt_Dev_User.ReadOnly = true;
			this.txt_Dev_User.Size = new System.Drawing.Size(128, 21);
			this.txt_Dev_User.TabIndex = 282;
			this.txt_Dev_User.TabStop = false;
			this.txt_Dev_User.Text = "";
			// 
			// lbl_Maint_User
			// 
			this.lbl_Maint_User.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Maint_User.ImageIndex = 1;
			this.lbl_Maint_User.ImageList = this.img_Label;
			this.lbl_Maint_User.Location = new System.Drawing.Point(272, 113);
			this.lbl_Maint_User.Name = "lbl_Maint_User";
			this.lbl_Maint_User.Size = new System.Drawing.Size(100, 21);
			this.lbl_Maint_User.TabIndex = 291;
			this.lbl_Maint_User.Text = "유지보수담당자";
			this.lbl_Maint_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Dev_User
			// 
			this.lbl_Dev_User.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Dev_User.ImageIndex = 1;
			this.lbl_Dev_User.ImageList = this.img_Label;
			this.lbl_Dev_User.Location = new System.Drawing.Point(24, 113);
			this.lbl_Dev_User.Name = "lbl_Dev_User";
			this.lbl_Dev_User.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dev_User.TabIndex = 290;
			this.lbl_Dev_User.Text = "개발담당자";
			this.lbl_Dev_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Req_Contents
			// 
			this.lbl_Req_Contents.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Req_Contents.ImageIndex = 1;
			this.lbl_Req_Contents.ImageList = this.img_Label;
			this.lbl_Req_Contents.Location = new System.Drawing.Point(24, 192);
			this.lbl_Req_Contents.Name = "lbl_Req_Contents";
			this.lbl_Req_Contents.Size = new System.Drawing.Size(100, 21);
			this.lbl_Req_Contents.TabIndex = 289;
			this.lbl_Req_Contents.Text = "요청내용";
			this.lbl_Req_Contents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Type
			// 
			this.lbl_Type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Type.ImageIndex = 1;
			this.lbl_Type.ImageList = this.img_Label;
			this.lbl_Type.Location = new System.Drawing.Point(24, 170);
			this.lbl_Type.Name = "lbl_Type";
			this.lbl_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_Type.TabIndex = 288;
			this.lbl_Type.Text = "요청구분";
			this.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_GetDate
			// 
			this.lbl_GetDate.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_GetDate.ImageIndex = 1;
			this.lbl_GetDate.ImageList = this.img_Label;
			this.lbl_GetDate.Location = new System.Drawing.Point(24, 91);
			this.lbl_GetDate.Name = "lbl_GetDate";
			this.lbl_GetDate.Size = new System.Drawing.Size(100, 21);
			this.lbl_GetDate.TabIndex = 287;
			this.lbl_GetDate.Text = "요청일자";
			this.lbl_GetDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Menu_Pg
			// 
			this.lbl_Menu_Pg.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Menu_Pg.ImageIndex = 1;
			this.lbl_Menu_Pg.ImageList = this.img_Label;
			this.lbl_Menu_Pg.Location = new System.Drawing.Point(272, 69);
			this.lbl_Menu_Pg.Name = "lbl_Menu_Pg";
			this.lbl_Menu_Pg.Size = new System.Drawing.Size(100, 21);
			this.lbl_Menu_Pg.TabIndex = 286;
			this.lbl_Menu_Pg.Text = "프로그램 ID";
			this.lbl_Menu_Pg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(24, 69);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 285;
			this.lbl_Factory.Text = "공장코드";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_Menu_Pg
			// 
			this.txt_Menu_Pg.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Menu_Pg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Menu_Pg.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Menu_Pg.Location = new System.Drawing.Point(373, 69);
			this.txt_Menu_Pg.MaxLength = 10;
			this.txt_Menu_Pg.Name = "txt_Menu_Pg";
			this.txt_Menu_Pg.ReadOnly = true;
			this.txt_Menu_Pg.Size = new System.Drawing.Size(128, 21);
			this.txt_Menu_Pg.TabIndex = 279;
			this.txt_Menu_Pg.TabStop = false;
			this.txt_Menu_Pg.Text = "";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Owner = this;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 11;
			this.btn_Save.ImageList = this.image_List;
			this.btn_Save.Location = new System.Drawing.Point(430, 16);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(80, 24);
			this.btn_Save.TabIndex = 340;
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 100);
			this.groupBox1.TabIndex = 341;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Location = new System.Drawing.Point(8, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(504, 152);
			this.groupBox2.TabIndex = 342;
			this.groupBox2.TabStop = false;
			// 
			// Pop_Menu_SOS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(522, 312);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.cmb_Type);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.cmb_GetDate);
			this.Controls.Add(this.lbl_User);
			this.Controls.Add(this.txt_User);
			this.Controls.Add(this.txt_Req_Contents);
			this.Controls.Add(this.txt_Maint_User);
			this.Controls.Add(this.txt_Dev_User);
			this.Controls.Add(this.lbl_Maint_User);
			this.Controls.Add(this.lbl_Dev_User);
			this.Controls.Add(this.lbl_Req_Contents);
			this.Controls.Add(this.lbl_Type);
			this.Controls.Add(this.lbl_GetDate);
			this.Controls.Add(this.lbl_Menu_Pg);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.txt_Menu_Pg);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "Pop_Menu_SOS";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Program Request";
			this.Load += new System.EventHandler(this.Pop_Menu_SOS_Load);
			this.Closed += new System.EventHandler(this.Pop_Menu_SOS_Closed);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.txt_Menu_Pg, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.Controls.SetChildIndex(this.lbl_Menu_Pg, 0);
			this.Controls.SetChildIndex(this.lbl_GetDate, 0);
			this.Controls.SetChildIndex(this.lbl_Type, 0);
			this.Controls.SetChildIndex(this.lbl_Req_Contents, 0);
			this.Controls.SetChildIndex(this.lbl_Dev_User, 0);
			this.Controls.SetChildIndex(this.lbl_Maint_User, 0);
			this.Controls.SetChildIndex(this.txt_Dev_User, 0);
			this.Controls.SetChildIndex(this.txt_Maint_User, 0);
			this.Controls.SetChildIndex(this.txt_Req_Contents, 0);
			this.Controls.SetChildIndex(this.txt_User, 0);
			this.Controls.SetChildIndex(this.lbl_User, 0);
			this.Controls.SetChildIndex(this.cmb_GetDate, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.cmb_Type, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();
		private bool modiyfy_mode = false;
		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			DataTable dt_ret;

			// Title 값 지정
			this.Text = "Program Request";
			this.lbl_MainTitle.Text = "Program Request";

			//영문변환 사용
			ComFunction.SetLangDic(this);

			txt_Factory.Text = ComVar.Parameter_PopUp[0];
			txt_Menu_Pg.Text = ComVar.Parameter_PopUp[1];
			txt_User.Text = COM.ComVar.This_User;

			//요청타입 콤보
			dt_ret = ComVar.Select_ComCode(txt_Factory.Text,"SBC03");
			ComCtl.Set_ComboList(dt_ret,cmb_Type, 1, 2, false);

			dt_ret.Dispose();
		}

		/// <summary>
		/// Modify_Mode : 수정 가능/불가능 모드 Setting 
		/// </summary>
		/// <param name="arg_TrueFalse">가능/불가능 첵크</param>
		private void Modify_Mode(bool arg_TrueFalse)
		{
			modiyfy_mode = arg_TrueFalse;

			txt_Menu_Pg.Enabled		  = arg_TrueFalse;
			cmb_GetDate.Enabled		  = arg_TrueFalse;
			txt_User.Enabled		  = arg_TrueFalse;
			cmb_Type.Enabled		  = arg_TrueFalse;
			txt_Req_Contents.Enabled  = arg_TrueFalse;
			txt_Dev_User.Enabled      = arg_TrueFalse;
			txt_Maint_User.Enabled    = arg_TrueFalse;
		}

		#endregion 

		#region DB Connect

		/// <summary>
		/// Request 저장
		/// </summary>
		private void Save_Request()
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(9); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_MENU_SOS.INSERT_SCM_MENU_SOS";
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MENU_PG"; 
			MyOraDB.Parameter_Name[2] = "ARG_REQ_USER"; 
			MyOraDB.Parameter_Name[3] = "ARG_REQ_TYPE"; 
			MyOraDB.Parameter_Name[4] = "ARG_REQ_CONTENTS"; 
			MyOraDB.Parameter_Name[5] = "ARG_DEV_USER"; 
			MyOraDB.Parameter_Name[6] = "ARG_MAINT_USER"; 
			MyOraDB.Parameter_Name[7] = "ARG_STATUS"; 
			MyOraDB.Parameter_Name[8] = "ARG_UPD_USER"; 


			//03.DATA TYPE
			for (int i = 0; i <= 8; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}			

			//04.DATA 정의 
			MyOraDB.Parameter_Values[0] = txt_Factory.Text;
			MyOraDB.Parameter_Values[1] = txt_Menu_Pg.Text;
			MyOraDB.Parameter_Values[2] = txt_User.Text;
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_Type, " ");
			MyOraDB.Parameter_Values[4] = txt_Req_Contents.Text; 
			MyOraDB.Parameter_Values[5] = txt_Dev_User.Text; 
			MyOraDB.Parameter_Values[6] = txt_Maint_User.Text; 
			MyOraDB.Parameter_Values[7] = "1"; 
			MyOraDB.Parameter_Values[8] = ComVar.This_User; 

			MyOraDB.Add_Modify_Parameter(true); 

			ds_ret =  MyOraDB.Exe_Modify_Procedure();		

			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ;
				
			}
		}

		#endregion 

		#region 이벤트

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			Save_Request();
			this.Close();
		}

		private void Pop_Menu_SOS_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Pop_Menu_SOS_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		#endregion

		#region 버튼클릭시 이미지변경

		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 11;
		}

		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 10;
		}

		#endregion

	}
}

