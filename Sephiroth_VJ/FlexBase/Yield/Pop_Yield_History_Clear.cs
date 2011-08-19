using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.Yield
{
	public class Pop_Yield_History_Clear : COM.PCHWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ImageList img_LongLabel;
		private System.Windows.Forms.Label lbl_RemainCount;
		private System.Windows.Forms.TextBox txt_RemainCount;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Apply;
		private System.ComponentModel.IContainer components = null;

		public Pop_Yield_History_Clear()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Factory, _StyleCd;

		public Pop_Yield_History_Clear(string arg_factory, string arg_stylecd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			_Factory = arg_factory;
			_StyleCd = arg_stylecd;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_History_Clear));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_RemainCount = new System.Windows.Forms.TextBox();
            this.lbl_RemainCount = new System.Windows.Forms.Label();
            this.img_LongLabel = new System.Windows.Forms.ImageList(this.components);
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
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_RemainCount);
            this.groupBox1.Controls.Add(this.lbl_RemainCount);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 45);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // txt_RemainCount
            // 
            this.txt_RemainCount.BackColor = System.Drawing.SystemColors.Window;
            this.txt_RemainCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RemainCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_RemainCount.Location = new System.Drawing.Point(138, 14);
            this.txt_RemainCount.MaxLength = 18;
            this.txt_RemainCount.Name = "txt_RemainCount";
            this.txt_RemainCount.Size = new System.Drawing.Size(238, 21);
            this.txt_RemainCount.TabIndex = 542;
            // 
            // lbl_RemainCount
            // 
            this.lbl_RemainCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_RemainCount.ImageIndex = 0;
            this.lbl_RemainCount.ImageList = this.img_LongLabel;
            this.lbl_RemainCount.Location = new System.Drawing.Point(7, 14);
            this.lbl_RemainCount.Name = "lbl_RemainCount";
            this.lbl_RemainCount.Size = new System.Drawing.Size(130, 21);
            this.lbl_RemainCount.TabIndex = 541;
            this.lbl_RemainCount.Text = "Remain History Count";
            this.lbl_RemainCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_LongLabel
            // 
            this.img_LongLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongLabel.ImageStream")));
            this.img_LongLabel.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongLabel.Images.SetKeyName(0, "");
            this.img_LongLabel.Images.SetKeyName(1, "");
            this.img_LongLabel.Images.SetKeyName(2, "");
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 90);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 633;
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
            this.btn_Apply.Location = new System.Drawing.Point(248, 90);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 23);
            this.btn_Apply.TabIndex = 632;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_Yield_History_Clear
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 120);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Yield_History_Clear";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();  

		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				 
				this.Text = "Clear Yield History";
				lbl_MainTitle.Text = "Clear Yield History";

                ClassLib.ComFunction.SetLangDic(this);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
  
		} 


		/// <summary>
		/// Clear_Yield_History :  
		/// </summary>
		private void Clear_Yield_History()
		{ 
 
			DialogResult dr;
			bool check_flag = false;
			bool save_flag = false;
   
			// 정수형 숫자만 입력 가능하도록 처리
			//check_flag = ClassLib.ComFunction.Check_Decimal(txt_RemainCount.Text.Trim() );  
			
			check_flag = ClassLib.ComFunction.Set_NumberTextBox(txt_RemainCount, 20, ""); 
			if(! check_flag) return; 

			
			dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 
			if(dr == DialogResult.No) return;  
 
 
			save_flag = Clear_Yield_History_DB();
 

			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
			} 


		}




		#endregion  

		#region 이벤트 처리

		
		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				Clear_Yield_History();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

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

		#endregion 

		#region DB Connect
  

		/// <summary>
		/// Clear_Yield_History_DB : 
		/// </summary>
		/// <returns></returns>
		private bool Clear_Yield_History_DB()
		{
			try
			{
				DataSet ds_ret; 

				int col_ct = 4;   
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.DELETE_SBC_YIELD_HISTORY";
 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_REMAIN_VERSION_QTY";  
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER"; 
  

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
 
				  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _StyleCd.Replace("-", "");
				MyOraDB.Parameter_Values[2] = txt_RemainCount.Text; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_Factory; 


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
				ClassLib.ComFunction.User_Message(ex.Message, "Clear_Yield_History_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}


		}


		#endregion 



	}
}

