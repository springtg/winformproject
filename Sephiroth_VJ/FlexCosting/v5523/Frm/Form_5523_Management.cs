using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Excel;

namespace FlexCosting.v5523.Frm
{
    public partial class Form_5523_Management : COM.PCHWinForm.Form_Top
    {
        #region User Variable Define
        private COM.OraDB MyOraDB = new COM.OraDB();

        public string _head_factory         = "";
        public string _head_product_code    = "";
        public string _head_dev_code        = "";
        public string _head_product_name    = "";
        public string _head_product_type    = "";
        public string _head_product_factory = "";
        public string _head_season_cd       = "";
        public string _head_region          = "";
        public string _head_update_date     = ""; 
        public string _head_foxing          = ""; 
        public string _head_remarks         = ""; 

        private int[] copy_rows;
        private int copy_col;

        private bool change_flg = true;

        private Excel.Workbook vWB = null;
        private Excel.Worksheet vWS = null;
        private Excel.Application vApp = null;

        private int exr_PRODUCT_CODE    = 1;
        private int exr_DEV_VODE        = 2;
        private int exr_PRODUCT_NAME    = 3;
        private int exr_PRODUCT_TYPE    = 4;
        private int exr_PRODUCT_FACTORY = 5;
        private int exr_SEASON          = 6;
        private int exr_UPD_DATE        = 7;
        private int exr_REMARKS         = 19;
        private int exr_FOXING          = 20;
        private int exc_HEAD            = 4;

        private int exr_START_COMP      = 13;
        private int exc_DIVISION        = 3;
        private int exc_COMPONENT       = 4;
        private int exc_MEASUREMENT     = 5;
        private int exc_TTL             = 6;

        private string[] mtst_region;
        #endregion

        #region Constructor
        public Form_5523_Management()
        {
            InitializeComponent();            
        }
        #endregion

        #region Form Loading
        private void Form_5523_Management_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
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

        private void Init_Form()
        {
            //Title
            this.Text = "5523 Management";
            this.lbl_MainTitle.Text = "5523 Management";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFX_CBD_5523_MAIN", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.ExtendLastCol = false;                       

            fgrid_bottom.Set_Grid("SFX_CBD_5523_BOTTOM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_bottom.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_bottom.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;            
            fgrid_bottom.ExtendLastCol = false;
            fgrid_bottom.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            fgrid_bottom.AllowEditing = false;
            fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Fixed - 1, fgrid_bottom.Cols.Fixed, fgrid_bottom.Rows.Fixed - 1, fgrid_bottom.Cols.Count - 1).StyleNew.BackColor = Color.FloralWhite;
            fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Fixed - 1, fgrid_bottom.Cols.Fixed, fgrid_bottom.Rows.Fixed - 1, fgrid_bottom.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
        }

        private void Init_Control()
        {
            change_flg = false;

            FlexCosting.ClassLib.ComFunction_Cost comFnc = new FlexCosting.ClassLib.ComFunction_Cost();

            System.Data.DataTable vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_season_h, 0, 1, false, false);            
            vDT.Dispose();

            vDT = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_prod_type_h, 1, 2, false, false);
            vDT.Dispose();

            vDT = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_53");
            COM.ComCtl.Set_ComboList(vDT, cmb_foxing_h, 1, 2, false, false);
            vDT.Dispose();            
            
            tbtn_New.Enabled     = true;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            lbl_warning.Visible = false;
            _head_region = "US";
            GridSet_Material_Style();

