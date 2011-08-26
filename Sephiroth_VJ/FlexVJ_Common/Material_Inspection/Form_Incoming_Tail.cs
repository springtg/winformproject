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
    public enum GRID_ALIAS_D : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxINCOMING_YMD = 2,
        IxINCOMING_LOCATION = 3,
        IxINCOMING_SEQ = 4,
        IxCUST_CD = 5,
        IxINSP_SEQ = 6,
        IxINSP_YMD = 7,
        IxOBS_ID = 8,
        IxSTYLE_CD = 9,
        IxSTYLE_NAME = 10,
        IxLINE_CD = 11,
        IxSUPPLIER_CD = 12,
        IxGROUP_CD = 13,
        IxCLASS_CD = 14,
        IxCLASS_NAME = 15,
        IxMATERIAL_CD = 16,
        IxMATERIAL_NAME = 17,
        IxCOLOR_CD = 18,
        IxCOLOR_NAME = 19,
        IxUNIT = 20,
        IxINCOMING_QTY = 21,
        IxERROR_QTY1 = 22,
        IxREASON_CD1 = 23,
        IxERROR_QTY2 = 24,
        IxREASON_CD2 = 25,
        IxWEEKLY_CD = 26,
        IxREMARK = 27,
        IxFIX_YN = 28
    }

    public partial class Form_Incoming_Tail : COM.VJ_CommonWinForm.Form_Top
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
        private const string ARG_FAIL_QTY = "arg_fail_qty";
        private const string ARG_REASON_CD = "arg_reason_cd";
        private const string ARG_REASON_QTY = "arg_reason_qty";
        private const string ARG_INCOMING_CASE = "arg_incoming_case";
        private const string ARG_INCOMING_REMARK = "arg_incoming_remark";
        private const string ARG_FIX_TF = "arg_fix_tf";
        private const string ARG_WEEKLY_CD = "arg_weekly_cd";
        private const string ARG_UPD_USER = "arg_upd_user";

        private const string ARG_INSP_SEQ = "ARG_INSP_SEQ";
        private const string ARG_GROUP_CD = "ARG_GROUP_CD";
        private const string ARG_OBS_ID = "ARG_OBS_ID";
        private const string ARG_LINE_CD = "ARG_LINE_CD";

        private const string ARG_STYLE_CD = "ARG_STYLE_CD";
        private const string ARG_COLOR_CD = "ARG_COLOR_CD";
        private const string ARG_INCOMING_QTY = "ARG_INCOMING_QTY";
        private const string ARG_INSP_QTY = "ARG_INSP_QTY";
        private const string ARG_ERROR_QTY1 = "ARG_ERROR_QTY1";
        private const string ARG_REASON_CD1 = "ARG_REASON_CD1";
        private const string ARG_ERROR_QTY2 = "ARG_ERROR_QTY2";
        private const string ARG_REASON_CD2 = "ARG_REASON_CD2";
        private const string ARG_FIX_YN = "ARG_FIX_YN";

        private const string ARG_CLASS_CD = "ARG_CLASS_CD";
        private const string ARG_INSP_YMD = "ARG_INSP_YMD";
        private const string ARG_MATERIAL_CD = "ARG_MATERIAL_CD";



        #endregion

        public Form_Incoming_Tail()
        {
            InitializeComponent();
        }

        #region "Method"
        private void InitForm()
        {
            tbtn_Append.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Create.Enabled = false;
            btn_AddRow.Enabled = false;
            btn_Cancel.Enabled = false;
            tbtn_Confirm.Enabled = false;

            toolTip1.SetToolTip(btn_AddRow, "Add a Spection");
            toolTip1.SetToolTip(btn_Cancel, "Cancel Spection");

            this.Text = "Input for Inspection Tail";
            this.lbl_MainTitle.Text = this.Text;

            // factory set
            DataTable vDt = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            // 그리드 설정
            fgrid_Incoming.Set_Grid("SMI_INCOMING_LIST", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Incoming.Set_Action_Image(img_Action);
            fgrid_Incoming.KeyActionEnter = KeyActionEnum.MoveAcrossOut;

            fgrid_Incoming.Make_CmbDataList(COM.ComVar.ComboList_Type.Query, SEARCH_ALL_CUST(), Convert.ToInt32(GRID_ALIAS.CUST_CD));

            fgrid_Incoming.Cols[Convert.ToInt32(GRID_ALIAS.INCOMING_YMD)].Style.Format = "yyyy-MM-dd";

            fgrid_Incoming_detail.Set_Grid("SMI_INCOMING_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Incoming_detail.Set_Action_Image(img_Action);
            fgrid_Incoming_detail.KeyActionEnter = KeyActionEnum.MoveAcrossOut;
            fgrid_Incoming_detail.Make_CmbDataList(COM.ComVar.ComboList_Type.Query, GetDPOList(), Convert.ToInt32(GRID_ALIAS_D.IxOBS_ID));

            fgrid_Incoming_detail.Cols[Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_YMD)].Style.Format = "yyyy-MM-dd";
            fgrid_Incoming_detail.Cols[Convert.ToInt32(GRID_ALIAS_D.IxINSP_YMD)].Style.Format = "yyyy-MM-dd";

            fgrid_Incoming_detail.Cols[Convert.ToInt32(GRID_ALIAS_D.IxERROR_QTY1)].Style.Format = "###,###,##0.#";
            fgrid_Incoming_detail.Cols[Convert.ToInt32(GRID_ALIAS_D.IxERROR_QTY2)].Style.Format = "###,###,##0.#";
            fgrid_Incoming_detail.Cols[Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_QTY)].Style.Format = "###,###,##0.#";

            //LOCATION SET DATA

            vDt = SEARCH_SMI_CMN();
            COM.ComFunction.Set_ComboList(vDt, cmb_Location, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Location.SelectedIndex = 0;


            ClassLib.ComFunction.Init_Form_Control(this);
            ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
        }

        private DataTable GetDPOList()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_SBM_DP_DPO_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_DIVISION;
            MyOraDB.Parameter_Name[2] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = "2";
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
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

        private DataTable SEARCH_SMI_INCOMING()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.search_smi_incoming2";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_INCOMING_YMD;
            MyOraDB.Parameter_Name[2] = ARG_INCOMING_LOCATION;
            MyOraDB.Parameter_Name[3] = ARG_CUST_CD;
            MyOraDB.Parameter_Name[4] = "ARG_GOODSGROUP";
            MyOraDB.Parameter_Name[5] = "ARG_VIEWDATA";
            MyOraDB.Parameter_Name[6] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            MyOraDB.Parameter_Values[1] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_Cust, string.Empty);
            MyOraDB.Parameter_Values[4] = "";
            switch (chk_ViewAction.CheckState)
            {
                case CheckState.Checked:
                    MyOraDB.Parameter_Values[5] = "Y";
                    break;
                case CheckState.Indeterminate:
                    MyOraDB.Parameter_Values[5] = "";
                    break;
                case CheckState.Unchecked:
                    MyOraDB.Parameter_Values[5] = "N";
                    break;
                default:
                    MyOraDB.Parameter_Values[5] = "";
                    break;
            }
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        private void Display_FlexGrid(COM.FSP arg_FSP, DataTable arg_dt)
        {
            //arg_FSP.Redraw = false;
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
                if (arg_FSP.Name.Equals("fgrid_Incoming"))
                {
                    if (ClassLib.ComFunction.NullToBlank(arg_FSP[newRow.Row.Index, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y"))
                    {
                        arg_FSP.Rows[newRow.Row.Index].AllowEditing = false;
                    }
                    else
                    {
                        arg_FSP.Rows[newRow.Row.Index].AllowEditing = true;
                    }
                }
                else
                {
                    if (ClassLib.ComFunction.NullToBlank(arg_FSP[newRow.Row.Index, Convert.ToInt32(GRID_ALIAS_D.IxFIX_YN)]).Equals("Y"))
                    {
                        arg_FSP.Rows[newRow.Row.Index].AllowEditing = false;
                    }
                    else
                    {
                        arg_FSP.Rows[newRow.Row.Index].AllowEditing = true;
                    }
                }
            }
            if (iCount > 0)
            {
                btn_AddRow.Enabled = true;
                btn_Cancel.Enabled = true;
            }
            FormatGrid(arg_FSP);
            //arg_FSP.Redraw = false;
        }

        private void Clear_FlexGrid(COM.FSP arg_FSP)
        {
            if (arg_FSP.Rows.Fixed != arg_FSP.Rows.Count)
            {
                arg_FSP.Clear(ClearFlags.UserData, arg_FSP.Rows.Fixed, 1, arg_FSP.Rows.Count - 1, arg_FSP.Cols.Count - 1);

                arg_FSP.Rows.Count = arg_FSP.Rows.Fixed;
            }
        }

        private void FormatGrid(COM.FSP arg_FSP)
        {
            for (int i = arg_FSP.Rows.Fixed; i < arg_FSP.Rows.Count; i++)
            {
                if (arg_FSP.Name.Equals("fgrid_Incoming"))
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
                else
                {
                    if (ClassLib.ComFunction.NullToBlank(arg_FSP[i, Convert.ToInt32(GRID_ALIAS_D.IxFIX_YN)]).Equals("Y"))
                    {
                        CellStyle l_csTmp = arg_FSP.GetCellStyle(i, Convert.ToInt32(GRID_ALIAS_D.IxFIX_YN));
                        if (l_csTmp == null) l_csTmp = arg_FSP.Styles.Add("CONFIRM");
                        l_csTmp.BackColor = COM.ComVar.ClrFinishY;
                        for (int j = Convert.ToInt32(GRID_ALIAS_D.IxFACTORY); j < arg_FSP.Cols.Count; j++)
                        {
                            arg_FSP.SetCellStyle(i, j, l_csTmp);
                        }
                    }
                }
            }
        }

        private void AddNewRow()
        {
            COM.FSP l_Flex = fgrid_Incoming;
            if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed)
            {
                COM.ComFunction.User_Message("Pls select one 'Incoming Info'", "Error", MessageBoxButtons.OK);
                return;
            }
            if (
                //ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.FIX_TF)]).Equals("Y")
                 ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.REASON_QTY)]).Equals("")
                || ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.REASON_CD)]).Equals(""))
            {
                COM.ComFunction.User_Message("This record is no error, Pls select another one!", "Error", MessageBoxButtons.OK);
                return;
            }
            fgrid_Incoming.Enabled = false;

            COM.FSP l_Flexd = fgrid_Incoming_detail;
            l_Flexd.Add_Row(1);
            //them khoa chinh
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxFACTORY)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.FACTORY)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_SEQ)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_SEQ)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxCUST_CD)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.CUST_CD)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_LOCATION)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_LOCATION)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_YMD)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_YMD)];
            //them dieu kien default
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxWEEKLY_CD)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.WEEKLY_CD)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxREASON_CD1)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.REASON_CD)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxREASON_CD2)] = l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.REASON_CD)];
            l_Flexd[l_Flex.Rows.Fixed, Convert.ToInt32(GRID_ALIAS_D.IxINSP_YMD)] = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private DataTable SEARCH_SMI_INCOMING_TAIL(string arg_factory, string arg_incoming_date, string arg_location, string arg_cust, string arg_smi_incoming_seq)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.search_smi_incoming_tail";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_INCOMING_YMD;
            MyOraDB.Parameter_Name[2] = ARG_INCOMING_LOCATION;
            MyOraDB.Parameter_Name[3] = ARG_INCOMING_SEQ;
            MyOraDB.Parameter_Name[4] = ARG_CUST_CD;
            MyOraDB.Parameter_Name[5] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_incoming_date;
            MyOraDB.Parameter_Values[2] = arg_location;
            MyOraDB.Parameter_Values[3] = arg_smi_incoming_seq;
            MyOraDB.Parameter_Values[4] = arg_cust;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        public bool SAVE_SMI_INCOMING_TAIL()
        {
            try
            {
                int para_ct = 0;
                int iCount = 25;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "pkg_smi_mat_ins.save_smi_incoming_tail";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = ARG_DIVISION;
                MyOraDB.Parameter_Name[1] = ARG_FACTORY;
                MyOraDB.Parameter_Name[2] = ARG_INCOMING_YMD;
                MyOraDB.Parameter_Name[3] = ARG_INCOMING_LOCATION;
                MyOraDB.Parameter_Name[4] = ARG_INCOMING_SEQ;
                MyOraDB.Parameter_Name[5] = ARG_CUST_CD;
                MyOraDB.Parameter_Name[6] = ARG_INSP_SEQ;
                MyOraDB.Parameter_Name[7] = ARG_GROUP_CD;
                MyOraDB.Parameter_Name[8] = ARG_OBS_ID;
                MyOraDB.Parameter_Name[9] = ARG_LINE_CD;
                MyOraDB.Parameter_Name[10] = ARG_WEEKLY_CD;
                MyOraDB.Parameter_Name[11] = ARG_STYLE_CD;
                MyOraDB.Parameter_Name[12] = ARG_COLOR_CD;
                MyOraDB.Parameter_Name[13] = ARG_UNIT;
                MyOraDB.Parameter_Name[14] = ARG_INCOMING_QTY;
                MyOraDB.Parameter_Name[15] = ARG_ERROR_QTY1;
                MyOraDB.Parameter_Name[16] = ARG_REASON_CD1;
                MyOraDB.Parameter_Name[17] = ARG_ERROR_QTY2;
                MyOraDB.Parameter_Name[18] = ARG_REASON_CD2;
                MyOraDB.Parameter_Name[19] = ARG_FIX_YN;
                MyOraDB.Parameter_Name[20] = ARG_INCOMING_REMARK;
                MyOraDB.Parameter_Name[21] = ARG_CLASS_CD;
                MyOraDB.Parameter_Name[22] = ARG_INSP_YMD;
                MyOraDB.Parameter_Name[23] = ARG_MATERIAL_CD;
                MyOraDB.Parameter_Name[24] = ARG_UPD_USER;


                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[14] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[15] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.Number;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;


                COM.FSP l_Flex = fgrid_Incoming_detail;
                //MyOraDB.Parameter_Values = new string[iCount * (l_Flex.Rows.Count - l_Flex.Rows.Fixed)];
                ArrayList vModifyList = new ArrayList();

                for (int iRow = l_Flex.Rows.Fixed; iRow < l_Flex.Rows.Count; iRow++)
                {
                    if (!ClassLib.ComFunction.NullToBlank(l_Flex[iRow, 0]).Equals(""))
                    {
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxDIVISION)]));//division
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxFACTORY)]));//factory

                        DateTime l_DateTmp = DateTime.ParseExact(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_YMD)].ToString().Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);

                        vModifyList.Add(Convert.ToString(l_DateTmp.ToString("yyyyMMdd")));//incoming_ymd 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_LOCATION)]));//incoming_location
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_SEQ)]));//incoming_seq
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxCUST_CD)]));//cust_cd
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINSP_SEQ)]));//inspection seq 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxGROUP_CD)]));//material cat 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxOBS_ID)]));//dpo 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxLINE_CD)]));//line
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxWEEKLY_CD)]));//weekly cd
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxSTYLE_CD)]).Replace("-", ""));//style cd
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxCOLOR_CD)]));//color
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxUNIT)]));//unit
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_QTY)]));//incoming qty  
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxERROR_QTY1)]));//error qty 1
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxREASON_CD1)]));//reason cd 1
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxERROR_QTY2)]));//error qty 2
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxREASON_CD2)]));//reason cd 2
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxFIX_YN)]));//fix yn
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxREMARK)]));//remark
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxCLASS_CD)]));//class cd
                        l_DateTmp = DateTime.ParseExact(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINSP_YMD)].ToString().Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                        vModifyList.Add(Convert.ToString(l_DateTmp.ToString("yyyyMMdd")));//inspection ymd
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxMATERIAL_CD)]));//item cd
                        vModifyList.Add(COM.ComVar.This_User);//upd_user  
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
        public bool CONFIRM_SMI_INCOMING_TAIL(COM.FSP arg_fsp, string arg_Action)
        {
            try
            {
                int para_ct = 0;
                int iCount = 8;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "pkg_smi_mat_ins.comfirm_smi_incoming_tail";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = ARG_DIVISION;
                MyOraDB.Parameter_Name[1] = ARG_FACTORY;
                MyOraDB.Parameter_Name[2] = ARG_INCOMING_YMD;
                MyOraDB.Parameter_Name[3] = ARG_INCOMING_LOCATION;
                MyOraDB.Parameter_Name[4] = ARG_CUST_CD;
                MyOraDB.Parameter_Name[5] = ARG_INCOMING_SEQ;
                MyOraDB.Parameter_Name[6] = ARG_INSP_SEQ;
                MyOraDB.Parameter_Name[7] = ARG_UPD_USER;

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;


                COM.FSP l_Flex = arg_fsp;
                ArrayList vModifyList = new ArrayList();
                for (int i = 0; i < l_Flex.Selections.Length; i++)
                {
                    int iRow = l_Flex.Selections[i];
                    if (ClassLib.ComFunction.NullToBlank(l_Flex[iRow, 0]).Equals(""))
                    {
                        vModifyList.Add(arg_Action);
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxFACTORY)]));//factory
                        DateTime l_DateTmp = DateTime.ParseExact(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_YMD)].ToString().Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                        vModifyList.Add(Convert.ToString(l_DateTmp.ToString("yyyyMMdd")));//incoming_ymd 
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_LOCATION)]));//incoming_location
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxCUST_CD)]));//cust_cd
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINCOMING_SEQ)]));//incoming_seq
                        vModifyList.Add(Convert.ToString(l_Flex[iRow, Convert.ToInt32(GRID_ALIAS_D.IxINSP_SEQ)]));//inspec seq
                        vModifyList.Add(COM.ComVar.This_User);//upd_user  
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
        /// check on value before confirm action on control
        /// </summary>
        /// <param name="arg_fsp"></param>
        /// <param name="arg_RowConfirmIndex"></param>
        /// <returns></returns>
        private bool ValidateValueBeforeConfirm(COM.FSP arg_fsp)
        {
            int l_HasChanged = 0;
            for (int i = arg_fsp.Rows.Fixed; i < arg_fsp.Rows.Count; i++)
            {
                if (!ClassLib.ComFunction.NullToBlank(arg_fsp[i, 0]).Equals(""))
                {
                    l_HasChanged++;
                }
            }
            if (l_HasChanged > 0)
            {
                COM.ComFunction.User_Message("Pls 'Save Data' before 'Confirm'", "Error", MessageBoxButtons.OK);
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
        private bool ValidateValueBeforeCancelConfirm(COM.FSP arg_fsp)
        {
            int l_HasChanged = 0;
            for (int i = arg_fsp.Rows.Fixed; i < arg_fsp.Rows.Count; i++)
            {
                if (!ClassLib.ComFunction.NullToBlank(arg_fsp[i, 0]).Equals(""))
                {
                    l_HasChanged++;
                }
            }
            if (l_HasChanged > 0)
            {
                COM.ComFunction.User_Message("Pls 'Save Data' before 'Cancel Confirm'", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (COM.ComFunction.User_Message("Are you want to Cancel Confirm This Row", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        private void FilterCust_ByLoc()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                cmb_Cust.DataSource = null;
                DataTable dt = SEARCH_SCM_CUST();
                COM.ComFunction.Set_ComboList(dt, cmb_Cust, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "FilterCust_ByLoc", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public void Tbtn_Print_Click(int arg_ReportType, string arg_Para)
        {
            string mrd_Filename = string.Empty;
            switch (arg_ReportType)
            {
                case 1://Daily Inspection Report
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Daily_Inspection_Report");
                    break;
                case 2://Weekly Inspection Report
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Weekly_Inspection_Report");
                    break;
                case 3://Weekly Reject Case
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Weekly_Reject_Case_Report");
                    break;
                default:
                    break;
            }

            FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, arg_Para);

            report.Show();
        }

        #endregion

        #region "Event"

        private void Form_Incoming_Tail_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                AddNewRow();
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "btn_AddRow_Click");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            fgrid_Incoming_Click(fgrid_Incoming, EventArgs.Empty);
            fgrid_Incoming.Enabled = true;
        }

        private void txt_CustSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                FilterCust_ByLoc();
            }
        }

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Display_FlexGrid(fgrid_Incoming, SEARCH_SMI_INCOMING());
                fgrid_Incoming.Enabled = true;
                Clear_FlexGrid(fgrid_Incoming_detail);
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
                if (SAVE_SMI_INCOMING_TAIL())
                {
                    fgrid_Incoming_Click(fgrid_Incoming, EventArgs.Empty);
                    fgrid_Incoming.Enabled = true;
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

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                COM.FSP l_Flex = fgrid_Incoming_detail;
                if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed) return;
                if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxDIVISION)]).Equals("I"))
                {
                    l_Flex.RemoveItem(l_Flex.RowSel);
                }
                else if (ClassLib.ComFunction.NullToBlank(l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxDIVISION)]).Equals(""))
                {
                    l_Flex.Delete_Row(l_Flex.RowSel);
                }
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

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form_Material_Inspection_Report fReport = new Form_Material_Inspection_Report();
            if (fReport.ShowDialog() == DialogResult.OK)
            {
                if (fReport.Tag != null)
                {
                    ArrayList arr = (ArrayList)fReport.Tag;
                    Tbtn_Print_Click(Convert.ToInt32(arr[0].ToString()), arr[1].ToString());
                }
            }

        }

        private void fgrid_Incoming_detail_DoubleClick(object sender, EventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed) return;
            if (l_Flex.ColSel == Convert.ToInt32(GRID_ALIAS_D.IxSTYLE_CD) || l_Flex.ColSel == Convert.ToInt32(GRID_ALIAS_D.IxSTYLE_NAME))
            {
                int[] checks = new int[]{ Convert.ToInt32(GRID_ALIAS_D.IxSTYLE_CD),
                                          Convert.ToInt32(GRID_ALIAS_D.IxCOLOR_CD)};
                Pop_BC_Yield_Info l_Pop_BC_Yield_Info = new Pop_BC_Yield_Info(fgrid_Incoming_detail, checks);
                l_Pop_BC_Yield_Info.ShowDialog();
                if (ClassLib.ComVar.Parameter_PopUpTable.Rows.Count <= 0 || l_Pop_BC_Yield_Info.DialogResult != DialogResult.OK)
                {
                    l_Pop_BC_Yield_Info.Dispose();
                    return;
                }
                l_Pop_BC_Yield_Info.Dispose();
                if (ClassLib.ComVar.Parameter_PopUpTable.Rows.Count == 0) return;
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxCOLOR_CD)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["color_cd"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxCOLOR_NAME)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["color_nm"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxUNIT)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["unit"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxSTYLE_CD)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["style_cd"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxSTYLE_NAME)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["style_name"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxMATERIAL_CD)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["item_cd"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxMATERIAL_NAME)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["item_nm"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxGROUP_CD)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["group_cd"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxCLASS_CD)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["group_cd"];
                l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxCLASS_NAME)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["group_name2"];

                //l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS_D.IxCOLOR_CD)] = ClassLib.ComVar.Parameter_PopUpTable.Rows[0]["color_cd"];

            }
        }

        private void fgrid_Incoming_Click(object sender, EventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string l_factory = string.Format("{0}", l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.FACTORY)]);

                string l_incoming_date = string.Format("{0}", l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_YMD)]);
                DateTime l_DateTmp = DateTime.ParseExact(l_incoming_date.Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                l_incoming_date = l_DateTmp.ToString("yyyyMMdd");
                string l_location = string.Format("{0}", l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_LOCATION)]);
                string l_cust = string.Format("{0}", l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.CUST_CD)]);
                string l_incoming_seq = string.Format("{0}", l_Flex[l_Flex.RowSel, Convert.ToInt32(GRID_ALIAS.INCOMING_SEQ)]);

                Display_FlexGrid(fgrid_Incoming_detail, SEARCH_SMI_INCOMING_TAIL(l_factory, l_incoming_date, l_location, l_cust, l_incoming_seq));
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "fgrid_Incoming_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void fgrid_Incoming_detail_AfterEdit(object sender, RowColEventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            if (l_Flex.Rows.Count <= l_Flex.Rows.Fixed) return;
            l_Flex.Update_Row();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateValueBeforeConfirm(fgrid_Incoming_detail))
                {
                    if (CONFIRM_SMI_INCOMING_TAIL(fgrid_Incoming_detail, "CONFIRM"))
                    {
                        fgrid_Incoming_Click(fgrid_Incoming, EventArgs.Empty);
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
                if (ValidateValueBeforeConfirm(fgrid_Incoming))
                {
                    if (CONFIRM_SMI_INCOMING_TAIL(fgrid_Incoming_detail, "CANCEL"))
                    {
                        fgrid_Incoming_Click(fgrid_Incoming, EventArgs.Empty);
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


        private void cmb_Location_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterCust_ByLoc();
        }
        #endregion

        private void chk_ViewAction_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox l_CheckBox = (CheckBox)sender;
            switch (l_CheckBox.CheckState)
            {
                case CheckState.Checked:
                    l_CheckBox.Text = "Have Erorr";
                    tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
                    break;
                case CheckState.Indeterminate:
                    l_CheckBox.Text = "All";
                    tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
                    break;
                case CheckState.Unchecked:
                    l_CheckBox.Text = "No Erorr";
                    tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
                    break;
                default:
                    break;
            }

        }
    }
}