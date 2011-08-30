using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Frm
{
    public partial class Form_Base_Information : COM.PCHWinForm.Form_Top
    {
        #region User Variable Define
        private COM.OraDB MyOraDB = new COM.OraDB();

        private int[] copy_rows_01;
        private int[] copy_rows_02;
        private int[] copy_rows_03;
        #endregion

        #region Constructor
        public Form_Base_Information()
        {
            InitializeComponent();            
        }
        #endregion

        #region Form Loading
        private void Form_Base_Information_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch(Exception ex)
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
            this.Text = "Base Information";
            this.lbl_MainTitle.Text = "Base Information";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_fxrate.Set_Grid("SFX_CBD_BASE_FXRATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_fxrate.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_fxrate.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_fxrate.Set_Action_Image(img_Action);
            fgrid_fxrate.ExtendLastCol = false;
            fgrid_fxrate.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;

            for (int j = fgrid_fxrate.Cols.Fixed; j < fgrid_fxrate.Cols.Count; j++)
            {                
                if (j.Equals((int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSEASON_NAME))
                    fgrid_fxrate.Cols[j].AllowMerging = true;                
                else
                {
                    fgrid_fxrate.Cols[j].AllowMerging = false;

                    if (j >= (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE && j <= (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE)
                        fgrid_fxrate.GetCellRange(fgrid_fxrate.Rows.Fixed - 1, j).StyleNew.BackColor = Color.FromArgb(-3181363);                
                }
            }

            fgrid_packing.Set_Grid("SFX_CBD_BASE_PACKAGING", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_packing.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_packing.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_packing.Set_Action_Image(img_Action);
            fgrid_packing.ExtendLastCol = false;
            fgrid_packing.GetCellRange(fgrid_packing.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM, fgrid_packing.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE).StyleNew.BackColor = Color.FromArgb(-3181363);

            fgrid_packing.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;

            for (int j = fgrid_packing.Cols.Fixed; j < fgrid_packing.Cols.Count; j++)
            {
                if (j == (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxGENDER || j == (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxCATEGORY_V)
                    fgrid_packing.Cols[j].AllowMerging = true;
                else
                    fgrid_packing.Cols[j].AllowMerging = false;
            }

            
            fgrid_labor.Set_Grid("SFX_CBD_BASE_LABOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_labor.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_labor.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_labor.Set_Action_Image(img_Action);
            fgrid_labor.ExtendLastCol = false;
            fgrid_labor.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;

            for (int j = fgrid_labor.Cols.Fixed; j < fgrid_labor.Cols.Count; j++)
            {
                if(j.Equals((int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFACTORY_V))
                    fgrid_labor.Cols[j].AllowMerging = true;
                else if (j.Equals((int)ClassLib.TBSFX_CBD_BASE_LABOR.IxSEASON_NAME))
                    fgrid_labor.Cols[j].AllowMerging = true;
                else if (j >= (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST && j <= (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST)
                {
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Fixed - 1, j).StyleNew.BackColor = Color.FromArgb(-3181363);
                    fgrid_labor.Cols[j].AllowMerging = false;
                }
                else
                    fgrid_labor.Cols[j].AllowMerging = false;
            }

            fgrid_uom.Set_Grid("SFX_CBD_BASE_UOM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_uom.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_uom.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_uom.Set_Action_Image(img_Action);
            fgrid_uom.ExtendLastCol = false;
            fgrid_uom.GetCellRange(fgrid_uom.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, fgrid_uom.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.BackColor = Color.FromArgb(-3181363);
        }

        private void Init_Control()
        {
            FlexCosting.ClassLib.ComFunction_Cost comFnc = new FlexCosting.ClassLib.ComFunction_Cost();

            DataTable vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_seasonFrom, 0, 1, false, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_seasonTo, 0, 1, false, false);
            vDT.Dispose();

            int curMon = (int)Math.Ceiling((double)System.DateTime.Now.Month / 4);
            cmb_seasonFrom.SelectedValue = System.DateTime.Now.Year + "0" + curMon;
            cmb_seasonTo.SelectedValue = System.DateTime.Now.Year + "0" + curMon;

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            mnu_01_paste.Enabled = false;
            mnu_02_paste.Enabled = false;
            mnu_03_paste.Enabled = false;
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
            int tab_idx = tab_main.SelectedIndex;

            if (tab_idx.Equals(0))
            {
                Display_FX_Rate(); 
            }
            else if (tab_idx.Equals(1))
            {
                Display_Packing();
            }
            else if (tab_idx.Equals(2))
            {
                Display_Labor();
            }
            else if (tab_idx.Equals(3))
            {
                Display_UOM();
            }
        }
        private void Display_FX_Rate()
        {
            fgrid_fxrate.Rows.Count = fgrid_fxrate.Rows.Fixed;

            string[] arg_value = new string[3];
            arg_value[0] = COM.ComVar.This_Factory;
            arg_value[1] = cmb_seasonFrom.SelectedValue.ToString();
            arg_value[2] = cmb_seasonTo.SelectedValue.ToString();

            DataTable dt = SELECT_SFX_CBD_M_FXRATE(arg_value);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_fxrate.Rows.Add();

                for (int j = fgrid_fxrate.Cols.Fixed; j < fgrid_fxrate.Cols.Count; j++)
                {
                    fgrid_fxrate[fgrid_fxrate.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                }

                fgrid_fxrate.GetCellRange(fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxDIV,      fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCOUNTRY).StyleNew.BackColor = Color.White;
                fgrid_fxrate.GetCellRange(fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE,  fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE).StyleNew.BackColor = Color.FloralWhite;
                fgrid_fxrate.GetCellRange(fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxUPD_USER, fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxUPD_YMD).StyleNew.BackColor = Color.White;

                fgrid_fxrate.GetCellRange(fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE, fgrid_fxrate.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE).StyleNew.ForeColor = Color.Black;
            }
        }

        private void Display_Packing()
        {
            fgrid_packing.Rows.Count = fgrid_packing.Rows.Fixed;

            string[] arg_value = new string[3];
            arg_value[0] = COM.ComVar.This_Factory;
            arg_value[1] = cmb_seasonFrom.SelectedValue.ToString();
            arg_value[2] = cmb_seasonTo.SelectedValue.ToString();

            DataTable dt = SELECT_SFX_CBD_M_PACKING(arg_value);

            bool gender_change = false;
            string gen_cd_r = "";

            if (dt.Rows.Count > 0)
                gen_cd_r = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxGEN_CD].ToString().Trim();
            else
                return;

            //fgrid_packing.Rows[fgrid_packing.Rows.Count - 1].StyleNew.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Both;
            ////fgrid_packing.Rows[fgrid_packing.Rows.Count - 1].StyleNew.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Inset;
            //fgrid_packing.Rows[fgrid_packing.Rows.Count - 1].StyleNew.Border.Color = Color.Black;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_packing.Rows.Add();
                

                for (int j = fgrid_packing.Cols.Fixed; j < fgrid_packing.Cols.Count; j++)
                {
                    fgrid_packing[fgrid_packing.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                }

                string gen_cd = fgrid_packing[fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxGEN_CD].ToString().Trim();

                if (!gen_cd_r.Equals(gen_cd))
                {
                    if (gender_change)
                        gender_change = false;
                    else
                        gender_change = true;

                    gen_cd_r = gen_cd;                    
                }

                if (gender_change)
                {
                    fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_DESC).StyleNew.BackColor = Color.White;
                    fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxREMARKS, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxUPD_YMD).StyleNew.BackColor = Color.White;
                    
                }
                else
                {
                    fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_DESC).StyleNew.BackColor = Color.MintCream;
                    fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE).StyleNew.BackColor = Color.WhiteSmoke;
                    fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxREMARKS, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxUPD_YMD).StyleNew.BackColor = Color.MintCream;
                    
                }

                fgrid_packing.GetCellRange(fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM, fgrid_packing.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE).StyleNew.ForeColor = Color.Black;                
            }
        }

        private void Display_Labor()
        {
            fgrid_labor.Rows.Count = fgrid_labor.Rows.Fixed;

            string[] arg_value = new string[3];
            arg_value[0] = COM.ComVar.This_Factory;
            arg_value[1] = cmb_seasonFrom.SelectedValue.ToString();
            arg_value[2] = cmb_seasonTo.SelectedValue.ToString();

            DataTable dt = SELECT_SFX_CBD_M_LABOR(arg_value);
            bool season_change = false;
            string season_cd_r = "";

            if(dt.Rows.Count > 0)
                season_cd_r = dt.Rows[0].ItemArray[(int)ClassLib.TBSFX_CBD_BASE_LABOR.IxSEASON_CD].ToString().Trim();
            else
                return;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_labor.Rows.Add();

                for (int j = fgrid_labor.Cols.Fixed; j < fgrid_labor.Cols.Count; j++)
                {
                    fgrid_labor[fgrid_labor.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                }

                string season_cd = fgrid_labor[fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxSEASON_CD].ToString().Trim();

                if (!season_cd_r.Equals(season_cd))
                {
                    if (season_change)
                        season_change = false;
                    else
                        season_change = true;

                    season_cd_r = season_cd;
                }


                if (season_change)
                {
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST).StyleNew.BackColor = Color.White;
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxREMARKS, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxUPD_YMD).StyleNew.BackColor = Color.White;
                }
                else
                {
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST).StyleNew.BackColor = Color.MintCream;
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST).StyleNew.BackColor = Color.WhiteSmoke;
                    fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxREMARKS, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxUPD_YMD).StyleNew.BackColor = Color.MintCream;
                }

                fgrid_labor.GetCellRange(fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST, fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST).StyleNew.ForeColor = Color.Black;
            }
        }

        private void Display_UOM()
        {
            fgrid_uom.Rows.Count = fgrid_uom.Rows.Fixed;

            string[] arg_value = new string[1];
            arg_value[0] = COM.ComVar.This_Factory;            

            DataTable dt = SELECT_SFX_CBD_M_UOM(arg_value);
            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_uom.Rows.Add();

                for (int j = fgrid_uom.Cols.Fixed; j < fgrid_uom.Cols.Count; j++)
                {
                    fgrid_uom[fgrid_uom.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                }
                                
                fgrid_uom.GetCellRange(fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.BackColor = Color.FloralWhite;
                fgrid_uom.GetCellRange(fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.ForeColor = Color.Black;

                fgrid_uom.GetCellRange(fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS, fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_YMD).StyleNew.BackColor = Color.White;

            }
        }

        public DataTable SELECT_SFX_CBD_M_FXRATE(string [] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SELECT_SFX_CBD_M_FXRATE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
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
        public DataTable SELECT_SFX_CBD_M_PACKING(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SELECT_SFX_CBD_M_PACKING";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
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
        public DataTable SELECT_SFX_CBD_M_LABOR(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SELECT_SFX_CBD_M_LABOR";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
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
        public DataTable SELECT_SFX_CBD_M_UOM(string[] arg_value)
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SELECT_SFX_CBD_M_UOM";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = "";

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
                this.Cursor = Cursors.WaitCursor;

                Save_Data();
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

        private void Save_Data()
        {
            int tab_idx = tab_main.SelectedIndex;

            if (tab_idx.Equals(0))
            {
                if (SAVE_FX_RATE())
                {                    
                    MessageBox.Show("Save Completed");
                    Display_FX_Rate();
                }
            }
            else if (tab_idx.Equals(1))
            {
                if (Check_Save_Packing())
                {
                    if (SAVE_PACKING())
                    {
                        MessageBox.Show("Save Completed");
                        Display_Packing(); 
                    }
                }
            }
            else if (tab_idx.Equals(2))
            {
                if (Check_Save_Labor())
                {
                    if (SAVE_LABOR())
                    {
                        MessageBox.Show("Save Completed");
                        Display_Labor();
                    }
                }
            }
            else if (tab_idx.Equals(3))
            {
                if (Check_Save_UOM())
                {
                    if (DELETE_UOM())
                    {
                        if (SAVE_UOM())
                        {
                            MessageBox.Show("Save Completed");
                            Display_UOM();
                        }
                    }
                }
            } 
        }

        
        
        private bool SAVE_FX_RATE()
        {
            int vcnt = 8;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SAVE_SFX_CBD_M_FXRATE";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[2] = "ARG_CURR";
            MyOraDB.Parameter_Name[3] = "ARG_APP_DATE";
            MyOraDB.Parameter_Name[4] = "ARG_COUNTRY";
            MyOraDB.Parameter_Name[5] = "ARG_FX_RATE";
            MyOraDB.Parameter_Name[6] = "ARG_STATUS";
            MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
            
            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_fxrate.Rows.Fixed; i < fgrid_fxrate.Rows.Count; i++)
            {
                string _div = fgrid_fxrate[i, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_fxrate.Rows.Fixed; row < fgrid_fxrate.Rows.Count; row++)
            {
                string _div = fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFACTORY  ] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFACTORY  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSEASON_CD] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSEASON_CD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCURR     ] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCURR     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = Conv_Data_String(fgrid_fxrate, row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE);
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCOUNTRY  ] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCOUNTRY  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE  ] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSTATUS   ] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSTATUS   ].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
                
            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }
        private string Conv_Data_String(COM.FSP arg_grid, int arg_row, int arg_col)
        {
            try
            {
                string _return_value = "";
                string _data_type = arg_grid.Cols[arg_col].DataType.ToString();

                if (_data_type.Equals("System.DateTime"))
                {
                    string _date_row = (arg_grid[arg_row, arg_col] == null) ? DateTime.Now.ToString() : arg_grid[arg_row, arg_col].ToString().Trim();
                    DateTime date = Convert.ToDateTime(_date_row);

                    _return_value = date.ToString("yyyyMMdd");

                }

                return _return_value;
            }
            catch
            {
                return ""; 
            } 
        }

        private bool SAVE_PACKING()
        {
            int vcnt = 11;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SAVE_SFX_CBD_M_PACKING";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_GEN_CD";
            MyOraDB.Parameter_Name[2]  = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[3]  = "ARG_PACKING_SEQ";
            MyOraDB.Parameter_Name[4]  = "ARG_PACKING_DESC";
            MyOraDB.Parameter_Name[5]  = "ARG_SIZE_FROM";
            MyOraDB.Parameter_Name[6]  = "ARG_SIZE_TO";
            MyOraDB.Parameter_Name[7]  = "ARG_MAT_PRICE";
            MyOraDB.Parameter_Name[8]  = "ARG_REMARKS";
            MyOraDB.Parameter_Name[9]  = "ARG_STATUS";
            MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";
             

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_packing.Rows.Fixed; i < fgrid_packing.Rows.Count; i++)
            {
                string _div = fgrid_packing[i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_packing.Rows.Fixed; row < fgrid_packing.Rows.Count; row++)
            {
                string _div = fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxFACTORY     ] == null) ? "" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxFACTORY ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxGEN_CD      ] == null) ? "" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxGEN_CD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxCATEGORY    ] == null) ? "" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxCATEGORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_SEQ ] == null || fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_SEQ ].ToString().Trim().Equals("")) ? "0" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_SEQ ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_DESC] == null || fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_DESC].ToString().Trim().Equals("")) ? "0" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxPACKING_DESC].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM   ] == null || fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM   ].ToString().Trim().Equals("")) ? "0" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_FROM   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_TO     ] == null || fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_TO     ].ToString().Trim().Equals("")) ? "0" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxSIZE_TO     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE   ] == null || fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE   ].ToString().Trim().Equals("")) ? "0" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxREMARKS     ] == null || fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxREMARKS     ].ToString().Trim().Equals("")) ? "0" : fgrid_packing[row, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxREMARKS     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = "C";
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;

            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }
        private bool Check_Save_Packing()
        {
            try
            {
                for (int i = fgrid_packing.Rows.Fixed; i < fgrid_packing.Rows.Count; i++)
                {
                    string div = (fgrid_packing[i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV] == null) ? "" : fgrid_packing[i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV].ToString().Trim();

                    if (!div.Equals(""))
                    {
                        string value = (fgrid_packing[i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE] == null || fgrid_packing[i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE].ToString().Trim().Equals("")) ? "0" : fgrid_packing[i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE].ToString().Trim();

                        try
                        {
                            double value_chk = double.Parse(value);
                        }
                        catch
                        {
                            MessageBox.Show("Please Insert Numeric Value");
                            fgrid_packing.Select(i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE);
                            return false;
                        }

                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            } 
        }

        private bool SAVE_LABOR()
        {
            int vcnt = 12;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SAVE_SFX_CBD_M_LABOR";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[2]  = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[3] = "ARG_GENDER";
            MyOraDB.Parameter_Name[4] = "ARG_RETAIL_FROM";
            MyOraDB.Parameter_Name[5]  = "ARG_RETAIL_TO";
            MyOraDB.Parameter_Name[6]  = "ARG_FIXED_COST";
            MyOraDB.Parameter_Name[7]  = "ARG_LABOR_COST";
            MyOraDB.Parameter_Name[8]  = "ARG_OVERHEAD_COST";
            MyOraDB.Parameter_Name[9]  = "ARG_REMARKS";
            MyOraDB.Parameter_Name[10]  = "ARG_STATUS";
            MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";
          
            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_labor.Rows.Fixed; i < fgrid_labor.Rows.Count; i++)
            {
                string _div = fgrid_labor[i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_labor.Rows.Fixed; row < fgrid_labor.Rows.Count; row++)
            {
                string _div = fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFACTORY      ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFACTORY    ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxSEASON_CD    ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxSEASON_CD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxCATEGORY     ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxCATEGORY   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxGENDER       ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxGENDER     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxRETAIL_FROM  ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxRETAIL_FROM].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxRETAIL_TO    ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxRETAIL_TO  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST   ] == null || fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST   ].ToString().Trim().Equals("")) ? "0" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST   ] == null || fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST   ].ToString().Trim().Equals("")) ? "0" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST] == null || fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST].ToString().Trim().Equals("")) ? "0" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxREMARKS      ] == null) ? "" : fgrid_labor[row, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxREMARKS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = "C";
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;

            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }
        private bool Check_Save_Labor()
        {
            try
            {
                for (int i = fgrid_labor.Rows.Fixed; i < fgrid_labor.Rows.Count; i++)
                {
                    string div = (fgrid_labor[i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV] == null) ? "" : fgrid_labor[i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV].ToString().Trim();

                    if (!div.Equals(""))
                    {
                        for (int j = (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST; j <= (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST; j++)
                        {
                            string value = (fgrid_labor[i, j] == null || fgrid_labor[i, j].ToString().Trim().Equals("")) ? "0" : fgrid_labor[i, j].ToString().Trim();

                            try
                            {
                                double value_chk = double.Parse(value);
                            }
                            catch
                            {
                                MessageBox.Show("Please Insert Numeric Value");
                                fgrid_labor.Select(i, j);
                                return false;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool DELETE_UOM()
        {
            int vcnt = 1;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.DELETE_SFX_CBD_M_UOM";
            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }
        private bool SAVE_UOM()
        {
            int vcnt = 6;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_BASE.SAVE_SFX_CBD_M_UOM";
            
            //02.ARGURMENT 명            
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_COM_SEQ";
            MyOraDB.Parameter_Name[2] = "ARG_UOM";
            MyOraDB.Parameter_Name[3] = "ARG_SYSTEM_YN";
            MyOraDB.Parameter_Name[4] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_uom.Rows.Fixed; i < fgrid_uom.Rows.Count; i++)
            {                
                string _div = fgrid_uom[i, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV].ToString().Trim();

                if (!_div.Equals("D"))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_uom.Rows.Fixed; row < fgrid_uom.Rows.Count; row++)
            {
                string _div = fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV].ToString().Trim();

                if (_div.Equals("D"))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxFACTORY] == null) ? "" : fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxFACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_SEQ] == null) ? "" : fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_SEQ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1] == null) ? "" : fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1].ToString().Trim();
                string use_yn = (fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN] == null) ? "FALSE" : fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN].ToString().Trim().ToUpper();
                MyOraDB.Parameter_Values[vcnt++] = use_yn.Equals("TRUE") ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS] == null) ? "" : fgrid_uom[row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }
        private bool Check_Save_UOM()
        {
            try
            {

                if (fgrid_uom.Rows.Count.Equals(fgrid_uom.Rows.Fixed))
                {
                    MessageBox.Show("No Data");
                    return false; 
                }

                for (int i = fgrid_uom.Rows.Fixed; i < fgrid_uom.Rows.Count; i++)
                {
                    string div = (fgrid_uom[i, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV] == null) ? "" : fgrid_uom[i, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV].ToString().Trim();

                    if (!div.Equals(""))
                    {
                        string value = (fgrid_uom[i, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1] == null) ? "" : fgrid_uom[i, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1].ToString().Trim();

                        if (value.Equals(""))
                        {
                            MessageBox.Show("Please insert data");
                            fgrid_uom.Select(i, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1);
                            return false; 
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion
        
        #region Grid Event
        private void fgrid_fxrate_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_AfterEdit(fgrid_fxrate);
            }
            catch
            {
 
            }
        }
        private void fgrid_packing_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_AfterEdit(fgrid_packing);
            }
            catch
            {

            }
        }
        private void fgrid_labor_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_AfterEdit(fgrid_labor);
                Caculate_Fixed_Cost();
            }
            catch
            {

            }
        }
        private void fgrid_uom_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_AfterEdit(fgrid_uom);
            }
            catch
            {

            }
        }

        private void Grid_AfterEdit(COM.FSP arg_grid)
        {
            int sct_row = arg_grid.Selection.r1;
            int sct_col = arg_grid.Selection.c1;
            int[] sct_rows = arg_grid.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                arg_grid.Update_Row(sct_rows[i]);

                arg_grid[sct_rows[i], sct_col] = arg_grid[sct_row, sct_col];
            } 
            
            
        }
        private void Caculate_Fixed_Cost()
        {
            int sct_row = fgrid_labor.Selection.r1;            
            int[] sct_rows = fgrid_labor.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                double labor_cost = 0;
                double overhead_cost = 0;

                try
                {
                    labor_cost = double.Parse(fgrid_labor[sct_rows[i], (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST].ToString().Trim());
                }
                catch
                {
                    labor_cost = 0; 
                }

                try
                {
                    overhead_cost = double.Parse(fgrid_labor[sct_rows[i], (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST].ToString().Trim());
                }
                catch
                {
                    overhead_cost = 0;
                }

                double fixed_cost = labor_cost + overhead_cost;

                fgrid_labor[sct_rows[i], (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST] = fixed_cost.ToString();
            }
        }
        #endregion

        #region ContextMenu Event

        #region F/X Rate
        private void mnu_01_copy_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Copy_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mnu_01_paste_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Paste_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Packing
        private void mnu_02_copy_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Copy_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mnu_02_paste_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Paste_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region L/OH
        private void mnu_03_copy_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Copy_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void mnu_03_paste_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Paste_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region UOM
        private void mnu_04_insert_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Insert_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mnu_04_delete_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Delete_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void ContextMenu_Copy_Data()
        {
            if (tab_main.SelectedIndex.Equals(0))
            {
                if (fgrid_fxrate.Rows.Count.Equals(fgrid_fxrate.Rows.Fixed))
                    return;

                int sct_row = fgrid_fxrate.Selection.r1;

                if (sct_row < fgrid_fxrate.Rows.Fixed)
                    return;

                copy_rows_01 = fgrid_fxrate.Selections;
                mnu_01_paste.Enabled = true;
            }
            else if (tab_main.SelectedIndex.Equals(1))
            {
                if (fgrid_packing.Rows.Count.Equals(fgrid_packing.Rows.Fixed))
                    return;

                int sct_row = fgrid_packing.Selection.r1;

                if (sct_row < fgrid_packing.Rows.Fixed)
                    return;

                copy_rows_02 = fgrid_packing.Selections;
                mnu_02_paste.Enabled = true;
            }
            else if (tab_main.SelectedIndex.Equals(2))
            {
                if (fgrid_labor.Rows.Count.Equals(fgrid_labor.Rows.Fixed))
                    return;

                int sct_row = fgrid_labor.Selection.r1;

                if (sct_row < fgrid_labor.Rows.Fixed)
                    return;

                copy_rows_03 = fgrid_labor.Selections;
                mnu_03_paste.Enabled = true;
            }
        }
        private void ContextMenu_Paste_Data()
        {
            if (tab_main.SelectedIndex.Equals(0))
            {
                if (fgrid_fxrate.Rows.Count.Equals(fgrid_fxrate.Rows.Fixed))
                    return;

                int sct_row = fgrid_fxrate.Selection.r1;

                if (sct_row < fgrid_fxrate.Rows.Fixed)
                    return;

                for (int i = 0; i < copy_rows_01.Length; i++)
                {
                    if (sct_row + i >= fgrid_fxrate.Rows.Count)
                        break;

                    fgrid_fxrate[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE ] = fgrid_fxrate[copy_rows_01[i], (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE ];
                    fgrid_fxrate[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSTATUS  ] = fgrid_fxrate[copy_rows_01[i], (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSTATUS  ];
                    fgrid_fxrate[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE] = fgrid_fxrate[copy_rows_01[i], (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE];                    
                    fgrid_fxrate[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxDIV     ] = "U";
                }
            }
            else if (tab_main.SelectedIndex.Equals(1))
            {
                if (fgrid_packing.Rows.Count.Equals(fgrid_packing.Rows.Fixed))
                    return;

                int sct_row = fgrid_packing.Selection.r1;

                if (sct_row < fgrid_packing.Rows.Fixed)
                    return;

                for (int i = 0; i < copy_rows_02.Length; i++)
                {
                    if (sct_row + i >= fgrid_packing.Rows.Count)
                        break;

                    fgrid_packing[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE] = fgrid_packing[copy_rows_02[i], (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxMAT_PRICE];
                    fgrid_packing[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_PACKAGING.IxDIV      ] = "U";
                }
            }
            else if (tab_main.SelectedIndex.Equals(2))
            {
                if (fgrid_labor.Rows.Count.Equals(fgrid_labor.Rows.Fixed))
                    return;

                int sct_row = fgrid_labor.Selection.r1;

                if (sct_row < fgrid_labor.Rows.Fixed)
                    return;

                for (int i = 0; i < copy_rows_03.Length; i++)
                {
                    if (sct_row + i >= fgrid_labor.Rows.Count)
                        break;

                    fgrid_labor[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST   ] = fgrid_labor[copy_rows_03[i], (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxFIXED_COST   ];
                    fgrid_labor[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST   ] = fgrid_labor[copy_rows_03[i], (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxLABOR_COST   ];
                    fgrid_labor[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST] = fgrid_labor[copy_rows_03[i], (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxOVERHEAD_COST];
                    fgrid_labor[sct_row + i, (int)ClassLib.TBSFX_CBD_BASE_LABOR.IxDIV          ] = "U";
                }
            }

        }

        private void ContextMenu_Insert_Data()
        {
            if (fgrid_uom.Rows.Count.Equals(fgrid_uom.Rows.Fixed))
            {
                fgrid_uom.Rows.Add();
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV       ] = "I";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxFACTORY   ] = "DS";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_CD    ] = "SFB_50";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_SEQ   ] = "10";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_VALUE1] = "";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1 ] = "";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN    ] = "TRUE";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS   ] = "";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_USER  ] = "";
                fgrid_uom[fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_YMD   ] = "";

                fgrid_uom.GetCellRange(fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.BackColor = Color.FloralWhite;
                fgrid_uom.GetCellRange(fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.ForeColor = Color.Black;

                fgrid_uom.GetCellRange(fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS, fgrid_uom.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_YMD).StyleNew.BackColor = Color.White;
            }
            
            int sct_row = fgrid_uom.Selection.r1;

            if (sct_row < fgrid_uom.Rows.Fixed)            
                return;

            fgrid_uom.Add_Row(sct_row);

            sct_row = fgrid_uom.Selection.r1;

            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV       ] = "I";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxFACTORY   ] = "DS";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_CD    ] = "SFB_50";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_SEQ   ] = "10";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_VALUE1] = "";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1 ] = "";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN    ] = "TRUE";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS   ] = "";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_USER  ] = "";
            fgrid_uom[sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_YMD   ] = "";

            fgrid_uom.GetCellRange(sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.BackColor = Color.FloralWhite;
            fgrid_uom.GetCellRange(sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxCOM_DESC1, sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUSE_YN).StyleNew.ForeColor = Color.Black;

            fgrid_uom.GetCellRange(sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxREMARKS, sct_row, (int)ClassLib.TBSFX_CBD_BASE_UOM.IxUPD_YMD).StyleNew.BackColor = Color.White;

        }
        private void ContextMenu_Delete_Data()
        {
            if (fgrid_uom.Rows.Count.Equals(fgrid_uom.Rows.Fixed))
                return;

            int sct_row = fgrid_uom.Selection.r1;

            if (sct_row < fgrid_uom.Rows.Fixed)
                return;

            int[] sct_rows = fgrid_uom.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_uom[sct_rows[i], (int)ClassLib.TBSFX_CBD_BASE_UOM.IxDIV] = "D";
            }
        }
        #endregion       

        #region TabControl Event
        private void tab_main_SelectedIndexChanged(object sender, EventArgs e)
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
        #endregion

    }
}

