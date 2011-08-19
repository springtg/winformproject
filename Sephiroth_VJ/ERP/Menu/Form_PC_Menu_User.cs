using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;
using System.DirectoryServices; 

namespace ERP.Menu
{
    public partial class Form_PC_Menu_User : COM.APSWinForm.Form_Top
    {

        #region 생성자


        public Form_PC_Menu_User()
        {
            InitializeComponent();

            //Init_Form();
        }

        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


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
                //this.Text = "사용자/ 메뉴 권한 정보";
                //lbl_MainTitle.Text = "사용자/ 메뉴 권한 정보";


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


            //--------------------------------------------------------------------------------------------------------------
            // USER
            //--------------------------------------------------------------------------------------------------------------
            fgrid_User.Set_Grid("SCM_MENU_MAIN_USER_USER", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_User.ExtendLastCol = false;
            fgrid_User.AllowDragging = AllowDraggingEnum.None;
            fgrid_User.Set_Action_Image(img_Action);
            //--------------------------------------------------------------------------------------------------------------



            //--------------------------------------------------------------------------------------------------------------
            // MENU
            //--------------------------------------------------------------------------------------------------------------
            fgrid_Menu.Set_Grid("SCM_MENU_MAIN_USER", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Menu.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Menu.ExtendLastCol = false;
            fgrid_Menu.AllowSorting = AllowSortingEnum.None;
            fgrid_Menu.AllowDragging = AllowDraggingEnum.None;
            fgrid_Menu.Set_Action_Image(img_Action);


            fgrid_Menu.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Menu.Cols.Count - 1; i++)
            {
                fgrid_Menu.Cols[i].AllowMerging = false;
            }



            fgrid_Menu.Cols[(int)ClassLib.TBSCM_MENU_USER.IxFACTORY].AllowMerging = true;
            fgrid_Menu.Cols[(int)ClassLib.TBSCM_MENU_USER.IxUSER_ID].AllowMerging = true;
            fgrid_Menu.Cols[(int)ClassLib.TBSCM_MENU_USER.IxLANG_CD].AllowMerging = true;
            //--------------------------------------------------------------------------------------------------------------




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



            // EIS user role
            DataTable dt_ret = ERP.Menu.Form_PC_Menu_Role.SELECT_SCM_MENU_ROLE_ID(COM.ComVar.This_Factory, COM.ComVar.This_Lang);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Role, 2, 3, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Role.SelectedIndex = -1;


            //-------------------------------------------------
            // 그리드 컬럼 적용
            //-------------------------------------------------
            System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary();

            ld.Add("", "");

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                ld.Add(dt_ret.Rows[i].ItemArray[2].ToString(), dt_ret.Rows[i].ItemArray[3].ToString());
            }

            fgrid_User.Cols[(int)ClassLib.TBSCM_MENU_USER_MASTER.IxROLE_ID].DataMap = ld;
            //-------------------------------------------------




            dt_ret.Dispose();




        }






        #endregion

        #region 조회






        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {


            txt_User.Text = "";
            cmb_Role.SelectedIndex = -1;


            fgrid_User.ClearAll();
            fgrid_Menu.ClearAll();


        }




        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {


            string user_id = ClassLib.ComFunction.Empty_TextBox(txt_User, " ");
            string role = ClassLib.ComFunction.Empty_Combo(cmb_Role, " ");


            DataTable dt_ret = SELECT_SCM_USER(user_id, role);


            fgrid_User.Display_Grid(dt_ret, false);

            dt_ret.Dispose();


            if (fgrid_User.Rows.Count > fgrid_User.Rows.Fixed)
            {

                fgrid_User.Select(fgrid_User.Rows.Fixed, 0, fgrid_User.Rows.Fixed, fgrid_User.Cols.Count - 1, false);
                Event_fgrid_User_Click();

            }





        }



        /// <summary>
        /// Event_Tbtn_Save : 
        /// </summary>
        private void Event_Tbtn_Save()
        {



            fgrid_User.Select(fgrid_User.Selection.r1, 0, fgrid_User.Selection.r1, fgrid_User.Cols.Count - 1, false);


            bool save_flag = MyOraDB.Save_FlexGird("PKG_SCM_MENU.SAVE_SCM_USER", fgrid_User);

            if (!save_flag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);

                return;
            }
            else
            {


                save_flag = MyOraDB.Save_FlexGird("PKG_SCM_MENU.SAVE_SCM_MENU_USER", fgrid_Menu);


                if (!save_flag)
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);

