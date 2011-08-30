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
    public partial class Pop_CBD_Master_Print : COM.PCHWinForm.Pop_Large
    {
        public Pop_CBD_Master_Print(string arg_PGType, Frm.Form_CBD_Master_v6 arg_parent)
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

        private System.Threading.Thread vThExcel = null;
        FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220.ExcelExport vExp2 = null;

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

        #region 컨트롤 이벤트

        private void txt_searchText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClearAll();
                Search();
            }
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

        private void ctxt_exl_Click(object sender, EventArgs e)
        {
            if (vThExcel == null || !vThExcel.IsAlive)
            {
                ExportExcel();
            }
        }

        private void ExportExcel()
        {
            //FolderBrowserDialog vFBO = new FolderBrowserDialog();
            //if (vFBO.ShowDialog() == DialogResult.OK)
            //{
                vExp2 = new FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220.ExcelExport();
                //vExp2.sFilePath = vFBO.SelectedPath + "\\";                
                vExp2.sFilePath = Application.StartupPath + "\\";

                System.Collections.ArrayList vArr = new System.Collections.ArrayList();

                int iIdx = 0;
                foreach (int iRow in fgrid_main.Selections)
                {
                    if (iIdx < 20)
                    {
                        string sDevFac = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxDEV_FACTORY].ToString();
                        string sMOID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxMOID].ToString().Replace("-", "");
                        string sCBDID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxCBD_ID].ToString();
                        string sCBDVer = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxCBD_VER].ToString();
                        string sFobType = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxFOB_TYPE_CD].ToString();
                        string sSeasonCode = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxSEASON_CD].ToString();

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
            //}
        }

        private void ctxt_xml_Click(object sender, EventArgs e)
        {
            ExportXML();
        }

        private void ExportXML()
        {
            FolderBrowserDialog vFBO = new FolderBrowserDialog();
            if (vFBO.ShowDialog() == DialogResult.OK)
            {
                FlexCosting.Management.Costing.Frm.XMLExporter vExp = new FlexCosting.Management.Costing.Frm.XMLExporter();

                int[] iSels = fgrid_main.Selections;
                foreach (int iRow in iSels)
                {
                    string sDevFac = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxDEV_FACTORY].ToString();
                    string sMOID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxMOID].ToString().Replace("-", "");
                    string sCBDID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxCBD_ID].ToString();
                    string sCBDVer = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxCBD_VER].ToString();
                    string sFobType = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxFOB_TYPE_CD].ToString();
                    string sSeasonCode = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxSEASON_CD].ToString();
                    string sProdFac = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxPROD_FACTORY].ToString();
                    string sPath = vFBO.SelectedPath + "\\";

                    string sSeason = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxSEASON_NAME].ToString(); ;
                    string sDevName = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxMOID].ToString(); ;
                    string sModelName = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxMODEL_NAME].ToString(); ;
                    string sBOMID = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxCBD_ID].ToString(); ;
                    string sRound = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxROUND_TYPE].ToString(); ;

                    string sXMLSeq = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxXML_SEQ].ToString(); ;

                    // _path, _season, _dev_name, _model_name, _bom_id, _fob_type;
                    vExp.Path = sPath;
                    vExp.Season = sSeason;
                    vExp.Dev_name = sDevName;
                    vExp.Model_name = sModelName;
                    vExp.Bom_id = sBOMID;
                    vExp.Fob_type = sRound;
                    vExp.Prod_fac = sProdFac;

                    if (iSels[0] == iRow)
                    {
                        vExp.CreateXML(iSels.Length > 1);
                    }

                    vExp.Dev_fac = sDevFac;
                    vExp.Moid = sMOID;
                    vExp.Cbd_id = sCBDID;
                    vExp.Cbd_ver = sCBDVer;
                    vExp.Fob_type_cd = sFobType;
                    vExp.XMLSeq = Convert.ToInt32(sXMLSeq);

                    vExp.ExportXML();
                }

                vExp.flushXML();
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

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFX_CBD_MASTER_PRINT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
        }

        private void Init_Control()
        {
            // Factory
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_devFac, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_devFac.SelectedValue = COM.ComVar.This_Factory;

            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_prodFac, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_prodFac.SelectedValue = " ";
            vDT.Dispose();

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

            // Round
            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_round, 1, 2, true, false);
            cmb_round.SelectedValue = " ";
            vDT.Dispose();


            chk_CBD.Checked = true;
            chk_BOM.Checked = false;
            this.Text = "CBD Search";
            this.lbl_MainTitle.Text = "CBD Search";
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
            string sProdFac = COM.ComFunction.Empty_Combo(cmb_prodFac, "");
            string sSeason = COM.ComFunction.Empty_Combo(cmb_season, "");
            string sCategory = COM.ComFunction.Empty_Combo(cmb_category, "");
            string sDevName = COM.ComFunction.Empty_Combo(cmb_round, "");
            string sSchText = COM.ComFunction.Empty_TextBox(txt_searchText, "").Replace("-", "");

            if (chk_CBD.Checked)
            {
                DataTable vDT = SELECT_CBD_LIST_PRINT(sDevFac, sProdFac, sSeason, sCategory, sDevName, sSchText);
                if (vDT != null && vDT.Rows.Count > 0)
                {
                    fgrid_main.Display_Grid_Add(vDT, false);
                }
            }

            for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
            {
                string sClasstype = fgrid_main[iRow, (int)ClassLib.TBSFX_CBD_MASTER_PRINT.IxCLASS_NAME].ToString();

                if (sClasstype.Equals("BOM"))
                    fgrid_main.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrCBDGubun[0];
                else
                    fgrid_main.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrCBDGubun[2];
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

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

        public string SEARCH_TEXT
        {
            set
            {
                txt_searchText.Text = value;
            }
        }
        
        #endregion

        #endregion

        #endregion

        #region 디비 연결

        #region 조회

        /// <summary>
        /// PKG_SFM_CBD_SEARCH_BOM.SELECT_CBD_LIST_PRINT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_CBD_LIST_PRINT(string arg_dev_factory, string arg_prod_factory, string arg_season, string arg_category, string arg_dev_name, string arg_sch_text)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_SEARCH_BOM.SELECT_CBD_LIST_PRINT";

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

        #endregion

        #endregion

    }
}

