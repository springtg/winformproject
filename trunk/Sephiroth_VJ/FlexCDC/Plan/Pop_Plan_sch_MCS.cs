using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Plan
{
    public partial class Pop_Plan_sch_MCS : COM.PCHWinForm.Pop_Large_B
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string _form_type = "";
        public string _mcs_no = "", _color_name = "", _color_cd = "";
        #endregion

        #region 생성자
        public Pop_Plan_sch_MCS()
        {
            InitializeComponent();
        }
        public Pop_Plan_sch_MCS(string arg_form_type, string arg_mcs, string arg_color, string arg_color_cd)
        {
            InitializeComponent();

            _form_type  = arg_form_type;
            _mcs_no     = arg_mcs;
            _color_name = arg_color;
            _color_cd   = arg_color_cd;
        }
        #endregion       

        #region Form Loading
        private void Pop_Plan_sch_MCS_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Init_Form()
        {
            this.Text = "MCS / Color";
            lbl_MainTitle.Text = "MCS / Color";

            Init_Control();

            //Grid Setting
            fgrid_mcs.Set_Grid_CDC("SXG_MCS_POP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_mcs.ExtendLastCol = false;
            fgrid_mcs.AllowDragging = AllowDraggingEnum.None;

            fgrid_color.Set_Grid_CDC("SXG_MCS_POP", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_color.ExtendLastCol = false;
            fgrid_color.AllowDragging = AllowDraggingEnum.None;
        }

        private void Init_Control()
        {
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_mcs.Enabled   = false;
            txt_color.Enabled = false;
            txt_color_name.Enabled = false;

            txt_mcs.Text        = _mcs_no;
            txt_color.Text      = _color_cd;
            txt_color_name.Text = _color_name;

            txt_mcs.BackColor        = SystemColors.Control;
            txt_color.BackColor      = SystemColors.Control;
            txt_color_name.BackColor = SystemColors.Control;
            
            txt_mcs.CharacterCasing        = CharacterCasing.Upper;
            txt_color.CharacterCasing      = CharacterCasing.Upper;            
            txt_color_name.CharacterCasing = CharacterCasing.Upper;
            txt_name.CharacterCasing       = CharacterCasing.Upper;

            if (_form_type.Equals("M"))
                tab_main.SelectedIndex = 0;
            else
                tab_main.SelectedIndex = 1;
        }

        private void Display_data()
        {
            string arg_factory = COM.ComVar.This_Factory;
            string arg_name = txt_name.Text.Trim();
            
            if (tab_main.SelectedIndex.Equals(0))
            {
                string arg_div = "M";

                fgrid_mcs.Rows.Count = fgrid_mcs.Rows.Fixed;

                DataTable dt_ret = Select_result_list(arg_factory, arg_name, arg_div);

                if (dt_ret.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_ret.Rows.Count; i++)
                    {
                        fgrid_mcs.Rows.Add();

                        for (int j = fgrid_mcs.Cols.Fixed;j < fgrid_mcs.Cols.Count; j++)
                        {
                            fgrid_mcs[fgrid_mcs.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                        }
                    }
                }
            }
            else
            {
                string arg_div = "C";

                fgrid_color.Rows.Count = fgrid_color.Rows.Fixed;

                DataTable dt_ret = Select_result_list(arg_factory, arg_name, arg_div);

                if (dt_ret.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_ret.Rows.Count; i++)
                    {
                        fgrid_color.Rows.Add();

                        for (int j = fgrid_color.Cols.Fixed;j < fgrid_color.Cols.Count; j++)
                        {
                            fgrid_color[fgrid_color.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                        }
                    }
                }
            }
            
        }

        private DataTable Select_result_list(string arg_factory, string arg_name, string arg_div)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_03_SELECT.SELECT_SPECIFIC_POP_MCS";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_NAME";
            MyOraDB.Parameter_Name[2] = "ARG_DIV";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_name;
            MyOraDB.Parameter_Values[2] = arg_div;
            MyOraDB.Parameter_Values[3] = "";

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

                Display_data();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;

                    Display_data();
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
        #endregion

        #region Grid Event
        private void fgrid_mcs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int sct_row = fgrid_mcs.Selection.r1;

                txt_mcs.Text = fgrid_mcs[sct_row, 2].ToString().Trim();
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private void fgrid_color_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int sct_row = fgrid_color.Selection.r1;

                txt_color.Text = fgrid_color[sct_row, 2].ToString().Trim();
                txt_color_name.Text = fgrid_color[sct_row, 3].ToString().Trim();
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion
        
        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _mcs_no     = txt_mcs.Text.Trim();
                _color_cd   = txt_color.Text.Trim();
                _color_name = txt_color_name.Text.Trim();
                                
                this.Close();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion        

        #region Control Setting
        private void chk_new_code_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_new_code.Checked)
                {
                    txt_mcs.Enabled = true;
                    txt_mcs.BackColor = SystemColors.Window;
                }
                else
                {
                    txt_mcs.Enabled = false;
                    txt_mcs.BackColor = SystemColors.Control;
                }
            }
            catch
            {

            }
        }
        #endregion
    }
}

