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
    public partial class Pop_Import_Offer_Vendor : COM.PCHWinForm.Pop_Small
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성        
        public bool save_flg = false;
        public string ven_cd = "", ven_name = "";
        #endregion

        #region 생성자
        public Pop_Import_Offer_Vendor()
        {
            InitializeComponent();
        }        
        #endregion        

        #region Form Loading
        private void Pop_Import_Offer_Vendor_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {
 
            }
        }

        private void Init_Form()
        {
            this.Text = "PCC_Import Offer Vendor";
            this.lbl_MainTitle.Text = "PCC_Import Offer Vendor";

            DataTable dt_list = Select_vendor("");
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_vendor, 0, 1, false, 0, 176);
            cmb_vendor.SelectedIndex = 0;

            txt_vendor.CharacterCasing = CharacterCasing.Upper;
            txt_vendor.Focus();

        }
        private DataTable Select_vendor(string arg_vendor)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.select_vendor_pop";

            MyOraDB.Parameter_Name[0] = "arg_vendor";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_vendor;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion
                
        private void txt_vendor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyData == Keys.Enter)
                {
                    DataTable dt_list = Select_vendor(txt_vendor.Text);
                    ClassLib.ComCtl.Set_ComboList(dt_list, cmb_vendor, 0, 1, false, 0, 176);
                    cmb_vendor.SelectedIndex = 0;
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                                
                DataTable dt_list = Select_vendor(txt_vendor.Text);
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_vendor, 0, 1, false, 0, 176);
                cmb_vendor.SelectedIndex = 0;
                
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
                
        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                ven_cd = cmb_vendor.SelectedValue.ToString();
                ven_name = cmb_vendor.Text;

                save_flg = true;
                this.Close();
            }
            catch
            {
 
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

