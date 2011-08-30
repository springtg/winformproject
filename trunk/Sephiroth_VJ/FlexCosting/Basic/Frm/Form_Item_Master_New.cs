using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FlexCosting.Basic
{
    public partial class Form_Item_Master_New : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();
        
        private Excel.Workbook workbook = null;
        private Excel.Worksheet worksheet = null;
        private Excel.Application application = null;

        DataSet _ExlDS = null;
        string[] _headers = new string[] { "MXS#", "PROD.LOCATION", "MATERIALNAME", "UNIT", "WIDTH", "UNITPRICE", "CURRENCY", "REASONOFEXTRACHARGE", "EXTRACHARGE", "DELIVERYTERM", "LOSS(%)", "MOQ" };
        int xls_sheetnum = 1, xls_sheetcol = 1, xls_maxrow = 10000;

        private int xls_MXS           = 1;
        private int xls_PRODLOCATION  = 2;
        private int xls_MATERIALNAME  = 3;
        private int xls_UNIT          = 4;
        private int xls_WIDTH         = 5;
        private int xls_UNITPRICE     = 6;
        private int xls_CURRENCY      = 7;
        private int xls_SPECIALOPTION = 8;
        private int xls_EXTRACHARGE   = 9;
        private int xls_DELIVERYTERM  = 10;
        private int xls_LOSS          = 11;
        private int xls_MOQ           = 12;

        private bool history_flg = false;
        private bool size_bottom_flg = false;

        private DataTable CopyDT = null;

        private string textbox_supp = "";
        private int row_supp;
        private string textbox_item = "";
        private int row_item;
        private int tabindel_curr = 0;
        #endregion               

        #region Constructor
        public Form_Item_Master_New()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Item_Master_New_Load(object sender, EventArgs e)
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
            try
            {                
                this.Text = "Material Master";
                this.lbl_MainTitle.Text = "Material Master";
                ClassLib.ComFunction.SetLangDic(this);
                history_flg = true;

                Init_Grid();
                Init_Control();
                Init_Toolbar();

                history_flg = false;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Init_Grid()
        {
            fgrid_cust_list.Set_Grid("SFX_CBD_M_CUST_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cust_list.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cust_list.Font = new Font("Verdana", 8);
            fgrid_cust_list.Tree.Column = (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME;

            fgrid_cust_list_all.Set_Grid("SFX_CBD_M_CUST_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cust_list_all.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cust_list_all.Font = new Font("Verdana", 8);
            fgrid_cust_list_all.Tree.Column = (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME;

            fgrid_mat.Set_Grid("SFX_CBD_M_MAT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_mat.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_mat.Font = new Font("Verdana", 8);
            fgrid_mat.Set_Action_Image(img_Action);
            fgrid_mat.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;

            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT,           fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ).StyleNew.BackColor = Color.FromArgb(-3181363);            
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE,     fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY,       fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      ).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE,   fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ).StyleNew.BackColor = Color.FromArgb(-3181363);            
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM,  fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM ).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS,           fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ,            fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN,      fgrid_mat.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN     ).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.FromArgb(-3181363);

            

            fgrid_history.Set_Grid("SFX_CBD_M_MAT_HISTORY", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_history.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_history.Font = new Font("Verdana", 8);
            fgrid_history.Set_Action_Image(img_Action);

            fgrid_reinforce.Set_Grid("SFX_CBD_M_REINFORCE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_reinforce.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_reinforce.Font = new Font("Verdana", 8);
            fgrid_reinforce.Set_Action_Image(img_Action);

            fgrid_rp.Set_Grid("SFX_CBD_M_MAT_CHARGE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_rp.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_rp.Font = new Font("Verdana", 8);
            fgrid_rp.Set_Action_Image(img_Action);
            fgrid_rp.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE,  fgrid_rp.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE).StyleNew.BackColor = Color.FromArgb(-3181363);
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE, fgrid_rp.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE).StyleNew.Font = new Font("Verdana", 8, FontStyle.Bold);
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS,    fgrid_rp.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS  ).StyleNew.BackColor = Color.FromArgb(-3181363);
            
            fgrid_cust.Set_Grid("SFX_CBD_M_CUST_INFO", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cust.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cust.Set_Action_Image(img_Action);
            fgrid_cust.Font = new Font("Verdana", 8);
            fgrid_cust.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            fgrid_cust.GetCellRange(fgrid_cust.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST, fgrid_cust.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);    
      
            fgrid_conv.Set_Grid("SFX_CBD_M_MAT_CONV", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_conv.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_conv.Font = new Font("Verdana", 8);
            fgrid_conv.Set_Action_Image(img_Action);
            fgrid_conv.GetCellRange(fgrid_conv.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI02, fgrid_conv.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13).StyleNew.BackColor = Color.FromArgb(-3181363);

            fgrid_file_01.Set_Grid("SFX_CBD_M_FILE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_file_01.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_file_01.Font = new Font("Verdana", 8);
            fgrid_file_01.Set_Action_Image(img_Action);
            fgrid_file_01.ExtendLastCol = false;
            fgrid_file_01.GetCellRange(fgrid_file_01.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK).StyleNew.BackColor = Color.FromArgb(-3181363);

            fgrid_file_02.Set_Grid("SFX_CBD_M_FILE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_file_02.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_file_02.Font = new Font("Verdana", 8);
            fgrid_file_02.Set_Action_Image(img_Action);
            fgrid_file_02.ExtendLastCol = false;
            fgrid_file_02.GetCellRange(fgrid_file_01.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK).StyleNew.BackColor = Color.FromArgb(-3181363);

            fgrid_file_03.Set_Grid("SFX_CBD_M_FILE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_file_03.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_file_03.Font = new Font("Verdana", 8);
            fgrid_file_03.Set_Action_Image(img_Action);
            fgrid_file_03.ExtendLastCol = false;
            fgrid_file_03.GetCellRange(fgrid_file_01.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK).StyleNew.BackColor = Color.FromArgb(-3181363);

            Set_CustList();
        }
        private void Init_Control()
        {
            fgrid_cust_list_all.Visible = false;

            pnl_detail_mat_bottom.Height = 0;

            pnl_grid_left.Width = fgrid_cust_list.Cols[0].Width
                                + fgrid_cust_list.Cols[(int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].Width
                                + fgrid_cust_list.Cols[(int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME].Width
                                + fgrid_cust_list.Cols[(int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_MODIFY_YMD].Width
                                + 15;

            mnu_mat_paste.Enabled = false;
            txt_supplier.CharacterCasing = CharacterCasing.Upper;
            txt_item.CharacterCasing = CharacterCasing.Upper;

            fgrid_cust_list.Visible = true;
            fgrid_cust_list_all.Visible = false;
            lbl_Item.Visible = true;
            txt_item.Visible = true;
            lbl_Item.Text = "Item";
        }
        private void Init_Toolbar()
        {            
            tbtn_Delete.Enabled  = false;            
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
        }
        private void Set_CustList()
        {
            DataSet vDS = SELECT_SFX_CBD_M_CUST_LIST(COM.ComVar.This_Factory);

            DataTable vDT = vDS.Tables["PKG_SFX_CBD_M_MAT.SELECT_SFX_CUST_LIST"];
            Cust_List_Use(vDT);

            vDT = vDS.Tables["PKG_SFX_CBD_M_MAT.SELECT_SFX_CUST_LIST_ALL"];
            Cust_List_All(vDT);        
        }
        private void Cust_List_Use(DataTable arg_dt)
        {            
            if (arg_dt != null && arg_dt.Rows.Count > 0)
            {
                fgrid_cust_list.ClearAll();

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {
                    int tree_level = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxLEV].ToString().Trim());
                    fgrid_cust_list.Rows.InsertNode(fgrid_cust_list.Rows.Count, tree_level);

                    int row = fgrid_cust_list.Rows.Count - 1;

                    for (int j = fgrid_cust_list.Cols.Fixed; j < fgrid_cust_list.Cols.Count; j++)
                    {
                        fgrid_cust_list[row, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                    }

                    if (tree_level.Equals(0))
                        fgrid_cust_list.Rows[row].StyleNew.BackColor = Color.LightYellow;
                    else if (tree_level.Equals(1))
                        fgrid_cust_list.Rows[row].StyleNew.BackColor = Color.White;
                }

                fgrid_cust_list.Select(fgrid_cust_list.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME);
            }
            arg_dt.Dispose(); 
        }
        private void Cust_List_All(DataTable arg_dt)
        {
            if (arg_dt != null && arg_dt.Rows.Count > 0)
            {
                fgrid_cust_list_all.ClearAll();

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {
                    int tree_level = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxLEV].ToString().Trim());
                    fgrid_cust_list_all.Rows.InsertNode(fgrid_cust_list_all.Rows.Count, tree_level);

                    int row = fgrid_cust_list_all.Rows.Count - 1;

                    for (int j = fgrid_cust_list_all.Cols.Fixed; j < fgrid_cust_list_all.Cols.Count; j++)
                    {
                        fgrid_cust_list_all[row, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                    }


                    string location = fgrid_cust_list_all[row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME].ToString().Trim();
                    string status = fgrid_cust_list_all[row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxSTATUS].ToString().Trim();

                    if (tree_level.Equals(0))
                        fgrid_cust_list_all.Rows[row].StyleNew.BackColor = Color.LightYellow;
                    else if (tree_level.Equals(1))
                    {
                        if (status.Equals("C"))
                            fgrid_cust_list_all.Rows[row].StyleNew.BackColor = Color.White;
                        else
                            fgrid_cust_list_all.Rows[row].StyleNew.BackColor = Color.WhiteSmoke;
                    }


                    if (location.EndsWith("*"))
                    {
                        fgrid_cust_list_all.Rows[row].Style.Font = new Font("Verdana", 8, FontStyle.Bold);
                        fgrid_cust_list_all.Rows[row].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        fgrid_cust_list_all.Rows[row].Style.Font = new Font("Verdana", 8);
                        fgrid_cust_list_all.Rows[row].Style.ForeColor = Color.Black;
                    }
                }

                fgrid_cust_list_all.Select(fgrid_cust_list_all.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD);
            }
            arg_dt.Dispose();
        }

        public DataSet SELECT_SFX_CBD_M_CUST_LIST(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CUST_LIST";

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
                
                return SELECT_SFX_CBD_M_CUST_LIST_ALL(arg_factory);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SELECT_SFX_CBD_M_CUST_LIST_ALL(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CUST_LIST_ALL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(false);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret;
            }
            catch (Exception ex)
            {
                throw ex;
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
            if (tab_detail.SelectedIndex.Equals(0))
            {
                if (chk_all_mat.Checked)
                {
                    Display_Material_All();
                }
                else
                {
                    Display_Material();
                }
            }
            else if (tab_detail.SelectedIndex.Equals(1))
            {
                Display_RP();
            }
            else if (tab_detail.SelectedIndex.Equals(2))
            {
                Display_Supplier();                
            }
            else if (tab_detail.SelectedIndex.Equals(3))
            {
                Display_Conversion(); 
            }
            else if (tab_detail.SelectedIndex.Equals(4))
            {
                Display_FIleGrid("001");
            }
            else if (tab_detail.SelectedIndex.Equals(5))
            {
                Display_FIleGrid("002");
            }
            else
            {
                Display_FIleGrid("003");
            }
        }
        private void Display_Material()
        {
            try
            {

                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                if (arg_grid.Rows.Count.Equals(arg_grid.Rows.Fixed))
                    return;

                history_flg = true;

                fgrid_mat.ClearAll();
                fgrid_history.ClearAll();
                fgrid_reinforce.ClearAll();
                
                int sct_row = arg_grid.Selection.r1;

                string[] arg_value = new string[4];

                arg_value[0] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY         ] == null) ? COM.ComVar.This_Factory : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim(); 
                arg_value[1] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV         ] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV].ToString().Trim();
                arg_value[2] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
                arg_value[3] = txt_item.Text.Trim();
                

                DataTable vDT = SELECT_SFX_MAT_LIST(arg_value);

                if (vDT != null && vDT.Rows.Count > 0)
                {
                    for (int i = 0; i < vDT.Rows.Count; i++)
                    {
                        fgrid_mat.Rows.Add();

                        for (int j = fgrid_mat.Cols.Fixed; j < fgrid_mat.Cols.Count; j++)
                        {
                            fgrid_mat[fgrid_mat.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                        }

                        string status = fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS].ToString().Trim();
                        
                        if (status.Equals("D"))
                        {
                            fgrid_mat.Rows[fgrid_mat.Rows.Count - 1].AllowEditing = false;

                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONNAME).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD).StyleNew.BackColor = Color.LightGray;
                        }
                        else
                        {
                            fgrid_mat.Rows[fgrid_mat.Rows.Count - 1].AllowEditing = true;

                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONNAME).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD).StyleNew.BackColor = Color.White;                            
                        }


                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.ForeColor = Color.Black;
                    }                    
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                history_flg = false;
            }
        }
        private void Display_Material_All()
        {
            try
            {

                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                if (arg_grid.Rows.Count.Equals(arg_grid.Rows.Fixed))
                    return;

                history_flg = true;

                fgrid_mat.ClearAll();
                fgrid_history.ClearAll();
                fgrid_reinforce.ClearAll();

                int sct_row = arg_grid.Selection.r1;

                string[] arg_value = new string[3];

                arg_value[0] = COM.ComVar.This_Factory;
                arg_value[1] = txt_supplier.Text.Trim();
                arg_value[2] = txt_item.Text.Trim();


                DataTable vDT = SELECT_SFX_MAT_LIST_ALL(arg_value);

                if (vDT != null && vDT.Rows.Count > 0)
                {
                    for (int i = 0; i < vDT.Rows.Count; i++)
                    {
                        fgrid_mat.Rows.Add();

                        for (int j = fgrid_mat.Cols.Fixed; j < fgrid_mat.Cols.Count; j++)
                        {
                            fgrid_mat[fgrid_mat.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                        }

                        string status = fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS].ToString().Trim();

                        if (status.Equals("D"))
                        {
                            fgrid_mat.Rows[fgrid_mat.Rows.Count - 1].AllowEditing = false;

                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONNAME).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN).StyleNew.BackColor = Color.LightGray;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD).StyleNew.BackColor = Color.LightGray;
                        }
                        else
                        {
                            fgrid_mat.Rows[fgrid_mat.Rows.Count - 1].AllowEditing = true;

                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONNAME).StyleNew.BackColor = Color.White;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN).StyleNew.BackColor = Color.FloralWhite;
                            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD).StyleNew.BackColor = Color.White;
                        }


                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                history_flg = false;
            }
        }
        private void Display_RP()
        {
            fgrid_rp.ClearAll();

            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
            int sct_row = arg_grid.Selection.r1;

            string[] arg_value = new string[3];
            arg_value[0] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY] == null) ? COM.ComVar.This_Factory : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim();
            arg_value[1] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

            DataTable vDT = SELECT_SFX_RP_LIST(arg_value);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    fgrid_rp.Rows.Add();

                    for (int j = fgrid_rp.Cols.Fixed; j < fgrid_rp.Cols.Count; j++)
                    {
                        fgrid_rp[fgrid_rp.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                    }

                    fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV,         fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE).StyleNew.BackColor = Color.White;
                    fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV,  fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD       ).StyleNew.BackColor = Color.White;
                    fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxSTATUS,      fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUPD_YMD         ).StyleNew.BackColor = Color.White;
                    fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS         ).StyleNew.BackColor = Color.FloralWhite;
                    
                    fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV,  fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD).StyleNew.ForeColor = Color.Black;
                    fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS).StyleNew.ForeColor = Color.Black;
                    
                }

                vDT.Dispose();
            }
        }
        private void Display_Supplier()
        {
            fgrid_cust.ClearAll();

            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

            int sct_row = arg_grid.Selection.r1;

            string[] arg_value = new string[4];
            arg_value[0] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY         ] == null) ? COM.ComVar.This_Factory : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim();
            arg_value[1] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV         ] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV].ToString().Trim();
            arg_value[2] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
            arg_value[3] = (rbt_supp_use.Checked) ? "C" : "";


            DataTable vDT = SELECT_SFX_CUST_INFO(arg_value);
            
            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    fgrid_cust.Rows.Add();

                    for (int j = fgrid_cust.Cols.Fixed; j < fgrid_cust.Cols.Count; j++)
                    {
                        fgrid_cust[fgrid_cust.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                    }

                    fgrid_cust.GetCellRange(fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV,          fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV).StyleNew.BackColor = Color.White;                    
                    fgrid_cust.GetCellRange(fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST, fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_cust.GetCellRange(fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS,       fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxUPD_YMD).StyleNew.BackColor = Color.White;


                    fgrid_cust.GetCellRange(fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST,       fgrid_cust.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS).StyleNew.ForeColor = Color.Black;
                }
                
                vDT.Dispose();                
            }
        }
        private void Display_Conversion()
        {
            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

            if (arg_grid.Rows.Count.Equals(arg_grid.Rows.Fixed))
                return;

            fgrid_conv.ClearAll();

            int sct_row = arg_grid.Selection.r1;

            string[] arg_value = new string[2];

            arg_value[0] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY] == null) ? COM.ComVar.This_Factory : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim();
            arg_value[1] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

            DataTable vDT = SELECT_SFX_MAT_CONV_LIST(arg_value);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    fgrid_conv.Rows.Add();

                    for (int j = fgrid_conv.Cols.Fixed; j < fgrid_conv.Cols.Count; j++)
                    {
                        fgrid_conv[fgrid_conv.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                    }

                    fgrid_conv.GetCellRange(fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV, fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI01).StyleNew.BackColor = Color.White;
                    fgrid_conv.GetCellRange(fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI02, fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_conv.GetCellRange(fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI14, fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxUPD_YMD).StyleNew.BackColor = Color.White;

                    fgrid_conv.GetCellRange(fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI02, fgrid_conv.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13).StyleNew.ForeColor = Color.Black;
                }
            }
        }
        private void Display_FIleGrid(string arg_file_div)
        {
            COM.FSP arg_grid = arg_file_div.Equals("001") ? fgrid_file_01 : arg_file_div.Equals("002") ? fgrid_file_02 : fgrid_file_03;
            arg_grid.ClearAll();

            
            string[] arg_value = new string[3];

            arg_value[0] = COM.ComVar.This_Factory;
            arg_value[1] = arg_file_div;
            arg_value[2] = txt_supplier.Text;

            DataTable vDT = SELECT_SFX_FILE(arg_value);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    arg_grid.Rows.Add();

                    for (int j = arg_grid.Cols.Fixed; j < arg_grid.Cols.Count; j++)
                    {
                        arg_grid[arg_grid.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                    }

                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxDIV, arg_grid.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD).StyleNew.BackColor = Color.White;
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK, arg_grid.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME).StyleNew.BackColor = Color.MintCream;
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxREMARKS, arg_grid.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_FILE.IxUPD_YMD).StyleNew.BackColor = Color.White;
                }
            }
        }

        public DataTable SELECT_SFX_MAT_LIST(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_DIV";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[3] = "ARG_MATERIAL";                
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
        public DataTable SELECT_SFX_MAT_LIST_ALL(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_LIST_ALL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MAT_NUMBER";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_MATERIAL_NAME";                
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SELECT_SFX_RP_LIST(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_RP_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
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
        public DataTable SELECT_SFX_CUST_INFO(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CUST_INFO";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_DIV";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[3] = "ARG_STATUS";
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
        public DataTable SELECT_SFX_MAT_CONV_LIST(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_CONV_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
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
        public DataTable SELECT_SFX_FILE(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_FILE_DIV";
                MyOraDB.Parameter_Name[2] = "ARG_FILE_NAME";
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
            catch (Exception ex)
            {
                throw ex;
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
            catch(Exception ex)
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
            if (tab_detail.SelectedIndex.Equals(0))
            {
                if(fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                    return;

                int sct_row = fgrid_mat.Selection.r1;
                int sct_col = fgrid_mat.Selection.c1;

                if (Check_Save_Material())
                {
                    if (SAVE_SFX_MAT())
                    {
                        MessageBox.Show("Save Completed");

                        if (chk_all_mat.Checked)
                        {
                            Display_Material_All();
                        }
                        else
                        {
                            Display_Material();
                        }

                        fgrid_mat.Select(sct_row, sct_col);
                        Display_Detail();
                    }
                        
                } 
            }
            else if (tab_detail.SelectedIndex.Equals(1))
            {
                if (Check_Save_RP())
                {
                    if (SAVE_SFX_RP())
                    {
                        MessageBox.Show("Save Completed");
                        Display_RP(); 
                    }                        
                }
            }
            else if (tab_detail.SelectedIndex.Equals(2))
            {
                if (SAVE_SFX_CUST())
                {
                    MessageBox.Show("Save Completed");
                    Display_Supplier(); 
                }
            }
            else
            {
                if (DELETE_SFX_MAT_CONV())
                {
                    if (SAVE_SFX_MAT_CONV())
                    {
                        if (UPDATE_SFX_CBD_ERR_LOG())
                        {
                            MessageBox.Show("Save Completed");
                            Display_Conversion();
                        }
                    }
                } 
            }
        }

        private bool Check_Save_Material()
        {
            try
            {
                for (int i = fgrid_mat.Rows.Fixed; i < fgrid_mat.Rows.Count; i++)
                {
                    string div                = (fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ] == null) ? "" : fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ].ToString().Trim();
                    string mxs_number         = (fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ] == null) ? "" : fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ].ToString().Trim();
                    string mxs_width          = (fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ] == null) ? "" : fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ].ToString().Trim();
                    string mxs_special_option = (fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION] == null) ? "" : fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION].ToString().Trim();

                    if (div.Equals(""))
                        continue;

                    if (mxs_number.Equals(""))
                    {
                        MessageBox.Show("Input Error : Mxs Number is empty");
                        tab_detail.SelectedIndex = 0;
                        fgrid_mat.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER);
                        return false;
                    }
                    if (mxs_width.Equals(""))
                    {
                        MessageBox.Show("Input Error : Mxs Width is empty");
                        tab_detail.SelectedIndex = 0;
                        fgrid_mat.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH);
                        return false;
                    }
                    if (mxs_special_option.Equals(""))
                    {
                        MessageBox.Show("Input Error : Reason of Extra Charge is empty");
                        tab_detail.SelectedIndex = 0;
                        fgrid_mat.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION);
                        return false;
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
        private bool Check_Save_RP()
        {
            try
            {
                for (int i = fgrid_rp.Rows.Fixed; i < fgrid_rp.Rows.Count; i++)
                {
                    string div                = (fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV             ] == null) ? "" : fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV             ].ToString().Trim();
                    string mxs_locationcode   = (fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE] == null) ? "" : fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE].ToString().Trim();
                    string charge_div         = (fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV      ] == null) ? "" : fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV      ].ToString().Trim();
                    string charge_cd          = (fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD       ] == null) ? "" : fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD       ].ToString().Trim();
                    string up_charge          = (fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE       ] == null) ? "" : fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE       ].ToString().Trim();

                    if (div.Equals(""))
                        continue;

                    if (mxs_locationcode.Equals(""))
                    {
                        MessageBox.Show("Input Error : Mxs Location Code is empty");
                        tab_detail.SelectedIndex = 1;
                        fgrid_rp.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE);
                        return false;
                    }
                    if (charge_div.Equals(""))
                    {
                        MessageBox.Show("Input Error : Charge Division is empty");
                        tab_detail.SelectedIndex = 1;
                        fgrid_rp.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV);
                        return false;
                    }
                    if (charge_cd.Equals(""))
                    {
                        MessageBox.Show("Input Error : Charge Code is empty");
                        tab_detail.SelectedIndex = 1;
                        fgrid_rp.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD);
                        return false;
                    }

                    try
                    {
                        double charge = double.Parse(up_charge);

                    }
                    catch
                    {
                        MessageBox.Show("Input Error : Up Charge is not number");
                        tab_detail.SelectedIndex = 1;
                        fgrid_rp.Select(i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE);
                        return false;
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
        
        private bool SAVE_SFX_MAT()
        {
            
            int vcnt = 23;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_MAT";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
            MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";             
            MyOraDB.Parameter_Name[ 2] = "ARG_MAT_NUMBER";          
            MyOraDB.Parameter_Name[ 3] = "ARG_MXS_NUMBER";          
            MyOraDB.Parameter_Name[ 4] = "ARG_MXS_SEQ";             
            MyOraDB.Parameter_Name[ 5] = "ARG_MXS_MATERIAL_NAME";    
            MyOraDB.Parameter_Name[ 6] = "ARG_NIKE_MAT_NAME";       
            MyOraDB.Parameter_Name[ 7] = "ARG_MXS_UNIT";            
            MyOraDB.Parameter_Name[ 8] = "ARG_MXS_WIDTH";           
            MyOraDB.Parameter_Name[ 9] = "ARG_MXS_UNIT_PRICE";      
            MyOraDB.Parameter_Name[10] = "ARG_MXS_CURRENCY";        
            MyOraDB.Parameter_Name[11] = "ARG_MXS_EXTRA_CHARGE";    
            MyOraDB.Parameter_Name[12] = "ARG_MXS_SPECIAL_OPTION";  
            MyOraDB.Parameter_Name[13] = "ARG_MXS_DELIVERY_TERM";   
            MyOraDB.Parameter_Name[14] = "ARG_MXS_LOSS";            
            MyOraDB.Parameter_Name[15] = "ARG_MXS_MOQ";             
            MyOraDB.Parameter_Name[16] = "ARG_MXS_PROD_LOCATION";   
            MyOraDB.Parameter_Name[17] = "ARG_MXS_LOCATIONCODE";    
            MyOraDB.Parameter_Name[18] = "ARG_MXS_SINGLE_YN";       
            MyOraDB.Parameter_Name[19] = "ARG_STATUS";              
            MyOraDB.Parameter_Name[20] = "ARG_REMARKS";             
            MyOraDB.Parameter_Name[21] = "ARG_MXS_CURRENT_YN";      
            MyOraDB.Parameter_Name[22] = "ARG_UPD_USER";            

              

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_mat.Rows.Fixed; i < fgrid_mat.Rows.Count; i++)
            {
                string _div = fgrid_mat[i, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_mat.Rows.Fixed; row < fgrid_mat.Rows.Count; row++)
            {
                string _div = fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ] == null) ? "" : fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ] == null) ? "" : fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ] == null) ? "" : fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ] == null) ? "" : fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ] == null) ? "" : fgrid_mat[row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME );   
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME     );       
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION);  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           );  
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION );
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE  );                
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN     );
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            );        
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS           );       
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_MAT(row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    );
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);                
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;            
        }
        private bool SAVE_SFX_RP()
        {
            
            int vcnt = 10;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_RP";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_DIVISION";        
            MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_MXS_LOCATIONCODE";
            MyOraDB.Parameter_Name[3] = "ARG_CHARGE_DIV";
            MyOraDB.Parameter_Name[4] = "ARG_CHARGE_CD";
            MyOraDB.Parameter_Name[5] = "ARG_CHARGE_DESC";
            MyOraDB.Parameter_Name[6] = "ARG_UP_CHARGE";
            MyOraDB.Parameter_Name[7] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[8] = "ARG_STATUS";
            MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";
           
            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_rp.Rows.Fixed; i < fgrid_rp.Rows.Count; i++)
            {
                string _div = fgrid_rp[i, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_rp.Rows.Fixed; row < fgrid_rp.Rows.Count; row++)
            {
                string _div = fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV             ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV             ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxFACTORY         ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxFACTORY         ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV      ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV      ].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD       ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD       ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC     ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE       ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE       ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS         ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS         ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxSTATUS          ] == null) ? "" : fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxSTATUS          ].ToString().Trim();               
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);                
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;            
        }
        private bool SAVE_SFX_CUST()
        {
            
            int vcnt = 16;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_CUST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";          
            MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[ 2] = "ARG_MXS_LOCATIONCODE";
            MyOraDB.Parameter_Name[ 3] = "ARG_MXS_LOCATIONNAME_K";
            MyOraDB.Parameter_Name[ 4] = "ARG_MXS_LOCATIONNAME_E";
            MyOraDB.Parameter_Name[ 5] = "ARG_MXS_LOCATION_SEQ";
            MyOraDB.Parameter_Name[ 6] = "ARG_MXS_DIV";
            MyOraDB.Parameter_Name[ 7] = "ARG_MXS_MAN_CUST";
            MyOraDB.Parameter_Name[ 8] = "ARG_MXS_PHONE";
            MyOraDB.Parameter_Name[ 9] = "ARG_MXS_FAX";
            MyOraDB.Parameter_Name[10] = "ARG_MXS_HEADPHONE";
            MyOraDB.Parameter_Name[11] = "ARG_MXS_EMAIL";
            MyOraDB.Parameter_Name[12] = "ARG_MXS_COMMENTS";
            MyOraDB.Parameter_Name[13] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[14] = "ARG_STATUS";
            MyOraDB.Parameter_Name[15] = "ARG_UPD_USER";
          
            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_cust.Rows.Fixed; i < fgrid_cust.Rows.Count; i++)
            {
                string _div = fgrid_cust[i, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_cust.Rows.Fixed; row < fgrid_cust.Rows.Count; row++)
            {
                string _div = fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV               ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV               ].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY           ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE  ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATION_SEQ  ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATION_SEQ  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV           ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST      ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_PHONE         ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_PHONE         ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_FAX           ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_FAX           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_HEADPHONE     ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_HEADPHONE     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_EMAIL         ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_EMAIL         ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_COMMENTS      ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_COMMENTS      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS           ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS           ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS            ] == null) ? "" : fgrid_cust[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS            ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);                
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;            
        }
        private bool DELETE_SFX_MAT_CONV()
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.DELETE_SFX_MAT_CONV";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
                MyOraDB.Parameter_Values[1] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

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
        private bool SAVE_SFX_MAT_CONV()
        {
            try
            {
                int vcnt = 37;
                MyOraDB.ReDim_Parameter(vcnt);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_MAT_CONV";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_CHK";
                MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[3] = "ARG_MXS_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[5] = "ARG_I01";
                MyOraDB.Parameter_Name[6] = "ARG_I02";
                MyOraDB.Parameter_Name[7] = "ARG_I03";
                MyOraDB.Parameter_Name[8] = "ARG_I04";
                MyOraDB.Parameter_Name[9] = "ARG_I05";
                MyOraDB.Parameter_Name[10] = "ARG_I06";
                MyOraDB.Parameter_Name[11] = "ARG_I07";
                MyOraDB.Parameter_Name[12] = "ARG_I08";
                MyOraDB.Parameter_Name[13] = "ARG_I09";
                MyOraDB.Parameter_Name[14] = "ARG_I10";
                MyOraDB.Parameter_Name[15] = "ARG_I11";
                MyOraDB.Parameter_Name[16] = "ARG_I12";
                MyOraDB.Parameter_Name[17] = "ARG_I13";
                MyOraDB.Parameter_Name[18] = "ARG_I14";
                MyOraDB.Parameter_Name[19] = "ARG_I15";
                MyOraDB.Parameter_Name[20] = "ARG_I16";
                MyOraDB.Parameter_Name[21] = "ARG_I17";
                MyOraDB.Parameter_Name[22] = "ARG_I18";
                MyOraDB.Parameter_Name[23] = "ARG_I19";
                MyOraDB.Parameter_Name[24] = "ARG_I20";
                MyOraDB.Parameter_Name[25] = "ARG_I21";
                MyOraDB.Parameter_Name[26] = "ARG_I22";
                MyOraDB.Parameter_Name[27] = "ARG_I23";
                MyOraDB.Parameter_Name[28] = "ARG_I24";
                MyOraDB.Parameter_Name[29] = "ARG_I25";
                MyOraDB.Parameter_Name[30] = "ARG_I26";
                MyOraDB.Parameter_Name[31] = "ARG_I27";
                MyOraDB.Parameter_Name[32] = "ARG_I28";
                MyOraDB.Parameter_Name[33] = "ARG_I29";
                MyOraDB.Parameter_Name[34] = "ARG_I30";
                MyOraDB.Parameter_Name[35] = "ARG_STATUS";
                MyOraDB.Parameter_Name[36] = "ARG_UPD_USER";

                for (int para = 0; para < vcnt; para++)
                {
                    MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
                }
                
                vcnt = vcnt * fgrid_conv.Rows.Count;
                MyOraDB.Parameter_Values = new string[vcnt];
                vcnt = 0;

                for (int row = fgrid_conv.Rows.Fixed; row < fgrid_conv.Rows.Count; row++)
                {                    
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV] == null) ? "" : fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV].ToString().Trim();
                    string chk_yn = (fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxCHK] == null) ? "FALSE" : fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxCHK].ToString().Trim().ToUpper();
                    MyOraDB.Parameter_Values[vcnt++] = (chk_yn.Equals("TRUE")) ? "Y" : "N";
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxFACTORY] == null) ? "" : fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxFACTORY].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_SEQ] == null) ? "" : fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_SEQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE] == null) ? "" : fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI01); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI02); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI03); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI04); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI05); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI06); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI07); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI08); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI09); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI10); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI11); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI12); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI14); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI15); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI16); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI17); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI18); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI19); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI20); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI21); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI22); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI23); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI24); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI25); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI26); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI27); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI28); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI29); 
                    MyOraDB.Parameter_Values[vcnt++] = GET_GRID_VALUE_CONV(row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI30); 
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxSTATUS] == null) ? "" : fgrid_conv[row, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxSTATUS].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
                }

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
        private bool UPDATE_SFX_CBD_ERR_LOG()
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_BATCH_01.UPDATE_SFX_CBD_ERR_LOG";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

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

        private string GET_GRID_VALUE_MAT(int arg_row, int arg_col)
        {
            try
            {
                string _return = (fgrid_mat[arg_row, arg_col] == null) ? "" : fgrid_mat[arg_row, arg_col].ToString().Trim();


                if (arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE) ||
                    arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE) ||
                    arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS))
                {
                    if (_return.Equals(""))
                        _return = "0";
                }
                else if (arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN))
                {
                    _return = (_return.ToUpper().Equals("TRUE")) ? "Y" : "N";
                }

                return _return;
            }
            catch
            {
                return "";
            }
        }
        private string GET_GRID_VALUE_CONV(int arg_row, int arg_col)
        {
            try
            {
                string _return = (fgrid_conv[arg_row, arg_col] == null) ? "" : fgrid_conv[arg_row, arg_col].ToString().Trim();


                if (arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI06) ||
                    arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI09) ||
                    arg_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI11) )
                {
                    if (_return.Equals(""))
                        _return = "0";
                }

                return _return;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Print_Data();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void Print_Data()
        {
            if (fgrid_conv.Rows.Count.Equals(fgrid_conv.Rows.Fixed))
                return;

            string mrd_Filename = Application.StartupPath + @"\\Report\Costing_ErrLog_List.mrd";

            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

            int sct_row = arg_grid.Selection.r1;

            string[] arg_value = new string[2];
            arg_value[0] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY] == null) ? COM.ComVar.This_Factory : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim();
            arg_value[1] = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

            string sPara = " /rp " + "[" + arg_value[0] + "]" + " [" + arg_value[1] + "]";

            FlexCosting.Report.Form_RdViewer report = new FlexCosting.Report.Form_RdViewer(mrd_Filename, sPara);
            report.ShowDialog(); 
        }
        #endregion

        #region TabControl Event
        private void tab_detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TabControl_Event();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }
        }

        private void tab_detail_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {                
                if (!TabControl_GridCheck())
                {
                    e.Cancel = true;                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }
        }
                
        private void TabControl_Event()
        {            
            tabindel_curr = tab_detail.SelectedIndex;

            if (tab_detail.SelectedIndex.Equals(0))
            {                
                lbl_Item.Visible = true;
                txt_item.Visible = true;
                lbl_supplier.Text = "Supplier";
                lbl_Item.Text = "Item";

            }
            else if (tab_detail.SelectedIndex.Equals(1))
            {                
                lbl_Item.Visible = true;
                txt_item.Visible = true;
                lbl_supplier.Text = "Supplier";
                lbl_Item.Text = "R/P Code";                
            }
            else if (tab_detail.SelectedIndex.Equals(2))
            {
                lbl_Item.Visible = false;
                txt_item.Visible = false;
                lbl_supplier.Text = "Supplier";
            }
            else if (tab_detail.SelectedIndex.Equals(3))
            {
                lbl_Item.Visible = true;
                txt_item.Visible = true;
                lbl_supplier.Text = "Supplier";
                lbl_Item.Text = "Item";
            }
            else
            {
                lbl_Item.Visible = false;
                txt_item.Visible = false;

                lbl_supplier.Text = "File Name";                
            }
        }

        private bool TabControl_GridCheck()
        {
            try
            {
                COM.FSP arg_grid;

                if (tabindel_curr.Equals(0))
                {
                    if (chk_all_mat.Checked)
                    {
                        MessageBox.Show("Material All Search is checked.\r\n\r\nPlease uncheck this checkbox.");
                        chk_all_mat.Focus();
                        chk_all_mat.Select();
                        return false;
                    }

                    arg_grid = fgrid_mat;
                }
                else if (tabindel_curr.Equals(1))
                {
                    arg_grid = fgrid_rp;
                }
                else if (tabindel_curr.Equals(2))
                {
                    arg_grid = fgrid_cust;
                }
                else
                {
                    arg_grid = fgrid_conv;
                }

                for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                {
                    string div = (arg_grid[i, 0] == null) ? "" : arg_grid[i, 0].ToString().Trim();

                    if (!div.Equals(""))
                    {
                        MessageBox.Show("Update data is remained.\r\n\r\nPlease save first.");
                        arg_grid.Select(i, 0);
                        return false;
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
        #endregion

        #region Grid Event

        #region Cust List
        private void fgrid_cust_list_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void fgrid_cust_list_all_MouseDoubleClick(object sender, MouseEventArgs e)
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

        #region Material
        private void fgrid_mat_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    GridSizeChange();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void fgrid_mat_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                string div = fgrid_mat[e.Row, 0] == null ? "" : fgrid_mat[e.Row, 0].ToString();

                if (e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER ||
                    e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH ||
                    e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION)
                {
                    if (div.Equals("I"))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    GridBeforeEdit(fgrid_mat);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void fgrid_mat_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {                
                int[] sct_rows = fgrid_mat.Selections;
                int sct_col = fgrid_mat.Selection.c1;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (sct_col.Equals((int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER))
                    {
                        string mxs_number = fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER].ToString().Trim();
                        string loc_code = fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE].ToString().Trim();

                        fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER] = mxs_number + "." + loc_code;
                    }
                }

                GridAfterEdit(fgrid_mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void fgrid_mat_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            try
            {
                if (history_flg)
                    return;

                Display_Detail();
                GridMat_ContextMenu();                 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }
        private void fgrid_mat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                GridSizeChange();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void fgrid_history_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    GridSizeChange();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void fgrid_reinforce_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    GridSizeChange();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Display_Detail()
        {
            if(fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            if (tab_detail_bottom.SelectedIndex.Equals(0))
                Display_Mat_History();
            else
                Display_Mat_Reinforce();
        }
        private void Display_Mat_History()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            int sct_row = fgrid_mat.Selection.r1;

            if (sct_row < fgrid_mat.Rows.Fixed)
                return;

            fgrid_history.ClearAll();



            string[] arg_value = new string[5];

            arg_value[0] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY].ToString().Trim();
            arg_value[1] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER].ToString().Trim();
            arg_value[2] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH].ToString().Trim();
            arg_value[3] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION].ToString().Trim();
            arg_value[4] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ].ToString().Trim();

            DataTable vDT = SELECT_SFX_MAT_HISTORY(arg_value);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    fgrid_history.Rows.Add();

                    for (int j = fgrid_history.Cols.Fixed; j < fgrid_history.Cols.Count; j++)
                    {
                        fgrid_history[fgrid_history.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString().Trim();

                        if(i.Equals(0))
                            fgrid_history.Rows[fgrid_history.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        else
                            fgrid_history.Rows[fgrid_history.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;

                    }
                }
            }
        }
        private void Display_Mat_Reinforce()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            int sct_row = fgrid_mat.Selection.r1;

            if (sct_row < fgrid_mat.Rows.Fixed)
                return;

            fgrid_reinforce.ClearAll();



            string[] arg_value = new string[3];

            arg_value[0] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY].ToString();
            arg_value[1] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER].ToString();
            arg_value[2] = fgrid_mat[sct_row, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME].ToString();

            DataTable vDT = SELECT_SFX_MAT_REINFORCE(arg_value);
            
            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    fgrid_reinforce.Rows.Add();

                    for (int j = fgrid_reinforce.Cols.Fixed; j < fgrid_reinforce.Cols.Count; j++)
                    {
                        fgrid_reinforce[fgrid_reinforce.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString().Trim();
                    }
                }
            }
        }
        private void GridMat_ContextMenu()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;


            string status = fgrid_mat[fgrid_mat.Selection.r1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS].ToString().Trim();

            if (status.Equals("D"))
            {
                mnu_mat_drop.Enabled = false;
                mnu_mat_release.Enabled = true;
            }
            else
            {
                mnu_mat_drop.Enabled = true;
                mnu_mat_release.Enabled = false; 
            }
        }

        private DataTable SELECT_SFX_MAT_HISTORY(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_HISTORY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_WIDTH";
                MyOraDB.Parameter_Name[3] = "ARG_MXS_SPECIAL_OPTION";
                MyOraDB.Parameter_Name[4] = "ARG_MXS_SEQ";
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
        private DataTable SELECT_SFX_MAT_REINFORCE(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_MAT_REINFORCE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MAT_NUMBER";
                MyOraDB.Parameter_Name[2] = "ARG_MAT_NAME";
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region R/P
        private void fgrid_rp_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                string div = fgrid_rp[e.Row, 0] == null ? "" : fgrid_rp[e.Row, 0].ToString();

                if (e.Col == (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV ||
                    e.Col == (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD)
                {
                    if (div.Equals("I"))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    GridBeforeEdit(fgrid_rp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }           
        }

        private void fgrid_rp_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                GridAfterEdit(fgrid_rp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        #endregion

        #region Supplier
        private void fgrid_cust_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                GridBeforeEdit(fgrid_cust);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void fgrid_cust_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                GridAfterEdit(fgrid_cust);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }
        #endregion

        #region Conversion
        private void fgrid_conv_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                GridBeforeEdit(fgrid_conv);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void fgrid_conv_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                GridAfterEdit(fgrid_conv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        #endregion

        #region File Grid
        private void fgrid_file_01_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                File_Open_Grid(fgrid_file_01);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }

        private void fgrid_file_02_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                File_Open_Grid(fgrid_file_02);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fgrid_file_03_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                File_Open_Grid(fgrid_file_03);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void File_Open_Grid(COM.FSP arg_grid)
        {
            string save_path = "C:\\Program Files\\PCC_Sephiroth\\sch_file";            

            DirectoryInfo dr = new DirectoryInfo(save_path);

            if (!dr.Exists)
            {
                dr.Create();
            }

            string factory   = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_FILE.IxFACTORY].ToString().Trim();
            string file_cd   = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD].ToString().Trim();
            string file_name = int.Parse(arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD].ToString()).ToString() + "_" + arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME].ToString().Trim().Replace("/", "_");
            string file_path = save_path + "\\" + file_name;
            string file_type = file_name.Substring(file_name.LastIndexOf(".") + 1, 3).Trim().ToUpper();

            try
            {
                File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));

                ProcessStartInfo ps = new ProcessStartInfo();
                ps.WorkingDirectory = save_path;
                ps.FileName = file_name;

                try
                {
                    Process.Start(ps);
                }
                catch
                {
                    MessageBox.Show(file_type + " file cannot working.\r\n\r\nPlease install " + file_type + " viewer program in this computer.");                    
                }
            }
            catch
            {                
                MessageBox.Show(file_name + "\r\n\r\nThis File have a problem,\r\n\r\nPlease ask System.");                
            }

        }
        #endregion

        private void GridAfterEdit(COM.FSP arg_grid)
        {
            int sct_row = arg_grid.Selection.r1;
            int sct_col = arg_grid.Selection.c1;
            int[] sct_rows = arg_grid.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {                
                arg_grid[sct_rows[i], sct_col] = arg_grid[sct_row, sct_col].ToString().Trim().ToUpper();

                string div = (arg_grid[sct_rows[i], 0] == null) ? "" : arg_grid[sct_rows[i], 0].ToString().Trim();

                if(!div.Equals("I"))
                    arg_grid.Update_Row(sct_rows[i]); 
            }            
        }
        private void GridBeforeEdit(COM.FSP arg_grid)
        {
            if ((arg_grid.Rows.Fixed > 0) && (arg_grid.Row >= arg_grid.Rows.Fixed))
                arg_grid.Buffer_CellData = (arg_grid[arg_grid.Row, arg_grid.Col] == null) ? "" : arg_grid[arg_grid.Row, arg_grid.Col].ToString();
        }
        private void GridSizeChange()
        {
            if (size_bottom_flg)
            {
                pnl_detail_mat_bottom.Height = 0;
                size_bottom_flg = false;
            }
            else
            {
                pnl_detail_mat_bottom.Height = 250;
                size_bottom_flg = true;
            } 
        }
        #endregion

        #region ContextMenu Event

        #region Cust List Grid
        private void mnu_level_01_Click(object sender, EventArgs e)
        {
            try
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
                arg_grid.Tree.Show(0);                
            }
            catch
            {
 
            }
        }
        private void mnu_level_02_Click(object sender, EventArgs e)
        {
            try
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
                arg_grid.Tree.Show(1);                
            }
            catch
            {

            }
        }

        private void mnu_letft_addcust_Click(object sender, EventArgs e)
        {
            try
            {
                Cust_InsertData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void mnu_left_update_Click(object sender, EventArgs e)
        {
            try
            {
                Cust_UpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void mnu_left_use_yn_Click(object sender, EventArgs e)
        {
            try
            {
                Cust_UseYn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Cust_InsertData()
        {
            int row = fgrid_cust_list.TopRow;
            int sct_row = fgrid_cust_list.Selection.r1;
            int sct_col = fgrid_cust_list.Selection.c1;

            int row_all = fgrid_cust_list_all.TopRow;
            int sct_row_all = fgrid_cust_list_all.Selection.r1;
            int sct_col_all = fgrid_cust_list_all.Selection.c1;

            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
            int sct_col_curr = (rbt_supp_use.Checked) ? fgrid_cust_list.Selection.c1 : fgrid_cust_list_all.Selection.c1;

            string arg_mxs_div = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV].ToString().Trim();
            string arg_status = (rbt_supp_use.Checked) ? "C" : "N";

            FlexCosting.Basic.Pop.Pop_Item_Master_Add_Cust vPop = new FlexCosting.Basic.Pop.Pop_Item_Master_Add_Cust("I", arg_mxs_div, arg_status);

            if (vPop.ShowDialog() == DialogResult.OK)
            {
                Set_CustList();

                fgrid_cust_list.TopRow = row;
                fgrid_cust_list.Select(sct_row, sct_col);

                fgrid_cust_list_all.TopRow = row_all;
                fgrid_cust_list_all.Select(sct_row_all, sct_col_all);

                for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                {
                    string chk_loc_code = (arg_grid[i, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[i, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                    if (chk_loc_code.Equals(vPop._loc_code))
                    {
                        arg_grid.TopRow = i;
                        arg_grid.Select(i, sct_col_curr);
                    }
                }

                Display_Supplier();
            }
        }

        private void Cust_UpdateData()
        {
            int row = fgrid_cust_list.TopRow;
            int sct_row = fgrid_cust_list.Selection.r1;
            int sct_col = fgrid_cust_list.Selection.c1;

            int row_all = fgrid_cust_list_all.TopRow;
            int sct_row_all = fgrid_cust_list_all.Selection.r1;
            int sct_col_all = fgrid_cust_list_all.Selection.c1;

            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
            int sct_row_curr = (rbt_supp_use.Checked) ? fgrid_cust_list.Selection.r1 : fgrid_cust_list_all.Selection.r1;
            int sct_col_curr = (rbt_supp_use.Checked) ? fgrid_cust_list.Selection.c1 : fgrid_cust_list_all.Selection.c1;
            
            string arg_cust = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

            if (arg_cust.Equals(""))
            {
                MessageBox.Show("Please select Supplier");
                return;
            }

            string[] arg_value = new string[6];
            arg_value[0] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY           ] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY           ].ToString().Trim();
            arg_value[1] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD  ] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD  ].ToString().Trim();
            arg_value[2] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME  ] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME  ].ToString().Trim();
            arg_value[3] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME_E] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME_E].ToString().Trim();
            arg_value[4] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV           ] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV           ].ToString().Trim();
            arg_value[5] = (arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxSTATUS            ] == null) ? "" : arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxSTATUS            ].ToString().Trim();

            FlexCosting.Basic.Pop.Pop_Item_Master_Add_Cust vPop = new FlexCosting.Basic.Pop.Pop_Item_Master_Add_Cust("U", arg_value);

            if (vPop.ShowDialog() == DialogResult.OK)
            {
                Set_CustList();

                fgrid_cust_list.TopRow = row;
                fgrid_cust_list.Select(sct_row, sct_col);

                fgrid_cust_list_all.TopRow = row_all;
                fgrid_cust_list_all.Select(sct_row_all, sct_col_all);

                string loc_code = (arg_grid[sct_row_curr, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row_curr, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
                if (!vPop._loc_code.Equals(loc_code))
                {
                    for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                    {
                        string chk_loc_code = (arg_grid[i, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[i, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                        if (chk_loc_code.Equals(vPop._loc_code))
                        {
                            arg_grid.TopRow = i;
                            arg_grid.Select(i, sct_col_curr); 
                        }
                    }
                }
                

                Display_Supplier();
            }
        }

        private void Cust_UseYn()
        {
            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;


            int[] sct_rows = arg_grid.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                string _level = arg_grid[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxLEV].ToString().Trim();

                if (_level.Equals("1"))
                {
                    string _status = (arg_grid[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxSTATUS].ToString().Trim().Equals("C")) ? "N" : "C";
                    string[] arg_value = new string[4];

                    arg_value[0] = arg_grid[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim();
                    arg_value[1] = arg_grid[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
                    arg_value[2] = _status;
                    arg_value[3] = COM.ComVar.This_User;

                    if (SAVE_SFX_CUST_USE_YN(arg_value))
                    {
                        if (rbt_supp_use.Checked)
                        {
                            for (int row = fgrid_cust_list_all.Rows.Fixed; row < fgrid_cust_list_all.Rows.Count; row++)
                            {
                                string loc_code = fgrid_cust_list_all[row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                                if (arg_value[1].Equals(loc_code))
                                {
                                    fgrid_cust_list_all[row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxSTATUS] = _status;

                                    if (_status.Equals("C"))
                                        fgrid_cust_list_all.Rows[row].StyleNew.BackColor = Color.White;
                                    else
                                        fgrid_cust_list_all.Rows[row].StyleNew.BackColor = Color.WhiteSmoke;

                                    break;
                                }
                            }
                        }
                        else
                        {
                            arg_grid[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxSTATUS] = _status;

                            if (_status.Equals("C"))
                                arg_grid.Rows[sct_rows[i]].StyleNew.BackColor = Color.White;
                            else
                                arg_grid.Rows[sct_rows[i]].StyleNew.BackColor = Color.WhiteSmoke;
                        }

                    }
                }
            }

            DataSet vDS = SELECT_SFX_CBD_M_CUST_LIST(COM.ComVar.This_Factory);
            DataTable vDT = vDS.Tables["PKG_SFX_CBD_M_MAT.SELECT_SFX_CUST_LIST"];
            Cust_List_Use(vDT);

        }

        public bool SAVE_SFX_CUST_USE_YN(string[] arg_value)
        {
            try
            {

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_CUST_USE_YN";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "ARG_STATUS";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0]  = arg_value[0];
                MyOraDB.Parameter_Values[1]  = arg_value[1]; 
                MyOraDB.Parameter_Values[2]  = arg_value[2];
                MyOraDB.Parameter_Values[3]  = arg_value[3];
                
                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Material Grid
        private void mnu_mat_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Mat_AddData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_mat_drop_Click(object sender, EventArgs e)
        {
            try
            {
                Mat_DropData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_mat_release_Click(object sender, EventArgs e)
        {
            try
            {
                Mat_ReleaseData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }        

        private void mnu_mat_copy_Click(object sender, EventArgs e)
        {
            try
            {
                Mat_CopyData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_mat_paste_Click(object sender, EventArgs e)
        {
            try
            {
                Mat_PasteData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_reason_Click(object sender, EventArgs e)
        {
            try
            {
                Mat_UpdateReason();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void Mat_AddData()
        {
            history_flg = true;

            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
            int lev = arg_grid.Rows[arg_grid.Selection.r1].Node.Level;

            if (lev.Equals(0))
            {
                MessageBox.Show("Please select Supplier");
                return;
            }

            if (!fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
            {
                string cust_supp_code = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
                string mat_supp_code  = fgrid_mat[fgrid_mat.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE].ToString().Trim();

                if (!cust_supp_code.Equals(mat_supp_code))
                {
                    for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                    {
                        string supp_code = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                        if (supp_code.Equals(mat_supp_code))
                        {
                            arg_grid.Select(i, arg_grid.Selection.c1);
                            break;
                        }
                    }
                }
            }


            fgrid_mat.Add_Row(fgrid_mat.Rows.Count - 1);

            int row_mat = fgrid_mat.Rows.Count - 1;
            int row_cust = arg_grid.Selection.r1;

            fgrid_mat.Select(row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER);
            
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ] = "I";
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ] = arg_grid[row_cust, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY];
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ] = "";
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION] = "";
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ] = "001";
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE  ] = arg_grid[row_cust, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD];
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    ] = "Y";
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            ] = "C";
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_USER          ] = COM.ComVar.This_User;
            
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ] = 0;
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ] = 0;
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ] = 0;
            fgrid_mat[row_mat, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ] = 0;

            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.BackColor = Color.White;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.FloralWhite;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME).StyleNew.BackColor = Color.White;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.BackColor = Color.FloralWhite;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.BackColor = Color.White;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.BackColor = Color.FloralWhite;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.BackColor = Color.White;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.FloralWhite;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE).StyleNew.BackColor = Color.White;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN).StyleNew.BackColor = Color.FloralWhite;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD).StyleNew.BackColor = Color.White;

            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER).StyleNew.ForeColor = Color.Black;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.ForeColor = Color.Black;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.ForeColor = Color.Black;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.ForeColor = Color.Black;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.ForeColor = Color.Black;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.ForeColor = Color.Black;
            fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.ForeColor = Color.Black;

            history_flg = false;
        }
        private void Mat_DropData()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            int[] sct_rows = fgrid_mat.Selections;

            if (sct_rows.Length.Equals(0))
            {
                MessageBox.Show("Please select data");
                return;
            }

            FlexCosting.Basic.Pop.Pop_Item_Master_Conv _pop = new FlexCosting.Basic.Pop.Pop_Item_Master_Conv("DROP");

            _pop.ShowDialog();

            if (_pop.save_flg)
            {
                string remarks = _pop._remarks;                

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV] = "D";
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS] = "D";
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS] = remarks;
                }
            }            
        }
        private void Mat_ReleaseData()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            int[] sct_rows = fgrid_mat.Selections;

            if (sct_rows.Length.Equals(0))
            {
                MessageBox.Show("Please select data");
                return;
            }

            FlexCosting.Basic.Pop.Pop_Item_Master_Conv _pop = new FlexCosting.Basic.Pop.Pop_Item_Master_Conv("RELEASE");

            _pop.ShowDialog();

            if (_pop.save_flg)
            {
                string remarks = _pop._remarks;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV] = "U";
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS] = "C";
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS] = remarks;
                }
            }
        }
        private void Mat_UpdateReason()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            int[] sct_rows = fgrid_mat.Selections;

            if (sct_rows.Length.Equals(0))
            {
                MessageBox.Show("Please select data");
                return;
            }

            FlexCosting.Basic.Pop.Pop_Item_Master_Conv _pop = new FlexCosting.Basic.Pop.Pop_Item_Master_Conv("CONV");

            _pop.ShowDialog();

            if (_pop.save_flg)
            {
                string remarks = _pop._remarks;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV] = "U";                    
                    fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS] = remarks;
                }
            }
        }

        private void Mat_CopyData()
        {
            if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                return;

            int[] sct_rows = fgrid_mat.Selections;

            if (sct_rows.Length.Equals(0))
            {
                MessageBox.Show("Please select data");
                return;
            }

            //데이터 테이블 생성
            CopyDT = new DataTable();
            CopyDT.TableName = "CopyDataTable";
                        
            //생성한 데이터 테이블의 컬럼명을 그리드 컬럼명으로 설정.
            for (int iGridCol = fgrid_mat.Cols.Fixed; iGridCol < fgrid_mat.Cols.Count; iGridCol++)
            {
                string col_title = (fgrid_mat[0, iGridCol] == null) ? "" : fgrid_mat[0, iGridCol].ToString();
                Type col_type    = (fgrid_mat.Cols[iGridCol].DataType == null) ? fgrid_mat.Cols[1].DataType : fgrid_mat.Cols[iGridCol].DataType;
                CopyDT.Columns.Add(col_title, col_type);
            }

            for (int i = 0; i < sct_rows.Length; i++)
            {
                DataRow vNewRow = CopyDT.NewRow();

                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ] = "I";
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME     ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME     ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME     ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE  ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE  ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE  ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS           ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS           ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS           ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    ] = (fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    ] == null) ? "" : fgrid_mat[sct_rows[i], (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    ].ToString().Trim();
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_USER          ] = COM.ComVar.This_User;
                vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD           ] = DateTime.Now.ToString();

                CopyDT.Rows.Add(vNewRow);
            }

            mnu_mat_paste.Enabled = true;
        }
        private void Mat_PasteData()
        {
            history_flg = true;

            if (Mat_CustCheck())
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                int sct_row = arg_grid.Selection.r1;
                string cust_code = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                for (int i = 0; i < CopyDT.Rows.Count; i++)
                {
                    fgrid_mat.Rows.Add();

                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxDIV               ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY           ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER        ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER        ].ToString().Trim() + "." + cust_code;
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT          ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ           ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME     ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME     ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH         ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE    ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENCY      ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE  ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS          ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ           ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE  ] = cust_code;
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS            ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS           ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxREMARKS           ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN    ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_USER          ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_USER          ].ToString().Trim();
                    fgrid_mat[fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD           ] = CopyDT.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD           ].ToString().Trim();

                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxDIV, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.BackColor = Color.White;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxNIKE_MAT_NAME).StyleNew.BackColor = Color.White;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.BackColor = Color.White;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.BackColor = Color.White;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE).StyleNew.BackColor = Color.White;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SINGLE_YN).StyleNew.BackColor = Color.FloralWhite;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_YMD).StyleNew.BackColor = Color.White;

                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER).StyleNew.ForeColor = Color.Black;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME).StyleNew.ForeColor = Color.Black;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT).StyleNew.ForeColor = Color.Black;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_WIDTH).StyleNew.ForeColor = Color.Black;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE).StyleNew.ForeColor = Color.Black;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.ForeColor = Color.Black;
                    fgrid_mat.GetCellRange(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_DELIVERY_TERM, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_PROD_LOCATION).StyleNew.ForeColor = Color.Black;
                }

                fgrid_mat.Select(fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER);
            }

            history_flg = false;
        }

        private bool Mat_CustCheck()
        {
            try
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                int sct_row = arg_grid.Selection.r1;
                string cust_code = (arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null) ? "" : arg_grid[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                if (cust_code.Equals(""))
                {
                    MessageBox.Show("Please select Supplier");
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        #endregion

        #region R/P Grid
        private void mnu_rp_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mat_CustCheck())
                {
                    RP_InsertData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void RP_InsertData()
        {
            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;
            int lev = arg_grid.Rows[arg_grid.Selection.r1].Node.Level;

            if (lev.Equals(0))
            {
                MessageBox.Show("Please select Supplier");
                return;
            }

            if (!fgrid_rp.Rows.Count.Equals(fgrid_rp.Rows.Fixed))
            {
                string cust_supp_code = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
                string rp_supp_code = fgrid_rp[fgrid_rp.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE].ToString().Trim();

                if (!cust_supp_code.Equals(rp_supp_code))
                {
                    for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                    {
                        string supp_code = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();

                        if (supp_code.Equals(rp_supp_code))
                        {
                            arg_grid.Select(i, arg_grid.Selection.c1);
                            break;
                        }
                    }
                }
            }

            fgrid_rp.Add_Row(fgrid_rp.Rows.Count - 1);

            int row = fgrid_rp.Rows.Count - 1;
            int row_cust = arg_grid.Selection.r1;

            fgrid_rp.Select(row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV);

            // primary key 
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV             ] = "I";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxFACTORY         ] = arg_grid[row_cust, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY];
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE] = arg_grid[row_cust, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD];
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV      ] = "";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD       ] = "";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC     ] = "";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE       ] = "0";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS         ] = "";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxSTATUS          ] = "C";
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUPD_USER        ] = COM.ComVar.This_User;
            fgrid_rp[row, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUPD_YMD         ] = DateTime.Now;

            fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE).StyleNew.BackColor = Color.White;
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD).StyleNew.BackColor = Color.White;
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUPD_YMD).StyleNew.BackColor = Color.White;
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE).StyleNew.BackColor = Color.FloralWhite;

            fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD).StyleNew.ForeColor = Color.Black;
            fgrid_rp.GetCellRange(fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC, fgrid_rp.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE).StyleNew.ForeColor = Color.Black;
        }
        #endregion

        #region Supplier Grid
        private void mnu_cust_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Supp_InsertData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void Supp_InsertData()
        {
            if (fgrid_cust.Rows.Count.Equals(fgrid_cust.Rows.Fixed))
                return;

            int sct_row = fgrid_cust.Selection.r1;

            if (sct_row < fgrid_cust.Rows.Fixed)
                return;


            C1.Win.C1FlexGrid.Row vNewRow = fgrid_cust.Rows.Insert(sct_row + 1);
            int iNewRow = vNewRow.Index;

            fgrid_cust.Select(iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV);
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV               ] = "I";
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxLEV               ] = 1;
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY           ] = fgrid_cust[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE  ] = fgrid_cust[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K] = fgrid_cust[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E] = fgrid_cust[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV           ] = fgrid_cust[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS            ] = fgrid_cust[sct_row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxUPD_USER          ] = COM.ComVar.This_User;

            fgrid_cust.GetCellRange(iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxDIV,          iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV).StyleNew.BackColor = Color.White;
            fgrid_cust.GetCellRange(iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST, iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS).StyleNew.BackColor = Color.FloralWhite;
            fgrid_cust.GetCellRange(iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS,       iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxUPD_YMD).StyleNew.BackColor = Color.White;


            fgrid_cust.GetCellRange(iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST, iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxREMARKS).StyleNew.ForeColor = Color.Black;
            
        }
        #endregion

        #region Conversion Grid

        #region Upload Excel File
        private void mnu_conv_excel_Click(object sender, EventArgs e)
        {
            try
            {
                fgrid_conv.ClearAll();

                Excel_Upload();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void Excel_Upload()
        {
            COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

            if (arg_grid.Row >= arg_grid.Rows.Fixed)
            {
                if (arg_grid.Rows[arg_grid.Row].Node.Level > 0)
                {
                    FileDialog vDig = new OpenFileDialog();

                    vDig.DefaultExt = "XLS";
                    
                    if (vDig.ShowDialog() == DialogResult.OK)
                    {
                        if (ExcelFile_Check(vDig.FileName))
                        {
                            if (ExcelFile_Loading(vDig.FileName))
                            {
                                Excel_DisplayGrid(); 
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Suppiler", "File");
                }
            }
            else
            {
                MessageBox.Show("Select Suppiler", "File");
            } 
        }
        private void Excel_DisplayGrid()
        {
            for (int i = 0; i < _ExlDS.Tables[0].Rows.Count; i++)
            {
                fgrid_conv.Rows.Add();

                for (int j = fgrid_conv.Cols.Fixed; j < fgrid_conv.Cols.Count; j++)
                {
                    fgrid_conv[fgrid_conv.Rows.Count - 1, j] = _ExlDS.Tables[0].Rows[i].ItemArray[j].ToString();
                }
            }
        }

        #region Excel control
        private bool ExcelFile_Check(string arg_file_name)
        {
            try
            {
                if (!System.IO.File.Exists(arg_file_name))
                {
                    MessageBox.Show("File not found : " + arg_file_name);
                    return false;
                }

                if (!(new System.IO.FileInfo(arg_file_name)).Extension.ToUpper().Equals(".XLS"))
                {
                    if ((new System.IO.FileInfo(arg_file_name)).Extension.ToUpper().Equals(".XLSX"))
                    {
                        MessageBox.Show("Check excel version");
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("This file is not excel file");
                        return false;
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
        private bool ExcelFile_Loading(string arg_file_name)
        {
            try
            {
                _ExlDS = new DataSet();

                application = new Excel.Application();

                workbook = (Excel.Workbook)(application.Workbooks.Open(arg_file_name, Type.Missing, Type.Missing,
                                                                       Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                       Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                if (ExcelFile_FormatCheck(workbook))
                {
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[xls_sheetnum];

                    if (ExcelFile_CreateData(worksheet))
                    {

                    }
                }
                else
                {
                    return false;
                }
                
                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "File Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (application != null)
                {
                    application.Quit();
                    application = null;
                }
            }
        }
        private bool ExcelFile_FormatCheck(Excel.Workbook workbook)
        {
            try
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[xls_sheetnum];
                
                #region Header Check
                for (int col = 0; col < _headers.Length; col++)
                {
                    object xls_title_obj = worksheet.get_Range(worksheet.Cells[1, (col + xls_sheetcol)], worksheet.Cells[1, (col + xls_sheetcol)]).Value2;
                    string xls_title = xls_title_obj == null ? "" : xls_title_obj.ToString().ToUpper().Replace("\n", "").Replace("\t", "").Replace(" ", "");

                    if (!xls_title.Equals(_headers[col]))
                    {
                        MessageBox.Show(_headers[col] + " is wrong");
                        return false;
                    }
                }
                #endregion

                #region LocationCode Check
                string loc_grid = arg_grid[arg_grid.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString();

                for (int row = 2; row < xls_maxrow; row++)
                {
                    object loc_excel_obj = worksheet.get_Range(worksheet.Cells[row, xls_MXS], worksheet.Cells[row, xls_MXS]).Value2;
                    string loc_excel_row = (loc_excel_obj == null) ? "" : loc_excel_obj.ToString().Trim();

                    if (loc_excel_row.Equals(""))
                        break;


                    int loc_excel_idx = loc_excel_row.IndexOf(".");
                    int loc_excel_length = loc_excel_row.Length - loc_excel_idx - 1;

                    string loc_excel = loc_excel_row.Substring(loc_excel_idx + 1, loc_excel_length);

                    if (!loc_grid.Equals(loc_excel))
                    {
                        MessageBox.Show("Row Number : " + row + " - Location Code is wrong");
                        return false;
                    }

                }
                #endregion

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }            
        }
        private bool ExcelFile_CreateData(Excel.Worksheet worksheet)
        {
            try
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                //데이터 테이블 생성
                DataTable vDT = new DataTable();
                vDT.TableName = worksheet.Application.ActiveWorkbook.FullName + worksheet.Name;

                
                vDT.Columns.Add("", fgrid_conv.Cols[2].DataType);
                //생성한 데이터 테이블의 컬럼명을 그리드 컬럼명으로 설정.
                for (int iGridCol = fgrid_conv.Cols.Fixed + 1; iGridCol < fgrid_conv.Cols.Count; iGridCol++)
                {
                    vDT.Columns.Add(fgrid_conv[0, iGridCol].ToString(), fgrid_conv.Cols[iGridCol].DataType);
                }
                
                for (int iRow = 2; iRow < xls_maxrow; iRow++)
                {
                    DataRow vNewRow = vDT.NewRow();

                    if (ExcelFile_GetValue(worksheet, iRow, xls_MXS).Equals(""))
                        break;

                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV             ] = "I";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxCHK             ] = true;
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxFACTORY         ] = arg_grid[arg_grid.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY];
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_SEQ         ] = vDT.Rows.Count + 1;
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE] = arg_grid[arg_grid.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD];
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI01             ] = ExcelFile_GetValue(worksheet, iRow, xls_MXS          );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI02             ] = ExcelFile_GetValue(worksheet, iRow, xls_PRODLOCATION );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI03             ] = ExcelFile_GetValue(worksheet, iRow, xls_MATERIALNAME );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI04             ] = ExcelFile_GetValue(worksheet, iRow, xls_UNIT         );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI05             ] = ExcelFile_GetValue(worksheet, iRow, xls_WIDTH        );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI06             ] = ExcelFile_GetValue(worksheet, iRow, xls_UNITPRICE    );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI07             ] = ExcelFile_GetValue(worksheet, iRow, xls_CURRENCY     );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI08             ] = ExcelFile_GetValue(worksheet, iRow, xls_SPECIALOPTION);
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI09             ] = ExcelFile_GetValue(worksheet, iRow, xls_EXTRACHARGE  );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI10             ] = ExcelFile_GetValue(worksheet, iRow, xls_DELIVERYTERM );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI11             ] = ExcelFile_GetValue(worksheet, iRow, xls_LOSS         );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI12             ] = ExcelFile_GetValue(worksheet, iRow, xls_MOQ          );
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI14             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI15             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI16             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI17             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI18             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI19             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI20             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI21             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI22             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI23             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI24             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI25             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI26             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI27             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI28             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI29             ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI30             ] = "";                 
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxERR_FLG         ] = "";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxSTATUS          ] = "Y";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxUPD_USER        ] = COM.ComVar.This_User;
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxUPD_YMD         ] = System.DateTime.Now;

                    vDT.Rows.Add(vNewRow);
                }
                
                _ExlDS.Tables.Add(vDT);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                workbook.Close(false, workbook.FullName, null);
                workbook = null;
            }
        }
        private string ExcelFile_GetValue(Excel.Worksheet worksheet, int row, int col)
        {
            try
            {
                object xls_data_row = worksheet.get_Range(worksheet.Cells[row, col], worksheet.Cells[row, col]).Text;
                
                string xls_data = xls_data_row == null ? "" : xls_data_row.ToString().Trim();

                if (col.Equals(xls_UNITPRICE) || col.Equals(xls_EXTRACHARGE) || col.Equals(xls_LOSS))
                {                    
                    xls_data = xls_data.Equals("") ? "0" : xls_data.Replace("N/A", "0");
                }

                return xls_data;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        
        
        #endregion

        #region Update Reason
        private void mnu_remarks_Click(object sender, EventArgs e)
        {
            try
            {
                Conv_Update_Reason();
            }
            catch
            {
 
            }
        }

        private void Conv_Update_Reason()
        {

            if (fgrid_conv.Rows.Count.Equals(fgrid_conv.Rows.Fixed))
                return;

            FlexCosting.Basic.Pop.Pop_Item_Master_Conv _pop = new FlexCosting.Basic.Pop.Pop_Item_Master_Conv("CONV");

            _pop.ShowDialog();

            if (_pop.save_flg)
            {
                string remarks = _pop._remarks;

                for (int i = fgrid_conv.Rows.Fixed; i < fgrid_conv.Rows.Count; i++)
                {
                    string div = (fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV] == null) ? "" : fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV].ToString().Trim();

                    if(!div.Equals("I"))
                        fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV] = "U";

                    fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13] = remarks;
                }
            }
        }
        #endregion

        #region Delete Row
        private void mnu_conv_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Conv_Delete_Row();
            }
            catch
            {
 
            }
        }

        private void Conv_Delete_Row()
        {
            if (fgrid_conv.Rows.Count.Equals(fgrid_conv.Rows.Fixed))
                return;

            int[] sct_rows = fgrid_conv.Selections;
            int count = 0;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_conv.RemoveItem(sct_rows[i] + count);
                count--;
            }
        }
        #endregion

        #region Confirm
        private void mnu_conv_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Confirm_Data();
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

        private void Confirm_Data() 
        {

            if (fgrid_conv.Rows.Count.Equals(fgrid_conv.Rows.Fixed))
                return;



            if (Confirm_DataCheck())
            {
                COM.FSP arg_grid = (rbt_supp_use.Checked) ? fgrid_cust_list : fgrid_cust_list_all;

                string [] arg_value = new string[3];

                arg_value[0] = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString().Trim();
                arg_value[1] = arg_grid[arg_grid.Selection.r1, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString().Trim();
                arg_value[2] = COM.ComVar.This_User;

                if (CONFIRM_SFX_CUST(arg_value))
                {
                    if (UPDATE_SFX_CBD_M_MAT(arg_value))
                    {

                        MessageBox.Show("Confirm Completed");

                        int row = fgrid_cust_list.TopRow;
                        int sct_row = fgrid_cust_list.Selection.r1;
                        int sct_col = fgrid_cust_list.Selection.c1;

                        int row_all = fgrid_cust_list_all.TopRow;
                        int sct_row_all = fgrid_cust_list_all.Selection.r1;
                        int sct_col_all = fgrid_cust_list_all.Selection.c1;

                        Set_CustList();

                        fgrid_cust_list.TopRow = row;
                        fgrid_cust_list.Select(sct_row, sct_col);

                        fgrid_cust_list_all.TopRow = row_all;
                        fgrid_cust_list_all.Select(sct_row_all, sct_col_all);

                        Display_Conversion();

                    }
                }
 
            }
        }

        private bool Confirm_DataCheck()
        {
            try
            {
                for (int i = fgrid_conv.Rows.Fixed; i < fgrid_conv.Rows.Count; i++)
                {
                    string div      = (fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV] == null) ? "" : fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxDIV].ToString().Trim();
                    string err_code = (fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxERR_FLG] == null) ? "" : fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxERR_FLG].ToString().Trim();
                    string remarks  = (fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13] == null) ? "" : fgrid_conv[i, (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI13].ToString().Trim();

                    if (!div.Equals(""))
                    {
                        MessageBox.Show("Not Saved Data is exist.\r\n\r\nPlease check again.");
                        return false; 
                    }

                    if (!err_code.Equals(""))
                    {
                        MessageBox.Show("Error Data is exist.\r\n\r\nPlease check again.");
                        return false;
                    }

                    if (remarks.Equals(""))
                    {
                        MessageBox.Show("Update Reson is empty.");
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                return false; 
            }
 
        }

        public bool CONFIRM_SFX_CUST(string[] arg_value)
        {
            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.CONFIRM_SFX_CUST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];

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

        public bool UPDATE_SFX_CBD_M_MAT(string[] arg_value)
        {
            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_BATCH_01.UPDATE_SFX_CBD_M_MAT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];

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
                  
        #endregion       

        #region File Grid
        private void mnu_file_upload_Click(object sender, EventArgs e)
        {
            try

            {
                File_Upload();
                Display_Data();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void mnu_file_open_Click(object sender, EventArgs e)
        {
            try
            {
                File_Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_file_download_Click(object sender, EventArgs e)
        {
            try
            {
                File_Download();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void mnu_file_delete_Click(object sender, EventArgs e)
        {
            try
            {
                File_Delete();
                Display_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void File_Upload()
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Multiselect = true;
                string file_div = tab_detail.SelectedIndex.Equals(4) ? "001" : tab_detail.SelectedIndex.Equals(5) ? "002" : "003";

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;                  

                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        string file_name_short = openDlg.FileNames[i].Substring(openDlg.FileNames[i].LastIndexOf("\\") + 1, openDlg.FileNames[i].Length - openDlg.FileNames[i].LastIndexOf("\\") - 1);

                        string[] arg_value = new string[9];

                        arg_value[0] = "I";
                        arg_value[1] = COM.ComVar.This_Factory;
                        arg_value[2] = file_div;
                        arg_value[3] = "";
                        arg_value[4] = GET_SFX_FILE_CD().Rows[0].ItemArray[0].ToString().Trim();
                        arg_value[5] = file_name_short;
                        arg_value[6] = "";
                        arg_value[7] = "C";
                        arg_value[8] = COM.ComVar.This_User;

                        string file_name = openDlg.FileNames[i];

                        if (INSERT_FILE(arg_value[1], arg_value[4], file_name))
                        {
                            if (!SAVE_SFX_FILE(arg_value))
                            {
                                MessageBox.Show("FIle Upload Error, Please ask System");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("FIle Upload Error, Please ask System");
                            return;
                        }
                    }
                   
                    MessageBox.Show("File Upload Completed.");
                }
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
        private void File_Open()
        {
            string save_path = "C:\\Program Files\\PCC_Sephiroth\\sch_file";
            COM.FSP arg_grid = tab_detail.SelectedIndex.Equals(4) ? fgrid_file_01 : tab_detail.SelectedIndex.Equals(5) ? fgrid_file_02 : fgrid_file_03;

            DirectoryInfo dr = new DirectoryInfo(save_path);

            if (!dr.Exists)
            {
                dr.Create();
            }

            for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
            {
                try
                {
                    string chk = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK].ToString().Trim().ToUpper();

                    if (chk.Equals("TRUE"))
                    {
                        string factory = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFACTORY].ToString().Trim();
                        string file_cd = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD].ToString().Trim();
                        string file_name = int.Parse(arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD].ToString()).ToString() + "_" + arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME].ToString().Trim().Replace("/", "_");
                        string file_path = save_path + "\\" + file_name;
                        string file_type = file_name.Substring(file_name.LastIndexOf(".") + 1, 3).Trim().ToUpper();

                        File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));

                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.WorkingDirectory = save_path;
                        ps.FileName = file_name;

                        try
                        {
                            Process.Start(ps);
                        }
                        catch
                        {
                            MessageBox.Show(file_type + " file cannot working.\r\n\r\nPlease install " + file_type + " viewer program in this computer.");
                            continue;
                        }
                    }
                }
                catch
                {
                    string file_name = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                    MessageBox.Show(file_name + "\r\n\r\nThis File have a problem,\r\n\r\nPlease ask System.");
                    continue;
                }
            }

            

        }
        private void File_Download()
        {
            FolderBrowserDialog save_file = new FolderBrowserDialog();
            COM.FSP arg_grid = tab_detail.SelectedIndex.Equals(4) ? fgrid_file_01 : tab_detail.SelectedIndex.Equals(5) ? fgrid_file_02 : fgrid_file_03;

            if (save_file.ShowDialog() == DialogResult.OK)
            {
                string save_path = save_file.SelectedPath;

                for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                {
                    try
                    {
                        string chk = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK].ToString().Trim().ToUpper();

                        if (chk.Equals("TRUE"))
                        {
                            string factory = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFACTORY].ToString().Trim();
                            string file_cd = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD].ToString().Trim();
                            string file_name = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                            string file_path = save_path + "\\" + file_name;
                            File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));
                        }
                    }
                    catch
                    {
                        string file_name = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                        MessageBox.Show(file_name + "\r\nThis File have a problem,\r\nPlease ask System.");
                        continue;
                    }
                }

                MessageBox.Show("File Download Completed.");                
            }            
        }
        private void File_Delete()
        {
            try
            {
                DialogResult dr01 = MessageBox.Show("Do you want delete these checked files??", "Exclamation", MessageBoxButtons.YesNo);

                if (dr01 == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;

                    COM.FSP arg_grid = tab_detail.SelectedIndex.Equals(4) ? fgrid_file_01 : tab_detail.SelectedIndex.Equals(5) ? fgrid_file_02 : fgrid_file_03;

                    for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                    {
                        string chk = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxCHK].ToString().Trim().ToUpper();

                        if (chk.Equals("TRUE"))
                        {
                            string[] arg_value = new string[9];

                            arg_value[0] = "D";
                            arg_value[1] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFACTORY].ToString().Trim();
                            arg_value[2] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_DIV].ToString().Trim();
                            arg_value[3] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_SEQ].ToString().Trim();
                            arg_value[4] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_CD].ToString().Trim();
                            arg_value[5] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxFILE_NAME].ToString().Trim();
                            arg_value[6] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxREMARKS].ToString().Trim();
                            arg_value[7] = arg_grid[i, (int)ClassLib.TBSFX_CBD_M_FILE.IxSTATUS].ToString().Trim();
                            arg_value[8] = COM.ComVar.This_User;

                            if (DELETE_FILE(arg_value[1], arg_value[4]))
                            {
                                if (!SAVE_SFX_FILE(arg_value))
                                {
                                    MessageBox.Show("FIle Delete Error, Please ask System");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("FIle Delete Error, Please ask System");
                                return;
                            }
                        }
                    }

                    MessageBox.Show("File Delete Completed.");
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

        private DataTable GET_SFX_FILE_CD()
        {
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.GET_SFX_FILE_CD";

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private bool SAVE_SFX_FILE(string[] arg_value)
        {
            try
            {                

                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SAVE_SFX_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_FILE_DIV";
                MyOraDB.Parameter_Name[3] = "ARG_FILE_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_FILE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_FILE_NAME";
                MyOraDB.Parameter_Name[6] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[7] = "ARG_STATUS";
                MyOraDB.Parameter_Name[8] = "ARG_UPD_USER"; 
                
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
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];
                

                MyOraDB.Add_Modify_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Modify_Procedure();

                if (vDS == null) return false;
                return true;            
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "File Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #endregion

        #region RadioButton Event
        private void rbt_supp_use_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton_Event();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
        private void rbt_supp_all_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton_Event();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RadioButton_Event()
        {
            if (rbt_supp_use.Checked)
            {
                fgrid_cust_list.Visible = true;
                fgrid_cust_list_all.Visible = false;
            }
            else
            {
                fgrid_cust_list.Visible = false;
                fgrid_cust_list_all.Visible = true;
            }   
        }
        #endregion

        #region TextBox Event
        private void txt_supplier_KeyUp(object sender, KeyEventArgs e)
        {
            try
            { 
                if (e.KeyData == Keys.Enter)
                {
                    if (chk_all_mat.Checked)
                        Display_Material_All();
                    else
                    {
                        if (tab_detail.SelectedIndex > 3)
                            Display_Data();
                        else
                            Find_TextBox_Supplier();  
                    }
                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void txt_item_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (chk_all_mat.Checked)
                        Display_Material_All();
                    else
                        Find_TextBox_Item();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }



        private void Find_TextBox_Supplier()
        {
            COM.FSP cust_grid = (fgrid_cust_list.Visible) ? fgrid_cust_list : fgrid_cust_list_all;

            if (cust_grid.Rows.Count.Equals(cust_grid.Rows.Fixed))
                return;

            string textbox = txt_supplier.Text.Trim();

            if (textbox.Equals(""))
                return;



            string find_code = "";
            string find_name = "";
            int col_code = (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD;
            int col_name = (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME;

            try
            {
                find_code = double.Parse(textbox).ToString();
            }
            catch
            {
                find_name = textbox;
            }

            if (!find_code.Equals(""))
            {
                if (textbox_supp.Equals(textbox))
                {
                    GoToRow_GridText(row_supp, find_code, col_code, cust_grid);
                }
                else
                {
                    GoToRow_GridText(cust_grid.Rows.Fixed, find_code, col_code, cust_grid);
                }

                row_supp = cust_grid.Selection.r1 + 1;
                textbox_supp = find_code;

            }
            else if (!find_name.Equals(""))
            {
                if (textbox_supp.Equals(textbox))
                {
                    GoToRow_GridText(row_supp, find_name, col_name, cust_grid);
                }
                else
                {
                    GoToRow_GridText(cust_grid.Rows.Fixed, find_name, col_name, cust_grid);
                }

                row_supp = cust_grid.Selection.r1 + 1;
                textbox_supp = find_name;
            }


        }
        private void Find_TextBox_Item()
        {
            COM.FSP mat_grid = (tab_detail.SelectedIndex.Equals(0)) ? fgrid_mat : (tab_detail.SelectedIndex.Equals(1)) ? fgrid_rp : fgrid_conv;

            if (mat_grid.Rows.Count.Equals(mat_grid.Rows.Fixed))
                return;

            string textbox = txt_item.Text.Trim();

            if (textbox.Equals(""))
                return;

            string find_code = "";
            string find_name = "";
            int col_code = (tab_detail.SelectedIndex.Equals(0)) ? (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER :
                           (tab_detail.SelectedIndex.Equals(1)) ? (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD :
                                                                  (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI01;
            int col_name = (tab_detail.SelectedIndex.Equals(0)) ? (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME : 
                           (tab_detail.SelectedIndex.Equals(1)) ? (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD : 
                                                                  (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI02;

            try
            {
                find_code = double.Parse(textbox).ToString();
            }
            catch
            {
                find_name = textbox;
            }

            if (!find_code.Equals(""))
            {
                if (textbox_item.Equals(textbox))
                {
                    GoToRow_GridText(row_item, find_code, col_code, mat_grid);
                }
                else
                {
                    GoToRow_GridText(mat_grid.Rows.Fixed, find_code, col_code, mat_grid); 
                }

                row_item = mat_grid.Selection.r1 + 1;
                textbox_item = find_code;
            }
            else if (!find_name.Equals(""))
            {
                if (textbox_item.Equals(textbox))
                {
                    GoToRow_GridText(row_item, find_name, col_name, mat_grid);
                }
                else
                {
                    GoToRow_GridText(mat_grid.Rows.Fixed, find_name, col_name, mat_grid); 
                }

                row_item = mat_grid.Selection.r1 + 1;
                textbox_item = find_name;
            }
        }

        private void GoToRow_GridText(int arg_startrow, string arg_text, int arg_col, COM.FSP arg_grid)
        {
            int curr_row = arg_grid.Selection.r1;

            try
            {
                for (int i = arg_startrow; i < arg_grid.Rows.Count; i++)
                {
                    if (arg_grid.Tree.MaximumLevel > 0)
                    {
                        int lev = arg_grid.Rows[i].Node.Level;

                        if (lev.Equals(0))
                            continue;
                    }

                    string grid_text = (arg_grid[i, arg_col] == null) ? "" : arg_grid[i, arg_col].ToString().Trim();

                    int find_idx = grid_text.IndexOf(arg_text);

                    if (find_idx > -1)
                    {
                        arg_grid.Select(i, arg_col);
                        arg_grid.TopRow = i;
                        break;
                    }                   

                }
            }
            catch
            {
                arg_grid.Select(curr_row, arg_col);
            }
        }
        #endregion               

        #region CheckBox Event
        private void chk_all_mat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Check_Mat_AllSearch();
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private void Check_Mat_AllSearch()
        {
            if (chk_all_mat.Checked)
            {
                pnl_grid_left.Width = 0;

                lbl_supplier.Text = "Code";
                lbl_Item.Text = "Name";

                fgrid_mat.Cols[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONNAME].Visible = true;
            }
            else
            {
                pnl_grid_left.Width = 242;
                lbl_supplier.Text = "Supplier";
                lbl_Item.Text = "Item";

                fgrid_mat.Cols[(int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONNAME].Visible = false;
            }

            txt_supplier.Clear();
            txt_item.Clear();
            fgrid_mat.ClearAll();
            fgrid_history.ClearAll();
            fgrid_reinforce.ClearAll();
        }
        #endregion

        #region FIle Data


        #region Insert File
        private bool INSERT_FILE(string arg_factory, string arg_file_cd, string file_name)
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_FILE.INSERT_SFX_CBD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_FILE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_RAW_FILE";
                MyOraDB.Parameter_Name[3] = "ARG_STATUS";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Blob;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_file_cd;
                MyOraDB.Parameter_Values[2] = " ";
                MyOraDB.Parameter_Values[3] = "N";
                MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

                byte[] file = null;
                file = GetFile(file_name);
                MyOraDB.Exe_Modify_Procedure_Blob(file);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private byte[] GetFile(string arg_filename)
        {
            FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] file = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return file;
        }
        #endregion

        #region Select File
        private byte[] SELECT_FILE(string arg_factory, string arg_file_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SFX_CBD_FILE.SELECT_SFX_CBD_FILE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_FILE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_file_cd;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                byte[] MyData = null;

                if (ds_ret.Tables[0].Rows.Count > 0)
                {
                    MyData = (byte[])ds_ret.Tables[0].Rows[0].ItemArray[0];
                }

                return MyData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        #region Delete File
        private bool DELETE_FILE(string arg_factory, string arg_file_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_FILE.DELETE_SFX_CBD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_FILE_CD";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_file_cd;

                MyOraDB.Add_Modify_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Modify_Procedure();

                if (vDS == null) return false;
                return true;            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion


        #endregion     
    }
}


