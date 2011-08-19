using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ERP.Menu
{
    public partial class Form_PC_Menu_Role : COM.APSWinForm.Form_Top
    {

        #region 생성자


        public Form_PC_Menu_Role()
        {
            InitializeComponent();

            //Init_Form();
        }

        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        // 메뉴 type
        //private string _TypeRoot = "R";
        private string _TypeMenu = "M";
        private string _TypeSubmenu = "S";
        private string _TypeSeparator = "B";
        private string _TypeProgram = "P";

        //private string _RootMenuKey = "-1";





        #endregion

        #region 멤버 메서드


        #region 초기화




        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {


                ////Title
                //this.Text = "권한 메뉴";
                //lbl_MainTitle.Text = "권한 메뉴";


                Init_Grid();

                Init_Control();





            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// 
        /// </summary>
        private void Init_Grid()
        {


            fgrid_Main.Set_Grid("SCM_MENU_MAIN_ROLE_MAIN", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.Set_Action_Image(img_Action); // 옮길 메뉴 Y 표시하기 위한 방법



            fgrid_Role.Set_Grid("SCM_MENU_MAIN_ROLE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Role.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Role.ExtendLastCol = false;
            fgrid_Role.AllowSorting = AllowSortingEnum.None;
            fgrid_Role.AllowDragging = AllowDraggingEnum.None;
            fgrid_Role.Set_Action_Image(img_Action);



        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {



            // Disabled tbutton
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Color.Enabled = false;



            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();



            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;



        }




        #endregion

        #region 조회


        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_dt"></param>
        private void Display_Grid(COM.FSP arg_fgrid, DataTable arg_dt)
        {


            arg_fgrid.ClearAll();



            arg_fgrid.Tree.Column = (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_TEXT;
            arg_fgrid.Tree.Style = TreeStyleFlags.Complete;
            arg_fgrid.Tree.Show(-1);




            int level = 0;

            // data 표시
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_MENU_ROLE.IxMENU_LEVEL - 1].ToString());

                arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, level);

                arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "";

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[i + arg_fgrid.Rows.Fixed, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

            } // end for i





        }




        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {


            fgrid_Main.ClearAll();
            fgrid_Role.ClearAll();


        }




        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search(string arg_division)
        {


            //if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1 || cmb_RoleID.SelectedIndex == -1) return;

            //string factory = cmb_Factory.SelectedValue.ToString();
            //string lang_cd = cmb_LangCd.SelectedValue.ToString();
            //string role_id = cmb_RoleID.SelectedValue.ToString();


            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string lang_cd = ClassLib.ComFunction.Empty_Combo(cmb_LangCd, " ");
            string role_id = ClassLib.ComFunction.Empty_Combo(cmb_RoleID, " ");


            DataSet ds_ret = SELECT_SCM_MENU(factory, lang_cd, role_id);
            DataTable dt_menu = ds_ret.Tables[0];
            DataTable dt_role = ds_ret.Tables[1];



            if (arg_division == "Menu")
            {
                Display_Grid(fgrid_Main, dt_menu);
            }
            else if (arg_division == "Role")
            {
                Display_Grid(fgrid_Role, dt_role);
            }
            else
            {
                Display_Grid(fgrid_Main, dt_menu);
                Display_Grid(fgrid_Role, dt_role);
            }



            dt_menu.Dispose();
            dt_role.Dispose();
            ds_ret.Dispose();




        }




        /// <summary>
        /// Event_Tbtn_Save : 
        /// </summary>
        private void Event_Tbtn_Save()
        {


            bool save_flag = MyOraDB.Save_FlexGird("PKG_SCM_MENU.SAVE_SCM_MENU_ROLE", fgrid_Role);



            if (!save_flag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
            }
            else
            {
                Event_Tbtn_Search("");
            }





        }





        #endregion

        #region 그리드 이벤트 메서드


        /// <summary>
        /// Event_fgrid_Main_DoubleClick : 
        /// </summary>
        private void Event_fgrid_Main_DoubleClick()
        {


            //----------------------------------------------
            // 조회시 필수조건 체크 
            //----------------------------------------------
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_LangCd, cmb_RoleID };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = FlexAPS.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;
            //----------------------------------------------



            int start_row = -1;
            int end_row = -1;
            int find_row = -1;
            int insert_row = -1;

            int menu_ord = 0;
            int now_ord = 0;
            int menu_level = 0;
            int now_level = 0;
            string menu_type = "";
            string now_menu_type = "";


            menu_level = Convert.ToInt32(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_LEVEL].ToString());
            menu_type = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_TYPE].ToString();


            if (menu_type == _TypeMenu)
            {


                //----------------------------------------------
                // start
                //----------------------------------------------
                start_row = fgrid_Main.Row;
                //----------------------------------------------


                //----------------------------------------------
                // end
                //----------------------------------------------
                find_row = fgrid_Main.FindRow(menu_type, start_row + 1, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_TYPE, false, true, false);

                if (find_row == -1)
                {
                    end_row = fgrid_Main.Rows.Count - 1;
                }
                else
                {
                    end_row = find_row - 1;
                }


                for (int i = start_row; i <= end_row; i++)
                {
                    fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "Y";
                }
                //---------------------------------------------- 


                //----------------------------------------------
                // insert 
                //----------------------------------------------
                menu_ord = Convert.ToInt32(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD].ToString());


                for (int i = fgrid_Role.Rows.Fixed; i < fgrid_Role.Rows.Count; i++)
                {
                    now_ord = Convert.ToInt32(fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD].ToString());

                    if (menu_ord <= now_ord)
                    {
                        insert_row = i;
                        break;
                    }

                } // end for i



                if (insert_row == -1)
                {
                    insert_row = fgrid_Role.Rows.Count;
                }
                //----------------------------------------------



            } // end if (menu_type == _TypeMenu)
            else
            {


                //----------------------------------------------
                // start
                //----------------------------------------------
                fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "Y";


                for (int i = fgrid_Main.Row - 1; i >= fgrid_Main.Rows.Fixed; i--)
                {

                    now_menu_type = fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_TYPE].ToString();


                    if (now_menu_type == _TypeMenu || now_menu_type == _TypeSubmenu)
                    {


                        now_level = Convert.ToInt32(fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_LEVEL].ToString());

                        if (menu_level <= now_level)
                        {
                            continue;
                        }

                        fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "Y";

                        if (now_menu_type == _TypeMenu)
                        {
                            start_row = i;
                            break;
                        }

                    }


                } // end for i 
                //----------------------------------------------


                //----------------------------------------------
                // end
                //----------------------------------------------
                if (menu_type == _TypeSubmenu)
                {


                    for (int i = fgrid_Main.Row + 1; i < fgrid_Main.Rows.Count; i++)
                    {

                        now_menu_type = fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_TYPE].ToString();

                        now_level = Convert.ToInt32(fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_LEVEL].ToString());

                        if (menu_level >= now_level)
                        {
                            continue;
                        }




                        if (now_menu_type == _TypeMenu)
                        {
                            end_row = i - 1;
                            break;
                        }
                        else
                        {
                            fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "Y";
                        }



                    } // end for i


                    if (end_row == -1)
                    {
                        end_row = fgrid_Main.Rows.Count - 1;
                    }

                }
                else if (menu_type == _TypeProgram || menu_type == _TypeSeparator)
                {

                    fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "Y";

                    end_row = fgrid_Main.Row;

                }
                //----------------------------------------------


                //----------------------------------------------
                // insert 
                //----------------------------------------------
                // _TypeMenu row
                menu_ord = Convert.ToInt32(fgrid_Main[start_row, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD].ToString());


                for (int i = fgrid_Role.Rows.Fixed; i < fgrid_Role.Rows.Count; i++)
                {
                    now_ord = Convert.ToInt32(fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD].ToString());

                    if (menu_ord <= now_ord)
                    {
                        insert_row = i;
                        break;
                    }

                } // end for i



                if (insert_row == -1)
                {
                    insert_row = fgrid_Role.Rows.Count;
                }
                //----------------------------------------------



            } // end if


            //----------------------------------------------
            // move
            //----------------------------------------------
            Move_Menu(start_row, end_row, insert_row);
            //----------------------------------------------



        }



        /// <summary>
        /// Move_Menu : 
        /// </summary>
        /// <param name="arg_start_row"></param>
        /// <param name="arg_end_row"></param>
        /// <param name="arg_insert_row"></param>
        private void Move_Menu(int arg_start_row, int arg_end_row, int arg_insert_row)
        {


            int level = 0;
            int menu_ord = 0;
            int now_ord = 0;
            int insert_row = -1;

            for (int i = arg_start_row; i <= arg_end_row; i++)
            {


                insert_row = -1;


                if (fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION].ToString() != "Y")
                {
                    continue;
                }


                // 다음 액션을 위해서 옮길 메뉴 상태 초기화
                fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "";


                //----------------------------------------------
                // 중복 체크
                //----------------------------------------------
                string menu_key = fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_KEY].ToString();
                bool exist_menu = Exist_Menu(menu_key);
                if (exist_menu) continue;
                //----------------------------------------------


                //----------------------------------------------
                // insert row
                //----------------------------------------------
                menu_ord = Convert.ToInt32(fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD].ToString());


                for (int j = arg_insert_row; j < fgrid_Role.Rows.Count; j++)
                {
                    now_ord = Convert.ToInt32(fgrid_Role[j, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD].ToString());

                    if (menu_ord < now_ord)
                    {
                        insert_row = j;
                        break;
                    }

                } // end for j

                if (insert_row == -1)
                {
                    insert_row = fgrid_Role.Rows.Count;
                }



                //if (fgrid_Role.Rows.Count <= fgrid_Role.Rows.Fixed)
                //{
                //    insert_row = fgrid_Role.Rows.Count;
                //}
                //else
                //{




                //} // end if
                //----------------------------------------------


                //----------------------------------------------
                // data
                //----------------------------------------------
                level = Convert.ToInt32(fgrid_Main[i, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_LEVEL].ToString());

                fgrid_Role.Rows.InsertNode(insert_row, level);

                fgrid_Role[insert_row, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "I";


                for (int j = (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_LEVEL; j < (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_ORD_BEFORE; j++)
                {

                    if (fgrid_Main[i, j] == null)
                    {
                        fgrid_Role[insert_row, j] = "";
                    }
                    else
                    {
                        fgrid_Role[insert_row, j] = fgrid_Main[i, j].ToString();
                    }


                } // end for j


                fgrid_Role[insert_row, (int)ClassLib.TBSCM_MENU_ROLE.IxROLE_ID] = cmb_RoleID.SelectedValue.ToString();
                fgrid_Role[insert_row, (int)ClassLib.TBSCM_MENU_ROLE.IxROLE_NAME] = cmb_RoleID.Columns[1].Text;
                //----------------------------------------------



            } // end for i


        }



        /// <summary>
        /// Exist_Menu : false - 중복아님, true - 중복
        /// </summary>
        /// <param name="arg_menu_key"></param>
        /// <returns></returns>
        private bool Exist_Menu(string arg_menu_key)
        {

            int find_row = fgrid_Role.FindRow(arg_menu_key, fgrid_Role.Rows.Fixed, (int)ClassLib.TBSCM_MENU_ROLE.IxMENU_KEY, false, true, false);

            if (find_row == -1) // 중복 아님
            {
                return false;
            }
            else // 중복
            {
                return true;
            }


        }



        /// <summary>
        /// Event_fgrid_Role_DoubleClick : 
        /// </summary>
        private void Event_fgrid_Role_DoubleClick()
        {


            //하위 레벨 그룹 모두 처리

            int current_row = fgrid_Role.Row;
            int child_row1 = fgrid_Role.Row;



            while (true)
            {
                C1.Win.C1FlexGrid.Node node = null;

                node = fgrid_Role.Rows[current_row].Node;


                if (node.Children == 0) break;

                current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

            } // end while

            int child_row2 = current_row;


            for (int i = child_row2; i >= child_row1; i--)
            {

                if (fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION].ToString() == "I")
                {
                    fgrid_Role.Rows.Remove(i);
                }
                else if (fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION].ToString() == "D")
                {
                    fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "";
                }
                else
                {
                    fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "D";
                }

            }



        }


        /// <summary>
        /// Event_fgrid_Role_BeforeEdit : 
        /// </summary>
        private void Event_fgrid_Role_BeforeEdit()
        {

            if ((fgrid_Role.Rows.Fixed > 0) && (fgrid_Role.Row >= fgrid_Role.Rows.Fixed))
            {
                if (fgrid_Role.Cols[fgrid_Role.Col].DataType == typeof(bool))
                {
                    fgrid_Role.Buffer_CellData = "";
                }
                else
                {
                    fgrid_Role.Buffer_CellData = (fgrid_Role[fgrid_Role.Row, fgrid_Role.Col] == null) ? "" : fgrid_Role[fgrid_Role.Row, fgrid_Role.Col].ToString();
                }
            }



        }


        /// <summary>
        /// Event_fgrid_Role_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Role_AfterEdit()
        {

            fgrid_Role.Update_Row();

            // 상위 버튼 권한 수정시, 하위 버튼 권한 일괄 수정
            Update_ButtonRole();


        }


        /// <summary>
        /// Update_ButtonRole : 상위 버튼 권한 수정시, 하위 버튼 권한 일괄 수정
        /// </summary>
        private void Update_ButtonRole()
        {

            int sel_row = fgrid_Role.Row;
            int sel_col = fgrid_Role.Col;


            if (sel_col < (int)ClassLib.TBSCM_MENU_ROLE.IxUSE_YN || sel_col > (int)ClassLib.TBSCM_MENU_ROLE.IxREMARKS) return;

            string new_yn = fgrid_Role[sel_row, sel_col].ToString();

            //하위 레벨 그룹 모두 처리 

            int current_row = sel_row;
            int child_row1 = sel_row;



            while (true)
            {
                C1.Win.C1FlexGrid.Node node = null;

                node = fgrid_Role.Rows[current_row].Node;


                if (node.Children == 0) break;

                current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

            } // end while

            int child_row2 = current_row;


            for (int i = child_row2; i >= child_row1; i--)
            {
                fgrid_Role[i, sel_col] = new_yn;

                if (fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION].ToString() != "I")
                {
                    fgrid_Role[i, (int)ClassLib.TBSCM_MENU_ROLE.IxDIVISION] = "U";
                }

            }




        }





        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            Event_Tbtn_New();


            if (cmb_Factory.SelectedIndex == -1) return;



            // Language 코드
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLangCode); // "DA02"
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LangCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_LangCd.SelectedValue = ClassLib.ComVar.This_Lang;





        }


        /// <summary>
        /// Event_LangCd_SelectedValueChanged : 
        /// </summary>
        private void Event_LangCd_SelectedValueChanged()
        {


            Event_Tbtn_New();


            if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_LangCd.SelectedValue.ToString();


            DataTable dt_ret = SELECT_SCM_MENU_ROLE_ID(factory, lang_cd);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoleID, 2, 3, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_RoleID.SelectedIndex = -1;



            dt_ret.Dispose();


            Event_Tbtn_Search("Menu");



        }




        /// <summary>
        /// Event_cmb_RoleID_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_RoleID_SelectedValueChanged()
        {



            if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1 || cmb_RoleID.SelectedIndex == -1) return;



            Event_Tbtn_Search("Role");




        }


        /// <summary>
        /// Event_btn_CreateRoleID_Click : 
        /// </summary>
        private void Event_btn_CreateRoleID_Click()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_LangCd.SelectedValue.ToString();


            ERP.Menu.Pop_PC_Menu_Role pop_form = new ERP.Menu.Pop_PC_Menu_Role(factory, lang_cd);
            pop_form.ShowDialog();


            DataTable dt_ret = SELECT_SCM_MENU_ROLE_ID(factory, lang_cd);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoleID, 2, 3, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_RoleID.SelectedIndex = -1;


            fgrid_Role.ClearAll();




        }



        /// <summary>
        /// Event_btn_Copy_Click : 
        /// </summary>
        private void Event_btn_Copy_Click()
        {


            ERP.Menu.Pop_PC_Menu_Copy pop_form = new ERP.Menu.Pop_PC_Menu_Copy();
            pop_form.ShowDialog();


        }



        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드




        #endregion



        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트


        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
                Event_Tbtn_Search("");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }




        #endregion

        #region 그리드 이벤트



        private void fgrid_Main_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Main_DoubleClick();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void fgrid_Role_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Role_DoubleClick();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Role_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_Role_BeforeEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Role_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Role_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        private void fgrid_Role_AfterEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Role_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Role_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }





        #endregion

        #region 버튼 및 기타 이벤트


        #region 버튼클릭시 이미지변경


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }




        #endregion


        private void Form_EIS_Menu_Role_Load(object sender, EventArgs e)
        {
            Init_Form();
        }


        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Factory_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void cmb_LangCd_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_LangCd_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_LangCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_RoleID_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_RoleID_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_RoleID_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btn_CreateRoleID_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_CreateRoleID_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_CreateRoleID_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Copy_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Copy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #region 컨텍스트 메뉴 이벤트





        #endregion

        #endregion

        #region 디비 연결


        #region 콤보


        /// <summary>
        /// SELECT_SCM_DATA_DIC_PROJ : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SCM_DATA_DIC_PROJ(string arg_factory, string arg_lang_cd)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_DATA_DIC_PROJ";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = "";




                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }


        }



        /// <summary>
        /// SELECT_SCM_MENU_ROLE_ID : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <returns></returns>
        public static DataTable SELECT_SCM_MENU_ROLE_ID(string arg_factory, string arg_lang_cd)
        {

            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();



                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_MENU_ROLE_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = "";




                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }


        }




        #endregion

        #region 조회






        /// <summary>
        /// SELECT_SCM_MENU : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <param name="arg_role_id"></param>
        /// <returns></returns>
        private DataSet SELECT_SCM_MENU(string arg_factory, string arg_lang_cd, string arg_role_id)
        {

            try
            {


                #region ecb_menu



                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_MENU";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = "";



                MyOraDB.Add_Select_Parameter(true);



                #endregion

                #region ecb_menu_role


                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_MENU_ROLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "ARG_ROLE_ID";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = arg_role_id;
                MyOraDB.Parameter_Values[3] = "";



                MyOraDB.Add_Select_Parameter(false);


                #endregion




                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;


            }
            catch
            {
                return null;
            }


        }










        #endregion

        #endregion



    }
}