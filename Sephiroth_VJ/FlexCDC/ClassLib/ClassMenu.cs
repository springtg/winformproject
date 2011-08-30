using System;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using System.ComponentModel;
using System.Web;


namespace FlexCDC
{
    class ClassMenu
    {
        
        System.Windows.Forms.Form _Parent_Form;
        private COM.MyItem[] _Menuitem;
        private string _FormHomeName = "Form_Home";


		
 


		public ClassMenu()
		{ 
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

        /// <summary>
        /// 메뉴명으로 메뉴 활성화
        /// </summary>
        /// <param name="arg_FullName"></param>
        public void OpenFormByName(System.Windows.Forms.Form arg_form, COM.MyItem arg_menu, string arg_menu_pg, string arg_menu_text)
        {

            try
            {

                _Parent_Form = arg_form;
                // 팝업창 열때 mdi 로 열기 위함
                COM.ComVar.MDI_Parent = _Parent_Form;


                // 네임스페이스.폼명으로 폼 객체 생성
                string[] token = arg_menu_pg.Split('.');
                string project = token[0];

                Assembly asm = Assembly.Load(project);

                Type t = asm.GetType(arg_menu_pg);

                bool exist_yn = false;
                Form exist_form = null;


                if (t != null)
                {


                    // 중복 체크

                    foreach (Form f in _Parent_Form.MdiChildren)
                    {
                        // 중복
                        if (f.GetType().Equals(t))
                        {
                            exist_yn = true;
                            exist_form = f;

                            break;
                        }

                    } // end foreach  


                    if (!exist_yn)
                    {

                        //						Form frm = (Form) Activator.CreateInstance(t);
                        //						frm.MdiParent = _Parent_Form;   
                        //
                        //						frm.Show();  



                        Form frm = (Form)Activator.CreateInstance(t);


                        if (frm.WindowState.Equals(System.Windows.Forms.FormWindowState.Normal))
                        {

                            if (frm.Name == _FormHomeName)
                            {
                                frm.MdiParent = _Parent_Form;
                            }


                            frm.Show();


                        }
                        else
                        {
                            frm.MdiParent = _Parent_Form;
                            frm.Show();


                        }

                        exist_form = frm;


                    }
                    else
                    {
                        if (!exist_form.WindowState.Equals(FormWindowState.Maximized))
                        {
                            exist_form.WindowState = FormWindowState.Maximized;
                        }


                        exist_form.Activate();

                    }




                    if (!exist_form.WindowState.Equals(System.Windows.Forms.FormWindowState.Normal))
                    {
                        Add_Window_Menu(arg_form, arg_menu, exist_yn, arg_menu_pg, arg_menu_text);
                    }



                }
                else
                {
                    ClassLib.ComFunction.User_Message(arg_menu_pg + " is not found!!");
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "OpenFormByName", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        /// <summary>
        /// Add_Window_Menu : 
        /// </summary>
        /// <param name="arg_menu"></param>
        /// <param name="arg_existyn"></param>
        private void Add_Window_Menu(System.Windows.Forms.Form arg_form, COM.MyItem arg_menu, bool arg_existyn, string arg_menu_pg, string arg_menu_text)
        {


            string menu_key = "";
            string parent_menu_key = "-1";
            string role_id = "SYSTEM";

            COM.MyItem parent_Menuitem = null;


            foreach (COM.MyItem item in arg_form.Menu.MenuItems)
            {
                if (item._RoleID == role_id)
                {
                    parent_Menuitem = item;

                    break;

                }

            } // end foreach





            if (!arg_existyn)   // 신규
            {

                COM.MyItem menuitem = new COM.MyItem(menu_key, parent_menu_key, arg_menu_text, arg_menu_pg, role_id);


                
                parent_Menuitem.MenuItems.Add(menuitem);

                menuitem.Click += new EventHandler(Menu_Click);

                foreach (COM.MyItem child_item in parent_Menuitem.MenuItems)
                {
                    child_item.Checked = false;
                }

                menuitem.Checked = true;




            }
            else
            {


                foreach (COM.MyItem child_item in parent_Menuitem.MenuItems)
                {
                    if (child_item._MenuPG == arg_menu._MenuPG)
                    {
                        child_item.Checked = true;
                    }
                    else
                    {
                        child_item.Checked = false;
                    }

                }




            } // end if (!arg_existyn)








        }
        /// <summary>
        ///  해당 메뉴를 클릭시 폼 활성화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Click(object sender, EventArgs e)
        {

            COM.MyItem sel_menu = (COM.MyItem)sender;

            string menu_pg = sel_menu._MenuPG;
            string menu_text = sel_menu._MenuText;

            OpenFormByName(_Parent_Form, sel_menu, menu_pg, menu_text);


        }
    }
}
