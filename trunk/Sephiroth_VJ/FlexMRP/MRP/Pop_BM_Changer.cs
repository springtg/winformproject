using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexMRP.MRP
{
	public class Pop_BM_Changer : COM.PCHWinForm.Pop_Small
	{
		private System.ComponentModel.IContainer components = null;

		public Pop_BM_Changer()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_Changer));
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(324, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// Pop_BM_Changer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(358, 119);
			this.Name = "Pop_BM_Changer";

		}
		#endregion

		private void Init_Form()
		{
			string vTitle		= COM.ComVar.Parameter_PopUp[0];
			this.Text			= vTitle;
			lbl_MainTitle.Text	= vTitle;
			Control vCtl = null;

			switch (vTitle)
			{
				case "Value":
					vCtl = new Pop_BM_Text();
					break;

				case "Password":
					vCtl = new Pop_BM_Password();
					break;

				case "Date":
					
					if(COM.ComVar.Parameter_PopUp.Length == 1)
					{
						vCtl = new Pop_BM_DItem();
					}
					else
					{
						vCtl = new Pop_BM_DItem(COM.ComVar.Parameter_PopUp[1]);
					}

					break; 

				default:
					vCtl = new Pop_BM_CItem();
					break;
			}

			vCtl.Location = new Point(8, 40);
			this.Controls.Add(vCtl);
			COM.ComVar.Parameter_PopUp = null;
			ClassLib.ComVar.Parameter_PopUp_Object = null;
			vCtl.Disposed += new EventHandler(this.Ctl_Closed);
		}

		private void Ctl_Closed(object sender, System.EventArgs args)
		{
			this.Dispose();
		}
	}
}

