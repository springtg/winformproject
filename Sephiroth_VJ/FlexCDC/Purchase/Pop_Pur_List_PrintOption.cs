using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FlexCDC.Purchase
{
    public partial class Pop_Pur_List_PrintOption : COM.PCHWinForm.Pop_Small
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성

        private string _form_type, _factory, _pur_user, _get_from, _get_to, _status, _pur_no, _datatype, _pur_div, _vendor;
        private string _style, _mat_name, _srf_no, _season, _category, _purpose, _cdc, _bom_id, _style_cd, _etc_from, _etc_to;
        
        public Purchase.Form_Swatch_Book swatch_book = null;
        public Product.Form_Prod_Result_OPCD product = null;        
        public Plan.Form_Plan_sch mps = null;

        private string _offer_no = "", _dept_cd = "", _date_from = "", _date_to = "";

        private string[] temp_value;
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
        #endregion

        #region 생성자
        public Pop_Pur_List_PrintOption()
        {
            InitializeComponent();
        }

        #region Purchase List
        public Pop_Pur_List_PrintOption(string arg_form_type, string arg_factory, string arg_pur_user, string arg_get_from, string arg_get_to, string arg_status, string arg_pur_no, string arg_datatype, string arg_pur_div, string arg_vendor, string arg_style, string arg_mat_name, string arg_srf_no, string arg_season, string arg_category, string arg_purpose, string arg_cdc, string arg_bom_id, string arg_style_cd, string arg_etc_from, string arg_etc_to)
        {
            _form_type = arg_form_type;

            _factory  = arg_factory;
            _pur_user = arg_pur_user; 
            _get_from = arg_get_from;
            _get_to   = arg_get_to; 
            _status   = arg_status;  
            
            _pur_no   = arg_pur_no;  
            _datatype = arg_datatype;  
            _pur_div  = arg_pur_div;  
            _vendor   = arg_vendor;  
            _style    = arg_style;  
            
            _mat_name = arg_mat_name;  
            _srf_no   = arg_srf_no; 
            _season   = arg_season;
            _category = arg_category;
            _purpose  = arg_purpose;

            _cdc      = arg_cdc;
            _bom_id   = arg_bom_id;
            _style_cd = arg_style_cd;

            _etc_from = arg_etc_from;
            _etc_to   = arg_etc_to;

            InitializeComponent();
        }
        #endregion

        #region Swatch Book
        public Pop_Pur_List_PrintOption(string arg_form_type, Purchase.Form_Swatch_Book arg_swatch)
        {
            _form_type = arg_form_type;
            swatch_book = arg_swatch;

            InitializeComponent();
        }
        #endregion

        #region Passcard Print
        public Pop_Pur_List_PrintOption(string arg_form_type, Plan.Form_Plan_sch arg_mps)
        {
            _form_type    = arg_form_type;            
            mps           = arg_mps;

            InitializeComponent();
        }
        #endregion

        #region Import Offer
        public Pop_Pur_List_PrintOption(string arg_form_type, string arg_offer_no, string arg_dept_cd, string arg_from, string arg_to)
        {
            _form_type = arg_form_type;
            
            _offer_no  = arg_offer_no;
            _dept_cd   = arg_dept_cd;
            _date_from = arg_from;
            _date_to   = arg_to;

            InitializeComponent();
        }
        #endregion

        #region Production Result by Operation
        public Pop_Pur_List_PrintOption(string arg_form_type, string [] arg_value, Product.Form_Prod_Result_OPCD arg_form)
        {
            _form_type = arg_form_type;
            temp_value = arg_value;
            product    = arg_form;

            InitializeComponent();
        }
        
        #endregion

        #region Purchase Order for SHC
        public Pop_Pur_List_PrintOption(string arg_form_type, string arg_factory, string arg_pur_no, string arg_ven_seq)
        {
            InitializeComponent();

            _form_type = arg_form_type;
            _factory   = arg_factory;
            _pur_no    = arg_pur_no;
            _vendor    = arg_ven_seq;
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

                if (_form_type == "PURCHASE_SHC")
                {
                    DataTable dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXP17");
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_print_option, 1, 2, false, 0, 257);

                    cmb_print_option.SelectedIndex = 0;
                }
                else
                {
                    cmb_print_option.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
                    cmb_print_option.ClearItems();

                    cmb_print_option.AddItemTitles("Code;Name");

                    cmb_print_option.ValueMember = "Code";
                    cmb_print_option.DisplayMember = "Name";

                    //////////////////////////////////////////////////////
                    if (_form_type == "PCC")
                    {
                        cmb_print_option.AddItem("1;Purchase List 1");
                        cmb_print_option.AddItem("2;Purchase List 2");
                    }
                    else if (_form_type == "SHC")
                    {
                        cmb_print_option.AddItem("1;Purchase List SHC 1");
                        cmb_print_option.AddItem("2;Purchase List SHC 2");
                    }
                    else if (_form_type == "SWATCH")
                    {
                        cmb_print_option.AddItem("1;Swatch Book Head");
                        cmb_print_option.AddItem("2;Swatch Book Tail");
                    }
                    else if (_form_type == "PCARD")
                    {
                        cmb_print_option.AddItem("1;Label Print");
                        cmb_print_option.AddItem("2;A4 Print");
                    }
                    else if (_form_type == "IMPORT")
                    {
                        cmb_print_option.AddItem("1;Print 1");
                        cmb_print_option.AddItem("2;Print 2");
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

                if (_form_type == "SWATCH")
                {
                    #region Swatch Book
                    string txt_Filename = "";
                    string Para = " ";

                    if (cmb_print_option.SelectedValue.ToString() == "1")
                    {
                        mrd_Filename = "Swatch_Book_10.mrd";
                        txt_Filename = "Swatch_Book.txt";
                        Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";


                        #region 파일만들기
                        FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                        if (!file.Exists)
                        {
                            file.Create().Close();
                        }
                        file = null;

                        FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(sDatalist);


                        for (int i = swatch_book.flg_pur_order.Rows.Fixed; i < swatch_book.flg_pur_order.Rows.Count; i++)
                        {
                            string sData = " ";

                            if (swatch_book.flg_pur_order[i, (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK].ToString().Trim().ToUpper() == "TRUE")
                            {

                                for (int j = 0; j < swatch_book.flg_pur_order.Cols.Count; j++)
                                {
                                    if (swatch_book.flg_pur_order[i, j] == null)
                                        sData = sData + "@";
                                    else
                                        sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + "@";
                                }
                                sw.WriteLine(sData);
                            }
                        }
                        sw.Flush();
                        sw.Close();
                        sDatalist.Close();
                        #endregion
                    }
                    if (cmb_print_option.SelectedValue.ToString() == "2")
                    {
                        mrd_Filename = "Swatch_Book_11.mrd";
                        txt_Filename = "Swatch_Book_02.txt";                      
                        Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";                                             

                        #region 파일만들기
                        FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                        if (!file.Exists)
                        {
                            file.Create().Close();
                        }
                        file = null;

                        FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(sDatalist);


                        for (int i = swatch_book.flg_pur_order.Rows.Fixed; i < swatch_book.flg_pur_order.Rows.Count; i++)
                        {
                            string sData = " ";

                            if (swatch_book.flg_pur_order[i, (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK].ToString().Trim().ToUpper() == "TRUE")
                            {

                                for (int j = 0; j < swatch_book.flg_pur_order.Cols.Count; j++)
                                {
                                    if (swatch_book.flg_pur_order[i, j] == null)
                                        sData = sData + "@";
                                    else
                                    {
                                        if (j == (int)ClassLib.TBSXP_SWATCH_BOX.IxMAT_NAME)
                                        {
                                            if (swatch_book.flg_pur_order[i, j + 1].ToString().Trim() == "")
                                                sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + "@";
                                            else
                                                sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + " / " + swatch_book.flg_pur_order[i, j + 1].ToString().Trim().Replace("\r\n", "") + "@";
                                        }
                                        else if (j == (int)ClassLib.TBSXP_SWATCH_BOX.IxCOLOR_CD)
                                        {
                                            if (swatch_book.flg_pur_order[i, j + 1].ToString().Trim() == "")
                                                sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + "@";
                                            else
                                                sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + " / " + swatch_book.flg_pur_order[i, j + 1].ToString().Trim().Replace("\r\n", "") + "@";
                                        }
                                        else if (j == (int)ClassLib.TBSXP_SWATCH_BOX.IxVALUE_PUR)
                                        {
                                            if (swatch_book.flg_pur_order[i, (int)ClassLib.TBSXP_SWATCH_BOX.IxVALUE_PUR].ToString().Trim() == "0")
                                                sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + "@";
                                            else
                                                sData = sData + "@";
                                        }
                                        else
                                        {
                                            sData = sData + swatch_book.flg_pur_order[i, j].ToString().Trim().Replace("\r\n", "") + "@";
                                        }
                                    }
                                }
                                sw.WriteLine(sData);
                            }
                        }
                        sw.Flush();
                        sw.Close();
                        sDatalist.Close();

                        #endregion                       
                    }
                        
                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);                        
                    report.ShowDialog();
                    #endregion
                }
                else if (_form_type == "PCARD")
                {
                    #region Passcard
                    string txt_Filename = "pcard_label.txt";
                    string Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";                   

                    if (cmb_print_option.SelectedValue.ToString() == "1")
                    {
                        mrd_Filename = "Passcard_Label.mrd";
                    }
                    if (cmb_print_option.SelectedValue.ToString() == "2")
                    {                       
                        mrd_Filename = "Passcard_system.mrd";   
                    }

                    #region 파일만들기
                    FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                    if (!file.Exists)
                    {
                        file.Create().Close();
                    }                    
                    #endregion

                    #region DataList 만들기
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
                        string level = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString();

                        if (level.Equals("99"))
                        {
                            string factory = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxFACTORY].ToString();
                            string lot_no = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                            string lot_seq = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();

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

                    #region 공정별 세팅
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

                        if (op_name.Equals("PU Spray"))
                        {
                            DataRow dr_print = dt_print.NewRow();

                            for (int col = 0; col < dt_print.Columns.Count; col++)
                            {
                                dr_print[col] = dt_data_sum.Rows[row].ItemArray[col].ToString();
                            }

                            dt_print.Rows.Add(dr_print); 
                        }
                    }

                    //Spray
                    for (int row = 0; row < dt_data_sum.Rows.Count; row++)
                    {
                        string op_name = dt_data_sum.Rows[row].ItemArray[8].ToString().Trim();

                        if (op_name.Equals("Spray"))
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

                        if (op_name.Equals("IP Spray"))
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

                    //int[] sct_rows = mps.flg_sch.Selections;

                    //for (int i = 0; i < sct_rows.Length; i++)
                    //{
                    //    string level = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxSORT_NO].ToString();

                    //    if (level.Equals("99"))
                    //    {
                    //        string factory = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxFACTORY].ToString();
                    //        string lot_no  = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                    //        string lot_seq = mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();

                    //        DataTable dt_ret = passcard_print(factory, lot_no, lot_seq);
                            
                    //        if (dt_ret.Rows.Count > 0)
                    //        {
                    //            for (int j = 0; j < dt_ret.Rows.Count; j++)
                    //            {
                    //                string sData = " ";

                    //                for (int k = 0; k < dt_ret.Columns.Count; k++)
                    //                {
                    //                    sData = sData + dt_ret.Rows[j].ItemArray[k].ToString() + "@";
                    //                }
                    //                sw.WriteLine(sData);
                    //            }
                    //        }
                    //    }
                    //}
                    //sw.Flush();
                    //sw.Close();
                    //sDatalist.Close();
                    #endregion                        

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                    report.ShowDialog();
                    #endregion
                }
                else if (_form_type == "IMPORT")
                {
                    #region Import Offer
                    if (cmb_print_option.SelectedValue.ToString() == "1")
                    {
                        if (_dept_cd == "000001") // 부서가 CDC일때
                            mrd_Filename = Application.StartupPath + @"\Import_offer_DS" + ".mrd";
                        else if (_dept_cd == "000002")//부서가 SHC일때
                            mrd_Filename = Application.StartupPath + @"\Import_offer_SH" + ".mrd";
                        else if (_dept_cd == "000003")//부서가 QD일때
                            mrd_Filename = Application.StartupPath + @"\Import_offer_QD" + ".mrd";
                        else // 부서가 VJ 일떄
                            mrd_Filename = Application.StartupPath + @"\Import_offer_VJ" + ".mrd";

                        sPara = " /rp " + "[" + _offer_no + "]";
                    }
                    if (cmb_print_option.SelectedValue.ToString() == "2")
                    {
                        mrd_Filename = Application.StartupPath + @"\BT01_40" + ".mrd";

                        sPara = " /rp " + "[" + _date_from + "]" + "[" + _date_to + "]";
                    }                    

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                    report.ShowDialog();
                    #endregion
                }
                else if (_form_type == "PRODUCT")
                {
                    #region Production Result by Operation
                    if (cmb_print_option.SelectedValue.ToString() == "1")
                    {
                        mrd_Filename = Application.StartupPath + @"\Product_Worksheet_result.mrd";
                        string txt_Filename = "Product_Worksheet.txt";
                        string Para = " ";

                        //파라미터
                        Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";

                        #region 파일만들기
                        FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                        if (!file.Exists)
                        {
                            file.Create().Close();
                        }
                        file = null;


                        FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(sDatalist, K_Encode);

                        #endregion

                        #region Data Flush
                        for (int i = product.fgrid_result.Rows.Fixed; i < product.fgrid_result.Rows.Count; i++)
                        {
                            string sData = "";

                            for (int j = 0; j < product.fgrid_result.Cols.Count; j++)
                            {
                                if (product.fgrid_result[i, j] == null)
                                {
                                    sData = sData + "@";
                                }
                                else
                                {
                                    if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxCOLOR_VER)
                                    {
                                        if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").Length > 15)
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 15) + " @";
                                        }
                                        else
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                                        }
                                    }
                                    else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxSTYLE_NAME)
                                    {
                                        
                                        sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                                        
                                    }
                                    else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxSAMPLE_TYPE)
                                    {
                                        if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").Length > 12)
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 12) + " @";
                                        }
                                        else
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                                        }
                                    }
                                    else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxREQ_YMD)
                                    {
                                        sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 5) + " @";
                                    }
                                    else if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxMAT_YMD || j == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxIN_YMD)
                                    {
                                        try
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Replace("-", "").Substring(0, 8) + " @";
                                        }
                                        catch
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                                        }
                                    }
                                    else if (j >= (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPC_DIR && j <= (int)ClassLib.TBSXG_PROD_RESULT_OP.IxO_FGA_RST)
                                    {
                                        if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").ToUpper() != "X" && product.fgrid_result[i, j].ToString().Replace("\r\n", "").Length > 2)
                                        {
                                            string date = product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(0, 2) + "/" + product.fgrid_result[i, j].ToString().Replace("\r\n", "").Substring(2, 2);
                                            sData = sData + date + " @";

                                            string rst_status = product.fgrid_result[i, j + 1].ToString().Replace("\r\n", "");
                                            sData = sData + rst_status + " @";
                                        }
                                        else if (product.fgrid_result[i, j].ToString().Replace("\r\n", "").ToUpper() == "X")
                                        {
                                            sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";

                                            sData = sData + "1" + " @";
                                        }
                                    }
                                    else
                                    {
                                        sData = sData + product.fgrid_result[i, j].ToString().Replace("\r\n", "") + " @";
                                    }
                                }
                            }
                            if (product.cmb_sort.SelectedValue.ToString() == "T")
                            {
                                sData = sData + "Request Time" + "@";
                            }
                            else
                            {
                                if (product.cmb_opcd.Text.Equals("ETS"))
                                {
                                    sData = sData + "Assembly" + "@";
                                }
                                else
                                {
                                    sData = sData + product.cmb_opcd.Text + "@";
                                }
                            }
                            sData = sData + product.dtp_from.Value.ToString("yyyy-MM-dd") + "~" + product.dtp_to.Value.ToString("yyyy-MM-dd") + "@";
                            sData = sData + product.cmb_opcd.SelectedValue.ToString() + "@";



                            if (product.cmb_sort.SelectedValue.ToString() == "T")
                            {
                                sData = sData + product.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxREQ_YMD].ToString().Replace("/", "").Substring(0, 2) + "/" + product.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxREQ_YMD].ToString().Replace("/", "").Substring(2, 2) + "@";
                            }
                            else
                            {
                                sData = sData + product.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxETS].ToString() + "@";
                            }
                            sData = sData + product.cmb_sort.SelectedValue.ToString() + "@";

                            sw.WriteLine(sData);
                        }

                        sw.Flush();
                        sw.Close();

                        sDatalist.Close();
                        #endregion

                        //Report View
                        FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                        report.ShowDialog();

                        //File Delete
                        FileInfo file_delete = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                        file_delete.Delete();
                    }
                    else if (cmb_print_option.SelectedValue.ToString() == "2")
                    {                        
                        mrd_Filename = Application.StartupPath + @"\Product_Worksheet_leadtime" + ".mrd";
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
                        mrd_Filename = Application.StartupPath + @"\Production_List" + ".mrd";
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
                                       + " [" + temp_value[11] + "]";
                        
                        FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                        report.ShowDialog();
                    }
                    #endregion
                }
                else if (_form_type == "PURCHASE_SHC")
                {
                    #region Purchase Order for SHC

                    string dept_cd = cmb_print_option.SelectedValue.ToString();
                    if (dept_cd == "000001") // 부서가 CDC일때
                        mrd_Filename = Application.StartupPath + @"\Import_offer_DS_new" + ".mrd";
                    else if (dept_cd == "000002")//부서가 SHC일때
                        mrd_Filename = Application.StartupPath + @"\Import_offer_SH_new" + ".mrd";
                    else if (dept_cd == "000003")//부서가 QD일때
                        mrd_Filename = Application.StartupPath + @"\Import_offer_QD_new" + ".mrd";
                    else if (dept_cd == "000004")// 부서가 VJ 일떄
                        mrd_Filename = Application.StartupPath + @"\Import_offer_VJ_new" + ".mrd";

                    sPara = " /rp " + "[" + _factory + "]" + " [" + _pur_no + "]" + " [" + _vendor + "]" + "[" + dept_cd + "]";
                                        
                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                    report.ShowDialog();
                    #endregion
                }
                else
                {
                    #region Purchase List
                    if (_form_type == "PCC")
                    {
                        if (cmb_print_option.SelectedValue.ToString() == "1")
                        {
                            mrd_Filename = Application.StartupPath + @"\Purchase_list" + ".mrd";
                        }
                        if (cmb_print_option.SelectedValue.ToString() == "2")
                        {
                            mrd_Filename = Application.StartupPath + @"\Purchase_List_02" + ".mrd";
                        }

                        sPara = " /rp " + "[" + _factory + "]"
                                        + " [" + _pur_user + "]"
                                        + " [" + _get_from + "]"
                                        + " [" + _get_to + "]"
                                        + " [" + _status + "]"
                                        + " [" + _pur_no + "]"
                                        + " [" + _datatype + "]"
                                        + " [" + _pur_div + "]"
                                        + " [" + _vendor + "]"
                                        + " [" + _style + "]"
                                        + " [" + _mat_name + "]"
                                        + " [" + _srf_no + "]"
                                        + " [" + _season + "]"
                                        + " [" + _category + "]"
                                        + " [" + _purpose + "]"
                                        + " [" + _cdc + "]"
                                        + " [" + _bom_id + "]"
                                        + " [" + _style_cd + "]"
                                        + " [" + _etc_from + "]"
                                        + " [" + _etc_to + "]";

                    }
                    if (_form_type == "SHC")
                    {
                        if (cmb_print_option.SelectedValue.ToString() == "1")
                        {
                            mrd_Filename = Application.StartupPath + @"\Purchase_list_shc" + ".mrd";
                        }
                        if (cmb_print_option.SelectedValue.ToString() == "2")
                        {
                            mrd_Filename = Application.StartupPath + @"\Purchase_list_shc_02" + ".mrd";
                        }

                        sPara = " /rp " + "[" + _factory + "]"
                                        + " [" + _pur_user + "]"
                                        + " [" + _get_from + "]"
                                        + " [" + _get_to + "]"
                                        + " [" + _status + "]"
                                        + " [" + _pur_no + "]"
                                        + " [" + _datatype + "]"
                                        + " [" + _pur_div + "]"
                                        + " [" + _vendor + "]"
                                        + " [" + _style + "]"
                                        + " [" + _mat_name + "]"
                                        + " [" + _srf_no + "]";
                    }
                    
                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara + " /rxlsnopb");
                    report.ShowDialog();
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

