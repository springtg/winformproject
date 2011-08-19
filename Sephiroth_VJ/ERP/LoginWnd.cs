using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Data.OracleClient;
using System.IO;
using System.Text;
using System.DirectoryServices; 

namespace ERP
{

	/// <summary>
	/// LoginWnd에 대한 요약 설명입니다.
	/// </summary>
	public class LoginWnd : System.Windows.Forms.Form
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_LoginID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Passwd;
		private System.Windows.Forms.Label lbl_LoginID;
		private System.Windows.Forms.Label lbl_Passwd;
		private System.Windows.Forms.ImageList img_Work;
		private System.Windows.Forms.Label btn_Login;
		private System.Windows.Forms.ImageList img_Login;
		private System.Windows.Forms.ImageList img_Exit;
		private System.Windows.Forms.Label btn_Down;
		private System.Windows.Forms.Label btn_Close;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
        private CheckBox chk_ADAuthentication; 
		private System.ComponentModel.IContainer components; 
 

		public LoginWnd()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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

		#endregion

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWnd));
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.lbl_LoginID = new System.Windows.Forms.Label();
            this.lbl_Passwd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LoginID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Passwd = new System.Windows.Forms.TextBox();
            this.img_Work = new System.Windows.Forms.ImageList(this.components);
            this.btn_Login = new System.Windows.Forms.Label();
            this.img_Login = new System.Windows.Forms.ImageList(this.components);
            this.img_Exit = new System.Windows.Forms.ImageList(this.components);
            this.btn_Down = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_ADAuthentication = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_LoginID
            // 
            this.lbl_LoginID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoginID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_LoginID.Location = new System.Drawing.Point(180, 210);
            this.lbl_LoginID.Name = "lbl_LoginID";
            this.lbl_LoginID.Size = new System.Drawing.Size(80, 21);
            this.lbl_LoginID.TabIndex = 51;
            this.lbl_LoginID.Text = "Login ID";
            this.lbl_LoginID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Passwd
            // 
            this.lbl_Passwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Passwd.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Passwd.Location = new System.Drawing.Point(180, 234);
            this.lbl_Passwd.Name = "lbl_Passwd";
            this.lbl_Passwd.Size = new System.Drawing.Size(80, 21);
            this.lbl_Passwd.TabIndex = 52;
            this.lbl_Passwd.Text = "Password";
            this.lbl_Passwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(260, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 53;
            // 
            // txt_LoginID
            // 
            this.txt_LoginID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_LoginID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoginID.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_LoginID.Location = new System.Drawing.Point(268, 216);
            this.txt_LoginID.Name = "txt_LoginID";
            this.txt_LoginID.Size = new System.Drawing.Size(100, 14);
            this.txt_LoginID.TabIndex = 57;
            this.txt_LoginID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LoginID_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(260, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 55;
            // 
            // txt_Passwd
            // 
            this.txt_Passwd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Passwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Passwd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Passwd.Location = new System.Drawing.Point(268, 240);
            this.txt_Passwd.Name = "txt_Passwd";
            this.txt_Passwd.PasswordChar = '*';
            this.txt_Passwd.Size = new System.Drawing.Size(100, 14);
            this.txt_Passwd.TabIndex = 56;
            this.txt_Passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Passwd_KeyPress);
            // 
            // img_Work
            // 
            this.img_Work.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Work.ImageStream")));
            this.img_Work.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Work.Images.SetKeyName(0, "");
            this.img_Work.Images.SetKeyName(1, "");
            this.img_Work.Images.SetKeyName(2, "");
            this.img_Work.Images.SetKeyName(3, "");
            this.img_Work.Images.SetKeyName(4, "");
            this.img_Work.Images.SetKeyName(5, "");
            this.img_Work.Images.SetKeyName(6, "");
            this.img_Work.Images.SetKeyName(7, "");
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.ImageIndex = 1;
            this.btn_Login.ImageList = this.img_Login;
            this.btn_Login.Location = new System.Drawing.Point(380, 210);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(49, 46);
            this.btn_Login.TabIndex = 61;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Login_MouseDown);
            this.btn_Login.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Login_MouseUp);
            // 
            // img_Login
            // 
            this.img_Login.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Login.ImageStream")));
            this.img_Login.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Login.Images.SetKeyName(0, "");
            this.img_Login.Images.SetKeyName(1, "");
            // 
            // img_Exit
            // 
            this.img_Exit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Exit.ImageStream")));
            this.img_Exit.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Exit.Images.SetKeyName(0, "");
            this.img_Exit.Images.SetKeyName(1, "");
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.Color.Transparent;
            this.btn_Down.ImageIndex = 0;
            this.btn_Down.ImageList = this.img_Exit;
            this.btn_Down.Location = new System.Drawing.Point(424, 14);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(15, 15);
            this.btn_Down.TabIndex = 62;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.ImageIndex = 1;
            this.btn_Close.ImageList = this.img_Exit;
            this.btn_Close.Location = new System.Drawing.Point(442, 14);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(15, 15);
            this.btn_Close.TabIndex = 63;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 42);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 14);
            this.label1.TabIndex = 65;
            this.label1.Text = "Sephiroth";
            this.label1.Visible = false;
            // 
            // chk_ADAuthentication
            // 
            this.chk_ADAuthentication.AutoSize = true;
            this.chk_ADAuthentication.BackColor = System.Drawing.Color.Transparent;
            this.chk_ADAuthentication.Checked = true;
            this.chk_ADAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ADAuthentication.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_ADAuthentication.Location = new System.Drawing.Point(234, 259);
            this.chk_ADAuthentication.Name = "chk_ADAuthentication";
            this.chk_ADAuthentication.Size = new System.Drawing.Size(201, 15);
            this.chk_ADAuthentication.TabIndex = 66;
            this.chk_ADAuthentication.Text = "Active Directory Authentication";
            this.chk_ADAuthentication.UseVisualStyleBackColor = false;
            this.chk_ADAuthentication.Visible = false;
            // 
            // LoginWnd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 303);
            this.ControlBox = false;
            this.Controls.Add(this.chk_ADAuthentication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Passwd);
            this.Controls.Add(this.txt_LoginID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Passwd);
            this.Controls.Add(this.lbl_LoginID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sephiroth Login";
            this.Load += new System.EventHandler(this.LoginWnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion  

		#region 사용자 변수

		private COM.OraDB _MyOraDB = new COM.OraDB();
 
		private string _Connect = "CONNECT";  
		public static bool _Re_Login = true;  
 
		private string _Domain_Protocol = "LDAP://" + "dskorea.com"; 

		private AuthenticationTypes _AtADLiginType = AuthenticationTypes.Secure;


		#endregion

		#region 멤버 메소드

		/// <summary>
		/// Init_Form : Form 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 

			// Application.Run(new FlexCDC.MRP.Form_MRP_Check());

			//Form Control 사이즈 정의
			//OS 영/한 버전에 따른 사이즈 자동 조절 문제로 인해서 사이즈 고정 처리 작업
			Set_Control_Size();  
		 
			//Active Directory User ID 로드
			Read_AD_UserID(); 

			//시작 focus 정리
			txt_Passwd.Focus(); 
			
		}



		/// <summary>
		/// Set_Control_Size : Form Control 사이즈, 위치 정의
		/// </summary>
		private void Set_Control_Size()
		{
			this.Size = new Size(473, 303);

			btn_Down.Location = new Point(424, 14);
			btn_Close.Location = new Point(442, 14);

			lbl_LoginID.Location = new Point(180, 210);
			lbl_Passwd.Location = new Point(180, 234);

			pictureBox1.Location = new Point(196, 156);
			txt_LoginID.Location = new Point(268, 216);
			txt_Passwd.Location = new Point(268, 240);

			btn_Login.Location = new Point(380, 210);
			btn_Login.Size = new Size(49, 46);

			label3.Location = new Point(260, 210);
			label3.Size = new Size(120, 21);
			label4.Location = new Point(260, 234);
			label4.Size = new Size(120, 21);
		}


 
		/// <summary>
		/// Read_AD_UserID : Active Directory User ID 로드
		/// </summary>
		private void Read_AD_UserID()
		{
			/* DLL 참조 추가
			 * 1. System.DirectoryServices.dll
			 * 2. System.Security.dll */

			/* Using 추가
			 * using System.DirectoryServices;   */

			//AD계정 : "Domain영역이름\계정"형식
			string windows_userid = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
			char[] separator = @"\".ToCharArray();
			string[] token = windows_userid.Split(separator);
			string user_id = token[1];

			if(!Set_UserID(user_id) )
			{
				ClassLib.ComFunction.User_Message("Disconnect");
				return;
			} 
			else
			{ 
				txt_LoginID.Text = user_id;  
				txt_Passwd.Focus(); 
			}

		}



		/// <summary>
		/// Set_UserID : User ID 입력 여부 체크
		/// </summary> 
		public bool Set_UserID(string arg_userid)
		{
			if (arg_userid.Length <= 0)
			{
				return false;
			}
			else
			{
				ClassLib.ComVar.This_User = arg_userid.ToLower();
				return true;
			}
		}



		/// <summary>
		/// Exit_LoginWnd : Form Closing Event Handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_LoginWnd(object sender,System.EventArgs e)
		{
			string factory = ClassLib.ComVar.This_Factory;
			string user_id = ClassLib.ComVar.This_User;

			_Connect = "DISCONNECT";
			Save_UserLog(_Connect, factory, user_id, "", ""); 

			if(_Re_Login)
			{
				this.Dispose();
			}
			else
			{
				this.Visible = true;
				txt_LoginID.Text = "";
				txt_Passwd.Text = "";
				txt_LoginID.Focus();
				_Re_Login = !_Re_Login;
			}
		}

		
		
		#endregion

		#region 이벤트

		/// <summary>
		/// btn_Login_MouseDown : 로그인 버튼 다운 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Login.ImageIndex = 0;
		}


		/// <summary>
		/// btn_Login_MouseDown : 로그인 버튼 업 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Login_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Login.ImageIndex = 1;
		}

		/// <summary>
		/// 로그인 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Login_Click(object sender, System.EventArgs e)
		{ 
			//active directory로 login 작업
			Login_AD(); 
		}


		#region 로그인 관련 Function

		/// <summary>
		/// Login_AD : active directory로 login 작업
		/// </summary>
		private void Login_AD()
		{

            //try
            //{
            //    string user_id = txt_LoginID.Text;
            //    string pass_wd = txt_Passwd.Text;

            //    //User ID 입력 여부 체크 
            //    if (!Set_UserID(txt_LoginID.Text))
            //    {
            //        ClassLib.ComFunction.User_Message("Input Login ID");
            //        return;
            //    }
            //    else
            //    {
            //        //AD 로그인 인증 후 기타 User 데이터 DB에서 추출
            //        Login_DB(user_id);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ClassLib.ComFunction.User_Message(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}






            try
            {
                string user_id = txt_LoginID.Text;
                string pass_wd = txt_Passwd.Text;

                //User ID 입력 여부 체크 
                if (!Set_UserID(txt_LoginID.Text))
                {
                    ClassLib.ComFunction.User_Message("Input Login ID");
                    return;
                }
                else
                {


                    if (chk_ADAuthentication.Checked)
                    {

                        try
                        {
                            // now create the directory entry to establish connection
                            using (DirectoryEntry deDirEntry = new DirectoryEntry(_Domain_Protocol, user_id, pass_wd, _AtADLiginType))
                            {

                                try
                                {
                                    //check domain connect
                                    if (deDirEntry.Name.Length == 0)
                                    {
                                        ClassLib.ComFunction.User_Message("Disconnect");
                                        //chk_ADAuthentication.Visible = true;
                                        return;
                                    }
                                    else
                                    {
                                        //AD 로그인 인증 후 기타 User 데이터 DB에서 추출
                                        Login_DB(user_id);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    ClassLib.ComFunction.User_Message(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            } // end using  




                        }
                        catch (Exception ex)
                        {
                            ClassLib.ComFunction.User_Message(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Login_DB(user_id);
                        }

                    }
                    else
                    {
                        Login_DB(user_id);
                    }

                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			 


		}


		/// <summary>
		/// Login_DB : AD 로그인 인증 후 기타 User 데이터 DB에서 추출
		/// </summary>
		/// <param name="arg_userid"></param>
		private void Login_DB(string arg_userid)
		{  
			ClassLib.ComVar.This_User_AD = arg_userid + ClassLib.ComVar.This_Domain;   //"@" + _Domain; 

			string factory = ClassLib.ComVar.This_Factory;
			string user_id = ClassLib.ComVar.This_User_AD;
			string job_cd = ClassLib.ComVar.This_JobCdoe;

			if(!LogBase.ClassLog.Login_Check(user_id) )
			{
				txt_LoginID.Focus();
			}
			else
			{  

				// ad 로 인증된 패스워드
				COM.ComVar.This_PassWD = txt_Passwd.Text.Trim();


				// log history 저장
				IPHostEntry IPAddr = Dns.GetHostByName(Dns.GetHostName());
				string ipAddress = IPAddr.AddressList[0].ToString();  
				
				Save_UserLog(_Connect, factory, user_id, job_cd, ipAddress);  

				/*
				// 메인 메뉴 폼 열기
				MainWnd main = new MainWnd();
				main.Show();

				this.Visible = false;
				main.Disposed += new System.EventHandler(this.Exit_LoginWnd);
				*/

				COM.ComVar._LoginOK = true;

				this.Close();

			}

		}

  

		#endregion


		 
		private void btn_Down_Click(object sender, System.EventArgs e)
		{
			this.WindowState= System.Windows.Forms.FormWindowState.Minimized;
		}


		 
		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		} 
		

		private void txt_Passwd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				//active directory로 login 작업
				Login_AD(); 
			}

		}

		private void txt_LoginID_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				//active directory로 login 작업
				Login_AD(); 
			}
		}
 

		#endregion

		#region DB 접속

		private void Save_UserLog( string arg_division, string arg_Factory, string arg_User_id, string arg_Job_cd,   string arg_Login_ip )
		{


			string Proc_Name = "PKG_SPS_LOG_HIST.SAVE_SPS_LOG_HIST";

			_MyOraDB.ReDim_Parameter(5); 
			_MyOraDB.Process_Name = Proc_Name;

			_MyOraDB.Parameter_Name[0] = "ARG_DIVISOIN";
			_MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[2] = "ARG_USER_ID";
			_MyOraDB.Parameter_Name[3] = "ARG_JOB_CD";
			_MyOraDB.Parameter_Name[4] = "ARG_LOGIN_IP";

			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;


			_MyOraDB.Parameter_Values[0] = arg_division;
			_MyOraDB.Parameter_Values[1] = arg_Factory;
			_MyOraDB.Parameter_Values[2] = arg_User_id;
			_MyOraDB.Parameter_Values[3] = arg_Job_cd;
			_MyOraDB.Parameter_Values[4] = arg_Login_ip;


			_MyOraDB.Add_Modify_Parameter(true);
			_MyOraDB.Exe_Modify_Procedure();


		}

		private DataTable Select_UserLog_upd( string arg_Factory, string arg_User_id )
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_SPS_LOG_HIST_UPD";

			_MyOraDB.ReDim_Parameter(5); 
			_MyOraDB.Process_Name = Proc_Name;

			_MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[1] = "ARG_USER_ID";
			_MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


			_MyOraDB.Parameter_Values[0] = arg_Factory;
			_MyOraDB.Parameter_Values[1] = arg_User_id;
			_MyOraDB.Parameter_Values[2] = "";

			_MyOraDB.Add_Select_Parameter(true); 
			DataSet DS_Ret = _MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;

			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion 
 


		/// <summary>
		/// LoginWnd_Load : 로그인 폼 로드 시
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoginWnd_Load(object sender, System.EventArgs e)
		{
			try
			{
				Init_Form();
                txt_LoginID.Text = "NTDIEN.IT";
                txt_Passwd.Text = "system1730";
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}
	}
}
