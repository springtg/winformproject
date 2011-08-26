using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Xml;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FlexSQM
{
    public partial class Form_Component_Payment : COM.SQMWinForm.Form_Top
    {
        public Form_Component_Payment()
        {
            InitializeComponent();
            Init_Control();
            setDPO();
        }

        private const int G1_FACTORY        = 1;
        private const int G1_VENDOR_CD      = 2;
        private const int G1_VENDOR_NM      = 3;
        private const int G1_DPO            = 4;
        private const int G1_STYLE_CD       = 5;
        private const int G1_STYLE_NM       = 6;
        private const int G1_LOT_NO         = 7;
        private const int G1_COMP_CD        = 8;
        private const int G1_COMP_NM        = 9;
        private const int G1_PROCESS_CD     = 10;
        private const int G1_PROCESS_NM     = 11;
        private const int G1_QTY            = 12;


        private const int G2_FACTORY        = 1;
        private const int G2_VENDOR_CD      = 2;
        private const int G2_VENDOR_NM      = 3;
        private const int G2_DPO            = 4;
        private const int G2_STYLE_CD       = 5;
        private const int G2_STYLE_NM       = 6;
        private const int G2_LOT_NO         = 7;
        private const int G2_COMP_CD        = 8;
        private const int G2_COMP_NM        = 9;
        private const int G2_PROCESS_CD     = 10;
        private const int G2_PROCESS_NM     = 11;
        private const int G2_QTY            = 12;
        private const int G2_PRICE          = 13;
        private const int G2_CURR           = 14;
        private const int G2_AMT_USD        = 15;
        private const int G2_AMT_VND        = 16;




        private void Init_Control()
        {
            DataTable dt_ret;
            dt_ret = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            dt_ret = Select_Vendor_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Vendor.SelectedValue = " ";

            fgrid_Style_InComing.Set_Grid("SQM_PAYMENT_COMP_IN", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Style_InComing.Set_Action_Image(img_Action);

            fgrid_Style_Payment.Set_Grid("SQM_PAYMENT_FORM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Style_Payment.Set_Action_Image(img_Action);


            dt_ret = Select_Exchange_rate();
            txtExchangeRate.Text = Convert.ToString(dt_ret.Rows[0][1]);
            Set_Date();
            
        }

        private void Set_Date()
        {
            string month = DateTime.Now.AddMonths(-1).Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string day = "25";
            string date_time = year + "-" + month + "-" + day;    
            dpick_From.Value = Convert.ToDateTime(date_time);
        }

        public static DataTable Select_Exchange_rate()
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.sp_sel_exchange_rate";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Select_Vendor_List()
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_sqm_cust";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
        private void setDPO()
        {
            DataTable dt_ret = Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2");

            COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_fr, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_obsid_fr.SelectedIndex = 0;
        }

        public DataTable Select_DP_DPO_List(string arg_factory, string arg_division)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_SBM_DP_DPO_LIST";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_division;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }

        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Search_Process();
        }
        private void Search_Process()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                fgrid_Style_InComing.ClearAll();
                fgrid_Style_Payment.ClearAll();
                Display_FlexGrid(SearchData(Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(cmb_obsid_fr.SelectedValue), Convert.ToString(cmb_Vendor.SelectedValue),txtItem.Text,dpick_From.Text,dpick_to.Text)); 
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SearchData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
        }
        private DataTable SearchData(string p_factory, string p_dpo, string p_vendor_cd,string p_item,string p_date_from,string p_date_to)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.sp_sel_style_for_pay";

                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_dpo";
                MyOraDB.Parameter_Name[2] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[3] = "arg_item";
                MyOraDB.Parameter_Name[4] = "arg_ped_from";
                MyOraDB.Parameter_Name[5] = "arg_ped_to";
                MyOraDB.Parameter_Name[6] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_dpo;
                MyOraDB.Parameter_Values[2] = p_vendor_cd;
                MyOraDB.Parameter_Values[3] = p_item;
                MyOraDB.Parameter_Values[4] = p_date_from.Replace("-","");
                MyOraDB.Parameter_Values[5] = p_date_to.Replace("-","");
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void Display_FlexGrid(DataTable arg_dt)
        {
            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = fgrid_Style_InComing.Rows.InsertNode(fgrid_Style_InComing.Rows.Fixed + iRow, 1);
                fgrid_Style_InComing[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_Style_InComing[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }

        private void txtExchangeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void fgrid_Style_InComing_DoubleClick(object sender, EventArgs e)
        {
            if (CheckExist() == true)
            {
                if (Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_VENDOR_NM]) == "TOTAL")
                {
                    fgrid_Style_Payment.Rows.Remove(fgrid_Style_Payment.Rows.Count - 1);
                }
                fgrid_Style_Payment.Rows.Add();
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_FACTORY] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_FACTORY];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_VENDOR_CD] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_VENDOR_CD];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_VENDOR_NM] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_VENDOR_NM];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_DPO] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_DPO];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_STYLE_CD] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_STYLE_CD];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_STYLE_NM] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_STYLE_NM];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_LOT_NO] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_LOT_NO];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_COMP_CD] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_COMP_CD];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_COMP_NM] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_COMP_NM];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_PROCESS_CD] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_PROCESS_CD];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_PROCESS_NM] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_PROCESS_NM];
                fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_QTY] = fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_QTY];
                string p_factory = Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_FACTORY]);
                string p_dpo = Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_DPO]);
                string p_style_cd = Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_STYLE_CD]).Replace("-", "");
                string p_vendor_cd = Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_VENDOR_CD]);
                string p_comp_cd = Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_COMP_CD]);
                string p_process_cd = Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_PROCESS_CD]);

                DataTable dt = GetPrice(p_factory, p_dpo, p_style_cd, p_vendor_cd, p_comp_cd, p_process_cd);
                if (dt.Rows.Count > 0)
                {
                    fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_PRICE] = dt.Rows[0][0];
                    fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_CURR] = dt.Rows[0][1];
                }
                if (Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_CURR]) == "VND")
                {
                    fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_VND] = Math.Round(Convert.ToDecimal(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_PRICE]) * Convert.ToDecimal(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_QTY]),0);
                    fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_USD] = Math.Round(Convert.ToDecimal(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_VND]) / Convert.ToDecimal(txtExchangeRate.Text),2);
                }
                else
                {
                    fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_USD] = Math.Round(Convert.ToDecimal(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_PRICE]) * Convert.ToDecimal(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_QTY]), 2);
                    fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_VND] = Math.Round(Convert.ToDecimal(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_USD]) * Convert.ToDecimal(txtExchangeRate.Text), 0);
                }

                Cal_Row_Sum();
            }
            else
            {
                MessageBox.Show("This Item Already Selected Below");
            }
        }

        private DataTable GetPrice(string p_factory, string p_dpo, string p_style_cd, string p_vendor_cd,string p_comp_cd,string p_process_cd)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.sp_sel_price";

                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_dpo";
                MyOraDB.Parameter_Name[2] = "arg_style_cd";
                MyOraDB.Parameter_Name[3] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[4] = "arg_comp_cd";
                MyOraDB.Parameter_Name[5] = "arg_process_cd";
                MyOraDB.Parameter_Name[6] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_dpo;
                MyOraDB.Parameter_Values[2] = p_style_cd;
                MyOraDB.Parameter_Values[3] = p_vendor_cd;
                MyOraDB.Parameter_Values[4] = p_comp_cd;
                MyOraDB.Parameter_Values[5] = p_process_cd;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void cmb_Vendor_SelectedValueChanged(object sender, EventArgs e)
        {
            fgrid_Style_InComing.ClearAll();
            fgrid_Style_Payment.ClearAll();
            Search_Process();    
        }

        private bool CheckExist()
        {
            for (int i = fgrid_Style_Payment.Rows.Fixed; i < fgrid_Style_Payment.Rows.Count; i++)
            {
                if (Convert.ToString(fgrid_Style_Payment.Rows[i][G2_FACTORY]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_FACTORY]).Trim()) &&
                   Convert.ToString(fgrid_Style_Payment.Rows[i][G2_DPO]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_DPO]).Trim()) &&
                   Convert.ToString(fgrid_Style_Payment.Rows[i][G2_STYLE_CD]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_STYLE_CD]).Trim()) &&
                  Convert.ToString(fgrid_Style_Payment.Rows[i][G2_VENDOR_CD]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_VENDOR_CD]).Trim()) &&
                  Convert.ToString(fgrid_Style_Payment.Rows[i][G2_COMP_CD]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_COMP_CD]).Trim()) &&
                  Convert.ToString(fgrid_Style_Payment.Rows[i][G2_PROCESS_CD]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_PROCESS_CD]).Trim()) &&
                  Convert.ToString(fgrid_Style_Payment.Rows[i][G2_LOT_NO]).Trim().Equals(Convert.ToString(fgrid_Style_InComing.Rows[fgrid_Style_InComing.Row][G1_LOT_NO]).Trim()))
                {
                    return false;
                }
            }
            return true;
        }
        private void Cal_Row_Sum()
        {
            if (Convert.ToString(fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_VENDOR_NM]) == "TOTAL")
            {
                fgrid_Style_Payment.Rows.Remove(fgrid_Style_Payment.Rows.Count - 1);
            }
            fgrid_Style_Payment.Rows.Add();
            fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1].StyleNew.BackColor = Color.Yellow;
            fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1].StyleNew.Font.Bold.Equals(true);
            fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_VENDOR_NM] = "TOTAL";
            decimal total_vnd = 0;
            decimal total_usd = 0;
            for (int i = fgrid_Style_Payment.Rows.Fixed; i <= fgrid_Style_Payment.Rows.Count - 2; i++)
            {
                total_vnd = total_vnd + Convert.ToDecimal(fgrid_Style_Payment.Rows[i][G2_AMT_VND]);
                total_usd = total_usd + Convert.ToDecimal(fgrid_Style_Payment.Rows[i][G2_AMT_USD]);
            }
            fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_USD] = total_usd;
            fgrid_Style_Payment.Rows[fgrid_Style_Payment.Rows.Count - 1][G2_AMT_VND] = total_vnd;
            
        }

        private void fgrid_Style_Payment_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_Style_Payment.Row != fgrid_Style_Payment.Rows.Count - 1 && fgrid_Style_Payment.Row>=fgrid_Style_Payment.Rows.Fixed)
            {
                fgrid_Style_Payment.Rows.Remove(fgrid_Style_Payment.Row);
                if (fgrid_Style_Payment.Rows.Count > 3)
                {
                    Cal_Row_Sum();
                }
                else
                {
                    fgrid_Style_Payment.ClearAll();
                }
                
            }
        }
        private string payment_no = "";
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (fgrid_Style_Payment.Rows.Count < 3)
            {
                MessageBox.Show("Please Select Items To Print Payment");
            }
            else
            {
                if (ClassLib.ComFunction.User_Message("Are You Sure To Create This Payment ?", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = SELECT_PAY_NO();
                    payment_no = Convert.ToString(dt.Rows[0][0]);
                    SAVE_DATA_TEMP();
                    DISPLAY_REPORT();
                    fgrid_Style_InComing.ClearAll();
                    fgrid_Style_Payment.ClearAll();
                    Search_Process();
                }
            }
        }

        private DataTable SELECT_PAY_NO()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.sp_sel_max_pay_no";

                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[2] = "arg_pay_from";
                MyOraDB.Parameter_Name[3] = "arg_pay_to";
                MyOraDB.Parameter_Name[4] = "arg_upd_user";
                MyOraDB.Parameter_Name[5] = "arg_rate";
                MyOraDB.Parameter_Name[6] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Factory.SelectedValue);
                MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_Vendor.SelectedValue);
                MyOraDB.Parameter_Values[2] = Convert.ToString(dpick_From.Text.Replace("-",""));
                MyOraDB.Parameter_Values[3] = Convert.ToString(dpick_to.Text.Replace("-",""));
                MyOraDB.Parameter_Values[4] = Convert.ToString(COM.ComVar.This_User);
                MyOraDB.Parameter_Values[5] = txtExchangeRate.Text.Replace(",","");
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
        private void SAVE_DATA_TEMP()
        {

            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                int iCount = 20;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                MyOraDB.Process_Name = "PKG_SQM_CUST.sp_ins_payment_temp";

                //02.ARGURMENT OF PROC
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_VENDOR_CD";
                MyOraDB.Parameter_Name[2] = "ARG_VENDOR_NM";
                MyOraDB.Parameter_Name[3] = "ARG_DPO";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_NM";
                MyOraDB.Parameter_Name[6] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[7] = "ARG_COMP_CD";
                MyOraDB.Parameter_Name[8] = "ARG_COMP_NM";
                MyOraDB.Parameter_Name[9] = "ARG_PROCESS_CD";
                MyOraDB.Parameter_Name[10] = "ARG_PROCESS_NM";
                MyOraDB.Parameter_Name[11] = "ARG_QTY";
                MyOraDB.Parameter_Name[12] = "ARG_PRICE";
                MyOraDB.Parameter_Name[13] = "ARG_CURR";
                MyOraDB.Parameter_Name[14] = "ARG_AMT_USD";
                MyOraDB.Parameter_Name[15] = "ARG_AMT_VND";
                MyOraDB.Parameter_Name[16] = "ARG_PAY_NO";
                MyOraDB.Parameter_Name[17] = "ARG_PAY_FROM";
                MyOraDB.Parameter_Name[18] = "ARG_PAY_TO";
                MyOraDB.Parameter_Name[19] = "ARG_UPD_USER";

                

                //03. Type
                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                //MyOraDB.Parameter_Type[11] = (int)OracleType.Number;
                //MyOraDB.Parameter_Type[12] = (int)OracleType.Number;
                //MyOraDB.Parameter_Type[14] = (int)OracleType.Number;
                //MyOraDB.Parameter_Type[15] = (int)OracleType.Number;

                ArrayList temp = new ArrayList();

                for (int iRow = fgrid_Style_Payment.Rows.Fixed; iRow < fgrid_Style_Payment.Rows.Count-1; iRow++)
                {
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_FACTORY]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_VENDOR_CD]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_VENDOR_NM]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_DPO]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_STYLE_CD]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_STYLE_NM]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_LOT_NO]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_COMP_CD]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_COMP_NM]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_PROCESS_CD]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_PROCESS_NM]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_QTY]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_PRICE]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_CURR]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_AMT_USD]));
                    temp.Add(Convert.ToString(fgrid_Style_Payment.Rows[iRow][G2_AMT_VND]));
                    temp.Add(payment_no);
                    temp.Add(dpick_From.Text.Replace("-",""));
                    temp.Add(dpick_to.Text.Replace("-", ""));
                    temp.Add(Convert.ToString(COM.ComVar.This_User));
      
                }
                MyOraDB.Parameter_Values = new string[temp.Count];

                for (int j = 0; j < temp.Count; j++)
                {
                    MyOraDB.Parameter_Values[j] = temp[j].ToString();
                }
                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

            }
            catch (System.Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void DELETE_DATA_TEMP()
        //{
        //    int iCount = 1;
        //    int para_ct = 0;
        //    COM.OraDB MyOraDB = new COM.OraDB();
        //    MyOraDB.ReDim_Parameter(iCount);
        //    MyOraDB.Process_Name = "PKG_SQM_CUST.sp_del_payment_temp";
        //    MyOraDB.Parameter_Name[0] = "ARG_TEMP";
        //    MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    MyOraDB.Parameter_Values[para_ct + 0] = "";
        //    MyOraDB.Add_Modify_Parameter(true);
        //    MyOraDB.Exe_Modify_Procedure();
        //}

        private void DISPLAY_REPORT()
        {
            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Payment_For_Vendor");
            string Para = " ";
            int iCnt = 3;
            string[] aHead = new string[iCnt];


            
            aHead[0] = COM.ComVar.This_User_AD.ToString();
            aHead[1] = payment_no;
            aHead[2] = "";

            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);
            report.Show();
        }

        private void dpick_From_ValueChanged(object sender, EventArgs e)
        {
            fgrid_Style_InComing.ClearAll();
            fgrid_Style_Payment.ClearAll();
            Search_Process();
        }
        private void dpick_to_ValueChanged_1(object sender, EventArgs e)
        {
            fgrid_Style_InComing.ClearAll();
            fgrid_Style_Payment.ClearAll();
            Search_Process();
        }
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form_Payment_Management fo = new Form_Payment_Management();
            fo.ShowDialog();
        }

        
    }
}