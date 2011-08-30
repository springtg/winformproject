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
    public partial class Pop_Search_Part_For_Upper : COM.PCHWinForm.Pop_Medium
    {
        public Pop_Search_Part_For_Upper()
        {
            InitializeComponent();

            Init_Form();
        }

        public Pop_Search_Part_For_Upper(FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 arg_ParentForm)
        {
            InitializeComponent();

            _ParentForm = arg_ParentForm;
            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();
        private FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 _ParentForm = null;
        private COM.OraDB MyOraDB = new COM.OraDB();


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

                ClearAll();
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

        #endregion

        #region 그리드 이벤트

        private void fgrid_cbd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_cbd.Row >= fgrid_cbd.Rows.Fixed)
                    SelectCBD();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                ClearAll();
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

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void cmb_seasonFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
            cmb_seasonTo.SelectedValue = cmb_seasonFrom.SelectedValue;
        }

        private void ctxt_copyMat_Click(object sender, EventArgs e)
        {
            try
            {
                CopyToParentForm();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Text = "Part Search";
                this.lbl_MainTitle.Text = "Part Search";

                Init_Grid();
                Init_Control();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            // cbd list grid 
            fgrid_cbd.Set_Grid("SFX_CBD_HEAD_COPY", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cbd.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_cbd.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cbd.Font = new Font(fgrid_cbd.Font.FontFamily, (float)8);

            // up, pk, ms, os grid
            fgrid_mat.Set_Grid("SFX_CBD_TAIL_COPY", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_mat.AllowEditing = false;
            fgrid_mat.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_mat.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_mat.Font = new Font(fgrid_mat.Font.FontFamily, (float)8);
            fgrid_mat.Rows[fgrid_mat.Rows.Fixed - 1].HeightDisplay = fgrid_mat.Rows[fgrid_mat.Rows.Fixed - 1].HeightDisplay * 2;
            fgrid_mat.Rows[fgrid_mat.Rows.Fixed - 1].Style.WordWrap = true;

            for (int iCol = 1; iCol < fgrid_mat.Cols.Count; iCol++)
            {
                if (fgrid_mat.Cols[iCol].DataType == typeof(System.Double))
                {
                    fgrid_mat.Cols[iCol].Style.Format = "#,##0.00##";
                }
            }

            // mold grid
            fgrid_mold.Set_Grid("SFX_CBD_TAIL_MOLD_COPY", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_mold.AllowEditing = false;
            fgrid_mold.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_mold.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_mold.Font = new Font(fgrid_mold.Font.FontFamily, (float)8);
            fgrid_mold.Rows[fgrid_mold.Rows.Fixed - 1].HeightDisplay = fgrid_mold.Rows[fgrid_mold.Rows.Fixed - 1].HeightDisplay * 2;
            fgrid_mold.Rows[fgrid_mold.Rows.Fixed - 1].Style.WordWrap = true;

            for (int iCol = 1; iCol < fgrid_mold.Cols.Count; iCol++)
            {
                if (fgrid_mold.Cols[iCol].DataType == typeof(System.Double))
                {
                    fgrid_mold.Cols[iCol].Style.Format = "#,##0.00##";
                }
            }
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List_Cost();
            COM.ComCtl.Set_ComboList(vDT, cmb_devFac, 0, 1, false, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_prodFac, 0, 1, true, false);
            vDT.Dispose();
            cmb_devFac.SelectedValue = COM.ComVar.This_Factory;
            cmb_prodFac.SelectedValue = " ";
            cmb_devFac.ReadOnly = cmb_prodFac.ReadOnly = false;
            cmb_devFac.Enabled = cmb_prodFac.Enabled = true;

            if (COM.ComVar.This_CDCPower_Level.Equals("C01"))
            {
                cmb_devFac.ReadOnly = false;
                cmb_devFac.Enabled = true;

                cmb_prodFac.ReadOnly = false;
                cmb_prodFac.Enabled = true;
            }
            else
            {
                cmb_devFac.ReadOnly = true;
                cmb_devFac.Enabled = false;

                cmb_prodFac.ReadOnly = true;
                cmb_prodFac.Enabled = false;
            }


            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_fobType, 1, 2, true, false);
            vDT.Dispose();
            cmb_fobType.SelectedValue = " ";


            vDT = _ComFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_seasonFrom, 0, 1, false, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_seasonTo, 0, 1, false, false);
            vDT.Dispose();
            cmb_seasonFrom.SelectedIndex = 0;
            cmb_seasonTo.SelectedIndex = 0;
        }

        public void Init_Control(string sDevFac, string sProdFac, string sSeason, string sMOID)
        {
            try
            {
                cmb_devFac.SelectedValue = sDevFac;
                cmb_prodFac.SelectedValue = sProdFac;
                cmb_seasonFrom.SelectedValue = cmb_seasonTo.SelectedValue = sSeason;
                txt_searchText.Text = sMOID;

                Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_cbd.ClearAll();
            fgrid_mat.ClearAll();
        }

        private void Search()
        {
            DataTable vDT = SELECT_SFX_CBD_HEAD_LIST();

            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_cbd.Display_Grid(vDT, false);
            }
        }

        #endregion

        #region 그리드 이벤트

        private void SelectCBD()
        {
            fgrid_mat.ClearAll();

            int iRow = fgrid_cbd.Row;
            string sDevFac = fgrid_cbd[iRow, (int)ClassLib.TBSFX_CBD_HEAD_COPY.IxDEV_FAC].ToString();
            string sMOID = fgrid_cbd[iRow, (int)ClassLib.TBSFX_CBD_HEAD_COPY.IxMOID].ToString();
            string sCBDID = fgrid_cbd[iRow, (int)ClassLib.TBSFX_CBD_HEAD_COPY.IxCBD_ID].ToString();
            string sCBDVer = fgrid_cbd[iRow, (int)ClassLib.TBSFX_CBD_HEAD_COPY.IxCBD_VER].ToString();
            string sFobTypeCD = fgrid_cbd[iRow, (int)ClassLib.TBSFX_CBD_HEAD_COPY.IxFOB_TYPE_CD].ToString();

            DataTable vDT = SELECT_SFX_CBD_TAIL_UP(sDevFac, sMOID, sCBDID, sCBDVer, sFobTypeCD);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_mat.Display_Grid(vDT, false);
            }

            DataTable vDTM = SELECT_SFX_CBD_TAIL_MOLD(sDevFac, sMOID, sCBDID, sCBDVer, sFobTypeCD);

            if (vDTM != null && vDTM.Rows.Count > 0)
            {
                fgrid_mold.Display_Grid(vDTM, false);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void CopyToParentForm()
        {
            string sDiv = "MAT";
            C1.Win.C1FlexGrid.Row[] vDatas = null;

            if (tab_detail.SelectedTab.Name.Equals(tab_mat.Name))
            {
                sDiv = "MAT";

                int[] iSels = fgrid_mat.Selections;
                int iIdx = 0;

                vDatas = new C1.Win.C1FlexGrid.Row[iSels.Length];

                foreach (int iRow in iSels)
                {
                    vDatas[iIdx] = fgrid_mat.Rows[iRow];
                    iIdx++;
                }
            }
            else
            {
                sDiv = "MOLD";

                int[] iSels = fgrid_mold.Selections;
                int iIdx = 0;

                vDatas = new C1.Win.C1FlexGrid.Row[iSels.Length];

                foreach (int iRow in iSels)
                {
                    vDatas[iIdx] = fgrid_mold.Rows[iRow];
                    iIdx++;
                }
            }

            _ParentForm.CopyCBDFormOtherCBD(sDiv, vDatas);
        }

        #endregion

        #region Property 

        public string DEV_FACTORY
        {
            set
            {
                cmb_devFac.SelectedValue = value;
            }
        }

        public string PROD_FACTORY
        {
            set
            {
                cmb_prodFac.SelectedValue = value;
            }
        }

        public string SEASON
        {
            set
            {
                cmb_seasonFrom.SelectedValue = value;
                cmb_seasonTo.SelectedValue = value;
            }
        }

        public string FOB_TYPE
        {
            set
            {
                cmb_fobType.SelectedValue = value;
            }
        }

        #endregion

        #endregion

        #region 디비 연결

        #region 조건



        #endregion

        #region 조회


        /// <summary>
        /// PKG_SFX_CBD_MASTER_COPY.SELECT_SFM_CBD_HEAD_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_HEAD_LIST()
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_COPY.SELECT_SFX_CBD_HEAD_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_SCH_TEXT";
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
                MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_devFac, "");
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_prodFac, "");
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_seasonFrom, "");
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_seasonTo, "");
                MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_fobType, "");
                MyOraDB.Parameter_Values[5] = txt_searchText.Text;
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

        /// <summary>
        /// PKG_SFX_CBD_MASTER_COPY.SELECT_SFM_CBD_TAIL1_UP : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_TAIL_UP(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_COPY.SELECT_SFX_CBD_TAIL";

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
        /// PKG_SFX_CBD_MASTER_COPY.SELECT_SFM_CBD_TAIL1_UP : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_TAIL_MOLD(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_COPY.SELECT_SFX_CBD_TAIL_MOLD";

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

        #endregion

        #endregion

    }
}

