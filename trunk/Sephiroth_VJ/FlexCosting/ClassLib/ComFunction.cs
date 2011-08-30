using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace FlexCosting.ClassLib
{
    class ComFunction : COM.ComFunction
    {
        /// <summary>
        /// Select_Factory_List : Factory 조회
        /// </summary>
        /// <returns></returns>
        public static DataTable Select_Factory_List_Cost()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SFB_COMMON.SELECT_FACTORY_LIST";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Select_Prod_Factory_List_Cost()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SFB_COMMON.SELECT_PROD_FACTORY_LIST";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupTypeCode()
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "SEPHIROTH.PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TYPE";

            oraDB.ReDim_Parameter(1);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupLCode(string arg_group_type)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_L";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_group_type;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        #region Document number

        /// <summary>
        /// SELECT_DOCUMENT_NO : 
        /// </summary>
        /// <param name="arg_factory">Factory</param>
        /// <param name="arg_doc_division">Division</param>
        /// <param name="arg_doc_type">Type</param>
        /// <param name="agr_doc_date">Date</param>
        /// <param name="arg_upd_user">User</param>
        /// <returns></returns>
        public static DataTable SELECT_DOCUMENT_NO(string arg_factory,
            string arg_doc_division,
            string arg_doc_type,
            string agr_doc_date,
            string arg_upd_user)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_DOCUMENT_NO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DOC_DIVISION";
            MyOraDB.Parameter_Name[2] = "ARG_DOC_TYPE";
            MyOraDB.Parameter_Name[3] = "AGR_DOC_DATE";
            MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
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
            MyOraDB.Parameter_Values[1] = arg_doc_division;
            MyOraDB.Parameter_Values[2] = arg_doc_type;
            MyOraDB.Parameter_Values[3] = agr_doc_date;
            MyOraDB.Parameter_Values[4] = arg_upd_user;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        #endregion

        #region Old sephiroth

        public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt)
        {
            if (arg_cmb != null)
            {
                for (int i = 0; i < arg_cmb.Length; i++)
                {
                    if (arg_cmb[i].SelectedIndex < 0)
                    {
                        ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        arg_cmb[i].Focus();
                        return false;
                    }
                }
            }
            if (arg_txt != null)
            {
                for (int i = 0; i < arg_txt.Length; i++)
                {
                    if (arg_txt[i].Text == "")
                    {
                        ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        arg_txt[i].Focus();
                        return false;
                    }
                }
            }
            return true;
        }


        public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt, bool arg_blank_check)
        {
            if (arg_cmb != null)
            {
                for (int i = 0; i < arg_cmb.Length; i++)
                {
                    if (arg_cmb[i].SelectedIndex < 0 || arg_cmb[i].SelectedValue.ToString().Trim() == "")
                    {
                        ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        arg_cmb[i].Focus();
                        return false;
                    }
                }
            }
            if (arg_txt != null)
            {
                for (int i = 0; i < arg_txt.Length; i++)
                {
                    if (arg_txt[i].Text == "")
                    {
                        ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        arg_txt[i].Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Set_ComboList_Multi : 여러개 콤보리스트
        /// </summary> 
        public static void Set_ComboList_Multi(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int[] arg_pos, bool arg_emptyrow)
        {
            DataSet temp_dataset = new System.Data.DataSet();
            DataTable temp_datatable;
            DataRow newrow;

            temp_datatable = temp_dataset.Tables.Add("Combo List");

            for (int i = 0; i < arg_pos.Length; i++)
            {
                temp_datatable.Columns.Add(new DataColumn("Item" + i, Type.GetType("System.String")));
            }

            for (int i = 0; i < dtcmb_list.Rows.Count; i++)
            {
                newrow = temp_datatable.NewRow();
                for (int j = 0; j < arg_pos.Length; j++)
                {
                    newrow[j] = dtcmb_list.Rows[i].ItemArray[arg_pos[j]];
                }
                temp_datatable.Rows.Add(newrow);
            }



            arg_cmb.DataSource = temp_datatable;

            arg_cmb.ValueMember = "Item0";
            arg_cmb.DisplayMember = "Item0";

            arg_cmb.SelectedIndex = -1;
            arg_cmb.MaxDropDownItems = 10;

            int dropdownwidth = arg_pos.Length * 60;
            if (arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width;
            arg_cmb.DropDownWidth = dropdownwidth;

            arg_cmb.ExtendRightColumn = true;
            arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
        }

        public static DataTable SELECT_MODEL_LIST(string arg_factory)
        {

            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_SDC_MODEL";

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Set_OBSID_CmbList : OBS TYPE별 OBS ID 생성 및 콤보리스트에 추가
        /// </summary>
        /// <param name="arg_type">선택된 OBS Type</param>
        /// <param name="arg_cmb">적용 대상 콤보 박스명</param>
        public static void Set_OBSID_CmbList(string arg_type, bool arg_empty, C1.Win.C1List.C1Combo arg_cmb)
        {
            int i = 0;
            string sDate1, sDate2;

            COM.ComFunction MyComFunction = new COM.ComFunction();
            DateTime CurDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));


            arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            arg_cmb.ClearItems();
            arg_cmb.ExtendRightColumn = true;
            arg_cmb.ColumnHeaders = false;
            arg_cmb.SelectedIndex = -1;



            arg_cmb.AddItem("ALL");



            switch (arg_type)
            {
                case "OR":
                    for (i = -1; i <= 1; i++)
                        //arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0605");
                        arg_cmb.AddItem(CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2, 2) + "0605");


                    break;

                case "SS":
                case "PS":
                    for (i = -1; i <= 1; i++)
                        //arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0112");
                        arg_cmb.AddItem(CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2, 2) + "0112");

                    // arg_cmb.SelectedIndex = 1;
                    break;

                case "TS":
                case "TP":
                //				case "ID" :
                //					for(i = -7; i <= 3; i++)					
                //					{					
                //						sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
                //						sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + "01";
                //
                //						arg_cmb.AddItem(sDate1);
                //					}
                //
                //					arg_cmb.SelectedIndex = 3;													
                //					break;		

                case "QQ":

                    for (i = -3; i <= 3; i++)
                    {
                        sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
                        sDate2 = CurDate.AddMonths(i + 1).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2); ;

                        arg_cmb.AddItem(sDate1);
                    }

                    //arg_cmb.SelectedIndex = 3;
                    break;

                default:
                    for (i = -7; i <= 3; i++)
                    {
                        sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
                        sDate2 = CurDate.AddMonths(i + 2).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2);

                        arg_cmb.AddItem(sDate1);
                    }


                    //arg_cmb.SelectedIndex = 5;
                    break;
            }

            arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);
            arg_cmb.SelectedIndex = 0;
        }

        /// <summary>
        /// SELECT_MATPRICE_COMBO_YEAR : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_poweruser_yn"></param>
        /// <returns></returns>
        public static DataTable SELECT_MATPRICE_COMBO_YEAR(string arg_factory, string arg_poweruser_yn)
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH.SELECT_COMBO_YEAR";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_POWERUSER_YN";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_poweruser_yn;
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

        // combo style change (title, width, visible)
        public static void SetComboStyle(C1.Win.C1List.C1Combo arg_combo, string[] arg_title, int[] arg_width, bool[] arg_visible, string arg_display)
        {
            if (arg_title.Length == arg_width.Length && arg_width.Length == arg_visible.Length)
            {
                for (int i = 0; i < arg_title.Length; i++)
                {
                    arg_combo.Columns[i].Caption = arg_title[i];
                    arg_combo.Splits[0].DisplayColumns[i].Width = arg_width[i];
                    arg_combo.Splits[0].DisplayColumns[i].Visible = arg_visible[i];
                }

                arg_combo.DisplayMember = arg_display;
            }
            else
                return;
        }

        /// <summary>
        /// SELECT_MATPRICE_COMBO_FACTORY : 
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_MATPRICE_COMBO_FACTORY()
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(1);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EFI_BEP_SIMULATION.SELECT_FACTORY_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = "";


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

        public static string Set_Default_Factory()
        {


            string webservice_url = COM.ComVar._WebSvc.Url;
            string return_factory = COM.ComVar.DSFactory;


            if (webservice_url == COM.ComVar.DS_WebSvc_Url)
            {
                return_factory = "VJ";
            }
            else if (webservice_url == COM.ComVar.QD_WebSvc_Url)
            {
                return_factory = "QD";
            }
            else if (webservice_url == COM.ComVar.VJ_WebSvc_Url)
            {
                return_factory = "VJ";
            }


            return return_factory;

        }

        #endregion
    }
}
