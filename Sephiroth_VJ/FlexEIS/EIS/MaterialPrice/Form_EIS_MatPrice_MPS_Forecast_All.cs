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


namespace FlexEIS.EIS.MaterialPrice
{
    public partial class  Form_EIS_MatPrice_MPS_Forecast_All : COM.APSWinForm.Form_Top
    {


        #region 생성자


        private System.IO.MemoryStream _memoryStream;


        public  Form_EIS_MatPrice_MPS_Forecast_All()
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
                //this.Text = "차월 자재비 예측 - 표준 원가 비율";
                //lbl_MainTitle.Text = "차월 자재비 예측 - 표준 원가 비율";


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


            fgrid_Ratio.Set_Grid("EIS_MATPRICE_MPS_FORECAST_ALL", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Ratio.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Ratio.ExtendLastCol = false;
            fgrid_Ratio.AllowSorting = AllowSortingEnum.None;
            fgrid_Ratio.AllowDragging = AllowDraggingEnum.None;


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


            rad_Factory.Checked = true;



            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_FACTORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();


            //cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
            cmb_Factory.SelectedIndex = -1;





            // plan_month : 원가 마감 월 + 3
            dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_MONTH("", "N");

            if (dt_ret == null || dt_ret.Rows.Count == 0) return;

            string max_month = dt_ret.Rows[0].ItemArray[0].ToString() + "-01";

            for (int i = 1; i <= 3; i++)
            {
                DataRow dr = dt_ret.NewRow();
                dr[0] = Convert.ToDateTime(max_month).AddMonths(i).ToString("yyyy-MM");
                dt_ret.Rows.InsertAt(dr, 0);
            }


            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PlanMonth_From, 0, 0, false, COM.ComVar.ComboList_Visible.Code);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PlanMonth_To, 0, 0, false, COM.ComVar.ComboList_Visible.Code);


