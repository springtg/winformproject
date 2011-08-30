using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCDC.CDC_Bom
{
    public partial class Pop_Bom_Pirnt_Option : COM.APSWinForm.Pop_Small
    {
        public Pop_Bom_Pirnt_Option()
        {
            InitializeComponent();

        }


        private string[] arg_value = new string[14];

        public Pop_Bom_Pirnt_Option(string[] arg_arg)
        {
            InitializeComponent();

            arg_value = arg_arg;
         
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


                cmb_print_option.AddItem("1;Sample Request1");
                cmb_print_option.AddItem("2;Sample Request2");

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


        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";
    

                if (cmb_print_option.SelectedIndex == 0)
                {
                    mrd_Filename = Application.StartupPath + @"\SampleRequest_List_Cost" + ".mrd";


                }
                else
                {

                    mrd_Filename = Application.StartupPath + @"\SampleRequest_List" + ".mrd";

                }
      

                sPara = " /rp " + "[" + arg_value[0] + "]"
                                + " [" + arg_value[1] + "]"
                                + " [" + arg_value[2] + "]"
                                + " [" + arg_value[3] + "]"
                                + " [" + arg_value[4] + "]"
                                + " [" + arg_value[5] + "]"
                                + " [" + arg_value[6] + "]"
                                + " [" + arg_value[7] + "]"
                                + " [" + arg_value[8] + "]"
                                + " [" + arg_value[9] + "]"
                                + " [" + arg_value[10] + "]"
                                + " [" + arg_value[11] + "]"
                                + " [" + arg_value[12] + "]"
                                + " [" + arg_value[13] + "]";

       

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotPrint, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Pop_Bom_Pirnt_Option_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        
    }
}

