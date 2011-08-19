using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_List_Changer : COM.PCHWinForm.Pop_Small
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.ComponentModel.IContainer components = null;

		#region 생성자 / 소멸자
		public Pop_BI_Incoming_List_Changer()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_List_Changer));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.GridDefinition = "86.6666666666667:False:True;3.33333333333333:False:True;\t1.02040816326531:False:T" +
                "rue;93.8775510204082:False:False;1.02040816326531:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 48);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(392, 120);
            this.c1Sizer1.TabIndex = 0;
            this.c1Sizer1.TabStop = false;
            // 
            // Pop_BI_Incoming_List_Changer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(386, 167);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BI_Incoming_List_Changer";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{

            ClassLib.ComFunction.SetLangDic(this);


			string vTitle		= COM.ComVar.Parameter_PopUp[0];
			lbl_MainTitle.Text	= vTitle;
			UserControl vCtl	= null;
			this.Text = "Value Changer";



			if (ClassLib.ComVar.Parameter_PopUp_Object != null)
				vCtl = new Pop_BI_Incoming_List_CItem();
			else if (ClassLib.ComVar.Parameter_PopUpTable != null)
				vCtl = new Pop_BI_Incoming_List_BItem();
			else
			{
				if (vTitle.Equals(ClassLib.ComVar.Vendor) || vTitle.Equals(ClassLib.ComVar.User))
					vCtl = new Pop_BI_Incoming_List_MixedItem();
				else
					vCtl = new Pop_BI_Incoming_List_LItem();
			}

			this.c1Sizer1.Controls.Add(vCtl);
			COM.ComVar.Parameter_PopUp = null;
			ClassLib.ComVar.Parameter_PopUp_Object = null;
			vCtl.Disposed += new EventHandler(this.Ctl_Closed);
		}

		private void Ctl_Closed(object sender, System.EventArgs args)
		{
			this.Dispose();
		}

		#endregion
	}
}

