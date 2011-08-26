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

namespace FlexVJ_Common.Material_Inspection
{
    public partial class Form_Material_Pass_Status_Year : COM.VJ_CommonWinForm.Form_Top
    {
        public Form_Material_Pass_Status_Year()
        {
            InitializeComponent();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //init chart
                chart1.ToolBar.RemoveAt(0);
                int _lenght = chart1.ToolBar.Length;
                for (int i = 3; i < _lenght; i++)
                {
                    chart1.ToolBar.RemoveAt(i);
                    _lenght = chart1.ToolBar.Length;
                }


                _memoryStream = new MemoryStream();
                chart1.Export(FileFormat.Binary, _memoryStream);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Form_Material_Pass_Status_Year");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #region "Variable"
        private COM.OraDB MyOraDB = new COM.OraDB();
        private MemoryStream _memoryStream;
        string l_StrFormatPercent = "###,###,##0.##%";
        string l_StrFormat = "###,###,##0.#";
        private bool _Have5Week = false;

        private const string ARG_FACTORY = "arg_factory";
        private const string ARG_GRP_CODE = "ARG_GRP_CODE";
        private const string OUT_CURSOR = "OUT_CURSOR";
        private const string ARG_INCOMING_YMD = "arg_incoming_ymd";
        private const string ARG_INCOMING_LOCATION = "arg_incoming_location";
        private const string ARG_KEYSEARCH = "ARG_KEYSEARCH";
        private const string ARG_CUST_CD = "arg_cust_cd";

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
            tbtn_Print.Enabled = false;

            DataTable vDt;
            //LOCATION SET DATA

            vDt = SEARCH_SMI_CMN();
            COM.ComFunction.Set_ComboList(vDt, cmb_Location, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Location.SelectedIndex = 0;

            ClassLib.ComFunction.Init_Form_Control(this);
            ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);


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
            if (arg_dt == null) return;
            arg_FSP.Rows.Count = arg_dt.Rows.Count + 3;
            if (arg_dt.Rows.Count < 1) return;

            int iCount = arg_dt.Rows.Count;

            int iColCount = arg_dt.Columns.Count;



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
        }

        private void ResetChart()
        {
            _memoryStream.Position = 0;
            chart1.Import(FileFormat.Binary, _memoryStream);
            chart1.Data.Clear();
            chart1.Cursor = Cursors.Default;
        }


        /// <summary>
        /// out put data to report
        /// </summary>
        public void Tbtn_Print_Click()
        {
            string mrd_Filename = string.Empty;

            mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Pass_Status");

            string Para = " ";

            int iCnt = 4;
            string[] aHead = new string[iCnt];
            aHead[0] = COM.ComVar.This_Factory;
            aHead[1] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            aHead[2] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            aHead[3] = "";

            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }

            FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);

            report.Show();
        }

        private DataTable GET_CHART_VALUE()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS_RPT.GET_CHART_VALUE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = ARG_FACTORY;
            MyOraDB.Parameter_Name[1] = ARG_INCOMING_LOCATION;
            MyOraDB.Parameter_Name[2] = ARG_CUST_CD;
            MyOraDB.Parameter_Name[3] = ARG_INCOMING_YMD;            
            MyOraDB.Parameter_Name[4] = OUT_CURSOR;

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Cust, string.Empty);
            MyOraDB.Parameter_Values[3] = dpk_Incomingdate.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[4] = "";

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
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = txt_CustSearchKey.Text;
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Location, string.Empty);
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private void FilterCust_by_Location()
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
                COM.ComFunction.User_Message(ex.Message, "FilterCust_by_Location", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region "Event"
        private void Form_Material_Pass_Status_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                InitForm();
                ResetChart();
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Form_Material_Pass_Status_Load");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ResetChart();
                chart1.DataSourceSettings.DataSource = GET_CHART_VALUE();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
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

        private void cmb_Location_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterCust_by_Location();
        }

        private void txt_CustSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                FilterCust_by_Location();
            }
        }
    }



}