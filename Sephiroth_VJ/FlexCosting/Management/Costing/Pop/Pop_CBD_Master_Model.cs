using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Pop
{
    public partial class Pop_CBD_Master_Model : COM.PCHWinForm.Pop_Small
    {
        #region Constructor

        public Pop_CBD_Master_Model()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion

        #region User Define Variable

        #endregion

        #region Form Loading

        private void Init_Form()
        {
            //Title
            this.Text = "Model Search";
            this.lbl_MainTitle.Text = "Model Search";
            ClassLib.ComFunction.SetLangDic(this);
        }

        #endregion

        #region Find data

        private void txt_MatName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindData();
            }
        }

        private void FindData()
        {

        }

        #endregion

    }
}

