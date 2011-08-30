using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexCosting.Basic.Frm
{
    public partial class Form_Material_Management : COM.PCHWinForm.Form_Top
    {
        public Form_Material_Management()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private COM.OraDB MyOraDB = new COM.OraDB();

        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();
        private DataTable _ClassDT = null;


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
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Save())
                {
                    fgrid_main.Refresh_Division();
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
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridBeforeEdit();
        }

        private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridAfterEdit();
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void ctxm_priceHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int row = fgrid_main.Row, col = fgrid_main.Col;

                if (row >= fgrid_main.Rows.Fixed)
                {
                    string sFac = fgrid_main[row, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxFACTORY].ToString();
                    string sMat = fgrid_main[row, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxMAT_CD].ToString();

                    Pop.Pop_Material_History histPop = new FlexCosting.Basic.Pop.Pop_Material_History();
                    histPop.Factory = sFac;
                    histPop.MatCode = sMat;

                    histPop.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "History", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Text = "Material management for CBD";
                this.lbl_MainTitle.Text = "Material management for CBD";
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
            fgrid_main.Set_Grid("SXD_SRF_M_MAT", "4", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Set_Action_Image(img_Action);
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();
            cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

            vDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_factory, ClassLib.ComVar.This_Factory), "SFB_02");
            COM.ComCtl.Set_ComboList(vDT, cmb_div, 1, 2, true);
            cmb_div.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            _ClassDT = COM.ComVar.Select_ComCode(COM.ComFunction.Empty_Combo(cmb_factory, ClassLib.ComVar.This_Factory), "SFB_03");
        }

        private void Init_Toolbar()
        {
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_main.ClearAll();
        }

        private void Search()
        {
            string sFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
            string sClass = COM.ComFunction.Empty_Combo(cmb_div, "");
            string sSchText = txt_schText.Text;

            DataTable vDT = SELECT_SXD_SRF_M_MAT(sFactory, sClass, sSchText);

            fgrid_main.ClearAll();
            if (vDT != null)
            {
                fgrid_main.Display_Grid(vDT, false);

                for (int idx = 0; idx < fgrid_main.Styles.Count; idx++)
                {
                    string ssn = "COMBO_CLASS_";

                    if (fgrid_main.Styles[idx].Name.IndexOf(ssn) > 0)
                        fgrid_main.Styles.Remove(fgrid_main.Styles[idx]);
                }

                int divCol = (int)ClassLib.TBSXD_SRF_M_MAT_04.IxDIV;
                int clsCol = (int)ClassLib.TBSXD_SRF_M_MAT_04.IxCBD_CLASS;
                for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
                {
                    string ssn = "COMBO_CLASS_" + row;
                    //fgrid_main.Styles.Remove(ssn);

                    CellStyle cs = fgrid_main.Styles.Add(ssn);
                    cs.DataMap = new ListDictionary();
                    cs.DataMap.Add("", "");
                    CellRange range = fgrid_main.GetCellRange(row, clsCol);
                    range.Style = fgrid_main.Styles[ssn];

                    string sDiv = fgrid_main[row, divCol].ToString();
                    MakeCmbDataList(sDiv, row);
                }
            }
        }

        private bool Save()
        {
            return MyOraDB.Save_FlexGird("PKG_SXD_SRF_M_MAT.SAVE_SFB_CBD_B_MAT_REL", fgrid_main);
        }

        #endregion

        #region 그리드 이벤트

        private void GridAfterEdit()
        {
            int row = fgrid_main.Row, col = fgrid_main.Col;

            if (col == (int)ClassLib.TBSXD_SRF_M_MAT_04.IxVENDOR_DESC)
                return;

            int[] sels = fgrid_main.Selections;

            // Vendor
            switch (col) 
            {
                case (int)ClassLib.TBSXD_SRF_M_MAT_04.IxDIV:
                    string sDiv = fgrid_main[row, col].ToString();

                    foreach (int row1 in sels)
                    {
                        CellRange range = fgrid_main.GetCellRange(row1, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxCBD_CLASS);
                        range.Data = "";

                        fgrid_main[row1, col] = fgrid_main[row, col]; 
                        MakeCmbDataList(sDiv, row1);
                        fgrid_main.Update_Row(row1);
                    }
                    break;
                default :
                    foreach (int row1 in sels)
                    {
                        fgrid_main[row1, col] = fgrid_main[row, col];
                        fgrid_main.Update_Row(row1);
                    }
                    break;
            }
        }

        #region Vendor 

        private string _GridBuffer = null;

        private void GridVendorAfterEdit()
        {
            // Vendor
            switch (fgrid_main.Col)
            {
                case (int)ClassLib.TBSXD_SRF_M_MAT_04.IxVENDOR_DESC:
                    string sFac = fgrid_main[fgrid_main.Row, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxFACTORY].ToString();
                    string sVen = fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
                    
                    if (sVen.Length > 2)
                    {
                        ContextMenuStrip mnu = new ContextMenuStrip();
                        mnu.Closed += new ToolStripDropDownClosedEventHandler(mnu_Closed);

                        DataTable vDT = _ComFnc.SELECT_CDC_VENDOR_LIST(sFac, sVen);
                        if (vDT != null && vDT.Rows.Count > 0)
                        {
                            for (int idx = 0; idx < vDT.Rows.Count; idx++)
                            {
                                ToolStripItem item = mnu.Items.Add(vDT.Rows[idx][1].ToString(), null, mnuVendorItem_Click);
                                item.Tag = vDT.Rows[idx][0];
                            }

                            Point gridPoint = fgrid_main.GetCellRect(fgrid_main.Row, fgrid_main.Col).Location;
                            mnu.Show(fgrid_main.PointToScreen(gridPoint));
                        }
                        else
                        {
                            fgrid_main[fgrid_main.Row, fgrid_main.Col] = _GridBuffer;
                        }
                    }
                    else
                    {
                        fgrid_main[fgrid_main.Row, fgrid_main.Col] = _GridBuffer;
                    }
                    break;
            }
        }

        void mnu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (e.CloseReason != ToolStripDropDownCloseReason.ItemClicked)
                fgrid_main[fgrid_main.Row, fgrid_main.Col] = _GridBuffer;
        }

        private void fgrid_main_KeyDownEdit(object sender, C1.Win.C1FlexGrid.KeyEditEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && e.Col == (int)ClassLib.TBSXD_SRF_M_MAT_04.IxVENDOR_DESC)
                {
                    _GridBuffer = fgrid_main[e.Row, e.Col].ToString();
                    fgrid_main.FinishEditing(false);
                    GridVendorAfterEdit();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Vendor cell key down", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuVendorItem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sels = fgrid_main.Selections;
                fgrid_main.FinishEditing();
                int row = fgrid_main.Row;
                int venSeqCol = (int)ClassLib.TBSXD_SRF_M_MAT_04.IxVEN_SEQ;
                int venDescCol = (int)ClassLib.TBSXD_SRF_M_MAT_04.IxVENDOR_DESC;

                ToolStripItem item = sender as ToolStripItem;

                foreach (int cRow in sels)
                {
                    fgrid_main[cRow, venSeqCol] = item.Tag;
                    fgrid_main[cRow, venDescCol] = item.Text;

                    fgrid_main[fgrid_main.Row, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxUPD_USER] = COM.ComVar.This_User;
                    fgrid_main[fgrid_main.Row, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxUPD_YMD] = DateTime.Now;
                    fgrid_main.Update_Row(cRow);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Vendor click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void GridBeforeEdit()
        {
            if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
                fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
        }

        private void MakeCmbDataList(string arg_div, int arg_row)
        {
            try
            {
                DataRow[] vDR = _ClassDT.Select("COM_VALUE2 = '" + arg_div + "'");

                int sel_code = 0;
                int sel_name = 0;

                sel_code = (int)COM.TBSCM_CODE.IxCOM_VALUE1;
                sel_name = (int)COM.TBSCM_CODE.IxCOM_DESC1;

                CellRange range = fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXD_SRF_M_MAT_04.IxCBD_CLASS);
                range.Style.DataMap.Clear();
                
                range.Style.DataMap.Add("", "");
                foreach (DataRow dr in vDR)
                {
                    range.Style.DataMap.Add(dr[sel_code].ToString(), dr[sel_name].ToString());
                }
            }

            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Make cmb data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트


        #endregion

        #endregion

        #region 디비 연결

        #region 조건

        #endregion

        #region 조회

        /// <summary>
        /// PKG_SXD_SRF_M_MAT.SELECT_SXD_SRF_M_MAT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_MAT(string arg_factory, string arg_class, string arg_search_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXD_SRF_M_MAT.SELECT_SXD_SRF_M_MAT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_CLASS";
                MyOraDB.Parameter_Name[2] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_class;
                MyOraDB.Parameter_Values[2] = arg_search_text;
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


        #endregion

        #endregion
    }
}

