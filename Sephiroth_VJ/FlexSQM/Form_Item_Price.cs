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

namespace FlexSQM
{
    public partial class Form_Item_Price : COM.SQMWinForm.Pop_Large
    {
        public Form_Item_Price()
        {
            InitializeComponent();
            Init_Control();
        }


        private COM.OraDB oraDB = null;

        private const int G_FACTORY     = 1;
        private const int G_DPO         = 2;
        private const int G_STYLE_CD    = 3;
        private const int G_STYLE_NM    = 4;
        private const int G_VENDOR_CD   = 5;
        private const int G_VENDOR_NM   = 6;
        private const int G_COMP_CD     = 7;
        private const int G_COMP_NM     = 8;
        private const int G_COMP_UNIT   = 9;
        private const int G_PRO_CD      = 10;
        private const int G_UNIT_PRICE  = 11;
        private const int G_CURR_UNIT   = 12;
        private const int G_REMARK      = 13;


        private void Init_Control()
        {
            DataTable dt_ret;

            // factory
            dt_ret = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            dt_ret.Dispose(); 

            fgrid_Item_Price.Set_Grid("SQM_ITEM_PRICE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Item_Price.Set_Action_Image(img_Action);

            dt_ret = Select_Vendor_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Vendor.SelectedValue = " ";

            setDPO();
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
        private void Clear_FlexGrid()
        {
            if (fgrid_Item_Price.Rows.Fixed != fgrid_Item_Price.Rows.Count)
            {
                fgrid_Item_Price.Clear(ClearFlags.UserData, fgrid_Item_Price.Rows.Fixed, 1, fgrid_Item_Price.Rows.Count - 1, fgrid_Item_Price.Cols.Count - 1);

                fgrid_Item_Price.Rows.Count = fgrid_Item_Price.Rows.Fixed;

            }
        }

        private DataTable SearchData(string p_factory,string p_dpo,string p_vendor, string p_item)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.sp_sel_item_price";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_dpo";
                MyOraDB.Parameter_Name[2] = "ARG_VENDOR";
                MyOraDB.Parameter_Name[3] = "ARG_ITEM";
                MyOraDB.Parameter_Name[4] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_dpo;
                MyOraDB.Parameter_Values[2] = p_vendor;
                MyOraDB.Parameter_Values[3] = p_item;
                MyOraDB.Parameter_Values[4] = "";

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
                C1.Win.C1FlexGrid.Node newRow = fgrid_Item_Price.Rows.InsertNode(fgrid_Item_Price.Rows.Fixed + iRow, 1);
                fgrid_Item_Price[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_Item_Price[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Clear_FlexGrid();
                Display_FlexGrid(SearchData(Convert.ToString(cmb_Factory.SelectedValue),Convert.ToString(cmb_obsid_fr.SelectedValue) ,Convert.ToString(cmb_Vendor.SelectedValue), txtItem.Text));
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

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (Convert.ToString(cmb_Vendor.SelectedValue) != " ")
            {
                fgrid_Item_Price.Add_Row(fgrid_Item_Price.Rows.Count - 1);
                fgrid_Item_Price.Rows[fgrid_Item_Price.Rows.Count - 1][G_FACTORY] = cmb_Factory.SelectedValue;
                fgrid_Item_Price.Rows[fgrid_Item_Price.Rows.Count - 1][G_VENDOR_NM] = cmb_Vendor.Text;
                fgrid_Item_Price.Rows[fgrid_Item_Price.Rows.Count - 1][G_VENDOR_CD] = cmb_Vendor.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please Select Vendor To Add New");
            }
        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = fgrid_Item_Price.Selections.Length - 1; i >= 0; i--)
                {
                    if (Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.Selections[i]][0]) == "" || Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.Selections[i]][0])=="U")
                    {
                        //MessageBox.Show(Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.Selections[i]][G_SEQ]));
                        fgrid_Item_Price.Delete_Row(fgrid_Item_Price.Selections[i]);
                    }
                    else
                    {
                        fgrid_Item_Price.Rows.Remove(fgrid_Item_Price.Selections[i]);
                    }
                }
            }
            catch (System.Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (Savedata(true))
            {
                tbtn_Search_Click(tbtn_Search, null);
                ClassLib.ComFunction.User_Message("Upload Data Sucess!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool Savedata(bool doExecute)
        {
            try
            {
                COM.OraDB oraDB = new COM.OraDB();
                int para_ct = 0;
                int iCount = 12;
                oraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                oraDB.Process_Name = "pkg_sqm_cust.sp_ins_sqm_item_price";

                //02.ARGURMENT OF PROC

                oraDB.Parameter_Name[0] = "arg_division";
                oraDB.Parameter_Name[1] = "arg_factory";
                oraDB.Parameter_Name[2] = "arg_dpo";
                oraDB.Parameter_Name[3] = "arg_style_cd";
                oraDB.Parameter_Name[4] = "arg_vendor_cd";
                oraDB.Parameter_Name[5] = "arg_comp_cd";
                oraDB.Parameter_Name[6] = "arg_comp_unit";
                oraDB.Parameter_Name[7] = "arg_process_cd";
                oraDB.Parameter_Name[8] = "arg_unit_price";
                oraDB.Parameter_Name[9] = "arg_curr_unit";
                oraDB.Parameter_Name[10] = "arg_remark";
                oraDB.Parameter_Name[11] = "arg_user_upd";


                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                oraDB.Parameter_Type[8] = (int)OracleType.Number;

                oraDB.Parameter_Values = new string[iCount * (fgrid_Item_Price.Rows.Count - fgrid_Item_Price.Rows.Fixed)];

                for (int iRow = fgrid_Item_Price.Rows.Fixed; iRow < fgrid_Item_Price.Rows.Count; iRow++)
                {
                    oraDB.Parameter_Values[para_ct + 0] = Convert.ToString(fgrid_Item_Price[iRow, 0]);
                    oraDB.Parameter_Values[para_ct + 1] = Convert.ToString(fgrid_Item_Price[iRow, G_FACTORY]);
                    oraDB.Parameter_Values[para_ct + 2] = Convert.ToString(fgrid_Item_Price[iRow, G_DPO]);
                    oraDB.Parameter_Values[para_ct + 3] = Convert.ToString(fgrid_Item_Price[iRow, G_STYLE_CD]);
                    oraDB.Parameter_Values[para_ct + 4] = Convert.ToString(fgrid_Item_Price[iRow, G_VENDOR_CD]);
                    oraDB.Parameter_Values[para_ct + 5] = Convert.ToString(fgrid_Item_Price[iRow, G_COMP_CD]);
                    oraDB.Parameter_Values[para_ct + 6] = Convert.ToString(fgrid_Item_Price[iRow, G_COMP_UNIT]);
                    oraDB.Parameter_Values[para_ct + 7] = Convert.ToString(fgrid_Item_Price[iRow, G_PRO_CD]);
                    oraDB.Parameter_Values[para_ct + 8] = Convert.ToString(fgrid_Item_Price[iRow, G_UNIT_PRICE]);
                    oraDB.Parameter_Values[para_ct + 9] = Convert.ToString(fgrid_Item_Price[iRow, G_CURR_UNIT]);
                    oraDB.Parameter_Values[para_ct + 10] = Convert.ToString(fgrid_Item_Price[iRow, G_REMARK]);
                    oraDB.Parameter_Values[para_ct + 11] = COM.ComVar.This_User;
                    para_ct += iCount;
                }

                oraDB.Add_Modify_Parameter(true);

                if (doExecute)
                {
                    if (oraDB.Exe_Modify_Procedure() == null)
                        return false;
                    else
                        return true;
                }

                return true;

            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private void fgrid_Item_Price_AfterEdit(object sender, RowColEventArgs e)
        {
            fgrid_Item_Price.Update_Row(e.Row);
        }

        private void fgrid_Item_Price_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_Item_Price.RowSel < fgrid_Item_Price.Rows.Fixed) return;
            if (fgrid_Item_Price.ColSel == G_STYLE_CD || fgrid_Item_Price.ColSel == G_STYLE_NM)
            {
                Form_Select_Style fo = new Form_Select_Style();
                 if (fo.ShowDialog() == DialogResult.OK)
                {
                    fgrid_Item_Price.Rows[fgrid_Item_Price.RowSel][G_STYLE_CD] = fo.l_style_cd;
                    fgrid_Item_Price.Rows[fgrid_Item_Price.RowSel][G_STYLE_NM] = fo.l_style_nm;
                    fgrid_Item_Price.Rows[fgrid_Item_Price.RowSel][G_DPO] = fo.l_dpo;
                }
            }
            if (fgrid_Item_Price.ColSel == G_COMP_CD || fgrid_Item_Price.ColSel == G_COMP_NM)
            {
                string p_style_cd = Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.RowSel][G_STYLE_CD]);
                if (p_style_cd != "")
                {
                    Form_Select_Item fo = new Form_Select_Item(p_style_cd);
                    if (fo.ShowDialog() == DialogResult.OK)
                    {
                        fgrid_Item_Price.Rows[fgrid_Item_Price.RowSel][G_COMP_CD] = fo.l_comp_cd;
                        fgrid_Item_Price.Rows[fgrid_Item_Price.RowSel][G_COMP_NM] = fo.l_comp_nm;
                    }
                }
                else
                {
                    MessageBox.Show("Select Item First!!!");
                }
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string p_dpo= Convert.ToString(cmb_obsid_fr.SelectedValue);
            string p_factory = Convert.ToString(cmb_Factory.SelectedValue);
            string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
            string p_item = txtItem.Text;


            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Item_Price");
            string Para = " ";


            int iCnt = 5;
            string[] aHead = new string[iCnt];
  
            aHead[0] = p_factory;
            aHead[1] = p_dpo;
            aHead[2] = p_vendor_cd;
            aHead[3] = p_item;
            aHead[4] = "";
            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);
            report.Show();
        }

    }
}