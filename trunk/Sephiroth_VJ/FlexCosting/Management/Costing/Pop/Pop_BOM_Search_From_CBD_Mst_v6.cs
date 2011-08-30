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
    public partial class Pop_BOM_Search_From_CBD_Mst_v6 : COM.PCHWinForm.Pop_Large
    {
        public Pop_BOM_Search_From_CBD_Mst_v6(string arg_PGType, Frm.Form_CBD_Master_v6 arg_parent)
        {
            InitializeComponent();

            _Parent = arg_parent;
            _PGType = arg_PGType;

            Init_Form();
        }

        #region 전역 변수 선언 및 정의

        private Frm.Form_CBD_Master_v6 _Parent = null;
        private COM.OraDB MyOraDB = new COM.OraDB();
        private string _PGType = null;

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
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        private void fgrid_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed && fgrid_main.Row >= fgrid_main.Rows.Fixed)
                {
                    bool bFlag = true;
                    int vRow = fgrid_main.Row;
                    string sClass = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCLASS_NAME].ToString();

                    switch (sClass)
                    {
                        case "BOM":
                            bFlag = SelectBOM();
                            break;
                        case "CBD":
                            bFlag = SelectCBD();
                            break;
                        default:
                            bFlag = false;
                            break;
                    }

                    if (bFlag)
                    {
                        this.DialogResult = DialogResult.OK;
                        if (!sClass.Equals("CBD"))
                            this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Double Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 컨트롤 이벤트

        private void txt_searchText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    ClearAll();
                    Search();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_OpenNew_Click(object sender, EventArgs e)
        {
            FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 vMewForm = new FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6();
            FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 vTmpForm = _Parent;

            try
            {
                _Parent = vMewForm;
                _Parent.Show();

                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed && fgrid_main.Row >= fgrid_main.Rows.Fixed)
                {
                    bool bFlag = true;
                    int vRow = fgrid_main.Row;
                    string sClass = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCLASS_NAME].ToString();

                    switch (sClass)
                    {
                        case "BOM":
                            bFlag = SelectBOM();
                            _Parent.DIVISION = "I";
                            break;
                        case "CBD":
                            bFlag = SelectCBD();
                            _Parent.DIVISION = "U";
                            break;
                        default:
                            bFlag = false;
                            break;
                    }

                    if (bFlag)
                    {
                        this.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                _Parent.Close();
                ClassLib.ComFunction.User_Message(ex.Message, "Open New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _Parent = vTmpForm;
            }
        }

        private void ctxt_OpenMain_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed && fgrid_main.Row >= fgrid_main.Rows.Fixed)
                {
                    bool bFlag = true;
                    int vRow = fgrid_main.Row;
                    string sClass = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCLASS_NAME].ToString();

                    switch (sClass)
                    {
                        case "BOM":
                            bFlag = SelectBOM();
                            _Parent.DIVISION = "I";
                            break;
                        case "CBD":
                            bFlag = SelectCBD();
                            _Parent.DIVISION = "U";
                            break;
                        default:
                            bFlag = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Open Main", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClassLib.ComFunction.User_Message("Do you want to confirm CBD?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Confirm();
                    MessageBox.Show("Confirm complete.", "Confirm");
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        
        private void ctx_main_Opening(object sender, CancelEventArgs e)
        {
            if (_PGType.Equals("10"))
            {
                ctxt_bar1.Visible = false;
                ctxt_confirm.Visible = false;
            }
            else
            {
                ctxt_bar1.Visible = true;
                ctxt_confirm.Visible = true;
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
                this.Text = "CBD and BOM Search";
                this.lbl_MainTitle.Text = "CBD and BOM Search";

                Init_Grid();
                Init_Control();
                Init_Toolbar();

                this.TopMost = true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            if (_PGType.Equals("10"))
            {
                fgrid_main.Set_Grid("SFX_CBD_MASTER_SEARCH_BOM", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
                fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            }
            else
            {
                fgrid_main.Set_Grid("SFX_CBD_MASTER_SEARCH_CBD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
                fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            }
        }

        private void Init_Control()
        {
            // Factory
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_devFac, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_devFac.SelectedValue = COM.ComVar.This_Factory;

            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_ProdFac, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_ProdFac.SelectedValue = " ";
            vDT.Dispose();

            if (COM.ComVar.This_CDCPower_Level.Equals("C01"))
            {
                cmb_devFac.ReadOnly = false;
                cmb_devFac.Enabled = true;

                cmb_ProdFac.ReadOnly = false;
                cmb_ProdFac.Enabled = true;
            }
            else
            {
                cmb_devFac.ReadOnly = true;
                cmb_devFac.Enabled = false;

                cmb_ProdFac.ReadOnly = true;
                cmb_ProdFac.Enabled = false;
            }

            ClassLib.ComFunction_Cost comFnc = new ClassLib.ComFunction_Cost();


            // Season
            vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_season, 0, 1, true, false);

            string sCurSeaMon = Math.Truncate((double)DateTime.Now.AddYears(1).Month / 4) + 1 + "";
            cmb_season.SelectedValue = DateTime.Now.AddYears(1).Year.ToString() + "0" + sCurSeaMon;
            vDT.Dispose();

            // Category
            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "MD02");
            COM.ComCtl.Set_ComboList(vDT, cmb_category, 1, 2, true, false);
            cmb_category.SelectedValue = " ";
            vDT.Dispose();

            // FOB Type code
            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_round, 1, 2, true, false);
            cmb_round.SelectedValue = " ";
            vDT.Dispose();


            if (_PGType.Equals("10"))
            {
                chk_CBD.Checked = false;
                chk_BOM.Checked = true;
                this.Text = "BOM Search";
                this.lbl_MainTitle.Text = "BOM Search";
                cmb_round.ReadOnly = true;
                cmb_round.Enabled = false;
            }
            else if (_PGType.Equals("30"))
            {
                chk_CBD.Checked = true;
                chk_BOM.Checked = false;
                this.Text = "CBD Search";
                this.lbl_MainTitle.Text = "CBD Search";
                cmb_round.ReadOnly = false;
                cmb_round.Enabled = true;
            }
            else
            {
                chk_CBD.Checked = false;
                chk_BOM.Checked = false;
            }
        }

        private void Init_Toolbar()
        {
            this.tbtn_New.Enabled = false;
            this.tbtn_Save.Enabled = false;
            this.tbtn_Delete.Enabled = false;
            this.tbtn_Print.Enabled = false;
            this.tbtn_Conform.Enabled = false;
            this.tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_main.ClearAll();
        }

        public void Search()
        {
            string sDevFac = COM.ComFunction.Empty_Combo(cmb_devFac, "");
            string sProdFac = COM.ComFunction.Empty_Combo(cmb_ProdFac, "");            
            string sSeason = COM.ComFunction.Empty_Combo(cmb_season, "");
            string sCategory = COM.ComFunction.Empty_Combo(cmb_category, "");
            string sRound = COM.ComFunction.Empty_Combo(cmb_round, ""); ;
            string sSchText = COM.ComFunction.Empty_TextBox(txt_searchText, "").Replace("-", "");

            if (chk_CBD.Checked)
            {
                DataTable vDT = SELECT_CBD_LIST(sDevFac, sProdFac, sSeason, sCategory, sRound, sSchText);
                if (vDT != null && vDT.Rows.Count > 0)
                {
                    fgrid_main.Display_Grid_Add(vDT, false);
                }
            }

            if (chk_BOM.Checked)
            {
                DataTable vDT = SELECT_BOM_LIST(sDevFac, sProdFac, sSeason, sCategory, sRound, sSchText);
                if (vDT != null && vDT.Rows.Count > 0)
                {
                    fgrid_main.Display_Grid_Add(vDT, false);
                }
            }

            // issued date를 임시로 status 필드로 사용합니다. 
            for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
            {
                string sStatus = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxISSUED_DATE].ToString();

                if (sStatus.Equals("S"))
                    fgrid_main.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrCBDGubun[0];
                else
                    fgrid_main.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrCBDGubun[2];
            }
        }

        #endregion

        #region 그리드 이벤트

        private bool SelectBOM()
        {
            try
            {
                ClassLib.ComFunction_Cost costCom = new FlexCosting.ClassLib.ComFunction_Cost();

                int iRow = fgrid_main.Row;

                string sDevFac = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxDEV_FACTORY].ToString();
                string sSRNo = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxSR_NO].ToString();
                string sMOID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxMOID].ToString();
                string sBOMID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxBOM].ToString();
                string sBOMRev = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxBOM_REV].ToString();
                string sNFCD = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxFOB_TYPE_CD].ToString();
                string sSRFSeq = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxSRF_SEQ].ToString();

                string sSeasonCD = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxSEASON_CD].ToString();
                string sCategoryCD = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCATEGORY_NAME].ToString();
                string sGendorCD = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxGEN_CD].ToString();
                string sModelID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxMODEL_ID].ToString();
                string sModelName = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxMODEL_NAME].ToString();

                // Head
                DataTable vDT = costCom.SELECT_SXD_SRF_HEAD(sDevFac, sSRNo, sMOID, sBOMID, sBOMRev, sNFCD, sSRFSeq, sSeasonCD, sModelID);
                _Parent.LoadBOMHead(vDT);
                vDT.Dispose();

                // F/X Rate
                string sSeason = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxSEASON_CD].ToString();
                vDT = costCom.SELECT_SFX_CBD_FXRATE(sDevFac, null, null, null, null, sSeason);
                _Parent.DisplayFXRate(vDT);
                vDT.Dispose();

                if (_PGType.Equals("10"))
                {
                    // Tail
                    string[] proc = new string[] { "PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL", 
                                                "PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_LB", 
                                                "PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_OH"};

                    string sSDMYN = "N";
                    if (sModelName.IndexOf('+') > 0)
                        sSDMYN = "Y";
                    if (costCom.SELECT_SXD_SRF_TAIL_PK(sDevFac, sSRNo, sMOID, sBOMID, sBOMRev, sNFCD, sSRFSeq, sSeasonCD, sCategoryCD, sGendorCD, sSDMYN))
                    {
                        DataSet vDS = costCom.SELECT_SXD_SRF_TAIL(proc, sDevFac, sSRNo, sMOID, sBOMID, sBOMRev, sNFCD, sSRFSeq);
                        _Parent.LoadBOMDetail(vDS);
                    }
                }
                vDT.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select bom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SelectCBD()
        {
            try
            {
                int vRow = fgrid_main.Row;

                // arg_factory, arg_moid, arg_cbd_id, arg_cbd_seq, arg_fob_type_cd
                string sDevFac = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxDEV_FACTORY].ToString();
                string sProdFac = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxPROD_FACTORY].ToString();
                string sMOID = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxMOID].ToString(); ;
                string sCBDID = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCBD_ID].ToString(); ;
                string sCBDVer = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCBD_VER].ToString(); ;
                string sFOBType = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxFOB_TYPE_CD].ToString();

                ClassLib.ComFunction_Cost costCom = new FlexCosting.ClassLib.ComFunction_Cost();

                // Header 
                DataTable vDTH = costCom.SELECT_SFX_CBD_HEAD(sDevFac, sMOID, sCBDID, sCBDVer, sFOBType);
                _Parent.LoadCBDHead(vDTH);
                vDTH.Dispose();

                // F/X Rate
                string sSeason = fgrid_main[vRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxSEASON_CD].ToString();
                DataTable vDT = costCom.SELECT_SFX_CBD_FXRATE(sDevFac, sMOID, sCBDID, sCBDVer, sFOBType, sSeason);
                _Parent.DisplayFXRate(vDT);
                vDT.Dispose();

                // Detail 
                string[] procs = new string[] {
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_LB",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_OH",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_SM",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_PM", };
                
                DataSet vDST = costCom.SELECT_SFX_CBD_TAIL(procs, sDevFac, sMOID, sCBDID, sCBDVer, sFOBType);
                _Parent.LoadCBDDetail(vDST);
                vDST.Dispose();

                return true;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select bom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void Confirm()
        {
            SAVE_SFX_CBD_MASTER_CONFIRM();
        }

        #region Property

        public string DEV_FACTORY
        {
            set
            {
                cmb_devFac.SelectedValue = value;
            }
        }

        public string SEASON
        {
            set
            {
                cmb_season.SelectedValue = value;
            }
        }

        public string CATEGORY
        {
            set
            {
                cmb_category.SelectedValue = value;
            }
        }
        
        #endregion

        #endregion

        #endregion

        #region 디비 연결

        #region 조회

        /// <summary>
        /// PKG_SFM_CBD_SEARCH_BOM.SELECT_CBD_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_CBD_LIST(string arg_dev_factory, string arg_prod_factory, string arg_season, string arg_category, string arg_dev_name, string arg_sch_text)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_SEARCH_BOM.SELECT_CBD_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_DEV_NAME";
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
                MyOraDB.Parameter_Values[0] = arg_dev_factory;
                MyOraDB.Parameter_Values[1] = arg_prod_factory;
                MyOraDB.Parameter_Values[2] = arg_season;
                MyOraDB.Parameter_Values[3] = arg_category;
                MyOraDB.Parameter_Values[4] = arg_dev_name;
                MyOraDB.Parameter_Values[5] = arg_sch_text;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS == null)
                    return null;

                return vDS.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFM_CBD_SEARCH_BOM.SELECT_BOM_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_BOM_LIST(string arg_dev_factory, string arg_prod_factory, string arg_season, string arg_category, string arg_dev_name, string arg_sch_text)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_SEARCH_BOM.SELECT_BOM_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_DEV_NAME";
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
                MyOraDB.Parameter_Values[0] = arg_dev_factory;
                MyOraDB.Parameter_Values[1] = arg_prod_factory;
                MyOraDB.Parameter_Values[2] = arg_season;
                MyOraDB.Parameter_Values[3] = arg_category;
                MyOraDB.Parameter_Values[4] = arg_dev_name;
                MyOraDB.Parameter_Values[5] = arg_sch_text;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS == null)
                    return null;

                return vDS.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_MASTER_CONFIRM : 
        /// </summary>
        private bool SAVE_SFX_CBD_MASTER_CONFIRM()
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_MASTER_CONFIRM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

                //04.DATA 정의
                int iIdx = 0;
                int[] iRows = fgrid_main.Selections;
                MyOraDB.Parameter_Values = new string[iRows.Length * MyOraDB.Parameter_Name.Length];

                foreach (int iRow in iRows)
                {
                    MyOraDB.Parameter_Values[iIdx++] = "C";
                    MyOraDB.Parameter_Values[iIdx++] = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxDEV_FACTORY].ToString();
                    MyOraDB.Parameter_Values[iIdx++] = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxMOID].ToString();
                    MyOraDB.Parameter_Values[iIdx++] = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCBD_ID].ToString();
                    MyOraDB.Parameter_Values[iIdx++] = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxCBD_VER].ToString();
                    MyOraDB.Parameter_Values[iIdx++] = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_SEARCH.IxFOB_TYPE_CD].ToString();
                    MyOraDB.Parameter_Values[iIdx++] = COM.ComVar.This_User; 
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

        #endregion

        #endregion

    }
}

