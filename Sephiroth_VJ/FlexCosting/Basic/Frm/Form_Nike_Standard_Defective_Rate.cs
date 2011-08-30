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
    public partial class Form_Nike_Standard_Defective_Rate : COM.PCHWinForm.Form_Top
    {
        public Form_Nike_Standard_Defective_Rate()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        #endregion

        #region 이벤트 핸들러

        #region 툴바 이벤트

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

                Search();

                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
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
                    fgrid_tail.Refresh_Division();
                }
                else
                {
                    COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        private void fgrid_head_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_head.Row >= fgrid_head.Rows.Fixed)
                {
                    dpick_appDate.Enabled = false;
                    txt_contents.ReadOnly = false;

                    string sfactory = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxFACTORY].ToString();
                    string sAppDate = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxAPPLIED_DATE].ToString();
                    string sContents = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxCONTENTS].ToString();

                    DateTime dLastDate = new DateTime(int.Parse(sAppDate.Substring(0, 4)), int.Parse(sAppDate.Substring(4, 2)), int.Parse(sAppDate.Substring(6, 2)));
                    dpick_appDate.Value = dLastDate;
                    txt_contents.Text = sContents;

                    SearchTail(sfactory, sAppDate);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void fgrid_tail_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridAfterEdit(sender as COM.FSP);
        }

        private void fgrid_tail_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridBeforeEdit(sender as COM.FSP);
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable vDT = SELECT_LAST_DATE(COM.ComVar.This_Factory);
                string sLastDate = vDT.Rows[0][0].ToString();
                string[] sLastDateArr = sLastDate.Split(':');

                DateTime dLastDate = new DateTime(int.Parse(sLastDateArr[0]), int.Parse(sLastDateArr[1]), int.Parse(sLastDateArr[2]));
                dpick_appDate.Value = dLastDate;
                txt_contents.Text = "";

                SearchTail(COM.ComVar.This_Factory, dpick_appDate.Value.ToString("yyyyMMdd"));

                dpick_appDate.Enabled = true;
                txt_contents.ReadOnly = false;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dpick_appDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string sfactory = COM.ComVar.This_Factory;
                string sAppDate = dpick_appDate.Value.ToString("yyyyMMdd");

                SearchHead(sfactory);
                for (int row = fgrid_head.Rows.Fixed; row < fgrid_head.Rows.Count; row++)
                {
                    string sAppD = fgrid_head[row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxAPPLIED_DATE].ToString();
                    if (sAppD.Equals(sAppDate))
                    {
                        fgrid_head.Select(row, 0);
                        fgrid_head_MouseUp(fgrid_head, null);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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
                this.Text = "Nike standard defective rate";
                this.lbl_MainTitle.Text = "Nike standard defective rate";
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
            fgrid_head.Set_Grid("SFB_NIKE_STD_DEFECTIVE_RATE_HEAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_head.Set_Action_Image(img_Action);
            fgrid_head.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_head.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_head.ExtendLastCol = false;

            fgrid_tail.Set_Grid("SFB_NIKE_STD_DEFECTIVE_RATE_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_tail.Set_Action_Image(img_Action);
            fgrid_tail.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_tail.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_tail.ExtendLastCol = false;
        }

        private void Init_Control()
        {
            dpick_appDate.Enabled = false;
            txt_contents.ReadOnly = true;
        }

        private void Init_Toolbar()
        {
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_head.ClearAll();
            fgrid_tail.ClearAll();
        }

        private void Search()
        {
            dpick_appDate.Enabled = false;
            txt_contents.ReadOnly = true;
            dpick_appDate.Value = DateTime.Now;
            txt_contents.Text = "";

            string sfactory = COM.ComVar.This_Factory;

            ClearAll();
            SearchHead(sfactory);

            if (fgrid_head.Rows.Fixed < fgrid_head.Rows.Count)
            {
                sfactory = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxFACTORY].ToString();
                string sAppDate = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxAPPLIED_DATE].ToString();
                string sContents = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxCONTENTS].ToString();

                DateTime dLastDate = new DateTime(int.Parse(sAppDate.Substring(0, 4)), int.Parse(sAppDate.Substring(4, 2)), int.Parse(sAppDate.Substring(6, 2)));
                dpick_appDate.Value = dLastDate;
                txt_contents.Text = sContents;

                fgrid_head.Select(fgrid_head.Rows.Fixed, 0);
                SearchTail(sfactory, sAppDate);
            }
        }

        // 외부에서 호출 가능한 메서드 
        public void Search(string asFactory, string asAppDate)
        {
            tbtn_New.Enabled = false;
            tbtn_Search.Enabled = false;
            tbtn_Save.Enabled = false;
            btn_New.Enabled = false;
            fgrid_head.AllowEditing = false;
            fgrid_tail.AllowEditing = false;

            dpick_appDate.Enabled = false;
            txt_contents.ReadOnly = true;
            txt_contents.BackColor = Color.WhiteSmoke;
            dpick_appDate.Value = DateTime.Now;
            txt_contents.Text = "";

            string sfactory = asFactory;

            ClearAll();
            SearchHead(sfactory);

            if (fgrid_head.Rows.Fixed < fgrid_head.Rows.Count)
            {
                for (int iHRow = fgrid_head.Rows.Count - 1; iHRow >= fgrid_head.Rows.Fixed; iHRow--)
                {
                    string sAppDate = fgrid_head[iHRow, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxAPPLIED_DATE].ToString();
                    if (sAppDate.Equals(asAppDate))
                    {
                        fgrid_head.Select(iHRow, 0);
                        break;
                    }
                }

                if (fgrid_head.Row >= fgrid_head.Rows.Fixed)
                {
                    sfactory = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxFACTORY].ToString();
                    string sAppDate = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxAPPLIED_DATE].ToString();
                    string sContents = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxCONTENTS].ToString();

                    DateTime dLastDate = new DateTime(int.Parse(sAppDate.Substring(0, 4)), int.Parse(sAppDate.Substring(4, 2)), int.Parse(sAppDate.Substring(6, 2)));
                    dpick_appDate.Value = dLastDate;
                    txt_contents.Text = sContents;

                    SearchTail(sfactory, sAppDate);
                }
            }
        }

        private void SearchHead(string sFactory)
        {
            DataTable vHDT = SELECT_SFB_CBD_B_LOSSRATE_HEAD(sFactory);
            fgrid_head.Display_Grid(vHDT, false);
        }

        private void SearchTail(string sFactory, string sAppDate)
        {
            DataTable vTDT = SELECT_SFB_CBD_B_LOSSRATE_TAIL(sFactory, sAppDate);
            fgrid_tail.Display_Grid(vTDT, false);
            fgrid_tail.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;

            fgrid_tail.Cols[0].AllowMerging = false;
            for (int col = fgrid_tail.Cols.Frozen; col < fgrid_tail.Cols.Count; col++)
            {
                fgrid_tail.Cols[col].AllowMerging = false;
            } 
        }

        private bool Save()
        {
            for (int row = fgrid_tail.Rows.Fixed; row < fgrid_tail.Rows.Count; row++)
            {
                fgrid_tail[row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_TAIL.IxCONTENTS] = txt_contents.Text;
                fgrid_tail[row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_TAIL.IxAPP_DATE] = dpick_appDate.Value.ToString("yyyyMMdd");
                fgrid_tail[row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_TAIL.IxUPDATE_USER] = COM.ComVar.This_User;
                fgrid_tail.Update_Row(row);
            }

            if (MyOraDB.Save_FlexGird("PKG_SFB_CBD_B_LOSSRATE.SAVE_SFB_CBD_B_LOSSRATE", fgrid_tail))
            {
                string sfactory = fgrid_head[fgrid_head.Row, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxFACTORY].ToString();
                string sAppDate = dpick_appDate.Value.ToString("yyyyMMdd");

                SearchHead(sfactory);

                for (int hrow = fgrid_head.Rows.Fixed; hrow < fgrid_head.Rows.Count; hrow++)
                {
                    string sfactory2 = fgrid_head[hrow, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxFACTORY].ToString();
                    string sAppDate2 = fgrid_head[hrow, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxAPPLIED_DATE].ToString();
                    string sContents2 = fgrid_head[hrow, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD.IxCONTENTS].ToString();

                    if (sfactory2.Equals(sfactory) && sAppDate2.Equals(sAppDate))
                    {
                        DateTime dLastDate = new DateTime(int.Parse(sAppDate2.Substring(0, 4)), int.Parse(sAppDate2.Substring(4, 2)), int.Parse(sAppDate2.Substring(6, 2)));
                        dpick_appDate.Value = dLastDate;
                        txt_contents.Text = sContents2;

                        fgrid_head.Select(hrow, 0);
                        SearchTail(sfactory, sAppDate);
                        break;
                    }
                }
            }

            return true;
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

                arg_grid[row1, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_TAIL.IxUPDATE_USER] = COM.ComVar.This_User;
                arg_grid[row1, (int)ClassLib.TBSFB_NIKE_STD_DEFECTIVE_RATE_TAIL.IxUPDATE_YMD] = DateTime.Now;
            }
        }

        private void GridBeforeEdit(COM.FSP arg_grid)
        {
            if ((arg_grid.Rows.Fixed > 0) && (arg_grid.Row >= arg_grid.Rows.Fixed))
                arg_grid.Buffer_CellData = (arg_grid[arg_grid.Row, arg_grid.Col] == null) ? "" : arg_grid[arg_grid.Row, arg_grid.Col].ToString();
        }

        #endregion

        #region 버튼 및 기타 이벤트


        #endregion

        #endregion

        #region 디비 연결

        #region 조건

        /// <summary>
        /// PKG_SFB_CBD_B_LOSSRATE.SELECT_LAST_DATE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_LAST_DATE(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_LOSSRATE.SELECT_LAST_DATE";

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

        #region 조회

        /// <summary>
        /// PKG_SFB_CBD_B_LOSSRATE.SELECT_SFB_CBD_B_LOSSRATE_HEAD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFB_CBD_B_LOSSRATE_HEAD(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_LOSSRATE.SELECT_SFB_CBD_B_LOSSRATE_HEAD";

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
        /// PKG_SFB_CBD_B_LOSSRATE.SELECT_SFB_CBD_B_LOSSRATE_TAIL : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFB_CBD_B_LOSSRATE_TAIL(string arg_factory, string arg_app_date)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_LOSSRATE.SELECT_SFB_CBD_B_LOSSRATE_TAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_APP_DATE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_app_date;
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

