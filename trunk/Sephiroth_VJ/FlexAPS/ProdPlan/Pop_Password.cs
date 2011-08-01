using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace FlexAPS.ProdPlan
{
	public class Pop_Password : COM.APSWinForm.Pop_Small
	{
		
		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.Label btn_Close;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.TextBox txt_Password;
		private System.ComponentModel.IContainer components = null;

		public Pop_Password()
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

		
		#endregion 

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Password));
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
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
			this.lbl_MainTitle.Text = "Password";
			// 
			// txt_Password
			// 
			this.txt_Password.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Password.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Password.Location = new System.Drawing.Point(141, 55);
			this.txt_Password.MaxLength = 60;
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(210, 21);
			this.txt_Password.TabIndex = 1;
			this.txt_Password.Text = "";
			this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
			// 
			// lbl_Password
			// 
			this.lbl_Password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Password.ImageIndex = 0;
			this.lbl_Password.ImageList = this.img_Label;
			this.lbl_Password.Location = new System.Drawing.Point(40, 55);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(100, 21);
			this.lbl_Password.TabIndex = 288;
			this.lbl_Password.Text = "Password";
			this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Close.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Close.ImageIndex = 0;
			this.btn_Close.ImageList = this.img_Button;
			this.btn_Close.Location = new System.Drawing.Point(312, 88);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 287;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(241, 88);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 290;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_Password
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(392, 119);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.btn_Close);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_Password";
			this.Text = "Password";
			this.Load += new System.EventHandler(this.Pop_Password_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.lbl_Password, 0);
			this.Controls.SetChildIndex(this.txt_Password, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.ResumeLayout(false);

		}
		#endregion
 

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();  

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Init_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			//Title
			this.Text = "Password";
			lbl_MainTitle.Text = "Password"; 

			ClassLib.ComFunction.SetLangDic(this); 

		}


		/// <summary>
		/// Check_PassWord : 비밀번호 Check
		/// </summary>
		/// <returns></returns>
		private bool Check_PassWord()
		{ 
			string password = "";

			try
			{
				password = ClassLib.ComVar.This_PassWD;  //This_Password; 

				if(password == txt_Password.Text)
					return true;
				else
					return false;

			}
			catch
			{
				return false;
			}
		}


		#endregion 

		#region 이벤트 처리

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}



		public bool _Password_OK_Flag = false;
		public bool _Apply_Flag = false;

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			 
			bool pwd_flag = false;

			try
			{
				 
				pwd_flag = Check_PassWord();

				if(!pwd_flag)
				{
					ClassLib.ComFunction.Data_Message("Password", ClassLib.ComVar.MgsWrongInput, this);
					txt_Password.Text = ""; 

					_Password_OK_Flag = false;
					_Apply_Flag = false;
					return;
				}
				else
				{
					_Password_OK_Flag = true;
					_Apply_Flag = true;
					this.Close();
				}

					 
			}
			catch
			{
			}
		}


		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			_Apply_Flag = false;
			this.Close();
		}


		private void txt_Password_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//13 : enter
			if(e.KeyChar == (char)13) 
			{
				btn_Apply_Click(null, null);
			}
		}



		#endregion
 
		#region DB Connect 

		 
		#endregion


 
		private void Pop_Password_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 
		}
 


	}
}

