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
    public partial class Form_CBD_Master_Search_FullCBD : COM.PCHWinForm.Form_Top
    {
        #region Constructor

        public Form_CBD_Master_Search_FullCBD()
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

        #region Excel export

        private void ctxt_exl_Click(object sender, EventArgs e)
        {
            if (fgrid_head.Selections.Length > 0)
            {
                if (vThExcel == null || !vThExcel.IsAlive)
                {
                    ExportExcel();
                }
            }
        }

        private void ExportExcel()
        {
            vExp2 = new FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220.ExcelExport();
            vExp2.sFilePath = Application.StartupPath + "\\";

            System.Collections.ArrayList vArr = new System.Collections.ArrayList();

            int iIdx = 0;
            foreach (int iRow in fgrid_head.Selections)
            {
                if (iIdx < 20)
                {
                    string sDevFac = fgrid_head[iRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxDEV_FAC].ToString();
                    string sMOID = fgrid_head[iRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxMOID].ToString().Replace("-", "");
                    string sCBDID = fgrid_head[iRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_ID].ToString();
                    string sCBDVer = fgrid_head[iRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxCBD_SEQ].ToString();
                    string sFobType = fgrid_head[iRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxFOB_TYPE_CD].ToString();
                    string sSeasonCode = fgrid_head[iRow, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxSEASON_NAME].ToString();

                    string[] sKeys = new string[] { sDevFac, sMOID, sCBDID, sCBDVer, sFobType, sSeasonCode };
                    vArr.Add(sKeys);
                    iIdx++;
                }
            }

            vExp2.vKeys = vArr;

            vThExcel = new System.Threading.Thread(new System.Threading.ThreadStart(vExp2.OpenFile));
            vThExcel.IsBackground = true;
            vThExcel.Start();

            timer_excel.Start();
        }

        private void timer_Excel_Tick(object sender, EventArgs e)
        {
            try
            {
                if (vThExcel != null)
                {
                    if (vThExcel.IsAlive)
                    {
                        if (vExp2.TOTAL_COUNT > 0)
                            lbl_status.Text = vExp2.CURRENT_STATUS + " (" + (int)(((double)vExp2.CURRENT_COUNT / (double)vExp2.TOTAL_COUNT) * 100) + "%)";
                    }
                    else
                    {
                        timer_excel.Stop();
                        lbl_status.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                // timer exception 
            }
        }

        #endregion

        #region MEOF, 5523

        private void tab_detail_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    if (_isVisibleDetail)
                    {
                        sizer_Main.Grid.Rows[1].Size = (int)(sizer_Main.Height * 0.50);
                        _isVisibleDetail = false;
                    }
                    else
                    {
                        sizer_Main.Grid.Rows[1].Size = (int)(sizer_Main.Height * 0.20);
                        _isVisibleDetail = true;
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if (tab_detail.SelectedTab.Name.Equals("tabPage10"))
                    {
                        Display5523();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            fgrid_head.Set_Grid("SFX_CBD_HEAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_head.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_head.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_head.Font = new Font(fgrid_head.Font.FontFamily, (float)8.5);
            fgrid_head.ExtendLastCol = false;
            fgrid_head.AllowEditing = false;

            fgrid_upper.Set_Grid("SFX_CBD_TAIL_UP_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_upper);
            fgrid_upper.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
            fgrid_upper.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].Visible = false;
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


            fgrid_packaging.Set_Grid("SFX_CBD_TAIL_PK_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_packaging);
            fgrid_packaging.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME;
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].Visible = false;
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].Visible = false;
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;
            fgrid_packaging.GetCellRange(
                fgrid_packaging.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_packaging.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_packaging.GetCellRange(
                fgrid_packaging.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_packaging.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_midsole.Set_Grid("SFX_CBD_TAIL_MS_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_midsole);
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].Visible = false;
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].Visible = false;
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;

            fgrid_midsole.GetCellRange(
                fgrid_midsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_midsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_midsole.GetCellRange(
                fgrid_midsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_midsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_outsole.Set_Grid("SFX_CBD_TAIL_OS_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_outsole);
            fgrid_outsole.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].Visible = false;
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].Visible = false;
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;

            fgrid_outsole.GetCellRange(
                fgrid_outsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_outsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_outsole.GetCellRange(
                fgrid_outsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_outsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_labor.Set_Grid("SFX_CBD_TAIL_LB_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_labor);
            fgrid_labor.GetCellRange(
                fgrid_labor.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD,
                fgrid_labor.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD).StyleNew.BackColor = Color.OrangeRed;
            fgrid_labor.Cols[(int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD].StyleNew.BackColor = Color.Yellow;
            fgrid_labor.Cols[(int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD].Style.Format = "#,##0.00";


            fgrid_overhead.Set_Grid("SFX_CBD_TAIL_OH_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_overhead);
            fgrid_overhead.Cols[(int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD].StyleNew.BackColor = Color.Yellow;
            fgrid_overhead.GetCellRange(
                fgrid_overhead.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD,
                fgrid_overhead.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD).StyleNew.BackColor = Color.OrangeRed;
            fgrid_overhead.Cols[(int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD].Style.Format = "#,##0.00";


            fgrid_sampMold.Set_Grid("SFX_CBD_TAIL_MOLD_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_sampMold);
            fgrid_sampMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR].StyleNew.BackColor = Color.Yellow;
            fgrid_sampMold.GetCellRange(
                fgrid_sampMold.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR,
                fgrid_sampMold.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR).StyleNew.BackColor = Color.OrangeRed;
            fgrid_sampMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST_USD].Style.Format = "#,##0.00";


            fgrid_prodMold.Set_Grid("SFX_CBD_TAIL_MOLD_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_prodMold);
            fgrid_prodMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR].StyleNew.BackColor = Color.Yellow;
            fgrid_prodMold.GetCellRange(
                fgrid_prodMold.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR,
                fgrid_prodMold.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR).StyleNew.BackColor = Color.OrangeRed;
            fgrid_prodMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST_USD].Style.Format = "#,##0.00";

            fgrid_5523.Set_Grid("EBM_FOB_5523_TAIL", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_5523.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_5523.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_5523.Font = new Font(fgrid_5523.Font.FontFamily, (float)8.5);
            fgrid_5523.ExtendLastCol = false;
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
            tbtn_New.Enabled = true;
            tbtn_Search.Enabled = true;
            tbtn_Save.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Confirm.Enabled = false;
        }


        private void ClearAll()
        {
            fgrid_head.ClearAll();
            ClearHead();
            ClearDetail();
        }

        private void ClearHead()
        {
            foreach (Control ctl in pnl_CBDDetailSummary.Controls)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Text = "";
                }
                else if (ctl is C1.Win.C1List.C1Combo)
                {
                    (ctl as C1.Win.C1List.C1Combo).SelectedIndex = -1;
                }
                else if (ctl is DateTimePicker)
                {
                    (ctl as DateTimePicker).Value = DateTime.Now;
                }
            }

            txt_hOVERHEAD_CMT.Text = "";
            txt_hLABOR_CMT.Text = "";
        }

        private void ClearDetail()
        {
            // Detail
            fgrid_upper.ClearAll();
            fgrid_packaging.ClearAll();
            fgrid_midsole.ClearAll();
            fgrid_outsole.ClearAll();
            fgrid_labor.ClearAll();
            fgrid_overhead.ClearAll();
            fgrid_sampMold.ClearAll();
            fgrid_prodMold.ClearAll();

            // 5523
            fgrid_5523.ClearAll();
            fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
            txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
            txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
            txt_date_5523.Text = "";
            txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
            txt_other_5523.Text = "";
        }

        #endregion

        #region Search 

        private bool SearchHeadList()
        {
            string sProdFac = COM.ComFunction.Empty_Combo(cmb_ProdFac, ""); ;
            string sSeason = COM.ComFunction.Empty_Combo(cmb_Season, "");
            string sOBSID = COM.ComFunction.Empty_Combo(cmb_DPO, "");
            string sOBSType = "";
            txt_MOID.Text = txt_MOID.Text.ToUpper();
            string sMOID = COM.ComFunction.Empty_TextBox(txt_MOID, "").Replace("-", "");
            string sBOMID = COM.ComFunction.Empty_TextBox(txt_BOMID, "");

            DataTable vDT = SELECT_SFX_CBD_HEAD_LIST(sProdFac, sSeason, sOBSID, sOBSType, sMOID, sBOMID);
            
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

                ClearHead();
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
                DisplayCBDHead(vDTH);
                vDTH.Dispose();

                return SearchDetail();
            }
            else
            {
                return false;
            }
        }

        private void DisplayCBDHead(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count == 1)
            {
                for (int iCIdx = 0; iCIdx < vDT.Rows[0].ItemArray.Length; iCIdx++)
                {
                    string sColName = vDT.Columns[iCIdx].ColumnName;

                    if (pnl_CBDDetailSummary.Controls["txt_h" + sColName] != null)
                    {
                        TextBox vTxt = pnl_CBDDetailSummary.Controls["txt_h" + sColName] as TextBox;
                        vTxt.Text = vDT.Rows[0][iCIdx].ToString();
                    }
                }

                txt_hOVERHEAD_CMT.Text = (vDT.Rows[0]["OVERHEAD_CMT"] == null ? "" : vDT.Rows[0]["OVERHEAD_CMT"].ToString());
                txt_hLABOR_CMT.Text = vDT.Rows[0]["LABOR_CMT"] == null ? "" : vDT.Rows[0]["LABOR_CMT"].ToString();
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
                string[] procs = new string[] {
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_LB",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_OH",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_SM",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_PM", };

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
            DisplayCBDDetail(vPKDT, fgrid_packaging);
            DisplayCBDDetail(vMSDT, fgrid_midsole);
            DisplayCBDDetail(vOSDT, fgrid_outsole);

            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_LB"], fgrid_labor);
            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_OH"], fgrid_overhead);
            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_SM"], fgrid_sampMold);
            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_PM"], fgrid_prodMold);

            Display5523();
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
                    if (!grid.Name.Equals(fgrid_labor.Name) && !grid.Name.Equals(fgrid_overhead.Name))
                    {
                        row.IsNode = true;
                        row.Node.Level = 0;
                        row.StyleNew.BackColor = Color.White;
                        row.AllowEditing = true;
                    }

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

        private void Display5523()
        {
            if (fgrid_head.Rows.Count > fgrid_head.Rows.Fixed && fgrid_head.Row >= fgrid_head.Rows.Fixed)
            {
                fgrid_5523.ClearAll();
                fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
                txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
                txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
                txt_date_5523.Text = "";
                txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
                txt_other_5523.Text = "";

                string sSFactory = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxPROD_FAC].ToString();
                string sSRegion = ClassLib.ComFunction.Empty_Combo(cmb_region, "");
                string sSStyle = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxSTYLE_CD].ToString().Replace("-", "").Trim();

                if (!sSFactory.Equals("") && !sSRegion.Equals(""))
                {
                    string sSMOID = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxSTYLE_CD].ToString().Replace("-", "").Trim();
                    string sSSeason = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxSEASON_CD].ToString();
                    string sSBOMID = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxBOM_ID].ToString();
                    string sSRound = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxFOB_TYPE].ToString();

                    System.Data.DataTable vDT = _ComFnc.SELECT_EBM_FOB_5523(sSFactory, null, sSStyle, sSRegion, sSMOID, sSBOMID, sSRound, sSSeason);

                    if (vDT != null && vDT.Rows.Count > 0)
                    {
                        string sTBOM = "";
                        string sTStyle = "";

                        for (int i = 0; i < vDT.Rows.Count; i++)
                        {
                            // Set header
                            if (i == 0)
                            {
                                txt_prodCode_5523.Text = vDT.Rows[i]["product_code"].ToString();
                                txt_devCode_5523.Text = vDT.Rows[i]["dev_code"].ToString();
                                txt_prodName_5523.Text = vDT.Rows[i]["product_name"].ToString();
                                txt_prodType_5523.Text = vDT.Rows[i]["product_type"].ToString();
                                txt_factory_5523.Text = vDT.Rows[i]["factory"].ToString();
                                txt_season_5523.Text = vDT.Rows[i]["season_cd"].ToString();
                                txt_date_5523.Text = vDT.Rows[i]["app_ymd"].ToString();

                                txt_leather_5523.Text = vDT.Rows[i]["leather_pct"].ToString();
                                txt_synthetic_5523.Text = vDT.Rows[i]["synthetic_pct"].ToString();
                                txt_textile_5523.Text = vDT.Rows[i]["textile_pct"].ToString();
                                txt_other_5523.Text = vDT.Rows[i]["other_pct"].ToString();

                                string sBOM = vDT.Rows[i]["bom_id"].ToString();
                                string sStyle = vDT.Rows[i]["style_cd"].ToString();

                                C1.Win.C1FlexGrid.Column col = fgrid_5523.Cols.Add();
                                col.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                                col[fgrid_5523.Rows.Fixed - 1] = sStyle;
                                col[fgrid_5523.Rows.Fixed - 2] = sBOM;

                                for (int ii = i; ii < vDT.Rows.Count; ii++, i++)
                                {
                                    sTBOM = vDT.Rows[ii]["bom_id"].ToString();
                                    sTStyle = vDT.Rows[ii]["style_cd"].ToString();
                                    if (!sBOM.Equals(sTBOM) && !sStyle.Equals(sTStyle))
                                    {
                                        i = ii;
                                        break;
                                    }

                                    C1.Win.C1FlexGrid.Row row = fgrid_5523.Rows.Add();
                                    row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxSEQ] = vDT.Rows[ii]["component_seq"];
                                    row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_DIV] = vDT.Rows[ii]["component_div"];
                                    row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_NAME] = vDT.Rows[ii]["components"];
                                    row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = vDT.Rows[ii]["measurement"];
                                    row[col.Index] = vDT.Rows[ii]["material_style"];
                                }
                            }
                            else
                            {
                                int iRow = fgrid_5523.Rows.Fixed;
                                string sBOM2 = vDT.Rows[i]["bom_id"].ToString();
                                string sStyle2 = vDT.Rows[i]["style_cd"].ToString();

                                C1.Win.C1FlexGrid.Column col2 = fgrid_5523.Cols.Add();
                                col2[fgrid_5523.Rows.Fixed - 1] = sStyle2;
                                col2[fgrid_5523.Rows.Fixed - 2] = sBOM2;

                                for (int ii = i; ii < vDT.Rows.Count; ii++)
                                {
                                    sTBOM = vDT.Rows[ii]["bom_id"].ToString();
                                    sTStyle = vDT.Rows[ii]["style_cd"].ToString();
                                    if (sBOM2.Equals(sTBOM) && sStyle2.Equals(sTStyle))
                                    {
                                        i = ii;
                                        break;
                                    }

                                    fgrid_5523[iRow, (int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = vDT.Rows[ii]["measurement"];
                                    fgrid_5523[iRow, col2.Index] = vDT.Rows[ii]["material_style"];
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DisplayMEOFHead(COM.FSP fgrid_meof_head, COM.FSP fgrid_meof_size, string sFactory, string sMOID)
        {
            try
            {
                fgrid_meof_head.ClearAll();
                fgrid_meof_size.ClearAll();

                System.Data.DataTable vDDT = SELECT_EBM_FOB_MEOF_HEAD(sFactory, sMOID);
                System.Data.DataTable vHDT = MyOraDB.Select_GridHead("EBM_FOB_MEOF_HEAD", "4");

                if (vDDT != null && vHDT != null)
                {
                    for (int iDIdx = 0; iDIdx < vDDT.Rows.Count; iDIdx++)
                    {
                        for (int iDCol = 0, iHIdx = 0; iDCol < vDDT.Rows[iDIdx].ItemArray.Length; iDCol++, iHIdx++)
                        {
                            C1.Win.C1FlexGrid.Row newRow = fgrid_meof_head.Rows.Add();
                            newRow[1] = vHDT.Rows[iHIdx]["head_desc1"];
                            newRow[2] = vDDT.Rows[iDIdx][iDCol];

                            newRow.IsNode = true;

                            if (iDCol == 0)
                            {
                                newRow.Node.Level = 0;
                                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                            }
                            else
                            {
                                newRow.Node.Level = 1;
                                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                            }
                        }
                    }

                    fgrid_meof_head.Tree.Column = 1;
                    fgrid_meof_head.Tree.Show(0);
                    fgrid_meof_head.ExtendLastCol = true;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMEOFSize(COM.FSP fgrid_meof_head, COM.FSP fgrid_meof_size)
        {
            try
            {
                if (fgrid_meof_head.Rows.Fixed < fgrid_meof_head.Rows.Count &&
                    fgrid_meof_head.Row >= fgrid_meof_head.Rows.Fixed)
                {
                    fgrid_meof_size.ClearAll();

                    string sFactory = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxPROD_FAC].ToString();
                    string sMOID = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFX_CBD_HEAD_LIST.IxMOID].ToString().Replace("-", "");

                    int iPRow = fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.Row.Index;
                    if (fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.Level > 0)
                        iPRow = fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;

                    string sMoldCD = fgrid_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxMOLD_CD + (iPRow - 1), 2].ToString();
                    string sPIMSeq = fgrid_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxPIM_SEQ + (iPRow - 1), 2].ToString();

                    DataTable vDT = SELECT_EBM_FOB_MEOF_SIZE(sFactory, sMOID, sMoldCD, sPIMSeq);

                    if (vDT != null && vDT.Rows.Count > 0)
                    {
                        fgrid_meof_size.Display_Grid(vDT, false);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF size", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataTable SELECT_SFX_CBD_HEAD_LIST(string arg_prod_fac, string arg_season_cd, string arg_obs_id, string arg_obs_type, string arg_moid, string arg_bom_id)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_ANALYSIS.SELECT_SFX_CBD_HEAD_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_MOID";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_prod_fac;
                MyOraDB.Parameter_Values[1] = arg_season_cd;
                MyOraDB.Parameter_Values[2] = arg_obs_id;
                MyOraDB.Parameter_Values[3] = arg_obs_type;
                MyOraDB.Parameter_Values[4] = arg_moid;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = "";

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

        #endregion
    }
}

