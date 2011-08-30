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

namespace FlexCosting.v5523.Pop
{
    public partial class Pop_5523_List_Loading : COM.PCHWinForm.Form_Top
    {
        #region User Variable Define
        private COM.OraDB MyOraDB = new COM.OraDB();    
    
        private FlexCosting.v5523.Frm.Form_5523_Management _main_form;

        public bool loading_flg = false;
        #endregion

        #region Constructor
        public Pop_5523_List_Loading()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }

        public Pop_5523_List_Loading(FlexCosting.v5523.Frm.Form_5523_Management arg_form)
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
            _main_form = arg_form;
        }
        #endregion

        #region Form Loading
        private void Pop_5523_List_Loading_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }     
        }      

        private void Init_Form()
        {
            //Title
            this.Text = "5523 Loading";
            this.lbl_MainTitle.Text = "5523 Loading";
            ClassLib.ComFunction.SetLangDic(this);
                       

            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFX_CBD_5523_LIST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.ExtendLastCol = false;            
        }

        private void Init_Control()
        {
            FlexCosting.ClassLib.ComFunction_Cost comFnc = new FlexCosting.ClassLib.ComFunction_Cost();

            //Factory
            DataTable vDT = COM.ComFunction.Select_Factory_List_CDC();
            COM.ComCtl.Set_Factory_List(vDT, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedValue = COM.ComVar.This_Factory;

            if (cmb_factory.SelectedIndex < 0)
                cmb_factory.SelectedIndex = 0;

            vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_season, 0, 1, true, false);
            cmb_season.SelectedIndex = 0;
            vDT.Dispose();
            
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = true;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Display_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }     
        }

       
        private void Display_Data()
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            string[] arg_value = new string[3];
            arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[1] = cmb_season.SelectedValue.ToString();
            arg_value[2] = txt_prod_code.Text.Trim();


            DataTable dt = SELECT_SFX_CBD_5523_LIST(arg_value);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                }

                fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_POP.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_5523_POP.IxUPD_YMD).StyleNew.BackColor = Color.White;
            }
        }

        public DataTable SELECT_SFX_CBD_5523_LIST(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SELECT_SFX_CBD_5523_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON";
            MyOraDB.Parameter_Name[2] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (Save_Data())
                {
                    Display_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private bool Save_Data()
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return false;

                DialogResult dr01 = MessageBox.Show("Do you want save??", "Exclamation", MessageBoxButtons.YesNo);

                if (dr01 == DialogResult.No)
                {
                    return false;
                }

                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    string _div = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxDIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxDIV].ToString().Trim();

                    if (_div.Equals("D"))
                    {
                        string[] arg_value = new string[6];

                        arg_value[0] = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxFACTORY     ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxFACTORY     ].ToString().Trim();
                        arg_value[1] = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxPRODUCT_CODE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxPRODUCT_CODE].ToString().Trim();
                        arg_value[2] = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxDEV_CODE    ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxDEV_CODE    ].ToString().Trim();
                        arg_value[3] = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxREGION      ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxREGION      ].ToString().Trim();
                        arg_value[4] = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxSEASON_CD   ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxSEASON_CD   ].ToString().Trim();
                        arg_value[5] = (fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxPRODUCT_TYPE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxPRODUCT_TYPE].ToString().Trim();

                        if (DELETE_SFX_CBD_5523(arg_value))
                        {
                            fgrid_main[i, (int)ClassLib.TBSFX_CBD_5523_POP.IxDIV] = "";
                        }
                        else
                        {
                            break;
                            return false;
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false; 
            }
        }

        private bool DELETE_SFX_CBD_5523(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.DELETE_SFX_CBD_5523";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PRODUCT_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_DEV_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_REGION";
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_PRODUCT_TYPE";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];


            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;

        }
        #endregion

        #region Delete Data
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Delete_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Delete_Data()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int[] sct_rows = fgrid_main.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_main[sct_rows[i], (int)ClassLib.TBSFX_CBD_5523_POP.IxDIV] = "D";
            }
        }
        #endregion

        #region Grid Event
        private void fgrid_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                MainFrom_Loading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }     
        }

        private void MainFrom_Loading()
        {
            _main_form._head_factory      = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSFX_CBD_5523_POP.IxFACTORY].ToString().Trim();
            _main_form._head_product_code = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSFX_CBD_5523_POP.IxPRODUCT_CODE].ToString().Trim();
            _main_form._head_dev_code     = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSFX_CBD_5523_POP.IxDEV_CODE].ToString().Trim();
            _main_form._head_region       = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSFX_CBD_5523_POP.IxREGION].ToString().Trim();
            _main_form._head_season_cd    = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSFX_CBD_5523_POP.IxSEASON_CD].ToString().Trim();
            _main_form._head_product_type = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSFX_CBD_5523_POP.IxPRODUCT_TYPE].ToString().Trim();

            loading_flg = true;
            this.Close();
        }
        #endregion

        #region Data Sync
        private void btn_sync_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Sync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Data_Sync()
        {
            DialogResult dr01 = MessageBox.Show("Synchronize data to other factory. Do you want synchronization?", "Exclamation", MessageBoxButtons.YesNo);
            if (dr01 == DialogResult.No)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            if (SYNC_SFX_CBD_5523())
            {
                MessageBox.Show("Data synchronization completed.");
            }
        }

        private bool SYNC_SFX_CBD_5523()
        {            
            MyOraDB.ReDim_Parameter(1);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_5523.SYNC_SFX_CBD_5523";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }
        #endregion

        
        


    }
}

