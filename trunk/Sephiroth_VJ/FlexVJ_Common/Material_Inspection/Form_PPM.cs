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
using ChartFX.WinForms;
using ChartFX.WinForms.DataProviders;

namespace FlexVJ_Common.Material_Inspection
{
    /// <summary>
    /// alias for grid
    /// </summary>
    public enum GRID_ALIAS_SMI_PPM : int
    {
        IxDIVISION = 0,
        IxSUB_CODE = 1,
        IxDESCRIPTION = 2,
        IxINCOMING_1ST = 3,
        IxPASS_1ST = 4,
        IxFAIL_1ST = 5,
        IxPPM_1ST = 6,
        IxINCOMING_2ND = 7,
        IxPASS_2ND = 8,
        IxFAIL_2ND = 9,
        IxPPM_2ND = 10,
        IxINCOMING_3RD = 11,
        IxPASS_3RD = 12,
        IxFAIL_3RD = 13,
        IxPPM_3RD = 14,
        IxINCOMING_4TH = 15,
        IxPASS_4TH = 16,
        IxFAIL_4TH = 17,
        IxPPM_4TH = 18,
        IxINCOMING_5TH = 19,
        IxPASS_5TH = 20,
        IxFAIL_5TH = 21,
        IxPPM_5TH = 22,
        IxINCOMING_TOTAL = 23,
        IxPASS_TOTAL = 24,
        IxFAIL_TOTAL = 25,
        IxPPM_TOTAL = 26,
        IxL_MONYY = 27
    }



    public partial class Form_PPM : COM.VJ_CommonWinForm.Form_Top
    {
        public Form_PPM()
        {
            InitializeComponent();
        }

        #region "Variable"
        private MemoryStream _memoryStream;
        private cPPM[] lstPPM = null;
        private DataTable l_DataChart = null;
        string l_StrFormat = "###,###,##0.#";
        private COM.OraDB MyOraDB = new COM.OraDB();
        private CellStyle cs_Bottom = null;//<3000
        private CellStyle cs_Top = null;//>3000~4000
        private CellStyle cs_Midle = null;//>4000
        private CellStyle cs_Header1 = null;//format for header row 1
        private CellStyle cs_Header2 = null;//format for header row 2
        private CellStyle cs_Col1 = null;//format for col 1
        private CellStyle cs_RowEnd1 = null;// format for row end
        private CellStyle cs_Normal = null;//format for cell blank

        #endregion

