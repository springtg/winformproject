using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace FlexCosting.Management.Costing.Frm
{
    class DBMngr
    {
        COM.OraDB MyOraDB = new COM.OraDB();

        #region 조회 ( XML 용 )

        public System.Data.DataSet SELECT_SFX_CBD_HEAD(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd, string arg_xml_seq)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_XML_SEQ";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                int idx2 = 0;
                for (; idx2 < MyOraDB.Parameter_Name.Length - 1; idx2++)
                {
                    MyOraDB.Parameter_Type[idx2] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[5] = arg_xml_seq;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);

                string[] procs = new string[] {
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL1_UP", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL2_PK", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL3_MS", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL4_OS", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL5_LB", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL6_OH", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL7_SM", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_SFX_CBD_TAIL8_PM", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_EBM_FOB_5523", 
                        "PKG_SFX_CBD_MASTER_XML.SELECT_EBM_FOB_MEOF",
                        "PKG_SFX_CBD_MASTER_XML.SELECT_EBM_FOB_MAX_COUNT"
                };

                return SELECT_SFX_CBD_TAIL(procs, arg_dev_fac, arg_moid, arg_cbd_id, arg_cbd_seq, arg_fob_type_cd, arg_xml_seq);
            }
            catch
            {
                return null;
            }
        }

        private System.Data.DataSet SELECT_SFX_CBD_TAIL(string[] arg_proc_names,
            string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd, string arg_xml_seq) 
        {
            try
            {
                for (int idx = 0; idx < arg_proc_names.Length; idx++)
                {
                    MyOraDB.ReDim_Parameter(7);

                    //01.PROCEDURE명
                    MyOraDB.Process_Name = arg_proc_names[idx];

                    //02.ARGURMENT 명
                    MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                    MyOraDB.Parameter_Name[1] = "ARG_MOID";
                    MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                    MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                    MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                    MyOraDB.Parameter_Name[5] = "ARG_XML_SEQ";
                    MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                    //03.DATA TYPE 정의
                    int idx2 = 0;
                    for (; idx2 < MyOraDB.Parameter_Name.Length - 1; idx2++)
                    {
                        MyOraDB.Parameter_Type[idx2] = (int)OracleType.VarChar;
                    }
                    MyOraDB.Parameter_Type[idx2] = (int)OracleType.Cursor;

                    //04.DATA 정의
                    MyOraDB.Parameter_Values[0] = arg_dev_fac;
                    MyOraDB.Parameter_Values[1] = arg_moid;
                    MyOraDB.Parameter_Values[2] = arg_cbd_id;
                    MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                    MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                    MyOraDB.Parameter_Values[5] = arg_xml_seq;
                    MyOraDB.Parameter_Values[6] = "";

                    MyOraDB.Add_Select_Parameter(false);
                }

                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;
            }
            catch
            {
                return null;
            }
        }

        #endregion

    }
}
