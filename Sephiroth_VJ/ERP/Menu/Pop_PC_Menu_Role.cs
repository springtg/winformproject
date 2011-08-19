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
    public partial class Pop_PC_Menu_Role : COM.APSWinForm.Pop_Small
    {

        #region 생성자


        public Pop_PC_Menu_Role()
        {
            InitializeComponent();

        }
           
        private string _Factory = "";
        private string _LangCd = "";



        public Pop_PC_Menu_Role(string arg_factory, string arg_lang_cd)
        {

            InitializeComponent();


            _Factory = arg_factory;
            _LangCd = arg_lang_cd;


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
                //this.Text = "Menu Role";
                //lbl_MainTitle.Text = "Menu Role";


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


            fgrid_Main.Set_Grid("SCM_MENU_ROLE_ID", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);


        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {




            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();


            cmb_Factory.SelectedValue = _Factory;



        }






        #endregion

        #region 조회






        #endregion

        #region 툴바 이벤트 메서드




        #endregion

        #region 그리드 이벤트 메서드



        /// <summary>
        /// Event_fgrid_Main_BeforeEdit : 
        /// </summary>
        private void Event_fgrid_Main_BeforeEdit()
        {

            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
            }


        }



        /// <summary>
        /// Event_fgrid_Main_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Main_AfterEdit()
        {

            fgrid_Main.Update_Row();

        }





        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1) return;



            // Language 코드
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLangCode); // "DA02"
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LangCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_LangCd.SelectedValue = _LangCd;





        }


        /// <summary>
        /// Event_LangCd_SelectedValueChanged : 
        /// </summary>
        private void Event_LangCd_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1) return;


            Event_btn_Search_Click();

        }


        /// <summary>
        /// Event_btn_Search_Click : 
        /// </summary>
        private void Event_btn_Search_Click()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1) return;



            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_LangCd.SelectedValue.ToString();

            DataTable dt_ret = SELECT_SCM_MENU_ROLE_ID(factory, lang_cd);
            fgrid_Main.Display_Grid(dt_ret, false);


        }


        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        private void Event_btn_Apply_Click()
        {

            // 행 수정상태 해제 
            fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, false);


            DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
            if (result == DialogResult.No) return;



            bool save_flag = SAVE_SCM_MENU_ROLE_ID();

            if (save_flag)
            {

                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
                Event_btn_Search_Click();

            }
            else
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return;

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


        /// <summary>
        /// Event_memuitem_Insert_Click : 
        /// </summary>
        private void Event_memuitem_Insert_Click()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_LangCd.SelectedIndex == -1) return;



            fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);


            fgrid_Main[fgrid_Main.Rows.Count - 1, 1] = cmb_Factory.SelectedValue.ToString();
            fgrid_Main[fgrid_Main.Rows.Count - 1, 2] = cmb_LangCd.SelectedValue.ToString();



        }



        /// <summary>
        /// Event_memuitem_Delete_Click : 
        /// </summary>
        private void Event_memuitem_Delete_Click()
        {

            fgrid_Main.Delete_Row();

        }



        #endregion



        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트


     



        #endregion

        #region 그리드 이벤트



        private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Main_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Main_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void Pop_PC_Menu_Role_Load(object sender, EventArgs e)
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


        private void btn_Search_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Search_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void memuitem_Insert_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_memuitem_Insert_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_memuitem_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void menuitem_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_memuitem_Delete_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_memuitem_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #endregion

        #region 디비 연결


        #region 콤보

 
        #endregion

        #region 조회




        /// <summary>
        /// SELECT_SCM_MENU_ROLE_ID : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SCM_MENU_ROLE_ID(string arg_factory, string arg_lang_cd)
        {

            try
            {

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

        #region 저장



        /// <summary>
        /// SAVE_SCM_MENU_ROLE_ID : 
        /// </summary>
        /// <returns></returns>
        private bool SAVE_SCM_MENU_ROLE_ID()
        {

            try
            {

                int col_ct = 9;


                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SCM_MENU.SAVE_SCM_MENU_ROLE_ID";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[3] = "ARG_ROLE_ID";
                MyOraDB.Parameter_Name[4] = "ARG_ROLE_NAME";
                MyOraDB.Parameter_Name[5] = "ARG_ROLE_ORD";
                MyOraDB.Parameter_Name[6] = "ARG_MENU_KEY";
                MyOraDB.Parameter_Name[7] = "ARG_MENU_TYPE";
                MyOraDB.Parameter_Name[8] = "ARG_UPD_USER";





                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                System.Collections.ArrayList vList = new System.Collections.ArrayList();


                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    vList.Add(fgrid_Main[i, 0].ToString());  // division
                    vList.Add(fgrid_Main[i, 1].ToString());  // factory
                    vList.Add(fgrid_Main[i, 2].ToString());  // lang_cd
                    vList.Add(fgrid_Main[i, 3].ToString());  // role_id
                    vList.Add(fgrid_Main[i, 4].ToString());  // role_name
                    vList.Add(fgrid_Main[i, 5].ToString());  // role_ord
                    vList.Add("0");                          // menu_key
                    vList.Add("R");                          // menu_type
                    vList.Add(ClassLib.ComVar.This_User);    // upd_user


                }

              


                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

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