            cmb_PlanMonth_From.SelectedValue = System.DateTime.Now.ToString("yyyy-MM");



        }




        #endregion

        #region 조회


        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_dt_ret"></param>
        private void Display_Grid(DataTable arg_dt_ret)
        {

            fgrid_Ratio.Rows.Count = fgrid_Ratio.Rows.Fixed;


            for (int i = 0; i < arg_dt_ret.Rows.Count; i++)
            {

                fgrid_Ratio.Rows.Add();
                //fgrid_Ratio.Rows[fgrid_Ratio.Rows.Count - 1].Height = 20;


                for (int j = 0; j < arg_dt_ret.Columns.Count; j++)
                {


                    if (j == (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_DESC - 1)
                    {

                        if (arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_ORDER - 1].ToString() == "1")
                        {

                            if (ClassLib.ComVar.This_Lang == "KO")
                            {
                                fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = "정규오더 FT,PS";
                            }
                            else
                            {
                                fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = "Forecast FT,PS";
                            }

                        }
                        else if (arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_ORDER - 1].ToString() == "2")
                        {

                            if (ClassLib.ComVar.This_Lang == "KO")
                            {
                                fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = "비정규오더 CP,GTM,ID";
                            }
                            else
                            {
                                fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = "Forecast CP,GTM,ID";
                            }

                        }
                        else if (arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_ORDER - 1].ToString() == "3")
                        {

                            if (ClassLib.ComVar.This_Lang == "KO")
                            {
                                fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = "예측결과";
                            }
                            else
                            {
                                fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = "Forecast Result";
                            }

                        }


                    }
                    else
                    {
                        fgrid_Ratio[fgrid_Ratio.Rows.Count - 1, j + 1] = arg_dt_ret.Rows[i].ItemArray[j].ToString();
                    }


                } // end for j 

            } // end for i



            //---------------------------------------------------
            // subtotal
            //---------------------------------------------------
            fgrid_Ratio.Tree.Column = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDISPLAY_DESC;

            fgrid_Ratio.Subtotal(AggregateEnum.Clear);
            fgrid_Ratio.SubtotalPosition = SubtotalPositionEnum.AboveData;



            fgrid_Ratio.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
            fgrid_Ratio.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
            fgrid_Ratio.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
            fgrid_Ratio.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;

            // plan_ymd
            fgrid_Ratio.Subtotal(AggregateEnum.Max, 0, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxPLAN_YMD, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxPLAN_YMD, "{0}");
            // factory
            fgrid_Ratio.Subtotal(AggregateEnum.Max, 1, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxFACTORY, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxFACTORY, "{0}");
             
            //---------------------------------------------------


            // ratio
            CellStyle cellst_ratio = fgrid_Ratio.Styles.Add("NUMBER_RATIO");
            cellst_ratio.ForeColor = ClassLib.ComVar.ClrImportant;
            cellst_ratio.Font = new Font("Verdana", 8, FontStyle.Bold);


            for (int i = fgrid_Ratio.Rows.Fixed; i < fgrid_Ratio.Rows.Count; i++)
            {

                if (fgrid_Ratio[i, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_ORDER] == null
                    || fgrid_Ratio[i, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_ORDER].ToString().Trim() == ""
                    || fgrid_Ratio[i, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxDIV_ORDER].ToString() != "3")
                {
                    continue;
                }

                CellRange cr = fgrid_Ratio.GetCellRange(i, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_ALL.IxSTANDARD_RATIO);
                cr.Style = fgrid_Ratio.Styles["NUMBER_RATIO"];


            } // end for i





            fgrid_Ratio.Tree.Show(-1);
            rad_Factory.Checked = true;



        }





        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {

            fgrid_Ratio.ClearAll();

        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {


            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_PlanMonth_From, cmb_PlanMonth_To };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string plan_ymd_from = cmb_PlanMonth_From.SelectedValue.ToString().Replace("-", "");
            string plan_ymd_to = cmb_PlanMonth_To.SelectedValue.ToString().Replace("-", "");

            DataTable dt_ret = SELECT_MPS_FORECAST_TOTAL_ALL(factory, plan_ymd_from, plan_ymd_to);
            Display_Grid(dt_ret);

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

                fgrid_Ratio.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "차월 자재비 예측", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        }


        private void Event_cmb_PlanMonth_From_SelectedValueChange()
        {


            Event_Tbtn_New();

            cmb_PlanMonth_To.SelectedIndex = -1;


            if (cmb_PlanMonth_From.SelectedIndex == -1) return;


            cmb_PlanMonth_To.SelectedValue = cmb_PlanMonth_From.SelectedValue.ToString();



        }



        /// <summary>
        /// Event_cmb_Month_To_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_PlanMonth_To_SelectedValueChanged()
        {

            Event_Tbtn_New();

        }





        /// <summary>
        /// Event_rad_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_rad_CheckedChanged(object sender)
        {

            RadioButton src = sender as RadioButton;


            if (src == rad_Month)
            {

                fgrid_Ratio.Tree.Show(1);

            }
            else 
            {

                fgrid_Ratio.Tree.Show(-1);

            }

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


        private void  Form_EIS_MatPrice_MPS_Forecast_All_Load(object sender, EventArgs e)
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


        private void cmb_PlanMonth_From_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_PlanMonth_From_SelectedValueChange();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanMonth_From_SelectedValueChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void cmb_PlanMonth_To_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_PlanMonth_To_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanMonth_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }





        private void rad_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_rad_CheckedChanged(sender);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// SELECT_MPS_FORECAST_TOTAL_ALL : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_ymd_from"></param>
        /// <param name="arg_plan_ymd_to"></param>
        /// <returns></returns>
        private DataTable SELECT_MPS_FORECAST_TOTAL_ALL(string arg_factory, string arg_plan_ymd_from, string arg_plan_ymd_to)
        {

            try
            {


                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_TOTAL_ALL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_YMD_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_ymd_from;
                MyOraDB.Parameter_Values[2] = arg_plan_ymd_to;
                MyOraDB.Parameter_Values[3] = "";


                MyOraDB.Add_Select_Parameter(true);

                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
                

                if (ds_ret == null) return null;
                return ds_ret.Tables[0];


            }
            catch
            {
                return null;
            }


        }





        #endregion 

        private void lbl_Factory_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}

