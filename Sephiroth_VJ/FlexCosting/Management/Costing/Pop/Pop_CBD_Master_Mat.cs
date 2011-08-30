using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Pop
{
    public partial class Pop_CBD_Master_Mat : COM.PCHWinForm.Pop_Large
    {
        #region 생성자 

        public Pop_CBD_Master_Mat()
        {
            InitializeComponent();
            Init_Form();
        }

        #endregion


        #region 전역변수 

        private COM.OraDB MyOraDB = new COM.OraDB();
        private string[] _sParentData = null;

        #endregion


        #region 이벤트 핸들러

        #region 폼 이벤트 

        private void Pop_CBD_Master_Mat_Load(object sender, EventArgs e)
        {
            tbtn_Search_Click(null, null);
        }

        #endregion

        #region 툴바 버튼 이벤트

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                New();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
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
                if (txt_CustCode.Text.Trim().Equals("") && txt_CustName.Text.Trim().Equals("") &&
                    txt_MatCode.Text.Trim().Equals("") && txt_MatName.Text.Trim().Equals(""))
                    return;

                Search();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (Save())
                {
                    if (txt_Seq.Text.Trim().Equals(""))
                    {
                        txt_MatCode.Text = txt_MatNumber.Text + "." + cmb_LocationCode.SelectedValue.ToString();
                        txt_MatName.Text = txt_MatName2.Text;
                        txt_CustCode.Text = cmb_LocationCode.SelectedValue.ToString();
                        txt_CustName.Text = cmb_LocationCode.SelectedText;
                    }

                    Search();
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
                }
                else
                {
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        private void fgrid_CurMat_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_CurMat.Rows.Fixed < fgrid_CurMat.Rows.Count && fgrid_CurMat.Row >= fgrid_CurMat.Rows.Fixed)
                    SelectMaterial();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_CurMat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_CurMat.Rows.Count > fgrid_CurMat.Rows.Fixed && fgrid_CurMat.Row >= fgrid_CurMat.Rows.Fixed)
                {
                    int iCurRow = fgrid_CurMat.Row, iCurCol = fgrid_CurMat.Col;

                    // "0. MAT_CD", "1. MAT_NAME", "2. UOM", "3. FRT_TRM", "4. FOB", "5. CURR", "6. MAT_UPRICE", "7. VEN_NAME", "8. VEN_CD", "9. LOSS_PCT", "10. SE4PCIAL_OPTION"
                    string sMatCD = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_NUMBER].ToString();
                    string sMatName = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_MATERIAL_NAME].ToString();
                    string sUOM = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxUOM].ToString();
                    string sFRTTRM = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_DELIVERY_TERM] == null ? "" : fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_DELIVERY_TERM].ToString();
                    double sFRTTRMPct = 0;
                    if (sFRTTRM.Equals("FOB") || sFRTTRM.Trim().Equals(""))
                        sFRTTRMPct = 3;
                    else
                        sFRTTRMPct = 0;
                    string sCurr = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_CURRENCY].ToString();
                    double dUnitPrice = Convert.ToDouble(fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_UNIT_PRICE].ToString());
                    string sCustName = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_LOCATIONNAME_E].ToString();
                    string sCustCD = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_LOCATIONCODE].ToString();
                    string sLoss = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_LOSS].ToString();
                    string sSpeicalOption = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_SPECIAL_OPTION].ToString();
                    if (fgrid_CurMat.Col == (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_UNIT_PRICE)
                        sSpeicalOption = "";

                    if (iCurCol == (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_UNIT_PRICE)
                    {
                        COM.ComVar.Parameter_PopUp = new string[] { sMatCD, sMatName, sUOM, sFRTTRM, sFRTTRMPct.ToString(), sCurr, dUnitPrice.ToString(), sCustName, sCustCD, sLoss, sSpeicalOption };
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (iCurCol == (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_EXTRA_CHARGE)
                    {
                        double dExtra = Convert.ToDouble(fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_EXTRA_CHARGE].ToString());
                        COM.ComVar.Parameter_PopUp = new string[] { sMatCD, sMatName, sUOM, sFRTTRM, sFRTTRMPct.ToString(), sCurr, Convert.ToString(dUnitPrice + dExtra), sCustName, sCustCD, sLoss, sSpeicalOption };
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Apply data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 컨트롤 이벤트

        private void txt_LocationCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchCust();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Location select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_SearchKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        #endregion

        #endregion


        #region 이벤트 처리

        #region 초기화

        private void Init_Form()
        {
            //Title
            this.Text = "Material Information";
            this.lbl_MainTitle.Text = "Material Information";

            Init_Grid();
            Init_Control();
            Init_Toolbar();

            _sParentData = COM.ComVar.Parameter_PopUp;
        }

        private void Init_Grid()
        {
            fgrid_CurMat.Set_Grid("SFX_CBD_M_MAT_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_CurMat.Set_Action_Image(img_Action);
            fgrid_CurMat.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_CurMat.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_CurMat.AllowEditing = false;
            fgrid_CurMat.Font = new Font(fgrid_CurMat.Font.FontFamily, (float)8);

            //fgrid_MatHistory.Set_Grid("SFX_CBD_M_MAT_HISTORY", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            //fgrid_MatHistory.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            //fgrid_MatHistory.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            //fgrid_MatHistory.Font = new Font(fgrid_MatHistory.Font.FontFamily, (float)8);
        }

        private void Init_Control()
        {
            DataTable vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_01");
            COM.ComFunction.Set_ComboList(vDT, cmb_Currency, 1, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Currency.SelectedValue = "USD";
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_04");
            COM.ComFunction.Set_ComboList(vDT, cmb_FRTTerm, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Currency.SelectedValue = " ";
            vDT.Dispose();

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "CM04");
            COM.ComFunction.Set_ComboList(vDT, cmb_RPYn, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_RPYn.SelectedValue = "N";
            vDT.Dispose();

            txt_MatNumber.ReadOnly = true;
            txt_Unit.ReadOnly = false;
            txt_Seq.ReadOnly = true;
            txt_MatName2.ReadOnly = false;
            txt_Width.ReadOnly = true;
            txt_UnitPrice.ReadOnly = false;
            cmb_Currency.ReadOnly = false;
            txt_ExtraCharge.ReadOnly = false;
            txt_SpecialOption.ReadOnly = true;
            cmb_FRTTerm.ReadOnly = false;
            txt_Loss.ReadOnly = false;
            txt_MOQ.ReadOnly = false;
            txt_ProdLocation.ReadOnly = false;
            txt_LocationCode.ReadOnly = false;
            cmb_LocationCode.ReadOnly = false;
            txt_Remarks.ReadOnly = false;
        }

        private void Init_Toolbar()
        {
            tbtn_Save.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 버튼 이벤트 처리

        private void ClearAll()
        {
            fgrid_CurMat.ClearAll();
            fgrid_MatHistory.ClearAll();

            txt_MatNumber.ReadOnly = true;
            txt_Unit.ReadOnly = false;
            txt_Seq.ReadOnly = true;
            txt_MatName2.ReadOnly = false;
            txt_Width.ReadOnly = true;
            txt_UnitPrice.ReadOnly = false;
            cmb_Currency.ReadOnly = false;
            txt_ExtraCharge.ReadOnly = false;
            txt_SpecialOption.ReadOnly = true;
            cmb_FRTTerm.ReadOnly = false;
            txt_Loss.ReadOnly = false;
            txt_MOQ.ReadOnly = false;
            txt_ProdLocation.ReadOnly = false;
            txt_LocationCode.ReadOnly = false;
            cmb_LocationCode.ReadOnly = false;
            cmb_RPYn.ReadOnly = false;
            txt_Remarks.ReadOnly = false;

            txt_MatNumber.Text = "";
            txt_Unit.Text = "";
            txt_Seq.Text = "001";
            txt_MatName2.Text = "";
            txt_Width.Text = "0";
            txt_UnitPrice.Text = "0";
            cmb_Currency.Text = "USD";
            txt_ExtraCharge.Text = "0";
            txt_SpecialOption.Text = "";
            cmb_FRTTerm.Text = " ";
            txt_Loss.Text = "0";
            txt_MOQ.Text = "0";
            txt_ProdLocation.Text = "";
            txt_LocationCode.Text = "";
            cmb_LocationCode.SelectedIndex = -1;
            cmb_RPYn.SelectedValue = "N";
            txt_Remarks.Text = "";
        }

        private void New()
        {
            fgrid_CurMat.ClearAll();
            fgrid_MatHistory.ClearAll();

            txt_MatNumber.ReadOnly = false;
            txt_Unit.ReadOnly = false;
            txt_Seq.ReadOnly = true;
            txt_MatName2.ReadOnly = false;
            txt_Width.ReadOnly = false;
            txt_UnitPrice.ReadOnly = false;
            cmb_Currency.ReadOnly = false;
            txt_ExtraCharge.ReadOnly = false;
            txt_SpecialOption.ReadOnly = false;
            cmb_FRTTerm.ReadOnly = false;
            txt_Loss.ReadOnly = false;
            txt_MOQ.ReadOnly = false;
            txt_ProdLocation.ReadOnly = false;
            txt_LocationCode.ReadOnly = false;
            cmb_LocationCode.ReadOnly = false;
            cmb_RPYn.ReadOnly = false;
            txt_Remarks.ReadOnly = false;

            txt_MatNumber.Text = _sParentData[0];
            txt_Unit.Text = "";
            txt_Seq.Text = "";
            txt_MatName2.Text = _sParentData[1];
            txt_Width.Text = "0";
            txt_UnitPrice.Text = _sParentData[6];
            cmb_Currency.Text = _sParentData[5];
            txt_ExtraCharge.Text = "0";
            txt_SpecialOption.Text = "";
            cmb_FRTTerm.Text = _sParentData[3];
            txt_Loss.Text = _sParentData[9];
            txt_MOQ.Text = "0";
            txt_ProdLocation.Text = "";
            txt_LocationCode.Text = _sParentData[7];
            SearchCust();
            cmb_LocationCode.SelectedIndex = -1;
            cmb_RPYn.SelectedValue = "N";
            txt_Remarks.Text = "";
        }

        private void Search()
        {
            string sFactory = COM.ComVar.This_Factory;
            string sLocCode = txt_CustCode.Text;
            string sLocName = txt_CustName.Text;
            string sMatCode = txt_MatCode.Text;
            string sMatName = txt_MatName.Text;

            if (sLocCode.Trim().Equals("") && sLocName.Trim().Equals("") && sMatCode.Trim().Equals("") && sMatName.Trim().Equals(""))
                return;

            DataTable vDT = SELECT_SFX_MAT_LIST(sFactory, sLocCode, sLocName, sMatCode, sMatName);

            ClearAll();
            if (vDT != null && vDT.Rows.Count > 0)
            {
                //fgrid_CurMat.Display_Grid(vDT, true);
                for (int irIdx = 0; irIdx < vDT.Rows.Count; irIdx++)
                {
                    C1.Win.C1FlexGrid.Row iRow = fgrid_CurMat.Rows.Add();
                    iRow.IsNode = true;
                    iRow.Node.Level = Convert.ToInt32(vDT.Rows[irIdx][0].ToString());
                    fgrid_CurMat.GetCellRange(iRow.Index, 1, iRow.Index, fgrid_CurMat.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

                    if (iRow.Node.Level == 0)
                        iRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                    else
                        iRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;

                    for (int icIdx = 1; icIdx < vDT.Columns.Count; icIdx++)
                    {
                        iRow[icIdx] = vDT.Rows[irIdx][icIdx];
                    }
                }
            }

            fgrid_CurMat.Tree.Column = (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_MATERIAL_NAME; ;
        }

        private bool Save()
        {
            if (txt_MatNumber.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Empty material number");
                return false;
            }

            if (txt_Width.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Empty width");
                return false;
            }

            if (txt_MatName2.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Empty material name");
                return false;
            }

            if (txt_SpecialOption.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Empty special option");
                return false;
            }

            if (cmb_LocationCode.SelectedValue == null)
            {
                MessageBox.Show("Empty supplier");
                return false;
            }

            double dTmp = 0;
            double.TryParse(txt_Width.Text, out dTmp);
            txt_Width.Text = dTmp.ToString();

            double.TryParse(txt_UnitPrice.Text, out dTmp);
            txt_UnitPrice.Text = dTmp.ToString();

            double.TryParse(txt_ExtraCharge.Text, out dTmp);
            txt_ExtraCharge.Text = dTmp.ToString();

            double.TryParse(txt_Loss.Text, out dTmp);
            txt_Loss.Text = dTmp.ToString();

            double.TryParse(txt_MOQ.Text, out dTmp);
            txt_MOQ.Text = dTmp.ToString();

            return SAVE_SFX_MAT();
        }

        #endregion

        #region 그리드 이벤트 처리

        private void SelectMaterial()
        {
            int iCurRow = fgrid_CurMat.Row;

            txt_MatNumber.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMAT_NUMBER].ToString();
            txt_Unit.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_UNIT].ToString();
            txt_Seq.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_SEQ].ToString();
            txt_MatName2.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_MATERIAL_NAME].ToString();
            txt_Width.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_WIDTH].ToString();
            txt_UnitPrice.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_UNIT_PRICE].ToString();
            cmb_Currency.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_CURRENCY].ToString();
            txt_ExtraCharge.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_EXTRA_CHARGE].ToString();
            txt_SpecialOption.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_SPECIAL_OPTION].ToString();
            cmb_FRTTerm.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_DELIVERY_TERM].ToString();
            txt_Loss.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_LOSS].ToString();
            txt_MOQ.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_MOQ].ToString();
            txt_ProdLocation.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_PROD_LOCATION].ToString();
            txt_LocationCode.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_LOCATIONCODE].ToString();
            cmb_RPYn.SelectedValue = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxMXS_SINGLE_YN].ToString();
            if (txt_LocationCode.Text.Trim().Length > 1)
            {
                SearchCust(); 
                cmb_LocationCode.SelectedIndex = 0;
            }
            txt_Remarks.Text = fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_SEARCH.IxREMARKS].ToString();
        }

        #endregion

        #region 컨트롤 이벤트 처리

        private void SearchCust()
        {
            string sFactory = COM.ComVar.This_Factory;
            string sSchText = txt_LocationCode.Text;

            DataTable vDT = SELECT_SFX_CBD_M_CUST_LIST(sFactory, sSchText);
            COM.ComCtl.Set_ComboList(vDT, cmb_LocationCode, 0, 1);
        }

        #endregion

        #region 프로퍼티

        public string CustName
        {
            set
            {
                txt_CustName.Text = value;
            }
        }

        public string MatCode
        {
            set
            {
                txt_MatCode.Text = value;
            }
        }

        public string MatName
        {
            set
            {
                txt_MatName.Text = value;
            }
        }

        #endregion

        #endregion


        #region 데이터베이스

        /// <summary>
        /// PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_MAT_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_MAT_LIST(string arg_factory, string arg_mxs_locationcode, string arg_mxs_locationname_e, string arg_mat_code, string arg_mat_name)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_MAT_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_LOCATIONNAME_E";
                MyOraDB.Parameter_Name[3] = "ARG_MAT_CODE";
                MyOraDB.Parameter_Name[4] = "ARG_MAT_NAME";
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
                MyOraDB.Parameter_Values[1] = arg_mxs_locationcode;
                MyOraDB.Parameter_Values[2] = arg_mxs_locationname_e;
                MyOraDB.Parameter_Values[3] = arg_mat_code;
                MyOraDB.Parameter_Values[4] = arg_mat_name;
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
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_HISTORY : 
        /// </summary>
        private DataTable SELECT_SFX_MAT_HISTORY(string arg_factory, string arg_mxs_number, string arg_mxs_unit, string arg_mxs_special_option, string arg_mxs_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_HISTORY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_UNIT";
                MyOraDB.Parameter_Name[3] = "ARG_MXS_SPECIAL_OPTION";
                MyOraDB.Parameter_Name[4] = "ARG_MXS_SEQ";
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
                MyOraDB.Parameter_Values[1] = arg_mxs_number;
                MyOraDB.Parameter_Values[2] = arg_mxs_unit;
                MyOraDB.Parameter_Values[3] = arg_mxs_special_option;
                MyOraDB.Parameter_Values[4] = arg_mxs_seq;
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
        /// PKG_SFX_CBD_M_MAT.SAVE_SFX_MAT : 
        /// </summary>
        public bool SAVE_SFX_MAT()
        {
            try
            {

                MyOraDB.ReDim_Parameter(23);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_MAT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_MAT_NUMBER";
                MyOraDB.Parameter_Name[3] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[4] = "ARG_MXS_UNIT";
                MyOraDB.Parameter_Name[5] = "ARG_MXS_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_MXS_MATERIAL_NAME";
                MyOraDB.Parameter_Name[7] = "ARG_NIKE_MAT_NAME";
                MyOraDB.Parameter_Name[8] = "ARG_MXS_WIDTH";
                MyOraDB.Parameter_Name[9] = "ARG_MXS_UNIT_PRICE";
                MyOraDB.Parameter_Name[10] = "ARG_MXS_CURRENCY";
                MyOraDB.Parameter_Name[11] = "ARG_MXS_EXTRA_CHARGE";
                MyOraDB.Parameter_Name[12] = "ARG_MXS_SPECIAL_OPTION";
                MyOraDB.Parameter_Name[13] = "ARG_MXS_DELIVERY_TERM";
                MyOraDB.Parameter_Name[14] = "ARG_MXS_LOSS";
                MyOraDB.Parameter_Name[15] = "ARG_MXS_MOQ";
                MyOraDB.Parameter_Name[16] = "ARG_MXS_PROD_LOCATION";
                MyOraDB.Parameter_Name[17] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[18] = "ARG_MXS_SINGLE_YN";
                MyOraDB.Parameter_Name[19] = "ARG_STATUS";
                MyOraDB.Parameter_Name[20] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[21] = "ARG_MXS_CURRENT_YN";
                MyOraDB.Parameter_Name[22] = "ARG_UPD_USER";

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

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = txt_Seq.Text.Trim().Equals("") ? "I" : "U";
                MyOraDB.Parameter_Values[1] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[2] = txt_MatNumber.Text;
                MyOraDB.Parameter_Values[3] = txt_MatNumber.Text + "." + cmb_LocationCode.SelectedValue.ToString();
                MyOraDB.Parameter_Values[4] = txt_Unit.Text;
                MyOraDB.Parameter_Values[5] = txt_Seq.Text.Trim().Equals("") ? "001" : txt_Seq.Text;
                MyOraDB.Parameter_Values[6] = txt_MatName2.Text;
                MyOraDB.Parameter_Values[7] = txt_MatName2.Text;
                MyOraDB.Parameter_Values[8] = txt_Width.Text;
                MyOraDB.Parameter_Values[9] = txt_UnitPrice.Text;
                MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_Currency, "USD");
                MyOraDB.Parameter_Values[11] = txt_ExtraCharge.Text;
                MyOraDB.Parameter_Values[12] = txt_SpecialOption.Text;
                MyOraDB.Parameter_Values[13] = COM.ComFunction.Empty_Combo(cmb_FRTTerm, " ");
                MyOraDB.Parameter_Values[14] = txt_Loss.Text;
                MyOraDB.Parameter_Values[15] = txt_MOQ.Text;
                MyOraDB.Parameter_Values[16] = txt_ProdLocation.Text;
                MyOraDB.Parameter_Values[17] = cmb_LocationCode.SelectedValue.ToString();
                MyOraDB.Parameter_Values[18] = cmb_RPYn.SelectedValue.ToString();
                MyOraDB.Parameter_Values[19] = "C";
                MyOraDB.Parameter_Values[20] = txt_Remarks.Text;
                MyOraDB.Parameter_Values[21] = "Y";
                MyOraDB.Parameter_Values[22] = COM.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_CUST_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_CUST_LIST(string arg_factory, string arg_search_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_TYPE_SEARCH.SELECT_SFX_CBD_M_CUST_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_search_text;
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


        #endregion

    }
}

