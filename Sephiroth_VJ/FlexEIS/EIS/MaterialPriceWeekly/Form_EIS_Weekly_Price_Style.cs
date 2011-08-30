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
    public partial class  Form_EIS_Weekly_Price_Style : COM.APSWinForm.Form_Top
    {


        #region ������
         

        public  Form_EIS_Weekly_Price_Style()
        {

            InitializeComponent();

        }


        public static string _Factory = "";
        public static string _PlanMonth = "";
        public static string _PlanWeek = "";
        public static string _LineGroup = "";
        public static string _LineCd = "";
        



        public Form_EIS_Weekly_Price_Style(string arg_factory, 
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

        #region ���� ����


        private COM.OraDB MyOraDB = new COM.OraDB();

        


        #endregion

        #region ��� �޼���


        #region �ʱ�ȭ

        
        
        
        /// <summary>
        /// Inti_Form : Form Load �� �ʱ�ȭ �۾�
        /// </summary>
        private void Init_Form()
        {

            try
            {


                ////Title
                //this.Text = "�ְ� ���� �м� - ��Ÿ��";
                //lbl_MainTitle.Text = "�ְ� ���� �м� - ��Ÿ��";


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


            fgrid_Main.Set_Grid("EIS_MATPRICE_WEEKLY_DIVISION", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
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



            rad_Line.Checked = true;



            txt_WarningDesc1_Green.Text = "3";
            txt_WarningDesc1_Yellow.Text = "-5";
            txt_WarningDesc1_Red.Text = "-5";




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



        /// <summary>
        /// set combo : style list
        /// </summary>
        private void Init_Control_cmb_StyleCd()
        {

            if (cmb_Factory.SelectedIndex == -1 || cmb_PlanMonth.SelectedIndex == -1) return;

            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
            string plan_week = ClassLib.ComFunction.Empty_Combo(cmb_PlanWeek, " ");
            string out_type = ClassLib.ComFunction.Empty_Combo(cmb_OutType, " ");
            string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
            string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");
            string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

            DataTable dt_ret = SELECT_WEEKLY_STYLE_CD(factory, plan_month, plan_week, out_type, line_group, line_cd, style_cd);

            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
            ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, true, 80, 200);

            dt_ret.Dispose();



        }





        #endregion

        #region ��ȸ



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
                string out_type = ClassLib.ComFunction.Empty_Combo(cmb_OutType, " ");
                string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
                string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

                DataTable dt_ret = SELECT_WEEKLY_DIVISION(factory, plan_month, plan_week, out_type, line_group, line_cd, style_cd);

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


            //---------------------------------------------------
            // merge
            //---------------------------------------------------
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = false;
            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxFACTORY; i <= (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxLINE_NAME; i++)
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
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxPLAN_WEEK_DESC;
            fgrid_Main.Subtotal(AggregateEnum.Clear);
            fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;


            fgrid_Main.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;  // total
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal0].Font = new Font("Verdana", 8, FontStyle.Bold);

            fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;  // week
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal1].Font = new Font("Verdana", 8, FontStyle.Bold);

            fgrid_Main.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;  // out_type
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Blue;
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal2].Font = new Font("Verdana", 8, FontStyle.Bold);

            fgrid_Main.Styles[CellStyleEnum.Subtotal3].BackColor = ClassLib.ComVar.ClrSubTotal3;  // factory group
            fgrid_Main.Styles[CellStyleEnum.Subtotal3].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal3].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal3].Font = new Font("Verdana", 8, FontStyle.Bold);

            fgrid_Main.Styles[CellStyleEnum.Subtotal4].BackColor = ClassLib.ComVar.ClrSubTotal4;  // line
            fgrid_Main.Styles[CellStyleEnum.Subtotal4].ForeColor = Color.Black;
            fgrid_Main.Styles[CellStyleEnum.Subtotal4].Format = "#,###";
            fgrid_Main.Styles[CellStyleEnum.Subtotal4].Font = new Font("Verdana", 8, FontStyle.Bold);


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO) continue;


                fgrid_Main.Subtotal(AggregateEnum.Sum, 0, -1, i, "TOTAL"); 

            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO) continue;


                fgrid_Main.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxPLAN_WEEK_DESC, i, "{0}");

            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO) continue;


                fgrid_Main.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxOUT_TYPE, i, "{0}");

            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO) continue;

                fgrid_Main.Subtotal(AggregateEnum.Sum, 3, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxLINE_GROUP_NAME, i, "{0}");

            }


            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO
                    || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO) continue;

                fgrid_Main.Subtotal(AggregateEnum.Sum, 4, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxLINE_NAME, i, "{0}");

            }
            //-----------------------------------------------------------------------------------------


            #endregion

            #region total ratio


            //-----------------------------------------------------------------------------------------
            // total ratio ���
            //-----------------------------------------------------------------------------------------
            for (int i = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST; i < fgrid_Main.Cols.Count; i++)
            {


                if (i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO
                    && i != (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO) continue;


                double adjust_amount = 0;
                double out_all_amount = 0;
                double cal_amount = 0;
                string cal_ratio = "";



                for (int j = fgrid_Main.Rows.Fixed; j < fgrid_Main.Rows.Count; j++)
                {

                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxPLAN_WEEK] != null) continue;



                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST] == null
                        || fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST].ToString().Trim() == "")
                    {
                        adjust_amount = 0;
                    }
                    else
                    {
                        adjust_amount = Convert.ToDouble(fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_ADJUST].ToString());
                    }



                    if (fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_ALL] == null
                        || fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_ALL].ToString().Trim() == "")
                    {
                        out_all_amount = 0;
                    }
                    else
                    {
                        out_all_amount = Convert.ToDouble(fgrid_Main[j, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_ALL].ToString());
                    }





                    if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO
                        || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO
                        || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO
                        || i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO)
                    {


                        int col = 0;


                        if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_NORMAL;
                        }
                        else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_DEFECTIVE;
                        }
                        else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OVERUSAGE;
                        }
                        else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER_RATIO)
                        {
                            col = (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_OTHER;
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
                    else if (i == (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO)
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




                    fgrid_Main[j, i] = cal_ratio.ToString();




                } // end for j




            } // end for i
            //-----------------------------------------------------------------------------------------

            #endregion

            #region warning


            Event_btn_WarningRange_Click();


            #endregion

            #region etc



            //-----------------------------------------------------------------------------------------
            // view tree level
            //-----------------------------------------------------------------------------------------
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {

                fgrid_Main.Rows[i].Node.Collapsed = true;

            } // end for i



            fgrid_Main.Tree.Show(4);
            rad_Line.Checked = true;
            //-----------------------------------------------------------------------------------------


            #endregion





        }
       


        #endregion

        #region ���� �̺�Ʈ �޼���



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


            //// ��ȸ�� �ʼ����� üũ 
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

            saveFileDialog1.Filter = "Excel ����|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            if (saveFileDialog1.FileName != "")
            {

                fgrid_Main.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "�ְ� ��Ÿ�Ϻ� ���� �м�", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }



        #endregion

        #region �׸��� �̺�Ʈ �޼���


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
            string plan_month = cmb_PlanMonth.SelectedValue.ToString().Replace("-", "");
            string plan_week = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxPLAN_WEEK].ToString(); 
            string out_type = "";
            string line_group = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxLINE_GROUP_NAME].ToString();
            string line_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxLINE_NAME].ToString();
            string style_cd = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxSTYLE_CD].ToString().Replace("-", "");


            EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Item pop_form = new EIS.MaterialPriceWeekly.Form_EIS_Weekly_Price_Item(factory, plan_month, plan_week, out_type, line_group, line_cd, style_cd);
            ClassLib.ComFunction.OpenFormByName(pop_form.GetType().FullName.ToString());

           
					


        }



        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ �޼���



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1) return;


           
            Event_Tbtn_New();




            string factory = cmb_Factory.SelectedValue.ToString();


            // plan_month ����
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



            // outgoing type : PRODUCTION, OTHER
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxEISMatCostOutType);  // "EIS_MAT_14";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OutType, 1, 2, true, COM.ComVar.ComboList_Visible.Name);

            if (dt_ret.Rows.Count > 0)
            {
                cmb_OutType.SelectedIndex = 0;
            }
            else
            {
                cmb_OutType.SelectedIndex = -1;
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


            // plan_week ����
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
            string out_type = ClassLib.ComFunction.Empty_Combo(cmb_OutType, " ");
            
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
        /// Event_cmb_OutType_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_OutType_SelectedValueChanged()
        {

            if (cmb_OutType.SelectedIndex == -1) return;


            Event_Tbtn_New();


            //// line_group
            //string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            //string plan_month = ClassLib.ComFunction.Empty_Combo(cmb_PlanMonth, " ").Replace("-", "");
            //string plan_week = ClassLib.ComFunction.Empty_Combo(cmb_PlanWeek, " ");
            //string out_type = ClassLib.ComFunction.Empty_Combo(cmb_OutType, " ");

            //DataTable dt_ret = SELECT_WEEKLY_FACTORY_GROUP(factory, plan_month, plan_week, out_type);
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineGroup, 0, 0, true, COM.ComVar.ComboList_Visible.Name);

            //dt_ret.Dispose();


        }




        /// <summary>
        /// Event_cmb_LineGroup_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_LineGroup_SelectedValueChanged()
        {


            cmb_Line.SelectedIndex = -1;
            fgrid_Main.ClearAll();
            

            if (cmb_LineGroup.SelectedIndex == -1) return;



            Event_txt_StyleCd_KeyUp();



            // line
            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string plan_month = ClassLib.ComFunction.Empty_Combo(cmb_PlanMonth, " ").Replace("-", "");
            string plan_week = ClassLib.ComFunction.Empty_Combo(cmb_PlanWeek, " ");
            string out_type = ClassLib.ComFunction.Empty_Combo(cmb_OutType, " ");
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

            Event_txt_StyleCd_KeyUp();


        }



        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary>
        private void Event_txt_StyleCd_KeyUp()
        {

            //-------------------------------------------------------------------------
            // ��Ÿ ��Ʈ�� �ʱ�ȭ 
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
            // ��Ÿ ��Ʈ�� �ʱ�ȭ 
            fgrid_Main.ClearAll();
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


            if (src == rad_Week)
            {

                fgrid_Main.Tree.Show(1);

            }
            else if (src == rad_OutType)
            {

                fgrid_Main.Tree.Show(2);

            }
            else if (src == rad_FactoryGroup)
            {

                fgrid_Main.Tree.Show(3);

            }
            else if (src == rad_Line)
            {

                fgrid_Main.Tree.Show(4);

            }
            else if (src == rad_Style)
            {

                fgrid_Main.Tree.Show(-1);

            }



        }



        /// <summary>
        /// Event_btn_WarningRange_Click : 
        /// </summary>
        private void Event_btn_WarningRange_Click()
        {


            // ǥ�� ��� ��� ���� ����
            Display_Warning_Profit_Ratio();


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



                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxFORECAST_YN].ToString().Trim().Equals("Y"))
                {

                    // �ش� Row ���ڻ� ����
                    CellStyle cellst_forecast = fgrid_Main.Styles.Add("FORECAST" + i.ToString());
                    //cellst_forecast.ForeColor = Color.Gray;
                    cellst_forecast.BackColor = Color.Empty;

                    // i - 2 : ���� subtotal row ���� ������ ���� ������ ���� ó��
                    CellRange cr_forecast = fgrid_Main.GetCellRange(i - 5, 1, i, fgrid_Main.Cols.Count - 1);
                    cr_forecast.Style = fgrid_Main.Styles["FORECAST" + i.ToString()];


                    //// subtotal row ���� ������ ���� ������ ���� ó��
                    //// SUBTOTAL ROW �̱� ������ DEFAULT : 0.0, ToString() : 0
                    //for (int a = 1; a <= 4; a++)
                    //{

                    //    if (fgrid_Main[i - a, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxFORECAST_YN] == null
                    //        || fgrid_Main[i - a, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxFORECAST_YN].ToString().Trim().Equals("")
                    //        || fgrid_Main[i - a, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxFORECAST_YN].ToString().Trim().Equals("0"))
                    //    {
                    //        fgrid_Main[i - a, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxFORECAST_YN] = "Y";
                    //    }

                    //}


                    continue;


                }


           


                // MPS Production ��� ���
                if (fgrid_Main.Rows[i].Node.Level == 2) // out_type subtotal
                {
                    if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxPLAN_WEEK_DESC].ToString().Trim().Equals("Etc"))
                    {
                        break;  // order by ������ etc ���ϴ� ��� etc �������̹Ƿ� warning �����ص� ����
                    }
                }



                



                double out_profit_ratio = 0;



                if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO] == null
                    || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO].ToString().Trim().Equals(""))
                {
                    out_profit_ratio = 0;
                }
                else
                {
                    out_profit_ratio = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO].ToString());
                }




                CellRange cr = fgrid_Main.GetCellRange(i, (int)ClassLib.TBEIS_MATPRICE_WEEKLY_DIVISION.IxAMOUNT_OUT_PROFIT_RATIO);

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
                    else if (fgrid_Main.Rows[i].Node.Level == 2) // out_type
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal2;
                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 3) // factory group
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal3;
                    }
                    else if (fgrid_Main.Rows[i].Node.Level == 4) // line
                    {
                        color_default = ClassLib.ComVar.ClrSubTotal4;
                    }

                }
                else  // style
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




        #endregion

        #region ���ؽ�Ʈ �޴� �̺�Ʈ �޼���

       

        #endregion



        #endregion 

        #region �̺�Ʈ ó��

        #region ���� �̺�Ʈ


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

        #region �׸��� �̺�Ʈ


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

        #region ��ư �� ��Ÿ �̺�Ʈ


        #region ��ưŬ���� �̹�������


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


        private void Form_EIS_Weekly_Price_Style_Load(object sender, EventArgs e)
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


        private void cmb_OutType_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_OutType_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_OutType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        #endregion

        #region ���ؽ�Ʈ �޴� �̺�Ʈ

        



        #endregion

        #endregion

        #region ��� ����


        #region �޺�


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

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_PLAN_MONTH";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;


                //04.DATA ����
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

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_PLAN_WEEK";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA ����
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

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_FACTORY_GROUP";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";


                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;


                //04.DATA ����
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

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_LINE";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";


                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;


                //04.DATA ����
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

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_STYLE_CD";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";


                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;


                //04.DATA ����
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

        #region ��ȸ



        /// <summary>
        /// SELECT_WEEKLY_DIVISION : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_plan_week"></param>
        /// <param name="arg_out_type"></param>
        /// <param name="arg_line_group"></param>
        /// <param name="arg_line_cd"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_WEEKLY_DIVISION(string arg_factory,
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

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_WEEK_DIVISION.SELECT_WEEKLY_DIVISION";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_MONTH";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_WEEK";
                MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";


                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;


                //04.DATA ����
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

       
     
        #endregion
       




    }
}




