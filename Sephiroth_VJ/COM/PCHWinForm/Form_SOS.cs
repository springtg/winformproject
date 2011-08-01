using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace COM.PCHWinForm
{
	public class Form_SOS : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private System.Windows.Forms.DateTimePicker cmb_GetDate;
		private C1.Win.C1List.C1Combo cmb_LFactory;
		private System.Windows.Forms.Label lbl_User;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.TextBox txt_Req_Contents;
		private System.Windows.Forms.TextBox txt_Type;
		private System.Windows.Forms.TextBox txt_Maint_User;
		private System.Windows.Forms.TextBox txt_Dev_User;
		private System.Windows.Forms.Label lbl_Maint_User;
		private System.Windows.Forms.Label lbl_Dev_User;
		private System.Windows.Forms.Label lbl_Req_Contents;
		private System.Windows.Forms.Label lbl_Type;
		private System.Windows.Forms.Label lbl_Ymd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_Menu_Pg;
		private System.ComponentModel.IContainer components = null;

		public Form_SOS()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SOS));
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.cmb_GetDate = new System.Windows.Forms.DateTimePicker();
			this.cmb_LFactory = new C1.Win.C1List.C1Combo();
			this.lbl_User = new System.Windows.Forms.Label();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.txt_Req_Contents = new System.Windows.Forms.TextBox();
			this.txt_Type = new System.Windows.Forms.TextBox();
			this.txt_Maint_User = new System.Windows.Forms.TextBox();
			this.txt_Dev_User = new System.Windows.Forms.TextBox();
			this.lbl_Maint_User = new System.Windows.Forms.Label();
			this.lbl_Dev_User = new System.Windows.Forms.Label();
			this.lbl_Req_Contents = new System.Windows.Forms.Label();
			this.lbl_Type = new System.Windows.Forms.Label();
			this.lbl_Ymd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Menu_Pg = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LFactory)).BeginInit();
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
			// c1ToolBar1
			// 
			this.c1ToolBar1.CommandHolder = null;
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(464, 8);
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(24, 24);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// cmb_GetDate
			// 
			this.cmb_GetDate.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
			this.cmb_GetDate.CalendarMonthBackground = System.Drawing.Color.Yellow;
			this.cmb_GetDate.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
			this.cmb_GetDate.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.cmb_GetDate.CalendarTrailingForeColor = System.Drawing.Color.Green;
			this.cmb_GetDate.CustomFormat = "yyyy-mm-dd HH:MM";
			this.cmb_GetDate.Enabled = false;
			this.cmb_GetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmb_GetDate.Location = new System.Drawing.Point(112, 80);
			this.cmb_GetDate.Name = "cmb_GetDate";
			this.cmb_GetDate.Size = new System.Drawing.Size(128, 21);
			this.cmb_GetDate.TabIndex = 296;
			// 
			// cmb_LFactory
			// 
			this.cmb_LFactory.AddItemCols = 0;
			this.cmb_LFactory.AddItemSeparator = ';';
			//this.cmb_LFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LFactory.Caption = "";
			this.cmb_LFactory.CaptionHeight = 17;
			this.cmb_LFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LFactory.ColumnCaptionHeight = 18;
			this.cmb_LFactory.ColumnFooterHeight = 18;
			this.cmb_LFactory.ContentHeight = 17;
			this.cmb_LFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LFactory.EditorHeight = 17;
			this.cmb_LFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LFactory.GapHeight = 2;
			this.cmb_LFactory.ItemHeight = 15;
			this.cmb_LFactory.Location = new System.Drawing.Point(112, 48);
			this.cmb_LFactory.MatchEntryTimeout = ((long)(2000));
			this.cmb_LFactory.MaxDropDownItems = ((short)(5));
			this.cmb_LFactory.MaxLength = 32767;
			this.cmb_LFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LFactory.Name = "cmb_LFactory";
			//this.cmb_LFactory.PartialRightColumn = false;
			this.cmb_LFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LFactory.Size = new System.Drawing.Size(128, 23);
			this.cmb_LFactory.TabIndex = 280;
			// 
			// lbl_User
			// 
			this.lbl_User.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_User.ImageIndex = 1;
			this.lbl_User.ImageList = this.img_Label;
			this.lbl_User.Location = new System.Drawing.Point(272, 80);
			this.lbl_User.Name = "lbl_User";
			this.lbl_User.Size = new System.Drawing.Size(100, 21);
			this.lbl_User.TabIndex = 295;
			this.lbl_User.Text = "요청사용자";
			this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_User
			// 
			this.txt_User.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_User.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_User.Location = new System.Drawing.Point(376, 80);
			this.txt_User.MaxLength = 10;
			this.txt_User.Name = "txt_User";
			this.txt_User.ReadOnly = true;
			this.txt_User.Size = new System.Drawing.Size(128, 21);
			this.txt_User.TabIndex = 294;
			this.txt_User.TabStop = false;
			this.txt_User.Text = "";
			// 
			// txt_Req_Contents
			// 
			this.txt_Req_Contents.BackColor = System.Drawing.Color.White;
			this.txt_Req_Contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Req_Contents.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Req_Contents.ForeColor = System.Drawing.Color.Black;
			this.txt_Req_Contents.Location = new System.Drawing.Point(112, 176);
			this.txt_Req_Contents.Multiline = true;
			this.txt_Req_Contents.Name = "txt_Req_Contents";
			this.txt_Req_Contents.Size = new System.Drawing.Size(392, 104);
			this.txt_Req_Contents.TabIndex = 282;
			this.txt_Req_Contents.Text = "";
			// 
			// txt_Type
			// 
			this.txt_Type.BackColor = System.Drawing.Color.White;
			this.txt_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Type.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Type.Location = new System.Drawing.Point(112, 144);
			this.txt_Type.MaxLength = 10;
			this.txt_Type.Name = "txt_Type";
			this.txt_Type.Size = new System.Drawing.Size(128, 21);
			this.txt_Type.TabIndex = 281;
			this.txt_Type.Text = "";
			// 
			// txt_Maint_User
			// 
			this.txt_Maint_User.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Maint_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Maint_User.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Maint_User.Location = new System.Drawing.Point(376, 112);
			this.txt_Maint_User.MaxLength = 10;
			this.txt_Maint_User.Name = "txt_Maint_User";
			this.txt_Maint_User.ReadOnly = true;
			this.txt_Maint_User.Size = new System.Drawing.Size(128, 21);
			this.txt_Maint_User.TabIndex = 293;
			this.txt_Maint_User.TabStop = false;
			this.txt_Maint_User.Text = "";
			// 
			// txt_Dev_User
			// 
			this.txt_Dev_User.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Dev_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dev_User.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Dev_User.Location = new System.Drawing.Point(112, 112);
			this.txt_Dev_User.MaxLength = 10;
			this.txt_Dev_User.Name = "txt_Dev_User";
			this.txt_Dev_User.ReadOnly = true;
			this.txt_Dev_User.Size = new System.Drawing.Size(128, 21);
			this.txt_Dev_User.TabIndex = 292;
			this.txt_Dev_User.TabStop = false;
			this.txt_Dev_User.Text = "";
			// 
			// lbl_Maint_User
			// 
			this.lbl_Maint_User.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Maint_User.ImageIndex = 1;
			this.lbl_Maint_User.ImageList = this.img_Label;
			this.lbl_Maint_User.Location = new System.Drawing.Point(272, 112);
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
			this.lbl_Dev_User.Location = new System.Drawing.Point(8, 112);
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
			this.lbl_Req_Contents.Location = new System.Drawing.Point(8, 176);
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
			this.lbl_Type.Location = new System.Drawing.Point(8, 144);
			this.lbl_Type.Name = "lbl_Type";
			this.lbl_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_Type.TabIndex = 288;
			this.lbl_Type.Text = "요청구분";
			this.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Ymd
			// 
			this.lbl_Ymd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Ymd.ImageIndex = 1;
			this.lbl_Ymd.ImageList = this.img_Label;
			this.lbl_Ymd.Location = new System.Drawing.Point(8, 80);
			this.lbl_Ymd.Name = "lbl_Ymd";
			this.lbl_Ymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_Ymd.TabIndex = 287;
			this.lbl_Ymd.Text = "요청일자";
			this.lbl_Ymd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(272, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 286;
			this.label1.Text = "프로그램 ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 48);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 284;
			this.lbl_Factory.Text = "공장코드";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_Menu_Pg
			// 
			this.txt_Menu_Pg.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txt_Menu_Pg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Menu_Pg.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Menu_Pg.Location = new System.Drawing.Point(376, 48);
			this.txt_Menu_Pg.MaxLength = 10;
			this.txt_Menu_Pg.Name = "txt_Menu_Pg";
			this.txt_Menu_Pg.ReadOnly = true;
			this.txt_Menu_Pg.Size = new System.Drawing.Size(128, 21);
			this.txt_Menu_Pg.TabIndex = 285;
			this.txt_Menu_Pg.TabStop = false;
			this.txt_Menu_Pg.Text = "";
			// 
			// Form_SOS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(514, 296);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.cmb_GetDate);
			this.Controls.Add(this.cmb_LFactory);
			this.Controls.Add(this.lbl_User);
			this.Controls.Add(this.txt_User);
			this.Controls.Add(this.txt_Req_Contents);
			this.Controls.Add(this.txt_Type);
			this.Controls.Add(this.txt_Maint_User);
			this.Controls.Add(this.txt_Dev_User);
			this.Controls.Add(this.lbl_Maint_User);
			this.Controls.Add(this.lbl_Dev_User);
			this.Controls.Add(this.lbl_Req_Contents);
			this.Controls.Add(this.lbl_Type);
			this.Controls.Add(this.lbl_Ymd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.txt_Menu_Pg);
			this.Name = "Form_SOS";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.txt_Menu_Pg, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lbl_Ymd, 0);
			this.Controls.SetChildIndex(this.lbl_Type, 0);
			this.Controls.SetChildIndex(this.lbl_Req_Contents, 0);
			this.Controls.SetChildIndex(this.lbl_Dev_User, 0);
			this.Controls.SetChildIndex(this.lbl_Maint_User, 0);
			this.Controls.SetChildIndex(this.txt_Dev_User, 0);
			this.Controls.SetChildIndex(this.txt_Maint_User, 0);
			this.Controls.SetChildIndex(this.txt_Type, 0);
			this.Controls.SetChildIndex(this.txt_Req_Contents, 0);
			this.Controls.SetChildIndex(this.txt_User, 0);
			this.Controls.SetChildIndex(this.lbl_User, 0);
			this.Controls.SetChildIndex(this.cmb_LFactory, 0);
			this.Controls.SetChildIndex(this.cmb_GetDate, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LFactory)).EndInit();
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
			DataTable dt_ret;

			// Title 값 지정
			this.Text = "Menu SOS";
			this.lbl_MainTitle.Text = "Menu SOS";

			//Factory
			dt_ret = ComFunction.Select_Factory_List();
			ComCtl.Set_ComboList(dt_ret, cmb_LFactory, 0, 1, false); 
			cmb_LFactory.SelectedValue = ComVar.This_Factory;

			txt_Menu_Pg.Text = COM.ComVar.Parameter_PopUp[0];
			txt_User.Text = COM.ComVar.This_User;

		}

		#endregion 

		private void Pop_MenuSOS_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		#region DB Connect

		/// <summary>
		/// Save_Code : 공통 코드 저장
		/// </summary>
		private void Save_Code()
		{
			//DataSet ds_ret;

			MyOraDB.ReDim_Parameter(11); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_CODE.SAVE_CODE_LIST";
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_MENU_PG"; 
			//MyOraDB.Parameter_Name[3] = "ARG_SEQ"; 
			MyOraDB.Parameter_Name[3] = "ARG_REQ_YMD"; 
			MyOraDB.Parameter_Name[4] = "ARG_REQ_USER"; 
			MyOraDB.Parameter_Name[5] = "ARG_REQ_TYPE"; 
			MyOraDB.Parameter_Name[6] = "ARG_REQ_CONTENTS"; 
			MyOraDB.Parameter_Name[7] = "ARG_DEV_USER"; 
			MyOraDB.Parameter_Name[8] = "ARG_MAINT_USER"; 
			MyOraDB.Parameter_Name[9] = "ARG_STATUS"; 
			MyOraDB.Parameter_Name[10] = "ARG_UPD_YMD"; 


			//03.DATA TYPE
			for (int i = 0; i <= 10; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}			

			
			//04.DATA 정의 

			/*			if (COM.ComVar.Parameter_PopUp[1] == "" || COM.ComVar.Parameter_PopUp[1] != txt_Code.Text)    //초기 코드 없는 경우 (신규일때)
						{
							MyOraDB.Parameter_Values[0] = "I";
						}
						else
						{
							MyOraDB.Parameter_Values[0] = "U";
						} 
			 
						MyOraDB.Parameter_Values[1] = this.cmb_TblFactory.SelectedValue.ToString(); 
						MyOraDB.Parameter_Values[2] = txt_Menu_Pg.Text;
						//MyOraDB.Parameter_Values[3] = "0"; 
						MyOraDB.Parameter_Values[3] = this.cmb_GetDate.Value.ToString(); 
						MyOraDB.Parameter_Values[4] = txt_User.Text;
						MyOraDB.Parameter_Values[5] = txt_Type.Text; 
						MyOraDB.Parameter_Values[6] = txt_Contents.Text; 
						MyOraDB.Parameter_Values[7] = txt_Dev_User.Text; 
						MyOraDB.Parameter_Values[8] = txt_Maint_User.Text; 
						MyOraDB.Parameter_Values[9] = '1'; 
						MyOraDB.Parameter_Values[10] = COM.ComVar.This_User; 

						MyOraDB.Add_Modify_Parameter(true); 

						ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
						//Error 처리
						if(ds_ret == null) 
						{
							MessageBox.Show("Error") ;
				
						}*/
		}

		#endregion 

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
	/*		if(modiyfy_mode)
			{

				MyOraDB.Parameter_Values[1] = this.cmb_TblFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = txt_Menu_Pg.Text;
				//MyOraDB.Parameter_Values[3] = "0"; 
				MyOraDB.Parameter_Values[3] = this.cmb_GetDate.Value.ToString(); 
				MyOraDB.Parameter_Values[4] = txt_User.Text;
				MyOraDB.Parameter_Values[5] = txt_Type.Text; 
				MyOraDB.Parameter_Values[6] = txt_Contents.Text; 
				MyOraDB.Parameter_Values[7] = txt_Dev_User.Text; 
				MyOraDB.Parameter_Values[8] = txt_Maint_User.Text; 
				MyOraDB.Parameter_Values[9] = '1'; 
				MyOraDB.Parameter_Values[10] = COM.ComVar.This_User; 


				string[] ArrayItem = new string[12];
				ArrayItem[0] = cmb_TblFactory.SelectedValue.ToString(); 
				ArrayItem[1] = txt_Menu_Pg.Text;
				ArrayItem[2] = cmb_GetDate.Value.ToString(); 
				ArrayItem[3] = txt_User.Text;

				ArrayItem[4] = txt_Type.Text;
				ArrayItem[5] = txt_Contents.Text;
				ArrayItem[6] = txt_Dev_User.Text;
				ArrayItem[7] = txt_body_h.Text;
				ArrayItem[8] = txt_body_t.Text;
				ArrayItem[9] = Check_TrueFalse(chk_useyn.Checked);
				ArrayItem[10] = Check_TrueFalse(chk_mail.Checked);

				ArrayItem[11]= ClassLib.ComVar.This_User;

				Save_Notice_Datil(ArrayItem);
		
				Modify_Mode(false); //수정 불가능 모드
				Modify_Mode1(true);
		
				tbtn_search_Click(sender, e);
			}	*/
		}
	}
}

