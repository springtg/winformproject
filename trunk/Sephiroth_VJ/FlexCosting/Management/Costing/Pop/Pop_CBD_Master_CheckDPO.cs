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
    public partial class Pop_CBD_Master_CheckDPO : COM.PCHWinForm.Pop_Large
    {
        FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 _Parent = null;

        public Pop_CBD_Master_CheckDPO()
        {
            InitializeComponent();
            Init_Form();
        }

        #region 이벤트 핸들러

        private void Init_Form()
        {
            try
            {
                this.Text = "Exist DPO, please check again";
                this.lbl_MainTitle.Text = "Exist DPO, please check again";

                fgrid_main.Set_Grid("SFX_CBD_MASTER_SEARCH_CBD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
                fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayGrid(DataTable vDT)
        {
            try
            {
                fgrid_main.Display_Grid(vDT, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void fgrid_main_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed && fgrid_main.Row >= fgrid_main.Rows.Fixed)
                {
                    _Parent = new FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6();
                    _Parent.Show();

                    SelectCBD();
                    _Parent.DIVISION = "U";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open");
            }
        }

        #endregion

    }
}

