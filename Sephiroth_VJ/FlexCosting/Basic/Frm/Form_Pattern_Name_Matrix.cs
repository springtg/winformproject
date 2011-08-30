using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Frm
{
    public partial class Form_Pattern_Name_Matrix : COM.PCHWinForm.Pop_Large
    {
        public Form_Pattern_Name_Matrix()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        #endregion

        #region 이벤트 핸들러

        #region 툴바 이벤트

        private void Form_Pattern_Name_Matrix_Load(object sender, EventArgs e)
        {
            Init_Control();
            Init_Toolbar();
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

                ClearAll();
                Search();

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

                Save();

                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
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

        private void fgrid_part_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_part.Rows.Fixed < fgrid_part.Rows.Count && fgrid_part.Rows.Fixed <= fgrid_part.Row)
                {
                    fgrid_matrix.ClearAll();
                    SearchPatternMatrix(fgrid_part.Row);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_matrix_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridAfterEdit();
        }

        private void fgrid_matrix_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridBeforeEdit();
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (fgrid_part.Rows.Fixed < fgrid_part.Rows.Count && fgrid_part.Rows.Fixed <= fgrid_part.Row)
                AddPtnMatrixRow();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (fgrid_part.Rows.Fixed < fgrid_part.Rows.Count && fgrid_part.Rows.Fixed <= fgrid_part.Row)
                fgrid_matrix.Delete_Row();
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
                this.Text = "Pattern name matrix";
                this.lbl_MainTitle.Text = "Pattern name matrix";
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
            fgrid_part.Set_Grid("SFB_CBD_B_PTN_MATRIX", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_part.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_part.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;

            fgrid_matrix.Set_Grid("SFB_CBD_B_PTN_MATRIX", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_matrix.Set_Action_Image(img_Action);
            fgrid_matrix.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_matrix.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComFunction.Set_Factory_List(vDT, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();
            cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

            vDT.Dispose();
        }

        private void Init_Toolbar()
        {
            tbtn_New.Enabled = true;
            tbtn_Search.Enabled = true;
            tbtn_Save.Enabled = true;
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_part.ClearAll();
            fgrid_matrix.ClearAll();
        }

        private void Search()
        {
            SearchPart();

            if (fgrid_part.Rows.Fixed < fgrid_part.Rows.Count)
            {
                fgrid_part.Select(fgrid_part.Rows.Fixed, 0);
                SearchPatternMatrix(fgrid_part.Row);
            }
        }

        private void SearchPart()
        {
            string sFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
            string sCmp = txt_cmp.Text;

            DataTable vDT = SELECT_SXD_SRF_M_PART(sFactory, sCmp);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_part.ClearAll();
                fgrid_part.Display_Grid(vDT, false);
            }
        }

        private void SearchPatternMatrix(int arg_row)
        {
            string sFactory = fgrid_part[arg_row, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_PART.IxFACTORY].ToString();
            string sPartSeq = fgrid_part[arg_row, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_PART.IxPART_SEQ].ToString();

            DataTable vDT = SELECT_SXD_SRF_M_PART_REL(sFactory, sPartSeq);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_matrix.ClearAll();
                fgrid_matrix.Display_Grid(vDT, false);
            }
        }

        private void Save()
        {
            if (MyOraDB.Save_FlexGird("PKG_SXD_SRF_M_PART.SAVE_SFB_CBD_B_PART_REL", fgrid_matrix))
            {
                SearchPatternMatrix(fgrid_part.Row);
            }
        }

        #endregion

        #region 그리드 이벤트

        private void GridAfterEdit()
        {
            fgrid_matrix.Update_Row();

            fgrid_matrix[fgrid_matrix.Row, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxUPD_USER] = COM.ComVar.This_User;
            fgrid_matrix[fgrid_matrix.Row, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxUPD_YMD] = DateTime.Now;
        }

        private void GridBeforeEdit()
        {
            if ((fgrid_matrix.Rows.Fixed > 0) && (fgrid_matrix.Row >= fgrid_matrix.Rows.Fixed))
                fgrid_matrix.Buffer_CellData = (fgrid_matrix[fgrid_matrix.Row, fgrid_matrix.Col] == null) ? "" : fgrid_matrix[fgrid_matrix.Row, fgrid_matrix.Col].ToString();
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void AddPtnMatrixRow()
        {
            int pRow = fgrid_part.Row;

            fgrid_matrix.Add_Row(fgrid_matrix.Rows.Count - 1);
            int nRow = fgrid_matrix.Rows.Count - 1;

            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxFACTORY] = fgrid_part[pRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_PART.IxFACTORY];
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxPART_SEQ] = fgrid_part[pRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_PART.IxPART_SEQ];
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxPART_TYPE] = "";
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxPART_CLASS] = "";
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxPART_NAME] = fgrid_part[pRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_PART.IxPART_DESC];
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxUSE_YN] = "Y";
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxUPD_USER] = COM.ComVar.This_User;
            fgrid_matrix[nRow, (int)ClassLib.TBSFB_CBD_B_PTN_MATRIX_REL.IxUPD_YMD] = DateTime.Now;
        }

        #endregion

        #endregion

        #region 디비 연결

        #region 조건



        #endregion

        #region 조회



        /// <summary>
        /// PKG_SXD_SRF_M_PART.SELECT_SXD_SRF_M_PART :
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_PART(string arg_factory, string arg_search_text)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXD_SRF_M_PART.SELECT_SXD_SRF_M_PART";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEARCH_TEXT";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_search_text;
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
        /// PKG_SXD_SRF_M_PART.SELECT_SXD_SRF_M_PART_REL : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SXD_SRF_M_PART_REL(string arg_factory, string arg_part_seq)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXD_SRF_M_PART.SELECT_SXD_SRF_M_PART_REL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PART_SEQ";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_part_seq;
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

        #endregion

    }
}

