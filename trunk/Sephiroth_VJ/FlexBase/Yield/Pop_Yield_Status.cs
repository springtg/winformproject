using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.Yield
{
	public class Pop_Yield_Status : COM.PCHWinForm.Pop_Small_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.TextBox txt_Status;
		private System.Windows.Forms.Label lbl_ConfirmYMD;
		private System.Windows.Forms.Label lbl_Status;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.DateTimePicker dpick_ConfirmYMD;
		private System.Windows.Forms.Label btn_Apply;

		public Pop_Yield_Status()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
		}


		private string _Factory;
		private string _StyleCd; 
		private string _YieldStatus; 
		private string _YieldStatusDesc;


		public Pop_Yield_Status(string arg_factory, string arg_stylecd, string arg_yieldstatus, string arg_yieldstatus_desc)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_Factory = arg_factory;
			_StyleCd = arg_stylecd;
			_YieldStatus = arg_yieldstatus; 
			_YieldStatusDesc = arg_yieldstatus_desc; 
 

			Init_Form(); 



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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Status));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpick_ConfirmYMD = new System.Windows.Forms.DateTimePicker();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmYMD = new System.Windows.Forms.Label();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dpick_ConfirmYMD);
            this.groupBox1.Controls.Add(this.txt_Remarks);
            this.groupBox1.Controls.Add(this.txt_Status);
            this.groupBox1.Controls.Add(this.lbl_ConfirmYMD);
            this.groupBox1.Controls.Add(this.lbl_Remarks);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 88);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // dpick_ConfirmYMD
            // 
            this.dpick_ConfirmYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ConfirmYMD.Location = new System.Drawing.Point(108, 36);
            this.dpick_ConfirmYMD.Name = "dpick_ConfirmYMD";
            this.dpick_ConfirmYMD.Size = new System.Drawing.Size(270, 21);
            this.dpick_ConfirmYMD.TabIndex = 546;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Remarks.Location = new System.Drawing.Point(108, 58);
            this.txt_Remarks.MaxLength = 18;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(268, 21);
            this.txt_Remarks.TabIndex = 2;
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Status.Location = new System.Drawing.Point(108, 14);
            this.txt_Status.MaxLength = 100;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(268, 21);
            this.txt_Status.TabIndex = 545;
            this.txt_Status.TabStop = false;
            // 
            // lbl_ConfirmYMD
            // 
            this.lbl_ConfirmYMD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ConfirmYMD.ImageIndex = 0;
            this.lbl_ConfirmYMD.ImageList = this.img_Label;
            this.lbl_ConfirmYMD.Location = new System.Drawing.Point(7, 36);
            this.lbl_ConfirmYMD.Name = "lbl_ConfirmYMD";
            this.lbl_ConfirmYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_ConfirmYMD.TabIndex = 542;
            this.lbl_ConfirmYMD.Text = "Confirm Date";
            this.lbl_ConfirmYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Remarks.ImageIndex = 0;
            this.lbl_Remarks.ImageList = this.img_Label;
            this.lbl_Remarks.Location = new System.Drawing.Point(7, 58);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_Remarks.TabIndex = 541;
            this.lbl_Remarks.Text = "Remarks";
            this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Status.ImageIndex = 0;
            this.lbl_Status.ImageList = this.img_Label;
            this.lbl_Status.Location = new System.Drawing.Point(7, 14);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(100, 21);
            this.lbl_Status.TabIndex = 540;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 134);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 666;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(248, 134);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 23);
            this.btn_Apply.TabIndex = 665;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_Yield_Status
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 165);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Yield_Status";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
 

		//Apply 버튼 클릭 여부
		public bool _Close_Apply = false;



		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				//Title 
				this.Text = "Yield Status";  
				lbl_MainTitle.Text = "Yield Status";


                ClassLib.ComFunction.SetLangDic(this);


				txt_Status.Text = _YieldStatusDesc;


				dpick_ConfirmYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType; 
				dpick_ConfirmYMD.Text = DateTime.Now.ToString(ClassLib.ComVar.This_SetedDateType);



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
  
		}


		 


		/// <summary>
		/// Apply : [Apply] 버튼 이벤트
		/// </summary>
		private void Apply()
		{ 
 
			
			//bool save_flag = FlexBase.Yield.Form_BC_Yield_withExcel.Save_Yield_Status(_Factory, _StyleCd, _YieldStatus);

			ClassLib.ComFunction myFunction = new ClassLib.ComFunction(); 
			string confirm_ymd = myFunction.ConvertDate2DbType(dpick_ConfirmYMD.Text); 

			string remarks = txt_Remarks.Text.Trim();


			bool save_flag = Save_Yield_Status(_Factory, _StyleCd, _YieldStatus, confirm_ymd, remarks);


			if(!save_flag)
			{
				_Close_Apply = false; 
			}
			else
			{
				_Close_Apply = true;
				this.Close();
			}
 

			
		}




		#endregion 

		#region 이벤트 처리
		
		#region 버튼클릭시 이미지변경
 

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

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{  
				Apply();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_Close_Apply = false;
			this.Close();
		}

		 

		#endregion      

		#region DB Connect
 

		/// <summary>
		/// Save_Yield_Status : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_yieldstatus"></param>
		/// <param name="arg_confirmymd"></param>
		/// <param name="arg_remarks"></param>
		/// <returns></returns>
		private bool Save_Yield_Status(string arg_factory, string arg_stylecd, string arg_yieldstatus, string arg_confirmymd, string arg_remarks)
		{
			try
			{ 

				DataSet ds_ret;
 
				int col_ct = 6;   
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.SAVE_SBC_YIELD_INFO_STATUS";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_YIELD_STATUS";  
				MyOraDB.Parameter_Name[3] = "ARG_CONFIRM_YMD"; 
				MyOraDB.Parameter_Name[4] = "ARG_REMARKS";  
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_stylecd;
				MyOraDB.Parameter_Values[2] = arg_yieldstatus; 
				MyOraDB.Parameter_Values[3] = arg_confirmymd;
				MyOraDB.Parameter_Values[4] = arg_remarks;
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User; 



				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  // error
				{ 
					return false;
				}
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Yield_Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}




		#endregion 

 

	}
}

