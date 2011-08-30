using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FlexCDC.Product_VJ
{
    public partial class Pop_Prod_PrintOption_VJ : COM.PCHWinForm.Pop_Small
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 立加 俺眉 积己

        private string _form_type;       
        
        public Product_VJ.Form_Prod_Result_OPCD_VJ product = null;
        public Product_VJ.Form_Plan_sch_VJ mps = null;

        
        private string[] temp_value;
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
        #endregion

        #region Resource
        public Pop_Prod_PrintOption_VJ()
        {
            InitializeComponent();
        }

        
        #region Passcard Print
        public Pop_Prod_PrintOption_VJ(string arg_form_type, Product_VJ.Form_Plan_sch_VJ arg_mps)
        {
            _form_type    = arg_form_type;            
            mps           = arg_mps;

            InitializeComponent();
        }
        #endregion

       
        #region Production Result by Operation
        public Pop_Prod_PrintOption_VJ(string arg_form_type, string[] arg_value, Product_VJ.Form_Prod_Result_OPCD_VJ arg_form)
        {
            _form_type = arg_form_type;
            temp_value = arg_value;
            product    = arg_form;

            InitializeComponent();
        }
        
        #endregion

       

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

                //////////////////////////////////////////////////////
                
                if (_form_type == "PCARD")
                {
                    cmb_print_option.AddItem("1;Label Print");
                    cmb_print_option.AddItem("2;A4 Print");
                }                
                else if (_form_type == "PRODUCT")
                {
                    cmb_print_option.AddItem("1;Daily Worksheet");
                    cmb_print_option.AddItem("2;Leadtime Analisys");
                    cmb_print_option.AddItem("3;Production Result List");
                }

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
                string mrd_Filename = "", sPara = "";

                if (_form_type == "PCARD")
                {
                    #region Passcard
                    string txt_Filename = "Report_VJ\\pcard_label.txt";
                    string Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";                   

                    if (cmb_print_option.SelectedValue.ToString() == "1")
                    {
                        mrd_Filename = "Report_VJ\\Passcard_Label_VJ.mrd";
                    }
                    if (cmb_print_option.SelectedValue.ToString() == "2")
                    {                       
                        mrd_Filename = "Report_VJ\\Passcard_system_VJ.mrd";   
                    }

                    #region File Create
                    FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                    if (!file.Exists)
                    {
                        file.Create().Close();
                    }                    
                    #endregion

                    #region DataList Setting
                    FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(sDatalist);
                    DataTable dt_data_sum = new DataTable("Pcard Data");
                    DataTable dt_print = new DataTable("Pcard Print");
                    dt_data_sum.Columns.Add("STYLE_NAME");
                    dt_data_sum.Columns.Add("BOM_STYLE");
                    dt_data_sum.Columns.Add("COLOR_VER");
                    dt_data_sum.Columns.Add("SAMPLE_TYPES");
                    dt_data_sum.Columns.Add("DIR_YMD");
                    dt_data_sum.Columns.Add("SEASON");
                    dt_data_sum.Columns.Add("GEN_SIZE");
                    dt_data_sum.Columns.Add("RST_QTY");
                    dt_data_sum.Columns.Add("OP_NAME");
                    dt_data_sum.Columns.Add("BAR_CODE");
                    dt_print.Columns.Add("STYLE_NAME");
                    dt_print.Columns.Add("BOM_STYLE");
                    dt_print.Columns.Add("COLOR_VER");
                    dt_print.Columns.Add("SAMPLE_TYPES");
                    dt_print.Columns.Add("DIR_YMD");
                    dt_print.Columns.Add("SEASON");
                    dt_print.Columns.Add("GEN_SIZE");
                    dt_print.Columns.Add("RST_QTY");
                    dt_print.Columns.Add("OP_NAME");
                    dt_print.Columns.Add("BAR_CODE");

                    int[] sct_rows = mps.flg_sch.Selections;

                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        string level = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString();

                        if (level.Equals("99"))
                        {
                            string factory = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                            string lot_no = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                            string lot_seq = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();

                            DataTable dt_ret = passcard_print(factory, lot_no, lot_seq);

                            if (dt_ret.Rows.Count > 0)
                            {
                                for (int j = 0; j < dt_ret.Rows.Count; j++)
                                {
                                    DataRow dr = dt_data_sum.NewRow();

                                    for (int cols = 0; cols < dt_print.Columns.Count; cols++)
                                    {
                                        dr[cols] = dt_ret.Rows[j].ItemArray[cols].ToString();
                                    }                                    
                                    dt_data_sum.Rows.Add(dr);
                                }
                            }
                        }
                    }

                    #region OP Setting
                    //Cutting
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("Cutting"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString(); 
                            }
                            
                            dt_print.Rows.Add(dr_print); 
                        }
                    }

                    //OS Press
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("OS Press"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString();
                            }

                            dt_print.Rows.Add(dr_print); 
                        }
                    }

                    //CMP Press
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("CMP Press"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString();
                            }

                            dt_print.Rows.Add(dr_print); 
                        }
                    }

                    //PU Spray
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("PU"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString();
                            }

                            dt_print.Rows.Add(dr_print); 
                        }
                    }

                    //H/F
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("H/F"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString();
                            }

                            dt_print.Rows.Add(dr_print);
                        }
                    }

                    //IP Spray
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("IP"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString();
                            }

                            dt_print.Rows.Add(dr_print); 
                        }
                    }
                    #endregion

                    for (int print_row = 0; print_row < dt_print.Rows.Count; print_row++)
                    {
                        string sData = " ";

                        for (int col = 0; col < dt_print.Columns.Count; col++)
                        {
                            sData = sData + dt_print.Rows[print_row].ItemArray[col].ToString() + "@";
                        }

                        sw.WriteLine(sData); 
                    }
                    sw.Flush();
                    sw.Close();
                    sDatalist.Close();                    
                    #endregion                        

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                    report.ShowDialog();
                    #endregion
                }                
                else if (_form_type == "PRODUCT")
                {
                    #region Production Result by Operation
                    if (cmb_print_option.SelectedValue.ToString() == "1")
                    {
                        mrd_Filename = Application.StartupPath + @"\Report_VJ\Product_Worksheet_result_VJ" + ".mrd";
                        sPara = " /rp " + "[" + temp_value[0] + "]"
                                       + " [" + temp_value[1] + "]"
                                       + " [" + temp_value[2] + "]"
                                       + " [" + temp_value[3] + "]"
                                       + " [" + temp_value[4] + "]"
                                       + " [" + temp_value[5] + "]"
                                       + " [" + temp_value[6] + "]"
                                       + " [" + temp_value[7] + "]"
                                       + " [" + temp_value[8] + "]"
                                       + " [" + temp_value[9] + "]"
                                       + " [" + temp_value[10] + "]"
                                       + " [" + temp_value[11] + "]"
                                       + " [" + temp_value[12] + "]";

                        FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                        report.ShowDialog();

                        #region mark
                        //mrd_Filename = Application.StartupPath + @"\Report_VJ\Product_Worksheet_result_VJ.mrd";
                        //string txt_Filename = "Report_VJ\\Product_Worksheet.txt";
                        //string Para = " ";
                                                
                        //Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";

                        //#region
                        //FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                        //if (!file.Exists)
                        //{
                        //    file.Create().Close();
                        //}
                        //file = null;


                        //FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                        //StreamWriter sw = new StreamWriter(sDatalist, K_Encode);

                        //#endregion

                        //#region Data Flush
                        //for (int i = product.fgrid_result.Rows.Fixed; i < product.fgrid_result.Rows.Count; i++)
                        //{
                        //    string sData = "";

                        //    for (int j = 0; j < product.fgrid_result.Cols.Count; j++)
                        //    {
                        //        if (product.fgrid_result[i, j] == null)
                        //        {
                        //            sData = sData + "@";
                        //        }
                        //        else
                        //        {
                        //            if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxCOLOR_VER)
                        //            {
                        //                if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").Length > 15)
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 15) + " @";
                        //                }
                        //                else
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                        //                }
                        //            }
                        //            else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTYLE_NAME)
                        //            {
                                        
                        //                sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                                        
                        //            }
                        //            else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSAMPLE_TYPE)
                        //            {
                        //                if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").Length > 12)
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 12) + " @";
                        //                }
                        //                else
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                        //                }
                        //            }
                        //            else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD)
                        //            {
                        //                sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 5) + " @";
                        //            }
                        //            else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD || j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD)
                        //            {
                        //                try
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Replace("-", "").Substring(0, 8) + " @";
                        //                }
                        //                catch
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                        //                }
                        //            }
                        //            else if (j >= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR && j <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxO_FGA_RST)
                        //            {
                        //                if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").ToUpper() != "X" && product.fgrid_result[i, j].ToString().Replace("\r\n", "").Length > 2)
                        //                {
                        //                    string date = product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 2) + "/" + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(2, 2);
                        //                    sData = sData + date + " @";

                        //                    string rst_status = product.fgrid_result[i, j + 1].ToString().Replace("\r\n", "");
                        //                    sData = sData + rst_status + " @";
                        //                }
                        //                else if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").ToUpper() == "X")
                        //                {
                        //                    sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";

                        //                    sData = sData + "1" + " @";
                        //                }
                        //            }
                        //            else
                        //            {
                        //                sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                        //            }
                        //        }
                        //    }
                        //    if (product.cmb_sort.SelectedValue.ToString() == "T")
                        //    {
                        //        sData = sData + "Request Time" + "@";
                        //    }
                        //    else
                        //    {
                        //        if (product.cmb_opcd.Text.Equals("ETS"))
                        //        {
                        //            sData = sData + "Assembly" + "@";
                        //        }
                        //        else
                        //        {
                        //            sData = sData + product.cmb_opcd.Text + "@";
                        //        }
                        //    }
                        //    sData = sData + product.dtp_from.Value.ToString("yyyy-MM-dd") + "~" + product.dtp_to.Value.ToString("yyyy-MM-dd") + "@";
                        //    sData = sData + product.cmb_opcd.SelectedValue.ToString() + "@";



                        //    if (product.cmb_sort.SelectedValue.ToString() == "T")
                        //    {
                        //        sData = sData + product.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD].ToString().Replace("/", "").Substring(0, 2) + "/" + product.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD].ToString().Replace("/", "").Substring(2, 2) + "@";
                        //    }
                        //    else
                        //    {
                        //        sData = sData + product.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxETS].ToString() + "@";
                        //    }
                        //    sData = sData + product.cmb_sort.SelectedValue.ToString() + "@";

                        //    sw.WriteLine(sData);
                        //}

                        //sw.Flush();
                        //sw.Close();

                        //sDatalist.Close();
                        //#endregion

                        ////Report View
                        //FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                        //report.ShowDialog();

                        ////File Delete
                        //FileInfo file_delete = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                        //file_delete.Delete();
                        #endregion
                    }
                    else if (cmb_print_option.SelectedValue.ToString() == "2")
                    {
                        mrd_Filename = Application.StartupPath + @"\Report_VJ\Product_Worksheet_leadtime_VJ" + ".mrd";
                        sPara = " /rp " + "[" + temp_value[0] + "]" 
                                       + " [" + temp_value[1] + "]" 
                                       + " [" + temp_value[2] + "]" 
                                       + " [" + temp_value[3] + "]" 
                                       + " [" + temp_value[4] + "]"
                                       + " [" + temp_value[5] + "]" 
                                       + " [" + temp_value[6] + "]" 
                                       + " [" + temp_value[7] + "]" 
                                       + " [" + temp_value[8] + "]" 
                                       + " [" + temp_value[9] + "]"
                                       + " [" + temp_value[10] + "]";
                        
                        FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                        report.ShowDialog();
                    }
                    else
                    {
                        mrd_Filename = Application.StartupPath + @"\Report_VJ\Production_List_VJ10" + ".mrd";
                        sPara = " /rp " + "[" + temp_value[0] + "]" 
                                       + " [" + temp_value[1] + "]" 
                                       + " [" + temp_value[2] + "]" 
                                       + " [" + temp_value[3] + "]" 
                                       + " [" + temp_value[4] + "]"
                                       + " [" + temp_value[5] + "]" 
                                       + " [" + temp_value[6] + "]" 
                                       + " [" + temp_value[7] + "]" 
                                       + " [" + temp_value[8] + "]" 
                                       + " [" + temp_value[9] + "]"
                                       + " [" + temp_value[10] + "]"
                                       + " [" + temp_value[11] + "]"
                                       + " [" + temp_value[12] + "]";
                        
                        FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                        report.ShowDialog();
                    }
                    #endregion
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

        #region DB Connect
        private DataTable passcard_print(string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            string Proc_Name = "pkg_sxg_mps_02_select.select_passcard_print";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_lot_no";
            MyOraDB.Parameter_Name[2] = "arg_lot_seq";
            MyOraDB.Parameter_Name[3] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_lot_no;
            MyOraDB.Parameter_Values[2] = arg_lot_seq;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

    }
}

