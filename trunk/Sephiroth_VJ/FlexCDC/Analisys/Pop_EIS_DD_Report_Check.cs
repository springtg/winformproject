using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Analisys
{
    public partial class Pop_EIS_DD_Report_Check : COM.APSWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private string season_from = "", season_to = "", factory = "", p_factory = "", category = "", model_id = "";
        #endregion

        #region 생성자
        public Pop_EIS_DD_Report_Check()
        {
            InitializeComponent();
        }
        public Pop_EIS_DD_Report_Check(string arg_season_from, string arg_season_to, string arg_factory, string arg_p_factory, string arg_category, string arg_model_id)
        {
            season_from = arg_season_from;
            season_to   = arg_season_to;
            factory     = arg_factory;
            p_factory   = arg_p_factory;
            category    = arg_category;
            model_id    = arg_model_id;

            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_EIS_DD_Report_Check_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Init_Form()
        {
            //Title
            this.Text = " Unchecked List";
            lbl_MainTitle.Text = " Unchecked List";

            tbtn_New.Enabled    = false;
            tbtn_Search.Enabled = false;
            tbtn_Save.Enabled   = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled  = false;
            tbtn_Insert.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Append.Enabled = false;

            Init_Grid();
            Display_Grid();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("EIS_DD_REPORT_POP", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;
        }

        private void Display_Grid()
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            DataTable dt_ret = SELECT_USERCHECK_LIST();

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();                    
                }
            }

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 7, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1).StyleNew.BackColor = Color.White;
        }

        private DataTable SELECT_USERCHECK_LIST()
        {
            try
            {
                string Proc_Name = "PKG_EDM_PCC_01.SELECT_USERCHECK_LIST_POP";

                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[3] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = season_from;
                MyOraDB.Parameter_Values[1] = season_to;
                MyOraDB.Parameter_Values[2] = factory;
                MyOraDB.Parameter_Values[3] = p_factory;
                MyOraDB.Parameter_Values[4] = category;
                MyOraDB.Parameter_Values[5] = model_id;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string mrd_Filename = Application.StartupPath + @"\Report\DD_Report_UserCheck.mrd";
            string sPara = " /rp " + "[" + season_from + "]" + " [" + season_to + "]" + " [" + factory + "]" + " [" + p_factory + "]" + " [" + category + "]" + " [" + model_id + "]";
            
            
            FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
            report.ShowDialog();

        }
        #endregion
    }
}

