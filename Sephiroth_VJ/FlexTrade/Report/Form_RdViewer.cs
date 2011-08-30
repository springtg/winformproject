using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexTrade.Report
{
	/// <summary>
	/// Form_RdViewer에 대한 요약 설명입니다.
	/// </summary>
	public class Form_RdViewer : System.Windows.Forms.Form
	{

		#region 컨트롤 속성정의

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
		private AxRDVIEWER40Lib.AxRdviewer40 axRdviewer402; 
		private string  sParam =" ";		

		#endregion
		
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>

		public Form_RdViewer(string arg_MrdFileName, string arg_param)
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			mrd_FileName = arg_MrdFileName;
			sParam       = arg_param;

			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_RdViewer));
			this.stbar = new System.Windows.Forms.StatusBar();
			this.info_bar = new System.Windows.Forms.StatusBarPanel();
			this.formname_bar = new System.Windows.Forms.StatusBarPanel();
			this.c1ContextMenu1 = new C1.Win.C1Command.C1ContextMenu();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.axRdviewer402 = new AxRDVIEWER40Lib.AxRdviewer40();
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axRdviewer402)).BeginInit();
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
			// c1ContextMenu1
			// 
			this.c1ContextMenu1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ContextMenu1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
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
			// axRdviewer402
			// 
			this.axRdviewer402.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axRdviewer402.Enabled = true;
			this.axRdviewer402.Location = new System.Drawing.Point(0, 0);
			this.axRdviewer402.Name = "axRdviewer402";
			this.axRdviewer402.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRdviewer402.OcxState")));
			this.axRdviewer402.Size = new System.Drawing.Size(1016, 644);
			this.axRdviewer402.TabIndex = 29;
			// 
			// Form_RdViewer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.axRdviewer402);
			this.Controls.Add(this.stbar);
			this.Name = "Form_RdViewer";
			this.Text = "Report";
			this.Load += new System.EventHandler(this.Form_RdViewer_Load);
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axRdviewer402)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_RdViewer_Load(object sender, System.EventArgs e)
		{
			this.axRdviewer402.FileOpen(@mrd_FileName, sParam); 		
		}

		private void axRdviewer402_DownloadFinished(object sender, System.EventArgs e)
		{
		
		}



	}
}
