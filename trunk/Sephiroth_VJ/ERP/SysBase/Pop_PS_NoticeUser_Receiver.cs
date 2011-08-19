using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeUser_Receiver : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.TextBox txt_subject;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label lbl_receive_id;
		private System.ComponentModel.IContainer components = null;


		#region 사용자 변수

		private COM.OraDB oraDB;
		private string factory;
		private string div;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1Command tbtn_answer;
		private System.Windows.Forms.Label lbl_senderid;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_tite1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_cencal;
		private string seq;
		private Pop_PS_NoticeAuto_User frm = null;
		private System.Windows.Forms.Label label1;
		private Form_Home home_frm = null;
		#endregion

		public Pop_PS_NoticeUser_Receiver(Pop_PS_NoticeAuto_User arg_frm, string arg_factory, string arg_div, string arg_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			frm = arg_frm;


			factory = arg_factory;
			div = arg_div;
			seq = arg_seq;

			if(arg_div == "S" || arg_div == "A")
				c1ToolBar1.Visible = false;
		}

		public Pop_PS_NoticeUser_Receiver(Form_Home arg_frm, string arg_factory, string arg_div, string arg_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			home_frm = arg_frm;


			factory = arg_factory;
			div = arg_div;
			seq = arg_seq;

			if(arg_div == "S" || arg_div == "A")
				c1ToolBar1.Visible = false;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeUser_Receiver));
			this.txt_subject = new System.Windows.Forms.TextBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.lbl_receive_id = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_answer = new C1.Win.C1Command.C1Command();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.lbl_senderid = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_tite1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_cencal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
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
			// txt_subject
			// 
			this.txt_subject.BackColor = System.Drawing.Color.White;
			this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_subject.Location = new System.Drawing.Point(8, 88);
			this.txt_subject.Multiline = true;
			this.txt_subject.Name = "txt_subject";
			this.txt_subject.ReadOnly = true;
			this.txt_subject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_subject.Size = new System.Drawing.Size(680, 344);
			this.txt_subject.TabIndex = 222;
			this.txt_subject.Text = "";
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(8, 62);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 225;
			this.lbl_title.Text = "제목";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_receive_id
			// 
			this.lbl_receive_id.ImageIndex = 0;
			this.lbl_receive_id.ImageList = this.img_Label;
			this.lbl_receive_id.Location = new System.Drawing.Point(8, 40);
			this.lbl_receive_id.Name = "lbl_receive_id";
			this.lbl_receive_id.Size = new System.Drawing.Size(100, 21);
			this.lbl_receive_id.TabIndex = 223;
			this.lbl_receive_id.Text = "보낸 아이디";
			this.lbl_receive_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(655, 8);
			this.c1ToolBar1.MinButtonSize = 30;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(30, 30);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_answer);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_answer
			// 
			this.tbtn_answer.ImageIndex = 4;
			this.tbtn_answer.Name = "tbtn_answer";
			this.tbtn_answer.Text = "Answer";
			this.tbtn_answer.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_answer_Click);
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.tbtn_answer;
			// 
			// lbl_senderid
			// 
			this.lbl_senderid.BackColor = System.Drawing.Color.Transparent;
			this.lbl_senderid.Location = new System.Drawing.Point(109, 39);
			this.lbl_senderid.Name = "lbl_senderid";
			this.lbl_senderid.Size = new System.Drawing.Size(576, 21);
			this.lbl_senderid.TabIndex = 228;
			this.lbl_senderid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(109, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(576, 1);
			this.panel1.TabIndex = 250;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(560, 1);
			this.panel3.TabIndex = 251;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Location = new System.Drawing.Point(0, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(560, 1);
			this.panel4.TabIndex = 250;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Location = new System.Drawing.Point(0, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(560, 1);
			this.panel2.TabIndex = 250;
			// 
			// lbl_tite1
			// 
			this.lbl_tite1.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tite1.Location = new System.Drawing.Point(109, 62);
			this.lbl_tite1.Name = "lbl_tite1";
			this.lbl_tite1.Size = new System.Drawing.Size(576, 21);
			this.lbl_tite1.TabIndex = 251;
			this.lbl_tite1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel5
			// 
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Location = new System.Drawing.Point(109, 82);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(576, 1);
			this.panel5.TabIndex = 252;
			// 
			// panel6
			// 
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(560, 1);
			this.panel6.TabIndex = 251;
			// 
			// panel7
			// 
			this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
			this.panel7.Location = new System.Drawing.Point(0, 16);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(560, 1);
			this.panel7.TabIndex = 250;
			// 
			// panel8
			// 
			this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
			this.panel8.Location = new System.Drawing.Point(0, 16);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(560, 1);
			this.panel8.TabIndex = 250;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_cencal
			// 
			this.btn_cencal.ImageIndex = 11;
			this.btn_cencal.ImageList = this.imgs_new_btn;
			this.btn_cencal.Location = new System.Drawing.Point(608, 440);
			this.btn_cencal.Name = "btn_cencal";
			this.btn_cencal.Size = new System.Drawing.Size(80, 23);
			this.btn_cencal.TabIndex = 253;
			this.btn_cencal.Click += new System.EventHandler(this.btn_cencal_Click);
			// 
			// label1
			// 
			this.label1.ImageIndex = 6;
			this.label1.ImageList = this.imgs_new_btn;
			this.label1.Location = new System.Drawing.Point(8, 440);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 255;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Pop_PS_NoticeUser_Receiver
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 472);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_cencal);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.lbl_tite1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbl_senderid);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.lbl_receive_id);
			this.Controls.Add(this.txt_subject);
			this.Name = "Pop_PS_NoticeUser_Receiver";
			this.Text = "Message View";
			this.Load += new System.EventHandler(this.Pop_PS_NoticeUser_Receiver_Load);
			this.Closed += new System.EventHandler(this.Pop_PS_NoticeUser_Receiver_Closed);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.txt_subject, 0);
			this.Controls.SetChildIndex(this.lbl_receive_id, 0);
			this.Controls.SetChildIndex(this.lbl_title, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.lbl_senderid, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_tite1, 0);
			this.Controls.SetChildIndex(this.panel5, 0);
			this.Controls.SetChildIndex(this.btn_cencal, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_PS_NoticeUser_Receiver_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			this.Text = "Auto Message For Job";
			this.lbl_MainTitle.Text = "Auto Message View";

			ClassLib.ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();
			DataTable dt = Select_SPS_Notice_User(factory, div, seq);

			lbl_senderid.Text = dt.Rows[0].ItemArray[3].ToString();
			lbl_tite1.Text     = dt.Rows[0].ItemArray[6].ToString();
			txt_subject.Text   = dt.Rows[0].ItemArray[7].ToString();

			Update_SPS_Notice_User(factory, div, seq);
		}

		private string Get_Name(string arg_user_id)
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
			DataSet DS_Ret =oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			

			try
			{

				if(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[1].ToString().Trim().Length != 0)
					return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[1].ToString();
				else
					return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[2].ToString();
			}
			catch
			{
				return null;
			}

		}

		/// <summary>
		/// Send_Mess : 메시지(개인 업무 알림) 보내기
		/// </summary>
		/// <param name="arg_division">Save Code</param>
		/// <param name="arg_div">S/R</param>
		/// <param name="arg_suser_name">보내는 이름</param>
		/// <param name="arg_ruser_id">받는이 아이디</param>
		/// <param name="arg_ruser_name">받는이 이름</param>
		private void Send_Mess(string arg_seq, string arg_division, string arg_div, string arg_suser_name, string arg_ruser_id, string arg_ruser_name, string arg_title, string arg_message)
		{

			string Proc_Name = "PKG_SPS_HOME.SAVE_SPS_NOTICE_USER";

			oraDB.ReDim_Parameter(12);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_DIVISION";
			oraDB.Parameter_Name[1]  = "ARG_FACTORY";
			oraDB.Parameter_Name[2]  = "ARG_DIV";
			oraDB.Parameter_Name[3]  = "ARG_SEQ";
			oraDB.Parameter_Name[4]  = "ARG_SUSER_ID";
			oraDB.Parameter_Name[5]  = "ARG_SUSER_NAME";
			oraDB.Parameter_Name[6]  = "ARG_RUSER_ID";
			oraDB.Parameter_Name[7]  = "ARG_RUSER_NAME";
			oraDB.Parameter_Name[8]  = "ARG_TITLE";
			oraDB.Parameter_Name[9]  = "ARG_MESSAGE";
			oraDB.Parameter_Name[10] = "ARG_READ_YN";
			oraDB.Parameter_Name[11] = "ARG_UPD_USER";

			oraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[11] = (int)OracleType.VarChar;



			oraDB.Parameter_Values[0]  = arg_division;
			oraDB.Parameter_Values[1]  = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2]  = arg_div;
			oraDB.Parameter_Values[3]  = arg_seq;
			oraDB.Parameter_Values[4]  = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[5]  = arg_suser_name;
			oraDB.Parameter_Values[6]  = arg_ruser_id;
			oraDB.Parameter_Values[7]  = arg_ruser_name;
			oraDB.Parameter_Values[8]  = arg_title;
			oraDB.Parameter_Values[9]  = arg_message;
			oraDB.Parameter_Values[10]  = "N";
			oraDB.Parameter_Values[11] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}


		/// <summary>
		/// Select_SPS_Notice_User : 메시지 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_div">R/S 구분자</param>
		/// <param name="arg_seq">시퀀스</param>
		/// <returns>정상:DataTable 오류: null</returns>
		private DataTable Select_SPS_Notice_User(string arg_factory, string arg_div, string arg_seq)
		{

			string Proc_Name = "PKG_SPS_HOME.VIEW_SPS_NOTICE_USER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_DIV";
			oraDB.Parameter_Name[2]  = "ARG_SEQ";
			oraDB.Parameter_Name[3]  = "OUT_CURSOR";

			oraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3]  = (int)OracleType.Cursor;


			oraDB.Parameter_Values[0]  = arg_factory;
			oraDB.Parameter_Values[1]  = arg_div;
			oraDB.Parameter_Values[2]  = arg_seq;
			oraDB.Parameter_Values[3]  = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret =oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return DS_Ret.Tables[Proc_Name];
		}



		private void Update_SPS_Notice_User(string arg_factory, string arg_div, string arg_seq)
		{

			string Proc_Name = "PKG_SPS_HOME.UPDATE_SPS_NOTICE";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_DIV";
			oraDB.Parameter_Name[2]  = "ARG_SEQ";

			oraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2]  = (int)OracleType.VarChar;


			oraDB.Parameter_Values[0]  = arg_factory;
			oraDB.Parameter_Values[1]  = arg_div;
			oraDB.Parameter_Values[2]  = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}


		private void Delete_SPS_Notice_User(string arg_factory, string arg_div, string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_SPS_NOTICE_USER";
			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_DIVISION";
			oraDB.Parameter_Name[2]  = "ARG_SEQ";

			oraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2]  = (int)OracleType.VarChar;


			oraDB.Parameter_Values[0]  = arg_factory;
			oraDB.Parameter_Values[1]  = arg_div;
			oraDB.Parameter_Values[2]  = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		private void tbtn_answer_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			string fac = ClassLib.ComVar.This_Factory;
//			string uid = ClassLib.ComVar.This_User;
//			string title = "[Re]"+txt_title.Text;
//			string subject = txt_subject.Text;
//			Pop_PS_NoticeUser_Sender sender_Form = new Pop_PS_NoticeUser_Sender(ClassLib.ComVar.This_Factory, ClassLib.ComVar.This_User, title, subject);
//			sender_Form.Show();
//			Close();
		}

		private void btn_cencal_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Pop_PS_NoticeUser_Receiver_Closed(object sender, System.EventArgs e)
		{
			if(frm != null)
			{
				frm.Get_Grid_List("A", "U", "");
			}
			else if(home_frm != null)
			{
				home_frm.Get_AutoMess();
			}
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
			DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete);

			if(DialogResult.Yes == dr)
			{
				Delete_SPS_Notice_User(factory, div, seq);
				Close();
			}
		}

		
	}
}

