using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Collections;

namespace FlexVJ_Common.Material_Inspection
{


    public partial class Form_Incoming : COM.VJ_CommonWinForm.Form_Top
    {
        #region "Variable"
        private COM.OraDB MyOraDB = new COM.OraDB();

        private const string ARG_FACTORY = "arg_factory";
        private const string ARG_GRP_CODE = "ARG_GRP_CODE";
        private const string ARG_COM_CD = "ARG_COM_CD";
        private const string ARG_KEYSEARCH = "ARG_KEYSEARCH";
        private const string ARG_INCOMING_YMD = "arg_incoming_ymd";
        private const string ARG_INCOMING_LOCATION = "arg_incoming_location";
        private const string ARG_CUST_CD = "arg_cust_cd";
        private const string OUT_CURSOR = "OUT_CURSOR";
        private const string ARG_DIVISION = "arg_division";
        private const string ARG_INCOMING_SEQ = "arg_incoming_seq";
        private const string ARG_INVOICE = "arg_invoice";
        private const string ARG_UNIT = "arg_unit";
        private const string ARG_TOTAL_QTY = "arg_total_qty";
        private const string ARG_TR_UNIT = "arg_tr_unit";
        private const string ARG_TR_TOTAL_QTY = "arg_tr_total_qty";
        private const string ARG_FAIL_QTY = "arg_fail_qty";
        private const string ARG_REASON_CD = "arg_reason_cd";
        private const string ARG_REASON_QTY = "arg_reason_qty";
        private const string ARG_INCOMING_CASE = "arg_incoming_case";
        private const string ARG_INCOMING_REMARK = "arg_incoming_remark";
        private const string ARG_FIX_TF = "arg_fix_tf";
        private const string ARG_WEEKLY_CD = "arg_weekly_cd";
        private const string ARG_UPD_USER = "arg_upd_user";
        private const string ARG_GOODSGROUP = "arg_goodsgroup";


        #endregion


