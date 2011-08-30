using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.vTooling.Frm
{

    public partial class Form_Tooling_Amortize_New : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();

        private int _DATACOL_DIV      = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV;
        private int _DATACOL_FACTORY  = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY ;
        private int _DATACOL_CATEGORY = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxCATEGORY;
        private int _DATACOL_STYLE_CD = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD;
        private int _DATACOL_DEV_NAME = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME;        
        private int _DATACOL_OBS_ID   = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 1;
        private int _DATACOL_OBS_TYPE = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 2;
        private int _DATACOL_OGAC_YMD = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 3;
        private int _DATACOL_DPO      = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 4;
        private int _DATACOL_FOB      = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 5;
        private int _DATACOL_TOOLING  = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 6;

        private string[] copy_dpo = new string[6];
        #endregion

        #region Constructor
        public Form_Tooling_Amortize_New()
        {
            InitializeComponent();
        }
        #endregion 
        
        #region Form Loading
        private void Form_Tooling_Amortize_New_Load(object sender, EventArgs e)
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
            this.Text = "FOB List";
            this.lbl_MainTitle.Text = "FOB List";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_tooling.Set_Grid("SFX_CBD_TOOLING", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_tooling.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_tooling.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_tooling.Set_Action_Image(img_Action);
            fgrid_tooling.ExtendLastCol = false;
            fgrid_tooling.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            fgrid_tooling.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5);            
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Prod_Factory_List_Cost();
            COM.ComCtl.Set_ComboList(vDT, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 0;
            vDT.Dispose();      

            tbtn_New.Enabled     = true;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
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
                
                Display_Title();
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

        private void Display_Title()
        {
            fgrid_tooling.Cols.Count = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt;
            fgrid_tooling.Rows.Count = fgrid_tooling.Rows.Fixed;

            string[] arg_value = new string[4];
            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_month_from.SelectedValue.ToString();
            arg_value[2] = cmb_month_to.SelectedValue.ToString();
            arg_value[3] = txt_style_cd.Text.Trim();

            DataTable dt = SELECT_SFX_CBD_TOOL_TITLE(arg_value);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_tooling.Cols.Count = fgrid_tooling.Cols.Count + 3;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].Width = 80;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].Width = 70;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].Width = 70;

                fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 3] = dt.Rows[i].ItemArray[0] == null ? "0" : dt.Rows[i].ItemArray[0].ToString();
                fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 2] = dt.Rows[i].ItemArray[1] == null ? "0" : dt.Rows[i].ItemArray[1].ToString();
                fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 1] = dt.Rows[i].ItemArray[2] == null ? "0" : dt.Rows[i].ItemArray[2].ToString();

                fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 3).StyleNew.BackColor = Color.Yellow;
                fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 3).StyleNew.ForeColor = Color.Black;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].StyleNew.BackColor = Color.LightYellow;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].StyleNew.BackColor = Color.White;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].StyleNew.BackColor = Color.White;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].AllowEditing = false;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].AllowEditing = false;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].AllowEditing = false;
            }
 
        }
        private void Display_Data()
        {
            string[] arg_value = new string[4];
            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_month_from.SelectedValue.ToString();
            arg_value[2] = cmb_month_to.SelectedValue.ToString();
            arg_value[3] = txt_style_cd.Text.Trim();


            DataTable dt = SELECT_SFX_CBD_TOOL_LIST(arg_value);

            string _style_cd = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string style_cd_row = dt.Rows[i].ItemArray[_DATACOL_STYLE_CD].ToString().Trim();

                if (!_style_cd.Equals(style_cd_row))
                {
                    fgrid_tooling.Rows.Add();

                    for (int j = fgrid_tooling.Cols.Fixed; j < (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt; j++)
                    {
                        fgrid_tooling[fgrid_tooling.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();                         
                    }

                    _style_cd = dt.Rows[i].ItemArray[_DATACOL_STYLE_CD].ToString().Trim();
                    fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV, fgrid_tooling.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME).StyleNew.BackColor = Color.White;                    
                }
                
                for (int j = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt; j < fgrid_tooling.Cols.Count; j++)
                {
                    string obs_id_title = fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, j].ToString().Trim();
                    string obs_id_row   = dt.Rows[i].ItemArray[_DATACOL_OBS_ID].ToString().Trim();

                    if (obs_id_title.Equals(obs_id_row))
                    {
                        string dpo     = dt.Rows[i].ItemArray[_DATACOL_DPO     ].ToString().Trim();
                        string fob     = dt.Rows[i].ItemArray[_DATACOL_FOB     ].ToString().Trim();
                        string tooling = dt.Rows[i].ItemArray[_DATACOL_TOOLING ].ToString().Trim();
                        string warning = dt.Rows[i].ItemArray[_DATACOL_OGAC_YMD].ToString().Trim();

                        try
                        {
                            dpo = double.Parse(dpo).ToString("#,###,##0");
                        }
                        catch
                        {

                        }

                        try
                        {
                            fob = double.Parse(fob).ToString("#,###,##0.00");
                        }
                        catch
                        {

                        }

                        try
                        {
                            tooling = double.Parse(tooling).ToString("#,###,##0.00");
                        }
                        catch
                        {

                        }

                        fgrid_tooling[fgrid_tooling.Rows.Count - 1, j    ] = dpo;
                        fgrid_tooling[fgrid_tooling.Rows.Count - 1, j + 1] = fob;
                        fgrid_tooling[fgrid_tooling.Rows.Count - 1, j + 2] = tooling;

                        if (warning.Equals("Y"))
                        {
                            fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Count - 1, j    ).StyleNew.ForeColor = Color.Red;
                            fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Count - 1, j + 1).StyleNew.ForeColor = Color.Red;
                            fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Count - 1, j + 2).StyleNew.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private DataTable SELECT_SFX_CBD_TOOL_TITLE(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL_TITLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = "";

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
        private DataTable SELECT_SFX_CBD_TOOL_LIST(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = "";

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

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Print_Data();
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

        private void Print_Data()
        {
            SaveFileDialog save_file = new SaveFileDialog();
            save_file.InitialDirectory = "C:\\";
            save_file.AddExtension = true;            
            save_file.DefaultExt = "xls";
            

            if (save_file.ShowDialog() == DialogResult.OK)
            {
                string save_path = save_file.FileName;                
                fgrid_tooling.SaveExcel(save_path, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells);
            }            
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (Check_Save_Data())
                    Save_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void Save_Data()
        {
            for (int i = fgrid_tooling.Rows.Fixed; i < fgrid_tooling.Rows.Count; i++)
            {
                string _div = (fgrid_tooling[i, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV] == null) ? "" : fgrid_tooling[i, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
 
                } 
            }
        }

        private bool Check_Save_Data()
        {
            try
            {
                for (int i = fgrid_tooling.Rows.Fixed; i < fgrid_tooling.Rows.Count; i++)
                {
                    string _div = (fgrid_tooling[i, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV] == null) ? "" : fgrid_tooling[i, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV].ToString().Trim();

                    if (!_div.Equals(""))
                    {
                        for (int j = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt; j < fgrid_tooling.Cols.Count; j++)
                        {
                            string value = (fgrid_tooling[i, j] == null) ? "" : fgrid_tooling[i, j].ToString().Trim();

                            if (!value.Equals(""))
                            {
                                try
                                {
                                    double value_num = double.Parse(value);
                                }
                                catch
                                {
                                    MessageBox.Show("This is not number");
                                    fgrid_tooling.Select(i, j);
                                    return false;
                                }                                
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

        private bool SAVE_SFX_CBD_TOOL()
        {
            //int vcnt = 8;
            //MyOraDB.ReDim_Parameter(vcnt);

            ////01.PROCEDURE명
            //MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_TOOL";
            ////02.ARGURMENT 명
            //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            //MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
            //MyOraDB.Parameter_Name[2] = "ARG_CURR";
            //MyOraDB.Parameter_Name[3] = "ARG_APP_DATE";
            //MyOraDB.Parameter_Name[4] = "ARG_COUNTRY";
            //MyOraDB.Parameter_Name[5] = "ARG_FX_RATE";
            //MyOraDB.Parameter_Name[6] = "ARG_STATUS";
            //MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

            //for (int para = 0; para < vcnt; para++)
            //{
            //    MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            //}

            //int vRow = 0;
            //for (int i = fgrid_fxrate.Rows.Fixed; i < fgrid_fxrate.Rows.Count; i++)
            //{
            //    string _div = fgrid_fxrate[i, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxDIV].ToString().Trim();

            //    if (!_div.Equals(""))
            //    {
            //        vRow++;
            //    }
            //}

            //vcnt = vcnt * vRow;
            //MyOraDB.Parameter_Values = new string[vcnt];
            //vcnt = 0;

            //for (int row = fgrid_fxrate.Rows.Fixed; row < fgrid_fxrate.Rows.Count; row++)
            //{
            //    string _div = fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxDIV].ToString().Trim();

            //    if (_div.Equals(""))
            //        continue;

            //    MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFACTORY] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFACTORY].ToString().Trim();
            //    MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSEASON_CD] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSEASON_CD].ToString().Trim();
            //    MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCURR] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCURR].ToString().Trim();
            //    MyOraDB.Parameter_Values[vcnt++] = Conv_Data_String(fgrid_fxrate, row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxAPP_DATE);
            //    MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCOUNTRY] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxCOUNTRY].ToString().Trim();
            //    MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxFX_RATE].ToString().Trim();
            //    MyOraDB.Parameter_Values[vcnt++] = (fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSTATUS] == null) ? "" : fgrid_fxrate[row, (int)ClassLib.TBSFX_CBD_BASE_FXRATE.IxSTATUS].ToString().Trim();
            //    MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;

            //}

            //MyOraDB.Add_Modify_Parameter(true);
            //DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            //if (vDS == null) return false;
            return true;
        }
        #endregion

        #region Grid Event
        private void fgrid_tooling_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_AterEdit_Event();
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void Grid_AterEdit_Event()
        {
            int[] sct_rows = fgrid_tooling.Selections;
            int sct_row = fgrid_tooling.Selection.r1;
            int sct_col = fgrid_tooling.Selection.c1;

            string sct_text = (fgrid_tooling[sct_row, sct_col] == null) ? "" : fgrid_tooling[sct_row, sct_col].ToString().Trim().Replace(",", "");
            string sct_head = (fgrid_tooling[fgrid_tooling.Rows.Fixed, sct_col] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed, sct_col].ToString().Trim();

            if (!sct_text.Equals(""))
            {
                if (sct_head.Equals("FOB($)") || sct_head.Equals("Tooling($)"))
                {
                    try
                    {
                        sct_text = double.Parse(sct_text).ToString("#,###,##0.00");
                    }
                    catch
                    {
                        MessageBox.Show("Please insert numeric data.");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        sct_text = double.Parse(sct_text).ToString("#,###,###");
                    }
                    catch
                    {
                        MessageBox.Show("Please insert numeric data.");
                        return;
                    }
                }
            }
            

            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_tooling[sct_rows[i], sct_col] = sct_text;
                fgrid_tooling[sct_rows[i], (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV] = "U";
            }            
        }
        #endregion

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Factory.SelectedIndex < 0)
                    return;

                if (cmb_Factory.SelectedValue == null)
                    return;

                Set_ComboBox_DPO_ID();
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private void Set_ComboBox_DPO_ID()
        {
            DataTable vDT = SELECT_DPO_ID(cmb_Factory.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(vDT, cmb_month_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComCtl.Set_ComboList(vDT, cmb_month_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_month_from.SelectedIndex = 0;
            cmb_month_to.SelectedIndex = 0;
            vDT.Dispose(); 
        }

        public DataTable SELECT_DPO_ID(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_DPO_ID";

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

        #region ContextMenu Event
        private void mnu_copy_dpo_Click(object sender, EventArgs e)
        {
            try
            {
                Copy_DPO();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void mnu_paste_dpo_Click(object sender, EventArgs e)
        {
            try
            {
                Paste_DPO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Copy_DPO()
        {
            if (fgrid_tooling.Rows.Count.Equals(fgrid_tooling.Rows.Fixed))
                return;

            int sct_row = fgrid_tooling.Selection.r1;
            int sct_col = fgrid_tooling.Selection.c1;

            if (sct_row < fgrid_tooling.Rows.Fixed)
                return;

            if (sct_col < (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt)
                return;

            string head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col].ToString().Trim();
            string dpo_qty    = (fgrid_tooling[sct_row, sct_col    ] == null) ? "" : fgrid_tooling[sct_row, sct_col    ].ToString().Trim();
            string fob        = (fgrid_tooling[sct_row, sct_col + 1] == null) ? "" : fgrid_tooling[sct_row, sct_col + 1].ToString().Trim();
            string tooling    = (fgrid_tooling[sct_row, sct_col + 2] == null) ? "" : fgrid_tooling[sct_row, sct_col + 2].ToString().Trim();

            if (dpo_qty.Equals(""))
            {
                MessageBox.Show("Empty Data");
                return;
            }

            if (head_title.Equals("FOB($)"))
            {
                head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 1] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 1].ToString().Trim();
                dpo_qty = (fgrid_tooling[sct_row, sct_col - 1] == null) ? "" : fgrid_tooling[sct_row, sct_col - 1].ToString().Trim();
                fob     = (fgrid_tooling[sct_row, sct_col    ] == null) ? "" : fgrid_tooling[sct_row, sct_col    ].ToString().Trim();
                tooling = (fgrid_tooling[sct_row, sct_col + 1] == null) ? "" : fgrid_tooling[sct_row, sct_col + 1].ToString().Trim();

            }
            else if (head_title.Equals("Tooling($)"))
            {
                head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 2] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 2].ToString().Trim();
                dpo_qty = (fgrid_tooling[sct_row, sct_col - 2] == null) ? "" : fgrid_tooling[sct_row, sct_col - 2].ToString().Trim();
                fob     = (fgrid_tooling[sct_row, sct_col - 1] == null) ? "" : fgrid_tooling[sct_row, sct_col - 1].ToString().Trim();
                tooling = (fgrid_tooling[sct_row, sct_col    ] == null) ? "" : fgrid_tooling[sct_row, sct_col    ].ToString().Trim();
            }

            string dpo_id     = head_title;
            string factory    = (fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY] == null) ? "" : fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY].ToString().Trim();
            string stlye_cd   = (fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD] == null) ? "" : fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD].ToString().Trim();
            string style_name = (fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME] == null) ? "" : fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME].ToString().Trim();

            if (fob.Equals("0.00") && tooling.Equals("0.00"))
            {
                MessageBox.Show("Empty Data");
                return;
            }

            copy_dpo[0] = factory;
            copy_dpo[1] = stlye_cd.Replace("-", "");
            copy_dpo[2] = dpo_id;
            copy_dpo[3] = dpo_qty;
            copy_dpo[4] = fob;
            copy_dpo[5] = tooling;

            string message = style_name + "/" + stlye_cd + "/" + dpo_id + " is copied.";
            //COM.ComFunction.Status_Bar_Message_Text(message, this);
        }

        private void Paste_DPO()
        {   
            if (fgrid_tooling.Rows.Count.Equals(fgrid_tooling.Rows.Fixed))
                return;

            int sct_row = fgrid_tooling.Selection.r1;
            int sct_col = fgrid_tooling.Selection.c1;

            if (sct_row < fgrid_tooling.Rows.Fixed)
                return;

            if (sct_col < (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt)
                return;

            if (copy_dpo[0] == null || copy_dpo[0].Equals(""))
                return;

            string sct_value  = (fgrid_tooling[sct_row, sct_col] == null) ? "" : fgrid_tooling[sct_row, sct_col].ToString().Trim();

            if (sct_value.Equals(""))
            {
                MessageBox.Show("Order is not exist");
                return;
            }
            
            string head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col].ToString().Trim();
                     

            if (head_title.Equals("FOB($)"))
            {
                head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 1] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 1].ToString().Trim();              
            }
            else if (head_title.Equals("Tooling($)"))
            {
                head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 2] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col - 2].ToString().Trim();
            }

            string [] arg_value = new string[3];
            arg_value[0] = (fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY] == null) ? "" : fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY].ToString().Trim();
            arg_value[1] = (fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD] == null) ? "" : fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD].ToString().Trim().Replace("-", "");
            arg_value[2] = head_title;

            if (arg_value[0] == copy_dpo[0] && arg_value[1] == copy_dpo[1])
            {
                DataTable dt = SELECT_SFX_CBD_EXIST(arg_value);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This is already exist");
                    return;
                }
                else
                {
                    string[] save_value = new string[5];
                    save_value[0] = copy_dpo[0];
                    save_value[1] = copy_dpo[1];
                    save_value[2] = copy_dpo[2]; 
                    save_value[3] = head_title;
                    save_value[4] = COM.ComVar.This_User;

                    if (SAVE_SFX_CBD_DPO(save_value))
                    {
                        MessageBox.Show("Save Completed");

                        
                        head_title = (fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col] == null) ? "" : fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, sct_col].ToString().Trim();
                        
                        if (head_title.Equals("FOB($)"))
                        {                            
                            fgrid_tooling[sct_row, sct_col    ] = copy_dpo[4];
                            fgrid_tooling[sct_row, sct_col + 1] = copy_dpo[5];
                        }
                        else if (head_title.Equals("Tooling($)"))
                        {                            
                            fgrid_tooling[sct_row, sct_col - 1] = copy_dpo[4];
                            fgrid_tooling[sct_row, sct_col    ] = copy_dpo[5];
                        }
                        else
                        {                            
                            fgrid_tooling[sct_row, sct_col + 1] = copy_dpo[4];
                            fgrid_tooling[sct_row, sct_col + 2] = copy_dpo[5]; 
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("This is not same style\r\n\r\nCopy : " + copy_dpo[0] + " / " + copy_dpo[1] + "\r\n\r\nPaste : " + arg_value[0] + " / " + arg_value[1]);
                return;
            }            
        }

        private DataTable SELECT_SFX_CBD_EXIST(string[] arg_value)
        {
            try
            {                
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_EXIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
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
                DataSet vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool SAVE_SFX_CBD_DPO(string[] arg_value)
        {
            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_DPO";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];

                MyOraDB.Add_Modify_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Modify_Procedure();

                if (vDS == null) return false;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}

