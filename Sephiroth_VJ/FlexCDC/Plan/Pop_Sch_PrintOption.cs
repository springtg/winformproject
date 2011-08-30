using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FlexCDC.Plan
{
    public partial class Pop_Sch_PrintOption : COM.PCHWinForm.Pop_Small
    {
        #region User Define Variable 
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 立加 俺眉 积己
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");

        private Form_Sch_Devcheck _main_form = null;
        #endregion

        #region Resource
        public Pop_Sch_PrintOption()
        {
            InitializeComponent();
        }

        public Pop_Sch_PrintOption(Form_Sch_Devcheck arg_form)
        {
            InitializeComponent();

            _main_form = arg_form;
        }       
        #endregion

        private void Pop_Pur_List_PrintOption_Load(object sender, EventArgs e)
        {
            Init_Form();
        }
        
        private void Init_Form()
        {
            try
            {
                this.Text = "Print Option";
                this.lbl_MainTitle.Text = "Print Option";

                
                cmb_print_option.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
                cmb_print_option.ClearItems();

                cmb_print_option.AddItemTitles("Code;Name");

                cmb_print_option.ValueMember = "Code";
                cmb_print_option.DisplayMember = "Name";

                cmb_print_option.AddItem("1;Development Meeting");
                cmb_print_option.AddItem("2;Weekly Report");
                cmb_print_option.AddItem("3;Weekly Report (GTM)");              
                
                cmb_print_option.SelectedIndex = -1;

                cmb_print_option.MaxDropDownItems = 10;
                cmb_print_option.Splits[0].DisplayColumns[0].Width = 0;
                cmb_print_option.Splits[0].DisplayColumns[1].Width = 258;

                cmb_print_option.ExtendRightColumn = true;
                cmb_print_option.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
                cmb_print_option.HScrollBar.Height = 0;

                cmb_print_option.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                string mrd_Filename = "", sPara = "";

                if (cmb_print_option.SelectedValue.ToString() == "1")
                {
                    string _directory = @"C:\WINDOWS\ReportDesigner";
                    DirectoryInfo dr = new DirectoryInfo(_directory);

                    if(!dr.Exists)
                    {
                        dr.Create();
                    }

                    string _report_file = Application.StartupPath + @"\Development_Meeting_02" + ".mrd";

                    FileInfo fi = new FileInfo(_report_file);

                    if (fi.Exists)
                    {
                        fi.CopyTo(_directory + @"\Development_Meeting_02.mrd", true);
                    }
                    else
                    {
                        MessageBox.Show("Report File is not exist, Please ask SYSTEM");
                        return;
                    }


                    
                    string[] arg_value = new string[9];

                    arg_value[0] = _main_form.cmb_factory.SelectedValue.ToString();
                    arg_value[1] = _main_form.cmb_season_from.SelectedValue.ToString();
                    arg_value[2] = _main_form.cmb_season_to.SelectedValue.ToString();
                    arg_value[3] = _main_form.cmb_category.SelectedValue.ToString();
                    arg_value[4] = _main_form.txt_model.Text.Trim();
                    arg_value[5] = _main_form.cmb_user.SelectedValue.ToString();
                    arg_value[6] = (_main_form.chk_pt.Checked) ? "Y" : "";
                    arg_value[7] = (_main_form.chk_file.Checked) ? "Y" : "";
                    arg_value[8] = (_main_form.chk_image.Checked) ? "Y" : "";

                    mrd_Filename = Application.StartupPath + @"\Development_Meeting_New" + ".mrd";
                    sPara = " /rp " +  "[" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]"
                                    + " [" + arg_value[3] + "]" + " [" + arg_value[4] + "]" + " [" + arg_value[5] + "]"
                                    + " [" + arg_value[6] + "]" + " [" + arg_value[7] + "]" + " [" + arg_value[8] + "]";
                }
                else if (cmb_print_option.SelectedValue.ToString() == "2")
                {
                    mrd_Filename = Application.StartupPath + @"\Plan_Weekly_Report" + ".mrd";

                    string[] arg_value = new string[6];

                    arg_value[0] = _main_form.cmb_factory.SelectedValue.ToString();
                    arg_value[1] = _main_form.cmb_season_from.SelectedValue.ToString();
                    arg_value[2] = _main_form.cmb_season_to.SelectedValue.ToString();
                    arg_value[3] = _main_form.cmb_category.SelectedValue.ToString();                    
                    arg_value[4] = _main_form.txt_model.Text.Trim();
                    arg_value[5] = _main_form.cmb_user.SelectedValue.ToString();

                    sPara = " /rp " +  "[" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]"
                                    + " [" + arg_value[3] + "]" + " [" + arg_value[4] + "]" + " [" + arg_value[5] + "]";
                                    

                }
                else if (cmb_print_option.SelectedValue.ToString() == "3")
                {
                    mrd_Filename = Application.StartupPath + @"\Plan_Sales_Report" + ".mrd";

                    string[] arg_value = new string[6];

                    arg_value[0] = _main_form.cmb_factory.SelectedValue.ToString();
                    arg_value[1] = _main_form.cmb_season_from.SelectedValue.ToString();
                    arg_value[2] = _main_form.cmb_season_to.SelectedValue.ToString();
                    arg_value[3] = _main_form.cmb_category.SelectedValue.ToString();
                    arg_value[4] = _main_form.txt_model.Text.Trim();
                    arg_value[5] = _main_form.cmb_user.SelectedValue.ToString();

                    sPara = " /rp " +  "[" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]"
                                    + " [" + arg_value[3] + "]" + " [" + arg_value[4] + "]" + " [" + arg_value[5] + "]";
                                    
                }                
                
                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {

            }
            finally
            {
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Pop_Sch_PrintOption_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
            }
            catch
            {
 
            }
        }
    }
}

