using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.CDC_Bom
{
    public partial class Pop_Worksheet_Huser : COM.PCHWinForm.Pop_Large_B
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        public FlexCDC.CDC_Bom.Form_Project_Manager _temp_ws = null;
        private string _temp_pe_sabun = "000000000", _temp_te_sabun = "000000000";
        private string _temp_nike_dev = "000000000", _temp_nike_pe = "000000000", _temp_nike_te = "000000000", _temp_nike_ce = "000000000";
        private string _temp_type;
        #endregion

        #region 생성자
        public Pop_Worksheet_Huser()
        {
            InitializeComponent();
        }

        public Pop_Worksheet_Huser(Form_Project_Manager arg_ws, string arg_type)
        {
            _temp_ws   = arg_ws;
            _temp_type = arg_type;

            InitializeComponent();
        }

        public Pop_Worksheet_Huser(Form_Project_Manager arg_ws)
        {
            _temp_ws = arg_ws;
            
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
            this.Text = "Nike/Pattern/Mold for SMS";
            this.lbl_MainTitle.Text = "Nike/Pattern/Mold"; 

            //Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Conform.Enabled = false;
            tbtn_Print.Enabled   = false;
            tbtn_Create.Enabled  = false;

            Control_setting();

            //Grid Setting
            fgrid_nike.Set_Grid_CDC("SXE_WORKSHEET_POP", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_nike.ExtendLastCol = false;
            fgrid_nike.AllowDragging = AllowDraggingEnum.None;

            fgrid_pattern.Set_Grid_CDC("SXE_WORKSHEET_POP", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_pattern.ExtendLastCol = false;
            fgrid_pattern.AllowDragging = AllowDraggingEnum.None;

            fgrid_mold.Set_Grid_CDC("SXE_WORKSHEET_POP", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_mold.ExtendLastCol = false;
            fgrid_mold.AllowDragging = AllowDraggingEnum.None;

            if (_temp_type.Equals("N"))
                tab_main.SelectedIndex = 0;
            else if (_temp_type.Equals("P"))
                tab_main.SelectedIndex = 1;
            else
                tab_main.SelectedIndex = 2;

            tbtn_Search_Click(null, null);
        }
        private void Control_setting()
        {
            txt_nike.ReadOnly      = true;
            txt_nike_pe.ReadOnly   = true;
            txt_nike_te.ReadOnly   = true;
            txt_nike_ce.ReadOnly   = true;
            txt_pattern.ReadOnly   = true;
            txt_pattern2.ReadOnly  = true;
            txt_pattern2.BackColor = SystemColors.Control;
            txt_mold.ReadOnly      = true;

            int sct_count = _temp_ws.flg_project.Selections.Length;

            if (sct_count == 1)
            {
                _temp_pe_sabun   = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxCDC_PE_SABUN].ToString();                
                _temp_te_sabun   = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxCDC_TE_SABUN].ToString();
                _temp_nike_dev   = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_DEV_SEQ].ToString();
                _temp_nike_pe    = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_PE_SEQ].ToString();
                _temp_nike_te    = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_TE_SEQ].ToString();
                _temp_nike_ce    = _temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_CE_SEQ].ToString();
                                
                txt_pattern.Text = _temp_ws.cmb_pattern.Text;
                txt_mold.Text    = _temp_ws.cmb_mold.Text;
                txt_nike.Text    = _temp_ws.cmb_nike.Text;
                txt_nike_pe.Text = _temp_ws.cmb_pe.Text;
                txt_nike_te.Text = _temp_ws.cmb_te.Text;
                txt_nike_ce.Text = _temp_ws.cmb_ce.Text;


                if (!_temp_pe_sabun.Equals("000000000"))
                {
                    DataTable dt_ret = get_huser_info(_temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxFACTORY].ToString(), _temp_pe_sabun);

                    string org_cd = dt_ret.Rows[0].ItemArray[2].ToString();

                    if (org_cd.Equals("102310")) // Pattern 1
                        txt_pattern2.Text = "황정환";
                    else                         // Pattern 2
                        txt_pattern2.Text = "박석수";
                }
                else
                {
                    txt_pattern2.Text = "N/A";
                }
            }

        }
        private DataTable get_huser_info(string arg_factory, string arg_user_sabun)
        {
            string Proc_Name = "pkg_sxg_prod_01_select.get_huser_info";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_user_sabun";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_user_sabun;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

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
                    fgrid_nike.Rows.Count = fgrid_nike.Rows.Fixed;

                    DataTable dt_list = Select_huser_list(arg_factory, "N", arg_user_name);

                    Display_Grid(dt_list, fgrid_nike); 
                }
                else if (tab_main.SelectedIndex.Equals(1))
                {
                    fgrid_pattern.Rows.Count = fgrid_pattern.Rows.Fixed;

                    DataTable dt_list = Select_huser_list(arg_factory, "P", arg_user_name);

                    Display_Grid(dt_list, fgrid_pattern);
                }
                else if (tab_main.SelectedIndex.Equals(2))
                {
                    fgrid_mold.Rows.Count = fgrid_mold.Rows.Fixed;

                    DataTable dt_list = Select_huser_list(arg_factory, "M", arg_user_name);

                    Display_Grid(dt_list, fgrid_mold);
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
        private void cmb_dept_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;            

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
                    if (j == 4)
                    {
                        string phone = arg_dt.Rows[i].ItemArray[j].ToString();
                        try
                        {                            
                            phone = phone.Substring(0, 3) + "-" + phone.Substring(3, phone.Length - 7) + "-" + phone.Substring(phone.Length - 4, 4);
                        }
                        catch
                        {
                            
                        }

                        arg_grid[arg_grid.Rows.Count - 1, j] = phone;
                    }
                    else
                    {
                        arg_grid[arg_grid.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                    }

                    
                }                
            }
        }
        private DataTable Select_huser_list(string arg_factory, string arg_dept_div, string arg_user_name)
        {
            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_01_select.select_huser_list";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_dept_div";
            MyOraDB.Parameter_Name[2] = "arg_user_name";
            MyOraDB.Parameter_Name[3] = "out_cursor";

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
        private void fgrid_nike_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string org_cd = fgrid_nike[fgrid_nike.Selection.r1, 3].ToString().Trim();

                if (org_cd.Equals("DEV"))
                {
                    _temp_nike_dev = fgrid_nike[fgrid_nike.Selection.r1, 1].ToString();
                    txt_nike.Text = fgrid_nike[fgrid_nike.Selection.r1, 2].ToString();                 
                }
                else if (org_cd.Equals("PE"))
                {
                    _temp_nike_pe = fgrid_nike[fgrid_nike.Selection.r1, 1].ToString();
                    txt_nike_pe.Text = fgrid_nike[fgrid_nike.Selection.r1, 2].ToString();                
                }
                else if (org_cd.Equals("TE"))
                {
                    _temp_nike_te = fgrid_nike[fgrid_nike.Selection.r1, 1].ToString();
                    txt_nike_te.Text = fgrid_nike[fgrid_nike.Selection.r1, 2].ToString();                
                }
                else if (org_cd.Equals("CE"))
                {
                    _temp_nike_ce = fgrid_nike[fgrid_nike.Selection.r1, 1].ToString();
                    txt_nike_ce.Text = fgrid_nike[fgrid_nike.Selection.r1, 2].ToString();                
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void fgrid_pattern_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                _temp_pe_sabun = fgrid_pattern[fgrid_pattern.Selection.r1, 1].ToString();
                txt_pattern.Text = fgrid_pattern[fgrid_pattern.Selection.r1, 2].ToString();

                DataTable dt_ret = get_huser_info(_temp_ws.flg_project[_temp_ws.flg_project.Selection.r1, (int)ClassLib.TBSXE_CREATE_LOT.IxFACTORY].ToString(), _temp_pe_sabun);

                string org_cd = dt_ret.Rows[0].ItemArray[2].ToString();

                if (org_cd.Equals("102310"))      // Pattern 1
                    txt_pattern2.Text = "황정환";
                else if (org_cd.Equals("102300")) // Pattern 1 부장님
                    txt_pattern2.Text = "황정환";
                else                              // Pattern 2
                    txt_pattern2.Text = "박석수";
               
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
                    string arg_factory  = _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxFACTORY].ToString();
                    string arg_lot_no   = _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxLOT_NO].ToString();
                    string arg_lot_seq  = _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxLOT_SEQ].ToString();
                   
                    Save_huser(arg_factory, arg_lot_no, arg_lot_seq,_temp_nike_dev, _temp_nike_pe, _temp_nike_te, _temp_nike_ce, _temp_pe_sabun, _temp_te_sabun);

                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_DEV_SEQ] = _temp_nike_dev;
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_PE_SEQ] = _temp_nike_pe;
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_TE_SEQ] = _temp_nike_te;
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxNIKE_CE_SEQ] = _temp_nike_ce;
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxCDC_PE_SABUN] = _temp_pe_sabun;
                    _temp_ws.flg_project[sct_rows[i], (int)ClassLib.TBSXE_CREATE_LOT.IxCDC_TE_SABUN] = _temp_te_sabun;
                                        
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

        private void Save_huser(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_nike_dev, string arg_nike_pe, string arg_nike_te, string arg_nike_ce, string arg_pe_sabun, string arg_te_sabun)
        {
            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = "pkg_sxg_mps_01.save_huser_pop_01";

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_lot_no";
            MyOraDB.Parameter_Name[2] = "arg_lot_seq";
            MyOraDB.Parameter_Name[3] = "arg_nike_dev";
            MyOraDB.Parameter_Name[4] = "arg_nike_pe";
            MyOraDB.Parameter_Name[5] = "arg_nike_te";
            MyOraDB.Parameter_Name[6] = "arg_nike_ce";
            MyOraDB.Parameter_Name[7] = "arg_pe_sabun";
            MyOraDB.Parameter_Name[8] = "arg_te_sabun";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_lot_no;
            MyOraDB.Parameter_Values[2] = arg_lot_seq;
            MyOraDB.Parameter_Values[3] = arg_nike_dev;
            MyOraDB.Parameter_Values[4] = arg_nike_pe;
            MyOraDB.Parameter_Values[5] = arg_nike_te;
            MyOraDB.Parameter_Values[6] = arg_nike_ce;
            MyOraDB.Parameter_Values[7] = arg_pe_sabun;
            MyOraDB.Parameter_Values[8] = arg_te_sabun;

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

        
    }
}

