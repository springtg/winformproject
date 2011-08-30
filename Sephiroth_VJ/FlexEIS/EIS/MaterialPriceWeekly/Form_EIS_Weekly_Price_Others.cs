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


namespace FlexEIS.EIS.MaterialPriceWeekly
{
    public partial class  Form_EIS_Weekly_Price_Others : COM.APSWinForm.Form_Top
    {


        #region 생성자
         

        public  Form_EIS_Weekly_Price_Others()
        {

            InitializeComponent();

        }


        public static string _Factory = "";
        public static string _PlanMonth = "";
        public static string _PlanWeek = "";
        public static string _LineGroup = "";
        public static string _LineCd = "";
        



        public Form_EIS_Weekly_Price_Others(string arg_factory, 
            string arg_plan_month,
            string arg_plan_week,
            string arg_line_group,
            string arg_line_cd)
        {

            InitializeComponent();



            _Factory = arg_factory;
            _PlanMonth = arg_plan_month;
            _PlanWeek = arg_plan_week;
            _LineGroup = arg_line_group;
            _LineCd = arg_line_cd;


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
                //this.Text = "주간 자재 분석 - 기타 출고";
                //lbl_MainTitle.Text = "주간 자재 분석 - 기타 출고";


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


            fgrid_Main.Set_Grid("EIS_MATPRICE_WEEKLY_DIV_OTHERS", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            //fgrid_Main.Font = new Font("Verdana", 7);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            //fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.Font = new Font("Verdana", 8);



        }

        

        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {




            // Disabled tbutton
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;




            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_FACTORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();




            if (_Factory != null && !_Factory.Trim().Equals(""))
            {
                cmb_Factory.SelectedValue = _Factory;
                _Factory = "";
            }
            else
            {
                cmb_Factory.SelectedValue = ClassLib.ComFunction.Set_Default_Factory();
            }



        }





        #endregion

        #region 조회



        /// <summary>
        /// Search : 
        /// </summary>
        private void Search()
        {

            try
            {

               
                string factory = cmb_Factory.SelectedValue.ToString();
                string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
                string plan_week = ClassLib.ComFunction.Empty_Combo(cmb_PlanWeek, " ");
                string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
                string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");

                DataTable dt_ret = SELECT_WEEKLY_DIVISION_OTHERS(factory, plan_month, plan_week, line_group, line_cd);

                Display_Grid(dt_ret);
                
                dt_ret.Dispose();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (temp_thread != null) temp_thread.Abort();
            }

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


            ////---------------------------------------------------
            //// merge
            ////---------------------------------------------------
            //fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            //for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            //{
            //    fgrid_Main.Cols[i].AllowMerging = false;
            //}


            //for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxFACTORY; i <= (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxOP_CD; i++)
            //{
            //    fgrid_Main.Cols[i].AllowMerging = true;
            //}

            ////---------------------------------------------------


            Display_Grid_Subtotal();



        }



        /// <summary>
        /// Display_Grid_Subtotal : 
        /// </summary>
        private void Display_Grid_Subtotal()
        {


            #region subtotal


            fgrid_Main.Subtotal(AggregateEnum.Clear);
            fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;


            fgrid_Main.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;  // total
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].Font = new Font("Verdana", 8, FontStyle.Bold);


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHERS_ALL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxITEM_CD
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxSPEC_CD
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxCOLOR_CD) continue;



                fgrid_Main.Subtotal(AggregateEnum.Sum, 0, -1, i, "TOTAL");

            }



            #endregion

