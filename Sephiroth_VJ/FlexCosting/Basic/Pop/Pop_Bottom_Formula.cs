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

namespace FlexCosting.Basic.Pop
{
    public partial class Pop_Bottom_Formula : COM.PCHWinForm.Form_Top
    {
        public Pop_Bottom_Formula()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private COM.OraDB MyOraDB = new COM.OraDB();
        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();

        private ArrayList _TailList = new ArrayList();
        private DataTable _DTBase = null;
        private DataTable _DTTailCol = null;


        #endregion

        #region 이벤트 핸들러

        #region 툴바 이벤트

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {

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
                SearchHead();
                SearchTail();

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
                //this.Cursor = Cursors.WaitCursor;

                //if (!ValidationHeadInfo) return;

                //if (Save())
                //{
                //    ClearAll();
                //    SearchHead();
                //    SearchTail();

                //    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
                //}
                //else
                //{
                //    COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
                //}
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

        //private void fgrid_tail_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        //{
        //    if (fgrid_tail.Rows[e.Row].Node.Level == 0)
        //    {
        //        e.Cancel = true;
        //        return;
        //    }

        //    if (e.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCMP_CD)
        //    {
        //        if (fgrid_tail[e.Row, 0] == null || !fgrid_tail[e.Row, 0].ToString().Equals("I"))
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }

        //    if (fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPDPB_ACT_PCT)
        //    {
        //        string sFClass = fgrid_tail[e.Row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS].ToString();
        //        if (!sFClass.Equals("20"))
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }

        //    GridBeforeEdit();
        //}


        //private void fgrid_tail_AfterEdit(object sender, RowColEventArgs e)
        //{
        //    GridAfterEdit();
        //}

        //private void ctx_tail_Opening(object sender, CancelEventArgs e)
        //{
        //    fgrid_tail.Select(fgrid_tail.MouseRow, fgrid_tail.MouseCol);
        //}

        //private void ctxt_addMat_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddBottomMaterial();
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Add bottom material", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void ctxt_removeMat_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        RemoveBottomMaterial();
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Add bottom material", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        #endregion

        #region 버튼 및 기타 이벤트

        private string _TxtBuf = "";

        private void textbox_BeforeEdit(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            _TxtBuf = tb.Text;
        }

