using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;

using C1.Win.C1FlexGrid;
using ChartFX.WinForms;
using ChartFX.WinForms.DataProviders;
using Excel;

namespace FlexCDC.FOB
{
    public partial class Form_EIS_Common_FOB_Master : COM.APSWinForm.Form_Top
    {        
        #region 생성자
        public Form_EIS_Common_FOB_Master()
        {
            InitializeComponent();
        }
        #endregion

        #region 변수 정의
        private COM.OraDB MyOraDB = new COM.OraDB();
        private FolderBrowserDialog fbd = new FolderBrowserDialog();

        // tree level
        private int _LevelHead = 0;
        private int _LevelDetail = 1;

        #endregion

        #region Form Loading
        private void Form_EIS_Common_FOB_Master_Load(object sender, EventArgs e)
        {
            Init_Form();
        }                
        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = "FOB Master";
                lbl_MainTitle.Text = "FOB Master"; 
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                Init_Control();

                chk_Model.Checked = false;
                chk_rate.Checked  = false;
                chk_desc.Checked  = false;

                tbtn_Color.ToolTipText = "Confirm";
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Init_Grid()
        {
            #region Head Grid Setting
            fgrid_Main.Set_Grid("EIS_FOB", "3", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.ForeColor = Color.Black;
            fgrid_Main.AllowEditing = true;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.AllowEditing = true;

            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxUP, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA).StyleNew.BackColor = Color.Pink;
            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxUP, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT).StyleNew.BackColor = Color.Pink;
            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING).StyleNew.BackColor = Color.Pink;
            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(0, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB, 2, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB).StyleNew.ForeColor = Color.Black;

            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY].Visible = false;
            //fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].Visible = false;
            //fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].Visible = false;

            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].Visible = false;

            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC].Visible = false;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC].Visible = false;
            #endregion

            #region Detail Grid Setting
            //UPPER
            fgrid_upper.Set_Grid("EBM_FOB_DETAIL", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_upper.Set_Action_Image(img_Action);
            fgrid_upper.ExtendLastCol = false;
            fgrid_upper.ForeColor = Color.Black;
            fgrid_upper.AllowEditing = false;

            //PACKING
            fgrid_packing.Set_Grid("EBM_FOB_DETAIL", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_packing.Set_Action_Image(img_Action);
            fgrid_packing.ExtendLastCol = false;
            fgrid_packing.ForeColor = Color.Black;
            fgrid_packing.AllowEditing = false;

            //MIDSOLE
            fgrid_midsole.Set_Grid("EBM_FOB_DETAIL", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_midsole.Set_Action_Image(img_Action);
            fgrid_midsole.ExtendLastCol = false;
            fgrid_midsole.ForeColor = Color.Black;
            fgrid_midsole.AllowEditing = false;

            //OUTSOLE
            fgrid_outsole.Set_Grid("EBM_FOB_DETAIL", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_outsole.Set_Action_Image(img_Action);
            fgrid_outsole.ExtendLastCol = false;
            fgrid_outsole.ForeColor = Color.Black;
            fgrid_outsole.AllowEditing = false;

            //LABOR
            fgrid_labor.Set_Grid("EBM_FOB_LABOR", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_labor.Set_Action_Image(img_Action);
            fgrid_labor.ExtendLastCol = false;
            fgrid_labor.ForeColor = Color.Black;
            fgrid_labor.AllowEditing = false;

            //OVERHEAD
            fgrid_overhead.Set_Grid("EBM_FOB_OVERHEAD", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_overhead.Set_Action_Image(img_Action);
            fgrid_overhead.ExtendLastCol = false;
            fgrid_overhead.ForeColor = Color.Black;
            fgrid_overhead.AllowEditing = false;


            //SAMPLE MOLD COST
            fgrid_sample_mold.Set_Grid("EBM_FOB_MOLD", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_sample_mold.Set_Action_Image(img_Action);
            fgrid_sample_mold.ExtendLastCol = false;
            fgrid_sample_mold.ForeColor = Color.Black;
            fgrid_sample_mold.AllowEditing = false;


            //PRODUCTION MOLD COST
            fgrid_prod_mold.Set_Grid("EBM_FOB_MOLD", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_prod_mold.Set_Action_Image(img_Action);
            fgrid_prod_mold.ExtendLastCol = false;
            fgrid_prod_mold.ForeColor = Color.Black;

            //PROD MOLD COST - MOEF Head
            fgrid_pm_meof_head.Set_Grid("EBM_FOB_MEOF_HEAD", "3", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_pm_meof_head.Set_Action_Image(img_Action);
            fgrid_pm_meof_head.ExtendLastCol = true;
            fgrid_pm_meof_head.ForeColor = Color.Black;
            fgrid_pm_meof_head.AllowEditing = false;
            fgrid_pm_meof_head.SelectionMode = SelectionModeEnum.Row;

            //PROD MOLD COST - MEOF Size
            fgrid_pm_meof_size.Set_Grid("EBM_FOB_MEOF_TAIL", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_pm_meof_size.Set_Action_Image(img_Action);
            fgrid_pm_meof_size.ExtendLastCol = false;
            fgrid_pm_meof_size.ForeColor = Color.Black;
            fgrid_pm_meof_size.AllowEditing = false;


            //TOTAL COST
            fgrid_etc.Set_Grid("EBM_FOB_ETC", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_etc.Set_Action_Image(img_Action);
            fgrid_etc.ExtendLastCol = false;
            fgrid_etc.ForeColor = Color.Black;
            fgrid_etc.AllowEditing = false;

            //5523
            fgrid_5523.Set_Grid("EBM_FOB_5523_TAIL", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_5523.Set_Action_Image(img_Action);
            fgrid_5523.ExtendLastCol = false;
            fgrid_5523.ForeColor = Color.Black;
            fgrid_5523.AllowEditing = false;
            #endregion            
        }
        private void Init_Control()
        {
            // Disabled tbutton
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = true;
            tbtn_Color.Enabled  = true;

            //btn_Batch.Visible  = false;
            //btn_upload.Visible = false;

            txt_Style.CharacterCasing = CharacterCasing.Upper;

            // Last update 조회
            Display_LastUpdateDate();

            // Factory Combobox Add Items
            System.Data.DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();

            // DS 제거 (선택불가)
            DataRow[] vDR = dt_ret.Select("FACTORY = 'DS'");
            if (vDR.Length == 1)
            {
                dt_ret.Rows.Remove(vDR[0]);
            }

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            dt_ret.Dispose();
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
        }
        private void Display_LastUpdateDate()
        {

            //string table_string = "EBM_FOB";
            ////System.Data.DataTable dt_ret = ClassLib.ComFunction.Select_LastUpdate_Date(table_string);

            //if (dt_ret == null || dt_ret.Rows.Count == 0) return;
            //lbl_LastUpdate2.Text = dt_ret.Rows[0].ItemArray[0].ToString();

        }
             
        private System.Data.DataTable SELECT_EBM_OBS_ID(string arg_factory)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_OBS_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }

        /*
        private System.Data.DataTable SELECT_EBM_STYLE(string arg_factory, string arg_obs_id, string arg_style_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_TMP.SELECT_EBM_STYLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_style_cd;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }
        */
        #endregion
        
        #region Excel File Loading
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void Event_Tbtn_New()
        {
            fgrid_Main.ClearAll();
            ClearAllGrid();
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ClearAllGrid()
        {
            fgrid_upper.ClearAll();
            fgrid_packing.ClearAll();
            fgrid_midsole.ClearAll();
            fgrid_outsole.ClearAll();
            fgrid_labor.ClearAll();
            fgrid_overhead.ClearAll();
            fgrid_sample_mold.ClearAll();
            fgrid_prod_mold.ClearAll();
            fgrid_pm_meof_head.ClearAll();
            fgrid_pm_meof_size.ClearAll();
            fgrid_etc.ClearAll();
            fgrid_5523.ClearAll();

            fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
            txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
            txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
            txt_date_5523.Text = "";
            txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
            txt_other_5523.Text = "";
        }
        
        private void Event_Tbtn_Search()
        {
            // 조회시 필수조건 체크 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            string factory  = cmb_Factory.SelectedValue.ToString();
            string season   = ClassLib.ComFunction.Empty_Combo(cmb_season, " ");
            string obs_id   = ClassLib.ComFunction.Empty_Combo(cmb_ObsID, " ");
            string style    = ClassLib.ComFunction.Empty_TextBox(txt_Style, " ").Replace("-", "");
            string bom_id   = ClassLib.ComFunction.Empty_TextBox(txt_bom_id, " ");
            
            
            System.Data.DataTable dt_ret = SELECT_EBM_FOB(factory, season, obs_id, style, bom_id);
            Display_Grid(dt_ret);
            

            dt_ret.Dispose();
        }
        private void Display_Grid(System.Data.DataTable arg_dt)
        {
            fgrid_Main.ClearAll();
            ClearAllGrid();

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                Row newRow = fgrid_Main.Rows.Add();

                for (int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
                {
                    fgrid_Main[fgrid_Main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();

                    if (j >= (int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD && j <= (int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD)
                    {  
                        fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, j).StyleNew.BackColor = Color.White; 
                    }
                }

                // ForeColor
                if (newRow[(int)ClassLib.TBEIS_FOB_MASTER.IxROUND].ToString().Equals("Prod"))
                {
                    fgrid_Main.GetCellRange(newRow.Index, 1, newRow.Index, fgrid_Main.Cols.Frozen - 1).StyleNew.BackColor = Color.FromArgb(208, 221, 247); 
                }
                else
                {
                    fgrid_Main.GetCellRange(newRow.Index, 1, newRow.Index, fgrid_Main.Cols.Frozen - 1).StyleNew.BackColor = Color.LightYellow;
                }
            }

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_FOB_MASTER.IxUP, fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA).StyleNew.BackColor = Color.FloralWhite;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH, fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT).StyleNew.BackColor = Color.FloralWhite;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING, fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING).StyleNew.BackColor = Color.FloralWhite;         
        }        

        private System.Data.DataTable SELECT_EBM_FOB(string arg_factory, string arg_season,  string arg_obs_id, string arg_style, string arg_bom_id)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
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
                MyOraDB.Parameter_Values[1] = arg_season;
                MyOraDB.Parameter_Values[2] = arg_obs_id;
                MyOraDB.Parameter_Values[3] = arg_style;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Event_Tbtn_Save()
        {
            // 행 수정상태 해제 
            fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, false);


            DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
            if (result == DialogResult.No) return;

            bool save_check = Save_check();

            if (!save_check)
                return;

            bool save_flag = SAVE_EBM_FOB();

            if (save_flag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
                fgrid_Main.ClearFlags();

                Set_season();
                Set_obs_id();

                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {
                    string vflag = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString();

                    if (vflag.Equals("D"))
                    {
                        fgrid_Main.Rows.Remove(i);
                    }
                    else
                    {
                        fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = ""; 
                    }
                }
                
            }
            else
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return;
            }

            if (SAVE_EBM_FOB_PROD_MOLD())
            {
                fgrid_prod_mold.ClearFlags();
            }
        }

        private bool Save_check()
        {
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {
                string vflag = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString();
                
                if (vflag.Equals("I") || vflag.Equals("U"))
                {
                    string factory  = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString().Trim();
                    string style_cd = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Trim().Replace("-", "");
                    string obs_id   = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString().Trim();
                    //string category = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY].ToString().Trim();
                    //string gender   = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].ToString().Trim();

                    if (factory.Equals("") || style_cd.Equals("") || obs_id.Equals(""))
                    {
                        MessageBox.Show("Style Code, DPO is empty, Please check again.");
                        return false;
                    }

                    try
                    {
                        double up        = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Trim()) ;
                        double bottom    = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Trim()) ;
                        double extra     = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Trim()) ;
                        double m_upper   = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER].ToString().Trim());
                                           
                        double m_packing = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING].ToString().Trim()) ;
                        double m_midsole = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE].ToString().Trim()) ;
                        double m_outsole = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE].ToString().Trim()) ;
                        double m_sizeup  = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP].ToString().Trim()) ;
                                           
                        double mat_tot   = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE].ToString().Trim()) ;
                                           
                        double l_oh      = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Trim()) ;
                        double profit    = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Trim()) ;
                        double other_ad  = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Trim()) ;
                        double nm_price  = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE].ToString().Trim()) ;
                                           
                        double t_sample  = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE].ToString().Trim()) ;
                        double t_product = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Trim()) ;
                        double t_price   = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Trim()) ;
                                           
                        double fob       = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB].ToString().Trim()) ;                       

                    }
                    catch
                    {
                        MessageBox.Show("Data Format is not Number, Please check again");
                    }

                    
                }
            }

            return true; 
        }
        private bool SAVE_EBM_FOB()
        {
            try
            {
                int col_ct = 55;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.SAVE_EBM_FOB";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_division";
                MyOraDB.Parameter_Name[1] = "arg_factory";
                MyOraDB.Parameter_Name[2] = "arg_obs_id";
                MyOraDB.Parameter_Name[3] = "arg_obs_type";
                MyOraDB.Parameter_Name[4] = "arg_style_cd";
                MyOraDB.Parameter_Name[5] = "arg_dev_name";
                MyOraDB.Parameter_Name[6] = "arg_mo_alias";
                MyOraDB.Parameter_Name[7] = "arg_bom_id";
                MyOraDB.Parameter_Name[8] = "arg_category";
                MyOraDB.Parameter_Name[9] = "arg_fob_status";
                MyOraDB.Parameter_Name[10] = "arg_fob_type";
                MyOraDB.Parameter_Name[11] = "arg_season_cd";
                MyOraDB.Parameter_Name[12] = "arg_quoted_ymd";
                MyOraDB.Parameter_Name[13] = "arg_gen_cd";
                MyOraDB.Parameter_Name[14] = "arg_size_cd";
                MyOraDB.Parameter_Name[15] = "arg_size_up";
                MyOraDB.Parameter_Name[16] = "arg_factory_fob";
                MyOraDB.Parameter_Name[17] = "arg_margin_rate";
                MyOraDB.Parameter_Name[18] = "arg_up";
                MyOraDB.Parameter_Name[19] = "arg_bottom";
                MyOraDB.Parameter_Name[20] = "arg_m_upper";
                MyOraDB.Parameter_Name[21] = "arg_m_packaging";
                MyOraDB.Parameter_Name[22] = "arg_m_midsole";
                MyOraDB.Parameter_Name[23] = "arg_m_outsole";
                MyOraDB.Parameter_Name[24] = "arg_m_size_up";
                MyOraDB.Parameter_Name[25] = "arg_m_price";
                MyOraDB.Parameter_Name[26] = "arg_m_ratio";
                MyOraDB.Parameter_Name[27] = "arg_extra";
                MyOraDB.Parameter_Name[28] = "arg_l_oh";
                MyOraDB.Parameter_Name[29] = "arg_profit";
                MyOraDB.Parameter_Name[30] = "arg_other_ad";
                MyOraDB.Parameter_Name[31] = "arg_nm_price";
                MyOraDB.Parameter_Name[32] = "arg_t_sample";
                MyOraDB.Parameter_Name[33] = "arg_t_production";
                MyOraDB.Parameter_Name[34] = "arg_tooling";
                MyOraDB.Parameter_Name[35] = "arg_fob";
                MyOraDB.Parameter_Name[36] = "arg_rate_idr";
                MyOraDB.Parameter_Name[37] = "arg_rate_inr";
                MyOraDB.Parameter_Name[38] = "arg_rate_krw";
                MyOraDB.Parameter_Name[39] = "arg_rate_rmb";
                MyOraDB.Parameter_Name[40] = "arg_rate_thb";
                MyOraDB.Parameter_Name[41] = "arg_rate_twd";
                MyOraDB.Parameter_Name[42] = "arg_rate_usd";
                MyOraDB.Parameter_Name[43] = "arg_rate_vnd";
                MyOraDB.Parameter_Name[44] = "arg_forecast";
                MyOraDB.Parameter_Name[45] = "arg_peak";
                MyOraDB.Parameter_Name[46] = "arg_retail";
                MyOraDB.Parameter_Name[47] = "arg_target";
                MyOraDB.Parameter_Name[48] = "arg_pattern_desc";
                MyOraDB.Parameter_Name[49] = "arg_tooling_desc";
                MyOraDB.Parameter_Name[50] = "arg_size_desc";
                MyOraDB.Parameter_Name[51] = "arg_remarks";
                MyOraDB.Parameter_Name[52] = "arg_status";
                MyOraDB.Parameter_Name[53] = "arg_upd_user";
                MyOraDB.Parameter_Name[54] = "arg_upd_method";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();

                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {                    
                    if (fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString().Equals("")) continue;

                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-",""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME]   == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS]     == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID]       == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY]     == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY    ].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS]   == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE]     == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString());            
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSEASON]       == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].ToString().Trim());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD]   == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD]       == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD]      == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP     ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP     ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxUP          ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxUP          ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM      ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM      ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER     ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER     ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE   ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE   ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE  ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE  ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP   ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP   ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE     ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE     ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO     ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO     ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA       ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA       ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH        ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH        ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT      ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT      ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING     ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING     ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB         ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB         ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND    ] == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND    ].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST]     == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPEAK]         == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPEAK].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPEAK].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL]       == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTARGET]       == null || fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTARGET].ToString().Trim().Equals("")) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTARGET].ToString().Replace(",", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC]    == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxREMARKS]      == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxREMARKS].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTATUS]       == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTATUS].ToString());
                    vList.Add(COM.ComVar.This_User);
                    vList.Add("U");

                } //end for i

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SAVE_EBM_FOB_PROD_MOLD : 
        /// </summary>
        public bool SAVE_EBM_FOB_PROD_MOLD()
        {
            try
            {

                MyOraDB.ReDim_Parameter(12);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SAVE_EBM_FOB_PROD_MOLD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                MyOraDB.Parameter_Name[4] = "ARG_SEQ";

                MyOraDB.Parameter_Name[5] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[6] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[7] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[8] = "ARG_MOLD_CODE";
                MyOraDB.Parameter_Name[9] = "ARG_PIM_SEQ";
                MyOraDB.Parameter_Name[10] = "ARG_ROUND";
                MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";

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

                //04.DATA 정의
                int iValueCount = 0;
                for (int iRow1 = fgrid_prod_mold.Rows.Fixed; iRow1 < fgrid_prod_mold.Rows.Count; iRow1++)
                {
                    if (fgrid_prod_mold[iRow1, 0] != null && fgrid_prod_mold[iRow1, 0].ToString().Equals("U"))
                        iValueCount += MyOraDB.Parameter_Name.Length;
                }

                MyOraDB.Parameter_Values = new string[iValueCount];
                for (int iRow2 = fgrid_prod_mold.Rows.Fixed, iIdx = 0; iRow2 < fgrid_prod_mold.Rows.Count; iRow2++)
                {
                    if (fgrid_prod_mold[iRow2, 0] != null && fgrid_prod_mold[iRow2, 0].ToString().Equals("U"))
                    {
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_prod_mold[iRow2, (int)ClassLib.TBEIS_FOB_MOLD.IxSEQ].ToString();

                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString();

                        MyOraDB.Parameter_Values[iIdx++] = fgrid_prod_mold[iRow2, (int)ClassLib.TBEIS_FOB_MOLD.IxMOLD_CODE].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_prod_mold[iRow2, (int)ClassLib.TBEIS_FOB_MOLD.IxPIM_SEQ].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxROUND].ToString();
                        MyOraDB.Parameter_Values[iIdx++] = COM.ComVar.This_User;
                    }
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

        #region Delete Data
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Event_Tbtn_Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Event_Tbtn_Delete()
        {
            foreach (int row in fgrid_Main.Selections)
            {
                if (fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxCHK].ToString().Equals("True"))
                    continue;
                fgrid_Main.Delete_Row(row);
            } // end foreach

        }
        #endregion

        #region Insert Data
        private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                fgrid_Main.Rows.Add();
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = "I";
                fgrid_Main.Select(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD);

                for (int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_FOB_MASTER.IxUP && i <= (int)ClassLib.TBEIS_FOB_MASTER.IxFOB)
                    {
                        fgrid_Main[fgrid_Main.Rows.Count - 1, i] = "0";
                    }
                    fgrid_Main.Cols[i].AllowEditing = true;
                }
                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;

                Pop_FOB_Master pop = new Pop_FOB_Master();
                pop.ShowDialog();

                if (pop.save_flg)
                {
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY] = pop.factory;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID] = pop.obs_id;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD] = pop.style_cd;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] = pop.style_name;
                }

                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion

        #region Confirm Data
        private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                // 행 수정상태 해제 
                fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, false);


                DialogResult dr01 = MessageBox.Show("Do you want to Confirm?", "Exclamation", MessageBoxButtons.YesNo);

                if (dr01 == DialogResult.No)                
                    return;
                
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {
                    string vflag  = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString();
                    string vcheck = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxCHK].ToString();

                    if (vflag.Equals("U") && vcheck.Equals("True"))
                    {
                        string factory  = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                        string obs_id   = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString();
                        string obs_type = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString();
                        string style_cd = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-", "");

                        string mo_alias = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();
                        string bom_id = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString();
                        string fob_type = fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString();

                        string status = "C";
                        string upd_user = COM.ComVar.This_User;

                        if (Confirm_EBM_FOB(factory, obs_id, obs_type, style_cd, mo_alias, bom_id, fob_type, status, upd_user))
                        {
                            fgrid_Main[i, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = "";
                            fgrid_Main.Rows[i].AllowEditing = false;
                            fgrid_Main.Rows[i].StyleNew.ForeColor = Color.Red;
                        }
                        else
                        {
                            MessageBox.Show("Database is Wrong, Please ask System.");
                            return;
                        }
                    }
                }
            }
            catch
            {
 
            }
        }

        private bool Confirm_EBM_FOB (
            string arg_factory,     string arg_obs_id,      string arg_obs_type,    string arg_style_cd, 
            string arg_mo_alias,    string arg_bom_id,      string arg_fob_type, 
            string arg_status,      string arg_upd_user)
        {
            try
            {              

                MyOraDB.ReDim_Parameter(9);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.CONFIRM_EBM_FOB";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_obs_id";
                MyOraDB.Parameter_Name[2] = "arg_obs_type";
                MyOraDB.Parameter_Name[3] = "arg_style_cd";

                MyOraDB.Parameter_Name[4] = "arg_mo_alias";
                MyOraDB.Parameter_Name[5] = "arg_bom_id";
                MyOraDB.Parameter_Name[6] = "arg_fob_type";
                
                MyOraDB.Parameter_Name[7] = "arg_status";
                MyOraDB.Parameter_Name[8] = "arg_upd_user";

                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;


                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style_cd;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_status;
                MyOraDB.Parameter_Values[8] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch 
            {
                return false;               
            }


        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void Event_Tbtn_Print()
        {
            saveFileDialog1.Filter = "Excel 파일|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            if (saveFileDialog1.FileName != "")
            {
                fgrid_Main.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "FOB", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveExcel(fgrid_Main, saveFileDialog1.FileName);

            }

        }

        private void SaveExcel(COM.FSP fGrid, string fileName)
        {

            string copyData = "";

            for (int nRow = 0; nRow < fgrid_Main.Rows.Count; nRow++)
            {
                for (int nCol = 0; nCol < fGrid.Cols.Count; nCol++)
                {
                    copyData += fGrid[nRow, nCol] + (nCol == fGrid.Cols.Count - 1 ? "\n" : "\t");
                }
            }

            Excel.Application exl = new Excel.ApplicationClass();
            Excel.Workbook wb = exl.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            exl.Visible = true;

            Excel.Worksheet ws = (Excel.Worksheet)wb.ActiveSheet;
            ws.Paste(ws.Cells[0, 0], copyData);
            
        }
        #endregion

        #region Grid Event
        private void fgrid_Main_MouseClick(object sender, MouseEventArgs e)
        {
            if (fgrid_Main.Selection.r1 <= fgrid_Main.Rows.Fixed)
                return;

            int sct_row = fgrid_Main.Selection.r1;
            int sct_col = fgrid_Main.Selection.c1;

            if (sct_col == (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD || 
                sct_col == (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME || 
                sct_col == (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID)
            {
                mnu_style.Visible = true;
            }
            else
            {
                mnu_style.Visible = false;
            }
            
            string sct_round = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxROUND].ToString();
            if (sct_round.Equals("Prod"))
            {
                mnu_insert.Visible = true;
            }
            else
            {
                mnu_insert.Visible = false;
            }
        }
        
        private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                //Event_fgrid_Main_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Event_fgrid_Main_AfterEdit()
        {
            int[] sct_rows = fgrid_Main.Selections;

            int sct_row = fgrid_Main.Selection.r1;
            int sct_col = fgrid_Main.Selection.c1;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                if (!fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString().Equals("I") && !fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString().Equals("D"))
                {
                    fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = "U";                    
                }

                fgrid_Main[sct_rows[i], sct_col] = fgrid_Main[sct_row, sct_col].ToString();
            }

            if (sct_col >= (int)ClassLib.TBEIS_FOB_MASTER.IxUP || sct_col <= (int)ClassLib.TBEIS_FOB_MASTER.IxFOB)
            {
                //Material
                double up     = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxUP] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString());
                double bottom = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString());
                double extra  = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString());
                
                double mat_tot = up + bottom;
                fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE] = mat_tot.ToString();
                
                
                //Non Material
                double l_oh     = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString());
                double other_ad = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString());
                double profit   = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString());
                
                double nm_price = l_oh + other_ad + profit;
                fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE] = nm_price.ToString();
                
                double t_total = Convert.ToDouble((fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Trim() == "" || fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING] == null) ? "0" : fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString());

                double fob = mat_tot + nm_price + t_total + extra;
                fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB] = fob.ToString();

                double m_ratio = mat_tot * 100 / fob;
                fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO] = m_ratio.ToString("##,###,##0.00");
            }
        }

        private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Event_fgrid_Main_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Event_fgrid_Main_BeforeEdit()
        {
            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
            }

        }
        
        private void fgrid_Main_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_Main.Rows.Count == fgrid_Main.Rows.Fixed)
                    return;

                this.Cursor = Cursors.WaitCursor;               

                int sct_row = fgrid_Main.Selection.r1;

                string arg_factory  = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                string arg_obs_id   = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString();
                string arg_obs_type = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString();
                string arg_style    = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-", "");

                string arg_mo_alias = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();
                string arg_bom_id   = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString();
                string arg_fob_type = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString();

                string arg_round = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxROUND].ToString();

                System.Data.DataSet ds_ret = SELECT_EBM_FOB_DETAIL(
                    arg_factory, arg_obs_id, arg_obs_type, arg_style, 
                    arg_mo_alias, arg_bom_id, arg_fob_type, 
                    arg_round);

                
                System.Data.DataTable dt_detail = ds_ret.Tables[0];
                System.Data.DataTable dt_midsole = ds_ret.Tables[1];
                System.Data.DataTable dt_outsole = ds_ret.Tables[2];
                System.Data.DataTable dt_labor = ds_ret.Tables[3];
                System.Data.DataTable dt_overhead = ds_ret.Tables[4];
                System.Data.DataTable dt_sample_mold = ds_ret.Tables[5];
                System.Data.DataTable dt_prod_mold = ds_ret.Tables[6];
                System.Data.DataTable dt_etc = ds_ret.Tables[7];
                System.Data.DataTable dt_5523 = ds_ret.Tables[8];

                System.Data.DataTable vDT = SELECT_EBM_FOB_DETAIL_REGION(arg_factory, arg_style, arg_mo_alias, arg_bom_id, arg_fob_type);
                if (vDT != null)
                {
                    ClassLib.ComCtl.Set_ComboList(vDT, cmb_region, 0, 0, false);
                    cmb_region.SelectedValue = "US";

                    if (cmb_region.SelectedIndex == -1)
                        cmb_region.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
                }

                Display_Grid_Detail(dt_detail);                
                Display_Grid_Bottom(fgrid_midsole, dt_midsole);
                Display_Grid_Bottom(fgrid_outsole, dt_outsole);
                Display_Grid_Labor(dt_labor);
                Display_Grid_Overhead(dt_overhead);
                Display_Grid_Mold(fgrid_sample_mold, dt_sample_mold);
                Display_Grid_Mold(fgrid_prod_mold, dt_prod_mold);
                Display_Grid_Etc(dt_etc);
                Display_Grid_5523(dt_5523);
            }
            catch 
            {
                
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Display_Grid_Detail(System.Data.DataTable arg_dt)
        {
            fgrid_upper.ClearAll();
            fgrid_packing.ClearAll();

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                string _class = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_FOB_DETAIL.IxCLASS].ToString().Trim();

                if (_class.Equals("UP") || _class.Equals("PC") || _class.Equals("LCE") || _class.Equals("OTHER") || _class.Equals("TH") || _class.Equals("CM"))
                {
                    fgrid_upper.Rows.Add();

                    for (int j = fgrid_upper.Cols.Fixed; j < fgrid_upper.Cols.Count; j++)
                    {
                        if (j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxFX_RATE) || j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxMAT_PRICE))
                        {
                            try
                            {
                                fgrid_upper[fgrid_upper.Rows.Count - 1, j] = double.Parse(arg_dt.Rows[i].ItemArray[j].ToString()).ToString("###,###,##0.###0");
                            }
                            catch
                            {
                                fgrid_upper[fgrid_upper.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString(); 
                            }
                        }
                        else if (j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxFCT_LND_TOT) || j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxFCT_LND_USD_TOT))
                        {
                            try
                            {
                                fgrid_upper[fgrid_upper.Rows.Count - 1, j] = double.Parse(arg_dt.Rows[i].ItemArray[j].ToString()).ToString("###,###,##0.##0");
                            }
                            catch
                            {
                                fgrid_upper[fgrid_upper.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                            }
                        }
                        else
                        {
                            fgrid_upper[fgrid_upper.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                        }
                    }
                }
                else if (_class.Equals("PK"))
                {
                    fgrid_packing.Rows.Add();

                    for (int j = fgrid_packing.Cols.Fixed; j < fgrid_packing.Cols.Count; j++)
                    {
                        if (j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxFX_RATE) || j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxMAT_PRICE))
                        {
                            try
                            {
                                fgrid_packing[fgrid_packing.Rows.Count - 1, j] = double.Parse(arg_dt.Rows[i].ItemArray[j].ToString()).ToString("###,###,##0.###0");
                            }
                            catch
                            {
                                fgrid_packing[fgrid_packing.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                            }
                        }
                        else if (j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxFCT_LND_TOT) || j.Equals((int)ClassLib.TBEIS_FOB_DETAIL.IxFCT_LND_USD_TOT))
                        {
                            try
                            {
                                fgrid_packing[fgrid_packing.Rows.Count - 1, j] = double.Parse(arg_dt.Rows[i].ItemArray[j].ToString()).ToString("###,###,##0.##0");
                            }
                            catch
                            {
                                fgrid_packing[fgrid_packing.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                            }
                        }
                        else
                        {
                            fgrid_packing[fgrid_packing.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                        }
                    }
                }
            }
        }
        private void Display_Grid_Bottom(COM.FSP arg_fsp, System.Data.DataTable arg_dt)
        {
            arg_fsp.ClearAll();

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_fsp.Rows.Add();

                for (int j = arg_fsp.Cols.Fixed; j < arg_fsp.Cols.Count; j++)
                {
                    arg_fsp[arg_fsp.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
            }
        }
        private void Display_Grid_Labor(System.Data.DataTable arg_dt)
        {
            fgrid_labor.ClearAll();           

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_labor.Rows.Add();

                for (int j = fgrid_labor.Cols.Fixed; j < fgrid_labor.Cols.Count; j++)
                {
                    fgrid_labor[fgrid_labor.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
            }
        }
        private void Display_Grid_Overhead(System.Data.DataTable arg_dt)
        {
            fgrid_overhead.ClearAll();

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_overhead.Rows.Add();

                for (int j = fgrid_overhead.Cols.Fixed; j < fgrid_overhead.Cols.Count; j++)
                {
                    fgrid_overhead[fgrid_overhead.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
            }
        }
        private void Display_Grid_Mold(COM.FSP arg_fsp, System.Data.DataTable arg_dt)
        {
            arg_fsp.ClearAll();
            fgrid_pm_meof_head.ClearAll();
            fgrid_pm_meof_size.ClearAll();

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_fsp.Rows.Add();

                for (int j = arg_fsp.Cols.Fixed; j < arg_fsp.Cols.Count; j++)
                {
                    if (j.Equals((int)ClassLib.TBEIS_FOB_MOLD.IxUSD) || j.Equals((int)ClassLib.TBEIS_FOB_MOLD.IxUSD_PAIR))
                    {
                        try
                        {
                            arg_fsp[arg_fsp.Rows.Count - 1, j] = double.Parse(arg_dt.Rows[i].ItemArray[j].ToString()).ToString("###,###,##0.#0");
                        }
                        catch
                        {
                            arg_fsp[arg_fsp.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                        }
                    }
                    else
                    {
                        arg_fsp[arg_fsp.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                    }
                }
            }
        }
        private void Display_Grid_Etc(System.Data.DataTable arg_dt)
        {
            fgrid_etc.ClearAll();

            if (arg_dt.Rows.Count == 0)
                return;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_etc.Rows.Add();

                for (int j = fgrid_etc.Cols.Fixed; j < fgrid_etc.Cols.Count; j++)
                {
                    fgrid_etc[fgrid_etc.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
            }
        }
        private void Display_Grid_5523(System.Data.DataTable arg_dt)
        {
            fgrid_5523.ClearAll();
            fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
            txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
            txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
            txt_date_5523.Text = "";
            txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
            txt_other_5523.Text = ""; 

            if (arg_dt.Rows.Count == 0)
                return;

            string sTBOM = "";
            string sTStyle = "";

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                // Set header
                if (i == 0)
                {
                    txt_prodCode_5523.Text = arg_dt.Rows[i]["prod_code"].ToString();
                    txt_devCode_5523.Text = arg_dt.Rows[i]["dev_code"].ToString();
                    txt_prodName_5523.Text = arg_dt.Rows[i]["prod_name"].ToString();
                    txt_prodType_5523.Text = arg_dt.Rows[i]["prod_type"].ToString();
                    txt_factory_5523.Text = arg_dt.Rows[i]["factory"].ToString();
                    txt_season_5523.Text = arg_dt.Rows[i]["season_cd"].ToString();
                    txt_date_5523.Text = arg_dt.Rows[i]["app_ymd"].ToString();

                    txt_leather_5523.Text = arg_dt.Rows[i]["leather_pct"].ToString();
                    txt_synthetic_5523.Text = arg_dt.Rows[i]["synthetic_pct"].ToString();
                    txt_textile_5523.Text = arg_dt.Rows[i]["textile_pct"].ToString();
                    txt_other_5523.Text = arg_dt.Rows[i]["other_pct"].ToString();

                    string sBOM = arg_dt.Rows[i]["bom_id"].ToString();
                    string sStyle = arg_dt.Rows[i]["style_cd"].ToString();

                    C1.Win.C1FlexGrid.Column col = fgrid_5523.Cols.Add();
                    col.TextAlign = TextAlignEnum.CenterCenter;
                    col[fgrid_5523.Rows.Fixed - 1] = sStyle;
                    col[fgrid_5523.Rows.Fixed - 2] = sBOM;

                    for (int ii = i; ii < arg_dt.Rows.Count; ii++, i++)
                    {
                        sTBOM = arg_dt.Rows[ii]["bom_id"].ToString();
                        sTStyle = arg_dt.Rows[ii]["style_cd"].ToString();
                        if (!sBOM.Equals(sTBOM) && !sStyle.Equals(sTStyle))
                        {
                            i = ii;
                            break;
                        }

                        C1.Win.C1FlexGrid.Row row = fgrid_5523.Rows.Add();
                        row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxSEQ] = arg_dt.Rows[ii]["seq"];
                        row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_DIV] = arg_dt.Rows[ii]["comp_div"];
                        row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_NAME] = arg_dt.Rows[ii]["comp_name"];
                        row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = arg_dt.Rows[ii]["measual_data"];
                        row[col.Index] = arg_dt.Rows[ii]["bom_comp_read"];
                    }
                }
                else
                {
                    int iRow = fgrid_5523.Rows.Fixed;
                    string sBOM2 = arg_dt.Rows[i]["bom_id"].ToString();
                    string sStyle2 = arg_dt.Rows[i]["style_cd"].ToString();

                    C1.Win.C1FlexGrid.Column col2 = fgrid_5523.Cols.Add();
                    col2[fgrid_5523.Rows.Fixed - 1] = sStyle2;
                    col2[fgrid_5523.Rows.Fixed - 2] = sBOM2;

                    for (int ii = i; ii < arg_dt.Rows.Count; ii++)
                    {
                        sTBOM = arg_dt.Rows[ii]["bom_id"].ToString();
                        sTStyle = arg_dt.Rows[ii]["style_cd"].ToString();
                        if (sBOM2.Equals(sTBOM) && sStyle2.Equals(sTStyle))
                        {
                            i = ii;
                            break;
                        }

                        fgrid_5523[iRow, (int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = arg_dt.Rows[ii]["measual_data"];
                        fgrid_5523[iRow, col2.Index] = arg_dt.Rows[ii]["bom_comp_read"];
                    }
                }
            }
        }

        private System.Data.DataSet SELECT_EBM_FOB_DETAIL(
            string arg_factory, string arg_obs_id, string arg_obs_type, string arg_style, 
            string arg_mo_alias, string arg_bom_id, string arg_fob_type, 
            string arg_round)
        {
            try
            {
                int idx = 0;

                #region DETAIL
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_DETAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(true);
                #endregion  

                #region MIDSOLE + OUTSOLE
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MIDSOLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(false);


                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_OUTSOLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(false);
                #endregion   

                #region LABOR
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_LABOR";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";


                MyOraDB.Add_Select_Parameter(false);
                #endregion

                #region OVERHEAD
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_OVERHEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(false);
                #endregion

                #region MOLD
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_SAMPLE_MOLD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(false);


                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_PROD_MOLD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(false);
                #endregion

                #region Etc
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_ETC";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(false);
                #endregion

                #region Etc
                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_5523";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE";
                MyOraDB.Parameter_Name[2] = "ARG_REGION";

                MyOraDB.Parameter_Name[3] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[6] = "ARG_ROUND";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (idx = 0; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style;
                MyOraDB.Parameter_Values[2] = "US";

                MyOraDB.Parameter_Values[3] = arg_mo_alias;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = arg_fob_type;

                MyOraDB.Parameter_Values[6] = arg_round;
                MyOraDB.Parameter_Values[7] = "";

                MyOraDB.Add_Select_Parameter(false);
                #endregion
                                                
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void fgrid_prod_mold_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_sample_mold.Rows.Fixed < fgrid_sample_mold.Rows.Count &&
                    fgrid_sample_mold.Row >= fgrid_sample_mold.Rows.Fixed)
                {
                    string sFactory = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                    string sMOID = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();

                    DisplayMEOFHead(fgrid_pm_meof_head, fgrid_pm_meof_size, sFactory, sMOID);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Sample mold click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMEOFHead(COM.FSP fgrid_meof_head, COM.FSP fgrid_meof_size, string sFactory, string sMOID)
        {
            try
            {
                fgrid_meof_head.ClearAll();
                fgrid_meof_size.ClearAll();

                System.Data.DataTable vDDT = SELECT_EBM_FOB_MEOF_HEAD(sFactory, sMOID);
                System.Data.DataTable vHDT = MyOraDB.Select_GridHead("EBM_FOB_MEOF_HEAD", "4");

                if (vDDT != null && vHDT != null)
                {
                    for (int iDIdx = 0; iDIdx < vDDT.Rows.Count; iDIdx++)
                    {
                        for (int iDCol = 0, iHIdx = 0; iDCol < vDDT.Rows[iDIdx].ItemArray.Length; iDCol++, iHIdx++)
                        {
                            Row newRow = fgrid_meof_head.Rows.Add();
                            newRow[1] = vHDT.Rows[iHIdx]["head_desc1"];
                            newRow[2] = vDDT.Rows[iDIdx][iDCol];

                            newRow.IsNode = true;

                            if (iDCol == 0)
                            {
                                newRow.Node.Level = 0;
                                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                            }
                            else
                            {
                                newRow.Node.Level = 1;
                                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                            }
                        }
                    }

                    fgrid_meof_head.Tree.Column = 1;
                    fgrid_meof_head.Tree.Show(0);
                    fgrid_meof_head.ExtendLastCol = true;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMEOFSize(COM.FSP fgrid_meof_head, COM.FSP fgrid_meof_size)
        {
            try
            {
                if (fgrid_meof_head.Rows.Fixed < fgrid_meof_head.Rows.Count &&
                    fgrid_meof_head.Row >= fgrid_meof_head.Rows.Fixed)
                {
                    fgrid_meof_size.ClearAll();

                    string sFactory = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                    string sMOID = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();

                    int iPRow = fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.Row.Index;
                    if (fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.Level > 0)
                        iPRow = fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

                    string sMoldCD = fgrid_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxMOLD_CD + (iPRow - 1), 2].ToString();
                    string sPIMSeq = fgrid_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxPIM_SEQ + (iPRow - 1), 2].ToString();

                    System.Data.DataTable vDT = SELECT_EBM_FOB_MEOF_SIZE(sFactory, sMOID, sMoldCD, sPIMSeq);

                    if (vDT != null && vDT.Rows.Count > 0)
                    {
                        fgrid_meof_size.Display_Grid(vDT, false);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF size", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_REGION : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_DETAIL_REGION(
            string arg_factory, string arg_style_cd, 
            string arg_mo_alias, string arg_bom_id, string arg_fob_type)
        {
            try
            {

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_REGION";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
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
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_mo_alias;
                MyOraDB.Parameter_Values[3] = arg_fob_type;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_HEAD : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_MEOF_HEAD(string arg_factory, string arg_moid)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_SIZE : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_MEOF_SIZE(string arg_factory, string arg_moid, string arg_mold_cd, string arg_pim_seq)
        {
            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_SIZE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_MOLD_CD";
                MyOraDB.Parameter_Name[3] = "ARG_PIM_SEQ";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_mold_cd;
                MyOraDB.Parameter_Values[3] = arg_pim_seq;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmb_region_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sRegion = ClassLib.ComFunction.Empty_Combo(cmb_region, "");
                if (!sRegion.Equals(""))
                {
                    int sct_row = fgrid_Main.Row;

                    string sFactory = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                    string sStyle = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-", "");

                    string sMOID = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();
                    string sBOMID = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString();
                    string sFobType = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString();
                    string sRound = fgrid_Main[sct_row, (int)ClassLib.TBEIS_FOB_MASTER.IxROUND].ToString();

                    System.Data.DataTable vDT = SELECT_EBM_FOB_5523(sFactory, sStyle, sRegion,
                        sMOID, sBOMID, sFobType, sRound);

                    if (vDT != null)
                    {
                        Display_Grid_5523(vDT);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Region select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_5523 : 
        /// </summary>
        /// <returns>DataTable</returns>
        public System.Data.DataTable SELECT_EBM_FOB_5523(string arg_factory, string arg_style, string arg_region, 
            string arg_mo_alias, string arg_bom_id, string arg_fob_type, 
            string arg_round)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_5523";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE";
                MyOraDB.Parameter_Name[2] = "ARG_REGION";

                MyOraDB.Parameter_Name[3] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[6] = "ARG_ROUND";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";
            
                //03.DATA TYPE 정의
                int idx = 0;
                for (; idx < MyOraDB.Parameter_Name.Length - 1; idx++)
                {
                    MyOraDB.Parameter_Type[idx] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style;
                MyOraDB.Parameter_Values[2] = arg_region;

                MyOraDB.Parameter_Values[3] = arg_mo_alias;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = arg_fob_type;

                MyOraDB.Parameter_Values[6] = arg_round;
                MyOraDB.Parameter_Values[7] = "";

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

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                if (cmb_Factory.SelectedIndex == -1) return;

                Set_season();                            
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }                                               
        private void cmb_season_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_season.SelectedIndex == -1) return;

                Set_obs_id();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Set_season()
        {
            System.Data.DataTable dt_ret = Select_season();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_season.SelectedIndex = 0;

            dt_ret.Dispose();
        }
        private void Set_obs_id()
        {
            System.Data.DataTable dt_ret = Select_obs_id();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ObsID, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_ObsID.SelectedIndex = 0;

            dt_ret.Dispose();
        }
        
        private System.Data.DataTable Select_season()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_SEASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }
        private System.Data.DataTable Select_obs_id()
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_OBS_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = cmb_season.SelectedValue.ToString();
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }
        
        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }
        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }
        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }
        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }

        private void chk_Model_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Model.Checked)
            {
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].Visible     = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY].Visible   = true;
                //fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].Visible   = true;
                //fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].Visible     = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].Visible     = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD].Visible    = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].Visible    = true;
            }
            else
            {
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].Visible     = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY].Visible   = false;
                //fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].Visible   = false;
                //fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].Visible     = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].Visible     = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD].Visible    = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].Visible    = false;
            }
        }
        private void chk_rate_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_rate.Checked)
            {
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].Visible = true;
            }
            else
            {
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].Visible = false;
            }
        }
        private void chk_desc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_desc.Checked)
            {
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC].Visible = true;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC].Visible    = true;
            }
            else
            {
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC].Visible = false;
                fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC].Visible    = false;
            }
        }
        #endregion

        /*
        #region Batch Event
        private void Event_btn_Batch_Click()
        {
            if (cmb_Factory.SelectedIndex == -1 || cmb_ObsID.SelectedIndex == -1) return;


            DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);

            if (result == DialogResult.No) return;



            string this_factory = ClassLib.ComVar.This_Factory;
            string factory      = cmb_Factory.SelectedValue.ToString();
            string obs_id       = cmb_ObsID.SelectedValue.ToString();
            string upd_user     = ClassLib.ComVar.This_User;

            bool run_flag = RUN_STM_FOB_TO_EBM_FOB(this_factory, factory, obs_id, upd_user);

            if (run_flag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

                Display_LastUpdateDate();
            }
            else
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
            }


        }
        private bool RUN_STM_FOB_TO_EBM_FOB(string arg_this_factory, string arg_factory, string arg_obs_id, string arg_upd_user)
        {
            try
            {
                int col_ct = 4;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_TMP.RUN_STM_FOB_TO_EBM_FOB";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_this_factory;
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_obs_id;
                MyOraDB.Parameter_Values[3] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion
        */

        #region Context Menu Event
        private void menuItem_TreeViewHead_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_TreeViewHead();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_TreeViewHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void menuItem_TreeViewDetail_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_TreeViewDetail();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_TreeViewDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void mnu_insert_Click(object sender, EventArgs e)
        {
            try
            {
                int [] sct_rows = fgrid_Main.Selections;

                for (int row = 0; row < sct_rows.Length; row++)
                {
                    fgrid_Main.Rows.Add();
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV] = "I";

                    for (int i = fgrid_Main.Cols.Fixed + 1; i < fgrid_Main.Cols.Count; i++)
                    {
                        fgrid_Main[fgrid_Main.Rows.Count - 1, i] = (fgrid_Main[fgrid_Main.Selection.r1, i] == null) ? "" : fgrid_Main[fgrid_Main.Selection.r1, i].ToString();
                        fgrid_Main.Cols[i].AllowEditing = true;
                    }
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;

                }

                if (sct_rows.Length > 1)
                {
                    fgrid_Main.Select(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD);
                }
                else
                {
                    string factory = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                    string obs_id = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString();
                    string style_cd = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString();

                    fgrid_Main.Select(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD);

                    Pop_FOB_Master pop = new Pop_FOB_Master(factory, obs_id, style_cd);
                    pop.ShowDialog();

                    if (pop.save_flg)
                    {
                        fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY]    = pop.factory;
                        fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID]     = pop.obs_id;
                        fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD]   = pop.style_cd;
                        fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] = pop.style_name;
                    }
                }                
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void mnu_style_Click(object sender, EventArgs e)
        {
            int sct_rows = fgrid_Main.Selection.r1;

            string factory  = fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
            string obs_id   = fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString();
            string style_cd = fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString();

            Pop_FOB_Master pop = new Pop_FOB_Master(factory, obs_id, style_cd);
            pop.ShowDialog();

            if (pop.save_flg)
            {
                if(!fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString().Equals("I"))
                    fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxDIV]        = "U";

                fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY]    = pop.factory;
                fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID]     = pop.obs_id;
                fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD]   = pop.style_cd;
                fgrid_Main[sct_rows, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] = pop.style_name;
            }
        }
        private void mnu_exportXML_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ExportXML();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ExportXML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Event_menuItem_TreeViewHead()
        {
            fgrid_Main.Tree.Show(_LevelHead);
        }
        private void Event_menuItem_TreeViewDetail()
        {
            fgrid_Main.Tree.Show(_LevelDetail);
        }
        private void ExportXML()
        {
            int[] sels = fgrid_Main.Selections;

            if (sels.Length <= 0)
                return;

            int iFirstRow = sels[0];

            FlexCDC.FOB.CBDExcel.V_1_220.XMLExporter exporter = new FlexCDC.FOB.CBDExcel.V_1_220.XMLExporter(null, null, null, null);
            // 1st
            string factory = null, obs_id = null, obs_type = null, style_cd = null;

            // 2nd
            string season = null, dev_name = null, model_name = null, bom_id = null, fob_type = null, round = null;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                exporter.Path = fbd.SelectedPath;

                foreach (int row in sels)
                {
                    factory = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString();
                    obs_id = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString();
                    obs_type = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString();
                    style_cd = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString();
                    style_cd = style_cd.Replace("-", "");

                    exporter.Factory = factory;
                    exporter.Obs_id = obs_id;
                    exporter.Obs_type = obs_type;
                    exporter.Style_cd = style_cd;

                    season = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].ToString();
                    dev_name = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString();
                    model_name = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME].ToString();
                    bom_id = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString();
                    fob_type = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString();

                    round = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_MASTER.IxROUND].ToString();

                    string season_y = season.Substring(2, 2);
                    string season_m = season.Substring(4, 2);
                    if (season_m.Equals("01"))
                        season_y = "SP" + season_y;
                    else if (season_m.Equals("02"))
                        season_y = "SU" + season_y;
                    else if (season_m.Equals("03"))
                        season_y = "FA" + season_y;
                    else if (season_m.Equals("04"))
                        season_y = "HO" + season_y;

                    exporter.Season = season_y;
                    exporter.Dev_name = dev_name;
                    exporter.Model_name = model_name;
                    exporter.Bom_id = bom_id;
                    exporter.Fob_type = fob_type;
                    exporter.Round = round;

                    if (iFirstRow == row)
                        exporter.CreateXML(sels.Length > 1);

                    exporter.ExportXML();
                }

                exporter.flushXML();
            }
        }
        #endregion

        private void btn_cbd_Click(object sender, EventArgs e)
        {
            try
            {
                CBDExcel.ExcelUploader uploader = new FlexCDC.FOB.CBDExcel.ExcelUploader();
                if (uploader.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CBD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_5523_Click(object sender, EventArgs e)
        {
            try
            {
                //string sRound = " ";
                //if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed) 
                //    sRound = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString();

                FlexCDC.FOB.CBDExcel.ExcelUpload_5523 uploader = new FlexCDC.FOB.CBDExcel.ExcelUpload_5523();
                uploader.Round = " ";

                uploader.WindowState = FormWindowState.Normal;
                uploader.ShowDialog();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "5523", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_meof_Click(object sender, EventArgs e)
        {
            try
            {
                FlexCDC.FOB.CBDExcel.ExcelUpload_MEOF uploader = new FlexCDC.FOB.CBDExcel.ExcelUpload_MEOF();
                uploader.WindowState = FormWindowState.Normal;
                uploader.ShowDialog();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab_detail_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name.Equals("tab_prod_mold"))
            {
                int iTotWidth = tab_detail.Width;

                fgrid_prod_mold.Width = (int)(iTotWidth * 0.5);
                fgrid_pm_meof_head.Width = (int)(iTotWidth * 0.3);
            }
        }

        private void fgrid_pm_meof_head_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_pm_meof_head.Rows.Fixed < fgrid_pm_meof_head.Rows.Count &&
                    fgrid_pm_meof_head.Row >= fgrid_pm_meof_head.Rows.Fixed)
                {
                    DisplayMEOFSize(fgrid_pm_meof_head, fgrid_pm_meof_size);

                    int iPRow = fgrid_pm_meof_head.Rows[fgrid_pm_meof_head.Row].Node.Row.Index;
                    if (fgrid_pm_meof_head.Rows[fgrid_pm_meof_head.Row].Node.Level > 0)
                        iPRow = fgrid_pm_meof_head.Rows[fgrid_pm_meof_head.Row].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

                    string sMoldCD = fgrid_pm_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxMOLD_CD + (iPRow - 1), 2].ToString();
                    string sPIMSeq = fgrid_pm_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxPIM_SEQ + (iPRow - 1), 2].ToString();

                    fgrid_pm_meof_head.DoDragDrop(new string[] { sMoldCD, sPIMSeq }, DragDropEffects.Move);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fgrid_prod_mold_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] vData = (string[])e.Data.GetData("System.String[]");

                fgrid_prod_mold[fgrid_prod_mold.MouseRow, (int)ClassLib.TBEIS_FOB_MOLD.IxMOLD_CODE] = vData[0];
                fgrid_prod_mold[fgrid_prod_mold.MouseRow, (int)ClassLib.TBEIS_FOB_MOLD.IxPIM_SEQ] = vData[1];
                fgrid_prod_mold.Update_Row(fgrid_prod_mold.MouseRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fgrid_prod_mold_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (fgrid_prod_mold.Rows.Fixed < fgrid_prod_mold.Rows.Count &&
                    fgrid_prod_mold.Row >= fgrid_prod_mold.Rows.Fixed)
                {
                    if (fgrid_prod_mold.Col == (int)ClassLib.TBEIS_FOB_MOLD.IxMOLD_CODE)
                    {
                        if (e.KeyCode == Keys.Delete)
                        {
                            fgrid_prod_mold[fgrid_prod_mold.Row, (int)ClassLib.TBEIS_FOB_MOLD.IxMOLD_CODE] = "";
                            fgrid_prod_mold[fgrid_prod_mold.Row, (int)ClassLib.TBEIS_FOB_MOLD.IxPIM_SEQ] = "";
                            fgrid_prod_mold.Update_Row(fgrid_prod_mold.Row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fgrid_prod_mold_DragOver(object sender, DragEventArgs e)
        {
            if (fgrid_prod_mold.Rows.Fixed >= fgrid_prod_mold.Rows.Count ||
                fgrid_prod_mold.MouseRow < fgrid_prod_mold.Rows.Fixed)
                e.Effect = DragDropEffects.None;
            else
                e.Effect = DragDropEffects.Move;
        }

    }
}
