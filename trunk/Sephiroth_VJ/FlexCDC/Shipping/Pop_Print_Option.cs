using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCDC.Shipping
{
    public partial class Pop_Print_Option : COM.PCHWinForm.Pop_Small
    {
        #region 사용자 정의 변수
        private string _factory;
        private string _ship_no;
        private string _mrp_no;
        private string _mrp_req_flg;
        private string _srf_no;
        private string _mat_name;
        #endregion
        public Pop_Print_Option()
        {
            InitializeComponent();
        }

        public Pop_Print_Option(string arg_factory, string arg_ship_no, string arg_mrp_no, string arg_map_req_flg, string arg_srf_no, string arg_mat_name)
        {
            InitializeComponent();

            _factory = arg_factory;
            _ship_no = arg_ship_no;
            _mrp_no  = arg_mrp_no;
            _mrp_req_flg = arg_map_req_flg;
            _srf_no  = arg_srf_no;
            _mat_name = arg_mat_name;
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
                
                //////////////////////////////////////////////////////

                cmb_print_option.AddItem("1;Outgoing Ticket");
                cmb_print_option.AddItem("2;Barcode");

                cmb_print_option.SelectedIndex = -1;

                cmb_print_option.MaxDropDownItems = 10;
                cmb_print_option.Splits[0].DisplayColumns[0].Width = 0;
                cmb_print_option.Splits[0].DisplayColumns[1].Width = 257;

                cmb_print_option.ExtendRightColumn = true;
                cmb_print_option.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
                cmb_print_option.HScrollBar.Height = 0;

                cmb_print_option.SelectedIndex = 0;
            }
            catch
            {
                
            }        
        }

        private void Pop_Print_Option_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {

            }
            finally
            {
 
            }
            
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_print_option.SelectedValue.ToString() == "1")
                {
                    string mrd_Filename = Application.StartupPath + @"\Outgoing_Ticket" + ".mrd";
                    string sPara = " /rp " + "[" + _factory + "]" 
                                           + " [" + _ship_no + "]" 
                                           + " [" + _mrp_no + "]" 
                                           + " [" + _mrp_req_flg + "]" 
                                           + " [" + _srf_no + "]"
                                           + " [" + _mat_name + "]";

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                    report.ShowDialog();
                }
                if (cmb_print_option.SelectedValue.ToString() == "2")
                {
                    string mrd_Filename = Application.StartupPath + @"\Shipping_Barcode" + ".mrd";
                    string sPara = " /rp " + "[" + _factory + "]" + " [" + _ship_no + "]" + " [" + _mrp_no + "]" + " [" + _mrp_req_flg + "]" + " [" + _srf_no + "]"
                                           + " [" + _mat_name + "]";

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                    report.ShowDialog();

                }
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
    }
}

