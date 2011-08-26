using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexVJ_Common.Report
{
	/// <summary>
	/// Form_RdViewer�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Form_RdViewer : System.Windows.Forms.Form
	{

		#region ��Ʈ�� �Ӽ�����

		private System.ComponentModel.Container components = null;
		//private System.Windows.Forms.Panel panel1; 
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		public System.Windows.Forms.StatusBar stbar;

		//private string  txt_Filename =" ";
		private string  mrd_FileName =" ";
		private C1.Win.C1Command.C1ContextMenu c1ContextMenu1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
//		private AxRDVIEWER40Lib.AxRdviewer40 axRdviewer402;
		private AxRDVIEWER40Lib.AxRdviewer40 axRdviewer401; 
		private string  sParam =" ";		

		#endregion
		
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>

		public Form_RdViewer(string arg_MrdFileName, string arg_param)
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			mrd_FileName = arg_MrdFileName;
			sParam       = arg_param;

			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_RdViewer));
			this.stbar = new System.Windows.Forms.StatusBar();
			this.info_bar = new System.Windows.Forms.StatusBarPanel();
			this.formname_bar = new System.Windows.Forms.StatusBarPanel();
			this.c1ContextMenu1 = new C1.Win.C1Command.C1ContextMenu();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.axRdviewer401 = new AxRDVIEWER40Lib.AxRdviewer40();
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axRdviewer401)).BeginInit();
			this.SuspendLayout();
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 598);
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.info_bar,
																					 this.formname_bar});
			this.stbar.ShowPanels = true;
			this.stbar.Size = new System.Drawing.Size(846, 20);
			this.stbar.TabIndex = 27;
			// 
			// c1ContextMenu1
			// 
			this.c1ContextMenu1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ContextMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.c1ContextMenu1.Name = "c1ContextMenu1";
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Text = "New Command";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.c1ContextMenu1);
			this.c1CommandHolder1.Owner = this;
			// 
			// axRdviewer401
			// 
			this.axRdviewer401.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axRdviewer401.Enabled = true;
			this.axRdviewer401.Location = new System.Drawing.Point(0, 0);
			this.axRdviewer401.Name = "axRdviewer401";
			this.axRdviewer401.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRdviewer401.OcxState")));
			this.axRdviewer401.Size = new System.Drawing.Size(846, 598);
			this.axRdviewer401.TabIndex = 31;
			this.axRdviewer401.DownloadFinished += new System.EventHandler(this.axRdviewer401_DownloadFinished);
			// 
			// Form_RdViewer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(846, 618);
			this.Controls.Add(this.axRdviewer401);
			this.Controls.Add(this.stbar);
			this.Name = "Form_RdViewer";
			this.Text = "Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_RdViewer_Load);
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axRdviewer401)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_RdViewer_Load(object sender, System.EventArgs e)
		{
			this.axRdviewer401.FileOpen(@mrd_FileName, sParam);
		}



		private void axRdviewer401_DownloadFinished(object sender, System.EventArgs e)
		{
		
		}



	}
}
