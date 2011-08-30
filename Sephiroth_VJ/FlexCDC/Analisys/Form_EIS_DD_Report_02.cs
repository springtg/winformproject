using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using ChartFX.WinForms;

namespace FlexCDC.Analisys
{
    public partial class Form_EIS_DD_Report_02 : COM.APSWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private string _form_type = "N"; // "N"은 보통 상태, "Y"는 DD Report by Season에서 띄운 상태
        private string _season = "";
        private string _td_code = "";
        #endregion

        #region 생성자
        public Form_EIS_DD_Report_02()
        {
            InitializeComponent();
        }
        public Form_EIS_DD_Report_02(string arg_season, string arg_td_code)
        {
            InitializeComponent();

            _form_type = "Y";
            _season = arg_season;
            _td_code = arg_td_code;
        }
        #endregion

        #region Form Loading
        private void Form_EIS_DD_Report_02_Load(object sender, EventArgs e)
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
            this.Text = " DD Report by Season Simulation ";
            lbl_MainTitle.Text = " DD Report by Season Simulation ";
            lbl_title.Text = "       Search Condition ";

            Init_Grid();
            Init_Control();
            Init_Toolbar();

            tbtn_Search_Click(null, null);           
        }
        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EIS_DD_REPORT_02", "1", 3, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            //fgrid_Main.AllowMerging = AllowMergingEnum.Free;
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_DD_REPORT_MODEL.IxITEM_01;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_MODEL.IxC01B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_MODEL.IxC02M).StyleNew.BackColor = Color.LightPink;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_MODEL.IxC01B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_MODEL.IxC02M).StyleNew.ForeColor = Color.Black;
                        
        }
        private void Init_Control()
        {
            // Combobox Add Items
            DataTable dt_ret = SELECT_SEASON();

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_from.SelectedValue = _season;
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_to.SelectedValue = _season;           

        }
        private void Init_Toolbar()
        {
            // Disabled tbutton
            tbtn_Print.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
        }

        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "DS";
                MyOraDB.Parameter_Values[1] = "";

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

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string arg_season_from = cmb_Season_from.SelectedValue.ToString();
                string arg_season_to   = cmb_Season_to.SelectedValue.ToString();
                string arg_td_code     = _td_code;

                DataTable dt_ret = SELECT_DD_LIST(arg_season_from, arg_season_to, arg_td_code);

                Display_Grid(dt_ret);

                Radio_Button_Check(null, null);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }

        }
        private DataTable SELECT_DD_LIST(string arg_season_from, string arg_season_to, string arg_td_code)
        {
            try
            {
                string Proc_Name = "PKG_EDM_PCC_01.SELECT_DD_LIST_MODEL";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "ARG_TD_CODE";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_season_from;
                MyOraDB.Parameter_Values[1] = arg_season_to;
                MyOraDB.Parameter_Values[2] = arg_td_code;
                MyOraDB.Parameter_Values[3] = "";

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

        private void Display_Grid(DataTable arg_dt)
        {
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                int lev = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_DD_REPORT_MODEL.IxLEV].ToString());
                fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, lev);
                
                for (int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
                {
                    if (arg_dt.Rows[i].ItemArray[j].ToString().Equals("0"))
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j] = " ";
                    else
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                if(lev.Equals(1))
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(239, 231, 241);
                else
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(255, 242, 238);
            }            
        }
        #endregion

        #region Radio Button
        private void Radio_Button_Check(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------
            //Radio Button 검색 조건
            //------------------------------------------------------------------------------------
            if (rad_sesn_fact.Checked)
            {
                fgrid_Main.Tree.Show(1);
            }
            else if (rad_model.Checked)
            {
                fgrid_Main.Tree.Show(2);
            }            
        }
        #endregion
                
    }
}


