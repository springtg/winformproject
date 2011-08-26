using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexVJ_Common.Material_Inspection
{
    public partial class Form_Material_Pass_Status : COM.VJ_CommonWinForm.Form_Top
    {
        public Form_Material_Pass_Status()
        {
            InitializeComponent();
        }
        #region "Variable"
        private COM.OraDB MyOraDB = new COM.OraDB();

        string l_StrFormatPercent = "###,###,##0.##%";
        string l_StrFormat = "###,###,##0.#";
        private bool _Have5Week = false;

        private const string ARG_FACTORY = "arg_factory";
        private const string ARG_GRP_CODE = "ARG_GRP_CODE";
        private const string OUT_CURSOR = "OUT_CURSOR";
        private const string ARG_INCOMING_YMD = "arg_incoming_ymd";
        private const string ARG_INCOMING_LOCATION = "arg_incoming_location";

        private CellStyle cs_Bottom = null;//99%
        private CellStyle cs_Top = null;//97%
        private CellStyle cs_Midle = null;//98%
        private CellStyle cs_Header1 = null;//format for header row 1
        private CellStyle cs_Header2 = null;//format for header row 2
        private CellStyle cs_Col1_2 = null;//format for col 1, col 2
        private CellStyle cs_RowEnd = null;// format for row total of end grid
        private CellStyle cs_RowEnd2 = null;// format for row total of end grid
        private CellStyle cs_Normal = null;//format for cell blank
        private CellStyle cs_NormalTotal = null;//format for cell total normal

        private double _Targ1 = 0;
        private double _Targ2 = 0;
        private double _Targ3 = 0;

        #endregion

        #region "Method"
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
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        /// <summary>
        /// kiem tra trong source
        /// </summary>
        /// <param name="arg_DataSource"></param>
        /// <returns></returns>
        private bool Have5Weekly()
        {
            DataTable l_dt = null;
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.check_have_5_weekly";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_INCOMING_YMD;
            MyOraDB.Parameter_Name[2] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return false;

            l_dt = vds_ret.Tables[MyOraDB.Process_Name];

            if (l_dt == null) return false;
            if (l_dt.Rows.Count <= 0) return false;

            if (l_dt.Rows[0][0].ToString().Equals("5"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Khoi tao cac control cua form
        /// </summary>
        private void InitForm()
        {
            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Save.Enabled = false;

            COM.FSP l_Flex = fgrid_MaterialPassStatus;
            if (cs_Bottom == null)//99%
            {
                cs_Bottom = l_Flex.Styles.Add("cs_Bottom");
                cs_Bottom.BackColor = Color.FromArgb(0, 255, 0);
                cs_Bottom.Format = l_StrFormatPercent;
                cs_Bottom.DataType = typeof(decimal);
            }
            if (cs_Top == null)//97%
            {
                cs_Top = l_Flex.Styles.Add("cs_Top");
                cs_Top.BackColor = Color.FromArgb(255, 0, 0);
                cs_Top.Format = l_StrFormatPercent;
                cs_Top.DataType = typeof(decimal);
            }
            if (cs_Midle == null)//98%
            {
                cs_Midle = l_Flex.Styles.Add("cs_Midle");
                cs_Midle.BackColor = Color.FromArgb(255, 255, 0);
                cs_Midle.Format = l_StrFormatPercent;
                cs_Midle.DataType = typeof(decimal);
            }
            if (cs_Header1 == null)//row header 1
            {
                cs_Header1 = l_Flex.Styles.Add("cs_Header1");
                cs_Header1.BackColor = Color.FromArgb(153, 204, 0);
                cs_Header1.DataType = typeof(string);
                cs_Header1.ForeColor = Color.Blue;
                cs_Header1.Font = new Font("Verdana", 9, FontStyle.Bold);
            }
            if (cs_Header2 == null)//row header 1
            {
                cs_Header2 = l_Flex.Styles.Add("cs_Header2");
                cs_Header2.BackColor = Color.FromArgb(153, 204, 0);
                cs_Header2.DataType = typeof(string);
                cs_Header2.ForeColor = Color.Blue;
                cs_Header2.Font = new Font("Verdana", 9, FontStyle.Bold);
            }
            if (cs_Col1_2 == null)//col 1, 2
            {
                cs_Col1_2 = l_Flex.Styles.Add("cs_Col1");
                cs_Col1_2.BackColor = Color.FromArgb(153, 204, 0);
                cs_Col1_2.DataType = typeof(string);
                cs_Col1_2.ForeColor = Color.Black;
                cs_Col1_2.Font = new Font("Verdana", 9, FontStyle.Bold);
                cs_Col1_2.WordWrap = true;
            }
            if (cs_RowEnd == null)//row total end of grid
            {
                cs_RowEnd = l_Flex.Styles.Add("cs_RowEnd");
                cs_RowEnd.BackColor = Color.FromArgb(51, 204, 204);
                cs_RowEnd.Format = l_StrFormat;
                cs_RowEnd.DataType = typeof(decimal);
            }
            if (cs_RowEnd2 == null)//row total end of grid
            {
                cs_RowEnd2 = l_Flex.Styles.Add("cs_RowEnd2");
                cs_RowEnd2.BackColor = Color.FromArgb(51, 204, 204);
                cs_RowEnd2.Format = l_StrFormat;
                cs_RowEnd2.ForeColor = Color.Red;
                cs_RowEnd2.DataType = typeof(decimal);
            }
            if (cs_Normal == null)//format normal cell for all week
            {
                cs_Normal = l_Flex.Styles.Add("cs_Normal");
                cs_Normal.BackColor = Color.FromArgb(255, 255, 255);
                cs_Normal.Format = l_StrFormat;
                cs_Normal.DataType = typeof(decimal);
            }
            if (cs_NormalTotal == null)//format normal cell for total
            {
                cs_NormalTotal = l_Flex.Styles.Add("cs_NormalTotal");
                cs_NormalTotal.BackColor = Color.FromArgb(192, 192, 192);
                cs_NormalTotal.Format = l_StrFormat;
                cs_NormalTotal.DataType = typeof(decimal);
            }
            if (rbt_PassPercent.Checked)
                InitGrid(MATERIAL_PASS_STATUS.PASS_PERCENT);
            if (rbt_PassTotal.Checked)
                InitGrid(MATERIAL_PASS_STATUS.PASS_TOTAL);

            DataTable vDt;
            //LOCATION SET DATA

            vDt = SEARCH_SMI_CMN();
            COM.ComFunction.Set_ComboList(vDt, cmb_Location, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Location.SelectedIndex = 0;

            ClassLib.ComFunction.Init_Form_Control(this);
            ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
        }

        /// <summary>
        /// Khoi tao grid control tuong ung voi dieu kien
        /// </summary>
        /// <param name="ARG_MATERIAL_PASS_STATUS"></param>
        private void InitGrid(MATERIAL_PASS_STATUS ARG_MATERIAL_PASS_STATUS)
        {
            int _ColMin = 0;
            int _colMax = 0;
            if (ARG_MATERIAL_PASS_STATUS == MATERIAL_PASS_STATUS.PASS_TOTAL)
            {
                if (_Have5Week)
                {
                    fgrid_MaterialPassStatus.Set_Grid("SMI_MATERIAL_PASS_STATUS_TOTAL", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    _ColMin = (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_1ST;
                    _colMax = (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_TOTAL;
                }
                else
                {
                    fgrid_MaterialPassStatus.Set_Grid("SMI_MATERIAL_PASS_STATUS_TOTAL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    _ColMin = (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxFAIL_QTY_1ST;
                    _colMax = (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_TOTAL;
                }
            }
            else
            {
                if (_Have5Week)
                {
                    fgrid_MaterialPassStatus.Set_Grid("SMI_MATERIAL_PASS_STATUS_PERCENT", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    _ColMin = (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_1ST;
                    _colMax = (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_TOTAL;
                }
                else
                {
                    fgrid_MaterialPassStatus.Set_Grid("SMI_MATERIAL_PASS_STATUS_PERCENT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    _ColMin = (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_1ST;
                    _colMax = (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_TOTAL;
                }
            }
            for (int i = _ColMin; i <= _colMax; i++)
            {
                fgrid_MaterialPassStatus.Cols[i].Style.Format = l_StrFormatPercent;
            }
            fgrid_MaterialPassStatus.Set_Action_Image(img_Action);
            fgrid_MaterialPassStatus.KeyActionEnter = KeyActionEnum.MoveAcrossOut;
        }

        /// <summary>
        /// clear data on grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        private void Clear_FlexGrid(ref COM.FSP arg_FSP)
        {
            if (arg_FSP.Rows.Fixed != arg_FSP.Rows.Count)
            {
                arg_FSP.Clear(ClearFlags.UserData, arg_FSP.Rows.Fixed, 1, arg_FSP.Rows.Count - 1, arg_FSP.Cols.Count - 1);

                arg_FSP.Rows.Count = arg_FSP.Rows.Fixed;
            }
        }

        /// <summary>
        /// Re init header title of grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        /// <param name="arg_dt"></param>
        /// <param name="arg_iColCount"></param>
        private void ReInitHeaderLabel(ref COM.FSP arg_FSP, DataTable arg_dt, ref int arg_iColCount)
        {
            if (rbt_PassTotal.Checked)
            {
                if (_Have5Week)
                {
                    arg_iColCount = arg_iColCount - 6;//cal col count
                    //set data for header
                    string l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_1ST"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxINC_QTY_1ST] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_QTY_1ST] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_1ST] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_1ST] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_2ND"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxINC_QTY_2ND] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_QTY_2ND] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_2ND] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_2ND] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_3RD"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxINC_QTY_3RD] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_QTY_3RD] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_3RD] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_3RD] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_4TH"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxINC_QTY_4TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_QTY_4TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_4TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_4TH] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_5TH"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxINC_QTY_5TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_QTY_5TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_5TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_5TH] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_TOTAL"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxINC_QTY_TOTAL] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_QTY_TOTAL] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxFAIL_QTY_TOTAL] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_TOTAL] = l_objTitle;
                }
                else
                {
                    arg_iColCount = arg_iColCount - 5;//cal col count
                    string l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_1ST"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxINC_QTY_1ST] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_QTY_1ST] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxFAIL_QTY_1ST] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_1ST] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_2ND"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxINC_QTY_2ND] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_QTY_2ND] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxFAIL_QTY_2ND] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_2ND] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_3RD"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxINC_QTY_3RD] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_QTY_3RD] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxFAIL_QTY_3RD] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_3RD] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_4TH"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxINC_QTY_4TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_QTY_4TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxFAIL_QTY_4TH] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_4TH] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_TOTAL"]);
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxINC_QTY_TOTAL] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_QTY_TOTAL] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxFAIL_QTY_TOTAL] = l_objTitle;
                    fgrid_MaterialPassStatus[1, (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_TOTAL] = l_objTitle;
                }
            }
            if (rbt_PassPercent.Checked)
            {
                if (_Have5Week)
                {
                    arg_iColCount = arg_iColCount - 6;//cal col count
                    string l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_1ST"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_1ST] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_2ND"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_2ND] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_3RD"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_3RD] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_4TH"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_4TH] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_5TH"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_5TH] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_TOTAL"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_TOTAL] = l_objTitle;
                }
                else
                {
                    arg_iColCount = arg_iColCount - 5;//cal col count
                    string l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_1ST"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_1ST] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_2ND"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_2ND] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_3RD"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_3RD] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_4TH"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_4TH] = l_objTitle;
                    l_objTitle = Convert.ToString(arg_dt.Rows[0]["WEEKLY_TOTAL"]);
                    fgrid_MaterialPassStatus[2, (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_TOTAL] = l_objTitle;
                }
            }
        }

        /// <summary>
        /// hien thi du lieu len grid
        /// show data to grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        /// <param name="arg_dt"></param>
        private void Display_FlexGrid(ref COM.FSP arg_FSP, DataTable arg_dt)
        {
            Clear_FlexGrid(ref arg_FSP);
            if (arg_dt == null) return;
            if (rbt_PassPercent.Checked)
                arg_FSP.Rows.Count = arg_dt.Rows.Count + 3;
            if (rbt_PassTotal.Checked)
                arg_FSP.Rows.Count = arg_dt.Rows.Count + 4;
            if (arg_dt.Rows.Count < 1) return;

            int iCount = arg_dt.Rows.Count;

            int iColCount = arg_dt.Columns.Count;

            ReInitHeaderLabel(ref arg_FSP, arg_dt, ref iColCount);

            int j = 3;
            for (int iRow = 0; iRow < iCount; iRow++)
            {
                arg_FSP[j, 0] = "";
                for (int iCol = 1; iCol <= iColCount; iCol++)
                {
                    arg_FSP[j, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
                j++;
            }


            if (rbt_PassTotal.Checked)
            {
                arg_FSP[arg_FSP.Rows.Count - 1, 1] = "Total";
                arg_FSP[arg_FSP.Rows.Count - 1, 2] = "Total";
                if (_Have5Week)
                {
                    for (int i = 3; i < arg_FSP.Cols.Count; i++)
                    {
                        if (i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_1ST)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_2ND)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_3RD)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_4TH)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_5TH)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_TOTAL))
                        {
                            double l_inco = 0;
                            double l_pass = 0;
                            try
                            {
                                l_inco = double.Parse(arg_FSP[arg_FSP.Rows.Count - 1, i - 3].ToString());
                            }
                            catch
                            {
                                l_inco = 0;
                            }
                            try
                            {
                                l_pass = double.Parse(arg_FSP[arg_FSP.Rows.Count - 1, i - 2].ToString());
                            }
                            catch
                            {
                                l_pass = 0;
                            }
                            try
                            {
                                if (l_inco == 0)
                                {
                                    arg_FSP[arg_FSP.Rows.Count - 1, i] = 0;
                                }
                                else
                                {
                                    arg_FSP[arg_FSP.Rows.Count - 1, i] = l_pass / l_inco;
                                }
                            }
                            catch
                            {
                                arg_FSP[arg_FSP.Rows.Count - 1, i] = 0;
                            }
                        }
                        else
                        {
                            arg_FSP[arg_FSP.Rows.Count - 1, i] = SumCol(arg_FSP, i);
                        }
                    }
                }
                else
                {
                    for (int i = 3; i < arg_FSP.Cols.Count; i++)
                    {
                        if (i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_1ST)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_2ND)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_3RD)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_4TH)
                            || i == Convert.ToInt32(SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_TOTAL))
                        {
                            double l_inco = 0;
                            double l_pass = 0;
                            try
                            {
                                l_inco = double.Parse(arg_FSP[arg_FSP.Rows.Count - 1, i - 3].ToString());
                            }
                            catch
                            {
                                l_inco = 0;
                            }
                            try
                            {
                                l_pass = double.Parse(arg_FSP[arg_FSP.Rows.Count - 1, i - 2].ToString());
                            }
                            catch
                            {
                                l_pass = 0;
                            }
                            try
                            {
                                if (l_inco == 0)
                                {
                                    arg_FSP[arg_FSP.Rows.Count - 1, i] = 0;
                                }
                                else
                                {
                                    if (Math.Round(l_pass / l_inco, 4).Equals(1))
                                    {
                                        arg_FSP[arg_FSP.Rows.Count - 1, i] = 1;// Math.Round(l_pass / l_inco, 4);
                                    }
                                    else
                                    {
                                        arg_FSP[arg_FSP.Rows.Count - 1, i] = Math.Round(l_pass / l_inco, 4);
                                    }
                                }
                            }
                            catch
                            {
                                arg_FSP[arg_FSP.Rows.Count - 1, i] = 0;
                            }
                        }
                        else
                        {
                            arg_FSP[arg_FSP.Rows.Count - 1, i] = SumCol(arg_FSP, i);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// tinh dong tong cho du lieu tren grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        /// <param name="arg_Col"></param>
        /// <returns></returns>
        private double SumCol(COM.FSP arg_FSP, int arg_Col)
        {
            double l_tmp = 0;
            for (int i = arg_FSP.Rows.Fixed; i < arg_FSP.Rows.Count; i++)
            {
                object tmp = arg_FSP[i, arg_Col];
                if (tmp != null)
                {
                    l_tmp += double.Parse(tmp.ToString());
                }
            }
            return l_tmp;
        }

        /// <summary>
        /// to mau cho cell ung voi target
        /// </summary>
        /// <param name="arg_Flex"></param>
        /// <param name="arg_row"></param>
        /// <param name="arg_col"></param>
        private void FillCellStyle(COM.FSP arg_Flex, int arg_row, int arg_col)
        {
            string l_tmp = string.Empty;
            l_tmp = ClassLib.ComFunction.NullToBlank(arg_Flex[arg_row, arg_col]);

            if (!l_tmp.Trim().Equals(string.Empty))
            {
                double l_decimal = double.Parse(l_tmp);
                if (l_decimal >= _Targ3)
                {
                    arg_Flex.SetCellStyle(arg_row, arg_col, cs_Bottom);
                }
                if (l_decimal > _Targ1 && l_decimal < _Targ3)
                {
                    arg_Flex.SetCellStyle(arg_row, arg_col, cs_Midle);
                }
                if (l_decimal <= _Targ1)
                {
                    arg_Flex.SetCellStyle(arg_row, arg_col, cs_Top);
                }
            }
        }

        /// <summary>
        /// format cell style forgir
        /// </summary>
        /// <param name="arg_Flex"></param>
        private void ReFormatGrid(ref COM.FSP arg_Flex)
        {
            try
            {
                for (int i = 1; i < arg_Flex.Rows.Count; i++)
                {
                    if (i == 1)
                    {
                        //format for header 1
                        for (int j = 1; j < arg_Flex.Cols.Count; j++)
                        {
                            arg_Flex.SetCellStyle(i, j, cs_Header1);
                        }
                    }
                    if (i == 2)
                    {
                        //format for header2
                        for (int j = 1; j < arg_Flex.Cols.Count; j++)
                        {
                            arg_Flex.SetCellStyle(i, j, cs_Header2);
                        }
                    }
                    if (i >= 3 && i < arg_Flex.Rows.Count)
                    {
                        //format for data row
                        for (int j = 1; j < arg_Flex.Cols.Count; j++)
                        {
                            if (rbt_PassTotal.Checked)//for pass total
                            {
                                if (_Have5Week)
                                {
                                    if (j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_1ST
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_2ND
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_3RD
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_4TH
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_5TH
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK.IxPASS_PERCENT_QTY_TOTAL)
                                    {
                                        FillCellStyle( arg_Flex, i, j);
                                    }
                                    else
                                        arg_Flex.SetCellStyle(i, j, cs_Normal);
                                }
                                else
                                {
                                    if (j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_1ST
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_2ND
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_3RD
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_4TH
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_TOTAL.IxPASS_PERCENT_QTY_TOTAL)
                                    {
                                        FillCellStyle( arg_Flex, i, j);
                                    }
                                    else
                                        arg_Flex.SetCellStyle(i, j, cs_Normal);
                                }
                            }
                            if (rbt_PassPercent.Checked)//for pass %
                            {
                                if (_Have5Week)
                                {
                                    if (j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_1ST
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_2ND
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_3RD
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_4TH
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_5TH
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK.IxPASS_PERCENT_QTY_TOTAL)
                                    {
                                        FillCellStyle( arg_Flex, i, j);
                                    }
                                    else
                                        arg_Flex.SetCellStyle(i, j, cs_Normal);
                                }
                                else
                                {
                                    if (j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_1ST
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_2ND
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_3RD
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_4TH
                                        || j == (int)SMI_MATERIAL_PASS_STATUS_PERCENT.IxPASS_PERCENT_QTY_TOTAL)
                                    {
                                        FillCellStyle( arg_Flex, i, j);
                                    }
                                    else
                                        arg_Flex.SetCellStyle(i, j, cs_Normal);
                                }
                            }

                        }
                    }
                    //format for row height
                    arg_Flex.Rows[i].Height = 28;
                    //format col 1, 2
                    arg_Flex.SetCellStyle(i, 1, cs_Col1_2);
                    arg_Flex.SetCellStyle(i, 2, cs_Col1_2);
                }
                arg_Flex.AllowMerging = AllowMergingEnum.Free;
                arg_Flex.Cols[1].AllowMerging = true;
                for (int i = 3; i < arg_Flex.Cols.Count; i++)
                {
                    arg_Flex.Cols[i].AllowMerging = false;
                }
                arg_Flex.Rows[arg_Flex.Rows.Count - 1].AllowMerging = true;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// out put data to report
        /// </summary>
        public void Tbtn_Print_Click()
        {
            string mrd_Filename = string.Empty;
            if (rbt_PassPercent.Checked == true)//report for Pass percent
            {
                if (_Have5Week)
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Pass_Status_Percent_5");
                else
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Pass_Status_Percent");
            }
            if (rbt_PassTotal.Checked == true)//report for Pass Total
            {
                if (_Have5Week)
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Pass_Status_5");
                else
                    mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Pass_Status");
            }
            if (rbt_StatusChart.Checked == true)//report for pass status chart
            {
                mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Pass_Status_Chart");
            }
            string Para = " ";

            int iCnt = 5;
            string[] aHead = new string[iCnt];

            aHead = new string[iCnt];
            aHead[0] = COM.ComVar.This_Factory;
            aHead[1] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            aHead[2] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            aHead[3] = cmb_Location.SelectedText;
            aHead[4] = "";


            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }

            FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);

            report.Show();
        }

        /// <summary>
        /// Load data from DB for MATERIAL_PASS_STATUS_TOTAL
        /// </summary>
        /// <returns></returns>
        private DataTable SEARCH_MATERIAL_PASS_STATUS(MATERIAL_PASS_STATUS arg_MATERIAL_PASS_STATUS)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            if (arg_MATERIAL_PASS_STATUS == MATERIAL_PASS_STATUS.PASS_TOTAL)
                MyOraDB.Process_Name = "PKG_SMI_MAT_INS_RPT.MATERIAL_PASS_STATUS_TOTAL";
            else
                MyOraDB.Process_Name = "PKG_SMI_MAT_INS_RPT.MATERIAL_PASS_STATUS_PERCENT";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_INCOMING_YMD;
            MyOraDB.Parameter_Name[2] = ARG_INCOMING_LOCATION;
            MyOraDB.Parameter_Name[3] = "ARG_INCOMING_LOC";
            MyOraDB.Parameter_Name[4] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[3] = cmb_Location.SelectedText;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        /// <summary>
        /// lay thong tin target
        /// </summary>
        private void getTargetMaterialPassStatus()
        {
            DataTable l_dt = null;
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS_RPT.GET_TARGET_VALUE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "ARG_YYYYMM";
            MyOraDB.Parameter_Name[2] = "ARG_TAR_DIV";
            MyOraDB.Parameter_Name[3] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = "003";
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return;

            l_dt = vds_ret.Tables[MyOraDB.Process_Name];

            if (l_dt == null) return;
            if (l_dt.Rows.Count <= 0) return;

            _Targ1 = Convert.ToDouble(l_dt.Rows[0][0]);
            _Targ2 = Convert.ToDouble(l_dt.Rows[0][1]);
            _Targ3 = Convert.ToDouble(l_dt.Rows[0][2]);
            
            label1.Text = string.Format("{0}%", _Targ3*100);
            label3.Text = string.Format("{0}%", _Targ1*100);
            label4.Text = string.Format("{0}%", _Targ2*100);
        }

        #endregion

        #region "Event"
        private void Form_Material_Pass_Status_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _Have5Week = Have5Weekly();
                InitForm();
                tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                COM.ComFunction.User_Message(ex.Message, "Form_Material_Pass_Status_Load");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void rbt_PassPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_PassPercent.Checked)
            {
                fgrid_MaterialPassStatus.Show();
                panel4.Controls.RemoveByKey("STATUSCHART");
                tbtn_Search.Click -= new C1.Win.C1Command.ClickEventHandler(Load_Chart_Status);
                tbtn_Search.Click -= new C1.Win.C1Command.ClickEventHandler(tbtn_Search_Click);
                tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(tbtn_Search_Click);
                tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
            }
        }

        private void rbt_PassTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_PassTotal.Checked)
            {
                fgrid_MaterialPassStatus.Show();
                panel4.Controls.RemoveByKey("STATUSCHART");
                tbtn_Search.Click -= new C1.Win.C1Command.ClickEventHandler(Load_Chart_Status);
                tbtn_Search.Click -= new C1.Win.C1Command.ClickEventHandler(tbtn_Search_Click);
                tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(tbtn_Search_Click);
                tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
            }
        }

        private void rbt_StatusChart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_StatusChart.Checked)
            {
                tbtn_Search.Click -= new C1.Win.C1Command.ClickEventHandler(tbtn_Search_Click);
                tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(Load_Chart_Status);
                fgrid_MaterialPassStatus.Hide();
                Load_Chart_Status(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);

            }
        }

        private void Load_Chart_Status(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            panel4.Controls.RemoveByKey("STATUSCHART");
            US_Material_Pass_Status_Chart _US = new US_Material_Pass_Status_Chart(COM.ComVar.This_Factory, COM.ComFunction.Empty_Combo(cmb_Location, string.Empty), cmb_Location.SelectedText, dpk_Incomingdate.Value.ToString("yyyyMMdd"), 0.99F);
            _US.Name = "STATUSCHART";
            _US.Dock = DockStyle.Fill;
            panel4.Controls.Add(_US);
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable l_dtTmp = null;

                if (rbt_PassPercent.Checked == true)
                {
                    //khoi tao grid
                    InitGrid(MATERIAL_PASS_STATUS.PASS_PERCENT);
                    //Search data
                    l_dtTmp = SEARCH_MATERIAL_PASS_STATUS(MATERIAL_PASS_STATUS.PASS_PERCENT);
                }
                if (rbt_PassTotal.Checked == true)
                {
                    //khoi tao grid
                    InitGrid(MATERIAL_PASS_STATUS.PASS_TOTAL);
                    //Search data
                    l_dtTmp = SEARCH_MATERIAL_PASS_STATUS(MATERIAL_PASS_STATUS.PASS_TOTAL);
                }

                Display_FlexGrid(ref fgrid_MaterialPassStatus, l_dtTmp);
                //fgrid_MaterialPassStatus.Rows.Count = fgrid_MaterialPassStatus.Rows.Count-1 ;
                //reformat grid - 1
                getTargetMaterialPassStatus();
                ReFormatGrid(ref fgrid_MaterialPassStatus);
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                COM.ComFunction.User_Message(ex.Message, "tbtn_Search_Click");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Tbtn_Print_Click();
        }

        #endregion


    }

    #region "IXTable"

    /// <summary>
    /// All Grid type to view on form
    /// </summary>
    public enum MATERIAL_PASS_STATUS
    {
        PASS_PERCENT = 0,
        PASS_TOTAL = 1
    }

    /// <summary>
    /// alias for SMI_MATERIAL_PASS_STATUS_TOTAL
    /// </summary>
    public enum SMI_MATERIAL_PASS_STATUS_TOTAL : int
    {
        IxDIVISION = 0,
        IxGROUP_NAME = 1,
        IxCUST_NAME = 2,
        IxINC_QTY_1ST = 3,
        IxPASS_QTY_1ST = 4,
        IxFAIL_QTY_1ST = 5,
        IxPASS_PERCENT_QTY_1ST = 6,
        IxINC_QTY_2ND = 7,
        IxPASS_QTY_2ND = 8,
        IxFAIL_QTY_2ND = 9,
        IxPASS_PERCENT_QTY_2ND = 10,
        IxINC_QTY_3RD = 11,
        IxPASS_QTY_3RD = 12,
        IxFAIL_QTY_3RD = 13,
        IxPASS_PERCENT_QTY_3RD = 14,
        IxINC_QTY_4TH = 15,
        IxPASS_QTY_4TH = 16,
        IxFAIL_QTY_4TH = 17,
        IxPASS_PERCENT_QTY_4TH = 18,
        IxINC_QTY_TOTAL = 19,
        IxPASS_QTY_TOTAL = 20,
        IxFAIL_QTY_TOTAL = 21,
        IxPASS_PERCENT_QTY_TOTAL = 22
    }

    /// <summary>
    /// alias for SMI_MATERIAL_PASS_STATUS_TOTAL WITH 5 WEEK
    /// </summary>
    public enum SMI_MATERIAL_PASS_STATUS_TOTAL_5WEEK : int
    {
        IxDIVISION = 0,
        IxGROUP_NAME = 1,
        IxCUST_NAME = 2,
        IxINC_QTY_1ST = 3,
        IxPASS_QTY_1ST = 4,
        IxFAIL_QTY_1ST = 5,
        IxPASS_PERCENT_QTY_1ST = 6,
        IxINC_QTY_2ND = 7,
        IxPASS_QTY_2ND = 8,
        IxFAIL_QTY_2ND = 9,
        IxPASS_PERCENT_QTY_2ND = 10,
        IxINC_QTY_3RD = 11,
        IxPASS_QTY_3RD = 12,
        IxFAIL_QTY_3RD = 13,
        IxPASS_PERCENT_QTY_3RD = 14,
        IxINC_QTY_4TH = 15,
        IxPASS_QTY_4TH = 16,
        IxFAIL_QTY_4TH = 17,
        IxPASS_PERCENT_QTY_4TH = 18,
        IxINC_QTY_5TH = 19,
        IxPASS_QTY_5TH = 20,
        IxFAIL_QTY_5TH = 21,
        IxPASS_PERCENT_QTY_5TH = 22,
        IxINC_QTY_TOTAL = 23,
        IxPASS_QTY_TOTAL = 24,
        IxFAIL_QTY_TOTAL = 25,
        IxPASS_PERCENT_QTY_TOTAL = 26
    }

    /// <summary>
    /// alias for SMI_MATERIAL_PASS_STATUS_PERCENT
    /// </summary>
    public enum SMI_MATERIAL_PASS_STATUS_PERCENT : int
    {
        IxDIVISION = 0,
        IxGROUP_NAME = 1,
        IxCUST_NAME = 2,
        IxPASS_PERCENT_QTY_1ST = 3,
        IxPASS_PERCENT_QTY_2ND = 4,
        IxPASS_PERCENT_QTY_3RD = 5,
        IxPASS_PERCENT_QTY_4TH = 6,
        IxPASS_PERCENT_QTY_TOTAL = 7
    }

    /// <summary>
    /// alias for SMI_MATERIAL_PASS_STATUS_PERCENT WITH 5 WEEK
    /// </summary>
    public enum SMI_MATERIAL_PASS_STATUS_PERCENT_5WEEK : int
    {
        IxDIVISION = 0,
        IxGROUP_NAME = 1,
        IxCUST_NAME = 2,
        IxPASS_PERCENT_QTY_1ST = 3,
        IxPASS_PERCENT_QTY_2ND = 4,
        IxPASS_PERCENT_QTY_3RD = 5,
        IxPASS_PERCENT_QTY_4TH = 6,
        IxPASS_PERCENT_QTY_5TH = 7,
        IxPASS_PERCENT_QTY_TOTAL = 8
    }

    #endregion


}