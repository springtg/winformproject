using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexCDC.Purchase
{
    public partial class Form_Swatch_Book : COM.PCHWinForm.Form_Top
    {
        public Form_Swatch_Book()
        {
            InitializeComponent();
            
        }

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private bool first_flg = true;
        #endregion

        #region 공통메서드 
        private void Init_Form()
        {
            this.Text = "PCC_Swatch Book Manager";
            this.lbl_MainTitle.Text = "PCC_Swatch Book Manager";
            ClassLib.ComFunction.SetLangDic(this);
            
            #region ComboBox Setting
            first_flg = true;
            dpk_get_from.Value = DateTime.Now.AddDays(-7);
            dpk_get_to.Value = DateTime.Now;
            
            //Season Setting
            DataTable dt_ret = Select_Season_List();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_season, true, 0, 1, 0, 211);
            cmb_season.SelectedIndex = 0;

            dt_ret = Select_Purpose();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_purpose, true, 0, 1, 0, 211);
            cmb_purpose.SelectedIndex = 0;

            dt_ret = Select_Model();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_model, true, 0, 0, 0, 211);
            cmb_model.SelectedIndex = 0;

            cmb_mat_div.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_mat_div.ClearItems();
            cmb_mat_div.AddItemTitles("Code;Name");
            cmb_mat_div.ValueMember = "Code";
            cmb_mat_div.DisplayMember = "Name";
            cmb_mat_div.AddItem("N;Main Material");
            cmb_mat_div.AddItem("Y;Sub Material");
            cmb_mat_div.SelectedIndex = -1;
            cmb_mat_div.MaxDropDownItems = 10;
            cmb_mat_div.Splits[0].DisplayColumns[0].Width = 0;
            cmb_mat_div.Splits[0].DisplayColumns[1].Width = 211;
            cmb_mat_div.ExtendRightColumn = true;
            cmb_mat_div.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_mat_div.HScrollBar.Height = 0;

            cmb_mat_div.SelectedIndex = 0;

            first_flg = false;
            txt_bom.CharacterCasing    = CharacterCasing.Upper;
            txt_style.CharacterCasing  = CharacterCasing.Upper;
            txt_mat.CharacterCasing    = CharacterCasing.Upper;
            txt_color.CharacterCasing  = CharacterCasing.Upper;
            txt_vendor.CharacterCasing = CharacterCasing.Upper;
            #endregion

            #region Button Control 
            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Save.Enabled = false;
            #endregion

            #region Grid Setting
            flg_pur_order.Set_Grid_CDC("SXP_SWATCH", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_pur_order.Set_Action_Image(img_Action);
            flg_pur_order.Rows.Count = flg_pur_order.Rows.Fixed;
            #endregion            
        }

        private void Display_Data()
        {
            flg_pur_order.Rows.Count = flg_pur_order.Rows.Fixed;

            DataTable dt_list = Select_List();

            for (int i = 0; i < dt_list.Rows.Count; i++)
            {
                flg_pur_order.AddItem(dt_list.Rows[i].ItemArray, flg_pur_order.Rows.Count, 1);
            }
            flg_pur_order.AllowMerging = AllowMergingEnum.Free;


            for (int i = (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK; i < flg_pur_order.Cols.Count + 1; i++)
            {
                flg_pur_order.Cols[i].AllowMerging = false;
            }           
        }
        #endregion

        #region 이벤트처리

        #region Control Event
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();

                Init_Form();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dpk_get_from_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                DataTable dt_ret = Select_Season_List();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_season, true, 0, 1, 0, 211);
                cmb_season.SelectedIndex = 0;

            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dpk_get_to_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                DataTable dt_ret = Select_Season_List();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_season, true, 0, 1, 0, 211);
                cmb_season.SelectedIndex = 0;

            }
            catch
            {
                this.Cursor = Cursors.Default;
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

                if (first_flg)
                    return;

                DataTable dt_ret = Select_Purpose();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_purpose, true, 0, 1, 0, 211);
                cmb_purpose.SelectedIndex = 0;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_purpose_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                DataTable dt_ret = Select_Model();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_model, true, 0, 0, 0, 211);
                cmb_model.SelectedIndex = 0;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #endregion

        #region Button Event
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                Display_Data();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Pop_Pur_List_PrintOption pop_print = new Pop_Pur_List_PrintOption("SWATCH", this);
                pop_print.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {           

        }

        #endregion

        #region Grid Event
        private void flg_pur_order_Click(object sender, EventArgs e)
        {
            try
            {                
                int[] selectRow = flg_pur_order.Selections;
                int row = flg_pur_order.Selection.r1;
                int col = flg_pur_order.Selection.c1;
                if (col == (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK)
                {

                    if (flg_pur_order[row, (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK].ToString() == "true")
                    {
                        for (int i = 0; i < flg_pur_order.Selections.Length; i++)
                        {
                            flg_pur_order[selectRow[i], (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK] = "true";
                        }
                    }
                    if (flg_pur_order[row, (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK].ToString() == "false")
                    {
                        for (int i = 0; i < flg_pur_order.Selections.Length; i++)
                        {
                            flg_pur_order[selectRow[i], (int)ClassLib.TBSXP_SWATCH_BOX.IxCHECK] = "false";
                        }
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
        #endregion
        #endregion

        #region DB Connect
        private DataTable Select_Season_List()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SWATCH_SEASON";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";   
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;        
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_Purpose()
        {

            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SWATCH_PURPOSE";


            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_SEASON";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = "";


            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_Model()
        {

            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SWATCH_MODEL";


            MyOraDB.ReDim_Parameter(6);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_SEASON";
            MyOraDB.Parameter_Name[4] = "ARG_PURPOSE";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_purpose.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }       


        private DataTable Select_List()
        {

            MyOraDB.ReDim_Parameter(13);

            if(COM.ComVar.This_Factory.Equals("DS"))
                MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SWATCH_LIST";
            else
                MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SWATCH_LIST_QDVJ";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_SEASON";
            MyOraDB.Parameter_Name[4] = "ARG_PURPOSE";
            MyOraDB.Parameter_Name[5] = "ARG_MODEL";            
            MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[7] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[8] = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[9] = "ARG_COLOR";
            MyOraDB.Parameter_Name[10] = "ARG_VENDOR";
            MyOraDB.Parameter_Name[11] = "ARG_SUB_MAT";
            MyOraDB.Parameter_Name[12] = "OUT_CURSOR";

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

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Text.Trim().Replace("-","");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Text.Trim().Replace("-","");
            MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_season, "");
            MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_purpose, "");
            MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_model, "");            
            MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_TextBox(txt_style, "");
            MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_TextBox(txt_bom, "");
            MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_TextBox(txt_mat, "");
            MyOraDB.Parameter_Values[9] = ClassLib.ComFunction.Empty_TextBox(txt_color, "");
            MyOraDB.Parameter_Values[10] = ClassLib.ComFunction.Empty_TextBox(txt_vendor, "");
            MyOraDB.Parameter_Values[11] = ClassLib.ComFunction.Empty_Combo(cmb_mat_div, ""); ;
            MyOraDB.Parameter_Values[12] = "";


            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];             
        }
             
        #endregion

        private void Form_Swatch_Book_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);

                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
        }  
    }
}

