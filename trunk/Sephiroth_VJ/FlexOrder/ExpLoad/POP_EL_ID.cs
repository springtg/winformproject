using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexOrder.ExpLoad
{
	public class POP_EL_ID : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤정의 및 리소스정의
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.TextBox txt_Fail;
		private System.Windows.Forms.TextBox txt_Total;
		private System.Windows.Forms.TextBox txt_Load;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

		public POP_EL_ID()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

        private string _thisfactory ="";
		private string _totalcount ="";
		private string _loadcount ="";
		private string _failcount ="";

		public POP_EL_ID(string arg_this_factory, string arg_total_count, string arg_load_count, string arg_fail_count)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			_thisfactory  = arg_this_factory;
			_totalcount = arg_total_count;
			_loadcount  = arg_load_count;
			_failcount  = arg_fail_count;

			


			Init_Form();

			

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

		#endregion


		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EL_ID));
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Fail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Total = new System.Windows.Forms.TextBox();
			this.txt_Load = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
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
			this.lbl_MainTitle.Text = "ID Loading";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.ImageIndex = 2;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 248;
			this.label2.Text = "Fail Count";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Fail
			// 
			this.txt_Fail.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Fail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Fail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Fail.ForeColor = System.Drawing.Color.Red;
			this.txt_Fail.Location = new System.Drawing.Point(111, 103);
			this.txt_Fail.MaxLength = 10;
			this.txt_Fail.Name = "txt_Fail";
			this.txt_Fail.Size = new System.Drawing.Size(220, 21);
			this.txt_Fail.TabIndex = 247;
			this.txt_Fail.Text = "";
			this.txt_Fail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 2;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 246;
			this.label1.Text = "Load Count";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Total
			// 
			this.txt_Total.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Total.Enabled = false;
			this.txt_Total.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Total.Location = new System.Drawing.Point(111, 61);
			this.txt_Total.MaxLength = 10;
			this.txt_Total.Name = "txt_Total";
			this.txt_Total.Size = new System.Drawing.Size(220, 20);
			this.txt_Total.TabIndex = 245;
			this.txt_Total.Text = "";
			this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_Load
			// 
			this.txt_Load.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Load.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Load.Enabled = false;
			this.txt_Load.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Load.Location = new System.Drawing.Point(111, 82);
			this.txt_Load.MaxLength = 10;
			this.txt_Load.Name = "txt_Load";
			this.txt_Load.ReadOnly = true;
			this.txt_Load.Size = new System.Drawing.Size(220, 20);
			this.txt_Load.TabIndex = 244;
			this.txt_Load.Text = "";
			this.txt_Load.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(111, 40);
			this.txt_Factory.MaxLength = 6;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.Size = new System.Drawing.Size(220, 20);
			this.txt_Factory.TabIndex = 243;
			this.txt_Factory.Text = "";
			this.txt_Factory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8F);
			this.label7.ImageIndex = 2;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(8, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 242;
			this.label7.Text = "Total Count";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 2;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 241;
			this.label9.Text = "Factory";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(257, 129);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 249;
			this.btn_Cancel.Text = "OK";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(8, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(240, 23);
			this.label3.TabIndex = 250;
			this.label3.Text = "If there is fail count, please check  data";
			// 
			// POP_EL_ID
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(338, 159);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Fail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Total);
			this.Controls.Add(this.txt_Load);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Name = "POP_EL_ID";
			this.Load += new System.EventHandler(this.POP_EL_ID_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.txt_Load, 0);
			this.Controls.SetChildIndex(this.txt_Total, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txt_Fail, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.ResumeLayout(false);

		}
		#endregion


		#region  공통메쏘드
		private void Init_Form()
		{ 
			
		
			//Title
			this.Text = "ID Loading";
			this.lbl_MainTitle.Text = "ID Loading";
			

			txt_Factory.Text = _thisfactory;
			txt_Total.Text  = _totalcount;
			txt_Load.Text  = _loadcount;
			txt_Fail.Text   =_failcount;


			

		}

	
		
			

		#endregion


		#region 버튼이벤트
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion 


		private void POP_EL_ID_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
	}
}

