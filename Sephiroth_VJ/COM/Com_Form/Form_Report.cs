using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace COM.Com_Form
{
	/// <summary>
	/// Form_Report�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Form_Report : System.Windows.Forms.Form
	{
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string title;
		private string mrdname;
		private AxRDVIEWER40Lib.AxRdviewer40 report_viewer;
		private string para;

		public Form_Report(string arg_title, string arg_mrdname, string arg_para)
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//

			title = arg_title;
			mrdname = arg_mrdname;
			para = arg_para;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Report));
			this.report_viewer = new AxRDVIEWER40Lib.AxRdviewer40();
			((System.ComponentModel.ISupportInitialize)(this.report_viewer)).BeginInit();
			this.SuspendLayout();
			// 
			// report_viewer
			// 
			this.report_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.report_viewer.Enabled = true;
			this.report_viewer.Location = new System.Drawing.Point(0, 0);
			this.report_viewer.Name = "report_viewer";
			this.report_viewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("report_viewer.OcxState")));
			this.report_viewer.Size = new System.Drawing.Size(936, 534);
			this.report_viewer.TabIndex = 0;
			// 
			// Form_Report
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(936, 534);
			this.Controls.Add(this.report_viewer);
			this.Name = "Form_Report";
			this.Text = "Form_Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.report_viewer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Report_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text = title;
			report_viewer.FileOpen(mrdname, para);
		}
	}
}
