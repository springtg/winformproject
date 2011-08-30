using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Pop
{
    public partial class Pop_ProCost_Yield_Search : COM.PCHWinForm.Form_Top
    {
        public Pop_ProCost_Yield_Search()
        {
            InitializeComponent();

            Init_Form();
        }

        public Pop_ProCost_Yield_Search(FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 arg_parent)
        {
            InitializeComponent();
            _Parent = arg_parent;
            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private COM.OraDB MyOraDB = new COM.OraDB();

        private string sSqlConnectionString = "Data Source=203.228.109.234;Initial Catalog=ProCost4;User ID=sa; Timeout=5";
        private string sSqlSelectStyle = null;
        private string sSqlSelectpart = null;

        FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 _Parent = null;
        private Color[] vBC = new Color[] { ClassLib.ComVar.ClrLevel_1st, ClassLib.ComVar.ClrLevel_3rd };
        private object[][] _copyRange;

        private string _DevFac = "", _MOID = "", _CBDID = "", _CBDVer = "", _FOBTypeCD = "";

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
            SqlConnection vCon = new SqlConnection(sSqlConnectionString);

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Save())
                {
                    SearchCBDPart();
                    SearchProcostPart(vCon);
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
                }
                else
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                if (vCon != null && vCon.State == ConnectionState.Open)
                    vCon.Close();

                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Save())
                {
                    _Parent.SetUpperYieldFLD();
                    this.Close();
                }
                else
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Data_Message(COM.ComVar.MgsEndSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        private void fgrid_procostStyle_Click(object sender, EventArgs e)
        {
            SqlConnection vCon = new SqlConnection(sSqlConnectionString);

            try
            {
                if (fgrid_procostStyle.Rows.Fixed < fgrid_procostStyle.Rows.Count && fgrid_procostStyle.Row >= fgrid_procostStyle.Rows.Fixed)
                {
                    SearchProcostPart(vCon);
                    if (SearchCBDPart() > 0)
                    {
                        btn_AutoCheck.Enabled = false;
                    }
                    UpdateProcostPart();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Procost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (vCon != null && vCon.State == ConnectionState.Open)
                    vCon.Close();
            }
        }

        private void fgrid_cbdPart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_cbdPart.Row >= fgrid_cbdPart.Rows.Fixed)
                {
                    if (fgrid_cbdPart.Rows[fgrid_cbdPart.Row].Node.Level == 1)
                    {
                        if (fgrid_cbdPart[fgrid_cbdPart.Row, 0] != null && fgrid_cbdPart[fgrid_cbdPart.Row, 0].ToString().Equals("I"))
                        {
                            fgrid_cbdPart.Rows.Remove(fgrid_cbdPart.Row);
                        }
                        else
                        {
                            fgrid_cbdPart.Delete_Row(fgrid_cbdPart.Row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Double click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_procostPart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_cbdPart.Rows[fgrid_cbdPart.Row].Node.Level == 0)
                {
                    SelectYield();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Double click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void cmb_server_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int iCmbRow = cmb_server.SelectedIndex;

                if (iCmbRow >= 0)
                {
                    string sServer = cmb_server.GetItemText(iCmbRow, 1);
                    string sCatalog = cmb_server.GetItemText(iCmbRow, 2);
                    string sUser = cmb_server.GetItemText(iCmbRow, 3);
                    string sPass = cmb_server.GetItemText(iCmbRow, 4);

                    sSqlConnectionString = "Data Source=" + sServer.Trim() + ";" +
                    "Initial Catalog=" + sCatalog.Trim() + ";" +
                    "User ID=" + sUser.Trim() +";" +
                    "Password=" + sPass.Trim() + ";" + 
                    "Timeout=5";
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Server Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_copy_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_cbdPart.Row >= fgrid_cbdPart.Rows.Fixed)
                {
                    DataCopy(fgrid_cbdPart);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_paste_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_cbdPart.Row >= fgrid_cbdPart.Rows.Fixed)
                {
                    DataPaste(fgrid_cbdPart);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_cbdPart.Row >= fgrid_cbdPart.Rows.Fixed)
                {
                    foreach (int iRow in fgrid_cbdPart.Selections)
                    {
                        if (fgrid_cbdPart.Rows[iRow].Node.Level == 1)
                        {
                            if (fgrid_cbdPart[iRow, 0] != null && fgrid_cbdPart[iRow, 0].ToString().Equals("I"))
                            {
                                fgrid_cbdPart.Rows.Remove(iRow);
                            }
                            else
                            {
                                fgrid_cbdPart.Delete_Row(iRow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_AutoCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_cbdPart.Row >= fgrid_cbdPart.Rows.Fixed)
                {
                    SearchMatrixBase();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Matching", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Text = "Yield Search";
                this.lbl_MainTitle.Text = "Yield Search";

                Init_Grid();
                Init_Control();
                Init_Toolbar();
                Init_Query();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Query()
        {
            sSqlSelectStyle = "SELECT ID, SEASON, CATEGORY, USER_, STYLE, BASIC_SIZE, DESCRIPTION, SEMIFILE, CREATE_DATE, LASTMODIFIEDDATE " +
                                     "  FROM STYLE " + 
                                     " WHERE SEASON   LIKE @season   + '%'" +
                                     "   AND CATEGORY LIKE @category + '%'" +
                                     "   AND USER_    LIKE @user     + '%'" + 
                                     "   AND ( STYLE  LIKE @sch_text + '%'" +
                                     "      OR SEMIFILE LIKE @sch_text + '%') ";


            sSqlSelectpart = "SELECT D.ID_STYLE_PATTERN, D.ID_PATTERN_GEO,  D.ID, " + 
                             "       B.PATT_NAME, " + 
                             "       D.GAP, " + 
                             "       D.PATT_NUMBER, " + 
                             "       D.EFFIC, " + 
                             "       D.YIELDFLD, " + 
                             "       D.YIELDUNIT, " + 
                             "       convert(VARCHAR, D.YIELDFLD) + '/' + YIELDUNIT, " + 
                             "       D.LENGTH_UNIT_MATERIAL + '*' + WIDTH_UNIT_MATERIAL, " + 
                             "       D.LENGTH_MATERIAL, " + 
                             "       D.WIDTH_MATERIAL, " + 
                             "       D.MARGIN_X, " + 
                             "       D.MARGIN_X_UNIT, " + 
                             "       D.MARGIN_W, " + 
                             "       D.MARGIN_W_UNIT " + 
                             "  FROM STYLE A LEFT JOIN PATTERN B " + 
                             "                      ON A.ID = B.ID_STYLE_PATTERN " + 
                             "               LEFT JOIN PATTERN_GEO C " + 
                             "                      ON B.ID_PATTERN_GEO = C.ID " + 
                             "                     AND B.ID_STYLE_PATTERN = C.ID_STYLE_PATTERN_GEO " + 
                             "               LEFT JOIN PATTERN_MAT D " + 
                             "                      ON B.ID_PATTERN_MAT = D.ID " + 
                             "                     AND B.ID_STYLE_PATTERN = D.ID_STYLE_PATTERN " + 
                             "                     AND B.ID_PATTERN_GEO = D.ID_PATTERN_GEO " +  
                             " WHERE A.ID = @style_id ";
        }

        private void Init_Grid()
        {
            fgrid_procostStyle.Set_Grid("PRO_COST_STYLE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_procostStyle.Font = new Font(fgrid_procostStyle.Font.FontFamily, (float)8.5);
            fgrid_procostStyle.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_procostStyle.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;

            fgrid_cbdPart.Set_Grid("SFM_CBD_PART", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cbdPart.Font = new Font(fgrid_cbdPart.Font.FontFamily, (float)8.5);
            fgrid_cbdPart.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_cbdPart.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cbdPart.Set_Action_Image(img_Action);

            fgrid_procostPart.Set_Grid("SFM_PROCOST_PART", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_procostPart.Font = new Font(fgrid_procostPart.Font.FontFamily, (float)8.5);
            fgrid_procostPart.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_procostPart.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
        }

        private void Init_Control()
        {
            FlexCosting.ClassLib.ComFunction_Cost comFnc = new FlexCosting.ClassLib.ComFunction_Cost();

            DataTable vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_season, 0, 1, false, false);
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_51");
            COM.ComCtl.Set_ComboList(vDT, cmb_user, 1, 2, true);
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "MD02");
            COM.ComCtl.Set_ComboList(vDT, cmb_category, 1, 2, false);
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_36");
            COM.ComCtl.Set_ComboList_Multi(vDT, cmb_server, new int[] { 1, 2, 4, 6, 8 }, false);
            cmb_server.Splits[0].DisplayColumns[1].Visible = false;
            cmb_server.Splits[0].DisplayColumns[2].Visible = false;
            cmb_server.Splits[0].DisplayColumns[3].Visible = false;
            cmb_server.Splits[0].DisplayColumns[4].Visible = false;
            cmb_server.DropDownWidth = cmb_server.Width;
            cmb_server.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();
        }

        private void Init_Toolbar()
        {
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_cbdPart.ClearAll();
            fgrid_procostPart.ClearAll();
            fgrid_procostStyle.ClearAll();
        }

        private void Search()
        {
            SqlConnection vCon = new SqlConnection(sSqlConnectionString);

            try
            {
                fgrid_cbdPart.ClearAll();
                fgrid_procostPart.ClearAll();
                SearchProcostStyle(vCon);
                SearchCBDPart();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (vCon != null && vCon.State == ConnectionState.Open)
                    vCon.Close();
            }
        }

        private void SearchProcostStyle(SqlConnection vCon)
        {
            //string sSeason = COM.ComFunction.Empty_Combo(cmb_season, "");

            string sSeason = cmb_season.SelectedText;
            string sCategory = ""; //cmb_category.SelectedText;
            string sUser = COM.ComFunction.Empty_Combo(cmb_user, "");
            string sSchText = txt_schText.Text;

            SqlDataReader vDR = SELECT_PROCOST_STYLE(vCon, sSeason, sCategory, sUser, sSchText);

            fgrid_procostStyle.ClearAll();
            if (vDR.Read())
            {
                do
                {
                    C1.Win.C1FlexGrid.Row vNewRow = fgrid_procostStyle.Rows.Add();

                    for (int iCol = 1; iCol < vDR.FieldCount; iCol++)
                    {
                        vNewRow[iCol] = vDR[iCol - 1];
                    }


                } while (vDR.Read());
            }
        }

        private int SearchCBDPart()
        {
            // select cbd part list
            // model, moid, bomid, style_cd, td, category, prod_fac 
            // dev_fac, cbd_id, cbd_ver, fob_type_cd 
            string sDevFac = _DevFac;
            string sMOID = _MOID;
            string sCBDID = _CBDID;
            string sCBDVer = _CBDVer;
            string sFOBTypeCD = _FOBTypeCD;

            int iPttnCnt = 0;

            DataTable vDT = SELECT_SFX_CBD_PART(sDevFac, sMOID, sCBDID, sCBDVer, sFOBTypeCD);
            fgrid_cbdPart.ClearAll();
            fgrid_cbdPart.Display_Grid(vDT, false);

            for (int iRow = fgrid_cbdPart.Rows.Fixed; iRow < fgrid_cbdPart.Rows.Count; iRow++)
            {
                fgrid_cbdPart.Rows[iRow].IsNode = true;
                fgrid_cbdPart.Rows[iRow].Node.Level = Convert.ToInt32(fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxLEV].ToString());
                fgrid_cbdPart.Rows[iRow].StyleNew.BackColor = vBC[fgrid_cbdPart.Rows[iRow].Node.Level];
            }

            for (int iRow = fgrid_cbdPart.Rows.Fixed; iRow < fgrid_cbdPart.Rows.Count; iRow++)
            {
                if (fgrid_cbdPart.Rows[iRow].Node.Level == 0)
                {
                    fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT] = fgrid_cbdPart.Rows[iRow].Node.Children;
                    if (fgrid_cbdPart.Rows[iRow].Node.Children > 0)
                    {
                        fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD] = fgrid_cbdPart.Aggregate(
                            C1.Win.C1FlexGrid.AggregateEnum.Sum,
                            fgrid_cbdPart.GetCellRange(iRow + 1, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD,
                            iRow + fgrid_cbdPart.Rows[iRow].Node.Children, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD));
                    }
                    iPttnCnt += fgrid_cbdPart.Rows[iRow].Node.Children;
                }
            }

            fgrid_cbdPart.Tree.Column = (int)ClassLib.TBSFM_CBD_PART.IxPART_NAME;

            return iPttnCnt;
        }

        private void SearchProcostPart(SqlConnection vCon)
        {
            string sStyle = fgrid_procostStyle[fgrid_procostStyle.Row, (int)ClassLib.TBPRO_COST_STYLE.IxSTYLE_ID].ToString();

            SqlDataReader vDR = SELECT_PROCOST_PART(vCon, sStyle);

            fgrid_procostPart.ClearAll();
            if (vDR.Read())
            {
                do
                {
                    C1.Win.C1FlexGrid.Row vNewRow = fgrid_procostPart.Rows.Add();

                    for (int iCol = 1; iCol <= vDR.FieldCount; iCol++)
                    {
                        vNewRow[iCol] = vDR[iCol - 1];
                    }

                } while (vDR.Read());
            }
        }

        private void UpdateProcostPart()
        {
            for (int iCBDRow = fgrid_cbdPart.Rows.Fixed; iCBDRow < fgrid_cbdPart.Rows.Count; iCBDRow++)
            {
                if (fgrid_cbdPart.Rows[iCBDRow].Node.Level == 1)
                {
                    string sIDStylePttn1 = fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxID_STYLE_PATTERN].ToString();
                    string sIDPttnGeo1 = fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_GEO].ToString();
                    string sIDPttnMat1 = fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_MAT].ToString();

                    for (int iProcostRow = fgrid_procostPart.Rows.Fixed; iProcostRow < fgrid_procostPart.Rows.Count; iProcostRow++)
                    {
                        string sIDStylePttn2 = fgrid_procostPart[iProcostRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_STYLE_PATTERN].ToString();
                        string sIDPttnGeo2 = fgrid_procostPart[iProcostRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_PATTERN_GEO].ToString();
                        string sIDPttnMat2 = fgrid_procostPart[iProcostRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_PATTERN_MAT].ToString();

                        if (sIDStylePttn1.Equals(sIDStylePttn2) && sIDPttnGeo1.Equals(sIDPttnGeo2) && sIDPttnMat1.Equals(sIDPttnMat2))
                        {
                            fgrid_procostPart.Rows[iProcostRow].StyleNew.BackColor = Color.Black;
                            fgrid_procostPart.Rows[iProcostRow].StyleNew.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        //private void UpdateCBDPart()
        //{
        //    // ID_STYLE_PATTERN, ID_PATTERN_GEO, ID_PATTERN_MAT 

        //    for (int iCBDRow = fgrid_cbdPart.Rows.Fixed; iCBDRow < fgrid_cbdPart.Rows.Count; iCBDRow++)
        //    {
        //        string sIDStylePttn2 = fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxID_STYLE_PATTERN].ToString();
        //        string sIDPttnGeo2 = fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_GEO].ToString();
        //        string sIDPttnMat2 = fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_MAT].ToString();
                
        //        for (int iProRow = fgrid_procostPart.Rows.Fixed; iProRow < fgrid_procostPart.Rows.Count; iProRow++)
        //        {
        //            string sIDStylePttn1 = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_STYLE_PATTERN].ToString();
        //            string sIDPttnGeo1 = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_PATTERN_GEO].ToString();
        //            string sIDPttnMat1 = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_PATTERN_MAT].ToString();

        //            if (sIDStylePttn1.Equals(sIDStylePttn2) && sIDPttnGeo1.Equals(sIDPttnGeo2) && sIDPttnMat1.Equals(sIDPttnMat2))
        //            {
        //                string width = NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxWEIGHT]);
        //                string length = NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxLENGTH]);
        //                string sUOM = length + "x" + width;

        //                if (!NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxPATT_NAME]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_NAME])) ||
        //                    //!NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxPATT_SIZE]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_SIZE])) ||
        //                    //!NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxPATT_METHOD]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_METHOD])) ||
        //                    !NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxEFFIC]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxEFFIC])) ||
        //                    !NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxPART_GAP]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPART_GAP])) ||
        //                    !NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxPARTS_PER_PAIR]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPARTS_PER_PAIR])) ||
        //                    !NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD]).Equals(NullToString(fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxYIELD_FLD])) ||
        //                    !NullToString(fgrid_cbdPart[iProRow, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_UNIT]).Equals(sUOM))
        //                {
        //                    fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPATT_NAME] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_NAME];
        //                    //fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPATT_SIZE] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_SIZE];
        //                    //fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPATT_METHOD] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_METHOD];
        //                    fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxEFFIC] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxEFFIC];
        //                    fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPART_GAP] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPART_GAP];
        //                    fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPARTS_PER_PAIR] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPARTS_PER_PAIR];
        //                    fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD] = fgrid_procostPart[iProRow, (int)ClassLib.TBSFM_PROCOST_PART.IxYIELD_FLD];
        //                    fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_UNIT] = sUOM;
        //                    fgrid_cbdPart.Update_Row(iCBDRow);
        //                }
        //            }
        //        }
        //    }
        //}

        //private void SearchMatrixBase()
        //{
        //    double dCnt = fgrid_cbdPart.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
        //        fgrid_cbdPart.Rows.Fixed, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT,
        //        fgrid_cbdPart.Rows.Count - 1, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT);

        //    if (dCnt == 0)
        //    {
        //        string sDevFac = _DevFac;
        //        string sMOID = _MOID;
        //        string sCBDID = _CBDID;
        //        string sCBDVer = _CBDVer;
        //        string sFOBTypeCD = _FOBTypeCD;

        //        DataTable vDT = SELECT_SFX_CBD_M_PTN_MATRIX(sDevFac, sMOID, sCBDID, sCBDVer, sFOBTypeCD);

        //        for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
        //        {
        //            string sPartName = vDT.Rows[iIdx][0].ToString();
        //            string sPttnName = vDT.Rows[iIdx][1].ToString();

        //            // CBD Up No 검색
        //            for (int iRow = fgrid_cbdPart.Rows.Fixed; iRow < fgrid_cbdPart.Rows.Count; iRow++)
        //            {
        //                if (NullToString(fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxPART_NAME]).Equals(sPartName))
        //                {
        //                    // Pro-cost Part 검색
        //                    for (int iPCRow = fgrid_procostPart.Rows.Fixed; iPCRow < fgrid_procostPart.Rows.Count; iPCRow++)
        //                    {
        //                        string sCurPttn = fgrid_procostPart[iPCRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_NAME].ToString();

        //                        //if (sCurPttn.IndexOf(sPttn) >= 0)
        //                        if (sCurPttn.Equals(sPttnName))
        //                        {
        //                            fgrid_cbdPart.Select(iRow, 0);
        //                            fgrid_procostPart.Select(iPCRow, 0);
        //                            SelectYield();
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        private void SearchMatrixBase()
        {
            double dCnt = fgrid_cbdPart.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                fgrid_cbdPart.Rows.Fixed, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT,
                fgrid_cbdPart.Rows.Count - 1, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT);

            if (dCnt == 0)
            {
                for (int iCBDRow = fgrid_cbdPart.Rows.Fixed; iCBDRow < fgrid_cbdPart.Rows.Count; iCBDRow++)
                {
                    string sCurPartName = NullToString(fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPART_NAME]);
                    sCurPartName = sCurPartName.Replace(" ", "").Replace("_", "").Replace("-", "").Replace("#", "").Replace(".", "").Replace("/", "").ToUpper();
                    if (!sCurPartName.Equals(""))
                    {
                            // Pro-cost Part 검색
                            for (int iPCRow = fgrid_procostPart.Rows.Fixed; iPCRow < fgrid_procostPart.Rows.Count; iPCRow++)
                            {
                                string sCurPttn = fgrid_procostPart[iPCRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_NAME].ToString();
                                sCurPttn = sCurPttn.Replace(" ", "").Replace("_", "").Replace("-", "").Replace("#", "").Replace(".", "").Replace("/", "").ToUpper();

                                if (sCurPartName.Equals(sCurPttn))
                                {
                                    fgrid_cbdPart.Select(iCBDRow, 0);
                                    fgrid_procostPart.Select(iPCRow, 0);
                                    SelectYield();
                                    iCBDRow++;
                                }
                            }
                    }
                }
            }
        }

        private bool CheckExist(int iCBDRow, string sIDStylePttn1, string sIDPttnGeo1, string sIDPttnMat1)
        {
            //for (int iRow = iCBDRow + 1; iRow < (iCBDRow + 1) + fgrid_cbdPart.Rows[iCBDRow].Node.Children; iRow++)
            //{
            //    string sIDStylePttn2 = fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxID_STYLE_PATTERN].ToString();
            //    string sIDPttnGeo2 = fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_GEO].ToString();
            //    string sIDPttnMat2 = fgrid_cbdPart[iRow, (int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_MAT].ToString();

            //    if (sIDStylePttn1.Equals(sIDStylePttn2) && sIDPttnGeo1.Equals(sIDPttnGeo2) && sIDPttnMat1.Equals(sIDPttnMat2))
            //    {
            //        return true;
            //    }
            //}

            return false;
        }

        private bool Save()
        {
            if (SAVE_SFX_CBD_TAIL_PROCOST())
            {
                return true;
            }

            return false;
        }

        #endregion

        #region 그리드 이벤트

        private void SelectYield()
        {
            if (fgrid_procostPart.Rows.Fixed < fgrid_procostPart.Rows.Count && fgrid_procostPart.Row >= fgrid_procostPart.Rows.Fixed)
            {
                if (fgrid_cbdPart.Rows.Fixed < fgrid_cbdPart.Rows.Count && fgrid_cbdPart.Row >= fgrid_cbdPart.Rows.Fixed)
                {
                    int iCBDRow = fgrid_cbdPart.Row;
                    if (fgrid_cbdPart.Rows[iCBDRow].Node.Level > 0)
                        iCBDRow = fgrid_cbdPart.Rows[iCBDRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;

                    if (fgrid_cbdPart[iCBDRow, 0] != null && !fgrid_cbdPart[iCBDRow, 0].ToString().Equals("D"))
                    {
                        int iPCRow = fgrid_procostPart.Row;
                        string sIDStylePttn2 = fgrid_procostPart[iPCRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_STYLE_PATTERN].ToString();
                        string sIDPttnGeo2 = fgrid_procostPart[iPCRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_PATTERN_GEO].ToString();
                        string sIDPttnMat2 = fgrid_procostPart[iPCRow, (int)ClassLib.TBSFM_PROCOST_PART.IxID_PATTERN_MAT].ToString();

                        if (!CheckExist(iCBDRow, sIDStylePttn2, sIDPttnGeo2, sIDPttnMat2))
                        {
                            C1.Win.C1FlexGrid.Node vNewNode = fgrid_cbdPart.Rows.InsertNode(iCBDRow + 1, fgrid_cbdPart.Rows[iCBDRow].Node.Level + 1);
                            vNewNode.Row[0] = "I";
                            // CBD data
                            for (int iCBDCol = 1; iCBDCol < (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT; iCBDCol++)
                            {
                                vNewNode.Row[iCBDCol] = fgrid_cbdPart[iCBDRow, iCBDCol];
                            }

                            // Procost data
                            for (int iPCCol = 1, iCBDCol = (int)ClassLib.TBSFM_CBD_PART.IxID_STYLE_PATTERN; iPCCol < fgrid_procostPart.Cols.Count; iPCCol++, iCBDCol++)
                            {
                                vNewNode.Row[iCBDCol] = fgrid_procostPart[iPCRow, iPCCol];
                            }
                            vNewNode.Row[(int)ClassLib.TBSFM_CBD_PART.IxPART_NAME] = fgrid_procostPart[iPCRow, (int)ClassLib.TBSFM_PROCOST_PART.IxPATT_NAME];
                            vNewNode.Row[(int)ClassLib.TBSFM_CBD_PART.IxUPD_USER] = COM.ComVar.This_User;
                            vNewNode.Row[(int)ClassLib.TBSFM_CBD_PART.IxUPD_YMD] = DateTime.Now;
                            fgrid_procostPart.Rows[iPCRow].StyleNew.BackColor = Color.Black;
                            fgrid_procostPart.Rows[iPCRow].StyleNew.ForeColor = Color.White;

                            fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT] = fgrid_cbdPart.Rows[iCBDRow].Node.Children;
                            if (fgrid_cbdPart.Rows[iCBDRow].Node.Children > 0)
                            {
                                fgrid_cbdPart[iCBDRow, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD] = fgrid_cbdPart.Aggregate(
                                    C1.Win.C1FlexGrid.AggregateEnum.Sum,
                                    fgrid_cbdPart.GetCellRange(iCBDRow + 1, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD,
                                    iCBDRow + fgrid_cbdPart.Rows[iCBDRow].Node.Children, (int)ClassLib.TBSFM_CBD_PART.IxYIELD_FLD));
                            }
                        }
                    }
                }
            }
        }

        private void fgrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                COM.FSP grid = (sender as COM.FSP);

                if (grid.Rows.Count > grid.Rows.Fixed)
                {
                    if (e.Control && e.KeyCode == Keys.C)
                    {
                        DataCopy(sender as COM.FSP);
                    }
                    else if (e.Control && e.KeyCode == Keys.V)
                    {
                        DataPaste(sender as COM.FSP);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Grid Copy & Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataCopy(COM.FSP arg_grid)
        {
            int[] iSels = arg_grid.Selections;
            int rIdx = iSels.Length;
            int cIdx = arg_grid.Cols.Count;

            string copyData = "";
            _copyRange = new object[rIdx][];

            for (int idx = 0; idx < _copyRange.Length; idx++)
            {
                _copyRange[idx] = new object[cIdx - 1];
            }

            int oRow = 0;
            foreach (int iRow in iSels)
            {
                for (int nCol = 1, oCol = 0; nCol < cIdx; nCol++, oCol++)
                {
                    _copyRange[oRow][oCol] = arg_grid[iRow, nCol];
                    copyData += arg_grid[iRow, nCol] + (nCol == (cIdx - 1) ? "\n" : "\t");
                }

                oRow++;
            }

            Clipboard.Clear();

            if (copyData != null && !copyData.Equals(""))
                Clipboard.SetText(copyData);
        }

        private void DataPaste(COM.FSP arg_grid)
        {
            string sClip = Clipboard.GetText();

            if (_copyRange != null && _copyRange.Length > 0)
            {
                int row = fgrid_cbdPart.Row;
                if (fgrid_cbdPart.Rows[row].Node.Level == 0)
                {
                    int rowCount = _copyRange.Length;
                    int colCount = _copyRange[0].Length;

                    for (int nRow = row, oRow = 0; oRow < rowCount; nRow++, oRow++)
                    {
                        string sIDStylePttn2 = _copyRange[oRow][(int)ClassLib.TBSFM_CBD_PART.IxID_STYLE_PATTERN - 1].ToString();
                        string sIDPttnGeo2 = _copyRange[oRow][(int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_GEO - 1].ToString();
                        string sIDPttnMat2 = _copyRange[oRow][(int)ClassLib.TBSFM_CBD_PART.IxID_PATTERN_MAT - 1].ToString();

                        if (!CheckExist(row, sIDStylePttn2, sIDPttnGeo2, sIDPttnMat2))
                        {
                            C1.Win.C1FlexGrid.Node vNewRow = arg_grid.Rows.InsertNode(row + arg_grid.Rows[row].Node.Children + 1, 1);
                            vNewRow.Row[0] = "I";

                            for (int nCol = 1, oCol = 0; oCol < colCount; nCol++, oCol++)
                            {
                                if (nRow < arg_grid.Rows.Count && nCol < arg_grid.Cols.Count)
                                {
                                    vNewRow.Row[nCol] = _copyRange[oRow][oCol];
                                }
                            }
                        }
                    }
                }
            }

            if (sClip != null && !sClip.Equals(""))
                Clipboard.SetText(sClip);
        }

        #endregion

        #region 버튼 및 기타 이벤트


        #endregion

        #region Property

        // dev_fac, moid, cbd_id, cbd_ver, fob_type_cd 
        public string DevFac
        {
            get { return _DevFac; }
            set { _DevFac = value; }
        }
        
        public string MOID
        {
            set { _MOID = value; }
            get { return _MOID; }
        }

        public string CBDID
        {
            get { return _CBDID; }
            set { _CBDID = value; }
        }

        public string CBDVer
        {
            get { return _CBDVer; }
            set { _CBDVer = value; }
        }

        public string FOBTypeCD
        {
            get { return _FOBTypeCD; }
            set { _FOBTypeCD = value; }
        }

        // season, category
        public string SeasonCode
        {
            get { return cmb_season.SelectedText; }
            set
            {
                if (value != null && !value.Equals(""))
                    cmb_season.SelectedValue = value;
            }
        }

        public string CategoryCode
        {
            get { return cmb_category.SelectedValue.ToString(); }
            set { cmb_category.SelectedValue = value; }
        }

        #endregion

        #endregion

        #region 디비 연결

        #region 조건

        // Season list 


        #endregion

        #region 조회

        // 1. Procost style list 
        private SqlDataReader SELECT_PROCOST_STYLE(SqlConnection vCon, string arg_season, string arg_category, string arg_user, string arg_sch_text)
        {
            try
            {
                vCon.Open();

                SqlCommand vCmd = new SqlCommand(sSqlSelectStyle, vCon);
                vCmd.Parameters.Add("@season", SqlDbType.VarChar);
                vCmd.Parameters.Add("@category", SqlDbType.VarChar);
                vCmd.Parameters.Add("@user", SqlDbType.VarChar);
                vCmd.Parameters.Add("@sch_text", SqlDbType.VarChar);

                vCmd.Parameters["@season"].Value = arg_season.Trim();
                vCmd.Parameters["@category"].Value = arg_category.Trim();
                vCmd.Parameters["@user"].Value = arg_user.Trim();
                vCmd.Parameters["@sch_text"].Value = arg_sch_text.Trim();

                return vCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        // 2. CBD part list 
        /// <summary>
        /// PKG_SFB_CBD_B_PTN_MATRIX.SELECT_SFM_CBD_PART : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_PART(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TAIL_PROCOST.SELECT_SFX_CBD_PART";

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
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
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


        // 3. Procost part list 
        private SqlDataReader SELECT_PROCOST_PART(SqlConnection vCon, string arg_style_id)
        {
            try
            {
                vCon.Open();

                SqlCommand vCmd = new SqlCommand(sSqlSelectpart, vCon);
                vCmd.Parameters.Add("@style_id", SqlDbType.VarChar);

                vCmd.Parameters["@style_id"].Value = arg_style_id.Trim();

                return vCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFX_CBD_TAIL_PROCOST.SELECT_SFX_CBD_M_PTN_MATRIX : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_PTN_MATRIX(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TAIL_PROCOST.SELECT_SFX_CBD_M_PTN_MATRIX";

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
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
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
        /// PKG_SFX_CBD_TAIL_PROCOST.SAVE_SFX_CBD_TAIL_PROCOST : 
        /// </summary>
        public bool SAVE_SFX_CBD_TAIL_PROCOST()
        {
            try
            {
                //02.ARGURMENT 명
                MyOraDB.ReDim_Parameter(34);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TAIL_PROCOST.SAVE_SFX_CBD_TAIL_PROCOST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_LEV";
                MyOraDB.Parameter_Name[2] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[3] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[4] = "ARG_MOID";
                MyOraDB.Parameter_Name[5] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[6] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[7] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[8] = "ARG_CBD_NO";
                MyOraDB.Parameter_Name[9] = "ARG_PTN_SEQ";
                MyOraDB.Parameter_Name[10] = "ARG_PART_NO";
                MyOraDB.Parameter_Name[11] = "ARG_PART_TYPE";
                MyOraDB.Parameter_Name[12] = "ARG_PART_CLASS";
                MyOraDB.Parameter_Name[13] = "ARG_PART_SEQ";
                MyOraDB.Parameter_Name[14] = "ARG_PART_NAME";
                MyOraDB.Parameter_Name[15] = "ARG_PTTN_CNT";
                MyOraDB.Parameter_Name[16] = "ARG_ID_STYLE_PATTERN";
                MyOraDB.Parameter_Name[17] = "ARG_ID_PATTERN_GEO";
                MyOraDB.Parameter_Name[18] = "ARG_ID_PATTERN_MAT";
                MyOraDB.Parameter_Name[19] = "ARG_PATT_NAME";
                MyOraDB.Parameter_Name[20] = "ARG_PART_GAP";
                MyOraDB.Parameter_Name[21] = "ARG_PARTS_PER_PAIR";
                MyOraDB.Parameter_Name[22] = "ARG_EFFIC";
                MyOraDB.Parameter_Name[23] = "ARG_YIELD_FLD";
                MyOraDB.Parameter_Name[24] = "ARG_YIELD_UNIT";
                MyOraDB.Parameter_Name[25] = "ARG_YIELD_PAIR";
                MyOraDB.Parameter_Name[26] = "ARG_W_L";
                MyOraDB.Parameter_Name[27] = "ARG_WEIGHT";
                MyOraDB.Parameter_Name[28] = "ARG_LENGTH";
                MyOraDB.Parameter_Name[29] = "ARG_MARGIN_L";
                MyOraDB.Parameter_Name[30] = "ARG_MARGIN_L_UNIT";
                MyOraDB.Parameter_Name[31] = "ARG_MARGIN_R";
                MyOraDB.Parameter_Name[32] = "ARG_MARGIN_R_UNIT";
                MyOraDB.Parameter_Name[33] = "ARG_UPD_USER";

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
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[27] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[28] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[29] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[30] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[31] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[32] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[33] = (int)OracleType.VarChar;

                //04.DATA 정의
                int iIdx = 0;
                for (int iRow1 = fgrid_cbdPart.Rows.Fixed; iRow1 < fgrid_cbdPart.Rows.Count; iRow1++)
                {
                    if (fgrid_cbdPart.Rows[iRow1].Node.Level == 1)
                    {
                        if (fgrid_cbdPart[iRow1, 0] != null && !fgrid_cbdPart[iRow1, 0].ToString().Equals(""))
                            iIdx += MyOraDB.Parameter_Name.Length;
                    }
                }
                MyOraDB.Parameter_Values = new string[iIdx];

                iIdx = 0;
                for (int iRow2 = fgrid_cbdPart.Rows.Fixed; iRow2 < fgrid_cbdPart.Rows.Count; iRow2++)
                {
                    if (fgrid_cbdPart.Rows[iRow2].Node.Level == 1)
                    {
                        if (fgrid_cbdPart[iRow2, 0] != null && !fgrid_cbdPart[iRow2, 0].ToString().Equals(""))
                        {
                            // Head
                            int iParentRow2 = fgrid_cbdPart.Rows[iRow2].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;

                            MyOraDB.Parameter_Values[iIdx++] = fgrid_cbdPart[iRow2, 0].ToString();
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxLEV]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxDEV_FAC]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPROD_FAC]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxMOID]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxCBD_ID]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxCBD_VER]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxFOB_TYPE_CD]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxCBD_NO]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iRow2, (int)ClassLib.TBSFM_CBD_PART.IxPTN_SEQ]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPART_NO]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPART_TYPE]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPART_CLASS]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPART_SEQ]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPART_NAME]);
                            MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iParentRow2, (int)ClassLib.TBSFM_CBD_PART.IxPTTN_CNT]);

                            // Tail
                            for (int iCol2 = (int)ClassLib.TBSFM_CBD_PART.IxID_STYLE_PATTERN; iCol2 < fgrid_cbdPart.Cols.Count - 1; iCol2++)
                            {
                                MyOraDB.Parameter_Values[iIdx++] = NullToString(fgrid_cbdPart[iRow2, iCol2]);
                            }
                        }
                    }
                }

                MyOraDB.Add_Modify_Parameter(true);
                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string NullToString(object arg_obs)
        {
            return arg_obs == null ? "" : arg_obs.ToString();
        }        

        #endregion

        #endregion

    }
}