        private void textbox_AfterEdit(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox tb = sender as TextBox;

                double dTmp = 0;
                if (!double.TryParse(tb.Text.Replace(",", ""), out dTmp))
                    tb.Text = _TxtBuf;

                CalcTargetWTBatch();
                CalcMultipliplierFactory();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Textbox after edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_PrimaryKeyChenged(object sender, EventArgs e)
        {
            for (int iRow = fgrid_tail.Rows.Fixed; iRow < fgrid_tail.Rows.Count; iRow++)
            {
                if (fgrid_tail.Rows[iRow].Node.Level == 1)
                {
                    fgrid_tail[iRow, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxMCS_NO] = txt_mcsNo.Text;
                    fgrid_tail[iRow, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCOLOR_CD] = txt_colorCd.Text;
                }
            }
        }

        public new DialogResult ShowDialog()
        {
            try
            {
                

                ClearAll();
                SearchHead();
                SearchTail();

                base.ShowDialog();
                return DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Show Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
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
                this.Text = "Standard Bottom Formula";
                this.lbl_MainTitle.Text = "Standard Bottom Formula";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                Init_Control();
                Init_Toolbar();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            fgrid_tail.Set_Grid("SFB_CBD_B_FORMU_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_tail.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_tail.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_tail.Set_Action_Image(img_Action);
            fgrid_tail.ExtendLastCol = false;

            _DTBase = new DataTable();
            for (int col = 1; col < fgrid_tail.Cols.Count; col++)
            {
                _DTBase.Columns.Add(fgrid_tail[0, col].ToString());
            }

            _DTTailCol = this.MyOraDB.Select_GridHead("SFB_CBD_B_FORMU_TAIL", "2");
            ClearTail();
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_prodFac2, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_prodFac2.SelectedValue = ClassLib.ComVar.This_Factory;
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_prodFac2, ClassLib.ComVar.This_Factory), "SFB_20");
            COM.ComCtl.Set_ComboList(vDT, cmb_div2, 1, 2, false);
            cmb_div2.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_prodFac2, ClassLib.ComVar.This_Factory), "SFB_09");
            COM.ComCtl.Set_ComboList(vDT, cmb_stdColType, 1, 2, false);
            cmb_stdColType.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_prodFac2, ClassLib.ComVar.This_Factory), "SFB_11");
            COM.ComCtl.Set_ComboList(vDT, cmb_bttmType2, 1, 2, false);
            cmb_bttmType2.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_prodFac2, ClassLib.ComVar.This_Factory), "SFB_21");
            COM.ComCtl.Set_ComboList(vDT, cmb_formulaType, 1, 2, false);
            cmb_formulaType.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_prodFac2, ClassLib.ComVar.This_Factory), "CM04");
            COM.ComCtl.Set_ComboList(vDT, cmb_useYN, 1, 2, false);
            cmb_useYN.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            HeadCtlReadonly(true);
        }

        private void Init_Toolbar()
        {
            tbtn_New.Enabled = false;
            tbtn_Search.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            ClearTail();
            ClearControl();
        }

        private void ClearTail()
        {
            fgrid_tail.ClearAll();

            int iClassName = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCLASS_NAME;
            int iFColor = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS;
            if (_DTTailCol != null && _DTTailCol.Rows.Count > 1)
            {
                for (int row = 0; row < _DTTailCol.Rows.Count; row++)
                {
                    string sHeadDesc1 = _DTTailCol.Rows[row]["HEAD_DESC1"].ToString();
                    string sHeadDesc2 = _DTTailCol.Rows[row]["HEAD_DESC2"].ToString();

                    Node vNewNode = fgrid_tail.Rows.InsertNode(fgrid_tail.Rows.Fixed + row, 0);
                    vNewNode.Row[iClassName] = sHeadDesc1;
                    vNewNode.Row[iFColor] = sHeadDesc2;

                    vNewNode.Row.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                }
            }

            fgrid_tail.Tree.Column = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCLASS_NAME;
        }

        private void ClearControl()
        {
            cmb_div2.SelectedIndex = 0;
            txt_material.Text = "";
            //txt_mcsNo.Text = "";
            //txt_colorCd.Text = "";
            txt_colorName.Text = "";
            cmb_stdColType.SelectedIndex = 0;
            txt_margin.Text = "";
            dpick_appDate.Value = System.DateTime.Now;
            cmb_useYN.SelectedIndex = 0;
            txt_remarks.Text = "";
            cmb_formulaType.SelectedIndex = 0;

            lbl_sv_pdpb_tot.Text = "";
            lbl_sv_polymer_tot.Text = "";
            lbl_sv_avg_sg.Text = "";
            lbl_sv_cost_kg.Text = "";
            txt_sv_mix_caps.Text = "";
            txt_sv_actual_sg.Text = "";
            txt_sv_desired_caps.Text = "";
            lbl_sv_target_wt.Text = "";
            lbl_sv_mult_fac.Text = "";
        }

        //private void Search()
        //{
        //    SearchTail();
        //}

        private bool SearchHead()
        {
            string sFactory = cmb_prodFac2.SelectedValue.ToString();
            string sColorCd = txt_colorCd.Text;
            string sMCSNo = txt_mcsNo.Text;

            DataTable vDTH = SELECT_SFB_CBD_B_FORMU_H(sFactory, sMCSNo, sColorCd);

            if (vDTH != null && vDTH.Rows.Count > 0)
            {
                // div2, bttmType, material, mcsNo, colorCd, colorName, stcColorType, margin, applidate, used, remarks, formulatype
                cmb_div2.SelectedValue = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxDIVISION];
                cmb_bttmType2.SelectedValue = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxBTTM_TYPE];
                txt_material.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxMATERIAL].ToString();
                txt_colorName.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxCOLOR_NAME].ToString();
                cmb_stdColType.SelectedValue = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxCOLOR_TYPE];
                string sMargin = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxCOLOR_MARGIN_PCT].ToString();
                txt_margin.Text = Convert.ToString((int)(Convert.ToDouble(sMargin) * 100));
                cmb_useYN.SelectedValue = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxUSE_YN];
                cmb_formulaType.SelectedValue = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxFORMULA_TYPE];
                txt_remarks.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxMCS_REMARK].ToString();

                try
                {
                    string sAppDate = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxAPP_DATE].ToString();
                    string sAppYear = sAppDate.Substring(0, 4);
                    string sAppMon = sAppDate.Substring(4, 2);
                    string sAppDay = sAppDate.Substring(6, 2);
                    dpick_appDate.Value = new DateTime(int.Parse(sAppYear), int.Parse(sAppMon), int.Parse(sAppDay));
                }
                catch
                {
                    dpick_appDate.Value = DateTime.Now;
                }
                
                lbl_sv_pdpb_tot.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxPDPB_TOT].ToString();
                lbl_sv_polymer_tot.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxPOLYMER_TOT].ToString();
                lbl_sv_avg_sg.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxSG_AVG].ToString();
                txt_sv_mix_caps.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxMIX_CAPA].ToString();
                txt_sv_actual_sg.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxSG_ACTUAL].ToString();
                txt_sv_desired_caps.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxUTIL_CAPA_PCT].ToString();
                lbl_sv_target_wt.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxTARGET_WT].ToString();
                lbl_sv_mult_fac.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxMUTI_FACTORY].ToString();
                lbl_sv_cost_kg.Text = vDTH.Rows[0][(int)ClassLib.TBSFB_CBD_B_FORMU_HEAD.IxCOST_KG].ToString();
            }

            return true;
        }

        private bool SearchTail()
        {
            string sFactory = cmb_prodFac2.SelectedValue.ToString();
            string sColorCd = txt_colorCd.Text;
            string sMCSNo = txt_mcsNo.Text;

            DataTable vTDT = SELECT_SFB_CBD_B_FORMU_T(sFactory, sMCSNo, sColorCd);

            ClearTail();

            if (vTDT != null && vTDT.Rows.Count > 0)
            {
                Node vPolymers = fgrid_tail.Rows[fgrid_tail.Rows.Fixed].Node;
                string sPolymers = fgrid_tail[vPolymers.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS].ToString();

                Node vNodePDPB = fgrid_tail.Rows[fgrid_tail.Rows.Fixed + 1].Node;
                string sPDPB = fgrid_tail[vNodePDPB.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS].ToString();

                Node vNodeNonPDPB = fgrid_tail.Rows[fgrid_tail.Rows.Fixed + 2].Node;
                string sNonPDPB = fgrid_tail[vNodeNonPDPB.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS].ToString();

                for (int idx = 0; idx < vTDT.Rows.Count; idx++)
                {
                    Row newRow = null;

                    string fClass = vTDT.Rows[idx]["F_CLASS"].ToString();
                    if (fClass.Equals(sPolymers))
                        newRow = fgrid_tail.AddItem(vTDT.Rows[idx].ItemArray, (vPolymers.Row.Index + vPolymers.Children) + 1, 1);
                    else if (fClass.Equals(sPDPB))
                        newRow = fgrid_tail.AddItem(vTDT.Rows[idx].ItemArray, (vNodePDPB.Row.Index + vNodePDPB.Children) + 1, 1);
                    else if (fClass.Equals(sNonPDPB))
                        newRow = fgrid_tail.AddItem(vTDT.Rows[idx].ItemArray, (vNodeNonPDPB.Row.Index + vNodeNonPDPB.Children) + 1, 1);


                    double dCbdPrice = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(newRow.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCBD_PRICE));
                    double dUnitPrice = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(newRow.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUNIT_PRICE));

                    if (dCbdPrice != dUnitPrice)
                        fgrid_tail.GetCellRange(newRow.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUNIT_PRICE).StyleNew.ForeColor = Color.Red;
                    else
                        fgrid_tail.GetCellRange(newRow.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUNIT_PRICE).StyleNew.ForeColor = Color.Blue;

                    newRow.IsNode = true;
                    newRow.Node.Level = vNodePDPB.Level + 1;
                    newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                }

                vTDT.Dispose();

                ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR);
                ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR);
                ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVOLM);
                ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPRICE_BATCH);
            }

            return true;
        }

        //private bool Save()
        //{
        //    if (SAVE_SFB_CBD_B_FORMU_COLOR_H())
        //    {
        //        if (MyOraDB.Save_FlexGird("PKG_SFB_CBD_B_FORMU.SAVE_SFB_CBD_B_FORMU_T", fgrid_tail))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        #endregion

        #region 그리드 이벤트 

        //private void GridAfterEdit()
        //{
        //    try
        //    {
        //        fgrid_tail.Update_Row();

        //        if (fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPDPB_FILLER || 
        //            fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR ||
        //            fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUNIT_PRICE ||
        //            fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxSP_GR ||
        //            fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxACT_PHR ||
        //            fgrid_tail.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPDPB_ACT_PCT)
        //        {
        //            CalcPHR();
        //            CalcVolumn();
        //            CalcPriceBatch();
        //            CalcTargetWTBatch();
        //            CalcMultipliplierFactory();

        //            // Column total
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR);
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR);
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVOLM);
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPRICE_BATCH);

        //            Summary();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Grid after edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void GridBeforeEdit()
        //{
        //    if ((fgrid_tail.Rows.Fixed > 0) && (fgrid_tail.Row >= fgrid_tail.Rows.Fixed))
        //        fgrid_tail.Buffer_CellData = (fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] == null) ? "" : fgrid_tail[fgrid_tail.Row, fgrid_tail.Col].ToString();
        //}

        //private void AddBottomMaterial()
        //{
        //    if (ValidationHeadInfo && 
        //        fgrid_tail.Row >= fgrid_tail.Rows.Fixed &&
        //        fgrid_tail.Row < fgrid_tail.Rows.Count - 1)
        //    {
        //        int curRow = fgrid_tail.Row;

        //        Node pNode = fgrid_tail.Rows[curRow].Node;
        //        Node nNode = null;
        //        if (fgrid_tail.Rows[curRow].Node.Level == 1)
        //        {
        //            nNode = fgrid_tail.Rows.InsertNode(pNode.Row.Index, pNode.Level);
        //        }
        //        else
        //        {
        //            nNode = fgrid_tail.Rows.InsertNode((pNode.Row.Index + pNode.Children) + 1, pNode.Level + 1);
        //        }                

        //        fgrid_tail[nNode.Row.Index, 0] = "I";
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCMP_CD] = "";
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxFACTORY] = cmb_prodFac2.SelectedValue;
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxMCS_NO] = txt_mcsNo.Text;
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCOLOR_CD] = txt_colorCd.Text;
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS] = fgrid_tail[pNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxF_CLASS];
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxAPP_DATE] = dpick_appDate.Value.ToString("yyyyMMdd");
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUPD_YMD] = DateTime.Now;
        //        fgrid_tail[nNode.Row.Index, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUPD_USER] = COM.ComVar.This_User;

        //        CalcPHR();
        //        CalcVolumn();
        //        CalcPriceBatch();
        //        CalcTargetWTBatch();
        //        CalcMultipliplierFactory();

        //        // Column total
        //        ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR);
        //        ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR);
        //        ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVOLM);
        //        ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPRICE_BATCH);

        //        Summary();
        //    }
        //}

        //private void RemoveBottomMaterial()
        //{
        //    if (fgrid_tail.Row >= fgrid_tail.Rows.Fixed)
        //    {
        //        int curRow = fgrid_tail.Row;

        //        Node pNode = fgrid_tail.Rows[curRow].Node;
        //        if (fgrid_tail.Rows[curRow].Node.Level != 0)
        //        {
        //            if (fgrid_tail[curRow, 0] == null)
        //            {
        //                fgrid_tail.Delete_Row(curRow);
        //            }
        //            else
        //            {
        //                if (fgrid_tail[curRow, 0].ToString().Equals("I"))
        //                    fgrid_tail.Rows.Remove(curRow);                        
        //            }

        //            CalcPHR();
        //            CalcVolumn();
        //            CalcPriceBatch();
        //            CalcTargetWTBatch();
        //            CalcMultipliplierFactory();

        //            // Column total
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR);
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR);
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVOLM);
        //            ColumnTotal((int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPRICE_BATCH);

        //            Summary();
        //        }
        //    }
        //}

        #region Bottom material

        //private string _GridBuffer = null;

        //private void GridBottomMatAfterEdit()
        //{
        //    // Vendor
        //    switch (fgrid_tail.Col)
        //    {
        //        case (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCMP_CD:
        //            string sFac = fgrid_tail[fgrid_tail.Row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxFACTORY].ToString();
        //            string sMat = fgrid_tail[fgrid_tail.Row, fgrid_tail.Col].ToString();

        //            if (sMat.Length > 1)
        //            {
        //                ContextMenuStrip mnu = new ContextMenuStrip();
        //                mnu.Closed += new ToolStripDropDownClosedEventHandler(mnu_Closed);

        //                DataTable vDT = _ComFnc.SELECT_SFB_CBD_B_MAT_BTTM_LIST(sFac, sMat);
        //                if (vDT != null && vDT.Rows.Count > 0)
        //                {
        //                    for (int idx = 0; idx < vDT.Rows.Count; idx++)
        //                    {
        //                        ToolStripItem item = mnu.Items.Add(vDT.Rows[idx][2].ToString(), null, mnuBottomMatItem_Click);
        //                        item.Tag = new object[] { 
        //                            vDT.Rows[idx]["MAT_CD"], vDT.Rows[idx]["CBD_NAME"], 
        //                            vDT.Rows[idx]["VEN_CD"], vDT.Rows[idx]["VEN_CBD_NAME"], 
        //                            vDT.Rows[idx]["UNIT_PRICE"]
        //                        };
        //                    }

        //                    Point gridPoint = fgrid_tail.GetCellRect(fgrid_tail.Row, fgrid_tail.Col).Location;
        //                    mnu.Show(fgrid_tail.PointToScreen(gridPoint));
        //                }
        //                else
        //                {
        //                    fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //                }
        //            }
        //            else
        //            {
        //                fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //            }
        //            break;
        //    }
        //}

        //private void fgrid_tail_KeyDownEdit(object sender, C1.Win.C1FlexGrid.KeyEditEventArgs e)
        //{
        //    try
        //    {
        //        if (e.KeyData == Keys.Enter && e.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCMP_CD)
        //        {
        //            _GridBuffer = fgrid_tail[e.Row, e.Col].ToString();
        //            fgrid_tail.FinishEditing(false);
        //            GridBottomMatAfterEdit();
        //        }
        //        if (e.KeyData == Keys.Enter && e.Col == (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVEN_CBD_NAME)
        //        {
        //            _GridBuffer = fgrid_tail[e.Row, e.Col].ToString();
        //            fgrid_tail.FinishEditing(false);
        //            GridVendorAfterEdit();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Bottom material cell key down", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void mnuBottomMatItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int[] sels = fgrid_tail.Selections;
        //        fgrid_tail.FinishEditing();
        //        int row = fgrid_tail.Row;
        //        int cmpCdCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCMP_CD;
        //        int cmpNmCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCBD_NAME;

        //        ToolStripItem item = sender as ToolStripItem;

        //        // 중복 검사
        //        Node pNode = fgrid_tail.Rows[row].Node.GetNode(NodeTypeEnum.Parent);
        //        object[] sData = (object[])item.Tag;
        //        string sOCmpCd = sData[0].ToString();
        //        for (int TRow = pNode.Row.Index + 1; TRow <= (pNode.Row.Index + pNode.Children); TRow++)
        //        {
        //            string sTCmpCd = fgrid_tail[TRow, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCMP_CD].ToString();

        //            if (sOCmpCd.Equals(sTCmpCd) && TRow != row)
        //            {
        //                ClassLib.ComFunction.User_Message("Duplicate bottom material", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //                fgrid_tail[row, cmpCdCol] = _GridBuffer;
        //                return;
        //            }
        //        }

        //        fgrid_tail[row, cmpCdCol] = sData[0];
        //        fgrid_tail[row, cmpNmCol] = item.Text;

        //        fgrid_tail[row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVEN_CBD_NAME] = sData[3];
        //        fgrid_tail[row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVEN_CD] = sData[2];
        //        fgrid_tail[row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxCBD_PRICE] = sData[4];
        //        fgrid_tail[row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxAPP_DATE] = DateTime.Now.ToString("yyyyMMdd");
        //        fgrid_tail[row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUPD_USER] = COM.ComVar.This_User;
        //        fgrid_tail[row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUPD_YMD] = DateTime.Now;
        //        fgrid_tail.Update_Row(row);
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Bottom material click", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //    }
        //}

        //void mnu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        //{
        //    if (e.CloseReason != ToolStripDropDownCloseReason.ItemClicked)
        //    {
        //        fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //    }
        //}

        #endregion

        #region Vendor

        //private void GridVendorAfterEdit()
        //{
        //    // Vendor
        //    switch (fgrid_tail.Col)
        //    {
        //        case (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVEN_CBD_NAME:
        //            string sFac = fgrid_tail[fgrid_tail.Row, (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxFACTORY].ToString();
        //            string sVen = fgrid_tail[fgrid_tail.Row, fgrid_tail.Col].ToString();

        //            if (sVen.Length > 1)
        //            {
        //                ContextMenuStrip mnu = new ContextMenuStrip();
        //                mnu.Closed += new ToolStripDropDownClosedEventHandler(mnu_Closed);

        //                DataTable vDT = _ComFnc.SELECT_SHC_VENDOR_LIST(sFac, sVen);
        //                if (vDT != null && vDT.Rows.Count > 0)
        //                {
        //                    for (int idx = 0; idx < vDT.Rows.Count; idx++)
        //                    {
        //                        ToolStripItem item = mnu.Items.Add(vDT.Rows[idx][1].ToString(), null, mnuVendorItem_Click);
        //                        item.Tag = vDT.Rows[idx][0];
        //                    }

        //                    Point gridPoint = fgrid_tail.GetCellRect(fgrid_tail.Row, fgrid_tail.Col).Location;
        //                    mnu.Show(fgrid_tail.PointToScreen(gridPoint));
        //                }
        //                else
        //                {
        //                    fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //                }
        //            }
        //            else
        //            {
        //                fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //            }
        //            break;
        //    }
        //}

        //private void mnuVendorItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int[] sels = fgrid_tail.Selections;
        //        fgrid_tail.FinishEditing();
        //        int row = fgrid_tail.Row;
        //        int venCdCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVEN_CD;
        //        int venNmCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVEN_CBD_NAME;
                
        //        ToolStripItem item = sender as ToolStripItem;

        //        fgrid_tail[row, venCdCol] = item.Tag;
        //        fgrid_tail[row, venNmCol] = item.Text;
        //        fgrid_tail.Update_Row(row);
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Vendor click", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] = _GridBuffer;
        //    }
        //}

        #endregion

        #region Calculation 

        #region Common

        private bool GetRowIdx(ref int iPRow, ref int iFCRow, ref int iLCRow, int iCIdx)
        {
            iPRow = fgrid_tail.Rows.Fixed;

            if (fgrid_tail.Rows.Count == iPRow)
                return false;

            Node iPNode = fgrid_tail.Rows[iPRow].Node;

            for (int idx = 0; idx < iCIdx; idx++)
            {
                iPNode = iPNode.GetNode(NodeTypeEnum.NextSibling);
            }

            iPRow = iPNode.Row.Index;
            iFCRow = iPRow + 1;
            iLCRow = iPRow + iPNode.Children;

            if (iFCRow > iLCRow)
                return false;

            return true;
        }

        // 1. PHR
        private void CalcPHR()
        {
            CalcPolymersPHR();
            CalcPDPBPHR();
            CalcNonPDPBPHR();
        }

        // 2. Volumn
        private void CalcVolumn()
        {
            int iWeight = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR;
            int iSP_GR = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxSP_GR;

            int iVolumn = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVOLM;

            for (int iRow = fgrid_tail.Rows.Fixed; iRow < fgrid_tail.Rows.Count; iRow++)
            {
                if (fgrid_tail.Rows[iRow].Node.Level != 0)
                {
                    double dWeight = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iRow, iWeight));
                    double dSP_GR = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iRow, iSP_GR));

                    double dResult = Math.Round(dWeight / (dSP_GR * 1000), 2);
                    fgrid_tail[iRow, iVolumn] = CheckDoubleValue(dResult);
                }
            }
        }

        // 3. Price US/Batch
        private void CalcPriceBatch()
        {
            int iWeight = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR;
            int iUnitPrice = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxUNIT_PRICE;

            int iPriceBatch = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPRICE_BATCH;

            for (int iRow = fgrid_tail.Rows.Fixed; iRow < fgrid_tail.Rows.Count; iRow++)
            {
                if (fgrid_tail.Rows[iRow].Node.Level != 0)
                {
                    double dWeight = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iRow, iWeight));
                    double dUnitPrice = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iRow, iUnitPrice));

                    double dResult = Math.Round((dWeight / 1000) * dUnitPrice, 2);
                    fgrid_tail[iRow, iPriceBatch] = CheckDoubleValue(dResult);
                }
            }
        }

        // 100. Total
        private void ColumnTotal(int arg_col)
        {
            if (fgrid_tail.Rows.Fixed >= fgrid_tail.Rows.Count)
                return;

            int iTotRow = fgrid_tail.Rows.Count - 1;

            fgrid_tail[iTotRow, arg_col] = fgrid_tail.Aggregate(
                AggregateEnum.Sum,
                fgrid_tail.GetCellRange(fgrid_tail.Rows.Fixed, arg_col, fgrid_tail.Rows.Count - 2, arg_col));
        }

        #endregion

        #region Polymers

        private void CalcPolymersPHR()
        {
            int iPRow = 0, iFCRow = 0, iLCRow = 0;
            if (GetRowIdx(ref iPRow, ref iFCRow, ref iLCRow, 0))
            {
                int iPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR;
                int iActPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxACT_PHR;

                for (int iRow = iFCRow; iRow <= iLCRow; iRow++)
                {
                    fgrid_tail[iRow, iPHRCol] = fgrid_tail[iRow, iActPHRCol];
                }
            }
        }

        #endregion


        #region PDPB Materials

        private void CalcPDPBPHR()
        {
            int iPRow = 0, iFCRow = 0, iLCRow = 0;
            if (GetRowIdx(ref iPRow, ref iFCRow, ref iLCRow, 1))
            {
                int iPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR;

                int iPDPBActCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPDPB_ACT_PCT; 
                int iActPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxACT_PHR;

                for (int iRow = iFCRow; iRow <= iLCRow; iRow++)
                {
                    double dActive = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iRow, iPDPBActCol));
                    double dActPHR = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iRow, iActPHRCol));

                    double dPHR = Math.Round((dActPHR * 100) / dActive, 2);
                    fgrid_tail[iRow, iPHRCol] = CheckDoubleValue(dPHR);
                }
            }
        }

        #endregion


        #region Non-PDPB Material

        private void CalcNonPDPBPHR()
        {
            int iPRow = 0, iFCRow = 0, iLCRow = 0;
            if (GetRowIdx(ref iPRow, ref iFCRow, ref iLCRow, 2))
            {
                int iPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR;
                int iActPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxACT_PHR;

                for (int iRow = iFCRow; iRow <= iLCRow; iRow++)
                {
                    fgrid_tail[iRow, iPHRCol] = fgrid_tail[iRow, iActPHRCol];
                }
            }
        }

        #endregion


        #region Summary

        // 4. Target Weight Batch 
        private void CalcTargetWTBatch()
        {
            // txt_sv_mix_caps * txt_sv_actual_sg * (txt_sv_desired_caps / 100)
            string sMixCapa = txt_sv_mix_caps.Text;
            string sActualSG = txt_sv_actual_sg.Text;
            string sDesiredCapa = txt_sv_desired_caps.Text;

            double dResult = 0, dTmp = 0;

            if (double.TryParse(sMixCapa.Replace(",", ""), out dTmp) &&
                double.TryParse(sActualSG.Replace(",", ""), out dTmp) &&
                double.TryParse(sDesiredCapa.Replace(",", ""), out dTmp))
            {
                double dMixCapa = double.Parse(sMixCapa.Replace(",", ""));
                double dActualSG = double.Parse(sActualSG.Replace(",", ""));
                double dDesiredCapa = double.Parse(sDesiredCapa.Replace(",", ""));

                dResult = dMixCapa * dActualSG * (dDesiredCapa / 100);
                //lbl_sv_target_wt.Text = CheckDoubleValue(dResult).ToString();
                lbl_sv_target_wt.Text = string.Format("{0:#,##0.00}", CheckDoubleValue(dResult));
            }
        }

        // 5. Multipliplier Factory
        private void CalcMultipliplierFactory()
        {
            int iTotRow = fgrid_tail.Rows.Count - 1;
            int iPHRCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPHR;

            double dTmp = 0;
            if (double.TryParse(lbl_sv_target_wt.Text.Replace(",", ""), out dTmp))
            {
                double dTotPHR = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iTotRow, iPHRCol));
                double dTargetWT = double.Parse(lbl_sv_target_wt.Text.Replace(",", ""));

                double dResult = Math.Round(dTargetWT / dTotPHR, 6);
                lbl_sv_mult_fac.Text = Convert.ToString(CheckDoubleValue(dResult));
            }
        }

        // 101. ETC Summary
        private void Summary()
        {
            // PDPB Total
            int iPRow = 0, iFCRow = 0, iLCRow = 0, iCount = 0, iFixed = 0;
            iFixed = fgrid_tail.Rows.Fixed;
            iCount = fgrid_tail.Rows.Count - 1;

            int iPDPBCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPDPB_FILLER;
            double dTotPDPBPct = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iFixed, iPDPBCol, iCount, iPDPBCol));
            //lbl_sv_pdpb_tot.Text = Convert.ToString(CheckDoubleValue(dTotPDPBPct / 1000));
            lbl_sv_pdpb_tot.Text = string.Format("{0:#,##0.000}", CheckDoubleValue(dTotPDPBPct / 1000));

            // Polymer Total
            int iWeightCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxWEIGHT_GR;
            if (GetRowIdx(ref iPRow, ref iFCRow, ref iLCRow, 0))
            {
                double dTotPolymer = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iFCRow, iWeightCol, iLCRow, iWeightCol));
                //lbl_sv_polymer_tot.Text = Convert.ToString(CheckDoubleValue(dTotPolymer / 1000));
                lbl_sv_polymer_tot.Text = string.Format("{0:#,##0.000}", CheckDoubleValue(dTotPolymer / 1000));
            }

            // Avg S.G
            int iVolCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxVOLM;
            double dTotWeight = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iCount, iWeightCol));
            double dTotVol = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iCount, iVolCol));

            //lbl_sv_avg_sg.Text = Convert.ToString(CheckDoubleValue(dTotWeight / (dTotVol * 1000)));
            lbl_sv_avg_sg.Text = string.Format("{0:#,##0.000}", CheckDoubleValue(dTotWeight / (dTotVol * 1000)));

            // Cost KG
            int iPriceBatchCol = (int)ClassLib.TBSFB_CBD_B_FORMU_TAIL.IxPRICE_BATCH;
            double dPriceBatch = fgrid_tail.Aggregate(AggregateEnum.Sum, fgrid_tail.GetCellRange(iCount, iPriceBatchCol));

            //lbl_sv_cost_kg.Text = Convert.ToString(CheckDoubleValue(dPriceBatch / (dTotWeight / 1000)));
            lbl_sv_cost_kg.Text = string.Format("{0:#,##0.000}", CheckDoubleValue(dPriceBatch / (dTotWeight / 1000)));
        }

        #endregion

        #endregion

        #endregion

        #region 버튼 및 기타 이벤트

        //private bool ValidationHeadInfo
        //{
        //    get
        //    {
        //        if (cmb_prodFac2.SelectedIndex < 0)
        //        {
        //            cmb_prodFac2.Focus();
        //            ClassLib.ComFunction.User_Message("Select factory", "Head", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }

        //        if (txt_mcsNo.Text.Length <= 0)
        //        {
        //            txt_mcsNo.Focus();
        //            ClassLib.ComFunction.User_Message("Input MCS #", "Head", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }

        //        if (txt_colorCd.Text.Length <= 0)
        //        {
        //            txt_colorCd.Focus();
        //            ClassLib.ComFunction.User_Message("Input color code", "Head", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }

        //        return true;
        //    }
        //}

        private void HeadCtlReadonly(bool arg_pri)
        {
            // Primary 
            foreach (Control vCtl in pnl_search2.Controls)
            {
                if (vCtl is TextBox)
                {
                    (vCtl as TextBox).ReadOnly = arg_pri;
                    (vCtl as TextBox).BackColor = arg_pri ? Color.WhiteSmoke : Color.White;
                }
                else if (vCtl is C1.Win.C1List.C1Combo)
                {
                    (vCtl as C1.Win.C1List.C1Combo).ReadOnly = arg_pri;
                    (vCtl as C1.Win.C1List.C1Combo).EditorBackColor = arg_pri ? Color.WhiteSmoke : Color.White;
                }
                else if (vCtl is DateTimePicker)
                {
                    (vCtl as DateTimePicker).Enabled = !arg_pri;
                    (vCtl as DateTimePicker).BackColor = !arg_pri ? Color.WhiteSmoke : Color.White;
                }
            }

            foreach (Control vCtl in pnl_result.Controls)
            {
                if (vCtl is TextBox)
                {
                    (vCtl as TextBox).ReadOnly = arg_pri;
                    (vCtl as TextBox).BackColor = arg_pri ? Color.WhiteSmoke : Color.White;
                }
            }

            fgrid_tail.AllowEditing = !arg_pri;
            if (arg_pri)
            {
                for (int iCol = fgrid_tail.Cols.Frozen; iCol < fgrid_tail.Cols.Count; iCol++)
                {
                    fgrid_tail.Cols[iCol].StyleNew.ForeColor = Color.Black;
                }
            }
        }

        private double CheckDoubleValue(double arg_val)
        {
            if (double.IsInfinity(arg_val) || double.IsNaN(arg_val))
                return 0;
            else
                return arg_val;
        }

        #region Properties 

        public string PROD_FAC
        {
            set
            {
                cmb_prodFac2.SelectedValue = value;
            }
        }

        public string MCS_NO
        {
            set
            {
                txt_mcsNo.Text = value;
            }
        }

        public string COLOR_CD
        {
            set
            {
                txt_colorCd.Text = value;
            }
        }

        #endregion

        #endregion

        #endregion

        #region 디비 연결

        #region 조회

        /// <summary>
        /// PKG_SFB_CBD_B_FORMU.SELECT_SFB_CBD_B_FORMU_H : 
        /// </summary>
        /// <returns>DataTable</returns>
        private DataTable SELECT_SFB_CBD_B_FORMU_H(string arg_factory, string arg_mcs_no, string arg_color_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_FORMU.SELECT_SFB_CBD_B_FORMU_H";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MCS_NO";
                MyOraDB.Parameter_Name[2] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mcs_no;
                MyOraDB.Parameter_Values[2] = arg_color_cd;
                MyOraDB.Parameter_Values[3] = "";

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
        /// PKG_SFB_CBD_B_FORMU.SELECT_SFB_CBD_B_FORMU_T : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFB_CBD_B_FORMU_T(string arg_prod_fac, string arg_mcs_no, string arg_color_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_FORMU.SELECT_SFB_CBD_B_FORMU_T";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MCS_NO";
                MyOraDB.Parameter_Name[2] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_prod_fac;
                MyOraDB.Parameter_Values[1] = arg_mcs_no;
                MyOraDB.Parameter_Values[2] = arg_color_cd;
                MyOraDB.Parameter_Values[3] = "";

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


        ///// <summary>
        ///// PKG_SFB_CBD_B_FORMU.SAVE_SFB_CBD_B_FORMU_COLOR_H : 
        ///// </summary>
        //public bool SAVE_SFB_CBD_B_FORMU_COLOR_H()
        //{
        //    try
        //    {

        //        MyOraDB.ReDim_Parameter(24);

        //        //01.PROCEDURE명
        //        MyOraDB.Process_Name = "PKG_SFB_CBD_B_FORMU.SAVE_SFB_CBD_B_FORMU_H";

        //        //02.ARGURMENT 명
        //        MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
        //        MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
        //        MyOraDB.Parameter_Name[2] = "ARG_MCS_NO";
        //        MyOraDB.Parameter_Name[3] = "ARG_COLOR_CD";
        //        MyOraDB.Parameter_Name[4] = "ARG_FORMURA_TYPE";
        //        MyOraDB.Parameter_Name[5] = "ARG_DIV";
        //        MyOraDB.Parameter_Name[6] = "ARG_BTTM_TYPE";
        //        MyOraDB.Parameter_Name[7] = "ARG_COLOR_NAME";
        //        MyOraDB.Parameter_Name[8] = "ARG_COLOR_TYPE_CD";
        //        MyOraDB.Parameter_Name[9] = "ARG_COLOR_MARGIN_PCT";
        //        MyOraDB.Parameter_Name[10] = "ARG_MATERIAL";
        //        MyOraDB.Parameter_Name[11] = "ARG_MCS_REMARK";
        //        MyOraDB.Parameter_Name[12] = "ARG_APP_DATE";
        //        MyOraDB.Parameter_Name[13] = "ARG_PDPB_TOT";
        //        MyOraDB.Parameter_Name[14] = "ARG_POLYMER_TOT";
        //        MyOraDB.Parameter_Name[15] = "ARG_SG_AVG";
        //        MyOraDB.Parameter_Name[16] = "ARG_MIX_CAPA";
        //        MyOraDB.Parameter_Name[17] = "ARG_SG_ACTUAL";
        //        MyOraDB.Parameter_Name[18] = "ARG_UTIL_CAPA_PCT";
        //        MyOraDB.Parameter_Name[19] = "ARG_TARGET_WT";
        //        MyOraDB.Parameter_Name[20] = "ARG_MUTI_FACTOR";
        //        MyOraDB.Parameter_Name[21] = "ARG_COST_KG";
        //        MyOraDB.Parameter_Name[22] = "ARG_USE_YN";
        //        MyOraDB.Parameter_Name[23] = "ARG_UPD_USER";

        //        //03.DATA TYPE 정의
        //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;

        //        //04.DATA 정의
        //        MyOraDB.Parameter_Values[0] = "U";
        //        MyOraDB.Parameter_Values[1] = cmb_prodFac2.SelectedValue.ToString();
        //        MyOraDB.Parameter_Values[2] = txt_mcsNo.Text;
        //        MyOraDB.Parameter_Values[3] = txt_colorCd.Text;
        //        MyOraDB.Parameter_Values[4] = cmb_formulaType.SelectedValue.ToString();
        //        MyOraDB.Parameter_Values[5] = cmb_div2.SelectedValue.ToString();
        //        MyOraDB.Parameter_Values[6] = cmb_bttmType2.SelectedValue.ToString();
        //        MyOraDB.Parameter_Values[7] = txt_colorName.Text;
        //        MyOraDB.Parameter_Values[8] = cmb_stdColType.SelectedValue.ToString();
        //        string sMargin = scr_margin.Value.ToString();
        //        MyOraDB.Parameter_Values[9] = Convert.ToString(Convert.ToDouble(sMargin) / 100);
        //        MyOraDB.Parameter_Values[10] = txt_material.Text;
        //        MyOraDB.Parameter_Values[11] = txt_remarks.Text;
        //        MyOraDB.Parameter_Values[12] = dpick_appDate.Value.ToString("yyyyMMdd");

        //        MyOraDB.Parameter_Values[13] = Convert.ToString(StringToDouble(lbl_sv_pdpb_tot.Text));
        //        MyOraDB.Parameter_Values[14] = Convert.ToString(StringToDouble(lbl_sv_polymer_tot.Text));
        //        MyOraDB.Parameter_Values[15] = Convert.ToString(StringToDouble(lbl_sv_avg_sg.Text));
        //        MyOraDB.Parameter_Values[16] = Convert.ToString(StringToDouble(txt_sv_mix_caps.Text));
        //        MyOraDB.Parameter_Values[17] = Convert.ToString(StringToDouble(txt_sv_actual_sg.Text));
        //        MyOraDB.Parameter_Values[18] = Convert.ToString(StringToDouble(txt_sv_desired_caps.Text));
        //        MyOraDB.Parameter_Values[19] = Convert.ToString(StringToDouble(lbl_sv_target_wt.Text));
        //        MyOraDB.Parameter_Values[20] = Convert.ToString(StringToDouble(lbl_sv_mult_fac.Text));
        //        MyOraDB.Parameter_Values[21] = Convert.ToString(StringToDouble(lbl_sv_cost_kg.Text));

        //        MyOraDB.Parameter_Values[22] = cmb_useYN.SelectedValue.ToString();
        //        MyOraDB.Parameter_Values[23] = COM.ComVar.This_User;

        //        MyOraDB.Add_Modify_Parameter(true);
        //        DataSet vDS = MyOraDB.Exe_Modify_Procedure();

        //        if (vDS != null)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        private double StringToDouble(string arg_str)
        {
            double dRet = 0, dTmp = 0;

            if (!arg_str.Equals(""))
            {
                if (double.TryParse(arg_str, out dTmp))
                    dRet = Convert.ToDouble(arg_str);
            }

            return dRet;
        }


        #endregion


        #endregion

    }
}

