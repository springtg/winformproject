using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Collections;

namespace FlexSQM
{
    public partial class Form_Select_Comp : COM.SQMWinForm.Pop_Small
    {
        private string _DaySeq = "0";
        public Form_Select_Comp(C1.Win.C1List.C1Combo arg_cboComp, string arg_StyleCode, string arg_StyleName, object arg_FromDate, string arg_DaySeq)
        {
            InitializeComponent();
            cmbComponent.DataSource = arg_cboComp.DataSource;
            cmbComponent.DisplayMember = arg_cboComp.DisplayMember;
            cmbComponent.ValueMember = arg_cboComp.ValueMember;
            txt_StyleCode.Text = arg_StyleCode;
            txt_StyleName.Text = arg_StyleName;
            dpk_FromDate.Value =(DateTime) arg_FromDate;
            dpk_ToDate.Value = dpk_FromDate.Value;
            _DaySeq = arg_DaySeq;
        }

        #region "Method"

        private DataTable Search_Component()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_component";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_style_cd";
                MyOraDB.Parameter_Name[1] = "arg_comp_nm";
                MyOraDB.Parameter_Name[2] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = txt_StyleCode.Text;
                MyOraDB.Parameter_Values[1] = Convert.ToString(txtComponent.Text);
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                DataTable a = ds_ret.Tables[0];
                return a;
            }
            catch
            {
                return null;
            }
        }

        private ArrayList GetReturnValue()
        {
            string _NewComp = COM.ComFunction.Empty_Combo(cmbComponent, string.Empty);
            if (_NewComp.Equals(string.Empty))
            {
                COM.ComFunction.User_Message("Pls Select Comp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            ArrayList arr = new ArrayList();
            arr.Add(dpk_FromDate.Value.ToString("yyyyMMdd"));
            arr.Add(dpk_ToDate.Value.ToString("yyyyMMdd"));
            arr.Add(_NewComp);
            arr.Add(_DaySeq);
            return arr;
        }

        #endregion

        private void btn_Select_Click(object sender, EventArgs e)
        {
            ArrayList l_arrTmp = GetReturnValue();
            if (l_arrTmp != null)
            {
                this.Tag = l_arrTmp;
                DialogResult = DialogResult.OK;
            }
        }

        private void Form_Select_Comp_Load(object sender, EventArgs e)
        {

        }

        private void cmbComponent_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_Select.Enabled = true;
        }

        private void txtComponent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                DataTable dt_ret = Search_Component();
                COM.ComCtl.Set_ComboList(dt_ret, cmbComponent, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Component_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}