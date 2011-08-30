using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;

namespace FlexCDC.Analisys
{
    public partial class Pop_DD_Report_Option : COM.PCHWinForm.Pop_Small
    {
        #region 생성자
        public Pop_DD_Report_Option()
        {
            InitializeComponent();
        }

        public Pop_DD_Report_Option(Form_EIS_DD_Report_New arg_form)
        {
            InitializeComponent();
            _main_form = arg_form;
        }
        #endregion

        #region 사용자 정의 변수        
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
        Form_EIS_DD_Report_New _main_form = null;
        #endregion


        #region Form Loading
        private void Pop_DD_Report_Option_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {
 
            }
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
                cmb_print_option.AddItem("1;DD Report");
                cmb_print_option.AddItem("2;DD Status");

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
        #endregion

        private void btn_apply_Click(object sender, EventArgs e)
        {
            string mrd_Filename = "";
            string sPara = "";

            if (cmb_print_option.SelectedValue.ToString() == "1")
            {                
                string txt_Filename = "DD_Report.txt";
                string Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";

                #region 파일만들기
                FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                if (!file.Exists)
                {
                    file.Create().Close();
                }

                FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(sDatalist, K_Encode);
                #endregion

                #region Level에 따른 Data Flush
                if (_main_form.lbl_viewSeason.Checked || _main_form.lbl_viewFactory.Checked) // 1, 2 Level
                {
                    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_new.mrd";

                    #region Data Flush
                    string season = "";

                    for (int i = _main_form.fgrid_Main.Rows.Fixed; i < _main_form.fgrid_Main.Rows.Count; i++)
                    {
                        string sData = "";
                        string lev = _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                        if (lev.Equals("1"))
                        {
                            season = _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Trim();
                        }
                        else if (lev.Equals("2"))
                        {
                            sData = season + "@" + _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                            for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; j < _main_form.fgrid_Main.Cols.Count; j++)
                            {
                                if (_main_form.fgrid_Main[i, j] == null)
                                {
                                    sData = sData + "@";
                                }
                                else
                                {
                                    sData = sData + _main_form.fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
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
                else if (_main_form.lbl_viewModel.Checked) // 3 Level
                {
                    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_4Level_new.mrd";

                    #region Data Flush
                    for (int i = _main_form.fgrid_Main.Rows.Fixed; i < _main_form.fgrid_Main.Rows.Count; i++)
                    {
                        string sData = "";

                        string lev = _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                        if (!lev.Equals("4"))
                        {
                            sData = lev + "@" + _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                            for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; j < _main_form.fgrid_Main.Cols.Count; j++)
                            {
                                if (_main_form.fgrid_Main[i, j] == null)
                                {
                                    sData = sData + "@";
                                }
                                else
                                {
                                    sData = sData + _main_form.fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
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
                else if (_main_form.lbl_viewBom.Checked) // 4 Level
                {
                    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_4Level_new.mrd";

                    #region Data Flush
                    for (int i = _main_form.fgrid_Main.Rows.Fixed; i < _main_form.fgrid_Main.Rows.Count; i++)
                    {
                        string sData = "";

                        string lev = _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                        sData = lev + "@" + _main_form.fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                        for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; j < _main_form.fgrid_Main.Cols.Count; j++)
                        {
                            if (_main_form.fgrid_Main[i, j] == null)
                            {
                                sData = sData + "@";
                            }
                            else
                            {
                                sData = sData + _main_form.fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                            }
                        }

                        sw.WriteLine(sData);
                    }

                    sw.Flush();
                    sw.Close();

                    sDatalist.Close();
                    #endregion
                }
                #endregion

                //Report View
                Report.Form_RdViewer report = new Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                report.ShowDialog();

                //File Delete
                file.Delete();
            }
            else if (cmb_print_option.SelectedValue.ToString() == "2")
            {
                mrd_Filename = Application.StartupPath + @"\Report\DD_Report_02" + ".mrd";

                string[] arg_value = new string[6];
                arg_value[0] = _main_form.cmb_Season_from.SelectedValue.ToString().Trim();
                arg_value[1] = _main_form.cmb_Season_to.SelectedValue.ToString().Trim();
                arg_value[2] = _main_form.cmb_factory.SelectedValue.ToString().Trim();
                arg_value[3] = _main_form.cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[4] = _main_form.cmb_category.SelectedValue.ToString().Trim();
                arg_value[5] = _main_form.cmb_model.SelectedValue.ToString().Trim();

                sPara = " /rp " + "[" + arg_value[0] + "]" + "[" + arg_value[1] + "]" + "[" + arg_value[2] + "]" + "[" + arg_value[3] + "]" + "[" + arg_value[4] + "]" + "[" + arg_value[5] + "]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();   
            }            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

