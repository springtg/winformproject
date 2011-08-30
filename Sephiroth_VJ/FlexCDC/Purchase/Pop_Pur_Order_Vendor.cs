using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Purchase
{
    public partial class Pop_Pur_Order_Vendor : COM.PCHWinForm.Pop_Large_B
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        public bool save_flg = false;
        #endregion

        #region 생성자
        public Pop_Pur_Order_Vendor()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_Pur_Order_Vendor_Load(object sender, EventArgs e)
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
            this.Text = "Vendor Information";
            this.lbl_MainTitle.Text = "Vendor Information";

            tbtn_Append.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Conform.Enabled = false;
			tbtn_Create.Enabled  = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Insert.Enabled  = false;
			tbtn_New.Enabled	 = false;
			tbtn_Print.Enabled   = false;
			tbtn_Save.Enabled    = true;
			tbtn_Search.Enabled  = true;           

            //Grid Setting
            fgrid_vendor.Set_Grid_CDC("SXP_PUR_VENDOR_POP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_vendor.Set_Action_Image(img_Action);
            
            //Control Setting
            txt_name.CharacterCasing        = CharacterCasing.Upper;
            txt_vendor_name.CharacterCasing = CharacterCasing.Upper;
            txt_popula_name.CharacterCasing = CharacterCasing.Upper;

            txt_ven_seq.Enabled     = false;
            txt_vendor_name.Enabled = false;
            txt_popula_name.Enabled = false;

            txt_name.Focus();
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataTable dt_ret = SELECT_PUR_VENDOR_POP();
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
        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt_ret = SELECT_PUR_VENDOR_POP();
                    Display_Grid(dt_ret);
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
              
        private DataTable SELECT_PUR_VENDOR_POP()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_PUR_VENDOR_POP";

            MyOraDB.Parameter_Name[0] = "ARG_VEN_NAME";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = txt_name.Text.Trim();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private void Display_Grid(DataTable arg_dt)
        {            
            fgrid_vendor.Rows.Count = fgrid_vendor.Rows.Fixed;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_vendor.AddItem(arg_dt.Rows[i].ItemArray, fgrid_vendor.Rows.Count, 0);
            }
        }
        #endregion
        
        #region Grid Event
        private void fgrid_vendor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_vendor.Rows.Count == fgrid_vendor.Rows.Fixed)
                    return;

                int sct_row = fgrid_vendor.Selection.r1;

                txt_ven_seq.Text     = fgrid_vendor[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR_POP.IxVEN_SEQ].ToString().Trim();
                txt_vendor_name.Text = fgrid_vendor[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR_POP.IxVEN_NAME].ToString().Trim();
                txt_popula_name.Text = fgrid_vendor[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR_POP.IxPOPULA_NAME].ToString().Trim();

                tbtn_Save_Click(null, null);
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        #endregion

        #region Create New Code(X Code)
        private void chk_xcode_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_xcode.Checked)
            {
                txt_ven_seq.Clear();
                txt_vendor_name.Clear();
                txt_popula_name.Clear();
                
                txt_vendor_name.Enabled = true;
                txt_popula_name.Enabled = true;
            }
            else
            {
                txt_ven_seq.Clear();
                txt_vendor_name.Clear();
                txt_popula_name.Clear();

                txt_vendor_name.Enabled = false;
                txt_popula_name.Enabled = false;
            }
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataTable dt_ret = SAVE_PUR_VENDOR_CHECK();

                string chk_flg  = dt_ret.Rows[0].ItemArray[0].ToString();
                string new_code = (chk_xcode.Checked) ? "Y" : "N";

                if (new_code.Equals("N"))
                {
                    if (chk_flg.Equals("N"))
                    {
                        MessageBox.Show("Please Register SH Vendor Code..");
                        return;
                    }
                }
                else
                {
                    dt_ret = SAVE_PUR_VENDOR_XCODE();
                    string ven_seq = dt_ret.Rows[0].ItemArray[0].ToString();

                    txt_ven_seq.Text = ven_seq;
                }

                COM.ComVar.Parameter_PopUp[0] = txt_ven_seq.Text.Trim();
                COM.ComVar.Parameter_PopUp[1] = txt_vendor_name.Text.Trim();

                save_flg = true;
                this.Close();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;                 
            }
        }

        private DataTable SAVE_PUR_VENDOR_CHECK()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_VENDOR_CHECK";

            MyOraDB.Parameter_Name[0] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = txt_ven_seq.Text.Trim();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SAVE_PUR_VENDOR_XCODE()
        {
            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_VENDOR_XCODE";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_VEN_DESC";
            MyOraDB.Parameter_Name[2] = "ARG_POPULA_NAME";
            MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_CDC_Factory;
            MyOraDB.Parameter_Values[1] = txt_vendor_name.Text.Trim();
            MyOraDB.Parameter_Values[2] = txt_popula_name.Text.Trim();
            MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion
    }
}

