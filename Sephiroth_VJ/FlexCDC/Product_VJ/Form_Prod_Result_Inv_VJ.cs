using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product_VJ
{
    public partial class Form_Prod_Result_Inv_VJ : COM.APSWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string _form_type = "";
        private int copy_row = 0;
        #endregion

        #region Resource
        public Form_Prod_Result_Inv_VJ()
        {
            InitializeComponent();
        }
        public Form_Prod_Result_Inv_VJ(string arg_type)
        {
            _form_type = arg_type;
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cmb_factory.SelectedIndex == -1)
                    return;


                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_Form();

                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Form_Prod_Result_Inv_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_factory = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_factory, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {
            }
        }

        private void Init_Form()
        {
            //Title
            this.Text = "Production Inventory";
            lbl_MainTitle.Text = "  Production Inventory";
            
            Init_Grid();
            Init_Control();

            if (_form_type.Equals("P"))
                tbtn_Search_Click(null, null);
        }


        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SXG_PROD_INV_VJ", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;
            fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcrossOut;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL).StyleNew.ForeColor = Color.Black;


            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER).StyleNew.TextAlign = TextAlignEnum.LeftCenter;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER).StyleNew.ForeColor = Color.White;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE).StyleNew.BackColor = Color.LightBlue;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_TOTAL).StyleNew.BackColor = Color.LightBlue;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_TOTAL).StyleNew.ForeColor = Color.Black;            

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE).StyleNew.TextAlign = TextAlignEnum.LeftCenter;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE).StyleNew.ForeColor = Color.White;
        }


        private void Init_Control()
        {
            //Round
            DataTable dt_ret = Select_round();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 170);
            cmb_round.SelectedIndex = 0;


            // Combobox Add Items
            dt_ret = Select_season();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_from, 0, 1, true, COM.ComVar.ComboList_Visible.Name);           
            cmb_Season_from.SelectedIndex = 0;
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_to, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_to.SelectedIndex = 0;
            
            //Dev User
            dt_ret = Select_user();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 120);


            if (COM.ComVar.This_CDCPower_Level.Substring(0, 1).Equals("D"))
            {
                if (COM.ComVar.This_CDCGroup_Code.Equals("NOS"))
                {
                    cmb_user.SelectedIndex = 0;
                }
                else
                {
                    cmb_user.Enabled = false;

                    DataTable user_datatable = new DataTable("UserList");
                    DataRow newrow;

                    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                    newrow = user_datatable.NewRow();
                    newrow["Code"] = ClassLib.ComVar.This_User;
                    newrow["Name"] = ClassLib.ComVar.This_User;

                    user_datatable.Rows.Add(newrow);

                    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                    cmb_user.SelectedValue = ClassLib.ComVar.This_User;
                }
            }
            else
            {
                cmb_user.SelectedIndex = 0;
            }

            //Check
            cmb_check.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_check.ClearItems();

            cmb_check.AddItemTitles("Code;Name");

            cmb_check.ValueMember = "Code";
            cmb_check.DisplayMember = "Name";

            cmb_check.AddItem(";ALL");
            cmb_check.AddItem("TRUE;Checked");
            cmb_check.AddItem("FALSE;Unchecked");

            cmb_check.SelectedIndex = -1;

            cmb_check.MaxDropDownItems = 10;
            cmb_check.Splits[0].DisplayColumns[0].Width = 0;
            cmb_check.Splits[0].DisplayColumns[1].Width = 155;

            cmb_check.ExtendRightColumn = true;
            cmb_check.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_check.HScrollBar.Height = 0;

            if (_form_type.Equals("P"))
                cmb_check.SelectedValue = "FALSE";
            else
                cmb_check.SelectedIndex = 0;

            //Status
            cmb_status.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_status.ClearItems();

            cmb_status.AddItemTitles("Code;Name");

            cmb_status.ValueMember = "Code";
            cmb_status.DisplayMember = "Name";

            cmb_status.AddItem(";ALL");
            cmb_status.AddItem("Y;Not Completed");
            cmb_status.AddItem("C;Completed");

            cmb_status.SelectedIndex = -1;

            cmb_status.MaxDropDownItems = 10;
            cmb_status.Splits[0].DisplayColumns[0].Width = 0;
            cmb_status.Splits[0].DisplayColumns[1].Width = 155;

            cmb_status.ExtendRightColumn = true;
            cmb_status.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_status.HScrollBar.Height = 0;

            if (_form_type.Equals("P"))
                cmb_status.SelectedValue = "C";
            else
                cmb_status.SelectedIndex = 0;
            //날짜 Setting
            DateTime limit_date = new DateTime(2009, 7, 1);
            dtp_from.Value = limit_date;
            dtp_to.Value = DateTime.Now;

            tbtn_New.Enabled    = false;
            tbtn_Search.Enabled = true;
            tbtn_Save.Enabled   = true;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled  = true;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Color.Enabled  = false;

            lbl_ing.BackColor      = Color.Yellow;
            lbl_complete.BackColor = Color.Aqua;

            txt_model.CharacterCasing = CharacterCasing.Upper;
            txt_bom.Focus();

            mnu_paste.Enabled = false;
        }

        private DataTable Select_season()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_order_01.select_season";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_round()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_01_select.select_sample_types";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }


        private DataTable Select_user()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_01_select.select_user";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //1. Grid 초기화
                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                //2. 조회조건
                string[] arg_value = new string[12];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dtp_from.Value.ToString("yyyyMMdd");
                arg_value[2] = dtp_to.Value.ToString("yyyyMMdd");
                arg_value[3] = txt_model.Text.Trim();
                arg_value[4] = txt_style_cd.Text.Trim();
                arg_value[5] = cmb_round.SelectedValue.ToString().Trim();
                arg_value[6] = txt_bom.Text.Trim();
                arg_value[7] = cmb_user.SelectedValue.ToString().Trim();
                arg_value[8] = cmb_check.SelectedValue.ToString();
                arg_value[9] = cmb_status.SelectedValue.ToString();
                arg_value[10] = cmb_Season_from.SelectedValue.ToString();
                arg_value[11] = cmb_Season_to.SelectedValue.ToString();


                
                
                //3. Data Search (BOM Info)
                DataTable dt_list = Select_result_list(arg_value);

                if (_form_type.Equals("P"))
                {
                    if (dt_list.Rows.Count == 0)
                        this.Close();
                }

                Display_grid(dt_list, fgrid_main);

                fgrid_main.Tree.Show(1);
                dt_list.Dispose();
            }
            catch
            {                
                ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
        }

        private DataTable Select_result_list(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_PROD_02_SELECT.SELECT_SXG_PROD_INV_01";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_MODEL";
            MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[5] = "ARG_ROUND";
            MyOraDB.Parameter_Name[6] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[7] = "ARG_DEV_USER";
            MyOraDB.Parameter_Name[8] = "ARG_CHECK";
            MyOraDB.Parameter_Name[9] = "ARG_P_STATUS";
            MyOraDB.Parameter_Name[10] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[11] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[12] = "OUT_CURSOR";

            //03. DATA TYPE 정의
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
            MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = arg_value[8];
            MyOraDB.Parameter_Values[9] = arg_value[9];           
            MyOraDB.Parameter_Values[10] = (cmb_Season_from.SelectedIndex ==0 )? "000000":arg_value[10];
            MyOraDB.Parameter_Values[11] = (cmb_Season_to.SelectedIndex == 0) ? "999999" : arg_value[11];
            MyOraDB.Parameter_Values[12] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }


        private void Display_grid(DataTable arg_list, COM.FSP arg_grid)
        {
            // Grid에 Data 입력
            for (int i = 0; i < arg_list.Rows.Count; i++)
            {
                arg_grid.Rows.Add();

                double value_sum = 0;

                for (int j = arg_grid.Cols.Fixed; j < arg_grid.Cols.Count; j++)
                {
                    if (j >= (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL && j <= (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE)                            
                    {
                        try
                        {
                            string value = (arg_list.Rows[i].ItemArray[j].ToString().Trim().Equals("")) ? "0" : arg_list.Rows[i].ItemArray[j].ToString().Trim();
                            value_sum += double.Parse(value);                            

                            arg_grid[arg_grid.Rows.Count - 1, j] = (value == "0") ? "" : double.Parse(value).ToString("#,##0.#");
                        }
                        catch
                        {
                            arg_grid[arg_grid.Rows.Count - 1, j] = arg_list.Rows[i].ItemArray[j].ToString();
                        }
                    }
                    else if (j >= (int)ClassLib.TBSXG_PROD_INV.IxRST_QTY && j <= (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY)
                    {
                        try
                        {
                            string value = (arg_list.Rows[i].ItemArray[j].ToString().Trim().Equals("")) ? "0" : arg_list.Rows[i].ItemArray[j].ToString().Trim();
                            value_sum += double.Parse(value);

                            arg_grid[arg_grid.Rows.Count - 1, j] = (value == "0") ? "0" : double.Parse(value).ToString("#,##0.#");
                        }
                        catch
                        {
                            arg_grid[arg_grid.Rows.Count - 1, j] = arg_list.Rows[i].ItemArray[j].ToString();
                        }
                    }
                    else
                    {
                        arg_grid[arg_grid.Rows.Count - 1, j] = arg_list.Rows[i].ItemArray[j].ToString();
                    }
                }                

                string status = arg_grid[arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxP_STATUS].ToString().Trim();
                //string check  = arg_grid[arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxCHECK].ToString().Trim().ToUpper();

                //if (check.Equals("TRUE"))
                //{
                //    double value_prod = double.Parse(arg_grid[arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY].ToString().Trim());

                //    if (!value_prod.Equals(value_sum))
                //        arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxCHECK, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxRST_QTY).StyleNew.ForeColor = Color.Red;
                //    else
                //        arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxCHECK, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxRST_QTY).StyleNew.ForeColor = Color.Black;
                //}
                //else
                //{
                //    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxCHECK, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxRST_QTY).StyleNew.ForeColor = Color.Black; 
                //}

                if (status.Equals("C"))
                {
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY).StyleNew.BackColor = Color.Aqua;
                }
                else
                {
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY).StyleNew.BackColor = Color.Yellow; 
                }
            }

            arg_grid.GetCellRange(arg_grid.Rows.Fixed, (int)ClassLib.TBSXG_PROD_INV.IxCHECK, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxRST_QTY).StyleNew.BackColor = Color.White;
            arg_grid.GetCellRange(arg_grid.Rows.Fixed, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL).StyleNew.BackColor = Color.WhiteSmoke;
            arg_grid.GetCellRange(arg_grid.Rows.Fixed, (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER).StyleNew.BackColor = Color.Snow;
            arg_grid.GetCellRange(arg_grid.Rows.Fixed, (int)ClassLib.TBSXG_PROD_INV.IxINV_TOTAL, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_TOTAL).StyleNew.BackColor = Color.WhiteSmoke;
            arg_grid.GetCellRange(arg_grid.Rows.Fixed, (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE).StyleNew.BackColor = Color.MintCream;
            arg_grid.GetCellRange(arg_grid.Rows.Fixed, (int)ClassLib.TBSXG_PROD_INV.IxPROBLEM_DESC, arg_grid.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_INV.IxPROBLEM_DESC).StyleNew.BackColor = Color.White;
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Check_Save())
                {
                    if (Save_Data())
                    {
                        fgrid_main.ClearFlags();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private bool Check_Save()
        {
            try
            {
                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    if (fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxDIV].ToString().Trim().Equals("U"))
                    {
                        int value_sum = 0;

                        //for (int j = (int)ClassLib.TBSXG_PROD_INV.IxINV_001; j <= (int)ClassLib.TBSXG_PROD_INV.IxINV_015; j++)
                        //{
                        //    string value = (fgrid_main[i, j].ToString().Trim().Equals("")) ? "0" : fgrid_main[i, j].ToString().Trim();
                        //    value_sum += int.Parse(value);
                        //}

                        //int value_prod = int.Parse(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY].ToString().Trim());


                        //if (!value_sum.Equals(0))
                        //{
                        //    if (!value_prod.Equals(value_sum))
                        //    {
                        //        MessageBox.Show("Worng Qty");
                        //        fgrid_main.Select(i, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY);

                        //        return false;
                        //    }
                        //}
                        //else
                        //{
                        //    string check = fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxCHECK].ToString().Trim().ToUpper();

                        //    if (check.Equals("TRUE"))
                        //    {
                        //        MessageBox.Show("Please Insert Qty");
                        //        fgrid_main.Select(i, (int)ClassLib.TBSXG_PROD_INV.IxPROD_QTY);

                        //        return false; 
                        //    }
                        //}
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Save_Data()
        {
            try
            {
                int col_ct = 26;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SXG_PROD_02.SAVE_SXG_PROD_INV_01";

                // 파라미터 이름 설정

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
                MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_INV_UPC";
                MyOraDB.Parameter_Name[6] = "ARG_INV_UPS";
                MyOraDB.Parameter_Name[7] = "ARG_INV_SILHOUETTE";
                MyOraDB.Parameter_Name[8] = "ARG_INV_LASTED_UPPER";
                MyOraDB.Parameter_Name[9] = "ARG_INV_NIKE";
                MyOraDB.Parameter_Name[10] = "ARG_INV_VJ";
                MyOraDB.Parameter_Name[11] = "ARG_INV_QD";
                MyOraDB.Parameter_Name[12] = "ARG_INV_5523";
                MyOraDB.Parameter_Name[13] = "ARG_INV_YIELD_COST";
                MyOraDB.Parameter_Name[14] = "ARG_INV_SHC_QA";
                MyOraDB.Parameter_Name[15] = "ARG_INV_SL_KEEP";
                MyOraDB.Parameter_Name[16] = "ARG_INV_DEV_KEEP";
                MyOraDB.Parameter_Name[17] = "ARG_INV_CE_TEST";
                MyOraDB.Parameter_Name[18] = "ARG_INV_PATTERN_TEST";
                MyOraDB.Parameter_Name[19] = "ARG_INV_PAD_PROD";
                MyOraDB.Parameter_Name[20] = "ARG_INV_OTHER";
                MyOraDB.Parameter_Name[21] = "ARG_INV_NIKE_MEET";
                MyOraDB.Parameter_Name[22] = "ARG_INV_DEFFECTIVE";
                MyOraDB.Parameter_Name[23] = "ARG_PROBLEM_DESC";
                MyOraDB.Parameter_Name[24] = "ARG_CHECK";
                MyOraDB.Parameter_Name[25] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                ArrayList vList = new ArrayList();

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    if (fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxDIV] == null || fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxDIV].ToString().Equals(""))
                        continue;

                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxFACTORY].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxLOT_NO].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxLOT_SEQ].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxDAY_SEQ].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxLINE_CD].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_UPS].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_SILHOUETTE].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER].ToString());                    
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_VJ].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_QD].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_5523].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_YIELD_COST].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_SHC_QA].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_SL_KEEP].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEV_KEEP].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_CE_TEST].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_PATTERN_TEST].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_PAD_PROD].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_OTHER].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE_MEET].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxPROBLEM_DESC].ToString());
                    vList.Add((fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxCHECK] == null || fgrid_main[i, (int)ClassLib.TBSXG_PROD_INV.IxCHECK].ToString().Trim().ToUpper() == "FALSE") ? "N" : "C");
                    vList.Add(COM.ComVar.This_User);
                }

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
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {

                string[] arg_value = new string[12];

                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dtp_from.Value.ToString("yyyyMMdd");
                arg_value[2] = dtp_to.Value.ToString("yyyyMMdd");
                arg_value[3] = txt_model.Text.Trim();
                arg_value[4] = txt_style_cd.Text.Trim();
                arg_value[5] = cmb_round.SelectedValue.ToString().Trim();
                arg_value[6] = txt_bom.Text.Trim();
                arg_value[7] = cmb_user.SelectedValue.ToString().Trim();
                arg_value[8] = cmb_check.SelectedValue.ToString();
                arg_value[9] = cmb_status.SelectedValue.ToString();
                arg_value[10] = (cmb_Season_from.SelectedIndex == 0) ? "000000" : cmb_Season_from.SelectedValue.ToString();
                arg_value[11] = (cmb_Season_to.SelectedIndex == 0) ? "999999" : cmb_Season_to.SelectedValue.ToString();




                //Pop_Inv_Print pop = new Pop_Inv_Print(arg_value);
                //pop.ShowDialog();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  


        }
        #endregion
        
        #region Grid Event
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_main.Selections;
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                
                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_main[sct_rows[i], sct_col] = fgrid_main[sct_row, sct_col].ToString();
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxDIV] = "U";

                    if(!sct_col.Equals((int)ClassLib.TBSXG_PROD_INV.IxCHECK))
                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxCHECK] = "TRUE";

                    if (sct_col >= (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC && sct_col <= (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER)
                    {
                        double inv_upc          = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC         ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC         ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_UPC         ].ToString().Trim());
                        double inv_ups          = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_UPS         ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_UPS         ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_UPS         ].ToString().Trim());
                        double inv_silhouette   = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SILHOUETTE  ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SILHOUETTE  ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SILHOUETTE  ].ToString().Trim());
                        double inv_lasted_upper = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_LASTED_UPPER].ToString().Trim());

                        double half_total = inv_upc + inv_ups + inv_silhouette + inv_lasted_upper;

                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL] = half_total.ToString("#,###.#");
                    }
                    else if (sct_col >= (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE && sct_col <= (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE)
                    {
                        double inv_nike         = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE        ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE        ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE        ].ToString().Trim());
                        double inv_vj           = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_VJ          ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_VJ          ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_VJ          ].ToString().Trim());
                        double inv_qd           = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_QD          ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_QD          ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_QD          ].ToString().Trim());
                        double inv_5523         = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_5523        ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_5523        ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_5523        ].ToString().Trim());
                        double inv_yield_cost   = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_YIELD_COST  ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_YIELD_COST  ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_YIELD_COST  ].ToString().Trim());
                        double inv_shc_qa       = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SHC_QA      ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SHC_QA      ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SHC_QA      ].ToString().Trim());
                        double inv_sl_keep      = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SL_KEEP     ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SL_KEEP     ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_SL_KEEP     ].ToString().Trim());
                        double inv_dev_keep     = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_DEV_KEEP    ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_DEV_KEEP    ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_DEV_KEEP    ].ToString().Trim());
                        double inv_ce_test      = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_CE_TEST     ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_CE_TEST     ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_CE_TEST     ].ToString().Trim());
                        double inv_pattern_test = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_PATTERN_TEST].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_PATTERN_TEST].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_PATTERN_TEST].ToString().Trim());
                        double inv_pad_prod     = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_PAD_PROD    ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_PAD_PROD    ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_PAD_PROD    ].ToString().Trim());
                        double inv_other        = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_OTHER       ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_OTHER       ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_OTHER       ].ToString().Trim());
                        double inv_nike_meet    = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE_MEET   ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE_MEET   ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_NIKE_MEET   ].ToString().Trim());
                        double inv_deffective   = double.Parse((fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE  ].Equals(null) || fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE  ].ToString().Trim().Equals("")) ? "0" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE  ].ToString().Trim());
                        
                        double total = inv_nike + inv_vj + inv_qd + inv_5523 + inv_yield_cost + inv_shc_qa + inv_sl_keep + inv_dev_keep + inv_ce_test + inv_pattern_test
                                       + inv_pad_prod + inv_other + inv_nike_meet + inv_deffective;

                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxINV_TOTAL] = total.ToString("#,###.#");
                    }
                }
            }
            catch
            {

            }            
        }
        #endregion
                
        #region Context Menu
        private void mnu_copy_Click(object sender, EventArgs e)
        {
            try
            {
                copy_row = fgrid_main.Selection.r1;

                mnu_paste.Enabled = true;
            }
            catch
            {
 
            }
        }

        private void mnu_paste_Click(object sender, EventArgs e)
        {
            try
            {
                if (copy_row >= fgrid_main.Rows.Fixed)
                {
                    int[] sct_rows = fgrid_main.Selections;

                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        for (int j = (int)ClassLib.TBSXG_PROD_INV.IxHALF_TOTAL; j <= (int)ClassLib.TBSXG_PROD_INV.IxINV_DEFFECTIVE; j++)
                        {
                            fgrid_main[sct_rows[i], j] = fgrid_main[copy_row, j].ToString().Trim();
                        }

                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxDIV] = "U";
                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXG_PROD_INV.IxCHECK] = "TRUE";
                    }                    
                }
            }
            catch
            {

            }
        }
        #endregion

       
        
    }
}

