using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexCDC.Plan
{
    public partial class Form_Sch_Management : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수 
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private bool[] dev_check = new bool[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMAX_CNT];
        private bool column_view = true;
        #endregion

        #region 생성자
        public Form_Sch_Management()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Sch_Management_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Schedule Management";
            this.lbl_MainTitle.Text = "PCC_PCC_Schedule Management";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;

            //Prod. Factory
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_p_factory.SelectedIndex = 0;

            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_season_from.SelectedValue = "200904";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_season_to.SelectedValue = "200904";

            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            //User
            dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;
            #endregion

            #region Grid Setting 
            //Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_MANAGEMENT", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;           

            fgrid_main.ExtendLastCol = false;
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.Tree.Column = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME;
            fgrid_main.KeyActionEnter = KeyActionEnum.None;
                        
            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_005).StyleNew.BackColor = Color.LightGreen;
            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_005).StyleNew.ForeColor = Color.Black;

            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_005).StyleNew.BackColor = Color.LightPink;
            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_005).StyleNew.ForeColor = Color.Black;

            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_005).StyleNew.BackColor = Color.FromArgb(255, 255, 101);
            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_005).StyleNew.ForeColor = Color.Black;

            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.ForeColor = Color.Black;            

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_STATUS).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_STATUS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_STATUS).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_STATUS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS).StyleNew.BackColor = Color.FromArgb(255, 255, 101);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.ForeColor = Color.Black;            
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;
            #endregion 
        }

        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_SEASON";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;
                                
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_CATEGORY()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_CATEGORY";

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
            catch
            {
                return null; 
            }
        }
        private DataTable SELECT_USER()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_USER";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
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
            catch(Exception ex)
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

            string[] arg_value = new string[7];

            arg_value[0] = cmb_factory.SelectedValue.ToString();
            arg_value[1] = cmb_p_factory.SelectedValue.ToString();
            arg_value[2] = cmb_season_from.SelectedValue.ToString();
            arg_value[3] = cmb_season_to.SelectedValue.ToString();
            arg_value[4] = cmb_category.SelectedValue.ToString();
            arg_value[5] = txt_model.Text.Trim();
            arg_value[6] = cmb_user.SelectedValue.ToString();

            DataTable dt_ret = SELECT_SCH_MANAGEMENT(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                int vTreeLevel = int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxLEV].ToString());
                fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, vTreeLevel);

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }

                if (vTreeLevel.Equals(1))
                {
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.Beige;

                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_STATUS).StyleNew.BackColor = Color.FromArgb(223, 250, 197);
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_STATUS).StyleNew.BackColor = Color.FromArgb(254, 239, 220);
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS).StyleNew.BackColor = Color.FromArgb(255, 255, 156);
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                }
                else if (vTreeLevel.Equals(2))
                {
                    if (fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxBOM_ID].ToString().Trim().Equals("_________________"))
                    {
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.FromArgb(255, 255, 245);
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                    }
                    else
                    {
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.FromArgb(255, 255, 232);
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_STATUS).StyleNew.BackColor = Color.MintCream;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_STATUS).StyleNew.BackColor = Color.Snow;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS).StyleNew.BackColor = Color.FromArgb(255, 255, 205);
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxIPW_YMD).StyleNew.BackColor = Color.FromArgb(255, 250, 236);
                    }
                }
                else
                {
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME).StyleNew.BackColor = Color.White;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxUPD_YMD).StyleNew.BackColor = Color.WhiteSmoke;
                }
            }

            if(rbtn_model.Checked)
                fgrid_main.Tree.Show(1);
            else if(rbtn_bom.Checked)
                fgrid_main.Tree.Show(2);
            else
                fgrid_main.Tree.Show(3);
        }

        private DataTable SELECT_SCH_MANAGEMENT(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_MANAGEMENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL";
                MyOraDB.Parameter_Name[6] = "ARG_USER";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";
                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        #endregion

        #region Grid Event
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSEASON_V].Visible = column_view;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY_V].Visible = column_view;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY_V].Visible = column_view;

                    if (column_view)
                        column_view = false;
                    else
                        column_view = true;
                }
            }
            catch
            {
 
            }
        }

        private void fgrid_main_EnterCell(object sender, EventArgs e)
        {
            //try
            //{
            //    int sct_row = fgrid_main.Selection.r1;
            //    int sct_col = fgrid_main.Selection.c1;

            //    if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxMAT_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP.IxIN_YMD)
            //    {
            //        fgrid_main.GetCellRange(sct_row, sct_col).StyleNew.DataType = typeof(DateTime);
            //        fgrid_main.GetCellRange(sct_row, sct_col).StyleNew.Format = "yyyyMMdd";
            //    }
            //}
            //catch
            //{

            //}
        }
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                string _value = fgrid_main[sct_row, sct_col].ToString().Trim();

                
                //if (!_value.Length.Equals(8))
                //{
                //    if (!_value.Length.Equals(0))
                //    {
                //        MessageBox.Show("Data Format is wrong.\r\n\r\nPlease use this format : YYYYMMDD");
                        
                //        fgrid_main.StartEditing(sct_row, sct_col);
                //        return;
                //    }
                //}
                //else
                //{
                //    try
                //    {
                //        int year = int.Parse(_value.Substring(0, 4));
                //        int month = int.Parse(_value.Substring(4, 2));
                //        int day = int.Parse(_value.Substring(6, 2));

                //        DateTime date = new DateTime(year, month, day);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Data Format is wrong.\r\n\r\nPlease use this format : YYYYMMDD");
                //        fgrid_main.StartEditing(sct_row, sct_col);
                //        return; 
                //    }
                //}


                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";
                    fgrid_main[sct_rows[i], sct_col] = _value;
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Control Event
        #region Combo Box
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////Model
                //DataTable dt_ret = SELECT_MODEL();

                //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model, 0, 1, true, 0, 300);
                //cmb_model.SelectedIndex = 0;
            }
            catch
            {

            }
            finally
            {

            }
        }
        private DataTable SELECT_MODEL()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_MODEL";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        #region Check Box
        private void chk_dev_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();
            }
            catch
            {
 
            }
        }

        private void chk_comm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();
            }
            catch
            {

            }
        }

        private void chk_cfm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS; j++)
                {
                    chk_dev_check.Checked = false;

                    if (chk_cfm.Checked)
                        fgrid_main.Cols[j].Visible = true;
                    else
                        fgrid_main.Cols[j].Visible = false;
                }
            }
            catch
            {

            }
        }

        private void chk_dev_check_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;                      
                
                if (chk_dev_check.Checked)
                {
                    chk_dev.Enabled  = false;
                    chk_comm.Enabled = false;
                    chk_cfm.Enabled  = false;                    
                }
                else
                {
                    chk_dev.Enabled  = true;
                    chk_comm.Enabled = true;
                    chk_cfm.Enabled  = true;
                }

                Get_View_Check();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chk_adjust_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_View_Check();
            }
            catch
            {
 
            }
        }

        private void Get_View_Check()
        {
            bool dev_chk        = chk_dev.Checked;
            bool comm_chk       = chk_comm.Checked;
            bool cfm_chk        = chk_cfm.Checked;
            bool dev_report_chk = chk_dev_check.Checked;
            bool adj_chk        = chk_adjust.Checked;

            if (dev_report_chk)
            {
                #region 개발 점검 회의용 체크
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_CD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_TA_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_A1_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_A2_YMD] = adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_AC_YMD] = true;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_TA_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_A1_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_A2_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_AC_YMD] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS] = false;
                #endregion
            }
            else
            {
                #region DEV
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_TA_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_A1_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_A2_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_AC_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_CD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_TA_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_A1_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_A2_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_AC_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_020_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_CD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_TA_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_A1_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_A2_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_AC_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_030_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_CD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_TA_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_A1_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_A2_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_AC_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_040_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_CD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_TA_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_A1_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_A2_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_AC_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_050_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_CD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_TA_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_A1_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_A2_YMD] = (!dev_chk) ? dev_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_AC_YMD] = dev_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_060_STATUS] = false;
                #endregion

                #region COMM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_070_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_080_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_090_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_100_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_110_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_120_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_130_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_140_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_150_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_160_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_170_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_180_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk; ;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk; ;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_190_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_200_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_210_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_220_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_230_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_240_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_250_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_260_STATUS] = false;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_CD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_TA_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_A1_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_A2_YMD] = (!comm_chk) ? comm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_AC_YMD] = comm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_270_STATUS] = false;
                #endregion

                #region PROD CFM
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_CD] = cfm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_TA_YMD] = cfm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_A1_YMD] = (!cfm_chk) ? cfm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_A2_YMD] = (!cfm_chk) ? cfm_chk : adj_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_AC_YMD] = cfm_chk;
                dev_check[(int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS] = false;
                #endregion
            }

            for (int j = (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_010_CD; j <= (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxNF_280_STATUS; j++)
            {
                fgrid_main.Cols[j].Visible = dev_check[j];
            }
        }
        #endregion

        #region Radio Button
        private void rbtn_model_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(1);
            }
            catch
            {
 
            }
        }

        private void rbtn_bom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(2);
            }
            catch
            {

            }
        }

        private void rbtn_task_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_main.Tree.Show(3);
            }
            catch
            {

            }
        }
        #endregion        
        #endregion

        #region Context Menu Event
        private void mnu_moid_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(1);
        }

        private void mnu_bom_id_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(2);
        }

        private void mnu_task_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(3);
        }        
        #endregion        

    }
}