            #region total ratio



            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_NORMAL_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHERS_ALL_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHER_RATIO) continue;


                double out_all_amount = 0;
                double cal_amount = 0;
                string cal_ratio = "";




                if (fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_ALL] == null
                    || fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_ALL].ToString().Trim() == "")
                {
                    out_all_amount = 0;
                }
                else
                {
                    out_all_amount = Convert.ToDouble(fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_ALL].ToString());
                }





                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHERS_ALL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHER_RATIO)
                {


                    int col = 0;


                    if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_NORMAL_RATIO)
                    {
                        col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_NORMAL;
                    }
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHERS_ALL_RATIO)
                    {
                        col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHERS_ALL;
                    }
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_DEFECTIVE_RATIO)
                    {
                        col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_DEFECTIVE;
                    }
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OVERUSAGE_RATIO)
                    {
                        col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OVERUSAGE;
                    }
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHER_RATIO)
                    {
                        col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS.IxAMOUNT_OUT_OTHER;
                    }



                    if (fgrid_Main[fgrid_Main.Rows.Fixed, col] == null || fgrid_Main[fgrid_Main.Rows.Fixed, col].ToString().Trim() == "")
                    {
                        cal_amount = 0;
                    }
                    else
                    {
                        cal_amount = Convert.ToDouble(fgrid_Main[fgrid_Main.Rows.Fixed, col].ToString());
                    }


                    if (out_all_amount == 0)
                    {
                        cal_ratio = "0";
                    }
                    else
                    {
                        cal_ratio = Convert.ToString(Math.Round((cal_amount / out_all_amount) * 100, 2));
                    }



                }



                fgrid_Main[fgrid_Main.Rows.Fixed, i] = cal_ratio.ToString();




            } // end for i
            //-----------------------------------------------------------------------------------------

            #endregion



        }






        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {


            fgrid_Main.ClearAll();



        }



        private EIS.Common.Pop_Wait_UsingThread _popWait = null;
        private Thread temp_thread = null;


        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {


            //// 조회시 필수조건 체크 
            //C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth, cmb_Deduction };
            //System.Windows.Forms.TextBox[] txt_array = { };
            //bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            //if (!previous_check) return;


            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1 || cmb_PlanWeek.SelectedIndex == -1) return;


            //_popWait = new Pop_Wait_UsingThread();
            //temp_thread = new Thread(new ThreadStart(_popWait.Start));

            //if (temp_thread != null)
            //{
            //    temp_thread.Start();
            //    Search();
            //}


            Search();


        }


        /// <summary>
        /// Event_Tbtn_Print : 
        /// </summary>
        private void Event_Tbtn_Print()
        {

            saveFileDialog1.Filter = "Excel 파일|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            if (saveFileDialog1.FileName != "")
            {

                fgrid_Main.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "주간 자재 분석 - 기타 출고", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }



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


           
            Event_Tbtn_New();




            string factory = cmb_Factory.SelectedValue.ToString();


            // plan_month 설정
            DataTable dt_ret = SELECT_WEEKLY_PLAN_MONTH(factory);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PlanMonth, 0, 0, false, COM.ComVar.ComboList_Visible.Code);


            if (_PlanMonth != null && !_PlanMonth.Trim().Equals(""))
            {
                cmb_PlanMonth.SelectedValue = _PlanMonth;
                _PlanMonth = "";
            }
            else
            {

                if (dt_ret.Rows.Count > 0)
                {
                    cmb_PlanMonth.SelectedIndex = 0;
                }
                else
                {
                    cmb_PlanMonth.SelectedIndex = -1;
                }

            }



            dt_ret.Dispose();




        }


        /// <summary>
        /// Event_cmb_PlanMonth_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_PlanMonth_SelectedValueChanged()
        {

            if (cmb_PlanMonth.SelectedIndex == -1) return;


            Event_Tbtn_New();


            // plan_week 설정
            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");


            DataTable dt_ret = SELECT_WEEKLY_PLAN_WEEK(factory, plan_month);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PlanWeek, 0, 1, false, COM.ComVar.ComboList_Visible.Name);


            if (_PlanWeek != null && !_PlanWeek.Trim().Equals(""))
            {
                cmb_PlanWeek.SelectedValue = _PlanWeek;
                _PlanWeek = "";
            }
            else
            {

                if (dt_ret.Rows.Count > 0)
                {
                    cmb_PlanWeek.SelectedIndex = 0;
                }
                else
                {
                    cmb_PlanWeek.SelectedIndex = -1;
                }

            }



            dt_ret.Dispose();




        }



        /// <summary>
        /// Event_cmb_PlanWeek_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_PlanWeek_SelectedValueChanged()
        {

            if (cmb_PlanWeek.SelectedIndex == -1) return;


            Event_Tbtn_New();




            // line_group
            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string plan_month = ClassLib.ComFunction.Empty_Combo(cmb_PlanMonth, " ").Replace("-", "");
            string plan_week = ClassLib.ComFunction.Empty_Combo(cmb_PlanWeek, " ");
            string out_type = "";
            
            DataTable dt_ret = SELECT_WEEKLY_FACTORY_GROUP(factory, plan_month, plan_week, out_type);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineGroup, 0, 0, true, COM.ComVar.ComboList_Visible.Name);


            if (_LineGroup != null && !_LineGroup.Trim().Equals(""))
            {
                cmb_LineGroup.SelectedValue = _LineGroup;
                _LineGroup = "";
            }
            else
            {

                if (dt_ret.Rows.Count > 0)
                {
                    cmb_LineGroup.SelectedIndex = 0;
                }
                else
                {
                    cmb_LineGroup.SelectedIndex = -1;
                }

            }



            dt_ret.Dispose();


        }


        

        /// <summary>
        /// Event_cmb_LineGroup_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_LineGroup_SelectedValueChanged()
        {


            cmb_Line.SelectedIndex = -1;
            fgrid_Main.ClearAll();
            

            if (cmb_LineGroup.SelectedIndex == -1) return;


            // line
            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string plan_month = ClassLib.ComFunction.Empty_Combo(cmb_PlanMonth, " ").Replace("-", "");
            string plan_week = ClassLib.ComFunction.Empty_Combo(cmb_PlanWeek, " ");
            string out_type = "";
            string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");


            DataTable dt_ret = SELECT_WEEKLY_LINE(factory, plan_month, plan_week, out_type, line_group);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 0, true, COM.ComVar.ComboList_Visible.Name);


            if (_LineCd != null && !_LineCd.Trim().Equals(""))
            {
                cmb_Line.SelectedValue = _LineCd;
                _LineCd = "";
            }
            else
            {

                if (dt_ret.Rows.Count > 0)
                {
                    cmb_Line.SelectedIndex = 0;
                }
                else
                {
                    cmb_Line.SelectedIndex = -1;
                }

            }


            dt_ret.Dispose();

          

        }



        /// <summary>
        /// Event_cmb_Line_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Line_SelectedValueChanged()
        {


            fgrid_Main.ClearAll();

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
                //this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
                Event_Tbtn_Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



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


        private void Form_EIS_Weekly_Price_Others_Load(object sender, EventArgs e)
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

                Event_cmb_PlanMonth_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanMonth_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_PlanWeek_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_PlanWeek_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanWeek_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_LineGroup_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_LineGroup_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_LineGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_Line_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Line_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Line_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// SELECT_WEEKLY_PLAN_MONTH : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_PLAN_MONTH(string arg_factory)
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_PLAN_MONTH";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
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
        
 

        /// <summary>
        /// SELECT_WEEKLY_FACTORY_GROUP : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_out_type"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_FACTORY_GROUP(string arg_factory,
            string arg_plan_month,
            string arg_plan_week,
            string arg_out_type)
        {

            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_FACTORY_GROUP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_plan_week;
                MyOraDB.Parameter_Values[3] = arg_out_type;
                MyOraDB.Parameter_Values[4] = "";


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
        /// SELECT_WEEKLY_LINE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_out_type"></param>
        /// <param name="arg_line_group"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_LINE(string arg_factory,
            string arg_plan_month,
            string arg_plan_week,
            string arg_out_type,
            string arg_line_group)
        {

            try
            {

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_LINE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_plan_week;
                MyOraDB.Parameter_Values[3] = arg_out_type;
                MyOraDB.Parameter_Values[4] = arg_line_group;
                MyOraDB.Parameter_Values[5] = "";


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
        /// SELECT_WEEKLY_STYLE_CD : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_out_type"></param>
        /// <param name="arg_line_group"></param>
        /// <param name="arg_line_cd"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_STYLE_CD(string arg_factory,
            string arg_plan_month,
            string arg_plan_week,
            string arg_out_type,
            string arg_line_group,
            string arg_line_cd,
            string arg_style_cd)
        {

            try
            {


                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_STYLE_CD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_plan_week;
                MyOraDB.Parameter_Values[3] = arg_out_type;
                MyOraDB.Parameter_Values[4] = arg_line_group;
                MyOraDB.Parameter_Values[5] = arg_line_cd;
                MyOraDB.Parameter_Values[6] = arg_style_cd;
                MyOraDB.Parameter_Values[7] = "";


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
        /// SELECT_WEEKLY_DIVISION_OTHERS : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_line_group"></param>
        /// <param name="arg_line_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_DIVISION_OTHERS(string arg_factory,
            string arg_plan_month,
            string arg_plan_week,
            string arg_line_group,
            string arg_line_cd)
        {

            try
            {
                 

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_DIVISION_OTHERS";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_plan_week;
                MyOraDB.Parameter_Values[3] = arg_line_group;
                MyOraDB.Parameter_Values[4] = arg_line_cd;
                MyOraDB.Parameter_Values[5] = "";




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




