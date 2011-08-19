using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.MaterialBase
{
	public class Pop_SaveName : COM.PCHWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Save;
		private System.ComponentModel.IContainer components = null;

		public Pop_SaveName()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		private string _FormName = "";
		private string _Name = "";

		public bool _Close_Save = false;

		public Pop_SaveName(string arg_formname, string arg_name)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_FormName = arg_formname;
			_Name = arg_name;

			Init_FormName();
 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_SaveName));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(5, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 40);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.ImageIndex = 0;
            this.lbl_Name.ImageList = this.img_Label;
            this.lbl_Name.Location = new System.Drawing.Point(7, 13);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Name.TabIndex = 103;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Name.Location = new System.Drawing.Point(108, 13);
            this.txt_Name.MaxLength = 100;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(268, 21);
            this.txt_Name.TabIndex = 102;
            this.txt_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyUp);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 88);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 563;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Save.ImageIndex = 0;
            this.btn_Save.ImageList = this.img_Button;
            this.btn_Save.Location = new System.Drawing.Point(248, 88);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(70, 23);
            this.btn_Save.TabIndex = 562;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Save.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_SaveName
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 120);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_SaveName";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Save, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 멤버 메서드

 
		/// <summary>
		/// Inti_FormName : Form Load 시 초기화 작업
		/// </summary>
		private void Init_FormName()
		{ 
			try
            {

                ClassLib.ComFunction.SetLangDic(this); 


				//Title
				if(_FormName.Equals("Form_BC_BOMTemplate") )
				{
					this.Text = "Save BOM Template Name";
					lbl_MainTitle.Text = "Save BOM Template Name";

				}
				else if(_FormName.Equals("Form_BW_Model") )
				{
					this.Text = "Save Workflow Name";
					lbl_MainTitle.Text = "Save Workflow Name";
				}
				else if(_FormName.Equals("Pop_Yield_Modify_withSRF") )
				{
					this.Text = "Save New Component";
					lbl_MainTitle.Text = "Save New Component";
				}

 
				txt_Name.Text = _Name;
  	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_FormName", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Save_OK : 
		/// </summary>
		private void Save_OK()
		{
			try
			{ 
				DataTable dt_ret;
 
				dt_ret = Check_Duplicate_DB();

				// 중복 아님, 저장 가능
				if(Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]) )  
				{
					_Close_Save = true;
					ClassLib.ComVar.Parameter_PopUp = new string[] {txt_Name.Text};
 
					dt_ret.Dispose();  
					this.Close();

				} // end if
				else
				{
					ClassLib.ComFunction.User_Message("Duplicate Name : [" 
													+ dt_ret.Rows[0].ItemArray[0].ToString().Trim() + "]", 
													"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

					dt_ret.Dispose();   
				} 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			
		}


		#endregion 

		#region 이벤트 처리


		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Save_OK();
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Close_Save = false;
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txt_Name_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return; 
				Save_OK();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Name_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
		/// Check_Duplicate_DB : 
		/// </summary> 
		/// <returns></returns>
		private DataTable Check_Duplicate_DB()
		{  
			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;  

				MyOraDB.ReDim_Parameter(2);

				 
				if(_FormName.Equals("Form_BC_BOMTemplate") )
				{
					MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.CHECK_TEMPLATE_TREE_EXIST"; 
				
					MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_NAME"; 
					MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


				}
				else if(_FormName.Equals("Form_BW_Model") )
				{
					MyOraDB.Process_Name = "PKG_SBW_MODEL.CHECK_WORKFLOW_NAME_EXIST"; 
				
					MyOraDB.Parameter_Name[0] = "ARG_WORKFLOW_NAME"; 
					MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				}
				else if(_FormName.Equals("Pop_Yield_Modify_withSRF") )
				{
					MyOraDB.Process_Name = "PKG_SBC_YIELD_SRF.CHECK_COMPONENT_NAME_EXIST"; 
				
					MyOraDB.Parameter_Name[0] = "ARG_COMPONENT_NAME"; 
					MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				}


				

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;  

				MyOraDB.Parameter_Values[0] = @"'" + txt_Name.Text + @"'";
				MyOraDB.Parameter_Values[1] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}


		#endregion

		


	}
}