                    return;
                }
                else
                {


                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);


                    int sel_row = fgrid_User.Selection.r1;



                    Event_Tbtn_Search();


                    if (sel_row < fgrid_User.Rows.Count)
                    {
                        fgrid_User.Select(sel_row, 0, sel_row, fgrid_User.Cols.Count - 1, false);
                        Event_fgrid_User_Click();
                    }






                } // end if SAVE_ECM_MENU_USER 



            } // end if SAVE_ECM_USER





        }





        #endregion

        #region 그리드 이벤트 메서드



        /// <summary>
        /// Event_fgrid_User_BeforeEdit : 
        /// </summary>
        private void Event_fgrid_User_BeforeEdit()
        {

            if ((fgrid_User.Rows.Fixed > 0) && (fgrid_User.Row >= fgrid_User.Rows.Fixed))
            {
                if (fgrid_User.Cols[fgrid_User.Col].DataType == typeof(bool))
                {
                    fgrid_User.Buffer_CellData = "";
                }
                else
                {
                    fgrid_User.Buffer_CellData = (fgrid_User[fgrid_User.Row, fgrid_User.Col] == null) ? "" : fgrid_User[fgrid_User.Row, fgrid_User.Col].ToString();
                }
            }


        }



        /// <summary>
        /// Event_fgrid_User_AfterEdit : 
        /// </summary>
        private void Event_fgrid_User_AfterEdit()
        {

            fgrid_User.Update_Row();

        }





        /// <summary>
        /// Event_fgrid_Menu_BeforeEdit : 
        /// </summary>
        private void Event_fgrid_Menu_BeforeEdit()
        {

            if ((fgrid_Menu.Rows.Fixed > 0) && (fgrid_Menu.Row >= fgrid_Menu.Rows.Fixed))
            {
                if (fgrid_Menu.Cols[fgrid_Menu.Col].DataType == typeof(bool))
                {
                    fgrid_Menu.Buffer_CellData = "";
                }
                else
                {
                    fgrid_Menu.Buffer_CellData = (fgrid_Menu[fgrid_Menu.Row, fgrid_Menu.Col] == null) ? "" : fgrid_Menu[fgrid_Menu.Row, fgrid_Menu.Col].ToString();
                }
            }


        }



        /// <summary>
        /// Event_fgrid_Menu_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Menu_AfterEdit()
        {

            fgrid_Menu.Update_Row();

            // 상위 버튼 권한 수정시, 하위 버튼 권한 일괄 수정
            Update_ButtonRole();


        }



        /// <summary>
        /// Update_ButtonRole : 상위 버튼 권한 수정시, 하위 버튼 권한 일괄 수정
        /// </summary>
        private void Update_ButtonRole()
        {

            int sel_row = fgrid_Menu.Row;
            int sel_col = fgrid_Menu.Col;


            if (sel_col < (int)ClassLib.TBSCM_MENU_USER.IxUSE_YN || sel_col > (int)ClassLib.TBSCM_MENU_USER.IxREMARKS) return;

            string new_yn = fgrid_Menu[sel_row, sel_col].ToString();

            //하위 레벨 그룹 모두 처리 

            int current_row = sel_row;
            int child_row1 = sel_row;



            while (true)
            {
                C1.Win.C1FlexGrid.Node node = null;

                node = fgrid_Menu.Rows[current_row].Node;


                if (node.Children == 0) break;

                current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

            } // end while

            int child_row2 = current_row;


            for (int i = child_row2; i >= child_row1; i--)
            {
                fgrid_Menu[i, sel_col] = new_yn;

                if (fgrid_Menu[i, (int)ClassLib.TBSCM_MENU_USER.IxDIVISION].ToString() != "I")
                {
                    fgrid_Menu[i, (int)ClassLib.TBSCM_MENU_USER.IxDIVISION] = "U";
                }

            }




        }





        /// <summary>
        /// Event_fgrid_User_Click : 
        /// </summary>
        private void Event_fgrid_User_Click()
        {



            fgrid_Menu.ClearAll();


            if (fgrid_User.Rows.Count < fgrid_User.Rows.Fixed) return;


            string factory = "";
            string user_id = "";
            string lang_cd = "";


            if (fgrid_User[fgrid_User.Row, (int)ClassLib.TBSPS_USER.IxFACTORY] == null)
            {
                factory = "";
            }
            else
            {
                factory = fgrid_User[fgrid_User.Row, (int)ClassLib.TBSPS_USER.IxFACTORY].ToString();
            }


            if (fgrid_User[fgrid_User.Row, (int)ClassLib.TBSPS_USER.IxUSER_ID] == null)
            {
                user_id = "";
            }
            else
            {
                user_id = fgrid_User[fgrid_User.Row, (int)ClassLib.TBSPS_USER.IxUSER_ID].ToString();
            }


            if (fgrid_User[fgrid_User.Row, (int)ClassLib.TBSPS_USER.IxLANG_CD] == null)
            {
                lang_cd = "";
            }
            else
            {
                lang_cd = fgrid_User[fgrid_User.Row, (int)ClassLib.TBSPS_USER.IxLANG_CD].ToString();
            }






            DataTable dt_ret = SELECT_SCM_MENU_USER(user_id);
            Display_Grid(fgrid_Menu, dt_ret);



            dt_ret.Dispose();






        }



        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_dt"></param>
        private void Display_Grid(COM.FSP arg_fgrid, DataTable arg_dt)
        {


            arg_fgrid.ClearAll();




            arg_fgrid.Tree.Column = (int)ClassLib.TBSCM_MENU_USER.IxMENU_TEXT;
            arg_fgrid.Tree.Style = TreeStyleFlags.Complete;
            arg_fgrid.Tree.Show(-1);



            int level = 0;

            // data 표시
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_MENU_USER.IxMENU_LEVEL - 1].ToString());

                arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, level);

                arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_USER.IxDIVISION] = "";

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[i + arg_fgrid.Rows.Fixed, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

            } // end for i





        }



        #endregion

        #region 버튼 및 기타 이벤트 메서드


        /// <summary>
        /// Event_txt_User_KeyUp : 
        /// </summary>
        private void Event_txt_User_KeyUp()
        {

            Event_Tbtn_Search();

        }



        /// <summary>
        /// Event_cmb_Role_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Role_SelectedValueChanged()
        {

            Event_Tbtn_Search();

        }




        #region Create user from AD



        private DataTable _DT_User;





        /// <summary>
        /// Event_btn_AdUpdate_Click : 
        /// </summary>
        private void Event_btn_AdUpdate_Click()
        {


            _DT_User = new DataTable();

            _DT_User.Columns.Add("Mail");
            _DT_User.Columns.Add("Name");




            /*
			
			
             SELECT REPLACE(distinguishedName, ',DC=dskorea,DC=com', '') AS distinguishedName, Name, mail
                FROM OPENQUERY (ADSI, 
                    'SELECT Name, distinguishedName, mail, extensionAttribute1
                    FROM  ''LDAP://203.228.108.2/DC=dskorea,DC=com'' 
                    WHERE objectClass = ''user''
                    ')
                WHERE distinguishedName LIKE '%OU=CS Inc%'
                    OR distinguishedName LIKE '%OU=CSTC%'
                    OR distinguishedName LIKE '%OU=QD%'
                    OR distinguishedName LIKE '%OU=VJ%'
                    OR distinguishedName LIKE '%OU=JJ%'
                    OR distinguishedName LIKE '%OU=SHC%'

			
             */


            DirectoryEntry deDirEntry = new DirectoryEntry("LDAP://dskorea.com");

            //objectClass = 'organizationalUnit' 


            DirectoryEntry ou_csinc = deDirEntry.Children.Find("OU=CS Inc");
            DirectoryEntry ou_cstc = deDirEntry.Children.Find("OU=CSTC");
            DirectoryEntry ou_qd = deDirEntry.Children.Find("OU=QD");
            DirectoryEntry ou_vj = deDirEntry.Children.Find("OU=VJ");
            DirectoryEntry ou_jj = deDirEntry.Children.Find("OU=JJ");
            DirectoryEntry ou_csinc_ex = deDirEntry.Children.Find("OU=SHC");


            DirectorySearcher search = null;


            search = new DirectorySearcher(ou_csinc);
            Make_User_Table(search);

            search = new DirectorySearcher(ou_cstc);
            Make_User_Table(search);

            search = new DirectorySearcher(ou_qd);
            Make_User_Table(search);

            search = new DirectorySearcher(ou_vj);
            Make_User_Table(search);

            search = new DirectorySearcher(ou_jj);
            Make_User_Table(search);

            search = new DirectorySearcher(ou_csinc_ex);
            Make_User_Table(search);


            deDirEntry.Close();
            ou_csinc.Close();
            ou_cstc.Close();
            ou_qd.Close();
            ou_vj.Close();
            ou_jj.Close();
            ou_csinc_ex.Close();







            bool save_flag = SAVE_SCM_USER_AD(_DT_User);

            if (!save_flag)
            {
                COM.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
            }
            else
            {
                COM.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
            }





        }




        /// <summary>
        /// Make_User_Table : 
        /// </summary>
        /// <param name="arg_search"></param>
        private void Make_User_Table(DirectorySearcher arg_search)
        {

            arg_search.PropertiesToLoad.Add("mail");
            arg_search.PropertiesToLoad.Add("name");

            arg_search.Filter = "(&(objectClass=user)(mail=*))";
            arg_search.SearchScope = SearchScope.Subtree;



            SearchResultCollection results = arg_search.FindAll();



            DataRow dr;


            foreach (SearchResult result in results)
            {


                dr = _DT_User.NewRow();


                foreach (string property_name in result.Properties.PropertyNames)
                {

                    string property_value = result.Properties[property_name][0].ToString();


                    if (property_name == "mail")
                    {
                        dr[0] = property_value;
                    }

                    if (property_name == "name")
                    {
                        dr[1] = property_value;
                    }


                } // end foreach


                _DT_User.Rows.Add(dr);



            } // end foreach



        }



        /// <summary>
        /// SAVE_ECM_USER_AD : 
        /// </summary>
        /// <param name="arg_dt"></param>
        /// <returns></returns>
        private bool SAVE_SCM_USER_AD(DataTable arg_dt)
        {
            try
            {

                //COM.OraDB MyOraDB = new COM.OraDB();

                int col_ct = 3;


                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SPS_USER_BSC.SAVE_SPS_USER_AD";


                MyOraDB.Parameter_Name[0] = "ARG_USER_ID";
                MyOraDB.Parameter_Name[1] = "ARG_USER_NAME";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";



                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }






                // 파라미터 값에 저장할 배열
                System.Collections.ArrayList vList = new System.Collections.ArrayList();


                for (int i = 0; i < _DT_User.Rows.Count; i++)
                {

                    vList.Add(_DT_User.Rows[i].ItemArray[0].ToString());  // user_id
                    vList.Add(_DT_User.Rows[i].ItemArray[1].ToString());  // user_name
                    vList.Add(ClassLib.ComVar.This_User);    // upd_user


                }


                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));



                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)  // error
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_ECM_USER_AD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }



        #endregion




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

                Event_Tbtn_Search();
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


        private void fgrid_User_BeforeEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_User_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_User_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_User_AfterEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_User_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_User_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_User_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_User_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_User_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void fgrid_Menu_BeforeEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_Menu_AfterEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void Form_EIS_Menu_User_Load(object sender, EventArgs e)
        {
            Init_Form();
        }


        private void txt_User_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyCode != Keys.Enter) return;

                Event_txt_User_KeyUp();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_User_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_Role_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;


                Event_cmb_Role_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Role_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }





        private void btn_AdUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;


                Event_btn_AdUpdate_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_AdUpdate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        #endregion

        #region 조회


        /// <summary>
        /// SELECT_SCM_USER : 
        /// </summary>
        /// <param name="arg_user_id"></param>
        /// <param name="arg_role"></param>
        /// <returns></returns>
        private DataTable SELECT_SCM_USER(string arg_user_id, string arg_role)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_USER";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_USER_ID";
                MyOraDB.Parameter_Name[1] = "ARG_ROLE_ID";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_user_id;
                MyOraDB.Parameter_Values[1] = arg_role;
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
        /// SELECT_SCM_MENU_USER : 
        /// </summary>
        /// <param name="arg_user_id"></param>
        /// <returns></returns>
        private DataTable SELECT_SCM_MENU_USER(string arg_user_id)
        {

            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_MENU_USER";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_USER_ID";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";




                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;




                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_user_id;
                MyOraDB.Parameter_Values[1] = "";




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



        #endregion

       



    }
}