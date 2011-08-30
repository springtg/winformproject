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

namespace FlexCDC.Scheduling
{
    public partial class Pop_Value_Change : COM.PCHWinForm.Pop_Small
    {
        #region 사용자 정의 변수
        public BaseInfo.Form_Calendar arg_request = null;
        private COM.OraDB MyOraDB = new COM.OraDB();
        DataTable dt_ret = null;
        string factory = "";
        string work_ymd = "";
        string holy_yn = "";
        string remarks = "";

        public DialogResult dd;
        #endregion

        public Pop_Value_Change()
        {
            InitializeComponent();
        }

        public Pop_Value_Change(BaseInfo.Form_Calendar arg_request1, DataTable arg_dt, string arg_factory, string arg_work_ymd, string arg_holy_yn, string arg_remarks)
        {
            InitializeComponent();
            arg_request = arg_request1;
            dt_ret      = arg_dt;
            factory     = arg_factory;
            work_ymd    = arg_work_ymd;
            holy_yn     = arg_holy_yn;
            remarks     = arg_remarks;
        }


        private void Init_Form()
        {
            this.Text = "Value Change";
            this.lbl_MainTitle.Text = "Value Change";

            try
            {  

                cmb_work_div.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
                cmb_work_div.ClearItems();

                cmb_work_div.AddItemTitles("Code;Name");

                cmb_work_div.ValueMember = "Code";
                cmb_work_div.DisplayMember = "Name";

                //////////////////////////////////////////////////////

                cmb_work_div.AddItem("Y;HOLIDAY");
                cmb_work_div.AddItem("N;WORK");

                cmb_work_div.SelectedIndex = -1;

                cmb_work_div.MaxDropDownItems = 10;
                cmb_work_div.Splits[0].DisplayColumns[0].Width = 0;
                cmb_work_div.Splits[0].DisplayColumns[1].Width = 220;

                cmb_work_div.ExtendRightColumn = true;
                cmb_work_div.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
                cmb_work_div.HScrollBar.Height = 0;

                cmb_work_div.SelectedValue = holy_yn;
            }
            catch 
            {
               
            }        

            //txt_remark.CharacterCasing = CharacterCasing.Upper;
            txt_remark.Text = remarks.Trim();
 
        }

        private void Pop_Value_Change_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                
                string _work_desc  = cmb_work_div.Text.Trim();
                string _holiday_yn = cmb_work_div.SelectedValue.ToString().Trim();
                string _remarks = ClassLib.ComFunction.Empty_TextBox(txt_remark, "");

                Update_Calendar(factory, work_ymd, _work_desc, _holiday_yn, _remarks);

                if (!COM.ComVar.This_Factory.Equals("DS"))
                {
                    if (holy_yn != _holiday_yn)
                        Update_Work_Data(factory, work_ymd, _holiday_yn);
                }



                //int [] selectrow = arg_request.fgrid_Main.Selections;

                //int sctrow_f = arg_request.fgrid_Main.Selection.r1;
                //int sctrow_l = arg_request.fgrid_Main.Selection.r2;
                //int sctclo_f = arg_request.fgrid_Main.Selection.c1;
                //int sctclo_l = arg_request.fgrid_Main.Selection.c2;

                //for (int i = sctrow_f; i <= sctrow_l; i++)
                //{
                //    for (int j = sctclo_f; j <= sctclo_l; j++)
                //    {
                //        if (arg_request.fgrid_Main[i, j].ToString().Trim() != "")
                //        {
                //            string _work_day = (arg_request.fgrid_Main[i, j].ToString().Length == 2) ? arg_request.fgrid_Main[i, j].ToString() : "0" + arg_request.fgrid_Main[i, j].ToString();
                //            string _work_ymd = work_ymd + _work_day.Substring(0,2);
                //            string _work_desc = cmb_work_div.Text.Trim();
                //            string _holiday_yn = cmb_work_div.SelectedValue.ToString().Trim();
                //            string _remarks = ClassLib.ComFunction.Empty_TextBox(txt_remark, "");

                //            Update_Calendar(factory, _work_ymd, _work_desc, _holiday_yn, _remarks);
                //        }
                //    }
                //}

                dd = DialogResult.OK;
                
            }
            catch
            {
                this.Cursor = Cursors.Default; 
            }                    
            finally
            {
                this.Cursor = Cursors.Default;
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dd = DialogResult.None;
            this.Close();
        }

        private void Update_Calendar(string arg_factory, string arg_work_ymd, string arg_work_desc, string arg_holiday_yn, string arg_remarks)
        {

            MyOraDB.ReDim_Parameter(5);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "PKG_SXB_BASE_02.UPDATE_CALENDAR";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_WORK_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_WORK_DESC";
            MyOraDB.Parameter_Name[3] = "ARG_HOLIDAY_YN";
            MyOraDB.Parameter_Name[4] = "ARG_REMARKS";


            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_work_ymd;
            MyOraDB.Parameter_Values[2] = arg_work_desc;
            MyOraDB.Parameter_Values[3] = arg_holiday_yn;
            MyOraDB.Parameter_Values[4] = arg_remarks;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void Update_Work_Data(string arg_factory, string arg_work_ymd, string arg_holiday_yn)
        {

            MyOraDB.ReDim_Parameter(4);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "pkg_sxg_mps_02.save_sxg_mps_calendar";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_WORK_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_HOLIDAY_YN";
            MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";


            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_work_ymd;
            MyOraDB.Parameter_Values[2] = arg_holiday_yn;
            MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
    }
}

