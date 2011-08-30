using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexCosting.Basic.Frm
{
    public partial class Form_Bottom_Componend_Cost : COM.PCHWinForm.Form_Top
    {
        public Form_Bottom_Componend_Cost()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의

        ToolTip _tp = new ToolTip();

        private COM.OraDB MyOraDB = new COM.OraDB();
        private DataTable _DTFactory = null, _DTSeason = null, _DTStandColor = null;
        private object[] _cellData = new object[3];
        private string _firstStatus = " ";

        #endregion

        #region 이벤트 핸들러

        #region 툴바 이벤트

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                ClearAll();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //ClearAll();
                Search();

                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSearch, this);
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

                if (Save())
                {
                    //ClearAll();
                    fgrid_main.Refresh_Division();
                    Search();
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
                }
                else
                {
                    COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        #endregion

        #region 그리드 이벤트

        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                GridAfterEdit(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "GridAfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_main_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                if (e.Col > (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxREMARKS)
                {
                    object oCellData = fgrid_main.GetCellRange(e.Row, e.Col).UserData;
                    if (oCellData == null)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        CellUserData cellData = (CellUserData)oCellData;
                        if (!cellData.Season.Equals(cmb_season.SelectedValue.ToString()))
                            e.Cancel = true;
                    }
                }
                else
                {
                    GridBeforeEdit();
                }
            }
            catch(Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "GridBeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_main_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CellRange cell = fgrid_main.GetCellRange(fgrid_main.Row, fgrid_main.Col);
                if (cell.UserData != null)
                {
                    CellUserData oaCellData = (CellUserData)cell.UserData;
                    Pop.Pop_Bottom_Formula vPop = new Pop.Pop_Bottom_Formula();

                    vPop.PROD_FAC = fgrid_main[fgrid_main.Row, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxFACTORY].ToString();
                    vPop.MCS_NO = fgrid_main[fgrid_main.Row, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxMCS_NO].ToString();
                    vPop.COLOR_CD = oaCellData.ColorCd;
                    vPop.WindowState = FormWindowState.Normal;

                    vPop.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Formula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void ctxm_priceHistory_Click(object sender, EventArgs e)
        {
            try
            {
                new Pop.Pop_Material_History().ShowDialog();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "History", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxm_formula_Click(object sender, EventArgs e)
        {
            try
            {
                CellRange cell = fgrid_main.GetCellRange(fgrid_main.Row, fgrid_main.Col);
                if (cell.UserData != null)
                {
                    CellUserData oaCellData = (CellUserData)cell.UserData;
                    Pop.Pop_Bottom_Formula vPop = new Pop.Pop_Bottom_Formula();

                    vPop.PROD_FAC = fgrid_main[fgrid_main.Row, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxFACTORY].ToString();
                    vPop.MCS_NO = fgrid_main[fgrid_main.Row, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxMCS_NO].ToString();
                    vPop.COLOR_CD = oaCellData.ColorCd;

                    vPop.ShowDialog();
                }

                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Formula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_prodFac_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetHeader();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Factory select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_season_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_prodFac.SelectedIndex >= 0)
                    SetHeader();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Season select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_main_MouseHoverCell(object sender, EventArgs e)
        {
            try
            {
                CellRange range = fgrid_main.GetCellRange(fgrid_main.MouseRow, fgrid_main.MouseCol);

                if (range.r1 >= fgrid_main.Rows.Fixed && range.c1 >= fgrid_main.Cols.Frozen)
                {
                    CellUserData oaCellData = (CellUserData)fgrid_main.GetCellRange(fgrid_main.MouseRow, fgrid_main.MouseCol).UserData;
                    _tp.UseAnimation = true;
                    _tp.ToolTipIcon = ToolTipIcon.Info;
                    _tp.ToolTipTitle = "Last update date";
                    _tp.Show(oaCellData.AppDate, this, MousePosition, 2000);
                }
                else
                {
                    _tp.RemoveAll();
                }
            }
            catch
            {

            }
        }

        #endregion

        #endregion

        #region 이벤트 처리

        #region 초기화

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {
                //Title
                this.Text = "Bottom compound cost";
                this.lbl_MainTitle.Text = "Bottom compound cost";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                Init_Control();
                //Init_Toolbar();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFB_CBD_B_MAT_BTTM_COST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Set_Action_Image(img_Action);
        }

        private void Init_Control()
        {
            _DTFactory = COM.ComFunction.Select_Factory_List();
            // T2 공장 코드 세팅
            DataRow vNewRow = _DTFactory.NewRow();
            vNewRow[0] = "T2";
            vNewRow[1] = "T2";
            _DTFactory.Rows.Add(vNewRow);

            COM.ComCtl.Set_ComboList(_DTFactory, cmb_prodFac, 0, 1, true); 

            DataTable vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_20");
            COM.ComCtl.Set_ComboList(vDT, cmb_div, 1, 2, true);
            vDT.Dispose();
            cmb_div.SelectedValue = " ";

            ClassLib.ComFunction_Cost comCost = new FlexCosting.ClassLib.ComFunction_Cost();
            _DTSeason = comCost.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(_DTSeason, cmb_season, 0, 1, false);
            vDT.Dispose();
            cmb_season.SelectedValue = DateTime.Now.Year + string.Format("{0:00}", ((DateTime.Now.Month - 1) / 3) + 1);

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_09");
            COM.ComCtl.Set_ComboList(vDT, cmb_bttmType, 1, 2, true);
            vDT.Dispose();
            cmb_bttmType.SelectedValue = " ";

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_23");
            COM.ComCtl.Set_ComboList(vDT, cmb_status, 1, 2, false);
            vDT.Dispose();
            cmb_status.ReadOnly = true;

            _DTStandColor = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_09");

            cmb_prodFac.SelectedValue = COM.ComVar.This_Factory;
        }

        private void Init_Toolbar()
        {

        }

        private void SetHeader()
        {
            fgrid_main.ClearAll();
            fgrid_main.Cols.Count = fgrid_main.Cols.Frozen;

            string sFactory = cmb_prodFac.SelectedValue.ToString();
            string sSeason = cmb_season.SelectedValue.ToString();

            DataTable vCDT = SELECT_COLUMN_HEADER(sFactory, sSeason);

            for (int iCIdx = 0, iCol = fgrid_main.Cols.Frozen; iCIdx < vCDT.Rows.Count; iCIdx++, iCol++)
            {
                Column vNewCol = fgrid_main.Cols.Add();

                vNewCol.Name = vCDT.Rows[iCIdx]["FACTORY"].ToString() + vCDT.Rows[iCIdx]["SEASON_CD"].ToString() + vCDT.Rows[iCIdx]["COLOR_CD"].ToString();
                vNewCol[0] = vCDT.Rows[iCIdx]["FACTORY"].ToString() + vCDT.Rows[iCIdx]["SEASON_CD"].ToString() + vCDT.Rows[iCIdx]["COLOR_CD"].ToString();
                vNewCol[1] = vCDT.Rows[iCIdx]["FACTORY"].ToString() + " / " + vCDT.Rows[iCIdx]["SEASON_NAME"].ToString();
                vNewCol[2] = vCDT.Rows[iCIdx]["COLOR_CD"].ToString();
            }

            DataTable vRDT = SELECT_ROW_HEADER(sFactory);

            for (int iRIdx = 0; iRIdx < vRDT.Rows.Count; iRIdx++)
            {
                Row vNewRow = fgrid_main.AddItem(vRDT.Rows[iRIdx].ItemArray);
            }
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_main.ClearAll();
        }

        private void Search()
        {
            string sFactory = COM.ComFunction.Empty_Combo(cmb_prodFac, "");
            string sSeason = COM.ComFunction.Empty_Combo(cmb_season, "");
            string sDiv = COM.ComFunction.Empty_Combo(cmb_div, "");
            string sBttmType = COM.ComFunction.Empty_Combo(cmb_bttmType, "");
            string sMcsNO = COM.ComFunction.Empty_TextBox(txt_mcsNO, "");

            if (SELECT_SFB_CBD_B_FORMU_LIST(sFactory, sSeason, sDiv, sBttmType, sMcsNO))
            {
                if (SELECT_SFB_CBD_B_BTTM_CBD_LIST(sFactory, sSeason, sDiv, sBttmType, sMcsNO))
                {
                    DataSet vDS = SELECT_SFB_CBD_B_MAT_UPD_YMD(sFactory, sSeason, sDiv, sBttmType, sMcsNO);

                    if (vDS != null && vDS.Tables.Count == 3)
                    {
                        SearchCBDStatus(vDS.Tables[1]);
                        SearchStdFormulaCost(vDS.Tables[0]);
                        SearchBttmCompoundCost(vDS.Tables[1]);

                        string sStatus = COM.ComFunction.Empty_Combo(cmb_status, "");
                        if (sStatus.Equals("Confirm"))
                        {
                            fgrid_main.AllowEditing = false;
                        }
                        else
                        {
                            fgrid_main.AllowEditing = true;
                        }

                        SearchBttmMatLastUpdate(vDS.Tables[2]);
                        cmb_status.ReadOnly = false;
                    }
                }
            }
        }

        #region Search 

        private void SearchStdFormulaCost(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count > 0)
            {
                string sStatus = COM.ComFunction.Empty_Combo(cmb_status, "");

                for (int iidx = 0; iidx < vDT.Rows.Count; iidx++)
                {
                    // Row
                    string svFactory = vDT.Rows[iidx]["PROD_FAC"].ToString();
                    string svDiv = vDT.Rows[iidx]["DIV"].ToString();
                    string svDivName = vDT.Rows[iidx]["DIV_NAME"].ToString();
                    string svMCSNo = vDT.Rows[iidx]["MCS_NO"].ToString();

                    // Col
                    string svSeason = vDT.Rows[iidx]["SEASON"].ToString();
                    string svColorType = vDT.Rows[iidx]["COLOR_TYPE_CD"].ToString();
                    string svColorCD = vDT.Rows[iidx]["COLOR_CD"].ToString();

                    // Value
                    object ovCost = vDT.Rows[iidx]["COST_KG"];

                    Column col = fgrid_main.Cols[svFactory + svSeason + svColorType];
                    if (col != null)
                    {
                        int iRow = fgrid_main.FindRow(svFactory + svDiv + svMCSNo, fgrid_main.Rows.Fixed, 1, false);

                        if (iRow >= fgrid_main.Rows.Fixed)
                        {
                            CellRange cell = fgrid_main.GetCellRange(iRow, col.Index);
                            cell.UserData = new CellUserData();

                            CellUserData oaCellData = (CellUserData)cell.UserData;

                            //if (_firstStatus.Equals("Release"))
                            //{
                                fgrid_main[iRow, col.Index] = ovCost;
                                oaCellData.Division = "I";
                                oaCellData.Season = svSeason;
                                oaCellData.ColorTypeCode = svColorType;
                                oaCellData.ColorCd = svColorCD;
                                oaCellData.AppDate = "";
                            //}
                        }
                    }
                }
            }
        }

        private void SearchBttmCompoundCost(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int iidx = 0; iidx < vDT.Rows.Count; iidx++)
                {
                    // Row
                    string svFactory = vDT.Rows[iidx]["FACTORY"].ToString();
                    string svDiv = vDT.Rows[iidx]["DIV"].ToString();
                    string svDivName = vDT.Rows[iidx]["DIV_NAME"].ToString();
                    string svMCSNo = vDT.Rows[iidx]["MCS_NO"].ToString();

                    // Col
                    string svSeason = vDT.Rows[iidx]["SEASON"].ToString();
                    string svColorType = vDT.Rows[iidx]["COLOR_TYPE_CD"].ToString();
                    string svColorCD = vDT.Rows[iidx]["COLOR_CD"].ToString();

                    // Value
                    object ovCost = vDT.Rows[iidx]["COST_KG"];
                    object ovAppDate = vDT.Rows[iidx]["APP_DATE"];
                    object ovRemarks = "";
                    if (svSeason.Equals(cmb_season.SelectedValue.ToString()))
                        ovRemarks = vDT.Rows[iidx]["REMARKS"];

                    Column col = fgrid_main.Cols[svFactory + svSeason + svColorType];
                    if (col != null)
                    {
                        object oCellData = "";
                        string sCurDiv = "";
                        int iRow = fgrid_main.FindRow(svFactory + svDiv + svMCSNo, fgrid_main.Rows.Fixed, 1, false);

                        if (iRow >= fgrid_main.Rows.Fixed)
                        {
                            oCellData = fgrid_main.GetCellRange(iRow, col.Index).UserData;
                            if (svSeason.Equals(cmb_season.SelectedValue.ToString()))
                            {
                                double dCurData = fgrid_main.Aggregate(AggregateEnum.Sum, fgrid_main.GetCellRange(iRow, col.Index));
                                double fCurData = 0;
                                double.TryParse(ovCost.ToString(), out fCurData);

                                if (dCurData != fCurData)
                                {
                                    if (_firstStatus.Equals("Release"))
                                        col[iRow] = dCurData;
                                    else
                                        col[iRow] = fCurData;

                                    if (!_firstStatus.Equals("Confirm"))
                                    {
                                        if (oCellData == null)
                                            fgrid_main.GetCellRange(iRow, col.Index).StyleNew.ForeColor = Color.Blue;
                                        else
                                            fgrid_main.GetCellRange(iRow, col.Index).StyleNew.ForeColor = Color.Red;

                                        sCurDiv = oCellData == null ? "I" : "U";
                                    }
                                    else
                                    {
                                        fgrid_main.GetCellRange(iRow, col.Index).StyleNew.ForeColor = Color.Black;
                                    }
                                }
                                else
                                {
                                    fgrid_main.GetCellRange(iRow, col.Index).StyleNew.ForeColor = Color.Black;
                                }
                            }
                            else
                            {
                                fgrid_main[iRow, col.Index] = ovCost;
                            }
                        }

                        if (iRow >= fgrid_main.Rows.Fixed)
                        {
                            CellUserData oaCellData = null;
                            if (oCellData == null)
                                oaCellData = new CellUserData();
                            else
                                oaCellData = (CellUserData)oCellData;

                            oaCellData.Season = svSeason;
                            oaCellData.ColorTypeCode = svColorType;
                            oaCellData.ColorCd = svColorCD;
                            oaCellData.AppDate = ovAppDate.ToString();
                            oaCellData.Division = sCurDiv;

                            fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxREMARKS] = ovRemarks;

                            CellRange cell = fgrid_main.GetCellRange(iRow, col.Index);
                            cell.UserData = oaCellData;
                        }
                    }
                }
            }
        }

        private void SearchCBDStatus(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count > 0)
            {
                DataRow[] vDRs = vDT.Select("SEASON = " + cmb_season.SelectedValue.ToString());

                if (vDRs.Length > 0)
                {
                    cmb_status.SelectedValue = vDRs[0]["STATUS"].ToString();
                }
                else
                {
                    cmb_status.SelectedValue = "Release";
                }
            }
            else
            {
                cmb_status.SelectedIndex = 0;
            }

            _firstStatus = cmb_status.SelectedValue.ToString();
        }

        private void SearchBttmMatLastUpdate(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count == 1)
            {
                txt_lastUpdate.Text = vDT.Rows[0][0].ToString();
            }
        }

        #endregion

        private bool Save()
        {
            if(SAVE_SFB_CBD_B_BTTM_CBD())
            {
                if (SAVE_SFB_CBD_B_BTTM_CBD_REMARK())
                {
                    string sStatus = COM.ComFunction.Empty_Combo(cmb_status, "");

                    //if (!_firstStatus.Equals(sStatus))
                    //{
                        string sFactory = COM.ComFunction.Empty_Combo(cmb_prodFac, "");
                        string sSeason = COM.ComFunction.Empty_Combo(cmb_season, "");

                        SAVE_SFB_CBD_B_BTTM_CBD_STATUS(sFactory, sSeason, sStatus);
                        return true;
                    //}
                }
            }

            return false;
        }

        #endregion

        #region 그리드 이벤트

        private void GridAfterEdit(RowColEventArgs e)
        {
            if (e.Col > (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxREMARKS)
            {
                CellRange range = fgrid_main.GetCellRange(e.Row, e.Col);
                CellUserData cellData = (CellUserData)range.UserData;
                if (!cellData.Division.Equals("I"))
                    cellData.Division = "U";
            }
            else
            {
                fgrid_main.Update_Row(e.Row);
            }
        }

        private void GridBeforeEdit()
        {
            if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
                fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
        }

        #endregion

        #region 버튼 및 기타 이벤트


        #endregion

        #endregion

        #region 디비 연결

        #region 조건

        /// <summary>
        /// PKG_SFB_CBD_B_BTTM_CBD.SELECT_COLUMN_HEADER : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_COLUMN_HEADER(string arg_factory, string arg_season)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SELECT_COLUMN_HEADER";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
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
        /// PKG_SFB_CBD_B_BTTM_CBD.SELECT_ROW_HEADER : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_ROW_HEADER(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SELECT_ROW_HEADER";

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

        #endregion

        #region 조회

        /// <summary>
        /// PKG_SFB_CBD_B_BTTM_CBD.SELECT_SFB_CBD_B_FORMU_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public bool SELECT_SFB_CBD_B_FORMU_LIST(string arg_factory, string arg_season, string arg_div, string arg_bttm_type, string arg_mcs_no)
        {
            try
            {
                //DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SELECT_SFB_CBD_B_FORMU_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_DIV";
                MyOraDB.Parameter_Name[3] = "ARG_BTTM_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_MCS_NO";
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
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = arg_div;
                MyOraDB.Parameter_Values[3] = arg_bttm_type;
                MyOraDB.Parameter_Values[4] = arg_mcs_no;
                MyOraDB.Parameter_Values[5] = "";

                return MyOraDB.Add_Select_Parameter(true);
                //vds_ret = MyOraDB.Exe_Select_Procedure();
                //if (vds_ret == null) return null;

                //return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFB_CBD_B_BTTM_CBD.SELECT_SFB_CBD_B_BTTM_CBD_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public bool SELECT_SFB_CBD_B_BTTM_CBD_LIST(string arg_factory, string arg_season, string arg_div, string arg_bttm_type, string arg_mcs_no)
        {
            try
            {
                //DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SELECT_SFB_CBD_B_BTTM_CBD_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_DIV";
                MyOraDB.Parameter_Name[3] = "ARG_BTTM_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_MCS_NO";
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
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = arg_div;
                MyOraDB.Parameter_Values[3] = arg_bttm_type;
                MyOraDB.Parameter_Values[4] = arg_mcs_no;
                MyOraDB.Parameter_Values[5] = "";

                return MyOraDB.Add_Select_Parameter(false);
                //vds_ret = MyOraDB.Exe_Select_Procedure();
                //if (vds_ret == null) return null;

                //return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFB_CBD_B_BTTM_CBD.SELECT_SFB_CBD_B_MAT_UPD_YMD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_SFB_CBD_B_MAT_UPD_YMD(string arg_factory, string arg_season, string arg_div, string arg_bttm_type, string arg_mcs_no)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SELECT_SFB_CBD_B_MAT_UPD_YMD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_DIV";
                MyOraDB.Parameter_Name[3] = "ARG_BTTM_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_MCS_NO";
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
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = arg_div;
                MyOraDB.Parameter_Values[3] = arg_bttm_type;
                MyOraDB.Parameter_Values[4] = arg_mcs_no;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(false);
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
        /// PKG_SFB_CBD_B_BTTM_CBD.SAVE_SFB_CBD_B_BTTM_CBD : 
        /// </summary>
        public bool SAVE_SFB_CBD_B_BTTM_CBD()
        {
            try
            {

                MyOraDB.ReDim_Parameter(14);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SAVE_SFB_CBD_B_BTTM_CBD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_ROW_NAME";
                MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[3] = "ARG_DIV";
                MyOraDB.Parameter_Name[4] = "ARG_DIV_NAME";
                MyOraDB.Parameter_Name[5] = "ARG_MCS_NO";
                MyOraDB.Parameter_Name[6] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[7] = "ARG_SEASON";
                MyOraDB.Parameter_Name[8] = "ARG_COLOR_TYPE_CD";
                MyOraDB.Parameter_Name[9] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[10] = "ARG_COST_KG";
                MyOraDB.Parameter_Name[11] = "ARG_APP_DATE";
                MyOraDB.Parameter_Name[12] = "ARG_STATUS";
                MyOraDB.Parameter_Name[13] = "ARG_UPD_USER";

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
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;

                //04.DATA 정의
                ArrayList vAR = new ArrayList();
                for (int iCol = fgrid_main.Cols.Frozen; iCol < fgrid_main.Cols.Count; iCol++)
                {
                    if (fgrid_main.Cols[iCol].AllowEditing)
                    {
                        for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
                        {
                            object oCellData = fgrid_main.GetCellRange(iRow, iCol).UserData;
                            if (oCellData != null)
                            {
                                CellUserData cellData = (CellUserData)oCellData;

                                if (!cellData.Division.Equals(""))
                                {
                                    vAR.Add(cellData.Division);
                                    vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxROW_NAME].ToString());
                                    vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxFACTORY].ToString());
                                    vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxDIV].ToString());
                                    vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxDIV_NAME].ToString());
                                    vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxMCS_NO].ToString());
                                    vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxREMARKS].ToString());

                                    vAR.Add(cellData.Season);
                                    vAR.Add(cellData.ColorTypeCode);
                                    vAR.Add(cellData.ColorCd);
                                    vAR.Add(fgrid_main[iRow, iCol].ToString());
                                    vAR.Add(cellData.AppDate);
                                    vAR.Add(cmb_status.SelectedValue.ToString());
                                    vAR.Add(COM.ComVar.This_User);
                                }
                            }
                        }
                    }
                }

                MyOraDB.Parameter_Values = (string[])vAR.ToArray(Type.GetType("System.String"));

                return MyOraDB.Add_Modify_Parameter(true);

                //if (MyOraDB.Exe_Modify_Procedure() == null)
                //    return false;
                //else
                //    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFB_CBD_B_BTTM_CBD.SAVE_SFB_CBD_B_BTTM_CBD_REMARK : 
        /// </summary>
        public bool SAVE_SFB_CBD_B_BTTM_CBD_REMARK()
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SAVE_SFB_CBD_B_BTTM_CBD_REMARK";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_MCS_NO";
                MyOraDB.Parameter_Name[3] = "ARG_COLOR_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

                ArrayList vAR = new ArrayList();

                for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
                {
                    if (fgrid_main[iRow, 0] != null)
                    {
                        if (fgrid_main[iRow, 0].ToString().Equals("U"))
                        {
                            vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxFACTORY].ToString());
                            vAR.Add(cmb_season.SelectedValue.ToString());
                            vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxMCS_NO].ToString());
                            vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxDIV].ToString());
                            vAR.Add(fgrid_main[iRow, (int)ClassLib.TBSFB_CBD_B_MAT_BTTM_COST.IxREMARKS].ToString());
                            vAR.Add(COM.ComVar.This_User);
                        }
                    }
                }

                MyOraDB.Parameter_Values = (string[])vAR.ToArray(Type.GetType("System.String"));

                return MyOraDB.Add_Modify_Parameter(false);

                //if (MyOraDB.Exe_Modify_Procedure() == null)
                //    return false;
                //else
                //    return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFB_CBD_B_BTTM_CBD.SAVE_SFB_CBD_B_BTTM_CBD_STATUS : 
        /// </summary>
        public bool SAVE_SFB_CBD_B_BTTM_CBD_STATUS(string arg_factory, string arg_season, string arg_status)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_BTTM_CBD.SAVE_SFB_CBD_B_BTTM_CBD_STATUS";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_STATUS";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = arg_status;
                MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(false);
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

        #endregion

    }
}


