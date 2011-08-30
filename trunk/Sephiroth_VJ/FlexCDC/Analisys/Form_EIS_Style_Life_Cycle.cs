using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;
using C1.Win.C1Chart;
using ChartFX.WinForms;
using ChartFX.WinForms.DataProviders;

namespace EIS.PCC
{
    public partial class Form_EIS_Style_Life_Cycle : COM.APSWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction MyComFunction = new COM.ComFunction();
        #endregion
        
        #region 생성자
        public Form_EIS_Style_Life_Cycle()
        {
            InitializeComponent();                   
        }
        #endregion

        #region Form Loading
        private void Form_EIS_Style_Life_Cycle_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form(); 
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = "Style Life Cycle";
                lbl_MainTitle.Text = "Style Life Cycle";
                lbl_title.Text = "      Search Condition";

                Init_Grid();
                Init_Control();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Init_Grid()
        {
            //Grid setting
            fgrid_Order.Set_Grid("EIS_STYLE_LIFE_CYCLE", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Order.Font = new Font("Verdana", 8);
            fgrid_Order.ExtendLastCol = false;
        }
        private void Init_Control()
        {
            // Disabled tbutton
            tbtn_New.Enabled    = false;
            tbtn_Save.Enabled   = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled  = false;
            tbtn_Print.Enabled  = false;

            // 공장 Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Factory.SelectedIndex = 0;

            // Month from, to add items
            dt_ret = Select_Month_List();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Month_From, 0, 1, false, 0, 140);
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Month_To, 0, 1, false, 0, 140);
            dt_ret.Dispose();
            cmb_Month_From.SelectedIndex = 5; cmb_Month_To.SelectedIndex = 0;


