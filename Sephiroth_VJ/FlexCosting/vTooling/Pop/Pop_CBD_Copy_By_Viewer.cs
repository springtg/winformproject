using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.vTooling.Pop
{
    public partial class Pop_CBD_Copy_By_Viewer : COM.PCHWinForm.Pop_Small
    {
        #region Constructor

        public Pop_CBD_Copy_By_Viewer()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion

        #region User Define Variable
        
        private COM.OraDB MyOraDB = new COM.OraDB();
        private string _CBDVer = null;
        private string _FOBType = null;

        #endregion

        #region Form Loading

        private void Init_Form()
        {
            //Title
            this.Text = "Copy CBD";
            this.lbl_MainTitle.Text = "Copy CBD";
            ClassLib.ComFunction.SetLangDic(this);
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
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        #region Properties

        public string DEV_FAC
        {
            get
            {
                return COM.ComVar.This_Factory;
            }
        }

        public string MOID
        {
            get
            {
                return txt_MOID2.Text.Replace("-", "");
            }
        }

        public string BOM_ID
        {
            get
            {
                return txt_CBDID2.Text;
            }
        }

        #endregion

    }
}

