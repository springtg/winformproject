using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Xml;
using System.IO;
using C1.Win.C1FlexGrid;
using System.Diagnostics;
using System.Text;


namespace FlexCDC.BaseInfo
{
    public partial class Form_EIS_Common_Category : COM.APSWinForm.Form_Top
    {
        public Form_EIS_Common_Category()
        {
            InitializeComponent();
        }



        #region 사용자 정의 변수

        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction MyComFunction = new COM.ComFunction();
        private int _treelevel = 3;


        #endregion



        #region 공통모듈

        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = " Category 분류 ";
                lbl_MainTitle.Text = " Category 분류 ";
                lbl_title.Text = "       Category 분류 ";


                Init_Control();
                Init_Grid();
                Init_Toolbar();

                rdbtn_viewModelSTD_CheckedChanged(null, null);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {

            // Grid Setting
            fgrid_Main.Set_Grid("EDM_PCC_CATEGORY", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.ExtendLastCol = false;
            //fgrid_Main.SelectionMode = SelectionModeEnum.RowRange;

        }


        private void Init_Control()
        {



            // 공장 Combobox Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Factory.SelectedIndex = 0;
            cmb_Factory.Enabled = false;


            // Combobox Add Items
            dt_ret = SELECT_SEASON();

            string season = DateTime.Now.Month.ToString();
            if (season.Equals("1") || season.Equals("2") || season.Equals("3"))
                season = DateTime.Now.Year.ToString() + "02";
            else if (season.Equals("4") || season.Equals("5") || season.Equals("6"))
                season = DateTime.Now.Year.ToString() + "03";
            else if (season.Equals("7") || season.Equals("8") || season.Equals("9"))
                season = DateTime.Now.Year.ToString() + "04";
            else if (season.Equals("10") || season.Equals("11") || season.Equals("12"))
                season = DateTime.Now.AddYears(1).Year.ToString() + "01";

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_from.SelectedValue = season;
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_to.SelectedValue = season;




            // Category Setting..
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_CDC_Factory, "SXB03");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Category, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            dt_ret.Dispose();
            cmb_Category.SelectedIndex = 0;
        
            




            //Status
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_CDC_Factory, "SXC34");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_status.SelectedIndex = 0;
            dt_ret.Dispose();


        }


        private void Init_Toolbar()
        {
            // Disabled tbutton
            tbtn_Print.Enabled = false;
            tbtn_Save.Enabled = true;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = true;
            tbtn_Color.Text = "Confirm";
        }


        private void Event_Tbtn_Search()
        {


            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_Season_from, cmb_Season_to };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            string vFactory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string vSeasonFrom = cmb_Season_from.SelectedValue.ToString();
            string vSeasonTo = cmb_Season_to.SelectedValue.ToString();
            string vCategory = ClassLib.ComFunction.Empty_Combo(cmb_Category, " ");
            string vStatus = ClassLib.ComFunction.Empty_Combo(cmb_status, " ");

            DataTable dt_ret = SELECT_EDM_SRF_LIST(vFactory, vSeasonFrom, vSeasonTo, vCategory, vStatus);
            Display_Grid(dt_ret);
            dt_ret.Dispose();

