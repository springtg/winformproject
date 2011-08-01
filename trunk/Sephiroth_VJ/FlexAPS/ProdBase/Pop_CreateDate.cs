using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdBase
{
	public class Pop_CreateDate : COM.APSWinForm.Pop_Small
	{
		private System.Windows.Forms.DateTimePicker dpick_ToYMD;
		private System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.TextBox txt_ToYMD;
		private System.Windows.Forms.TextBox txt_FromYMD;
		private System.Windows.Forms.Label lbl_Format;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateDate()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateDate));
			this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.txt_ToYMD = new System.Windows.Forms.TextBox();
			this.txt_FromYMD = new System.Windows.Forms.TextBox();
			this.lbl_Format = new System.Windows.Forms.Label();
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
			// dpick_ToYMD
			// 
			this.dpick_ToYMD.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToYMD.Location = new System.Drawing.Point(8, 120);
			this.dpick_ToYMD.Name = "dpick_ToYMD";
			this.dpick_ToYMD.Size = new System.Drawing.Size(72, 22);
			this.dpick_ToYMD.TabIndex = 69;
			this.dpick_ToYMD.Visible = false;
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(8, 104);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(72, 22);
			this.dpick_FromYMD.TabIndex = 68;
			this.dpick_FromYMD.Visible = false;
			// 
			// label2
			// 
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(40, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 67;
			this.label2.Text = "End Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(40, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 66;
			this.label1.Text = "Start Date";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(241, 112);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 65;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(312, 112);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 64;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
			// 
			// txt_ToYMD
			// 
			this.txt_ToYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ToYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ToYMD.Location = new System.Drawing.Point(141, 77);
			this.txt_ToYMD.MaxLength = 8;
			this.txt_ToYMD.Name = "txt_ToYMD";
			this.txt_ToYMD.Size = new System.Drawing.Size(210, 21);
			this.txt_ToYMD.TabIndex = 71;
			this.txt_ToYMD.Text = "";
			this.txt_ToYMD.Leave += new System.EventHandler(this.txt_ToYMD_Leave);
			// 
			// txt_FromYMD
			// 
			this.txt_FromYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_FromYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_FromYMD.Location = new System.Drawing.Point(141, 55);
			this.txt_FromYMD.MaxLength = 8;
			this.txt_FromYMD.Name = "txt_FromYMD";
			this.txt_FromYMD.Size = new System.Drawing.Size(210, 21);
			this.txt_FromYMD.TabIndex = 70;
			this.txt_FromYMD.Text = "";
			this.txt_FromYMD.Leave += new System.EventHandler(this.txt_FromYMD_Leave);
			// 
			// lbl_Format
			// 
			this.lbl_Format.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Format.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Format.Location = new System.Drawing.Point(144, 32);
			this.lbl_Format.Name = "lbl_Format";
			this.lbl_Format.Size = new System.Drawing.Size(208, 23);
			this.lbl_Format.TabIndex = 72;
			this.lbl_Format.Text = "FORMAT : YYYYMMDD";
			this.lbl_Format.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_CreateDate
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 145);
			this.Controls.Add(this.lbl_Format);
			this.Controls.Add(this.txt_ToYMD);
			this.Controls.Add(this.txt_FromYMD);
			this.Controls.Add(this.dpick_ToYMD);
			this.Controls.Add(this.dpick_FromYMD);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_CreateDate";
			this.Text = "Create Date";
			this.Load += new System.EventHandler(this.Pop_CreateDate_Load);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.dpick_FromYMD, 0);
			this.Controls.SetChildIndex(this.dpick_ToYMD, 0);
			this.Controls.SetChildIndex(this.txt_FromYMD, 0);
			this.Controls.SetChildIndex(this.txt_ToYMD, 0);
			this.Controls.SetChildIndex(this.lbl_Format, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
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
 			 
			//Title
			this.Text = "Create Date";
			lbl_MainTitle.Text = "Create Date";

			ClassLib.ComFunction.SetLangDic(this);



//			dpick_FromYMD.CustomFormat = " ";
//			dpick_ToYMD.CustomFormat = " ";
  
		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{
			this.Close();
		}

   
 

		#endregion 

		#region 이벤트 처리 

		
  
//		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
//		{
//			dpick_FromYMD.CustomFormat = "yyyyMMdd"; 
//		}
//
//		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
//		{
//			dpick_ToYMD.CustomFormat = "yyyyMMdd"; 
//		}

  
		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 1;
		}

		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 0;
		}

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			if(txt_FromYMD.Text == "" || txt_ToYMD.Text == "") return;

			Save_Date();
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

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			Close_Form();
		}

		private void txt_FromYMD_Leave(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_NumberTextBox(txt_FromYMD, 8);
		}

		private void txt_ToYMD_Leave(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_NumberTextBox(txt_ToYMD, 8);
		}

		

		#endregion 

		#region DB Connect


		/// <summary>
		/// Save_Date : 기본 날짜 생성
		/// </summary>
		private void Save_Date()
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.INSERT_CAL";
	
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FROM_YMD";
			MyOraDB.Parameter_Name[1] = "ARG_TO_YMD"; 
			MyOraDB.Parameter_Name[2] = "ARG_UPD_USER"; 
			  
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = txt_FromYMD.Text;  //dpick_FromYMD.Text;
			MyOraDB.Parameter_Values[1] = txt_ToYMD.Text;    //dpick_ToYMD.Text;
			MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;  


			MyOraDB.Add_Modify_Parameter(true);  
			ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
			//Error 처리
			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ; 
			} 
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
			}

 
		}

 

		#endregion


		private void Pop_CreateDate_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

 


	}
}

