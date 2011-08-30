using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.v5523.Pop
{
    public partial class Pop_5523_Add_Bom : COM.PCHWinForm.Pop_Small
    {
        #region Constructor
        public Pop_5523_Add_Bom()
        {
            InitializeComponent();
        }       
        #endregion

        #region User Define Variable
        public string _style_cd = "";
        public string _bom_id = "";
        public bool _save_flg = false;
        #endregion   

        #region Form Loading
        private void Pop_5523_Add_Bom_Load(object sender, EventArgs e)
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
            this.Text = "Add BOM";
            this.lbl_MainTitle.Text = "Add BOM";
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
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Apply_Data()
        {
            _style_cd = txt_color_code.Text.Trim();
            _bom_id   = txt_bom_id.Text.Trim();
            
            if (_bom_id.Equals(""))
            {
                MessageBox.Show("Please write BOM ID");
                return;
            }

            _save_flg = true;
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
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Cancel_Data()
        {
            this.Close();
        }
        #endregion


    }
}

