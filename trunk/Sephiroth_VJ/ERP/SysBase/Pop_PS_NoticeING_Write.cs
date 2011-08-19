using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeING_Write : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_jobcd;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.TextBox txt_title;
		private System.Windows.Forms.TextBox txt_body;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1Command tbtn_send;
		private C1.Win.C1Command.C1Command tbtn_clear;
		private C1.Win.C1Command.C1Command tbtn_close;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_jobcd;
		private System.Windows.Forms.Label lbl_edate;
		private System.Windows.Forms.DateTimePicker dpick_end;



		#region 사용자 변수

		private COM.OraDB oraDB = new COM.OraDB();

		private System.Windows.Forms.Label lbl_news;
		private System.Windows.Forms.CheckBox chk_news;
		
		private Pop_PS_NoticeING_List frm = null;
		
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_cencal;
		private System.Windows.Forms.Label lbl_save;
		private System.Windows.Forms.GroupBox groupBox1;
		
		private bool notice_load = false;

		#endregion

		public Pop_PS_NoticeING_Write(Pop_PS_NoticeING_List arg_frm)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			frm = arg_frm;
		}

		public Pop_PS_NoticeING_Write()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeING_Write));
			this.lbl_jobcd = new System.Windows.Forms.Label();
			this.lbl_title = new System.Windows.Forms.Label();
			this.txt_title = new System.Windows.Forms.TextBox();
			this.txt_body = new System.Windows.Forms.TextBox();
			this.cmb_jobcd = new C1.Win.C1List.C1Combo();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_send = new C1.Win.C1Command.C1Command();
			this.tbtn_clear = new C1.Win.C1Command.C1Command();
			this.tbtn_close = new C1.Win.C1Command.C1Command();
			this.lbl_edate = new System.Windows.Forms.Label();
			this.dpick_end = new System.Windows.Forms.DateTimePicker();
			this.lbl_news = new System.Windows.Forms.Label();
			this.chk_news = new System.Windows.Forms.CheckBox();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_cencal = new System.Windows.Forms.Label();
			this.lbl_save = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobcd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			// lbl_jobcd
			// 
			this.lbl_jobcd.ImageIndex = 0;
			this.lbl_jobcd.ImageList = this.img_Label;
			this.lbl_jobcd.Location = new System.Drawing.Point(5, 17);
			this.lbl_jobcd.Name = "lbl_jobcd";
			this.lbl_jobcd.Size = new System.Drawing.Size(100, 21);
			this.lbl_jobcd.TabIndex = 226;
			this.lbl_jobcd.Text = "업무";
			this.lbl_jobcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(5, 39);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 228;
			this.lbl_title.Text = "제목";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_title
			// 
			this.txt_title.BackColor = System.Drawing.Color.White;
			this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_title.Location = new System.Drawing.Point(106, 39);
			this.txt_title.Name = "txt_title";
			this.txt_title.Size = new System.Drawing.Size(569, 21);
			this.txt_title.TabIndex = 230;
			this.txt_title.Text = "";
			// 
			// txt_body
			// 
			this.txt_body.BackColor = System.Drawing.Color.White;
			this.txt_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_body.Location = new System.Drawing.Point(5, 112);
			this.txt_body.Multiline = true;
			this.txt_body.Name = "txt_body";
			this.txt_body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_body.Size = new System.Drawing.Size(685, 280);
			this.txt_body.TabIndex = 231;
			this.txt_body.Text = "";
			// 
			// cmb_jobcd
			// 
			this.cmb_jobcd.AddItemCols = 0;
			this.cmb_jobcd.AddItemSeparator = ';';
			this.cmb_jobcd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_jobcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_jobcd.Caption = "";
			this.cmb_jobcd.CaptionHeight = 17;
			this.cmb_jobcd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_jobcd.ColumnCaptionHeight = 18;
			this.cmb_jobcd.ColumnFooterHeight = 18;
			this.cmb_jobcd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_jobcd.ContentHeight = 17;
			this.cmb_jobcd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_jobcd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_jobcd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobcd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_jobcd.EditorHeight = 17;
			this.cmb_jobcd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobcd.GapHeight = 2;
			this.cmb_jobcd.ItemHeight = 15;
			this.cmb_jobcd.Location = new System.Drawing.Point(106, 17);
			this.cmb_jobcd.MatchEntryTimeout = ((long)(2000));
			this.cmb_jobcd.MaxDropDownItems = ((short)(5));
			this.cmb_jobcd.MaxLength = 32767;
			this.cmb_jobcd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_jobcd.Name = "cmb_jobcd";
			this.cmb_jobcd.PartialRightColumn = false;
			this.cmb_jobcd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_jobcd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_jobcd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_jobcd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_jobcd.Size = new System.Drawing.Size(160, 21);
			this.cmb_jobcd.TabIndex = 233;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_send);
			this.c1CommandHolder1.Commands.Add(this.tbtn_clear);
			this.c1CommandHolder1.Commands.Add(this.tbtn_close);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_send
			// 
			this.tbtn_send.Name = "tbtn_send";
			// 
			// tbtn_clear
			// 
			this.tbtn_clear.Name = "tbtn_clear";
			// 
			// tbtn_close
			// 
			this.tbtn_close.Name = "tbtn_close";
			// 
			// lbl_edate
			// 
			this.lbl_edate.ImageIndex = 0;
			this.lbl_edate.ImageList = this.img_Label;
			this.lbl_edate.Location = new System.Drawing.Point(416, 17);
			this.lbl_edate.Name = "lbl_edate";
			this.lbl_edate.Size = new System.Drawing.Size(100, 21);
			this.lbl_edate.TabIndex = 242;
			this.lbl_edate.Text = "공지 기간";
			this.lbl_edate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_end
			// 
			this.dpick_end.CustomFormat = "";
			this.dpick_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_end.Location = new System.Drawing.Point(517, 17);
			this.dpick_end.Name = "dpick_end";
			this.dpick_end.Size = new System.Drawing.Size(160, 21);
			this.dpick_end.TabIndex = 243;
			// 
			// lbl_news
			// 
			this.lbl_news.ImageIndex = 0;
			this.lbl_news.ImageList = this.img_Label;
			this.lbl_news.Location = new System.Drawing.Point(284, 17);
			this.lbl_news.Name = "lbl_news";
			this.lbl_news.Size = new System.Drawing.Size(100, 21);
			this.lbl_news.TabIndex = 245;
			this.lbl_news.Text = "공지 첵크";
			this.lbl_news.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_news
			// 
			this.chk_news.BackColor = System.Drawing.Color.Transparent;
			this.chk_news.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_news.Location = new System.Drawing.Point(384, 18);
			this.chk_news.Name = "chk_news";
			this.chk_news.Size = new System.Drawing.Size(17, 21);
			this.chk_news.TabIndex = 246;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_cencal
			// 
			this.btn_cencal.ImageIndex = 10;
			this.btn_cencal.ImageList = this.imgs_new_btn;
			this.btn_cencal.Location = new System.Drawing.Point(610, 401);
			this.btn_cencal.Name = "btn_cencal";
			this.btn_cencal.Size = new System.Drawing.Size(80, 23);
			this.btn_cencal.TabIndex = 248;
			this.btn_cencal.Click += new System.EventHandler(this.btn_cencal_Click);
			// 
			// lbl_save
			// 
			this.lbl_save.ImageIndex = 2;
			this.lbl_save.ImageList = this.imgs_new_btn;
			this.lbl_save.Location = new System.Drawing.Point(529, 401);
			this.lbl_save.Name = "lbl_save";
			this.lbl_save.Size = new System.Drawing.Size(80, 23);
			this.lbl_save.TabIndex = 249;
			this.lbl_save.Click += new System.EventHandler(this.lbl_save_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmb_jobcd);
			this.groupBox1.Controls.Add(this.lbl_jobcd);
			this.groupBox1.Controls.Add(this.lbl_title);
			this.groupBox1.Controls.Add(this.lbl_edate);
			this.groupBox1.Controls.Add(this.dpick_end);
			this.groupBox1.Controls.Add(this.lbl_news);
			this.groupBox1.Controls.Add(this.chk_news);
			this.groupBox1.Controls.Add(this.txt_title);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 67);
			this.groupBox1.TabIndex = 250;
			this.groupBox1.TabStop = false;
			// 
			// Pop_PS_NoticeING_Write
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 432);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbl_save);
			this.Controls.Add(this.btn_cencal);
			this.Controls.Add(this.txt_body);
			this.Name = "Pop_PS_NoticeING_Write";
			this.Text = "Work List";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PS_NoticeING_Write_Closing);
			this.Load += new System.EventHandler(this.Form_PC_NoticeING_Write_Load);
			this.Controls.SetChildIndex(this.txt_body, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_cencal, 0);
			this.Controls.SetChildIndex(this.lbl_save, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobcd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 메소드

		private void init_Form()
		{
			this.Text = "Job Message Write";
			this.lbl_MainTitle.Text = "Write Message";

			ClassLib.ComFunction.SetLangDic(this);


			dpick_end.CustomFormat = ClassLib.ComVar.This_SetedDateType;

			oraDB = new COM.OraDB();

			DataTable dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxJobCd);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_jobcd, 1, 2, false);
			cmb_jobcd.SelectedValue = ClassLib.ComVar.This_JobCdoe;


			cmb_jobcd.SelectedValue = ClassLib.ComVar.This_JobCdoe;

			dpick_end.Value = DateTime.Now.AddDays(7);
		}

		private void Send_Message()
		{
			string sender_id     = ClassLib.ComVar.This_User;
			string sender_name   = ClassLib.ComVar.This_Name;
			string job_cd = cmb_jobcd.SelectedValue.ToString();
			string title = txt_title.Text;
			string body  = txt_body.Text;


			COM.ComFunction comfunc = new COM.ComFunction();
			string edate = comfunc.ConvertDate2DbType(dpick_end.Text);




			string[] ArrayItem = new string[11];

			ArrayItem[0]  = ClassLib.ComVar.This_Factory;
			ArrayItem[1]  = "A";
			ArrayItem[2]  = edate;
			ArrayItem[3]  = job_cd;
			ArrayItem[4]  = sender_id;
			ArrayItem[5]  = sender_name;
			ArrayItem[6]  = "system";
			ArrayItem[7]  = "system";
			ArrayItem[8]  = title;
			ArrayItem[9]  = body;
			ArrayItem[10] = sender_id;


			Insert_Sps_Notice_IngWork(ArrayItem);

			if(chk_news.Checked)
			{
				string stdate;

				string yyyy = DateTime.Now.Year.ToString();

				string MM = DateTime.Now.Month.ToString();

				if(MM.Length == 1)
				{
					MM = "0" + MM;
				}

				string dd = DateTime.Now.Day.ToString();

				if(dd.Length == 1)
				{
					dd = "0" + dd;
				}

				stdate = yyyy + MM + dd;

				Pop_PS_NoticeWrite write = new Pop_PS_NoticeWrite();
				write.Insert_Notice_ref(sender_id, sender_name, title,stdate,edate,body);


				notice_load = true;
			}
		}

		#endregion

		#region 이벤트

		private void Form_PC_NoticeING_Write_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void Form_PS_NoticeING_Write_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(frm != null)
			{
				frm.Get_Grid_List_Ref("U", "", notice_load);

			}
		}

		private void btn_cencal_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void lbl_save_Click(object sender, System.EventArgs e)
		{
			if(txt_title.Text.Length == 0)
			{
				ClassLib.ComFunction.User_Message("Input Title!");
				txt_title.Focus();
				return;
			}
			else if(txt_body.Text.Length == 0)
			{
				ClassLib.ComFunction.User_Message("Input Contents!");
				txt_body.Focus();
				return;
			}
			else
			{
				Send_Message();
				Close();
			}
		}

		#endregion

		#region DB 접속

		/// <summary>
		/// Insert_Sps_Notice_IngWork : 진행중인 업무 메시지 보내기
		/// </summary>
		/// <param name="arg_arrayitem">입력할 데이터 배열</param>
		private void Insert_Sps_Notice_IngWork(string[] arg_arrayitem)
		{
			string Proc_Name = "PKG_SPS_HOME.INSERT_SPS_NOTICE_INGWORK";

			oraDB.ReDim_Parameter(11);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_DIVISION";
			oraDB.Parameter_Name[2]  = "ARG_EDATE";
			oraDB.Parameter_Name[3]  = "ARG_JOB_CD";
			oraDB.Parameter_Name[4]  = "ARG_SUSER_ID";
			oraDB.Parameter_Name[5]  = "ARG_SUSER_NAME";
			oraDB.Parameter_Name[6]  = "ARG_RUSER_ID";
			oraDB.Parameter_Name[7]  = "ARG_RUSER_NAME";
			oraDB.Parameter_Name[8]  = "ARG_TITLE";
			oraDB.Parameter_Name[9]  = "ARG_MESSAGE";
			oraDB.Parameter_Name[10] = "ARG_UPD_USER";

			for(int i=0; i<arg_arrayitem.Length; i++)
			{
				oraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}

			for(int i=0; i<arg_arrayitem.Length; i++)
			{
				oraDB.Parameter_Values[i] = arg_arrayitem[i].ToString();
			}

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}


		/// <summary>
		/// Get_Name : 사용자 이름,메일 주소 가져오기 가져오기
		/// </summary>
		/// <param name="arg_user_id">사용자 아이디</param>
		/// <returns>정상:DataTable ,오류:null</returns>
		private DataTable Get_Name(string arg_user_id)
		{

			string Proc_Name = "PKG_SPS_HOME.GET_USER_NAME";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_USER_ID";
			oraDB.Parameter_Name[2]  = "OUT_CURSOR";

			oraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2]  = (int)OracleType.Cursor;


			oraDB.Parameter_Values[0]  = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1]  = arg_user_id;
			oraDB.Parameter_Values[2]  = "";

			oraDB.Add_Select_Parameter(true); 
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		


		#endregion



		
	}
}

