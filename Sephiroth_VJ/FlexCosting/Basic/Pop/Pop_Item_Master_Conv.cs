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
    public partial class Pop_Item_Master_Conv : COM.PCHWinForm.Pop_Small
    {
        #region Constructor
        public Pop_Item_Master_Conv()
        {
            InitializeComponent();
        }

        public Pop_Item_Master_Conv(string arg_form)
        {
            InitializeComponent();
            _form_div = arg_form;
        }    
        #endregion

        #region User Define Variable
        private string _form_div = "";
        public string _remarks;
        public bool save_flg = false;
        #endregion      

        #region Form Loading
        private void Pop_Item_Master_Conv_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Init_Form()
        {
            if (_form_div.Equals("CONV"))
            {
                //Title
                this.Text = "Item Update Reason";
                this.lbl_MainTitle.Text = "Item Update Reason";
            }
            else if (_form_div.Equals("DROP"))
            {
                //Title
                this.Text = "Item Drop Reason";
                this.lbl_MainTitle.Text = "Item Drop Reason"; 
            }
            else if (_form_div.Equals("RELEASE"))
            {
                //Title
                this.Text = "Item Release Reason";
                this.lbl_MainTitle.Text = "Item Release Reason";
            }

            ClassLib.ComFunction.SetLangDic(this);

            txt_Remarks.Focus();
        }
        #endregion

        #region Apply Data
        private void btn_apply_Click(object sender, EventArgs e)
        {
            Apply_Data();
        }

        private void Apply_Data()
        {
            _remarks = txt_Remarks.Text.Trim();
            save_flg = true;
            this.Close();
        }
        #endregion

        #region Cancel Data
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}

