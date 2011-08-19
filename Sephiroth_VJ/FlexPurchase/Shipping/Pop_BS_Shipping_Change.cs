using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_Change : COM.PCHWinForm.Pop_Small
	{

		#region 사용자 정의 변수
		
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 디자이너에서 생성한 변수
		
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.DateTimePicker dpick_scanYmd;
		private System.Windows.Forms.Label lbl_scanYmd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components = null;
		
		#endregion 

		#region 생성자 / 소멸자

		public Pop_BS_Shipping_Change()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_Change));
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.dpick_scanYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_scanYmd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(206, 96);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(277, 96);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dpick_scanYmd
            // 
            this.dpick_scanYmd.Checked = false;
            this.dpick_scanYmd.CustomFormat = "";
            this.dpick_scanYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_scanYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_scanYmd.Location = new System.Drawing.Point(109, 16);
            this.dpick_scanYmd.Name = "dpick_scanYmd";
            this.dpick_scanYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_scanYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_scanYmd.TabIndex = 1;
            // 
            // lbl_scanYmd
            // 
            this.lbl_scanYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_scanYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scanYmd.ImageIndex = 0;
            this.lbl_scanYmd.ImageList = this.img_Label;
            this.lbl_scanYmd.Location = new System.Drawing.Point(8, 16);
            this.lbl_scanYmd.Name = "lbl_scanYmd";
            this.lbl_scanYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_scanYmd.TabIndex = 202;
            this.lbl_scanYmd.Text = "Shipping Date";
            this.lbl_scanYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dpick_scanYmd);
            this.groupBox1.Controls.Add(this.lbl_scanYmd);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Pop_BS_Shipping_Change
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 128);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Name = "Pop_BS_Shipping_Change";
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelClickProcess();
		}
		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
        {
			this.Text			= "Shipping Change";
            lbl_MainTitle.Text = "Shipping Change";
            ClassLib.ComFunction.SetLangDic(this);

			dpick_scanYmd.Value = ClassLib.ComFunction.StringToDateTime(ClassLib.ComVar.Parameter_PopUp[3].ToString());

		}

		private void Btn_ApplyClickProcess()
		{
			if (this.SHIPPING_CHANGE())
			{
				ClassLib.ComFunction.User_Message("Complete Shipping Change", "Shipping Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				ClassLib.ComFunction.User_Message("Error Shipping Change", "Shipping Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

	}

		private void Btn_CancelClickProcess()
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}



		#endregion

		#region 버튼효과

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;		
		}

		#endregion 
		
		#region DB 작업

		/// <summary>
		/// SHIPPING_CHANGE : 
		/// </summary>
		public bool SHIPPING_CHANGE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.RUN_SHIPPING_CHANGE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_SHIP_DATE";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = ClassLib.ComVar.Parameter_PopUp[0].ToString();
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.Parameter_PopUp[1].ToString();
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.Parameter_PopUp[2].ToString();
				MyOraDB.Parameter_Values[3] = dpick_scanYmd.Text.Replace("-", "");  
				MyOraDB.Parameter_Values[4] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);

				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SHIPPING_CHANGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		#endregion


	}
}

