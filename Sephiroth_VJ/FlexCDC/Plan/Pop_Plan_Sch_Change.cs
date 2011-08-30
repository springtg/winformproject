using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Plan
{
    public partial class Pop_Plan_Sch_Change : COM.PCHWinForm.Pop_Large_B
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private Plan.Form_Plan_sch _main_form = null;
        private string _form_type = "";
        #endregion
        
        #region 리소스 정의
        public Pop_Plan_Sch_Change()
        {
            InitializeComponent();
        }
        public Pop_Plan_Sch_Change(Plan.Form_Plan_sch arg_form, string arg_form_type)
        {
            InitializeComponent();

            _main_form = arg_form;
            _form_type = arg_form_type;
        }  
        #endregion

        #region Form Loading
        private void Pop_Plan_Sch_Change_Load(object sender, EventArgs e)
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
            //1. Title Setting
            this.Text = "PCC_MPS Data Change";
            this.lbl_MainTitle.Text = "PCC_MPS Data Change";
            ClassLib.ComFunction.SetLangDic(this);            

            //2. tbtn Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            //3. Grid Setting            
            flg_mps_pop.Set_Grid_CDC("SXG_MPS_POP", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            flg_mps_pop.Set_Action_Image(img_Action);
            flg_mps_pop.Rows.Count = flg_mps_pop.Rows.Fixed;
            flg_mps_pop.ExtendLastCol = false;            
            
            Grid_Data_Setting();
            Control_Setting();

            flg_mps_pop.Select(flg_mps_pop.Rows.Fixed, (int)ClassLib.TBSXO_OUT_SCH_POP.IxMODEL);
            //Grid_click(flg_mps_pop.Rows.Fixed);
            
        }
        private void Grid_Data_Setting()
        {

            int[] sct_rows = _main_form.flg_sch.Selections;

            string _sort_no = _main_form.flg_sch[sct_rows[0], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

            if (_sort_no.Equals("99"))
            {                
                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _sort_no_row = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

                    if (_sort_no_row.Equals("99"))
                    {
                        #region 1 Level 일때

                        string _status = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSTATUS].ToString().Trim();
                        if (!_status.Equals("C"))
                        {
                            flg_mps_pop.Rows.Add();

                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDIVISION]    = "";
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxFACTORY]     = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxFACTORY].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxMODEL]       = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxMODEL_NAME].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCOLOR_VER]   = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxCOLOR_VER].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxBOM_STYLE]   = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxBOM_STYLECD].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxSAMPLE_TYPE] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSAMPLE_TYPE].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxUSER]        = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxCDC_DEV_NAME].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_NAME]     = "ETS";
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxQTY]         = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_QTY].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO]      = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ]     = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ]     = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxDAY_SEQ].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD]     = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLINE_CD].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCMP_CD]      = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxCMP_CD].ToString();
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_CD]       = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxOP_CD].ToString();                            
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxUPS_USER]    = "";
                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxREMARKS]     = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxREMARKS].ToString();
                        }
                        #endregion
                    }
                }
            }
            else
            {
                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _sort_no_row = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

                    if (!_sort_no_row.Equals("99"))
                    {
                        #region 2 Level 일때
                        

                            if (_main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSTATUS].ToString() != "C")
                            {
                                string arg_lot_no = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                                string arg_lot_seq = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();
                                string arg_ups_user = "";

                                flg_mps_pop.Rows.Add();

                                for (int j = _main_form.flg_sch.Rows.Fixed + 1; j < _main_form.flg_sch.Rows.Count; j++)
                                {
                                    if (arg_lot_no == _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString() && arg_lot_seq == _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString())
                                    {
                                        if (_main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString() == "99")
                                        {
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDIVISION] = "";
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxFACTORY] = _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxFACTORY].ToString();
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxMODEL] = _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxMODEL_NAME].ToString();
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCOLOR_VER] = _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxCOLOR_VER].ToString();
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxBOM_STYLE] = _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxBOM_STYLECD].ToString();
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxSAMPLE_TYPE] = _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxSAMPLE_TYPE].ToString();
                                            flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxUSER] = _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxCDC_DEV_NAME].ToString();
                                        }
                                        else
                                        {
                                            string user = (_main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxCDC_DEV_NAME] == null) ? "" : _main_form.flg_sch[j, (int)ClassLib.TBSXO_OUT_SCH.IxCDC_DEV_NAME].ToString().Trim();
                                            if (user != "")
                                            {
                                                arg_ups_user = user;
                                                break;
                                            }
                                        }
                                    }
                                }

                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_NAME] = get_cmp_cd(sct_rows[i]).Rows[0].ItemArray[2].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxDAY_SEQ].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLINE_CD].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCMP_CD] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxCMP_CD].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_CD] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxOP_CD].ToString();

                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxUPS_USER] = arg_ups_user;
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxREMARKS] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxREMARKS].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_SCH_POP.IxQTY] = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_QTY].ToString();
                            }
                        
                        #endregion
                    }
                }                
            }
        }
        private void Control_Setting()
        {
            int sct_row = _main_form.flg_sch.Selection.r1;

            if (_form_type.Equals("DATE"))
            {
                string work_date = _main_form.flg_sch[sct_row, (int)ClassLib.TBSXO_OUT_SCH.IxWORK_DATE].ToString();

                try
                {
                    int year = int.Parse(work_date.Substring(0, 4));
                    int month = int.Parse(work_date.Substring(4, 2));
                    int day = int.Parse(work_date.Substring(6, 2));

                    DateTime datetime = new DateTime(year, month, day);
                    dtp_date.Value = datetime;
                }
                catch
                {
                    dtp_date.Value = DateTime.Now; 
                }

                dtp_date.Enabled = true;
                txt_qty.Enabled = false;
                txt_remarks.Enabled = true;
            }
            else
            {
                string work_qty = _main_form.flg_sch[sct_row, (int)ClassLib.TBSXO_OUT_SCH.IxWORK_QTY].ToString();
                txt_qty.Text = work_qty;

                dtp_date.Enabled = false;
                txt_qty.Enabled = true;
                txt_remarks.Enabled = true;
            }

            string _level = _main_form.flg_sch[sct_row, (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString();
            if (_level.Equals("99"))
            {
                lbl_ets.Text = "ETS";
            }
            else
            {
                lbl_ets.Text = flg_mps_pop[flg_mps_pop.Rows.Fixed, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_NAME].ToString();
            }
        }

        private DataTable get_cmp_cd(int arg_row)
        {

            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_02_select.get_sxg_op_cd";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_op_cd";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = _main_form.flg_sch[arg_row, (int)ClassLib.TBSXO_OUT_SCH.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = _main_form.flg_sch[arg_row, (int)ClassLib.TBSXO_OUT_SCH.IxOP_CD].ToString();
            MyOraDB.Parameter_Values[2] = "";


            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion
       
        #region Grid Event
        private void flg_mps_pop_Click(object sender, EventArgs e)
        {
            int sct_row = flg_mps_pop.Selection.r1;

            Grid_click(sct_row);
        }
        private void Grid_click(int arg_row)
        {
            lbl_ets.Text      = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_NAME].ToString();            
        }

        
        #endregion        

        #region Save
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (_main_form != null)
                {
                    #region MPS 에서 띄울때
                    string holiday = "N";
                    string select_date  = dtp_date.Value.ToString("yyyyMMdd");

                    for (int i = flg_mps_pop.Rows.Fixed; i < flg_mps_pop.Rows.Count; i++)
                    {
                        if (_form_type.Equals("DATE"))
                        {
                            string _level = _main_form.flg_sch[_main_form.flg_sch.Selection.r1, (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

                            if (_level == "99")
                            {
                                holiday = SAVE_DATE_01(i);
                            }
                            else
                            {
                                holiday = SAVE_DATE_02(i);
                            }
                        }
                        else
                        {
                            string _level = _main_form.flg_sch[_main_form.flg_sch.Selection.r1, (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

                            if (_level == "99")
                            {
                                holiday = SAVE_QTY_01(i);
                            }
                            else
                            {
                                holiday = SAVE_QTY_02(i);
                            } 
                        }
                        

                        if (holiday == "Y")
                        {
                            MessageBox.Show("This is Holiday");
                            return;
                        }
                        else
                        {                            
                            Save_Setting(i);
                        }
                    }                    
                    #endregion

                }
                

                this.Close();
            }
            catch
            {
 
            }                
        }

        private void Save_Setting(int arg_row)
        {
            string lot_no = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO].ToString();
            string lot_seq = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ].ToString();
            string day_seq = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ].ToString();
            string line_cd = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD].ToString();
            string cmp_cd = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCMP_CD].ToString();
            string op_cd = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_CD].ToString();
            string work_date = dtp_date.Value.ToString("yyyyMMdd");
            string work_qty = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxQTY].ToString();
            string remarks = txt_remarks.Text;

            if (_form_type.Equals("DATE"))
            {
                int cfm_date = int.Parse(_main_form.confirm_date);
                int limit_date = int.Parse(_main_form.limit_date);

                int[] sct_rows = _main_form.flg_sch.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _level = _main_form.flg_sch[_main_form.flg_sch.Selection.r1, (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

                    if (_level == "99")
                    {
                        #region 1 Level
                        if (_main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString() == "99")
                        {
                            string p_lot_no = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                            string p_lot_seq = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();
                            string p_day_seq = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxDAY_SEQ].ToString();
                            string p_line_cd = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLINE_CD].ToString();
                            string p_cmp_cd = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxCMP_CD].ToString();
                            string p_op_cd = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxOP_CD].ToString();
                            string p_old_date = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_DATE].ToString();


                            if (lot_no == p_lot_no && lot_seq == p_lot_seq && day_seq == p_day_seq && line_cd == p_line_cd && cmp_cd == p_cmp_cd && op_cd == p_op_cd)
                            {
                                _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_DATE] = work_date;
                                _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_QTY] = work_qty;
                                _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxREMARKS] = remarks;

                                for (int j = (int)ClassLib.TBSXO_OUT_SCH.IxPCARD_STATUS + 1; j < _main_form.flg_sch.Cols.Count; j++)
                                {
                                    string p_date = _main_form.flg_sch[_main_form.flg_sch.Rows.Fixed - 2, j].ToString() + _main_form.flg_sch[_main_form.flg_sch.Rows.Fixed - 1, j].ToString();


                                    if (p_old_date == p_date)
                                    {
                                        _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.White;
                                        _main_form.flg_sch[sct_rows[i], j] = "";

                                        if (int.Parse(p_old_date) <= limit_date)
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.Orange;
                                        }
                                        if (int.Parse(p_old_date) <= cfm_date)
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_confirm;
                                        }
                                    }

                                    if (p_date == work_date)
                                    {
                                        string status = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSTATUS].ToString();
                                        string p_status = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxPCARD_STATUS].ToString();

                                        if (status.Equals("C"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_confirm;
                                        }
                                        else if (status.Equals("Y") || status.Equals("U"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_nomal;
                                        }

                                        if (p_status.Equals("Y"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_ing;
                                        }
                                        else if (p_status.Equals("C"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_complete;
                                        }

                                        _main_form.flg_sch[sct_rows[i], j] = work_qty;
                                    }
                                }
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        #region 2 Level
                        if (_main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString() != "99")
                        {
                            string p_lot_no = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                            string p_lot_seq = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();
                            string p_day_seq = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxDAY_SEQ].ToString();
                            string p_line_cd = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLINE_CD].ToString();
                            string p_cmp_cd = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxCMP_CD].ToString();
                            string p_op_cd = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxOP_CD].ToString();
                            string p_old_date = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_DATE].ToString();

                            if (lot_no == p_lot_no && lot_seq == p_lot_seq && day_seq == p_day_seq && line_cd == p_line_cd && cmp_cd == p_cmp_cd && op_cd == p_op_cd)
                            {
                                _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_DATE] = work_date;
                                _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxWORK_QTY] = work_qty;
                                _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxREMARKS] = remarks;

                                for (int j = (int)ClassLib.TBSXO_OUT_SCH.IxPCARD_STATUS + 1; j < _main_form.flg_sch.Cols.Count; j++)
                                {
                                    string p_date = _main_form.flg_sch[_main_form.flg_sch.Rows.Fixed - 2, j].ToString() + _main_form.flg_sch[_main_form.flg_sch.Rows.Fixed - 1, j].ToString();


                                    if (p_old_date == p_date)
                                    {
                                        _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.White;
                                        _main_form.flg_sch[sct_rows[i], j] = "";

                                        if (int.Parse(p_old_date) <= limit_date)
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.Orange;
                                        }
                                        if (int.Parse(p_old_date) <= cfm_date)
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_confirm;
                                        }
                                    }

                                    if (p_date == work_date)
                                    {
                                        string status = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSTATUS].ToString();
                                        string p_status = _main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxPCARD_STATUS].ToString();

                                        if (status.Equals("C"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_confirm;
                                        }
                                        else if (status.Equals("Y") || status.Equals("U"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_nomal;
                                        }

                                        if (p_status.Equals("Y"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_ing;
                                        }
                                        else if (p_status.Equals("C"))
                                        {
                                            _main_form.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = _main_form.color_complete;
                                        }

                                        _main_form.flg_sch[sct_rows[i], j] = work_qty;
                                    }
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            else
            {
                int[] sct_rows = _main_form.flg_sch.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _level = _main_form.flg_sch[_main_form.flg_sch.Selection.r1, (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString().Trim();

                    if (_level == "99")
                    {
                        #region 1 Level
                        if (_main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString() == "99")
                        {
                            _main_form.flg_sch[sct_rows[i], _main_form.flg_sch.Selection.c1] = txt_qty.Text.Trim();                                    
                        }
                        #endregion
                    }
                    else
                    {
                        #region 2 Level
                        if (_main_form.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString() != "99")
                        {
                            _main_form.flg_sch[sct_rows[i], _main_form.flg_sch.Selection.c1] = txt_qty.Text.Trim();    
                        }
                        #endregion
                    }
                } 
            }
            
        }
        private string SAVE_DATE_01(int arg_row)
        {
            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_LEV_01_DATE";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY"; 
            MyOraDB.Parameter_Name[1]  = "ARG_LOT_NO";   
            MyOraDB.Parameter_Name[2]  = "ARG_LOT_SEQ";    
            MyOraDB.Parameter_Name[3]  = "ARG_DAY_SEQ";     
            MyOraDB.Parameter_Name[4]  = "ARG_LINE_CD";
            MyOraDB.Parameter_Name[5]  = "ARG_PLAN_YMD";
            MyOraDB.Parameter_Name[6]  = "ARG_REMARKS";      
            MyOraDB.Parameter_Name[7]  = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[8]  = "OUT_CURSOR";      
           
            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;           
            
            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[2] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[3] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD].ToString(); 
            MyOraDB.Parameter_Values[5] = dtp_date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[6] = txt_remarks.Text;
            MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }
        private string SAVE_QTY_01(int arg_row)
        {
            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_LEV_01_QTY";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY"; 
            MyOraDB.Parameter_Name[1]  = "ARG_LOT_NO";   
            MyOraDB.Parameter_Name[2]  = "ARG_LOT_SEQ";    
            MyOraDB.Parameter_Name[3]  = "ARG_DAY_SEQ";     
            MyOraDB.Parameter_Name[4]  = "ARG_LINE_CD";
            MyOraDB.Parameter_Name[5]  = "ARG_PLAN_QTY";
            MyOraDB.Parameter_Name[6]  = "ARG_REMARKS";      
            MyOraDB.Parameter_Name[7]  = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[8]  = "OUT_CURSOR";      
           
            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;           
            
            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[2] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[3] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD].ToString();
            MyOraDB.Parameter_Values[5] = txt_qty.Text.Trim();
            MyOraDB.Parameter_Values[6] = txt_remarks.Text;
            MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }

        private string SAVE_DATE_02(int arg_row)
        {
            MyOraDB.ReDim_Parameter(12);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_LEV_02_DATE";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
            MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
            MyOraDB.Parameter_Name[6] = "ARG_CMP_CD";
            MyOraDB.Parameter_Name[7] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[8] = "ARG_DIR_YMD";            
            MyOraDB.Parameter_Name[9] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

            //03. DATA TYPE 정의
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
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = "U";
            MyOraDB.Parameter_Values[1] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[2] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[3] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[5] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD].ToString();
            MyOraDB.Parameter_Values[6] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCMP_CD].ToString();
            MyOraDB.Parameter_Values[7] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_CD].ToString();
            MyOraDB.Parameter_Values[8] = dtp_date.Value.ToString("yyyyMMdd");            
            MyOraDB.Parameter_Values[9] = txt_remarks.Text;
            MyOraDB.Parameter_Values[10] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[11] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }
        private string SAVE_QTY_02(int arg_row)
        {
            MyOraDB.ReDim_Parameter(12);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_LEV_02_QTY";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
            MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
            MyOraDB.Parameter_Name[6] = "ARG_CMP_CD";
            MyOraDB.Parameter_Name[7] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[8] = "ARG_DIR_QTY";
            MyOraDB.Parameter_Name[9] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

            //03. DATA TYPE 정의
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
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = "U";
            MyOraDB.Parameter_Values[1] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[2] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[3] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[5] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxLINE_CD].ToString();
            MyOraDB.Parameter_Values[6] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxCMP_CD].ToString();
            MyOraDB.Parameter_Values[7] = flg_mps_pop[arg_row, (int)ClassLib.TBSXO_OUT_SCH_POP.IxOP_CD].ToString();
            MyOraDB.Parameter_Values[8] = txt_qty.Text.Trim();
            MyOraDB.Parameter_Values[9] = txt_remarks.Text;
            MyOraDB.Parameter_Values[10] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[11] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }
        #endregion
               
    }
}

