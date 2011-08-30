using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace FlexOrder.Report
{
	/// <summary>
	/// Form_RdViewer에 대한 요약 설명입니다.
	/// </summary>
	public class Form_RD_PKG_Base : System.Windows.Forms.Form
	{

		#region 컨트롤 속성정의

		private System.ComponentModel.Container components = null;
		//private System.Windows.Forms.Panel panel1; 
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		public System.Windows.Forms.StatusBar stbar;

		//private string  txt_Filename =" ";
		private string  mrd_FileName =" ";
		private AxRDVIEWER40Lib.AxRdviewer40 axRdviewer401;
		private string  sParam =" ";		

		#endregion
		
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>

		public Form_RD_PKG_Base(string arg_MrdFileName, string arg_param)
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			mrd_FileName = arg_MrdFileName;
			sParam       = arg_param;

			InitializeComponent();

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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_RD_PKG_Base));
			this.stbar = new System.Windows.Forms.StatusBar();
			this.info_bar = new System.Windows.Forms.StatusBarPanel();
			this.formname_bar = new System.Windows.Forms.StatusBarPanel();
			this.axRdviewer401 = new AxRDVIEWER40Lib.AxRdviewer40();
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axRdviewer401)).BeginInit();
			this.SuspendLayout();
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 644);
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.info_bar,
																					 this.formname_bar});
			this.stbar.ShowPanels = true;
			this.stbar.Size = new System.Drawing.Size(1016, 22);
			this.stbar.TabIndex = 27;
			// 
			// axRdviewer401
			// 
			this.axRdviewer401.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axRdviewer401.Enabled = true;
			this.axRdviewer401.Location = new System.Drawing.Point(0, 0);
			this.axRdviewer401.Name = "axRdviewer401";
			this.axRdviewer401.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRdviewer401.OcxState")));
			this.axRdviewer401.Size = new System.Drawing.Size(1016, 644);
			this.axRdviewer401.TabIndex = 28;
			// 
			// Form_RD_PKG_Base
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.axRdviewer401);
			this.Controls.Add(this.stbar);
			this.Name = "Form_RD_PKG_Base";
			this.Text = "Form_RD_PKG_Base";
			this.Load += new System.EventHandler(this.Form_RD_PKG_Base_Load);
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axRdviewer401)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_RD_PKG_Base_Load(object sender, System.EventArgs e)
		{
			this.axRdviewer401.FileOpen(@mrd_FileName, sParam); 
	
		}

	}
}
