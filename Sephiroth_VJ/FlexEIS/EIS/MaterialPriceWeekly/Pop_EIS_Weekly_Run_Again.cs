using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;
using C1.Win.C1FlexGrid;

namespace FlexEIS.EIS.MaterialPriceWeekly
{
    public partial class Pop_EIS_Weekly_Run_Again : COM.APSWinForm.Pop_Small
    {

        #region 생성자


        public Pop_EIS_Weekly_Run_Again()
        {
            InitializeComponent();
        }



        private string _Factory = "";
        private string _PlanMonth = "";



        public Pop_EIS_Weekly_Run_Again(string arg_factory, string arg_plan_month)
        {

            InitializeComponent();


            _Factory = arg_factory;
            _PlanMonth = arg_plan_month;


        }




        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();

        public bool _Apply_Flag = false;

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
                //this.Text = "주간 자재 분석 재 실행";
                //lbl_MainTitle.Text = "주간 자재 분석 재 실행";


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


            fgrid_Main.Set_Grid("EIS_MATPRICE_WEEKLY_RUN_AGAIN", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Font = new Font("Verdana", 8);


        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {




            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_FACTORY();
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



       


        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1) return;



            string factory = cmb_Factory.SelectedValue.ToString();


            // plan_month 설정
            DataTable dt_ret = EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Factory.SELECT_WEEKLY_PLAN_MONTH(factory);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PlanMonth, 0, 0, false, COM.ComVar.ComboList_Visible.Code);
            cmb_PlanMonth.SelectedValue = _PlanMonth;


            dt_ret.Dispose();


        }


        /// <summary>
        /// Event_PlanMonth_SelectedValueChanged : 
        /// </summary>
        private void Event_PlanMonth_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;


            Event_btn_Search_Click();

        }


        /// <summary>
        /// Event_btn_Search_Click : 
        /// </summary>
        private void Event_btn_Search_Click()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;



            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");

            DataTable dt_ret = SELECT_WEEKLY_PLAN_WEEK(factory, plan_month);
            Display_Grid(dt_ret);


        }



        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_dt"></param>
        private void Display_Grid(DataTable arg_dt)
        {

            

            fgrid_Main.Clear(ClearFlags.UserData);


            if (arg_dt.Rows.Count == 0) return;


            fgrid_Main.Display_Grid(arg_dt, false);
            
            

            // 컬럼에 check field 표시
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {


                // 행 높이 조절
                fgrid_Main.Rows[i].Height = 20;



                fgrid_Main.SetCellCheck(i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxPLAN_WEEK_DESC, CheckEnum.Unchecked);


                // 상태 컬럼 값 설정
                fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxSTATUS] = "Ready";


                // forecast 이면 글자색 변경
                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxFORECAST_YN] == null
                    || ! fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxFORECAST_YN].ToString().Trim().Equals("Y")) continue;

                CellStyle cellst_forecast = fgrid_Main.Styles.Add("FORECAST" + i.ToString());
                cellst_forecast.ForeColor = Color.Gray;

                CellRange cr_forecast = fgrid_Main.GetCellRange(i, 1, i, fgrid_Main.Cols.Count - 1);
                cr_forecast.Style = fgrid_Main.Styles["FORECAST" + i.ToString()];


              

            }



            fgrid_Main.ExtendLastCol = true;


           



        }




        private EIS.Common.Pop_Wait_UsingThread _popWait = null;
        private Thread temp_thread = null;




        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        private void Event_btn_Apply_Click()
        {



            if(cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;



            // 행 수정상태 해제 
            fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, false);


            DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
            if (result == DialogResult.No) return;


            System.Windows.Forms.Application.DoEvents();


            _popWait = new EIS.Common.Pop_Wait_UsingThread();
            temp_thread = new Thread(new ThreadStart(_popWait.Start));

            if (temp_thread != null)
            {
                temp_thread.Start();

                Apply();
            }



        }



        /// <summary>
        /// Apply : 
        /// </summary>
        private void Apply()
        {


            try
            {


                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxPLAN_WEEK_DESC).Equals(CheckEnum.Unchecked)) continue;


                    string this_factory = ClassLib.ComVar.This_Factory;
                    string factory = cmb_Factory.SelectedValue.ToString();
                    string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
                    string plan_week = fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxPLAN_WEEK].ToString();
                    string upd_user = ClassLib.ComVar.This_User;
                    string forecast_yn = fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxFORECAST_YN].ToString();



                    bool run_flag = RUN_EMM_WEEKLY_USER_AGAIN(this_factory, factory, plan_month, plan_week, upd_user, forecast_yn);



                    if (run_flag)
                    {
                        fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxSTATUS] = "Completed";
                    }
                    else
                    {
                        fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_RUN_AGAIN.IxSTATUS] = "Failed";
                    }



                    System.Windows.Forms.Application.DoEvents();



                }



                _Apply_Flag = true;



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (temp_thread != null) temp_thread.Abort();
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


            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;



            fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);


            fgrid_Main[fgrid_Main.Rows.Count - 1, 1] = cmb_Factory.SelectedValue.ToString();
            fgrid_Main[fgrid_Main.Rows.Count - 1, 2] = cmb_PlanMonth.SelectedValue.ToString();



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



        private void Pop_EIS_Weekly_Run_Again_Load(object sender, EventArgs e)
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


        private void cmb_PlanMonth_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_PlanMonth_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_PlanMonth_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// SELECT_WEEKLY_PLAN_WEEK : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_PLAN_WEEK(string arg_factory, string arg_plan_month)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_PLAN_WEEK";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
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

        #region 실행



        /// <summary>
        /// RUN_EMM_WEEKLY_USER_AGAIN : 
        /// </summary>
        /// <param name="arg_this_factory"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_upd_user"></param>
        /// <param name="arg_forecast_yn"></param>
        /// <returns></returns>
        private bool RUN_EMM_WEEKLY_USER_AGAIN(string arg_this_factory, 
            string arg_factory, 
            string arg_plan_month, 
            string arg_plan_week, 
            string arg_upd_user,
            string arg_forecast_yn)
        {

            try
            {


                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_BATCH.RUN_EMM_WEEKLY_USER_AGAIN";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[3] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[5] = "ARG_FORECAST_YN";

                

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_this_factory;
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_plan_month;
                MyOraDB.Parameter_Values[3] = arg_plan_week;
                MyOraDB.Parameter_Values[4] = arg_upd_user;
                MyOraDB.Parameter_Values[5] = arg_forecast_yn;


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
            catch
            {
                return false;
            }


        }






        #endregion



        #endregion

        


        
       




    }
}

