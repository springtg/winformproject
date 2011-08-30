using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Purchase
{
    public partial class Pop_Pur_Request_Detail : COM.PCHWinForm.Pop_Large_B
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        Form_Pur_Request _main_form = null;
        #endregion

        #region 생성자 
        public Pop_Pur_Request_Detail()
        {
            InitializeComponent();
        }
        public Pop_Pur_Request_Detail(Form_Pur_Request arg_form)
        {
            _main_form = arg_form;
            InitializeComponent();
        }
        #endregion
        
        #region Form Loading
        private void Pop_Pur_Request_Detail_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        private void Init_Form()
        {
            this.Text = "Material Information";
            this.lbl_MainTitle.Text = "Material Information";

            //ComboBox Setting
            DataTable dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_CDC_Factory, "SXC07");
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_search, 1, 1, true, 0, 200);
            cmb_search.SelectedIndex = 0;

            #region Grid Setting
            fgrid_part.Set_Grid_CDC("SXP_REQ_POP_PART", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_part.Set_Action_Image(img_Action);
            fgrid_part.AllowDragging = AllowDraggingEnum.None;
            fgrid_part.AllowSorting = AllowSortingEnum.None;
            fgrid_part.ExtendLastCol = false;

            fgrid_mat.Set_Grid_CDC("SXP_REQ_POP_MAT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_mat.Set_Action_Image(img_Action);
            fgrid_mat.AllowDragging = AllowDraggingEnum.None;
            fgrid_mat.AllowSorting = AllowSortingEnum.None;
            fgrid_mat.ExtendLastCol = false;

            fgrid_color.Set_Grid_CDC("SXP_REQ_POP_COLOR", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_color.Set_Action_Image(img_Action);
            fgrid_color.AllowDragging = AllowDraggingEnum.None;
            fgrid_color.AllowSorting = AllowSortingEnum.None;
            fgrid_color.ExtendLastCol = false;

            fgrid_unit.Set_Grid_CDC("SXP_REQ_POP_UNIT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_unit.Set_Action_Image(img_Action);
            fgrid_unit.AllowDragging = AllowDraggingEnum.None;
            fgrid_unit.AllowSorting = AllowSortingEnum.None;
            fgrid_unit.ExtendLastCol = false;

            fgrid_vendor.Set_Grid_CDC("SXP_REQ_POP_VENDOR", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_vendor.Set_Action_Image(img_Action);
            fgrid_vendor.AllowDragging = AllowDraggingEnum.None;
            fgrid_vendor.AllowSorting = AllowSortingEnum.None;
            fgrid_vendor.ExtendLastCol = false;
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;            

            txt_color_cd.CharacterCasing   = CharacterCasing.Upper;
            txt_color_name.CharacterCasing = CharacterCasing.Upper;
            txt_mat_code.CharacterCasing   = CharacterCasing.Upper;
            txt_mat_name.CharacterCasing   = CharacterCasing.Upper;
            txt_part_name.CharacterCasing  = CharacterCasing.Upper;
            txt_part_no.CharacterCasing    = CharacterCasing.Upper;
            txt_search.CharacterCasing     = CharacterCasing.Upper;
            txt_spec.CharacterCasing       = CharacterCasing.Upper;            
            txt_ven_name.CharacterCasing   = CharacterCasing.Upper;
            txt_ven_seq.CharacterCasing    = CharacterCasing.Upper;

            txt_color_cd.Enabled   = false;  
            txt_color_name.Enabled = false;  
            txt_mat_code.Enabled   = false;    
            txt_mat_name.Enabled   = false;    
            txt_part_name.Enabled  = false;   
            txt_part_no.Enabled    = false;                 
            txt_spec.Enabled       = false;        
            txt_unit.Enabled       = false;        
            txt_ven_name.Enabled   = false;
            txt_ven_seq.Enabled    = false;

            txt_search.Focus();
            #endregion

            
            Default_Data_Setting();
        }
        private void Default_Data_Setting()
        {
            if (!_main_form.Equals(null))
            {
                int sct_row = _main_form.fgrid_detail.Selection.r1;
                int sct_col = _main_form.fgrid_detail.Selection.c1;

                if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO) || sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC))
                    tab_main.SelectedIndex = 0;
                if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD) || sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME))
                    tab_main.SelectedIndex = 1;
                if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD) || sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME))
                    tab_main.SelectedIndex = 2;
                if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD) || sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME))
                    tab_main.SelectedIndex = 3;
                if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR))
                    tab_main.SelectedIndex = 4;
                if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS))
                    txt_remarks.Focus();

                txt_part_no.Text       = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO]       == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO].ToString().Trim();
                txt_part_name.Text     = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC]     == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC].ToString().Trim();
                txt_mat_code.Text      = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD]        == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD].ToString().Trim();
                txt_mat_name.Text      = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME]      == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME].ToString().Trim();
                txt_mat_comment.Text   = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_COMMENT]   == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_COMMENT].ToString().Trim();                
                txt_color_cd.Text      = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD]      == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD].ToString().Trim();
                txt_color_name.Text    = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME]    == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME].ToString().Trim();
                txt_color_comment.Text = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_COMMENT] == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_COMMENT].ToString().Trim();
                txt_unit.Text          = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD]   == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD].ToString().Trim();
                txt_spec_cd.Text       = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD]   == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD].ToString().Trim();
                txt_spec.Text          = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME]     == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME].ToString().Trim();
                txt_ven_seq.Text       = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ]       == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ].ToString().Trim();
                txt_ven_name.Text      = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR]        == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR].ToString().Trim();
                txt_remarks.Text       = (_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS]       == null) ? "" : _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS].ToString().Trim();
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
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }        
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;

                    Display_Data(); 
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

        private void cmb_search_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_search.SelectedIndex == -1)
                    return;

                Display_Data();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }     
        }

        private void Display_Data()
        {
            fgrid_part.Rows.Count   = fgrid_part.Rows.Fixed;
            fgrid_mat.Rows.Count    = fgrid_mat.Rows.Fixed;
            fgrid_color.Rows.Count  = fgrid_color.Rows.Fixed;
            fgrid_unit.Rows.Count   = fgrid_unit.Rows.Fixed;
            fgrid_vendor.Rows.Count = fgrid_vendor.Rows.Fixed;

            string arg_value = txt_search.Text.Trim();
            DataTable dt_ret = null;

            if (tab_main.SelectedIndex.Equals(0)) //Part
            {
                dt_ret = SELECT_SXP_REQ_POP_PART(arg_value);
                Display_Grid(dt_ret, fgrid_part);
            }
            else if (tab_main.SelectedIndex.Equals(1)) //Material
            {
                dt_ret = SELECT_SXP_REQ_POP_MAT(arg_value);
                Display_Grid(dt_ret, fgrid_mat);
            }
            else if (tab_main.SelectedIndex.Equals(2)) //Color
            {
                dt_ret = SELECT_SXP_REQ_POP_COLOR(arg_value);
                Display_Grid(dt_ret, fgrid_color);
            }
            else if (tab_main.SelectedIndex.Equals(3)) //Unit/Spec
            {
                arg_value = cmb_search.SelectedValue.ToString();
                dt_ret = SELECT_SXP_REQ_POP_UNIT(arg_value);
                Display_Grid(dt_ret, fgrid_unit);
            }
            else if (tab_main.SelectedIndex.Equals(4)) //Vendor
            {
                dt_ret = SELECT_SXP_REQ_POP_VENDOR(arg_value);
                Display_Grid(dt_ret, fgrid_vendor);
            }
            
        }

        private DataTable SELECT_SXP_REQ_POP_PART(string arg_value)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_POP_PART";

            MyOraDB.Parameter_Name[0] = "ARG_VALUE";            
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SXP_REQ_POP_MAT(string arg_value)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_POP_MAT";

            MyOraDB.Parameter_Name[0] = "ARG_VALUE";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SXP_REQ_POP_COLOR(string arg_value)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_POP_COLOR";

            MyOraDB.Parameter_Name[0] = "ARG_VALUE";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SXP_REQ_POP_UNIT(string arg_value)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_POP_UNIT";

            MyOraDB.Parameter_Name[0] = "ARG_VALUE";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SXP_REQ_POP_VENDOR(string arg_value)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_POP_VENDOR";

            MyOraDB.Parameter_Name[0] = "ARG_VALUE";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_gird)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_gird.Rows.Add();

                for (int j = arg_gird.Cols.Fixed; j < arg_gird.Cols.Count; j++)
                {
                    arg_gird[arg_gird.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                    arg_gird.Rows[arg_gird.Rows.Count - 1].StyleNew.BackColor = Color.White;
                }
            }
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {

                if (!Check_Save_Data())
                    return;

                int sct_row = _main_form.fgrid_detail.Selection.r1;                
                
                DataTable dt_ret = GET_MATERIAL_INFO();                
                string _pur_div   = dt_ret.Rows[0].ItemArray[0].ToString();

                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO]       = txt_part_no.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC]     = txt_part_name.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD]        = txt_mat_code.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME]      = txt_mat_name.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_COMMENT]   = txt_mat_comment.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD]      = txt_color_cd.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME]    = txt_color_name.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_COMMENT] = txt_color_comment.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD]   = txt_unit.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD]   = txt_spec_cd.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME]     = txt_spec.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV]       = _pur_div;
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ]       = txt_ven_seq.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR]        = txt_ven_name.Text.Trim();
                _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS]       = txt_remarks.Text.Trim();

                if (!_main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV].ToString().Equals("I"))
                    _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV] = "U";

                this.Close();
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private bool Check_Save_Data()
        {
            try
            {
                string mat_name = txt_mat_name.Text.Trim().ToUpper();

                if (mat_name.Equals("") || mat_name.Equals("NA") || mat_name.Equals("N/A") || mat_name.Equals("NONE"))
                {
                    MessageBox.Show("Materila Name cannot have ( NA, N/A, NONE ).\r\n\r\nPlease make another material name.");
                    return false;
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }

        private DataTable GET_MATERIAL_INFO()
        {            
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.GET_MAT_INFO";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";           
            MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";            
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;            
            MyOraDB.Parameter_Values[1] = txt_mat_code.Text.ToUpper();
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Grid Event
        private void fgrid_part_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_part.Rows.Count == fgrid_part.Rows.Fixed)
                return;

            int sct_row = fgrid_part.Selection.r1;

            txt_part_no.Text   = fgrid_part[sct_row, 1].ToString();
            txt_part_name.Text = fgrid_part[sct_row, 3].ToString();

            tab_main.SelectedIndex = 1;
        }

        private void fgrid_mat_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_mat.Rows.Count == fgrid_mat.Rows.Fixed)
                return;

            int sct_row = fgrid_mat.Selection.r1;

            txt_mat_code.Text = fgrid_mat[sct_row, 1].ToString();
            txt_mat_name.Text = fgrid_mat[sct_row, 2].ToString();

            tab_main.SelectedIndex = 2;
        }

        private void fgrid_color_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_color.Rows.Count == fgrid_color.Rows.Fixed)
                return;

            int sct_row = fgrid_color.Selection.r1;

            txt_color_cd.Text   = fgrid_color[sct_row, 1].ToString();
            txt_color_name.Text = fgrid_color[sct_row, 2].ToString();

            tab_main.SelectedIndex = 3;
        }

        private void fgrid_unit_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_unit.Rows.Count == fgrid_unit.Rows.Fixed)
                return;

            int sct_row = fgrid_unit.Selection.r1;

            txt_unit.Text    = fgrid_unit[sct_row, 1].ToString();
            txt_spec_cd.Text = fgrid_unit[sct_row, 2].ToString();
            txt_spec.Text    = fgrid_unit[sct_row, 3].ToString();
            

            tab_main.SelectedIndex = 4;
        }

        private void fgrid_vendor_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_vendor.Rows.Count == fgrid_vendor.Rows.Fixed)
                return;

            int sct_row = fgrid_vendor.Selection.r1;

            txt_ven_seq.Text = fgrid_vendor[sct_row, 1].ToString();
            txt_ven_name.Text = fgrid_vendor[sct_row, 2].ToString();
        }
        #endregion

        #region Control Event
        private void tab_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search.Clear();

            if (tab_main.SelectedIndex.Equals(3))
            {
                cmb_search.Visible = true;
                txt_search.Visible = false;
            }
            else
            {
                cmb_search.Visible = false;
                txt_search.Visible = true; 
            }
        }
        private void chk_new_mat_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_new_mat.Checked)
            {
                txt_mat_name.Enabled = true;
                txt_mat_code.Text    = "X";
                txt_mat_name.BackColor = Color.White;
            }
            else
            {
                txt_mat_name.Enabled = false;
                txt_mat_code.Text = "";
                txt_mat_name.Text = "";
                txt_mat_name.BackColor = Color.WhiteSmoke;
            }
        }
        #endregion        

    }
}

