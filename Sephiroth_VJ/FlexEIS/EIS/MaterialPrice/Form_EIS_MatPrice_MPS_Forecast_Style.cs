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
    public partial class  Form_EIS_MatPrice_MPS_Forecast_Style : COM.APSWinForm.Form_Top
    {


        #region 생성자


        private System.IO.MemoryStream _memoryStream;



        public  Form_EIS_MatPrice_MPS_Forecast_Style()
        {
            InitializeComponent();


            //Init_Form();


            _memoryStream = new System.IO.MemoryStream();

            chart_StyleOpRatio.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);


        }



        public static string _Factory = "";
        public static string _PlanMonth = "";
        public static string _LineGroup = "";
        public static string _LineCd = "";


        public Form_EIS_MatPrice_MPS_Forecast_Style(string arg_factory, 
            string arg_plan_month, 
            string arg_line_group, 
            string arg_line_cd)
        {
            InitializeComponent();


            //Init_Form();


            _memoryStream = new System.IO.MemoryStream();

            chart_StyleOpRatio.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);




            _Factory = arg_factory;
            _PlanMonth = arg_plan_month;
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
                //this.Text = "스타일별 차월 자재비 예측";
                //lbl_MainTitle.Text = "스타일별 차월 자재비 예측";


                Init_Grid();

                Init_Control();

                Init_Chart_FX_Clear();


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


            fgrid_Main.Set_Grid("EIS_MATPRICE_MPS_FORECAST_STYLE", "1", 3, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.Font = new Font("Verdana", 8);

            fgrid_Main.Rows[fgrid_Main.Rows.Fixed - 3].Visible = false;

          


        }



        /// <summary>
        /// 
        /// </summary>
        private void Init_Grid_Detail()
        {


            #region cell style


            //------------------------------------------------------------------------
            // cell style
            //------------------------------------------------------------------------
            CellStyle cellst = fgrid_Main.Styles.Add("NUMBER");
            cellst.DataType = typeof(double);
            cellst.Format = "#,###";
            cellst.TextAlign = TextAlignEnum.RightCenter;

            CellStyle cellst_ratio = fgrid_Main.Styles.Add("NUMBER_RATIO");
            cellst_ratio.DataType = typeof(double);
            cellst_ratio.Format = "#,##0.##";
            cellst_ratio.TextAlign = TextAlignEnum.RightCenter;


            CellStyle cellst_group = fgrid_Main.Styles.Add("NUMBER_GROUP");
            cellst_group.DataType = typeof(double);
            cellst_group.Format = "#,###";
            cellst_group.TextAlign = TextAlignEnum.RightCenter;
            //cellst_group.BackColor = ClassLib.ComVar.ClrLevel_3rd;

            CellStyle cellst_group_ratio = fgrid_Main.Styles.Add("NUMBER_GROUP_RATIO");
            cellst_group_ratio.DataType = typeof(double);
            cellst_group_ratio.Format = "#,##0.##";
            cellst_group_ratio.TextAlign = TextAlignEnum.RightCenter;
            //cellst_group_ratio.BackColor = ClassLib.ComVar.ClrLevel_3rd;


            //------------------------------------------------------------------------


            #endregion

            #region total column


            for (int i = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxMPS_QTY; i < (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START; i++)
            {

                fgrid_Main.Cols[i].Style = fgrid_Main.Styles["NUMBER"];

                if (i == (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTANDARD_RATIO)
                {
                    fgrid_Main.Cols[i].Style = fgrid_Main.Styles["NUMBER_RATIO"];
                }


            }

            #endregion

            #region cmp column

            //------------------------------------------------------------------------
            // 컬럼 표시 : description 항목
            //------------------------------------------------------------------------
            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, ClassLib.ComVar.This_Factory);
            DataTable dt_ret = SELECT_MPS_FORECAST_STYLE_COLUMN(factory);


            if (dt_ret == null || dt_ret.Rows.Count < 0) return;



            //-------------------------------------------------------------------------------------------------------------------------------
            // cmp column
            //-------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {


                fgrid_Main.Cols.InsertRange(fgrid_Main.Cols.Count, 2);


                for (int a = 0; a < 2; a++)
                {
                    fgrid_Main[fgrid_Main.Rows.Fixed - 3, fgrid_Main.Cols.Count - 1 - a] = dt_ret.Rows[i].ItemArray[0].ToString();
                    fgrid_Main[fgrid_Main.Rows.Fixed - 2, fgrid_Main.Cols.Count - 1 - a] = dt_ret.Rows[i].ItemArray[1].ToString();
                    fgrid_Main[fgrid_Main.Rows.Fixed - 1, fgrid_Main.Cols.Count - 1 - a] = "";

                    fgrid_Main.Cols[fgrid_Main.Cols.Count - 1 - a].Width = 80;
                    fgrid_Main.Cols[fgrid_Main.Cols.Count - 1 - a].AllowEditing = false;
                    fgrid_Main.Cols[fgrid_Main.Cols.Count - 1 - a].Style = fgrid_Main.Styles["NUMBER"];

                }


                fgrid_Main[fgrid_Main.Rows.Fixed - 1, fgrid_Main.Cols.Count - 2] = "Amount";
                fgrid_Main[fgrid_Main.Rows.Fixed - 1, fgrid_Main.Cols.Count - 1] = "Ratio";
                fgrid_Main.Cols[fgrid_Main.Cols.Count - 1].Style = fgrid_Main.Styles["NUMBER_RATIO"];



            } // end for i
            //-------------------------------------------------------------------------------------------------------------------------------


            #endregion

            #region op_group 별 total 표시



            ////-------------------------------------------------------------------------------------------------------------------------------
            //// op_group 별 total 표시
            ////-------------------------------------------------------------------------------------------------------------------------------
            if (fgrid_Main.Cols.Count <= (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START) return;

            string before_op_group = "";
            string now_op_group = "";



            int col = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START;

            while (true)
            {

                now_op_group = fgrid_Main[fgrid_Main.Rows.Fixed - 3, col].ToString();


                if (before_op_group != now_op_group)
                {



                    fgrid_Main.Cols.InsertRange(col, 2);


                    for (int a = 0; a < 2; a++)
                    {

                        fgrid_Main[fgrid_Main.Rows.Fixed - 3, col + a] = now_op_group;
                        fgrid_Main[fgrid_Main.Rows.Fixed - 2, col + a] = "[" + now_op_group + "] Group " + "Total";
                        fgrid_Main[fgrid_Main.Rows.Fixed - 1, col + a] = "";

                        fgrid_Main.Cols[col + a].Width = 80;
                        fgrid_Main.Cols[col + a].AllowEditing = false;
                        fgrid_Main.Cols[col + a].Style = fgrid_Main.Styles["NUMBER_GROUP"];


                    }



                    fgrid_Main[fgrid_Main.Rows.Fixed - 1, col] = "Amount";
                    fgrid_Main[fgrid_Main.Rows.Fixed - 1, col + 1] = "Ratio";
                    fgrid_Main.Cols[col + 1].Style = fgrid_Main.Styles["NUMBER_GROUP_RATIO"];



                    col += 2;


                } // end if
                else
                {
                    col++;
                }


                before_op_group = now_op_group;


                if (col >= fgrid_Main.Cols.Count - 1) break;


            } // end while



            //-------------------------------------------------------------------------------------------------------------------------------


            #endregion

            dt_ret.Dispose();



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



            rad_Style.Checked = true;



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
                //cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
                cmb_Factory.SelectedValue = ClassLib.ComFunction.Set_Default_Factory();
            }




        }




        /// <summary>
        /// set combo : style list
        /// </summary>
        private void Init_Control_cmb_StyleCd()
        {

            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;

            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_month_from = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
            string plan_month_to = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
            string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
            string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");
            string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

            DataTable dt_ret = SELECT_MPS_FORECAST_STYLE_CD(factory, plan_month_from, plan_month_to, line_group, line_cd, style_cd);

            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
            ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, true, 80, 200);

            dt_ret.Dispose();




        }



        /// <summary>
        /// Display_LastUpdateDate : Last update 조회
        /// </summary>
        private void Display_LastUpdateDate()
        {


            string table_string = "EMM_MPS_FORECAST_USAGE";

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
                where_string += @" AND SUBSTR(PLAN_YMD, 1, 6) = '" + cmb_PlanMonth.SelectedValue.ToString().Replace("-", "") + @"'";
            }


            lbl_LastUpdate2.Text = ClassLib.ComFunction.Display_LastUpdateDate(table_string, where_string);

        }



        #endregion

        #region 조회


        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_dt_ret"></param>
        private void Display_Grid(DataTable arg_dt_ret)
        {

            int find_row = -1;
            int find_col = -1;
            string line_cd = "";
            string style_cd = "";
            string obs_id = "";
            string obs_type = "";
            string cmp_cd = "";


            string before_line_cd = "";
            string now_line_cd = "";


            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


            // line data 표시
            for (int i = 0; i < arg_dt_ret.Rows.Count; i++)
            {


                now_line_cd = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxLINE].ToString()
                    + arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxSTYLE_CD].ToString()
                    + arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxOBS_ID].ToString()
                    + arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxOBS_TYPE].ToString();

                if (before_line_cd != now_line_cd)
                {

                    fgrid_Main.Rows.Add();
                    //fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].Height = 20;



                    for (int a = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP; a < (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START; a++)
                    {



                        CellStyle cellst_ratio_total = fgrid_Main.Styles.Add("NUMBER_RATIO_TOTAL");
                        cellst_ratio_total.DataType = typeof(string);
                        cellst_ratio_total.TextAlign = TextAlignEnum.RightCenter;



                        if (fgrid_Main.Cols[a].Style.Name.Equals("NUMBER_GROUP_RATIO") || fgrid_Main.Cols[a].Style.Name.Equals("NUMBER_RATIO"))
                        {

                            CellRange cellrg = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, a);
                            cellrg.Style = fgrid_Main.Styles["NUMBER_RATIO_TOTAL"];

                            fgrid_Main[fgrid_Main.Rows.Count - 1, a] = string.Format("{0}", arg_dt_ret.Rows[i].ItemArray[a - 1].ToString() + "%");

                        }
                        else
                        {
                            fgrid_Main[fgrid_Main.Rows.Count - 1, a] = arg_dt_ret.Rows[i].ItemArray[a - 1].ToString();
                        }

                        
                    }




                    ////-----------------------------------------------------------------------------------
                    //// warning 표시
                    //// 30% 이하 Red, 40% 이하 Yellow
                    ////-----------------------------------------------------------------------------------
                    //double ratio = Convert.ToDouble(arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxSTANDARD_RATIO].ToString());

                    //CellStyle cellst_color_yellow = fgrid_Main.Styles.Add("RATIO_COLOR_YELLOW", "NUMBER_RATIO_TOTAL");
                    //CellStyle cellst_color_red = fgrid_Main.Styles.Add("RATIO_COLOR_RED", "NUMBER_RATIO_TOTAL");
                    //CellRange cr = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTANDARD_RATIO);

                    //if (ratio <= 40)
                    //{
                    //    cr.Style = fgrid_Main.Styles["RATIO_COLOR_YELLOW"];
                    //    cr.StyleNew.BackColor = Color.Yellow; // ClassLib.ComVar.ClrYellow;
                    //}

                    //if (ratio <= 30)
                    //{
                    //    cr.Style = fgrid_Main.Styles["RATIO_COLOR_RED"];
                    //    cr.StyleNew.BackColor = Color.Red; // ClassLib.ComVar.ClrWarning_Back;
                    //}
                    ////-----------------------------------------------------------------------------------




                } // end if

                before_line_cd = now_line_cd;



            } // end for i




            // cmp cd 데이터
            for (int i = 0; i < arg_dt_ret.Rows.Count; i++)
            {



                find_row = -1;
                find_col = -1;




                line_cd = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxLINE].ToString();
                find_row = fgrid_Main.FindRow(line_cd, fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE, false, true, false);
                if (find_row == -1) continue;


                style_cd = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxSTYLE_CD].ToString();
                find_row = fgrid_Main.FindRow(style_cd, find_row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTYLE_CD, false, true, false);
                if (find_row == -1) continue;


                obs_id = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxOBS_ID].ToString();
                find_row = fgrid_Main.FindRow(obs_id, find_row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxOBS_ID, false, true, false);
                if (find_row == -1) continue;


                obs_type = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxOBS_TYPE].ToString();
                find_row = fgrid_Main.FindRow(obs_type, find_row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxOBS_TYPE, false, true, false);
                if (find_row == -1) continue;






                cmp_cd = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxOP_CD].ToString();

                for (int j = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START; j < fgrid_Main.Cols.Count; j++)
                {

                    if (fgrid_Main[fgrid_Main.Rows.Fixed - 2, j].ToString() == cmp_cd)
                    {
                        find_col = j;
                        break;
                    } // end if

                } // end for j

                if (find_col == -1) continue;



                fgrid_Main[find_row, find_col] = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxSTANDARD_OP_AMOUNT].ToString();
                fgrid_Main[find_row, find_col + 1] = arg_dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE.IxSTANDARD_OP_RATIO].ToString();





            } // end for i



            ////---------------------------------------------------
            //// merge
            ////---------------------------------------------------
            //fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            //for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            //{
            //    fgrid_Main.Cols[i].AllowMerging = false;
            //}


            //fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP].AllowMerging = true;
            //fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP_NAME].AllowMerging = true;
            //fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_CD].AllowMerging = true;
            //fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE].AllowMerging = true;
            //---------------------------------------------------




            Display_Grid_SubTotal();




        }




        /// <summary>
        /// Display_Grid_SubTotal : 
        /// </summary>
        private void Display_Grid_SubTotal()
        {


            #region column


            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {



                string before_op_group = "";
                string now_op_group = "";



                int col = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START;
                int start_col = col;
                int end_col = 0;

                int sum_standard = 0;
                double sum_standard_ratio = 0;


                while (true)
                {

                    if (col == fgrid_Main.Cols.Count - 1)
                    {
                        now_op_group = "";
                    }
                    else
                    {
                        now_op_group = fgrid_Main[fgrid_Main.Rows.Fixed - 3, col].ToString();
                    }


                    if (before_op_group != "" && before_op_group != now_op_group)
                    {



                        end_col = col - 1;


                        //-----------------------------------------------------------------
                        // op_group 별 합계 계산
                        //-----------------------------------------------------------------
                        // start_col + 2 : group total 이후 계산
                        // a += 2 : standard, standrad_ratio
                        for (int a = start_col + 2; a <= end_col; a += 2)
                        {

                            sum_standard += (fgrid_Main[i, a] == null || fgrid_Main[i, a].ToString().Trim() == "") ? 0 : Convert.ToInt32(fgrid_Main[i, a].ToString());
                            sum_standard_ratio += (fgrid_Main[i, a + 1] == null || fgrid_Main[i, a + 1].ToString().Trim() == "") ? 0 : Convert.ToDouble(fgrid_Main[i, a + 1].ToString());
                           

                        } // end for a


                        fgrid_Main[i, start_col] = sum_standard.ToString();
                        //fgrid_Main[i, start_col + 1] = sum_standard_ratio.ToString();

                        CellStyle cellst_ratio_op = fgrid_Main.Styles.Add("NUMBER_RATIO_OP");
                        cellst_ratio_op.DataType = typeof(string);
                        cellst_ratio_op.TextAlign = TextAlignEnum.RightCenter;


                        CellRange cellrg_op = fgrid_Main.GetCellRange(i, start_col + 1);
                        cellrg_op.Style = fgrid_Main.Styles["NUMBER_RATIO_OP"];

                        fgrid_Main[i, start_col + 1] = string.Format("{0}", sum_standard_ratio.ToString() + "%");



                        //----------------------------------------------------------
                        // 컬럼 합계 계산 후 % 붙여서 다시 표시
                        //----------------------------------------------------------
                        for (int a = start_col + 2; a <= end_col; a += 2)
                        {

                            cellrg_op = fgrid_Main.GetCellRange(i, a + 1);
                            cellrg_op.Style = fgrid_Main.Styles["NUMBER_RATIO_OP"];

                            fgrid_Main[i, a + 1] = (fgrid_Main[i, a + 1] == null || fgrid_Main[i, a + 1].ToString().Trim() == "") ? "" : string.Format("{0}", fgrid_Main[i, a + 1].ToString() + "%");


                        } // end for a
                        //----------------------------------------------------------




                        sum_standard = 0;
                        sum_standard_ratio = 0;
                        //-----------------------------------------------------------------


                        start_col = end_col + 1;




                    } // end if
                    else
                    {
                        col++;
                    }


                    before_op_group = now_op_group;


                    if (col > fgrid_Main.Cols.Count - 1) break;


                } // end while







            } // end for i


            #endregion

            #region row


            // Row
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP_NAME;


            fgrid_Main.Subtotal(AggregateEnum.Clear);
            fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;


            fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrLevel_1st;
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; // ClassLib.ComVar.ClrImportant;
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].Font = new Font("Verdana", 8, FontStyle.Bold);


            fgrid_Main.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrLevel_2nd;
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black; // ClassLib.ComVar.ClrImportant;
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].Format = "#,###";


            fgrid_Main.Styles[CellStyleEnum.Subtotal3].BackColor = ClassLib.ComVar.ClrLevel_3rd;
            fgrid_Main.Styles[CellStyleEnum.Subtotal3].ForeColor = Color.Black; // ClassLib.ComVar.ClrImportant;
            fgrid_Main.Styles[CellStyleEnum.Subtotal3].Format = "#,###";



            // line subtotal
            for (int i = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxMPS_QTY; i < fgrid_Main.Cols.Count; i++)
            {



                if (fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_GROUP_RATIO") || fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_RATIO"))
                {
                    continue;
                }


                fgrid_Main.Subtotal(AggregateEnum.Sum, 3, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE, i, "{0}");



            } // end for i




            // line group subtotal
            for (int i = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxMPS_QTY; i < fgrid_Main.Cols.Count; i++)
            {

              
                //CellStyle cellst_group_ratio = fgrid_Main.Styles.Add("NUMBER_GROUP_RATIO");

                if (fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_GROUP_RATIO") || fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_RATIO"))
                {
                    continue;
                }


                fgrid_Main.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP_NAME, i, "{0}");

               

            } // end for i



            // grand total
            for (int i = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxMPS_QTY; i < fgrid_Main.Cols.Count; i++)
            {

              
                if (fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_GROUP_RATIO") || fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_RATIO"))
                {
                    continue;
                }


                fgrid_Main.Subtotal(AggregateEnum.Sum, 1, -1, i, "Grand Total");




            } // end for i



            //----------------------------------------------------------
            // ratio 합계 재 계산
            //----------------------------------------------------------
            for (int i = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxMPS_QTY; i < fgrid_Main.Cols.Count; i++)
            {


                if (!fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_GROUP_RATIO") && ! fgrid_Main.Cols[i].Style.Name.Equals("NUMBER_RATIO"))
                {
                    continue;
                }



                double sale_amount = 0;
                double standard_amount = 0;

                for (int j = fgrid_Main.Rows.Fixed; j < fgrid_Main.Rows.Count; j++)
                {

                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP] != null) continue;


                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxFOB_AMOUNT] == null
                        || fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxFOB_AMOUNT].ToString().Trim() == "")
                    {
                        sale_amount = 0;
                    }
                    else
                    {
                        sale_amount = Convert.ToDouble(fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxFOB_AMOUNT].ToString());
                    }


                    if (fgrid_Main[j, i - 1] == null || fgrid_Main[j, i - 1].ToString().Trim() == "")
                    {
                        standard_amount = 0;
                    }
                    else
                    {
                        standard_amount = Convert.ToDouble(fgrid_Main[j, i - 1].ToString());
                    }



                  
                   
                    string standard_ratio = "";


                    if (sale_amount == 0)
                    {
                        standard_ratio = "0";
                    }
                    else
                    {
                        standard_ratio = Convert.ToString(Math.Round((standard_amount / sale_amount) * 100, 2));
                    }




                    CellStyle cellst_ratio = fgrid_Main.Styles.Add("NUMBER_RATIO_SUBTOTAL");
                    cellst_ratio.DataType = typeof(string);
                    cellst_ratio.TextAlign = TextAlignEnum.RightCenter;



                    CellRange cellrg = fgrid_Main.GetCellRange(j, i);
                    cellrg.Style = fgrid_Main.Styles["NUMBER_RATIO_SUBTOTAL"];

                    fgrid_Main[j, i] = string.Format("{0}", standard_ratio + "%");



                } // end for j




            } // end for i
            //----------------------------------------------------------



            //-------------------------------------------------------------------------
            //subtotal row 색 표시
            //-------------------------------------------------------------------------
            CellStyle cellst_subtotal_1 = fgrid_Main.Styles.Add("SUBTOTAL_COLOR_1");
            cellst_subtotal_1.BackColor = ClassLib.ComVar.ClrLevel_1st;

            CellStyle cellst_subtotal_2 = fgrid_Main.Styles.Add("SUBTOTAL_COLOR_2");
            cellst_subtotal_2.BackColor = ClassLib.ComVar.ClrLevel_2nd;

            CellStyle cellst_subtotal_3 = fgrid_Main.Styles.Add("SUBTOTAL_COLOR_3");
            cellst_subtotal_3.BackColor = ClassLib.ComVar.ClrLevel_3rd;

            CellStyle cellst_subtotal_4 = fgrid_Main.Styles.Add("SUBTOTAL_COLOR_4");
            cellst_subtotal_4.BackColor = Color.Empty;


            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {

                CellRange cr = fgrid_Main.GetCellRange(i, 1, i, fgrid_Main.Cols.Count - 1);


                if (fgrid_Main.Rows[i].IsNode)
                {

                    int level = fgrid_Main.Rows[i].Node.Level;

                    if (level == 1)
                    {
                        cr.Style = fgrid_Main.Styles["SUBTOTAL_COLOR_1"];
                    }
                    else if (level == 2)
                    {
                        cr.Style = fgrid_Main.Styles["SUBTOTAL_COLOR_2"];
                    }
                    else if (level == 3)
                    {
                        cr.Style = fgrid_Main.Styles["SUBTOTAL_COLOR_3"];
                    }
                }
                else
                {
                    cr.Style = fgrid_Main.Styles["SUBTOTAL_COLOR_4"];


                    //-----------------------------------------------------------------------------------
                    // warning 표시
                    // 30% 이하 Red, 40% 이하 Yellow
                    //-----------------------------------------------------------------------------------
                    double ratio = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTANDARD_RATIO].ToString().Replace("%", "").Trim());

                    CellStyle cellst_color_yellow = fgrid_Main.Styles.Add("RATIO_COLOR_YELLOW", "NUMBER_RATIO_TOTAL");
                    cellst_color_yellow.BackColor = Color.Yellow; // Clasb.ComVar.ClrYellow;

                    CellStyle cellst_color_red = fgrid_Main.Styles.Add("RATIO_COLOR_RED", "NUMBER_RATIO_TOTAL");
                    cellst_color_red.BackColor = Color.Red; // ClassLib.ComVar.ClrWarning_Back;

                    CellRange cr_color = fgrid_Main.GetCellRange(i, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTANDARD_RATIO);

                    if (ratio <= 40)
                    {
                        cr_color.Style = fgrid_Main.Styles["RATIO_COLOR_YELLOW"];
                    }

                    if (ratio <= 30)
                    {
                        cr_color.Style = fgrid_Main.Styles["RATIO_COLOR_RED"];
                    }
                    //-----------------------------------------------------------------------------------



                }


            } // end for i
            //-------------------------------------------------------------------------




            fgrid_Main.Tree.Show(-1);
            rad_Style.Checked = true;



            #endregion


        }



        #region chart fx


        private void Init_Chart_FX()
        {


            Init_Chart_FX_Clear();

            Init_Chart_FX_Style();

            Init_Chart_FX_Data();


        }

        private void Init_Chart_FX_Clear()
        {

            _memoryStream.Position = 0;


            chart_StyleOpRatio.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_StyleOpRatio.Data.Clear();



        }

        private void Init_Chart_FX_Style()
        {


            Init_Char_FX_Style(chart_StyleOpRatio);


        }

        private void Init_Char_FX_Style(ChartFX.WinForms.Chart arg_chart)
        {


            arg_chart.Border = new ChartFX.WinForms.Adornments.SimpleBorder(ChartFX.WinForms.Adornments.SimpleBorderType.None);
            arg_chart.Background = new ChartFX.WinForms.Adornments.SolidBackground(Color.White);


            arg_chart.Font = new Font("Verdana", 8);
            arg_chart.Gallery = ChartFX.WinForms.Gallery.Bar;


            arg_chart.AllSeries.BarShape = ChartFX.WinForms.BarShape.Cylinder;
            arg_chart.AllSeries.Stacked = ChartFX.WinForms.Stacked.Normal;

            arg_chart.AllSeries.PointLabels.Visible = true;
            arg_chart.AllSeries.PointLabels.Font = new Font("Verdana", 7);
            arg_chart.AllSeries.PointLabels.TextColor = Color.Black;


            arg_chart.LegendBox.Visible = false;


            //arg_chart.AxisX.LabelAngle = 45;
            arg_chart.AxisX.Title.Text = "";
            arg_chart.AxisY.Title.Text = "%";
            arg_chart.AxisY.DataFormat.CustomFormat = "##0.##";




        }

        private void Init_Chart_FX_Data()
        {

            string line_group_name = "";
            string line_name = "";
            string style_cd = "";
            string style_name = "";
            string obs_id = "";
            string obs_type = "";
            string standard_amount = "";
            string op_cd = "";


          
            DataTable dt_c2 = new DataTable("STYLE_OP_STANDARD_RATIO");
            dt_c2.Columns.Add(new DataColumn("COL_ORDER", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("LINE", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("STYLE_CD", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("STYLE_NAME", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("OBS_ID", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("OBS_TYPE", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("OP_CD", typeof(string)));
            dt_c2.Columns.Add(new DataColumn("STANDARD_RATIO", typeof(string)));



            DataRow dr_c2 = null;
            int col_order = 0;


            line_group_name = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP_NAME].ToString().Trim();
            


            if (fgrid_Main.Rows[fgrid_Main.Row].IsNode)
            {
                line_name = "";
                style_cd = "";
                style_name = "";
                obs_id = "";
                obs_type = "";
            }
            else
            {
                line_name = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE].ToString();
                style_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTYLE_CD].ToString();
                style_name = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTYLE_NAME].ToString();
                obs_id = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxOBS_ID].ToString();
                obs_type = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxOBS_TYPE].ToString();
            }


            for (int j = (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxCMP_CD_START; j < fgrid_Main.Cols.Count; j++)
            {

                if (fgrid_Main.Cols[j].Style.Name.Equals("NUMBER_RATIO"))
                {

                    op_cd = fgrid_Main[fgrid_Main.Rows.Fixed - 2, j].ToString();
                    standard_amount = (fgrid_Main[fgrid_Main.Row, j] == null) ? "" : fgrid_Main[fgrid_Main.Row, j].ToString().Replace("%", "").Trim();


                    dr_c2 = dt_c2.NewRow();

                    dr_c2[0] = col_order.ToString();
                    dr_c2[1] = line_group_name + " - " + line_name;
                    dr_c2[2] = style_cd;
                    dr_c2[3] = style_name;
                    dr_c2[4] = obs_id;
                    dr_c2[5] = obs_type;
                    dr_c2[6] = op_cd;
                    dr_c2[7] = (standard_amount == "") ? "0" : standard_amount;

                    dt_c2.Rows.Add(dr_c2);

                    col_order++;


                }


            }


            chart_StyleOpRatio.Data.Series = 1;
            chart_StyleOpRatio.Series[0].Color = Color.Lavender;

            //-----------------------------------------------------------------------------
            ChartFX.WinForms.TitleDockable title = new ChartFX.WinForms.TitleDockable();



            if (fgrid_Main.Rows[fgrid_Main.Row].IsNode)
            {
                
                title.Text = "Line - [" + line_group_name + " - " + line_name + "]";

            }
            else
            {

                title.Text = "Line - [" + line_group_name + " - " + line_name + "]"
                        + "\n\r" + "Style - [" + style_cd + "    " + style_name + "]"
                        + ",    " + "DPO - [" + obs_id + "]"
                        + ",    " + "Type - [" + obs_type + "]";


            }



            

            title.Dock = ChartFX.WinForms.DockArea.Top;
            title.Alignment = StringAlignment.Near;
            title.Font = new Font("Verdana", 8, FontStyle.Bold);
            chart_StyleOpRatio.Titles.Add(title);
            //-----------------------------------------------------------------------------





            Init_Chart_FX_Data(chart_StyleOpRatio, dt_c2);



        }

        private void Init_Chart_FX_Data(ChartFX.WinForms.Chart arg_chart, DataTable arg_dt)
        {



            if (arg_dt == null || arg_dt.Rows.Count == 0) return;



            arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("COL_ORDER", ChartFX.WinForms.FieldUsage.XValue));
            arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("OP_CD", ChartFX.WinForms.FieldUsage.Label));
            arg_chart.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("STANDARD_RATIO", ChartFX.WinForms.FieldUsage.Value));


            arg_chart.DataSource = arg_dt;



        }




        #endregion




        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {


            //cmb_PlanMonth.SelectedValue = System.DateTime.Now.ToString("yyyy-MM");
            cmb_LineGroup.SelectedIndex = -1;
            cmb_Line.SelectedIndex = -1;
            cmb_OBSType.SelectedIndex = -1;
            txt_StyleCd.Text = "";
            cmb_StyleCd.SelectedIndex = -1;


            fgrid_Main.ClearAll();
            Init_Chart_FX_Clear();

        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {


            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_ymd = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
            string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
            string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");
            string obs_type = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " ");
            string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");


            DataTable dt_ret = SELECT_MPS_FORECAST_STYLE(factory, plan_ymd, line_group, line_cd, obs_type, style_cd);

            Display_Grid(dt_ret);

            Init_Chart_FX();



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

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "스타일별 차월 자재비 예측", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



        #endregion

        #region 그리드 이벤트 메서드



        /// <summary>
        /// Event_fgrid_Main_Click : 
        /// </summary>
        private void Event_fgrid_Main_Click()
        {

            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


            Init_Chart_FX();


        }



        /// <summary>
        /// Event_fgrid_Main_DoubleClick : 
        /// </summary>
        private void Event_fgrid_Main_DoubleClick()
        {


            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;



            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;

            if (fgrid_Main.Rows[fgrid_Main.Row].IsNode) return;



            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_ymd = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
            string line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_GROUP].ToString();
            string line_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxLINE_CD].ToString();
            string style_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxSTYLE_CD].ToString().Replace("-", "");
            string obs_id = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxOBS_ID].ToString();
            string obs_type = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_MPS_FORECAST_STYLE.IxOBS_TYPE].ToString();


            EIS.MaterialPrice.Form_EIS_MatPrice_MPS_Forecast_Style_Item pop_form = new EIS.MaterialPrice.Form_EIS_MatPrice_MPS_Forecast_Style_Item(factory, plan_ymd, line_group, line_cd, style_cd, obs_id, obs_type);
            //pop_form.ShowDialog();
            ClassLib.ComFunction.OpenFormByName(pop_form.GetType().FullName.ToString());



        }


        		
	

        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1) return;



            Init_Grid();
            Init_Grid_Detail();
            Init_Chart_FX_Clear();


            string factory = cmb_Factory.SelectedValue.ToString();


            DataTable dt_ret = null;


            // plan_month 설정
            dt_ret = SELECT_MPS_FORECAST_PLAN_MONTH(factory);
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




            // line_group
            dt_ret = ClassLib.ComFunction.SELECT_PRODUCT_LINE_INFO(factory, "", "LINE_GROUP");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineGroup, 0, 1, true, COM.ComVar.ComboList_Visible.Name);


            if (_LineGroup != null && !_LineGroup.Trim().Equals(""))
            {
                cmb_LineGroup.SelectedValue = _LineGroup;
                _LineGroup = "";
            }




            // order type
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);  // "SEM10";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);

            






            dt_ret.Dispose();


        }



        /// <summary>
        /// Event_cmb_PlanMonth_SelectedValueChange : 
        /// </summary>
        private void Event_cmb_PlanMonth_SelectedValueChange()
        {

            if (cmb_PlanMonth.SelectedIndex == -1) return;


            fgrid_Main.ClearAll();
            Init_Chart_FX_Clear();



            // Last update 조회
            Display_LastUpdateDate();



        }

       

        /// <summary>
        /// Event_cmb_LineGroup_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_LineGroup_SelectedValueChanged()
        {


            cmb_Line.SelectedIndex = -1;
            fgrid_Main.ClearAll();
            Init_Chart_FX_Clear();


            if (cmb_Factory.SelectedIndex == -1 || cmb_LineGroup.SelectedIndex == -1) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string line_group = cmb_LineGroup.SelectedValue.ToString();


            DataTable dt_ret = null;

            // line
            dt_ret = ClassLib.ComFunction.SELECT_PRODUCT_LINE_INFO(factory, line_group, "LINE_CD");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);



            if (_LineCd != null && !_LineCd.Trim().Equals(""))
            {
                cmb_Line.SelectedValue = _LineCd;
                _LineCd = "";
            }




            dt_ret.Dispose();


        }



        /// <summary>
        /// Event_cmb_Line_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Line_SelectedValueChanged()
        {


            fgrid_Main.ClearAll();
            Init_Chart_FX_Clear();


        }




        /// <summary>
        /// Event_cmb_OBSType_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_OBSType_SelectedValueChanged()
        {


            fgrid_Main.ClearAll();
            Init_Chart_FX_Clear();



        }


        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary>
        private void Event_txt_StyleCd_KeyUp()
        {

            //-------------------------------------------------------------------------
            // 기타 콘트롤 초기화 
            cmb_StyleCd.SelectedIndex = -1;
            fgrid_Main.ClearAll();
            //-------------------------------------------------------------------------


            // set combo : style list
            Init_Control_cmb_StyleCd();



            string stylecd = "";
            int exist_index = -1;

            stylecd = txt_StyleCd.Text.Trim();

            exist_index = txt_StyleCd.Text.IndexOf("-", 0);

            if (exist_index == -1 && stylecd.Length == 9)
            {
                stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
            }

            cmb_StyleCd.SelectedValue = stylecd;



        }



        /// <summary>
        /// Event_cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_StyleCd_SelectedValueChanged()
        {

            if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


            //-------------------------------------------------------------------------
            // 기타 콘트롤 초기화 
            fgrid_Main.ClearAll();
            Init_Chart_FX_Clear();
            //-------------------------------------------------------------------------



            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name 
            txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();



        }




        /// <summary>
        /// Event_rad_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_rad_CheckedChanged(object sender)
        {


            RadioButton src = sender as RadioButton;


            if (src == rad_LineGroup)
            {
                fgrid_Main.Tree.Show(2);


            }
            else if (src == rad_Line)
            {

                fgrid_Main.Tree.Show(3);


            }
            else if (src == rad_Style)
            {

                fgrid_Main.Tree.Show(-1);


            }


        }




        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드




        private void Event_menuItem_AnalysisStyleItem_Click()
        {

            Event_fgrid_Main_DoubleClick();
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

                Event_fgrid_Main_Click();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void fgrid_Main_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                Event_fgrid_Main_DoubleClick();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void  Form_EIS_MatPrice_MPS_Forecast_Style_Load(object sender, EventArgs e)
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

                Event_cmb_PlanMonth_SelectedValueChange();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanMonth_SelectedValueChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Event_cmb_LineGroup_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_LineGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmb_Line_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Event_cmb_Line_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Line_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmb_OBSType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Event_cmb_OBSType_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_OBSType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txt_StyleCd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyCode != Keys.Enter) return;

                Event_txt_StyleCd_KeyUp();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void cmb_StyleCd_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_StyleCd_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


      

        private void menuItem_AnalysisStyleItem_Click(object sender, EventArgs e)
        {

            try
            {
                Event_menuItem_AnalysisStyleItem_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_AnalysisStyleItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        #endregion

        #endregion

        #region 디비 연결


        #region 콤보


        /// <summary>
        /// SELECT_MPS_FORECAST_PLAN_MONTH : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <returns></returns>
        private DataTable SELECT_MPS_FORECAST_PLAN_MONTH(string arg_factory)
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_PLAN_MONTH";

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
        /// SELECT_MPS_FORECAST_STYLE_CD : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_ymd"></param>
        /// <param name="arg_line_gorup"></param>
        /// <param name="arg_line_cd"></param>
        /// <param name="arg_obs_type"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_MPS_FORECAST_STYLE_CD(string arg_factory,
            string arg_plan_ymd_from,
            string arg_plan_ymd_to,
            string arg_line_group,
            string arg_line_cd,
            string arg_style_cd)
        {

            try
            {

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_STYLE_CD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_ymd_from;
                MyOraDB.Parameter_Values[2] = arg_plan_ymd_to;
                MyOraDB.Parameter_Values[3] = arg_line_group;
                MyOraDB.Parameter_Values[4] = arg_line_cd;
                MyOraDB.Parameter_Values[5] = arg_style_cd;
                MyOraDB.Parameter_Values[6] = "";


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
        /// SELECT_MPS_FORECAST_STYLE_COLUMN : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <returns></returns>
        private DataTable SELECT_MPS_FORECAST_STYLE_COLUMN(string arg_factory)
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH.SELECT_PROCESS_CODE";

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
        /// SELECT_MPS_FORECAST_STYLE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_ymd"></param>
        /// <param name="arg_line_gorup"></param>
        /// <param name="arg_line_cd"></param>
        /// <param name="arg_obs_type"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_MPS_FORECAST_STYLE(string arg_factory, 
            string arg_plan_ymd, 
            string arg_line_gorup, 
            string arg_line_cd,
            string arg_obs_type,
            string arg_style_cd)
        {

            try
            {

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_STYLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

              

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_ymd;
                MyOraDB.Parameter_Values[2] = arg_line_gorup;
                MyOraDB.Parameter_Values[3] = arg_line_cd;
                MyOraDB.Parameter_Values[4] = arg_obs_type;
                MyOraDB.Parameter_Values[5] = arg_style_cd;
                MyOraDB.Parameter_Values[6] = "";


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

