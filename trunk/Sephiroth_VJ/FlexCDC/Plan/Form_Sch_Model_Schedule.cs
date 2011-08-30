using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using ChartFX.WinForms;
using ChartFX.WinForms.Annotation;
using ChartFX.WinForms.DataProviders;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FlexCDC.Plan
{
    public partial class Form_Sch_Model_Schedule : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 立加 俺眉 积己
        private bool chk_flg = false;
        private bool option_chk_flg = false;
        private bool grid_flg = false;
        private bool grid_size = false;
        private bool setting_flg = false;
        private string _date_from = "";
        private string _date_to   = "";
        private int select_row = 0;

        private System.IO.MemoryStream _memoryStream;
        private string[] nf_seq = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMAX_CNT];
        private string[] tk_cd = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMAX_CNT];
        #endregion

        #region Resource
        public Form_Sch_Model_Schedule()
        {
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();
            chart_01.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);

            _memoryStream = new System.IO.MemoryStream();
            chart_02.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
        }
        #endregion

        #region Form Loading
        private void Form_Sch_Model_Schedule_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Model Schedule";
            this.lbl_MainTitle.Text = "PCC_Model Schedule";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;            

            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_season_from.SelectedValue = "201004";
            cmb_season_to.SelectedValue = "201102";

            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            //User
            dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;

            dpk_get_from.Value = DateTime.Now.AddMonths(-1);
            dpk_get_to.Value   = DateTime.Now.AddMonths(+1);
            _date_from = dpk_get_from.Value.ToString("yyyyMMdd");
            _date_to   = dpk_get_to.Value.ToString("yyyyMMdd");

            string[] arg_value = new string[3];
            arg_value[0] = cmb_factory.SelectedValue.ToString(); ;
            arg_value[1] = "";
            arg_value[2] = "";

            setting_flg = true;
            dt_ret = SELECT_ROUND(arg_value);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
            cmb_round.SelectedIndex = 0;

            dt_ret = SELECT_FILE_TASK();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_task, 0, 1, true, 0, 100);
            cmb_task.SelectedIndex = 0;
            setting_flg = false;

            #endregion

            #region Grid Setting
            
            #region Main Grid
            grid_flg = true;
            fgrid_main.Set_Grid_CDC("SXC_SCH_MODEL_SCHEDULE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;

            fgrid_main_02.Set_Grid_CDC("SXC_SCH_MODEL_SCHEDULE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main_02.Set_Action_Image(img_Action);
            fgrid_main_02.AllowDragging = AllowDraggingEnum.None;
            fgrid_main_02.AllowSorting = AllowSortingEnum.None;
            fgrid_main_02.ExtendLastCol = false;

            Grid_Date_Setting();
            grid_flg = false;
            #endregion

            #region Detail Grid
            fgrid_detail.Set_Grid_CDC("SXC_SCH_MNG_BOM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_detail.Set_Action_Image(img_Action);
            fgrid_detail.AllowDragging = AllowDraggingEnum.None;
            fgrid_detail.AllowSorting = AllowSortingEnum.None;
            fgrid_detail.ExtendLastCol = false;
            fgrid_detail.KeyActionEnter = KeyActionEnum.None;
            //fgrid_detail.Tree.Column = (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxCOLOR_VER;
            fgrid_detail.AllowMerging = AllowMergingEnum.Free;
            fgrid_detail.AllowEditing = false;

            for (int i = fgrid_detail.Cols.Fixed; i < fgrid_detail.Cols.Count; i++)
            {
                if (i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY_V || i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL || i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMO_ID || i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxROUND)
                {
                    fgrid_detail.Cols[i].AllowMerging = true;
                }
                else
                {
                    fgrid_detail.Cols[i].AllowMerging = false;
                }
            }
            #endregion

            #region File Grid
            fgrid_file.Set_Grid_CDC("SXC_SCH_MNG_FILE", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_file.Set_Action_Image(img_Action);
            fgrid_file.AllowDragging = AllowDraggingEnum.None;
            fgrid_file.AllowSorting = AllowSortingEnum.None;
            fgrid_file.ExtendLastCol = false;
            fgrid_file.KeyActionEnter = KeyActionEnum.None;
            fgrid_file.AllowMerging = AllowMergingEnum.Free;
            
            for (int i = fgrid_file.Cols.Fixed; i < fgrid_file.Cols.Count; i++)
            {
                if (i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFACTORY_V || i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL || i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMO_ID || i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxROUND)
                    fgrid_file.Cols[i].AllowMerging = true;
                else
                    fgrid_file.Cols[i].AllowMerging = false;

                if (i == (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxCHK)
                    fgrid_file.Cols[i].AllowEditing = true;
                else
                    fgrid_file.Cols[i].AllowEditing = false;
            }
            #endregion
            
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;
            chk_all.Checked = true;
            #endregion

            Set_Chart_Before();            
        }
        private void Grid_Date_Setting()
        {
            string[] arg_value = new string[3];
            arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");

            #region Daily Setting
            DataTable dt_date = SELECT_WORK_YMD(arg_value);

            if (dt_date.Rows.Count > 0)
            {
                for (int i = 0; i < dt_date.Rows.Count; i++)
                {
                    fgrid_main.Cols.Add();
                    fgrid_main.Cols[fgrid_main.Cols.Count - 1].Width = 60;

                    fgrid_main[fgrid_main.Rows.Fixed - 2, fgrid_main.Cols.Count - 1] = dt_date.Rows[i].ItemArray[1].ToString();
                    fgrid_main[fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1] = dt_date.Rows[i].ItemArray[2].ToString();

                    string holiday_yn = dt_date.Rows[i].ItemArray[3].ToString().Trim();
                    if (holiday_yn.Equals("Y"))
                    {
                        fgrid_main.Cols[fgrid_main.Cols.Count - 1].StyleNew.BackColor = Color.LightGray;
                    }
                    else
                    {
                        fgrid_main.Cols[fgrid_main.Cols.Count - 1].StyleNew.BackColor = Color.White;
                    }

                    fgrid_main.Cols[fgrid_main.Cols.Count - 1].AllowEditing = false;
                }
            }
            else
            {
                MessageBox.Show("Date : wrong date");
                return;
            }
            #endregion

            #region Weekly Setting
            DataTable dt_week = SELECT_WORK_WEEK(arg_value);

            if (dt_week.Rows.Count > 0)
            {
                for (int i = 0; i < dt_week.Rows.Count; i++)
                {
                    fgrid_main_02.Cols.Add();
                    fgrid_main_02.Cols[fgrid_main_02.Cols.Count - 1].Width = 165;

                    fgrid_main_02[fgrid_main_02.Rows.Fixed - 2, fgrid_main_02.Cols.Count - 1] = dt_week.Rows[i].ItemArray[0].ToString();
                    fgrid_main_02[fgrid_main_02.Rows.Fixed - 1, fgrid_main_02.Cols.Count - 1] = dt_week.Rows[i].ItemArray[1].ToString();

                    fgrid_main_02.Cols[fgrid_main_02.Cols.Count - 1].StyleNew.BackColor = Color.White;
                    fgrid_main_02.Cols[fgrid_main_02.Cols.Count - 1].AllowEditing = false;
                }
            }
            else
            {
                MessageBox.Show("Date : wrong date");
                return;
            }
            #endregion
            
        }
        private void Set_Chart_Before()
        {
            //Model
            _memoryStream.Position = 0;
            chart_01.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_01.Data.Clear();
            chart_01.BackColor = Color.FloralWhite;

            //Dev
            _memoryStream.Position = 0;
            chart_02.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_02.Data.Clear();
            chart_02.BackColor = Color.MintCream;
        }        

        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_SEASON";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_CATEGORY()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_CATEGORY";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_USER()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_USER";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_WORK_YMD(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_WORK_YMD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_WORK_WEEK(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_WORK_WEEK";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_ROUND(string[] arg_value)
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.GET_DETAIL_ROUND";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_FILE_TASK()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_FILE_TASK";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;


                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
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
                this.Cursor = Cursors.WaitCursor;

                if (tabControl1.SelectedIndex.Equals(0) && chk_all_search.Checked)
                {
                    if (tab_grid_main.SelectedIndex.Equals(0))                    
                        Display_Detail_Data(fgrid_main);
                    else
                        Display_Detail_Data(fgrid_main_02);
                }
                else if (tabControl1.SelectedIndex.Equals(1) && chk_all_file.Checked)
                {
                    if (tab_grid_main.SelectedIndex.Equals(0)) 
                        Display_File_Data(fgrid_main);
                    else
                        Display_File_Data(fgrid_main_02);
                }
                else
                {
                    Display_Data();

                    if (tab_grid_main.SelectedIndex.Equals(0))
                    {
                        fgrid_main.Select(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V);
                        fgrid_main_MouseDoubleClick(null, null);
                    }
                    else
                    {
                        fgrid_main_02.Select(fgrid_main_02.Rows.Fixed, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V);
                        fgrid_main_02_MouseDoubleClick(null, null); 
                    }
                }

                Display_Chart();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Display_Data()
        {
            grid_flg = true; 
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
            fgrid_main_02.Rows.Count = fgrid_main_02.Rows.Fixed;

            string current_date_from = dpk_get_from.Value.ToString("yyyyMMdd");
            string current_date_to   = dpk_get_to.Value.ToString("yyyyMMdd");

            if (!_date_from.Equals(current_date_from) || !_date_to.Equals(current_date_to))
            {
                fgrid_main.Cols.Count = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT;
                Grid_Date_Setting();

                _date_from = current_date_from;
                _date_to   = current_date_to;
            }

            #region Data Setting
            string [] arg_value = new string[10];

            arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[1] = cmb_season_from.SelectedValue.ToString().Trim();
            arg_value[2] = cmb_season_to.SelectedValue.ToString().Trim();
            arg_value[3] = cmb_category.SelectedValue.ToString().Trim();
            arg_value[4] = txt_model.Text.Trim();
            arg_value[5] = cmb_user.SelectedValue.ToString().Trim();
            arg_value[6] = dpk_get_from.Value.ToString("yyyyMMdd");
            arg_value[7] = dpk_get_to.Value.ToString("yyyyMMdd");
            string chk_sch = "ALL";

            if (chk_dev_check.Checked)
                chk_sch = "DEV";
            else if (chk_cfm_shoe.Checked)
                chk_sch = "CFM";
            else if (chk_comm.Checked)
                chk_sch = "COMM";
            
            arg_value[8] = chk_sch;
            arg_value[9] = (chk_drop.Checked) ? "X" : "D";

            #region Daily Setting
            DataTable dt_ret = SELECT_SCH_MODEL_SCHEDULE_DAILY(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();
                fgrid_main.Rows[fgrid_main.Rows.Count - 1].Height = 50;

                for (int j = fgrid_main.Cols.Fixed; j <= (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS; j++)
                {
                    if (j.Equals((int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxIMAGE))
                    {
                        try
                        {
                            byte[] MyData = null;
                            MyData = (byte[])dt_ret.Rows[i].ItemArray[j];

                            MemoryStream ms = new MemoryStream(MyData);
                            Size imgsize = new Size(100, 50);
                            System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);
                            Image img = true_image;
                            System.Drawing.Bitmap grid_image = new System.Drawing.Bitmap(img, imgsize);
                            img = grid_image;

                            Hashtable Imgmap = new Hashtable();
                            Imgmap.Clear();
                            Imgmap.Add("", img);

                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, j).StyleNew.ImageMap = Imgmap;
                        }
                        catch
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "";
                        }
                    }
                    else
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();                        
                    }
                }

                string drop_yn = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS].ToString().Trim();

                if (drop_yn.Equals("D"))
                {
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V).StyleNew.BackColor = Color.LightGray;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxGENDER_V, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS).StyleNew.BackColor = Color.LightGray;
                }

                int cols_cnt = dt_ret.Columns.Count - (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT;
                for (int col = 0; col < cols_cnt; col++)
                {

                    string data_row = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT + col].ToString().Trim();

                    if (!data_row.Equals(""))
                    {
                        try
                        {
                            string status = data_row.Substring(0, 1);
                            string round = data_row.Substring(4);
                            int index = int.Parse(data_row.Substring(1, 3));
                            int colunm_index = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS + index;

                            if (!index.Equals(0))
                            {
                                fgrid_main[fgrid_main.Rows.Count - 1, colunm_index] = round;

                                if (status.Equals("N"))
                                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, colunm_index).StyleNew.BackColor = Color.Yellow;
                                else if (status.Equals("Y"))
                                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, colunm_index).StyleNew.BackColor = Color.Red;
                                else if (status.Equals("C"))
                                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, colunm_index).StyleNew.BackColor = Color.Aqua;
                            }
                        }
                        catch (Exception ex)
                        {
                            string model_name = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V].ToString().Trim();
                            int error_row = fgrid_main.Rows.Count - 1;

                            MessageBox.Show("Row Num. : " + error_row.ToString() + "\r\n\r\n" + model_name + "\r\n\r\n" + ex.ToString());
                        }
                    }
                }
            }
            #endregion

            #region Weekly Checked
            dt_ret = SELECT_SCH_MODEL_SCHEDULE_WEEKLY(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main_02.Rows.Add();
                fgrid_main_02.Rows[fgrid_main_02.Rows.Count - 1].Height = 50;

                for (int j = fgrid_main_02.Cols.Fixed; j <= (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS; j++)
                {
                    if (j.Equals((int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxIMAGE))
                    {
                        try
                        {
                            byte[] MyData = null;
                            MyData = (byte[])dt_ret.Rows[i].ItemArray[j];

                            MemoryStream ms = new MemoryStream(MyData);
                            Size imgsize = new Size(100, 50);
                            System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);
                            Image img = true_image;
                            System.Drawing.Bitmap grid_image = new System.Drawing.Bitmap(img, imgsize);
                            img = grid_image;

                            Hashtable Imgmap = new Hashtable();
                            Imgmap.Clear();
                            Imgmap.Add("", img);

                            fgrid_main_02.GetCellRange(fgrid_main_02.Rows.Count - 1, j).StyleNew.ImageMap = Imgmap;
                        }
                        catch
                        {
                            fgrid_main_02[fgrid_main_02.Rows.Count - 1, j] = "";
                        }
                    }
                    else
                    {
                        fgrid_main_02[fgrid_main_02.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                    }
                }

                string drop_yn = fgrid_main_02[fgrid_main_02.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS].ToString().Trim();

                if (drop_yn.Equals("D"))
                {
                    fgrid_main_02.GetCellRange(fgrid_main_02.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY, fgrid_main_02.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V).StyleNew.BackColor = Color.LightGray;
                    fgrid_main_02.GetCellRange(fgrid_main_02.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxGENDER_V, fgrid_main_02.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS).StyleNew.BackColor = Color.LightGray;
                }

                int cols_cnt = dt_ret.Columns.Count - (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT;
                for (int col = 0; col < cols_cnt; col++)
                {

                    string data_row = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT + col].ToString().Trim();

                    if (!data_row.Equals(""))
                    {
                        try
                        {
                            string status = data_row.Substring(0, 1);
                            string round = data_row.Substring(4);
                            int index = int.Parse(data_row.Substring(1, 3));
                            int colunm_index = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS + index;

                            if (!index.Equals(0))
                            {
                                string value = (fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index] == null) ? "" : fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index].ToString().Trim();

                                if (value.Equals(""))
                                    fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index] = round;
                                else
                                {
                                    if (!round.Equals(value))
                                    {
                                        string value_01 = value + ", " + round;

                                        if (value_01.Length > 26)
                                        {
                                            int value_length = value.Length;
                                            int enter_idx = value.LastIndexOf("\r\n");

                                            if (enter_idx.Equals(-1))
                                            {
                                                fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index] = value + ",\r\n" + round;
                                            }
                                            else
                                            {
                                                int cut_length = value_length - enter_idx;

                                                if (cut_length > 26)
                                                {
                                                    fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index] = value + ",\r\n" + round;
                                                }
                                                else
                                                {
                                                    fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index] = value_01;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            fgrid_main_02[fgrid_main_02.Rows.Count - 1, colunm_index] = value_01;
                                        }

                                    }
                                }

                                if (status.Equals("N"))
                                    fgrid_main_02.GetCellRange(fgrid_main_02.Rows.Count - 1, colunm_index).StyleNew.BackColor = Color.Yellow;
                                else if (status.Equals("Y"))
                                    fgrid_main_02.GetCellRange(fgrid_main_02.Rows.Count - 1, colunm_index).StyleNew.BackColor = Color.Red;
                                else if (status.Equals("C"))
                                    fgrid_main_02.GetCellRange(fgrid_main_02.Rows.Count - 1, colunm_index).StyleNew.BackColor = Color.Aqua;
                            }
                        }
                        catch (Exception ex)
                        {
                            string model_name = fgrid_main_02[fgrid_main_02.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V].ToString().Trim();
                            int error_row = fgrid_main_02.Rows.Count - 1;

                            MessageBox.Show("Row Num. : " + error_row.ToString() + "\r\n\r\n" + model_name + "\r\n\r\n" + ex.ToString());
                        }
                    }
                }
            }
            #endregion                       
            #endregion

            grid_flg = false;            
        }
        private void Display_Chart()
        {
            Set_Chart_Before();

            DataSet vDS = MakeChartData();
            DataTable vDT_01 = vDS.Tables[0];
            DataTable vDT_02 = vDS.Tables[1];

            #region Model                       
            chart_01.DataSource = vDT_01;
            chart_01.AllSeries.Gallery = Gallery.Gantt;
            chart_01.AllSeries.Volume = 20;
            chart_01.AxisX.AutoScroll = true;
            chart_01.AxisX.Font = new System.Drawing.Font("Verdana", 7F, FontStyle.Bold);
            chart_01.AxisX.ScrollPosition = 100;            
            chart_01.AllSeries.PointLabels.Visible = true;

            chart_01.Series[0].Color = Color.Red;

            chart_01.View3D.Enabled = false;
            chart_01.LegendBox.Visible = false;
            TitleDockable t_01 = new TitleDockable("Model");
            t_01.Font = new System.Drawing.Font("Verdana", 13F, FontStyle.Bold);
            chart_01.Titles.Add(t_01);

            chart_01.Cursor = Cursors.Default;            
            #endregion

            #region Dev.
            chart_02.DataSource = vDT_02;
            chart_02.AllSeries.Gallery = Gallery.Gantt;
            chart_02.AllSeries.Volume = 20;
            chart_02.AxisX.AutoScroll = true;
            chart_02.AxisX.Font = new System.Drawing.Font("Verdana", 7F, FontStyle.Bold);
            chart_02.AxisX.ScrollPosition = 100;
            chart_02.AllSeries.PointLabels.Visible = true;
            chart_02.View3D.Enabled = false;
            chart_02.LegendBox.Visible = false;
            TitleDockable t_02 = new TitleDockable("Developer");
            t_02.Font = new System.Drawing.Font("Verdana", 13F, FontStyle.Bold);
            chart_02.Titles.Add(t_02);

            chart_02.Cursor = Cursors.Default;
            #endregion
        }
        private DataSet MakeChartData()
        {
            try
            {   
                string[] arg_value = new string[10];

                arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[1] = cmb_season_from.SelectedValue.ToString().Trim();
                arg_value[2] = cmb_season_to.SelectedValue.ToString().Trim();
                arg_value[3] = cmb_category.SelectedValue.ToString().Trim();
                arg_value[4] = txt_model.Text.Trim();
                arg_value[5] = cmb_user.SelectedValue.ToString().Trim();
                arg_value[6] = dpk_get_from.Value.ToString("yyyyMMdd");
                arg_value[7] = dpk_get_to.Value.ToString("yyyyMMdd");
                string chk_sch = "ALL";

                if (chk_dev_check.Checked)
                    chk_sch = "DEV";
                else if (chk_cfm_shoe.Checked)
                    chk_sch = "CFM";
                else if (chk_comm.Checked)
                    chk_sch = "COMM";

                arg_value[8] = chk_sch;
                arg_value[9] = (chk_drop.Checked) ? "X" : "D";

                DataSet vDSChartData = SELECT_SCH_MODEL_SCHEDULE_CHART(arg_value);

                return vDSChartData;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        private DataTable SELECT_SCH_MODEL_SCHEDULE_DAILY(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_MODEL_DAILY";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_DATE_FROM";
                MyOraDB.Parameter_Name[7] = "ARG_DATE_TO";
                MyOraDB.Parameter_Name[8] = "ARG_CHK_SCH";
                MyOraDB.Parameter_Name[9] = "ARG_DROP_YN";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];
                MyOraDB.Parameter_Values[9] = arg_value[9];
                MyOraDB.Parameter_Values[10] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private DataTable SELECT_SCH_MODEL_SCHEDULE_WEEKLY(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_MODEL_WEEKLY";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_DATE_FROM";
                MyOraDB.Parameter_Name[7] = "ARG_DATE_TO";
                MyOraDB.Parameter_Name[8] = "ARG_CHK_SCH";
                MyOraDB.Parameter_Name[9] = "ARG_DROP_YN";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];
                MyOraDB.Parameter_Values[9] = arg_value[9];
                MyOraDB.Parameter_Values[10] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private DataSet SELECT_SCH_MODEL_SCHEDULE_CHART(string[] arg_value)
        {
            try
            {
                DataSet ds_ret;

                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_MODEL_CHART_01";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_DATE_FROM";
                MyOraDB.Parameter_Name[7] = "ARG_DATE_TO";
                MyOraDB.Parameter_Name[8] = "ARG_CHK_SCH";
                MyOraDB.Parameter_Name[9] = "ARG_DROP_YN";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];
                MyOraDB.Parameter_Values[9] = arg_value[9];
                MyOraDB.Parameter_Values[10] = "";

                MyOraDB.Add_Select_Parameter(true);
                
                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_MODEL_CHART_02";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_DATE_FROM";
                MyOraDB.Parameter_Name[7] = "ARG_DATE_TO";
                MyOraDB.Parameter_Name[8] = "ARG_CHK_SCH";
                MyOraDB.Parameter_Name[9] = "ARG_DROP_YN";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];
                MyOraDB.Parameter_Values[9] = arg_value[9];
                MyOraDB.Parameter_Values[10] = "";

                MyOraDB.Add_Select_Parameter(false);

                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        #region Grid Event

        #region Main Gird Event
        private void fgrid_main_AfterSelChange(object sender, RangeEventArgs e)
        {
            try
            {
                //if (grid_flg)
                //    return;

                //if (select_row.Equals(fgrid_main.Selection.r1))
                //    return;

                //if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                //    return;

                //if (tabControl1.SelectedIndex.Equals(0))
                //{
                //    string[] arg_value = new string[3];
                //    arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                //    arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                //    arg_value[2] = "";

                //    setting_flg = true;
                //    DataTable dt_ret = SELECT_ROUND(arg_value);
                //    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                //    cmb_round.SelectedIndex = 0;
                //    setting_flg = false;

                //    txt_bom_id.Text = "";

                //    Display_Detail_Data();
                //    fgrid_detail.Tree.Show(1);
                //}
                //else
                //{
                //    Display_File_Data();
                //}

                //select_row = fgrid_main.Selection.r1;
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (!chk_all_search.Checked)
                {
                    if (grid_size)
                    {
                        pnl_detail.Height = 216;
                        grid_size = false;
                    }
                    else
                    {
                        pnl_detail.Height = 450;
                        grid_size = true;
                    }
                }
            }
        }
        private void fgrid_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (grid_flg)
                    return;
               
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                this.Cursor = Cursors.WaitCursor;

                if (tabControl1.SelectedIndex.Equals(0))
                {
                    string[] arg_value = new string[3];
                    arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = "";

                    setting_flg = true;
                    DataTable dt_ret = SELECT_ROUND(arg_value);
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                    cmb_round.SelectedIndex = 0;
                    setting_flg = false;

                    txt_bom_id.Text = "";

                    Display_Detail_Data(fgrid_main);
                    fgrid_detail.Tree.Show(1);
                }
                else
                {
                    Display_File_Data(fgrid_main);
                }

                for (int j = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS + 1; j < fgrid_main.Cols.Count; j++)
                {
                    string value = (fgrid_main[fgrid_main.Selection.r1, j] == null) ? "" : fgrid_main[fgrid_main.Selection.r1, j].ToString().Trim();

                    if (!value.Equals(""))
                    {
                        fgrid_main.LeftCol = j;
                        break;
                    }                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void fgrid_main_02_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (!chk_all_search.Checked)
                {
                    if (grid_size)
                    {
                        pnl_detail.Height = 216;
                        grid_size = false;
                    }
                    else
                    {
                        pnl_detail.Height = 450;
                        grid_size = true;
                    }
                }
            }
        }

        private void fgrid_main_02_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (grid_flg)
                    return;

                if (fgrid_main_02.Rows.Count.Equals(fgrid_main_02.Rows.Fixed))
                    return;

                this.Cursor = Cursors.WaitCursor;

                if (tabControl1.SelectedIndex.Equals(0))
                {
                    string[] arg_value = new string[3];
                    arg_value[0] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = "";

                    setting_flg = true;
                    DataTable dt_ret = SELECT_ROUND(arg_value);
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                    cmb_round.SelectedIndex = 0;
                    setting_flg = false;

                    txt_bom_id.Text = "";

                    Display_Detail_Data(fgrid_main_02);
                    fgrid_detail.Tree.Show(1);
                }
                else
                {
                    Display_File_Data(fgrid_main_02);
                }

                for (int j = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSTATUS + 1; j < fgrid_main_02.Cols.Count; j++)
                {
                    string value = (fgrid_main_02[fgrid_main_02.Selection.r1, j] == null) ? "" : fgrid_main_02[fgrid_main_02.Selection.r1, j].ToString().Trim();
                    
                    if (!value.Equals(""))
                    {
                        fgrid_main_02.LeftCol = j;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region Detail Grid Setting
        private void Display_Detail_Data(C1FlexGrid arg_grid)
        {
            fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;

            int sct_row = arg_grid.Selection.r1;
            int sct_col = arg_grid.Selection.c1;

            DataTable dt_ret = null;

            if (!chk_all_search.Checked)
            {
                string[] arg_value = new string[7];
                arg_value[0] = arg_grid[sct_row, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                arg_value[1] = arg_grid[sct_row, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                arg_value[2] = arg_grid[sct_row, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSRF_NO].ToString().Trim();
                arg_value[3] = cmb_round.SelectedValue.ToString();
                arg_value[4] = txt_bom_id.Text.Trim();

                dt_ret = SELECT_SCH_MANAGEMENT_DETAIL(arg_value);
            }
            else
            {
                string[] arg_value = new string[8];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = cmb_season_from.SelectedValue.ToString();
                arg_value[2] = cmb_season_to.SelectedValue.ToString();
                arg_value[3] = cmb_category.SelectedValue.ToString();
                arg_value[4] = txt_model.Text.Trim();
                arg_value[5] = cmb_user.SelectedValue.ToString();
                arg_value[6] = cmb_round.SelectedValue.ToString();
                arg_value[7] = txt_bom_id.Text.Trim();

                dt_ret = SELECT_SCH_MANAGEMENT_DETAIL_ALL(arg_value);
            }

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_detail.Rows.Add();

                for (int j = fgrid_detail.Cols.Fixed; j < fgrid_detail.Cols.Count; j++)
                {
                    fgrid_detail[fgrid_detail.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }
            }

            Detail_Grid_Style_Setting();
        }
        private DataTable SELECT_SCH_MANAGEMENT_DETAIL(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_SCH_MNG_DETAIL";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private DataTable SELECT_SCH_MANAGEMENT_DETAIL_ALL(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(9);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_SCH_MNG_DETAIL_ALL";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[7] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private void Detail_Grid_Style_Setting()
        {
            for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
            {
                string status = fgrid_detail[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSTATUS].ToString().Trim();

                if (status.Equals("D"))
                {
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID_V, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.BackColor = Color.LightGray;                    
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSHOE_VER).StyleNew.BackColor = Color.LightGray;
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxIPW_YMD, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxUPD_YMD).StyleNew.BackColor = Color.LightGray;
                    fgrid_detail.Rows[i].AllowEditing = false;
                }
                else
                {
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID_V, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.BackColor = Color.Beige;
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSHOE_VER).StyleNew.BackColor = Color.White;
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxIPW_YMD, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxUPD_YMD).StyleNew.BackColor = Color.White;
                }

                for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP; j++)
                {
                    bool style_yn = Style_Setting_YN_Detail(j);

                    if (style_yn)
                    {
                        #region Date Type Setting
                        CellRange cellrg = fgrid_detail.GetCellRange(i, j);
                        CellStyle cellst = fgrid_detail.Styles.Add("DT_DETAIL_" + i.ToString() + j.ToString());
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.ForeColor = Color.Black;

                        if (status.Equals("D"))
                        {
                            cellst.BackColor = Color.LightGray;
                        }
                        else
                        {
                            string progress = fgrid_detail[i, j + 1].ToString().Trim();

                            if (progress.Equals("C"))
                            {
                                cellst.BackColor = Color.Aqua;
                            }
                            else if (progress.Equals("Y"))
                            {
                                cellst.BackColor = Color.Yellow;
                            }
                            else if (progress.Equals(""))
                            {
                                cellst.BackColor = Color.LightGray;
                            }
                            else
                            {
                                cellst.BackColor = Color.White;
                            }
                        }

                        cellrg.Style = fgrid_detail.Styles["DT_DETAIL_" + i.ToString() + j.ToString()];
                        #endregion

                        #region CheckBox Setting
                        if (status.Equals("D"))
                            fgrid_detail.Cols[j - 1].StyleNew.BackColor = Color.LightGray;
                        else
                            fgrid_detail.Cols[j - 1].StyleNew.BackColor = Color.White;
                        #endregion
                    }
                }

                string rep_yn = fgrid_detail[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxREP_YN].ToString().Trim();

                if (rep_yn.Equals("Y"))
                {
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID_V, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Blue;

                    Font ft = new Font("Verdana", 8, FontStyle.Bold);
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID_V, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.Font = ft;
                }
                else
                {
                    fgrid_detail.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID_V, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Black;                    
                }
            }
        }
        private bool Style_Setting_YN_Detail(int arg_col)
        {
            bool[] style_yn = new bool[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMAX_CNT];

            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_P] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD_P] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC_P] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK_P] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM_P] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_P] = false;

            return style_yn[arg_col];
        }
        #endregion

        #region File Grid Setting
        private void Display_File_Data(C1FlexGrid arg_grid)
        {
            fgrid_file.Rows.Count = fgrid_file.Rows.Fixed;

            DataTable dt_ret = null;

            if (!chk_all_file.Checked)
            {
                string[] arg_value = new string[5];

                arg_value[0] = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                arg_value[1] = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                arg_value[2] = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSRF_NO].ToString().Trim();
                arg_value[3] = cmb_task.SelectedValue.ToString().Trim();
                arg_value[4] = txt_search.Text.Trim();

                dt_ret = SELECT_SCH_MANAGEMENT_FILE(arg_value);
            }
            else
            {

                string[] arg_value = new string[8];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = cmb_season_from.SelectedValue.ToString();
                arg_value[2] = cmb_season_to.SelectedValue.ToString();
                arg_value[3] = cmb_category.SelectedValue.ToString();
                arg_value[4] = txt_model.Text.Trim();
                arg_value[5] = cmb_user.SelectedValue.ToString();
                arg_value[6] = cmb_task.SelectedValue.ToString();
                arg_value[7] = txt_search.Text.Trim();

                dt_ret = SELECT_SCH_MANAGEMENT_FILE_ALL(arg_value);
            }

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_file.Rows.Add();

                for (int j = fgrid_file.Cols.Fixed; j < fgrid_file.Cols.Count; j++)
                {
                    fgrid_file[fgrid_file.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }

                string rep_yn = fgrid_file[fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxREP_YN].ToString().Trim();

                if (rep_yn.Equals("Y"))
                {
                    fgrid_file.GetCellRange(fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxBOM_ID_V, fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxTASK_V).StyleNew.ForeColor = Color.Blue;
                    Font ft = new Font("Verdana", 8, FontStyle.Bold);
                    fgrid_file.GetCellRange(fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxBOM_ID_V, fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxTASK_V).StyleNew.Font = ft;
                }
                else
                {
                    fgrid_file.GetCellRange(fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxBOM_ID_V, fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxTASK_V).StyleNew.ForeColor = Color.Black;
                }

                fgrid_file.GetCellRange(fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxCHK, fgrid_file.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxUPD_YMD).StyleNew.BackColor = Color.White;
            }


        }
        private DataTable SELECT_SCH_MANAGEMENT_FILE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_SCH_MNG_FILE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private DataTable SELECT_SCH_MANAGEMENT_FILE_ALL(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(9);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_SCH_MNG_FILE_ALL";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_TK_CD";
                MyOraDB.Parameter_Name[7] = "ARG_SEARCH";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        #endregion

        #endregion

        #region Detail Grid Event
        private void fgrid_detail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (!chk_all_search.Checked)
                {
                    if (grid_size)
                    {
                        pnl_detail.Height = 216;
                        grid_size = false;
                    }
                    else
                    {
                        pnl_detail.Height = 450;
                        grid_size = true;
                    }
                }
            }
        }
        #endregion

        #region File Grid Event
        private void fgrid_file_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string save_path = Application.StartupPath + "\\sch_file";

                DirectoryInfo di = new DirectoryInfo(save_path);

                if (!di.Exists)
                {
                    di.Create();
                }
                else
                {
                    di.Delete(true);
                    di.Create();
                }

                string factory   = fgrid_file[fgrid_file.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFACTORY].ToString().Trim();
                string file_cd   = fgrid_file[fgrid_file.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_CD].ToString().Trim();
                string file_name = fgrid_file[fgrid_file.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_NAME].ToString().Trim();
                string file_path = save_path + "\\" + file_name;
                string file_type = file_name.Substring(file_name.LastIndexOf(".") + 1, 3).Trim().ToUpper();

                File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));

                if (file_type.Equals("XLS"))
                {
                    ProcessStartInfo ps = new ProcessStartInfo("EXCEL.EXE");
                    ps.WorkingDirectory = save_path;
                    ps.FileName = file_name;

                    Process.Start(ps);
                }
                else
                {
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.WorkingDirectory = save_path;
                    ps.FileName = file_name;

                    Process.Start(ps);
                }
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        #endregion

        #endregion

        #region Control Event

        #region CheckBox Event
        private void chk_daily_CheckedChanged(object sender, EventArgs e)
        {
            //if (option_chk_flg)
            //    return;

            //option_chk_flg = true;

            //if (chk_daily.Checked)
            //    chk_weekly.Checked = false;
            //else
            //    chk_weekly.Checked = true;

            //fgrid_main.Cols.Count = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT;
            //Grid_Date_Setting();

            //if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
            //{
            //    int sct_row = fgrid_main.Selection.r1;
            //    Display_Data();
            //    fgrid_main.Select(sct_row, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V);
            //}

            //option_chk_flg = false;
            
        }
        private void chk_weekly_CheckedChanged(object sender, EventArgs e)
        {
            //if (option_chk_flg)
            //    return;

            //option_chk_flg = true;

            //if (chk_weekly.Checked)
            //    chk_daily.Checked = false;
            //else
            //    chk_daily.Checked = true;
                        
            //fgrid_main.Cols.Count = (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMAX_CNT;
            //Grid_Date_Setting();

            //if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
            //{
            //    int sct_row = fgrid_main.Selection.r1;
            //    Display_Data();
            //    fgrid_main.Select(sct_row, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_V);
            //}

            //option_chk_flg = false;
        }

        private void chk_all_search_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                setting_flg = true;

                if (chk_all_search.Checked)
                {
                    pnl_detail.Height = pnl_grid.Height + pnl_detail.Height;
                    
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = true;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = true;

                    fgrid_main.Enabled = false;
                    tbtn_Save.Enabled  = false;

                    cmb_factory.Enabled     = false;
                    cmb_season_from.Enabled = false;
                    cmb_season_to.Enabled   = false;
                    cmb_category.Enabled    = false;
                    cmb_user.Enabled        = false;
                    dpk_get_from.Enabled    = false;
                    dpk_get_to.Enabled      = false;
                                        
                    txt_model.Enabled = false;
                    

                    string[] arg_detail_value = new string[3];
                    arg_detail_value[0] = COM.ComVar.This_Factory;
                    arg_detail_value[1] = "";
                    arg_detail_value[2] = "";

                    DataTable dt_ret = SELECT_ROUND(arg_detail_value);
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                    cmb_round.SelectedIndex = 0;

                    txt_bom_id.Text = "";


                    chk_flg = true;
                    chk_all_file.Checked = true;
                    chk_flg = false;
                }
                else
                {
                    pnl_detail.Height = 216;
                    
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = false;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = false;

                    fgrid_main.Enabled = true;
                    tbtn_Save.Enabled  = true;

                    cmb_factory.Enabled     = true;
                    cmb_season_from.Enabled = true;
                    cmb_season_to.Enabled   = true;
                    cmb_category.Enabled    = true;
                    cmb_user.Enabled        = true;
                    dpk_get_from.Enabled    = true;
                    dpk_get_to.Enabled      = true;
                                        
                    txt_model.Enabled = true;
                    
                    string[] arg_detail_value = new string[3];
                    arg_detail_value[0] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                    arg_detail_value[1] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                    arg_detail_value[2] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

                    DataTable dt_ret = SELECT_ROUND(arg_detail_value);
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                    cmb_round.SelectedIndex = 0;

                    txt_bom_id.Text = "";

                    if (tab_grid_main.SelectedIndex.Equals(0))
                        Display_Detail_Data(fgrid_main);
                    else
                        Display_Detail_Data(fgrid_main_02); ;

                    chk_flg = true;
                    chk_all_file.Checked = false;
                    chk_flg = false;
                }

                setting_flg = false;
            }
            catch
            {
 
            }
        }
        private void chk_all_file_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                setting_flg = true;

                if (chk_all_file.Checked)
                {
                    pnl_detail.Height = pnl_grid.Height + pnl_detail.Height;
                    
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = true;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = true;

                    fgrid_main.Enabled = false;
                    tbtn_Save.Enabled  = false;

                    cmb_factory.Enabled     = false;
                    cmb_season_from.Enabled = false;
                    cmb_season_to.Enabled   = false;
                    cmb_category.Enabled    = false;
                    cmb_user.Enabled        = false;
                    dpk_get_from.Enabled    = false;
                    dpk_get_to.Enabled      = false;
                                        
                    txt_model.Enabled = false;

                    

                    txt_search.Text = "";

                    chk_flg = true;
                    chk_all_search.Checked = true;
                    chk_flg = false;
                }
                else
                {
                    pnl_detail.Height = 216;
                    

                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = false;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = false;

                    fgrid_main.Enabled = true;
                    tbtn_Save.Enabled  = true;

                    cmb_factory.Enabled     = true;
                    cmb_season_from.Enabled = true;
                    cmb_season_to.Enabled   = true;
                    cmb_category.Enabled    = true;
                    cmb_user.Enabled        = true;
                    dpk_get_from.Enabled    = true;
                    dpk_get_to.Enabled      = true;

                    
                    txt_model.Enabled = true;

                    
                    txt_search.Text = "";

                    if (tab_grid_main.SelectedIndex.Equals(0))
                        Display_File_Data(fgrid_main);
                    else
                        Display_File_Data(fgrid_main_02);

                    chk_flg = true;
                    chk_all_search.Checked = false;
                    chk_flg = false;
                }

                setting_flg = false;
            }
            catch
            {
 
            }
        }
        #endregion

        #region ComboBox Event
        private void cmb_round_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (setting_flg)
                    return;

                if (chk_all_search.Checked)
                    return;

                if (tab_grid_main.SelectedIndex.Equals(0))
                    Display_Detail_Data(fgrid_main);
                else
                    Display_Detail_Data(fgrid_main_02);

                fgrid_detail.Tree.Show(1);
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void cmb_task_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (setting_flg)
                    return;

                if (chk_all_file.Checked)
                    return;

                if (tab_grid_main.SelectedIndex.Equals(0))
                    Display_File_Data(fgrid_main);
                else
                    Display_File_Data(fgrid_main_02);
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion

        #region TextBox Event
        private void txt_mo_id_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    tbtn_Search_Click(null, null);
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void txt_model_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    tbtn_Search_Click(null, null);
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void txt_bom_id_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (tab_grid_main.SelectedIndex.Equals(0))
                        Display_Detail_Data(fgrid_main);
                    else
                        Display_Detail_Data(fgrid_main_02); 

                    fgrid_detail.Tree.Show(1);
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (tab_grid_main.SelectedIndex.Equals(0))
                        Display_File_Data(fgrid_main);
                    else
                        Display_File_Data(fgrid_main_02);
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion

        #region TabControl Event

        #region Main Event
        private void tab_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_chart_01.Width = pnl_chart_main.Width / 2;
        }
        #endregion

        #region Detail Event
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (setting_flg)
                    return;

                if (tabControl1.SelectedIndex.Equals(0))
                {
                    if (chk_all_search.Checked)
                    {
                        fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = true;
                    }
                    else
                    {
                        if (tab_grid_main.SelectedIndex.Equals(0))
                            Display_Detail_Data(fgrid_main);
                        else
                            Display_Detail_Data(fgrid_main_02);
                    }
                }
                else
                {
                    if (chk_all_file.Checked)
                    {
                        fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = true;
                    }
                    else
                    {
                        fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = false;
                        if (tab_grid_main.SelectedIndex.Equals(0))
                            Display_File_Data(fgrid_main);
                        else
                            Display_File_Data(fgrid_main_02);
                    }
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion

        #endregion

        #endregion

        #region ContextMenu Event

        #region Main Grid
        private void mnu_open_subfile_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[3];

                if (tab_grid_main.SelectedIndex.Equals(0))
                {
                    arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSRF_NO].ToString().Trim();
                }
                else
                {
                    arg_value[0] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSRF_NO].ToString().Trim(); 
                }

                Pop_Sch_Devcheck_File pop = new Pop_Sch_Devcheck_File("MNG", arg_value);
                pop.ShowDialog();
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void mnu_print_Click(object sender, EventArgs e)
        {
            try
            {   
                string[] arg_value = new string[3];

                if (tab_grid_main.SelectedIndex.Equals(0))
                {
                    arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSRF_NO].ToString().Trim();
                }
                else
                {
                    arg_value[0] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main_02[fgrid_main_02.Selection.r1, (int)ClassLib.TBSXC_SCH_MODEL_SCHEDULE.IxSRF_NO].ToString().Trim(); 
                }

                string mrd_Filename = Application.StartupPath + @"\Development_Meeting_03.mrd";
                string sPara = " /rp" + " [" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion


        #region Detail Grid
        private void mnu_open_file_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex.Equals(0))
                {
                    File_Open_01();
                }
                else
                {
                    File_Open_02(); 
                }
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private void File_Open_01()
        {
            int sct_row = fgrid_detail.Selection.r1;
            int sct_col = fgrid_detail.Selection.c1;

            string[] arg_value = new string[7];
            arg_value[0] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
            arg_value[1] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
            arg_value[2] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
            arg_value[3] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
            arg_value[4] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
            arg_value[5] = Get_NF_SEQ(sct_col);
            arg_value[6] = Get_TASK_CD(sct_col);

            Pop_Sch_Management_File pop = new Pop_Sch_Management_File(arg_value);
            pop.ShowDialog(); 
        }
        private void File_Open_02()
        {
            try
            {
                string save_path = "C:\\Program Files\\PCC_Sephiroth\\sch_file";

                DirectoryInfo di = new DirectoryInfo(save_path);

                if (!di.Exists)
                {
                    di.Create();
                }
                else
                {

                }
                for (int i = fgrid_file.Rows.Fixed; i < fgrid_file.Rows.Count; i++)
                {
                    string chk = fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxCHK].ToString().Trim().ToUpper();

                    if (chk.Equals("TRUE"))
                    {
                        try
                        {

                            string factory = fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFACTORY].ToString().Trim();
                            string file_cd = fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_CD].ToString().Trim();
                            string file_name = int.Parse(fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_CD].ToString()).ToString() + "_"
                                               + fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_NAME_V].ToString().Trim().Replace("/", "_");

                            string file_path = save_path + "\\" + file_name;
                            string file_type = file_name.Substring(file_name.LastIndexOf(".") + 1, 3).Trim().ToUpper();

                            File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));

                            if (file_type.Equals("XLS"))
                            {
                                ProcessStartInfo ps = new ProcessStartInfo("EXCEL.EXE");
                                ps.WorkingDirectory = save_path;
                                ps.FileName = file_name;

                                Process.Start(ps);
                            }
                            else
                            {
                                ProcessStartInfo ps = new ProcessStartInfo();
                                ps.WorkingDirectory = save_path;
                                ps.FileName = file_name;

                                Process.Start(ps);
                            }
                        }
                        catch (Exception ex)
                        {
                            string file_name = int.Parse(fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_CD].ToString()).ToString() + "_"
                                           + fgrid_file[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxFILE_NAME_V].ToString().Trim().Replace("/", "_");
                            MessageBox.Show(file_name + "\r\n\r\nThis File have a problem,\r\n\r\nPlease ask System.");
                            continue;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("This File have a problem,\r\n\r\nPlease ask System.");
            }
            finally
            {

            }
        }

        private string Get_TASK_CD(int arg_col)
        {
            string task_cd = "";

            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_YN  ] = "510";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM     ] = "510";            
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD_YN] = "520";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD   ] = "520";            
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC_YN  ] = "530";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC     ] = "530";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK_YN] = "540";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK   ] = "540";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM_YN  ] = "550";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM     ] = "550";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_YN   ] = "560";
            tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP      ] = "560";

            task_cd = tk_cd[arg_col];
            return task_cd;
        }
        private string Get_NF_SEQ(int arg_col)
        {
            string nfseq = "";

            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_YN  ] = "501";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM     ] = "501";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD_YN] = "502";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD   ] = "502";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC_YN  ] = "503";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC     ] = "503";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK_YN] = "504";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK   ] = "504";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM_YN  ] = "505";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM     ] = "505";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_YN   ] = "506";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP      ] = "506";

            nfseq = nf_seq[arg_col];
            return nfseq;
        }
        #endregion

        #endregion

        #region CheckBox Event
        private void chk_dev_check_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (chk_dev_check.Checked)
                {
                    chk_cfm_shoe.Checked = false;
                    chk_comm.Checked     = false;
                    chk_all.Checked      = false;                    
                }

                if (!chk_dev_check.Checked && !chk_cfm_shoe.Checked && !chk_comm.Checked && !chk_all.Checked)
                    chk_all.Checked = true;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chk_cfm_shoe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (chk_cfm_shoe.Checked)
                {
                    chk_dev_check.Checked = false;
                    chk_all.Checked       = false;
                    chk_comm.Checked      = false;
                }

                if (!chk_dev_check.Checked && !chk_cfm_shoe.Checked && !chk_comm.Checked && !chk_all.Checked)
                    chk_all.Checked = true;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chk_comm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (chk_comm.Checked)
                {
                    chk_dev_check.Checked = false;
                    chk_cfm_shoe.Checked  = false;
                    chk_all.Checked       = false;
                }

                if (!chk_dev_check.Checked && !chk_cfm_shoe.Checked && !chk_comm.Checked && !chk_all.Checked)
                    chk_all.Checked = true;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (chk_all.Checked)
                {
                    chk_dev_check.Checked = false;
                    chk_cfm_shoe.Checked  = false;
                    chk_comm.Checked      = false;
                }

                if (!chk_dev_check.Checked && !chk_cfm_shoe.Checked && !chk_comm.Checked && !chk_all.Checked)
                    chk_all.Checked = true;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region SQL Server
        private SqlConnection SQL_CONNECTION()
        {
            try
            {
                string sqlConnection = "server=203.228.108.30;database=PCC_Schedule;uid=sa;pwd=csiroot1128;Connection Timeout=300;";
                if (COM.ComVar.This_Factory.Equals("VJ"))
                    sqlConnection = "server=211.54.128.3;database=PCC_Schedule;uid=sa;pwd=csiroot1;Connection Timeout=300;";
                if (COM.ComVar.This_Factory.Equals("QD"))
                    sqlConnection = "server=119.119.119.18;database=PCC_Schedule;uid=sa;pwd=csiroot1;Connection Timeout=300;";

                SqlConnection conn = new SqlConnection(sqlConnection);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {

            }
        }       

        #region Select File
        private string select_query()
        {
            string select_query = "SELECT RAW_FILE FROM SXC_SCH_FILE WHERE FACTORY = @FACTORY AND FILE_CD = @FILE_CD";

            return select_query;
        }
        private byte[] SELECT_FILE(string arg_factory, string arg_file_cd)
        {
            try
            {
                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(select_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_factory);
                com.Parameters.AddWithValue("@FILE_CD", arg_file_cd);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds, "SXC_SCH_FILE");
                byte[] MyData = null;


                if (ds.Tables[0].Rows.Count > 0)
                {
                    MyData = (byte[])ds.Tables[0].Rows[0].ItemArray[0];
                }

                conn.Close();

                return MyData;
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


