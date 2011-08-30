using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;

namespace FlexCosting.Management.Analysis.Frm
{
    public partial class  Form_EIS_MatPrice_Check_FOB : COM.APSWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();
        private Thread temp_thread = null;

        private string [] copy_row;
        #endregion

        #region Constructor
        public  Form_EIS_MatPrice_Check_FOB()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_EIS_MatPrice_Check_FOB_Load(object sender, EventArgs e)
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
            this.Text = "CBD Analysis";
            lbl_MainTitle.Text = "CBD Analysis";
            ClassLib.ComFunction.SetLangDic(this);
            
            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EIS_MATPRICE_CHECK_FOB", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.KeyActionEnter = KeyActionEnum.MoveAcross;
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
            {
                if (j.Equals((int)ClassLib.TBEIS_CBD_ANALISYS.IxFACTORY))
                    fgrid_Main.Cols[j].AllowMerging = true;
                else if (j.Equals((int)ClassLib.TBEIS_CBD_ANALISYS.IxCATEGORY_NAME))
                    fgrid_Main.Cols[j].AllowMerging = true;
                else if (j.Equals((int)ClassLib.TBEIS_CBD_ANALISYS.IxMODEL_NAME))
                    fgrid_Main.Cols[j].AllowMerging = true;
                else if (j.Equals((int)ClassLib.TBEIS_CBD_ANALISYS.IxSTYLE_CD))
                    fgrid_Main.Cols[j].AllowMerging = true;
                else
                {
                    fgrid_Main.Cols[j].AllowMerging = false;

                    if (j >= (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD && j <= (int)ClassLib.TBEIS_CBD_ANALISYS.IxDEDUCTION)
                    {
                        fgrid_Main.Cols[j].Format = "###0.00";
                    }                    
                }
            }

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD).StyleNew.BackColor = Color.LightPink;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD).StyleNew.ForeColor = Color.Black;
            
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMAT_SUMM_CBD).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMAT_SUMM_CBD).StyleNew.ForeColor = Color.Black;
            
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD).StyleNew.BackColor = Color.LightPink;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxNON_MAT_SUMM_CBD).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxNON_MAT_SUMM_CBD).StyleNew.ForeColor = Color.Black;
            
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD).StyleNew.BackColor = Color.LightPink;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxTOOL_SUMM_CBD).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxTOOL_SUMM_CBD).StyleNew.ForeColor = Color.Black;
            
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_INV).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_INV).StyleNew.ForeColor = Color.Black;            

        }

        private void Init_Control()
        {
                     
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Color.ToolTipText = "Order Quantity";

            tbtn_Save.Enabled   = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled  = false;


            if ((ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "C") ||
               (ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "S"))
            {
                tbtn_Save.Enabled = true;
                tbtn_Delete.Enabled = true;
            }



            // plan_month from, to add items
            DataTable dt_date = new DataTable();

            DataColumn dc_date = new DataColumn("PLAN_MONTH", Type.GetType("System.String"));
            dt_date.Columns.Add(dc_date);

            for (int i = -6; i <= 6; i++)
            {

                DataRow dr_date = dt_date.NewRow();

                dr_date["PLAN_MONTH"] = System.DateTime.Now.AddMonths(i * (-1)).ToString("yyyy-MM");
                dt_date.Rows.Add(dr_date);
            }

            ClassLib.ComFunction.Set_ComboList(dt_date, cmb_PlanMonth_From, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComFunction.Set_ComboList(dt_date, cmb_PlanMonth_To, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            dt_date.Dispose();
            cmb_PlanMonth_From.SelectedIndex = 0;
            cmb_PlanMonth_To.SelectedIndex = 0;

            // 공장 Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            if (ClassLib.ComVar.This_CDC_Factory != "DS")
            { cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory; cmb_Factory.Enabled = false; }
            else
            { cmb_Factory.SelectedValue = "QD"; cmb_Factory.Enabled = true; }



            ////Order Type Setting..
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Order_Type, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Order_Type.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Order_Type);


            // Category Setting..
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "MD02");
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Category, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Category.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Category);
                        
            // Model Setting..
            dt_ret = ClassLib.ComFunction.SELECT_MODEL_LIST(cmb_Factory.SelectedValue.ToString());
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Model, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Model.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Model);
            
            //Style Setting
            Set_Style_List();


            // User  Setting..
            dt_ret = SELECT_FOB_USER(cmb_Factory.SelectedValue.ToString());
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_User, 0, 0, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_User.SelectedIndex = 0;
            cmb_User.Splits[0].DisplayColumns[0].Width = 0;
            //cmb_User.Splits[0].DisplayColumns[1].Width = 210;
            //cmb_User.DropDownWidth = 310;

            txt_FOB_Lower.Text = "0.00";
            txt_FOB_Higher.Text = "500.00";
        }

        private void Set_Style_List()
        {
            DataTable dt_ret = SELECT_STYLE_LIST(ClassLib.ComFunction.Empty_Combo(cmb_Model, " "),
                                              ClassLib.ComFunction.Empty_TextBox(txt_Style, " "));

            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Style, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Style.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Style);
        }
        private void Set_Combo_Size(int arg_col1, int arg_col2, int arg_col_tot, C1.Win.C1List.C1Combo arg_cmb)
        {
            arg_cmb.SelectedIndex = 0;
            arg_cmb.Splits[0].DisplayColumns[0].Width = arg_col1;
            arg_cmb.Splits[0].DisplayColumns[1].Width = arg_col2;
            arg_cmb.DropDownWidth = arg_col_tot;
        }

        private DataTable SELECT_STYLE_LIST(string arg_model, string arg_style)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_SDC_STYLE";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_model;
                MyOraDB.Parameter_Values[1] = arg_style;
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
        private DataTable SELECT_FOB_USER(string arg_factory)
        {

            try
            {

                MyOraDB.ReDim_Parameter(2);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SELECT_FOB_USER";


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
        #endregion

        #region Refresh Form
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
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

        private void Event_Tbtn_New()
        {
            fgrid_Main.ClearAll();
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

            try
            {
                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

                string[] arg_value = new string[14];

                arg_value[0] = ClassLib.ComVar.This_CDC_Factory;
                arg_value[1] = cmb_Factory.SelectedValue.ToString();
                arg_value[2] = ClassLib.ComFunction.Empty_String(cmb_PlanMonth_From.SelectedValue.ToString().Replace("-", ""), "000000");
                arg_value[3] = ClassLib.ComFunction.Empty_String(cmb_PlanMonth_To.SelectedValue.ToString().Replace("-", ""), "999999");
                arg_value[4] = ClassLib.ComFunction.Empty_Combo(cmb_Order_Type, " ");
                arg_value[5] = (cmb_Order_ID.SelectedText.Equals("ALL")) ? " " : cmb_Order_ID.SelectedText;
                arg_value[6] = ClassLib.ComFunction.Empty_Combo(cmb_Category, " ");
                arg_value[7] = ClassLib.ComFunction.Empty_Combo(cmb_Model, " ");
                arg_value[8] = ClassLib.ComFunction.Empty_TextBox(txt_Style, " ");
                arg_value[9] = ClassLib.ComFunction.Empty_Combo(cmb_New, " ");
                arg_value[10] = ClassLib.ComFunction.Empty_Combo(cmb_Status, " ");
                arg_value[11] = ClassLib.ComFunction.Empty_Combo(cmb_User, " ");
                arg_value[12] = ClassLib.ComFunction.Empty_TextBox(txt_FOB_Lower, "0");
                arg_value[13] = ClassLib.ComFunction.Empty_TextBox(txt_FOB_Higher, "0");

               DataTable dt_ret = SELECT_CBD_ANALISYS(arg_value);

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_Main.Rows.Add();
                    int row = fgrid_Main.Rows.Count - 1;

                    for (int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
                    {
                        fgrid_Main[row, j] = dt_ret.Rows[i].ItemArray[j];

                        //GridStyle_Setting(row, j);
                    }

                    string detail = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL] == null) ? "FALSE" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL].ToString().Trim().ToUpper();

                    //if (detail.Equals("TRUE"))
                    //    fgrid_Main.Rows[row].AllowEditing = false;
                    //else
                        fgrid_Main.Rows[row].AllowEditing = true;

                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD, row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMAT_SUMM_CBD).StyleNew.BackColor = Color.LightYellow;
                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD, row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxNON_MAT_SUMM_CBD).StyleNew.BackColor = Color.LightYellow;
                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD, row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxTOOL_SUMM_CBD).StyleNew.BackColor = Color.LightYellow;
                    fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB).StyleNew.BackColor = Color.MintCream;

                    try
                    {
                        int over_gac = Convert.ToInt16(fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOVER_GAC].ToString().Trim());

                        if (over_gac >= -30)
                        {
                            string fob = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB] == null) ? "0" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB].ToString().Trim();

                            if (fob.Equals("0"))
                            {
                                fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOVER_GAC).StyleNew.ForeColor = Color.Red;
                            }
                        }
                    }
                    catch
                    {

                    }

                    string remarks = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxREMARKS] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxREMARKS].ToString().Trim();

                    if (remarks.Equals("COPY FT ORDER") || remarks.Equals("N"))
                    {
                        fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxREMARKS).StyleNew.ForeColor = Color.Blue;
                    }

                    string sCostFOB = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB] == null) ? "0" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB].ToString().Trim();
                    string sInvFOB = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_INV] == null) ? "0" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_INV].ToString().Trim();

                    if (!sCostFOB.Equals(sInvFOB))
                    {
                        fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_INV).StyleNew.BackColor = Color.Red;
                        fgrid_Main.GetCellRange(row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_INV).StyleNew.ForeColor = Color.White;
                    }
                }

                dt_ret.Dispose();
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


        private DataTable SELECT_CBD_ANALISYS(string[] arg_value)
        {
            try
            {

                MyOraDB.ReDim_Parameter(15);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SELECT_CBD_ANALISYS";


                //02.ARGURMENT 명
                int i = 0;
                MyOraDB.Parameter_Name[i++] = "ARG_THIS_FACTORY";
                MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[i++] = "ARG_PLAN_YMD_FROM";
                MyOraDB.Parameter_Name[i++] = "ARG_PLAN_YMD_TO";
                MyOraDB.Parameter_Name[i++] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[i++] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[i++] = "ARG_CATEGORY_CD";
                MyOraDB.Parameter_Name[i++] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[i++] = "ARG_NEW_YN";
                MyOraDB.Parameter_Name[i++] = "ARG_STATUS";
                MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[i++] = "ARG_FOB_LOWER";
                MyOraDB.Parameter_Name[i++] = "ARG_FOB_HIGHER";
                MyOraDB.Parameter_Name[i++] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                int j = 0;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.Cursor;
                
                //04.DATA 정의
                int k = 0;
                MyOraDB.Parameter_Values[k++] = arg_value[0];
                MyOraDB.Parameter_Values[k++] = arg_value[1]; 
                MyOraDB.Parameter_Values[k++] = arg_value[2]; 
                MyOraDB.Parameter_Values[k++] = arg_value[3]; 
                MyOraDB.Parameter_Values[k++] = arg_value[4]; 
                MyOraDB.Parameter_Values[k++] = arg_value[5]; 
                MyOraDB.Parameter_Values[k++] = arg_value[6]; 
                MyOraDB.Parameter_Values[k++] = arg_value[7]; 
                MyOraDB.Parameter_Values[k++] = arg_value[8]; 
                MyOraDB.Parameter_Values[k++] = arg_value[9]; 
                MyOraDB.Parameter_Values[k++] = arg_value[10];
                MyOraDB.Parameter_Values[k++] = arg_value[11];
                MyOraDB.Parameter_Values[k++] = arg_value[12];
                MyOraDB.Parameter_Values[k++] = arg_value[13];
                MyOraDB.Parameter_Values[k++] = "";
                
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

            // 행 수정상태 해제 
            fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, false);

            DialogResult result = MessageBox.Show("Do you want save?", "", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.No) return;

            if (SAVE_SFX_CBD_HEAD())
            {
                int sct_row = fgrid_Main.Selection.r1;
                int sct_col = fgrid_Main.Selection.c1;
                                
                Display_Data();
                MessageBox.Show("Save Completed");
                fgrid_Main.Select(sct_row, sct_col);
            }
        } 

        private bool SAVE_SFX_CBD_HEAD()
        {
            int vcnt = 31;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SAVE_SFX_CBD_HEAD";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";

            MyOraDB.Parameter_Name[1] = "ARG_DEV_FAC";
            MyOraDB.Parameter_Name[2] = "ARG_MOID";
            MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
            MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";

            MyOraDB.Parameter_Name[5]  = "ARG_CBD_SEQ";
            MyOraDB.Parameter_Name[6]  = "ARG_PROD_FAC";
            MyOraDB.Parameter_Name[7]  = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[8]  = "ARG_PRODUCT_CD";
            MyOraDB.Parameter_Name[9]  = "ARG_MODEL_NAME";
            MyOraDB.Parameter_Name[10]  = "ARG_CAT_CD";
            MyOraDB.Parameter_Name[11]  = "ARG_OBS_ID";
            MyOraDB.Parameter_Name[12]  = "ARG_OBS_TYPE";
            MyOraDB.Parameter_Name[13]  = "ARG_UPPER_SUMM_CBD";
            MyOraDB.Parameter_Name[14] = "ARG_PACKING_SUMM_CBD";
            MyOraDB.Parameter_Name[15] = "ARG_MIDSOLE_SUMM_CBD";
            MyOraDB.Parameter_Name[16] = "ARG_OUTSOLE_SUMM_CBD";
            MyOraDB.Parameter_Name[17] = "ARG_SIZEUP_SUMM_CBD";
            MyOraDB.Parameter_Name[18] = "ARG_MAT_SUMM_CBD";
            MyOraDB.Parameter_Name[19] = "ARG_LABOR_SUMM_CBD";
            MyOraDB.Parameter_Name[20] = "ARG_OVERHEAD_SUMM_CBD";
            MyOraDB.Parameter_Name[21] = "ARG_PROFIT_SUMM_CBD";
            MyOraDB.Parameter_Name[22] = "ARG_PRSS_SUMM_CBD";
            MyOraDB.Parameter_Name[23] = "ARG_OTHERADJ_SUMM_CBD";
            MyOraDB.Parameter_Name[24] = "ARG_NON_MAT_SUMM_CBD";
            MyOraDB.Parameter_Name[25] = "ARG_SMPL_TOOL_SUMM_CBD";
            MyOraDB.Parameter_Name[26] = "ARG_PROD_TOOL_SUMM_CBD";
            MyOraDB.Parameter_Name[27] = "ARG_TOOL_SUMM_CBD";
            MyOraDB.Parameter_Name[28] = "ARG_FOB";
            MyOraDB.Parameter_Name[29] = "ARG_STATUS";
            MyOraDB.Parameter_Name[30] = "ARG_UPD_USER";            

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {
                string _div = (fgrid_Main[i, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
            {
                string _div = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = _div;
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDEV_FAC] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDEV_FAC].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMOID] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMOID].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_ID] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_ID].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_TYPE_CD] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_TYPE_CD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_SEQ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_SEQ].ToString().Trim();

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFACTORY           ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFACTORY           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSTYLE_CD          ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSTYLE_CD          ].ToString().Trim().Replace("-", "");
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSTYLE_CD          ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSTYLE_CD          ].ToString().Trim().Replace("-", "") + "00";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMODEL_NAME        ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMODEL_NAME        ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCATEGORY_CD       ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCATEGORY_CD       ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOBS_ID            ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOBS_ID            ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOBS_TYPE          ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOBS_TYPE          ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD    ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD    ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPACKING_SUMM_CBD  ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPACKING_SUMM_CBD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMIDSOLE_SUMM_CBD  ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMIDSOLE_SUMM_CBD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOUTSOLE_SUMM_CBD  ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOUTSOLE_SUMM_CBD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD   ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMAT_SUMM_CBD      ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMAT_SUMM_CBD      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD    ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD    ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOVERHEAD_SUMM_CBD ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOVERHEAD_SUMM_CBD ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROFIT_SUMM_CBD   ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROFIT_SUMM_CBD   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPRSS_SUMM_CBD     ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPRSS_SUMM_CBD     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxNON_MAT_SUMM_CBD  ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxNON_MAT_SUMM_CBD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxTOOL_SUMM_CBD     ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxTOOL_SUMM_CBD     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB               ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB               ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSTATUS] == null) ? "S" : (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSTATUS].ToString().Trim().ToUpper().Equals("TRUE")) ? "C" : "S";
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

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
                Event_Tbtn_Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Event_Tbtn_Delete()
        {
            int[] vRow = fgrid_Main.Selections;
                        
            for (int i = 0; i < vRow.Length; i++)
            {
                fgrid_Main[vRow[i], 0] = "D";
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
                MessageBox.Show(ex.ToString());
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
                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "FOB 사전 점검", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Grid Event
        private void fgrid_Main_StartEdit(object sender, RowColEventArgs e)
        {
            try
            {
                Event_fgrid_Main_BeforeEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Event_fgrid_Main_AfterEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void fgrid_Main_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Event_fgrid_Main_DoubleClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Event_fgrid_Main_BeforeEdit()
        {
            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
                fgrid_Main.GetCellRange(fgrid_Main.Row, fgrid_Main.Col).StyleNew.Format = "#####0.00##########";
            }

        }
        private void Event_fgrid_Main_AfterEdit()
        {

            int sct_row = fgrid_Main.Selection.r1;
            int sct_col = fgrid_Main.Selection.c1;

            if (sct_col.Equals((int)ClassLib.TBEIS_CBD_ANALISYS.IxSTATUS))
                return;

            double upper_summ_cbd      = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD    );
            double packing_summ_cbd    = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPACKING_SUMM_CBD  );
            double midsole_summ_cbd    = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMIDSOLE_SUMM_CBD  );
            double outsole_summ_cbd    = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOUTSOLE_SUMM_CBD  );
            double sizeup_summ_cbd     = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD   );
            double mat_summ_cbd        = upper_summ_cbd + packing_summ_cbd + midsole_summ_cbd + outsole_summ_cbd + sizeup_summ_cbd;
            double labor_summ_cbd      = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD    );
            double overhead_summ_cbd   = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOVERHEAD_SUMM_CBD );
            double profit_summ_cbd     = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROFIT_SUMM_CBD   );
            double prss_summ_cbd       = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPRSS_SUMM_CBD     );
            double otheradj_summ_cbd   = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD );
            double non_mat_summ_cbd    = labor_summ_cbd + overhead_summ_cbd + profit_summ_cbd + prss_summ_cbd + otheradj_summ_cbd;
            double smpl_tool_summ_cbd  = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD);
            double prod_tool_summ_cbd  = ToDouble_GridValue(sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD);
            double tool_summ_cbd       = smpl_tool_summ_cbd +prod_tool_summ_cbd ;
            double fob                 = mat_summ_cbd + non_mat_summ_cbd + tool_summ_cbd;
            
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD    ] = upper_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPACKING_SUMM_CBD  ] = packing_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMIDSOLE_SUMM_CBD  ] = midsole_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOUTSOLE_SUMM_CBD  ] = outsole_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSIZEUP_SUMM_CBD   ] = sizeup_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMAT_SUMM_CBD      ] = mat_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxLABOR_SUMM_CBD    ] = labor_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOVERHEAD_SUMM_CBD ] = overhead_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROFIT_SUMM_CBD   ] = profit_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPRSS_SUMM_CBD     ] = prss_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxOTHERADJ_SUMM_CBD ] = otheradj_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxNON_MAT_SUMM_CBD  ] = non_mat_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxSMPL_TOOL_SUMM_CBD] = smpl_tool_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxPROD_TOOL_SUMM_CBD] = prod_tool_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxTOOL_SUMM_CBD     ] = tool_summ_cbd;
            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB               ] = fob;            

            fgrid_Main[sct_row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV] = "U";
            fgrid_Main.GetCellRange(sct_row, sct_col).StyleNew.Format = "#####0.00";
        }

        private double ToDouble_GridValue(int arg_row, int arg_col)
        {
            try
            {
                string value_string = (fgrid_Main[arg_row, arg_col] == null) ? "0" : fgrid_Main[arg_row, arg_col].ToString().Trim();

                double value = double.Parse(value_string);

                return value;
            }
            catch
            {
                return 0;
            }
        }

        private void Event_fgrid_Main_DoubleClick()
        {
            string vFactory = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFACTORY].ToString();
            string vModelCD = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMODEL_CD].ToString();
            string vModelName = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMODEL_NAME].ToString();

            Pop_EIS_MatPrice_Order_Qty vPop = new Pop_EIS_MatPrice_Order_Qty(vFactory, vModelCD, vModelName);
            vPop.ShowDialog();

        }
        #endregion

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Factory_SelectedValueChanged();
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
        private void cmb_Style_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Style.SelectedIndex == -1) return;

                txt_Style.Text = cmb_Style.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void cmb_Model_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Model.SelectedIndex <= 0) return;
                Set_Style_List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txt_Style_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    Set_Style_List();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cmb_Category_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Category.SelectedIndex <= 0) return;

                Set_Model_List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void cmb_Order_Type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Event_cmb_Order_Type_TextChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cmb_PlanMonth_To_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_PlanMonth_To_SelectedValueChanged();
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
        private void cmb_New_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_New_SelectedValueChanged();
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
        private void cmb_Status_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Status_SelectedValueChanged();
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

        private void Event_cmb_Factory_SelectedValueChanged()
        {
            if (cmb_Factory.SelectedIndex == -1) cmb_Factory.SelectedValue = "QD";


            if ((cmb_Factory.SelectedValue.ToString() != "JJ") && (cmb_Factory.SelectedValue.ToString() != "QD") &&
                (cmb_Factory.SelectedValue.ToString() != "VJ"))
                cmb_Factory.SelectedValue = "QD";


            // new yn
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxUseYN);  // "SBC00";
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_New, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_New.SelectedIndex = 0;           

            //Status
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "EIS_MAT_12");
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Status, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Status.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Status);

            Event_Tbtn_New();
        }
        private void Event_cmb_Order_Type_TextChanged()
        {
            cmb_Order_ID.ClearItems();
            ClassLib.ComFunction.Set_OBSID_CmbList(cmb_Order_Type.SelectedValue.ToString(), true, cmb_Order_ID);
            cmb_Order_ID.SelectedIndex = 0;
        }
        private void Event_cmb_PlanMonth_To_SelectedValueChanged()
        {           
            fgrid_Main.ClearAll();            
        }
        private void Event_cmb_New_SelectedValueChanged()
        {
            if (cmb_New.SelectedIndex == -1) return;


            fgrid_Main.ClearAll();
        }
        private void Event_cmb_Status_SelectedValueChanged()
        {

            if (cmb_Status.SelectedIndex == -1) return;


            fgrid_Main.ClearAll();
        }
        private void Set_Model_List()
        {
            DataTable dt_ret = SELECT_MODEL_LIST(ClassLib.ComFunction.Empty_Combo(cmb_Category, " "));

            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Model, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Model.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Model);
        }

        private DataTable SELECT_MODEL_LIST(string arg_category)
        {

            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_SDC_MODEL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_CATEGORY_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_category;
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
        #endregion  
        
        #region ContextMenu Event
        private void menuItem_Copy_Click(object sender, System.EventArgs e)
        {
            try
            {
                Event_Click_menuItem_Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void menuItem_Paste_Click(object sender, System.EventArgs e)
        {
            try
            {
                Event_Click_menuItem_Paste();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void menuItem_Delete_Click(object sender, System.EventArgs e)
        {
            try
            {
                Event_Click_menuItem_Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        

        private void Event_Click_menuItem_Copy()
        {
            if (fgrid_Main.Rows.Count.Equals(fgrid_Main.Rows.Fixed))
                return;

            int sct_row = fgrid_Main.Selection.r1;

            if (sct_row < fgrid_Main.Rows.Fixed)
                return;

            copy_row = new string[(int)ClassLib.TBEIS_CBD_ANALISYS.IxMaxCt];

            for (int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
            {
                copy_row[j] = (fgrid_Main[sct_row, j] == null) ? "" : fgrid_Main[sct_row, j].ToString(); 
            }

            string _factory    = copy_row[(int)ClassLib.TBEIS_CBD_ANALISYS.IxFACTORY];
            string _style_name = copy_row[(int)ClassLib.TBEIS_CBD_ANALISYS.IxMODEL_NAME];
            string _style_cd   = copy_row[(int)ClassLib.TBEIS_CBD_ANALISYS.IxSTYLE_CD];
            string _obs_id     = copy_row[(int)ClassLib.TBEIS_CBD_ANALISYS.IxOBS_ID];
            string _obs_type   = copy_row[(int)ClassLib.TBEIS_CBD_ANALISYS.IxOBS_TYPE];

            string message = _factory + " / " + _style_name + " / " + _style_cd + " / " + _obs_id + " / " + _obs_type + " is copied.";
            COM.ComFunction.Status_Bar_Message(message, this);
        }
        private void Event_Click_menuItem_Paste()
        {
            int[] sct_rows = fgrid_Main.Selections;
            
            for (int i = 0; i < sct_rows.Length; i++)
            {
                string detail = (fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL] == null) ? "FALSE" : fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL].ToString().Trim().ToUpper();

                if (detail.Equals("FALSE"))
                {
                    for (int j = (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD; j <= (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB; j++)
                    {
                        fgrid_Main[sct_rows[i], j] = copy_row[j];
                    }

                    fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV] = "U";
                }
            }
        }
        private void Event_Click_menuItem_Delete()
        {
            int[] sct_rows = fgrid_Main.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                string detail = (fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL] == null) ? "FALSE" : fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL].ToString().Trim().ToUpper();

                if (detail.Equals("FALSE"))
                {
                    for (int j = (int)ClassLib.TBEIS_CBD_ANALISYS.IxUPPER_SUMM_CBD; j <= (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB; j++)
                    {
                        fgrid_Main[sct_rows[i], j] = null;
                    }

                    fgrid_Main[sct_rows[i], (int)ClassLib.TBEIS_CBD_ANALISYS.IxDIV] = "D";
                }
            }
        }
        private void menuitem_OpenCBD_Click(object sender, EventArgs e)
        {
            try
            {
                int row = fgrid_Main.Row;
                if (fgrid_Main.Rows.Fixed <= row && fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                {
                    string sDetailChk = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDETAIL].ToString().Trim();

                    if (Convert.ToBoolean(sDetailChk))
                    {
                        string sDevFac = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDEV_FAC] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxDEV_FAC].ToString().Trim();
                        string sMOID = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMOID] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxMOID].ToString().Trim();
                        string sCBDID = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_ID] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_ID].ToString().Trim();
                        string sFOBType = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_TYPE_CD] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxFOB_TYPE_CD].ToString().Trim();
                        string sCBDSeq = (fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_SEQ] == null) ? "" : fgrid_Main[row, (int)ClassLib.TBEIS_CBD_ANALISYS.IxCBD_SEQ].ToString().Trim();

                        FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6 vCBDFrm = new FlexCosting.Management.Costing.Frm.Form_CBD_Master_v6();
                        vCBDFrm.Visible = true;
                        if (vCBDFrm.ShowDialog(sDevFac, sMOID, sCBDID, sCBDSeq, sFOBType) == DialogResult.OK)
                        {
                            // Open success
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

        #region For CBD List 

        public void OpenFromCBDList(string sFactory, string sMonFrom, string sMonTo, string sOBSID, string sOBSType, string sStyleCD)
        {
            try
            {
                cmb_Factory.SelectedValue = sFactory;
                cmb_PlanMonth_From.SelectedValue = sMonFrom;
                cmb_PlanMonth_To.SelectedValue = sMonTo;
                cmb_Order_Type.SelectedValue = sOBSType;

                for (int iIdx = 0; iIdx < cmb_Order_ID.ListCount; iIdx++)
                {
                    if (cmb_Order_ID.GetItemText(iIdx, 0).Equals(sOBSID))
                        cmb_Order_ID.SelectedIndex = iIdx;
                }                

                txt_Style.Text = sStyleCD;
                txt_Style_KeyPress(txt_Style, new KeyPressEventArgs((char)Keys.Enter));
                cmb_Style.SelectedValue = sStyleCD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cmb_Factory.SelectedValue != null && 
                    cmb_PlanMonth_From.SelectedValue != null && 
                    cmb_PlanMonth_To.SelectedValue != null && 
                    cmb_Order_Type.SelectedValue != null &&
                    cmb_Style.SelectedValue != null)
                Display_Data();
            }
        }

        #endregion
    }
}
