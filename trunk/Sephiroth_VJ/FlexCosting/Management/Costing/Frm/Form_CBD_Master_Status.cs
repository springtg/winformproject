using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Frm
{
    public partial class Form_CBD_Master_Status : COM.PCHWinForm.Form_Top
    {
        #region Constract

        public Form_CBD_Master_Status()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion


        #region Extrn variable

        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();
        private COM.OraDB MyOraDB = new COM.OraDB(); 

        #endregion


        #region Event handler

        #region Form event handler

        #endregion

        #region Toolbar event handler

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            ClearAll();
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ClearAll();
                if (Search())
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
                else
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ClearAll();
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

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Control event handler

        private void cmb_SchSeasonFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
            cmb_SchSeasonTo.SelectedValue = cmb_SchSeasonFrom.SelectedValue;
        }

        private void cmb_SchDevFac_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void cmb_SchRound_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        #endregion

        #region Grid event handler

        private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                COM.FSP fsp = sender as COM.FSP;
                fsp.Buffer_CellData = fsp[e.Row, e.Col] == null ? "" : fsp[e.Row, e.Col].ToString();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Before edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                foreach (int iRow in fgrid_main.Selections)
                {
                    fgrid_main[iRow, e.Col] = fgrid_main[e.Row, e.Col];
                    fgrid_main.Update_Row(iRow);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "After edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion


        #region Event process

        #region Init

        private void Init_Form()
        {
            this.Text = "Sample / Quoted Status";
            this.lbl_MainTitle.Text = "Sample / Quoted Status";

            Init_Grid();
            Init_Control();
            Init_Toolbar();
        }

        private void Init_Toolbar()
        {
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Insert.Enabled = false;
        }

        private void Init_Control()
        {
            // Dev factory
            System.Data.DataTable vDT = COM.ComFunction.Select_Factory_List();
            cmb_SchDevFac.Enabled = true;
            cmb_SchDevFac.ReadOnly = false;
            COM.ComCtl.Set_ComboList(vDT, cmb_SchDevFac, 0, 1, false, false);
            cmb_SchDevFac.SelectedValue = COM.ComVar.This_Factory;
            vDT.Dispose();

            // Season
            vDT = _ComFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_SchSeasonFrom, 0, 1, false, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_SchSeasonTo, 0, 1, false, false);
            string sCurSeaMon = Math.Truncate((double)DateTime.Now.Month / 4) + 1 + "";
            string sCurSeason = DateTime.Now.AddYears(1).Year.ToString() + "0" + sCurSeaMon;
            cmb_SchSeasonFrom.SelectedValue = sCurSeason;
            cmb_SchSeasonTo.SelectedValue = sCurSeason;
            vDT.Dispose();

            // Fob Type
            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_SchRound, 1, 2, false, false);
            cmb_SchRound.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFX_CBD_MASTER_STATUS", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Font = new Font(fgrid_main.Font.FontFamily, (float)8.5);
            fgrid_main.ExtendLastCol = false;
        }

        #endregion

        #region Toolbar event process

        private bool ClearAll()
        {
            fgrid_main.ClearAll();
            return true;
        }

        private bool Search()
        {
            try
            {
                string sDevFac = COM.ComFunction.Empty_Combo(cmb_SchDevFac, "");
                string sSeasonFrom = COM.ComFunction.Empty_Combo(cmb_SchSeasonFrom, "");
                string sSeasonTo = COM.ComFunction.Empty_Combo(cmb_SchSeasonTo, "");
                string sMOID = COM.ComFunction.Empty_TextBox(txt_SchMOID, "");
                string sCBDID = COM.ComFunction.Empty_TextBox(txt_SchCBDID, "");
                string sFobType = COM.ComFunction.Empty_Combo(cmb_SchRound, "");

                DataTable vDT = SELECT_SFX_CBD_MASTER_STATUS(sDevFac, sSeasonFrom, sSeasonTo, sMOID, sCBDID, sFobType);

                if (vDT != null && vDT.Rows.Count > 0)
                {
                    fgrid_main.Display_Grid(vDT, false);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Search() :: " + ex.Message);
            }
        }

        private bool Save()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                return MyOraDB.Save_FlexGird("PKG_SFX_CBD_MASTER_STATUS.SAVE_SFX_CBD_MASTER_STATUS", fgrid_main);
            }
            catch (Exception ex)
            {
                throw new Exception("Save() :: " + ex.Message);
            }
        }

        private void Print()
        {
            try
            {
                SaveFileDialog save_file = new SaveFileDialog();
                save_file.InitialDirectory = "C:\\";
                save_file.AddExtension = true;
                save_file.DefaultExt = "xls";


                if (save_file.ShowDialog() == DialogResult.OK)
                {
                    string save_path = save_file.FileName;
                    fgrid_main.SaveExcel(save_path, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Print() :: " + ex.Message);
            }
        }

        #endregion

        #region Control event process



        #endregion

        #endregion


        #region Database

        #region Search

        /// <summary>
        /// PKG_SFX_CBD_MASTER_STATUS.SELECT_SFX_CBD_MASTER_STATUS : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_MASTER_STATUS(string arg_factory, string arg_season_from, string arg_season_to, string arg_moid, string arg_bom_id, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_STATUS.SELECT_SFX_CBD_MASTER_STATUS";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_MOID";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "ARG_FOB_TYPE_CD";
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
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season_from;
                MyOraDB.Parameter_Values[2] = arg_season_to;
                MyOraDB.Parameter_Values[3] = arg_moid;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = arg_fob_type_cd;
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

        #endregion

        #endregion

    }
}