            //// Style  Setting..
            dt_ret = Select_Style(cmb_Factory.SelectedValue.ToString(),
                                  cmb_Month_From.SelectedValue.ToString().Replace("-", ""),
                                  cmb_Month_To.SelectedValue.ToString().Replace("-", ""),
                                  "",
                                  ClassLib.ComFunction.Empty_TextBox(txt_Style_Code, " "));
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Style_Code, 3, 4, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Style_Code.SelectedIndex = 0;
            cmb_Style_Code.Splits[0].DisplayColumns[0].Width = 100;
            cmb_Style_Code.Splits[0].DisplayColumns[1].Width = 150;
        }

        private DataTable Select_Month_List()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EOM_ORDER.select_monthly_list";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
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
        private DataTable Select_Style(string arg_factory, string arg_order_month_from, string arg_order_month_to, string arg_category_cd, string arg_style_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EOM_ORDER.select_style_list";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_EIS_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_EIS_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY_CD";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
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
                MyOraDB.Parameter_Values[1] = arg_order_month_from;
                MyOraDB.Parameter_Values[2] = arg_order_month_to;
                MyOraDB.Parameter_Values[3] = arg_category_cd;
                MyOraDB.Parameter_Values[4] = arg_style_cd;
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

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Display_Grid();
            }
            catch
            {

            }
        }

        private void Display_Grid()
        {
            try
            {               
                DataTable dt_ret;
                
                string arg_factory   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
                string arg_date_from = cmb_Month_From.SelectedValue.ToString().Replace("-", "");
                string arg_date_to   = cmb_Month_To.SelectedValue.ToString().Replace("-", "");
                string arg_style_cd  = cmb_Style_Code.SelectedValue.ToString();

                dt_ret = Select_Monthly_T(arg_factory, arg_date_from, arg_date_to);
                Display_Monthly(dt_ret, "T");

                dt_ret = Select_Monthly_D(arg_factory, arg_date_from, arg_date_to, "", arg_style_cd);
                Display_Monthly(dt_ret, "D");

                fgrid_Order.Tree.Show((int)ClassLib.TBEIS_ORDER_MONTH_MD.IxCATEGORY_NAME);
            }
            catch
            {

            }
        }
        private void Display_Monthly(DataTable arg_dt, string arg_div)
        {
            if (arg_dt.Rows.Count == 0) return;


            
            // merge           
            fgrid_Order.AllowMerging = AllowMergingEnum.Free;

            for (int i = fgrid_Order.Cols.Fixed; i < fgrid_Order.Cols.Count; i++)
            {
                if (i >= (int)ClassLib.TBEIS_ORDER_MONTH.IxFACTORY && i < (int)ClassLib.TBEIS_ORDER_MONTH.IxFOB)
                    fgrid_Order.MergedRanges.Add(fgrid_Order.GetCellRange(0, i, 2, i));
                fgrid_Order.Cols[i].AllowMerging = true;
            }
            
            if (arg_div.Equals("T"))
            {
                #region  Title
                //fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed;
                fgrid_Order.Cols.Count = (int)ClassLib.TBEIS_ORDER_MONTH.IxCAT_PER + 1;

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {
                    fgrid_Order.Cols.Count = fgrid_Order.Cols.Count + 1;

                    fgrid_Order[1, fgrid_Order.Cols.Count - 1] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MT.IxSEASON_NAME - 1].ToString();
                    fgrid_Order[2, fgrid_Order.Cols.Count - 1] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MT.IxEIS_MONTH - 1].ToString();
                    fgrid_Order.Cols[fgrid_Order.Cols.Count - 1].Format = "###,###,###";
                }

                #endregion
            }
            else
            {
                fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed;
                string vModel = ""; double vModelTotQty = 0; double vModelPer = 0;

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {

                    fgrid_Order.Rows.Count = fgrid_Order.Rows.Count + 1;
                    for (int j = (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxFACTORY; j <= (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxCAT_PER; j++)
                    {
                        fgrid_Order[fgrid_Order.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();  //row추가
                    }

                    if (vModel == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMODEL_CD - 1].ToString())
                        fgrid_Order.Rows.Count = fgrid_Order.Rows.Count - 1;


                    if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMODEL_CD - 1].ToString() != vModel) { vModelTotQty = 0; vModelPer = 0; }


                    for (int k = (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxCAT_PER; k < fgrid_Order.Cols.Count; k++)
                    {
                        //key비교
                        if (fgrid_Order[2, k].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxEIS_MONTH - 1].ToString())
                        {
                            fgrid_Order[fgrid_Order.Rows.Count - 1, k] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxTOT_QTY - 1].ToString();

                            vModelTotQty = vModelTotQty + Convert.ToDouble(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxTOT_QTY - 1].ToString());
                            fgrid_Order[fgrid_Order.Rows.Count - 1, (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxTOT_QTY] = vModelTotQty;

                            vModelPer = vModelPer + Convert.ToDouble(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMOD_PER - 1].ToString());
                            fgrid_Order[fgrid_Order.Rows.Count - 1, (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMOD_PER] = vModelPer;

                            continue;
                        }
                    }
                    vModel = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMODEL_CD - 1].ToString();
                }

            }

            Set_Subtotal();
        }
        private void Set_Subtotal()
        {
            for (int i = 0; i < fgrid_Order.Cols.Count; i++)
            {
                fgrid_Order.Cols[i].AllowMerging = false;
            }
            for (int i = 0; i <= (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMODEL_NAME; i++)
            {
                fgrid_Order.Cols[i].AllowMerging = true;
            }
            CellStyle cStyle = fgrid_Order.Styles[CellStyleEnum.Subtotal0];
            cStyle.Font = new Font(fgrid_Order.Font, FontStyle.Regular);

            int iFactory = (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxFACTORY;
            int iCategory = (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxCATEGORY_NAME;

            fgrid_Order.SubtotalPosition = SubtotalPositionEnum.AboveData;

            //BY Factory
            fgrid_Order.Tree.Column = iFactory;

            for (int c = (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxTOT_QTY; c < fgrid_Order.Cols.Count; c++)
            {
                fgrid_Order.Subtotal(AggregateEnum.Sum, iFactory, iFactory, c, "{0}");
                fgrid_Order.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;
                fgrid_Order.Styles[CellStyleEnum.Subtotal1].BackColor = System.Drawing.Color.FromArgb(255, 255, 153);
                fgrid_Order.Styles[CellStyleEnum.Subtotal1].Format = "###,###,###.##";

                fgrid_Order.Subtotal(AggregateEnum.Sum, iCategory, iCategory, c, "{0}");
                fgrid_Order.Styles[CellStyleEnum.Subtotal3].ForeColor = Color.Black;
                fgrid_Order.Styles[CellStyleEnum.Subtotal3].BackColor = Color.Transparent;
                fgrid_Order.Styles[CellStyleEnum.Subtotal3].Format = "###,###,###.##";
            }
            for (int c = (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxFOB; c <= (int)ClassLib.TBEIS_ORDER_MONTH_MD.IxFOB; c++)
            {
                fgrid_Order.Subtotal(AggregateEnum.Average, iCategory, iCategory, c, "{0}");
                fgrid_Order.Styles[CellStyleEnum.Subtotal3].ForeColor = Color.Black;
                fgrid_Order.Styles[CellStyleEnum.Subtotal3].BackColor = System.Drawing.Color.FromArgb(192, 237, 254);
                fgrid_Order.Styles[CellStyleEnum.Subtotal3].Format = "###,###,###.##";
            }
        }

        private DataTable Select_Monthly_T(string arg_factory, string arg_order_month_from, string arg_order_month_to)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EOM_ORDER.select_monthly_title";  // .SELECT_MAT_PRICE_CLOSING_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_EIS_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_EIS_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_order_month_from;
                MyOraDB.Parameter_Values[2] = arg_order_month_to;
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
        private DataTable Select_Monthly_D(string arg_factory, string arg_order_month_from, string arg_order_month_to, string arg_category_cd, string arg_style_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EOM_ORDER.select_monthly_test";  // .SELECT_MAT_PRICE_CLOSING_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_EIS_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_EIS_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY_CD";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
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
                MyOraDB.Parameter_Values[1] = arg_order_month_from;
                MyOraDB.Parameter_Values[2] = arg_order_month_to;
                MyOraDB.Parameter_Values[3] = "";
                MyOraDB.Parameter_Values[4] = arg_style_cd;
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

        #region Control Event
        private void txt_Style_Code_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt_ret = Select_Style(cmb_Factory.SelectedValue.ToString(),
                                                   cmb_Month_From.SelectedValue.ToString().Replace("-", ""),
                                                   cmb_Month_To.SelectedValue.ToString().Replace("-", ""), "",
                                                   ClassLib.ComFunction.Empty_TextBox(txt_Style_Code, " "));
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Style_Code, 3, 4, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
        }
        private void lbl_viewFactory_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Order.Tree.Show((int)ClassLib.TBEIS_ORDER_MONTH_MD.IxFACTORY);
        }

        private void lbl_viewCategory_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Order.Tree.Show((int)ClassLib.TBEIS_ORDER_MONTH_MD.IxCATEGORY_NAME);
        }

        private void lbl_viewModel_CheckedChanged(object sender, EventArgs e)
        {

            fgrid_Order.Tree.Show((int)ClassLib.TBEIS_ORDER_MONTH_MD.IxMODEL_NAME);
        }

        #endregion
    }
}

