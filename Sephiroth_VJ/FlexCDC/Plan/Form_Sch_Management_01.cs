using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;


namespace FlexCDC.Plan
{
    public partial class Form_Sch_Management_01 : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수 
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private bool[] dev_check  = new bool[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMAX_CNT];
        private string[] nf_cd    = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMAX_CNT];
        private string[] nf_seq   = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMAX_CNT];
        private string[] tk_cd    = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMAX_CNT];
        private bool column_view  = true;
        private Outlook.Application outlook = null;
        private Outlook.MailItem mailitem = null;        
        #endregion

        #region 생성자
        public Form_Sch_Management_01()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Sch_Management_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Schedule Management";
            this.lbl_MainTitle.Text = "PCC_Schedule Management";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;

            //Prod. Factory
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_p_factory.SelectedIndex = 0;

            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

            dt_ret = SELECT_SEASON_DEFAULT();

            if (dt_ret.Rows.Count > 0)
            {
                string default_season = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
                cmb_season_from.SelectedValue = default_season;
                cmb_season_to.SelectedValue = default_season;
            }
            else
            {
                cmb_season_from.SelectedValue = "201001";
                cmb_season_to.SelectedValue = "201001";
            }

            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            //User            
            string _power_lev = COM.ComVar.This_CDCPower_Level;

            if (!_power_lev.Substring(0, 1).Equals("D"))
            {
                dt_ret = SELECT_USER();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                cmb_user.SelectedIndex = 0;                
            }
            else
            {
                cmb_user.Enabled = false;

                DataTable user_datatable = new DataTable("UserList");
                DataRow newrow;

                user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                newrow = user_datatable.NewRow();
                newrow["Code"] = ClassLib.ComVar.This_User;
                newrow["Name"] = ClassLib.ComVar.This_User;

                user_datatable.Rows.Add(newrow);
                ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, 0, 200);
                cmb_user.SelectedValue = ClassLib.ComVar.This_User;                
            }                 
            #endregion

            #region Grid Setting 
            //Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_MANAGEMENT", "2", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;
            fgrid_main.Tree.Column = (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME;
            fgrid_main.KeyActionEnter = KeyActionEnum.None;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN).StyleNew.BackColor = Color.FromArgb(255, 255, 101);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD).StyleNew.ForeColor = Color.Black;            
            
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;

            chk_dev_check.Checked = true;
            #endregion 
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
        private DataTable SELECT_SEASON_DEFAULT()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_SEASON_DEFAULT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_YEAR_MONTH";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = DateTime.Now.ToString("yyyyMM");
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
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Display_Data();
                Display_File_YN();
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
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            string[] arg_value = new string[8];

            arg_value[0] = cmb_factory.SelectedValue.ToString();
            arg_value[1] = cmb_p_factory.SelectedValue.ToString();
            arg_value[2] = cmb_season_from.SelectedValue.ToString();
            arg_value[3] = cmb_season_to.SelectedValue.ToString();
            arg_value[4] = cmb_category.SelectedValue.ToString();
            arg_value[5] = txt_model.Text.Trim();
            arg_value[6] = cmb_user.SelectedValue.ToString();
            arg_value[7] = (chk_adjust.Checked) ? "Y" : "N";

            #region Task Setting
            DataTable dt_ret = SELECT_SCH_MANAGEMENT(arg_value);
            DataTable dt_task_01 = SELECT_SCH_TASK("01");
            DataTable dt_task_02 = SELECT_SCH_TASK("02");

            string value = "";
            string name = "";

            System.Collections.Specialized.ListDictionary ld_lev01 = new System.Collections.Specialized.ListDictionary();
            ld_lev01.Add("", "");

            if (dt_task_01.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_01.Rows.Count; row++)
                {
                    value = dt_task_01.Rows[row].ItemArray[0].ToString();
                    name = dt_task_01.Rows[row].ItemArray[1].ToString();

                    ld_lev01.Add(value, name);
                }
            }

            System.Collections.Specialized.ListDictionary ld_lev02 = new System.Collections.Specialized.ListDictionary();
            ld_lev02.Add("", "");

            if (dt_task_02.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_02.Rows.Count; row++)
                {
                    value = dt_task_02.Rows[row].ItemArray[0].ToString();
                    name = dt_task_02.Rows[row].ItemArray[1].ToString();

                    ld_lev02.Add(value, name);
                }
            }
            #endregion

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                int vTreeLevel = int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString());
                fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, vTreeLevel);

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();                    
                }
            
                fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREMARKS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxUPD_YMD).StyleNew.BackColor = Color.White;

                string rep_yn = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN].ToString().Trim();

                if (vTreeLevel.Equals(1))
                {
                    #region Level 1 Style Setting

                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN).StyleNew.BackColor = Color.Beige;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.BackColor = Color.Beige;

                    if(rep_yn.Equals("Y"))
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;
                    else
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.ForeColor = Color.Black;


                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);                                       
                                        

                    CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN);
                    CellStyle cellst_dev = fgrid_main.Styles.Add("COMBO_DEV");
                    cellst_dev.DataMap = ld_lev01;
                    cellst_dev.BackColor = Color.FromArgb(223, 250, 197);
                    cellst_dev.ForeColor = Color.Black;
                    cellst_dev.TextAlign = TextAlignEnum.CenterCenter;
                    cellrg.Style = fgrid_main.Styles["COMBO_DEV"];

                    CellStyle cellst_comm = fgrid_main.Styles.Add("COMBO_COMM");
                    cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN);
                    cellst_comm.DataMap = ld_lev01;
                    cellst_comm.BackColor = Color.FromArgb(254, 239, 220);
                    cellst_comm.ForeColor = Color.Black;
                    cellst_comm.TextAlign = TextAlignEnum.CenterCenter;
                    cellrg.Style = fgrid_main.Styles["COMBO_COMM"];

                    CellStyle cellst_cfm = fgrid_main.Styles.Add("COMBO_CFM");
                    cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN);
                    cellst_cfm.DataMap = ld_lev01;
                    cellst_cfm.BackColor = Color.FromArgb(255, 255, 156);
                    cellst_cfm.ForeColor = Color.Black;
                    cellst_cfm.TextAlign = TextAlignEnum.CenterCenter;
                    cellrg.Style = fgrid_main.Styles["COMBO_CFM"];
                    #endregion
                }
                else if (vTreeLevel.Equals(2))
                {
                    if (fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID].ToString().Trim().Equals("_________________"))
                    {
                        #region Level 2 & Model Data Style Setting
                        string _nf_seq = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();
                        
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxUPD_YMD).StyleNew.BackColor = Color.White;

                        if (_nf_seq.Equals("999"))
                        {
                            fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = false;

                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.BackColor = Color.FromArgb(255, 250, 210);

                            CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN);
                            CellStyle cellst_dev = fgrid_main.Styles.Add("COMBO_DEV_F");
                            cellst_dev.DataMap = ld_lev02;
                            cellst_dev.BackColor = Color.Aquamarine;
                            cellst_dev.ForeColor = Color.Black;
                            cellst_dev.TextAlign = TextAlignEnum.CenterCenter;
                            cellrg.Style = fgrid_main.Styles["COMBO_DEV_F"];

                            CellStyle cellst_comm = fgrid_main.Styles.Add("COMBO_COMM_F");
                            cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN);
                            cellst_comm.DataMap = ld_lev02;
                            cellst_comm.BackColor = Color.MistyRose;
                            cellst_comm.ForeColor = Color.Black;
                            cellst_comm.TextAlign = TextAlignEnum.CenterCenter;
                            cellrg.Style = fgrid_main.Styles["COMBO_COMM_F"];

                            CellStyle cellst_cfm = fgrid_main.Styles.Add("COMBO_CFM_F");
                            cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN);
                            cellst_cfm.DataMap = ld_lev02;
                            cellst_cfm.BackColor = Color.FromArgb(255, 250, 205);
                            cellst_cfm.ForeColor = Color.Black;
                            cellst_cfm.TextAlign = TextAlignEnum.CenterCenter;
                            cellrg.Style = fgrid_main.Styles["COMBO_CFM_F"];
                        }
                        else
                        {
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.BackColor = Color.FromArgb(255, 255, 245);
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.BackColor = Color.FromArgb(255, 255, 245);                            

                            CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN);
                            CellStyle cellst = fgrid_main.Styles.Add("DATE_TIME");
                            cellst.DataType = typeof(DateTime);
                            cellst.Format = "yyyyMMdd";
                            cellst.TextAlign = TextAlignEnum.CenterCenter;
                            cellst.BackColor = Color.White;
                            cellst.ForeColor = Color.Black;
                            cellrg.Style = fgrid_main.Styles["DATE_TIME"];
                        }
                        #endregion
                    }
                    else
                    {
                        #region Level 2 & BOM Task Style Setting                        
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 250, 236);

                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN).StyleNew.BackColor = Color.FromArgb(255, 255, 232);
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.BackColor = Color.FromArgb(255, 255, 232);

                        if (rep_yn.Equals("Y"))
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;
                        else
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.ForeColor = Color.Black;
                        
                        CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN);
                        CellStyle cellst_dev = fgrid_main.Styles.Add("COMBO_DEV_B");
                        cellst_dev.DataType = typeof(DateTime);
                        cellst_dev.Format = "yyyyMMdd";
                        cellst_dev.BackColor = Color.MintCream;
                        cellst_dev.ForeColor = Color.Black;
                        cellst_dev.TextAlign = TextAlignEnum.CenterCenter;
                        cellrg.Style = fgrid_main.Styles["COMBO_DEV_B"];

                        CellStyle cellst_comm = fgrid_main.Styles.Add("COMBO_COMM_B");
                        cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN);
                        cellst_comm.DataType = typeof(DateTime);
                        cellst_comm.Format = "yyyyMMdd";
                        cellst_comm.BackColor = Color.Snow;
                        cellst_comm.ForeColor = Color.Black;
                        cellst_comm.TextAlign = TextAlignEnum.CenterCenter;
                        cellrg.Style = fgrid_main.Styles["COMBO_COMM_B"];

                        CellStyle cellst_cfm = fgrid_main.Styles.Add("COMBO_CFM_B");
                        cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN);
                        cellst_cfm.DataType = typeof(DateTime);
                        cellst_cfm.Format = "yyyyMMdd";
                        cellst_cfm.BackColor = Color.FromArgb(255, 255, 205);
                        cellst_cfm.ForeColor = Color.Black;
                        cellst_cfm.TextAlign = TextAlignEnum.CenterCenter;
                        cellrg.Style = fgrid_main.Styles["COMBO_CFM_B"];
                        #endregion                        
                    }
                }
                else
                {
                    #region Level 3 Style Setting
                    string _nf_seq = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.BackColor = Color.White;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxUPD_YMD).StyleNew.BackColor = Color.WhiteSmoke;

                    if (_nf_seq.Equals(""))
                    {
                        
                    }
                    else
                    {
                        CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN);
                        CellStyle cellst = fgrid_main.Styles.Add("DATE_TIME_03");
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.BackColor = Color.WhiteSmoke;
                        cellrg.Style = fgrid_main.Styles["DATE_TIME_03"];
                    }
                    #endregion
                }
            }

            if(rbtn_model.Checked)
                fgrid_main.Tree.Show(1);
            else if(rbtn_bom.Checked)
                fgrid_main.Tree.Show(2);
            else
                fgrid_main.Tree.Show(3);
        }
        private void Display_File_YN()
        {
            #region Combo Data Setting
            DataTable dt_task_01 = SELECT_SCH_TASK("01");
            DataTable dt_task_02 = SELECT_SCH_TASK("02");
            DataTable dt_task_03 = SELECT_SCH_TASK("03");

            string value = "";
            string name = "";

            System.Collections.Specialized.ListDictionary ld_lev_01 = new System.Collections.Specialized.ListDictionary();
            ld_lev_01.Add("", "");

            if (dt_task_01.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_01.Rows.Count; row++)
                {
                    value = dt_task_01.Rows[row].ItemArray[0].ToString();
                    name = dt_task_01.Rows[row].ItemArray[1].ToString();

                    ld_lev_01.Add(value, name);
                }
            }

            string value_02 = "";
            string name_02 = "";

            System.Collections.Specialized.ListDictionary ld_lev_02 = new System.Collections.Specialized.ListDictionary();
            ld_lev_02.Add("", "");

            if (dt_task_02.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_02.Rows.Count; row++)
                {
                    value_02 = dt_task_02.Rows[row].ItemArray[0].ToString();
                    name_02 = dt_task_02.Rows[row].ItemArray[1].ToString();

                    ld_lev_02.Add(value_02, name_02);
                }
            }

            string value_03 = "";
            string name_03 = "";

            System.Collections.Specialized.ListDictionary ld_lev_03 = new System.Collections.Specialized.ListDictionary();
            ld_lev_03.Add("", "");

            if (dt_task_03.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_03.Rows.Count; row++)
                {
                    value_03 = dt_task_03.Rows[row].ItemArray[0].ToString();
                    name_03 = dt_task_03.Rows[row].ItemArray[1].ToString();

                    ld_lev_03.Add(value_03, name_03);
                }
            }
            #endregion
            
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _level  = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
                string _nf_seq = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();

                if (_level.Equals("1") || (_level.Equals("2") && _nf_seq.Equals("")))
                {
                    for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN; j++)
                    {
                        string file_yn = (fgrid_main[i, j] == null) ? "" : fgrid_main[i, j].ToString().Trim();

                        if (file_yn.Equals("Y"))
                        {
                            if (_level.Equals("1"))
                            {
                                #region Level 1 Style Setting
                                CellRange cellrg = fgrid_main.GetCellRange(i, j - 1);
                                CellStyle cellst_01 = fgrid_main.Styles.Add("COMBO_01");
                                cellst_01.DataMap = ld_lev_01;
                                cellst_01.ForeColor = Color.Red;
                                cellst_01.TextAlign = TextAlignEnum.CenterCenter;

                                if(j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN)
                                    cellst_01.BackColor = Color.FromArgb(223, 250, 197);
                                else if(j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN)
                                    cellst_01.BackColor = Color.FromArgb(254, 239, 220);
                                else if(j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN)
                                    cellst_01.BackColor = Color.FromArgb(255, 255, 156);

                                cellrg.Style = fgrid_main.Styles["COMBO_01"];                               
                                #endregion
                            }
                            else if (_level.Equals("2"))
                            {                                
                                #region Level 2 Style Setting
                                CellRange cellrg = fgrid_main.GetCellRange(i, j - 1);
                                CellStyle cellst_02 = fgrid_main.Styles.Add("COMBO_02");
                                cellst_02.DataType = typeof(DateTime);
                                cellst_02.Format = "yyyyMMdd";
                                //cellst_02.DataMap = ld_lev_02;
                                cellst_02.ForeColor = Color.Red;
                                cellst_02.TextAlign = TextAlignEnum.CenterCenter;

                                if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN)
                                    cellst_02.BackColor = Color.MintCream;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN)
                                    cellst_02.BackColor = Color.Snow;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN)
                                    cellst_02.BackColor = Color.FromArgb(255, 255, 205);

                                cellrg.Style = fgrid_main.Styles["COMBO_02"];
                                #endregion
                            }
                        }
                    }
                }
                else if (_nf_seq.Equals("005"))
                {
                    for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN; j++)
                    {
                        string progress = (fgrid_main[i, j] == null) ? "" : fgrid_main[i, j].ToString().Trim();

                        #region Progress Setting
                        CellRange cellrg = fgrid_main.GetCellRange(i, j);

                        if (_level.Equals("2"))
                        {
                            CellStyle cellst_03 = fgrid_main.Styles.Add("COMBO_03_" + i.ToString() + j.ToString());
                            cellst_03.DataMap = ld_lev_03;
                            cellst_03.ForeColor = Color.Black;
                            cellst_03.TextAlign = TextAlignEnum.CenterCenter;
                            cellst_03.BackColor = Color.White;
                            if (progress.Equals("C"))
                                cellst_03.BackColor = Color.Aqua;
                            else if (progress.Equals("Y"))
                                cellst_03.BackColor = Color.Yellow;
                            else                        
                                cellst_03.BackColor = Color.White;

                            cellrg.Style = fgrid_main.Styles["COMBO_03_" + i.ToString() + j.ToString()];
                        }
                        else
                        {
                            CellStyle cellst_03 = fgrid_main.Styles.Add("COMBO_04_" + i.ToString() + j.ToString());
                            cellst_03.DataMap = ld_lev_03;
                            cellst_03.ForeColor = Color.Blue;
                            cellst_03.TextAlign = TextAlignEnum.CenterCenter;
                            cellst_03.BackColor = Color.White;
                            if (progress.Equals("C"))
                                cellst_03.BackColor = Color.Aqua;
                            else if (progress.Equals("Y"))
                                cellst_03.BackColor = Color.Yellow;
                            else
                                cellst_03.BackColor = Color.WhiteSmoke;

                            cellrg.Style = fgrid_main.Styles["COMBO_04_" + i.ToString() + j.ToString()];
                        }
                        #endregion
                    }                
                }
            }
        }


        private DataTable SELECT_SCH_MANAGEMENT(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(9);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_MANAGEMENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL";
                MyOraDB.Parameter_Name[6] = "ARG_USER";
                MyOraDB.Parameter_Name[7] = "ARG_ADJ_CHK";
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

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                SAVE_DATA();
                UPDATE_FILE_TASK();
                
                fgrid_main.ClearFlags();
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

        private void SAVE_DATA()
        {
            int vcnt = 52;

            MyOraDB.ReDim_Parameter(vcnt);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_SXC_SCH_MANAGEMENT";


            MyOraDB.Parameter_Name[0 ] = "ARG_DIVISION";
            MyOraDB.Parameter_Name[1 ] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2 ] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[3 ] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[4 ] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[5 ] = "ARG_NF_SEQ";
            MyOraDB.Parameter_Name[6 ] = "ARG_N010_T01_CD";
            MyOraDB.Parameter_Name[7 ] = "ARG_N010_T02_CD";
            MyOraDB.Parameter_Name[8 ] = "ARG_N010_T03_CD";
            MyOraDB.Parameter_Name[9 ] = "ARG_N010_T04_CD";
            MyOraDB.Parameter_Name[10] = "ARG_N010_T05_CD";
            MyOraDB.Parameter_Name[11] = "ARG_N020_T01_CD";
            MyOraDB.Parameter_Name[12] = "ARG_N020_T02_CD";
            MyOraDB.Parameter_Name[13] = "ARG_N020_T03_CD";
            MyOraDB.Parameter_Name[14] = "ARG_N020_T04_CD";
            MyOraDB.Parameter_Name[15] = "ARG_N020_T05_CD";
            MyOraDB.Parameter_Name[16] = "ARG_N030_T01_CD";
            MyOraDB.Parameter_Name[17] = "ARG_N030_T02_CD";
            MyOraDB.Parameter_Name[18] = "ARG_N030_T03_CD";
            MyOraDB.Parameter_Name[19] = "ARG_N030_T04_CD";
            MyOraDB.Parameter_Name[20] = "ARG_N030_T05_CD";
            MyOraDB.Parameter_Name[21] = "ARG_N040_T01_CD";
            MyOraDB.Parameter_Name[22] = "ARG_N040_T02_CD";
            MyOraDB.Parameter_Name[23] = "ARG_N040_T03_CD";
            MyOraDB.Parameter_Name[24] = "ARG_N040_T04_CD";
            MyOraDB.Parameter_Name[25] = "ARG_N040_T05_CD";
            MyOraDB.Parameter_Name[26] = "ARG_N050_T01_CD";
            MyOraDB.Parameter_Name[27] = "ARG_N060_T01_CD";
            MyOraDB.Parameter_Name[28] = "ARG_N070_T01_CD";
            MyOraDB.Parameter_Name[29] = "ARG_N080_T01_CD";
            MyOraDB.Parameter_Name[30] = "ARG_N090_T01_CD";
            MyOraDB.Parameter_Name[31] = "ARG_N100_T01_CD";
            MyOraDB.Parameter_Name[32] = "ARG_N110_T01_CD";
            MyOraDB.Parameter_Name[33] = "ARG_N120_T01_CD";
            MyOraDB.Parameter_Name[34] = "ARG_N130_T01_CD";
            MyOraDB.Parameter_Name[35] = "ARG_N140_T01_CD";
            MyOraDB.Parameter_Name[36] = "ARG_N150_T01_CD";
            MyOraDB.Parameter_Name[37] = "ARG_N160_T01_CD";
            MyOraDB.Parameter_Name[38] = "ARG_N170_T01_CD";
            MyOraDB.Parameter_Name[39] = "ARG_N180_T01_CD";
            MyOraDB.Parameter_Name[40] = "ARG_N190_T01_CD";
            MyOraDB.Parameter_Name[41] = "ARG_N200_T01_CD";
            MyOraDB.Parameter_Name[42] = "ARG_N210_T01_CD";
            MyOraDB.Parameter_Name[43] = "ARG_N220_T01_CD";
            MyOraDB.Parameter_Name[44] = "ARG_N230_T01_CD";
            MyOraDB.Parameter_Name[45] = "ARG_N240_T01_CD";
            MyOraDB.Parameter_Name[46] = "ARG_N240_T02_CD";
            MyOraDB.Parameter_Name[47] = "ARG_N240_T03_CD";
            MyOraDB.Parameter_Name[48] = "ARG_N240_T04_CD";
            MyOraDB.Parameter_Name[49] = "ARG_N240_T05_CD";
            MyOraDB.Parameter_Name[50] = "ARG_REMARK";
            MyOraDB.Parameter_Name[51] = "ARG_UPD_USER";            
            

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
            {
                string _div = fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;
                
                string _lev     = fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
                string _nf_seq  = fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();
                string division = "";

                if (_lev.Equals("1") && _nf_seq.Equals(""))
                {
                    division = "H";
                }
                else
                {
                    if (_nf_seq.Equals(""))
                        _nf_seq = "004";

                    division = "T";
                }

                MyOraDB.Parameter_Values[vcnt++] = division;
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY  ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = _nf_seq;
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05);
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREMARKS    ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREMARKS    ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;                
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private string GET_GRID_DATA_CHANGE(int arg_row, int arg_col)
        {
            string value = "";

            try
            {
                value = Convert.ToDateTime(fgrid_main[arg_row, arg_col].ToString().Trim()).ToString("yyyyMMdd");
            }
            catch
            {
                value = (fgrid_main[arg_row, arg_col] == null) ? "" : fgrid_main[arg_row, arg_col].ToString().Trim();
            }

            return value;
        }

        private void UPDATE_FILE_TASK()
        {
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV].ToString().Trim();

                if (_div.Equals("U"))
                {
                    for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN; j++)
                    {
                        string _file_yn = (fgrid_main[i, j] == null) ? "" : fgrid_main[i, j].ToString().Trim().ToUpper();

                        if (_file_yn.Equals("Y"))
                        {
                            string _task = (fgrid_main[i, j - 1] == null) ? "" : fgrid_main[i, j - 1].ToString().Trim();

                            if (!_task.Equals(""))
                            {
                                string[] arg_value = new string[7];

                                arg_value[0] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY].ToString().Trim();
                                arg_value[1] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID].ToString().Trim();
                                arg_value[2] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO].ToString().Trim();
                                arg_value[3] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID].ToString().Trim();
                                arg_value[4] = Get_NF_CD(j - 1);
                                arg_value[5] = Get_NF_SEQ(j - 1);
                                arg_value[6] = _task;

                                UPDATE_SCH_HEAD_FILE(arg_value);
                            }
                        }
                    }
                }
            }
        }
        private void UPDATE_SCH_HEAD_FILE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_HEAD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[5] = "ARG_NF_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_TK_CD";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();                                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save File Data", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        
        #endregion

        #region Grid Event
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSEASON_V].Visible = column_view;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY_V].Visible = column_view;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxCATEGORY_V].Visible = column_view;

                    if (column_view)
                        column_view = false;
                    else
                        column_view = true;
                }
                else
                {
                    mnu_upload_file.Enabled = false;
                    mnu_open_file.Enabled   = false;
                    mnu_clear_data.Enabled  = false;
                    mnu_rep.Enabled         = false;
                    mnu_rep_cancel.Enabled  = false;

                    if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                        return;

                    int sct_row = fgrid_main.Selection.r1;
                    int sct_col = fgrid_main.Selection.c1;

                    if (sct_row < fgrid_main.Rows.Fixed)
                        return;

                    string _lev    = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
                    string _nf_seq = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();

                    if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN)
                    {
                        if (_lev.Equals("1") || (_lev.Equals("2") && _nf_seq.Equals("")))
                        {
                            string _value = (fgrid_main[sct_row, sct_col] == null) ? "" : fgrid_main[sct_row, sct_col].ToString().Trim();
                            string _file_yn = (fgrid_main[sct_row, sct_col + 1] == null) ? "" : fgrid_main[sct_row, sct_col + 1].ToString().Trim();

                            if (!_value.Equals(""))
                            {
                                mnu_clear_data.Enabled = true;
                                mnu_upload_file.Enabled = true;

                                if (_file_yn.Equals("Y"))
                                    mnu_open_file.Enabled = true;
                            }
                        }
                        else
                        {
                            if(!_nf_seq.Equals("999"))
                                mnu_clear_data.Enabled = true;
                        }
                    }
                    else if (sct_col.Equals((int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME))
                    {
                        if (_nf_seq.Equals(""))
                        {
                            mnu_rep.Enabled = true;
                            mnu_rep_cancel.Enabled = true;
                        }
                    }
                }
        
            }
            catch
            {
 
            }
        }

        private void fgrid_main_EnterCell(object sender, EventArgs e)
        {
            //try
            //{
            //    int sct_row = fgrid_main.Selection.r1;
            //    int sct_col = fgrid_main.Selection.c1;

            //    if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxMAT_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxIN_YMD)
            //    {
            //        fgrid_main.GetCellRange(sct_row, sct_col).StyleNew.DataType = typeof(DateTime);
            //        fgrid_main.GetCellRange(sct_row, sct_col).StyleNew.Format = "yyyyMMdd";
            //    }
            //}
            //catch
            //{

            //}
        }
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_SEQ].ToString().Trim().Equals("005"))
                    {
                        DataTable dt_task = SELECT_SCH_TASK("03");

                        string value = "";
                        string name = "";

                        System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary();
                        ld.Add("", "");

                        if (dt_task.Rows.Count > 0)
                        {
                            for (int row = 0; row < dt_task.Rows.Count; row++)
                            {
                                value = dt_task.Rows[row].ItemArray[0].ToString();
                                name = dt_task.Rows[row].ItemArray[1].ToString();

                                ld.Add(value, name);
                            }
                        }
                        
                        CellRange cellrg = fgrid_main.GetCellRange(sct_rows[i], sct_col);
                        CellStyle cellst = fgrid_main.Styles.Add("COMBO_YN_" + sct_rows[i].ToString() + sct_col.ToString());
                        cellst.DataMap = ld;                        
                        cellst.TextAlign = TextAlignEnum.CenterCenter;

                        string progress = (fgrid_main[sct_rows[i], sct_col] == null) ? "" : fgrid_main[sct_rows[i], sct_col].ToString().Trim();
                        string level = (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV] == null) ? "" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                        if(level.Equals("2"))
                            cellst.ForeColor = Color.Black;
                        else
                            cellst.ForeColor = Color.Blue;

                        if (progress.Equals("C"))
                            cellst.BackColor = Color.Aqua;
                        else if (progress.Equals("Y"))
                            cellst.BackColor = Color.Yellow;
                        else
                        {
                            if(level.Equals("2"))
                                cellst.BackColor = Color.White;
                            else
                                cellst.BackColor = Color.WhiteSmoke;
                        }

                        cellrg.Style = fgrid_main.Styles["COMBO_YN_" + sct_rows[i].ToString() + sct_col.ToString()];
                    }

                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";                    
                }
            }
            catch
            {

            }
        }

        private void fgrid_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private DataTable SELECT_SCH_TASK(string arg_division)
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_TASK";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_division;
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
        #endregion

        #region Control Event
        #region Combo Box
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////Model
                //DataTable dt_ret = SELECT_MODEL();

                //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model, 0, 1, true, 0, 300);
                //cmb_model.SelectedIndex = 0;
            }
            catch
            {

            }
            finally
            {

            }
        }
        private DataTable SELECT_MODEL()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_MODEL";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = "";

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

        #region Check Box
        private void chk_dev_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();
            }
            catch
            {
 
            }
        }

        private void chk_comm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();
            }
            catch
            {

            }
        }

        private void chk_cfm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();                
            }
            catch
            {

            }
        }

        private void chk_dev_check_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (chk_dev_check.Checked)
                {
                    chk_dev.Enabled = false;
                    chk_comm.Enabled = false;
                    chk_cfm.Enabled = false;

                    chk_cfm_shoe.Checked = false;
                }
                else
                {
                    if (!chk_cfm_shoe.Checked)
                    {
                        chk_dev.Enabled = true;
                        chk_comm.Enabled = true;
                        chk_cfm.Enabled = true;
                    }
                }

                if (!chk_cfm_shoe.Checked)
                    Get_View_Check();
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
                    chk_dev.Enabled  = false;
                    chk_comm.Enabled = false;
                    chk_cfm.Enabled  = false;

                    chk_dev_check.Checked = false;
                }
                else
                {
                    if (!chk_dev_check.Checked)
                    {
                        chk_dev.Enabled = true;
                        chk_comm.Enabled = true;
                        chk_cfm.Enabled = true;
                    }
                }

                if (!chk_dev_check.Checked)
                    Get_View_Check();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chk_adjust_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();
            }
            catch
            {
 
            }
        }

        private void Get_View_Check()
        {
            bool dev_chk        = chk_dev.Checked;
            bool cfm_show_chk   = chk_cfm_shoe.Checked;
            bool comm_chk       = chk_comm.Checked;
            bool cfm_chk        = chk_cfm.Checked;
            bool dev_report_chk = chk_dev_check.Checked;
            bool adj_chk        = chk_adjust.Checked;

            if (dev_report_chk)
            {
                #region 개발 점검 회의용 체크
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01] = true;  //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02] = true;  //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03] = true;  //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04] = true;  //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05] = true;  //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01] = true;  //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02] = true;  //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03] = true;  //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04] = true;  //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05] = true;  //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01] = false; //WHQ Tooling Target
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01] = true;  //WHQ Upper Target
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01] = false; //MS Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01] = true;  //MST S/F
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01] = true;  //Asia Tooling
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01] = true;  //MST
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01] = true;  //Asia Upper
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01] = true;  //MST TP Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01] = true;  //Offshore MST
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01] = false; //EXT Mold Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01] = true;  //EXT S/F
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01] = true;  //EXT ASS
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01] = true;  //EXT TP Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01] = false; //CSS Data CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01] = false; //A Set Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01] = false; //FSR S/T@CDC
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01] = false; //A Set Mold Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01] = true;  //FSR S/T@Offshore
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01] = true;  //FSR
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01] = false; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02] = false; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03] = false; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04] = false; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05] = false; //Prod. CFM
                #endregion
            }
            else if (cfm_show_chk)
            {
                #region CFM Shoe Schedule
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01] = false; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02] = false; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03] = false; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04] = false; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05] = false; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01] = false; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02] = false; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03] = false; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04] = false; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05] = false; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05] = true;  //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05] = true;  //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01] = false; //WHQ Tooling Target
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01] = false; //WHQ Upper Target
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01] = false; //MS Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01] = false; //MST S/F
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01] = false; //Asia Tooling
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01] = false; //MST
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01] = false; //Asia Upper
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01] = false; //MST TP Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01] = false; //Offshore MST
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01] = false; //EXT Mold Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01] = false; //EXT S/F
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01] = false; //EXT ASS
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01] = false; //EXT TP Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01] = false; //CSS Data CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01] = false; //A Set Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01] = false; //FSR S/T@CDC
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01] = false; //A Set Mold Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01] = false; //FSR S/T@Offshore
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01] = false; //FSR
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01] = true;  //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02] = true;  //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03] = true;  //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04] = true;  //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05] = true;  //Prod. CFM
                #endregion 
            }
            else
            {
                #region DEV
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01] = dev_chk; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02] = dev_chk; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03] = dev_chk; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04] = dev_chk; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05] = dev_chk; //SMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01] = dev_chk; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02] = dev_chk; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03] = dev_chk; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04] = dev_chk; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05] = dev_chk; //RLF
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01] = dev_chk; //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02] = dev_chk; //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03] = dev_chk; //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04] = dev_chk; //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05] = dev_chk; //GTM 1st
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01] = dev_chk; //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02] = dev_chk; //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03] = dev_chk; //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04] = dev_chk; //GTM 2nd
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05] = dev_chk; //GTM 2nd               
                #endregion

                #region COMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01] = comm_chk; //WHQ Tooling Target
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01] = comm_chk; //WHQ Upper Target
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01] = comm_chk; //MS Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01] = comm_chk; //MST S/F
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01] = comm_chk; //Asia Tooling
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01] = comm_chk; //MST
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01] = comm_chk; //Asia Upper
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01] = comm_chk; //MST TP Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01] = comm_chk; //Offshore MST
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01] = comm_chk; //EXT Mold Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01] = comm_chk; //EXT S/F
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01] = comm_chk; //EXT ASS
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01] = comm_chk; //EXT TP Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01] = comm_chk; //CSS Data CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01] = comm_chk; //A Set Part CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01] = comm_chk; //FSR S/T@CDC
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01] = comm_chk; //A Set Mold Shipping
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01] = comm_chk; //FSR S/T@Offshore
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01] = comm_chk; //FSR               
                #endregion

                #region PROD CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01] = cfm_chk; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02] = cfm_chk; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03] = cfm_chk; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04] = cfm_chk; //Prod. CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05] = cfm_chk; //Prod. CFM
                #endregion
            }

            for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05; j++)
            {
                fgrid_main.Cols[j].Visible = dev_check[j];
            }
        }
        #endregion

        #region Radio Button
        private void rbtn_model_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(1);
            }
            catch
            {
 
            }
        }

        private void rbtn_bom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(2);
            }
            catch
            {

            }
        }

        private void rbtn_task_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(3);
            }
            catch
            {

            }
        }
        #endregion        
        #endregion
                
        #region Context Menu Event
        private void mnu_moid_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(1);
        }
        private void mnu_bom_id_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(2);
        }
        private void mnu_task_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(3);
        }
        private void mnu_clear_data_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                if (sct_row < fgrid_main.Rows.Fixed)
                    return;

                fgrid_main[sct_row, sct_col] = null;
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxDIV] = "U";
            }
            catch
            {
 
            }
        }

        #region 대표 설정
        private void mnu_rep_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;


                string rep_yn = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN].ToString().Trim();
                string lev    = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
                string nf_seq = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();

                if(rep_yn.Equals("N"))
                {
                    string[] arg_value = new string[5];

                    arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO].ToString().Trim();
                    arg_value[3] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID].ToString().Trim();
                    arg_value[4] = "Y";

                    if (UPDATE_SXC_SCH_REP_YN(arg_value))
                    {
                        fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN] = "Y";
                        fgrid_main.GetCellRange(sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    if (lev.Equals("1"))
                        MessageBox.Show("This Model is already represented");
                    else
                        MessageBox.Show("This BOM is already represented");
                }

            }
            catch
            {
 
            }
        }

        private void mnu_rep_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;


                string rep_yn = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN].ToString().Trim();
                string lev    = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
                string nf_seq = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();

                if (rep_yn.Equals("Y"))
                {
                    string[] arg_value = new string[5];

                    arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO].ToString().Trim();
                    arg_value[3] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID].ToString().Trim();
                    arg_value[4] = "N";

                    if (UPDATE_SXC_SCH_REP_YN(arg_value))
                    {
                        fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxREP_YN] = "N";
                        fgrid_main.GetCellRange(sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxITEM_NAME).StyleNew.ForeColor = Color.Black;
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    if (lev.Equals("1"))
                        MessageBox.Show("This Model is already canceled");
                    else
                        MessageBox.Show("This BOM is already canceled");
                }

            }
            catch
            {

            }
        }

        private bool UPDATE_SXC_SCH_REP_YN(string[] arg_value)
        {
            try
            {
                bool ret = false;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_REP_YN";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";                
                MyOraDB.Parameter_Name[4] = "ARG_REP_YN";                
                MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;                

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        #region File Control
        private void mnu_upload_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Multiselect = true;
                
                if (openDlg.ShowDialog() == DialogResult.OK)
                {   
                    this.Cursor = Cursors.WaitCursor;


                    int sct_row = fgrid_main.Selection.r1;
                    int sct_col = fgrid_main.Selection.c1;                                        
                    
                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        string file_name_short = openDlg.FileNames[i].Substring(openDlg.FileNames[i].LastIndexOf("\\") + 1, openDlg.FileNames[i].Length - openDlg.FileNames[i].LastIndexOf("\\") - 1);
                        
                        string[] arg_value = new string[9];
                        
                        arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO].ToString().Trim();
                        arg_value[3] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID].ToString().Trim();
                        arg_value[4] = Get_NF_CD(sct_col);
                        arg_value[5] = Get_NF_SEQ(sct_col);
                        arg_value[6] = Get_TASK_CD(sct_row, sct_col);
                        arg_value[7] = GET_SCH_FILE_CD().Rows[0].ItemArray[0].ToString().Trim();
                        arg_value[8] = int.Parse(arg_value[7]).ToString() + "_" + file_name_short;

                        string file_name = openDlg.FileNames[i];

                        if (INSERT_FILE(arg_value, file_name))
                        {
                            if (!SAVE_SCH_HEAD_FILE(arg_value))
                            {
                                MessageBox.Show("FIle Upload Error, Please ask System");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("FIle Upload Error, Please ask System");
                            return; 
                        }
                    }

                    fgrid_main[sct_row, sct_col + 1] = "Y";

                    string _level = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
                    if (_level.Equals("1"))
                    {
                        #region Level 1 Style Setting
                        DataTable dt_task_01 = SELECT_SCH_TASK("01");

                        string value = "";
                        string name = "";

                        System.Collections.Specialized.ListDictionary ld_lev_01 = new System.Collections.Specialized.ListDictionary();
                        ld_lev_01.Add("", "");

                        if (dt_task_01.Rows.Count > 0)
                        {
                            for (int row = 0; row < dt_task_01.Rows.Count; row++)
                            {
                                value = dt_task_01.Rows[row].ItemArray[0].ToString();
                                name = dt_task_01.Rows[row].ItemArray[1].ToString();

                                ld_lev_01.Add(value, name);
                            }
                        }

                        CellRange cellrg = fgrid_main.GetCellRange(sct_row, sct_col);
                        CellStyle cellst_01 = fgrid_main.Styles.Add("COMBO_FI_01");
                        cellst_01.DataMap = ld_lev_01;
                        cellst_01.ForeColor = Color.Red;
                        cellst_01.TextAlign = TextAlignEnum.CenterCenter;

                        if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN)
                            cellst_01.BackColor = Color.FromArgb(223, 250, 197);
                        else if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN)
                            cellst_01.BackColor = Color.FromArgb(254, 239, 220);
                        else if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN)
                            cellst_01.BackColor = Color.FromArgb(255, 255, 156);

                        cellrg.Style = fgrid_main.Styles["COMBO_FI_01"];
                        #endregion
                    }
                    else if (_level.Equals("2"))
                    {
                        #region Level 2 Style Setting
                        DataTable dt_task_02 = SELECT_SCH_TASK("02");
                        string value_02 = "";
                        string name_02 = "";

                        System.Collections.Specialized.ListDictionary ld_lev_02 = new System.Collections.Specialized.ListDictionary();
                        ld_lev_02.Add("", "");

                        if (dt_task_02.Rows.Count > 0)
                        {
                            for (int row = 0; row < dt_task_02.Rows.Count; row++)
                            {
                                value_02 = dt_task_02.Rows[row].ItemArray[0].ToString();
                                name_02 = dt_task_02.Rows[row].ItemArray[1].ToString();

                                ld_lev_02.Add(value_02, name_02);
                            }
                        }

                        CellRange cellrg = fgrid_main.GetCellRange(sct_row, sct_col);
                        CellStyle cellst_02 = fgrid_main.Styles.Add("COMBO_FI_02");
                        cellst_02.DataMap = ld_lev_02;
                        cellst_02.ForeColor = Color.Red;
                        cellst_02.TextAlign = TextAlignEnum.CenterCenter;

                        if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05_YN)
                            cellst_02.BackColor = Color.MintCream;
                        else if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01_YN)
                            cellst_02.BackColor = Color.Snow;
                        else if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05_YN)
                            cellst_02.BackColor = Color.FromArgb(255, 255, 205);

                        cellrg.Style = fgrid_main.Styles["COMBO_FI_02"];
                        #endregion
                    }

                    #region Mail Send
                    string mail_addr = COM.ComVar.This_User;
                    string mail_subject = "File Upload";
                    bool isExecuting = false;

                    Process[] processes = Process.GetProcesses();
                    foreach (Process proc in processes)
                    {
                        if (proc.ProcessName.Equals("OUTLOOK"))
                        {
                            isExecuting = true;
                            break;
                        }
                    }

                    if (!isExecuting)
                        Process.Start("OUTLOOK.EXE");

                    outlook = new Outlook.Application();
                    mailitem = (Outlook.MailItem)outlook.CreateItem(Outlook.OlItemType.olMailItem);
                    mailitem.Recipients.Add(mail_addr + "@dskorea.com");
                    mailitem.Subject = mail_subject;
                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        mailitem.Attachments.Add(openDlg.FileNames[i], Outlook.OlAttachmentType.olByValue, 1, openDlg.FileNames[i]);
                    }

                    mailitem.Display(null);
                    #endregion

                    mnu_open_file.Enabled = true;
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

        private DataTable GET_SCH_FILE_CD()
        {
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.GET_SXC_SCH_FILE_CD";

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private bool SAVE_SCH_HEAD_FILE(string[] arg_value)
        {
            try
            {
                bool ret = false;

                MyOraDB.ReDim_Parameter(10);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_SXC_SCH_HEAD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[5] = "ARG_NF_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_TK_CD";
                MyOraDB.Parameter_Name[7] = "ARG_FILE_CD";
                MyOraDB.Parameter_Name[8] = "ARG_FILE_NAME";                
                MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";               

                //03.DATA TYPE 정의                
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

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];
                MyOraDB.Parameter_Values[9] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "File Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private byte[] GetFile(string arg_filename)
        {
            FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] file = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return file;
        }
        
        private void mnu_open_file_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                string[] arg_value = new string[7];
                arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxSRF_NO].ToString().Trim();
                arg_value[3] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxBOM_ID].ToString().Trim();
                arg_value[4] = Get_NF_CD(sct_col);
                arg_value[5] = Get_NF_SEQ(sct_col);
                arg_value[6] = Get_TASK_CD(sct_row, sct_col);

                Pop_Sch_Management_File pop = new Pop_Sch_Management_File(arg_value);
                pop.ShowDialog();                
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
        
        private DataTable SELECT_SCH_HEAD_FILE(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(7);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_HEAD_FILE";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
            MyOraDB.Parameter_Name[5] = "ARG_NF_SEQ";            
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private string Get_NF_CD(int arg_col)
        {
            string nf_code = "";

            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01] = "010";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02] = "010";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03] = "010";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04] = "010";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05] = "010";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01] = "020";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02] = "020";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03] = "020";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04] = "020";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05] = "020";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01] = "030";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02] = "030";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03] = "030";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04] = "030";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05] = "030";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01] = "040";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02] = "040";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03] = "040";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04] = "040";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05] = "040";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01] = "050";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01] = "060";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01] = "070";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01] = "080";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01] = "090";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01] = "100";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01] = "110";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01] = "120";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01] = "130";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01] = "140";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01] = "150";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01] = "160";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01] = "170";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01] = "180";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01] = "190";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01] = "200";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01] = "210";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01] = "220";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01] = "230";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01] = "240";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02] = "240";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03] = "240";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04] = "240";
            nf_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05] = "240";

            nf_code = nf_cd[arg_col];
            return nf_code;
        }

        private string Get_NF_SEQ(int arg_col)
        {
            string nfseq = "";

            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02] = "002";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03] = "003";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04] = "004";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05] = "005";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02] = "002";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03] = "003";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04] = "004";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05] = "005";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02] = "002";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03] = "003";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04] = "004";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05] = "005";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02] = "002";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03] = "003";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04] = "004";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05] = "005";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01] = "001";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02] = "002";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03] = "003";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04] = "004";
            nf_seq[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05] = "005";

            nfseq = nf_seq[arg_col];
            return nfseq;
        }

        private string Get_TASK_CD(int arg_row, int arg_col)
        {
            string _lev    = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxLEV].ToString().Trim();
            string _nf_seq = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxNF_SEQ].ToString().Trim();

            string task_cd = "";

            if (_lev.Equals("1"))
            {
                task_cd = (fgrid_main[arg_row, arg_col] == null) ? "" : fgrid_main[arg_row, arg_col].ToString().Trim();
            }
            else if (_lev.Equals("2") && _nf_seq.Equals(""))
            {
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T01] = "510";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T02] = "520";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T03] = "530";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T04] = "540";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN010_T05] = "550";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T01] = "510";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T02] = "520";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T03] = "530";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T04] = "540";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN020_T05] = "550";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T01] = "510";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T02] = "520";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T03] = "530";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T04] = "540";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN030_T05] = "550";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T01] = "510";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T02] = "520";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T03] = "530";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T04] = "540";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN040_T05] = "550";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN050_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN060_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN070_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN080_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN090_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN100_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN110_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN120_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN130_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN140_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN150_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN160_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN170_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN180_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN190_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN200_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN210_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN220_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN230_T01] = "";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T01] = "510";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T02] = "520";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T03] = "530";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T04] = "540";
                tk_cd[(int)ClassLib.TBSXC_SCH_MANAGEMENT_01.IxN240_T05] = "550";

                task_cd = tk_cd[arg_col];
            }

            return task_cd;
        }
        #endregion        

        #endregion        

        #region SQL Server 관련
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

        private string insert_query()
        {
            string insert_query = "INSERT INTO SXC_SCH_FILE (FACTORY, FILE_CD, RAW_FILE) VALUES (@FACTORY, @FILE_CD, @RAW_FILE)";

            return insert_query;
        }

        private bool INSERT_FILE(string [] arg_value, string file_name)
        {
            try
            {
                byte[] file = null;
                file = GetFile(file_name);

                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(insert_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_value[0]);
                com.Parameters.AddWithValue("@FILE_CD", arg_value[7]);
                com.Parameters.AddWithValue("@RAW_FILE", file);

                com.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch
            {
                return false; 
            }
        }        
        #endregion

    }
}


