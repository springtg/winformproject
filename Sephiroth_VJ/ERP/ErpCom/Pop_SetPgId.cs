using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.ErpCom
{
	public class Pop_SetPgId : COM.APSWinForm.Pop_Small
	{
		private System.Windows.Forms.TextBox txt_PgSeq;
		private System.Windows.Forms.TextBox txt_PgId;
		private System.Windows.Forms.Label lbl_PgSeq;
		private System.Windows.Forms.Label lbl_PgId;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label lbl_save;
		private System.Windows.Forms.Label lbl_delete;
		private System.Windows.Forms.Label lbl_close;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetPgId()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetPgId));
			this.txt_PgSeq = new System.Windows.Forms.TextBox();
			this.lbl_PgSeq = new System.Windows.Forms.Label();
			this.lbl_PgId = new System.Windows.Forms.Label();
			this.txt_PgId = new System.Windows.Forms.TextBox();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.lbl_save = new System.Windows.Forms.Label();
			this.lbl_delete = new System.Windows.Forms.Label();
			this.lbl_close = new System.Windows.Forms.Label();
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
			this.lbl_MainTitle.Text = "Set Program ID/SEQ";
			// 
			// txt_PgSeq
			// 
			this.txt_PgSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PgSeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_PgSeq.Location = new System.Drawing.Point(109, 62);
			this.txt_PgSeq.MaxLength = 20;
			this.txt_PgSeq.Name = "txt_PgSeq";
			this.txt_PgSeq.Size = new System.Drawing.Size(275, 21);
			this.txt_PgSeq.TabIndex = 58;
			this.txt_PgSeq.Text = "";
			// 
			// lbl_PgSeq
			// 
			this.lbl_PgSeq.ImageIndex = 0;
			this.lbl_PgSeq.ImageList = this.img_Label;
			this.lbl_PgSeq.Location = new System.Drawing.Point(8, 62);
			this.lbl_PgSeq.Name = "lbl_PgSeq";
			this.lbl_PgSeq.Size = new System.Drawing.Size(100, 21);
			this.lbl_PgSeq.TabIndex = 56;
			this.lbl_PgSeq.Text = "����";
			this.lbl_PgSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PgId
			// 
			this.lbl_PgId.ImageIndex = 0;
			this.lbl_PgId.ImageList = this.img_Label;
			this.lbl_PgId.Location = new System.Drawing.Point(8, 40);
			this.lbl_PgId.Name = "lbl_PgId";
			this.lbl_PgId.Size = new System.Drawing.Size(100, 21);
			this.lbl_PgId.TabIndex = 55;
			this.lbl_PgId.Text = "���̵�";
			this.lbl_PgId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_PgId
			// 
			this.txt_PgId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PgId.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_PgId.Location = new System.Drawing.Point(109, 40);
			this.txt_PgId.MaxLength = 40;
			this.txt_PgId.Name = "txt_PgId";
			this.txt_PgId.Size = new System.Drawing.Size(275, 21);
			this.txt_PgId.TabIndex = 57;
			this.txt_PgId.Text = "";
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_save
			// 
			this.lbl_save.ImageIndex = 2;
			this.lbl_save.ImageList = this.imgs_new_btn;
			this.lbl_save.Location = new System.Drawing.Point(96, 88);
			this.lbl_save.Name = "lbl_save";
			this.lbl_save.Size = new System.Drawing.Size(80, 23);
			this.lbl_save.TabIndex = 229;
			this.lbl_save.Click += new System.EventHandler(this.lbl_save_Click);
			// 
			// lbl_delete
			// 
			this.lbl_delete.ImageIndex = 6;
			this.lbl_delete.ImageList = this.imgs_new_btn;
			this.lbl_delete.Location = new System.Drawing.Point(8, 88);
			this.lbl_delete.Name = "lbl_delete";
			this.lbl_delete.Size = new System.Drawing.Size(80, 23);
			this.lbl_delete.TabIndex = 228;
			this.lbl_delete.Click += new System.EventHandler(this.lbl_delete_Click);
			// 
			// lbl_close
			// 
			this.lbl_close.ImageIndex = 10;
			this.lbl_close.ImageList = this.imgs_new_btn;
			this.lbl_close.Location = new System.Drawing.Point(304, 88);
			this.lbl_close.Name = "lbl_close";
			this.lbl_close.Size = new System.Drawing.Size(80, 23);
			this.lbl_close.TabIndex = 230;
			this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
			// 
			// Pop_SetPgId
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 120);
			this.Controls.Add(this.lbl_close);
			this.Controls.Add(this.lbl_save);
			this.Controls.Add(this.lbl_delete);
			this.Controls.Add(this.txt_PgSeq);
			this.Controls.Add(this.lbl_PgSeq);
			this.Controls.Add(this.lbl_PgId);
			this.Controls.Add(this.txt_PgId);
			this.Name = "Pop_SetPgId";
			this.Text = "Set Program ID/SEQ";
			this.Load += new System.EventHandler(this.Pop_SetPgId_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.txt_PgId, 0);
			this.Controls.SetChildIndex(this.lbl_PgId, 0);
			this.Controls.SetChildIndex(this.lbl_PgSeq, 0);
			this.Controls.SetChildIndex(this.txt_PgSeq, 0);
			this.Controls.SetChildIndex(this.lbl_delete, 0);
			this.Controls.SetChildIndex(this.lbl_save, 0);
			this.Controls.SetChildIndex(this.lbl_close, 0);
			this.ResumeLayout(false);

		}
		#endregion


		#region ���� ����

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion


		#region ��� �޼���


		
		/// <summary>
		/// Inti_Form : Form Load �� �ʱ�ȭ �۾�
		/// </summary>
		private void Init_Form()
		{
			//Title
			this.Text = "Set Program ID/SEQ";
			this.lbl_MainTitle.Text = "Set Program ID/SEQ";
			ClassLib.ComFunction.SetLangDic(this);



			txt_PgId.Text = COM.ComVar.Parameter_PopUp[0];
			txt_PgSeq.Text = COM.ComVar.Parameter_PopUp[1];

		}


		/// <summary>
		/// Close_Form : Form Close �� �۾�
		/// </summary>
		private void Close_Form()
		{
			COM.ComVar.Parameter_PopUp = new string[] {txt_PgId.Text, txt_PgSeq.Text};
			this.Close();
		}




		
		#endregion


		#region �̺�Ʈ ó�� 


		private void Pop_SetPgId_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void lbl_save_Click(object sender, System.EventArgs e)
		{
			Save_PgList();
			Close_Form();
		}

		private void lbl_delete_Click(object sender, System.EventArgs e)
		{
			Delete_PgList();
			Close_Form();
		}

		private void lbl_close_Click(object sender, System.EventArgs e)
		{
			Close_Form();
		}


		#endregion



		#region DB Connect

  
		/// <summary>
		/// Save_PgList : ���α׷� ���̵�, ���� ����Ʈ ����
		/// </summary>
		private void Save_PgList()
		{
			  
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SCM_TABLE.INSERT_PG_LIST";
 
			//02.ARGURMENT�� 
			MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
			MyOraDB.Parameter_Name[1] = "ARG_PG_SEQ";
			MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";  


			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 

			
			//04.DATA ����  
			MyOraDB.Parameter_Values[0] = txt_PgId.Text; 
			MyOraDB.Parameter_Values[1] = txt_PgSeq.Text; 
			MyOraDB.Parameter_Values[2] = COM.ComVar.This_User; 

			MyOraDB.Add_Modify_Parameter(true); 

			ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure ����		

			
			//Error ó��
			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ;
				
			}



		}


		/// <summary>
		/// Delete_PgList : ���α׷� ���̵�, ���� ����Ʈ ���� (���� ����Ʈ ��� ����)
		/// </summary>
		private void Delete_PgList()
		{
			 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SCM_TABLE.DELETE_PG_LIST";
 
			//02.ARGURMENT�� 
			MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
			MyOraDB.Parameter_Name[1] = "ARG_PG_SEQ";   


			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 

			
			//04.DATA ����  
			MyOraDB.Parameter_Values[0] = txt_PgId.Text; 
			MyOraDB.Parameter_Values[1] = txt_PgSeq.Text;  

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

