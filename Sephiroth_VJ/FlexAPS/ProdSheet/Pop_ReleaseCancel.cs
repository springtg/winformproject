using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace FlexAPS.ProdSheet
{
	public class Pop_ReleaseCancel : COM.APSWinForm.Pop_Small
	{
		
		#region ��Ʈ�� ���� �� ���ҽ� ����

		private System.Windows.Forms.TextBox txt_Status;
		private System.Windows.Forms.TextBox txt_StatusDay;
		private System.Windows.Forms.Label lbl_Status;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.Label btn_Close;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.TextBox txt_Password;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region ������, �Ҹ���


		public Pop_ReleaseCancel()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}




		private string _Factory;
		private string _StatusDay;
		private string _Status;


		public Pop_ReleaseCancel(string arg_factory, string arg_status_day, string arg_status)
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.


			_Factory = arg_factory;
			_StatusDay = arg_status_day;
			_Status = arg_status;

			Init_Form();
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

		
		#endregion 

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_ReleaseCancel));
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Label();
			this.txt_Status = new System.Windows.Forms.TextBox();
			this.txt_StatusDay = new System.Windows.Forms.TextBox();
			this.lbl_Status = new System.Windows.Forms.Label();
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
			this.lbl_MainTitle.Text = "Work Sheet Release Cancel";
			// 
			// txt_Password
			// 
			this.txt_Password.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Password.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Password.Location = new System.Drawing.Point(141, 77);
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
			this.lbl_Password.Location = new System.Drawing.Point(40, 77);
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
			this.btn_Close.Location = new System.Drawing.Point(312, 115);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 287;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			this.btn_Close.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Close.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_Status
			// 
			this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Status.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Status.Location = new System.Drawing.Point(247, 55);
			this.txt_Status.MaxLength = 60;
			this.txt_Status.Name = "txt_Status";
			this.txt_Status.ReadOnly = true;
			this.txt_Status.Size = new System.Drawing.Size(104, 21);
			this.txt_Status.TabIndex = 2;
			this.txt_Status.Text = "";
			// 
			// txt_StatusDay
			// 
			this.txt_StatusDay.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StatusDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StatusDay.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StatusDay.Location = new System.Drawing.Point(141, 55);
			this.txt_StatusDay.MaxLength = 60;
			this.txt_StatusDay.Name = "txt_StatusDay";
			this.txt_StatusDay.ReadOnly = true;
			this.txt_StatusDay.Size = new System.Drawing.Size(105, 21);
			this.txt_StatusDay.TabIndex = 3;
			this.txt_StatusDay.Text = "";
			// 
			// lbl_Status
			// 
			this.lbl_Status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Status.ImageIndex = 0;
			this.lbl_Status.ImageList = this.img_Label;
			this.lbl_Status.Location = new System.Drawing.Point(40, 55);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(100, 21);
			this.lbl_Status.TabIndex = 284;
			this.lbl_Status.Text = "Status";
			this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(241, 115);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 290;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_ReleaseCancel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(392, 151);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.txt_Status);
			this.Controls.Add(this.txt_StatusDay);
			this.Controls.Add(this.lbl_Status);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_ReleaseCancel";
			this.Text = "Work Sheet Release Cancel";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_Status, 0);
			this.Controls.SetChildIndex(this.txt_StatusDay, 0);
			this.Controls.SetChildIndex(this.txt_Status, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.lbl_Password, 0);
			this.Controls.SetChildIndex(this.txt_Password, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.ResumeLayout(false);

		}
		#endregion
  
		#region ���� ����

		 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 


		public bool _Close_Save = false;

		#endregion 

		#region ��� �޼���


		#region �ʱ�ȭ

		/// <summary>
		/// Inti_Form : Form Load �� �ʱ�ȭ �۾�
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
  
				//Title
				this.Text = "Work Sheet Release Cancel";
				lbl_MainTitle.Text = "Work Sheet Release Cancel"; 
  
  
				txt_StatusDay.Text = MyComFunction.ConvertDate2Type(_StatusDay);
				txt_Status.Text = _Status;
				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}

 

		#endregion
		  
		#region ��ȸ


		#endregion

		#region ���� �̺�Ʈ �޼���
 

		#endregion

		#region �׸��� �̺�Ʈ �޼���
 
		#endregion

		#region ��ư �� ��Ÿ �̺�Ʈ �޼���


		#region ��ư �̹��� �̺�Ʈ

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			

		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{

			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		#endregion
  


		
		/// <summary>
		/// Check_PassWord : ��й�ȣ Check
		/// </summary>
		/// <returns></returns>
		private bool Check_PassWord()
		{ 
			string password = "";

			try
			{
				password = Select_Cancel_Password(_Factory); 

				if(password == txt_Password.Text)
					return true;
				else
					return false;

			}
			catch
			{
				return false;
			}


			

			#region �α��� ����ڿ� ���� ��й�ȣ �˻�

			//			string password = "";
			//
			//			try
			//			{
			//				password = ClassLib.ComVar.This_PassWD;  //This_Password; 
			//
			//				if(password == txt_Password.Text)
			//					return true;
			//				else
			//					return false;
			//
			//			}
			//			catch
			//			{
			//				return false;
			//			}
			 

			#endregion


		}




		/// <summary>
		/// Event_Click_btn_Apply : 
		/// </summary>
		private void Event_Click_btn_Apply()
		{

			#region before apply thread

//			string pcard_count = "";
//			bool pwd_flag = false, save_flag = false;
//
//			 
//			this.Cursor = Cursors.WaitCursor; 
//
//			string factory = _Factory;
//			string status_day = _StatusDay;
//
//
//			// cancel condition check
//			// �̹� passcard print �Ǿ����� cancel �Ұ�
//			pcard_count = Get_SELECT_PCARD_PRINT_COUNT(factory, status_day);
//
//			if (pcard_count == null) return;
//
//			if(Convert.ToInt32(pcard_count) > 0)
//			{
//				string message = "Already passcard print." + "\r\n\r\n" + @"Can't not cancel.";
//				ClassLib.ComFunction.User_Message(message, "Apply", MessageBoxButtons.OK, MessageBoxIcon.Information);
// 
//				this.Cursor = Cursors.Default;
//				this.Close(); 
//			}
//			else
//			{
//
//				// cancel password ����
//				pwd_flag = Check_PassWord();
//
//				if(!pwd_flag)
//				{
//					ClassLib.ComFunction.Data_Message("Password", ClassLib.ComVar.MgsWrongInput, this);
//					txt_Password.Text = "";
//					this.Cursor = Cursors.Default;
//					return;
//				}
//
//
//
//				// �۾����� ���
//				save_flag = Run_SP_SPD_Cancel_Daily_WorkSheet(_Factory, status_day);
//
//				this.Cursor = Cursors.Default;
//
//				if(!save_flag) 
//				{
//					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this); 
//					return;  
//				}
//				else
//				{
//					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
//					this.Close();
//				}
//			}
			

			#endregion



			string pcard_count = "";
			bool pwd_flag = false;

			 
			this.Cursor = Cursors.WaitCursor; 

			string factory = _Factory;
			string status_day = _StatusDay;


			// cancel condition check
			// �̹� passcard print �Ǿ����� cancel �Ұ�
			pcard_count = Get_SELECT_PCARD_PRINT_COUNT(factory, status_day);

			if (pcard_count == null) return;

			if(Convert.ToInt32(pcard_count) > 0)
			{
				string message = "Already passcard print." + "\r\n\r\n" + @"Can't not cancel.";
				ClassLib.ComFunction.User_Message(message, "Apply", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
				this.Cursor = Cursors.Default;
					
				_Close_Save = false;
				this.Close(); 
			}
			else
			{

				// cancel password ����
				pwd_flag = Check_PassWord();

					
				this.Cursor = Cursors.Default;


				if(!pwd_flag)
				{
					ClassLib.ComFunction.Data_Message("Password", ClassLib.ComVar.MgsWrongInput, this);
					txt_Password.Text = "";


//					_Close_Save = false;
//					this.Close(); 

					return;

				}
				else
				{
					_Close_Save = true;
					this.Close(); 
				} 

					
			}
				



		}





		#endregion

		#region ���ؽ�Ʈ �޴� �̺�Ʈ �޼���

 

		#endregion
 

		#endregion   
		
		#region �̺�Ʈ ó��

		#region ���� �̺�Ʈ


		#endregion 

		#region �׸��� �̺�Ʈ
  

		#endregion

		#region ��ư �� ��Ÿ �̺�Ʈ

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				Event_Click_btn_Apply(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				_Close_Save = false;
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Close_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void txt_Password_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//13 : enter
			if(e.KeyChar == (char)13) 
			{
				Event_Click_btn_Apply();
			}
		}


		#endregion

		#region ���ؽ�Ʈ �޴� �̺�Ʈ

  

		#endregion


		#endregion
		 
		#region ��� ����
 

		/// <summary>
		/// Run_SP_SPD_Cancel_Daily_WorkSheet : ���� ���� �������� �۾�����(�������κ�,���ζ��� �ñ�뺰) ��� 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_status_day"></param>
		/// <returns></returns>
		public static bool Run_SP_SPD_Cancel_Daily_WorkSheet(string arg_factory, string arg_status_day) 
		{  
			
			try
			{

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;

				LMyOraDB.ReDim_Parameter(3);  

				LMyOraDB.Process_Name = "SP_SPD_Cancel_Daily_WorkSheet";  
  
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_DIR_YMD";
				LMyOraDB.Parameter_Name[2] = "ARG_UPD_USER";  
  
				for (int i = 0; i <= 2; i++)
				{
					LMyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
 
				LMyOraDB.Parameter_Values[0] = arg_factory;
				LMyOraDB.Parameter_Values[1] = arg_status_day; 
				LMyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User; 

				LMyOraDB.Add_Run_Parameter(true);  
				ds_ret =  LMyOraDB.Exe_Run_Procedure();	 
			 
				if(ds_ret == null)  
					return false; 
				else
					return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Run_SP_SPD_Cancel_Daily_WorkSheet",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			} 
		}

		 
		/// <summary>
		/// Select_Cancel_Password : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private string Select_Cancel_Password(string arg_factory) 
		{  
			
			try
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(2);  

				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_RELEASE_CANCEL_PWD";  
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";  
   
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
 
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();
	 
				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Select_Cancel_Password",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			} 
		}

 
		/// <summary>
		/// Get_SELECT_PCARD_PRINT_COUNT : �۾����� ��� �� �н�ī�� ������ ���� üũ
		/// </summary>
		/// <returns></returns>
		private string Get_SELECT_PCARD_PRINT_COUNT(string arg_factory, string arg_status_day) 
		{  
		
			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(3);  

				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_PCARD_PRINT_COUNT";  
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";  
   
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
 
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = arg_status_day; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();
	 
				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Select_Cancel_Password",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			} 
		}


		
		#endregion

		




	}
}

