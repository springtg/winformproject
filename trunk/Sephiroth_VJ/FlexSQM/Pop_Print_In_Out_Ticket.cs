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
    public partial class Pop_Print_In_Out_Ticket : COM.SQMWinForm.Pop_Normal
    {
        public Pop_Print_In_Out_Ticket()
        {
            InitializeComponent();
            Init_Control();
        }
        private const int G_FACTORY         = 1;
        private const int G_VENDOR_CD       = 2;
        private const int G_VENDOR_NM       = 3;
        private const int G_STYLE_CD        = 4;
        private const int G_STYLE_NM        = 5;
        private const int G_COMP_CD         = 6;
        private const int G_COMP_NM         = 7;
        private const int G_PROCESS_CD      = 8;
        private const int G_PROCESS_NM      = 9;
        private const int G_LINE_CD         = 10;
        private const int G_LINE_NM         = 11;
        private const int G_DPO             = 12;
        private const int G_DAY_SEQ         = 13;
        private const int G_LOT_NO          = 14;
        private const int G_OUT_YMD         = 15;
        private const int G_OUT_KIND        = 16;




        private const int G2_FACTORY            = 1;
        private const int G2_VENDOR_CD          = 2;
        private const int G2_VENDOR_NM          = 3;
        private const int G2_DPO                = 4;
        private const int G2_STYLE_CD           = 5;
        private const int G2_STYLE_NM           = 6;
        private const int G2_LOT_NO             = 7;
        private const int G2_COMP_CD            = 8;
        private const int G2_COMP_NM            = 9;
        private const int G2_PROCESS_CD         = 10;
        private const int G2_PROCESS_NM         = 11;
        private const int G2_OUT_KIND           = 12;
        private const int G2_LINE_CD            = 13;
        private const int G2_LINE_NM            = 14;
        private const int G2_OUT_YMD            = 15;
        private const int G2_DAY_SEQ            = 16;
        private const int G2_ITEM_CD            = 17;
        private const int G2_ITEM_NM            = 18;
        private const int G2_SPEC_CD            = 19;
        private const int G2_SPEC_NM            = 20;
        private const int G2_COLOR_CD           = 21;
        private const int G2_COLOR_NM           = 22;
        private const int G2_QTY                = 23;
        private const int G2_UNIT               = 24;
        private const int G2_REMARK             = 25;


        private void Init_Control()
        {
            DataTable dt_ret;

            dt_ret = Select_Vendor_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Vendor.SelectedValue = " ";

            fgrid_style_cd.Set_Grid("SQM_TICKET_STYLE_OUT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_style_cd.Set_Action_Image(img_Action);

            fgrid_style_cd_to_print.Set_Grid("SQM_COMP_OUT_REPORT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_style_cd_to_print.Set_Action_Image(img_Action);

            fgrid_material.Set_Grid("SQM_TICKET_MATERIAL_HEAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_material.Set_Action_Image(img_Action);

            fgrid_material_to_print.Set_Grid("SQM_TICKET_MATERIAL_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_material_to_print.Set_Action_Image(img_Action);

            dt_ret = SELECT_LINE_INFO();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Line.SelectedIndex = 0;

            dt_ret = ClassLib.ComVar.Select_ComFilterCode(COM.ComVar.This_Factory, "SQM_OUT");
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Out_Kind, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Out_Kind.SelectedIndex = 0;
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
        private DataTable SELECT_LINE_INFO()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = "";

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

        

        

        //private DataTable Search_Component()
        //{
        //    try
        //    {
        //        COM.OraDB MyOraDB = new COM.OraDB();
        //        DataSet ds_ret;

        //        string process_name = "pkg_sqm_cust.select_component_2";

        //        MyOraDB.ReDim_Parameter(2);
        //        MyOraDB.Process_Name = process_name;

        //        MyOraDB.Parameter_Name[0] = "arg_comp_nm";
        //        MyOraDB.Parameter_Name[1] = "out_cursor";

        //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

        //        MyOraDB.Parameter_Values[0] = Convert.ToString(txtComponent.Text);
        //        MyOraDB.Parameter_Values[1] = "";

        //        MyOraDB.Add_Select_Parameter(true);
        //        ds_ret = MyOraDB.Exe_Select_Procedure();

        //        DataTable a = ds_ret.Tables[0];
        //        return a;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (tab_Content.SelectedIndex == 0)
            {
                Clear_FlexGrid();
                Clear_FlexGrid2();
                Display_Value();
            }
            else
            {
                fgrid_material.ClearAll();
                fgrid_material_to_print.ClearAll();
                Display_Value2();
            }

        }
        private void Clear_FlexGrid()
        {
            if (fgrid_style_cd.Rows.Fixed != fgrid_style_cd.Rows.Count)
            {
                fgrid_style_cd.Clear(ClearFlags.UserData, fgrid_style_cd.Rows.Fixed, 1, fgrid_style_cd.Rows.Count - 1, fgrid_style_cd.Cols.Count - 1);
                fgrid_style_cd.Rows.Count = fgrid_style_cd.Rows.Fixed;

                
            }          
        }

        

        private void Clear_FlexGrid2()
        {
            if (fgrid_style_cd_to_print.Rows.Fixed != fgrid_style_cd_to_print.Rows.Count)
            {
                fgrid_style_cd_to_print.Clear(ClearFlags.UserData, fgrid_style_cd_to_print.Rows.Fixed, 1, fgrid_style_cd_to_print.Rows.Count - 1, fgrid_style_cd_to_print.Cols.Count - 1);
                fgrid_style_cd_to_print.Rows.Count = fgrid_style_cd_to_print.Rows.Fixed;
            }
        }
        private void Display_Value()
        {
            string p_out_date = dpick_YMD.Value.ToString("yyyyMMdd");
            string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
            string p_line_cd = Convert.ToString(cmb_Line.SelectedValue);
            string p_kind_out = Convert.ToString(cmb_Out_Kind.SelectedValue);
            DataTable dt = SELECT_STYLE_CD(p_out_date, p_vendor_cd, p_kind_out, p_line_cd);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count;i++ )
                    {
                        fgrid_style_cd.Rows.Add();
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_FACTORY]       = dt.Rows[i][0];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_VENDOR_CD]     = dt.Rows[i][1];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_VENDOR_NM]     = dt.Rows[i][2];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_STYLE_CD]      = dt.Rows[i][3];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_STYLE_NM]      = dt.Rows[i][4];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_COMP_CD]       = dt.Rows[i][5];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_COMP_NM]       = dt.Rows[i][6];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_PROCESS_CD]    = dt.Rows[i][7];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_PROCESS_NM]    = dt.Rows[i][8];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_LINE_CD]       = dt.Rows[i][9];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_LINE_NM]       = dt.Rows[i][10];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_DPO]           = dt.Rows[i][11];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_DAY_SEQ]       = dt.Rows[i][12];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_LOT_NO]        = dt.Rows[i][13];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_OUT_YMD]       = dt.Rows[i][14];
                        fgrid_style_cd.Rows[fgrid_style_cd.Rows.Count - 1][G_OUT_KIND]      = dt.Rows[i][15];
                    }
                }
            }
        }

        private void Display_Value2()
        {
            string p_out_date = dpick_YMD.Value.ToString("yyyyMMdd");
            string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
            string p_line_cd = Convert.ToString(cmb_Line.SelectedValue);
            string p_kind_out = Convert.ToString(cmb_Out_Kind.SelectedValue);
            DataTable dt = SELECT_ITEM_CD(p_out_date, p_vendor_cd, p_kind_out, p_line_cd);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        fgrid_material.Rows.Add();
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_FACTORY]      = dt.Rows[i][0];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_VENDOR_CD]    = dt.Rows[i][1];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_VENDOR_NM]    = dt.Rows[i][2];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_DPO]          = dt.Rows[i][3];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_STYLE_CD]     = dt.Rows[i][4];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_STYLE_NM]     = dt.Rows[i][5];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_LOT_NO]       = dt.Rows[i][6];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_COMP_CD]      = dt.Rows[i][7];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_COMP_NM]      = dt.Rows[i][8];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_PROCESS_CD]   = dt.Rows[i][9];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_PROCESS_NM]   = dt.Rows[i][10];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_OUT_KIND]     = dt.Rows[i][11];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_LINE_CD]      = dt.Rows[i][12];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_LINE_NM]      = dt.Rows[i][13];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_OUT_YMD]      = dt.Rows[i][14];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_DAY_SEQ]      = dt.Rows[i][15];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_ITEM_CD]      = dt.Rows[i][16];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_ITEM_NM]      = dt.Rows[i][17];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_SPEC_CD]      = dt.Rows[i][18];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_SPEC_NM]      = dt.Rows[i][19];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_COLOR_CD]     = dt.Rows[i][20];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_COLOR_NM]     = dt.Rows[i][21];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_QTY]          = dt.Rows[i][22];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_UNIT]         = dt.Rows[i][23];
                        fgrid_material.Rows[fgrid_material.Rows.Count - 1][G2_REMARK]       = dt.Rows[i][24];
                    }
                }
            }
        }
        private DataTable SELECT_STYLE_CD(string p_out_date, string p_vendor_cd,string p_kind_out,string p_line_cd)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_style_cd_to_report";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_out_date";
                MyOraDB.Parameter_Name[1] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[2] = "arg_kind_out";
                MyOraDB.Parameter_Name[3] = "arg_line_cd";
                MyOraDB.Parameter_Name[4] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_out_date;
                MyOraDB.Parameter_Values[1] = p_vendor_cd;
                MyOraDB.Parameter_Values[2] = p_kind_out;
                MyOraDB.Parameter_Values[3] = p_line_cd;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret != null)
                {
                    DataTable a = ds_ret.Tables[0];
                    return a;
                }
                else
                {
                    return null; 
                }
            }
            catch
            {
                return null;
            }
        }

        private DataTable SELECT_ITEM_CD(string p_out_date, string p_vendor_cd, string p_kind_out, string p_line_cd)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_item_cd_to_report";

                MyOraDB.ReDim_Parameter(5);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_out_date";
                MyOraDB.Parameter_Name[1] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[2] = "arg_kind_out";
                MyOraDB.Parameter_Name[3] = "arg_line_cd";
                MyOraDB.Parameter_Name[4] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_out_date;
                MyOraDB.Parameter_Values[1] = p_vendor_cd;
                MyOraDB.Parameter_Values[2] = p_kind_out;
                MyOraDB.Parameter_Values[3] = p_line_cd;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret != null)
                {
                    DataTable a = ds_ret.Tables[0];
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        
        public void Display_Report()
        {
            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Outgoing_Ticket");
            string Para = " ";
            int iCnt = 4;
            string[] aHead = new string[iCnt];

            aHead[0] = dpick_YMD.Value.ToString("yyyyMMdd");
            aHead[1] = Convert.ToString(cmb_Vendor.SelectedValue);
            aHead[2] = Convert.ToString(cmb_Out_Kind.SelectedValue);
            aHead[3] = "";
            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);
            report.Show();
        }

        public void Display_Report2()
        {
            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Out_Ticket");
            string Para = " ";
            int iCnt = 4;
            string[] aHead = new string[iCnt];

            aHead[0] = dpick_YMD.Value.ToString("yyyyMMdd");
            aHead[1] = Convert.ToString(cmb_Vendor.SelectedValue);
            aHead[2] = Convert.ToString(cmb_Out_Kind.SelectedValue);
            aHead[3] = "";
            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);
            report.Show();
        }
        private bool CheckExist()
        {
            if (tab_Content.SelectedIndex == 0)
            {
                for (int i = fgrid_style_cd_to_print.Rows.Fixed; i < fgrid_style_cd_to_print.Rows.Count; i++)
                {
                    string p_factory = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_FACTORY]).Trim();
                    string p_vendor_cd = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_VENDOR_CD]).Trim();
                    string p_style_cd = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_STYLE_CD]).Trim();
                    string p_comp_cd = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_COMP_CD]).Trim();
                    string p_process_cd = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_PROCESS_CD]).Trim();
                    string p_line_cd = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_LINE_CD]).Trim();
                    string p_dpo = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_DPO]).Trim();
                    string p_lot_no = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_LOT_NO]).Trim();
                    string p_out_ymd = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_OUT_YMD]).Trim();
                    string p_out_kind = Convert.ToString(fgrid_style_cd_to_print.Rows[i][G_OUT_KIND]).Trim();

                    string f_factory = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_FACTORY]).Trim();
                    string f_vendor_cd = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_VENDOR_CD]).Trim();
                    string f_style_cd = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_STYLE_CD]).Trim();
                    string f_comp_cd = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_COMP_CD]).Trim();
                    string f_process_cd = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_PROCESS_CD]).Trim();
                    string f_line_cd = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LINE_CD]).Trim();
                    string f_dpo = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_DPO]).Trim();
                    string f_lot_no = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LOT_NO]).Trim();
                    string f_out_ymd = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_OUT_YMD]).Trim();
                    string f_out_kind = Convert.ToString(fgrid_style_cd.Rows[fgrid_style_cd.Row][G_OUT_KIND]).Trim();

                    if (p_factory.Equals(f_factory)
                     && p_vendor_cd.Equals(f_vendor_cd)
                     && p_style_cd.Equals(f_style_cd)
                     && p_comp_cd.Equals(f_comp_cd)
                     && p_process_cd.Equals(f_process_cd)
                     && p_line_cd.Equals(f_line_cd)
                     && p_dpo.Equals(f_dpo)
                     && p_lot_no.Equals(f_lot_no)
                     && p_out_ymd.Equals(f_out_ymd)
                     && p_out_kind.Equals(f_out_kind))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = fgrid_material_to_print.Rows.Fixed; i < fgrid_material_to_print.Rows.Count; i++)
                {
                    string p_factory = Convert.ToString(fgrid_material_to_print.Rows[i][G2_FACTORY]).Trim();
                    string p_vendor_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_VENDOR_CD]).Trim();
                    string p_style_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_STYLE_CD]).Trim();
                    string p_comp_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_COMP_CD]).Trim();
                    string p_process_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_PROCESS_CD]).Trim();
                    string p_line_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_LINE_CD]).Trim();
                    string p_dpo = Convert.ToString(fgrid_material_to_print.Rows[i][G2_DPO]).Trim();
                    string p_lot_no = Convert.ToString(fgrid_material_to_print.Rows[i][G2_LOT_NO]).Trim();
                    string p_out_ymd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_OUT_YMD]).Trim();
                    string p_out_kind = Convert.ToString(fgrid_material_to_print.Rows[i][G2_OUT_KIND]).Trim();
                    string p_item_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_ITEM_CD]).Trim();
                    string p_spec_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_SPEC_CD]).Trim();
                    string p_color_cd = Convert.ToString(fgrid_material_to_print.Rows[i][G2_COLOR_CD]).Trim();

                    string f_factory = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_FACTORY]).Trim();
                    string f_vendor_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_VENDOR_CD]).Trim();
                    string f_style_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_STYLE_CD]).Trim();
                    string f_comp_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_COMP_CD]).Trim();
                    string f_process_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_PROCESS_CD]).Trim();
                    string f_line_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_LINE_CD]).Trim();
                    string f_dpo = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_DPO]).Trim();
                    string f_lot_no = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_LOT_NO]).Trim();
                    string f_out_ymd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_OUT_YMD]).Trim();
                    string f_out_kind = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_OUT_KIND]).Trim();
                    string f_item_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_ITEM_CD]).Trim();
                    string f_spec_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_SPEC_CD]).Trim();
                    string f_color_cd = Convert.ToString(fgrid_material.Rows[fgrid_material.Row][G2_COLOR_CD]).Trim();

                    if (p_factory.Equals(f_factory)
                     && p_vendor_cd.Equals(f_vendor_cd)
                     && p_style_cd.Equals(f_style_cd)
                     && p_comp_cd.Equals(f_comp_cd)
                     && p_process_cd.Equals(f_process_cd)
                     && p_line_cd.Equals(f_line_cd)
                     && p_dpo.Equals(f_dpo)
                     && p_lot_no.Equals(f_lot_no)
                     && p_out_ymd.Equals(f_out_ymd)
                     && p_out_kind.Equals(f_out_kind)
                     && p_item_cd.Equals(f_item_cd)
                     && p_spec_cd.Equals(f_spec_cd)
                     && p_color_cd.Equals(f_color_cd)
                        )
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tab_Content.SelectedIndex == 0)
            {
                if (fgrid_style_cd_to_print.Rows.Count > 2)
                {
                    Delete_Data_Temp();
                    Insert_Data_Temp();
                    Display_Report();

                }
                else
                {
                    MessageBox.Show("Select Style To Print !");
                }
            }
            else
            {
                if (fgrid_material_to_print.Rows.Count > 2)
                {
                    Insert_Data_Temp2();
                    Display_Report2();

                }
                else
                {
                    MessageBox.Show("Select Item To Print !");
                }
            }
        }

        private void fgrid_style_cd_DoubleClick(object sender, EventArgs e)
        {
            if (CheckExist() == true)
            {
                fgrid_style_cd_to_print.Rows.Add();
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_FACTORY] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_FACTORY];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_VENDOR_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_VENDOR_CD];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_VENDOR_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_VENDOR_NM];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_STYLE_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_STYLE_CD];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_STYLE_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_STYLE_NM];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_COMP_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_COMP_CD];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_COMP_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_COMP_NM];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_PROCESS_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_PROCESS_CD];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_PROCESS_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_PROCESS_NM];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_LINE_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LINE_CD];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_LINE_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LINE_NM];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_DPO] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_DPO];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_DAY_SEQ] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_DAY_SEQ];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_LOT_NO] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LOT_NO];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_OUT_YMD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_OUT_YMD];
                fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_OUT_KIND] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_OUT_KIND];

            }
            else
            {
                MessageBox.Show("It's already exist");
            }
        }

        private void fgrid_style_cd_to_print_DoubleClick(object sender, EventArgs e)
        {
            fgrid_style_cd_to_print.Rows.Remove(fgrid_style_cd_to_print.Row);
        }


        private void Insert_Data_Temp()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                int iCount = 11;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                MyOraDB.Process_Name = "PKG_SQM_CUST.SP_INS_TICKET_OUT_TEMP";

                //02.ARGURMENT OF PROC
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_VENDOR_CD";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_COMP_CD";
                MyOraDB.Parameter_Name[4] = "ARG_PROCESS_CD";
                MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[7] = "ARG_DPO";
                MyOraDB.Parameter_Name[8] = "ARG_DAY_SEQ";
                MyOraDB.Parameter_Name[9] = "ARG_OUT_YMD";
                MyOraDB.Parameter_Name[10] = "ARG_OUT_KIND";
                

                //03. Type
                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                ArrayList temp = new ArrayList();

                for (int iRow = fgrid_style_cd_to_print.Rows.Fixed; iRow < fgrid_style_cd_to_print.Rows.Count; iRow++)
                {
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_FACTORY]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_VENDOR_CD]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_STYLE_CD]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_COMP_CD]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_PROCESS_CD]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_LINE_CD]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_LOT_NO]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_DPO]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_DAY_SEQ]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_OUT_YMD]));
                    temp.Add(Convert.ToString(fgrid_style_cd_to_print.Rows[iRow][G_OUT_KIND]));
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
        private void Delete_Data_Temp()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            int iCount = 1;
            int para_ct = 0;
            MyOraDB.ReDim_Parameter(iCount);
            MyOraDB.Process_Name = "PKG_SQM_CUST.sp_del_ticket_out_temp";
            MyOraDB.Parameter_Name[0] = "ARG_TEMP";
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Values[para_ct + 0] = "";
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }

        private void Insert_Data_Temp2()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                int iCount = 18;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                MyOraDB.Process_Name = "PKG_SQM_CUST.sp_ins_item_out_temp";

                //02.ARGURMENT OF PROC

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[2] = "arg_dpo";
                MyOraDB.Parameter_Name[3] = "arg_style_cd";
                MyOraDB.Parameter_Name[4] = "arg_lot_no";
                MyOraDB.Parameter_Name[5] = "arg_comp_cd";
                MyOraDB.Parameter_Name[6] = "arg_process_cd";
                MyOraDB.Parameter_Name[7] = "arg_out_kind";
                MyOraDB.Parameter_Name[8] = "arg_line_cd";
                MyOraDB.Parameter_Name[9] = "arg_out_ymd";
                MyOraDB.Parameter_Name[10] = "arg_day_seq";
                MyOraDB.Parameter_Name[11] = "arg_item_cd";
                MyOraDB.Parameter_Name[12] = "arg_spec_cd";
                MyOraDB.Parameter_Name[13] = "arg_color_cd";
                MyOraDB.Parameter_Name[14] = "arg_qty";
                MyOraDB.Parameter_Name[15] = "arg_unit";
                MyOraDB.Parameter_Name[16] = "arg_upd_user";
                MyOraDB.Parameter_Name[17] = "arg_remark";



                //03. Type
                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[14] = (int)OracleType.Number ;

                ArrayList temp = new ArrayList();

                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");
                temp.Add(0);
                temp.Add("D");
                temp.Add("D");
                temp.Add("D");

                for (int iRow = fgrid_material_to_print.Rows.Fixed; iRow < fgrid_material_to_print.Rows.Count; iRow++)
                {
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_FACTORY]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_VENDOR_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_DPO]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_STYLE_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_LOT_NO]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_COMP_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_PROCESS_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_OUT_KIND]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_LINE_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_OUT_YMD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_DAY_SEQ]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_ITEM_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_SPEC_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_COLOR_CD]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_QTY]));
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_UNIT]));
                    temp.Add(COM.ComVar.This_User);
                    temp.Add(Convert.ToString(fgrid_material_to_print.Rows[iRow][G2_REMARK]));
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
        private void fgrid_material_DoubleClick(object sender, EventArgs e)
        {
            if (CheckExist() == true)
            {
                fgrid_material_to_print.Rows.Add();
                for (int i = 1; i < fgrid_material.Cols.Count; i++)
                {
                    fgrid_material_to_print.Rows[fgrid_material_to_print.Rows.Count - 1][i] = fgrid_material.Rows[fgrid_material.Row][i];
                }
                //    fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_FACTORY] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_FACTORY];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_VENDOR_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_VENDOR_CD];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_VENDOR_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_VENDOR_NM];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_STYLE_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_STYLE_CD];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_STYLE_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_STYLE_NM];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_COMP_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_COMP_CD];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_COMP_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_COMP_NM];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_PROCESS_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_PROCESS_CD];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_PROCESS_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_PROCESS_NM];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_LINE_CD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LINE_CD];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_LINE_NM] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LINE_NM];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_DPO] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_DPO];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_DAY_SEQ] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_DAY_SEQ];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_LOT_NO] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_LOT_NO];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_OUT_YMD] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_OUT_YMD];
                //fgrid_style_cd_to_print.Rows[fgrid_style_cd_to_print.Rows.Count - 1][G_OUT_KIND] = fgrid_style_cd.Rows[fgrid_style_cd.Row][G_OUT_KIND];

            }
            else
            {
                MessageBox.Show("It's already exist");
            }
        }

        private void fgrid_material_to_print_DoubleClick(object sender, EventArgs e)
        {
            fgrid_material_to_print.Rows.Remove(fgrid_material_to_print.Row);
        }
    }
}