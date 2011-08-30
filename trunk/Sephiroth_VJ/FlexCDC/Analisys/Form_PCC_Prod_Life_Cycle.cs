using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace EIS.PCC
{
    public partial class Form_PCC_Prod_Life_Cycle : COM.APSWinForm.Form_Top
    {
        #region 생성자
        public Form_PCC_Prod_Life_Cycle()
        {
            InitializeComponent();
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        #endregion

        #region Form Loading
        private void Form_PCC_Prod_Life_Cycle_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();

            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void Init_Form()
        {
            //Title
            this.Text = "PCC Production Life Cycle";
            lbl_MainTitle.Text = "PCC Production Life Cycle";

            //Grid Setting
            fgrid_main.Set_Grid("EDM_PCC_PROD_LIFE", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.ExtendLastCol = false;
            fgrid_main.AllowSorting = AllowSortingEnum.None;
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.Tree.Column = (int)ClassLib.TBEDM_PCC_PROD_LIFE.IxITEM;

            Init_Control();
        }

        private void Init_Control()
        {
            //Button Setting
            tbtn_New.Enabled    = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled  = false;
            tbtn_Save.Enabled   = false;
            tbtn_Print.Enabled  = false;

            tbtn_Search.Enabled = true;

            // Factory Combobox Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 0;

            // Season Combobox Setting            
            dt_ret = SELECT_SEASON();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_from.SelectedValue = System.DateTime.Now.AddMonths(1).ToString("yyyyMM");
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_to.SelectedValue = System.DateTime.Now.AddMonths(1).ToString("yyyyMM");

            // Category Combobox Setting
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Category.SelectedIndex = 0;
                       
            // Style Combobox Setting
            dt_ret = SELECT_MODEL();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_StyleName, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_StyleName.SelectedIndex = 0;

            //radio btn setting
            rdbtn_viewSeason.Checked = false;
            rdbtn_viewFactory.Checked = false;
            rdbtn_viewCategory.Checked = true;
            rdbtn_viewModel.Checked = false;
            rdbtn_viewBom.Checked = false;

            dt_ret.Dispose();
 
        }

        private System.Data.DataTable SELECT_SEASON()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_SEASON";

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private System.Data.DataTable SELECT_CATEGORY()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_CATEGORY";

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private System.Data.DataTable SELECT_MODEL()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_MODEL_LIST";

            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = cmb_Season_from.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = cmb_Season_to.SelectedValue.ToString();
            MyOraDB.Parameter_Values[3] = cmb_Category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = "";
            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
       
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataTable dt_ret_01 = SELECT_PCC_PROD_LIFE_CYCLE();
                DataTable dt_ret_02 = SELECT_PCC_PROD_MIN_MAX();

                Display_Grid(dt_ret_01, dt_ret_02);
                dt_ret_01.Dispose();
                dt_ret_02.Dispose();

            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;  
            }
        }

        private void Display_Grid(DataTable arg_dt_01, DataTable arg_dt_02)
        {
            fgrid_main.ClearAll();
            fgrid_main.Cols.Count = (int)ClassLib.TBEDM_PCC_PROD_LIFE.IxOTH_T_YMD + 1;

            for (int k = 0; k < arg_dt_02.Rows.Count; k++)
            {
                fgrid_main.Cols.Add();
                fgrid_main.Cols[fgrid_main.Cols.Count - 1].Width = 50;

                fgrid_main[fgrid_main.Rows.Fixed - 2, fgrid_main.Cols.Count - 1] = arg_dt_02.Rows[k].ItemArray[0].ToString();
                fgrid_main[fgrid_main.Rows.Fixed - 1, fgrid_main.Cols.Count - 1] = arg_dt_02.Rows[k].ItemArray[1].ToString();
                fgrid_main[fgrid_main.Rows.Fixed - 3, fgrid_main.Cols.Count - 1] = arg_dt_02.Rows[k].ItemArray[2].ToString();
            }


            for (int i = 0; i < arg_dt_01.Rows.Count; i++)
            {
                int lev = int.Parse(arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxT_LEV].ToString());

                fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, lev);

                int LKS_F_IDX = 0;
                int SMM_F_IDX = 0;
                int RLF_F_IDX = 0;
                int GTM_F_IDX = 0;
                int ACN_F_IDX = 0;
                int PRE_F_IDX = 0;
                int RFC_F_IDX = 0;
                int PRO_F_IDX = 0;
                int OTH_F_IDX = 0;        

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    if (j <= (int)ClassLib.TBEDM_PCC_PROD_LIFE.IxOTH_T_YMD)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt_01.Rows[i].ItemArray[j].ToString();
                    }
                    else
                    {
                        string LKS_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxLKS_F_YMD].ToString();
                        string LKS_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxLKS_T_YMD].ToString();
                        string SMM_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxSMM_F_YMD].ToString();
                        string SMM_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxSMM_T_YMD].ToString();
                        string RLF_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxRLF_F_YMD].ToString();
                        string RLF_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxRLF_T_YMD].ToString();
                        string GTM_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxGTM_F_YMD].ToString();
                        string GTM_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxGTM_T_YMD].ToString();
                        string ACN_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxACN_F_YMD].ToString();
                        string ACN_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxACN_T_YMD].ToString();
                        string PRE_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxPRE_F_YMD].ToString();
                        string PRE_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxPRE_T_YMD].ToString();
                        string RFC_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxRFC_F_YMD].ToString();
                        string RFC_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxRFC_T_YMD].ToString();
                        string PRO_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxPRO_F_YMD].ToString();
                        string PRO_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxPRO_T_YMD].ToString();
                        string OTH_F_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxOTH_F_YMD].ToString();
                        string OTH_T_YMD = arg_dt_01.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_LIFE.IxOTH_T_YMD].ToString();

                        string title = fgrid_main[fgrid_main.Rows.Fixed - 2, j].ToString() + fgrid_main[fgrid_main.Rows.Fixed - 3, j].ToString();

                        if (title.Equals(LKS_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "LKS_FROM";                            
                            LKS_F_IDX = j;
                        }
                        if (title.Equals(LKS_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "LKS_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, LKS_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                            
                        }
                        if (title.Equals(SMM_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "SMM_F_YMD";                            
                            SMM_F_IDX = j;
                        }
                        if (title.Equals(SMM_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "SMM_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, SMM_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(RLF_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "RLF_F_YMD";                            
                            RLF_F_IDX = j;
                        }
                        if (title.Equals(RLF_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "RLF_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, RLF_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(GTM_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "GTM_F_YMD";                            
                            GTM_F_IDX = j;
                        }
                        if (title.Equals(GTM_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "GTM_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, GTM_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(ACN_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "ACN_F_YMD";                            
                            ACN_F_IDX = j;
                        }
                        if (title.Equals(ACN_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "ACN_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, ACN_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(PRE_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "PRE_F_YMD";                            
                            PRE_F_IDX = j;
                        }
                        if (title.Equals(PRE_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "PRE_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, PRE_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(RFC_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "RFC_F_YMD";                            
                            RFC_F_IDX = j;
                        }
                        if (title.Equals(RFC_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "RFC_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, RFC_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(PRO_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "PRO_F_YMD";                            
                            PRO_F_IDX = j;
                        }
                        if (title.Equals(PRO_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "PRO_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, PRO_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;
                        }
                        if (title.Equals(OTH_F_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "OTH_F_YMD";                            
                            OTH_F_IDX = j;
                        }
                        if (title.Equals(OTH_T_YMD))
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "OTH_T_YMD";
                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, OTH_F_IDX, fgrid_main.Rows.Count - 1, j).StyleNew.BackColor = Color.Yellow;                            
                        }

                    }
                }
            }
            
            
            
        }

        private DataTable SELECT_PCC_PROD_LIFE_CYCLE()
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_LIFE_CYCLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "";
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

        private DataTable SELECT_PCC_PROD_MIN_MAX()
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_FROM_TO";

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
                MyOraDB.Parameter_Values[0] = "DS";
                MyOraDB.Parameter_Values[1] = "20081001";
                MyOraDB.Parameter_Values[2] = "20090330";
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
        #endregion

        #region Control Event
        private void rdbtn_viewSeason_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(1);
        }

        private void rdbtn_viewFactory_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(2);
        }

        private void rdbtn_viewCategory_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(3);
        }

        private void rdbtn_viewModel_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(4);
        }

        private void rdbtn_viewBom_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(5);
        }
        #endregion

    }
}

