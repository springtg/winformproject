using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product_VJ
{
    public partial class Pop_Worksheet_Huser_VJ : COM.PCHWinForm.Pop_Large_B
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService Connection
        public FlexCDC.Product_VJ.Form_Worksheet_VJ _temp_ws = null;
        private string _temp_dev_sabun = "000000000", _temp_te_sabun = "000000000", _temp_ce_sabun= "000000000";        
        private string _temp_type;
        #endregion

        #region Resource
        public Pop_Worksheet_Huser_VJ()
        {
            InitializeComponent();
        }

        public Pop_Worksheet_Huser_VJ(Form_Worksheet_VJ arg_ws, string arg_type)
        {
            _temp_ws   = arg_ws;
            _temp_type = arg_type;

            InitializeComponent();
        }        
        #endregion

        #region Form Loading
        private void Pop_Worksheet_Huser_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void Init_Form()
        {
            //Title Setting
            this.Text = "Developer/Mold for SMS";
            this.lbl_MainTitle.Text = "Developer/Mold"; 

            //Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Conform.Enabled = false;
            tbtn_Print.Enabled   = false;
            tbtn_Create.Enabled  = false;

            Control_setting();

            fgrid_pattern.Set_Grid_CDC("SXG_HUSER_POP_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_pattern.ExtendLastCol = false;
            fgrid_pattern.AllowDragging = AllowDraggingEnum.None;

            fgrid_mold.Set_Grid_CDC("SXG_HUSER_POP_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_mold.ExtendLastCol = false;
            fgrid_mold.AllowDragging = AllowDraggingEnum.None;

            fgrid_chemical.Set_Grid_CDC("SXG_HUSER_POP_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_chemical.ExtendLastCol = false;
            fgrid_chemical.AllowDragging = AllowDraggingEnum.None;

            if (_temp_type.Equals("P"))
                tab_main.SelectedIndex = 0;
            else if (_temp_type.Equals("M"))
                tab_main.SelectedIndex = 1;
            else 
                tab_main.SelectedIndex = 2;

            tbtn_Search_Click(null, null);
        }
        private void Control_setting()
        {            
            txt_developer.ReadOnly   = true;            
            txt_mold.ReadOnly      = true;

            int sct_count = _temp_ws.flg_project.Selections.Length;

            if (sct_count == 1)
            {
                _temp_dev_sabun   = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_PE_SABUN].ToString();                
                _temp_te_sabun   = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_TE_SABUN].ToString();                
                                
                txt_developer.Text = _temp_ws.cmb_sms_dev.Text;
                txt_mold.Text    = _temp_ws.cmb_sms_mold.Text;
            }
        }        
        #endregion
        
        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                string arg_factory   = COM.ComVar.This_CDC_Factory;                
                string arg_user_name = txt_name.Text.Trim();

                if (tab_main.SelectedIndex.Equals(0))
                {
                    fgrid_pattern.Rows.Count = fgrid_pattern.Rows.Fixed;

                    DataTable dt_list = SELECT_HUSER_LIST(arg_factory, "P", arg_user_name);

                    Display_Grid(dt_list, fgrid_pattern);
                }
                else if (tab_main.SelectedIndex.Equals(1))
                {
                    fgrid_mold.Rows.Count = fgrid_mold.Rows.Fixed;

                    DataTable dt_list = SELECT_HUSER_LIST(arg_factory, "M", arg_user_name);

                    Display_Grid(dt_list, fgrid_mold);
                }
                else if (tab_main.SelectedIndex.Equals(2))
                {
                    fgrid_chemical.Rows.Count = fgrid_chemical.Rows.Fixed;

                    DataTable dt_list = SELECT_HUSER_LIST(arg_factory, "C", arg_user_name);

                    Display_Grid(dt_list, fgrid_chemical);
                }                
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyCode != Keys.Enter)
                    return;

                tbtn_Search_Click(null, null);
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        
        private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_grid)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_grid.Rows.Add();

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_grid[arg_grid.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }                
            }
        }
        private DataTable SELECT_HUSER_LIST(string arg_factory, string arg_dept_div, string arg_user_name)
        {
            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_HUSER_LIST";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DEPT_DIV";
            MyOraDB.Parameter_Name[2] = "ARG_USER_NAME";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_dept_div;
            MyOraDB.Parameter_Values[2] = arg_user_name;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Grid Setting 
        private void fgrid_pattern_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                _temp_dev_sabun   = fgrid_pattern[fgrid_pattern.Selection.r1, 1].ToString();
                txt_developer.Text = fgrid_pattern[fgrid_pattern.Selection.r1, 2].ToString();              
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void fgrid_mold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                _temp_te_sabun = fgrid_mold[fgrid_mold.Selection.r1, 1].ToString();
                txt_mold.Text = fgrid_mold[fgrid_mold.Selection.r1, 2].ToString();               
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion

        #region Sava Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = _temp_ws.flg_project.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string[] arg_value = new string[9];

                    arg_value[0] = _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
                    arg_value[1] = _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
                    arg_value[2] = _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
                    arg_value[3] = "";
                    arg_value[4] = "";
                    arg_value[5] = "";
                    arg_value[6] = "";
                    arg_value[7] = _temp_dev_sabun;
                    arg_value[8] = _temp_te_sabun;
                    //arg_value[9] = _temp_ce_sabun;
                    SAVE_HUSER(arg_value);
                    
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_PE_SABUN] = _temp_dev_sabun;
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_TE_SABUN] = _temp_te_sabun;
                                        
                }

                this.Close();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void SAVE_HUSER(string [] arg_value)
        {
            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = "PKG_SXG_MPS_01.SAVE_HUSER_POP_01";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[3] = "ARG_NIKE_DEV";
            MyOraDB.Parameter_Name[4] = "ARG_NIKE_PE";
            MyOraDB.Parameter_Name[5] = "ARG_NIKE_TE";
            MyOraDB.Parameter_Name[6] = "ARG_NIKE_CE";
            MyOraDB.Parameter_Name[7] = "ARG_PE_SABUN";
            MyOraDB.Parameter_Name[8] = "ARG_TE_SABUN";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = arg_value[8];

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Control Event
        private void tab_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_name.Text = "";

            tbtn_Search_Click(null, null); 
        }
        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fsp1_Click(object sender, EventArgs e)
        {

        }

        private void fgrid_chemical_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                _temp_ce_sabun = fgrid_chemical[fgrid_chemical.Selection.r1, 1].ToString();
                txt_chem.Text = fgrid_chemical[fgrid_chemical.Selection.r1, 2].ToString();
            }
            catch
            {

            }
            finally
            {

            }
        }

        
    }
}

