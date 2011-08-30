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
using System.Runtime.InteropServices;

namespace FlexCDC.Plan
{
    public partial class Form_Sch_Management_02 : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private bool[] group_view  = new bool[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMAX_CNT];
        private string[] nf_cd    = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMAX_CNT];
        private string[] nf_seq   = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMAX_CNT];
        private string[] tk_cd    = new string[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMAX_CNT];
        //private bool column_view  = true;
        private Outlook.Application outlook = null;
        private Outlook.MailItem mailitem = null;

        //private bool round_view = false;
        private bool grid_size = false;
        private bool setting_flg = false;
        private bool chk_flg = false;

        private int copy_row;
        private int select_row;

        private string _main_form = "";
        #endregion

        #region Resource
        public Form_Sch_Management_02()
        {
            InitializeComponent();
        }
        public Form_Sch_Management_02(string arg_form)
        {
            InitializeComponent();

            _main_form = arg_form;
        }
        #endregion

        #region Form Loading
        private void Form_Sch_Management_02_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Schedule Management (PMS)";
            this.lbl_MainTitle.Text = "PCC_Schedule Management (PMS)";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedValue = COM.ComVar.This_CDC_Factory;
            cmb_factory.Enabled = true;
           
            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_season_from.SelectedValue = "201004";
            cmb_season_to.SelectedValue = "201102";

            //dt_ret = SELECT_SEASON_DEFAULT();

            //if (dt_ret.Rows.Count > 0)
            //{
            //    string default_season = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
            //    cmb_season_from.SelectedValue = default_season;
            //    cmb_season_to.SelectedValue = default_season;

            //    cmb_season_from.SelectedIndex = cmb_season_from.SelectedIndex + 2;
            //    cmb_season_to.SelectedIndex = cmb_season_to.SelectedIndex - 3;
            //}
            //else
            //{
            //    cmb_season_from.SelectedValue = "201001";
            //    cmb_season_to.SelectedValue = "201001";
            //}

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
            else if (_power_lev.Equals("D00"))
            {
                dt_ret = SELECT_USER();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                cmb_user.SelectedValue = ClassLib.ComVar.This_User;

                if (cmb_user.SelectedIndex < 0)
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


            string[] arg_value = new string[3];
            arg_value[0] = "";
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

            if (_main_form.Equals("WORKSHEET"))
            {
                if (!Sch_Grouping_Check())
                {
                    this.Close();
                    return;
                }
            }

            #region Grid Setting

            #region  Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_MAIN", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;
            fgrid_main.Tree.Column = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME;
            fgrid_main.KeyActionEnter = KeyActionEnum.None;
                       
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01_P).StyleNew.ForeColor = Color.Black;
            Font grid_font = new Font("굴림", 11, FontStyle.Bold, GraphicsUnit.Pixel);

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01_P).StyleNew.Font = grid_font;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01_P).StyleNew.Font = grid_font;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01_P).StyleNew.Font = grid_font;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01_P).StyleNew.Font = grid_font;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P).StyleNew.Font = grid_font;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P).StyleNew.BackColor = Color.FromArgb(255, 255, 101);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.ForeColor = Color.Black;
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
                {
                    fgrid_file.Cols[i].AllowMerging = true;
                }
                else
                {
                    fgrid_file.Cols[i].AllowMerging = false;
                }
            }
            #endregion

            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
                        
            txt_model.CharacterCasing = CharacterCasing.Upper;
            txt_bom_id.CharacterCasing = CharacterCasing.Upper;
            txt_search.CharacterCasing = CharacterCasing.Upper;

            chk_dev_check.Checked = true;            
            #endregion 

            if (_main_form.Equals("WORKSHEET"))
            {
                if (COM.ComVar.This_CDCPower_Level.Substring(0, 1).Equals("D"))
                {
                    //ControlBox_Setting();
                    tbtn_Search_Click(null, null);
                }                
            }
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

        private DataTable SELECT_ROUND(string [] arg_value)
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
                    Display_Detail_Data();
                    fgrid_detail.Tree.Show(1); 
                }
                else if (tabControl1.SelectedIndex.Equals(1) && chk_all_file.Checked)
                {
                    Display_File_Data();
                }
                else
                {
                    bool target_chk = chk_target.Checked;
                    bool adj_chk    = chk_adjust.Checked;
                    bool detail_chk = chk_detail.Checked;
                    bool drop_chk   = chk_drop.Checked;

                    string[] arg_value = new string[10];

                    arg_value[0] = cmb_factory.SelectedValue.ToString();                    
                    arg_value[1] = cmb_season_from.SelectedValue.ToString();
                    arg_value[2] = cmb_season_to.SelectedValue.ToString();
                    arg_value[3] = cmb_category.SelectedValue.ToString();
                    arg_value[4] = txt_model.Text.Trim();
                    arg_value[5] = cmb_user.SelectedValue.ToString();
                    arg_value[6] = (target_chk) ? "Y" : "N";
                    arg_value[7] = (adj_chk) ? "Y" : "N";
                    arg_value[8] = (detail_chk) ? "Y" : "N";
                    arg_value[9] = (drop_chk) ? "Y" : "N";

                    DataTable dt_ret = SELECT_SCH_MANAGEMENT(arg_value);

                    if (!target_chk && !adj_chk && !detail_chk)
                        Display_Main_Data_1Level(dt_ret);
                    else
                        Display_Main_Data_2Level(dt_ret);

                    if (dt_ret.Rows.Count > 0)
                    {
                        fgrid_main.Select(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME);
                        select_row = fgrid_main.Rows.Fixed;

                        fgrid_main.Tree.Show(1);

                        if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                            return;

                        string[] arg_detail_value = new string[3];
                        arg_detail_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                        arg_detail_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                        arg_detail_value[2] = (fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim().Substring(0, 1).Equals("X")) ? "" : fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

                        dt_ret = SELECT_ROUND(arg_detail_value);
                        ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                        cmb_round.SelectedIndex = 0;

                        Display_Detail_Data();
                        fgrid_detail.Tree.Show(1);
                    }
                }

            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Display_Main_Data_1Level(DataTable arg_dt)
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {                    
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString().Trim();                    
                }                
            }

            Main_Grid_Style_Setting();

            if (arg_dt.Rows.Count > 0)
            {
                Display_Detail_Data();
                fgrid_detail.Tree.Show(1);
            }

        }

        private void Display_Main_Data_2Level(DataTable arg_dt)
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                int vTreeLevel = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString());
                string rep_yn = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();
                
                fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, vTreeLevel);
                
                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString().Trim();
                }                
            }

            Main_Grid_Style_Setting();
                        
            if (arg_dt.Rows.Count > 0)
            {
                Display_Detail_Data();
                fgrid_detail.Tree.Show(1);
            }
            
        }

        private void Main_Grid_Style_Setting()
        {
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD; j++)
                {
                    bool style_set = Style_Setting_YN(j);

                    if (style_set)
                    {
                        string progress = fgrid_main[i, j + 1].ToString().Trim();
                        string level  = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();
                        string status = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();

                        if (status.Equals("D"))
                        {
                            if (level.Equals("1"))
                            {
                                #region 1 Level
                                if (progress.Equals("C")) //Complete
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + i.ToString() + "c" + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Aqua;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + "r" + i.ToString() + "c" + j.ToString()];
                                }
                                else if (progress.Equals("Y")) //Progress
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + i.ToString() + "c" + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Red;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + "r" + i.ToString() + "c" + j.ToString()];
                                }
                                else
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.LightGray;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                #endregion
                            }
                            else
                            {
                                #region 2 Level
                                if (progress.Equals("C")) //Complete
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + i.ToString() + "c" + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Aqua;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + "r" + i.ToString() + "c" + j.ToString()];
                                }
                                else if (progress.Equals("Y")) //Progress
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + i.ToString() + "c" + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Red;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + "r" + i.ToString() + "c" + j.ToString()];
                                }
                                else
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.LightGray;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                #endregion
                            }                            

                            fgrid_main.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY, i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD).StyleNew.BackColor = Color.LightGray;
                            fgrid_main.Rows[i].AllowEditing = false;
                        }
                        else if (status.Equals("N"))
                        {
                            if (level.Equals("1"))
                            {
                                #region 1 Level
                                if (progress.Equals("")) //Null
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.LightGray;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;

                                    if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                        cellst.BackColor = Color.MintCream;
                                    else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                        cellst.BackColor = Color.Snow;
                                    else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                        cellst.BackColor = Color.FromArgb(255, 255, 205);

                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                #endregion
                            }
                            else
                            {
                                #region 2 Level
                                if (progress.Equals("")) //Null
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.LightGray;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;

                                    if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                        cellst.BackColor = Color.White;
                                    else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                        cellst.BackColor = Color.White;
                                    else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                        cellst.BackColor = Color.White;

                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            if (level.Equals("1"))
                            {
                                #region 1 Level
                                if (progress.Equals("C")) //Completed
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Aqua;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else if (progress.Equals("Y")) //Progress
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Red;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else if (progress.Equals("N")) //Scheduled
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Yellow;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else if (progress.Equals("")) //Null
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.LightGray;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }                                
                                #endregion
                            }
                            else
                            {
                                #region 2 Level
                                if (progress.Equals("C")) //Completed
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Aqua;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else if (progress.Equals("Y")) //Progress
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Red;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else if (progress.Equals("N")) //Scheduled
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.Yellow;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else if (progress.Equals("")) //Null
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                                    cellst.BackColor = Color.LightGray;
                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                else
                                {
                                    CellRange cellrg = fgrid_main.GetCellRange(i, j);
                                    CellStyle cellst = fgrid_main.Styles.Add("DT_" + i.ToString() + j.ToString());
                                    cellst.DataType = typeof(DateTime);
                                    cellst.Format = "yyyyMMdd";
                                    cellst.TextAlign = TextAlignEnum.CenterCenter;

                                    if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                        cellst.BackColor = Color.White;
                                    else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                        cellst.BackColor = Color.White;
                                    else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                        cellst.BackColor = Color.White;

                                    cellst.ForeColor = Color.Black;
                                    cellrg.Style = fgrid_main.Styles["DT_" + i.ToString() + j.ToString()];
                                }
                                #endregion
                            }
                        }
                    }
                }

                string rep_yn = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();
                
                if (rep_yn.Equals("Y"))
                    fgrid_main.GetCellRange(i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;                
            }

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
        }

        private bool Style_Setting_YN(int arg_col)
        {
            bool[] style_yn = new bool[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMAX_CNT];

            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01_P ] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01   ] = true;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P ] = false;            
            
            return style_yn[arg_col];
        }

        private DataTable SELECT_SCH_MANAGEMENT(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_SCH_MANAGEMENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";                
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";                
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_TARGET_CHK";
                MyOraDB.Parameter_Name[7] = "ARG_ADJ_CHK";
                MyOraDB.Parameter_Name[8] = "ARG_DETAIL_CHK";
                MyOraDB.Parameter_Name[9] = "ARG_DROP_CHK";
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
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (SAVE_DATA())
                {
                    for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                    {
                        string div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV].ToString().Trim();

                        if (div.Equals("U"))
                        {
                            fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "Y";

                            Main_Grid_Style_Setting_Row(i);
                        }
                    }
                    
                    fgrid_main.ClearFlags();
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private bool SAVE_DATA()
        {
            try
            {
                int vcnt = 113;

                MyOraDB.ReDim_Parameter(vcnt);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_SXC_SCH_MANAGEMENT_MAIN";


                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_ITEM_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_N010_T01";
                MyOraDB.Parameter_Name[5] = "ARG_N010_T02";
                MyOraDB.Parameter_Name[6] = "ARG_N010_T03";
                MyOraDB.Parameter_Name[7] = "ARG_N010_T04";
                MyOraDB.Parameter_Name[8] = "ARG_N010_T05";
                MyOraDB.Parameter_Name[9] = "ARG_N020_T01";
                MyOraDB.Parameter_Name[10] = "ARG_N020_T02";
                MyOraDB.Parameter_Name[11] = "ARG_N020_T03";
                MyOraDB.Parameter_Name[12] = "ARG_N020_T04";
                MyOraDB.Parameter_Name[13] = "ARG_N020_T05";
                MyOraDB.Parameter_Name[14] = "ARG_N030_T01";
                MyOraDB.Parameter_Name[15] = "ARG_N040_T01";
                MyOraDB.Parameter_Name[16] = "ARG_N040_T02";
                MyOraDB.Parameter_Name[17] = "ARG_N040_T03";
                MyOraDB.Parameter_Name[18] = "ARG_N040_T04";
                MyOraDB.Parameter_Name[19] = "ARG_N040_T05";
                MyOraDB.Parameter_Name[20] = "ARG_N050_T01";
                MyOraDB.Parameter_Name[21] = "ARG_N050_T02";
                MyOraDB.Parameter_Name[22] = "ARG_N050_T03";
                MyOraDB.Parameter_Name[23] = "ARG_N050_T04";
                MyOraDB.Parameter_Name[24] = "ARG_N050_T05";
                MyOraDB.Parameter_Name[25] = "ARG_N060_T01";
                MyOraDB.Parameter_Name[26] = "ARG_N070_T01";
                MyOraDB.Parameter_Name[27] = "ARG_N070_T02";
                MyOraDB.Parameter_Name[28] = "ARG_N070_T03";
                MyOraDB.Parameter_Name[29] = "ARG_N070_T04";
                MyOraDB.Parameter_Name[30] = "ARG_N070_T05";
                MyOraDB.Parameter_Name[31] = "ARG_N080_T01";
                MyOraDB.Parameter_Name[32] = "ARG_N080_T02";
                MyOraDB.Parameter_Name[33] = "ARG_N080_T03";
                MyOraDB.Parameter_Name[34] = "ARG_N080_T04";
                MyOraDB.Parameter_Name[35] = "ARG_N080_T05";
                MyOraDB.Parameter_Name[36] = "ARG_N090_T01";
                MyOraDB.Parameter_Name[37] = "ARG_N100_T01";
                MyOraDB.Parameter_Name[38] = "ARG_N110_T01";
                MyOraDB.Parameter_Name[39] = "ARG_N120_T01";
                MyOraDB.Parameter_Name[40] = "ARG_N130_T01";
                MyOraDB.Parameter_Name[41] = "ARG_N140_T01";
                MyOraDB.Parameter_Name[42] = "ARG_N150_T01";
                MyOraDB.Parameter_Name[43] = "ARG_N160_T01";
                MyOraDB.Parameter_Name[44] = "ARG_N170_T01";
                MyOraDB.Parameter_Name[45] = "ARG_N180_T01";
                MyOraDB.Parameter_Name[46] = "ARG_N190_T01";
                MyOraDB.Parameter_Name[47] = "ARG_N200_T01";
                MyOraDB.Parameter_Name[48] = "ARG_N210_T01";
                MyOraDB.Parameter_Name[49] = "ARG_N220_T01";
                MyOraDB.Parameter_Name[50] = "ARG_N230_T01";
                MyOraDB.Parameter_Name[51] = "ARG_N240_T01";
                MyOraDB.Parameter_Name[52] = "ARG_N250_T01";
                MyOraDB.Parameter_Name[53] = "ARG_N260_T01";
                MyOraDB.Parameter_Name[54] = "ARG_N270_T01";
                MyOraDB.Parameter_Name[55] = "ARG_N280_T01";
                MyOraDB.Parameter_Name[56] = "ARG_N290_T01";
                MyOraDB.Parameter_Name[57] = "ARG_N300_T01";
                MyOraDB.Parameter_Name[58] = "ARG_N010_T01_P";
                MyOraDB.Parameter_Name[59] = "ARG_N010_T02_P";
                MyOraDB.Parameter_Name[60] = "ARG_N010_T03_P";
                MyOraDB.Parameter_Name[61] = "ARG_N010_T04_P";
                MyOraDB.Parameter_Name[62] = "ARG_N010_T05_P";
                MyOraDB.Parameter_Name[63] = "ARG_N020_T01_P";
                MyOraDB.Parameter_Name[64] = "ARG_N020_T02_P";
                MyOraDB.Parameter_Name[65] = "ARG_N020_T03_P";
                MyOraDB.Parameter_Name[66] = "ARG_N020_T04_P";
                MyOraDB.Parameter_Name[67] = "ARG_N020_T05_P";
                MyOraDB.Parameter_Name[68] = "ARG_N030_T01_P";
                MyOraDB.Parameter_Name[69] = "ARG_N040_T01_P";
                MyOraDB.Parameter_Name[70] = "ARG_N040_T02_P";
                MyOraDB.Parameter_Name[71] = "ARG_N040_T03_P";
                MyOraDB.Parameter_Name[72] = "ARG_N040_T04_P";
                MyOraDB.Parameter_Name[73] = "ARG_N040_T05_P";
                MyOraDB.Parameter_Name[74] = "ARG_N050_T01_P";
                MyOraDB.Parameter_Name[75] = "ARG_N050_T02_P";
                MyOraDB.Parameter_Name[76] = "ARG_N050_T03_P";
                MyOraDB.Parameter_Name[77] = "ARG_N050_T04_P";
                MyOraDB.Parameter_Name[78] = "ARG_N050_T05_P";
                MyOraDB.Parameter_Name[79] = "ARG_N060_T01_P";
                MyOraDB.Parameter_Name[80] = "ARG_N070_T01_P";
                MyOraDB.Parameter_Name[81] = "ARG_N070_T02_P";
                MyOraDB.Parameter_Name[82] = "ARG_N070_T03_P";
                MyOraDB.Parameter_Name[83] = "ARG_N070_T04_P";
                MyOraDB.Parameter_Name[84] = "ARG_N070_T05_P";
                MyOraDB.Parameter_Name[85] = "ARG_N080_T01_P";
                MyOraDB.Parameter_Name[86] = "ARG_N080_T02_P";
                MyOraDB.Parameter_Name[87] = "ARG_N080_T03_P";
                MyOraDB.Parameter_Name[88] = "ARG_N080_T04_P";
                MyOraDB.Parameter_Name[89] = "ARG_N080_T05_P";
                MyOraDB.Parameter_Name[90] = "ARG_N090_T01_P";
                MyOraDB.Parameter_Name[91] = "ARG_N100_T01_P";
                MyOraDB.Parameter_Name[92] = "ARG_N110_T01_P";
                MyOraDB.Parameter_Name[93] = "ARG_N120_T01_P";
                MyOraDB.Parameter_Name[94] = "ARG_N130_T01_P";
                MyOraDB.Parameter_Name[95] = "ARG_N140_T01_P";
                MyOraDB.Parameter_Name[96] = "ARG_N150_T01_P";
                MyOraDB.Parameter_Name[97] = "ARG_N160_T01_P";
                MyOraDB.Parameter_Name[98] = "ARG_N170_T01_P";
                MyOraDB.Parameter_Name[99] = "ARG_N180_T01_P";
                MyOraDB.Parameter_Name[100] = "ARG_N190_T01_P";
                MyOraDB.Parameter_Name[101] = "ARG_N200_T01_P";
                MyOraDB.Parameter_Name[102] = "ARG_N210_T01_P";
                MyOraDB.Parameter_Name[103] = "ARG_N220_T01_P";
                MyOraDB.Parameter_Name[104] = "ARG_N230_T01_P";
                MyOraDB.Parameter_Name[105] = "ARG_N240_T01_P";
                MyOraDB.Parameter_Name[106] = "ARG_N250_T01_P";
                MyOraDB.Parameter_Name[107] = "ARG_N260_T01_P";
                MyOraDB.Parameter_Name[108] = "ARG_N270_T01_P";
                MyOraDB.Parameter_Name[109] = "ARG_N280_T01_P";
                MyOraDB.Parameter_Name[110] = "ARG_N290_T01_P";
                MyOraDB.Parameter_Name[111] = "ARG_N300_T01_P";
                MyOraDB.Parameter_Name[112] = "ARG_UPD_USER";

                for (int para = 0; para < vcnt; para++)
                {
                    MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
                }

                int vRow = 0;
                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    string _div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV].ToString().Trim();

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
                    string _div = fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV].ToString().Trim();

                    if (_div.Equals(""))
                        continue;

                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_SEQ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_SEQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01);
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01);
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (GET_GRID_DATA_CHANGE(fgrid_main, row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01).Equals("")) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
                }

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private string GET_GRID_DATA_CHANGE(C1FlexGrid arg_grid, int arg_row, int arg_col)
        {
            string value = "";

            try
            {
                value = Convert.ToDateTime(arg_grid[arg_row, arg_col].ToString().Trim()).ToString("yyyyMMdd");
            }
            catch
            {
                value = (arg_grid[arg_row, arg_col] == null) ? "" : arg_grid[arg_row, arg_col].ToString().Trim();
            }

            return value;
        }
        
        #endregion

        #region Grid Event

        #region Main Grid Event
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
                            pnl_detail.Height = 500;
                            grid_size = true;
                        }
                    }
                }
                else
                {
                    if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                        return;

                    MainGrid_Click_Setting();
                }

            }
            catch
            {

            }
            finally
            {
                
            }
        }
        private void fgrid_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_col = fgrid_main.Selection.c1;

                if (sct_col < (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 || sct_col > (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                {
                    if (tabControl1.SelectedIndex.Equals(0))
                    {
                        string[] arg_value = new string[3];
                        arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = (fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim().Substring(0, 1).Equals("X")) ? "" : fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

                        setting_flg = true;
                        DataTable dt_ret = SELECT_ROUND(arg_value);
                        ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                        cmb_round.SelectedIndex = 0;
                        setting_flg = false;

                        txt_bom_id.Text = "";

                        Display_Detail_Data();
                        fgrid_detail.Tree.Show(1);
                    }
                    else
                    {
                        Display_File_Data();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }

        }
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_main.Selections;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_main[sct_rows[i], sct_col] = fgrid_main[sct_row, sct_col];
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";

                    string value = (fgrid_main[sct_rows[i], sct_col].Equals(null)) ? "" : fgrid_main[sct_rows[i], sct_col].ToString().Trim();
                    string progress = (fgrid_main[sct_rows[i], sct_col + 1].Equals(null)) ? "" : fgrid_main[sct_rows[i], sct_col + 1].ToString().Trim();

                    if (value.Equals(""))
                    {
                        fgrid_main[sct_rows[i], sct_col + 1] = "";
                        mnu_progress.Enabled = false;
                        mnu_clear_data.Enabled = false;
                    }
                    else
                    {
                        if (progress.Equals(""))
                        {
                            fgrid_main[sct_rows[i], sct_col + 1] = "N"; 
                        }

                        mnu_progress.Enabled = true;
                        mnu_clear_data.Enabled = true;
                    }
                }

            }
            catch
            {

            }
        }
        private void fgrid_main_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                if (Style_Setting_YN(sct_col))
                {
                    string cell_value = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();

                    if (cell_value.Equals(""))
                    {
                        //fgrid_main.Buffer_CellData = DateTime.Now.ToString();
                    }
                    else
                    {
                        try
                        {
                            if (cell_value.Length > 8)
                            {
                                fgrid_main.Buffer_CellData = cell_value;
                            }
                            else
                            {
                                int year = int.Parse(cell_value.Substring(0, 4));
                                int month = int.Parse(cell_value.Substring(4, 2));
                                int day = int.Parse(cell_value.Substring(6, 2));

                                DateTime dt = new DateTime(year, month, day);

                                fgrid_main.Buffer_CellData = dt.ToString();
                            }
                        }
                        catch
                        {
                            fgrid_main.Buffer_CellData = DateTime.Now.ToString();
                        }

                        fgrid_main[fgrid_main.Row, fgrid_main.Col] = fgrid_main.Buffer_CellData.ToString();
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

        private void MainGrid_Click_Setting()
        {
            int sct_row = fgrid_main.Selection.r1;
            int sct_col = fgrid_main.Selection.c1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            select_row = sct_row;

            string level  = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();
            string rep_yn = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();
            string status = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();

            if (!status.Equals("D"))
            {                
                mnu_cancel_drop.Enabled = false;

                mnu_clear_data.Enabled = true;
                mnu_ipw_record.Enabled = true;

                if (level.Equals("1"))
                {
                    if (rep_yn.Equals("Y"))
                    {
                        mnu_drop_record.Enabled = true;
                        mnu_check_pt.Enabled = true;
                        mnu_upload_subfile.Enabled = true;
                        mnu_douwload_subfile.Enabled = true;

                        mnu_model_info.Visible = true;
                        mnu_model_info.Enabled = true;
                        mnu_cat_td.Visible = false;
                    }
                    else
                    {
                        mnu_drop_record.Enabled = false;
                        mnu_check_pt.Enabled = false;
                        mnu_upload_subfile.Enabled = false;
                        mnu_douwload_subfile.Enabled = false;

                        mnu_model_info.Visible = false;
                        mnu_cat_td.Visible = true;
                    }

                    mnu_print_pt.Enabled = true;                    
                }
                else
                {
                    mnu_cancel_drop.Enabled = false;
                    mnu_drop_record.Enabled = true;
                    mnu_check_pt.Enabled = false;
                    mnu_print_pt.Enabled = false;
                    mnu_upload_subfile.Enabled = false;
                    mnu_douwload_subfile.Enabled = false;

                    mnu_model_info.Visible = false;
                    mnu_cat_td.Visible = true;
                }
            }
            else
            {
                mnu_drop_record.Enabled = false;
                mnu_cancel_drop.Enabled = true;

                mnu_clear_data.Enabled = false;
                mnu_ipw_record.Enabled = false;

                mnu_check_pt.Enabled = false;
                mnu_print_pt.Enabled = false;
                mnu_upload_subfile.Enabled = false;
                mnu_douwload_subfile.Enabled = false;

                mnu_model_info.Enabled = false;
                mnu_model_info.Visible = true;
                mnu_cat_td.Visible = false;
            }

            if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
            {
                string value = (fgrid_main[sct_row, sct_col].Equals(null)) ? "" : fgrid_main[sct_row, sct_col].ToString().Trim();

                if (value.Equals(""))
                {
                    mnu_progress.Enabled = false;
                    mnu_clear_data.Enabled = false;
                }
                else
                {
                    mnu_progress.Enabled = true;
                    mnu_clear_data.Enabled = true; 
                }                
            }
            else
            {
                mnu_progress.Enabled = false;
                mnu_clear_data.Enabled = false;
            }
            
        }
        
        #region Detail Grid Setting
        private void Display_Detail_Data()
        {
            fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;

            int sct_row = fgrid_main.Selection.r1;
            int sct_col = fgrid_main.Selection.c1;

            DataTable dt_ret = null;

            if (!chk_all_search.Checked)
            {
                string[] arg_value = new string[7];
                arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
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

            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_YN]   = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM]      = true;            
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_P]    = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD]    = true;            
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD_P]  = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC_YN]   = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC]      = true;            
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC_P]    = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK_YN] = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK]    = true;            
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK_P]  = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM_YN]   = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM]      = true;            
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM_P]    = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_YN]    = false;
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP]       = true;            
            style_yn[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_P]     = false;

            return style_yn[arg_col];
        }
        #endregion

        #region File Grid Setting
        private void Display_File_Data()
        {
            fgrid_file.Rows.Count = fgrid_file.Rows.Fixed;
                        
            DataTable dt_ret = null;

            if (!chk_all_file.Checked)
            {
                string[] arg_value = new string[5];

                arg_value[0] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = (fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim().Substring(0, 1).Equals("X")) ? "" : fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
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
            try
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
                            pnl_detail.Height = 400;
                            grid_size = true;
                        }
                    }
                }
                else
                {
                    DetailGrid_Click_Setting();
                }
            }
            catch
            {
 
            }
        }
        private void fgrid_detail_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;
                int[] sct_rows = fgrid_detail.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_detail[sct_rows[i], sct_col] = fgrid_detail[sct_row, sct_col];
                    SAVE_DETAIL_DATA(sct_rows[i]); 
                }
                
            }
            catch
            {
 
            }
        }
        private void fgrid_detail_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                if (Style_Setting_YN_Detail(sct_col))
                {
                    string cell_value = (fgrid_detail[fgrid_detail.Row, fgrid_detail.Col] == null) ? "" : fgrid_detail[fgrid_detail.Row, fgrid_detail.Col].ToString();

                    if (cell_value.Equals(""))
                    {
                        
                    }
                    else
                    {
                        try
                        {
                            if (cell_value.Length > 8)
                            {
                                fgrid_detail.Buffer_CellData = cell_value;
                            }
                            else
                            {
                                int year = int.Parse(cell_value.Substring(0, 4));
                                int month = int.Parse(cell_value.Substring(4, 2));
                                int day = int.Parse(cell_value.Substring(6, 2));

                                DateTime dt = new DateTime(year, month, day);

                                fgrid_detail.Buffer_CellData = dt.ToString();
                            }
                        }
                        catch
                        {
                            fgrid_detail.Buffer_CellData = DateTime.Now.ToString();
                        }

                        fgrid_detail[fgrid_detail.Row, fgrid_detail.Col] = fgrid_detail.Buffer_CellData.ToString();
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

        private void DetailGrid_Click_Setting()
        {
            int sct_row = fgrid_detail.Selection.r1;
            int sct_col = fgrid_detail.Selection.c1;

            string status = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSTATUS].ToString().Trim();

            if (status.Equals("D"))
            {
                mnu_rep_detail.Enabled = false;
                mnu_rep_cancel_detail.Enabled = false;
                mnu_openfile_02.Enabled = false;
                mnu_upload.Enabled = false;
                mnu_upload_email.Enabled = false;
            }
            else
            {
                mnu_rep_detail.Enabled = true;
                mnu_rep_cancel_detail.Enabled = true;
                mnu_openfile_02.Enabled = true;
                mnu_upload.Enabled = true;
                mnu_upload_email.Enabled = true;
            }

            if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM_YN && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP)
            {
                if (sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC)
                {
                    mnu_upload.Enabled = true;
                    mnu_upload_email.Enabled = true;
                    mnu_open.Enabled = true;
                }
                else if (sct_col == (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP || sct_col == (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP_YN)
                {
                    mnu_upload.Enabled = true;
                    mnu_upload_email.Enabled = true;
                    mnu_open.Enabled = true;
                }
                else
                {
                    mnu_upload.Enabled = false;
                    mnu_upload_email.Enabled = false;
                    mnu_open.Enabled = false;
                }

                mnu_clear_detaildata.Enabled = true;
                mnu_progress_detail.Enabled = true;
            }
            else
            {
                mnu_upload.Enabled = false;
                mnu_upload_email.Enabled = false;
                mnu_open.Enabled = false;
                mnu_clear_detaildata.Enabled = false;
                mnu_progress_detail.Enabled = false;
            }
        }

        private void SAVE_DETAIL_DATA(int arg_row)
        {
            int vcnt = 20;

            MyOraDB.ReDim_Parameter(vcnt);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_SXC_SCH_MANAGEMENT_DETAIL";

            MyOraDB.Parameter_Name[0 ] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1 ] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2 ] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3 ] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4 ] = "ARG_NF_CD";
            MyOraDB.Parameter_Name[5 ] = "ARG_ITEM_SEQ";
            MyOraDB.Parameter_Name[6 ] = "ARG_SHOE_VER";
            MyOraDB.Parameter_Name[7 ] = "ARG_T01";
            MyOraDB.Parameter_Name[8 ] = "ARG_T02";
            MyOraDB.Parameter_Name[9 ] = "ARG_T03";
            MyOraDB.Parameter_Name[10] = "ARG_T04";
            MyOraDB.Parameter_Name[11] = "ARG_T05";
            MyOraDB.Parameter_Name[12] = "ARG_T06";
            MyOraDB.Parameter_Name[13] = "ARG_T01_P";
            MyOraDB.Parameter_Name[14] = "ARG_T02_P";
            MyOraDB.Parameter_Name[15] = "ARG_T03_P";
            MyOraDB.Parameter_Name[16] = "ARG_T04_P";
            MyOraDB.Parameter_Name[17] = "ARG_T05_P";
            MyOraDB.Parameter_Name[18] = "ARG_T06_P";
            MyOraDB.Parameter_Name[19] = "ARG_UPD_USER";

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            MyOraDB.Parameter_Values[0 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
            MyOraDB.Parameter_Values[1 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
            MyOraDB.Parameter_Values[2 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
            MyOraDB.Parameter_Values[3 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
            MyOraDB.Parameter_Values[4 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
            MyOraDB.Parameter_Values[5 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxITEM_SEQ] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxITEM_SEQ].ToString().Trim();
            MyOraDB.Parameter_Values[6 ] = (fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSHOE_VER] == null) ? "" : fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSHOE_VER].ToString().Trim();
            MyOraDB.Parameter_Values[7 ] = GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM);
            MyOraDB.Parameter_Values[8 ] = GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD);
            MyOraDB.Parameter_Values[9 ] = GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC);
            MyOraDB.Parameter_Values[10] = GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK);
            MyOraDB.Parameter_Values[11] = GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM);
            MyOraDB.Parameter_Values[12] = GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP);
            MyOraDB.Parameter_Values[13] = (GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM).Equals(""))? "" : "N";
            MyOraDB.Parameter_Values[14] = (GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_YIELD).Equals(""))? "" : "N";
            MyOraDB.Parameter_Values[15] = (GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_PFC).Equals(""))? "" : "N";
            MyOraDB.Parameter_Values[16] = (GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_SBOOK).Equals(""))? "" : "N";
            MyOraDB.Parameter_Values[17] = (GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_CFM).Equals(""))? "" : "N";
            MyOraDB.Parameter_Values[18] = (GET_GRID_DATA_CHANGE(fgrid_detail, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP).Equals("")) ? "" : "N";
            MyOraDB.Parameter_Values[19] = COM.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #endregion

        #region Control Event

        #region CheckBox Event

        #region Main CheckBox
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

                    GroupView_Setting();
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

                    GroupView_Setting();
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

                    GroupView_Setting();
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

                    GroupView_Setting();
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
        private void GroupView_Setting()
        {
            bool dev_chk = chk_dev_check.Checked;
            bool cfm_chk = chk_cfm_shoe.Checked;
            bool comm_chk = chk_comm.Checked;
            bool all_chk = chk_all.Checked;

            if (dev_chk)
            {
                #region 개발 점검 회의용 체크
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01] = false;  //WT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01] = false;  //GREY
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01] = false;  //PROMO
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01] = false;  //WHQ Tooling Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01] = true;   //WHQ Upper Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01] = false;  //MS Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01] = true;   //MST S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01] = true;   //Asia Tooling
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01] = true;   //MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01] = false;  //Asia Upper
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01] = true;   //MST TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01] = true;   //Offshore MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01] = false;  //EXT Mold Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01] = true;   //EXT S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01] = true;   //EXT ASS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01] = true;   //EXT TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01] = false;  //CSS Data CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01] = false;  //A Set Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01] = false;  //FSR S/T@CDC  
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01] = false;  //A Set Mold Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01] = true;   //FSR S/T@Offshore
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01] = true;   //FSR
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01] = false;  //Pre CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01] = false;  //Prod. CFM                
                #endregion
            }
            else if (cfm_chk)
            {
                #region CFM Shoe Schedule
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01] = false;  //WT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01] = false;  //GREY
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01] = false;  //PROMO
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01] = false;  //WHQ Tooling Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01] = false;  //WHQ Upper Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01] = false;  //MS Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01] = false;  //MST S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01] = false;  //Asia Tooling
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01] = false;  //MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01] = false;  //Asia Upper
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01] = false;  //MST TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01] = false;  //Offshore MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01] = false;  //EXT Mold Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01] = false;  //EXT S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01] = false;  //EXT ASS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01] = false;  //EXT TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01] = false;  //CSS Data CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01] = false;  //A Set Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01] = false;  //FSR S/T@CDC
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01] = false;  //A Set Mold Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01] = false;  //FSR S/T@Offshore
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01] = false;  //FSR
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01] = true;   //Pre CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01] = true;  //Prod. CFM
                #endregion
            }
            else if (comm_chk)
            {
                #region Commo Schedule
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01] = false;  //WT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01] = false;  //GREY
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01] = false;  //PROMO
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01] = true;   //WHQ Tooling Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01] = true;   //WHQ Upper Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01] = true;   //MS Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01] = true;   //MST S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01] = true;   //Asia Tooling
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01] = true;   //MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01] = true;   //Asia Upper
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01] = true;   //MST TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01] = true;   //Offshore MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01] = true;   //EXT Mold Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01] = true;   //EXT S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01] = true;   //EXT ASS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01] = true;   //EXT TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01] = true;   //CSS Data CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01] = true;   //A Set Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01] = true;   //FSR S/T@CDC
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01] = true;   //A Set Mold Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01] = true;   //FSR S/T@Offshore
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01] = true;   //FSR
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01] = false;  //Pre CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01] = false;  //Prod. CFM
                #endregion
            }
            else
            {
                #region All Check
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T02] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T03] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T04] = true;   //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T05] = false;  //LKS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T01] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T02] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T03] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T04] = true;   //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN020_T05] = false;  //SMM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN030_T01] = true;   //WT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T01] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T02] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T03] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T04] = true;   //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN040_T05] = false;  //RLF
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T01] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T02] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T03] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T04] = true;   //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN050_T05] = false;  //ACNT
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN060_T01] = true;   //GREY
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T01] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T02] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T03] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T04] = true;   //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN070_T05] = false;  //GTM 1st
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T01] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T02] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T03] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T04] = true;   //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN080_T05] = false;  //GTM 2nd
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01] = true;   //PROMO
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01] = true;   //WHQ Tooling Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN110_T01] = true;   //WHQ Upper Target
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN120_T01] = true;   //MS Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN130_T01] = true;   //MST S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN140_T01] = true;   //Asia Tooling
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN150_T01] = true;   //MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN160_T01] = true;   //Asia Upper
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN170_T01] = true;   //MST TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN180_T01] = true;   //Offshore MST
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN190_T01] = true;   //EXT Mold Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN200_T01] = true;   //EXT S/F
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN210_T01] = true;   //EXT ASS
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN220_T01] = true;   //EXT TP Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN230_T01] = true;   //CSS Data CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN240_T01] = true;   //A Set Part CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN250_T01] = true;   //FSR S/T@CDC
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN260_T01] = true;   //A Set Mold Shipping
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN270_T01] = true;   //FSR S/T@Offshore
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01] = true;   //FSR
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01] = true;   //Pre CFM
                group_view[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01] = true;  //Prod. CFM
                #endregion
            }

            for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01; j++)
            {
                fgrid_main.Cols[j].Visible = group_view[j];
            }
        }
        #endregion

        #region Detail CheckBox
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
                    grid_size = true;

                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = true;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = true;

                    fgrid_main.Enabled = false;                    
                    tbtn_Save.Enabled  = false;

                    cmb_factory.Enabled     = false;
                    cmb_season_from.Enabled = false;
                    cmb_season_to.Enabled   = false;
                    cmb_category.Enabled    = false;
                    cmb_user.Enabled        = false;
                                        
                    txt_model.Enabled = false;

                    chk_target.Enabled    = false;
                    chk_adjust.Enabled    = false;
                    chk_detail.Enabled    = false;
                    chk_dev_check.Enabled = false;
                    chk_comm.Enabled      = false;
                    chk_cfm_shoe.Enabled  = false;
                    chk_all.Enabled       = false;

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
                    grid_size = false;

                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = false;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = false;

                    fgrid_main.Enabled = true;
                    tbtn_Save.Enabled  = true;

                    cmb_factory.Enabled     = true;
                    cmb_season_from.Enabled = true;
                    cmb_season_to.Enabled   = true;
                    cmb_category.Enabled    = true;
                    cmb_user.Enabled        = true;
                                        
                    txt_model.Enabled = true;

                    chk_target.Enabled    = true;
                    chk_adjust.Enabled    = true;
                    chk_detail.Enabled    = true;
                    chk_dev_check.Enabled = true;
                    chk_comm.Enabled      = true;
                    chk_cfm_shoe.Enabled  = true;
                    chk_all.Enabled       = true;

                    string[] arg_detail_value = new string[3];
                    arg_detail_value[0] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                    arg_detail_value[1] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                    arg_detail_value[2] = fgrid_main[select_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

                    DataTable dt_ret = SELECT_ROUND(arg_detail_value);
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 100);
                    cmb_round.SelectedIndex = 0;

                    txt_bom_id.Text = "";

                    Display_Detail_Data();

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
                    grid_size = true;

                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = true;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = true;

                    fgrid_main.Enabled = false;
                    tbtn_Save.Enabled  = false;

                    cmb_factory.Enabled     = false;
                    cmb_season_from.Enabled = false;
                    cmb_season_to.Enabled   = false;
                    cmb_category.Enabled    = false;
                    cmb_user.Enabled        = false;
                                        
                    txt_model.Enabled = false;

                    chk_target.Enabled    = false;
                    chk_adjust.Enabled    = false;
                    chk_detail.Enabled    = false;
                    chk_dev_check.Enabled = false;
                    chk_comm.Enabled      = false;
                    chk_cfm_shoe.Enabled  = false;
                    chk_all.Enabled       = false;

                    txt_search.Text = "";

                    chk_flg = true;
                    chk_all_search.Checked = true;
                    chk_flg = false;
                }
                else
                {
                    pnl_detail.Height = 216;
                    grid_size = false;

                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL].Visible = false;
                    fgrid_file.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT_FILE.IxMODEL].Visible = false;

                    fgrid_main.Enabled = true;
                    tbtn_Save.Enabled  = true;

                    cmb_factory.Enabled     = true;
                    cmb_season_from.Enabled = true;
                    cmb_season_to.Enabled   = true;
                    cmb_category.Enabled    = true;
                    cmb_user.Enabled        = true;

                    
                    txt_model.Enabled = true;

                    chk_target.Enabled    = true;
                    chk_adjust.Enabled    = true;
                    chk_detail.Enabled    = true;
                    chk_dev_check.Enabled = true;
                    chk_comm.Enabled      = true;
                    chk_cfm_shoe.Enabled  = true;
                    chk_all.Enabled       = true;

                    txt_search.Text = "";

                    Display_File_Data();

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

                Display_Detail_Data();
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

                Display_File_Data();
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
                    Display_Detail_Data();
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
                    Display_File_Data();                    
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
                        Display_Detail_Data();                        
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
                        Display_File_Data(); 
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

        #region ContextMenu Event

        #region Main Grid 

        #region Rep Setting

        #region Event
        private void mnu_rep_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                int[] sct_rows = fgrid_main.Selections;

                if (Check_Representation(sct_rows))
                {
                    Representation_Data(sct_rows);
                    fgrid_main.Select(sct_row, sct_col);                    
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void mnu_rep_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;


                if (Check_Cancel_Representation())
                {
                    Cancel_Representation_Data();
                }


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

        #region Method

        #region Representation
        private bool Check_Representation(int[] arg_rows)
        {
            string rep_code     = "";
            string level_chk_01 = "";
            string level_chk_02 = "";
            string season_cd    = fgrid_main[arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSEASON_CD].ToString().Trim();
            string gen_cd       = fgrid_main[arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER].ToString().Trim();
            bool model_chk_02   = false;

            for (int i = 0; i < arg_rows.Length; i++)
            {
                string level         = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();
                string model_id      = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                string season_cd_row = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSEASON_CD].ToString().Trim();
                string gen_cd_row    = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER].ToString().Trim();
                string status        = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();


                //1. Drop 된 데이터가 포함되어 있을 경우 경고 후 취소.
                if (status.Equals("D"))
                {
                    MessageBox.Show("Cannot represent Drop Data.");
                    return false;
                }

                //2. 다른 Season이 포함되어 있을 경우 취소.
                if (!season_cd.Equals(season_cd_row))
                {
                    MessageBox.Show("Please select same Season.");
                    return false; 
                }

                //3. 다른 Gender가 포함되어 있을 경우 취소.
                if (!gen_cd.Equals(gen_cd_row))
                {
                    MessageBox.Show("Please select same Gender.");
                    return false;
                }

                if (level.Equals("1"))
                {
                    if (model_id.Substring(0, 1).Equals("X"))
                    {
                        if (rep_code.Equals(""))
                        {
                            rep_code = model_id;
                        }
                        else
                        {
                            //2. 선택된 데이터 중 대표로 선정된 데이터가 2개 이상일 경우 경고 후 취소.
                            MessageBox.Show("Please select only one Representation Data.");
                            return false;
                        }
                    }

                    level_chk_01 = "1";
                }
                else if (level.Equals("2"))
                {
                    string item_seq = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_SEQ].ToString().Trim();

                    if (item_seq.Equals("001") || item_seq.Equals("002") || item_seq.Equals("003"))
                    {
                        MessageBox.Show("Cannot represent this Data.");
                        return false;
                    }

                    string model_id_chk = fgrid_main[fgrid_main.Rows[arg_rows[i]].Node.GetNode(NodeTypeEnum.Parent).Row.Index, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();

                    for (int row = 0; row < arg_rows.Length; row++)
                    {
                        string level_chk = fgrid_main[arg_rows[row], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                        if (level_chk.Equals("1"))
                        {
                            string model_id_chk_02 = fgrid_main[arg_rows[row], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();

                            if (model_id_chk.Equals(model_id_chk_02))
                            {
                                model_chk_02 = true;
                            }
                        }
                    }

                    if (model_chk_02)
                    {
                        model_chk_02 = false;
                    }
                    else
                    {
                        MessageBox.Show("Please except already represented data.");
                        return false;
                    }
                }
            }

            if (level_chk_01.Equals(""))
            {
                //3. 2레벨만 선택후 대표지정 했을 경우 경고 후 취소.
                MessageBox.Show("Please select Representation Data.");
                return false;
            }
            return true;
        }
        private void Representation_Data(int[] arg_rows)
        {
            #region Get Model ID
            string rep_code = "";
            for (int i = 0; i < arg_rows.Length; i++)
            {
                string level = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();
                string model_id = fgrid_main[arg_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();

                if (level.Equals("1"))
                {
                    if (model_id.Substring(0, 1).Equals("X"))
                    {
                        if (rep_code.Equals(""))
                        {
                            rep_code = model_id;
                        }
                    }
                }
            }

            string arg_factory = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
            string arg_model_id = (rep_code.Equals("")) ? GET_NEW_MODEL_ID().Rows[0].ItemArray[0].ToString().Trim() : rep_code;
            #endregion

            if (UPDATE_MODEL_ID(arg_model_id))
            {
                if (rep_code.Equals(""))
                {
                    if (INSERT_SXC_HEAD_REP(arg_factory, arg_model_id))
                    {
                        Display_REP_Data(arg_factory, arg_model_id, "", arg_rows);
                    }
                }
                else
                {
                    Display_REP_Data(arg_factory, arg_model_id, "", arg_rows);
                }
            }


        }
        private void Display_REP_Data(string arg_factory, string arg_model_id, string arg_srf_no, int[] arg_rows)
        {
            string[] arg_value = new string[6];
            arg_value[0] = arg_factory;
            arg_value[1] = arg_model_id;
            arg_value[2] = arg_srf_no;
            arg_value[3] = (chk_target.Checked) ? "Y" : "N";
            arg_value[4] = (chk_adjust.Checked) ? "Y" : "N";
            arg_value[5] = (chk_detail.Checked) ? "Y" : "N";

            DataTable dt_row = SELECT_SCH_MANAGEMENT_ROW(arg_value);

            if (!chk_target.Checked && !chk_adjust.Checked && !chk_detail.Checked)
            {
                for (int i = arg_rows.Length - 1; i >= 0; i--)
                {
                    fgrid_main.Rows.Remove(arg_rows[i]);
                }

                fgrid_main.Rows.Insert(arg_rows[0]);

                for (int row = 0; row < dt_row.Rows.Count; row++)
                {
                    for (int col = 0; col < fgrid_main.Cols.Count; col++)
                    {
                        fgrid_main[arg_rows[0] + row, col] = dt_row.Rows[row].ItemArray[col].ToString();
                    }
                }

                Main_Grid_Style_Setting_Row(arg_rows[0]);
                fgrid_main.GetCellRange(arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;
                fgrid_main.GetCellRange(arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                fgrid_main.GetCellRange(arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
            }
            else
            {
                for (int i = arg_rows.Length - 1; i >= 0; i--)
                {
                    int nod_cnt = fgrid_main.Rows[arg_rows[i]].Node.Children;

                    //fgrid_main.Rows[arg_rows[i]].Node.GetNode(NodeTypeEnum.Parent).Row.Index

                    for (int child_row = 0; child_row < nod_cnt; child_row++)
                    {
                        fgrid_main.Rows.Remove(arg_rows[i] + 1);
                    }

                    fgrid_main.Rows.Remove(arg_rows[i]);
                }

                for (int row = 0; row < dt_row.Rows.Count; row++)
                {
                    int vTreeLevel = int.Parse(dt_row.Rows[row].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString());
                    string rep_yn = dt_row.Rows[row].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();

                    fgrid_main.Rows.InsertNode(arg_rows[0] + row, vTreeLevel);

                    for (int col = 0; col < fgrid_main.Cols.Count; col++)
                    {
                        fgrid_main[arg_rows[0] + row, col] = dt_row.Rows[row].ItemArray[col].ToString();
                    }

                    Main_Grid_Style_Setting_Row(arg_rows[0] + row);

                    fgrid_main.GetCellRange(arg_rows[0] + row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                    fgrid_main.GetCellRange(arg_rows[0] + row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, arg_rows[0] + row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                }

                fgrid_main.GetCellRange(arg_rows[0], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;

                for (int clear_row = fgrid_main.Rows.Fixed; clear_row < fgrid_main.Rows.Count; clear_row++)
                {
                    string level = fgrid_main[clear_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                    if (level.Equals("1"))
                    {
                        string rep_yn = fgrid_main[clear_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();

                        if (rep_yn.Equals("Y"))
                        {
                            int nod_cnt = fgrid_main.Rows[clear_row].Node.Children;

                            if (nod_cnt.Equals(0))
                            {
                                fgrid_main.Rows.Remove(clear_row);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Cancel Representation
        private bool Check_Cancel_Representation()
        {
            int[] sct_rows = fgrid_main.Selections;

            if (sct_rows.Length != 1)
            {
                MessageBox.Show("Please select only one representation data.");
                return false;
            }

            int sct_row = fgrid_main.Selection.r1;
            string model_id = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
            string item_seq = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_SEQ].ToString().Trim();

            if (model_id.Substring(0, 1).Equals("X"))
            {
                if (item_seq.Equals("001") || item_seq.Equals("002") || item_seq.Equals("003"))
                {
                    MessageBox.Show("Please select Representation Data.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please select Representation Data.");
                return false;
            }

            return true;
        }
        private void Cancel_Representation_Data()
        {
            int sct_row = fgrid_main.Selection.r1;

            string arg_factory  = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
            string arg_model_id = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
            string arg_srf_no   = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

            if (!chk_target.Checked && !chk_adjust.Checked && !chk_detail.Checked)
            {
                DialogResult dr01 = MessageBox.Show("Development Meeting Data will be deleted.\r\n\r\nNevertheless Do you want to delete model group?", "Warning", MessageBoxButtons.YesNo);
                if (dr01 == DialogResult.Yes)
                {
                    DataTable dt_ret = SELECT_CANCEL_REP_1LEV(arg_factory, arg_model_id);

                    if (DELETE_SXC_HEAD_REP(arg_factory, arg_model_id))
                    {
                        if (UPDATE_MODEL_ID_CANCEL(arg_factory, arg_model_id, ""))
                        {
                            fgrid_main.Rows.Remove(sct_row);

                            for (int i = dt_ret.Rows.Count - 1; i >= 0; i--)
                            {
                                fgrid_main.Rows.Insert(sct_row);

                                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                                {
                                    fgrid_main[sct_row, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                                }

                                Main_Grid_Style_Setting_Row(sct_row);
                                fgrid_main.GetCellRange(sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                                fgrid_main.GetCellRange(sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
            else
            {
                string level = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                if (level.Equals("1"))
                {
                    #region 1 Level
                    DialogResult dr01 = MessageBox.Show("Development Meeting Data will be deleted.\r\n\r\nNevertheless Do you want to delete model group?", "Warning", MessageBoxButtons.YesNo);
                    if (dr01 == DialogResult.Yes)
                    {
                        DataTable dt_ret = SELECT_CANCEL_REP_1LEV(arg_factory, arg_model_id);

                        if (DELETE_SXC_HEAD_REP(arg_factory, arg_model_id))
                        {
                            if (UPDATE_MODEL_ID_CANCEL(arg_factory, arg_model_id, ""))
                            {
                                int nod_cnt = fgrid_main.Rows[sct_row].Node.Children;

                                for (int child_row = 0; child_row < nod_cnt; child_row++)
                                {
                                    fgrid_main.Rows.Remove(sct_row + 1);
                                }

                                fgrid_main.Rows.Remove(sct_row);

                                for (int i = 0; i < dt_ret.Rows.Count; i++)
                                {
                                    int vTreeLevel = int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString());

                                    fgrid_main.Rows.InsertNode(sct_row + i, vTreeLevel);

                                    for (int j = 0; j < fgrid_main.Cols.Count; j++)
                                    {
                                        fgrid_main[sct_row + i, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                                    }

                                    Main_Grid_Style_Setting_Row(sct_row + i);

                                    fgrid_main.GetCellRange(sct_row + i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                                    fgrid_main.GetCellRange(sct_row + i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, sct_row + i, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                                }
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    #region 2 Level
                    if (UPDATE_MODEL_ID_CANCEL(arg_factory, arg_model_id, arg_srf_no))
                    {
                        DataTable dt_ret = SELECT_CANCEL_REP_2LEV(arg_factory, arg_srf_no);

                        int parent_Index = fgrid_main.Rows[sct_row].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
                        fgrid_main.Rows.Remove(sct_row);
                        int node_cnt = fgrid_main.Rows[parent_Index].Node.Children;

                        for (int i = 0; i < dt_ret.Rows.Count; i++)
                        {
                            int vTreeLevel = int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString());

                            fgrid_main.Rows.InsertNode(parent_Index + node_cnt + 1, vTreeLevel);

                            for (int j = 0; j < fgrid_main.Cols.Count; j++)
                            {
                                fgrid_main[parent_Index + node_cnt + 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                            }

                            Main_Grid_Style_Setting_Row(parent_Index + node_cnt + 1);

                            fgrid_main.GetCellRange(parent_Index + node_cnt + 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                            fgrid_main.GetCellRange(parent_Index + node_cnt + 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, parent_Index + node_cnt + 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                        }

                        if (node_cnt.Equals(0))
                        {
                            DELETE_SXC_HEAD_REP(arg_factory, arg_model_id);
                        }

                        fgrid_main.Select(parent_Index + node_cnt + 1, fgrid_main.Selection.c1);

                        for (int clear_row = fgrid_main.Rows.Fixed; clear_row < fgrid_main.Rows.Count; clear_row++)
                        {
                            string lev = fgrid_main[clear_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                            if (lev.Equals("1"))
                            {
                                string rep_yn = fgrid_main[clear_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();

                                if (rep_yn.Equals("Y"))
                                {
                                    int nod_cnt = fgrid_main.Rows[clear_row].Node.Children;

                                    if (nod_cnt.Equals(0))
                                    {
                                        fgrid_main.Rows.Remove(clear_row);
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                }
            }
        }
        #endregion

        #endregion

        #region DB Connect
        private DataTable GET_NEW_MODEL_ID()
        {
            string Proc_Name = "PKG_SXC_SCH_02_SELECT.GET_NEW_MODEL_ID";

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
        private bool UPDATE_MODEL_ID(string arg_model_id)
        {
            try
            {
                int col_ct = 5;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_MODEL_ID";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_MODEL_ID_TO";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                ArrayList vList = new ArrayList();
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string lev = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString();

                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString());
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString());
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString());
                    vList.Add(arg_model_id);
                    vList.Add(COM.ComVar.This_User);

                    //if (lev.Equals("1"))
                    //{

                    //}
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }
        private bool UPDATE_MODEL_ID_CANCEL(string arg_factory, string arg_model_id, string arg_srf_no)
        {
            try
            {
                int col_ct = 4;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_MODEL_ID_CANCEL";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_model_id;
                MyOraDB.Parameter_Values[2] = arg_srf_no;
                MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

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
        private bool INSERT_SXC_HEAD_REP(string arg_factory, string arg_model_id)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.INSERT_SXC_HEAD_REP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_model_id;
                MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

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
        private bool DELETE_SXC_HEAD_REP(string arg_factory, string arg_model_id)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.DELETE_SXC_HEAD_REP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_model_id;

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

        private DataTable SELECT_CANCEL_REP_1LEV(string arg_factory, string arg_model_id)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_CANCEL_REP_1LEV";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_model_id;
                MyOraDB.Parameter_Values[2] = "";

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
        private DataTable SELECT_CANCEL_REP_2LEV(string arg_factory, string arg_srf_no)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_CANCEL_REP_2LEV";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_srf_no;
                MyOraDB.Parameter_Values[2] = "";

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

        private void mnu_clear_data_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int[] sct_rows = fgrid_main.Selections;
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                if (sct_row < fgrid_main.Rows.Fixed)
                    return;

                if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01)
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        fgrid_main[sct_rows[i], sct_col] = null;
                        fgrid_main[sct_rows[i], sct_col + 1] = "";
                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";

                        CellRange cellrg = fgrid_main.GetCellRange(sct_rows[i], sct_col);
                        CellStyle cellst = fgrid_main.Styles.Add("PROG_" + sct_rows[i].ToString() + sct_col.ToString());
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.BackColor = Color.LightGray;
                        cellst.ForeColor = Color.Black;
                        cellrg.Style = fgrid_main.Styles["PROG_" + sct_rows[i].ToString() + sct_col.ToString()];
                    }
                }
            }
            catch
            {

            }
        }

        #region Progress
        private void mnu_scheduled_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                int[] sct_rows = fgrid_main.Selections;

                if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                {
                    string value = (fgrid_main[sct_row, sct_col].Equals(null)) ? "" : fgrid_main[sct_row, sct_col].ToString().Trim();

                    if (!value.Equals(""))
                    {
                        fgrid_main[sct_row, sct_col + 1] = "N";
                        fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";

                        CellRange cellrg = fgrid_main.GetCellRange(sct_row, sct_col);
                        CellStyle cellst = fgrid_main.Styles.Add("PROG_" + sct_row.ToString() + sct_col.ToString());
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.BackColor = Color.Yellow;
                        cellst.ForeColor = Color.Black;
                        cellrg.Style = fgrid_main.Styles["PROG_" + sct_row.ToString() + sct_col.ToString()];
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void mnu_in_progress_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                int[] sct_rows = fgrid_main.Selections;

                if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                {
                    string value = (fgrid_main[sct_row, sct_col].Equals(null)) ? "" : fgrid_main[sct_row, sct_col].ToString().Trim();

                    if (!value.Equals(""))
                    {
                        fgrid_main[sct_row, sct_col + 1] = "Y";
                        fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";

                        CellRange cellrg = fgrid_main.GetCellRange(sct_row, sct_col);
                        CellStyle cellst = fgrid_main.Styles.Add("PROG_" + sct_row.ToString() + sct_col.ToString());
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.BackColor = Color.Red;
                        cellst.ForeColor = Color.Black;
                        cellrg.Style = fgrid_main.Styles["PROG_" + sct_row.ToString() + sct_col.ToString()];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_completed_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                int[] sct_rows = fgrid_main.Selections;

                if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                {
                    string value = (fgrid_main[sct_row, sct_col].Equals(null)) ? "" : fgrid_main[sct_row, sct_col].ToString().Trim();

                    if (!value.Equals(""))
                    {
                        fgrid_main[sct_row, sct_col + 1] = "C";
                        fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";

                        CellRange cellrg = fgrid_main.GetCellRange(sct_row, sct_col);
                        CellStyle cellst = fgrid_main.Styles.Add("PROG_" + sct_row.ToString() + sct_col.ToString());
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.BackColor = Color.Aqua;
                        cellst.ForeColor = Color.Black;
                        cellrg.Style = fgrid_main.Styles["PROG_" + sct_row.ToString() + sct_col.ToString()];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        #endregion

        #region Development Meeting
        private void mnu_check_pt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string lev    = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim().ToUpper();
                    string rep_yn = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();
                    string status = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();
                    if (!status.Equals("D"))
                    {
                        if (lev.Equals("1") && rep_yn.Equals("Y"))
                        {
                            string print_yn = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCHK_PT].ToString().Trim().ToUpper();

                            string[] arg_value = new string[4];

                            arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                            arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                            arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                            arg_value[3] = (print_yn.Equals("TRUE")) ? "N" : "Y";

                            if (UPDATE_SXC_SCH_CHK_PT(arg_value))
                            {
                                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCHK_PT] = (print_yn.Equals("TRUE")) ? "FALSE" : "TRUE";
                            }
                        }
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
        /*******************************************************************/
        private void mnu_upload_subfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Multiselect = true;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {                    
                    int sct_row = fgrid_main.Selection.r1;
                    int sct_col = fgrid_main.Selection.c1;

                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        string file_name_short = openDlg.FileNames[i].Substring(openDlg.FileNames[i].LastIndexOf("\\") + 1, openDlg.FileNames[i].Length - openDlg.FileNames[i].LastIndexOf("\\") - 1);

                        string[] arg_value = new string[5];

                        arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                        arg_value[3] = GET_SCH_FILE_CD().Rows[0].ItemArray[0].ToString().Trim();
                        arg_value[4] = file_name_short;

                        string file_name = openDlg.FileNames[i];

                        if (INSERT_FILE_HEAD(arg_value, file_name))
                        {
                            if (SAVE_SCH_HEAD_FILE(arg_value))
                            {
                                MessageBox.Show("FIle Upload Complete.");
                                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCHK_FILE] = "TRUE";
                            }
                            else
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
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
        private void mnu_douwload_subfile_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[3];

                arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

                Pop_Sch_Devcheck_File pop = new Pop_Sch_Devcheck_File("MNG", arg_value);
                pop.ShowDialog();


                //FolderBrowserDialog save_file = new FolderBrowserDialog();

                //if (save_file.ShowDialog() == DialogResult.OK)
                //{
                //    string[] arg_value = new string[7];

                //    arg_value[0] = cmb_factory.SelectedValue.ToString();
                //    arg_value[1] = cmb_p_factory.SelectedValue.ToString();
                //    arg_value[2] = cmb_season_from.SelectedValue.ToString();
                //    arg_value[3] = cmb_season_to.SelectedValue.ToString();
                //    arg_value[4] = cmb_category.SelectedValue.ToString();
                //    arg_value[5] = txt_model.Text.Trim();
                //    arg_value[6] = cmb_user.SelectedValue.ToString();

                //    DataTable dt_ret = SELECT_SCH_DEVCHECK_FILE(arg_value);


                //    string save_path = save_file.SelectedPath;


                //    for (int i = 0; i < dt_ret.Rows.Count; i++)
                //    {

                //        try
                //        {
                //            string factory = dt_ret.Rows[i].ItemArray[0].ToString().Trim();
                //            string file_cd = dt_ret.Rows[i].ItemArray[1].ToString().Trim();
                //            string file_name = dt_ret.Rows[i].ItemArray[2].ToString().Trim().Replace("/", "_");
                //            string file_type = dt_ret.Rows[i].ItemArray[3].ToString().Trim().ToLower();

                //            string file_path = save_path + "\\" + file_name + "." + file_type;

                //            File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));
                //        }
                //        catch
                //        {
                //            string file_name = dt_ret.Rows[i].ItemArray[2].ToString().Trim();

                //            MessageBox.Show(file_name + "\r\nThis File have a problem,\r\nPlease ask System.");
                //            continue;
                //        }
                //    }

                //    MessageBox.Show("File Download Completed.");
                //}
            }
            catch
            {

            }
            finally
            {

            }
        }
        /*******************************************************************/
        private void mnu_update_image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.DefaultExt = "jpg";

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    int type_index = openDlg.FileName.LastIndexOf(".") + 1;
                    int type_length = openDlg.FileName.Length - type_index;
                    string file_type = openDlg.FileName.Substring(type_index, type_length).ToUpper().Trim();

                    if (!file_type.Equals("JPG") && !file_type.Equals("GIF") && !file_type.Equals("BMP"))
                    {
                        MessageBox.Show("File type is wrong. Please select iamge file (jpg, gif, bmp)");
                        return;
                    }
                    string targetPath = openDlg.FileName;


                    string[] arg_value = new string[4];

                    arg_value[0] = "I";
                    arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                    arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                    arg_value[3] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

                    if (SAVE_MODEL_IMAGE(arg_value, targetPath))
                    {
                        fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCHK_IMAGE] = "TRUE";
                    }
                }
            }
            catch
            {
 
            }
        }
        private void mnu_delete_image_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[3];

                arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                

                if (DELETE_MODEL_IMAGE(arg_value))
                {
                    fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCHK_IMAGE] = "FALSE";                    
                }
            }
            catch
            {

            }
        }

        private bool SAVE_MODEL_IMAGE(string[] arg_value, string arg_target_path)
        {
            try
            {
                bool ret = false;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_HEAD_IMG";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[3] = "ARG_SRF_NO";                
                MyOraDB.Parameter_Name[4] = "ARG_IMAGE";
                MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;                
                MyOraDB.Parameter_Type[4] = (int)OracleType.Blob;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];                
                MyOraDB.Parameter_Values[4] = " ";
                MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;

                byte[] photo = null;
                photo = GetPhoto(arg_target_path);
                ret = MyOraDB.Exe_Modify_Procedure_Blob(photo);

                return ret;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool DELETE_MODEL_IMAGE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.DELETE_SXC_SCH_HEAD_IMG";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";                

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private byte[] GetPhoto(string arg_filename)
        {
            FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;

        }
        /*******************************************************************/
        private void mnu_print_pt_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;

                string[] arg_value = new string[3];
                arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();

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
        /*******************************************************************/
        private bool SAVE_SCH_HEAD_FILE(string[] arg_value)
        {
            try
            {
                bool ret = false;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_HEAD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_FILE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_FILE_NAME";
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
                ClassLib.ComFunction.User_Message(ex.Message, "File Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private DataTable SELECT_SCH_DEVCHECK_FILE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_DEVCHECK_FILE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL";
                MyOraDB.Parameter_Name[6] = "ARG_USER";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = "";

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
        private bool UPDATE_SXC_SCH_CHK_PT(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_CHK_PT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_PT_YN";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

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

        #region Update
        private void mnu_ipw_record_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;

                string[] arg_value = new string[4];

                arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                arg_value[3] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD].ToString().Trim();

                Pop_sch_ipw_change pop = new Pop_sch_ipw_change(arg_value);
                pop.ShowDialog();

                if (pop._save_flg)
                {
                    arg_value = new string[6];

                    arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                    arg_value[3] = (chk_target.Checked) ? "Y" : "N";
                    arg_value[4] = (chk_adjust.Checked) ? "Y" : "N";
                    arg_value[5] = (chk_detail.Checked) ? "Y" : "N";


                    DataTable dt_ret = SELECT_SCH_MANAGEMENT_ROW(arg_value);

                    if (!chk_target.Checked && !chk_adjust.Checked && !chk_detail.Checked)
                        Display_Main_Data_1Level_Row(dt_ret, sct_row);
                    else
                        Display_Main_Data_2Level_Row(dt_ret, sct_row);
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
        /*******************************************************************/
        private void mnu_drop_record_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string drop_status = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();
                    string rep_yn      = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();
                    string level       = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                    if (!drop_status.Equals("D") && rep_yn.Equals("Y"))
                    {
                        if (level.Equals("1"))
                        {
                            string[] arg_value = new string[4];

                            arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                            arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                            arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                            arg_value[3] = "D";

                            if (UPDATE_SXC_SCH_DROP(arg_value))
                            {
                                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "D";
                                Main_Grid_Style_Setting_Row(sct_rows[i]);

                                try
                                {
                                    int nod_cnt = fgrid_main.Rows[sct_rows[i]].Node.Children;

                                    for (int row = 1; row <= nod_cnt; row++)
                                    {
                                        fgrid_main[sct_rows[i] + row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "D";
                                        Main_Grid_Style_Setting_Row(sct_rows[i] + row);
                                    }
                                }
                                catch
                                {

                                }
                            }
                        }
                        
                    }
                    else if (!drop_status.Equals("D"))
                    {
                        if (level.Equals("2"))
                        {
                            string[] arg_value = new string[4];

                            arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                            arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                            arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                            arg_value[3] = "D";

                            if (UPDATE_SXC_SCH_DROP(arg_value))
                            {
                                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "D";
                                Main_Grid_Style_Setting_Row(sct_rows[i]);
                            }
                        }
                    }
                }

                Display_Detail_Data();
                fgrid_detail.Tree.Show(1);
                MainGrid_Click_Setting();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void mnu_cancel_drop_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string drop_status = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();

                    if (drop_status.Equals("D"))
                    {
                        string level = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();

                        if (level.Equals("1"))
                        {
                            string[] arg_value = new string[4];

                            arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                            arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                            arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                            arg_value[3] = "N";

                            if (UPDATE_SXC_SCH_DROP(arg_value))
                            {
                                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "N";
                                Main_Grid_Style_Setting_Row(sct_rows[i]);

                                try
                                {
                                    int nod_cnt = fgrid_main.Rows[sct_rows[i]].Node.Children;

                                    for (int row = 1; row <= nod_cnt; row++)
                                    {
                                        fgrid_main[sct_rows[i] + row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "N";
                                        Main_Grid_Style_Setting_Row(sct_rows[i] + row);
                                    }
                                }
                                catch
                                {

                                }
                            }
                        }
                        else
                        {
                            string[] arg_value = new string[4];

                            arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                            arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                            arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                            arg_value[3] = "N";

                            if (UPDATE_SXC_SCH_DROP(arg_value))
                            {
                                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS] = "N";
                                Main_Grid_Style_Setting_Row(sct_rows[i]);
                            }
                        }
                    }
                }

                Display_Detail_Data();
                fgrid_detail.Tree.Show(1);
                MainGrid_Click_Setting();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        /*******************************************************************/
        private void mnu_model_info_Click(object sender, EventArgs e)
        {
            try
            {
                Pop_Sch_Value_Change_Desc pop = new Pop_Sch_Value_Change_Desc(this);
                pop.ShowDialog();
            }
            catch
            {
 
            }
        }
        private void mnu_cat_td_Click(object sender, EventArgs e)
        {
            try
            {
                Pop_Sch_Value_Change pop = new Pop_Sch_Value_Change(this);
                pop.ShowDialog();
            }
            catch
            {

            }
        }
        /*******************************************************************/
        private void mnu_copy_record_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;

                copy_row = sct_row;
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void mnu_paste_record_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P; j++)
                    {
                        bool set_yn = Style_Setting_YN(j);

                        if (set_yn)
                        {
                            if (fgrid_main[copy_row, j].Equals(""))
                            {
                                fgrid_main[sct_rows[i], j] = null;
                            }
                            else
                            {
                                try
                                {
                                    int year = int.Parse(fgrid_main[copy_row, j].ToString().Trim().Substring(0, 4));
                                    int month = int.Parse(fgrid_main[copy_row, j].ToString().Trim().Substring(4, 2));
                                    int day = int.Parse(fgrid_main[copy_row, j].ToString().Trim().Substring(6, 2));

                                    DateTime date = new DateTime(year, month, day);

                                    fgrid_main[sct_rows[i], j] = date;
                                }
                                catch
                                {
                                    DateTime date = new DateTime();

                                    date = Convert.ToDateTime(fgrid_main[copy_row, j].ToString().Trim());

                                    fgrid_main[sct_rows[i], j] = date;
                                }
                            }
                        }
                        else
                        {
                            fgrid_main[sct_rows[i], j] = fgrid_main[copy_row, j].ToString().Trim();
                        }
                    }

                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        /*******************************************************************/
        private void Display_Main_Data_1Level_Row(DataTable arg_dt, int arg_row)
        {

            for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01; j++)
            {
                bool set_yn = Style_Setting_YN(j);

                if (set_yn)
                {
                    if (arg_dt.Rows[0].ItemArray[j].ToString().Trim().Equals(""))
                    {
                        fgrid_main[arg_row, j] = null;
                    }
                    else
                    {
                        int year = int.Parse(arg_dt.Rows[0].ItemArray[j].ToString().Trim().Substring(0, 4));
                        int month = int.Parse(arg_dt.Rows[0].ItemArray[j].ToString().Trim().Substring(4, 2));
                        int day = int.Parse(arg_dt.Rows[0].ItemArray[j].ToString().Trim().Substring(6, 2));

                        DateTime date = new DateTime(year, month, day);

                        fgrid_main[arg_row, j] = date;
                    }
                }
            }

            for (int col = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD; col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD; col++)
            {
                fgrid_main[arg_row, col] = arg_dt.Rows[0].ItemArray[col].ToString().Trim();
            }

            if (arg_dt.Rows.Count > 0)
            {
                Display_Detail_Data();
                fgrid_detail.Tree.Show(1);
            }
        }
        private void Display_Main_Data_2Level_Row(DataTable arg_dt, int arg_row)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01; j++)
                {
                    bool set_yn = Style_Setting_YN(j);

                    if (set_yn)
                    {
                        if (arg_dt.Rows[0].ItemArray[j].ToString().Trim().Equals(""))
                        {
                            fgrid_main[arg_row + i, j] = null;
                        }
                        else
                        {
                            int year  = int.Parse(arg_dt.Rows[i].ItemArray[j].ToString().Trim().Substring(0, 4));
                            int month = int.Parse(arg_dt.Rows[i].ItemArray[j].ToString().Trim().Substring(4, 2));
                            int day   = int.Parse(arg_dt.Rows[i].ItemArray[j].ToString().Trim().Substring(6, 2));

                            DateTime date = new DateTime(year, month, day);

                            fgrid_main[arg_row + i, j] = date;
                        }
                    }
                }

                for (int col = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD; col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD; col++)
                {
                    fgrid_main[arg_row + i, col] = arg_dt.Rows[i].ItemArray[col].ToString().Trim();
                }
            }

            if (arg_dt.Rows.Count > 0)
            {
                Display_Detail_Data();
                fgrid_detail.Tree.Show(1);
            }
        }
        private void Main_Grid_Style_Setting_Row(int arg_row)
        {
            for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD; j++)
            {
                bool style_set = Style_Setting_YN(j);

                if (style_set)
                {
                    string progress = fgrid_main[arg_row, j + 1].ToString().Trim();
                    string level = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString().Trim();
                    string status = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTATUS].ToString().Trim();
                    string rep_yn = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN].ToString().Trim();

                    if (status.Equals("D"))
                    {
                        #region Drop Data
                        if (level.Equals("1"))
                        {
                            #region 1 Level
                            if (progress.Equals("C")) //Complete
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Aqua;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("Y")) //Progress
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Red;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }                            
                            else
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + arg_row.ToString() + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.LightGray;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + arg_row.ToString() + j.ToString()];
                            }
                            #endregion
                        }
                        else
                        {
                            #region 2 Level
                            if (progress.Equals("C")) //Complete
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Aqua;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("Y")) //Progress
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Red;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }                            
                            else
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + arg_row.ToString() + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.LightGray;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + arg_row.ToString() + j.ToString()];
                            }
                            #endregion
                        }
                        

                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN).StyleNew.BackColor = Color.LightGray;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.LightGray;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD).StyleNew.BackColor = Color.LightGray;
                        fgrid_main.Rows[arg_row].AllowEditing = false;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Black;
                        #endregion
                    }
                    else if (status.Equals("N"))
                    {
                        #region Before Edit
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN).StyleNew.BackColor = Color.Beige;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.Beige;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD).StyleNew.BackColor = Color.Beige;
                        fgrid_main.Rows[arg_row].AllowEditing = true;
                        if (rep_yn.Equals("Y"))
                            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;
                        else
                            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Black;

                        if (level.Equals("1"))
                        {
                            if (progress.Equals("")) //Null
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.LightGray;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;

                                if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                    cellst.BackColor = Color.MintCream;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                    cellst.BackColor = Color.Snow;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                    cellst.BackColor = Color.FromArgb(255, 255, 205);

                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                        
                        }
                        else 
                        {
                            if (progress.Equals("")) //Null
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.LightGray;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;

                                if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                    cellst.BackColor = Color.White;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                    cellst.BackColor = Color.White;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                    cellst.BackColor = Color.White;

                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        #region After Edit
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREP_YN).StyleNew.BackColor = Color.Beige;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.Beige;
                        fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD).StyleNew.BackColor = Color.Beige;
                        fgrid_main.Rows[arg_row].AllowEditing = true;
                        if (rep_yn.Equals("Y"))
                            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Blue;
                        else
                            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.ForeColor = Color.Black;


                        if (level.Equals("1"))
                        {
                            #region 1 Level
                            if (progress.Equals("C")) //Complete
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Aqua;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("Y")) //Progress
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Red;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("N")) //Progress
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Yellow;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("")) //Null
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.LightGray;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;

                                if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                    cellst.BackColor = Color.MintCream;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                    cellst.BackColor = Color.Snow;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                    cellst.BackColor = Color.FromArgb(255, 255, 205);

                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            #endregion
                        }
                        else
                        {
                            #region 2 Level
                            if (progress.Equals("C")) //Complete
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Aqua;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("Y")) //Progress
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Red;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("N")) //Progress
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.Yellow;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else if (progress.Equals("")) //Null
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;
                                cellst.BackColor = Color.LightGray;
                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            else
                            {
                                CellRange cellrg = fgrid_main.GetCellRange(arg_row, j);
                                CellStyle cellst = fgrid_main.Styles.Add("DT_" + "r" + arg_row.ToString() + "c" + j.ToString());
                                cellst.DataType = typeof(DateTime);
                                cellst.Format = "yyyyMMdd";
                                cellst.TextAlign = TextAlignEnum.CenterCenter;

                                if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN090_T01_P)
                                    cellst.BackColor = Color.White;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN100_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN280_T01_P)
                                    cellst.BackColor = Color.White;
                                else if (j >= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN290_T01 && j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxN300_T01_P)
                                    cellst.BackColor = Color.White;

                                cellst.ForeColor = Color.Black;
                                cellrg.Style = fgrid_main.Styles["DT_" + "r" + arg_row.ToString() + "c" + j.ToString()];
                            }
                            #endregion
                        }
                        #endregion
                    }
                }

            }
        }
        /*******************************************************************/
        private DataTable SELECT_SCH_MANAGEMENT_ROW(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SXC_SCH_MANAGEMENT_ROW";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_TARGET_CHK";
                MyOraDB.Parameter_Name[4] = "ARG_ADJ_CHK";
                MyOraDB.Parameter_Name[5] = "ARG_DETAIL_CHK";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private bool UPDATE_SXC_SCH_DROP(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_DROP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_STATUS";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

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

        #region View
        private void mnu_actual_view_Click(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(1);
            }
            catch
            {

            }
        }
        private void mnu_detail_view_Click(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(2);
            }
            catch
            {

            }
        }
        #endregion

        #endregion

        #region Detail Grid

        #region Representation
        private void mnu_rep_detail_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_detail.Rows.Count.Equals(fgrid_detail.Rows.Fixed))
                    return;

                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;                
                
                string rep_yn = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxREP_YN].ToString().Trim();                                
                string nf_seq = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxITEM_SEQ].ToString().Trim();
                                
                if (rep_yn.Equals("N"))                
                {                
                    string[] arg_value = new string[6];
                    
                    arg_value[0] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();                    
                    arg_value[1] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();                    
                    arg_value[2] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();                    
                    arg_value[3] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();                    
                    arg_value[4] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();                    
                    arg_value[5] = "Y";
                    
                    if (UPDATE_SXC_SCH_REP_YN_DETAIL(arg_value))                    
                    {
                        fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxREP_YN] = "Y";                        
                        fgrid_detail.GetCellRange(sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY_V, sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Blue;                        
                    }                    
                    else                    
                    {                    
                        return;                        
                    }                    
                }                
                else                
                {                
                    MessageBox.Show("This BOM is already represented");                    
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void mnu_rep_cancel_detail_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_detail.Rows.Count.Equals(fgrid_detail.Rows.Fixed))
                    return;

                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;


                string rep_yn = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxREP_YN].ToString().Trim();                
                string nf_seq = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxITEM_SEQ].ToString().Trim();

                if (rep_yn.Equals("Y"))
                {
                    string[] arg_value = new string[6];

                    arg_value[0] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
                    arg_value[3] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
                    arg_value[4] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
                    arg_value[5] = "N";
                    
                    if (UPDATE_SXC_SCH_REP_YN_DETAIL(arg_value))
                    {
                        fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxREP_YN] = "N";
                        fgrid_detail.GetCellRange(sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY_V, sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Black;
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("This BOM is already canceled");
                }

            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private bool UPDATE_SXC_SCH_REP_YN_DETAIL(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_REP_YN_DETAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[5] = "ARG_REP_YN";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;

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

        #region Progress
        private void mnu_clear_detaildata_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_detail.Rows.Count.Equals(fgrid_detail.Rows.Fixed))
                    return;

                int[] sct_rows = fgrid_detail.Selections;
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                if (sct_row < fgrid_detail.Rows.Fixed)
                    return;

                if (sct_col >= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM && sct_col <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP)
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        fgrid_detail[sct_rows[i], sct_col] = null;

                        SAVE_DETAIL_DATA(sct_rows[i]);
                    }
                }
            }
            catch
            {

            }
        }
        private void mnu_complete_detail_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
            finally
            {
 
            }
        }
        private void mnu_cancel_detail_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion

        #region Update
        private void mnu_drop_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_detail.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string[] arg_value = new string[6];

                    arg_value[0] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
                    arg_value[3] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
                    arg_value[4] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
                    arg_value[5] = "D";

                    if (UPDATE_SXC_SCH_DETAIL_DROP(arg_value))
                    {
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSTATUS] = "D";
                        Detail_Grid_Style_Setting_Row(sct_rows[i]);

                    }
                }

                DetailGrid_Click_Setting();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void mnu_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_detail.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string[] arg_value = new string[6];

                    arg_value[0] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
                    arg_value[3] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
                    arg_value[4] = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
                    arg_value[5] = "N";

                    if (UPDATE_SXC_SCH_DETAIL_DROP(arg_value))
                    {
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSTATUS] = "N";
                        Detail_Grid_Style_Setting_Row(sct_rows[i]);

                    }
                }

                DetailGrid_Click_Setting();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Detail_Grid_Style_Setting_Row(int arg_row)
        {
            string status = fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSTATUS].ToString().Trim();
            string rep_yn = fgrid_detail[arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxREP_YN].ToString().Trim();

            if (status.Equals("D"))
            {
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.BackColor = Color.LightGray;
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Black;
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSHOE_VER).StyleNew.BackColor = Color.LightGray;
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxIPW_YMD, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxUPD_YMD).StyleNew.BackColor = Color.LightGray;
                fgrid_detail.Rows[arg_row].AllowEditing = false;
            }
            else
            {
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.BackColor = Color.Beige;

                if (rep_yn.Equals("Y"))
                    fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Blue;
                else
                    fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTD_CODE).StyleNew.ForeColor = Color.Black;
                    
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSHOE_VER).StyleNew.BackColor = Color.White;
                fgrid_detail.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxIPW_YMD, arg_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxUPD_YMD).StyleNew.BackColor = Color.White;

                fgrid_detail.Rows[arg_row].AllowEditing = true;
            }

            for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_BOM; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxTASK_TP; j++)
            {
                bool style_yn = Style_Setting_YN_Detail(j);

                if (style_yn)
                {
                    #region Date Type Setting
                    CellRange cellrg = fgrid_detail.GetCellRange(arg_row, j);
                    CellStyle cellst = fgrid_detail.Styles.Add("DT_DETAIL_" + arg_row.ToString() + j.ToString());
                    cellst.DataType = typeof(DateTime);
                    cellst.Format = "yyyyMMdd";
                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                    cellst.ForeColor = Color.Black;

                    if (status.Equals("D"))
                    {
                        cellst.BackColor = Color.LightGray;

                        fgrid_detail.GetCellRange(arg_row, j - 1).StyleNew.BackColor = Color.LightGray;
                    }
                    else
                    {
                        fgrid_detail.GetCellRange(arg_row, j - 1).StyleNew.BackColor = Color.White;

                        string progress = fgrid_detail[arg_row, j + 1].ToString().Trim();

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

                    cellrg.Style = fgrid_detail.Styles["DT_DETAIL_" + arg_row.ToString() + j.ToString()];
                    #endregion                    
                }
            }

        }
        private bool UPDATE_SXC_SCH_DETAIL_DROP(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_DETAIL_DROP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[5] = "ARG_STATUS";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;

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

        #region File 관련
        private void mnu_upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Multiselect = true;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;


                    int sct_row = fgrid_detail.Selection.r1;
                    int sct_col = fgrid_detail.Selection.c1;

                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        string file_name_short = openDlg.FileNames[i].Substring(openDlg.FileNames[i].LastIndexOf("\\") + 1, openDlg.FileNames[i].Length - openDlg.FileNames[i].LastIndexOf("\\") - 1);

                        string[] arg_value = new string[9];

                        arg_value[0] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
                        arg_value[3] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
                        arg_value[4] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
                        arg_value[5] = Get_NF_SEQ(sct_col);
                        arg_value[6] = Get_TASK_CD(sct_col);
                        arg_value[7] = GET_SCH_FILE_CD().Rows[0].ItemArray[0].ToString().Trim();
                        arg_value[8] = int.Parse(arg_value[7]).ToString() + "_" + file_name_short;

                        string file_name = openDlg.FileNames[i];

                        if (INSERT_FILE(arg_value, file_name))
                        {
                            if (!SAVE_SCH_TAIL_FILE(arg_value))
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

                    bool col_check = Style_Setting_YN_Detail(sct_col);

                    if (col_check)
                    {
                        fgrid_detail[sct_row, sct_col - 1] = "TRUE";
                        fgrid_detail[sct_row, sct_col] = DateTime.Now;
                        SAVE_DETAIL_DATA(sct_row);
                    }
                    else
                    {
                        fgrid_detail[sct_row, sct_col] = "TRUE";
                        fgrid_detail[sct_row, sct_col + 1] = DateTime.Now;
                        SAVE_DETAIL_DATA(sct_row);
                    }

                    MessageBox.Show("File Upload Completed.");
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void mnu_upload_email_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Multiselect = true;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;


                    int sct_row = fgrid_detail.Selection.r1;
                    int sct_col = fgrid_detail.Selection.c1;

                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        string file_name_short = openDlg.FileNames[i].Substring(openDlg.FileNames[i].LastIndexOf("\\") + 1, openDlg.FileNames[i].Length - openDlg.FileNames[i].LastIndexOf("\\") - 1);

                        string[] arg_value = new string[9];

                        arg_value[0] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxSRF_NO].ToString().Trim();
                        arg_value[3] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxBOM_ID].ToString().Trim();
                        arg_value[4] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT_DETAIL.IxNF_CD].ToString().Trim();
                        arg_value[5] = Get_NF_SEQ(sct_col);
                        arg_value[6] = Get_TASK_CD(sct_col);
                        arg_value[7] = GET_SCH_FILE_CD().Rows[0].ItemArray[0].ToString().Trim();
                        arg_value[8] = int.Parse(arg_value[7]).ToString() + "_" + file_name_short;

                        string file_name = openDlg.FileNames[i];

                        if (INSERT_FILE(arg_value, file_name))
                        {
                            if (!SAVE_SCH_TAIL_FILE(arg_value))
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

                    bool col_check = Style_Setting_YN_Detail(sct_col);

                    if (col_check)
                    {
                        fgrid_detail[sct_row, sct_col - 1] = "TRUE";
                    }
                    else
                    {
                        fgrid_detail[sct_row, sct_col] = "TRUE";
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
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void mnu_open_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {

            }
            finally
            {

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
        private bool SAVE_SCH_TAIL_FILE(string[] arg_value)
        {
            try
            {
                bool ret = false;

                MyOraDB.ReDim_Parameter(10);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_SXC_SCH_TAIL_FILE";

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

        private void mnu_openfile_02_Click(object sender, EventArgs e)
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
        #endregion                
        #endregion

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

        #region Insert File
        private string insert_query()
        {
            string insert_query = "INSERT INTO SXC_SCH_FILE (FACTORY, FILE_CD, RAW_FILE) VALUES (@FACTORY, @FILE_CD, @RAW_FILE)";
            return insert_query;
        }
        private bool INSERT_FILE(string[] arg_value, string file_name)
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
        private bool INSERT_FILE_HEAD(string[] arg_value, string file_name)
        {
            try
            {
                byte[] file = null;
                file = GetFile(file_name);

                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(insert_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_value[0]);
                com.Parameters.AddWithValue("@FILE_CD", arg_value[3]);
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

        #region Form Closing
        private void Form_Sch_Management_02_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_main_form.Equals("WORKSHEET"))
                {
                    if (Sch_Grouping_Check())
                    {
                        MessageBox.Show("Non Grouping Data is exist. Please grouping all data");
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false; 
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }
        private bool Sch_Grouping_Check()
        {
            bool rnt_value = false;

            string[] arg_value = new string[6];

            arg_value[0] = cmb_factory.SelectedValue.ToString();
            arg_value[1] = cmb_season_from.SelectedValue.ToString();
            arg_value[2] = cmb_season_to.SelectedValue.ToString();
            arg_value[3] = cmb_category.SelectedValue.ToString();
            arg_value[4] = txt_model.Text.Trim();
            arg_value[5] = cmb_user.SelectedValue.ToString();

            DataTable dt_ret = SELECT_SCH_GROUP_CHK(arg_value);

            if (dt_ret.Rows.Count > 0)
            {
                rnt_value = true;
            }
            else
            {
                rnt_value = false;
            }

            return rnt_value;
        }
         
        private System.Data.DataTable SELECT_SCH_GROUP_CHK(string [] arg_value)
        {
            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_GROUP_CHECK";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[4] = "ARG_MODEL";
            MyOraDB.Parameter_Name[5] = "ARG_USER";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];
        }
        #endregion                

        

    }
}



