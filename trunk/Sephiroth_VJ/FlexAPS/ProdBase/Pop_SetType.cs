using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdBase
{
	public class Pop_SetType : COM.APSWinForm.Pop_Small
	{
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_Type;
		private System.Windows.Forms.TextBox txt_Type;
		private System.Windows.Forms.TextBox txt_Desc;
		private System.Windows.Forms.Label lbl_Desc;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetType()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetType));
			this.txt_Desc = new System.Windows.Forms.TextBox();
			this.lbl_Desc = new System.Windows.Forms.Label();
			this.lbl_Type = new System.Windows.Forms.Label();
			this.txt_Type = new System.Windows.Forms.TextBox();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
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
			// 
			// txt_Desc
			// 
			this.txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc.Location = new System.Drawing.Point(141, 77);
			this.txt_Desc.MaxLength = 20;
			this.txt_Desc.Name = "txt_Desc";
			this.txt_Desc.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc.TabIndex = 65;
			this.txt_Desc.Text = "";
			// 
			// lbl_Desc
			// 
			this.lbl_Desc.ImageIndex = 0;
			this.lbl_Desc.ImageList = this.img_Label;
			this.lbl_Desc.Location = new System.Drawing.Point(40, 77);
			this.lbl_Desc.Name = "lbl_Desc";
			this.lbl_Desc.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc.TabIndex = 63;
			this.lbl_Desc.Text = "Type Desc.";
			this.lbl_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Type
			// 
			this.lbl_Type.ImageIndex = 0;
			this.lbl_Type.ImageList = this.img_Label;
			this.lbl_Type.Location = new System.Drawing.Point(40, 55);
			this.lbl_Type.Name = "lbl_Type";
			this.lbl_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_Type.TabIndex = 62;
			this.lbl_Type.Text = "Type Code";
			this.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Type
			// 
			this.txt_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Type.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Type.Location = new System.Drawing.Point(141, 55);
			this.txt_Type.MaxLength = 20;
			this.txt_Type.Name = "txt_Type";
			this.txt_Type.Size = new System.Drawing.Size(210, 21);
			this.txt_Type.TabIndex = 64;
			this.txt_Type.Text = "";
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(170, 113);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 61;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// btn_Delete
			// 
			this.btn_Delete.ImageIndex = 0;
			this.btn_Delete.ImageList = this.img_Button;
			this.btn_Delete.Location = new System.Drawing.Point(241, 113);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(70, 23);
			this.btn_Delete.TabIndex = 60;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Delete_MouseUp);
			this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Delete_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(312, 113);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 59;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
			// 
			// Pop_SetType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 148);
			this.Controls.Add(this.txt_Desc);
			this.Controls.Add(this.lbl_Desc);
			this.Controls.Add(this.lbl_Type);
			this.Controls.Add(this.txt_Type);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_SetType";
			this.Text = "";
			this.Load += new System.EventHandler(this.Pop_SetShiftType_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Delete, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.txt_Type, 0);
			this.Controls.SetChildIndex(this.lbl_Type, 0);
			this.Controls.SetChildIndex(this.lbl_Desc, 0);
			this.Controls.SetChildIndex(this.txt_Desc, 0);
			this.ResumeLayout(false);

		}
		#endregion


		#region ���� ����


		private COM.OraDB MyOraDB = new COM.OraDB();

		//�� ������ �Ͼ �̺�Ʈ (Ȯ��, ����, ���)
		private string _CloseEvent;

		private string _LoadFlag;
		private string _Factory;

		#endregion


		#region ��� �޼���


		
		/// <summary>
		/// Inti_Form : Form Load �� �ʱ�ȭ �۾�
		/// </summary>
		private void Init_Form()
		{
			//Title

			ClassLib.ComFunction.SetLangDic(this);




			_LoadFlag = ClassLib.ComVar.Parameter_PopUp[0];

			switch(_LoadFlag)
			{
				case "0":    //holiday -> cal_type �߰�

					this.Text = "Set Calendar Type";
					lbl_MainTitle.Text = "Set Calendar Type";

					break;

				case "1":    //shift -> shift_type �߰�

					this.Text = "Set Shift Type";
					lbl_MainTitle.Text = "Set Shift Type";

					break;
					
			} 

			
			_Factory = ClassLib.ComVar.Parameter_PopUp[1];
			txt_Type.Text = ClassLib.ComVar.Parameter_PopUp[2];
			txt_Desc.Text = ClassLib.ComVar.Parameter_PopUp[3];

		}


		/// <summary>
		/// Close_Form : Form Close �� �۾�
		/// </summary>
		private void Close_Form()
		{
			ClassLib.ComVar.Parameter_PopUp = new string[] {txt_Type.Text, txt_Desc.Text, _CloseEvent};
			this.Close();
		}

 
	
		#endregion


		#region �̺�Ʈ ó�� 

		
		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			_CloseEvent = "Save";
			Close_Form();
		}


		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 1;
		}

		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 0;
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			_CloseEvent = "Delete";
 			Delete_Type();
			Close_Form();
		}

		private void btn_Delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 1;
		}

		private void btn_Delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 0;
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CloseEvent = "Cancel";
			Close_Form();
		}
  

		private void btn_Cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 1;
		}

		private void btn_Cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 0;
		}


		#endregion




		private void Pop_SetShiftType_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		 


		#region DB Connect


		
		/// <summary>
		/// Delete_Type :  ���� ����Ʈ ��� ���� 
		/// </summary>
		private void Delete_Type()
		{

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(2);

			switch(_LoadFlag)
			{
				case "0":    //holiday -> cal_type �߰�

					MyOraDB.Process_Name = "PKG_SPB_WORKCAL.DELETE_SPB_HOLIDAY_ALL";

					MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
					MyOraDB.Parameter_Name[1] = "ARG_CAL_TYPE";

					break;

				case "1":    //shift -> shift_type �߰�

					 
					MyOraDB.Process_Name = "PKG_SPB_WORKCAL.DELETE_SPB_SHIFT_ALL";

					MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
					MyOraDB.Parameter_Name[1] = "ARG_SHIFT_TYPE";
 

					break;
					
			}   
			

			
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Values[0] = _Factory; 
			MyOraDB.Parameter_Values[1] = txt_Type.Text;
 

			MyOraDB.Add_Modify_Parameter(true);  
			ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure ����		

			
			//Error ó��
			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ;
				
			}




		}




		#endregion







	}
}