            change_flg = true;
        }

        #endregion

        #region Form Clear
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Form_Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Form_Clear()
        {
            change_flg = false;

            txt_prod_code_h.Clear();
            txt_dev_code_h.Clear();
            txt_prod_name_h.Clear();
            cmb_prod_type_h.SelectedIndex = -1;
            txt_prod_factory_h.Clear();
            cmb_season_h.SelectedIndex = -1;
            txt_date_h.Clear();
            cmb_foxing_h.SelectedIndex = -1;
            txt_remarks_h.Clear();
            rdbtn_region_us.Checked = true;

            _head_factory         = "";
            _head_product_code    = "";
            _head_dev_code        = "";
            _head_product_name    = "";
            _head_product_type    = "";
            _head_product_factory = "";
            _head_season_cd       = "";            
            _head_update_date     = "";
            _head_foxing          = "";
            _head_remarks         = "";


            _head_region = "US";


            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
            fgrid_main.Cols.Count = (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt;
            fgrid_bottom.Rows.Count = fgrid_bottom.Rows.Fixed;
            fgrid_bottom.Cols.Count = (int)ClassLib.TBSFX_CBD_5523_MTST.IxMaxCt;
            fgrid_bottom[fgrid_bottom.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT] = "";
            fgrid_bottom[fgrid_bottom.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL        ] = "";

            GridSet_Material_Style();

            change_flg = true;
        }
        #endregion

        #region List Loading
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Pop_5523_List_Loading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        
        private void Pop_5523_List_Loading()
        {
            FlexCosting.v5523.Pop.Pop_5523_List_Loading pop = new FlexCosting.v5523.Pop.Pop_5523_List_Loading(this);

            pop.ShowDialog();

            if (pop.loading_flg)
            {
                Display_Data(); 
            }
        }

        #endregion

        #region Search Data
        

        private void Display_Data()
        {
            Clear_Data();
            Display_Head();
            Display_Tail();
            Display_Mtst();
            Caculate_Head();            
            Data_Update_Warning(false);
        }

        private void Clear_Data()
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
            fgrid_main.Cols.Count = (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt;
        }
        private void Display_Head()
        {
            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;

            string arg_region = "US";
            if (rdbtn_region_us.Checked)
                arg_region = "US";
            else if (rdbtn_region_us2nd.Checked)
                arg_region = "US2ND";
            else if (rdbtn_region_eu.Checked)
                arg_region = "EU";
            else if (rdbtn_region_mexico.Checked)
                arg_region = "MEXICO";
            else if (rdbtn_region_jp.Checked)
                arg_region = "JP";

            arg_value[3] = _head_region.Equals("") ? arg_region : _head_region;
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString(): _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;


            System.Data.DataTable dt = SELECT_SFX_CBD_5523_HEAD(arg_value);

            if (dt.Rows.Count > 0)
            {
                change_flg = false;
                txt_prod_code_h.Text = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxPRODUCT_CODE].ToString().Trim();
                string dev_code_view = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxDEV_CODE].ToString().Trim();

                try
                {
                    dev_code_view = dev_code_view.Substring(0, 4) + "-" + dev_code_view.Substring(4, dev_code_view.Length - 7) + "-" + dev_code_view.Substring(dev_code_view.Length - 3, 3);
                }
                catch
                {
 
                }

                txt_dev_code_h.Text        = dev_code_view;
                txt_prod_name_h.Text       = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxPRODUCT_NAME].ToString().Trim();
                cmb_prod_type_h.SelectedValue = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxPRODUCT_TYPE].ToString().Trim();
                txt_prod_factory_h.Text    = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxPRODUCT_FACTORY].ToString().Trim();
                cmb_season_h.SelectedValue = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxSEASON_CD].ToString().Trim();
                txt_date_h.Text            = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD].ToString().Trim();
                cmb_foxing_h.SelectedValue = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxFOXING_LIKE_BAND].ToString().Trim();
                txt_remarks_h.Text         = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREMARKS].ToString().Trim();

                string region = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREGION].ToString().Trim();

                if (region.Equals("US"))
                {
                    rdbtn_region_us.Checked = true; 
                }
                else if (region.Equals("US2ND"))
                {
                    rdbtn_region_us2nd.Checked = true;
                }
                else if (region.Equals("EU"))
                {
                    rdbtn_region_eu.Checked = true;
                }
                else if (region.Equals("MEXICO"))
                {
                    rdbtn_region_mexico.Checked = true;
                }
                else if (region.Equals("JP"))
                {
                    rdbtn_region_jp.Checked = true;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    fgrid_main.Rows.Add();

                    for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                    }

                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD).StyleNew.BackColor = Color.White;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD).StyleNew.ForeColor = Color.Black;
                    fgrid_main.Rows[fgrid_main.Rows.Fixed - 1].AllowMerging = false;
                }

                Control_ChangeEvent();
                change_flg = true;

            }            
        }
        private void Display_Tail()
        {
            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;

            string arg_region = "US";
            if (rdbtn_region_us.Checked)
                arg_region = "US";
            else if (rdbtn_region_us2nd.Checked)
                arg_region = "US2ND";
            else if (rdbtn_region_eu.Checked)
                arg_region = "EU";
            else if (rdbtn_region_mexico.Checked)
                arg_region = "MEXICO";
            else if (rdbtn_region_jp.Checked)
                arg_region = "JP";

            arg_value[3] = _head_region.Equals("") ? arg_region : _head_region;
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;

            System.Data.DataTable dt = SELECT_SFX_CBD_5523_TAIL(arg_value);

            if (dt.Rows.Count > 0)
            {
                string _seq      = "";
                int _row_start = fgrid_main.Rows.Fixed;
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string curr_seq = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!_seq.Equals(curr_seq))
                    {
                        fgrid_main.Cols.Add();
                        fgrid_main.Cols[fgrid_main.Cols.Count - 1].AllowEditing = true;                        
                        fgrid_main.Cols[fgrid_main.Cols.Count - 1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                        fgrid_main.Cols[fgrid_main.Cols.Count - 1].StyleNew.BackColor = Color.MintCream;

                        string _bom_id   = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();
                        string _style_cd = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                        if (_style_cd.Length.Equals(9))
                        {
                            _style_cd = _style_cd.Substring(6, 3);
                        }

                        fgrid_main[fgrid_main.Rows.Fixed - 3, fgrid_main.Cols.Count - 1] = "BOM";
                        fgrid_main[fgrid_main.Rows.Fixed - 2, fgrid_main.Cols.Count - 1] = _bom_id;
                        fgrid_main[fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1] = _style_cd;

                        fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1).StyleNew.BackColor = Color.Yellow;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
                        

                        _seq = curr_seq;
                        _row_start = fgrid_main.Rows.Fixed;
                    }

                    fgrid_main[_row_start++, fgrid_main.Cols.Count - 1] = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxMATERIAL_STYLE].ToString().Trim();
                }               
            }
        }
        private void Display_Mtst()
        {
            GridSet_Material_Style();
            Caculate_Material_Style();
        }
        private void Caculate_Head()
        {
            #region Total
            double value_sum = 0;

            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string measurement = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT] == null) ? "0" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();

                try
                {
                    value_sum += double.Parse(measurement);
                }
                catch
                {

                }
            }

            fgrid_bottom[fgrid_bottom.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT] = value_sum.ToString();

            #endregion

            #region Percentage


            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string measurement = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT] == null) ? "0" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();

                try
                {
                    double value_per = (value_sum.Equals(0)) ? 0 : double.Parse(measurement) / value_sum * 100;

                    fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL] = value_per.ToString("0.#0");
                }
                catch
                {
                    fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL] = "0.00";
                }
            }

            fgrid_bottom[fgrid_bottom.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL] = "100.00";
            #endregion
        }
        

        public System.Data.DataTable SELECT_SFX_CBD_5523_HEAD(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SELECT_SFX_CBD_5523_HEAD";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }
        public System.Data.DataTable SELECT_SFX_CBD_5523_TAIL(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SELECT_SFX_CBD_5523_TAIL";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Save_Data();
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

        private void Save_Data()
        {
            if (Check_Save_Data())
            {
                Create_Seq();
                Save_Data_Head();
            }
        }

        private bool Check_Save_Data()
        {
            try
            {
                if (!_head_product_code.Length.Equals(6) && !_head_product_code.Length.Equals(0))
                {
                    MessageBox.Show("Please write Product Code");
                    return false;
                }

                if (_head_dev_code.Length.Equals(0))
                {
                    MessageBox.Show("Please write Dev. Code");
                    return false;
                }

                if (_head_product_type.Length.Equals(0))
                {
                    MessageBox.Show("Please select Product Type. Code");
                    return false;
                }

                if (_head_season_cd.Length.Equals(0))
                {
                    MessageBox.Show("Please select Season. Code");
                    return false;
                }

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    string component = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS].ToString().Trim();

                    if(component.Equals(""))
                    {
                        MessageBox.Show("Please write Component");
                        fgrid_main.Select(i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void Create_Seq()
        {
            int seq = 1;

            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_SEQ] = seq++;
            }
        }
        private void Save_Data_Head()
        {
            try
            {
                if (DELETE_SFX_CBD_5523())
                {
                    if (SAVE_SFX_CBD_5523_HEAD())
                    {
                        if (SAVE_SFX_CBD_5523_TAIL())
                        {
                            if (SAVE_SFX_CBD_5523_MTST())
                            {
                                string[] arg_value = new string[5];
                                arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
                                arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
                                arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;
                                arg_value[3] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
                                arg_value[4] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;

                                System.Data.DataTable dt = GET_HEAD_COUNT(arg_value);

                                if (dt.Rows.Count > 0)
                                {
                                    string record_count = dt.Rows[0].ItemArray[0].ToString().Trim();

                                    if (record_count.Equals("1"))
                                        Create_5523_Other_Region();
                                }

                                Display_Data();
                            }
                        }

                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }

        private void Create_5523_Other_Region()
        {
            string arg_region = "US";
            if (rdbtn_region_us.Checked)
                arg_region = "US";
            else if (rdbtn_region_us2nd.Checked)
                arg_region = "US2ND";
            else if (rdbtn_region_eu.Checked)
                arg_region = "EU";
            else if (rdbtn_region_mexico.Checked)
                arg_region = "MEXICO";
            else if (rdbtn_region_jp.Checked)
                arg_region = "JP";

            string[] region = new string[5];
            region[0] = "US";
            region[1] = "US2ND";
            region[2] = "EU";
            region[3] = "MEXICO";
            region[4] = "JP";


            for (int i = 0; i < region.Length; i++)
            {
                if (!arg_region.Equals(region[i]))
                {
                    _head_region = region[i];

                    if (SAVE_SFX_CBD_5523_HEAD())
                    {
                        if (SAVE_SFX_CBD_5523_TAIL())
                        {
                            if (SAVE_SFX_CBD_5523_MTST())
                            {
 
                            }
                        }
                    }
                }
            }

            _head_region = arg_region;
        }

        private bool DELETE_SFX_CBD_5523()
        {            
            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.DELETE_SFX_CBD_5523";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";            
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = _head_factory;
            MyOraDB.Parameter_Values[1] = _head_product_code;
            MyOraDB.Parameter_Values[2] = _head_dev_code;
            MyOraDB.Parameter_Values[3] = _head_region;
            MyOraDB.Parameter_Values[4] = _head_season_cd;
            MyOraDB.Parameter_Values[5] = _head_product_type;
                

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
 
        }
        private bool SAVE_SFX_CBD_5523_HEAD()
        {
            int vcnt = 17;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SAVE_SFX_CBD_5523_HEAD";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "ARG_COMPONENT_DIV";
            MyOraDB.Parameter_Name[7] = "ARG_COMPONENT_SEQ";
            MyOraDB.Parameter_Name[8] = "ARG_COMPONENTS";
            MyOraDB.Parameter_Name[9] = "ARG_PRODUCT_NAME";            
            MyOraDB.Parameter_Name[10] = "ARG_PRODUCT_FACTORY";            
            MyOraDB.Parameter_Name[11] = "ARG_MEASUREMENT";
            MyOraDB.Parameter_Name[12] = "ARG_TTL";
            MyOraDB.Parameter_Name[13] = "ARG_FOXING_LIKE_BAND";
            MyOraDB.Parameter_Name[14] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[15] = "ARG_STATUS";
            MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";
                    
            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {                
                vRow++;               
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
            {
                MyOraDB.Parameter_Values[vcnt++] = _head_factory;
                MyOraDB.Parameter_Values[vcnt++] = _head_product_code;
                MyOraDB.Parameter_Values[vcnt++] = _head_dev_code;
                MyOraDB.Parameter_Values[vcnt++] = _head_region;
                MyOraDB.Parameter_Values[vcnt++] = _head_season_cd;
                MyOraDB.Parameter_Values[vcnt++] = _head_product_type;
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_SEQ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_SEQ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = _head_product_name;                
                MyOraDB.Parameter_Values[vcnt++] = _head_product_factory;                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = _head_foxing;
                MyOraDB.Parameter_Values[vcnt++] = _head_remarks;
                MyOraDB.Parameter_Values[vcnt++] = "N";
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;

            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;

        }
        private bool SAVE_SFX_CBD_5523_TAIL()
        {
            int vcnt = 15;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SAVE_SFX_CBD_5523_TAIL";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "ARG_COMPONENT_DIV";
            MyOraDB.Parameter_Name[7] = "ARG_COMPONENT_SEQ";
            MyOraDB.Parameter_Name[8] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[9] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[10] = "ARG_SEQ";
            MyOraDB.Parameter_Name[11] = "ARG_MATERIAL_STYLE";
            MyOraDB.Parameter_Name[12] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[13] = "ARG_STATUS";
            MyOraDB.Parameter_Name[14] = "ARG_UPD_USER";
            

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                vRow++;
            }

            int vCol = 0;
            for (int j = (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt; j < fgrid_main.Cols.Count; j++)
            {
                vCol++;
            }

            vcnt = vcnt * vRow * vCol;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            int vColCnt = 1;
            for (int col = (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt; col < fgrid_main.Cols.Count; col++)
            {
                string _bom_id = (fgrid_main[fgrid_main.Rows.Fixed - 2, col] == null) ? "" : fgrid_main[fgrid_main.Rows.Fixed - 2, col].ToString().Trim();
                string _style_cd = _head_product_code + ((fgrid_main[fgrid_main.Rows.Fixed - 1, col] == null) ? "" : fgrid_main[fgrid_main.Rows.Fixed - 1, col].ToString().Trim());

                for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
                {
                    MyOraDB.Parameter_Values[vcnt++] = _head_factory;
                    MyOraDB.Parameter_Values[vcnt++] = _head_product_code;
                    MyOraDB.Parameter_Values[vcnt++] = _head_dev_code;
                    MyOraDB.Parameter_Values[vcnt++] = _head_region;
                    MyOraDB.Parameter_Values[vcnt++] = _head_season_cd;
                    MyOraDB.Parameter_Values[vcnt++] = _head_product_type;
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_SEQ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_SEQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = _style_cd;
                    MyOraDB.Parameter_Values[vcnt++] = _bom_id;
                    MyOraDB.Parameter_Values[vcnt++] = vColCnt.ToString();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, col] == null) ? "" : fgrid_main[row, col].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = "";
                    MyOraDB.Parameter_Values[vcnt++] = "N";
                    MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
                }

                vColCnt++;
            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;

        }
        private bool SAVE_SFX_CBD_5523_MTST()
        {
            int vcnt = 14;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SAVE_SFX_CBD_5523_MTST";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2]  = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3]  = "ARG_REGION";
            MyOraDB.Parameter_Name[4]  = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5]  = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6]  = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[7]  = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[8]  = "ARG_SEQ";
            MyOraDB.Parameter_Name[9]  = "ARG_MATERIAL_STYLE";
            MyOraDB.Parameter_Name[10] = "ARG_MTST_PER";
            MyOraDB.Parameter_Name[11] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[12] = "ARG_STATUS";
            MyOraDB.Parameter_Name[13] = "ARG_UPD_USER";

            
            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }


            MTST_By_Region();

            int vRow = mtst_region.Length;
            
            int vCol = 0;
            for (int j = (int)ClassLib.TBSFX_CBD_5523_MTST.IxMaxCt; j < fgrid_bottom.Cols.Count; j++)
            {
                vCol++;
            }

            vcnt = vcnt * vRow * vCol;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            int vColCnt = 1;
            for (int col = (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt; col < fgrid_bottom.Cols.Count; col++)
            {
                string _bom_id = (fgrid_main[fgrid_main.Rows.Fixed - 2, col] == null) ? "" : fgrid_main[fgrid_main.Rows.Fixed - 2, col].ToString().Trim();
                string _style_cd = _head_product_code + ((fgrid_main[fgrid_main.Rows.Fixed - 1, col] == null) ? "" : fgrid_main[fgrid_main.Rows.Fixed - 1, col].ToString().Trim());

                for (int row = 0; row < mtst_region.Length; row++)
                {
                    MyOraDB.Parameter_Values[vcnt++] = _head_factory;
                    MyOraDB.Parameter_Values[vcnt++] = _head_product_code;
                    MyOraDB.Parameter_Values[vcnt++] = _head_dev_code;
                    MyOraDB.Parameter_Values[vcnt++] = _head_region;
                    MyOraDB.Parameter_Values[vcnt++] = _head_season_cd;
                    MyOraDB.Parameter_Values[vcnt++] = _head_product_type;
                    MyOraDB.Parameter_Values[vcnt++] = _style_cd;
                    MyOraDB.Parameter_Values[vcnt++] = _bom_id;
                    MyOraDB.Parameter_Values[vcnt++] = vColCnt.ToString();
                    MyOraDB.Parameter_Values[vcnt++] = mtst_region[row];
                    MyOraDB.Parameter_Values[vcnt++] = Get_MTST_Value(mtst_region[row], col);
                    MyOraDB.Parameter_Values[vcnt++] = "";
                    MyOraDB.Parameter_Values[vcnt++] = "N";
                    MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User; 
                }                

                vColCnt++;
            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;            

        }
        private void MTST_By_Region()
        {
            try
            {
                if (_head_region.Equals("US"))
                {
                    mtst_region = new string[4];

                    mtst_region[0] = "L";
                    mtst_region[1] = "R";
                    mtst_region[2] = "T";
                    mtst_region[3] = "O";

                }
                else if (_head_region.Equals("US2ND"))
                {
                    mtst_region = new string[4];

                    mtst_region[0] = "L";
                    mtst_region[1] = "R";
                    mtst_region[2] = "T";
                    mtst_region[3] = "O";
                }
                else if (_head_region.Equals("EU"))
                {
                    mtst_region = new string[5];

                    mtst_region[0] = "L";
                    mtst_region[1] = "CL";
                    mtst_region[2] = "R";
                    mtst_region[3] = "T";
                    mtst_region[4] = "O";

                }
                else if (_head_region.Equals("MEXICO"))
                {
                    mtst_region = new string[4];

                    mtst_region[0] = "L";                    
                    mtst_region[1] = "R";
                    mtst_region[2] = "T";
                    mtst_region[3] = "O";
                }
                else if (_head_region.Equals("JP"))
                {
                    mtst_region = new string[5];

                    mtst_region[0] = "L";
                    mtst_region[1] = "R";
                    mtst_region[2] = "P";
                    mtst_region[3] = "T";
                    mtst_region[4] = "O";
                }
            }
            catch
            {
                
            }
        }

        private string Get_MTST_Value(string arg_value, int arg_col)
        {
            double value_sum = 0;

            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string mtst = (fgrid_main[i, arg_col] == null) ? "" : fgrid_main[i, arg_col].ToString().Trim();

                if (arg_value.Equals(mtst))
                {
                    string ttl = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim();

                    try
                    {
                        value_sum += (ttl.Equals("")) ? 0 : double.Parse(ttl);
                    }
                    catch
                    {
 
                    }
                }
            }

            string result = (value_sum > 100) ? "100.00" : value_sum.ToString("#0.00");

            return result;
        }
        public System.Data.DataTable GET_HEAD_COUNT(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.GET_HEAD_COUNT";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[4] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if(Print_Check())
                    Excel_Export();
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

        private bool Print_Check()
        {
            if (lbl_warning.Visible)
            {
                MessageBox.Show("Please Save First");
                return false;
            }

            if (txt_dev_code_h.Text.Trim().Equals(""))
            {
                return false;
            }

            return true;

        }
        private void Excel_Export()
        {            
            SaveFileDialog save_file = new SaveFileDialog();
            save_file.InitialDirectory = "C:\\";
            save_file.AddExtension = true;            
            save_file.DefaultExt = "xls";
            

            if (save_file.ShowDialog() == DialogResult.OK)
            {
                string rawfile_path = System.Windows.Forms.Application.StartupPath + "\\5523.xls";

                string tempfile_path = System.Windows.Forms.Application.StartupPath + "\\" + COM.ComVar.This_User + "_" + DateTime.Now.ToString("yyyyMMdd") + ".xls";

                FileInfo raw_file = new FileInfo(rawfile_path);

                if (!raw_file.Exists)
                {
                    MessageBox.Show("File error, Sample File is not exist\r\n\r\nPleas ask System");
                    return;
                }

                raw_file.CopyTo(tempfile_path, true);

                FileInfo temp_file = new FileInfo(tempfile_path);

                if (temp_file.Exists)
                {
                    vApp = new Excel.Application();
                    vWB = (Workbook)(vApp.Workbooks.Open(tempfile_path, Type.Missing, true,
                                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                        false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                    vApp.Visible = false;
                    vApp.DisplayAlerts = false;

                    Excel_Sheet_US();
                    Excel_Sheet_US2ND();
                    Excel_Sheet_EU();
                    Excel_Sheet_MEXICO();
                    Excel_Sheet_JP();

                    vWB.SaveCopyAs(save_file.FileName);
                    vWB.Close(false, temp_file.FullName, null);

                    Excel_CloseFile();
                    temp_file.Delete();

                    if (temp_file.Exists)
                    {
                        FileInfo ffff = new FileInfo(temp_file.FullName);
                        ffff.Delete();
                    }
                    
                }
            }
        }

        private void Excel_Sheet_US()
        {
            vWS = (Excel.Worksheet)vWB.Sheets[1];

            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;
            arg_value[3] = "US";
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;


            DataSet ds = SELECT_EXCEL_DATA(arg_value);

            vWS.Cells[exr_PRODUCT_CODE   , exc_HEAD] = _head_product_code;
            vWS.Cells[exr_DEV_VODE       , exc_HEAD] = txt_dev_code_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_NAME   , exc_HEAD] = _head_product_name;
            vWS.Cells[exr_PRODUCT_TYPE   , exc_HEAD] = cmb_prod_type_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_FACTORY, exc_HEAD] = _head_product_factory;
            vWS.Cells[exr_SEASON         , exc_HEAD] = cmb_season_h.Text.Trim();
            


            #region Component Setting
            System.Data.DataTable dt_us_head = ds.Tables[0];

            vWS.Cells[exr_UPD_DATE, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD].ToString().Trim();
            vWS.Cells[exr_REMARKS,  exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREMARKS].ToString().Trim();
            vWS.Cells[exr_FOXING,   5       ] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxFOXING_LIKE_BAND].ToString().Trim();


            for (int i = 0; i < dt_us_head.Rows.Count - 1; i++)
            {
                Range vRng = vWS.get_Range(vWS.Cells[exr_START_COMP + 1, "A"], vWS.Cells[exr_START_COMP + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);                
            }

            double measurement = 0;

            for (int row = 0; row < dt_us_head.Rows.Count; row++)
            {
                vWS.Cells[exr_START_COMP + row, exc_DIVISION   ] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_COMPONENT  ] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS   ].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_MEASUREMENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT  ].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_TTL        ] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL          ].ToString().Trim() + "%";

                try
                {
                    measurement += double.Parse(dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim());
                }
                catch
                {
                    measurement += 0;
 
                }
            }

            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_MEASUREMENT] = measurement.ToString("#0.000");
            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_TTL        ] = "100.00%";
            #endregion

            #region BOM Setting
            System.Data.DataTable dt_us_tail = ds.Tables[1];

            if (dt_us_tail.Rows.Count > 0)
            {
                string seq = "";

                for (int t_row = 0; t_row < dt_us_tail.Rows.Count; t_row++)
                {
                    string seq_row = dt_us_tail.Rows[t_row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        Range vRng = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "H"]);
                        vRng.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        seq = seq_row;
                    }
                }


                Range vRng_d = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "I"]);
                vRng_d.EntireColumn.Delete(XlInsertShiftDirection.xlShiftToRight);


                seq = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                int col_count = 0;
                int row_count = 0;

                vWS.Cells[10, 7 + col_count] = "BOM";
                vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                string style_cd = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                if (style_cd.Length.Equals(9))
                    style_cd = style_cd.Substring(6, 3);
                vWS.Cells[12, 7 + col_count] = style_cd;
                

                for (int t_r = 0; t_r < dt_us_tail.Rows.Count; t_r++)
                {
                    string seq_row = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();                    

                    if (!seq_row.Equals(seq))
                    {                        
                        col_count++;
                        row_count = 0;
                        seq = seq_row;

                        vWS.Cells[10, 7 + col_count] = "BOM";
                        vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                        style_cd = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                        if (style_cd.Length.Equals(9))
                            style_cd = style_cd.Substring(6, 3);
                        vWS.Cells[12, 7 + col_count] = style_cd;
                    }

                    vWS.Cells[exr_START_COMP + row_count++, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxMATERIAL_STYLE].ToString().Trim();  
                }

            }


            
            #endregion

            #region MTST Setting
            System.Data.DataTable dt_us_mtst = ds.Tables[2];
                        
            if (dt_us_mtst.Rows.Count > 0)
            {
                string seq = dt_us_mtst.Rows[0].ItemArray[0].ToString().Trim();
                int col_count = 0;
                int row_count = 0;

                int _start_row = dt_us_head.Rows.Count + exr_START_COMP + 1;

                for (int m_r = 0; m_r < dt_us_mtst.Rows.Count; m_r++)
                {
                    string seq_row = dt_us_mtst.Rows[m_r].ItemArray[0].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;                        
                    }

                    vWS.Cells[_start_row + row_count++, 7 + col_count] = dt_us_mtst.Rows[m_r].ItemArray[4].ToString().Trim() + "%";  
                }
            }
            #endregion

            
        }
        private void Excel_Sheet_US2ND()
        {
            vWS = (Excel.Worksheet)vWB.Sheets[2];

            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;
            arg_value[3] = "US2ND";
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;

            DataSet ds = SELECT_EXCEL_DATA(arg_value);

            vWS.Cells[exr_PRODUCT_CODE, exc_HEAD] = _head_product_code;
            vWS.Cells[exr_DEV_VODE, exc_HEAD] = txt_dev_code_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_NAME, exc_HEAD] = _head_product_name;
            vWS.Cells[exr_PRODUCT_TYPE, exc_HEAD] = cmb_prod_type_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_FACTORY, exc_HEAD] = _head_product_factory;
            vWS.Cells[exr_SEASON, exc_HEAD] = cmb_season_h.Text.Trim();
            
            

            #region Component Setting
            System.Data.DataTable dt_us_head = ds.Tables[0];

            vWS.Cells[exr_UPD_DATE, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD].ToString().Trim();
            vWS.Cells[exr_REMARKS, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREMARKS].ToString().Trim();
            

            for (int i = 0; i < dt_us_head.Rows.Count - 1; i++)
            {
                Range vRng = vWS.get_Range(vWS.Cells[exr_START_COMP + 1, "A"], vWS.Cells[exr_START_COMP + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
            }

            double measurement = 0;

            for (int row = 0; row < dt_us_head.Rows.Count; row++)
            {
                vWS.Cells[exr_START_COMP + row, exc_DIVISION] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_COMPONENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_MEASUREMENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_TTL] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim() + "%";

                try
                {
                    measurement += double.Parse(dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim());
                }
                catch
                {
                    measurement += 0;

                }
            }

            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_MEASUREMENT] = measurement.ToString("#0.000");
            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_TTL] = "100.00%";
            #endregion

            #region BOM Setting
            System.Data.DataTable dt_us_tail = ds.Tables[1];

            if (dt_us_tail.Rows.Count > 0)
            {
                string seq = "";

                for (int t_row = 0; t_row < dt_us_tail.Rows.Count; t_row++)
                {
                    string seq_row = dt_us_tail.Rows[t_row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        Range vRng = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "H"]);
                        vRng.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        seq = seq_row;
                    }
                }


                Range vRng_d = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "I"]);
                vRng_d.EntireColumn.Delete(XlInsertShiftDirection.xlShiftToRight);


                seq = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                int col_count = 0;
                int row_count = 0;

                vWS.Cells[10, 7 + col_count] = "BOM";
                vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                string style_cd = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                if (style_cd.Length.Equals(9))
                    style_cd = style_cd.Substring(6, 3);
                vWS.Cells[12, 7 + col_count] = style_cd;


                for (int t_r = 0; t_r < dt_us_tail.Rows.Count; t_r++)
                {
                    string seq_row = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;

                        vWS.Cells[10, 7 + col_count] = "BOM";
                        vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                        style_cd = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                        if (style_cd.Length.Equals(9))
                            style_cd = style_cd.Substring(6, 3);
                        vWS.Cells[12, 7 + col_count] = style_cd;
                    }

                    vWS.Cells[exr_START_COMP + row_count++, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxMATERIAL_STYLE].ToString().Trim();
                }

            }



            #endregion

            #region MTST Setting
            System.Data.DataTable dt_us_mtst = ds.Tables[2];


            if (dt_us_mtst.Rows.Count > 0)
            {
                string seq = dt_us_mtst.Rows[0].ItemArray[0].ToString().Trim();
                int col_count = 0;
                int row_count = 0;

                int _start_row = dt_us_head.Rows.Count + exr_START_COMP + 1;

                for (int m_r = 0; m_r < dt_us_mtst.Rows.Count; m_r++)
                {
                    string seq_row = dt_us_mtst.Rows[m_r].ItemArray[0].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;
                    }

                    vWS.Cells[_start_row + row_count++, 7 + col_count] = dt_us_mtst.Rows[m_r].ItemArray[4].ToString().Trim() + "%";
                }
            }
            #endregion
        }
        private void Excel_Sheet_EU()
        {
            vWS = (Excel.Worksheet)vWB.Sheets[3];

            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;
            arg_value[3] = "EU";
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;

            DataSet ds = SELECT_EXCEL_DATA(arg_value);

            vWS.Cells[exr_PRODUCT_CODE, exc_HEAD] = _head_product_code;
            vWS.Cells[exr_DEV_VODE, exc_HEAD] = txt_dev_code_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_NAME, exc_HEAD] = _head_product_name;
            vWS.Cells[exr_PRODUCT_TYPE, exc_HEAD] = cmb_prod_type_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_FACTORY, exc_HEAD] = _head_product_factory;
            vWS.Cells[exr_SEASON, exc_HEAD] = cmb_season_h.Text.Trim();
            
            

            #region Component Setting
            System.Data.DataTable dt_us_head = ds.Tables[0];

            vWS.Cells[exr_UPD_DATE, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD].ToString().Trim();
            vWS.Cells[exr_REMARKS, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREMARKS].ToString().Trim();
            

            for (int i = 0; i < dt_us_head.Rows.Count - 1; i++)
            {
                Range vRng = vWS.get_Range(vWS.Cells[exr_START_COMP + 1, "A"], vWS.Cells[exr_START_COMP + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
            }

            double measurement = 0;

            for (int row = 0; row < dt_us_head.Rows.Count; row++)
            {
                vWS.Cells[exr_START_COMP + row, exc_DIVISION] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_COMPONENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_MEASUREMENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_TTL] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim() + "%";

                try
                {
                    measurement += double.Parse(dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim());
                }
                catch
                {
                    measurement += 0;

                }
            }

            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_MEASUREMENT] = measurement.ToString("#0.000");
            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_TTL] = "100.00%";
            #endregion

            #region BOM Setting
            System.Data.DataTable dt_us_tail = ds.Tables[1];

            if (dt_us_tail.Rows.Count > 0)
            {
                string seq = "";

                for (int t_row = 0; t_row < dt_us_tail.Rows.Count; t_row++)
                {
                    string seq_row = dt_us_tail.Rows[t_row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        Range vRng = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "H"]);
                        vRng.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        seq = seq_row;
                    }
                }


                Range vRng_d = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "I"]);
                vRng_d.EntireColumn.Delete(XlInsertShiftDirection.xlShiftToRight);


                seq = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                int col_count = 0;
                int row_count = 0;

                vWS.Cells[10, 7 + col_count] = "BOM";
                vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                string style_cd = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                if (style_cd.Length.Equals(9))
                    style_cd = style_cd.Substring(6, 3);
                vWS.Cells[12, 7 + col_count] = style_cd;


                for (int t_r = 0; t_r < dt_us_tail.Rows.Count; t_r++)
                {
                    string seq_row = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;

                        vWS.Cells[10, 7 + col_count] = "BOM";
                        vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                        style_cd = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                        if (style_cd.Length.Equals(9))
                            style_cd = style_cd.Substring(6, 3);
                        vWS.Cells[12, 7 + col_count] = style_cd;
                    }

                    vWS.Cells[exr_START_COMP + row_count++, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxMATERIAL_STYLE].ToString().Trim();
                }

            }



            #endregion

            #region MTST Setting
            System.Data.DataTable dt_us_mtst = ds.Tables[2];


            if (dt_us_mtst.Rows.Count > 0)
            {
                string seq = dt_us_mtst.Rows[0].ItemArray[0].ToString().Trim();
                int col_count = 0;
                int row_count = 0;

                int _start_row = dt_us_head.Rows.Count + exr_START_COMP + 1;

                for (int m_r = 0; m_r < dt_us_mtst.Rows.Count; m_r++)
                {
                    string seq_row = dt_us_mtst.Rows[m_r].ItemArray[0].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;
                    }

                    vWS.Cells[_start_row + row_count++, 7 + col_count] = dt_us_mtst.Rows[m_r].ItemArray[4].ToString().Trim() + "%";
                }
            }
            #endregion
        }
        private void Excel_Sheet_MEXICO()
        {
            vWS = (Excel.Worksheet)vWB.Sheets[4];

            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;
            arg_value[3] = "MEXICO";
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;

            DataSet ds = SELECT_EXCEL_DATA(arg_value);

            vWS.Cells[exr_PRODUCT_CODE, exc_HEAD] = _head_product_code;
            vWS.Cells[exr_DEV_VODE, exc_HEAD] = txt_dev_code_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_NAME, exc_HEAD] = _head_product_name;
            vWS.Cells[exr_PRODUCT_TYPE, exc_HEAD] = cmb_prod_type_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_FACTORY, exc_HEAD] = _head_product_factory;
            vWS.Cells[exr_SEASON, exc_HEAD] = cmb_season_h.Text.Trim();
           

            #region Component Setting
            System.Data.DataTable dt_us_head = ds.Tables[0];

            vWS.Cells[exr_UPD_DATE, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD].ToString().Trim();
            vWS.Cells[exr_REMARKS, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREMARKS].ToString().Trim();
            vWS.Cells[exr_FOXING, 5] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxFOXING_LIKE_BAND].ToString().Trim();

            for (int i = 0; i < dt_us_head.Rows.Count - 1; i++)
            {
                Range vRng = vWS.get_Range(vWS.Cells[exr_START_COMP + 1, "A"], vWS.Cells[exr_START_COMP + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
            }

            double measurement = 0;

            for (int row = 0; row < dt_us_head.Rows.Count; row++)
            {
                vWS.Cells[exr_START_COMP + row, exc_DIVISION] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_COMPONENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_MEASUREMENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_TTL] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim() + "%";

                try
                {
                    measurement += double.Parse(dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim());
                }
                catch
                {
                    measurement += 0;

                }
            }

            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_MEASUREMENT] = measurement.ToString("#0.000");
            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_TTL] = "100.00%";
            #endregion

            #region BOM Setting
            System.Data.DataTable dt_us_tail = ds.Tables[1];

            if (dt_us_tail.Rows.Count > 0)
            {
                string seq = "";

                for (int t_row = 0; t_row < dt_us_tail.Rows.Count; t_row++)
                {
                    string seq_row = dt_us_tail.Rows[t_row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        Range vRng = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "H"]);
                        vRng.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        seq = seq_row;
                    }
                }


                Range vRng_d = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "I"]);
                vRng_d.EntireColumn.Delete(XlInsertShiftDirection.xlShiftToRight);


                seq = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                int col_count = 0;
                int row_count = 0;

                vWS.Cells[10, 7 + col_count] = "BOM";
                vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                string style_cd = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                if (style_cd.Length.Equals(9))
                    style_cd = style_cd.Substring(6, 3);
                vWS.Cells[12, 7 + col_count] = style_cd;


                for (int t_r = 0; t_r < dt_us_tail.Rows.Count; t_r++)
                {
                    string seq_row = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;

                        vWS.Cells[10, 7 + col_count] = "BOM";
                        vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                        style_cd = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                        if (style_cd.Length.Equals(9))
                            style_cd = style_cd.Substring(6, 3);
                        vWS.Cells[12, 7 + col_count] = style_cd;
                    }

                    vWS.Cells[exr_START_COMP + row_count++, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxMATERIAL_STYLE].ToString().Trim();
                }

            }



            #endregion

            #region MTST Setting
            System.Data.DataTable dt_us_mtst = ds.Tables[2];


            if (dt_us_mtst.Rows.Count > 0)
            {
                string seq = dt_us_mtst.Rows[0].ItemArray[0].ToString().Trim();
                int col_count = 0;
                int row_count = 0;

                int _start_row = dt_us_head.Rows.Count + exr_START_COMP + 1;

                for (int m_r = 0; m_r < dt_us_mtst.Rows.Count; m_r++)
                {
                    string seq_row = dt_us_mtst.Rows[m_r].ItemArray[0].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;
                    }

                    vWS.Cells[_start_row + row_count++, 7 + col_count] = dt_us_mtst.Rows[m_r].ItemArray[4].ToString().Trim() + "%";
                }
            }
            #endregion
        }
        private void Excel_Sheet_JP()
        {
            vWS = (Excel.Worksheet)vWB.Sheets[5];

            string[] arg_value = new string[6];
            arg_value[0] = _head_factory.Equals("") ? COM.ComVar.This_Factory : _head_factory;
            arg_value[1] = _head_product_code.Equals("") ? txt_prod_code_h.Text.Trim() : _head_product_code;
            arg_value[2] = _head_dev_code.Equals("") ? txt_dev_code_h.Text.Trim() : _head_dev_code;
            arg_value[3] = "JP";
            arg_value[4] = _head_season_cd.Equals("") ? cmb_season_h.SelectedValue.ToString() : _head_season_cd;
            arg_value[5] = _head_product_type.Equals("") ? cmb_prod_type_h.SelectedValue.ToString() : _head_product_type;

            DataSet ds = SELECT_EXCEL_DATA(arg_value);

            vWS.Cells[exr_PRODUCT_CODE, exc_HEAD] = _head_product_code;
            vWS.Cells[exr_DEV_VODE, exc_HEAD] = txt_dev_code_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_NAME, exc_HEAD] = _head_product_name;
            vWS.Cells[exr_PRODUCT_TYPE, exc_HEAD] = cmb_prod_type_h.Text.Trim();
            vWS.Cells[exr_PRODUCT_FACTORY, exc_HEAD] = _head_product_factory;
            vWS.Cells[exr_SEASON, exc_HEAD] = cmb_season_h.Text.Trim();
           
            #region Component Setting
            System.Data.DataTable dt_us_head = ds.Tables[0];

            vWS.Cells[exr_UPD_DATE, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD].ToString().Trim();
            vWS.Cells[exr_REMARKS, exc_HEAD] = dt_us_head.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxREMARKS].ToString().Trim();
            

            for (int i = 0; i < dt_us_head.Rows.Count - 1; i++)
            {
                Range vRng = vWS.get_Range(vWS.Cells[exr_START_COMP + 1, "A"], vWS.Cells[exr_START_COMP + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
            }

            double measurement = 0;

            for (int row = 0; row < dt_us_head.Rows.Count; row++)
            {
                vWS.Cells[exr_START_COMP + row, exc_DIVISION] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_COMPONENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_MEASUREMENT] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim();
                vWS.Cells[exr_START_COMP + row, exc_TTL] = dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim() + "%";

                try
                {
                    measurement += double.Parse(dt_us_head.Rows[row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT].ToString().Trim());
                }
                catch
                {
                    measurement += 0;

                }
            }

            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_MEASUREMENT] = measurement.ToString("#0.000");
            vWS.Cells[exr_START_COMP + dt_us_head.Rows.Count, exc_TTL] = "100.00%";
            #endregion

            #region BOM Setting
            System.Data.DataTable dt_us_tail = ds.Tables[1];

            if (dt_us_tail.Rows.Count > 0)
            {
                string seq = "";

                for (int t_row = 0; t_row < dt_us_tail.Rows.Count; t_row++)
                {
                    string seq_row = dt_us_tail.Rows[t_row].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        Range vRng = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "H"]);
                        vRng.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        seq = seq_row;
                    }
                }


                Range vRng_d = vWS.get_Range(vWS.Cells[10, "H"], vWS.Cells[10, "I"]);
                vRng_d.EntireColumn.Delete(XlInsertShiftDirection.xlShiftToRight);


                seq = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                int col_count = 0;
                int row_count = 0;

                vWS.Cells[10, 7 + col_count] = "BOM";
                vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                string style_cd = dt_us_tail.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                if (style_cd.Length.Equals(9))
                    style_cd = style_cd.Substring(6, 3);
                vWS.Cells[12, 7 + col_count] = style_cd;


                for (int t_r = 0; t_r < dt_us_tail.Rows.Count; t_r++)
                {
                    string seq_row = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSEQ].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;

                        vWS.Cells[10, 7 + col_count] = "BOM";
                        vWS.Cells[11, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxBOM_ID].ToString().Trim();

                        style_cd = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxSTYLE_CD].ToString().Trim();

                        if (style_cd.Length.Equals(9))
                            style_cd = style_cd.Substring(6, 3);
                        vWS.Cells[12, 7 + col_count] = style_cd;
                    }

                    vWS.Cells[exr_START_COMP + row_count++, 7 + col_count] = dt_us_tail.Rows[t_r].ItemArray[(int)ClassLib.TBSFX_CBD_5523_TAIL.IxMATERIAL_STYLE].ToString().Trim();
                }

            }



            #endregion

            #region MTST Setting
            System.Data.DataTable dt_us_mtst = ds.Tables[2];


            if (dt_us_mtst.Rows.Count > 0)
            {
                string seq = dt_us_mtst.Rows[0].ItemArray[0].ToString().Trim();
                int col_count = 0;
                int row_count = 0;

                int _start_row = dt_us_head.Rows.Count + exr_START_COMP + 1;

                for (int m_r = 0; m_r < dt_us_mtst.Rows.Count; m_r++)
                {
                    string seq_row = dt_us_mtst.Rows[m_r].ItemArray[0].ToString().Trim();

                    if (!seq_row.Equals(seq))
                    {
                        col_count++;
                        row_count = 0;
                        seq = seq_row;
                    }

                    vWS.Cells[_start_row + row_count++, 7 + col_count] = dt_us_mtst.Rows[m_r].ItemArray[4].ToString().Trim() + "%";
                }
            }
            #endregion
        }

        public bool Excel_CloseFile()
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(vWS);                
                System.Runtime.InteropServices.Marshal.ReleaseComObject(vWB);
                vApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(vApp);
                
                vWB = null;
                vWS = null;
                vApp = null;
                return true;
            }
            catch (Exception ex)
            {
                vWB = null;
                vWS = null;
                vApp = null;

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        
        private DataSet SELECT_EXCEL_DATA(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SELECT_SFX_CBD_5523_HEAD";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            
            

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SELECT_SFX_CBD_5523_TAIL";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(false);
           

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SELECT_SFX_CBD_5523_MTST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(false);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret;
        }
        #endregion

        #region Grid Event
        private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_After_Edit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Grid_After_Edit()
        {
            int sct_row = fgrid_main.Selection.r1;
            int sct_col = fgrid_main.Selection.c1;

            int[] sct_rows = fgrid_main.Selections;


            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_main[sct_rows[i], sct_col] = fgrid_main[sct_row, sct_col]; 
            }

            Caculate_Head();
            Caculate_Material_Style();
            Data_Update_Warning(true);
        }
        #endregion

        #region ContextMenu Event
        private void mnu_insert_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Insert_Data();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }
        private void mnu_remove_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Remove_Data();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void mnu_copy_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Copy_Data();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void mnu_paste_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Paste_Data();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_add_bom_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Add_BOM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void mnu_remove_bom_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Remove_BOM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void mnu_copy_bom_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Copy_BOM_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mnu_paste_bom_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Paste_BOM_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ContextMenu_Insert_Data()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
            {
                fgrid_main.Rows.Add();
                fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD).StyleNew.BackColor = Color.White;
                fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD).StyleNew.ForeColor = Color.Black;
            }
            else
            {

                int sct_row = fgrid_main.Selection.r1;

                if (sct_row < fgrid_main.Rows.Fixed)
                    return;

                fgrid_main.Rows.Insert(sct_row + 1);

                fgrid_main.GetCellRange(sct_row + 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxDIV, sct_row + 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD).StyleNew.BackColor = Color.White;
                fgrid_main.GetCellRange(sct_row + 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxDIV, sct_row + 1, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD).StyleNew.ForeColor = Color.Black;
            }

            Data_Update_Warning(true);

        }
        private void ContextMenu_Remove_Data()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int sct_row = fgrid_main.Selection.r1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            fgrid_main.Rows.Remove(sct_row);
            Data_Update_Warning(true);
        }

        private void ContextMenu_Copy_Data()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int sct_row = fgrid_main.Selection.r1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            copy_rows = fgrid_main.Selections;
        }
        private void ContextMenu_Paste_Data()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int sct_row = fgrid_main.Selection.r1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            for (int i = 0; i < copy_rows.Length; i++)
            {
                if (sct_row + i >= fgrid_main.Rows.Count)
                    break;

                fgrid_main[sct_row + i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV] = fgrid_main[copy_rows[i], (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENT_DIV];
                fgrid_main[sct_row + i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS   ] = fgrid_main[copy_rows[i], (int)ClassLib.TBSFX_CBD_5523_HEAD.IxCOMPONENTS   ];
                fgrid_main[sct_row + i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT  ] = fgrid_main[copy_rows[i], (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMEASUREMENT  ];
                fgrid_main[sct_row + i, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL          ] = fgrid_main[copy_rows[i], (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL          ];                
            }

            Data_Update_Warning(true);
        }

        private void ContextMenu_Add_BOM()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            FlexCosting.v5523.Pop.Pop_5523_Add_Bom pop = new FlexCosting.v5523.Pop.Pop_5523_Add_Bom();

            pop.ShowDialog();

            if (pop._save_flg)
            {
                fgrid_main.Cols.Add();
                fgrid_main.Cols[fgrid_main.Cols.Count - 1].AllowEditing = true;
                fgrid_main.Cols[fgrid_main.Cols.Count - 1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                fgrid_main.Cols[fgrid_main.Cols.Count - 1].StyleNew.BackColor = Color.MintCream;

                fgrid_main[fgrid_main.Rows.Fixed - 3, fgrid_main.Cols.Count - 1] = "BOM";
                fgrid_main[fgrid_main.Rows.Fixed - 2, fgrid_main.Cols.Count - 1] = pop._bom_id;
                fgrid_main[fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1] = pop._style_cd;

                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1).StyleNew.BackColor = Color.Yellow;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

                fgrid_bottom.Cols.Add();
                fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Fixed - 1, fgrid_bottom.Cols.Count - 1).StyleNew.BackColor = Color.FloralWhite;
                fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Fixed, fgrid_bottom.Cols.Count - 1, fgrid_bottom.Rows.Count - 1, fgrid_bottom.Cols.Count - 1).StyleNew.BackColor = Color.MintCream;

                Data_Update_Warning(true);
            }
        }
        private void ContextMenu_Remove_BOM()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            if (fgrid_main.Selection.c1 <= (int)ClassLib.TBSFX_CBD_5523_HEAD.IxUPD_YMD)
                return;

            int sct_col = fgrid_main.Selection.c1;
            fgrid_main.Cols.Remove(sct_col);
            fgrid_bottom.Cols.Remove(sct_col);
            
            Data_Update_Warning(true);
        }

        private void ContextMenu_Copy_BOM_Data()
        {
            if (fgrid_main.Cols.Count.Equals((int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt))
                return;
            
            int sct_col = fgrid_main.Selection.c1;

            if (sct_col < (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt)
                return;

            copy_col = sct_col;
        }
        private void ContextMenu_Paste_BOM_Data()
        {
            if (fgrid_main.Cols.Count.Equals((int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt))
                return;

            int sct_col = fgrid_main.Selection.c1;

            if (sct_col < (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt)
                return;


            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                fgrid_main[i, sct_col] = fgrid_main[i, copy_col];                
            }

            Caculate_Material_Style();
            Data_Update_Warning(true);
        }
        #endregion

        #region control Event
        private void txt_prod_code_h_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }   
        }

        private void txt_dev_code_h_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }   
        }

        private void txt_prod_name_h_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }   
        }

        private void cmb_prod_type_h_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }   
        }        

        private void txt_prod_factory_h_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }   
        }

        private void cmb_season_h_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }   
        }

        private void cmb_foxing_h_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            } 
        }

        private void txt_remarks_h_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control_ChangeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            } 
        }


        private void Control_ChangeEvent()
        {
            _head_factory         = (_head_factory.Equals("")) ? COM.ComVar.This_Factory : _head_factory;
            _head_product_code    = txt_prod_code_h.Text.Trim();
            _head_dev_code        = txt_dev_code_h.Text.Trim().Replace("-", "");
            _head_product_name    = txt_prod_name_h.Text.Trim();
            _head_product_type    = (cmb_prod_type_h.SelectedValue == null) ? "" : cmb_prod_type_h.SelectedValue.ToString();
            _head_product_factory = txt_prod_factory_h.Text.Trim();
            _head_season_cd       = (cmb_season_h.SelectedValue == null) ? "" : cmb_season_h.SelectedValue.ToString();
            _head_update_date     = txt_date_h.Text.Trim();
            _head_foxing          = (cmb_foxing_h.SelectedValue == null) ? "" : cmb_foxing_h.SelectedValue.ToString();
            _head_remarks         = txt_remarks_h.Text.Trim();

            Data_Update_Warning(true);
        }

        private void Data_Update_Warning(bool arg_bool)
        {
            if (!change_flg)
                return;

            lbl_warning.Visible = arg_bool;
        }
        #endregion        

        #region RadioButton Event
        private void rdbtn_region_us_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!change_flg)
                    return;

                if (rdbtn_region_us.Checked)
                {
                    if (_head_dev_code.Equals(""))
                        return;
                    
                    _head_region = "US";
                    Display_Data();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdbtn_region_us2nd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!change_flg)
                    return;

                if (rdbtn_region_us2nd.Checked)
                {
                    if (_head_dev_code.Equals(""))
                        return;

                    _head_region = "US2ND";
                    Display_Data();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdbtn_region_eu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!change_flg)
                    return;

                if (rdbtn_region_eu.Checked)
                {
                    if (_head_dev_code.Equals(""))
                        return;

                    _head_region = "EU";
                    Display_Data();                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdbtn_region_mexico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!change_flg)
                    return;

                if (rdbtn_region_mexico.Checked)
                {
                    if (_head_dev_code.Equals(""))
                        return;

                    _head_region = "MEXICO";
                    Display_Data();                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdbtn_region_jp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!change_flg)
                    return;

                if (rdbtn_region_jp.Checked)
                {
                    if (_head_dev_code.Equals(""))
                        return;

                    _head_region = "JP";
                    Display_Data();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GridSet_Material_Style()
        {

            fgrid_bottom.Rows.Count = fgrid_bottom.Rows.Fixed;

            if (rdbtn_region_us.Checked)
            {
                string[] arg_mtst = new string[4];
                arg_mtst[0] = "L";
                arg_mtst[1] = "R";
                arg_mtst[2] = "T";
                arg_mtst[3] = "O";

                string[] arg_mtst_name = new string[4];
                arg_mtst_name[0] = "LEATHER";
                arg_mtst_name[1] = "SYNTHETIC";
                arg_mtst_name[2] = "TEXTILE";
                arg_mtst_name[3] = "OTHER";

                for (int i = 0; i < arg_mtst.Length; i++)
                {
                    fgrid_bottom.Rows.Add();

                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV         ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxFACTORY     ] = _head_factory;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxPRODUCT_CODE] = _head_product_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDEV_CODE    ] = _head_dev_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxREGION      ] = _head_region;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_01     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_02     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_NAME  ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_03     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_04     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_05     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_06     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_VALUE ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE   ] = arg_mtst_name[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD] = arg_mtst[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_08     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_09     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_10     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11     ] = "";
                    
                    System.Drawing.Font ft = new System.Drawing.Font("Verdana", 8);                    
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.BackColor = Color.White;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.ForeColor = Color.Black;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.Font = ft;
                }
            }
            else if (rdbtn_region_us2nd.Checked)
            {
                string[] arg_mtst = new string[4];
                arg_mtst[0] = "L";
                arg_mtst[1] = "R";
                arg_mtst[2] = "T";
                arg_mtst[3] = "O";

                string[] arg_mtst_name = new string[4];
                arg_mtst_name[0] = "LEATHER";
                arg_mtst_name[1] = "SYNTHETIC";
                arg_mtst_name[2] = "TEXTILE";
                arg_mtst_name[3] = "OTHER";

                for (int i = 0; i < arg_mtst.Length; i++)
                {
                    fgrid_bottom.Rows.Add();

                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV         ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxFACTORY     ] = _head_factory;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxPRODUCT_CODE] = _head_product_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDEV_CODE    ] = _head_dev_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxREGION      ] = _head_region;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_01     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_02     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_NAME  ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_03     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_04     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_05     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_06     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_VALUE ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE   ] = arg_mtst_name[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD] = arg_mtst[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_08     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_09     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_10     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11     ] = "";

                    System.Drawing.Font ft = new System.Drawing.Font("Verdana", 8);
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.BackColor = Color.White;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.ForeColor = Color.Black;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.Font = ft;
                }
            }
            else if (rdbtn_region_eu.Checked)
            {
                string[] arg_mtst = new string[5];
                arg_mtst[0] = "L";
                arg_mtst[1] = "CL";
                arg_mtst[2] = "R";
                arg_mtst[3] = "T";
                arg_mtst[4] = "O";

                string[] arg_mtst_name = new string[5];
                arg_mtst_name[0] = "LEATHER";
                arg_mtst_name[1] = "COATED LEATHER";
                arg_mtst_name[2] = "SYNTHETIC";
                arg_mtst_name[3] = "TEXTILE";
                arg_mtst_name[4] = "OTHER";

                for (int i = 0; i < arg_mtst.Length; i++)
                {
                    fgrid_bottom.Rows.Add();

                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV         ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxFACTORY     ] = _head_factory;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxPRODUCT_CODE] = _head_product_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDEV_CODE    ] = _head_dev_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxREGION      ] = _head_region;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_01     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_02     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_NAME  ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_03     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_04     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_05     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_06     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_VALUE ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE   ] = arg_mtst_name[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD] = arg_mtst[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_08     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_09     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_10     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11     ] = "";

                    System.Drawing.Font ft = new System.Drawing.Font("Verdana", 8);
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.BackColor = Color.White;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.ForeColor = Color.Black;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.Font = ft;
                }
            }
            else if (rdbtn_region_mexico.Checked)
            {
                string[] arg_mtst = new string[4];
                arg_mtst[0] = "L";
                arg_mtst[1] = "R";
                arg_mtst[2] = "T";
                arg_mtst[3] = "O";

                string[] arg_mtst_name = new string[4];
                arg_mtst_name[0] = "LEATHER";
                arg_mtst_name[1] = "SYNTHETIC";
                arg_mtst_name[2] = "TEXTILE";
                arg_mtst_name[3] = "OTHER";

                for (int i = 0; i < arg_mtst.Length; i++)
                {
                    fgrid_bottom.Rows.Add();

                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV         ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxFACTORY     ] = _head_factory;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxPRODUCT_CODE] = _head_product_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDEV_CODE    ] = _head_dev_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxREGION      ] = _head_region;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_01     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_02     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_NAME  ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_03     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_04     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_05     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_06     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_VALUE ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE   ] = arg_mtst_name[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD] = arg_mtst[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_08     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_09     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_10     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11     ] = "";

                    System.Drawing.Font ft = new System.Drawing.Font("Verdana", 8);
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.BackColor = Color.White;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.ForeColor = Color.Black;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.Font = ft;
                }
            }
            else if (rdbtn_region_jp.Checked)
            {
                string[] arg_mtst = new string[5];
                arg_mtst[0] = "L";
                arg_mtst[1] = "R";
                arg_mtst[2] = "P";
                arg_mtst[3] = "T";
                arg_mtst[4] = "O";
                

                string[] arg_mtst_name = new string[5];
                arg_mtst_name[0] = "LEATHER";
                arg_mtst_name[1] = "RUBBER";
                arg_mtst_name[2] = "PLASTIC";
                arg_mtst_name[3] = "TEXTILE";
                arg_mtst_name[4] = "OTHER";

                for (int i = 0; i < arg_mtst.Length; i++)
                {
                    fgrid_bottom.Rows.Add();

                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV         ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxFACTORY     ] = _head_factory;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxPRODUCT_CODE] = _head_product_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDEV_CODE    ] = _head_dev_code;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxREGION      ] = _head_region;
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_01     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_02     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_NAME  ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_03     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_04     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_05     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_06     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxTOTAL_VALUE ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE   ] = arg_mtst_name[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD] = arg_mtst[i];
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_08     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_09     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_10     ] = "";
                    fgrid_bottom[fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11     ] = "";

                    System.Drawing.Font ft = new System.Drawing.Font("Verdana", 8);
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.BackColor = Color.White;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.ForeColor = Color.Black;
                    fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxDIV, fgrid_bottom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_MTST.IxNULL_11).StyleNew.Font = ft;
                }
            }

            fgrid_bottom.Cols.Count = (int)ClassLib.TBSFX_CBD_5523_MTST.IxMaxCt;

            for (int j = (int)ClassLib.TBSFX_CBD_5523_HEAD.IxMaxCt; j < fgrid_main.Cols.Count; j++)
            {
                fgrid_bottom.Cols.Add();
                fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Fixed - 1, fgrid_bottom.Cols.Count - 1).StyleNew.BackColor = Color.FloralWhite;
                fgrid_bottom.GetCellRange(fgrid_bottom.Rows.Fixed, fgrid_bottom.Cols.Count - 1, fgrid_bottom.Rows.Count - 1, fgrid_bottom.Cols.Count - 1).StyleNew.BackColor = Color.MintCream;
            }
        }
        private void Caculate_Material_Style()
        {
            int record_count = fgrid_main.Rows.Count - fgrid_main.Rows.Fixed;
            int region_count = fgrid_bottom.Rows.Count - fgrid_bottom.Rows.Fixed;
            string[] _region = new string[region_count];
            
            for (int i = 0; i < _region.Length; i++)
            {
                _region[i] = fgrid_bottom[fgrid_bottom.Rows.Fixed + i, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD].ToString().Trim();
            }

            for (int col = (int)ClassLib.TBSFX_CBD_5523_MTST.IxMaxCt; col < fgrid_main.Cols.Count; col++)
            {
                double[] _region_value = new double[region_count];

                for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
                {
                    string main_region = (fgrid_main[row, col] == null) ? "" : fgrid_main[row, col].ToString().Trim();
                    string main_ttl = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_5523_HEAD.IxTTL].ToString().Trim();

                    for (int i = 0; i < _region.Length; i++)
                    {
                        if (_region[i].Equals(main_region))
                        {
                            _region_value[i] += (main_ttl.Equals(""))? 0: double.Parse(main_ttl);
                        }                        
                    }
                }

                for (int b_row = fgrid_bottom.Rows.Fixed; b_row < fgrid_bottom.Rows.Count; b_row++)
                {
                    string b_mtst = fgrid_bottom[b_row, (int)ClassLib.TBSFX_CBD_5523_MTST.IxMAT_STYLE_CD].ToString().Trim();
                    double b_mtst_value = 0;

                    for (int b_region = 0; b_region < _region.Length; b_region++)
                    {
                        if(b_mtst.Equals(_region[b_region]))
                        {
                            b_mtst_value = _region_value[b_region];
                        }
                    }                    

                    fgrid_bottom[b_row, col] = (b_mtst_value > 100) ? "100.00" : b_mtst_value.ToString("#0.00");
                }
            }
        }
        #endregion

        
    }
}