        public Form_Incoming()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void InitForm()
        {
            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Print.Enabled = false;

            btn_Cancel_Confirm.Enabled = false;
            btn_Confirm.Enabled = false;

            this.Text = "Input for Inspection Head";
            this.lbl_MainTitle.Text = this.Text;

            // factory set
            DataTable vDt = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            //set cho goods group 
            vDt = SEARCH_GOODSGROUP();
            COM.ComCtl.Set_ComboList(vDt, cmb_GoodGroup, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_GoodGroup.SelectedIndex = 0;

            // 그리드 설정
            fgrid_Incoming.Set_Grid("SMI_INCOMING_LIST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Incoming.Set_Action_Image(img_Action);
            fgrid_Incoming.KeyActionEnter = KeyActionEnum.MoveAcrossOut;

            fgrid_Incoming.Make_CmbDataList(COM.ComVar.ComboList_Type.Query, SEARCH_ALL_CUST(), Convert.ToInt32(GRID_ALIAS.CUST_CD));

            fgrid_Incoming.Cols[Convert.ToInt32(GRID_ALIAS.TOTAL_QTY)].Style.Format = "###,###,##0.#";
            fgrid_Incoming.Cols[Convert.ToInt32(GRID_ALIAS.REASON_QTY)].Style.Format = "###,###,##0.#";
            fgrid_Incoming.Cols[Convert.ToInt32(GRID_ALIAS.TR_TOTAL_QTY)].Style.Format = "###,###,##0.#";
            fgrid_Incoming.Cols[Convert.ToInt32(GRID_ALIAS.FAIL_QTY)].Style.Format = "###,###,##0.#";

            //LOCATION SET DATA

            vDt = SEARCH_SMI_CMN();
            COM.ComFunction.Set_ComboList(vDt, cmb_Location, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Location.SelectedIndex = 0;


            ClassLib.ComFunction.Init_Form_Control(this);
            ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
        }

        private bool ValidateBeforeAddNew()
        {
            string rsMsg = string.Empty;
            if (COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty) == string.Empty)
            {
                rsMsg += "Pls Select 'Factory'\n";
                cmb_Factory.Focus();
            }
            if (COM.ComFunction.Empty_Combo(cmb_Location, string.Empty).Equals(string.Empty))
            {
                rsMsg += "Pls Select 'Location'\n";
                cmb_Location.Focus();
            }
            if (dpk_Incomingdate.Value == null)
            {
                rsMsg += "Pls Select 'Incoming Date'\n";
                dpk_Incomingdate.Focus();
            }
            if (COM.ComFunction.Empty_Combo(cmb_Cust, string.Empty).Equals(string.Empty))
            {
                rsMsg += "Pls Select 'Customer'\n";
                cmb_Cust.Focus();
            }
            if (rsMsg.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                COM.ComFunction.User_Message(rsMsg);
                return false;
            }
        }

        private DataTable SEARCH_SMI_CMN()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_SMI_CMN";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_GRP_CODE;
            MyOraDB.Parameter_Name[2] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = "";
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable SEARCH_SCM_CUST()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_SCM_CUST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_KEYSEARCH;
            MyOraDB.Parameter_Name[2] = ARG_INCOMING_LOCATION;
            MyOraDB.Parameter_Name[3] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = txt_CustSearchKey.Text;
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable SEARCH_ALL_CUST()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_ALL_CUST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable SEARCH_GOODSGROUP()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_SMI_CMN_GOODSGROUP";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_GRP_CODE;
            MyOraDB.Parameter_Name[2] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable SEARCH_SCM_CODE(string arg_Com_cd)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_SCM_CODE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_COM_CD;
            MyOraDB.Parameter_Name[2] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = arg_Com_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable SEARCH_SMI_INCOMING()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_SMI_INCOMING";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_INCOMING_YMD;
            MyOraDB.Parameter_Name[2] = ARG_INCOMING_LOCATION;
            MyOraDB.Parameter_Name[3] = ARG_CUST_CD;
            MyOraDB.Parameter_Name[4] = ARG_GOODSGROUP;
            MyOraDB.Parameter_Name[5] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_Cust, string.Empty);
            MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_GoodGroup, string.Empty);
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        public bool SAVE_SMI_INCOMING()
        {
            try
            {
                int para_ct = 0;
                int iCount = 20;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "pkg_smi_mat_ins.save_smi_incoming";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = ARG_DIVISION;
                MyOraDB.Parameter_Name[1] = ARG_FACTORY;
                MyOraDB.Parameter_Name[2] = ARG_INCOMING_YMD;
                MyOraDB.Parameter_Name[3] = ARG_INCOMING_LOCATION;
                MyOraDB.Parameter_Name[4] = ARG_CUST_CD;
                MyOraDB.Parameter_Name[5] = ARG_INCOMING_SEQ;
                MyOraDB.Parameter_Name[6] = ARG_INVOICE;
                MyOraDB.Parameter_Name[7] = ARG_UNIT;
                MyOraDB.Parameter_Name[8] = ARG_TOTAL_QTY;
                MyOraDB.Parameter_Name[9] = ARG_TR_UNIT;
                MyOraDB.Parameter_Name[10] = ARG_TR_TOTAL_QTY;
                MyOraDB.Parameter_Name[11] = ARG_FAIL_QTY;
                MyOraDB.Parameter_Name[12] = ARG_REASON_CD;
                MyOraDB.Parameter_Name[13] = ARG_REASON_QTY;
                MyOraDB.Parameter_Name[14] = ARG_INCOMING_CASE;
                MyOraDB.Parameter_Name[15] = ARG_INCOMING_REMARK;
                MyOraDB.Parameter_Name[16] = ARG_WEEKLY_CD;
                MyOraDB.Parameter_Name[17] = ARG_FIX_TF;
                MyOraDB.Parameter_Name[18] = ARG_UPD_USER;
                MyOraDB.Parameter_Name[19] = ARG_GOODSGROUP;

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[11] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[14] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;


                COM.FSP l_Flex = fgrid_Incoming;
                //MyOraDB.Parameter_Values = new string[iCount * (l_Flex.Rows.Count - l_Flex.Rows.Fixed)];
                ArrayList vModifyList = new ArrayList();

                for (int iRow = l_Flex.Rows.Fixed; iRow < l_Flex.Rows.Count; iRow++)
                {
                    if (!ClassLib.ComFunction.NullToBlank(l_Flex[iRow, 0]).Equals(""))
                    {
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, 0]));//division
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.FACTORY)]));//factory

                        DateTime l_DateTmp = DateTime.ParseExact(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_YMD)].ToString().Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                        vModifyList.Add(Convert.ToString(l_DateTmp.ToString("yyyyMMdd")));//incoming_ymd

                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_LOCATION)]));//incoming_location
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.CUST_CD)]));//cust_cd
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_SEQ)]));//incoming_seq
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INVOICE)]));//invoice 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.UNIT)]));//unit 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.TOTAL_QTY)]));//total_qty 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.TR_UNIT)]));//tr unit 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.TR_TOTAL_QTY)]));//tr total_qty 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.FAIL_QTY)]));//fail_qty   
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.REASON_CD)]));//reason_cd 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.REASON_QTY)]));//reason_qty 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_CASE)]));//incoming_case   
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_REMARK)]));//incoming_remark  
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.WEEKLY_CD)]));//weekly_cd  
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.FIX_TF)]));//FIX_TF  
                        vModifyList.Add(COM.ComVar.This_User);//upd_user  
                        vModifyList.Add(COM.ComFunction.Empty_Combo(cmb_GoodGroup, ""));//goods group
                        //para_ct += iCount;
                    }
                }

                MyOraDB.Parameter_Values = new string[vModifyList.Count];
                for (int j = 0; j < vModifyList.Count; j++)
                {
                    MyOraDB.Parameter_Values[j] = vModifyList[j].ToString().Trim();
                }

                MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가


                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg_fsp"></param>
        /// <param name="arg_RowConfirmIndex"></param>
        /// <param name="arg_Action"></param>
        /// <returns></returns>
        public bool CONFIRM_SMI_INCOMING(COM.FSP arg_fsp, int arg_RowConfirmIndex, string arg_Action)
        {
            try
            {
                int para_ct = 0;
                int iCount = 7;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "pkg_smi_mat_ins.comfirm_smi_incoming";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = ARG_DIVISION;
                MyOraDB.Parameter_Name[1] = ARG_FACTORY;
                MyOraDB.Parameter_Name[2] = ARG_INCOMING_YMD;
                MyOraDB.Parameter_Name[3] = ARG_INCOMING_LOCATION;
                MyOraDB.Parameter_Name[4] = ARG_CUST_CD;
                MyOraDB.Parameter_Name[5] = ARG_INCOMING_SEQ;
                MyOraDB.Parameter_Name[6] = ARG_UPD_USER;

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;


                COM.FSP l_Flex = arg_fsp;
                ArrayList vModifyList = new ArrayList();
                int iRow = arg_RowConfirmIndex;
                if (ClassLib.ComFunction.NullToBlank(l_Flex[iRow, 0]).Equals(""))
                {
                    vModifyList.Add(arg_Action);
                    vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.FACTORY)]));//factory
                    DateTime l_DateTmp = DateTime.ParseExact(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_YMD)].ToString().Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                    vModifyList.Add(Convert.ToString(l_DateTmp.ToString("yyyyMMdd")));//incoming_ymd 
                    vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_LOCATION)]));//incoming_location
                    vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.CUST_CD)]));//cust_cd
                    vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS.INCOMING_SEQ)]));//incoming_seq
                    vModifyList.Add(COM.ComVar.This_User);//upd_user  
                }

                MyOraDB.Parameter_Values = new string[vModifyList.Count];
                for (int j = 0; j < vModifyList.Count; j++)
                {
                    MyOraDB.Parameter_Values[j] = vModifyList[j].ToString().Trim();
                }

                MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가


                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// check on value before confirm action on control
        /// </summary>
        /// <param name="arg_fsp"></param>
        /// <param name="arg_RowConfirmIndex"></param>
        /// <returns></returns>
        private bool ValidateValueBeforeConfirm(COM.FSP arg_fsp, int arg_RowConfirmIndex)
        {
            if (!ClassLib.ComFunction.NullToBlank(arg_fsp[arg_RowConfirmIndex, 0]).Equals(""))
            {
                COM.ComFunction.User_Message("Pls 'Save Data' before 'Confirm'", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (ClassLib.ComFunction.NullToBlank(arg_fsp[arg_RowConfirmIndex, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y"))
            {
                COM.ComFunction.User_Message("This Row has Confirmed!", "Infor", MessageBoxButtons.OK);
                return false;
            }
            if (COM.ComFunction.User_Message("Are you want to Confirm This Row", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// check on value before cancel confirm action on control
        /// </summary>
        /// <param name="arg_fsp"></param>
        /// <param name="arg_RowConfirmIndex"></param>
        /// <returns></returns>
        private bool ValidateValueBeforeCancelConfirm(COM.FSP arg_fsp, int arg_RowConfirmIndex)
        {
            if (COM.ComFunction.User_Message("Are you want to Cancel Confirm This Row", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// check on value before save action on control
        /// </summary>
        /// <returns></returns>
        private bool ValidateValueBeforeSave()
        {
            string rsMsg = string.Empty;
            COM.FSP l_Flex = fgrid_Incoming;
            string strTemplate = "Row: {0} Pls Input: {1}\n";
            for (int i = l_Flex.Rows.Fixed; i < l_Flex.Rows.Count; i++)
            {
                if (ClassLib.ComFunction.NullToBlank(l_Flex[i, 0]).Equals("")) continue;
                if (ClassLib.ComFunction.NullToBlank(l_Flex[i, 0]).Equals("D")) continue;
                string rsMsg1 = string.Empty;
                //check Invoice No
                if (l_Flex[i, Convert.ToInt32(GRID_ALIAS.INVOICE)].Equals(string.Empty))
                {
                    if (COM.ComFunction.User_Message("Are you want to auto Invoice No", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        l_Flex[i, Convert.ToInt32(GRID_ALIAS.INVOICE)] = string.Format("AUTO_{0}", dpk_Incomingdate.Value.ToString("yyyyMMdd"));
                    }
                    else
                    {
                        rsMsg1 += "\tInvoice No";
                    }
                }
                //check total
                if (l_Flex[i, Convert.ToInt32(GRID_ALIAS.TOTAL_QTY)] == null)
                {
                    rsMsg1 += "\t'Total'";
                }
                //check weekly
                if (l_Flex[i, Convert.ToInt32(GRID_ALIAS.WEEKLY_CD)] == null)
                {
                    rsMsg1 += "\t'Weekly'";
                }

                //check fail
                if (l_Flex[i, Convert.ToInt32(GRID_ALIAS.FAIL_QTY)] != null)
                {
                    /*if (ClassLib.ComFunction.NullToBlank(l_Flex[i, Convert.ToInt32(GRID_ALIAS.REASON_CD)].ToString()) != "")
                    {
                        rsMsg1 += "\t'Reason'";
                    
                    if (COM.ComFunction.Empty_Number(ClassLib.ComFunction.NullToBlank(l_Flex[i, Convert.ToInt32(GRID_ALIAS.REASON_QTY)]), "0") >= 1)
                    {
                        rsMsg1 += "\t'Reason Qty'";
                    }*/
                }
                if (rsMsg1 != string.Empty)
                {
                    rsMsg += string.Format(strTemplate, (i - 1), rsMsg1);
                }

            }
            if (!rsMsg.Equals(string.Empty))
            {
                COM.ComFunction.User_Message(rsMsg, "Error");
                return false;
            }
            return true;
        }

        /// <summary>
        /// active trang thai control kho add new row hay cancel
        /// </summary>
        /// <param name="arg_Cancel">true: CANCEL; false: ADD NEW</param>
        private void ActiveGroupControl(bool arg_Cancel)
        {
            if (!arg_Cancel)//neu la add new
            {
                pnl_head.Enabled = false;
                tbtn_Create.Enabled = true;
            }
            else//neu la cancel
            {
                pnl_head.Enabled = true;
                tbtn_Create.Enabled = false;
            }
        }

        /// <summary>
        /// hien thi du lieu len grid
        /// show data to grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        /// <param name="arg_dt"></param>
        private void Display_FlexGrid(COM.FSP arg_FSP, DataTable arg_dt)
        {
            Clear_FlexGrid(arg_FSP);

            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = arg_FSP.Rows.InsertNode(arg_FSP.Rows.Fixed + iRow, 1);
                arg_FSP[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    arg_FSP[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
                if (ClassLib.ComFunction.NullToBlank(arg_FSP[newRow.Row.Index, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y"))
                {
                    arg_FSP.Rows[newRow.Row.Index].AllowEditing = false;
                }
                else
                {
                    arg_FSP.Rows[newRow.Row.Index].AllowEditing = true;
                }
            }
            FormatGrid(arg_FSP);
        }

        /// <summary>
        /// format grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        private void FormatGrid(COM.FSP arg_FSP)
        {
            for (int i = arg_FSP.Rows.Fixed; i < arg_FSP.Rows.Count; i++)
            {
                if (ClassLib.ComFunction.NullToBlank(arg_FSP[i, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y"))
                {
                    CellStyle l_csTmp = arg_FSP.GetCellStyle(i, Convert.ToInt32(GRID_ALIAS.FIX_TF));
                    if (l_csTmp == null) l_csTmp = arg_FSP.Styles.Add("CONFIRM");
                    l_csTmp.BackColor = COM.ComVar.ClrFinishY;
                    for (int j = Convert.ToInt32(GRID_ALIAS.FACTORY); j < arg_FSP.Cols.Count; j++)
                    {
                        arg_FSP.SetCellStyle(i, j, l_csTmp);
                    }

                }
            }
        }


        /// <summary>
        /// clear data on grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        private void Clear_FlexGrid(COM.FSP arg_FSP)
        {
            if (arg_FSP.Rows.Fixed != arg_FSP.Rows.Count)
            {
                arg_FSP.Clear(ClearFlags.UserData, arg_FSP.Rows.Fixed, 1, arg_FSP.Rows.Count - 1, arg_FSP.Cols.Count - 1);

                arg_FSP.Rows.Count = arg_FSP.Rows.Fixed;
            }
        }

        private void FilterCust_by_Location()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                cmb_Cust.DataSource = null;
                DataTable dt = SEARCH_SCM_CUST();
                COM.ComFunction.Set_ComboList(dt, cmb_Cust, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
                //fgrid_Incoming.Make_CmbDataList(COM.ComVar.ComboList_Type.ComCode, dt, Convert.ToInt32(GRID_ALIAS.CUST_CD));
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "FilterCust_by_Location", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region "Event"

        private void Form_Incoming_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Display_FlexGrid(fgrid_Incoming, SEARCH_SMI_INCOMING());
                ActiveGroupControl(true);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateValueBeforeSave())
                {
                    if (SAVE_SMI_INCOMING())
                    {
                        Display_FlexGrid(fgrid_Incoming, SEARCH_SMI_INCOMING());
                    }
                }
                ActiveGroupControl(true);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                COM.FSP l_Flex = fgrid_Incoming;
                if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed) return;
                if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, 0]).Equals("I"))
                {
                    l_Flex.RemoveItem(l_Flex.RowSel);
                }
                else if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, 0]).Equals(""))
                {
                    l_Flex.Delete_Row(l_Flex.RowSel);
                }
                ActiveGroupControl(false);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (ValidateBeforeAddNew())
            {
                COM.FSP l_Flex = fgrid_Incoming;
                l_Flex.Add_Row(1);
                l_Flex[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS.FACTORY)] = cmb_Factory.SelectedValue;
                l_Flex[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS.INCOMING_SEQ)] = "1";
                l_Flex[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS.CUST_CD)] = cmb_Cust.SelectedValue;
                l_Flex[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS.INCOMING_LOCATION)] = cmb_Location.SelectedValue;
                l_Flex[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS.INCOMING_YMD)] = dpk_Incomingdate.Value.ToString("yyyy-MM-dd");
                l_Flex[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS.UNIT)] = "pk";

                ActiveGroupControl(false);
            }
        }

        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (COM.ComFunction.User_Message("Are You want to cancel value add new on Grid?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ActiveGroupControl(true);
                    tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "tbtn_Create_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txt_CustSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                FilterCust_by_Location();
            }
        }

        private void fgrid_Incoming_DoubleClick(object sender, EventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            if (l_Flex.ColSel != Convert.ToInt32(GRID_ALIAS.REASON_CD)) return;
            if (l_Flex.RowSel < l_Flex.Rows.Fixed) return;
            if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y")) return;
            Form_MI_Reason pop_Form_MI_Reason = new Form_MI_Reason();
            if (pop_Form_MI_Reason.ShowDialog() == DialogResult.OK)
            {
                if (pop_Form_MI_Reason.Tag != null)
                {
                    l_Flex[l_Flex.RowSel, l_Flex.ColSel] = pop_Form_MI_Reason.Tag;
                }
            }
        }

        private void fgrid_Incoming_SelChange(object sender, EventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed)
            {
                return;
            }
            if (!ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, 0]).Equals(""))
            {
                return;
            }
            if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, 0]).Equals(""))
            {
                if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y"))
                {
                    btn_Confirm.Enabled = false;
                    btn_Cancel_Confirm.Enabled = true;
                }
                else
                {
                    btn_Confirm.Enabled = true;
                    btn_Cancel_Confirm.Enabled = false;
                }
            }
        }

        private void fgrid_Incoming_AfterEdit(object sender, RowColEventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            l_Flex.Update_Row();
            if (l_Flex.ColSel == Convert.ToInt32(GRID_ALIAS.FAIL_QTY))
            {
                int l_iTmp = COM.ComFunction.Empty_Number(ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, l_Flex.ColSel]), "0");
                if (l_iTmp > 0)
                {
                    l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_CASE)] = 1;
                    l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.REASON_QTY)] = l_iTmp;
                }
                else
                {
                    l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_CASE)] = null;
                    l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.REASON_QTY)] = null;
                }
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateValueBeforeConfirm(fgrid_Incoming, fgrid_Incoming.RowSel))
                {
                    if (CONFIRM_SMI_INCOMING(fgrid_Incoming, fgrid_Incoming.RowSel, "CONFIRM"))
                    {
                        Display_FlexGrid(fgrid_Incoming, SEARCH_SMI_INCOMING());
                    }
                }
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_Cancel_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateValueBeforeCancelConfirm(fgrid_Incoming, fgrid_Incoming.RowSel))
                {
                    if (CONFIRM_SMI_INCOMING(fgrid_Incoming, fgrid_Incoming.RowSel, "CANCEL"))
                    {
                        Display_FlexGrid(fgrid_Incoming, SEARCH_SMI_INCOMING());
                    }
                }
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dpk_Incomingdate_ValueChanged(object sender, EventArgs e)
        {
            tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
        }

        private void cmb_Cust_SelectedValueChanged(object sender, EventArgs e)
        {
            C1.Win.C1List.C1Combo l_cmbCust = (C1.Win.C1List.C1Combo)sender;
            if (ClassLib.ComFunction.NullToBlank(l_cmbCust.SelectedValue).Equals("300_001"))
            {
                lbl_GooodsGroup.Visible = true;
                cmb_GoodGroup.Visible = true;
            }
            else
            {
                lbl_GooodsGroup.Visible = false;
                cmb_GoodGroup.Visible = false;
            }
            tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
        }

        private void cmb_Location_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterCust_by_Location();
            tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
        }
        #endregion
    }

    public enum GRID_ALIAS : int
    {
        FACTORY = 1,
        INCOMING_YMD = 2,
        INCOMING_LOCATION = 3,
        CUST_CD = 4,
        INCOMING_SEQ = 5,
        INVOICE = 6,
        UNIT = 7,
        TOTAL_QTY = 8,
        TR_UNIT = 9,
        TR_TOTAL_QTY = 10,
        FAIL_QTY = 11,
        REASON_CD = 12,
        REASON_QTY = 13,
        INCOMING_CASE = 14,
        WEEKLY_CD = 15,
        INCOMING_REMARK = 16,
        FIX_TF = 17
    }
}