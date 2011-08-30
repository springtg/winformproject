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
    public partial class  Form_EIS_Weekly_Price_Factory : COM.APSWinForm.Form_Top
    {


        #region 생성자


        private System.IO.MemoryStream _memoryStream;



        public  Form_EIS_Weekly_Price_Factory()
        {

            InitializeComponent();


            _memoryStream = new System.IO.MemoryStream();
            chart_Week.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);

            _memoryStream = new System.IO.MemoryStream();
            chart_ProdRatio.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);



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
                //this.Text = "주간 자재 분석";
                //lbl_MainTitle.Text = "주간 자재 분석";


                Init_Grid();

                Init_Control(); 
                
                Init_Chart_FX_Clear("");




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


            fgrid_Main.Set_Grid("EIS_MATPRICE_WEEKLY_DIV_FACTORY", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            //fgrid_Main.Font = new Font("Verdana", 7);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
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


            rad_FactoryGroup.Checked = true;


            txt_WarningDesc1_Green.Text = "3";
            txt_WarningDesc1_Yellow.Text = "-5";
            txt_WarningDesc1_Red.Text = "-5";

            txt_WarningDesc2.Text = "1";



            // batch 버튼 활성화
            if (ClassLib.ComVar._WebSvc.Url == ClassLib.ComVar.DS_WebSvc_Url)
            {
                btn_RunBatch.Visible = false;
            }
            else
            {

                if (ClassLib.ComVar.This_Admin_YN == "Y")
                {
                    btn_RunBatch.Visible = true;
                }
                else
                {
                    btn_RunBatch.Visible = false;
                }


            }




            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_FACTORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();



            //cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
            cmb_Factory.SelectedValue = ClassLib.ComFunction.Set_Default_Factory();



        }




        /// <summary>
        /// Display_LastUpdateDate : Last update 조회
        /// </summary>
        private void Display_LastUpdateDate()
        {


            string table_string = "EMI_WEEKLY_DIVISION";

            string where_string = "";


            if (cmb_Factory.SelectedIndex == -1)
            {
                where_string = "";
            }
            else
            {
                where_string = @"FACTORY = '" + cmb_Factory.SelectedValue.ToString() + @"'";
            }



            if (cmb_PlanMonth.SelectedIndex == -1)
            {
                where_string += "";
            }
            else
            {
                where_string += @" AND PLAN_MONTH = '" + cmb_PlanMonth.SelectedValue.ToString().Replace("-", "") + @"'";
            }


            lbl_LastUpdate2.Text = ClassLib.ComFunction.Display_LastUpdateDate(table_string, where_string);

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

                DataTable dt_ret = SELECT_WEEKLY_FACTORY(factory, plan_month);

                Display_Grid(dt_ret);
                
                dt_ret.Dispose();


                Init_Chart_FX("");
                




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


            //---------------------------------------------------
            // merge
            //---------------------------------------------------
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = false;
            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFACTORY; i <= (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_NAME; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = true;
            }

            //---------------------------------------------------



            Display_Grid_Subtotal();


        }



        /// <summary>
        /// Display_Grid_Subtotal : 
        /// </summary>
        private void Display_Grid_Subtotal()
        {


            #region subtotal



            //-----------------------------------------------------------------------------------------
            // subtotal
            //-----------------------------------------------------------------------------------------
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC;
            fgrid_Main.Subtotal(AggregateEnum.Clear);
            fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;


            fgrid_Main.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].Font = new Font("Verdana", 8, FontStyle.Bold);

            fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal2;
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].Font = new Font("Verdana", 8, FontStyle.Bold);

            fgrid_Main.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal3;
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Blue;
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].Format = "#,###";
            //fgrid_Main.Styles[CellStyleEnum.Subtotal2].Font = new Font("Verdana", 8, FontStyle.Bold);



            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_LINE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_PROD_RATIO) continue;


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT)
                {
                    //fgrid_Main.Subtotal(AggregateEnum.Max, 0, -1, i, "TOTAL");
                }
                else
                {
                    fgrid_Main.Subtotal(AggregateEnum.Sum, 0, -1, i, "TOTAL");
                }

            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_LINE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_PROD_RATIO) continue;



                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT)
                {
                    fgrid_Main.Subtotal(AggregateEnum.Max, 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC, i, "{0}");
                }
                else
                {
                    fgrid_Main.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC, i, "{0}");
                }


            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_LINE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_PROD_RATIO) continue;



                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT)
                {
                    fgrid_Main.Subtotal(AggregateEnum.Max, 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME, i, "{0}");
                }
                else
                {
                    fgrid_Main.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME, i, "{0}");
                }



            }

            //-----------------------------------------------------------------------------------------


            #endregion

            #region total ratio


            //-----------------------------------------------------------------------------------------
            // total ratio 계산
            //-----------------------------------------------------------------------------------------
            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO) continue;


                double adjust_amount = 0;
                double out_all_amount = 0;
                double out_others_all_amount = 0;
                double cal_amount = 0;
                string cal_ratio = "";



                for (int j = fgrid_Main.Rows.Fixed; j < fgrid_Main.Rows.Count; j++)
                {

                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK] != null) continue;



                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST] == null
                        || fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST].ToString().Trim() == "")
                    {
                        adjust_amount = 0;
                    }
                    else
                    {
                        adjust_amount = Convert.ToDouble(fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST].ToString());
                    }



                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL] == null
                        || fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL].ToString().Trim() == "")
                    {
                        out_all_amount = 0;
                    }
                    else
                    {
                        out_all_amount = Convert.ToDouble(fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL].ToString());
                    }



                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL] == null
                        || fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL].ToString().Trim() == "")
                    {
                        out_others_all_amount = 0;
                    }
                    else
                    {
                        out_others_all_amount = Convert.ToDouble(fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL].ToString());
                    }


                    


                    if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL_RATIO
                        || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE_RATIO
                        || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE_RATIO
                        || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER_RATIO)
                    {


                        int col = 0;


                        if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_NORMAL;
                        }
                        else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_DEFECTIVE;
                        }
                        else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OVERUSAGE;
                        }
                        else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHER;
                        }



                        if (fgrid_Main[j, col] == null || fgrid_Main[j, col].ToString().Trim() == "")
                        {
                            cal_amount = 0;
                        }
                        else
                        {
                            cal_amount = Convert.ToDouble(fgrid_Main[j, col].ToString());
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
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO)
                    {

                        cal_amount = adjust_amount - out_all_amount;

                        if (adjust_amount == 0)
                        {
                            cal_ratio = "0";
                        }
                        else
                        {
                            cal_ratio = Convert.ToString(Math.Round((cal_amount / adjust_amount) * 100, 2));
                        }


                    }
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO)
                    {

                        cal_amount = out_others_all_amount;

                        if (adjust_amount == 0)
                        {
                            cal_ratio = "0";
                        }
                        else
                        {
                            cal_ratio = Convert.ToString(Math.Round((cal_amount / adjust_amount) * 100, 2));
                        }


                    }


                    


                    fgrid_Main[j, i] = cal_ratio.ToString();




                } // end for j




            } // end for i
            //-----------------------------------------------------------------------------------------

            #endregion

            #region warning


            Event_btn_WarningRange_Click();


            #endregion

            #region prod total, ratio, forecast를 제외한 표준금액 재 계산 (ratio에 forecast 포함하지 않기 위함)


            // total, weekly 아니면 데이터 표시 안함
            // weekly 만 집계해서 total 표시 (prs_qty, sale_amount)

            double total_standard_amount = 0;
            double out_profit_ratio = 0;

            double total_prs_qty = 0;
            double total_sale_amount = 0;

            double sale_amount = 0;
            double amount_out_all = 0;
            double out_prod_ratio = 0;



            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {


                // forecast 이후는 모두 예측이므로 계산 종료
                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("Y"))
                {

                    //-----------------------------------------------------------------------------------
                    // forecast 일 경우 생산 예상 금액 대비 표준 금액으로 ratio 계산
                    //-----------------------------------------------------------------------------------
                    if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] == null
                           || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT].ToString().Trim().Equals(""))
                    {
                        sale_amount = 0;
                    }
                    else
                    {
                        sale_amount = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT].ToString());
                    }


                    if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST] == null
                       || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST].ToString().Trim().Equals(""))
                    {
                        amount_out_all = 0;
                    }
                    else
                    {
                        amount_out_all = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST].ToString());
                    }




                    if (sale_amount == 0)
                    {
                        out_prod_ratio = 0;
                    }
                    else
                    {
                        out_prod_ratio = Math.Round((amount_out_all / sale_amount) * 100, 2);
                    }


                    fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_PROD_RATIO] = out_prod_ratio.ToString();




                    // 생산 수량, 금액 Weekly 이하 표시하지 않음.
                    for (int a = i + 1; a < fgrid_Main.Rows.Count; a++)
                    {

                        fgrid_Main[a, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY] = "0";
                        fgrid_Main[a, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] = "0";

                    }



                    //-----------------------------------------------------------------------------------


                    break;
                }




                sale_amount = 0;
                amount_out_all = 0;
                out_prod_ratio = 0;



                if (fgrid_Main.Rows[i].IsNode)
                {

                    if (fgrid_Main.Rows[i].Node.Level == 1) // weekly
                    {



                        //-----------------------------------------------------------------------------------
                        // forecast를 제외한 표준금액 재 계산 (ratio에 forecast 포함하지 않기 위함)
                        //-----------------------------------------------------------------------------------

                        if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST] == null
                            || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST].ToString().Trim().Equals(""))
                        {
                            total_standard_amount += 0;
                        }
                        else
                        {
                            total_standard_amount += Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST].ToString());
                        }
                        //-----------------------------------------------------------------------------------


                        
                        //-----------------------------------------------------------------------------------
                        // total 위한 집계
                        //-----------------------------------------------------------------------------------

                        if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY] == null
                            || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY].ToString().Trim().Equals(""))
                        {
                            total_prs_qty += 0;
                        }
                        else
                        {
                            total_prs_qty += Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY].ToString());
                        }


                        if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] == null
                            || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT].ToString().Trim().Equals(""))
                        {
                            total_sale_amount += 0;
                        }
                        else
                        {
                            total_sale_amount += Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT].ToString());
                        }
                        //-----------------------------------------------------------------------------------


                        //-----------------------------------------------------------------------------------
                        // 주 별 견적원가 대비 출고 비율 계산
                        //-----------------------------------------------------------------------------------

                        if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] == null
                           || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT].ToString().Trim().Equals(""))
                        {
                            sale_amount = 0;
                        }
                        else
                        {
                            sale_amount = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT].ToString());
                        }


                        if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL] == null
                           || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL].ToString().Trim().Equals(""))
                        {
                            amount_out_all = 0;
                        }
                        else
                        {
                            amount_out_all = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL].ToString());
                        }




                        if (total_sale_amount == 0)
                        {
                            out_prod_ratio = 0;
                        }
                        else
                        {
                            out_prod_ratio = Math.Round((amount_out_all / sale_amount) * 100, 2);
                        }


                        fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_PROD_RATIO] = out_prod_ratio.ToString();
                        //-----------------------------------------------------------------------------------





                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 2) // factory group
                    {
                        fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY] = "0";
                        fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] = "0";
                    }

                }
                else  // line
                {

                    fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY] = "0";
                    fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] = "0";


                } // end if



                //-----------------------------------------------------------------------------------
                // Total 견적원가 대비 출고 비율 계산
                //-----------------------------------------------------------------------------------

                fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPRS_QTY] = total_prs_qty.ToString();
                fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxSALE_AMOUNT] = total_sale_amount.ToString();


                sale_amount = 0;
                amount_out_all = 0;
                out_prod_ratio = 0;
                

                sale_amount = total_sale_amount;


                if (fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL] == null
                   || fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL].ToString().Trim().Equals(""))
                {
                    amount_out_all = 0;
                }
                else
                {
                    amount_out_all = Convert.ToDouble(fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL].ToString());
                }




                if (total_sale_amount == 0)
                {
                    out_prod_ratio = 0;
                }
                else
                {
                    out_prod_ratio = Math.Round((amount_out_all / sale_amount) * 100, 2);
                }


                fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_ALL_PROD_RATIO] = out_prod_ratio.ToString();
                //-----------------------------------------------------------------------------------


                //-----------------------------------------------------------------------------------
                // forecast를 제외한 표준금액, 비율 재 계산 (ratio에 forecast 포함하지 않기 위함)
                //-----------------------------------------------------------------------------------

                if (total_standard_amount == 0)
                {
                    out_profit_ratio = 0;
                }
                else
                {
                    out_profit_ratio = Math.Round(((total_standard_amount - amount_out_all) / total_standard_amount) * 100, 2);
                }



                fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_ADJUST] = total_standard_amount.ToString();
                fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO] = out_profit_ratio.ToString();
                //-----------------------------------------------------------------------------------



            } // end for i





            #endregion

            #region etc


            //-----------------------------------------------------------------------------------------
            // view tree level
            //-----------------------------------------------------------------------------------------
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {

                fgrid_Main.Rows[i].Node.Collapsed = true;

            } // end for i



            fgrid_Main.Tree.Show(2);
            rad_FactoryGroup.Checked = true;
            //-----------------------------------------------------------------------------------------


            #endregion



        }






        #region chart fx


        private void Init_Chart_FX(string arg_line_group)
        {


            Init_Chart_FX_Clear(arg_line_group);

            Init_Chart_FX_Style(arg_line_group);

            Init_Chart_FX_Data(arg_line_group);



        }

        private void Init_Chart_FX_Clear(string arg_line_group)
        {


            if (arg_line_group == "")
            {

                _memoryStream.Position = 0;
                chart_Week.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
                chart_Week.Data.Clear();

            }
            


            _memoryStream.Position = 0;
            chart_ProdRatio.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_ProdRatio.Data.Clear();


            chart_Week.UseWaitCursor = false;
            chart_ProdRatio.UseWaitCursor = false;


        }

        private void Init_Chart_FX_Style(string arg_line_group)
        {



            string plan_month = cmb_PlanMonth.SelectedValue.ToString();
            string plan_month_last = Convert.ToDateTime(cmb_PlanMonth.SelectedValue.ToString() + "-01").AddMonths(-1).ToString("yyyy-MM");

            if (arg_line_group == "")
            {

                #region Init_Char_FX_Style(chart_Week);


                Init_Char_FX_Style(chart_Week);



                ChartFX.WinForms.TitleDockable title = new ChartFX.WinForms.TitleDockable();

                if (ClassLib.ComVar.This_Lang == "KO")
                {
                    title.Text = "표준, 출고 금액 : " + plan_month;
                }
                else
                {
                    title.Text = "Standard, outgoing amount : " + plan_month;
                }

                title.Dock = ChartFX.WinForms.DockArea.Top;
                title.Alignment = StringAlignment.Near;
                title.Font = new Font("Verdana", 8, FontStyle.Bold);
                chart_Week.Titles.Add(title);


                chart_Week.AxisY.Title.Text = "1,000 $";
                chart_Week.AxisY.DataFormat.CustomFormat = "#,###";
                chart_Week.AxisY.LabelsFormat.Format = ChartFX.WinForms.AxisFormat.Number;
                //chart_Week.AxisY.LabelAngle = 15;
                //chart_Week.AllSeries.PointLabels.Angle = 5;


                chart_Week.Data.Series = 2;
                chart_Week.Series[0].Color = Color.FromArgb(75, 190, 208);
                chart_Week.Series[1].Color = Color.FromArgb(130, 220, 49);


                //chart_Week.Gallery = ChartFX.WinForms.Gallery.Bar;
                //chart_Week.AllSeries.BarShape = ChartFX.WinForms.BarShape.Cylinder;
                //chart_Week.AllSeries.Stacked = ChartFX.WinForms.Stacked.No;



                #endregion

            }


            #region Init_Char_FX_Style(chart_ProdRatio);


            Init_Char_FX_Style(chart_ProdRatio);


            if (arg_line_group == "")
            {

                //-----------------------------------------------------------------------------------------
                // chart title1
                //-----------------------------------------------------------------------------------------
                ChartFX.WinForms.TitleDockable title1 = new ChartFX.WinForms.TitleDockable();

                if (ClassLib.ComVar.This_Lang == "KO")
                {
                    title1.Text = "생산 대비 출고 비율 : " + plan_month_last + " ~ " + plan_month;
                }
                else
                {
                    title1.Text = "Production vs outgoing ratio : " + plan_month_last + " ~ " + plan_month;
                }

                title1.Dock = ChartFX.WinForms.DockArea.Top;
                title1.Alignment = StringAlignment.Near;
                title1.Font = new Font("Verdana", 8, FontStyle.Bold);
                chart_ProdRatio.Titles.Add(title1);
                //-----------------------------------------------------------------------------------------



                //-----------------------------------------------------------------------------------------
                // chart title2
                //-----------------------------------------------------------------------------------------
                ChartFX.WinForms.TitleDockable title2 = new ChartFX.WinForms.TitleDockable();

                if (ClassLib.ComVar.This_Lang == "KO")
                {
                    title2.Text = "파란색 : 이전 월, 검정색 : 현재 월";
                }
                else
                {
                    title2.Text = "Blue color : last month, Black color : current month";
                }

                title2.Dock = ChartFX.WinForms.DockArea.Bottom;
                title2.Alignment = StringAlignment.Near;
                chart_ProdRatio.Titles.Add(title2);
                //-----------------------------------------------------------------------------------------




                chart_ProdRatio.AxisY.Title.Text = "%";
                chart_ProdRatio.AxisY.DataFormat.CustomFormat = "#,##0.##";

                chart_ProdRatio.AxisY2.Visible = true;
                chart_ProdRatio.AxisY2.Title.Text = "Production qty.";
                chart_ProdRatio.AxisY2.DataFormat.CustomFormat = "#,###";



                chart_ProdRatio.Data.Series = 2;

                chart_ProdRatio.Series[0].Color = Color.Tomato;
                chart_ProdRatio.Series[1].Color = Color.WhiteSmoke;

                chart_ProdRatio.Series[0].Gallery = ChartFX.WinForms.Gallery.Curve;
                chart_ProdRatio.Series[1].Gallery = ChartFX.WinForms.Gallery.Bar;
                chart_ProdRatio.Series[1].BarShape = ChartFX.WinForms.BarShape.Rectangle;
                chart_ProdRatio.Series[1].AxisY = chart_ProdRatio.AxisY2;




                // 생산 수량 표시 하지 않음
                chart_ProdRatio.AxisY2.Visible = false;
                chart_ProdRatio.Series[1].Visible = false;

            }
            else
            {

                //-----------------------------------------------------------------------------------------
                // chart title3
                //-----------------------------------------------------------------------------------------
                ChartFX.WinForms.TitleDockable title3 = new ChartFX.WinForms.TitleDockable();

                if (ClassLib.ComVar.This_Lang == "KO")
                {
                    title3.Text = "표준 대비 출고 이익 비율 [" + arg_line_group + "] : " + plan_month_last + " ~ " + plan_month;
                }
                else
                {
                    title3.Text = "Standard vs outgoing profit ratio : " + plan_month_last + " ~ " + plan_month;
                }

                title3.Dock = ChartFX.WinForms.DockArea.Top;
                title3.Alignment = StringAlignment.Near;
                title3.Font = new Font("Verdana", 8, FontStyle.Bold);
                chart_ProdRatio.Titles.Add(title3);
                //-----------------------------------------------------------------------------------------


                chart_ProdRatio.AxisY.Title.Text = "%";
                chart_ProdRatio.AxisY.DataFormat.CustomFormat = "#,##0.##";


                chart_ProdRatio.Data.Series = 1;

                chart_ProdRatio.Series[0].Color = Color.FromArgb(255, 200, 0);

                //arg_chart.Series[0].Color = Color.FromArgb(255, 200, 0);
                //arg_chart.Series[1].Color = Color.FromArgb(0, 160, 196);


            }



            #endregion



        }

        private void Init_Char_FX_Style(ChartFX.WinForms.Chart arg_chart)
        {

            arg_chart.Border = new ChartFX.WinForms.Adornments.SimpleBorder(ChartFX.WinForms.Adornments.SimpleBorderType.None);
            arg_chart.Background = new ChartFX.WinForms.Adornments.SolidBackground(Color.White);


            arg_chart.Font = new Font("Verdana", 8);
            arg_chart.Gallery = ChartFX.WinForms.Gallery.Lines;
            arg_chart.AllSeries.Gallery = ChartFX.WinForms.Gallery.Curve;


            //arg_chart.Gallery = ChartFX.WinForms.Gallery.Bar;
            //arg_chart.AllSeries.BarShape = ChartFX.WinForms.BarShape.Cylinder;
            //arg_chart.AllSeries.Stacked = ChartFX.WinForms.Stacked.No;



            arg_chart.AllSeries.PointLabels.Visible = true;
            arg_chart.AllSeries.PointLabels.Font = new Font("Verdana", 8);
            arg_chart.AllSeries.PointLabels.TextColor = Color.Black;


            arg_chart.LegendBox.Visible = true;
            arg_chart.LegendBox.ContentLayout = ChartFX.WinForms.ContentLayout.Near;
            arg_chart.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            arg_chart.LegendBox.Font = new Font("Verdana", 8);



            arg_chart.UseWaitCursor = false;


        }

        // 이전달 weekly 수 : 생산 실적 대비 출고 비율 표시할 때, 이전달 range 표시하기 위함
        private int _Count_Plan_Month_Last_Weekly = 0;

        private void Init_Chart_FX_Data(string arg_line_group)
        {




            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");


            DataTable dt_ret = SELECT_WEEKLY_FACTORY_CHART(factory, plan_month, ((arg_line_group == "") ? "-1" : arg_line_group));



            // 쿼리에서 이전달, 현재달 모두 나오므로, 현재달만 걸러냄
            string condition = @"PLAN_MONTH = '" + plan_month + @"'";
            DataRow[] findrow = dt_ret.Select(condition);


            DataTable dt_ret_amount = dt_ret.Clone();



            if (findrow.Length > 0)
            {

                for (int i = 0; i < findrow.Length; i++)
                {

                    DataRow newrow = dt_ret_amount.NewRow();

                    for (int j = 0; j < dt_ret.Columns.Count; j++)
                    {

                        if (findrow[i].ItemArray[j] != null && findrow[i].ItemArray[j].ToString() != "")
                        {
                            newrow[j] = findrow[i].ItemArray[j].ToString();
                        }
                        else
                        {
                            newrow[j] = 0;
                        }

                    } // end for j

                    dt_ret_amount.Rows.Add(newrow);

                } // end for i


            } // end if(findrow)




            // 이전달 weekly 수 : 생산 실적 대비 출고 비율 표시할 때, 이전달 range 표시하기 위함
            _Count_Plan_Month_Last_Weekly = dt_ret.Rows.Count - dt_ret_amount.Rows.Count;



            if (arg_line_group == "")
            {
                Init_Chart_FX_Data(chart_Week, dt_ret_amount, arg_line_group);
            }

            Init_Chart_FX_Data(chart_ProdRatio, dt_ret, arg_line_group);


            dt_ret_amount.Dispose();
            dt_ret.Dispose();



        }

        private void Init_Chart_FX_Data(ChartFX.WinForms.Chart arg_chart, DataTable arg_dt, string arg_line_group)
        {


            if (arg_dt == null || arg_dt.Rows.Count == 0) return;



            //arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("PLAN_WEEK", ChartFX.WinForms.FieldUsage.XValue));
            arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("LABEL_DESC_1", ChartFX.WinForms.FieldUsage.Label));



            if (arg_chart == chart_Week)
            {

                arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("AMOUNT_STANDARD", ChartFX.WinForms.FieldUsage.Value));
                arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("AMOUNT_OUT", ChartFX.WinForms.FieldUsage.Value));
            
            }
            else if (arg_chart == chart_ProdRatio)
            {


                if (arg_line_group == "")
                {

                    arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("AMOUNT_OUT_PROD_RATIO", ChartFX.WinForms.FieldUsage.Value));
                    arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("PRS_QTY", ChartFX.WinForms.FieldUsage.Value));

                }
                else
                {

                    arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("AMOUNT_OUT_PROFIT_RATIO", ChartFX.WinForms.FieldUsage.Value));

                }




            }

           
            arg_chart.DataSource = arg_dt;


            Init_Chart_FX_Data_LegendBox(arg_chart, arg_dt, arg_line_group);



        }

        private void Init_Chart_FX_Data_LegendBox(ChartFX.WinForms.Chart arg_chart, DataTable arg_dt, string arg_line_group)
        {



            if (arg_chart == chart_Week)
            {

                if (ClassLib.ComVar.This_Lang == "KO")
                {
                    arg_chart.Series[0].Text = "표준 금액";
                    arg_chart.Series[1].Text = "출고 금액";
                }
                else
                {
                    arg_chart.Series[0].Text = "Standard amount";
                    arg_chart.Series[1].Text = "Outgoing amount";
                }



            }
            else if (arg_chart == chart_ProdRatio)
            {


                if (arg_line_group == "")
                {

                    if (ClassLib.ComVar.This_Lang == "KO")
                    {
                        arg_chart.Series[0].Text = "생산 대비 출고 비율";
                        arg_chart.Series[1].Text = "생산 수량";
                    }
                    else
                    {
                        arg_chart.Series[0].Text = "Production vs outgoing ratio";
                        arg_chart.Series[1].Text = "Production Qty.";
                    }

                }
                else
                {

                    if (ClassLib.ComVar.This_Lang == "KO")
                    {
                        arg_chart.Series[0].Text = "표준 대비 이익 비율";
                    }
                    else
                    {
                        arg_chart.Series[0].Text = "Standard vs outgoing profit ratio";
                    }


                }



                ChartFX.WinForms.AxisSection section = new ChartFX.WinForms.AxisSection();
                arg_chart.AxisX.Sections.Add(section);
                section.BackColor = Color.WhiteSmoke;
                section.TextColor = Color.Blue;
                section.From = 0;
                section.To = _Count_Plan_Month_Last_Weekly + 0.5;

                
            }

           



        }





        #endregion






        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {


            fgrid_Main.ClearAll();

            Init_Chart_FX_Clear("");


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


            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;


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

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "주간별 원가 분석", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }



        #endregion

        #region 그리드 이벤트 메서드



        private void Event_fgrid_Main_Click()
        {


            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


            string line_group = "";


            if (fgrid_Main.Rows[fgrid_Main.Row].IsNode)
            {

                if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 2)  // factory group
                {
                    line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString();
                }
                else
                {
                    line_group = "";
                }

            }
            else
            {
                line_group = "";
            }


            Init_Chart_FX(line_group);


        }



        private void Event_fgrid_Main_DoubleClick()
        {


            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;
            
        

            string factory = "";
            string plan_month = "";
            string plan_week = "";
            string line_group = "";
            string line_cd = "";
            string forecast_yn = "";



            //if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME] != null)
            //{

            //    factory = cmb_Factory.SelectedValue.ToString();
            //    plan_month = cmb_PlanMonth.SelectedValue.ToString();
            //    plan_week = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK].ToString();
            //    line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME].ToString();
            //    line_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_NAME].ToString();

            //}
            //else
            //{


            //    if (fgrid_Main[fgrid_Main.Row + 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK] != null)
            //    {

            //        factory = cmb_Factory.SelectedValue.ToString();
            //        plan_month = cmb_PlanMonth.SelectedValue.ToString();
            //        plan_week = fgrid_Main[fgrid_Main.Row + 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK].ToString();
            //        line_group = fgrid_Main[fgrid_Main.Row + 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME].ToString();
            //        line_cd = "";

            //    }

            //}


            if (fgrid_Main.Rows[fgrid_Main.Row].IsNode)
            {


                if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 0)  // total
                {

                    factory = cmb_Factory.SelectedValue.ToString();
                    plan_month = cmb_PlanMonth.SelectedValue.ToString();
                    plan_week = "";
                    line_group = "";
                    line_cd = "";

                }
                else if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 1)  // week
                {

                    factory = cmb_Factory.SelectedValue.ToString();
                    plan_month = cmb_PlanMonth.SelectedValue.ToString();
                    plan_week = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString().Substring(0, 1);
                    line_group = "";
                    line_cd = "";

                }
                else if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 2)  // factory group
                {

                    factory = cmb_Factory.SelectedValue.ToString();
                    plan_month = cmb_PlanMonth.SelectedValue.ToString();
                    plan_week = fgrid_Main[fgrid_Main.Rows[fgrid_Main.Row].Node.GetNode(NodeTypeEnum.Parent).Row.Index, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString().Substring(0, 1);
                    line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString();
                    line_cd = "";
                }


            }
            else
            {

                factory = cmb_Factory.SelectedValue.ToString();
                plan_month = cmb_PlanMonth.SelectedValue.ToString();
                plan_week = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK].ToString();
                line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME].ToString();
                line_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_NAME].ToString();
            }




            EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Style pop_form = new EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Style(factory, plan_month, plan_week, line_group, line_cd);
            ClassLib.ComFunction.OpenFormByName(pop_form.GetType().FullName.ToString());





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


            Event_Tbtn_Search();




            string factory = cmb_Factory.SelectedValue.ToString();


            // plan_month 설정
            DataTable dt_ret = SELECT_WEEKLY_PLAN_MONTH(factory);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PlanMonth, 0, 0, false, COM.ComVar.ComboList_Visible.Code);


            if (dt_ret.Rows.Count > 0)
            {
                cmb_PlanMonth.SelectedIndex = 0;
            }
            else
            {
                cmb_PlanMonth.SelectedIndex = -1;
            }

            dt_ret.Dispose();




        }


        /// <summary>
        /// Event_cmb_PlanMonth_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_PlanMonth_SelectedValueChanged()
        {

            Event_Tbtn_New();


            if (cmb_PlanMonth.SelectedIndex == -1) return;



            // Last update 조회
            Display_LastUpdateDate();


            Event_Tbtn_Search();

            

        }



        /// <summary>
        /// Event_rad_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_rad_CheckedChanged(object sender)
        {


            RadioButton src = sender as RadioButton;


            if (src == rad_Week)
            {

                fgrid_Main.Tree.Show(1);

            }
            else if (src == rad_FactoryGroup)
            {

                fgrid_Main.Tree.Show(2);

            }
            else if (src == rad_Line)
            {

                fgrid_Main.Tree.Show(-1);

            }



        }



        /// <summary>
        /// Event_btn_WarningRange_Click : 
        /// </summary>
        private void Event_btn_WarningRange_Click()
        {


            // 1. 표준 대비 출고 이익 비율
            Display_Warning_Profit_Ratio();

            // 2. 기타 전체 출고 이익 비율
            Display_Warning_Others_Ratio();


           
        }


        
        /// <summary>
        /// Display_Warning_Profit_Ratio : 
        /// </summary>
        private void Display_Warning_Profit_Ratio()
        {

            Color color_default = Color.Empty;
            Color color_warning_red = Color.FromArgb(255, 85, 85);
            Color color_warning_yellow = Color.FromArgb(255, 255, 77);
            Color color_warning_green = Color.FromArgb(173, 255, 47);



            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {



                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("Y"))
                {


                


                    // 해당 Row 글자색 변경
                    CellStyle cellst_forecast = fgrid_Main.Styles.Add("FORECAST" + i.ToString());
                    cellst_forecast.ForeColor = Color.Gray;
                    cellst_forecast.BackColor = Color.Empty;

                    // i - 2 : 상위 subtotal row 없앨 기준이 없기 때문에 임의 처리
                    CellRange cr_forecast = fgrid_Main.GetCellRange(i - 2, 1, i, fgrid_Main.Cols.Count - 1);
                    cr_forecast.Style = fgrid_Main.Styles["FORECAST" + i.ToString()];


                    // subtotal row 없앨 기준이 없기 때문에 임의 처리
                    // SUBTOTAL ROW 이기 때문에 DEFAULT : 0.0, ToString() : 0
                    if (fgrid_Main[i - 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN] == null
                        || fgrid_Main[i - 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("")
                        || fgrid_Main[i - 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("0"))
                    {
                        fgrid_Main[i - 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN] = "Y";
                    }

                    if (fgrid_Main[i - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN] == null
                        || fgrid_Main[i - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("")
                        || fgrid_Main[i - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("0"))
                    {
                        fgrid_Main[i - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN] = "Y";
                    }





                    // 표준 대비 이익 비율 0 표시
                    fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO] = "0";
                    fgrid_Main[i - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO] = "0";
                    fgrid_Main[i - 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO] = "0";




                    continue;


                }






                double out_profit_ratio = 0;



                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO] == null
                    || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO].ToString().Trim().Equals(""))
                {
                    out_profit_ratio = 0;
                }
                else
                {
                    out_profit_ratio = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO].ToString());
                }




                CellRange cr = fgrid_Main.GetCellRange(i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_PROFIT_RATIO);

                CellStyle cellst = fgrid_Main.Styles.Add("WARNING_PROFIT_RATIO" + i.ToString());



                if (fgrid_Main.Rows[i].IsNode)
                {

                    if (fgrid_Main.Rows[i].Node.Level == 0) // total
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal0;
                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 1) // weekly
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal2;
                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 2) // factory group
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal3;
                    }

                }
                else  // line
                {

                    color_default = Color.Empty;

                } // end if




                if (txt_WarningDesc1_Green.Text.Trim().Equals("") || txt_WarningDesc1_Yellow.Text.Trim().Equals("") || txt_WarningDesc1_Red.Text.Trim().Equals(""))
                {
                    cellst.BackColor = color_default;
                }
                else
                {


                    cellst.BackColor = color_default;


                    if (out_profit_ratio <= Convert.ToDouble(txt_WarningDesc1_Red.Text.Trim()))
                    {

                        cellst.BackColor = color_warning_red;

                    }


                    if (out_profit_ratio >= Convert.ToDouble(txt_WarningDesc1_Yellow.Text.Trim()))
                    {

                        cellst.BackColor = color_warning_yellow;

                    }


                    if (out_profit_ratio >= Convert.ToDouble(txt_WarningDesc1_Green.Text.Trim()))
                    {

                        cellst.BackColor = color_warning_green;

                    }





                } // end if


                cr.Style = fgrid_Main.Styles["WARNING_PROFIT_RATIO" + i.ToString()];


            } // end for i



        }



        /// <summary>
        /// Display_Warning_Others_Ratio : 
        /// </summary>
        private void Display_Warning_Others_Ratio()
        {



            Color color_default = Color.Empty;
            Color color_warning = Color.FromArgb(177, 162, 255);
            


            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {



                //// 차주 예측일 경우 표시 하지 않음
                //if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN].ToString().Trim().Equals("Y"))
                //{

                //    // 해당 Row 글자색 변경
                //    CellStyle cellst_forecast = fgrid_Main.Styles.Add("FORECAST" + i.ToString());
                //    cellst_forecast.ForeColor = Color.Gray;
                //    cellst_forecast.BackColor = Color.Empty;

                //    // i - 2 : 상위 subtotal row 없앨 기준이 없기 때문에 임의 처리
                //    CellRange cr_forecast = fgrid_Main.GetCellRange(i - 2, 1, i, fgrid_Main.Cols.Count - 1);
                //    cr_forecast.Style = fgrid_Main.Styles["FORECAST" + i.ToString()];

                //    continue;


                //}






                double out_others_all_ratio = 0;



                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO] == null
                    || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO].ToString().Trim().Equals(""))
                {
                    out_others_all_ratio = 0;
                }
                else
                {
                    out_others_all_ratio = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO].ToString());
                }




                CellRange cr = fgrid_Main.GetCellRange(i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxAMOUNT_OUT_OTHERS_ALL_RATIO);

                CellStyle cellst = fgrid_Main.Styles.Add("WARNING_OTHERS_RATIO" + i.ToString());



                if (fgrid_Main.Rows[i].IsNode)
                {

                    if (fgrid_Main.Rows[i].Node.Level == 0) // total
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal0;
                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 1) // weekly
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal2;
                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 2) // factory group
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal3;
                    }

                }
                else  // line
                {

                    color_default = Color.Empty;

                } // end if




                if (txt_WarningDesc2.Text.Trim().Equals(""))
                {
                    cellst.BackColor = color_default;
                }
                else
                {

                    if (out_others_all_ratio >= Convert.ToDouble(txt_WarningDesc2.Text.Trim()))
                    {

                        cellst.BackColor = color_warning;

                    }
                    else
                    {

                        cellst.BackColor = color_default;

                    }

                } // end if


                cr.Style = fgrid_Main.Styles["WARNING_OTHERS_RATIO" + i.ToString()];


            } // end for i






        }



        #region Event_btn_RunBatch_Click() : 마지막 주차만 재 실행 가능


        ///// <summary>
        ///// Event_btn_RunBatch_Click : 
        ///// </summary>
        //private void Event_btn_RunBatch_Click()
        //{


        //    // forecast 데이터도 있기 때문에, 마지막 주차만 재 실행 가능으로 설정

        //    DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);

        //    if (result == DialogResult.No) return;




        //    _popWait = new EIS.Common.Pop_Wait_UsingThread();
        //    temp_thread = new Thread(new ThreadStart(_popWait.Start));

        //    if (temp_thread != null)
        //    {
        //        temp_thread.Start();
        //        Run();
        //    }


        //}



        ///// <summary>
        ///// Run : 
        ///// </summary>
        //private void Run()
        //{


        //    try
        //    {




        //        // 필수조건 체크 
        //        C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
        //        System.Windows.Forms.TextBox[] txt_array = { };
        //        bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
        //        if (!previous_check) return;

        //        string this_factory = ClassLib.ComVar.This_Factory;
        //        string factory = cmb_Factory.SelectedValue.ToString();
        //        string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
        //        string upd_user = ClassLib.ComVar.This_User;



        //        int find_row_forecast = fgrid_Main.FindRow("Y", fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxFORECAST_YN, false, true, false);

        //        string plan_week = "";

        //        if (find_row_forecast == -1) // forecast 없는 마지막 주차
        //        {

        //            plan_week = fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK].ToString().Trim();

        //        }
        //        else
        //        {

        //            plan_week = fgrid_Main[find_row_forecast - 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK].ToString().Trim();

        //        }



        //        bool run_flag = RUN_EMM_WEEKLY_DETAIL(this_factory, factory, plan_month, plan_week, upd_user);


        //        if (run_flag)
        //        {

        //            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);



        //            // Last update 조회
        //            Display_LastUpdateDate();


        //            Event_Tbtn_Search();

        //        }
        //        else
        //        {
        //            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Run", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (temp_thread != null) temp_thread.Abort();
        //    }



        //}






        #endregion


        /// <summary>
        /// Event_btn_RunBatch_Click : 
        /// </summary>
        private void Event_btn_RunBatch_Click()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_month = cmb_PlanMonth.SelectedValue.ToString();


            EIS.MaterialPriceWeekly.Pop_EIS_Weekly_Run_Again pop_form = new EIS.MaterialPriceWeekly.Pop_EIS_Weekly_Run_Again(factory, plan_month);
            pop_form.ShowDialog();



            if (pop_form._Apply_Flag)
            {


                // Last update 조회
                Display_LastUpdateDate();


                Event_Tbtn_Search();


            }




        }





        #region 컨텍스트 메뉴 이벤트 메서드

      


        #endregion



        #endregion 

        #region 컨텍스트 메뉴 이벤트 메서드


        /// <summary>
        /// Event_menuItem_OthersItemAnalysis_Click : 
        /// </summary>
        private void Event_menuItem_OthersItemAnalysis_Click()
        {


            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;



            string factory = "";
            string plan_month = "";
            string plan_week = "";
            string line_group = "";
            string line_cd = "";



            if (fgrid_Main.Rows[fgrid_Main.Row].IsNode)
            {


                if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 0)  // total
                {

                    factory = cmb_Factory.SelectedValue.ToString();
                    plan_month = cmb_PlanMonth.SelectedValue.ToString();
                    plan_week = "";
                    line_group = "";
                    line_cd = "";

                }
                else if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 1)  // week
                {

                    factory = cmb_Factory.SelectedValue.ToString();
                    plan_month = cmb_PlanMonth.SelectedValue.ToString();
                    plan_week = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString().Substring(0, 1);
                    line_group = "";
                    line_cd = "";

                }
                else if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 2)  // factory group
                {

                    factory = cmb_Factory.SelectedValue.ToString();
                    plan_month = cmb_PlanMonth.SelectedValue.ToString();
                    plan_week = fgrid_Main[fgrid_Main.Rows[fgrid_Main.Row].Node.GetNode(NodeTypeEnum.Parent).Row.Index, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString().Substring(0, 1);
                    line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK_DESC].ToString();
                    line_cd = "";
                }


            }
            else
            {

                factory = cmb_Factory.SelectedValue.ToString();
                plan_month = cmb_PlanMonth.SelectedValue.ToString();
                plan_week = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxPLAN_WEEK].ToString();
                line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_GROUP_NAME].ToString();
                line_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIV_FACTORY.IxLINE_NAME].ToString();
            }




            EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Others pop_form = new EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Others(factory, plan_month, plan_week, line_group, line_cd);
            ClassLib.ComFunction.OpenFormByName(pop_form.GetType().FullName.ToString());






        }



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


        private void fgrid_Main_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Main_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



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


        private void Form_EIS_Weekly_Price_Factory_Load(object sender, EventArgs e)
        {
            Init_Form();

            Event_Tbtn_Search();
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


        private void btn_WarningRange_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_WarningRange_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_WarningRange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        private void btn_RunBatch_Click(object sender, EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                Event_btn_RunBatch_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_RunBatch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }





        #endregion

        #region 컨텍스트 메뉴 이벤트


        private void menuItem_OthersItemAnalysis_Click(object sender, EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_OthersItemAnalysis_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_OthersItemAnalysis_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        /// <summary>
        /// SELECT_WEEKLY_PLAN_MONTH : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <returns></returns>
        public static DataTable SELECT_WEEKLY_PLAN_MONTH(string arg_factory)
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();



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



        #endregion

        #region 조회

        

        /// <summary>
        /// SELECT_WEEKLY_FACTORY : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_FACTORY(string arg_factory, string arg_plan_month)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_FACTORY";

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
        /// SELECT_WEEKLY_FACTORY_CHART : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_line_group"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_FACTORY_CHART(string arg_factory, string arg_plan_month, string arg_line_group)
        {

            try
            {

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_FACTORY_CHART";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_line_group;
                MyOraDB.Parameter_Values[3] = "";




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
    
        #region 배치


        /// <summary>
        /// RUN_EMM_WEEKLY_DETAIL : 
        /// </summary>
        /// <param name="arg_this_factory"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_upd_user"></param>
        /// <returns></returns>
        //private bool RUN_EMM_WEEKLY_DETAIL(string arg_this_factory, 
        //    string arg_factory, 
        //    string arg_plan_month, 
        //    string arg_plan_week, 
        //    string arg_upd_user)
        //{

        //    try
        //    {


        //        MyOraDB.ReDim_Parameter(5);

        //        //01.PROCEDURE명
        //        MyOraDB.Process_Name = "PKG_EMM_WEEK_BATCH_01.RUN_EMM_WEEKLY_DETAIL";

        //        //02.ARGURMENT 명
        //        MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
        //        MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
        //        MyOraDB.Parameter_Name[2] = "ARG_PLAN_MONTH";
        //        MyOraDB.Parameter_Name[3] = "ARG_PLAN_WEEK";
        //        MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";


        //        //03.DATA TYPE 정의
        //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;



        //        //04.DATA 정의
        //        MyOraDB.Parameter_Values[0] = arg_this_factory;
        //        MyOraDB.Parameter_Values[1] = arg_factory;
        //        MyOraDB.Parameter_Values[2] = arg_plan_month;
        //        MyOraDB.Parameter_Values[3] = arg_plan_week;
        //        MyOraDB.Parameter_Values[4] = arg_upd_user;


        //        MyOraDB.Add_Modify_Parameter(true);
        //        DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

        //        if (ds_ret == null)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }


        //    }
        //    catch
        //    {
        //        return false;
        //    }


        //}



        #endregion


  
     
        #endregion

    


    }
}




