using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// MainWin에 대한 요약 설명입니다.
	/// </summary>
	public class MainWnd : System.Windows.Forms.Form
	{
        public System.Windows.Forms.MainMenu mainMenu1;
        private IContainer components; 




		public MainWnd()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.SuspendLayout();
            // 
            // MainWnd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 528);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainWnd";
            this.Text = "Sephiroth";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWnd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWnd_FormClosing);
            this.ResumeLayout(false);

		}
		#endregion

 
		ClassMenu ClsMenu = new ClassMenu();  


		private void MainWnd_Load(object sender, System.EventArgs e)
		{


			ClassLib.ComVar.arg_form = this;
			COM.ComVar.static_form = this;   
			

			
			ERP.Form_Home formHome = new Form_Home();
			formHome.MdiParent = this; 
			formHome.Show();
 


			Reload_Menu();
 


		}


		public void Reload_Menu()
		{
			ClsMenu.Create_Menu(); 

		}



        private void MainWnd_FormClosing(object sender, FormClosingEventArgs e)
        {


            FlexBase.Yield.Form_BC_Yield_withExcel yield_upper_form;
            FlexBase.Yield_New.Form_BC_Yield yield_upper_new_form;
            FlexBase.Yield.Form_BC_FormulaN yield_formula_form;
            FlexPurchase.Shipping.Form_BS_Shipping_Material sm_form;

            bool check_flag = false;
            int mdichildren_count = 0;

            COM.ComVar._CloseFlg = false;


            foreach (Form f in ClassLib.ComVar.arg_form.MdiChildren)
            {

                mdichildren_count++;


                if (f.Name.ToString() == "Form_BC_Yield_withExcel"
                    || f.Name.ToString() == "Form_BC_Yield"
                    || f.Name.ToString() == "Form_BC_FormulaN"
                    || f.Name.ToString() == "Form_BS_Shipping_Material")
                {

                    if (f.Name.ToString() == "Form_BC_Yield_withExcel")
                    {
                        yield_upper_form = (FlexBase.Yield.Form_BC_Yield_withExcel)f;
                        check_flag = yield_upper_form.chk_CheckInOut.Checked;
                    }
                    else if (f.Name.ToString() == "Form_BC_Yield")
                    {
                        yield_upper_new_form = (FlexBase.Yield_New.Form_BC_Yield)f;
                        check_flag = yield_upper_new_form.chk_CheckInOut.Checked;
                    }
                    else if (f.Name.ToString() == "Form_BC_FormulaN")
                    {
                        yield_formula_form = (FlexBase.Yield.Form_BC_FormulaN)f;
                        check_flag = yield_formula_form.chk_CheckInOut.Checked;
                    }
                    else if (f.Name.ToString() == "Form_BS_Shipping_Material")
                    {
                        sm_form = (FlexPurchase.Shipping.Form_BS_Shipping_Material)f;
                        check_flag = sm_form.chk_CheckInOut.Checked;
                    }



                    if (check_flag)
                    {
                        e.Cancel = true;

                        f.Activate();
                        ClassLib.ComFunction.User_Message("Need Check Out.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        COM.ComVar._CloseFlg = false;

                        break;
                    }
                    else
                    {
                        COM.ComVar._CloseFlg = true;
                    }


                }
                else
                {
                    COM.ComVar._CloseFlg = true;
                }



            } // end foreach



            // mdi children 창 아무것도 없을 때, 메뉴만 떠 있는 상태일때
            if (mdichildren_count == 0)
            {
                COM.ComVar._CloseFlg = true;
            }



        }



 

		 
	}
}
