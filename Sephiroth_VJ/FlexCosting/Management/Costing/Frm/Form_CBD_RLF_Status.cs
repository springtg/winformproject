using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Frm
{
    public partial class Form_CBD_RLF_Status : COM.PCHWinForm.Form_Top
    {
        #region Constract

        public Form_CBD_RLF_Status()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion



        #region Extrn variable

        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();

        #endregion



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

        #endregion


        #region Control event handler

        #endregion



        #region Event process

        #region 

        private void Init_Form()
        {
            this.Text = "RLF Status";
            this.lbl_MainTitle.Text = "RLF Status";

            Init_Grid();
            Init_Control();
            Init_Toolbar();
        }

        private void Init_Toolbar()
        {
            tbtn_New.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Print.Enabled = false; 
        }

        private void Init_Control()
        {
            // Dev factory
            System.Data.DataTable vDT = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(vDT, cmb_SchDevFac, 0, 1, false, false);
            cmb_SchDevFac.SelectedValue = COM.ComVar.This_Factory;
            vDT.Dispose();

            // Season
            vDT = _ComFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_SchSeason, 1, 2, true, false);
            cmb_SchSeason.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

            // Category
            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_48");
            COM.ComCtl.Set_ComboList(vDT, cmb_SchCategory, 1, 2, true, false);
            cmb_SchCategory.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFX_CBD_TAIL_PK", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Font = new Font(fgrid_main.Font.FontFamily, (float)8.5);
            fgrid_main.ExtendLastCol = false;
        }

        #endregion

        #region Form event process

        private bool ClearAll()
        {
            fgrid_main.ClearAll();
            return true;
        }

        private bool Search()
        {
            try
            {
                DataTable vDT = null;

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
                return MyOraDB.Save_FlexGird("proc_name", fgrid_main);
            }
            catch (Exception ex)
            {
                throw new Exception("Save() :: " + ex.Message);
            }   
        }

        #endregion


        #region Toolbar event process

        #endregion


        #region Control event process



        #endregion

        #endregion



        #region Database

        #region Init


        #endregion

        #region Search


        #endregion

        #endregion
    }
}

