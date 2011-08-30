using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;

namespace FlexCDC.Product
{
    public partial class Pop_OP_Setting : COM.PCHWinForm.Pop_Small
    {

        private string settingfile = @"C:\sephroth_setting.ini";
        private COM.OraDB OraDB = new COM.OraDB();
        private Form_Prod_BarScan _form = null;
        private Form_Prod_Result_Input _form_input = null;

        public Pop_OP_Setting(Form_Prod_BarScan arg_form)
        {
            InitializeComponent();

            _form = arg_form;
        }

        public Pop_OP_Setting(Form_Prod_Result_Input arg_form)
        {
            InitializeComponent();

            _form_input = arg_form;
        }

        private void Pop_OP_Setting_Load(object sender, EventArgs e)
        {
            Init_Form();
        }


        private void Init_Form()
        {


            this.Text = "PCC_OP System Setting";
            this.lbl_MainTitle.Text = "PCC_OP System Setting";

            DataTable dt_ret = null;

            dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);

            


            FileInfo settingFile = new FileInfo(settingfile);

            if (!settingFile.Exists)
            {
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;


                dt_ret = Select_sxb_scan_op(cmb_factory.SelectedValue.ToString());
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_op, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_op.SelectedIndex = 0;
            }
            else
            {
                string fullname = settingfile;
                FileStream file = new FileStream(fullname, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(file);

                string[] value = sr.ReadLine().Split(":".ToCharArray());

                sr.Close();
                file.Close();


                cmb_factory.SelectedValue = value[0];



                dt_ret = Select_sxb_scan_op(cmb_factory.SelectedValue.ToString());
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_op, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_op.SelectedValue = value[1];

                
            }



        }


        private DataTable Select_sxb_scan_op(string arg_factory)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXB_SCAN_OP";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private void btn_crt_xml_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(settingfile);
            fileinfo.Delete();

            using (StreamWriter sw = fileinfo.CreateText())
            {
                sw.WriteLine(cmb_factory.SelectedValue.ToString() + ":" + cmb_op.SelectedValue.ToString() + ":" + cmb_op.GetItemText(cmb_op.SelectedIndex, 1));


                if (_form != null)
                {

                    _form.txt_op_cd.Text = cmb_op.SelectedValue.ToString();
                    _form.txt_op_name.Text = cmb_op.GetItemText(cmb_op.SelectedIndex, 1);
                }
                else
                {
                    _form_input.txt_op_cd.Text = cmb_op.SelectedValue.ToString();
                    _form_input.txt_op_name.Text = cmb_op.GetItemText(cmb_op.SelectedIndex, 1);
                }
            }

            this.Close();

        }
    }
}