        #region "Method"
        private decimal ToDecimal(object arg_Value)
        {
            decimal dfvalue = 0;
            if (arg_Value == null) return dfvalue;
            if (arg_Value.Equals(DBNull.Value)) return dfvalue;
            if (arg_Value.Equals(string.Empty)) return dfvalue;
            if (COM.ComFunction.Check_Decimal(arg_Value.ToString()))
            {
                return decimal.Parse(arg_Value.ToString());
            }
            return dfvalue;
        }
        /// <summary>
        /// Khoi tao cac doi tuong cho form
        /// </summary>
        private void InitGrid()
        {
            bool have5weekly = Have5Weekly();
            // init gird
            if (have5weekly)
                fgrid_PPM.Set_Grid("SMI_PPM", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            else
                fgrid_PPM.Set_Grid("SMI_PPM", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_PPM.Set_Action_Image(img_Action);
            fgrid_PPM.KeyActionEnter = KeyActionEnum.MoveAcrossOut;

            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_1ST)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_1ST)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_1ST)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_1ST)].Style.Format = l_StrFormat;

            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_2ND)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_2ND)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_2ND)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_2ND)].Style.Format = l_StrFormat;

            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_3RD)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_3RD)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_3RD)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_3RD)].Style.Format = l_StrFormat;

            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_4TH)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_4TH)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_4TH)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_4TH)].Style.Format = l_StrFormat;


            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_5TH)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_5TH)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_5TH)].Style.Format = l_StrFormat;
            fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_5TH)].Style.Format = l_StrFormat;
            if (have5weekly)
            {

                fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_TOTAL)].Style.Format = l_StrFormat;
                fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_TOTAL)].Style.Format = l_StrFormat;
                fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_TOTAL)].Style.Format = l_StrFormat;
                fgrid_PPM.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_TOTAL)].Style.Format = l_StrFormat;
            }

            if (cs_Bottom == null)//<3000
            {
                cs_Bottom = fgrid_PPM.Styles.Add("cs_Bottom");
                cs_Bottom.BackColor = Color.FromArgb(0, 255, 0);
                cs_Bottom.Format = l_StrFormat;
                cs_Bottom.DataType = typeof(decimal);
            }
            if (cs_Top == null)//>3000~4000
            {
                cs_Top = fgrid_PPM.Styles.Add("cs_Top");
                cs_Top.BackColor = Color.FromArgb(255, 0, 0);
                cs_Top.Format = l_StrFormat;
                cs_Top.DataType = typeof(decimal);
            }
            if (cs_Midle == null)//>4000
            {
                cs_Midle = fgrid_PPM.Styles.Add("cs_Midle");
                cs_Midle.BackColor = Color.FromArgb(255, 255, 0);
                cs_Midle.Format = l_StrFormat;
                cs_Midle.DataType = typeof(decimal);
            }
            if (cs_Header1 == null)
            {
                cs_Header1 = fgrid_PPM.Styles.Add("cs_Header1");
                cs_Header1.BackColor = Color.FromArgb(153, 204, 255);
                cs_Header1.DataType = typeof(string);
                cs_Header1.ForeColor = Color.Blue;
                cs_Header1.Font = new Font("Verdana", 9, FontStyle.Bold);
            }
            if (cs_Header2 == null)
            {
                cs_Header2 = fgrid_PPM.Styles.Add("cs_Header2");
                cs_Header2.BackColor = Color.FromArgb(192, 192, 192);
                cs_Header2.DataType = typeof(string);
                cs_Header2.ForeColor = Color.Blue;
                cs_Header2.Font = new Font("Verdana", 9, FontStyle.Bold);
            }
            if (cs_Col1 == null)
            {
                cs_Col1 = fgrid_PPM.Styles.Add("cs_Col1");
                cs_Col1.BackColor = Color.FromArgb(51, 204, 204);
                cs_Col1.DataType = typeof(string);
                cs_Col1.ForeColor = Color.Blue;
                cs_Col1.Font = new Font("Verdana", 9, FontStyle.Bold);
                cs_Col1.WordWrap = true;
            }
            if (cs_RowEnd1 == null)
            {
                cs_RowEnd1 = fgrid_PPM.Styles.Add("cs_RowEnd1");
                cs_RowEnd1.BackColor = Color.FromArgb(153, 204, 255);
                cs_RowEnd1.Format = l_StrFormat;
                cs_RowEnd1.DataType = typeof(decimal);
            }
            if (cs_Normal == null)
            {
                cs_Normal = fgrid_PPM.Styles.Add("cs_Normal");
                cs_Normal.BackColor = Color.FromArgb(255, 255, 255);
                cs_Normal.Format = l_StrFormat;
                cs_Normal.DataType = typeof(decimal);
            }
            ReFormatGrid(ref fgrid_PPM);


        }
        private void InitForm()
        {
            //init chart
            ResetChart();
            //init toolbar control
            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Save.Enabled = false;

            InitGrid();

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
        /// hien thi du lieu len grid
        /// show data to grid
        /// </summary>
        /// <param name="arg_FSP"></param>
        /// <param name="arg_dt"></param>
        private void Display_FlexGrid(ref COM.FSP arg_FSP, DataTable arg_dt)
        {
            Clear_FlexGrid(ref arg_FSP);
            arg_FSP.Rows.Count = 7;
            bool l_Have5Weekly = Have5Weekly();
            int iCount = arg_dt.Rows.Count;
            int iColCount = arg_dt.Columns.Count;
            if (l_Have5Weekly)
                iColCount = iColCount - 6;
            else
                iColCount = iColCount - 5;
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
            if (l_Have5Weekly)
            {
                //Active5Weekly(arg_FSP, true);
                l_DataChart = new DataTable();
                lstPPM = new cPPM[6];
                lstPPM[0] = new cPPM("1st",
                   ToDecimal(arg_dt.Rows[0]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_1st"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_1st"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_1st"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_1st"]));

                lstPPM[1] = new cPPM("2nd",
                    ToDecimal(arg_dt.Rows[0]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_2nd"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_2nd"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_2nd"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_2nd"]));

                lstPPM[2] = new cPPM("3rd",
                    ToDecimal(arg_dt.Rows[0]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_3rd"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_3rd"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_3rd"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_3rd"]));

                lstPPM[3] = new cPPM("4th",
                    ToDecimal(arg_dt.Rows[0]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_4th"]),
                    ToDecimal(arg_dt.Rows[0]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_4th"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_4th"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_4th"]));

                lstPPM[4] = new cPPM("5th",
                    ToDecimal(arg_dt.Rows[0]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_5th"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_5th"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_5th"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_5th"]));

                lstPPM[5] = new cPPM("Total",
                    ToDecimal(arg_dt.Rows[0]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_monthly"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_monthly"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_monthly"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_5th"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_monthly"]));

            }
            else
            {
                //Active5Weekly(arg_FSP, false);               

                lstPPM = new cPPM[5];
                lstPPM[0] = new cPPM("1st",
                   ToDecimal(arg_dt.Rows[0]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_1st"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_1st"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_1st"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_1st"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_1st"]));

                lstPPM[1] = new cPPM("2nd",
                    ToDecimal(arg_dt.Rows[0]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_2nd"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_2nd"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_2nd"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_2nd"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_2nd"]));

                lstPPM[2] = new cPPM("3rd",
                    ToDecimal(arg_dt.Rows[0]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_3rd"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_3rd"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_3rd"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_3rd"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_3rd"]));

                lstPPM[3] = new cPPM("4th",
                    ToDecimal(arg_dt.Rows[0]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_4th"]),
                    ToDecimal(arg_dt.Rows[0]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_4th"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_4th"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_4th"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_4th"]));

                lstPPM[4] = new cPPM("Total",
                    ToDecimal(arg_dt.Rows[0]["ppm_monthly"]),
                    string.Format("{0},{1}", arg_dt.Rows[0]["sub_name"], arg_dt.Rows[0]["ppm_monthly"]),
                    ToDecimal(arg_dt.Rows[1]["ppm_monthly"]),
                    string.Format("{0},{1}", arg_dt.Rows[1]["sub_name"], arg_dt.Rows[1]["ppm_monthly"]),
                    ToDecimal(arg_dt.Rows[2]["ppm_monthly"]),
                    string.Format("{0},{1}", arg_dt.Rows[2]["sub_name"], arg_dt.Rows[2]["ppm_monthly"]),
                    ToDecimal(arg_dt.Rows[3]["ppm_monthly"]),
                    string.Format("{0},{1}", arg_dt.Rows[3]["sub_name"], arg_dt.Rows[3]["ppm_monthly"]));
            }

        }

        /// <summary>
        /// format cell style forgir
        /// </summary>
        /// <param name="arg_Flex"></param>
        private void ReFormatGrid(ref COM.FSP arg_Flex)
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
                if (i == 3 || i == 4 || i == 5 || i == 6)
                {
                    //format for data row
                    for (int j = 1; j < arg_Flex.Cols.Count; j++)
                    {
                        string l_tmp = string.Empty;
                        l_tmp = ClassLib.ComFunction.NullToBlank(arg_Flex[i, j]);
                        switch (j)
                        {
                            case (int)GRID_ALIAS_SMI_PPM.IxPPM_1ST:
                                if (!l_tmp.Trim().Equals(string.Empty))
                                {
                                    decimal l_decimal = decimal.Parse(l_tmp);
                                    if (l_decimal < 3000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Bottom);
                                    }
                                    if (l_decimal >= 3000 && l_decimal <= 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Midle);
                                    }
                                    if (l_decimal > 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Top);
                                    }
                                }
                                break;
                            case (int)GRID_ALIAS_SMI_PPM.IxPPM_2ND:
                                if (!l_tmp.Trim().Equals(string.Empty))
                                {
                                    decimal l_decimal = decimal.Parse(l_tmp);
                                    if (l_decimal < 3000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Bottom);
                                    }
                                    if (l_decimal >= 3000 && l_decimal <= 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Midle);
                                    }
                                    if (l_decimal > 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Top);
                                    }
                                }
                                break;
                            case (int)GRID_ALIAS_SMI_PPM.IxPPM_3RD:
                                if (!l_tmp.Trim().Equals(string.Empty))
                                {
                                    decimal l_decimal = decimal.Parse(l_tmp);
                                    if (l_decimal < 3000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Bottom);
                                    }
                                    if (l_decimal >= 3000 && l_decimal <= 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Midle);
                                    }
                                    if (l_decimal > 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Top);
                                    }
                                }
                                break;
                            case (int)GRID_ALIAS_SMI_PPM.IxPPM_4TH:
                                if (!l_tmp.Trim().Equals(string.Empty))
                                {
                                    decimal l_decimal = decimal.Parse(l_tmp);
                                    if (l_decimal < 3000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Bottom);
                                    }
                                    if (l_decimal >= 3000 && l_decimal <= 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Midle);
                                    }
                                    if (l_decimal > 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Top);
                                    }
                                }
                                break;
                            case (int)GRID_ALIAS_SMI_PPM.IxPPM_5TH:
                                if (!l_tmp.Trim().Equals(string.Empty))
                                {
                                    decimal l_decimal = decimal.Parse(l_tmp);
                                    if (l_decimal < 3000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Bottom);
                                    }
                                    if (l_decimal >= 3000 && l_decimal <= 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Midle);
                                    }
                                    if (l_decimal > 4000)
                                    {
                                        arg_Flex.SetCellStyle(i, j, cs_Top);
                                    }
                                }
                                break;
                            default:
                                if (i == 6)//for mat for row end
                                    arg_Flex.SetCellStyle(i, j, cs_RowEnd1);
                                else
                                    arg_Flex.SetCellStyle(i, j, cs_Normal);
                                break;
                        }
                    }
                }
                //format for row height
                arg_Flex.Rows[i].Height = 38;
                arg_Flex.SetCellStyle(i, Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxDESCRIPTION), cs_Col1);
            }
            fgrid_PPM.Rows.Count = 7;
        }

        private void Active5Weekly(COM.FSP arg_Flex, bool arg_Enable)
        {
            arg_Flex.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxINCOMING_5TH)].Visible = arg_Enable;
            arg_Flex.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPASS_5TH)].Visible = arg_Enable;
            arg_Flex.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxFAIL_5TH)].Visible = arg_Enable;
            arg_Flex.Cols[Convert.ToInt32(GRID_ALIAS_SMI_PPM.IxPPM_5TH)].Visible = arg_Enable;
        }

        /// <summary>
        /// lay du lieu PPM tu database
        /// </summary>
        /// <returns></returns>
        private DataTable GET_PPM_BY_PK()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.PR_GET_PPM_BY_PK2";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_incoming_ymd";
            MyOraDB.Parameter_Name[2] = "out_cursor";

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
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_incoming_ymd";
            MyOraDB.Parameter_Name[2] = "out_cursor";

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

        private void ResetChart()
        {
            _memoryStream.Position = 0;
            chr_PPM.Import(FileFormat.Binary, _memoryStream);
            chr_PPM.Data.Clear();
            chr_PPM.Gallery = Gallery.Bar;
            chr_PPM.Cursor = Cursors.Default;
        }

        private void DrawChart(DataTable arg_DataSource)
        {
            ResetChart();
            ListProvider lstProvider = new ListProvider(lstPPM);
            chr_PPM.DataSourceSettings.DataSource = lstProvider;

            CustomGridLine custom1 = new CustomGridLine();
            custom1.Value = 3000;
            custom1.Color = Color.DarkBlue;
            custom1.Text = "Target 3000 ppm";
            custom1.Width = 2;
            chr_PPM.AxisY.CustomGridLines.Add(custom1);



        }

        public void Tbtn_Print_Click()
        {
            string mrd_Filename = string.Empty;
            if (Have5Weekly())
                mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Incoming_Inspection_PPM_5");
            else
                mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Incoming_Inspection_PPM");
            string Para = " ";

            int iCnt = 3;
            string[] aHead = new string[iCnt];
            aHead[0] = COM.ComVar.This_Factory;
            aHead[1] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            aHead[2] = "";

            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }

            FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);

            report.Show();
        }

        #endregion

        #region "Event"

        private void Form_PPM_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _memoryStream = new MemoryStream();
                chr_PPM.Export(FileFormat.Binary, _memoryStream);
                InitForm();

                tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Form_PPM_Load", MessageBoxButtons.OK);
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

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Tbtn_Print_Click();
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                InitGrid();
                DataTable l_dtTmp = GET_PPM_BY_PK();
                Display_FlexGrid(ref fgrid_PPM, l_dtTmp);
                ReFormatGrid(ref fgrid_PPM);
                DrawChart(l_DataChart);
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

        #endregion


    }

    public class cPPM
    {
        public cPPM(string arg_weekly, decimal arg_sSHVale, string arg_sHSLable,
            decimal arg_localValue, string arg_localLable,
            decimal arg_importValue, string arg_importLable,
            decimal arg_totalValue, string arg_totalLabel)
        {
            weekly = arg_weekly;
            sSHVale = arg_sSHVale;
            sHSLable = arg_sHSLable;
            localValue = arg_localValue;
            localLable = arg_localLable;
            importValue = arg_importValue;
            importLable = arg_importLable;
            totalValue = arg_totalValue;
            totalLable = arg_totalLabel;

        }
        private string weekly;

        public string Weekly
        {
            get { return weekly; }
            set { weekly = value; }
        }

        private decimal sSHVale;

        public decimal SHC
        {
            get { return sSHVale; }
            set { sSHVale = value; }
        }
        private string sHSLable;

        public string SHSLable
        {
            get { return sHSLable; }
            set { sHSLable = value; }
        }
        private decimal localValue;

        public decimal Local
        {
            get { return localValue; }
            set { localValue = value; }
        }
        private string localLable;

        public string LocalLable
        {
            get { return localLable; }
            set { localLable = value; }
        }

        private decimal importValue;

        public decimal Import
        {
            get { return importValue; }
            set { importValue = value; }
        }
        private string importLable;

        public string ImportLable
        {
            get { return importLable; }
            set { importLable = value; }
        }

        private decimal totalValue;

        public decimal Total
        {
            get { return totalValue; }
            set { totalValue = value; }
        }

        private string totalLable;

        public string TotalLable
        {
            get { return totalLable; }
            set { totalLable = value; }
        }
    }
}