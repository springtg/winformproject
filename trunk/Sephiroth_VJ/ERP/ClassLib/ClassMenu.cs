using System;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using System.ComponentModel;
using System.Web;




namespace ERP
{

    /// <summary>
    /// ClassMenu에 대한 요약 설명입니다.
    /// </summary>
    public class ClassMenu
    {



        // 부모 윈도우
        System.Windows.Forms.Form _Parent_Form;



        string _Factory = ClassLib.ComVar.This_Factory;
        string _LangCd = ClassLib.ComVar.This_Lang;
        string _UserID_AD = ClassLib.ComVar.This_User_AD;



        public ClassMenu()
        {
            //
            // TODO: 여기에 생성자 논리를 추가합니다.
            //
        }




        // 메뉴 type
        private string _TypeMenu = "M";
        private string _TypeSubMenu = "S";
        private string _TypeProgram = "P";



        // default 메뉴 text 
        private string _Menu_Help = "Help";
        private string _Menu_Logout = "Logout";



        private string _FormHomeName = "Form_Home";




        private COM.MyItem[] _Menuitem;


        /// <summary>
        /// Create_Menu : 사용자 메뉴 구성
        /// </summary>
        /// <param name="arg_from">적용 폼</param>
        /// <param name="arg_Menu">적용 메인 메뉴</param>
        /// <param name="arg_job_cd">업무 코드</param>
        public void Create_Menu(System.Windows.Forms.Form arg_from, MainMenu arg_menu, string arg_job_cd)
        {

            arg_menu.MenuItems.Clear();


            _Parent_Form = arg_from;


            _Factory = ClassLib.ComVar.This_Factory;
            _LangCd = ClassLib.ComVar.This_Lang;
            _UserID_AD = ClassLib.ComVar.This_User_AD;



            DataTable dt_ret = SELECT_SCM_MENU_USER_VIEW(_UserID_AD);


            // 권한 없음
            if (dt_ret == null || dt_ret.Rows.Count == 0)
            {
                ClassLib.ComFunction.User_Message("This User ID is not grant permission!");
                arg_from.Close();
            }



            _Menuitem = new COM.MyItem[dt_ret.Rows.Count];
            COM.MyItem parent_Menuitem = null;




            string menu_type = "";
            string menu_key = "";
            string parent_menu_key = "";
            string menu_text = "";
            string menu_pg = "";
            string role_id = "";



            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {


                menu_type = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPC_MENU_ROLE.IxMENU_TYPE].ToString();

                menu_key = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPC_MENU_ROLE.IxMENU_KEY].ToString();
                parent_menu_key = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPC_MENU_ROLE.IxPARENT_MENU_KEY].ToString();
                menu_text = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPC_MENU_ROLE.IxMENU_TEXT].ToString();
                menu_pg = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPC_MENU_ROLE.IxMENU_PG].ToString();
                role_id = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPC_MENU_ROLE.IxROLE_ID].ToString();



                _Menuitem[i] = new COM.MyItem(menu_key, parent_menu_key, menu_text, menu_pg, role_id);



                if (menu_type == _TypeMenu)
                {
                    arg_menu.MenuItems.Add(_Menuitem[i]);
                }
                else
                {

                    for (int j = 0; j < i; j++)
                    {
                        if (_Menuitem[j]._RoleID == role_id && _Menuitem[j]._MenuKey == parent_menu_key)
                        {
                            parent_Menuitem = _Menuitem[j];
                            parent_Menuitem.MenuItems.Add(_Menuitem[i]);

                            if (menu_type == _TypeProgram)
                            {
                                _Menuitem[i].Click += new EventHandler(Menu_Click);
                            }
                            else if (menu_type == _TypeSubMenu)
                            {

                                if (menu_text == _Menu_Help)
                                {
                                    _Menuitem[i].Click += new EventHandler(Help);
                                }
                                else if (menu_text == _Menu_Logout)
                                {
                                    _Menuitem[i].Click += new EventHandler(Log_Out);
                                }


                            }

                            break;
                        } // end if

                    } // end for j

                } // end if (menu_type == _TypeMenu)



            } // end for i



        }





        /// <summary>
        ///  메뉴 클릭시 폼 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Log_Out(object sender, EventArgs e)
        {
            ClassLib.ComVar.arg_form.Close();
        }


        /// <summary>
        ///  메뉴 클릭시 Help 창 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help(object sender, EventArgs e)
        {

            //			string help_path = Application.StartupPath + @"\Sephritoh_Manual\default.htm";  
            //
            //			//string help_path_1 = @"D:\03. 신 자재\2. 프로그램 소스\2. Sephiroth_B\ERP\bin\Debug\Sephiroth_Manual\default.htm";  
            //			
            //			ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");  // explorer.exe
            //			startInfo.WindowStyle = ProcessWindowStyle.Maximized;  
            //			startInfo.Arguments = help_path;  
            //			
            //			Process.Start(startInfo); 

            MessageBox.Show("Help");


        }




        /// <summary>
        /// Create_Menu : 사용자 메뉴 구성
        /// </summary>
        /// <param name="arg_from">적용 폼</param>
        /// <param name="arg_Menu">적용 메인 메뉴</param>
        /// <param name="arg_job_cd">업무 코드</param>
        public void Create_Menu()
        {
            Create_Menu(ClassLib.ComVar.arg_form, ClassLib.ComVar.arg_form.mainMenu1, ClassLib.ComVar.This_Form);
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

            OpenFormByName(sel_menu, menu_pg);


        }





        /// <summary>
        /// 메뉴명으로 메뉴 활성화
        /// </summary>
        /// <param name="arg_FullName"></param>
        public void OpenFormByName(COM.MyItem arg_menu, string arg_menu_pg)
        {

            try
            {

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

                    foreach (Form f in ClassLib.ComVar.arg_form.MdiChildren)
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


                            //Add_Window_Menu(arg_menu, exist_yn);

                        }

                        exist_form = frm;


                    }
                    else
                    {
                        exist_form.Activate();

                    }




                    if (!exist_form.WindowState.Equals(System.Windows.Forms.FormWindowState.Normal))
                    {
                        Add_Window_Menu(arg_menu, exist_yn);
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
        private void Add_Window_Menu(COM.MyItem arg_menu, bool arg_existyn)
        {


            string menu_key = "";
            string parent_menu_key = "-1";
            string window_text = "WINDOW";

            COM.MyItem parent_Menuitem = null;


            foreach (COM.MyItem item in ClassLib.ComVar.arg_form.Menu.MenuItems)
            {
                //if(item._RoleID == role_id)
                //{
                //    parent_Menuitem = item;

                //    break;

                //}

                if (item._MenuText.ToUpper().Trim() == window_text.ToUpper().Trim())
                {
                    parent_Menuitem = item;

                    break;

                }



            } // end foreach





            if (!arg_existyn)   // 신규
            {

                COM.MyItem menuitem = new COM.MyItem(menu_key, parent_menu_key, arg_menu._MenuText, arg_menu._MenuPG, "");



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
        /// SELECT_SCM_MENU_USER_VIEW : 
        /// </summary>
        /// <param name="_Factory"></param>
        /// <param name="_LangCd"></param>
        /// <param name="_UserID_AD_ad"></param>
        /// <returns></returns>
        private static DataTable SELECT_SCM_MENU_USER_VIEW(string _UserID_AD_ad)
        {
            COM.OraDB oraDB = new COM.OraDB();


            string Proc_Name = "PKG_SCM_MENU.SELECT_SCM_MENU_USER_VIEW";


            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;


            oraDB.Parameter_Name[0] = "ARG_USER_ID";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = _UserID_AD_ad;
            oraDB.Parameter_Values[1] = "";


            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }






    }



}
