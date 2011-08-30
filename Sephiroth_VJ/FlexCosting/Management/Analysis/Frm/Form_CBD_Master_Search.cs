using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Analysis.Frm
{
    public partial class Form_CBD_Master_Search : COM.PCHWinForm.Form_Top
    {
        #region Constructor

        public Form_CBD_Master_Search()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion

        #region Extrn variable

        private bool _isVisibleDetail = true;
        private COM.OraDB MyOraDB = new COM.OraDB();
        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();

        private System.Threading.Thread vThExcel = null;
        private FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220.ExcelExport vExp2 = null;

        #endregion

        #region Event

        #region Toolbar

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

                ClearAll();
                SearchHeadList();
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
                ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion 

        #region Grid 

        private void fgrid_head_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                SelectCBD();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CBD Summary double click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Control

        private void cmb_ProdFac_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetSeason();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Season_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetObsID();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_DPO_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txt_SearchText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    ClearAll();
                    SearchHeadList();
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
                }
                catch (Exception ex)
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
                    ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        #endregion

        #endregion

        #region Event handler

        #region Init

        /// <summary>
        /// init form
        /// </summary>
        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = "CBD Search";
                this.lbl_MainTitle.Text = "CBD Search";

                Init_Grid();
                Init_Control();
                Init_Toolbar();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// init grid
        /// </summary>
        private void Init_Grid()
        {
            fgrid_head.Set_Grid("SFX_CBD_HEAD", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_head.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_head.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_head.Font = new Font(fgrid_head.Font.FontFamily, (float)8.5);
            fgrid_head.ExtendLastCol = false;
            fgrid_head.AllowEditing = false;

            fgrid_upper.Set_Grid("SFX_CBD_TAIL_UP_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_upper);
            fgrid_upper.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
            fgrid_upper.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;

            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";
        }

        /// <summary>
        /// grid design setting 
        /// </summary>
        /// <param name="arg_grid">Grid</param>
        /// <param name="arg_Imgmap">Imagelist</param>
        private void SetGridDesign(COM.FSP arg_grid)
        {
            arg_grid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            arg_grid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            arg_grid.Font = new Font(arg_grid.Font.FontFamily, (float)8.5);
            arg_grid.Rows[fgrid_upper.Rows.Fixed - 2].Style.WordWrap = true;
            arg_grid.ExtendLastCol = false;
            arg_grid.AllowEditing = false;
            for (int iCol = 1; iCol < arg_grid.Cols.Count; iCol++)
            {
                if (arg_grid.Cols[iCol].DataType == typeof(System.Double))
                {
                    arg_grid.Cols[iCol].Style.Format = "#,##0.00##";
                }
            }
        }

        /// <summary>
        /// init control
        /// </summary>
        private void Init_Control()
        {
            System.Data.DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            DataRow[] vDR = vDT.Select("FACTORY = 'DS'");
            if (vDR.Length == 1)
            {
                vDT.Rows.Remove(vDR[0]);
            }

            ClassLib.ComFunction.Set_ComboList(vDT, cmb_ProdFac, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();
            cmb_ProdFac.SelectedValue = ClassLib.ComVar.This_Factory.Equals("DS") ? "VJ" : ClassLib.ComVar.This_Factory;

            // FOB Type
            vDT = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "SFB_06");
            ClassLib.ComFunction.Set_ComboList(vDT, cmb_fobStatus, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();
            cmb_fobStatus.SelectedValue = "Y0000";
        }

        private void SetSeason()
        {
            System.Data.DataTable dt_ret = SelectSeason();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Season, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_Season.SelectedIndex = 0;

            dt_ret.Dispose();
        }
        private void SetObsID()
        {
            if (cmb_Season.SelectedValue == null)
                return;

            System.Data.DataTable dt_ret = SelectObsID();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_DPO, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_DPO.SelectedIndex = 0;
            dt_ret.Dispose();
        }

        /// <summary>
        /// init toolbar
        /// </summary>
        private void Init_Toolbar()
        {
        }


        private void ClearAll()
        {
            fgrid_head.ClearAll();
            ClearDetail();
        }

        private void ClearDetail()
        {
            // Detail
            fgrid_upper.ClearAll();
        }

        #endregion

        #region Search 

        private bool SearchHeadList()
        {
            string sProdFac = COM.ComFunction.Empty_Combo(cmb_ProdFac, ""); ;
            string sSeason = COM.ComFunction.Empty_Combo(cmb_Season, "");
            string sOBSID = COM.ComFunction.Empty_Combo(cmb_DPO, "");
            string sOBSType = "";
            string sFOBType = COM.ComFunction.Empty_Combo(cmb_fobStatus, "");
            txt_MOID.Text = txt_MOID.Text.ToUpper();
            string sMOID = COM.ComFunction.Empty_TextBox(txt_MOID, "").Replace("-", "");
            string sBOMID = COM.ComFunction.Empty_TextBox(txt_BOMID, "");

            DataTable vDT = SELECT_SFX_CBD_HEAD_LIST(sProdFac, sSeason, sOBSID, sOBSType, sFOBType, sMOID, sBOMID);
            
            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_head.Display_Grid(vDT, true);
                return true;
            }

            return false;
        }

        private void SelectCBD()
        {
            try
            {
                if (fgrid_head.Rows.Count <= fgrid_head.Rows.Fixed)
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
                    return;
                }

                ClearDetail();

                if (SearchHead())
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
                }
                else
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select CBD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SearchHead()
        {
            int vRow = fgrid_head.Row;

            // arg_factory, arg_moid, arg_cbd_id, arg_cbd_seq, arg_fob_type_cd
            string sDevFac = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxDEV_FAC].ToString();
            string sProdFac = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxPROD_FAC].ToString();
            string sMOID = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxMOID].ToString();
            string sCBDID = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_ID].ToString();
            string sCBDVer = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_SEQ].ToString();
            string sFOBType = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxFOB_TYPE_CD].ToString();

            // Header 
            DataTable vDTH = _ComFnc.SELECT_SFX_CBD_HEAD(sDevFac, sMOID, sCBDID, sCBDVer, sFOBType);

            if (vDTH != null && vDTH.Rows.Count == 1)
            {
                // Summary 보일 필요성이 없다면 이 function 자재를 삭제하고 detail 만 조회하면 됨. 
                vDTH.Dispose();
                return SearchDetail();
            }
            else
            {
                return false;
            }
        }

        private bool SearchDetail()
        {
            try
            {
                int vRow = fgrid_head.Row;

                // arg_factory, arg_moid, arg_cbd_id, arg_cbd_seq, arg_fob_type_cd
                string sDevFac = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxDEV_FAC].ToString();
                string sProdFac = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxPROD_FAC].ToString();
                string sMOID = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxMOID].ToString();
                string sCBDID = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_ID].ToString();
                string sCBDVer = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_SEQ].ToString();
                string sFOBType = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxFOB_TYPE_CD].ToString();

                // Detail 
                string[] procs = new string[] { "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL" };

                DataSet vDST = _ComFnc.SELECT_SFX_CBD_TAIL(procs, sDevFac, sMOID, sCBDID, sCBDVer, sFOBType);
                LoadCBDDetail(vDST);
                vDST.Dispose();

                return true;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select CBD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LoadCBDDetail(DataSet vDS)
        {
            ClearDetail();

            DataTable vOrgDT = vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL"];
            DataTable vUPDT = null, vPKDT = null, vMSDT = null, vOSDT = null;

            if (vOrgDT != null && vOrgDT.Rows.Count > 0)
            {
                vUPDT = new DataTable("UPPER");
                vPKDT = new DataTable("PACKAGING");
                vMSDT = new DataTable("MIDSOLE");
                vOSDT = new DataTable("OUTSOLE");

                for (int icidx = 0; icidx < vOrgDT.Columns.Count; icidx++)
                {
                    vUPDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vPKDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vMSDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vOSDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                }

                for (int iridx = 0; iridx < vOrgDT.Rows.Count; iridx++)
                {
                    string sCBDClass = vOrgDT.Rows[iridx]["DIV"].ToString();

                    if (sCBDClass.Equals("MIDSOLE"))
                    {
                        vMSDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else if (sCBDClass.Equals("OUTSOLE"))
                    {
                        vOSDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else if (sCBDClass.Equals("PACKAGING"))
                    {
                        vPKDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else
                    {
                        vUPDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                }
            }

            DisplayCBDDetail(vUPDT, fgrid_upper);
        }

        private void DisplayCBDDetail(DataTable vDT, COM.FSP grid)
        {
            grid.ClearAll();

            int iRefCol = FindCol(grid, "REF");
            int iSingleYNCol = FindCol(grid, "SINGLE_YN");

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    C1.Win.C1FlexGrid.Row row = grid.AddItem(vDT.Rows[i].ItemArray, grid.Rows.Count, 1);

                    if (iRefCol > 0)
                    {
                        string sRef = row[iRefCol] == null ? "" : row[iRefCol].ToString();
                        C1.Win.C1FlexGrid.CellRange vRange = grid.GetCellRange(row.Index, iRefCol);
                        vRange.UserData = sRef;

                        if (sRef.Equals("D"))
                        {
                            row.StyleNew.ForeColor = Color.Red;
                        }
                        else if (sRef.Equals("A"))
                        {
                            row.StyleNew.ForeColor = Color.Green;
                        }
                        else if (sRef.Equals("U"))
                        {
                            row.StyleNew.BackColor = Color.Yellow;
                        }
                        else
                        {
                            if (iSingleYNCol > 0)
                            {
                                string sSingleYN = row[iSingleYNCol] == null ? "" : row[iSingleYNCol].ToString();
                                if (sSingleYN.Equals("Y"))
                                    row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Italic);

                            }
                            else
                            {
                                row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Regular);
                                row.StyleNew.ForeColor = Color.Black;
                            }
                        }
                    }
                }

                vDT.Dispose();
            }
        }

        #endregion        

        #region Function

        private int FindCol(COM.FSP arg_fsp, string col_name)
        {
            int iFindCol = -1;

            for (int ICol = 1; ICol < arg_fsp.Cols.Count; ICol++)
            {
                if (arg_fsp[0, ICol].ToString().Equals(col_name))
                    iFindCol = ICol;
            }

            return iFindCol;
        }

        #endregion

        #endregion

        #region Database

        #region Search condition

        private System.Data.DataTable SelectSeason()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_ANALYSIS.SELECT_EBM_SEASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_ProdFac.SelectedValue.ToString();
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

        private System.Data.DataTable SelectObsID()
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_ANALYSIS.SELECT_EBM_OBS_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_ProdFac.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = cmb_Season.SelectedValue.ToString();
                MyOraDB.Parameter_Values[2] = "";

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

        #endregion

        #region Search

        /// <summary>
        /// PKG_SFX_CBD_ANALYSIS.SELECT_SFX_CBD_HEAD_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_HEAD_LIST(string arg_prod_fac, string arg_season_cd, string arg_obs_id, string arg_obs_type, string arg_fob_type, string arg_moid, string arg_bom_id)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_ANALYSIS.SELECT_SFX_CBD_HEAD_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE";
                MyOraDB.Parameter_Name[5] = "ARG_MOID";
                MyOraDB.Parameter_Name[6] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_prod_fac;
                MyOraDB.Parameter_Values[1] = arg_season_cd;
                MyOraDB.Parameter_Values[2] = arg_obs_id;
                MyOraDB.Parameter_Values[3] = arg_obs_type;
                MyOraDB.Parameter_Values[4] = arg_fob_type;
                MyOraDB.Parameter_Values[5] = arg_moid;
                MyOraDB.Parameter_Values[6] = arg_bom_id;
                MyOraDB.Parameter_Values[7] = "";

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

        #endregion;

        #region MEF, 5523

        /// <summary>
        /// PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_REGION : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_DETAIL_REGION(
            string arg_factory, string arg_style_cd,
            string arg_mo_alias, string arg_bom_id, string arg_fob_type)
        {
            try
            {

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_REGION";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
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
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_mo_alias;
                MyOraDB.Parameter_Values[3] = arg_fob_type;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_HEAD : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_MEOF_HEAD(string arg_factory, string arg_moid)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_SIZE : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_MEOF_SIZE(string arg_factory, string arg_moid, string arg_mold_cd, string arg_pim_seq)
        {
            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_SIZE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_MOLD_CD";
                MyOraDB.Parameter_Name[3] = "ARG_PIM_SEQ";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_mold_cd;
                MyOraDB.Parameter_Values[3] = arg_pim_seq;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string mrd_Filename = Application.StartupPath + @"\\Report\Costing\rd_CBD_Search.mrd";

            int vRow = fgrid_head.Selection.r1;

            string sDevFac = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxDEV_FAC].ToString();
            string sMOID = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxMOID].ToString().Replace("-", "");
            string sCBDID = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_ID].ToString();
            string sCBDVer = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_SEQ].ToString();
            string sFOBType = fgrid_head[vRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxFOB_TYPE_CD].ToString();

            string sPara = " /rpaper [A4] /rp " + "[" + sDevFac + "]" + " [" + sMOID + "]" + " [" + sCBDID + "]" + " [" + sCBDVer + "]" + " [" + sFOBType + "]";

            FlexCosting.Report.Form_RdViewer report = new FlexCosting.Report.Form_RdViewer(mrd_Filename, sPara);
            report.ShowDialog(); 
        }

        #endregion
    }
}

