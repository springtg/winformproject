using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using Excel;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class Detail
    {
        private Excel.Workbook workbook = null;

        private string factory = "";
        private string style_cd = "";
        private string obs_01 = "";
        private string obs_02 = "";
        private string obs_03 = "";
        private string obs_type = "";
        private string bom_id = "";

        private string mo_alias = "";
        private string fob_type = ""; // round

        #region 1, 데이터 테이블 만들기

        public DataSet CreateNewDateTable()
        {
            try
            {
                DataSet vDS = new DataSet("Detail");

                #region Detail System.Data.DataTable create

                System.Data.DataTable varg_orgDT = new System.Data.DataTable("Upper");
                varg_orgDT.Columns.Add(new DataColumn("factory"));
                varg_orgDT.Columns.Add(new DataColumn("obs_id_01"));
                varg_orgDT.Columns.Add(new DataColumn("obs_id_02"));
                varg_orgDT.Columns.Add(new DataColumn("obs_id_03"));
                varg_orgDT.Columns.Add(new DataColumn("obs_type"));
                varg_orgDT.Columns.Add(new DataColumn("style_cd"));
                varg_orgDT.Columns.Add(new DataColumn("size_excld"));
                varg_orgDT.Columns.Add(new DataColumn("class"));
                varg_orgDT.Columns.Add(new DataColumn("sub_class"));
                varg_orgDT.Columns.Add(new DataColumn("bom_id"));
                varg_orgDT.Columns.Add(new DataColumn("cbd"));
                varg_orgDT.Columns.Add(new DataColumn("part"));
                varg_orgDT.Columns.Add(new DataColumn("mat_name"));
                varg_orgDT.Columns.Add(new DataColumn("vendor"));
                varg_orgDT.Columns.Add(new DataColumn("color"));
                varg_orgDT.Columns.Add(new DataColumn("mat_no"));
                varg_orgDT.Columns.Add(new DataColumn("uom"));
                varg_orgDT.Columns.Add(new DataColumn("curr"));
                varg_orgDT.Columns.Add(new DataColumn("fx_rate"));
                varg_orgDT.Columns.Add(new DataColumn("mat_price"));
                varg_orgDT.Columns.Add(new DataColumn("frt_trm"));
                varg_orgDT.Columns.Add(new DataColumn("fct_lnd_rate"));
                varg_orgDT.Columns.Add(new DataColumn("fct_lnd_tot"));
                varg_orgDT.Columns.Add(new DataColumn("fct_lnd_usd_tot"));
                varg_orgDT.Columns.Add(new DataColumn("yield"));
                varg_orgDT.Columns.Add(new DataColumn("loss_rate"));
                varg_orgDT.Columns.Add(new DataColumn("usage"));
                varg_orgDT.Columns.Add(new DataColumn("us_cost"));
                varg_orgDT.Columns.Add(new DataColumn("size_tot_cost"));
                varg_orgDT.Columns.Add(new DataColumn("sizing_up_charge"));
                varg_orgDT.Columns.Add(new DataColumn("processing_cost"));
                varg_orgDT.Columns.Add(new DataColumn("remarks"));
                varg_orgDT.Columns.Add(new DataColumn("status"));
                varg_orgDT.Columns.Add(new DataColumn("upd_user"));

                varg_orgDT.Columns.Add(new DataColumn("mo_alias"));
                varg_orgDT.Columns.Add(new DataColumn("fob_type"));
                varg_orgDT.Columns.Add(new DataColumn("upd_method"));

                vDS.Tables.Add(varg_orgDT);

                #endregion


                #region Labor database create

                // 24
                System.Data.DataTable vDT_labor = new System.Data.DataTable("Labor");
                vDT_labor.Columns.Add(new DataColumn("factory"));
                vDT_labor.Columns.Add(new DataColumn("obs_id_01"));
                vDT_labor.Columns.Add(new DataColumn("obs_id_02"));
                vDT_labor.Columns.Add(new DataColumn("obs_id_03"));
                vDT_labor.Columns.Add(new DataColumn("obs_type"));
                vDT_labor.Columns.Add(new DataColumn("style_cd"));
                vDT_labor.Columns.Add(new DataColumn("class"));
                vDT_labor.Columns.Add(new DataColumn("sub_class"));
                vDT_labor.Columns.Add(new DataColumn("curr"));
                vDT_labor.Columns.Add(new DataColumn("fx_rate"));
                vDT_labor.Columns.Add(new DataColumn("process"));
                vDT_labor.Columns.Add(new DataColumn("direct_annual_wages"));
                vDT_labor.Columns.Add(new DataColumn("direct_labor_worker"));
                vDT_labor.Columns.Add(new DataColumn("day_paid_annualy"));
                vDT_labor.Columns.Add(new DataColumn("minute_day_worker"));
                vDT_labor.Columns.Add(new DataColumn("effctv_rate"));
                vDT_labor.Columns.Add(new DataColumn("cost_std_minute"));
                vDT_labor.Columns.Add(new DataColumn("std_minutes_pair"));
                vDT_labor.Columns.Add(new DataColumn("cost_pair_local"));
                vDT_labor.Columns.Add(new DataColumn("cost_pair_usd"));
                vDT_labor.Columns.Add(new DataColumn("ov_cost_pr"));
                vDT_labor.Columns.Add(new DataColumn("remarks"));
                vDT_labor.Columns.Add(new DataColumn("status"));
                vDT_labor.Columns.Add(new DataColumn("upd_user"));

                vDT_labor.Columns.Add(new DataColumn("mo_alias"));
                vDT_labor.Columns.Add(new DataColumn("bom_id"));
                vDT_labor.Columns.Add(new DataColumn("fob_type"));
                vDT_labor.Columns.Add(new DataColumn("upd_method"));


                vDS.Tables.Add(vDT_labor);

                #endregion


                #region Overhead

                // 16
                System.Data.DataTable vDT_overhead = new System.Data.DataTable("Overhead");
                vDT_overhead.Columns.Add(new DataColumn("factory"));
                vDT_overhead.Columns.Add(new DataColumn("obs_id_01"));
                vDT_overhead.Columns.Add(new DataColumn("obs_id_02"));
                vDT_overhead.Columns.Add(new DataColumn("obs_id_03"));
                vDT_overhead.Columns.Add(new DataColumn("obs_type"));
                vDT_overhead.Columns.Add(new DataColumn("style_cd"));
                vDT_overhead.Columns.Add(new DataColumn("class"));
                vDT_overhead.Columns.Add(new DataColumn("sub_class"));
                vDT_overhead.Columns.Add(new DataColumn("curr"));
                vDT_overhead.Columns.Add(new DataColumn("fx_rate"));
                vDT_overhead.Columns.Add(new DataColumn("item"));
                vDT_overhead.Columns.Add(new DataColumn("local_cost"));
                vDT_overhead.Columns.Add(new DataColumn("usd_cost"));
                vDT_overhead.Columns.Add(new DataColumn("remarks"));
                vDT_overhead.Columns.Add(new DataColumn("status"));
                vDT_overhead.Columns.Add(new DataColumn("upd_user"));

                vDT_overhead.Columns.Add(new DataColumn("mo_alias"));
                vDT_overhead.Columns.Add(new DataColumn("bom_id"));
                vDT_overhead.Columns.Add(new DataColumn("fob_type"));
                vDT_overhead.Columns.Add(new DataColumn("upd_method"));

                vDS.Tables.Add(vDT_overhead);

                #endregion


                #region mold

                // 23
                System.Data.DataTable vDT_mold = new System.Data.DataTable("MOLD");
                vDT_mold.Columns.Add(new DataColumn("factory"));
                vDT_mold.Columns.Add(new DataColumn("obs_id_01"));
                vDT_mold.Columns.Add(new DataColumn("obs_id_02"));
                vDT_mold.Columns.Add(new DataColumn("obs_id_03"));
                vDT_mold.Columns.Add(new DataColumn("obs_type"));
                vDT_mold.Columns.Add(new DataColumn("style_cd"));
                vDT_mold.Columns.Add(new DataColumn("class"));
                vDT_mold.Columns.Add(new DataColumn("mold_set"));
                vDT_mold.Columns.Add(new DataColumn("mold_type"));
                vDT_mold.Columns.Add(new DataColumn("mold_code"));
                vDT_mold.Columns.Add(new DataColumn("description"));
                vDT_mold.Columns.Add(new DataColumn("molds_no"));
                vDT_mold.Columns.Add(new DataColumn("curr"));
                vDT_mold.Columns.Add(new DataColumn("fx_rate"));
                vDT_mold.Columns.Add(new DataColumn("mold_costF"));
                vDT_mold.Columns.Add(new DataColumn("total_cost"));
                vDT_mold.Columns.Add(new DataColumn("usd"));
                vDT_mold.Columns.Add(new DataColumn("amort_pairs"));
                vDT_mold.Columns.Add(new DataColumn("usd_pair"));
                vDT_mold.Columns.Add(new DataColumn("notes"));
                vDT_mold.Columns.Add(new DataColumn("remarks"));
                vDT_mold.Columns.Add(new DataColumn("status"));
                vDT_mold.Columns.Add(new DataColumn("upd_user"));

                vDT_mold.Columns.Add(new DataColumn("mo_alias"));
                vDT_mold.Columns.Add(new DataColumn("bom_id"));
                vDT_mold.Columns.Add(new DataColumn("fob_type"));
                vDT_mold.Columns.Add(new DataColumn("upd_method"));

                vDS.Tables.Add(vDT_mold);

                #endregion


                #region ETC - 기타 ( Overhead 등 )

                System.Data.DataTable vDT_etc = new System.Data.DataTable("ETC");
                vDT_etc.Columns.Add(new DataColumn("factory"));
                vDT_etc.Columns.Add(new DataColumn("obs_id_01"));
                vDT_etc.Columns.Add(new DataColumn("obs_id_02"));
                vDT_etc.Columns.Add(new DataColumn("obs_id_03"));
                vDT_etc.Columns.Add(new DataColumn("obs_type"));
                vDT_etc.Columns.Add(new DataColumn("style_cd"));
                vDT_etc.Columns.Add(new DataColumn("total_cost"));
                vDT_etc.Columns.Add(new DataColumn("profit"));
                vDT_etc.Columns.Add(new DataColumn("other_adjust"));
                vDT_etc.Columns.Add(new DataColumn("total_tooling"));
                vDT_etc.Columns.Add(new DataColumn("total_fob"));
                vDT_etc.Columns.Add(new DataColumn("lean_saving_target"));
                vDT_etc.Columns.Add(new DataColumn("labor_comments"));
                vDT_etc.Columns.Add(new DataColumn("oh_comments"));
                vDT_etc.Columns.Add(new DataColumn("size_run"));
                vDT_etc.Columns.Add(new DataColumn("total_size_run"));
                vDT_etc.Columns.Add(new DataColumn("remarks"));
                vDT_etc.Columns.Add(new DataColumn("status"));
                vDT_etc.Columns.Add(new DataColumn("upd_user"));

                vDT_etc.Columns.Add(new DataColumn("mo_alias"));
                vDT_etc.Columns.Add(new DataColumn("bom_id"));
                vDT_etc.Columns.Add(new DataColumn("fob_type"));
                vDT_etc.Columns.Add(new DataColumn("upd_method"));

                vDS.Tables.Add(vDT_etc);

                #endregion

                return vDS;
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region 3. 데이터 체워 넣기

        public DataSet FillData(DataSet arg_orgDS, DataSet arg_destDS)
        {
            try
            {
                // Upper packing
                FillDataUpperOrPacking("Upper", arg_orgDS.Tables["UpperBomItem"], arg_destDS.Tables["Upper"]);
                FillDataUpperOrPacking("Packing", arg_orgDS.Tables["PackagingBomItem"], arg_destDS.Tables["Upper"]);


                // bottom
                FillDataUpperOrPacking("Midsole", arg_orgDS.Tables["MidsoleBomItem"], arg_destDS.Tables["Upper"]);
                FillDataUpperOrPacking("Outsole", arg_orgDS.Tables["OutsoleBomItem"], arg_destDS.Tables["Upper"]);


                // Labor cost
                FillDataLabor("Labor", arg_orgDS.Tables["LaborCost"], arg_destDS.Tables["Labor"]);


                // Overhead cost
                FillDataOverhead("Overhead", arg_orgDS.Tables["OverHeadCost"], arg_destDS.Tables["Overhead"]);
                

                // Mold
                FillDataMOLD("SampleMold", arg_orgDS.Tables["SampleMoldCost"], arg_destDS.Tables["MOLD"]);
                FillDataMOLD("ProdMold", arg_orgDS.Tables["ProductionMoldCost"], arg_destDS.Tables["MOLD"]);


                // Etc
                FillDataETC("ETC", new System.Data.DataTable[] { 
                    arg_orgDS.Tables["MaterialOverheadTotals"], 
                    arg_orgDS.Tables["NonMaterial"], 
                    arg_orgDS.Tables["MoldTooling"] }, 
                    arg_destDS.Tables["ETC"]);

                return arg_destDS;
            }
            catch
            {
                return null;
            }
        }

        // Upper or Packing
        public System.Data.DataTable FillDataUpperOrPacking(string arg_div, System.Data.DataTable arg_orgDT, System.Data.DataTable arg_destDT)
        {
            try
            {
                for (int detail_row = 0; detail_row < arg_orgDT.Rows.Count; detail_row++)
                {
                    DataRow dr_01 = arg_destDT.NewRow();

                    dr_01["factory"] = factory;
                    dr_01["obs_id_01"] = obs_01;
                    dr_01["obs_id_02"] = obs_02;
                    dr_01["obs_id_03"] = obs_03;
                    dr_01["obs_type"] = obs_type;
                    dr_01["style_cd"] = style_cd;
                    dr_01["bom_id"] = bom_id;

                    dr_01["mo_alias"] = mo_alias;
                    dr_01["fob_type"] = fob_type;
                    dr_01["upd_method"] = "E";

                    // 구분 필드 필요
                    dr_01["remarks"] = arg_div;

                    for (int detail_col = 0; detail_col < arg_orgDT.Columns.Count; detail_col++)
                    {
                        if (arg_orgDT.Columns[detail_col].ColumnName.Equals("SizingExcluded"))
                        {
                            dr_01["size_excld"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Class"))
                        {
                            dr_01["class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("SubClass"))
                        {
                            dr_01["sub_class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("CBDNumUpper"))
                        {
                            dr_01["cbd"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("ComponentName"))
                        {
                            dr_01["part"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("MaterialName"))
                        {
                            dr_01["mat_name"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Vendor"))
                        {
                            dr_01["vendor"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Color"))
                        {
                            dr_01["color"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("MtlNum"))
                        {
                            dr_01["mat_no"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("UOM"))
                        {
                            dr_01["uom"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Currency"))
                        {
                            dr_01["curr"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FXRate"))
                        {
                            dr_01["fx_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Cost"))
                        {
                            dr_01["mat_price"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FrtTerm"))
                        {
                            dr_01["frt_trm"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FctyLanded"))
                        {
                            dr_01["fct_lnd_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FctyLandedTotal"))
                        {
                            dr_01["fct_lnd_tot"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FctyLandedUSD"))
                        {
                            dr_01["fct_lnd_usd_tot"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Yield"))
                        {
                            dr_01["yield"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Loss"))
                        {
                            dr_01["loss_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Usage"))
                        {
                            dr_01["usage"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("USCost"))
                        {
                            dr_01["us_cost"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                    }

                    arg_destDT.Rows.Add(dr_01);
                }

                return arg_destDT;
            }
            catch
            {
                return null;
            }
        }


        // Labor
        public System.Data.DataTable FillDataLabor(string arg_div, System.Data.DataTable arg_orgDT, System.Data.DataTable arg_destDT)
        {
            try
            {
                for (int detail_row = 0; detail_row < arg_orgDT.Rows.Count; detail_row++)
                {
                    DataRow dr_01 = arg_destDT.NewRow();

                    dr_01["factory"] = factory;
                    dr_01["obs_id_01"] = obs_01;
                    dr_01["obs_id_02"] = obs_02;
                    dr_01["obs_id_03"] = obs_03;
                    dr_01["obs_type"] = obs_type;
                    dr_01["style_cd"] = style_cd;

                    dr_01["mo_alias"] = mo_alias;
                    dr_01["bom_id"] = bom_id;
                    dr_01["fob_type"] = fob_type;
                    dr_01["upd_method"] = "E";


                    // 구분 필드 필요
                    dr_01["remarks"] = arg_div;

                    for (int detail_col = 0; detail_col < arg_orgDT.Columns.Count; detail_col++)
                    {
                        if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Class"))
                        {
                            dr_01["class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("SubClass"))
                        {
                            dr_01["sub_class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Currency"))
                        {
                            dr_01["curr"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FXRate"))
                        {
                            dr_01["fx_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Process"))
                        {
                            dr_01["process"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("DaysPaidAnnually"))
                        {
                            dr_01["direct_annual_wages"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("DirectLaborWorkers"))
                        {
                            dr_01["direct_labor_worker"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("EffectiveRate"))
                        {
                            dr_01["effctv_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("CostPerMinute"))
                        {
                            dr_01["cost_std_minute"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("StandardMinutesPerPair"))
                        {
                            dr_01["std_minutes_pair"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("CostPerPairLocal"))
                        {
                            dr_01["cost_pair_local"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("USDollars"))
                        {
                            dr_01["cost_pair_usd"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                    }

                    arg_destDT.Rows.Add(dr_01);
                }

                return arg_destDT;
            }
            catch
            {
                return null;
            }
        }

        // Overhead
        public System.Data.DataTable FillDataOverhead(string arg_div, System.Data.DataTable arg_orgDT, System.Data.DataTable arg_destDT)
        {
            try
            {
                for (int detail_row = 0; detail_row < arg_orgDT.Rows.Count; detail_row++)
                {
                    DataRow dr_01 = arg_destDT.NewRow();

                    dr_01["factory"] = factory;
                    dr_01["obs_id_01"] = obs_01;
                    dr_01["obs_id_02"] = obs_02;
                    dr_01["obs_id_03"] = obs_03;
                    dr_01["obs_type"] = obs_type;
                    dr_01["style_cd"] = style_cd;

                    dr_01["mo_alias"] = mo_alias;
                    dr_01["bom_id"] = bom_id;
                    dr_01["fob_type"] = fob_type;
                    dr_01["upd_method"] = "E";

                    // 구분 필드 필요
                    dr_01["remarks"] = arg_div;

                    for (int detail_col = 0; detail_col < arg_orgDT.Columns.Count; detail_col++)
                    {
                        if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Class"))
                        {
                            dr_01["class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("SubClass"))
                        {
                            dr_01["sub_class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Currency"))
                        {
                            dr_01["curr"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FXRate"))
                        {
                            dr_01["fx_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Item"))
                        {
                            dr_01["item"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("LocalCost"))
                        {
                            dr_01["local_cost"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("USDCost"))
                        {
                            dr_01["usd_cost"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                    }

                    arg_destDT.Rows.Add(dr_01);
                }

                return arg_destDT;
            }
            catch
            {
                return null;
            }
        }


        // MOLD
        public System.Data.DataTable FillDataMOLD(string arg_div, System.Data.DataTable arg_orgDT, System.Data.DataTable arg_destDT)
        {
            try
            {
                for (int detail_row = 0; detail_row < arg_orgDT.Rows.Count; detail_row++)
                {
                    DataRow dr_01 = arg_destDT.NewRow();

                    dr_01["factory"] = factory;
                    dr_01["obs_id_01"] = obs_01;
                    dr_01["obs_id_02"] = obs_02;
                    dr_01["obs_id_03"] = obs_03;
                    dr_01["obs_type"] = obs_type;
                    dr_01["style_cd"] = style_cd;

                    dr_01["mo_alias"] = mo_alias;
                    dr_01["bom_id"] = bom_id;
                    dr_01["fob_type"] = fob_type;
                    dr_01["upd_method"] = "E";

                    // 구분 필드 필요
                    dr_01["remarks"] = arg_div;

                    for (int detail_col = 0; detail_col < arg_orgDT.Columns.Count; detail_col++)
                    {
                        if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Class"))
                        {
                            //dr_01["class"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                            if (arg_orgDT.TableName.Equals("SampleMoldCost"))
                                dr_01["class"] = "SM";
                            else
                                dr_01["class"] = "PM";
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("SET"))
                        {
                            dr_01["mold_set"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("MoldType"))
                        {
                            dr_01["mold_type"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("MoldCode"))
                        {
                            dr_01["mold_code"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Description"))
                        {
                            dr_01["description"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("NumberOfMolds"))
                        {
                            dr_01["molds_no"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Currency"))
                        {
                            dr_01["curr"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("FXRate"))
                        {
                            dr_01["fx_rate"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("CostPerMold"))
                        {
                            dr_01["mold_costF"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("TotalCost"))
                        {
                            dr_01["total_cost"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("USD"))
                        {
                            dr_01["usd"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("AmortPairs"))
                        {
                            dr_01["amort_pairs"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("USDPair"))
                        {
                            dr_01["usd_pair"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (arg_orgDT.Columns[detail_col].ColumnName.Equals("Notes"))
                        {
                            dr_01["notes"] = arg_orgDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                    }

                    arg_destDT.Rows.Add(dr_01);
                }

                return arg_destDT;
            }
            catch
            {
                return null;
            }
        }


        // ETC
        public System.Data.DataTable FillDataETC(string arg_div, System.Data.DataTable[] arg_orgDTs, System.Data.DataTable arg_destDT)
        {
            try
            {

                int detail_row = 0;
                DataRow dr_01 = arg_destDT.NewRow();

                dr_01["factory"] = factory;
                dr_01["obs_id_01"] = obs_01;
                dr_01["obs_id_02"] = obs_02;
                dr_01["obs_id_03"] = obs_03;
                dr_01["obs_type"] = obs_type;
                dr_01["style_cd"] = style_cd;

                dr_01["mo_alias"] = mo_alias;
                dr_01["bom_id"] = bom_id;
                dr_01["fob_type"] = fob_type;
                dr_01["upd_method"] = "E";

                // 구분 필드 필요
                dr_01["remarks"] = arg_div;

                for (int idx = 0; idx < arg_orgDTs.Length; idx++)
                {
                    System.Data.DataTable vDT = arg_orgDTs[idx];

                    if (vDT == null || vDT.Rows.Count <= 0)
                        continue;

                    for (int detail_col = 0; detail_col < vDT.Columns.Count; detail_col++)
                    {
                        if (vDT.Columns[detail_col].ColumnName.Equals("TotalMaterialsLaborOverhead"))
                        {
                            dr_01["total_cost"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("Profit"))
                        {
                            dr_01["profit"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("OtherAdjustments"))
                        {
                            dr_01["other_adjust"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("ToolingSamplePlusProduction"))
                        {
                            dr_01["total_tooling"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("TotalFob"))
                        {
                            dr_01["total_fob"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("LeanSavingsTarget"))
                        {
                            dr_01["lean_saving_target"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("LaborComments"))
                        {
                            dr_01["labor_comments"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("OverHead"))
                        {
                            dr_01["oh_comments"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("SizeRun"))
                        {
                            dr_01["size_run"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                        else if (vDT.Columns[detail_col].ColumnName.Equals("TotalSizeRun"))
                        {
                            dr_01["total_size_run"] = vDT.Rows[detail_row].ItemArray[detail_col].ToString();
                        }
                    }
                }

                arg_destDT.Rows.Add(dr_01);

                return arg_destDT;
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region Properties

        public Excel.Workbook Workbook
        {
            get { return workbook; }
            set { workbook = value; }
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