            fgrid_Main.Tree.Show(_treelevel);


        }



        //private void Event_Tbtn_Create()
        //{


          



        //}




        //private void Event_Tbtn_Save()
        //{


        //    try
        //    {
        //        this.Cursor = Cursors.WaitCursor;



        //        if (SAVE_EDM_SRF_CATEGORY() == true)
        //            Event_Tbtn_Search();
        //        else
        //            ClassLib.ComFunction.User_Message("Error", "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);


        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.Cursor = Cursors.Default;
        //    }



        //}









        private void Display_Grid(DataTable arg_dt)
        {
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            fgrid_Main.Tree.Column = (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxLEVELS_NAME;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                int lev = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxLEVELS - 1].ToString());

                fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, lev);
                fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();




                if (fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxLEVELS].ToString() == "3")
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;
                else
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;

            }



        }


        #endregion

        #region DB컨넥트
        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "DS";
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }


        private bool CREATE_EDM_SRF_CATEGORY()
        {

            try
            {


                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = "PKG_SXB_BASE_01.CREATE_SXD_SRF_M_CATEGORY";

                // 파라미터 이름 설정                

                MyOraDB.Parameter_Name[0] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;




                MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
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
                MessageBox.Show(ex.ToString());
                return false;
            }


        }



        private bool CONFIRM_EDM_SRF_CATEGORY()
        {

            try
            {



                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = "PKG_SXD_SRF_01.UPDATE_CATEGORY";

                // 파라미터 이름 설정                

                MyOraDB.Parameter_Name[0] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
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
                MessageBox.Show(ex.ToString());
                return false;
            }


        }



        private bool SAVE_EDM_SRF_CATEGORY()
        {

            try
            {



                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SXB_BASE_01.UPDATE_SXD_SRF_M_CATEGORY";

                // 파라미터 이름 설정                

                MyOraDB.Parameter_Name[0] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[1] = "ARG_REP_SRF_NO";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;



                //변수값 재할당
                int vCnt = 0;
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    if (fgrid_Main[i, 0].ToString() == "U") vCnt++;

                MyOraDB.Parameter_Values = new string[vCnt * 3];


                //파라미터의 VALUE할당.
                vCnt = 0;
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {
                    if (fgrid_Main[i, 0].ToString() == "U")
                    {

                        MyOraDB.Parameter_Values[vCnt++] = fgrid_Main[i, (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxCATEGORY_CD].ToString();
                        MyOraDB.Parameter_Values[vCnt++] = fgrid_Main[i, (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxREP_SRF_NO].ToString();
                        MyOraDB.Parameter_Values[vCnt++] = ClassLib.ComVar.This_User;

                    }

                }


                MyOraDB.Add_Modify_Parameter(true);
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
                MessageBox.Show(ex.ToString());
                return false;
            }


        }


        private DataTable SELECT_EDM_SRF_LIST(string arg_factory, string arg_season_from, string arg_season_to, string  arg_category, string arg_status)
        {
            try
            {
                string Proc_Name = "PKG_SXB_BASE_01.SELECT_SXD_SRF_M_CATEGORY";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "ARG_CATEGORY_CD";
                MyOraDB.Parameter_Name[3] = "ARG_STATUS";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;


                MyOraDB.Parameter_Values[0] = arg_season_from;
                MyOraDB.Parameter_Values[1] = arg_season_to;
                MyOraDB.Parameter_Values[2] = arg_category;
                MyOraDB.Parameter_Values[3] = arg_status;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }






        #endregion



        #region 버튼 컨트롤


        private void rdbtn_viewModel_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(4);
            _treelevel = 4;
        }

        private void rdbtn_viewSeason_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(1);
            _treelevel = 1;
        }

        private void rdbtn_viewModelSTD_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(3);
            _treelevel = 3;
        }

        private void rdbtn_viewStatus_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(2);
            _treelevel = 2;
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





        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {


                this.Cursor = Cursors.WaitCursor;

                if (CREATE_EDM_SRF_CATEGORY() == true)
                    Event_Tbtn_Search();
                else
                    ClassLib.ComFunction.User_Message("Error", "CREATE_EDM_SRF_CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Create", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



                if (SAVE_EDM_SRF_CATEGORY() == true)
                    Event_Tbtn_Search();
                else
                    ClassLib.ComFunction.User_Message("Error", "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);


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






        private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;


                if (CONFIRM_EDM_SRF_CATEGORY() == true)
                    Event_Tbtn_Search();
                else
                    ClassLib.ComFunction.User_Message("Error", "tbtn_Color_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Color_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }



        }



        private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {
                if (fgrid_Main.Rows[i].Selected)
                {

                    if (fgrid_Main[i, (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxLEVELS].ToString() == "3")
                        fgrid_Main.Update_Row(i);


                    fgrid_Main[i, (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxCATEGORY_CD] = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEDM_PCC_SRF_CATEGORY.lxCATEGORY_CD].ToString();
                }


            }
        }


       




        #endregion


        private void Form_EIS_Common_Category_Load(object sender, EventArgs e)
        {
            Init_Form();
        }





    }
}

