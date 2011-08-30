using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexOrder.Report
{
	/// <summary>
	/// Form_RD_Base�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Form_RD_Base : System.Windows.Forms.Form
	{
		#region ��Ʈ�� �Ӽ�����
		private AxRDVIEWER40Lib.AxRdviewer40 RPT_Veiwer;
		private System.ComponentModel.Container components = null;
		private string  txt_Filename =" ";
		private string  mrd_Filename =" ";
		private string  Para =" ";
		#endregion

		public Form_RD_Base(string arg_TFilename, string arg_MFilename, string arg_Para)
		{

			txt_Filename = arg_TFilename;
			mrd_Filename = arg_MFilename;
			Para         = arg_Para;	

			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_RD_Base));
			this.RPT_Veiwer = new AxRDVIEWER40Lib.AxRdviewer40();
			((System.ComponentModel.ISupportInitialize)(this.RPT_Veiwer)).BeginInit();
			this.SuspendLayout();
			// 
			// RPT_Veiwer
			// 
			this.RPT_Veiwer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RPT_Veiwer.Enabled = true;
			this.RPT_Veiwer.Location = new System.Drawing.Point(0, 0);
			this.RPT_Veiwer.Name = "RPT_Veiwer";
			this.RPT_Veiwer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RPT_Veiwer.OcxState")));
			this.RPT_Veiwer.Size = new System.Drawing.Size(992, 639);
			this.RPT_Veiwer.TabIndex = 1;
			// 
			// Form_RD_Base
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(992, 639);
			this.Controls.Add(this.RPT_Veiwer);
			this.IsMdiContainer = true;
			this.Name = "Form_RD_Base";
			this.Text = "Form_RD_Base";
			this.Load += new System.EventHandler(this.Form_RD_Base_Load);
			((System.ComponentModel.ISupportInitialize)(this.RPT_Veiwer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_RD_Base_Load(object sender, System.EventArgs e)
		{
			//RPT_Veiwer.ZoomRatio = 100;
			RPT_Veiwer.FileOpen(@mrd_Filename, Para); 
			
		}
	}
}
