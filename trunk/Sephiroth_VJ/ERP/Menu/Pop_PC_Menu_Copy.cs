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
    public partial class Pop_PC_Menu_Copy : COM.APSWinForm.Pop_Small
    {

        #region 생성자


        public Pop_PC_Menu_Copy()
        {
            InitializeComponent();

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
                //this.Text = "메뉴 복사";
                //lbl_MainTitle.Text = "메뉴 복사";


                Init_Grid();

                Init_Control();


                Display_Grid_Option();




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


            fgrid_Option.Set_Grid("SCM_MENU_COPY_OPTION", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);


        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {


            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_S, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_T, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();

            cmb_Factory_S.SelectedIndex = -1;
            cmb_Factory_T.SelectedIndex = -1;

        }



        /// <summary>
        /// Display_Grid_Option : 
        /// </summary>
        private void Display_Grid_Option()
        {



            fgrid_Option.Rows.InsertNode(fgrid_Option.Rows.Count, 0);
            fgrid_Option[fgrid_Option.Rows.Count - 1, 1] = "Factory";
            fgrid_Option.Rows[fgrid_Option.Rows.Count - 1].Height = 20;
            fgrid_Option.SetCellCheck(fgrid_Option.Rows.Count - 1, 1, CheckEnum.Unchecked);

            fgrid_Option.Rows.InsertNode(fgrid_Option.Rows.Count, 1);
            fgrid_Option[fgrid_Option.Rows.Count - 1, 1] = "Language";
            fgrid_Option.Rows[fgrid_Option.Rows.Count - 1].Height = 20;
            fgrid_Option.SetCellCheck(fgrid_Option.Rows.Count - 1, 1, CheckEnum.Unchecked);

            fgrid_Option.Rows.InsertNode(fgrid_Option.Rows.Count, 2);
            fgrid_Option[fgrid_Option.Rows.Count - 1, 1] = "Role";
            fgrid_Option.Rows[fgrid_Option.Rows.Count - 1].Height = 20;
            fgrid_Option.SetCellCheck(fgrid_Option.Rows.Count - 1, 1, CheckEnum.Checked);


            fgrid_Option.Rows[fgrid_Option.Rows.Fixed - 1].Visible = false;


            fgrid_Option.Tree.Show(-1);
            fgrid_Option.Tree.Style = TreeStyleFlags.Complete;
            fgrid_Option.Tree.Column = 1;




        }





        #endregion

        #region 조회






        #endregion

        #region 툴바 이벤트 메서드




        #endregion

        #region 그리드 이벤트 메서드



        /// <summary>
        /// Event_fgrid_Option_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Option_AfterEdit()
        {

            // Factory : fgrid_Option.Rows.Fixed 
            // Language : fgrid_Option.Rows.Fixed + 1
            // Role : fgrid_Option.Rows.Fixed + 2





            // factory check
            if (fgrid_Option.GetCellCheck(fgrid_Option.Rows.Fixed, 1) == CheckEnum.Checked)
            {


                fgrid_Option.SetCellCheck(fgrid_Option.Rows.Fixed + 1, 1, CheckEnum.Checked);
                fgrid_Option.SetCellCheck(fgrid_Option.Rows.Fixed + 2, 1, CheckEnum.Checked);



                cmb_Factory_S.Enabled = true;
                cmb_LangCd_S.Enabled = false;
                cmb_RoleID_S.Enabled = false;

                cmb_Factory_T.Enabled = true;
                cmb_LangCd_T.Enabled = false;
                cmb_RoleID_T.Enabled = false;


                cmb_LangCd_S.SelectedIndex = -1;
                cmb_RoleID_S.SelectedIndex = -1;
                cmb_LangCd_T.SelectedIndex = -1;
                cmb_RoleID_T.SelectedIndex = -1;

            }
            // language check
            else if (fgrid_Option.GetCellCheck(fgrid_Option.Rows.Fixed + 1, 1) == CheckEnum.Checked)
            {


                fgrid_Option.SetCellCheck(fgrid_Option.Rows.Fixed + 2, 1, CheckEnum.Checked);



                cmb_Factory_S.Enabled = true;
                cmb_LangCd_S.Enabled = true;
                cmb_RoleID_S.Enabled = false;

                cmb_Factory_T.Enabled = true;
                cmb_LangCd_T.Enabled = true;
                cmb_RoleID_T.Enabled = false;


                cmb_RoleID_S.SelectedIndex = -1;
                cmb_RoleID_T.SelectedIndex = -1;

            }
            // Role check
            else if (fgrid_Option.GetCellCheck(fgrid_Option.Rows.Fixed + 2, 1) == CheckEnum.Checked)
            {

                cmb_Factory_S.Enabled = true;
                cmb_LangCd_S.Enabled = true;
                cmb_RoleID_S.Enabled = true;

                cmb_Factory_T.Enabled = true;
                cmb_LangCd_T.Enabled = true;
                cmb_RoleID_T.Enabled = true;


            }







        }



        #endregion

        #region 버튼 및 기타 이벤트 메서드


        /// <summary>
        /// Event_cmb_Factory_S_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_S_SelectedValueChanged()
        {


            if (cmb_Factory_S.SelectedIndex == -1) return;



            // Language 코드
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory_S.SelectedValue.ToString(), ClassLib.ComVar.CxLangCode); // "DA02"
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LangCd_S, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_LangCd_S.SelectedIndex = -1;


        }


        /// <summary>
        /// Event_cmb_LangCd_S_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_LangCd_S_SelectedValueChanged()
        {


            if (cmb_Factory_S.SelectedIndex == -1 || cmb_LangCd_S.SelectedIndex == -1) return;


            string factory = cmb_Factory_S.SelectedValue.ToString();
            string lang_cd = cmb_LangCd_S.SelectedValue.ToString();


            DataTable dt_ret = ERP.Menu.Form_PC_Menu_Role.SELECT_SCM_MENU_ROLE_ID(factory, lang_cd);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoleID_S, 2, 3, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_RoleID_S.SelectedIndex = -1;



            dt_ret.Dispose();


        }



        /// <summary>
        /// Event_cmb_Factory_T_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_T_SelectedValueChanged()
        {


            if (cmb_Factory_T.SelectedIndex == -1) return;



            // Language 코드
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory_T.SelectedValue.ToString(), ClassLib.ComVar.CxLangCode); // "DA02"
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LangCd_T, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_LangCd_T.SelectedIndex = -1;





        }


        /// <summary>
        /// Event_cmb_LangCd_T_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_LangCd_T_SelectedValueChanged()
        {


            if (cmb_Factory_T.SelectedIndex == -1 || cmb_LangCd_T.SelectedIndex == -1) return;


            string factory = cmb_Factory_T.SelectedValue.ToString();
            string lang_cd = cmb_LangCd_T.SelectedValue.ToString();


            DataTable dt_ret = ERP.Menu.Form_PC_Menu_Role.SELECT_SCM_MENU_ROLE_ID(factory, lang_cd);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoleID_T, 2, 3, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_RoleID_T.SelectedIndex = -1;



            dt_ret.Dispose();


        }



        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        private void Event_btn_Apply_Click()
        {


            DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
            if (result == DialogResult.No) return;


            string division = "";
            string factory_s = "";
            string role_id_s = "";
            string lang_cd_s = "";
            string factory_t = "";
            string role_id_t = "";
            string lang_cd_t = "";
            string upd_user = ClassLib.ComVar.This_User;




            // Factory : fgrid_Option.Rows.Fixed 
            // Language : fgrid_Option.Rows.Fixed + 1
            // Role : fgrid_Option.Rows.Fixed + 2



            // factory check
            if (fgrid_Option.GetCellCheck(fgrid_Option.Rows.Fixed, 1) == CheckEnum.Checked)
            {
                division = "FACTORY";
            }
            // language check
            else if (fgrid_Option.GetCellCheck(fgrid_Option.Rows.Fixed + 1, 1) == CheckEnum.Checked)
            {
                division = "LANGUAGE";
            }
            // Role check
            else if (fgrid_Option.GetCellCheck(fgrid_Option.Rows.Fixed + 2, 1) == CheckEnum.Checked)
            {
                division = "ROLE";
            }
            else
            {
                division = "-1";
            }


            // option check 가 한건도 되어 있지 않은 경우
            if (division == "-1")
            {

                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
                return;

            }



            factory_s = ClassLib.ComFunction.Empty_Combo(cmb_Factory_S, " ");
            lang_cd_s = ClassLib.ComFunction.Empty_Combo(cmb_LangCd_S, " ");
            role_id_s = ClassLib.ComFunction.Empty_Combo(cmb_RoleID_S, " ");
            factory_t = ClassLib.ComFunction.Empty_Combo(cmb_Factory_T, " ");
            lang_cd_t = ClassLib.ComFunction.Empty_Combo(cmb_LangCd_T, " ");
            role_id_t = ClassLib.ComFunction.Empty_Combo(cmb_RoleID_T, " ");


            bool save_flag = COPY_SCM_MENU_ROLE(division, factory_s, lang_cd_s, role_id_s, factory_t, lang_cd_t, role_id_t, upd_user);

            if (save_flag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
            }
            else
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);

            }




        }


        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        private void Event_btn_Cancel_Click()
        {
            this.Close();
        }




        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드





        #endregion



        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트






        #endregion

        #region 그리드 이벤트


        private void fgrid_Option_AfterEdit(object sender, RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Option_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Option_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void Pop_EIS_Menu_Copy_Load(object sender, EventArgs e)
        {
            Init_Form();
        }


        private void cmb_Factory_S_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Factory_S_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_S_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_LangCd_S_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_LangCd_S_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_LangCd_S_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_Factory_T_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Factory_T_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_T_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_LangCd_T_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_LangCd_T_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_LangCd_T_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Apply_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Cancel_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        #endregion

        #region 저장



        /// <summary>
        /// COPY_SCM_MENU_ROLE : 
        /// </summary>
        /// <param name="arg_division"></param>
        /// <param name="arg_factory_s"></param>
        /// <param name="arg_role_id_s"></param>
        /// <param name="arg_lang_cd_s"></param>
        /// <param name="arg_factory_t"></param>
        /// <param name="arg_role_id_t"></param>
        /// <param name="arg_lang_cd_t"></param>
        /// <param name="arg_upd_user"></param>
        /// <returns></returns>
        private bool COPY_SCM_MENU_ROLE(string arg_division,
            string arg_factory_s,
            string arg_lang_cd_s,
            string arg_role_id_s,
            string arg_factory_t,
            string arg_lang_cd_t,
            string arg_role_id_t,
            string arg_upd_user)
        {

            try
            {


                int col_ct = 8;


                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SCM_MENU.COPY_SCM_MENU_ROLE";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY_S";
                MyOraDB.Parameter_Name[2] = "ARG_ROLE_ID_S";
                MyOraDB.Parameter_Name[3] = "ARG_LANG_CD_S";
                MyOraDB.Parameter_Name[4] = "ARG_FACTORY_T";
                MyOraDB.Parameter_Name[5] = "ARG_ROLE_ID_T";
                MyOraDB.Parameter_Name[6] = "ARG_LANG_CD_T";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";




                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }




                MyOraDB.Parameter_Values[0] = arg_division;
                MyOraDB.Parameter_Values[1] = arg_factory_s;
                MyOraDB.Parameter_Values[2] = arg_role_id_s;
                MyOraDB.Parameter_Values[3] = arg_lang_cd_s;
                MyOraDB.Parameter_Values[4] = arg_factory_t;
                MyOraDB.Parameter_Values[5] = arg_role_id_t;
                MyOraDB.Parameter_Values[6] = arg_lang_cd_t;
                MyOraDB.Parameter_Values[7] = arg_upd_user;


                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)
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
                return false;
            }


        }



        #endregion



        #endregion



    }
}