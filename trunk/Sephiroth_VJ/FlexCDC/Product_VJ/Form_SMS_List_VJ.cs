using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Product_VJ
{
    public partial class Form_SMS_List_VJ : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 立加 俺眉 积己      
        #endregion

        #region Resource
        public Form_SMS_List_VJ()
        {
            InitializeComponent();
        }
        #endregion
                
        #region Form Loading

        private void Form_SMS_List_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

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

        public void Init_Form()
        {
            //Title Setting
            this.Text = "SMS List";
            this.lbl_MainTitle.Text = "SMS List";
            this.lbl_title.Text = "         SMS Information";
            ClassLib.ComFunction.SetLangDic(this);           

            #region combobox setting
            //Order Date
            dpick_from.Value = DateTime.Now.AddDays(-7);
            dpick_to.Value   = DateTime.Now;

            DataTable dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_dev, 0, 0, true, 0, 180);
            cmb_dev.SelectedIndex = 0;
                     

            dt_ret.Dispose();
            #endregion

            #region control setting

            tbtn_Search.Enabled = true;
            tbtn_Print.Enabled = true;
            tbtn_Create.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Delete.Enabled = false;
            
            #endregion
            
            Init_Grid();
        }       
        private void Init_Grid()
        {
            #region Grid setting
            fgrid_main.Set_Grid_CDC("SDK_SMS_SEND_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
            #endregion
        }
        
        private DataTable SELECT_USER()
        {
            MyOraDB.ReDim_Parameter(1);

            MyOraDB.Process_Name = "PKG_SXG_SMS_SELECT.SELECT_USER_VJ";

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet dt_ret = MyOraDB.Exe_Select_Procedure();

            if (dt_ret == null) return null;

            return dt_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
                string arg_month_from = dpick_from.Value.ToString("yyyyMMdd");
                string arg_month_to   = dpick_to.Value.ToString("yyyyMMdd");
                string arg_dest_name  = cmb_dev.SelectedValue.ToString().Trim();

                DataTable dt_ret = Select_sms_send(arg_month_from, arg_month_to, arg_dest_name);

                if (dt_ret.Rows.Count > 0)
                {
                    Display_Grid(dt_ret, fgrid_main);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_grid)
        {
            arg_grid.Rows.Count = arg_grid.Rows.Fixed;

            fgrid_main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_grid.Rows.Add();

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_grid[arg_grid.Rows.Count - 1, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
            }
        }
        private DataTable Select_sms_send(string arg_month_from, string arg_month_to, string arg_dest_name)
        {
            MyOraDB.ReDim_Parameter(4);

            MyOraDB.Process_Name = "PKG_SXG_SMS_SELECT.SELECT_SMS_SEND_VJ";

            MyOraDB.Parameter_Name[0] = "ARG_MONTH_FROM";
            MyOraDB.Parameter_Name[1] = "ARG_MONTH_TO";
            MyOraDB.Parameter_Name[2] = "ARG_DEST_NAME";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month_from;
            MyOraDB.Parameter_Values[1] = arg_month_to;
            MyOraDB.Parameter_Values[2] = arg_dest_name;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet dt_ret = MyOraDB.Exe_Select_Procedure();

            if (dt_ret == null) return null;

            return dt_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion
        
        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
             try
            {
              
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;


                string _month_from = dpick_from.Value.ToString("yyyyMMdd");
                string _month_to   = dpick_to.Value.ToString("yyyyMMdd");                
                string _dest_name = cmb_dev.SelectedValue.ToString().Trim();

                string mrd_Filename = Application.StartupPath + @"\Report_VJ\\SMS_List_VJ" + ".mrd";
                string sPara = " /rp " +  "[" + _month_from + "]" +  "[" + _month_to + "]" + "[" + _dest_name + "]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();   
            }
            catch
            {

            }
        }        
        #endregion        
    }
}

