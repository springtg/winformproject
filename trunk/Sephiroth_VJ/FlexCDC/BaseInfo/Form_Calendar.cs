using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexCDC.BaseInfo
{
    public partial class Form_Calendar : COM.PCHWinForm.Pop_Large_B
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private bool first_flg = true;
        DataTable dt_ret = null;
        #endregion

        #region 생성자
        public Form_Calendar()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Calendar_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
        }

        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

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

        private void Init_Form()
        {

            this.Text = "PCC_Calendar";
            this.lbl_MainTitle.Text = "PCC_Calendar";
            ClassLib.ComFunction.SetLangDic(this);

            #region Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;            
            tbtn_Create.Enabled  = false;
            tbtn_Conform.Enabled = false;
            #endregion

            Year_Set();
            Month_Set();
            first_flg = false;

            #region Grid Setting
            fgrid_Main.Set_Grid_CDC("SXS_CALENDAR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            fgrid_Main.SelectionMode = SelectionModeEnum.CellRange;
            //fgrid_Main.ExtendLastCol = false;
            #endregion

            Display_Grid();
            
        }

        private void Year_Set()
        {
            DataTable dt_ret = Select_Work_Date_List(cmb_Factory.SelectedValue.ToString());

            cmb_year.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_year.ClearItems();

            cmb_year.AddItemTitles("Code;Year");

            cmb_year.ValueMember   = "Code";
            cmb_year.DisplayMember = "Year";

            //////////////////////////////////////////////////////
            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                cmb_year.AddItem(dt_ret.Rows[i].ItemArray[0].ToString() + ";" + dt_ret.Rows[i].ItemArray[0].ToString());
            }
            cmb_year.SelectedIndex = -1;

            cmb_year.MaxDropDownItems = 10;
            cmb_year.Splits[0].DisplayColumns[0].Width = 0;
            cmb_year.Splits[0].DisplayColumns[1].Width = 100;

            cmb_year.ExtendRightColumn = true;
            cmb_year.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_year.HScrollBar.Height = 0;

            cmb_year.SelectedValue = DateTime.Now.Year;
        }
        private void Month_Set()
        {


            cmb_month.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_month.ClearItems();

            cmb_month.AddItemTitles("Code;Month");

            cmb_month.ValueMember = "Code";
            cmb_month.DisplayMember = "Month";

            int startyear = 1;
            string month = "";
            //////////////////////////////////////////////////////
            for (int i = startyear; i <= 12; i++)
            {
                if (i.ToString().Length == 1)
                    month = "0" + i.ToString();
                else
                    month = i.ToString();

                cmb_month.AddItem(month + ";" + i);
            }
            cmb_month.SelectedIndex = -1;

            cmb_month.MaxDropDownItems = 10;
            cmb_month.Splits[0].DisplayColumns[0].Width = 0;
            cmb_month.Splits[0].DisplayColumns[1].Width = 100;

            cmb_month.ExtendRightColumn = true;
            cmb_month.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_month.HScrollBar.Height = 0;

            if (DateTime.Now.Month.ToString().Length == 1)
                month = "0" + DateTime.Now.Month.ToString();
            else
                month = DateTime.Now.Month.ToString();

            
            cmb_month.SelectedValue = month;
        }
        private void Display_Grid()
        {
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            string work_date = cmb_year.SelectedValue.ToString().Trim() + cmb_month.SelectedValue.ToString().Trim();
            dt_ret = Select_Calendar_List(cmb_Factory.SelectedValue.ToString(), work_date);

            int year = 0;
            int month = 0;
            int day = 0;
            int row = fgrid_Main.Rows.Count;

            fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);
            fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";
            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].Height = 90;
            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].TextAlign = TextAlignEnum.RightTop;

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                year = int.Parse(dt_ret.Rows[i].ItemArray[1].ToString().Trim().Substring(0, 4));
                month = int.Parse(dt_ret.Rows[i].ItemArray[1].ToString().Trim().Substring(4, 2));
                day = int.Parse(dt_ret.Rows[i].ItemArray[1].ToString().Trim().Substring(6, 2));

                DateTime daycheck = new DateTime(year, month, day);

                for (int j = 1; j <= fgrid_Main.Cols.Count; j++)
                {
                    if (fgrid_Main[1, j].ToString().Trim() == daycheck.DayOfWeek.ToString())
                    {
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j] = day.ToString() + "\r\n\r\n" + dt_ret.Rows[i].ItemArray[4].ToString().Trim();

                        if (dt_ret.Rows[i].ItemArray[3].ToString() == "Y")
                        {
                            fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, j).StyleNew.ForeColor = Color.Red;
                        }
                        break;
                    }
                }

                if (dt_ret.Rows.Count != day && daycheck.DayOfWeek.ToString() == Day.Saturday.ToString())
                {
                    fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);
                    fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].Height = 90;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].TextAlign = TextAlignEnum.RightTop;
                }


            }

            fgrid_Main.Cols[0].Width = 0;
        }

        private DataTable Select_Work_Date_List(string arg_factory)
        {

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_WORK_YMD";

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
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];

        }
        private DataTable Select_Calendar_List(string arg_factory, string arg_work_ymd)
        {

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_CALENDAR_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_WORK_YMD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_work_ymd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Control Event 
        private void cmb_year_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (first_flg)
                    return;

                Display_Grid();
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
        private void cmb_month_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (first_flg)
                    return;

                Display_Grid();
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
                
        #region Grid Event
        private void fgrid_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int sctrow = fgrid_Main.Selection.r1;
                int sctcol = fgrid_Main.Selection.c1;

                int day = 0;
                if (fgrid_Main[sctrow, sctcol].ToString().Trim().Length > 2)
                    day = int.Parse(fgrid_Main[sctrow, sctcol].ToString().Trim().Substring(0, fgrid_Main[sctrow, sctcol].ToString().Trim().IndexOf("\r")));
                else
                    day = int.Parse(fgrid_Main[sctrow, sctcol].ToString().Trim());

                string date = day.ToString();
                if (day.ToString().Length == 1)
                    date = "0" + date;

                string factory = cmb_Factory.SelectedValue.ToString();
                string work_ymd = cmb_year.SelectedValue.ToString().Trim() + cmb_month.SelectedValue.ToString().Trim() + date;
                string holy_yn = dt_ret.Rows[day - 1].ItemArray[3].ToString();
                string remarks = dt_ret.Rows[day - 1].ItemArray[4].ToString();

                Scheduling.Pop_Value_Change pop = new Scheduling.Pop_Value_Change(this, dt_ret, factory, work_ymd, holy_yn, remarks);
                pop.ShowDialog();

                if (pop.dd == DialogResult.OK)
                {
                    Display_Grid();
                    fgrid_Main.Select(sctrow, sctcol);                    
                }
            }
            catch
            {
 
            }
        }
        #endregion

    }
}

