using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class Header
    {
        private COM.OraDB MyOraDB = new COM.OraDB();

        private Microsoft.Office.Interop.Excel.Workbook workbook = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

        private string version = "";

        private string factory = "";
        private string style_cd = "";
        private string obs_01 = "";
        private string obs_02 = "";
        private string obs_03 = "";
        private string obs_type = "";
        private string bom_id = "";

        private string mo_alias = "";
        private string fob_type = ""; // round

        #region 0. 버전 체크하기

        // 1. 버전 체크
        public bool CheckExcelFile()
        {
            try
            {
                string sheet_name = worksheet.Name;

                try
                {
                    #region Version Check

                    string version_name = (worksheet.get_Range(worksheet.Cells[1, 21], worksheet.Cells[1, 21]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 21], worksheet.Cells[1, 21]).Value2.ToString().Trim().ToUpper();

                    if (version_name.Equals("VERSION:"))
                    {
                        string version_check = (worksheet.get_Range(worksheet.Cells[1, 22], worksheet.Cells[1, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 22], worksheet.Cells[1, 22]).Value2.ToString().Trim();

                        if (version_check.Equals(""))
                        {
                            MessageBox.Show("Version : " + sheet_name + "\r\n\r\n" + "Version Position is wrong");
                            return false;
                        }
                        else
                        {
                            version = version_check;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Version : " + sheet_name + "\r\n\r\n" + "Version Position is wrong");
                        return false;
                    }

                    #endregion

                    #region Head Data Check
                    //Model


                    string model_title = (worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 1]).Value2.ToString().Trim();
                    string model_value = (worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Value2.ToString().Trim();



                    if (!model_title.Equals("MODEL") || model_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Model Data is worng.");
                        return false;
                    }

                    //MO ID
                    string mo_id_title = (worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[3, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[3, 1]).Value2.ToString().Trim().Replace(" ", "").ToUpper();
                    string mo_id_value = (worksheet.get_Range(worksheet.Cells[3, 4], worksheet.Cells[3, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 4], worksheet.Cells[3, 4]).Value2.ToString().Trim().Replace("-", "");

                    if ((!mo_id_title.Equals("MODELOFFERINGID") && !mo_id_title.Equals("DEVPROJALIAS")) || mo_id_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Model Offering ID Data is worng.");
                        return false;
                    }

                    //BOM ID
                    string bom_id_title = (worksheet.get_Range(worksheet.Cells[5, 1], worksheet.Cells[5, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 1], worksheet.Cells[5, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string bom_id_value = (worksheet.get_Range(worksheet.Cells[5, 4], worksheet.Cells[5, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 4], worksheet.Cells[5, 4]).Value2.ToString().Trim();

                    if (!bom_id_title.Equals("BOMID") || bom_id_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "BOM ID Data is worng.");
                        return false;
                    }

                    //Primary Production(Factory)
                    string factory_title = (worksheet.get_Range(worksheet.Cells[9, 1], worksheet.Cells[9, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 1], worksheet.Cells[9, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string factory_value = (worksheet.get_Range(worksheet.Cells[9, 4], worksheet.Cells[9, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 4], worksheet.Cells[9, 4]).Value2.ToString().Trim();

                    if (!factory_title.Equals("PRIMARYPRODUCTION") || factory_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Primary Production (Factory) Data is worng.");
                        return false;
                    }
                    else if (!factory_value.Equals("DS") && !factory_value.Equals("QD") && !factory_value.Equals("VJ"))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Primary Production (Factory) Data is worng.");
                        return false;
                    }

                    //Category
                    string category_title = (worksheet.get_Range(worksheet.Cells[11, 1], worksheet.Cells[11, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[11, 1], worksheet.Cells[11, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string category_value = (worksheet.get_Range(worksheet.Cells[11, 4], worksheet.Cells[11, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[11, 4], worksheet.Cells[11, 4]).Value2.ToString().Trim();

                    if (!category_title.Equals("CATEGORY") || category_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "CATEGORY Data is worng.");
                        return false;
                    }

                    //FOB Status
                    string fob_status_title = (worksheet.get_Range(worksheet.Cells[13, 1], worksheet.Cells[13, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[13, 1], worksheet.Cells[13, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string fob_status_value = (worksheet.get_Range(worksheet.Cells[13, 4], worksheet.Cells[13, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[13, 4], worksheet.Cells[13, 4]).Value2.ToString().Trim();

                    if (!fob_status_title.Equals("FOBSTATUS") || fob_status_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "FOB STATUS Data is worng.");
                        return false;
                    }

                    //FOB Type
                    string fob_type_title = (worksheet.get_Range(worksheet.Cells[15, 1], worksheet.Cells[15, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[15, 1], worksheet.Cells[15, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string fob_type_value = (worksheet.get_Range(worksheet.Cells[15, 4], worksheet.Cells[15, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[15, 4], worksheet.Cells[15, 4]).Value2.ToString().Trim();

                    if (!fob_type_title.Equals("FOBTYPE") || fob_type_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "FOB Type Data is worng.");
                        return false;
                    }

                    if (fob_type_value.Equals("CFM"))
                    {
                        //Product Code(Style Code)
                        string style_cd_title = (worksheet.get_Range(worksheet.Cells[7, 1], worksheet.Cells[7, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 1], worksheet.Cells[7, 1]).Value2.ToString().Trim().Replace(" ", "");
                        string style_cd_value = (worksheet.get_Range(worksheet.Cells[7, 4], worksheet.Cells[7, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 4], worksheet.Cells[7, 4]).Value2.ToString().Trim();

                        if (!style_cd_title.Equals("PRODUCTCODE") || style_cd_value.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product Code (Style Code) Data is worng.");
                            return false;
                        }
                    }

                    //Season
                    string season_title = (worksheet.get_Range(worksheet.Cells[17, 1], worksheet.Cells[17, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 1], worksheet.Cells[17, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string season_value = (worksheet.get_Range(worksheet.Cells[17, 4], worksheet.Cells[17, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 4], worksheet.Cells[17, 4]).Value2.ToString().Trim();

                    if (!season_title.Equals("SEASON") || season_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Season Data is worng.");
                        return false;
                    }

                    //Date Quoted
                    string date_q_title = (worksheet.get_Range(worksheet.Cells[19, 1], worksheet.Cells[19, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 1], worksheet.Cells[19, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string date_q_value = (worksheet.get_Range(worksheet.Cells[19, 4], worksheet.Cells[19, 4]).Text == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 4], worksheet.Cells[19, 4]).Text.ToString().Trim();

                    if (date_q_title.Equals("DATEQUOTED"))
                    {
                        try
                        {
                            int yyyy = int.Parse("20" + date_q_value.Substring(date_q_value.Length - 2, 2));
                            int mm = int.Parse(date_q_value.Substring(0, date_q_value.IndexOf("-")));
                            int dd = int.Parse(date_q_value.Substring(date_q_value.IndexOf("-") + 1, 2).Replace("-", ""));
                            DateTime quo = new DateTime(yyyy, mm, dd);
                            date_q_value = quo.ToString("yyyy-MM-dd");
                        }
                        catch
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Date Quoted Data is worng.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Date Quoted Data is worng.");
                        return false;
                    }

                    //Gender
                    string gender_title = (worksheet.get_Range(worksheet.Cells[21, 1], worksheet.Cells[21, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 1], worksheet.Cells[21, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string gender_value = (worksheet.get_Range(worksheet.Cells[21, 4], worksheet.Cells[21, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 4], worksheet.Cells[21, 4]).Value2.ToString().Trim();

                    if (!gender_title.Equals("GENDER") || gender_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Gender Data is worng.");
                        return false;
                    }

                    //Size
                    string size_title = (worksheet.get_Range(worksheet.Cells[22, 1], worksheet.Cells[22, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 1], worksheet.Cells[22, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string size_value = (worksheet.get_Range(worksheet.Cells[22, 4], worksheet.Cells[22, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 4], worksheet.Cells[22, 4]).Value2.ToString().Trim();

                    if (!size_title.Equals("SIZE") || size_value.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Size is worng.");
                        return false;
                    }

                    //Size
                    string size_up_title = (worksheet.get_Range(worksheet.Cells[23, 1], worksheet.Cells[23, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 1], worksheet.Cells[23, 1]).Value2.ToString().Trim().Replace(" ", "");
                    string size_up_value = (worksheet.get_Range(worksheet.Cells[23, 4], worksheet.Cells[23, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 4], worksheet.Cells[23, 4]).Value2.ToString().Trim();

                    if (!size_up_title.Equals("SIZEUP%"))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Size Up % is worng.");
                        return false;
                    }

                    #endregion

                    if (version.Equals("1.153"))
                    {
                        #region Material
                        string m_upper_name = (worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2.ToString().Trim();
                        string m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        if (!m_upper_name.Equals("UPPER MATERIALS") || m_upper.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "UPPER MATERIAL is empty");
                            return false;
                        }
                        string m_packaging_name = (worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2.ToString().Trim();
                        string m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        if (!m_packaging_name.Equals("PACKAGING") || m_packaging.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PACKAGING is empty");
                            return false;
                        }
                        string m_midsole_name = (worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2.ToString().Trim();
                        string m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        if (!m_midsole_name.Equals("MIDSOLE") || m_midsole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MIDSOLE is empty");
                            return false;
                        }
                        string m_out_sole_name = (worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2.ToString().Trim();
                        string m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        if (!m_out_sole_name.Equals("OUTSOLE") || m_out_sole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "OUTSOLE is empty");
                            return false;
                        }
                        string m_size_up_name = (worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2.ToString().Trim();
                        string m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        if (!m_size_up_name.Equals("SIZE UP") || m_size_up.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SIZE UP is empty");
                            return false;
                        }
                        string m_price_name = (worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2.ToString().Trim();
                        string m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        if (!m_price_name.Equals("MATERIALS SUBTOTAL") || m_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        string m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString().Trim();
                        if (m_ratio.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL % of FOB is empty");
                            return false;
                        }
                        #endregion

                        #region Non Materials
                        string nm_price_name = (worksheet.get_Range(worksheet.Cells[16, 8], worksheet.Cells[16, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[16, 8], worksheet.Cells[16, 8]).Value2.ToString().Trim();
                        string nm_price = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        if (!nm_price_name.Equals("NON MATERIALS SUBTOTAL") || nm_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "NON MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region Tooling
                        string t_sample_name = (worksheet.get_Range(worksheet.Cells[19, 9], worksheet.Cells[19, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 9], worksheet.Cells[19, 9]).Value2.ToString().Trim();
                        string t_sample = (worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2.ToString().Trim();
                        if (!t_sample_name.Equals("SAMPLE TOOLING") || t_sample.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SAMPLE TOOLING is empty");
                            return false;
                        }
                        string t_production_name = (worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2.ToString().Trim();
                        string t_production = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        if (!t_production_name.Equals("PRODUCTION TOOLING") || t_production.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PRODUCTION TOOLING is empty");
                            return false;
                        }
                        string tooling_name = (worksheet.get_Range(worksheet.Cells[21, 8], worksheet.Cells[21, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 8], worksheet.Cells[21, 8]).Value2.ToString().Trim();
                        string tooling = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        if (!tooling_name.Equals("TOOLING SUBTOTAL") || tooling.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOOLING SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region FOB
                        string fob_name = (worksheet.get_Range(worksheet.Cells[23, 8], worksheet.Cells[23, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 8], worksheet.Cells[23, 8]).Value2.ToString().Trim();
                        string fob = (worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2.ToString().Trim();
                        if (!fob_name.Equals("TOTAL FOB WITH TOOLING") || fob.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOTAL FOB WITH TOOLING is empty");
                            return false;
                        }
                        #endregion
                    }
                    else if (version.Equals("1.154"))
                    {
                        #region Material
                        string m_upper_name = (worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2.ToString().Trim();
                        string m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        if (!m_upper_name.Equals("UPPER MATERIALS") || m_upper.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "UPPER MATERIAL is empty");
                            return false;
                        }
                        string m_packaging_name = (worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2.ToString().Trim();
                        string m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        if (!m_packaging_name.Equals("PACKAGING") || m_packaging.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PACKAGING is empty");
                            return false;
                        }
                        string m_midsole_name = (worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2.ToString().Trim();
                        string m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        if (!m_midsole_name.Equals("MIDSOLE") || m_midsole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MIDSOLE is empty");
                            return false;
                        }
                        string m_out_sole_name = (worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2.ToString().Trim();
                        string m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        if (!m_out_sole_name.Equals("OUTSOLE") || m_out_sole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "OUTSOLE is empty");
                            return false;
                        }
                        string m_size_up_name = (worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2.ToString().Trim();
                        string m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        if (!m_size_up_name.Equals("SIZE UP") || m_size_up.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SIZE UP is empty");
                            return false;
                        }
                        string m_price_name = (worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2.ToString().Trim();
                        string m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        if (!m_price_name.Equals("MATERIALS SUBTOTAL") || m_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        string m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString().Trim();
                        if (m_ratio.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL % of FOB is empty");
                            return false;
                        }
                        #endregion

                        #region Non Materials
                        string nm_price_name = (worksheet.get_Range(worksheet.Cells[16, 8], worksheet.Cells[16, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[16, 8], worksheet.Cells[16, 8]).Value2.ToString().Trim();
                        string nm_price = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        if (!nm_price_name.Equals("NON MATERIALS SUBTOTAL") || nm_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "NON MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region Tooling
                        string t_sample_name = (worksheet.get_Range(worksheet.Cells[19, 9], worksheet.Cells[19, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 9], worksheet.Cells[19, 9]).Value2.ToString().Trim();
                        string t_sample = (worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2.ToString().Trim();
                        if (!t_sample_name.Equals("SAMPLE TOOLING") || t_sample.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SAMPLE TOOLING is empty");
                            return false;
                        }
                        string t_production_name = (worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2.ToString().Trim();
                        string t_production = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        if (!t_production_name.Equals("PRODUCTION TOOLING") || t_production.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PRODUCTION TOOLING is empty");
                            return false;
                        }
                        string tooling_name = (worksheet.get_Range(worksheet.Cells[21, 8], worksheet.Cells[21, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 8], worksheet.Cells[21, 8]).Value2.ToString().Trim();
                        string tooling = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        if (!tooling_name.Equals("TOOLING SUBTOTAL") || tooling.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOOLING SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region FOB
                        string fob_name = (worksheet.get_Range(worksheet.Cells[23, 8], worksheet.Cells[23, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 8], worksheet.Cells[23, 8]).Value2.ToString().Trim();
                        string fob = (worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2.ToString().Trim();
                        if (!fob_name.Equals("TOTAL FOB WITH TOOLING") || fob.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOTAL FOB WITH TOOLING is empty");
                            return false;
                        }
                        #endregion
                    }
                    else if (version.Equals("1.157"))
                    {
                        #region Material
                        string m_upper_name = (worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2.ToString().Trim();
                        string m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        if (!m_upper_name.Equals("UPPER MATERIALS") || m_upper.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "UPPER MATERIAL is empty");
                            return false;
                        }
                        string m_packaging_name = (worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2.ToString().Trim();
                        string m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        if (!m_packaging_name.Equals("PACKAGING") || m_packaging.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PACKAGING is empty");
                            return false;
                        }
                        string m_midsole_name = (worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2.ToString().Trim();
                        string m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        if (!m_midsole_name.Equals("MIDSOLE") || m_midsole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MIDSOLE is empty");
                            return false;
                        }
                        string m_out_sole_name = (worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2.ToString().Trim();
                        string m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        if (!m_out_sole_name.Equals("OUTSOLE") || m_out_sole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "OUTSOLE is empty");
                            return false;
                        }
                        string m_size_up_name = (worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2.ToString().Trim();
                        string m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        if (!m_size_up_name.Equals("SIZE UP") || m_size_up.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SIZE UP is empty");
                            return false;
                        }
                        string m_price_name = (worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2.ToString().Trim();
                        string m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        if (!m_price_name.Equals("MATERIALS SUBTOTAL") || m_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        string m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString().Trim();
                        if (m_ratio.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL % of FOB is empty");
                            return false;
                        }
                        #endregion

                        #region Non Materials
                        string nm_price_name = (worksheet.get_Range(worksheet.Cells[17, 8], worksheet.Cells[17, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 8], worksheet.Cells[17, 8]).Value2.ToString().Trim();
                        string nm_price = (worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2.ToString().Trim();
                        if (!nm_price_name.Equals("NON MATERIALS SUBTOTAL") || nm_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "NON MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region Tooling
                        string t_sample_name = (worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2.ToString().Trim();
                        string t_sample = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        if (!t_sample_name.Equals("SAMPLE TOOLING") || t_sample.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SAMPLE TOOLING is empty");
                            return false;
                        }
                        string t_production_name = (worksheet.get_Range(worksheet.Cells[21, 9], worksheet.Cells[21, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 9], worksheet.Cells[21, 9]).Value2.ToString().Trim();
                        string t_production = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        if (!t_production_name.Equals("PRODUCTION TOOLING") || t_production.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PRODUCTION TOOLING is empty");
                            return false;
                        }
                        string tooling_name = (worksheet.get_Range(worksheet.Cells[22, 8], worksheet.Cells[22, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 8], worksheet.Cells[22, 8]).Value2.ToString().Trim();
                        string tooling = (worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2.ToString().Trim();
                        if (!tooling_name.Equals("TOOLING SUBTOTAL") || tooling.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOOLING SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region FOB
                        string fob_name = (worksheet.get_Range(worksheet.Cells[24, 8], worksheet.Cells[24, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[24, 8], worksheet.Cells[24, 8]).Value2.ToString().Trim();
                        string fob = (worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2.ToString().Trim();
                        if (!fob_name.Equals("TOTAL FOB WITH TOOLING") || fob.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOTAL FOB WITH TOOLING is empty");
                            return false;
                        }
                        #endregion
                    }
                    else if (version.Equals("1.2"))
                    {
                        #region Material
                        string m_upper_name = (worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2.ToString().Trim();
                        string m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        if (!m_upper_name.Equals("UPPER MATERIALS") || m_upper.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "UPPER MATERIAL is empty");
                            return false;
                        }
                        string m_packaging_name = (worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2.ToString().Trim();
                        string m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        if (!m_packaging_name.Equals("PACKAGING") || m_packaging.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PACKAGING is empty");
                            return false;
                        }
                        string m_midsole_name = (worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2.ToString().Trim();
                        string m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        if (!m_midsole_name.Equals("MIDSOLE") || m_midsole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MIDSOLE is empty");
                            return false;
                        }
                        string m_out_sole_name = (worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2.ToString().Trim();
                        string m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        if (!m_out_sole_name.Equals("OUTSOLE") || m_out_sole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "OUTSOLE is empty");
                            return false;
                        }
                        string m_size_up_name = (worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2.ToString().Trim();
                        string m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        if (!m_size_up_name.Equals("SIZE UP") || m_size_up.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SIZE UP is empty");
                            return false;
                        }
                        string m_price_name = (worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2.ToString().Trim();
                        string m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        if (!m_price_name.Equals("MATERIALS SUBTOTAL") || m_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        string m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString().Trim();
                        if (m_ratio.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL % of FOB is empty");
                            return false;
                        }
                        #endregion

                        #region Non Materials
                        string nm_price_name = (worksheet.get_Range(worksheet.Cells[17, 8], worksheet.Cells[17, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 8], worksheet.Cells[17, 8]).Value2.ToString().Trim();
                        string nm_price = (worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2.ToString().Trim();
                        if (!nm_price_name.Equals("NON MATERIALS SUBTOTAL") || nm_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "NON MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region Tooling
                        string t_sample_name = (worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2.ToString().Trim();
                        string t_sample = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        if (!t_sample_name.Equals("SAMPLE TOOLING") || t_sample.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SAMPLE TOOLING is empty");
                            return false;
                        }
                        string t_production_name = (worksheet.get_Range(worksheet.Cells[21, 9], worksheet.Cells[21, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 9], worksheet.Cells[21, 9]).Value2.ToString().Trim();
                        string t_production = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        if (!t_production_name.Equals("PRODUCTION TOOLING") || t_production.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PRODUCTION TOOLING is empty");
                            return false;
                        }
                        string tooling_name = (worksheet.get_Range(worksheet.Cells[22, 8], worksheet.Cells[22, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 8], worksheet.Cells[22, 8]).Value2.ToString().Trim();
                        string tooling = (worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2.ToString().Trim();
                        if (!tooling_name.Equals("TOOLING SUBTOTAL") || tooling.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOOLING SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region FOB
                        string fob_name = (worksheet.get_Range(worksheet.Cells[24, 8], worksheet.Cells[24, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[24, 8], worksheet.Cells[24, 8]).Value2.ToString().Trim();
                        string fob = (worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2.ToString().Trim();
                        if (!fob_name.Equals("TOTAL FOB WITH TOOLING") || fob.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOTAL FOB WITH TOOLING is empty");
                            return false;
                        }
                        #endregion
                    }
                    else if (version.Equals("1.22"))
                    {
                        #region Material
                        string m_upper_name = (worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 9]).Value2.ToString().Trim();
                        string m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        if (!m_upper_name.Equals("UPPER MATERIALS") || m_upper.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "UPPER MATERIAL is empty");
                            return false;
                        }
                        string m_packaging_name = (worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 9]).Value2.ToString().Trim();
                        string m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        if (!m_packaging_name.Equals("PACKAGING") || m_packaging.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PACKAGING is empty");
                            return false;
                        }
                        string m_midsole_name = (worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 9]).Value2.ToString().Trim();
                        string m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        if (!m_midsole_name.Equals("MIDSOLE") || m_midsole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MIDSOLE is empty");
                            return false;
                        }
                        string m_out_sole_name = (worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Value2.ToString().Trim();
                        string m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        if (!m_out_sole_name.Equals("OUTSOLE") || m_out_sole.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "OUTSOLE is empty");
                            return false;
                        }
                        string m_size_up_name = (worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 9], worksheet.Cells[8, 9]).Value2.ToString().Trim();
                        string m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        if (!m_size_up_name.Equals("SIZE UP") || m_size_up.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SIZE UP is empty");
                            return false;
                        }
                        string m_price_name = (worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 8], worksheet.Cells[9, 8]).Value2.ToString().Trim();
                        string m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        if (!m_price_name.Equals("MATERIALS SUBTOTAL") || m_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        string m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString().Trim();
                        if (m_ratio.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "MATERIALS SUBTOTAL % of FOB is empty");
                            return false;
                        }
                        #endregion

                        #region Non Materials
                        string nm_price_name = (worksheet.get_Range(worksheet.Cells[17, 8], worksheet.Cells[17, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 8], worksheet.Cells[17, 8]).Value2.ToString().Trim();
                        string nm_price = (worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2.ToString().Trim();
                        if (!nm_price_name.Equals("NON MATERIALS SUBTOTAL") || nm_price.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "NON MATERIALS SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region Tooling
                        string t_sample_name = (worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 9], worksheet.Cells[20, 9]).Value2.ToString().Trim();
                        string t_sample = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        if (!t_sample_name.Equals("SAMPLE TOOLING") || t_sample.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SAMPLE TOOLING is empty");
                            return false;
                        }
                        string t_production_name = (worksheet.get_Range(worksheet.Cells[21, 9], worksheet.Cells[21, 9]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 9], worksheet.Cells[21, 9]).Value2.ToString().Trim();
                        string t_production = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        if (!t_production_name.Equals("PRODUCTION TOOLING") || t_production.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "PRODUCTION TOOLING is empty");
                            return false;
                        }
                        string tooling_name = (worksheet.get_Range(worksheet.Cells[22, 8], worksheet.Cells[22, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 8], worksheet.Cells[22, 8]).Value2.ToString().Trim();
                        string tooling = (worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2.ToString().Trim();
                        if (!tooling_name.Equals("TOOLING SUBTOTAL") || tooling.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOOLING SUBTOTAL is empty");
                            return false;
                        }
                        #endregion

                        #region FOB
                        string fob_name = (worksheet.get_Range(worksheet.Cells[24, 8], worksheet.Cells[24, 8]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[24, 8], worksheet.Cells[24, 8]).Value2.ToString().Trim();
                        string fob = (worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2.ToString().Trim();
                        if (!fob_name.Equals("TOTAL FOB WITH TOOLING") || fob.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TOTAL FOB WITH TOOLING is empty");
                            return false;
                        }
                        #endregion
                    }
                    else
                    {
                        MessageBox.Show("Version : " + sheet_name + "\r\n\r\n" + "This Version is worng, Please ask System.");
                        return false;
                    }

                    #region Exchange Rate

                    string rate_idr = (worksheet.get_Range(worksheet.Cells[3, 18], worksheet.Cells[3, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 18], worksheet.Cells[3, 18]).Value2.ToString().Trim();
                    if (rate_idr.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (IDR) is empty");
                        return false;
                    }
                    string rate_inr = (worksheet.get_Range(worksheet.Cells[4, 18], worksheet.Cells[4, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 18], worksheet.Cells[4, 18]).Value2.ToString().Trim();
                    if (rate_inr.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (INR) is empty");
                        return false;
                    }
                    string rate_krw = (worksheet.get_Range(worksheet.Cells[5, 18], worksheet.Cells[5, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 18], worksheet.Cells[5, 18]).Value2.ToString().Trim();
                    if (rate_krw.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (KRW) is empty");
                        return false;
                    }
                    string rate_rmb = (worksheet.get_Range(worksheet.Cells[6, 18], worksheet.Cells[6, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 18], worksheet.Cells[6, 18]).Value2.ToString().Trim();
                    if (rate_rmb.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (RMB) is empty");
                        return false;
                    }
                    string rate_thb = (worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).Value2.ToString().Trim();
                    if (rate_thb.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (THB) is empty");
                        return false;
                    }
                    string rate_twd = (worksheet.get_Range(worksheet.Cells[8, 18], worksheet.Cells[8, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 18], worksheet.Cells[8, 18]).Value2.ToString().Trim();
                    if (rate_twd.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (TWD) is empty");
                        return false;
                    }
                    string rate_usd = (worksheet.get_Range(worksheet.Cells[9, 18], worksheet.Cells[9, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 18], worksheet.Cells[9, 18]).Value2.ToString().Trim();
                    if (rate_usd.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (USD) is empty");
                        return false;
                    }
                    string rate_vnd = (worksheet.get_Range(worksheet.Cells[10, 18], worksheet.Cells[10, 18]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[10, 18], worksheet.Cells[10, 18]).Value2.ToString().Trim();
                    if (rate_vnd.Equals(""))
                    {
                        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "F/X Rate (VND) is empty");
                        return false;
                    }
                    #endregion

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion


        #region 1, 데이터 테이블 만들기

        public System.Data.DataTable CreateNewDateTable()
        {
            try
            {
                System.Data.DataTable vDT = new System.Data.DataTable("Header");

                vDT.Columns.Add(new DataColumn("DIV"));
                vDT.Columns.Add(new DataColumn("ROUND"));
                vDT.Columns.Add(new DataColumn("FACTORY"));
                vDT.Columns.Add(new DataColumn("SEASON"));
                vDT.Columns.Add(new DataColumn("CATEGORY"));
                vDT.Columns.Add(new DataColumn("STYLE_NAME"));
                vDT.Columns.Add(new DataColumn("STYLE_CD"));
                vDT.Columns.Add(new DataColumn("OBS_ID"));
                vDT.Columns.Add(new DataColumn("OBS_TYPE"));
                vDT.Columns.Add(new DataColumn("MO_ALIAS"));
                vDT.Columns.Add(new DataColumn("BOM_ID"));
                vDT.Columns.Add(new DataColumn("CHK"));
                vDT.Columns.Add(new DataColumn("QUOTED_YMD"));
                vDT.Columns.Add(new DataColumn("GEN_CD"));
                vDT.Columns.Add(new DataColumn("SIZE_CD"));
                vDT.Columns.Add(new DataColumn("SIZE_UP"));
                vDT.Columns.Add(new DataColumn("UP"));
                vDT.Columns.Add(new DataColumn("BOTTOM"));
                vDT.Columns.Add(new DataColumn("EXTRA"));
                vDT.Columns.Add(new DataColumn("M_UPPER"));
                vDT.Columns.Add(new DataColumn("M_PACKAGING"));
                vDT.Columns.Add(new DataColumn("M_MIDSOLE"));
                vDT.Columns.Add(new DataColumn("M_OUTSOLE"));
                vDT.Columns.Add(new DataColumn("M_SIZE_UP"));
                vDT.Columns.Add(new DataColumn("M_PRICE"));
                vDT.Columns.Add(new DataColumn("M_RATIO"));
                vDT.Columns.Add(new DataColumn("L_OH"));
                vDT.Columns.Add(new DataColumn("PROFIT"));
                vDT.Columns.Add(new DataColumn("OTHER_AD"));
                vDT.Columns.Add(new DataColumn("NM_PRICE"));
                vDT.Columns.Add(new DataColumn("T_SAMPLE"));
                vDT.Columns.Add(new DataColumn("T_PRODUCTION"));
                vDT.Columns.Add(new DataColumn("TOOLING"));
                vDT.Columns.Add(new DataColumn("FOB"));
                vDT.Columns.Add(new DataColumn("FOB_STATUS"));
                vDT.Columns.Add(new DataColumn("FOB_TYPE"));
                vDT.Columns.Add(new DataColumn("FACTORY_FOB"));
                vDT.Columns.Add(new DataColumn("MARGIN_RATE"));
                vDT.Columns.Add(new DataColumn("RATE_IDR"));
                vDT.Columns.Add(new DataColumn("RATE_INR"));
                vDT.Columns.Add(new DataColumn("RATE_KRW"));
                vDT.Columns.Add(new DataColumn("RATE_RMB"));
                vDT.Columns.Add(new DataColumn("RATE_THB"));
                vDT.Columns.Add(new DataColumn("RATE_TWD"));
                vDT.Columns.Add(new DataColumn("RATE_USD"));
                vDT.Columns.Add(new DataColumn("RATE_VND"));
                vDT.Columns.Add(new DataColumn("FORECAST"));
                vDT.Columns.Add(new DataColumn("PEAK"));
                vDT.Columns.Add(new DataColumn("RETAIL"));
                vDT.Columns.Add(new DataColumn("TARGET"));
                vDT.Columns.Add(new DataColumn("PATTERN_DESC"));
                vDT.Columns.Add(new DataColumn("TOOLING_DESC"));
                vDT.Columns.Add(new DataColumn("SIZE_DESC"));
                vDT.Columns.Add(new DataColumn("REMARKS"));
                vDT.Columns.Add(new DataColumn("STATUS"));
                vDT.Columns.Add(new DataColumn("UPD_USER"));
                vDT.Columns.Add(new DataColumn("UPD_METHOD"));

                return vDT;
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region 2. 데이터 체워 넣기

        public System.Data.DataTable FillData(System.Data.DataTable arg_dt)
        {
            try
            {
                #region Excel

                //string sheet_name = worksheet.Name;

                try
                {
                    //int.Parse(sheet_name);

                    #region Head Excel Data Loading
                    factory = (worksheet.get_Range(worksheet.Cells[9, 4], worksheet.Cells[9, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 4], worksheet.Cells[9, 4]).Value2.ToString().Trim();
                    string season = (worksheet.get_Range(worksheet.Cells[17, 4], worksheet.Cells[17, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 4], worksheet.Cells[17, 4]).Value2.ToString().Trim();
                    season = Get_Season_code(season);
                    string category = (worksheet.get_Range(worksheet.Cells[11, 4], worksheet.Cells[11, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[11, 4], worksheet.Cells[11, 4]).Value2.ToString().Trim();
                    style_cd = (worksheet.get_Range(worksheet.Cells[7, 4], worksheet.Cells[7, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 4], worksheet.Cells[7, 4]).Value2.ToString().Trim();
                    if (style_cd.Equals("") || style_cd.Equals("NA"))
                        style_cd = "_________";
                    else
                        style_cd = style_cd.Substring(0, 10);

                    string style_name = (worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Value2.ToString().Trim();
                    string mo_alias = (worksheet.get_Range(worksheet.Cells[3, 4], worksheet.Cells[3, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 4], worksheet.Cells[3, 4]).Value2.ToString().Trim().Replace("-", "");
                    Mo_alias = mo_alias;

                    bom_id = (worksheet.get_Range(worksheet.Cells[5, 4], worksheet.Cells[5, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 4], worksheet.Cells[5, 4]).Value2.ToString().Trim();
                    string quoted_ymd = (worksheet.get_Range(worksheet.Cells[19, 4], worksheet.Cells[19, 4]).Text == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 4], worksheet.Cells[19, 4]).Text.ToString().Trim();

                    try
                    {
                        int yyyy = int.Parse("20" + quoted_ymd.Substring(quoted_ymd.Length - 2, 2));
                        int mm = int.Parse(quoted_ymd.Substring(0, quoted_ymd.IndexOf("-")));
                        int dd = int.Parse(quoted_ymd.Substring(quoted_ymd.IndexOf("-") + 1, 2).Replace("-", ""));
                        DateTime quo = new DateTime(yyyy, mm, dd);
                        quoted_ymd = quo.ToString("yyyy-MM-dd");
                    }
                    catch
                    {
                        quoted_ymd = quoted_ymd.Replace("-", "");
                    }

                    string gen_cd = (worksheet.get_Range(worksheet.Cells[21, 4], worksheet.Cells[21, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 4], worksheet.Cells[21, 4]).Value2.ToString().Trim();
                    string size_cd = (worksheet.get_Range(worksheet.Cells[22, 4], worksheet.Cells[22, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[22, 4], worksheet.Cells[22, 4]).Value2.ToString().Trim();
                    string size_up = (worksheet.get_Range(worksheet.Cells[23, 4], worksheet.Cells[23, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[23, 4], worksheet.Cells[23, 4]).Value2.ToString().Trim();

                    string fob_status = (worksheet.get_Range(worksheet.Cells[13, 4], worksheet.Cells[13, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[13, 4], worksheet.Cells[13, 4]).Value2.ToString().Trim();
                    string fob_type = (worksheet.get_Range(worksheet.Cells[15, 4], worksheet.Cells[15, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[15, 4], worksheet.Cells[15, 4]).Value2.ToString().Trim();
                    Fob_type = fob_type;

                    string factory_fob = "0";
                    string margin_rate = "0";

                    #region 변수정의
                    string m_upper = "";
                    string m_packaging = "";
                    string m_midsole = "";
                    string m_out_sole = "";
                    string m_size_up = "";
                    string m_price = "";
                    string m_ratio = "";
                    string extra = "";
                    string up = "";
                    string bottom = "";
                    string l_oh = "";
                    string profit = "";
                    string other_ad = "";
                    string nm_price = "";
                    string t_sample = "";
                    string t_production = "";
                    string tooling = "";
                    string fob = "";
                    #endregion

                    if (version.Equals("1.153"))
                    {
                        #region Version 1.153
                        m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text.ToString().Trim().Replace("%", "");

                        double extra_sum = 0;

                        for (int row = 37; row < 147; row++)
                        {
                            string arg_chk = (worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2.ToString().Trim();
                            string extra_temp = (worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2.ToString().Trim();


                            if (arg_chk.Equals("PC"))
                            {
                                try
                                {
                                    extra_sum = extra_sum + double.Parse(extra_temp);
                                }
                                catch
                                {
                                }
                            }

                        }
                        extra = extra_sum.ToString();
                        up = Convert.ToString(Convert.ToDouble(double.Parse(m_upper).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_packaging).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_size_up).ToString("##,###,##0.00")));
                        bottom = Convert.ToString(Convert.ToDouble(double.Parse(m_midsole).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_out_sole).ToString("##,###,##0.00"))); ;

                        l_oh = (worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2.ToString().Trim();
                        profit = (worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2.ToString().Trim();
                        other_ad = (worksheet.get_Range(worksheet.Cells[15, 14], worksheet.Cells[15, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[15, 14], worksheet.Cells[15, 14]).Value2.ToString().Trim();
                        nm_price = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        t_sample = (worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2.ToString().Trim();
                        t_production = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        tooling = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        fob = (worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2.ToString().Trim();
                        #endregion
                    }
                    else if (version.Equals("1.154"))
                    {
                        #region Version 1.154
                        m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text.ToString().Trim().Replace("%", "");

                        double extra_sum = 0;

                        for (int row = 37; row < 147; row++)
                        {
                            string arg_chk = (worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2.ToString().Trim();
                            string extra_temp = (worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2.ToString().Trim();


                            if (arg_chk.Equals("PC"))
                            {
                                try
                                {
                                    extra_sum = extra_sum + double.Parse(extra_temp);
                                }
                                catch
                                {
                                }
                            }

                        }
                        extra = extra_sum.ToString();
                        up = Convert.ToString(Convert.ToDouble(double.Parse(m_upper).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_packaging).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_size_up).ToString("##,###,##0.00")));
                        bottom = Convert.ToString(Convert.ToDouble(double.Parse(m_midsole).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_out_sole).ToString("##,###,##0.00"))); ;

                        string labor = (worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2.ToString().Trim();
                        string overhead = (worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2.ToString().Trim();
                        double l_oh_value = 0;

                        try
                        {
                            l_oh_value = double.Parse(labor) + double.Parse(overhead);
                        }
                        catch
                        {
                            l_oh_value = double.Parse(labor);
                        }

                        l_oh = l_oh_value.ToString("##,###,##0.00");
                        profit = (worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2.ToString().Trim();
                        other_ad = (worksheet.get_Range(worksheet.Cells[15, 14], worksheet.Cells[15, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[15, 14], worksheet.Cells[15, 14]).Value2.ToString().Trim();
                        nm_price = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        t_sample = (worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[19, 14], worksheet.Cells[19, 14]).Value2.ToString().Trim();
                        t_production = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        tooling = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        fob = (worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[23, 14], worksheet.Cells[23, 14]).Value2.ToString().Trim();
                        #endregion
                    }
                    else if (version.Equals("1.157"))
                    {
                        #region Version 1.157
                        m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Text == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Text.ToString().Trim().Replace("%", "");
                        m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text.ToString().Trim().Replace("%", "");

                        double extra_sum = 0;

                        for (int row = 37; row < 147; row++)
                        {
                            string arg_chk = (worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2.ToString().Trim();
                            string extra_temp = (worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2.ToString().Trim();


                            if (arg_chk.Equals("PC"))
                            {
                                try
                                {
                                    extra_sum = extra_sum + double.Parse(extra_temp);
                                }
                                catch
                                {
                                }
                            }

                        }
                        extra = extra_sum.ToString();
                        up = Convert.ToString(Convert.ToDouble(double.Parse(m_upper).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_packaging).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_size_up).ToString("##,###,##0.00")));
                        bottom = Convert.ToString(Convert.ToDouble(double.Parse(m_midsole).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_out_sole).ToString("##,###,##0.00"))); ;

                        string labor = (worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2.ToString().Trim();
                        string overhead = (worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2.ToString().Trim();
                        double l_oh_value = 0;

                        try
                        {
                            l_oh_value = double.Parse(labor) + double.Parse(overhead);
                        }
                        catch
                        {
                            l_oh_value = double.Parse(labor);
                        }

                        l_oh = l_oh_value.ToString("##,###,##0.00");
                        profit = (worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2.ToString().Trim();
                        other_ad = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        nm_price = (worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2.ToString().Trim();
                        t_sample = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        t_production = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        tooling = (worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2.ToString().Trim();
                        fob = (worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2.ToString().Trim();
                        #endregion
                    }
                    else if (version.Equals("1.2"))
                    {
                        #region Version 1.220
                        m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text.ToString().Trim().Replace("%", "");

                        double extra_sum = 0;

                        for (int row = 37; row < 147; row++)
                        {
                            string arg_chk = (worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2.ToString().Trim();
                            string extra_temp = (worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2.ToString().Trim();


                            if (arg_chk.Equals("PC"))
                            {
                                try
                                {
                                    extra_sum = extra_sum + double.Parse(extra_temp);
                                }
                                catch
                                {
                                }
                            }

                        }
                        extra = extra_sum.ToString();
                        up = Convert.ToString(Convert.ToDouble(double.Parse(m_upper).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_packaging).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_size_up).ToString("##,###,##0.00")));
                        bottom = Convert.ToString(Convert.ToDouble(double.Parse(m_midsole).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_out_sole).ToString("##,###,##0.00"))); ;

                        string labor = (worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2.ToString().Trim();
                        string overhead = (worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2.ToString().Trim();
                        double l_oh_value = 0;

                        try
                        {
                            l_oh_value = double.Parse(labor) + double.Parse(overhead);
                        }
                        catch
                        {
                            l_oh_value = double.Parse(labor);
                        }

                        l_oh = l_oh_value.ToString("##,###,##0.00");
                        profit = (worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2.ToString().Trim();
                        other_ad = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        nm_price = (worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2.ToString().Trim();
                        t_sample = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        t_production = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        tooling = (worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2.ToString().Trim();
                        fob = (worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2.ToString().Trim();
                        #endregion
                    }
                    else if (version.Equals("1.22"))
                    {
                        #region Version 1.220
                        m_upper = (worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[4, 14], worksheet.Cells[4, 14]).Value2.ToString().Trim();
                        m_packaging = (worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[5, 14]).Value2.ToString().Trim();
                        m_midsole = (worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 14], worksheet.Cells[6, 14]).Value2.ToString().Trim();
                        m_out_sole = (worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 14], worksheet.Cells[7, 14]).Value2.ToString().Trim();
                        m_size_up = (worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 14], worksheet.Cells[8, 14]).Value2.ToString().Trim();
                        m_price = (worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 14], worksheet.Cells[9, 14]).Value2.ToString().Trim();
                        m_ratio = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Text.ToString().Trim().Replace("%", "");

                        double extra_sum = 0;

                        for (int row = 37; row < 147; row++)
                        {
                            string arg_chk = (worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 2], worksheet.Cells[row, 2]).Value2.ToString().Trim();
                            string extra_temp = (worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row, 22], worksheet.Cells[row, 22]).Value2.ToString().Trim();


                            if (arg_chk.Equals("PC"))
                            {
                                try
                                {
                                    extra_sum = extra_sum + double.Parse(extra_temp);
                                }
                                catch
                                {
                                }
                            }

                        }
                        extra = extra_sum.ToString();
                        up = Convert.ToString(Convert.ToDouble(double.Parse(m_upper).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_packaging).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_size_up).ToString("##,###,##0.00")));
                        bottom = Convert.ToString(Convert.ToDouble(double.Parse(m_midsole).ToString("##,###,##0.00")) + Convert.ToDouble(double.Parse(m_out_sole).ToString("##,###,##0.00"))); ;

                        string labor = (worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[12, 14], worksheet.Cells[12, 14]).Value2.ToString().Trim();
                        string overhead = (worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[13, 14], worksheet.Cells[13, 14]).Value2.ToString().Trim();
                        double l_oh_value = 0;

                        try
                        {
                            l_oh_value = double.Parse(labor) + double.Parse(overhead);
                        }
                        catch
                        {
                            l_oh_value = double.Parse(labor);
                        }

                        l_oh = l_oh_value.ToString("##,###,##0.00");
                        profit = (worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[14, 14], worksheet.Cells[14, 14]).Value2.ToString().Trim();
                        other_ad = (worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[16, 14], worksheet.Cells[16, 14]).Value2.ToString().Trim();
                        nm_price = (worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[17, 14], worksheet.Cells[17, 14]).Value2.ToString().Trim();
                        t_sample = (worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[20, 14], worksheet.Cells[20, 14]).Value2.ToString().Trim();
                        t_production = (worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[21, 14], worksheet.Cells[21, 14]).Value2.ToString().Trim();
                        tooling = (worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[22, 14], worksheet.Cells[22, 14]).Value2.ToString().Trim();
                        fob = (worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[24, 14], worksheet.Cells[24, 14]).Value2.ToString().Trim();
                        #endregion
                    }



                    string rate_idr = (worksheet.get_Range(worksheet.Cells[3, 18], worksheet.Cells[3, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[3, 18], worksheet.Cells[3, 18]).Value2.ToString().Trim();
                    string rate_inr = (worksheet.get_Range(worksheet.Cells[4, 18], worksheet.Cells[4, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[4, 18], worksheet.Cells[4, 18]).Value2.ToString().Trim();
                    string rate_krw = (worksheet.get_Range(worksheet.Cells[5, 18], worksheet.Cells[5, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[5, 18], worksheet.Cells[5, 18]).Value2.ToString().Trim();
                    string rate_rmb = (worksheet.get_Range(worksheet.Cells[6, 18], worksheet.Cells[6, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[6, 18], worksheet.Cells[6, 18]).Value2.ToString().Trim();
                    string rate_thb = (worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).Value2.ToString().Trim();
                    string rate_twd = (worksheet.get_Range(worksheet.Cells[8, 18], worksheet.Cells[8, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[8, 18], worksheet.Cells[8, 18]).Value2.ToString().Trim();
                    string rate_usd = (worksheet.get_Range(worksheet.Cells[9, 18], worksheet.Cells[9, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[9, 18], worksheet.Cells[9, 18]).Value2.ToString().Trim();
                    string rate_vnd = (worksheet.get_Range(worksheet.Cells[10, 18], worksheet.Cells[10, 18]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[10, 18], worksheet.Cells[10, 18]).Value2.ToString().Trim();


                    string forecast = "";
                    string peak = "";
                    string retail = "";
                    string target = "";

                    string pattern_desc_1 = "";
                    string pattern_desc_2 = "";
                    string pattern_desc = "";

                    string tooling_desc_1 = "";
                    string tooling_desc_2 = "";
                    string tooling_desc_3 = "";
                    string tooling_desc = "";
                    string size_desc = "";

                    for (int row2 = 11; row2 <= 23; row2++)
                    {
                        string name = (worksheet.get_Range(worksheet.Cells[row2, 17], worksheet.Cells[row2, 17]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row2, 17], worksheet.Cells[row2, 17]).Value2.ToString().Trim();

                        if (name.Equals("Forecast"))
                        {
                            forecast = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                        }
                        else if (name.Equals("Retail"))
                        {
                            retail = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                        }
                        else if (name.Equals("Target"))
                        {
                            target = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                        }
                        else if (name.Equals("Pattern"))
                        {
                            pattern_desc_1 = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                            pattern_desc_2 = (worksheet.get_Range(worksheet.Cells[row2, 20], worksheet.Cells[row2, 20]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[row2, 20], worksheet.Cells[row2, 20]).Value2.ToString().Trim();

                            pattern_desc = pattern_desc_1 + pattern_desc_2;
                        }
                        else if (name.Equals("Tooling"))
                        {
                            tooling_desc_1 = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                            tooling_desc_2 = (worksheet.get_Range(worksheet.Cells[row2 + 1, 19], worksheet.Cells[row2 + 1, 19]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[row2 + 1, 19], worksheet.Cells[row2 + 1, 19]).Value2.ToString().Trim();
                            tooling_desc_3 = (worksheet.get_Range(worksheet.Cells[row2 + 2, 19], worksheet.Cells[row2 + 2, 19]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[row2 + 2, 19], worksheet.Cells[row2 + 2, 19]).Value2.ToString().Trim();

                            tooling_desc = tooling_desc_1 + tooling_desc_2 + tooling_desc_3;
                        }
                        else if (name.Equals("Size"))
                        {
                            size_desc = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                        }


                        try
                        {
                            if (name.Substring(0, 4).Equals("Peak"))
                            {
                                peak = (worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2 == null) ? "0" : worksheet.get_Range(worksheet.Cells[row2, 19], worksheet.Cells[row2, 19]).Value2.ToString().Trim();
                            }
                        }
                        catch
                        {

                        }
                    }

                    #endregion

                    if (fob_type.Equals("GTM"))
                    {
                        #region OBS ID Setting

                        string obs_year = season.Substring(2, 2);

                        obs_01 = obs_year + "0112";
                        obs_02 = "";
                        obs_03 = "";

                        obs_type = "SS";

                        #endregion



                        #region Insert data to Grid

                        DataRow row0 = arg_dt.NewRow();

                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = "I";
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxCHK] = "False";
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY] = factory;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON] = season;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY] = category;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD] = style_cd;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] = style_name;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID] = obs_01;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE] = obs_type;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS] = mo_alias;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID] = bom_id;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD] = quoted_ymd;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD] = gen_cd;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD] = size_cd;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP] = size_up;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB] = Convert.ToDouble(fob).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS] = fob_status;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE] = fob_type;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB] = Convert.ToDouble(factory_fob).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE] = Convert.ToDouble(margin_rate).ToString("##,###,##0.00");

                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxUP] = Convert.ToDouble(up).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER] = Convert.ToDouble(m_upper).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING] = Convert.ToDouble(m_packaging).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM] = Convert.ToDouble(bottom).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE] = Convert.ToDouble(m_midsole).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE] = Convert.ToDouble(m_out_sole).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP] = Convert.ToDouble(m_size_up).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE] = Convert.ToDouble(m_price).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO] = Convert.ToDouble(m_ratio).ToString("##,###,##0.00");

                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA] = Convert.ToDouble(extra).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH] = Convert.ToDouble(l_oh).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT] = Convert.ToDouble(profit).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD] = Convert.ToDouble(other_ad).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE] = Convert.ToDouble(nm_price).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING] = Convert.ToDouble(tooling).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE] = Convert.ToDouble(t_sample).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION] = Convert.ToDouble(t_production).ToString("##,###,##0.00");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB] = Convert.ToDouble(fob).ToString("##,###,##0.00");

                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR] = Convert.ToDouble(rate_idr).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR] = Convert.ToDouble(rate_inr).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW] = Convert.ToDouble(rate_krw).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB] = Convert.ToDouble(rate_rmb).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB] = Convert.ToDouble(rate_thb).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD] = Convert.ToDouble(rate_twd).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD] = Convert.ToDouble(rate_usd).ToString("##,###,##0.00####");
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND] = Convert.ToDouble(rate_vnd).ToString("##,###,##0.00####");

                        try
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST] = Convert.ToDouble(forecast).ToString("##,###,##0.00"); ;
                        }
                        catch
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST] = 0;
                        }
                        try
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK] = Convert.ToDouble(peak).ToString("##,###,##0.00");
                        }
                        catch
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK] = 0;
                        }
                        try
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL] = Convert.ToDouble(retail).ToString("##,###,##0.00");
                        }
                        catch
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL] = 0;
                        }
                        try
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET] = Convert.ToDouble(target).ToString("##,###,##0.00");
                        }
                        catch
                        {
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET] = 0;
                        }
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC] = pattern_desc;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC] = tooling_desc;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC] = size_desc;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_USER] = COM.ComVar.This_User;
                        row0[(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD] = "E";

                        arg_dt.Rows.Add(row0);

                        #endregion
                    }
                    else
                    {
                        #region OBS ID Setting

                        System.Data.DataTable dt_ret = GET_OBS_ID(factory, season);

                        if (dt_ret.Rows.Count >= 3)
                        {
                            obs_01 = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
                            obs_02 = dt_ret.Rows[1].ItemArray[0].ToString().Trim();
                            obs_03 = dt_ret.Rows[2].ItemArray[0].ToString().Trim();
                        }
                        else
                        {
                            MessageBox.Show("OBS ID is not Created, Please ask System");
                            return null;
                        }

                        obs_type = "FT";
                        #endregion

                        #region Insert data to Grid

                        for (int k = 0; k < 3; k++)
                        {
                            string obs_id = obs_01;

                            if (k == 0)
                                obs_id = obs_01;
                            else if (k == 1)
                                obs_id = obs_02;
                            else if (k == 2)
                                obs_id = obs_03;

                            DataRow row0 = arg_dt.NewRow();

                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = "I";
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxCHK] = "False";
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY] = factory;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON] = season;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY] = category;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD] = style_cd;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] = style_name;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID] = obs_id;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE] = obs_type;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS] = mo_alias;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID] = bom_id;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD] = quoted_ymd;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD] = gen_cd;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD] = size_cd;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP] = size_up;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB] = Convert.ToDouble(fob).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS] = fob_status;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE] = fob_type;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB] = Convert.ToDouble(factory_fob).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE] = Convert.ToDouble(margin_rate).ToString("##,###,##0.00");

                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxUP] = Convert.ToDouble(up).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER] = Convert.ToDouble(m_upper).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING] = Convert.ToDouble(m_packaging).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM] = Convert.ToDouble(bottom).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE] = Convert.ToDouble(m_midsole).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE] = Convert.ToDouble(m_out_sole).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP] = Convert.ToDouble(m_size_up).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE] = Convert.ToDouble(m_price).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO] = Convert.ToDouble(m_ratio).ToString("##,###,##0.00");

                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA] = Convert.ToDouble(extra).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH] = Convert.ToDouble(l_oh).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT] = Convert.ToDouble(profit).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD] = Convert.ToDouble(other_ad).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE] = Convert.ToDouble(nm_price).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING] = Convert.ToDouble(tooling).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE] = Convert.ToDouble(t_sample).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION] = Convert.ToDouble(t_production).ToString("##,###,##0.00");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFOB] = Convert.ToDouble(fob).ToString("##,###,##0.00");

                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR] = Convert.ToDouble(rate_idr).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR] = Convert.ToDouble(rate_inr).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW] = Convert.ToDouble(rate_krw).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB] = Convert.ToDouble(rate_rmb).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB] = Convert.ToDouble(rate_thb).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD] = Convert.ToDouble(rate_twd).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD] = Convert.ToDouble(rate_usd).ToString("##,###,##0.00####");
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND] = Convert.ToDouble(rate_vnd).ToString("##,###,##0.00####");

                            try
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST] = Convert.ToDouble(forecast).ToString("##,###,##0.00"); ;
                            }
                            catch
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST] = 0;
                            }
                            try
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK] = Convert.ToDouble(peak).ToString("##,###,##0.00");
                            }
                            catch
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK] = 0;
                            }
                            try
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL] = Convert.ToDouble(retail).ToString("##,###,##0.00");
                            }
                            catch
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL] = 0;
                            }
                            try
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET] = Convert.ToDouble(target).ToString("##,###,##0.00");
                            }
                            catch
                            {
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET] = 0;
                            }
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC] = pattern_desc;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC] = tooling_desc;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC] = size_desc;
                            row0[(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_USER] = COM.ComVar.This_User;
                            if (k == 0)
                                row0[(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD] = "E";

                            arg_dt.Rows.Add(row0);

                        }
                        #endregion
                    }
                }
                catch
                {
                    return null;
                }

                #endregion

                return arg_dt;
            }
            catch
            {
                return null;
            }

        }


        #region 3. 매크로 실행

        public DataSet ExecuteMacro()
        {
            try
            {
                if (version.Equals("1.22"))
                {
                    worksheet.Application.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod,
                        null, worksheet.Application, new object[] { "XferData2XmlMappWorksheet" });
                }

                DataSet vDS = null;

                XmlMaps map = workbook.XmlMaps;
                System.Collections.IEnumerator emap = map.GetEnumerator();

                while (emap.MoveNext())
                {
                    if (emap.Current == null) continue;
                    string xml_file = null;

                    try
                    {
                        Microsoft.Office.Interop.Excel.Worksheet sheet = ((Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet);

                        XmlMap m = emap.Current as XmlMap;
                        xml_file = System.Windows.Forms.Application.StartupPath + @"\" + sheet.Name + DateTime.Now.ToString("yyyyMMddhh24mmss") + ".xml";
                        //workbook.SaveAsXMLData(xml_file, map[i]);
                        workbook.XmlMaps[1].Export(xml_file, false);

                        System.IO.FileStream fsReadXml = new System.IO.FileStream(xml_file, System.IO.FileMode.Open);
                        System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);
                        vDS = new DataSet();
                        vDS.ReadXml(myXmlReader);
                        myXmlReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (System.IO.File.Exists(xml_file))
                            System.IO.File.Delete(xml_file);
                    }
                }

                return vDS;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #endregion


        #region 데이터베이스

        private string Get_Season_code(string arg_season_cd)
        {
            if (arg_season_cd.Equals(""))
                return "";

            string season_year = "20" + arg_season_cd.Substring(2, 2);
            string season_code = arg_season_cd.Substring(0, 2);

            if (season_code.Equals("SP"))
                season_code = "01";
            else if (season_code.Equals("SU"))
                season_code = "02";
            else if (season_code.Equals("FA"))
                season_code = "03";
            else if (season_code.Equals("HO"))
                season_code = "04";

            return season_year + season_code;
        }
        private System.Data.DataTable GET_OBS_ID(string arg_factory, string arg_season)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.GET_EBM_OBS_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region Properties

        public Microsoft.Office.Interop.Excel.Workbook Workbook
        {
            get { return workbook; }
            set { workbook = value; }
        }

        public Microsoft.Office.Interop.Excel.Worksheet Worksheet
        {
            get { return worksheet; }
            set { worksheet = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Factory
        {
            get { return factory; }
            set { factory = value; }
        }

        public string Style_cd
        {
            get { return style_cd; }
            set { style_cd = value; }
        }

        public string Obs_01
        {
            get { return obs_01; }
            set { obs_01 = value; }
        }

        public string Obs_02
        {
            get { return obs_02; }
            set { obs_02 = value; }
        }

        public string Obs_03
        {
            get { return obs_03; }
            set { obs_03 = value; }
        }

        public string Obs_type
        {
            get { return obs_type; }
            set { obs_type = value; }
        }

        public string Bom_id
        {
            get { return bom_id; }
            set { bom_id = value; }
        }

        // 추가
        public string Mo_alias
        {
            get { return mo_alias; }
            set { mo_alias = value; }
        }

        public string Fob_type
        {
            get { return fob_type; }
            set { fob_type = value; }
        }

        #endregion
    }
}
