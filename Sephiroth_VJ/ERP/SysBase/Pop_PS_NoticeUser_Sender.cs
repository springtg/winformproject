using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Web.Mail;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeUser_Sender : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.TextBox txt_subject;
		private System.Windows.Forms.TextBox txt_title;
		private System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.TextBox txt_send_id;
		private System.Windows.Forms.Label lbl_send_id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_list;


		#region ����� ����

		private COM.OraDB oraDB;
		private string factory = null;
		private string receive_id = null;
		private string title = null;
		private System.Windows.Forms.Label lbl_mail;
		private System.Windows.Forms.TextBox txt_tomail;
		private System.Windows.Forms.TextBox txt_frommail;
		private System.Windows.Forms.Label lbl_tomail;
		private System.Windows.Forms.Label lbl_frommail;
		private System.Windows.Forms.CheckBox chk_mail;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1Command tbtn_send;
		private string subject = null;
		#endregion

		public Pop_PS_NoticeUser_Sender()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		public Pop_PS_NoticeUser_Sender(string arg_factory, string arg_receive_id, string arg_title, string arg_subject)
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.

			factory = arg_factory;
			receive_id = arg_receive_id;
			title = arg_title;
			subject = arg_subject;
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeUser_Sender));
			this.txt_subject = new System.Windows.Forms.TextBox();
			this.txt_title = new System.Windows.Forms.TextBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.txt_send_id = new System.Windows.Forms.TextBox();
			this.lbl_send_id = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_list = new System.Windows.Forms.Label();
			this.txt_tomail = new System.Windows.Forms.TextBox();
			this.txt_frommail = new System.Windows.Forms.TextBox();
			this.lbl_mail = new System.Windows.Forms.Label();
			this.lbl_tomail = new System.Windows.Forms.Label();
			this.lbl_frommail = new System.Windows.Forms.Label();
			this.chk_mail = new System.Windows.Forms.CheckBox();
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_send = new C1.Win.C1Command.C1Command();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
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
			// txt_subject
			// 
			this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_subject.Location = new System.Drawing.Point(109, 90);
			this.txt_subject.Multiline = true;
			this.txt_subject.Name = "txt_subject";
			this.txt_subject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_subject.Size = new System.Drawing.Size(576, 246);
			this.txt_subject.TabIndex = 222;
			this.txt_subject.Text = "";
			// 
			// txt_title
			// 
			this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_title.Location = new System.Drawing.Point(109, 68);
			this.txt_title.Name = "txt_title";
			this.txt_title.Size = new System.Drawing.Size(576, 21);
			this.txt_title.TabIndex = 226;
			this.txt_title.Text = "";
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(8, 68);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 225;
			this.lbl_title.Text = "����";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_send_id
			// 
			this.txt_send_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_send_id.Location = new System.Drawing.Point(109, 46);
			this.txt_send_id.Name = "txt_send_id";
			this.txt_send_id.Size = new System.Drawing.Size(554, 21);
			this.txt_send_id.TabIndex = 224;
			this.txt_send_id.Text = "";
			// 
			// lbl_send_id
			// 
			this.lbl_send_id.ImageIndex = 0;
			this.lbl_send_id.ImageList = this.img_Label;
			this.lbl_send_id.Location = new System.Drawing.Point(8, 46);
			this.lbl_send_id.Name = "lbl_send_id";
			this.lbl_send_id.Size = new System.Drawing.Size(100, 21);
			this.lbl_send_id.TabIndex = 223;
			this.lbl_send_id.Text = "�޴� ���̵�";
			this.lbl_send_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 227;
			this.label1.Text = "����";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.btn_list.Location = new System.Drawing.Point(664, 46);
			this.btn_list.Name = "btn_list";
			this.btn_list.Size = new System.Drawing.Size(21, 21);
			this.btn_list.TabIndex = 230;
			this.btn_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
			this.btn_list.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_list_MouseUp);
			this.btn_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_list_MouseDown);
			// 
			// txt_tomail
			// 
			this.txt_tomail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_tomail.Enabled = false;
			this.txt_tomail.Location = new System.Drawing.Point(109, 359);
			this.txt_tomail.Name = "txt_tomail";
			this.txt_tomail.Size = new System.Drawing.Size(576, 21);
			this.txt_tomail.TabIndex = 231;
			this.txt_tomail.Text = "";
			// 
			// txt_frommail
			// 
			this.txt_frommail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_frommail.Enabled = false;
			this.txt_frommail.Location = new System.Drawing.Point(109, 381);
			this.txt_frommail.Multiline = true;
			this.txt_frommail.Name = "txt_frommail";
			this.txt_frommail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_frommail.Size = new System.Drawing.Size(576, 59);
			this.txt_frommail.TabIndex = 232;
			this.txt_frommail.Text = "";
			// 
			// lbl_mail
			// 
			this.lbl_mail.ImageIndex = 0;
			this.lbl_mail.ImageList = this.img_Label;
			this.lbl_mail.Location = new System.Drawing.Point(8, 337);
			this.lbl_mail.Name = "lbl_mail";
			this.lbl_mail.Size = new System.Drawing.Size(100, 21);
			this.lbl_mail.TabIndex = 233;
			this.lbl_mail.Text = "��������";
			this.lbl_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_tomail
			// 
			this.lbl_tomail.ImageIndex = 0;
			this.lbl_tomail.ImageList = this.img_Label;
			this.lbl_tomail.Location = new System.Drawing.Point(8, 359);
			this.lbl_tomail.Name = "lbl_tomail";
			this.lbl_tomail.Size = new System.Drawing.Size(100, 21);
			this.lbl_tomail.TabIndex = 234;
			this.lbl_tomail.Text = "�޴� ����";
			this.lbl_tomail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_frommail
			// 
			this.lbl_frommail.ImageIndex = 0;
			this.lbl_frommail.ImageList = this.img_Label;
			this.lbl_frommail.Location = new System.Drawing.Point(8, 381);
			this.lbl_frommail.Name = "lbl_frommail";
			this.lbl_frommail.Size = new System.Drawing.Size(100, 21);
			this.lbl_frommail.TabIndex = 235;
			this.lbl_frommail.Text = "������ ����";
			this.lbl_frommail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_mail
			// 
			this.chk_mail.BackColor = System.Drawing.SystemColors.Window;
			this.chk_mail.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_mail.Location = new System.Drawing.Point(109, 342);
			this.chk_mail.Name = "chk_mail";
			this.chk_mail.Size = new System.Drawing.Size(11, 11);
			this.chk_mail.TabIndex = 236;
			this.chk_mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_mail.CheckedChanged += new System.EventHandler(this.chk_mail_CheckedChanged);
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
			this.c1CommandHolder1.Commands.Add(this.tbtn_send);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.Turquoise;
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_send
			// 
			this.tbtn_send.ImageIndex = 10;
			this.tbtn_send.Name = "tbtn_send";
			this.tbtn_send.Text = "Send";
			this.tbtn_send.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_send_Click);
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.tbtn_send;
			// 
			// Pop_PS_NoticeUser_Sender
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.chk_mail);
			this.Controls.Add(this.lbl_frommail);
			this.Controls.Add(this.lbl_tomail);
			this.Controls.Add(this.lbl_mail);
			this.Controls.Add(this.txt_frommail);
			this.Controls.Add(this.txt_tomail);
			this.Controls.Add(this.btn_list);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_title);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.txt_send_id);
			this.Controls.Add(this.lbl_send_id);
			this.Controls.Add(this.txt_subject);
			this.Name = "Pop_PS_NoticeUser_Sender";
			this.Text = "Individual Message Write";
			this.Load += new System.EventHandler(this.Pop_PS_NoticeUser_Sender_Load);
			this.Controls.SetChildIndex(this.txt_subject, 0);
			this.Controls.SetChildIndex(this.lbl_send_id, 0);
			this.Controls.SetChildIndex(this.txt_send_id, 0);
			this.Controls.SetChildIndex(this.lbl_title, 0);
			this.Controls.SetChildIndex(this.txt_title, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.btn_list, 0);
			this.Controls.SetChildIndex(this.txt_tomail, 0);
			this.Controls.SetChildIndex(this.txt_frommail, 0);
			this.Controls.SetChildIndex(this.lbl_mail, 0);
			this.Controls.SetChildIndex(this.lbl_tomail, 0);
			this.Controls.SetChildIndex(this.lbl_frommail, 0);
			this.Controls.SetChildIndex(this.chk_mail, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_PS_NoticeUser_Sender_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		/// <summary>
		/// Inti_Form : Form Load �� �ʱ�ȭ �۾�
		/// </summary>
		private void Init_Form()
		{
			this.lbl_MainTitle.Text = "Individual Message Write";


			oraDB = new COM.OraDB();

			if(factory == null)
			{
				txt_send_id.Focus();
			}
			else
			{
				txt_send_id.Text = receive_id;
				txt_title.Text = title;
				txt_subject.Text = subject;
			}
		}

		private void Send()
		{

			string arg_division = "I";
			string arg_sender = ClassLib.ComVar.This_User;
			string arg_sendernema = Get_Name(ClassLib.ComVar.This_User);
			string arg_title = txt_title.Text;
			string arg_message = txt_subject.Text;
			
			string arg_id_div = ",";

			string arg_reciver = txt_send_id.Text;

			string[] reciver_count = arg_reciver.Split(arg_id_div.ToCharArray());

			for(int i=0; i<reciver_count.Length; i++)
			{
				if(ClassLib.ComVar.This_User == reciver_count[i])
				{
					MessageBox.Show("�ڽſ��Դ� ���� �� �����ϴ�.");
				}
				else
				{
				
					if(Get_Name(reciver_count[i]) != null)
					{
						Send_Mess("", arg_division, "R", arg_sendernema, reciver_count[i], Get_Name(reciver_count[i]), arg_title, arg_message);
						Send_Mess("", arg_division, "S", arg_sendernema, reciver_count[i], Get_Name(reciver_count[i]), arg_title, arg_message);
					}
					else
					{
						MessageBox.Show(reciver_count[i] + " �� �Һи� �մϴ�.");
					}
				}
			}


			//�׽�Ʈ�� ���� ������: ���� ������ �׸� ýũ�� ���� �ּҴ� DB���� �����ͼ� ������. 
			if(chk_mail.Checked)
			{
				MailMessage mail = new MailMessage();
				mail.From        = txt_frommail.Text;
				mail.To          = txt_tomail.Text;
				mail.Subject     = txt_title.Text;
				mail.Body        = txt_subject.Text;
				mail.BodyFormat  = MailFormat.Html;
				SmtpMail.SmtpServer = "haidin.net";
				SmtpMail.Send(mail);
			}

			Close();
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
		/// Send_Mess : �޽���(���� ���� �˸�) ������
		/// </summary>
		/// <param name="arg_division">Save Code</param>
		/// <param name="arg_div">S/R</param>
		/// <param name="arg_suser_name">������ �̸�</param>
		/// <param name="arg_ruser_id">�޴��� ���̵�</param>
		/// <param name="arg_ruser_name">�޴��� �̸�</param>
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

		private void btn_list_Click(object sender, System.EventArgs e)
		{
			Pop_PS_NoticeUser_UserList userList = new Pop_PS_NoticeUser_UserList(this, txt_send_id);
			userList.Show();
		}

		private void chk_mail_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chk_mail.Checked)
			{
				txt_frommail.Enabled = true;
				txt_tomail.Enabled = true;
			}
			else
			{
				txt_frommail.Enabled = false;
				txt_tomail.Enabled = false;
			}
		}

		private void tbtn_send_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(ClassLib.ComFunction.Empty_TextBox(txt_send_id,"").Length == 0)
			{
				MessageBox.Show("�޴��̸� ���� �Ͻʽÿ�.");
				txt_send_id.Focus();
			}
			else if(ClassLib.ComFunction.Empty_TextBox(txt_title,"").Length == 0)
			{
				MessageBox.Show("������ �Է� �ϼ���.");
				txt_title.Focus();
			}
			else if(ClassLib.ComFunction.Empty_TextBox(txt_subject, "").Length == 0)
			{
				MessageBox.Show("������ �Է� �ϼ���.");
				txt_subject.Focus();
			}
			else
			{
				Send();
			}
		}

		private void btn_list_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_list.ImageIndex = 8;
		}

		private void btn_list_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_list.ImageIndex = 9;
		}
	}
}

