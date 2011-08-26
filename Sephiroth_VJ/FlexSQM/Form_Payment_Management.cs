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
    public partial class Form_Payment_Management : COM.SQMWinForm.Pop_Large
    {
        public Form_Payment_Management()
        {
            InitializeComponent();
            Init_Control();
        }

        private void Init_Control()
        {
            DataTable dt_ret;
            dt_ret = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            dt_ret = Select_Vendor_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Vendor.SelectedValue = " ";

            fgrid_List_payment.Set_Grid("SQM_PAID_PAYMENT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_List_payment.Set_Action_Image(img_Action);

            fgrid_Unpaid.Set_Grid("SQM_UNPAID_MANAGE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Unpaid.Set_Action_Image(img_Action);
            tbtn_New.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Conform.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Append.Enabled = false;

            if (COM.ComVar.This_JobCdoe == "B")
            {
                tbtn_Save.Enabled = true;
                tbtn_Delete.Enabled = true;
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

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Search_Process();
        }
        private void Search_Process()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;


                fgrid_List_payment.ClearAll();
                Display_FlexGrid(SearchData());

                fgrid_Unpaid.ClearAll();
                Display_FlexGrid1(SearchData1());


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
        private DataTable SearchData()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_paid_payment";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[2] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Factory.SelectedValue) ;
                MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_Vendor.SelectedValue) ;
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

        private DataTable SearchData1()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_unpaid_for_vendor";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[2] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Factory.SelectedValue);
                MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_Vendor.SelectedValue);
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
        private void Display_FlexGrid(DataTable arg_dt)
        {
            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = fgrid_List_payment.Rows.InsertNode(fgrid_List_payment.Rows.Fixed + iRow, 1);
                fgrid_List_payment[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_List_payment[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }

        private void Display_FlexGrid1(DataTable arg_dt)
        {
            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = fgrid_Unpaid.Rows.InsertNode(fgrid_Unpaid.Rows.Fixed + iRow, 1);
                fgrid_Unpaid[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_Unpaid[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }
        private void fgrid_List_payment_DoubleClick(object sender, EventArgs e)
        {
            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Payment_For_Vendor");
            string Para = " ";
            int iCnt = 3;
            string[] aHead = new string[iCnt];



            aHead[0] = COM.ComVar.This_User_AD.ToString();
            aHead[1] = Convert.ToString(fgrid_List_payment.Rows[fgrid_List_payment.Row][1]);
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

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (ClassLib.ComFunction.User_Message("Are You Sure To Delete This Payment ?", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    for (int i = fgrid_List_payment.Selections.Length - 1; i >= 0; i--)
                    {
                        if (Convert.ToString(fgrid_List_payment.Rows[fgrid_List_payment.Selections[i]][0]) != "I")
                        {
                            //MessageBox.Show(Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.Selections[i]][G_SEQ]));
                            fgrid_List_payment.Delete_Row(fgrid_List_payment.Selections[i]);
                        }
                        else
                        {
                            fgrid_List_payment.Rows.Remove(fgrid_List_payment.Selections[i]);
                        }
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
            Delete_Process();
            Search_Process(); 
        }
        private void Delete_Process()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                int iCount = 3;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                MyOraDB.Process_Name = "PKG_SQM_CUST.sp_del_payment";

                //02.ARGURMENT OF PROC
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_PAY_NO";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";



                //03. Type
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;


                ArrayList temp = new ArrayList();

                for (int iRow = fgrid_List_payment.Rows.Fixed; iRow < fgrid_List_payment.Rows.Count; iRow++)
                {
                    if (Convert.ToString(fgrid_List_payment.Rows[iRow][0]) == "D")
                    {
                        temp.Add(Convert.ToString(fgrid_List_payment.Rows[iRow][0]));
                        temp.Add(Convert.ToString(fgrid_List_payment.Rows[iRow][1]));
                        temp.Add(Convert.ToString(COM.ComVar.This_User));
                    }
                    else
                    {
                        continue;
                    }

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
    }
}