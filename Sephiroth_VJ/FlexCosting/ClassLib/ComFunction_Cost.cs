using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexCosting.ClassLib
{
    class ComFunction_Cost
    {
        COM.OraDB MyOraDB = new COM.OraDB();

        #region DataBase

        /// <summary>
        /// 시즌 리스트를 가져옴
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable Select_Season(string arg_factory)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SFX_SEASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

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

        /// <summary>
        /// OBS ID를 가져옴
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable Select_DPO(string arg_factory)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SFX_OBS_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

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


        /// <summary>
        /// PKG_SFB_COMMON.SELECT_SXD_SRF_M_PART : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_PART(string arg_factory, string arg_search_text, string arg_part_type)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SXD_SRF_M_PART";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[2] = "ARG_PART_TYPE";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_search_text;
                MyOraDB.Parameter_Values[2] = arg_part_type;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFB_COMMON.SELECT_SXD_SRF_M_MAT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_MAT(string arg_factory, string arg_class, string arg_search_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SXD_SRF_M_MAT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_CLASS";
                MyOraDB.Parameter_Name[2] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_class;
                MyOraDB.Parameter_Values[2] = arg_search_text;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFB_COMMON.SELECT_SXD_SRF_M_MAT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_MAT_DETAIL(string arg_factory, string arg_class, string arg_search_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SXD_SRF_M_MAT_DETAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_CLASS";
                MyOraDB.Parameter_Name[2] = "ARG_MAT_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_class;
                MyOraDB.Parameter_Values[2] = arg_search_text;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SXD_SRF_M_MAT.SELECT_VENDOR_LIST : PCC 거래처 검색
        /// </summary>
        /// <returns>DataTable</returns>
        public System.Data.DataTable SELECT_CDC_VENDOR_LIST(string arg_factory, string arg_sch_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_CDC_VENDOR_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sch_text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFB_COMMON.SELECT_CDC_COLOR_LIST : PCC 칼라 검색
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_CDC_COLOR_LIST(string arg_factory, string arg_sch_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_CDC_COLOR_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sch_text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SXD_SRF_M_MAT.SELECT_VENDOR_LIST : 세피로스용 거래처 검색
        /// </summary>
        /// <returns>DataTable</returns>
        public System.Data.DataTable SELECT_SHC_VENDOR_LIST(string arg_factory, string arg_sch_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SHC_VENDOR_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sch_text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SXD_SRF_M_MAT.SELECT_SFB_CBD_B_MAT_BTTM_LIST : Bottom 원자재 검색
        /// </summary>
        /// <returns>DataTable</returns>
        public System.Data.DataTable SELECT_SFB_CBD_B_MAT_BTTM_LIST(string arg_factory, string arg_sch_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SFB_CBD_B_MAT_BTTM_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sch_text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFB_COMMON.SELECT_CBD_FOB_TYPE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_CBD_FOB_TYPE(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_CBD_FOB_TYPE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_SOLE.SELECT_SFB_CBD_B_MAT_BTTM : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFB_CBD_B_MAT_BTTM(string arg_factory, string arg_season, string arg_div)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();

                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFM_CBD_MASTER_SOLE.SELECT_SFB_CBD_B_MAT_BTTM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_DIV";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = arg_div;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Type and search

        /// <summary>
        /// PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_MAT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_MAT_LIST(string arg_factory, string arg_sch_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_MAT_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sch_text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_MAT_NUM_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_MAT_NUM_LIST(string arg_factory, string arg_mxs_number)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_MAT_NUM_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mxs_number;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_MAT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_MAT(string arg_factory, string arg_mxs_number, string arg_mxs_unit, string arg_mxs_special_option, string arg_mxs_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_MAT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_UNIT";
                MyOraDB.Parameter_Name[3] = "ARG_MXS_SPECIAL_OPTION";
                MyOraDB.Parameter_Name[4] = "ARG_MXS_SEQ";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mxs_number;
                MyOraDB.Parameter_Values[2] = arg_mxs_unit;
                MyOraDB.Parameter_Values[3] = arg_mxs_special_option;
                MyOraDB.Parameter_Values[4] = arg_mxs_seq;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFB_COMMON.SELECT_SXD_SRF_M_PART : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_PART_LIST(string arg_factory, string arg_search_text, string arg_part_type)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SXD_SRF_M_PART_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[2] = "ARG_PART_TYPE";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_search_text;
                MyOraDB.Parameter_Values[2] = arg_part_type;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SXD_SRF_M_PART : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_PART(string arg_factory, string arg_part_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SXD_SRF_M_PART";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PART_SEQ";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_part_seq;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SXD_SRF_M_MAT.SELECT_VENDOR_LIST : PCC 거래처 검색
        /// </summary>
        /// <returns>DataTable</returns>
        public System.Data.DataTable SELECT_SFX_CBD_M_CUST_LIST(string arg_factory, string arg_sch_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_CUST_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sch_text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Create CBD From BOM

        /// <summary>
        /// PKG_SFM_CBD_MASTER_BOM.SFM_CBD_JOB_CREATE_FROM_BOM : 
        /// </summary>
        public bool SFM_CBD_JOB_CREATE_FROM_BOM(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_srf_seq, string arg_upd_user)
        {
            try
            {

                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_BOM.SFM_CBD_JOB_CREATE_FROM_BOM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
                MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sr_no;
                MyOraDB.Parameter_Values[2] = arg_srf_no;
                MyOraDB.Parameter_Values[3] = arg_bom_id;
                MyOraDB.Parameter_Values[4] = arg_bom_rev;
                MyOraDB.Parameter_Values[5] = arg_nf_cd;
                MyOraDB.Parameter_Values[6] = arg_srf_seq;
                MyOraDB.Parameter_Values[7] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Modify_Procedure();

                if (vDS == null)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region FX Rate

        /// <summary>
        /// PKG_SFB_CBD_B_FXRATE.SELECT_FXRATE_BY_SEASON : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_FXRATE_BY_SEASON(string arg_factory, string arg_season_from, string arg_season_to)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_FXRATE.SELECT_FXRATE_BY_SEASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season_from;
                MyOraDB.Parameter_Values[2] = arg_season_to;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_SEARCH_BOM.SELECT_SFM_CBD_FXRATE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_FXRATE(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd, string arg_season)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_SEARCH_BOM.SELECT_SFM_CBD_FXRATE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_SEASON";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[5] = arg_season;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_SEARCH_BOM.SELECT_SFM_CBD_FXRATE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_FXRATE(string arg_dev_fac, string arg_season)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_SEARCH_BOM.SELECT_SFX_CBD_M_FXRATE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_SEARCH_BOM.SELECT_SFM_CBD_FXRATE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFM_CBD_FXRATE(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd, string arg_season)
        {
            return null;

            //try
            //{
            //    DataSet vds_ret;

            //    MyOraDB.ReDim_Parameter(7);

            //    //01.PROCEDURE명
            //    MyOraDB.Process_Name = "PKG_SFM_CBD_SEARCH_BOM.SELECT_SFM_CBD_FXRATE";

            //    //02.ARGURMENT 명
            //    MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
            //    MyOraDB.Parameter_Name[1] = "ARG_MOID";
            //    MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
            //    MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
            //    MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
            //    MyOraDB.Parameter_Name[5] = "ARG_SEASON";
            //    MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //    //03.DATA TYPE 정의
            //    MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //    //04.DATA 정의
            //    MyOraDB.Parameter_Values[0] = arg_dev_fac;
            //    MyOraDB.Parameter_Values[1] = arg_moid;
            //    MyOraDB.Parameter_Values[2] = arg_cbd_id;
            //    MyOraDB.Parameter_Values[3] = arg_cbd_seq;
            //    MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
            //    MyOraDB.Parameter_Values[5] = arg_season;
            //    MyOraDB.Parameter_Values[6] = "";

            //    MyOraDB.Add_Select_Parameter(true);
            //    vds_ret = MyOraDB.Exe_Select_Procedure();
            //    if (vds_ret == null) return null;

            //    return vds_ret.Tables[MyOraDB.Process_Name];
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        #endregion

        #region Select PCC-BOM

        /// <summary>
        /// PKG_SFM_CBD_MASTER_BOM.SELECT_SXD_SRF_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_HEAD(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_srf_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
                MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sr_no;
                MyOraDB.Parameter_Values[2] = arg_srf_no;
                MyOraDB.Parameter_Values[3] = arg_bom_id;
                MyOraDB.Parameter_Values[4] = arg_bom_rev;
                MyOraDB.Parameter_Values[5] = arg_nf_cd;
                MyOraDB.Parameter_Values[6] = arg_srf_seq;
                MyOraDB.Parameter_Values[7] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_BOM.SELECT_SXD_SRF_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_HEAD(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_srf_seq, string arg_season_cd, string arg_model_id)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(10);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
                MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
                MyOraDB.Parameter_Name[7] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[8] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sr_no;
                MyOraDB.Parameter_Values[2] = arg_srf_no;
                MyOraDB.Parameter_Values[3] = arg_bom_id;
                MyOraDB.Parameter_Values[4] = arg_bom_rev;
                MyOraDB.Parameter_Values[5] = arg_nf_cd;
                MyOraDB.Parameter_Values[6] = arg_srf_seq;
                MyOraDB.Parameter_Values[7] = arg_season_cd;
                MyOraDB.Parameter_Values[8] = arg_model_id;
                MyOraDB.Parameter_Values[9] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_BOM.SELECT_SXD_SRF_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_SXD_SRF_TAIL(string[] arg_procedure, string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_srf_seq)
        {
            try
            {
                DataSet vds_ret;

                for (int iIdx = 0; iIdx < arg_procedure.Length; iIdx++)
                {

                    MyOraDB.ReDim_Parameter(8);

                    //01.PROCEDURE명
                    MyOraDB.Process_Name = arg_procedure[iIdx];

                    //02.ARGURMENT 명
                    MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                    MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
                    MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                    MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                    MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
                    MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
                    MyOraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
                    MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

                    //03.DATA TYPE 정의
                    MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                    //04.DATA 정의
                    MyOraDB.Parameter_Values[0] = arg_factory;
                    MyOraDB.Parameter_Values[1] = arg_sr_no;
                    MyOraDB.Parameter_Values[2] = arg_srf_no;
                    MyOraDB.Parameter_Values[3] = arg_bom_id;
                    MyOraDB.Parameter_Values[4] = arg_bom_rev;
                    MyOraDB.Parameter_Values[5] = arg_nf_cd;
                    MyOraDB.Parameter_Values[6] = arg_srf_seq;
                    MyOraDB.Parameter_Values[7] = "";

                    MyOraDB.Add_Select_Parameter(false);
                }

                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;
                return vds_ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_PK : 
        /// </summary>
        /// <returns>DataTable</returns>
        public bool SELECT_SXD_SRF_TAIL_PK(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_srf_seq, string arg_season_cd, string arg_cat_cd, string arg_gen_cd, string arg_sdm_yn)
        {
            try
            {
                MyOraDB.ReDim_Parameter(12);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_PK";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
                MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
                MyOraDB.Parameter_Name[7] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[8] = "ARG_CAT_CD";
                MyOraDB.Parameter_Name[9] = "ARG_GEN_CD";
                MyOraDB.Parameter_Name[10] = "ARG_SDM_YN";
                MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_sr_no;
                MyOraDB.Parameter_Values[2] = arg_srf_no;
                MyOraDB.Parameter_Values[3] = arg_bom_id;
                MyOraDB.Parameter_Values[4] = arg_bom_rev;
                MyOraDB.Parameter_Values[5] = arg_nf_cd;
                MyOraDB.Parameter_Values[6] = arg_srf_seq;
                MyOraDB.Parameter_Values[7] = arg_season_cd;
                MyOraDB.Parameter_Values[8] = arg_cat_cd;
                MyOraDB.Parameter_Values[9] = arg_gen_cd;
                MyOraDB.Parameter_Values[10] = arg_sdm_yn;
                MyOraDB.Parameter_Values[11] = "";

                return MyOraDB.Add_Select_Parameter(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Costing CBD 

        /// <summary>
        /// PKG_SFM_CBD_MASTER_CBD.SELECT_SFM_CBD_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_HEAD(string arg_factory, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_CBD.SELECT_SFM_CBD_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_HEAD(string arg_proc, string arg_factory, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = arg_proc;

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_CBD.SELECT_SFM_CBD_TAIL1_UP : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_SFX_CBD_TAIL(string[] arg_procedure, string arg_factory, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                for (int iIdx = 0; iIdx < arg_procedure.Length; iIdx++)
                {
                    MyOraDB.ReDim_Parameter(6);

                    //01.PROCEDURE명
                    MyOraDB.Process_Name = arg_procedure[iIdx];

                    //02.ARGURMENT 명
                    MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                    MyOraDB.Parameter_Name[1] = "ARG_MOID";
                    MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                    MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                    MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                    MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                    //03.DATA TYPE 정의
                    MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                    MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                    //04.DATA 정의
                    MyOraDB.Parameter_Values[0] = arg_factory;
                    MyOraDB.Parameter_Values[1] = arg_moid;
                    MyOraDB.Parameter_Values[2] = arg_cbd_id;
                    MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                    MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                    MyOraDB.Parameter_Values[5] = "";

                    if (iIdx == 0)
                        MyOraDB.Add_Select_Parameter(true);
                    else
                        MyOraDB.Add_Select_Parameter(false);
                }

                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;
                return vds_ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_5523 : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_EBM_FOB_5523(string arg_factory, string arg_prod_fac, string arg_style, string arg_region, string arg_mo_alias, string arg_bom_id, string arg_round, string arg_season_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE¸í
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_M_5523";

                //02.ARGURMENT ¸í
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_REGION";
                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_ROUND";
                MyOraDB.Parameter_Name[7] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";


                //03.DATA TYPE Á¤ÀÇ
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

                //04.DATA Á¤ÀÇ
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_prod_fac;
                MyOraDB.Parameter_Values[2] = arg_style;
                MyOraDB.Parameter_Values[3] = arg_region;
                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_round;
                MyOraDB.Parameter_Values[7] = arg_season_cd;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_CBD.SELECT_SFM_CBD_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFM_CBD_HEAD(string arg_factory, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            return null;

            //try
            //{
            //    DataSet vds_ret;

            //    MyOraDB.ReDim_Parameter(6);

            //    //01.PROCEDURE명
            //    MyOraDB.Process_Name = "PKG_SFM_CBD_MASTER_CBD.SELECT_SFM_CBD_HEAD";

            //    //02.ARGURMENT 명
            //    MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
            //    MyOraDB.Parameter_Name[1] = "ARG_MOID";
            //    MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
            //    MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
            //    MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
            //    MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            //    //03.DATA TYPE 정의
            //    MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            //    MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //    //04.DATA 정의
            //    MyOraDB.Parameter_Values[0] = arg_factory;
            //    MyOraDB.Parameter_Values[1] = arg_moid;
            //    MyOraDB.Parameter_Values[2] = arg_cbd_id;
            //    MyOraDB.Parameter_Values[3] = arg_cbd_seq;
            //    MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
            //    MyOraDB.Parameter_Values[5] = "";

            //    MyOraDB.Add_Select_Parameter(true);
            //    vds_ret = MyOraDB.Exe_Select_Procedure();
            //    if (vds_ret == null) return null;

            //    return vds_ret.Tables[MyOraDB.Process_Name];
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        /// <summary>
        /// PKG_SFM_CBD_MASTER_CBD.SELECT_SFM_CBD_TAIL1_UP : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_SFM_CBD_TAIL(string[] arg_procedure, string arg_factory, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            return null;

            //try
            //{
            //    DataSet vds_ret;

            //    for (int iIdx = 0; iIdx < arg_procedure.Length; iIdx++)
            //    {
            //        MyOraDB.ReDim_Parameter(6);

            //        //01.PROCEDURE명
            //        MyOraDB.Process_Name = arg_procedure[iIdx];

            //        //02.ARGURMENT 명
            //        MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
            //        MyOraDB.Parameter_Name[1] = "ARG_MOID";
            //        MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
            //        MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
            //        MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
            //        MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            //        //03.DATA TYPE 정의
            //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            //        MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            //        MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            //        MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            //        MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            //        MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //        //04.DATA 정의
            //        MyOraDB.Parameter_Values[0] = arg_factory;
            //        MyOraDB.Parameter_Values[1] = arg_moid;
            //        MyOraDB.Parameter_Values[2] = arg_cbd_id;
            //        MyOraDB.Parameter_Values[3] = arg_cbd_seq;
            //        MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
            //        MyOraDB.Parameter_Values[5] = "";

            //        if (iIdx == 0)
            //            MyOraDB.Add_Select_Parameter(true);
            //        else
            //            MyOraDB.Add_Select_Parameter(false);
            //    }

            //    vds_ret = MyOraDB.Exe_Select_Procedure();
            //    if (vds_ret == null) return null;
            //    return vds_ret;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        #endregion

        #region CBD Remarks 

        /// <summary>
        /// PKG_SFM_CBD_REMARK.SELECT_SFM_CBD_REMARK_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFM_CBD_REMARK_LIST(string arg_dev_fac, string arg_prod_fac, string arg_moid, string arg_cbd_id)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_REMARK.SELECT_SFM_CBD_REMARK_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_prod_fac;
                MyOraDB.Parameter_Values[2] = arg_moid;
                MyOraDB.Parameter_Values[3] = arg_cbd_id;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Nike Std defeceive rate

        /// <summary>
        /// PKG_SFB_COMMON.SELECT_LOSS_RATE_UPDATE_YMD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_LOSS_RATE_UPDATE_YMD(string arg_factory, bool arg_clear, bool arg_exec)
        {
            try
            {
                DataSet vds_ret = null;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_LOSS_RATE_UPDATE_YMD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(arg_clear);

                if (arg_exec)
                    vds_ret = MyOraDB.Exe_Select_Procedure();

                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #endregion

        #region Excel export

        /// <summary>
        /// DataTable 엑셀로 내보내기
        /// </summary>
        /// <param name="ds"></param>
        private void ExportExcel(string arg_msg, DataTable[] arg_ds)
        {
            //declaring the application
            Excel.Application oAppln;
            //declaring work book
            Excel.Workbook oWorkBook;
            //declaring worksheet
            Excel.Worksheet oWorkSheet;
            //declaring the range
            Excel.Range oRange;

            try
            {
                oAppln = new Excel.Application();
                oWorkBook = (Excel.Workbook)(oAppln.Workbooks.Add(true));
                oWorkSheet = (Excel.Worksheet)oWorkBook.ActiveSheet;

                int iRow = 1;

                for (int tabNo = 0; tabNo < arg_ds.Length; tabNo++)
                {
                    DataTable ds = arg_ds[tabNo];

                    //check for data
                    if (ds.Rows.Count > 0)
                    {
                        //headers 
                        for (int colNo = 0, idx = 1; colNo < ds.Columns.Count; colNo++)
                        {
                            if (ds.Columns[colNo].Prefix != null)
                                oWorkSheet.Cells[1, idx] = ds.Columns[colNo].ColumnName;
                        }

                        //inserting datas
                        for (int rowNo = 0; rowNo < ds.Rows.Count; rowNo++)
                        {
                            //in each row
                            for (int colNo = 0, idx = 1; colNo < ds.Columns.Count; colNo++)
                            {
                                if (ds.Columns[colNo].Prefix != null)
                                {
                                    // in each column
                                    if (ds.Rows[rowNo][colNo].ToString().StartsWith("0"))
                                    {
                                        oWorkSheet.Cells[iRow, idx] = "'" + ds.Rows[rowNo][colNo].ToString();
                                    }
                                    else
                                    {
                                        oWorkSheet.Cells[iRow, idx] = ds.Rows[rowNo][colNo].ToString();
                                    }
                                }
                            }
                            //moving to next row
                            iRow++;
                        }
                    }
                }

                //range of the excel sheet
                oRange = oWorkSheet.get_Range("A1", "IV1");
                oRange.EntireColumn.AutoFit();
                oAppln.UserControl = false;
                //path declaration
                string strFile = Application.StartupPath + "\\" + arg_msg + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";

                // to view Excel sheet...
                //oAppln.Visible = true;

                // to save the excel sheet....
                oWorkBook.SaveAs(strFile, Excel.XlFileFormat.xlWorkbookNormal, null, null, false, 
                    false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null,null);
                oAppln.Quit();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// DataTable 엑셀로 내보내기
        /// </summary>
        /// <param name="ds"></param>
        public void ExportExcel(string arg_fileName, COM.FSP[] arg_fsp)
        {
            Excel.Application oAppln = null;
            Excel.Workbook oWorkBook = null;
            Excel.Worksheet oWorkSheet = null;
            Excel.Range oRange = null;

            try
            {
                oAppln = new Excel.Application();
                oWorkBook = (Excel.Workbook)(oAppln.Workbooks.Add(true));
                oWorkSheet = (Excel.Worksheet)oWorkBook.ActiveSheet;

                InsertingHeader(oWorkSheet);

                int iRow = 35;

                for (int tabNo = 0; tabNo < arg_fsp.Length; tabNo++)
                {
                    COM.FSP fsp = arg_fsp[tabNo];

                    if (fsp.Rows.Count > 0)
                    {
                        // Subject 
                        oWorkSheet.Cells[iRow++, "A"] = fsp.Name;                        
                        for (int iExlCol = 1, iGridCol = 1; iGridCol < fsp.Cols.Count; iExlCol++, iGridCol++)
                        {
                            if (fsp.Cols[iGridCol].Visible)
                            {
                                oWorkSheet.Cells[iRow, iExlCol] = fsp[fsp.Rows.Fixed - 1, iGridCol].ToString();
                                //Excel.Range vRange = (Excel.Range)oWorkSheet.Cells[iRow, iExlCol];
                            }
                        }
                        iRow++;

                        // Datas 
                        for (int iGridRow = fsp.Rows.Fixed; iGridRow < fsp.Rows.Count; iGridRow++)
                        {
                            for (int iGridCol = 1, iExlCol = 1; iGridCol < fsp.Cols.Count; iGridCol++, iExlCol++)
                            {
                                if (fsp.Cols[iGridCol].Visible)
                                {
                                    if (fsp.Cols[iGridCol].StyleDisplay.DataType.Equals(System.Type.GetType("System.Double")))
                                    {
                                        oWorkSheet.Cells[iRow, iExlCol] = "'" + NullToDouble(fsp[iGridRow, iGridCol], 0);
                                    }
                                    else
                                    {
                                        if (fsp.Cols[iGridCol].Style.DataMap != null)
                                        {
                                            oWorkSheet.Cells[iRow, iExlCol] = NullToString(fsp.GetDataDisplay(iGridRow, iGridCol), "");
                                        }
                                        else
                                        {
                                            oWorkSheet.Cells[iRow, iExlCol] = NullToString(fsp[iGridRow, iGridCol], "");
                                        }
                                    }
                                }
                            }
                            iRow++;
                        }
                        iRow++;
                    }
                }

                // range of the excel sheet
                oRange = oWorkSheet.get_Range("A1", "IV1");
                oAppln.UserControl = false;

                //vpath declaration
                string strFile = Application.StartupPath + "\\" + arg_fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";

                // to view Excel sheet...
                //oAppln.Visible = true;

                // to save the excel sheet
                oWorkBook.SaveAs(strFile, Excel.XlFileFormat.xlWorkbookNormal, null, null, false,
                    false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oAppln != null)
                {
                    oAppln.Quit();
                    oAppln = null;
                }
                GC.Collect();
            }
        }

        private void InsertingHeader(Excel.Worksheet oWorkSheet)
        {
            

            // Subject 
            // A1
            int iExlRow = 1;
            string sExlCol = "A";
            oWorkSheet.Cells[iExlRow, sExlCol] = "MODEL";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "Dev Proj Alias";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "BOM ID";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "PRODUCT CODE";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "PRIMARY PRODUCTION";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "CATEGORY";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "FOB STATUS";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "FOB TYPE";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "SEASON";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "DATE QUO;TED";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "GENDER";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "SIZE";
            oWorkSheet.Cells[iExlRow += 2, sExlCol] = "SIZE UP %";

            // H1, I1
            iExlRow = 1;
            string sExlColSum = "H";
            string sExlColSub = "I";

            oWorkSheet.Cells[iExlRow++, sExlColSum] = "FOB SUMMARY";

            oWorkSheet.Cells[iExlRow++, sExlColSub] = "MATERIALS";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "UPPER MATERIALS";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "PACKAGING";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "MIDSOLE";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "OUTSOLE";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "SIZE UP";

            oWorkSheet.Cells[iExlRow++, sExlColSum] = "MATERIALS SUBTOTAL";


            iExlRow++;
            oWorkSheet.Cells[iExlRow++, sExlColSum] = "NON MATERIALS";

            oWorkSheet.Cells[iExlRow++, sExlColSub] = "LABOR";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "OVERHEAD";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "PROFIT (BEFORE TOOLING)";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "PROCESS COST";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "OTHER ADJUSTMENTS";

            oWorkSheet.Cells[iExlRow++, sExlColSum] = "NON MATERIALS SUBTOTAL";


            iExlRow++;
            oWorkSheet.Cells[iExlRow++, sExlColSum] = "TOOLING";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "SAMPLE TOOLING";
            oWorkSheet.Cells[iExlRow++, sExlColSub] = "PRODUCTION TOOLING";
            oWorkSheet.Cells[iExlRow++, sExlColSum] = "TOOLING SUBTOTAL";

            iExlRow++;
            oWorkSheet.Cells[iExlRow++, sExlColSum] = "TOTAL FOB WITH TOOLING";


            // N2, O2
            iExlRow = 2;
            string sExlColCost = "N";
            string sExlColPCT = "O";
            oWorkSheet.Cells[iExlRow, sExlColCost] = "COST";
            oWorkSheet.Cells[iExlRow, sExlColPCT] = "% OF FOB";


            // Q2, R2, S2
            iExlRow = 2;
            string sExlColCurr = "Q";
            string sExlColRate = "R";
            string sExlColCountry = "S";
            oWorkSheet.Cells[iExlRow, sExlColCurr] = "CURR";
            oWorkSheet.Cells[iExlRow, sExlColRate] = "F/X Rate";
            oWorkSheet.Cells[iExlRow, sExlColCountry] = "County";


            // Datas 


        }

        public string NullToString(object obj, string ret)
        {
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return ret;
            }
        }

        public double NullToDouble(object obj, double ret)
        {
            if (obj != null)
            {
                double dObj = 0;
                double.TryParse(obj.ToString(), out dObj);
                return dObj;
            }
            else
            {
                return ret;
            }
        }

        #endregion

        #region Properties

        public COM.OraDB MyOraDBInstance
        {
            get
            {
                return MyOraDB;
            }
        }

        #endregion

    }
}
