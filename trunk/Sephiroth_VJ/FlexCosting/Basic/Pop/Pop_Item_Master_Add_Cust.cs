using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Pop
{
    public partial class Pop_Item_Master_Add_Cust : COM.PCHWinForm.Pop_Small
    {
        #region Constructor
        public Pop_Item_Master_Add_Cust()
        {
            InitializeComponent();
        }


        public Pop_Item_Master_Add_Cust(string arg_div, string arg_mxs_div, string arg_status)
        {
            InitializeComponent();
            
            _main_div = arg_div;
            _main_mxs_div = arg_mxs_div;
            _main_status = arg_status;
        }
        public Pop_Item_Master_Add_Cust(string arg_div, string[] arg_value)
        {
            InitializeComponent();

            _main_div = arg_div;
            _main_value = arg_value;
        }
        #endregion

        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();
        private string [] _main_value;
        private string _main_div = "";
        private string _main_mxs_div = "";
        private string _main_status = "N";
        public string _loc_code = "";
        #endregion

        #region Form Loading
        private void Pop_Item_Master_Add_Cust_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void Init_Form()
        {
            //Title
            this.Text = "Supplier";
            this.lbl_MainTitle.Text = "Supplier";
            ClassLib.ComFunction.SetLangDic(this);

            DataTable vDT = COM.ComFunction.Select_Factory_List();
            COM.ComFunction.Set_ComboList(vDT, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedValue = COM.ComVar.This_Factory;
            vDT.Dispose();

            vDT = MyOraDB.Select_ComCode(COM.ComVar.This_Factory, "SFB_37");
            COM.ComFunction.Set_ComboList(vDT, cmb_Division, 1, 2, false, COM.ComVar.ComboList_Visible.Name);

            vDT.Dispose();

            Control_Setting();
        }

        private void Control_Setting()
        {
            if (_main_div.Equals("I"))
                cmb_Division.SelectedValue = _main_mxs_div;
            else if (_main_div.Equals("U"))
            {
                cmb_Factory.Enabled = false;
                txt_LocationCode.Enabled = false;

                cmb_Factory.SelectedValue  = _main_value[0];
                txt_LocationCode.Text      = _main_value[1];
                txt_LocationNameKor.Text   = _main_value[2];
                txt_LocationNameEng.Text   = _main_value[3];
                cmb_Division.SelectedValue = _main_value[4];
            }
            else
                cmb_Division.SelectedIndex = 0;

            txt_LocationNameKor.CharacterCasing = CharacterCasing.Upper;
            txt_LocationNameEng.CharacterCasing = CharacterCasing.Upper;
        }
        #endregion

        #region Apply Data
        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                Apply_Data();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Apply_Data()
        {
            string[] arg_value = new string[16];
            arg_value[ 0] = _main_div;            
            arg_value[ 1] = cmb_Factory.SelectedValue.ToString().Trim();
            arg_value[ 2] = txt_LocationCode.Text.Trim();
            arg_value[ 3] = txt_LocationNameKor.Text.Trim();
            arg_value[ 4] = txt_LocationNameEng.Text.Trim();
            arg_value[ 5] = "";
            arg_value[ 6] = cmb_Division.SelectedValue.ToString().Trim();
            arg_value[ 7] = txt_ManCust.Text.Trim();
            arg_value[ 8] = txt_Phone.Text.Trim();
            arg_value[ 9] = txt_Fax.Text.Trim();
            arg_value[10] = txt_CellPhone.Text.Trim();
            arg_value[11] = txt_Email.Text.Trim();
            arg_value[12] = txt_Comments.Text.Trim();
            arg_value[13] = txt_Remarks.Text.Trim();
            arg_value[14] = (_main_value == null) ? _main_status : _main_value[5];
            arg_value[15] = COM.ComVar.This_User;
                        
            if (Apply_CheckData(arg_value))
            {
                if (SAVE_SFX_CUST(arg_value))
                {
                    this.DialogResult = DialogResult.OK;
                    _loc_code = txt_LocationCode.Text.Trim();

                    this.Close();
                }
            }
        }
        
        private bool Apply_CheckData(string [] arg_value)
        {
            try
            {
                if (arg_value[1] == null)
                {
                    MessageBox.Show("Factory is not selected");
                    cmb_Factory.Focus();
                    return false;
                }
                if (arg_value[2] == null)
                {
                    MessageBox.Show("Location Code is empty");
                    txt_LocationCode.Focus();
                    return false;
                }
                if (arg_value[3] == null)
                {
                    MessageBox.Show("Korean Name is empty");
                    txt_LocationNameKor.Focus();
                    return false;
                }
                if (arg_value[4] == null)
                {
                    MessageBox.Show("English Name is empty");
                    txt_LocationNameEng.Focus();
                    return false;
                }

                if (arg_value[6] == null)
                {
                    MessageBox.Show("Division is not selected");
                    cmb_Division.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool SAVE_SFX_CUST(string[] arg_value)
        {
            try
            {

                MyOraDB.ReDim_Parameter(16);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_CUST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";                
                MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[ 2] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[ 3] = "ARG_MXS_LOCATIONNAME_K";
                MyOraDB.Parameter_Name[ 4] = "ARG_MXS_LOCATIONNAME_E";
                MyOraDB.Parameter_Name[ 5] = "ARG_MXS_LOCATION_SEQ";
                MyOraDB.Parameter_Name[ 6] = "ARG_MXS_DIV";
                MyOraDB.Parameter_Name[ 7] = "ARG_MXS_MAN_CUST";
                MyOraDB.Parameter_Name[ 8] = "ARG_MXS_PHONE";
                MyOraDB.Parameter_Name[ 9] = "ARG_MXS_FAX";
                MyOraDB.Parameter_Name[10] = "ARG_MXS_HEADPHONE";
                MyOraDB.Parameter_Name[11] = "ARG_MXS_EMAIL";
                MyOraDB.Parameter_Name[12] = "ARG_MXS_COMMENTS";
                MyOraDB.Parameter_Name[13] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[14] = "ARG_STATUS";
                MyOraDB.Parameter_Name[15] = "ARG_UPD_USER";

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
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                

                //04.DATA 정의
                MyOraDB.Parameter_Values[0]  = arg_value[0];
                MyOraDB.Parameter_Values[1]  = arg_value[1]; 
                MyOraDB.Parameter_Values[2]  = arg_value[2];
                MyOraDB.Parameter_Values[3]  = arg_value[3];
                MyOraDB.Parameter_Values[4]  = arg_value[4];
                MyOraDB.Parameter_Values[5]  = arg_value[5];
                MyOraDB.Parameter_Values[6]  = arg_value[6];
                MyOraDB.Parameter_Values[7]  = arg_value[7];
                MyOraDB.Parameter_Values[8]  = arg_value[8];
                MyOraDB.Parameter_Values[9]  = arg_value[9];
                MyOraDB.Parameter_Values[10] = arg_value[10];
                MyOraDB.Parameter_Values[11] = arg_value[11];
                MyOraDB.Parameter_Values[12] = arg_value[12];
                MyOraDB.Parameter_Values[13] = arg_value[13];
                MyOraDB.Parameter_Values[14] = arg_value[14];
                MyOraDB.Parameter_Values[15] = arg_value[15];
                

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cancel Data
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                Cancel_Data();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cancel_Data()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}

