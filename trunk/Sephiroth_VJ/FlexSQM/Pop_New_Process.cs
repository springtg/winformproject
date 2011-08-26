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
    public partial class Pop_New_Process : COM.SQMWinForm.Pop_Small
    {
        public string p_process_code = "";
        public Pop_New_Process(string l_process_code)
        {
            p_process_code = l_process_code;
            InitializeComponent();
        }

        private void Pop_New_Process_Load(object sender, EventArgs e)
        {
            DataTable dt = SearchData();
            if (dt.Rows.Count>0)
            {
                txtProcessCode.Text = Convert.ToString(dt.Rows[0][0]);
                txtProcessName.Text = Convert.ToString(dt.Rows[0][1]);
                txtDescription.Text = Convert.ToString(dt.Rows[0][2]);
            }
        }

        private DataTable SearchData()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_process_by_code";

                MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_process_cd";
                MyOraDB.Parameter_Name[1] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_process_code;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                DataTable a = ds_ret.Tables[0];
                return a;
            }
            catch
            {
                return null;
            }
        }

        private DataTable Search_Process_Code()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_next_process_code";

                MyOraDB.ReDim_Parameter(1);

                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                DataTable a = ds_ret.Tables[0];
                return a;
            }
            catch
            {
                return null;
            }
        }

        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtProcessCode.Text == "")
            {
                MessageBox.Show("Please Click InSert To Create New Process !!!");
            }
            else if (txtProcessName.Text == "")
            {
                MessageBox.Show("Please Input Process Name");
            }
            else
            {
                if (SaveData(true))
                {
                    MessageBox.Show("Already Add New Process!!!");
                }
            }
        }
        private bool SaveData(bool doExecute)
        {
            try
            {
                COM.OraDB oraDB = new COM.OraDB();
                int iCount = 5;
                oraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                oraDB.Process_Name = "pkg_sqm_cust.sp_ins_del_process";

                //02.ARGURMENT OF PROC
                oraDB.Parameter_Name[0] = "arg_division";
                oraDB.Parameter_Name[1] = "arg_process_cd";
                oraDB.Parameter_Name[2] = "arg_process_nm";
                oraDB.Parameter_Name[3] = "arg_description";
                oraDB.Parameter_Name[4] = "arg_upd_user";

                oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                oraDB.Parameter_Values = new string[iCount];

                oraDB.Parameter_Values[0] = "I";
                oraDB.Parameter_Values[1] = txtProcessCode.Text;
                oraDB.Parameter_Values[2] = txtProcessName.Text;
                oraDB.Parameter_Values[3] = txtDescription.Text;
                oraDB.Parameter_Values[4] = Convert.ToString(COM.ComVar.This_User);

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

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            DataTable dt = Search_Process_Code();
            if (dt != null)
            {
                txtProcessCode.Text = Convert.ToString(dt.Rows[0][0]);
                txtProcessName.Text = "";
                txtDescription.Text = "";
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            if (DeleteData(true))
            {
                MessageBox.Show("Delete Process Completed !!!");
                btn_Insert_Click(sender, e);
            }

        }
        private bool DeleteData(bool doExecute)
        {
            try
            {
                COM.OraDB oraDB = new COM.OraDB();
                int iCount = 5;
                oraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                oraDB.Process_Name = "pkg_sqm_cust.sp_ins_del_process";

                //02.ARGURMENT OF PROC
                oraDB.Parameter_Name[0] = "arg_division";
                oraDB.Parameter_Name[1] = "arg_process_cd";
                oraDB.Parameter_Name[2] = "arg_process_nm";
                oraDB.Parameter_Name[3] = "arg_description";
                oraDB.Parameter_Name[4] = "arg_upd_user";

                oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                oraDB.Parameter_Values = new string[iCount];

                oraDB.Parameter_Values[0] = "D";
                oraDB.Parameter_Values[1] = txtProcessCode.Text;
                oraDB.Parameter_Values[2] = txtProcessName.Text;
                oraDB.Parameter_Values[3] = txtDescription.Text;
                oraDB.Parameter_Values[4] = Convert.ToString(COM.ComVar.This_User);

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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}