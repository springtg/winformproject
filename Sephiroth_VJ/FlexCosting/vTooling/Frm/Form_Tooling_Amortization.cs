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
    struct CBD_Struct
    {
        // cbd info
        public string sDEV_FAC;
        public string sMOID;
        public string sCBD_ID;
        public string sFOB_TYPE_CD;
        public string sCBD_SEQ;
        public string sREV_REASON;
        public double dFOB_INVOICE;

        // order info
        public string sFACTORY;
        public string sSEASON_CD;
        public string sSTYLE_CD;
        public string sOBS_ID;
        public string sOBS_TYPE;

        // data
        public double dORDER_QTY;
        public double dFOB;
        public double dTOOLING;

        // config 
        public int iRow;
        public int iStrCol;
        public int iEndCol;
    }

    public partial class Form_Tooling_Amortization : COM.PCHWinForm.Form_Top
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
        private int _KEY_START_COL    = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME + 7;

        //private string[] copy_dpo = new string[6];
        private CBD_Struct copy_cbd = new CBD_Struct();
        private Color[] col_bc = new Color[] { ClassLib.ComVar.ClrLevel_1st, Color.White };
        private Color[] col_fc = new Color[] { Color.Black, Color.Black };
        private bool _readonly = true;
        #endregion

        #region Constructor
        public Form_Tooling_Amortization()
        {
            InitializeComponent();
        }
        #endregion 
        
        #region Form Loading
        private void Form_Tooling_Amortization_Load(object sender, EventArgs e)
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
            fgrid_tooling.Set_Grid("SFX_CBD_TOOLING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
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

            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_58");
            COM.ComCtl.Set_ComboList(vDT, cmb_obs_type, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
            cmb_obs_type.SelectedValue = "FT";
            vDT.Dispose();

            if (tbtn_Save.Enabled)
            {
                tbtn_Save.Enabled    = false;
                tbtn_Delete.Enabled  = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled  = false;

                _readonly = false;
            }            
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

            string[] arg_value = new string[5];
            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_month_from.SelectedValue.ToString();
            arg_value[2] = cmb_month_to.SelectedValue.ToString();
            arg_value[3] = cmb_obs_type.SelectedValue.ToString();
            arg_value[4] = txt_style_cd.Text.Trim().Replace("-", "");

            DataTable dt = SELECT_SFX_CBD_TOOL_TITLE(arg_value);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_tooling.Cols.Count = fgrid_tooling.Cols.Count + 3;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].Width = 80;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].Width = 90;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].Width = 70;

                fgrid_tooling[fgrid_tooling.Rows.Fixed - 2, fgrid_tooling.Cols.Count - 3] = dt.Rows[i].ItemArray[3] == null ? "0" : dt.Rows[i].ItemArray[3].ToString();
                fgrid_tooling[fgrid_tooling.Rows.Fixed - 2, fgrid_tooling.Cols.Count - 2] = dt.Rows[i].ItemArray[3] == null ? "0" : dt.Rows[i].ItemArray[3].ToString();
                fgrid_tooling[fgrid_tooling.Rows.Fixed - 2, fgrid_tooling.Cols.Count - 1] = dt.Rows[i].ItemArray[3] == null ? "0" : dt.Rows[i].ItemArray[3].ToString();

                fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 3] = dt.Rows[i].ItemArray[0] == null ? "0" : dt.Rows[i].ItemArray[0].ToString();
                fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 2] = dt.Rows[i].ItemArray[1] == null ? "0" : dt.Rows[i].ItemArray[1].ToString();
                fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 1] = dt.Rows[i].ItemArray[2] == null ? "0" : dt.Rows[i].ItemArray[2].ToString();

                fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 3).StyleNew.BackColor = Color.Yellow;
                fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed - 1, fgrid_tooling.Cols.Count - 3).StyleNew.ForeColor = Color.Black;

                //fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].StyleNew.BackColor = col_bc[fgrid_tooling.Cols.Count % 2];
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].StyleNew.BackColor = Color.LightBlue;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].StyleNew.BackColor = Color.White;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].StyleNew.BackColor = Color.White;

                //fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].Style.ForeColor = col_fc[fgrid_tooling.Cols.Count % 2];
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].Style.ForeColor = Color.Black;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].Style.ForeColor = Color.Black;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].Style.ForeColor = Color.Black;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].AllowEditing = false;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].AllowEditing = false;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].AllowEditing = false;

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].Visible = false;
            }
 
        }
        private void Display_Data()
        {
            string[] arg_value = new string[5];
            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_month_from.SelectedValue.ToString();
            arg_value[2] = cmb_month_to.SelectedValue.ToString();
            arg_value[3] = cmb_obs_type.SelectedValue.ToString(); ;
            arg_value[4] = txt_style_cd.Text.Trim().Replace("-", "");


            DataTable dt = SELECT_SFX_CBD_TOOL_LIST(arg_value);

            string _factory = "", _style_cd = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string factory_row = dt.Rows[i].ItemArray[_DATACOL_FACTORY].ToString().Trim();
                string style_cd_row = dt.Rows[i].ItemArray[_DATACOL_STYLE_CD].ToString().Trim();

                if ( !_factory.Equals(factory_row) || !_style_cd.Equals(style_cd_row))
                {
                    fgrid_tooling.Rows.Add();

                    for (int j = fgrid_tooling.Cols.Fixed; j < (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt; j++)
                    {
                        fgrid_tooling[fgrid_tooling.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim(); 
                    }

                    _factory = dt.Rows[i].ItemArray[_DATACOL_FACTORY].ToString().Trim();
                    _style_cd = dt.Rows[i].ItemArray[_DATACOL_STYLE_CD].ToString().Trim();
                    //fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDIV, fgrid_tooling.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME).StyleNew.BackColor = Color.White;                    
                }
                
                for (int j = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt; j < fgrid_tooling.Cols.Count; j++)
                {
                    string obs_id_title = fgrid_tooling[fgrid_tooling.Rows.Fixed - 1, j].ToString().Trim();
                    string obs_id_row   = dt.Rows[i].ItemArray[_DATACOL_OBS_ID].ToString().Trim();

                    if (obs_id_title.Equals(obs_id_row))
                    {
                        DisplayData(dt.Rows[i], fgrid_tooling.Rows.Count - 1, j);
                    }
                }
            }

            if (fgrid_tooling.Rows.Fixed < fgrid_tooling.Rows.Count)
                fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed, 1, fgrid_tooling.Rows.Count - 1, fgrid_tooling.Cols.Frozen - 1).StyleNew.BackColor = Color.LightYellow;
        }
        private void DisplayData(DataRow vDR, int iRow, int iStrCol)
        {
            CBD_Struct vCBD = MakeCBDStruct(vDR);
            vCBD.iRow = iRow;
            vCBD.iStrCol = iStrCol;
            vCBD.iEndCol = iStrCol + 2;

            string warning = vDR.ItemArray[_DATACOL_OGAC_YMD].ToString().Trim();
            string confirm = vDR.ItemArray[_KEY_START_COL + 6].ToString().Trim();

            if (vCBD.sREV_REASON.Equals("x"))
            {
                fgrid_tooling[iRow, iStrCol] = vCBD.dORDER_QTY.ToString("#,###,##0");
            }
            else
            {
                fgrid_tooling[iRow, iStrCol] = vCBD.dORDER_QTY.ToString("#,###,##0");
                fgrid_tooling[iRow, iStrCol + 1] = "$ " + vCBD.dFOB.ToString("#,###,##0.00");
                fgrid_tooling[iRow, iStrCol + 2] = "$ " + vCBD.dTOOLING.ToString("#,###,##0.00");
            }

            C1.Win.C1FlexGrid.CellRange vCR = fgrid_tooling.GetCellRange(iRow, iStrCol);
            vCR.UserData = vCBD;
            vCR = fgrid_tooling.GetCellRange(iRow, iStrCol + 1);
            vCR.UserData = vCBD;
            vCR = fgrid_tooling.GetCellRange(iRow, iStrCol + 2);
            vCR.UserData = vCBD;

            // OGac -15일 경고 
            if (warning.Equals("Y"))
            {
                //fgrid_tooling.GetCellRange(iRow, iStrCol).StyleNew.BackColor = Color.Red;
                fgrid_tooling.GetCellRange(iRow, iStrCol + 1).StyleNew.BackColor = Color.Red;
                //fgrid_tooling.GetCellRange(iRow, iStrCol + 2).StyleNew.BackColor = Color.Red;
            }
            // full cbd 구분 
            if (!vCBD.sREV_REASON.Equals("60") && !vCBD.sREV_REASON.Equals("x"))
            {
                if (confirm.Equals("Confirmed"))
                {
                    fgrid_tooling.GetCellRange(iRow, iStrCol).StyleNew.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5, FontStyle.Bold);
                    fgrid_tooling.GetCellRange(iRow, iStrCol + 1).StyleNew.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5, FontStyle.Bold);
                    fgrid_tooling.GetCellRange(iRow, iStrCol + 2).StyleNew.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5, FontStyle.Bold);
                }
                else
                {
                    fgrid_tooling.GetCellRange(iRow, iStrCol).StyleNew.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5);
                    fgrid_tooling.GetCellRange(iRow, iStrCol + 1).StyleNew.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5);
                    fgrid_tooling.GetCellRange(iRow, iStrCol + 2).StyleNew.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5);
                }
            }
            // invoice fob vs costing fob 비교 
            if (vCBD.dFOB_INVOICE > 0 && vCBD.dFOB > 0 && vCBD.dFOB_INVOICE != vCBD.dFOB)
            {
                fgrid_tooling.GetCellRange(iRow, iStrCol + 1).StyleNew.BackColor = Color.Red;
                fgrid_tooling[iRow, iStrCol + 1] = "$ " + vCBD.dFOB.ToString("#,###,##0.00") + " (" + vCBD.dFOB_INVOICE.ToString("#,###,##0.00") + ")";
            }
        }
        private CBD_Struct MakeCBDStruct(DataRow vDR)
        {
            CBD_Struct vCBD = new CBD_Struct();
            vCBD.sDEV_FAC = vDR.ItemArray[_KEY_START_COL].ToString().Trim();
            vCBD.sMOID = vDR.ItemArray[_KEY_START_COL + 1].ToString().Trim();
            vCBD.sCBD_ID = vDR.ItemArray[_KEY_START_COL + 2].ToString().Trim();
            vCBD.sFOB_TYPE_CD = vDR.ItemArray[_KEY_START_COL + 3].ToString().Trim();
            vCBD.sCBD_SEQ = vDR.ItemArray[_KEY_START_COL + 4].ToString().Trim();
            vCBD.sREV_REASON = vDR.ItemArray[_KEY_START_COL + 5].ToString().Trim();
            vCBD.sSEASON_CD = vDR.ItemArray[_KEY_START_COL + 7].ToString().Trim();
            vCBD.dFOB_INVOICE = Convert.ToDouble(vDR.ItemArray[_KEY_START_COL + 8].ToString());

            vCBD.sFACTORY = vDR.ItemArray[_DATACOL_FACTORY].ToString().Trim();
            vCBD.sSTYLE_CD = vDR.ItemArray[_DATACOL_STYLE_CD].ToString().Trim().Replace("-", "");
            vCBD.sOBS_ID = vDR.ItemArray[_DATACOL_OBS_ID].ToString().Trim();
            vCBD.sOBS_TYPE = vDR.ItemArray[_DATACOL_OBS_TYPE].ToString().Trim();

            string dpo = vDR.ItemArray[_DATACOL_DPO].ToString().Trim();
            string fob = vDR.ItemArray[_DATACOL_FOB].ToString().Trim();
            string tooling = vDR.ItemArray[_DATACOL_TOOLING].ToString().Trim();
            string warning = vDR.ItemArray[_DATACOL_OGAC_YMD].ToString().Trim();

            try
            {
                vCBD.dORDER_QTY = double.Parse(dpo);
            }
            catch
            {
                vCBD.dORDER_QTY = 0;
            }

            try
            {
                vCBD.dFOB = double.Parse(fob);
            }
            catch
            {
                vCBD.dFOB = 0;
            }

            try
            {
                vCBD.dTOOLING = double.Parse(tooling);
            }
            catch
            {
                vCBD.dTOOLING = 0;
            }

            return vCBD;
        }
        private DataTable SELECT_SFX_CBD_TOOL_TITLE(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL_TITLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

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

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

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
        private void fgrid_tooling_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_readonly)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    int iRow = fgrid_tooling.Row, iCol = fgrid_tooling.Col;
                    object obj = fgrid_tooling.GetCellRange(iRow, iCol).UserData;
                    if (obj != null)
                    {
                        CBD_Struct vCBD = (CBD_Struct)obj;

                        if (!vCBD.sREV_REASON.Equals("60") && !vCBD.sREV_REASON.Equals("x"))
                        {
                            Copy_DPO();
                        }
                    }
                }
                if (e.Control && e.KeyCode == Keys.V)
                {
                    if (copy_cbd.sREV_REASON != null)
                    {
                        Paste_DPO();
                    }
                }
            }
        }
        private void fgrid_tooling_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                fgrid_tooling.Select(fgrid_tooling.MouseRow, fgrid_tooling.MouseCol);

                if (fgrid_tooling.Rows.Count > fgrid_tooling.Rows.Fixed && fgrid_tooling.Rows.Fixed <= fgrid_tooling.Row && !_readonly)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        int iRow = fgrid_tooling.Row, iCol = fgrid_tooling.Col;

                        object obj = fgrid_tooling.GetCellRange(iRow, iCol).UserData;
                        if (obj != null)
                        {
                            CBD_Struct vCBD = (CBD_Struct)obj;

                            if (copy_cbd.sREV_REASON == null)
                            {
                                mnu_paste_dpo.Enabled = false;
                            }
                            else
                            {
                                mnu_paste_dpo.Enabled = true;
                            }

                            if (vCBD.sREV_REASON.Equals("60") || vCBD.sREV_REASON.Equals("x"))
                            {
                                //mnu_copy_dpo.Enabled = false;
                                //mnu_bar1.Enabled = false;

                                if (vCBD.sREV_REASON.Equals("60"))
                                {
                                    mnu_copy_dpo.Enabled = true;
                                    mnu_bar1.Enabled = true;
                                    mnu_delete_cbd.Enabled = true;
                                }
                                else
                                {
                                    mnu_copy_dpo.Enabled = false;
                                    mnu_bar1.Enabled = false; 
                                    mnu_delete_cbd.Enabled = false;
                                }
                            }
                            else
                            {
                                mnu_copy_dpo.Enabled = true;
                                mnu_bar1.Enabled = true;
                                //mnu_open_cbd.Enabled = true;
                                mnu_delete_cbd.Enabled = true;
                            }

                            if (mnu_copy_dpo.Enabled || mnu_paste_dpo.Enabled || mnu_open_cbd.Enabled || mnu_delete_cbd.Enabled)
                            {
                                ctmnu_01.Show(MousePosition.X, MousePosition.Y);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                fgrid_tooling.ClearAll();
                Set_ComboBox_DPO_ID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmb_obs_type_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_obs_type.SelectedIndex < 0)
                    return;

                if (cmb_obs_type.SelectedValue == null)
                    return;

                fgrid_tooling.ClearAll();
                Set_ComboBox_DPO_ID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Set_ComboBox_DPO_ID()
        {
            if (cmb_Factory.SelectedValue == null || cmb_obs_type.SelectedValue == null)
                return;

            string sMonthFrom = COM.ComFunction.Empty_Combo(cmb_month_from, " ");
            string sMonthTo = COM.ComFunction.Empty_Combo(cmb_month_to, " ");

            DataTable vDT = SELECT_DPO_ID(cmb_Factory.SelectedValue.ToString(), cmb_obs_type.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(vDT, cmb_month_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComCtl.Set_ComboList(vDT, cmb_month_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();

            cmb_month_from.SelectedValue = sMonthFrom;
            cmb_month_to.SelectedValue = sMonthTo;

            if (cmb_month_from.SelectedIndex == -1 || cmb_month_to.SelectedIndex == -1)
            {
                cmb_month_from.SelectedIndex = 0;
                cmb_month_to.SelectedIndex = 0;
            }
        }

        public DataTable SELECT_DPO_ID(string arg_factory, string arg_obs_type)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_DPO_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_type;
                MyOraDB.Parameter_Values[2] = "";

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

            object obj = fgrid_tooling.GetCellRange(sct_row, sct_col).UserData;
            if (obj == null)
                return;

            CBD_Struct vCBD = (CBD_Struct)obj;

            if (vCBD.dFOB == 0 && vCBD.dTOOLING == 0)
            {
                MessageBox.Show("Empty Data");
                return;
            }

            if (copy_cbd.sREV_REASON != null)
            {
                for (int iTmpCol = copy_cbd.iStrCol; iTmpCol <= copy_cbd.iEndCol; iTmpCol++)
                {
                    fgrid_tooling.GetCellRange(sct_row, iTmpCol).StyleDisplay.Font = new Font(fgrid_tooling.Font.FontFamily, fgrid_tooling.Font.Size, FontStyle.Bold);
                }
            }

            copy_cbd = vCBD;
            string style_name = fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME].ToString();
            string style_code = fgrid_tooling[sct_row, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD].ToString();

            string message = style_name + "/" + style_code + "/" + vCBD.sOBS_ID + " is copied.";

            for (int iTmpCol = vCBD.iStrCol; iTmpCol <= vCBD.iEndCol; iTmpCol++)
            {
                fgrid_tooling.GetCellRange(sct_row, iTmpCol).StyleDisplay.Font = new Font(fgrid_tooling.Font.FontFamily, fgrid_tooling.Font.Size, FontStyle.Underline);
            }

            COM.ComFunction.Status_Bar_Message_Text(message, this);
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

            CBD_Struct vCOPY_CBD = (CBD_Struct)copy_cbd;
            CBD_Struct vPASTE_CBD = (CBD_Struct)fgrid_tooling.GetCellRange(sct_row, sct_col).UserData;

            string [] arg_value = new string[4];
            arg_value[0] = vPASTE_CBD.sFACTORY;
            arg_value[1] = vPASTE_CBD.sSTYLE_CD;
            arg_value[2] = vPASTE_CBD.sOBS_ID;
            arg_value[3] = vPASTE_CBD.sOBS_TYPE;

            DataTable dt = SELECT_SFX_CBD_EXIST(arg_value);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This is already exist");
                return;
            }
            else
            {
                DataTable vDT = null;

                if (vPASTE_CBD.sFACTORY == vCOPY_CBD.sFACTORY && vPASTE_CBD.sSTYLE_CD == vCOPY_CBD.sSTYLE_CD)
                {
                    vDT = SAVE_SFX_CBD_DPO(vCOPY_CBD, vPASTE_CBD);
                }
                else
                {
                    FlexCosting.vTooling.Pop.Pop_CBD_Copy_By_Viewer vPop = new FlexCosting.vTooling.Pop.Pop_CBD_Copy_By_Viewer();
                    if (vPop.ShowDialog() == DialogResult.OK)
                    {
                        string sProdFac = fgrid_tooling[vPASTE_CBD.iRow, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY].ToString();
                        vDT = SAVE_SFX_CBD_COPY_OTHER_STYLE(vCOPY_CBD, vPASTE_CBD, vPop.DEV_FAC, sProdFac, vPop.MOID, vPop.BOM_ID);
                    }
                    else
                    {
                        return;
                    }
                }

                if (vDT != null && vDT.Rows.Count == 1)
                {
                    vDT = SELECT_SFX_CBD_TOOL(vDT.Rows[0].ItemArray[0].ToString(),
                        vDT.Rows[0].ItemArray[1].ToString(),
                        vDT.Rows[0].ItemArray[2].ToString(),
                        vDT.Rows[0].ItemArray[3].ToString(),
                        vDT.Rows[0].ItemArray[4].ToString());
                    if (vDT != null && vDT.Rows.Count == 1)
                    {
                        MessageBox.Show("Save Completed");
                        DisplayData(vDT.Rows[0], sct_row, vPASTE_CBD.iStrCol);
                    }
                }
                else
                {
                    MessageBox.Show("Save Failed");
                }
            }
        }

        //private void CopyCBDToOtherModel(CBD vCOPY_CBD, CBD vPASTE_CBD)
        //{
        //    try
        //    {
        //        FlexCosting.Management.Costing.Pop.Pop_CBD_Master_CopyCBD vPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_CopyCBD();

        //        vPop.DevFac = vCOPY_CBD.sDEV_FAC;
        //        vPop.ProdFac = fgrid_tooling[vCOPY_CBD.iRow, (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY].ToString();
        //        vPop.MOID = vCOPY_CBD.sMOID.Replace("-", "");
        //        vPop.CBDID = vCOPY_CBD.sCBD_ID;
        //        vPop.CBDVer = vCOPY_CBD.sCBD_SEQ;
        //        vPop.FOBType = vCOPY_CBD.sFOB_TYPE_CD;
        //        vPop.RoundCD = vCOPY_CBD.sFOB_TYPE_CD;
        //        vPop.Season = cmb_hSEASON_CD.SelectedValue.ToString();

        //        if (vPop.ShowDialog() == DialogResult.OK)
        //        {
        //            ClassLib.ComFunction.User_Message("CBD Copy complete", "Copy CBD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Copy CBD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private DataTable SELECT_SFX_CBD_EXIST(string[] arg_value)
        {
            try
            {                
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_EXIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
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
                DataSet vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable SAVE_SFX_CBD_DPO(CBD_Struct vCOPY_CBD, CBD_Struct vPASTE_CBD)
        {
            try
            {

                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_COPY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = vCOPY_CBD.sDEV_FAC;
                MyOraDB.Parameter_Values[1] = vCOPY_CBD.sMOID;
                MyOraDB.Parameter_Values[2] = vCOPY_CBD.sCBD_ID;
                MyOraDB.Parameter_Values[3] = vCOPY_CBD.sFOB_TYPE_CD;
                MyOraDB.Parameter_Values[4] = vCOPY_CBD.sCBD_SEQ;
                MyOraDB.Parameter_Values[5] = vPASTE_CBD.sOBS_ID;
                MyOraDB.Parameter_Values[6] = vPASTE_CBD.sOBS_TYPE;
                MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;
                MyOraDB.Parameter_Values[8] = " ";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();

                if (vDS == null) return null;
                return vDS.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable SAVE_SFX_CBD_COPY_OTHER_STYLE(CBD_Struct vCOPY_CBD, CBD_Struct vPASTE_CBD, string sDevFac, string sProdFac, string sMOID, string sBOMID)
        {
            try
            {

                MyOraDB.ReDim_Parameter(22);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_COPY_OTHER_STYLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_SEASON_CD";

                MyOraDB.Parameter_Name[7] = "ARG_DEV_FAC_2";
                MyOraDB.Parameter_Name[8] = "ARG_PROD_FAC_2";
                MyOraDB.Parameter_Name[9] = "ARG_MOID_2";
                MyOraDB.Parameter_Name[10] = "ARG_CBD_ID_2";
                MyOraDB.Parameter_Name[11] = "ARG_FOB_TYPE_CD_2";
                MyOraDB.Parameter_Name[12] = "ARG_CBD_SEQ_2";
                MyOraDB.Parameter_Name[13] = "ARG_SEASON_CD_2";

                MyOraDB.Parameter_Name[14] = "ARG_REV_REASON";
                MyOraDB.Parameter_Name[15] = "ARG_DESC";
                MyOraDB.Parameter_Name[16] = "ARG_STATUS_CD";

                MyOraDB.Parameter_Name[17] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[18] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[19] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[20] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[21] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                for (int i = 0; i < MyOraDB.Parameter_Name.Length - 1; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[MyOraDB.Parameter_Name.Length - 1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = vCOPY_CBD.sDEV_FAC;
                MyOraDB.Parameter_Values[1] = vCOPY_CBD.sFACTORY;
                MyOraDB.Parameter_Values[2] = vCOPY_CBD.sMOID;
                MyOraDB.Parameter_Values[3] = vCOPY_CBD.sCBD_ID;
                MyOraDB.Parameter_Values[4] = vCOPY_CBD.sFOB_TYPE_CD;
                MyOraDB.Parameter_Values[5] = vCOPY_CBD.sCBD_SEQ;
                MyOraDB.Parameter_Values[6] = vCOPY_CBD.sSEASON_CD;

                MyOraDB.Parameter_Values[7] = sDevFac;
                MyOraDB.Parameter_Values[8] = sProdFac;
                MyOraDB.Parameter_Values[9] = sMOID;
                MyOraDB.Parameter_Values[10] = sBOMID + "-1";
                MyOraDB.Parameter_Values[11] = "Y0000";
                MyOraDB.Parameter_Values[12] = "1";
                MyOraDB.Parameter_Values[13] = vPASTE_CBD.sSEASON_CD;

                MyOraDB.Parameter_Values[14] = "40";
                MyOraDB.Parameter_Values[15] = "Copy fob list program";
                MyOraDB.Parameter_Values[16] = "S";

                MyOraDB.Parameter_Values[17] = vPASTE_CBD.sSTYLE_CD;
                MyOraDB.Parameter_Values[18] = vPASTE_CBD.sOBS_ID;
                MyOraDB.Parameter_Values[19] = vPASTE_CBD.sOBS_TYPE;
                MyOraDB.Parameter_Values[20] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[21] = " ";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();

                if (vDS == null) return null;
                return vDS.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_TOOL(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_fob_type_cd, string arg_cbd_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(11);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[6] = "ARG_MOID";
                MyOraDB.Parameter_Name[7] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[8] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[9] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

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
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_month_from, "");
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_month_to, "");
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_obs_type, "");
                MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_style_cd, "");
                MyOraDB.Parameter_Values[5] = arg_dev_fac;
                MyOraDB.Parameter_Values[6] = arg_moid;
                MyOraDB.Parameter_Values[7] = arg_cbd_id;
                MyOraDB.Parameter_Values[8] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[9] = arg_cbd_seq;
                MyOraDB.Parameter_Values[10] = "";

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
        private void ctmnu_01_Opening(object sender, CancelEventArgs e)
        {
            int iRow = fgrid_tooling.Row, iCol = fgrid_tooling.Col;

            object obj = fgrid_tooling.GetCellRange(iRow, iCol).UserData;
            if (obj != null) 
            {
                CBD_Struct vCBD = (CBD_Struct)obj;
                
                if (copy_cbd.sREV_REASON == null)
                {
                    mnu_paste_dpo.Visible = false;
                }
                else
                {
                    mnu_paste_dpo.Visible = true;
                }

                if (vCBD.sREV_REASON.Equals("60") || vCBD.sREV_REASON.Equals("x"))
                {
                    if (mnu_paste_dpo.Visible)
                    {
                        mnu_copy_dpo.Visible = false;
                        mnu_bar1.Visible = false;
                        mnu_open_cbd.Visible = false;
                        e.Cancel = false;
                        return;
                    }
                }
                else
                {
                    mnu_copy_dpo.Visible = true;
                    mnu_bar1.Visible = true;
                    mnu_open_cbd.Visible = true;
                    e.Cancel = false;
                    return;
                }
            }

            e.Cancel = true;
        }
        private void mnu_open_cbd_Click(object sender, EventArgs e)
        {
            try
            {
                int row = fgrid_tooling.Row, col = fgrid_tooling.Col;
                if (fgrid_tooling.Rows.Fixed <= row && fgrid_tooling.Rows.Count > fgrid_tooling.Rows.Fixed)
                {
                    object obj = fgrid_tooling.GetCellRange(row, col).UserData;

                    if (obj != null)
                    {
                        CBD_Struct vCBD = (CBD_Struct)obj;

                        if (vCBD.sREV_REASON.Equals("x") || vCBD.sREV_REASON.Equals("60"))
                        {
                            if (vCBD.sREV_REASON.Equals("60"))
                            {
                                FlexCosting.Management.Analysis.Frm.Form_EIS_MatPrice_Check_FOB vAnalysis = new FlexCosting.Management.Analysis.Frm.Form_EIS_MatPrice_Check_FOB();
                                vAnalysis.MdiParent = this.MdiParent;
                                vAnalysis.Visible = true;

                                string OBSMonFrom = vCBD.sOBS_ID.Substring(0, 2);
                                string OBSMonTo = vCBD.sOBS_ID.Substring(0, 2);
                                if (int.Parse(vCBD.sOBS_ID.Substring(2, 2)) > int.Parse(vCBD.sOBS_ID.Substring(4, 2)))
                                {
                                    OBSMonTo = Convert.ToString(int.Parse(OBSMonFrom) + 1).PadLeft(2, '0');
                                }
                                string sMonFrom = ("20" + OBSMonFrom + "-" + vCBD.sOBS_ID.Substring(2, 2));
                                string sMonTo = ("20" + OBSMonTo + "-" + vCBD.sOBS_ID.Substring(4, 2));
                                vAnalysis.OpenFromCBDList(vCBD.sFACTORY, sMonFrom, sMonTo, vCBD.sOBS_ID, vCBD.sOBS_TYPE, vCBD.sSTYLE_CD); 
                            }
                            else
                            {
                                FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 vCBDFrm = new FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6();
                                vCBDFrm.MdiParent = this.MdiParent;
                                vCBDFrm.Visible = true;
                            }
                        }
                        else
                        {
                            string sDevFac = vCBD.sDEV_FAC;
                            string sMOID = vCBD.sMOID;
                            string sCBDID = vCBD.sCBD_ID;
                            string sFOBType = vCBD.sFOB_TYPE_CD;
                            string sCBDSeq = vCBD.sCBD_SEQ;

                            FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 vCBDFrm = new FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6();
                            vCBDFrm.Visible = true;
                            if (vCBDFrm.ShowDialog(sDevFac, sMOID, sCBDID, sCBDSeq, sFOBType) == DialogResult.OK)
                            {
                                DataTable vDT = SELECT_SFX_CBD_TOOL(sDevFac, sMOID, sCBDID, sFOBType, sCBDSeq);
                                if (vDT != null && vDT.Rows.Count == 1)
                                {
                                    DisplayData(vDT.Rows[0], vCBD.iRow, vCBD.iStrCol);
                                }
                            }
                        }
                    }
                    else
                    {
                        FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 vCBDFrm = new FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6();
                        vCBDFrm.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mnu_delete_cbd_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_tooling.Rows.Count.Equals(fgrid_tooling.Rows.Fixed))
                    return;

                int sct_row = fgrid_tooling.Selection.r1;
                int sct_col = fgrid_tooling.Selection.c1;

                if (sct_row < fgrid_tooling.Rows.Fixed)
                    return;

                if (sct_col < (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt)
                    return;

                object oCUR_CBD = fgrid_tooling.GetCellRange(sct_row, sct_col).UserData;

                if (oCUR_CBD != null)
                {
                    CBD_Struct vCUR_CBD = (CBD_Struct)oCUR_CBD;

                    if (!vCUR_CBD.sREV_REASON.Equals("x"))
                    {
                        if (SAVE_SFX_CBD_DPO(vCUR_CBD))
                        {
                            vCUR_CBD.sDEV_FAC = null;
                            vCUR_CBD.sMOID = null;
                            vCUR_CBD.sCBD_ID = null;
                            vCUR_CBD.sFOB_TYPE_CD = null;
                            vCUR_CBD.sCBD_SEQ = null;
                            vCUR_CBD.sREV_REASON = "x";

                            vCUR_CBD.dFOB = 0;
                            vCUR_CBD.dTOOLING = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        private bool SAVE_SFX_CBD_DPO(CBD_Struct vCUR_CBD)
        {
            try
            {

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_DPO";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = "D";
                MyOraDB.Parameter_Values[1] = vCUR_CBD.sDEV_FAC;
                MyOraDB.Parameter_Values[2] = vCUR_CBD.sMOID;
                MyOraDB.Parameter_Values[3] = vCUR_CBD.sCBD_ID;
                MyOraDB.Parameter_Values[4] = vCUR_CBD.sFOB_TYPE_CD;
                MyOraDB.Parameter_Values[5] = vCUR_CBD.sCBD_SEQ;
                MyOraDB.Parameter_Values[6] = COM.ComVar.This_User;

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

