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
    public partial class Form_Pur_Manager_New_02 : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        #endregion

        #region 생성자
        public Form_Pur_Manager_New_02()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Form Loading
        private void Form_Pur_Manager_New_02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();
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
            this.Text               = "PCC_Purchase Manager";
			this.lbl_MainTitle.Text = "PCC_Purchase Manager";
			ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            dpk_get_from.Value = DateTime.Now.AddDays(-7);
			dpk_get_to.Value = DateTime.Now;

            DataTable dt_ret = null;
            
            //Status (D - Delete, R : Return, N - Ready(User가 없을때, Y - Save, C - Confirm)
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_Status);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, false);
            cmb_status.SelectedIndex = 0;

            //Purchase Division
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
            cmb_pur_div.SelectedIndex = 0;

            //Data Type (MRP/Request)
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_DataType);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_data_type, 1, 2, true, false);
            cmb_data_type.SelectedIndex = 0;

			#region Upload  User설정
            dt_ret = SELECT_SXP_PUR_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_pur_user.SelectedIndex = 0;

            chk_status.Checked = true;
			#endregion                       
            #endregion

            #region Grid Setting
            fgrid_manager.Set_Grid_CDC("SXP_PUR_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_manager.Set_Action_Image(img_Action);
			fgrid_manager.ExtendLastCol = false;
			fgrid_manager.Tree.Column = (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxITEM_01;
            #endregion

            #region Button Setting 
            tbtn_Print.Enabled   = false;
			tbtn_Delete.Enabled  = true;
			tbtn_New.Enabled     = false;
            tbtn_Save.Enabled    = true;
            tbtn_Confirm.Enabled = true;
            tbtn_Create.Enabled  = true;
            tbtn_Search.Enabled  = true;
            #endregion                        

            #region ETC
            txt_style_name.CharacterCasing = CharacterCasing.Upper;
            txt_mat_name.CharacterCasing   = CharacterCasing.Upper;

            lbl_return.BackColor  = Color.Orange;
            lbl_ready.BackColor   = Color.LightYellow;
            lbl_save.BackColor    = Color.White;
            lbl_delete.BackColor  = Color.LightGray;
            lbl_confirm.BackColor = Color.Bisque;
            #endregion
        }
        private DataTable SELECT_SXP_PUR_USER()
        {            
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PURUSER"; ;
                        
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                        
            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                        
            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Create Data
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string arg_factory = cmb_Factory.SelectedValue.ToString();
                string arg_user = "yonggeun.byun"; //COM.ComVar.This_User;

                GET_CREATE_DATA(arg_factory, arg_user);
                tbtn_Search_Click(null, null);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void GET_CREATE_DATA(string arg_factory, string arg_user)
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_01.GET_SXP_PUR_MANAGER";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_user;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_manager.Rows.Count = fgrid_manager.Rows.Fixed;
                
                string[] arg_value = new string[9];
                arg_value[0] = cmb_Factory.SelectedValue.ToString().Trim();
                arg_value[1] = cmb_pur_user.SelectedValue.ToString().Trim();                
                arg_value[2] = dpk_get_from.Value.ToString("yyyyMMdd");
                arg_value[3] = dpk_get_to.Value.ToString("yyyyMMdd");
                arg_value[4] = cmb_data_type.SelectedValue.ToString().Trim();
                arg_value[5] = cmb_pur_div.SelectedValue.ToString().Trim();
                arg_value[6] = txt_style_name.Text.Trim().ToUpper().Trim();
                arg_value[7] = txt_mat_name.Text.Trim().ToUpper().Trim();
                arg_value[8] = (chk_status.Checked) ? "X" : cmb_status.SelectedValue.ToString().Trim();

                DataTable dt_ret = SELECT_PUR_MANAGER(arg_value);
                Display_Grid(dt_ret);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private DataTable SELECT_PUR_MANAGER(string [] arg_value)
        {            
            MyOraDB.ReDim_Parameter(10);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PUR_MANAGER_01";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";            
            MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
            MyOraDB.Parameter_Name[4] = "ARG_DATA_TYPE";
            MyOraDB.Parameter_Name[5] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[6] = "ARG_STYLE_NAME";
            MyOraDB.Parameter_Name[7] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[8] = "ARG_STATUS";
            MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

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
            MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = arg_value[8];            
            MyOraDB.Parameter_Values[9] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_search = MyOraDB.Exe_Select_Procedure();

            return ds_search.Tables[MyOraDB.Process_Name];
        }
        private void Display_Grid(DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                int _level = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString());
                fgrid_manager.Rows.InsertNode(fgrid_manager.Rows.Count, _level);

                for (int j = 0; j < fgrid_manager.Cols.Count; j++)
                {
                    fgrid_manager[fgrid_manager.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();                    
                }

                if (_level.Equals(1))
                {
                    string _status = fgrid_manager[fgrid_manager.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString();

                    if (_status.Equals("C"))       // Confirm 일때
                    {
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].AllowEditing = false;
                        fgrid_manager.GetCellRange(fgrid_manager.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_USER).StyleNew.ForeColor = Color.Black;                        
                    }
                    else if (_status.Equals("Y")) // Save 일때
                    {
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].AllowEditing = true;
                    }
                    else if (_status.Equals("N")) // Ready 일때
                    {
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].StyleNew.BackColor = Color.LightYellow;
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].AllowEditing = true;
                    }
                    else if (_status.Equals("R")) // Return 일때
                    {
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].StyleNew.BackColor = Color.Orange;
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].AllowEditing = true;
                    }
                    else if (_status.Equals("D")) // Delete 일때
                    {
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].StyleNew.BackColor = Color.LightGray;
                        fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].AllowEditing = false;
                        fgrid_manager.GetCellRange(fgrid_manager.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_USER).StyleNew.ForeColor = Color.Black;                        
                    }                    
                }
                else
                {
                    fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                    fgrid_manager.Rows[fgrid_manager.Rows.Count - 1].AllowEditing = false; 
                }

                
            }

            fgrid_manager.Tree.Show(1);
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_manager.Select(fgrid_manager.Selection.r1, fgrid_manager.Selection.c1);

                SAVE_PUR_MANAGER();

                tbtn_Search_Click(null, null);
            }
            catch
            {

            }
            finally 
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void SAVE_PUR_MANAGER()
        {
            int vCol = 5;
            MyOraDB.ReDim_Parameter(vCol);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_01.SAVE_SXP_PUR_MANAGER";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_mrp_seq";
            MyOraDB.Parameter_Name[2] = "arg_pur_user";
            MyOraDB.Parameter_Name[3] = "arg_status";
            MyOraDB.Parameter_Name[4] = "arg_upd_user";
            
            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;            

            //04.DATA 정의
            int vRow = 0;
            for (int i = fgrid_manager.Rows.Fixed; i < fgrid_manager.Rows.Count; i++)
            {
                string _div = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxDIV].ToString().Trim();
                if (!_div.Equals(""))
                {
                    int node_cnt = fgrid_manager.Rows[i].Node.Children;
                    for (int node = 1; node <= node_cnt; node++)
                    {
                        vRow++;
                    }
                }
            }

            int vCnt = vCol * vRow;
            MyOraDB.Parameter_Values = new string[vCnt];

            vCnt = 0;
            for (int i = fgrid_manager.Rows.Fixed; i < fgrid_manager.Rows.Count; i++)
            {
                string _level = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString().Trim();
                string _div   = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxDIV].ToString().Trim();
                
                if (_level.Equals("2") || _div.Equals(""))
                    continue;

                int node_cnt = fgrid_manager.Rows[i].Node.Children;

                for (int node = 1; node <= node_cnt; node++)
                {
                    MyOraDB.Parameter_Values[vCnt++] = fgrid_manager[i + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxFACTORY].ToString().Trim();
                    MyOraDB.Parameter_Values[vCnt++] = fgrid_manager[i + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxMRP_SEQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vCnt++] = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxP_USER].ToString().Trim();

                    string _status = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxDIV].ToString().Trim();
                    if (_status.Equals("U"))
                        _status = "Y";
                    else if (_status.Equals("D"))
                        _status = "D";

                    MyOraDB.Parameter_Values[vCnt++] = _status;
                    MyOraDB.Parameter_Values[vCnt++] = COM.ComVar.This_User; 
                }                
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure(); 
        }
        #endregion

        #region Delete Data
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_manager.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _lev    = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString().Trim();
                    string _status = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString().Trim();

                    if (_lev.Equals("2") || _status.Equals("C") || _status.Equals("D"))
                        continue;

                    fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxDIV] = "D";
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                //this.Cursor = Cursors.WaitCursor;

                //CONFIRM_PUR_MANAGER();

                //tbtn_Search_Click(null, null);

                this.Cursor = Cursors.WaitCursor;

                if (fgrid_manager.Rows.Count == fgrid_manager.Rows.Fixed)
                    return;

                int[] sct_rows = fgrid_manager.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _lev    = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString();
                    string _status = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString();

                    if (_lev.Equals("2") || _status.Equals("C") || _status.Equals("D"))
                        continue;

                    int node_cnt = fgrid_manager.Rows[sct_rows[i]].Node.Children;

                    for (int node = 1; node <= node_cnt; node++)
                    {
                        string arg_factory = fgrid_manager[sct_rows[i] + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxFACTORY].ToString();
                        string arg_mrp_seq = fgrid_manager[sct_rows[i] + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxMRP_SEQ].ToString();
                        CONFIRM_PUR_MANAGER(arg_factory, arg_mrp_seq);
                    }

                    fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS] = "C";
                    fgrid_manager.Rows[sct_rows[i]].StyleNew.BackColor = Color.Bisque;
                    fgrid_manager.Rows[sct_rows[i]].AllowEditing = false;
                    fgrid_manager.GetCellRange(sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_USER).StyleNew.ForeColor = Color.Black;
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
        private void CONFIRM_PUR_MANAGER()
        {
            int vCol = 3;
            MyOraDB.ReDim_Parameter(vCol);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_01.COMFIRM_SXP_PUR_MANAGER";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MRP_SEQ";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            
            //04.DATA 정의
            int vRow = 0;
            for (int i = fgrid_manager.Rows.Fixed; i < fgrid_manager.Rows.Count; i++)
            {
                string _level  = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString().Trim();
                string _status = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString().Trim();
                
                if (_level.Equals("2"))
                {
                    if (!_status.Equals("C") && !_status.Equals("D"))
                        vRow++;
                }
            }

            int vCnt = vCol * vRow;
            MyOraDB.Parameter_Values = new string[vCnt];

            vCnt = 0;
            for (int i = fgrid_manager.Rows.Fixed; i < fgrid_manager.Rows.Count; i++)
            {                
                string _level  = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString().Trim();
                string _status = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString().Trim();

                if (_level.Equals("1") || _status.Equals("C") || _status.Equals("D"))
                    continue;
                
                MyOraDB.Parameter_Values[vCnt++] = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxFACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxMRP_SEQ].ToString().Trim();                   
                MyOraDB.Parameter_Values[vCnt++] = COM.ComVar.This_User;               
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Context Menu
        private void mnu_mat_Click(object sender, EventArgs e)
        {
            fgrid_manager.Tree.Show(1);
        }

        private void mnu_bom_Click(object sender, EventArgs e)
        {
            fgrid_manager.Tree.Show(2);
        }

        private void mnu_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_manager.Rows.Count == fgrid_manager.Rows.Fixed)
                    return;

                int[] sct_rows = fgrid_manager.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _lev    = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString();
                    string _status = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString();

                    if (_lev.Equals("2") || _status.Equals("C") || _status.Equals("D"))
                        continue;

                    int node_cnt = fgrid_manager.Rows[sct_rows[i]].Node.Children;

                    for (int node = 1; node <= node_cnt; node++)
                    {
                        string arg_factory = fgrid_manager[sct_rows[i] + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxFACTORY].ToString();
                        string arg_mrp_seq = fgrid_manager[sct_rows[i] + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxMRP_SEQ].ToString();
                        CONFIRM_PUR_MANAGER(arg_factory, arg_mrp_seq);
                    }

                    fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS] = "C";
                    fgrid_manager.Rows[sct_rows[i]].StyleNew.BackColor = Color.Bisque;
                    fgrid_manager.Rows[sct_rows[i]].AllowEditing = false;
                    fgrid_manager.GetCellRange(sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_USER).StyleNew.ForeColor = Color.Black; 
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
        private void CONFIRM_PUR_MANAGER(string arg_factory, string arg_mrp_seq)
        {            
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_01.COMFIRM_SXP_PUR_MANAGER";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MRP_SEQ";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04.DATA 정의            
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_mrp_seq;
            MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;


            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
                     
        }
        private void mnu_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_manager.Rows.Count == fgrid_manager.Rows.Fixed)
                    return;

                int[] sct_rows = fgrid_manager.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _lev = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString();
                    string _status = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString();
                    string _pur_no = (fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_NO] == null) ? "" : fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_NO].ToString().Trim();

                    if (_lev.Equals("2") || _status.Equals("Y") || _status.Equals("N") || _status.Equals("R") || !_pur_no.Equals(""))
                        continue;

                    int node_cnt = fgrid_manager.Rows[sct_rows[i]].Node.Children;

                    for (int node = 1; node <= node_cnt; node++)
                    {
                        string arg_factory = fgrid_manager[sct_rows[i] + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxFACTORY].ToString();
                        string arg_mrp_seq = fgrid_manager[sct_rows[i] + node, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxMRP_SEQ].ToString();
                        RELEASE_PUR_MANAGER(arg_factory, arg_mrp_seq);
                    }

                    fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS] = "Y";
                    fgrid_manager.Rows[sct_rows[i]].StyleNew.BackColor = Color.White;
                    fgrid_manager.Rows[sct_rows[i]].AllowEditing = true;
                    fgrid_manager.GetCellRange(sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_USER).StyleNew.ForeColor = Color.Blue;
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
        private void RELEASE_PUR_MANAGER(string arg_factory, string arg_mrp_seq)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_01.RELEASE_SXP_PUR_MANAGER";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MRP_SEQ";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04.DATA 정의            
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_mrp_seq;
            MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;


            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Grid Event
        private void fgrid_manager_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_manager.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _level = fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString().Trim();
                    string _div   =  fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString().Trim();

                    if (_level.Equals("2") || _div.Equals("D") || _div.Equals("C"))
                        continue;
                    
                    fgrid_manager.Update_Row(sct_rows[i]);
                    fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxP_USER] = fgrid_manager[fgrid_manager.Selection.r1, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxP_USER].ToString();
                    fgrid_manager[sct_rows[i], (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_USER] = fgrid_manager[fgrid_manager.Selection.r1, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxP_USER].ToString();
                }
            }
            catch
            {
 
            }
        }
        private void fgrid_manager_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_manager.Rows.Count == fgrid_manager.Rows.Fixed)
                    return;

                int sct_row = fgrid_manager.Selection.r1;

                string _lev    = fgrid_manager[sct_row, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxT_LEVEL].ToString();
                string _status = fgrid_manager[sct_row, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxSTATUS].ToString();
                string _pur_no = (fgrid_manager[sct_row, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_NO] == null) ? "" : fgrid_manager[sct_row, (int)ClassLib.TBSXP_PUR_MANAGER_NEW_02.IxPUR_NO].ToString();

                if (_lev.Equals("1"))
                {
                    if (_status.Equals("C") || _status.Equals("D"))
                    {
                        mnu_confirm.Enabled = false;
                        
                        if(_pur_no.Equals(""))
                            mnu_cancel.Enabled  = true;
                        else
                            mnu_cancel.Enabled = false;
                    }
                    else
                    {
                        mnu_confirm.Enabled = true;
                        mnu_cancel.Enabled  = false;
                    }
                }
                else
                {
                    mnu_confirm.Enabled = false;
                    mnu_cancel.Enabled  = false; 
                }


            }
            catch
            { 
            }
        }
        #endregion

        #region Control Event
        private void chk_status_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_status.Checked)
                {
                    cmb_status.SelectedIndex = 0;
                    cmb_status.Enabled = false;
                }
                else
                {
                    cmb_status.Enabled = true; 
                }

            }
            catch
            {
 
            }
        }
        #endregion
    }
}

