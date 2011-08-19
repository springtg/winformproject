using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// Form_Sephiroth_About�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Form_Sephiroth_About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label btn_colse;
		private System.Windows.Forms.Label lbl_adout;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_Sephiroth_About()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//


			lbl_adout.Text = "�� ���α׷��� ��ȣ �˴ϴ�.";
			btn_colse.Focus();
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sephiroth_About));
            this.btn_colse = new System.Windows.Forms.Label();
            this.lbl_adout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_colse
            // 
            this.btn_colse.BackColor = System.Drawing.Color.Transparent;
            this.btn_colse.Image = ((System.Drawing.Image)(resources.GetObject("btn_colse.Image")));
            this.btn_colse.Location = new System.Drawing.Point(244, 199);
            this.btn_colse.Name = "btn_colse";
            this.btn_colse.Size = new System.Drawing.Size(83, 21);
            this.btn_colse.TabIndex = 0;
            this.btn_colse.Click += new System.EventHandler(this.btn_colse_Click);
            // 
            // lbl_adout
            // 
            this.lbl_adout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adout.Location = new System.Drawing.Point(40, 112);
            this.lbl_adout.Name = "lbl_adout";
            this.lbl_adout.Size = new System.Drawing.Size(288, 72);
            this.lbl_adout.TabIndex = 1;
            this.lbl_adout.Text = "�� ���α׷�...";
            this.lbl_adout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form_Sephiroth_About
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(343, 229);
            this.Controls.Add(this.lbl_adout);
            this.Controls.Add(this.btn_colse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Sephiroth_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Sephiroth";
            this.ResumeLayout(false);

		}
		#endregion

		private void btn_colse_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
