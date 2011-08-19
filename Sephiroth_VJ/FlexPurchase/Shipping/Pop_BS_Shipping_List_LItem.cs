using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	/// <summary>
	/// Pop_BS_Shipping_List_CItem에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_BS_Shipping_List_LItem : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_value;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components;

		public Pop_BS_Shipping_List_LItem()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
            lbl_item.Text = COM.ComVar.Parameter_PopUp[0];
		}

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BS_Shipping_List_LItem));
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.btn_apply = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_value = new System.Windows.Forms.TextBox();
			this.lbl_item = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(70, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_apply
			// 
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.ImageIndex = 1;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(188, 38);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 235;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.ImageIndex = 1;
			this.btn_cancel.ImageList = this.img_Button;
			this.btn_cancel.Location = new System.Drawing.Point(259, 38);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_cancel.TabIndex = 236;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.TabIndex = 237;
			// 
			// txt_value
			// 
			this.txt_value.BackColor = System.Drawing.SystemColors.Window;
			this.txt_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_value.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_value.Location = new System.Drawing.Point(109, 16);
			this.txt_value.MaxLength = 30;
			this.txt_value.Name = "txt_value";
			this.txt_value.Size = new System.Drawing.Size(220, 21);
			this.txt_value.TabIndex = 234;
			this.txt_value.Text = "";
			this.txt_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_value_KeyPress);
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(248)), ((System.Byte)(218)));
			this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.Location = new System.Drawing.Point(8, 16);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_item.TabIndex = 246;
			this.lbl_item.Text = "Item";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_value);
			this.groupBox1.Controls.Add(this.btn_cancel);
			this.groupBox1.Controls.Add(this.btn_apply);
			this.groupBox1.Controls.Add(this.lbl_item);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 72);
			this.groupBox1.TabIndex = 247;
			this.groupBox1.TabStop = false;
			// 
			// Pop_BS_Shipping_List_LItem
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Pop_BS_Shipping_List_LItem";
			this.Size = new System.Drawing.Size(344, 72);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_TextBox(txt_value, "");
			this.Dispose();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void txt_value_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
				btn_apply_Click(null, null);
		}
	}
}
