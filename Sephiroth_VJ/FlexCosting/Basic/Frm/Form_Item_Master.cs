using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FlexCosting.Basic
{
    public partial class Form_Item_Master : COM.PCHWinForm.Form_Top
    {
        public Form_Item_Master()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의

        delegate void ShowLoadingImgCallback();

        private COM.OraDB MyOraDB = new COM.OraDB();
        private ShowLoadingImgCallback _LoadingCallback;
        private Pop.Pop_Loading _Loading;
        private Thread _LoadThread;

        private Excel.Workbook workbook = null;
        private Excel.Worksheet worksheet = null;
        private Excel.Application application = null;

        #endregion

        #region 이벤트 핸들러

        #region 툴바 이벤트

        private void Form_Item_Master_Load(object sender, EventArgs e)
        {
            SearchCustInfo();
        }

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                SearchCustListTree();
                SearchCustInfo();
                SearchMaterial();
                SearchMatConv();

                int iMatOrgRow = fgrid_mat.Row, iMatOrgCol = fgrid_mat.Col;

                if (fgrid_mat.Rows.Count > iMatOrgRow)
                {
                    fgrid_mat.Select(iMatOrgRow, iMatOrgCol);
                    fgrid_mat_MouseDown(null, null);
                }

                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Save())
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
                    SearchCustListTree();
                    SearchCustInfo();
                    SearchMaterial();
                    SearchMatConv();

                    int iMatOrgRow = fgrid_mat.Row, iMatOrgCol = fgrid_mat.Col;

                    if (fgrid_mat.Rows.Count > iMatOrgRow)
                    {
                        fgrid_mat.Select(iMatOrgRow, iMatOrgCol);
                        fgrid_mat_MouseDown(null, null);
                    }
                }
                else
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
                }                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        #region Tab #1 (Material)

        private void fgrid_mat_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //this.Cursor = Cursors.WaitCursor;
                if (fgrid_mat.Row >= fgrid_mat.Rows.Fixed)
                {
                    SearchMatDetail();
                    SearchReinforce();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //} 
        }


        private void fgrid_mat_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            string sDiv = fgrid_mat[e.Row,0] == null ? "" : fgrid_mat[e.Row,0].ToString();
            
                if (e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER ||
                    e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT ||
                    e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION)
                {
                    if (sDiv.Equals("I"))
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

        private void fgrid_mat_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                GridAfterEdit(fgrid_mat);

                if (e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER || e.Col == (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE)
                {
                    int iRow = fgrid_mat.Row;

                    fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER] =
                        fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER] + "." +
                        fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE];
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Material Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_cust_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (fgrid_cust_list.Row >= fgrid_cust_list.Rows.Fixed)
                    SearchMaterial();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void fgrid_conv_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            //GridAfterEdit(fgrid_conv);

            int row = fgrid_conv.Row, col = fgrid_conv.Col;
            int[] sels = fgrid_conv.Selections;

            foreach (int row1 in sels)
            {
                fgrid_conv.Update_Row(row1);
            }
        }

        private void fgrid_conv_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridBeforeEdit(fgrid_conv);
        }

        #endregion

        #region Tab #2 (Supplier information)

        private void fgrid_cust_MouseDown(object sender, MouseEventArgs e)
        {
            if (fgrid_cust.Rows.Fixed <= fgrid_cust.Rows.Count &&
                fgrid_cust.MouseRow >= fgrid_cust.Rows.Fixed &&
                fgrid_cust.MouseRow < fgrid_cust.Rows.Count)
            {
                if (e.Button == MouseButtons.Right)
                    fgrid_cust.Select(fgrid_cust.MouseRow, fgrid_cust.MouseCol);
            }
        }


        private void fgrid_cust_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            fgrid_cust_AfterEdit(fgrid_cust);
        }

        private void fgrid_cust_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            fgrid_cust_BeforeEdit(fgrid_cust, e);
        }

        #endregion

        #region Tab #3 (Convertion)

        private void fgrid_conv_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                OpenMatExcel(null);
                DisplayConv();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "DeagDrop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_cust_list_conv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                SearchMatConv();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Conv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #endregion

        #region 컨텍스트메뉴

        private void ctxt_view_supplier_Click(object sender, EventArgs e)
        {
            fgrid_cust.Tree.Show(0);
        }

        private void ctxt_view_charger_Click(object sender, EventArgs e)
        {
            fgrid_cust.Tree.Show(1);
        }

        private void ctxt_SearchExcel_Click(object sender, EventArgs e)
        {
            if (fgrid_cust_list_conv.Row >= fgrid_cust_list_conv.Rows.Fixed)
            {
                if (fgrid_cust_list_conv.Rows[fgrid_cust_list_conv.Row].Node.Level > 0)
                {
                    FileDialog vDig = new OpenFileDialog();
                    if (vDig.ShowDialog() == DialogResult.OK)
                    {
                        if (OpenMatExcel(vDig.FileNames))
                            DisplayConv();
                    }
                }
                else
                {
                    MessageBox.Show("Select customer", "File");
                }
            }
            else
            {
                MessageBox.Show("Select customer", "File");
            }
        }

        private void ctxt_convDelete_Click(object sender, EventArgs e)
        {
            fgrid_conv.Delete_Row();
        }

        private void ctxt_convCancel_Click(object sender, EventArgs e)
        {
            fgrid_conv.Recover_Row();
        }

        private void ctxt_convConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string sFactory = fgrid_cust_list_conv[fgrid_cust_list_conv.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString();
                string sUser = COM.ComVar.This_User;

                if (this.Save())
                {
                    if (CONFIRM_SFX_CBD_M_CUST(sFactory, sUser))
                    {
                        COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);

                        SearchCustListTree();
                        SearchCustInfo();
                        SearchMaterial();
                        SearchMatConv();

                        int iMatOrgRow = fgrid_mat.Row, iMatOrgCol = fgrid_mat.Col;

                        if (fgrid_mat.Rows.Count > iMatOrgRow)
                        {
                            fgrid_mat.Select(iMatOrgRow, iMatOrgCol);
                            fgrid_mat_MouseDown(null, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void cmb_seasonFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Season selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_SchText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (fgrid_cust_list.Row >= fgrid_cust_list.Rows.Fixed)
                        SearchMaterial();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void ctxt_custInsert_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                InsertCustomer();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // add supplier information
        private void btn_InfoAdd_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_cust.Rows.Fixed <= fgrid_cust.Rows.Count && fgrid_cust.Rows.Fixed <= fgrid_cust.Row)
                    InsertCharger();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Add info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_InfoDel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_cust.Rows.Fixed <= fgrid_cust.Rows.Count && fgrid_cust.Rows.Fixed <= fgrid_cust.Row)
                    DeleteCharger();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_InfoCancel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                CancelModifyInfo();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Cancel modify info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // add material
        private void btn_MatAdd_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_cust_list.Row >= fgrid_cust_list.Rows.Fixed && fgrid_cust_list.Rows[fgrid_cust_list.Row].Node.Level > 0)
                    AddMat();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Add material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_MatDel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_mat.Rows.Count >= fgrid_mat.Rows.Fixed && fgrid_mat.Rows.Fixed <= fgrid_mat.Row) 
                    DelMat();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Delete material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_MatCancel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                CancelModifyMat();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Cancel modify material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ctxt_matInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_cust_list.Row >= fgrid_cust_list.Rows.Fixed && fgrid_cust_list.Rows[fgrid_cust_list.Row].Node.Level > 0)
                    AddMat();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Add material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_matDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_mat.Rows.Count >= fgrid_mat.Rows.Fixed && fgrid_mat.Rows.Fixed <= fgrid_mat.Row)
                    DelMat();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Delete material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_matCancel_Click(object sender, EventArgs e)
        {
            try
            {
                CancelModifyMat();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Cancel modify material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_sup_code_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SupCodeFoundAndSelect(fgrid_cust.Row);
                }
                else
                {
                    SupFound();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Supplier code key up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_sup_name_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SupNameFoundAndSelect(fgrid_cust.Row);
                }
                else
                {
                    SupFound();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Supplier name key up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_conv_sup_code_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConvSupCodeFoundAndSelect(fgrid_cust_list_conv.Row);
                }
                else
                {
                    ConvSupFound();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Conversion supplier code key up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_conv_sup_name_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConvSupNameFoundAndSelect(fgrid_cust_list_conv.Row);
                }
                else
                {
                    ConvSupFound();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Conversion supplier name key up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region 이벤트 처리

        #region 초기화

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = "Item Master";
                this.lbl_MainTitle.Text = "Item Master";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                Init_Control();
                Init_Toolbar();
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

            fgrid_cust.Set_Grid("SFX_CBD_M_CUST_INFO", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cust.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cust.Set_Action_Image(img_Action);
            fgrid_cust.Font = new Font("Verdana", 8);
            //fgrid_cust.Tree.Column = (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST;

            fgrid_mat.Set_Grid("SFX_CBD_M_MAT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_mat.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_mat.Font = new Font("Verdana", 8);
            fgrid_mat.Set_Action_Image(img_Action);

            fgrid_history.Set_Grid("SFX_CBD_M_MAT_HISTORY", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_history.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_history.Font = new Font("Verdana", 8);
            fgrid_history.Set_Action_Image(img_Action);

            fgrid_reinforce.Set_Grid("SFX_CBD_M_REINFORCE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_reinforce.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_reinforce.Font = new Font("Verdana", 8);
            fgrid_reinforce.Set_Action_Image(img_Action);

            fgrid_cust_list_conv.Set_Grid("SFX_CBD_M_CUST_LIST", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_cust_list_conv.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_cust_list_conv.Font = new Font("Verdana", 8);

            fgrid_conv.Set_Grid("SFX_CBD_M_MAT_CONV", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_conv.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_conv.Font = new Font("Verdana", 8);
            fgrid_conv.Set_Action_Image(img_Action);

            SearchCustListTree();
        }

        private void Init_Control()
        {
            spc_mat.SplitterDistance = spc_mat.Size.Height;
            //sizer_conv.Grid.Columns[0].Size = 200;
        }

        private void Init_Toolbar()
        {
            //tbtn_New.Enabled = false;
            //tbtn_Search.Enabled = false;
            //tbtn_Save.Enabled = false;

            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_cust.Recover_Row();
            fgrid_mat.ClearAll();
            fgrid_history.ClearAll();
            fgrid_reinforce.ClearAll();
            fgrid_conv.ClearAll();
        }

        private void SearchCustListTree()
        {
            // Customer list search
            DataSet vDS = SELECT_SFX_CBD_M_CUST_LIST(COM.ComVar.This_Factory);
            DataTable vDT = vDS.Tables["PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_LIST"];
            if (vDT != null && vDT.Rows.Count > 0)
            {
                int iCurRow = fgrid_cust_list.Row;
                int iCurTopRow = fgrid_cust_list.TopRow;

                fgrid_cust_list.ClearAll();
                fgrid_cust_list.Display_Grid(vDT, false);
                for (int iRow = fgrid_cust_list.Rows.Fixed; iRow < fgrid_cust_list.Rows.Count; iRow++)
                {
                    fgrid_cust_list.Rows[iRow].IsNode = true;
                    int iLev = Convert.ToInt32(fgrid_cust_list[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxLEV].ToString());
                    fgrid_cust_list.Rows[iRow].Node.Level = iLev;

                    if (iLev == 0)
                        fgrid_cust_list.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                    else if (iLev == 1)
                        fgrid_cust_list.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                }

                fgrid_cust_list.Tree.Column = (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME;
                fgrid_cust_list.TopRow = iCurTopRow;
                if (iCurRow >= fgrid_cust_list.Rows.Fixed && iCurRow < fgrid_cust_list.Rows.Count)
                {
                    fgrid_cust_list.Select(iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME);
                }
                else
                {
                    fgrid_cust_list.Select(fgrid_cust_list.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME);
                }
            }
            vDT.Dispose();

            vDT = vDS.Tables["PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_LIST_ALL"];
            if (vDT != null && vDT.Rows.Count > 0)
            {
                int iCurRow = fgrid_cust_list_conv.Row;
                int iCurTopRow = fgrid_cust_list_conv.TopRow;

                fgrid_cust_list_conv.ClearAll();
                fgrid_cust_list_conv.Display_Grid(vDT, false);
                for (int iRow = fgrid_cust_list_conv.Rows.Fixed; iRow < fgrid_cust_list_conv.Rows.Count; iRow++)
                {
                    fgrid_cust_list_conv.Rows[iRow].IsNode = true;
                    int iLev = Convert.ToInt32(fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxLEV].ToString());
                    string sLocName = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME].ToString();
                    fgrid_cust_list_conv.Rows[iRow].Node.Level = iLev;

                    if (iLev == 0)
                        fgrid_cust_list_conv.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                    else if (iLev == 1)
                        fgrid_cust_list_conv.Rows[iRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;

                    if (sLocName.EndsWith("*"))
                    {
                        fgrid_cust_list_conv.Rows[iRow].Style.Font = new Font("Verdana", 8, FontStyle.Bold);
                        fgrid_cust_list_conv.Rows[iRow].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        fgrid_cust_list_conv.Rows[iRow].Style.Font = new Font("Verdana", 8);
                        fgrid_cust_list_conv.Rows[iRow].Style.ForeColor = Color.Black;
                    }
                }

                fgrid_cust_list_conv.Tree.Column = (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD;
                fgrid_cust_list_conv.TopRow = iCurTopRow;
                if (iCurRow >= fgrid_cust_list_conv.Rows.Fixed && iCurRow < fgrid_cust_list_conv.Rows.Count)
                {
                    fgrid_cust_list_conv.Select(iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD);
                }
                else
                {
                    fgrid_cust_list_conv.Select(fgrid_cust_list_conv.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD);
                }
                SupFound();
            }
            vDT.Dispose();
        }

        private void SearchMaterial()
        {
            try
            {
                fgrid_mat.ClearAll();
                fgrid_history.ClearAll();
                fgrid_reinforce.ClearAll();

                //_LoadThread = new Thread(new ThreadStart(_LoadingCallback));
                //_LoadThread.Start();

                int iRow = fgrid_cust_list.Row;

                if (iRow < fgrid_mat.Rows.Fixed)
                    return;

                string sFactory = COM.ComVar.This_Factory;
                string sMxsCode = fgrid_cust_list[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV] == null ? "" : fgrid_cust_list[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_DIV].ToString();
                string sLocation = fgrid_cust_list[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD] == null ? "" : fgrid_cust_list[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString();
                string sItemCode = txt_itemCode.Text.Trim();
                string sItemName = txt_itemName.Text.Trim();

                DataTable vDT = SELECT_SFX_CBD_M_MAT_LIST(sFactory, sMxsCode, sLocation, sItemCode, sItemName);

                if (vDT != null)
                {
                    fgrid_mat.Display_Grid(vDT, false);
                    spc_mat.SplitterDistance = spc_mat.Size.Height;
                    if (vDT.Rows.Count > 0)
                    {
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed, 1, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ).StyleNew.ForeColor = Color.Black;
                        fgrid_mat.GetCellRange(fgrid_mat.Rows.Fixed, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION, fgrid_mat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION).StyleNew.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //try
                //{
                //    if (_LoadThread != null && _LoadThread.IsAlive)
                //        _LoadThread.Abort();
                //}
                //catch
                //{

                //}
            }
        }

        private void ShowLoadingImg()
        {
            try
            {
                if (Thread.CurrentThread.IsAlive)
                {
                    _Loading = new FlexCosting.Basic.Pop.Pop_Loading();
                    _Loading.WindowState = FormWindowState.Normal;
                    _Loading.StartPosition = FormStartPosition.Manual;
                    _Loading.Size = new Size(66, 66);
                    _Loading.Location = new Point((this.Width / 2) - 33, (this.Height / 2) - 33);
                    //_Loading.Location = new Point(fgrid_mat.Left, fgrid_mat.Top);
                    _Loading.ShowInTaskbar = false;

                    _Loading.ShowDialog();
                }
            }
            catch
            {
                return;
            }
        }

        private void SearchCustInfo()
        {
            int iRow = fgrid_cust_list.Row;

            string sFactory = COM.ComVar.This_Factory;

            DataTable vDT = SELECT_SFX_CBD_M_CUST_INFO(sFactory);

            fgrid_cust.ClearAll();
            if (vDT != null)
            {
                for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
                {
                    C1.Win.C1FlexGrid.Row vNewRow = fgrid_cust.AddItem(vDT.Rows[iIdx].ItemArray, fgrid_cust.Rows.Count, 1);
                    vNewRow[0] = "";
                    //vNewRow.IsNode = true;
                    //vNewRow.Node.Level = Convert.ToInt32(vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxLEV - 1]);

                    //if (vNewRow.Node.Level == 0)
                    //{
                    //    vNewRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                    //    fgrid_cust.GetCellRange(vNewRow.Index, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST).StyleNew.ForeColor = Color.Black;
                    //    fgrid_cust.GetCellRange(vNewRow.Index, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST).Style.Font = new Font(
                    //        fgrid_cust.GetCellRange(vNewRow.Index, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST).Style.Font.FontFamily,
                    //        fgrid_cust.GetCellRange(vNewRow.Index, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST).Style.Font.Size, 
                    //        FontStyle.Bold);
                    //}
                    //else
                    //{
                    //    vNewRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                    //}
                }

                vDT.Dispose();

                fgrid_cust.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                fgrid_cust.Cols[0].AllowMerging = false;
                for (int iCol = 1; iCol < fgrid_cust.Cols.Count; iCol++)
                {
                    if (iCol < fgrid_cust.Cols.Frozen)
                        fgrid_cust.Cols[iCol].AllowMerging = true;
                    else
                        fgrid_cust.Cols[iCol].AllowMerging = false;
                }
            }
        }

        private void SearchMatDetail()
        {
            int iRow = fgrid_mat.Row;

            string sFactory = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY].ToString();
            string sMxsNumber = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_NUMBER].ToString(); 
            string sMxsUnit = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT].ToString(); 
            string sMxsSpecialOption = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION].ToString();
            string sMxsSeq = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ].ToString();

            DataTable vDT = SELECT_SFX_CBD_M_MAT_HISTORY(sFactory, sMxsNumber, sMxsUnit, sMxsSpecialOption, sMxsSeq);

            fgrid_history.ClearAll();
            if (vDT != null)
            {
                fgrid_history.Display_Grid(vDT, false);

                if (vDT.Rows.Count <= 0)
                {
                    spc_mat.SplitterDistance = spc_mat.Size.Height;
                }
                else
                {
                    spc_mat.SplitterDistance = (int)(spc_mat.Size.Height * 0.7);
                }
            }
            else
            {
                spc_mat.SplitterDistance = spc_mat.Size.Height;
            }
        }

        private void SearchReinforce()
        {
            int iRow = fgrid_mat.Row;

            string sFactory = COM.ComVar.This_Factory;
            string sMatNumber = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER] == null ? "" : fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER].ToString();
            string sMatDesc = fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME] == null ? "" : fgrid_mat[iRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MATERIAL_NAME].ToString();

            DataTable vDT = SELECT_SFX_CBD_M_REINFORCE(sFactory, sMatNumber, sMatDesc);

            fgrid_reinforce.ClearAll();
            if (vDT != null)
            {
                fgrid_reinforce.Display_Grid(vDT, false);
            }
        }

        private void SearchMatConv()
        {
            int iRow = fgrid_cust_list_conv.Row;
            string sFactory = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY].ToString();
            string sLocCode = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString();
            DataTable vDT = SELECT_SFX_CBD_M_MAT_CONV_LIST(sFactory, sLocCode);

            fgrid_conv.ClearAll();
            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_conv.Display_Grid(vDT, false);
            }
        }

        private bool Save()
        {
            if (MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_M_MAT.SAVE_SFX_CBD_M_CUST", fgrid_cust, true))
            {
                if (MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_M_MAT.SAVE_SFX_CBD_M_MAT", fgrid_mat, false))
                {
                    if (MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_M_MAT.SAVE_SFX_CBD_M_MAT_CONV", fgrid_conv, false))
                    {
                        DataSet vDS = MyOraDB.Exe_Modify_Procedure();

                        if (vDS == null)
                            return false;
                        else
                            return true;
                    }
                }
            }

            return false;
        }

        #endregion

        #region 그리드 이벤트

        private void GridAfterEdit(COM.FSP arg_grid)
        {
            int row = arg_grid.Row, col = arg_grid.Col;
            int[] sels = arg_grid.Selections;

            foreach (int row1 in sels)
            {
                arg_grid[row1, col] = arg_grid[row, col];
                arg_grid.Update_Row(row1);
            }
        }

        private void GridBeforeEdit(COM.FSP arg_grid)
        {
            if ((arg_grid.Rows.Fixed > 0) && (arg_grid.Row >= arg_grid.Rows.Fixed))
                arg_grid.Buffer_CellData = (arg_grid[arg_grid.Row, arg_grid.Col] == null) ? "" : arg_grid[arg_grid.Row, arg_grid.Col].ToString();
        }

        private void fgrid_cust_BeforeEdit(COM.FSP arg_grid, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridBeforeEdit(fgrid_cust);
            //if (fgrid_cust.Rows[fgrid_cust.Row].Node.Level == 0)
            //{
            //    if (fgrid_cust.Col == (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST || fgrid_cust.Col == (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E_VIEW)
            //    {
            //        e.Cancel = false;
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void fgrid_cust_AfterEdit(COM.FSP arg_grid)
        {
            C1.Win.C1FlexGrid.CellRange vRange = arg_grid.GetMergedRange(arg_grid.Row, arg_grid.Col);
            for (int iRow = vRange.r1; iRow <= vRange.r2; iRow++)
            {
                arg_grid.Update_Row(iRow);
            }

            //int row = arg_grid.Row, col = arg_grid.Col;

            //switch (col)
            //{
            //    case (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST:
            //        if (fgrid_cust.Rows[row].Node.Level == 0)
            //        {
            //            for (int irow = row + 1; irow < (row + 1) + arg_grid.Rows[row].Node.Children; irow++)
            //            {
            //                arg_grid[irow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K] = arg_grid[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_MAN_CUST];
            //                arg_grid.Update_Row(irow);
            //            }
            //        }
            //        break;
            //    case (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E_VIEW:
            //        if (fgrid_cust.Rows[row].Node.Level == 0)
            //        {
            //            for (int irow = row + 1; irow < (row + 1) + arg_grid.Rows[row].Node.Children; irow++)
            //            {
            //                arg_grid[irow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E] = arg_grid[row, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E_VIEW];
            //                arg_grid.Update_Row(irow);
            //            }
            //        }
            //        break;
            //}

            //if (fgrid_cust.Rows[row].Node.Level > 0)
            //{
            //    int[] sels = arg_grid.Selections;

            //    foreach (int irow in sels)
            //    {
            //        if (fgrid_cust.Rows[irow].Node.Level == 1)
            //        {
            //            arg_grid[irow, col] = arg_grid[row, col];
            //            arg_grid.Update_Row(irow);
            //        }
            //    }
            //}
        }

        #region Excel control

        private bool OpenMatExcel(string[] sFileNames)
        {
            try
            {
                if (sFileNames.Length > 0)
                {
                    _ExlDS = new DataSet();

                    application = new Excel.Application();

                    for (int iIdx = 0; iIdx < sFileNames.Length; iIdx++)
                    {
                        // 0. File exist check
                        if (!System.IO.File.Exists(sFileNames[iIdx]))
                        {
                            MessageBox.Show("File not found : " + sFileNames[iIdx]);
                            return false;
                        }

                        if (!(new System.IO.FileInfo(sFileNames[iIdx])).Extension.ToUpper().Equals(".XLS"))
                        {
                            if ((new System.IO.FileInfo(sFileNames[iIdx])).Extension.ToUpper().Equals(".XLSX"))
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

                        workbook = (Excel.Workbook)(application.Workbooks.Open(sFileNames[iIdx], Type.Missing, Type.Missing,
                                                                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                        if (!HeaderCheck(workbook))
                        {
                            return false;
                        }
                    }
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

        DataSet _ExlDS = null;
        string[] _headers = new string[] { "MXS#", "PROD.LOCATION", "MATERIALNAME", "UNIT", "WIDTH", "UNITPRICE", "CURRENCY", "SPECIALOPTION", "EXTRACHARGE", "DELIVERYTERM", "LOSS(%)", "MOQ" };
        int _ExlSheetNum = 1, _ExlSheetCol = 1, _ExlMaxRow = 500;

        private bool HeaderCheck(Excel.Workbook workbook)
        {
            try
            {
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[_ExlSheetNum];
                for (int iIdx = 0; iIdx < _headers.Length; iIdx++)
                {
                    object oTit = worksheet.get_Range(worksheet.Cells[1, (iIdx + _ExlSheetCol)], worksheet.Cells[1, (iIdx + _ExlSheetCol)]).Value2;
                    string sTit = oTit == null ? "" : oTit.ToString().ToUpper().Replace("\n", "").Replace("\t", "").Replace(" ", "");

                    if (!sTit.Equals(_headers[iIdx]))
                    {
                        MessageBox.Show(_headers[iIdx] + " is worng");
                        return false;
                    }
                }

                return CreateDataTable(worksheet);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Header check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                workbook.Close(false, workbook.FullName, null);
                workbook = null;
            }
        }

        private bool CreateDataTable(Excel.Worksheet worksheet)
        {
            try
            {
                DataTable vDT = new DataTable();
                vDT.TableName = worksheet.Application.ActiveWorkbook.FullName + worksheet.Name;

                for (int iGridCol = 1; iGridCol < fgrid_conv.Cols.Count; iGridCol++)
                {
                    vDT.Columns.Add(fgrid_conv[0, iGridCol].ToString(), fgrid_conv.Cols[iGridCol].DataType);
                }

                string sLocCodeExl = "";
                string sLocCodeGrid = fgrid_cust_list_conv[fgrid_cust_list_conv.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString();

                for (int iRow = 2; iRow < _ExlMaxRow; iRow++)
                {
                    object cData = worksheet.get_Range(worksheet.Cells[iRow, 2], worksheet.Cells[iRow, 2]).Value2;
                    if (cData == null)
                    {
                        if (iRow == 2)
                        {
                            MessageBox.Show("Data not found!!", "Load data");
                            return false;
                        }
                        else
                        {
                            break;
                        }
                    }

                    DataRow vNewRow = vDT.NewRow();
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxCHK - 1] = true;
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxFACTORY - 1] = fgrid_cust_list_conv[fgrid_cust_list_conv.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY];
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_SEQ - 1] = vDT.Rows.Count + 1;
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE - 1] = fgrid_cust_list_conv[fgrid_cust_list_conv.Row, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD];
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxSTATUS - 1] = "Y";
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxUPD_USER - 1] = COM.ComVar.This_User;
                    vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxUPD_YMD - 1] = System.DateTime.Now;

                    for (int iArrayIdx = 0, iCellCol = _ExlSheetCol, iDTCol = 0; iArrayIdx < _headers.Length; iArrayIdx++, iCellCol++, iDTCol++)
                    {
                        object oData = worksheet.get_Range(worksheet.Cells[iRow, iCellCol], worksheet.Cells[iRow, iCellCol]).Text;
                        string sData = oData == null ? "" : oData.ToString().Trim();
                        double dTemp = 0;
                        
                        if (vDT.Columns[iDTCol + (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE].DataType == Type.GetType("System.Double"))
                        {
                            if (!double.TryParse(sData.Replace("N/A", "0").Trim(), out dTemp))
                            {
                                object oTitle = worksheet.get_Range(worksheet.Cells[1, iCellCol], worksheet.Cells[1, iCellCol]).Value2;
                                string sTitle = oTitle == null ? "" : oTitle.ToString().Trim();

                                MessageBox.Show(sTitle + " is not number");
                                return false;

                            }
                            else
                            {
                                vNewRow[iDTCol + (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE] = dTemp;
                            }
                        }
                        else
                        {
                            vNewRow[iDTCol + (int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxMXS_LOCATIONCODE] = sData;
                        }
                    }

                    sLocCodeExl = vNewRow[(int)ClassLib.TBSFX_CBD_M_MAT_CONV.IxI01 - 1].ToString();
                    vDT.Rows.Add(vNewRow);
                }

                if (!sLocCodeExl.EndsWith(sLocCodeGrid))
                {
                    if (MessageBox.Show("Continue?", "Load data", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    {
                        return false;
                    }
                }

                _ExlDS.Tables.Add(vDT);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        private void DisplayConv()
        {
            for (int iIdx = 0; iIdx < _ExlDS.Tables.Count; iIdx++)
            {
                fgrid_conv.Display_Grid(_ExlDS.Tables[iIdx], false);

                for (int iRow = fgrid_conv.Rows.Fixed; iRow < fgrid_conv.Rows.Count; iRow++)
                {
                    fgrid_conv[iRow, 0] = "I";
                }
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void InsertCustomer()
        {
            FlexCosting.Basic.Pop.Pop_Item_Master_Add_Cust vPop = new FlexCosting.Basic.Pop.Pop_Item_Master_Add_Cust();
            if (vPop.ShowDialog() == DialogResult.OK)
            {
                SearchCustInfo();
            }
        }

        private void InsertCharger()
        {
            int iCurRow = fgrid_cust.Row;

            C1.Win.C1FlexGrid.Row vNewRow = fgrid_cust.Rows.Insert(iCurRow + 1);
            int iNewRow = vNewRow.Index;

            fgrid_cust.Select(iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV);
            fgrid_cust[iNewRow, 0] = "I";
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxLEV] = 1;
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY] = fgrid_cust[iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE] = fgrid_cust[iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K] = fgrid_cust[iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E] = fgrid_cust[iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV] = fgrid_cust[iCurRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV];
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS] = "N";
            fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxUPD_USER] = COM.ComVar.This_User;
        }

        //private void InsertCharger()
        //{
        //    int iCurRow = fgrid_cust.Row;
        //    int iParentRow = iCurRow;

        //    // parent node search 
        //    if (fgrid_cust.Rows[iCurRow].Node.Level == 1)
        //    {
        //        iParentRow = fgrid_cust.Rows[iCurRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;
        //    }

        //    C1.Win.C1FlexGrid.Node vNewNode = fgrid_cust.Rows[iParentRow].Node.AddNode(C1.Win.C1FlexGrid.NodeTypeEnum.LastChild, null);
        //    fgrid_cust.Select(vNewNode.Row.Index, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV);

        //    // if exist previous leaf node then get information it
        //    C1.Win.C1FlexGrid.Node vPreviousSib = vNewNode.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.PreviousSibling);
        //    if (vPreviousSib != null)
        //        iParentRow = vPreviousSib.Row.Index;

        //    int iNewRow = vNewNode.Row.Index;

        //    fgrid_cust[iNewRow, 0] = "I";
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxLEV] = 1;
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY] = fgrid_cust[iParentRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxFACTORY];
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE] = fgrid_cust[iParentRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE];
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K] = fgrid_cust[iParentRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_K];
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E] = fgrid_cust[iParentRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E];
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV] = fgrid_cust[iParentRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_DIV];
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxSTATUS] = "C";
        //    fgrid_cust[iNewRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxUPD_USER] = COM.ComVar.This_User;
        //}

        private void DeleteCharger()
        {
            //if (fgrid_cust.Rows[fgrid_cust.Row].Node.Level == 1)
            //{
            int[] iSels = fgrid_cust.Selections;

            foreach (int iRow in iSels)
            {
                fgrid_cust.Delete_Row(iRow);
            }
            //}
        }

        private void CancelModifyInfo()
        {
            fgrid_cust.Recover_Row();
        }


        // Add material
        private void AddMat()
        {
            fgrid_mat.Add_Row(fgrid_mat.Rows.Count - 1);

            int iNewRow = fgrid_mat.Rows.Count - 1, iCurCustRow = fgrid_cust_list.Row;

            fgrid_mat.Select(iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMAT_NUMBER);

            // primary key 
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxFACTORY] = fgrid_cust_list[iCurCustRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxFACTORY];
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT] = "_____";
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SPECIAL_OPTION] = "_____";
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_SEQ] = "001";
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOCATIONCODE] = fgrid_cust_list[iCurCustRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD];
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_CURRENT_YN] = "Y";
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxSTATUS] = "C";
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxUPD_USER] = COM.ComVar.This_User;

            // sub data
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_UNIT_PRICE] = 0;
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_EXTRA_CHARGE] = 0;
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_LOSS] = 0;
            fgrid_mat[iNewRow, (int)ClassLib.TBSFX_CBD_M_MAT.IxMXS_MOQ] = 0;
        }

        private void DelMat()
        {
            fgrid_mat.Delete_Row();
        }

        private void CancelModifyMat()
        {
            fgrid_mat.Recover_Row();
        }

        private void DelCharge()
        {
            fgrid_history.Delete_Row();
        }

        private void CancelModifyCharge()
        {
            fgrid_history.Recover_Row();
        }

        private void SupFound()
        {
            int iFirstFound = fgrid_cust.Row;
            string sTxtSupCode = txt_sup_code.Text.Trim().ToUpper();
            string sTxtSupName = txt_sup_name.Text.Trim().ToUpper();

            for (int iRow = fgrid_cust.Rows.Fixed; iRow < fgrid_cust.Rows.Count; iRow++)
            {
                string sSupCode = fgrid_cust[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE].ToString();
                string sSupName = fgrid_cust[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E].ToString();

                if ((sSupCode.ToUpper().StartsWith(txt_sup_code.Text.Trim().ToUpper())) &&
                (sSupName.ToUpper().StartsWith(txt_sup_name.Text.Trim().ToUpper())))
                {
                    if (!sTxtSupCode.Equals("") || !sTxtSupName.Equals(""))
                    {
                        fgrid_cust.Rows[iRow].StyleNew.BackColor = Color.Yellow;
                    }
                    else
                    {
                        fgrid_cust.Rows[iRow].StyleNew.BackColor = Color.White;
                    }
                }
                else
                {
                    fgrid_cust.Rows[iRow].StyleNew.BackColor = Color.White;
                }
            }

            fgrid_cust.Select(iFirstFound, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE);
        }

        private void SupCodeFoundAndSelect(int iStartRow)
        {
            for (int iRow = iStartRow + 1; iRow < fgrid_cust.Rows.Count; iRow++)
            {
                string sSupCode = fgrid_cust[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE].ToString();

                if (sSupCode.ToUpper().StartsWith(txt_sup_code.Text.Trim().ToUpper()))
                {
                    if (!(fgrid_cust.TopRow <= iRow && fgrid_cust.BottomRow >= iRow))
                        fgrid_cust.TopRow = iRow;
                    fgrid_cust.Select(iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONCODE);
                    break;
                }
                else
                {
                    if (iRow == fgrid_cust.Rows.Count - 1)
                    {
                        SupCodeFoundAndSelect(fgrid_cust.Rows.Fixed - 1);
                        break;
                    }
                    else if (iRow == fgrid_cust.Row)
                    {
                        break;
                    }
                }
            }
        }

        private void SupNameFoundAndSelect(int iStartRow)
        {
            for (int iRow = iStartRow + 1; iRow < fgrid_cust.Rows.Count; iRow++)
            {
                string sSupName = fgrid_cust[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E].ToString();

                if (sSupName.ToUpper().StartsWith(txt_sup_name.Text.Trim().ToUpper()))
                {
                    if (!(fgrid_cust.TopRow <= iRow && fgrid_cust.BottomRow >= iRow))
                        fgrid_cust.TopRow = iRow;
                    fgrid_cust.Select(iRow, (int)ClassLib.TBSFX_CBD_M_CUST_INFO.IxMXS_LOCATIONNAME_E);
                    break;
                }
                else
                {
                    if (iRow == fgrid_cust.Rows.Count - 1)
                    {
                        SupNameFoundAndSelect(fgrid_cust.Rows.Fixed - 1);
                        break;
                    }
                    else if (iRow == fgrid_cust.Row)
                    {
                        break;
                    }
                }
            }
        }



        private void ConvSupFound()
        {
            int iFirstFound = fgrid_cust_list_conv.Row;
            string sTxtSupCode = txt_conv_sup_code.Text.Trim().ToUpper();
            string sTxtSupName = txt_conv_sup_name.Text.Trim().ToUpper();

            for (int iRow = fgrid_cust_list_conv.Rows.Fixed; iRow < fgrid_cust_list_conv.Rows.Count; iRow++)
            {
                string sSupCode = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString();
                string sSupName = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME].ToString();

                //if ((sSupCode.ToUpper().StartsWith(txt_conv_sup_code.Text.Trim().ToUpper()) && !txt_conv_sup_code.Text.Trim().Equals("")) &&
                //    (sSupName.ToUpper().StartsWith(txt_conv_sup_name.Text.Trim().ToUpper()) && !txt_conv_sup_name.Text.Trim().Equals("")) &&
                //    fgrid_cust_list_conv.Rows[iRow].Node.Level > 0)

                if ((sSupCode.ToUpper().StartsWith(txt_conv_sup_code.Text.Trim().ToUpper())) &&
                (sSupName.ToUpper().StartsWith(txt_conv_sup_name.Text.Trim().ToUpper())) &&
                fgrid_cust_list_conv.Rows[iRow].Node.Level > 0)
                {
                    if (!sTxtSupCode.Equals("") || !sTxtSupName.Equals(""))
                    {
                        fgrid_cust_list_conv.Rows[iRow].StyleNew.BackColor = Color.Yellow;
                    }
                    else
                    {
                        fgrid_cust_list_conv.Rows[iRow].StyleNew.BackColor = Color.White;
                    }
                }
                else
                {
                    fgrid_cust_list_conv.Rows[iRow].StyleNew.BackColor = Color.White;
                }
            }

            fgrid_cust_list_conv.Select(iFirstFound, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD);
        }

        private void ConvSupCodeFoundAndSelect(int iStartRow)
        {
            for (int iRow = iStartRow + 1; iRow < fgrid_cust_list_conv.Rows.Count; iRow++)
            {
                string sSupCode = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD].ToString();

                if (sSupCode.ToUpper().StartsWith(txt_conv_sup_code.Text.Trim().ToUpper()))
                {
                    if (!(fgrid_cust_list_conv.TopRow <= iRow && fgrid_cust_list_conv.BottomRow >= iRow))
                        fgrid_cust_list_conv.TopRow = iRow;
                    fgrid_cust_list_conv.Select(iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxNIKE_SUPPLIER_CD);
                    break;
                }
                else
                {
                    if (iRow == fgrid_cust_list_conv.Rows.Count - 1)
                    {
                        ConvSupCodeFoundAndSelect(fgrid_cust_list_conv.Rows.Fixed - 1);
                        break;
                    }
                    else if (iRow == fgrid_cust_list_conv.Row)
                    {
                        break;
                    }
                }
            }
        }

        private void ConvSupNameFoundAndSelect(int iStartRow)
        {
            for (int iRow = iStartRow + 1; iRow < fgrid_cust_list_conv.Rows.Count; iRow++)
            {
                string sSupName = fgrid_cust_list_conv[iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME].ToString();

                if (sSupName.ToUpper().StartsWith(txt_conv_sup_name.Text.Trim().ToUpper()))
                {
                    if (!(fgrid_cust_list_conv.TopRow <= iRow && fgrid_cust_list_conv.BottomRow >= iRow))
                        fgrid_cust_list_conv.TopRow = iRow;
                    fgrid_cust_list_conv.Select(iRow, (int)ClassLib.TBSFX_CBD_M_CUST_LIST.IxMXS_LOCATIONNAME);
                    break;
                }
                else
                {
                    if (iRow == fgrid_cust_list_conv.Rows.Count - 1)
                    {
                        ConvSupNameFoundAndSelect(fgrid_cust_list_conv.Rows.Fixed - 1);
                        break;
                    }
                    else if (iRow == fgrid_cust_list_conv.Row)
                    {
                        break;
                    }
                }
            }
        }

        #endregion

        #endregion

        #region 디비 연결

        #region 조건

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_SFX_CBD_M_CUST_LIST(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_LIST";

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

                return SELECT_SFX_CBD_M_CUST_LIST_ALL(arg_factory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_LIST_ALL : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_SFX_CBD_M_CUST_LIST_ALL(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_LIST_ALL";

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

        #region 조회

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_INFO : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_CUST_INFO(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_CUST_INFO";

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

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_MAT_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_MAT_LIST(string arg_factory, string arg_mxs_div, string arg_mxs_locationcode, string arg_mat_code, string arg_mat_name)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_MAT_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_DIV";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[3] = "ARG_MAT_CODE";
                MyOraDB.Parameter_Name[4] = "ARG_MAT_NAME";
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
                MyOraDB.Parameter_Values[1] = arg_mxs_div;
                MyOraDB.Parameter_Values[2] = arg_mxs_locationcode;
                MyOraDB.Parameter_Values[3] = arg_mat_code;
                MyOraDB.Parameter_Values[4] = arg_mat_name;
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

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_MAT_HISTORY : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_MAT_HISTORY(string arg_factory, string arg_mxs_number, string arg_mxs_unit, string arg_mxs_special_option, string arg_mxs_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_MAT_HISTORY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[2] = "ARG_MXS_UNIT";
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
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mxs_number;
                MyOraDB.Parameter_Values[2] = arg_mxs_unit;
                MyOraDB.Parameter_Values[3] = arg_mxs_special_option;
                MyOraDB.Parameter_Values[4] = arg_mxs_seq;
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

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_REINFORCE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_REINFORCE(string arg_factory, string arg_mat_number, string arg_mat_name)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_REINFORCE";

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
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mat_number;
                MyOraDB.Parameter_Values[2] = arg_mat_name;
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

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_MAT_CONV_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_M_MAT_CONV_LIST(string arg_factory, string arg_mxs_locationcode)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_CBD_M_MAT_CONV_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mxs_locationcode;
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

        /// <summary>
        /// PKG_SFX_CBD_M_MAT.CONFIRM_SFX_CBD_M_CUST : 
        /// </summary>
        public bool CONFIRM_SFX_CBD_M_CUST(string arg_factory, string arg_upd_user)
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.CONFIRM_SFX_CBD_M_CUST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(true);
                return UPDATE_SFX_CBD_M_MAT(arg_factory, arg_upd_user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFX_BATCH_01.UPDATE_SFX_CBD_M_MAT : 
        /// </summary>
        public bool UPDATE_SFX_CBD_M_MAT(string arg_factory, string arg_upd_user)
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_BATCH_01.UPDATE_SFX_CBD_M_MAT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(false);
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

    }
}

