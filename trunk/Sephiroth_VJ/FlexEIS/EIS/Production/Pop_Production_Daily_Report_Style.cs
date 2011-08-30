using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexEIS.EIS.Production
{
    public partial class Pop_Production_Daily_Report_Style : COM.APSWinForm.Pop_Small
    {
        #region 생성자

        public Pop_Production_Daily_Report_Style()
        {
            InitializeComponent();
            Init_Form();
        }

        #endregion


        #region 전역변수

        COM.OraDB MyOraDB = new COM.OraDB();

        #endregion


        #region 이벤트

        private void Pop_Production_Daily_Report_Style_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                Apply();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                Cancel();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_model_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    InputModel();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "input style", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_model_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SelectModel();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "select style", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_model_MouseClick(object sender, MouseEventArgs e)
        {
        }

        #endregion


        #region 이벤트 처리

        private void Init_Form()
        {
            this.Text = "Model select";
            this.lbl_MainTitle.Text = "Model select";

            DataTable vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxOBSType);
            //DataRow newRow = vDT.NewRow();
            //newRow[0] = "__";
            //newRow[1] = "__";
            //vDT.Rows.InsertAt(newRow, 0);
            COM.ComFunction.Set_ComboList(vDT, cmb_obsType, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();
        }

        private void InputModel()
        {
            string vsModel = txt_model.Text;
            DataTable vDT = Select_Model_List(vsModel);
            //DataRow newRow = vDT.NewRow();
            //newRow[0] = "______";
            //newRow[1] = "______";
            //vDT.Rows.InsertAt(newRow, 0);
            COM.ComFunction.Set_ComboList(vDT, cmb_model, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            vDT.Dispose();
        }

        private void SelectModel()
        {
        }

        private void Apply()
        {
            if (cmb_model.SelectedIndex >= 0 && cmb_obsType.SelectedIndex >= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }

        }

        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        #endregion


        #region 결과값

        public string ModelCode
        {
            get
            {
                if (cmb_model.SelectedIndex > -1)
                    return ClassLib.ComFunction.Empty_Combo(cmb_model, "").Replace("-", "");
                else
                    return "______";
            }
            set
            {
                txt_model.Text = "";
                cmb_model.SelectedIndex = -1;
            }
        }

        public string ModelName
        {
            get
            {
                if (cmb_model.SelectedIndex > -1)
                    return cmb_model.SelectedText;
                else
                    return "______";
            }
        }

        public string OBSType
        {
            get
            {
                if (cmb_obsType.SelectedIndex > -1)
                    return ClassLib.ComFunction.Empty_Combo(cmb_obsType, "");
                else
                    return "__";
            }
            set
            {
                cmb_obsType.SelectedIndex = -1;
            }
        }

        #endregion


        #region 데이터베이스

        private DataTable Select_Model_List(string arg_model_cd)
        {

            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_MODEL_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_MODEL_INFO";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_TextBox(txt_model, " ");
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw new Exception("Select_Style_List : " + ex);
            }
        }

        #endregion

    }
}

