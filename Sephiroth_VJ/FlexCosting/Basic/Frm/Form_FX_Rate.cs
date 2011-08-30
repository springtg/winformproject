using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Frm
{
    public partial class Form_FX_Rate : COM.PCHWinForm.Form_Top
    {
        public Form_FX_Rate()
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

        private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridBeforeEdit();
        }

        private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            GridAfterEdit();
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void cmb_seasonFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SelectNextSeason();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Season selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_seasonTo_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
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
                this.Text = "F/X Rate management";
                this.lbl_MainTitle.Text = "F/X Rate management";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                Init_Control();
                //Init_Toolbar();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SXF_CBD_M_FXRATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.ExtendLastCol = false;
        }

        private void Init_Control()
        {
            FlexCosting.ClassLib.ComFunction_Cost comFnc = new FlexCosting.ClassLib.ComFunction_Cost();

            DataTable vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_seasonFrom, 0, 1, false, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_seasonTo, 0, 1, false, false);
            vDT.Dispose();

            int curMon = (int)Math.Ceiling((double)System.DateTime.Now.Month / 4);
            cmb_seasonFrom.SelectedValue = System.DateTime.Now.Year + "0" + curMon;
        }

        private void Init_Toolbar()
        {

        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_main.ClearAll();
        }

        private void Search()
        {
            string sFactory = COM.ComVar.This_Factory;
            string sSeasonFrom = COM.ComFunction.Empty_Combo(cmb_seasonFrom, "");
            string sSeasonTo = COM.ComFunction.Empty_Combo(cmb_seasonTo, "");

            DataTable vDT = SELECT_FXRATE_BY_SEASON(sFactory, sSeasonFrom, sSeasonTo);

            fgrid_main.ClearAll();
            if (vDT != null)
            {
                fgrid_main.Display_Grid(vDT, false);
                fgrid_main.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;

                fgrid_main.Cols[0].AllowMerging = false;
                for (int col = fgrid_main.Cols.Frozen; col < fgrid_main.Cols.Count; col++)
                {
                    fgrid_main.Cols[col].AllowMerging = false;
                } 
            }
        }

        private void Save()
        {
            //MyOraDB.Save_FlexGird("PKG_SFB_CBD_B_FXRATE.SAVE_FXRATE_BY_SEASON", fgrid_main);
            if (SAVE_FXRATE_BY_SEASON())
            {
                Search();
            }
        }

        #endregion

        #region 그리드 이벤트

        private void GridAfterEdit()
        {
            int row = fgrid_main.Row, col = fgrid_main.Col;
            int[] sels = fgrid_main.Selections;

            foreach (int row1 in sels)
            {
                fgrid_main[row1, col] = fgrid_main[row, col];
                fgrid_main.Update_Row(row1);

                fgrid_main[row1, (int)ClassLib.TBSXF_CBD_M_FXRATE.IxUPD_USER] = COM.ComVar.This_User;
                fgrid_main[row1, (int)ClassLib.TBSXF_CBD_M_FXRATE.IxUPD_YMD] = DateTime.Now;
            }            
        }

        private void GridBeforeEdit()
        {
            if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
                fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void SelectNextSeason()
        {
            if (cmb_seasonFrom.SelectedIndex - 3 < 0)
                cmb_seasonTo.SelectedIndex = 0;
            else
                cmb_seasonTo.SelectedIndex = cmb_seasonFrom.SelectedIndex - 3;

        }

        #endregion

        #endregion

        #region 디비 연결

        #region 조건



        #endregion

        #region 조회

        /// <summary>
        /// PKG_SFB_CBD_B_FXRATE.SELECT_FXRATE_BY_SEASON : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_FXRATE_BY_SEASON(string arg_factory, string arg_season_from, string arg_season_to)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_FXRATE.SELECT_FXRATE_BY_SEASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season_from;
                MyOraDB.Parameter_Values[2] = arg_season_to;
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
        /// PKG_SFB_CBD_B_FXRATE.SAVE_FXRATE_BY_SEASON : 
        /// </summary>
        public bool SAVE_FXRATE_BY_SEASON()
        {
            try
            {

                MyOraDB.ReDim_Parameter(11);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_CBD_B_FXRATE.SAVE_FXRATE_BY_SEASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_NAME";
                MyOraDB.Parameter_Name[2] = "ARG_CURR_NAME";
                MyOraDB.Parameter_Name[3] = "ARG_COUNTRY_NAME";
                MyOraDB.Parameter_Name[4] = "ARG_FX_RATE";
                MyOraDB.Parameter_Name[5] = "ARG_STATUS";
                MyOraDB.Parameter_Name[6] = "ARG_APP_DATE";
                MyOraDB.Parameter_Name[7] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[8] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[9] = "ARG_CURR_CD";
                MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";

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
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;

                //04.DATA 정의
                ArrayList aList = new ArrayList();

                for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
                {
                    if (fgrid_main[row, 0] != null && fgrid_main[row, 0].Equals("U"))
                    {
                        aList.Add(NullToBlank(fgrid_main[row, 0]));
                        aList.Add(NullToBlank(fgrid_main[row, 1]));
                        aList.Add(NullToBlank(fgrid_main[row, 2]));
                        aList.Add(NullToBlank(fgrid_main[row, 3]));
                        aList.Add(NullToBlank(fgrid_main[row, 4]));
                        aList.Add(NullToBlank(fgrid_main[row, 5]));
                        aList.Add(NullToDate(fgrid_main[row, 6]));
                        aList.Add(NullToBlank(fgrid_main[row, 7]));
                        aList.Add(NullToBlank(fgrid_main[row, 8]));
                        aList.Add(NullToBlank(fgrid_main[row, 9]));
                        aList.Add(COM.ComVar.This_User);
                    }
                }

                MyOraDB.Parameter_Values = (string[])aList.ToArray(typeof(string));

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();
                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private string NullToBlank(object arg_obj)
        {
            if (arg_obj != null)
            {
                return arg_obj.ToString();
            }

            return "";
        }

        private string NullToDate(object arg_obj)
        {
            if (arg_obj != null)
            {
                DateTime dt = (System.DateTime)arg_obj;
                return dt.ToString("yyyyMMdd");
            }

            return System.DateTime.Now.ToString("yyyyMMdd");
        }

        #endregion

        #endregion

    }
}

