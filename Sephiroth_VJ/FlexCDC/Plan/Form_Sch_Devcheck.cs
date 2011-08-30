using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.IO;
using Lassalle.Flow;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FlexCDC.Plan
{
    public partial class Form_Sch_Devcheck : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string[] nf_cd = new string[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxMAX_CNT];
        private string[] nf_seq = new string[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxMAX_CNT];
        private bool[] file_yn_set = new bool[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxMAX_CNT];
        private float _MaxImageWidth = 295;
        private float _MaxImageHeight = 223;
        private bool first_flg = false;
        private bool grid_size = false;

        private Outlook.Application outlook = null;
        private Outlook.MailItem mailitem = null;
        #endregion

        #region Resource
        public Form_Sch_Devcheck()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Sch_Devcheck_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Development Meeting";
            this.lbl_MainTitle.Text = "PCC_Development Meeting";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;
                        
            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_t, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_season_from.SelectedValue = "201004";
            cmb_season_to.SelectedValue = "201102";

            //dt_ret = SELECT_SEASON_DEFAULT();

            //if (dt_ret.Rows.Count > 0)
            //{
            //    string default_season = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
            //    cmb_season_from.SelectedValue = default_season;
            //    cmb_season_to.SelectedValue = default_season;

            //    cmb_season_from.SelectedIndex = cmb_season_from.SelectedIndex + 2;
            //    cmb_season_to.SelectedIndex = cmb_season_to.SelectedIndex - 3;
            //}
            //else
            //{
            //    cmb_season_from.SelectedValue = "201001";
            //    cmb_season_to.SelectedValue = "201001";
            //}

            //Season Detail            
            cmb_season_t.SelectedIndex = -1;
            
            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;
            //Category Detail
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category_t, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_category_t.SelectedIndex = -1;

            //User
            string _power_lev = COM.ComVar.This_CDCPower_Level;

            if (!_power_lev.Substring(0, 1).Equals("D"))
            {
                dt_ret = SELECT_USER();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                cmb_user.SelectedIndex = 0;
            }
            else
            {
                cmb_user.Enabled = false;

                DataTable user_datatable = new DataTable("UserList");
                DataRow newrow;

                user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                newrow = user_datatable.NewRow();
                newrow["Code"] = ClassLib.ComVar.This_User;
                newrow["Name"] = ClassLib.ComVar.This_User;

                user_datatable.Rows.Add(newrow);
                ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, 0, 200);
                cmb_user.SelectedValue = ClassLib.ComVar.This_User;
            }

            dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_cdc_dev_t, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_cdc_dev_t.SelectedIndex = -1;

            ////Gender
            //dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender_t, 1, 2, false, 0, 120);

            ////T_D
            //dt_ret = SELECT_TD();
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_td_t, 0, 1, false, 0, 120);
            //cmb_td_t.SelectedIndex = -1;
            #endregion

            #region Grid Setting
            //Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_DEVCHECK", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;           

            fgrid_main.ExtendLastCol = false;
            fgrid_main.AllowDragging = AllowDraggingEnum.None;            
            fgrid_main.KeyActionEnter = KeyActionEnum.None;

            //Detail Grid
            fgrid_detail.Set_Grid_CDC("SXC_SCH_DEVCHECK_DETAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_detail.Set_Action_Image(img_Action);
            fgrid_detail.AllowDragging = AllowDraggingEnum.None;
            fgrid_detail.AllowSorting = AllowSortingEnum.None;

            fgrid_detail.ExtendLastCol = false;
            fgrid_detail.AllowDragging = AllowDraggingEnum.None;            
            fgrid_detail.KeyActionEnter = KeyActionEnum.None;

            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04).StyleNew.ForeColor = Color.Black;

            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04).StyleNew.ForeColor = Color.Black;

            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04).StyleNew.ForeColor = Color.Black;

            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN180_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN280_T01).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_detail.GetCellRange(fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN180_T01, fgrid_detail.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN280_T01).StyleNew.ForeColor = Color.Black;
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;

            chk_lks.Checked = true;
            chk_smm.Checked = true;
            chk_rlf.Checked = true;
            chk_acnt.Checked = true;
            chk_gtm.Checked = true;
            #endregion 
        }

        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_SEASON";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;
                                
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_SEASON_DEFAULT()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_SEASON_DEFAULT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_YEAR_MONTH";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = DateTime.Now.ToString("yyyyMM");
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_CATEGORY()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_CATEGORY";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null; 
            }
        }
        private DataTable SELECT_USER()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_USER";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_TD()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_TD";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
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
            catch(Exception ex)
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
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            string[] arg_value = new string[9];

            arg_value[0] = cmb_factory.SelectedValue.ToString();            
            arg_value[1] = cmb_season_from.SelectedValue.ToString();
            arg_value[2] = cmb_season_to.SelectedValue.ToString();
            arg_value[3] = cmb_category.SelectedValue.ToString();
            arg_value[4] = txt_model.Text.Trim();
            arg_value[5] = cmb_user.SelectedValue.ToString();
            arg_value[6] = (chk_pt.Checked) ? "Y" : "N";
            arg_value[7] = (chk_file.Checked) ? "Y" : "N";
            arg_value[8] = (chk_image.Checked) ? "Y" : "N";

            DataTable dt_ret = SELECT_SCH_DEVCHECK(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }
            }

            if (dt_ret.Rows.Count > 0)
            {
                fgrid_main.Select(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL);

                Display_Head_Data();
                Display_Head_Image();
                Display_Detail_Data();
            }
        }

        private DataTable SELECT_SCH_DEVCHECK(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(10);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_DEVCHECK";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";                
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL";
                MyOraDB.Parameter_Name[5] = "ARG_USER";
                MyOraDB.Parameter_Name[6] = "ARG_CHK_PT";
                MyOraDB.Parameter_Name[7] = "ARG_CHK_FILE";
                MyOraDB.Parameter_Name[8] = "ARG_CHK_IMAGE";
                MyOraDB.Parameter_Name[9] = "OUT_CURSOR";
                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;                
                MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];
                MyOraDB.Parameter_Values[8] = arg_value[8];                
                MyOraDB.Parameter_Values[9] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                if (Check_Save())
                {
                    SAVE_DATA();
                    Display_Detail_Data();
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
        private bool Check_Save()
        {
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                if (div.Equals("U"))
                {
                    #region Round Count Check
                    int round_cnt = 0;

                    for (int j = (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_01; j <= (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_05; j++)
                    {
                        string nf_cd = fgrid_main[i, j].ToString().Trim();

                        if (!nf_cd.Equals(""))
                        {
                            round_cnt++; 
                        }
                    }

                    if (!round_cnt.Equals(3))
                    {                        
                        MessageBox.Show("Please select three round.");
                        fgrid_main.Select(i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL);
                        Display_Head_Data();
                        Display_Head_Image();
                        Display_Detail_Data();

                        return false;
                    }
                    #endregion

                    #region Numeric Data Check
                    string target_fob = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB].ToString().Trim();
                    try
                    {
                        double _target_fob = double.Parse(target_fob);
                    }
                    catch
                    {
                        MessageBox.Show("Wrong data : Target FOB.\r\n\r\nPlease insert numeric data.");
                        return false;
                    }


                    string current_fob = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB].ToString().Trim();
                    try
                    {
                        double _current_fob = double.Parse(current_fob);
                    }
                    catch
                    {
                        MessageBox.Show("Wrong data : Current FOB.\r\n\r\nPlease insert numeric data.");
                        return false;
                    }


                    string retail_price = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE].ToString().Trim();
                    try
                    {
                        double _retail_price = double.Parse(retail_price);
                    }
                    catch
                    {
                        MessageBox.Show("Wrong data : Retail Price.\r\n\r\nPlease insert numeric data.");
                        return false;
                    }


                    string forecast = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST].ToString().Trim();
                    try
                    {
                        double _forecast = double.Parse(forecast);
                    }
                    catch
                    {
                        MessageBox.Show("Wrong data : Forecast.\r\n\r\nPlease insert numeric data.");
                        return false;
                    }
                    #endregion
                }
            }

            return true; 
        }
        private string Get_Selected_Round(int arg_row, int arg_index)
        {
            try
            {
                string[] return_value = new string[3];
                int round_cnt = 0;

                for (int i = (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_01; i <= (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_05; i++)
                {
                    string nf_cd = fgrid_main[arg_row, i].ToString().Trim();

                    if (!nf_cd.Equals(""))
                    {
                        return_value[round_cnt] = nf_cd;
                        round_cnt++;
                    } 
                }

                return return_value[arg_index];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

                return "";
            }                
        }
        private void SAVE_DATA()
        {
            int vcnt = 31;

            MyOraDB.ReDim_Parameter(vcnt);
            MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_DEV_HEAD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";            
            MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";            
            MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[5] = "ARG_LAST_CD";
            MyOraDB.Parameter_Name[6] = "ARG_GEN_CD";
            MyOraDB.Parameter_Name[7] = "ARG_T_D";
            MyOraDB.Parameter_Name[8] = "ARG_TARGET_FOB";
            MyOraDB.Parameter_Name[9] = "ARG_CURRENT_FOB";
            MyOraDB.Parameter_Name[10] = "ARG_RETAIL_PRICE";
            MyOraDB.Parameter_Name[11] = "ARG_FORECAST";
            MyOraDB.Parameter_Name[12] = "ARG_MIDSOLE";
            MyOraDB.Parameter_Name[13] = "ARG_AIRBAG";
            MyOraDB.Parameter_Name[14] = "ARG_OUTSOLE";
            MyOraDB.Parameter_Name[15] = "ARG_WHQ_DEV";
            MyOraDB.Parameter_Name[16] = "ARG_NLO_DEV";
            MyOraDB.Parameter_Name[17] = "ARG_NLO_PE";
            MyOraDB.Parameter_Name[18] = "ARG_NLO_TE";
            MyOraDB.Parameter_Name[19] = "ARG_CDC_DEV";
            MyOraDB.Parameter_Name[20] = "ARG_CDC_PE";
            MyOraDB.Parameter_Name[21] = "ARG_CDC_TE";
            MyOraDB.Parameter_Name[22] = "ARG_IPW_YMD";
            MyOraDB.Parameter_Name[23] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[24] = "ARG_MODEL_DESC";
            MyOraDB.Parameter_Name[25] = "ARG_SRF_NO_DESC";
            MyOraDB.Parameter_Name[26] = "ARG_P_FACTORY_DESC";
            MyOraDB.Parameter_Name[27] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[28] = "ARG_NF_CD_01";
            MyOraDB.Parameter_Name[29] = "ARG_NF_CD_02";
            MyOraDB.Parameter_Name[30] = "ARG_NF_CD_03";
           

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
            {
                string _div = fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCATEGORY] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCATEGORY].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSEASON_CD] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSEASON_CD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxLAST_CD] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxLAST_CD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxGENDER] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxGENDER].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxT_D] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxT_D].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMIDSOLE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMIDSOLE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxAIRBAG] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxAIRBAG].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxOUTSOLE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxOUTSOLE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxWHQ_DEV] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxWHQ_DEV].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_DEV] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_DEV].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_PE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_PE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_TE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_TE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_DEV] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_DEV].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_PE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_PE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_TE] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_TE].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxIPW_YMD] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxIPW_YMD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxREMARK] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxREMARK].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO_DESC] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO_DESC].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxP_FACTORY_DESC] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxP_FACTORY_DESC].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
                MyOraDB.Parameter_Values[vcnt++] = Get_Selected_Round(row, 0);
                MyOraDB.Parameter_Values[vcnt++] = Get_Selected_Round(row, 1);
                MyOraDB.Parameter_Values[vcnt++] = Get_Selected_Round(row, 2);
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

            fgrid_main.ClearFlags();
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Pop_Sch_PrintOption _pop = new Pop_Sch_PrintOption(this);
                _pop.ShowDialog();
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        #endregion

        #region Grid Event

        #region Grid Head
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    if (grid_size)
                    {
                        c1Sizer1.Grid.Rows[1].Size = 132;                        
                        grid_size = false;
                    }
                    else
                    {
                        c1Sizer1.Grid.Rows[1].Size = 230;
                        grid_size = true;
                    }
                }
                else
                {
                    if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                        return;

                    Display_Head_Data();
                    Display_Head_Image();
                    Display_Detail_Data();
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

        private void Display_Head_Data()
        {
            first_flg = true;
            int sct_row = fgrid_main.Selection.r1;

            txt_model_t.Text             = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL         ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL         ].ToString().Trim();
            cmb_category_t.SelectedValue = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCATEGORY      ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCATEGORY      ].ToString().Trim();
            txt_p_factory_t.Text         = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxP_FACTORY_DESC].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxP_FACTORY_DESC].ToString().Trim();
            cmb_season_t.SelectedValue   = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSEASON_CD     ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSEASON_CD     ].ToString().Trim();
            txt_mo_id_t.Text             = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO_DESC   ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO_DESC   ].ToString().Trim();
            txt_last_cd.Text             = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxLAST_CD       ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxLAST_CD       ].ToString().Trim();
            txt_gender_t.Text            = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxGENDER        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxGENDER        ].ToString().Trim();
            txt_td_t.Text                = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxT_D           ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxT_D           ].ToString().Trim();
            txt_target_fob.Text          = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB    ].Equals(null)) ? "" : (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB    ].ToString().Trim().Equals("0")) ? "" : fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB  ].ToString().Trim();
            txt_current_fob.Text         = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB   ].Equals(null)) ? "" : (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB   ].ToString().Trim().Equals("0")) ? "" : fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB ].ToString().Trim();
            txt_retail_price.Text        = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE  ].Equals(null)) ? "" : (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE  ].ToString().Trim().Equals("0")) ? "" : fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE].ToString().Trim();
            txt_forecast.Text            = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST      ].Equals(null)) ? "" : (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST      ].ToString().Trim().Equals("0")) ? "" : fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST    ].ToString().Trim();
            txt_midsole.Text             = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMIDSOLE       ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMIDSOLE       ].ToString().Trim();
            txt_airbag.Text              = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxAIRBAG        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxAIRBAG        ].ToString().Trim();
            txt_outsole.Text             = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxOUTSOLE       ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxOUTSOLE       ].ToString().Trim(); 
            txt_bvtn_dev.Text            = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxWHQ_DEV       ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxWHQ_DEV       ].ToString().Trim();
            txt_nlo_dev.Text             = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_DEV       ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_DEV       ].ToString().Trim();
            txt_nlo_pe.Text              = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_PE        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_PE        ].ToString().Trim();
            txt_nlo_te.Text              = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_TE        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_TE        ].ToString().Trim();
            cmb_cdc_dev_t.SelectedValue  = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_DEV       ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_DEV       ].ToString().Trim();
            txt_cdc_pe.Text              = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_PE        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_PE        ].ToString().Trim();
            txt_cdc_te.Text              = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_TE        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_TE        ].ToString().Trim();
            txt_remark.Text              = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxREMARK        ].Equals(null)) ? "" :  fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxREMARK        ].ToString().Trim();


            string ipw_ymd = (fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxIPW_YMD].Equals(null)) ? "" : fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxIPW_YMD].ToString().Trim();

            try
            {
                int year  = int.Parse(ipw_ymd.Substring(0, 4));
                int month = int.Parse(ipw_ymd.Substring(4, 2));
                int day   = int.Parse(ipw_ymd.Substring(6, 2));

                DateTime ipw = new DateTime(year, month, day);

                dtp_ipw.Value = ipw;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }

            Round_Check_Display(sct_row);

            first_flg = false;            
        }
        private void Display_Detail_Data()
        {            
            fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;
            
            string[] arg_value = new string[3];

            arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
            arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
            arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();

            DataTable dt_ret = SELECT_SCH_DEVCHECK_TASK(arg_value);
            
            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_detail.Rows.Add();

                for (int j = 0; j < fgrid_detail.Cols.Count; j++)
                {
                    fgrid_detail[fgrid_detail.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }
            }

            Display_Detail_Style();
        }

        private void Display_Detail_Style()
        {
            #region Task Data Setting
            DataTable dt_task_01 = SELECT_SCH_TASK("01");
            DataTable dt_task_02 = SELECT_SCH_TASK("03");

            string value = "";
            string name = "";

            System.Collections.Specialized.ListDictionary ld_task_01 = new System.Collections.Specialized.ListDictionary();
            ld_task_01.Add("", "");

            if (dt_task_01.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_01.Rows.Count; row++)
                {
                    value = dt_task_01.Rows[row].ItemArray[0].ToString();
                    name  = dt_task_01.Rows[row].ItemArray[1].ToString();

                    ld_task_01.Add(value, name);
                }
            }

            string value_02 = "";
            string name_02 = "";

            System.Collections.Specialized.ListDictionary ld_task_02 = new System.Collections.Specialized.ListDictionary();
            ld_task_02.Add("", "");

            if (dt_task_02.Rows.Count > 0)
            {
                for (int row = 0; row < dt_task_02.Rows.Count; row++)
                {
                    value_02 = dt_task_02.Rows[row].ItemArray[0].ToString();
                    name_02  = dt_task_02.Rows[row].ItemArray[1].ToString();

                    ld_task_02.Add(value_02, name_02);
                }
            }
            #endregion

            string _main_status = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSTATUS].ToString().Trim();

            for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
            {
                for (int j = (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01; j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN280_T01; j++)
                {
                    string _nf_seq = fgrid_detail[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxNF_SEQ].ToString().Trim();

                    if (_nf_seq.Equals("000"))
                    {
                        #region Task
                        CellRange cellrg = fgrid_detail.GetCellRange(i, j);
                        CellStyle cellst = fgrid_detail.Styles.Add("TASK_" + i.ToString() + j.ToString());
                        cellst.DataMap = ld_task_01;
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.BackColor = Color.LightYellow;
                        cellst.ForeColor = Color.Black;

                        cellrg.Style = fgrid_detail.Styles["TASK_" + i.ToString() + j.ToString()];
                        #endregion
                    }
                    else if (_nf_seq.Equals("005"))
                    {
                        #region Progress
                        CellRange cellrg = fgrid_detail.GetCellRange(i, j);
                        CellStyle cellst = fgrid_detail.Styles.Add("PROGRESS_" + i.ToString() + j.ToString());
                        cellst.DataMap = ld_task_02;
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.ForeColor = Color.Black;

                        string progress = fgrid_detail[i, j].ToString().Trim();

                        if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04)
                        {
                            if (_main_status.Equals("N"))
                            {
                                if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                                else
                                    cellst.BackColor = Color.FromArgb(247, 251, 251);
                            }
                            else
                            {
                                if (progress.Equals("C"))
                                    cellst.BackColor = Color.Aqua;
                                else if (progress.Equals("Y"))
                                    cellst.BackColor = Color.Red;
                                else if (progress.Equals("N"))
                                    cellst.BackColor = Color.Yellow;
                                else if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                            }
                        }
                        else if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04)
                        {
                            if (_main_status.Equals("N"))
                            {
                                if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                                else
                                    cellst.BackColor = Color.FromArgb(247, 251, 251);
                            }
                            else
                            {
                                if (progress.Equals("C"))
                                    cellst.BackColor = Color.Aqua;
                                else if (progress.Equals("Y"))
                                    cellst.BackColor = Color.Red;
                                else if (progress.Equals("N"))
                                    cellst.BackColor = Color.Yellow;
                                else if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                            }
                        }
                        else if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04)
                        {
                            if (_main_status.Equals("N"))
                            {
                                if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                                else
                                    cellst.BackColor = Color.FromArgb(247, 251, 251);
                            }
                            else
                            {
                                if (progress.Equals("C"))
                                    cellst.BackColor = Color.Aqua;
                                else if (progress.Equals("Y"))
                                    cellst.BackColor = Color.Red;
                                else if (progress.Equals("N"))
                                    cellst.BackColor = Color.Yellow;
                                else if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                            }
                        }
                        else if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN180_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN280_T01)
                        {
                            if (_main_status.Equals("N"))
                            {
                                if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                                else
                                    cellst.BackColor = Color.FromArgb(247, 251, 251);
                            }
                            else
                            {
                                if (progress.Equals("C"))
                                    cellst.BackColor = Color.Aqua;
                                else if (progress.Equals("Y"))
                                    cellst.BackColor = Color.Red;
                                else if (progress.Equals("N"))
                                    cellst.BackColor = Color.Yellow;
                                else if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                            }
                        }
                        else
                        {
                            if (_main_status.Equals("N"))
                            {
                                if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                                else
                                    cellst.BackColor = Color.White;
                            }
                            else
                            {
                                if (progress.Equals("C"))
                                    cellst.BackColor = Color.Aqua;
                                else if (progress.Equals("Y"))
                                    cellst.BackColor = Color.Red;
                                else if (progress.Equals("N"))
                                    cellst.BackColor = Color.Yellow;
                                else if (progress.Equals(""))
                                    cellst.BackColor = Color.LightGray;
                            }
                        }

                        cellrg.Style = fgrid_detail.Styles["PROGRESS_" + i.ToString() + j.ToString()];
                        #endregion
                    }
                    else
                    {
                        #region Date
                        CellRange cellrg = fgrid_detail.GetCellRange(i, j);
                        CellStyle cellst = fgrid_detail.Styles.Add("DATETIME_" + i.ToString() + j.ToString());
                        cellst.DataType = typeof(DateTime);
                        cellst.Format = "yyyyMMdd";
                        cellst.TextAlign = TextAlignEnum.CenterCenter;
                        cellst.ForeColor = Color.Black;

                        if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04)
                        {
                            cellst.BackColor = Color.FromArgb(247, 251, 251);
                        }
                        else if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04)
                        {
                            cellst.BackColor = Color.FromArgb(247, 251, 251);
                        }
                        else if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04)
                        {
                            cellst.BackColor = Color.FromArgb(247, 251, 251);
                        }
                        else if (j >= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN180_T01 && j <= (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN280_T01)
                        {
                            cellst.BackColor = Color.FromArgb(247, 251, 251);
                        }
                        else
                        {
                            cellst.BackColor = Color.White;
                        }

                        string progress = fgrid_detail[fgrid_detail.Rows.Count - 1, j].ToString().Trim();

                        if (progress.Equals(""))
                            cellst.BackColor = Color.LightGray;

                        cellrg.Style = fgrid_detail.Styles["DATETIME_" + i.ToString() + j.ToString()];
                        #endregion
                    }
                }
            }
        }
        private void Display_Head_Image()
        {
            addflow.Items.Clear();
            addflow.ResetDefNodeProp();
            addflow.ResetDefLinkProp();
            addflow.ResetGrid();
            addflow.ResetText();
            
            addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;      

            string[] arg_value = new string[3];

            arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
            arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
            arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();

            DataTable dt = SELECT_SCH_HEAD_IMAGE(arg_value);

            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            for (int i = 0; i < dt_rows; i++)
            {

                byte[] MyData = null;
                MyData = (byte[])dt.Rows[i].ItemArray[0];

                MemoryStream ms = new MemoryStream(MyData);
                System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);

                Image img = true_image;
                float imgFwidth = float.Parse(img.Width.ToString());
                float imgFheight = float.Parse(img.Height.ToString());

                Rectangle rect = new Rectangle(1, 1, Convert.ToInt32(imgFwidth - 2), Convert.ToInt32(imgFheight - 2)); // 잘라낼 영역으로 사용  
                //Rectangle rect = new Rectangle(1, 1, Convert.ToInt32(imgFwidth), Convert.ToInt32(imgFheight)); // 잘라낼 영역으로 사용  
                PixelFormat pixf = img.PixelFormat; // 이미지의 픽셀포맷 
                Bitmap bt_img = ((Bitmap)img).Clone(rect, pixf);
                img = (Image)bt_img;

                imgFwidth = float.Parse(img.Width.ToString());
                imgFheight = float.Parse(img.Height.ToString());

                addflow.Images.Add(img);
                // Create nodes
                // 이미지 크기가 기본 addflow 영역보다 클 경우는 줄여서 load
                imgFheight = (imgFheight < _MaxImageHeight) ? imgFheight : _MaxImageHeight;
                imgFwidth = (imgFwidth < _MaxImageWidth) ? imgFwidth : _MaxImageWidth;

                Lassalle.Flow.Node node1 = new Lassalle.Flow.Node(0, 0, true_image.Width, true_image.Height);

                // 이미지 노드의 라인색
                node1.DrawColor = Color.Transparent;
                // 이미지 노드의 투명화
                node1.FillColor = Color.Transparent;
                node1.Shape.Style = Lassalle.Flow.ShapeStyle.Rectangle;
                //node1.AutoSize = Lassalle.Flow.AutoSize.ImageToNode;
                node1.Font = new Font("Verdana", 7);


                // 노드 태그가 -1 이면 이미지 노드라고 정의하고, edit 못하도록 처리
                node1.Tag = "-1";

                int imgIndex = addflow.Images.Count;

                if (imgIndex <= 0)
                {
                    node1.ImageIndex = 0;
                }
                else
                {
                    node1.ImageIndex = (imgIndex - 1);
                }

                addflow.DefLinkProp.AdjustOrg = true;
                addflow.DefLinkProp.AdjustDst = true;
                addflow.Enabled = false;
                addflow.Nodes.Add(node1);       
            }
        }

        private void Round_Check_Display(int arg_row)
        {
            string[] nf_cd = new string[5];

            nf_cd[0] = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_01].ToString().Trim();
            nf_cd[1] = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_02].ToString().Trim();
            nf_cd[2] = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_03].ToString().Trim();
            nf_cd[3] = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_04].ToString().Trim();
            nf_cd[4] = fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_05].ToString().Trim();

            chk_lks.Checked = false;
            chk_smm.Checked = false;
            chk_rlf.Checked = false;
            chk_acnt.Checked = false;
            chk_gtm.Checked = false;

            for (int i = 0; i < nf_cd.Length; i++)
            {
                if (nf_cd[i].Equals("010"))
                {
                    chk_lks.Checked = true; 
                }
                else if (nf_cd[i].Equals("020"))
                {
                    chk_smm.Checked = true;
                }
                else if (nf_cd[i].Equals("040"))
                {
                    chk_rlf.Checked = true;
                }
                else if (nf_cd[i].Equals("050"))
                {
                    chk_acnt.Checked = true;
                }
                else if (nf_cd[i].Equals("070"))
                {
                    chk_gtm.Checked = true;
                }
            }
        }

        private DataTable SELECT_SCH_DEVCHECK_TASK(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_DEVCHECK_TASK";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private DataTable SELECT_SCH_HEAD_IMAGE(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_DEVCHECK_IMG";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SCH_TASK(string arg_division)
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_TASK";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_division;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Grid Tail
        private void fgrid_detail_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;


            }
            catch
            {
 
            }
        }
        private void fgrid_detail_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                if (fgrid_detail.Rows.Count.Equals(fgrid_detail.Rows.Fixed))
                    return;

                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                string[] arg_value = new string[36];

                arg_value[0 ] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxFACTORY].ToString().Trim();
                arg_value[1 ] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxMODEL_ID].ToString().Trim();
                arg_value[2 ] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxSRF_NO].ToString().Trim();
                arg_value[3 ] = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxNF_SEQ].ToString().Trim();
                arg_value[4 ] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01);
                arg_value[5 ] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T02);
                arg_value[6 ] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T03);
                arg_value[7 ] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04);                
                arg_value[8 ] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T01);
                arg_value[9 ] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T02);
                arg_value[10] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T03);
                arg_value[11] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T04);
                arg_value[12] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01);
                arg_value[13] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T02);
                arg_value[14] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T03);
                arg_value[15] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04);
                arg_value[16] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T01);
                arg_value[17] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T02);
                arg_value[18] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T03);
                arg_value[19] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T04);
                arg_value[20] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01);
                arg_value[21] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T02);
                arg_value[22] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T03);
                arg_value[23] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04);
                arg_value[24] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN110_T01);
                arg_value[25] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN130_T01);
                arg_value[26] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN140_T01);
                arg_value[27] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN150_T01);
                arg_value[28] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN170_T01);
                arg_value[29] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN180_T01);
                arg_value[30] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN200_T01);
                arg_value[31] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN210_T01);
                arg_value[32] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN220_T01);
                arg_value[33] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN270_T01);
                arg_value[34] = GET_GRID_DATA_CHANGE(sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN280_T01);          
                arg_value[35] = COM.ComVar.This_User;

                if (SAVE_TASK(arg_value))
                {
                    string _nf_seq = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxNF_SEQ].ToString().Trim();
                    fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSTATUS] = "Y";

                    Display_Detail_Data();

                    fgrid_detail.Select(sct_row, sct_col);                    
                }
            }
            catch
            {
 
            }
        }
        private void fgrid_detail_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                string item_seq = fgrid_detail[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxNF_SEQ].ToString().Trim();

                if (item_seq.Equals("001") || item_seq.Equals("002") || item_seq.Equals("003") || item_seq.Equals("004"))
                {

                    string cell_value = (fgrid_detail[sct_row, sct_col] == null) ? "" : fgrid_detail[sct_row, sct_col].ToString();

                    if (!cell_value.Equals(""))
                    {
                        try
                        {
                            if (cell_value.Length > 8)
                            {
                                fgrid_detail.Buffer_CellData = cell_value;
                            }
                            else
                            {
                                int year = int.Parse(cell_value.Substring(0, 4));
                                int month = int.Parse(cell_value.Substring(4, 2));
                                int day = int.Parse(cell_value.Substring(6, 2));

                                DateTime dt = new DateTime(year, month, day);

                                fgrid_detail.Buffer_CellData = dt.ToString();
                            }
                        }
                        catch
                        {
                            fgrid_detail.Buffer_CellData = DateTime.Now.ToString();
                        }

                        fgrid_detail[sct_row, sct_col] = fgrid_detail.Buffer_CellData.ToString();
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
        private string GET_GRID_DATA_CHANGE(int arg_row, int arg_col)
        {
            string value = "";

            try
            {
                value = Convert.ToDateTime(fgrid_detail[arg_row, arg_col].ToString().Trim()).ToString("yyyyMMdd");
            }
            catch
            {
                value = (fgrid_detail[arg_row, arg_col] == null) ? "" : fgrid_detail[arg_row, arg_col].ToString().Trim();
            }

            return value;
        }

        
        private bool SAVE_TASK(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(36);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_DEV_TASK";

                MyOraDB.Parameter_Name[0 ] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1 ] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2 ] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3 ] = "ARG_ITEM_SEQ";
                MyOraDB.Parameter_Name[4 ] = "ARG_N010_T01";
                MyOraDB.Parameter_Name[5 ] = "ARG_N010_T02";
                MyOraDB.Parameter_Name[6 ] = "ARG_N010_T03";
                MyOraDB.Parameter_Name[7 ] = "ARG_N010_T04";
                MyOraDB.Parameter_Name[8 ] = "ARG_N020_T01";
                MyOraDB.Parameter_Name[9 ] = "ARG_N020_T02";
                MyOraDB.Parameter_Name[10] = "ARG_N020_T03";
                MyOraDB.Parameter_Name[11] = "ARG_N020_T04";
                MyOraDB.Parameter_Name[12] = "ARG_N040_T01";
                MyOraDB.Parameter_Name[13] = "ARG_N040_T02";
                MyOraDB.Parameter_Name[14] = "ARG_N040_T03";
                MyOraDB.Parameter_Name[15] = "ARG_N040_T04";
                MyOraDB.Parameter_Name[16] = "ARG_N050_T01";
                MyOraDB.Parameter_Name[17] = "ARG_N050_T02";
                MyOraDB.Parameter_Name[18] = "ARG_N050_T03";
                MyOraDB.Parameter_Name[19] = "ARG_N050_T04";
                MyOraDB.Parameter_Name[20] = "ARG_N070_T01";
                MyOraDB.Parameter_Name[21] = "ARG_N070_T02";
                MyOraDB.Parameter_Name[22] = "ARG_N070_T03";
                MyOraDB.Parameter_Name[23] = "ARG_N070_T04";
                MyOraDB.Parameter_Name[24] = "ARG_N110_T01";
                MyOraDB.Parameter_Name[25] = "ARG_N130_T01";
                MyOraDB.Parameter_Name[26] = "ARG_N140_T01";
                MyOraDB.Parameter_Name[27] = "ARG_N150_T01";
                MyOraDB.Parameter_Name[28] = "ARG_N170_T01";
                MyOraDB.Parameter_Name[29] = "ARG_N180_T01";
                MyOraDB.Parameter_Name[30] = "ARG_N200_T01";
                MyOraDB.Parameter_Name[31] = "ARG_N210_T01";
                MyOraDB.Parameter_Name[32] = "ARG_N220_T01";
                MyOraDB.Parameter_Name[33] = "ARG_N270_T01";
                MyOraDB.Parameter_Name[34] = "ARG_N280_T01";
                MyOraDB.Parameter_Name[35] = "ARG_UPD_USER";

                MyOraDB.Parameter_Type[0 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9 ] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[27] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[28] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[29] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[30] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[31] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[32] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[33] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[34] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[35] = (int)OracleType.VarChar;
                
                
                MyOraDB.Parameter_Values[0 ] = arg_value[0 ];
                MyOraDB.Parameter_Values[1 ] = arg_value[1 ];
                MyOraDB.Parameter_Values[2 ] = arg_value[2 ];
                MyOraDB.Parameter_Values[3 ] = arg_value[3 ];
                MyOraDB.Parameter_Values[4 ] = arg_value[4 ];
                MyOraDB.Parameter_Values[5 ] = arg_value[5 ];
                MyOraDB.Parameter_Values[6 ] = arg_value[6 ];
                MyOraDB.Parameter_Values[7 ] = arg_value[7 ];
                MyOraDB.Parameter_Values[8 ] = arg_value[8 ];
                MyOraDB.Parameter_Values[9 ] = arg_value[9 ];
                MyOraDB.Parameter_Values[10] = arg_value[10];
                MyOraDB.Parameter_Values[11] = arg_value[11];
                MyOraDB.Parameter_Values[12] = arg_value[12];
                MyOraDB.Parameter_Values[13] = arg_value[13];
                MyOraDB.Parameter_Values[14] = arg_value[14];
                MyOraDB.Parameter_Values[15] = arg_value[15];
                MyOraDB.Parameter_Values[16] = arg_value[16];
                MyOraDB.Parameter_Values[17] = arg_value[17];
                MyOraDB.Parameter_Values[18] = arg_value[18];
                MyOraDB.Parameter_Values[19] = arg_value[19];
                MyOraDB.Parameter_Values[20] = arg_value[20];
                MyOraDB.Parameter_Values[21] = arg_value[21];
                MyOraDB.Parameter_Values[22] = arg_value[22];
                MyOraDB.Parameter_Values[23] = arg_value[23];
                MyOraDB.Parameter_Values[24] = arg_value[24];
                MyOraDB.Parameter_Values[25] = arg_value[25];
                MyOraDB.Parameter_Values[26] = arg_value[26];
                MyOraDB.Parameter_Values[27] = arg_value[27];
                MyOraDB.Parameter_Values[28] = arg_value[28];
                MyOraDB.Parameter_Values[29] = arg_value[29];
                MyOraDB.Parameter_Values[30] = arg_value[30];
                MyOraDB.Parameter_Values[31] = arg_value[31];
                MyOraDB.Parameter_Values[32] = arg_value[32];
                MyOraDB.Parameter_Values[33] = arg_value[33];
                MyOraDB.Parameter_Values[34] = arg_value[34];
                MyOraDB.Parameter_Values[35] = arg_value[35];
                               
                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

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

        #region Control Event

        #region Combo Box
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////Model
                //DataTable dt_ret = SELECT_MODEL();

                //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model, 0, 1, true, 0, 300);
                //cmb_model.SelectedIndex = 0;
            }
            catch
            {

            }
            finally
            {

            }
        }
        private DataTable SELECT_MODEL()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_MODEL";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion        

        #region Control Event
        private void txt_p_factory_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxP_FACTORY_DESC] = txt_p_factory_t.Text.Trim();
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY_V] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim() + "/" + fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxP_FACTORY_DESC].ToString().Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_model_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL] = txt_model_t.Text;
                

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {
 
            }
        }
        private void cmb_category_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCATEGORY] = cmb_category_t.SelectedValue.ToString().Trim();
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCATEGORY_V] = cmb_category_t.SelectedText.ToString().Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        
        private void cmb_season_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSEASON_CD] = cmb_season_t.SelectedValue.ToString().Trim();
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSEASON_V] = cmb_season_t.SelectedText.ToString().Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_mo_id_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO_DESC] = txt_mo_id_t.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }        
        private void txt_last_cd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxLAST_CD] = txt_last_cd.Text.Trim();                

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        
        private void txt_target_fob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxTARGET_FOB] = txt_target_fob.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_current_fob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCURRENT_FOB] = txt_current_fob.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_retail_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxRETAIL_PRICE] = txt_retail_price.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_forecast_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFORECAST] = txt_forecast.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_midsole_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMIDSOLE] = txt_midsole.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_airbag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxAIRBAG] = txt_airbag.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_outsole_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxOUTSOLE] = txt_outsole.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void dtp_ipw_CloseUp(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxIPW_YMD] = dtp_ipw.Value.ToString("yyyyMMdd");

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_bvtn_dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxWHQ_DEV] = txt_bvtn_dev.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_nlo_dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_DEV] = txt_nlo_dev.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_nlo_pe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_PE] = txt_nlo_pe.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_nlo_te_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNLO_TE] = txt_nlo_te.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        
        private void txt_cdc_pe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_PE] = txt_cdc_pe.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_cdc_te_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_TE] = txt_cdc_te.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_remark_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxREMARK] = txt_remark.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_gender_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxGEN_CD] = txt_gender_t.Text.Trim();
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxGENDER] = txt_gender_t.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }

        private void txt_td_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxT_D] = txt_td_t.Text.Trim();

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void cmb_cdc_dev_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                int sct_row = fgrid_main.Selection.r1;
                string div = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV].ToString().Trim();

                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxCDC_DEV] = cmb_cdc_dev_t.SelectedValue.ToString().Trim();
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDEV_USER] = cmb_cdc_dev_t.SelectedValue.ToString().Trim();                

                if (div.Equals(""))
                    fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";
            }
            catch
            {

            }
        }
        #endregion

        #endregion

        #region Context Menu

        #region Grid Head
        
        #region Presentation
        private void mnu_chk_pt_Click(object sender, EventArgs e)
        {
            try
            {
                if(fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string print_yn = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_DEVCHECK.IxPRINT_YN].ToString().Trim().ToUpper();

                    string[] arg_value = new string[4];

                    arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
                    arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
                    arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();
                    arg_value[3] = (print_yn.Equals("TRUE")) ? "N" : "Y";

                    if (UPDATE_SXC_SCH_CHK_PT(arg_value))
                    {
                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_DEVCHECK.IxPRINT_YN] = (print_yn.Equals("TRUE")) ? "FALSE" : "TRUE";
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
        private bool UPDATE_SXC_SCH_CHK_PT(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_CHK_PT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_PT_YN";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        /*******************************************************************/
        private void mnu_upload_ptfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Multiselect = true;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    int sct_row = fgrid_main.Selection.r1;
                    int sct_col = fgrid_main.Selection.c1;

                    for (int i = 0; i < openDlg.FileNames.Length; i++)
                    {
                        string file_name_short = openDlg.FileNames[i].Substring(openDlg.FileNames[i].LastIndexOf("\\") + 1, openDlg.FileNames[i].Length - openDlg.FileNames[i].LastIndexOf("\\") - 1);

                        string[] arg_value = new string[5];

                        arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();
                        arg_value[3] = GET_SCH_FILE_CD().Rows[0].ItemArray[0].ToString().Trim();
                        arg_value[4] = file_name_short;

                        string file_name = openDlg.FileNames[i];

                        if (INSERT_FILE(arg_value, file_name))
                        {
                            if (SAVE_SCH_HEAD_FILE(arg_value))
                            {
                                MessageBox.Show("FIle Upload Complete.");
                                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFILE_YN] = "TRUE";                                
                            }
                            else
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
                }
                   
            }
            catch
            {

            }
            finally
            {
 
            }
        }        
        private void mnu_open_ptfile_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[8];

                arg_value[0] = cmb_factory.SelectedValue.ToString();                
                arg_value[1] = cmb_season_from.SelectedValue.ToString();
                arg_value[2] = cmb_season_to.SelectedValue.ToString();
                arg_value[3] = cmb_category.SelectedValue.ToString();
                arg_value[4] = txt_model.Text.Trim();
                arg_value[5] = cmb_user.SelectedValue.ToString();
                arg_value[6] = (chk_pt.Checked) ? "Y" : "";
                arg_value[7] = (chk_image.Checked) ? "Y" : "";



                Pop_Sch_Devcheck_File pop = new Pop_Sch_Devcheck_File("DEV", arg_value);
                pop.ShowDialog();                
            }
            catch
            {

            }
            finally
            {

            }
        }
        /*******************************************************************/
        private DataTable GET_SCH_FILE_CD()
        {
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.GET_SXC_SCH_FILE_CD";

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }        
        private bool SAVE_SCH_HEAD_FILE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_HEAD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_FILE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_FILE_NAME";
                MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "File Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        
        #endregion

        #region Model Image
        private void mnu_updateimage_Click(object sender, EventArgs e)
        {
            try
            {
                string m_strPath = null;
                OpenFileDialog openDlg = new OpenFileDialog();

                // 파일오픈에 대한 기초환경 설정 부분 >> 시작
                // 현재 업로드되는 파일은 "gif, jpg" 만 가능하며, 추가 가능하다.
                openDlg.InitialDirectory = "c:\\";
                openDlg.DefaultExt = "jpg, gif";
                openDlg.Filter = "Image File (*.jpg)|*.jpg|Image File(*.gif)|*.gif";
                openDlg.RestoreDirectory = false;
                // 파일오픈에 대한 기초환경 설정부분 >> 끝

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    m_strPath = openDlg.FileName;

                    // 이미지 Resource 추가.
                    addflow.Items.Clear();
                    addflow.ResetDefNodeProp();
                    addflow.ResetDefLinkProp();
                    addflow.ResetGrid();
                    addflow.ResetText();

                    addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;


                    addflow.Images.Add(m_strPath);

                    //// 호출된 이미지 Resource 의 Size 구하는 부분
                    Image img = Image.FromFile(m_strPath);
                    float imgFwidth = float.Parse(img.Width.ToString());
                    float imgFheight = float.Parse(img.Height.ToString());

                    //// Create nodes

                    //// 이미지 크기가 기본 addflow 영역보다 클 경우는 줄여서 load
                    imgFheight = (imgFheight < _MaxImageHeight) ? imgFheight : _MaxImageHeight;
                    imgFwidth = (imgFwidth < _MaxImageWidth) ? imgFwidth : _MaxImageWidth;
                    Lassalle.Flow.Node node1 = new Lassalle.Flow.Node(10, 10, imgFwidth, imgFheight);


                    //// 이미지 노드의 라인색
                    node1.DrawColor = Color.Transparent;
                    //// 이미지 노드의 투명화
                    node1.FillColor = Color.Transparent;
                    node1.Shape.Style = Lassalle.Flow.ShapeStyle.Rectangle;
                    node1.AutoSize = Lassalle.Flow.AutoSize.ImageToNode;

                    //// 노드 태그가 -1 이면 이미지 노드라고 정의하고, edit 못하도록 처리
                    node1.Tag = "-1";

                    int imgIndex = addflow.Images.Count;

                    if (imgIndex <= 0)
                    {
                        node1.ImageIndex = 0;
                    }
                    else
                    {
                        node1.ImageIndex = (imgIndex - 1);
                    }

                    addflow.DefLinkProp.AdjustOrg = true;
                    addflow.DefLinkProp.AdjustDst = true;

                    addflow.Nodes.Add(node1);


                    string[] arg_value = new string[5];

                    arg_value[0] = "I";
                    arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
                    arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
                    arg_value[3] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();
                    arg_value[4] = "_________________";

                    Metafile mf = addflow.ExportMetafile(false, true, false, false, false);
                    string targetPath = Application.StartupPath + @"\" + arg_value[1] + "-" + arg_value[2] + "-" + arg_value[3] + ".jpg";
                    mf.Save(targetPath, ImageFormat.Jpeg);

                    SAVE_MODEL_IMAGE(arg_value, targetPath);

                    FileInfo fi = new FileInfo(targetPath);
                    if (fi.Exists)
                    {
                        fi.Delete();
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

        private void mnu_deleteimage_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[4];

                arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxSRF_NO].ToString().Trim();
                arg_value[3] = "_________________";

                if (DELETE_MODEL_IMAGE(arg_value))
                {
                    addflow.Items.Clear();
                    addflow.ResetDefNodeProp();
                    addflow.ResetDefLinkProp();
                    addflow.ResetGrid();
                    addflow.ResetText();
                    addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private bool SAVE_MODEL_IMAGE(string[] arg_value, string arg_target_path)
        {
            try
            {
                bool ret = false;

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_HEAD_IMG";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[3] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "ARG_IMAGE";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Blob;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = " ";
                MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;

                byte[] photo = null;
                photo = GetPhoto(arg_target_path);
                ret = MyOraDB.Exe_Modify_Procedure_Blob(photo);

                return ret;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool DELETE_MODEL_IMAGE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.DELETE_SXC_SCH_HEAD_IMG";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private byte[] GetPhoto(string arg_filename)
        {
            FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;

        }
        #endregion
        
        #endregion

        #region Grid Tail
        private void mnu_data_clear_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                fgrid_detail[sct_row, sct_col] = null;

                fgrid_detail_AfterEdit(null, null);
            }
            catch
            {

            }
        }        
        #endregion

        #endregion

        #region CheckBox Event
        private void chk_lks_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_lks.Checked)
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T02].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T03].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04].Visible = true;
                }
                else
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T01].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T02].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T03].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN010_T04].Visible = false; 
                }

                if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                {
                    if (!first_flg)
                        fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";

                    Check_Changed_Setting(fgrid_main.Selection.r1);
                }
            }
            catch
            {
 
            }
        }

        private void chk_smm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_smm.Checked)
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T01].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T02].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T03].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T04].Visible = true;
                }
                else
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T01].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T02].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T03].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN020_T04].Visible = false; 
                }

                if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                {
                    if (!first_flg)
                        fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";

                    Check_Changed_Setting(fgrid_main.Selection.r1);
                }
            }
            catch
            {

            }
        }

        private void chk_rlf_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_rlf.Checked)
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T02].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T03].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04].Visible = true;
                }
                else
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T01].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T02].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T03].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN040_T04].Visible = false;
                }

                if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                {
                    if (!first_flg)
                        fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";

                    Check_Changed_Setting(fgrid_main.Selection.r1);
                }
            }
            catch
            {

            }
        }

        private void chk_acnt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_acnt.Checked)
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T01].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T02].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T03].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T04].Visible = true;
                }
                else
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T01].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T02].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T03].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN050_T04].Visible = false;
                }

                if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                {
                    if (!first_flg)
                        fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";

                    Check_Changed_Setting(fgrid_main.Selection.r1);
                }
            }
            catch
            {

            }
        }

        private void chk_gtm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_gtm.Checked)
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T02].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T03].Visible = true;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04].Visible = true;
                }
                else
                {
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T01].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T02].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T03].Visible = false;
                    fgrid_detail.Cols[(int)ClassLib.TBSXC_SCH_DEVCHECK_TASK.IxN070_T04].Visible = false;
                }

                if (!fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                {
                    if (!first_flg)
                        fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxDIV] = "U";

                    Check_Changed_Setting(fgrid_main.Selection.r1);
                }
            }
            catch
            {

            }
        }

        private void Check_Changed_Setting(int arg_row)
        {
            if (chk_lks.Checked)
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_01] = "010";
            }
            else 
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_01] = "";
            }

            if (chk_smm.Checked)
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_02] = "020";
            }
            else
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_02] = "";
            }

            if (chk_rlf.Checked)
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_03] = "040";
            }
            else
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_03] = "";
            }

            if (chk_acnt.Checked)
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_04] = "050";
            }
            else
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_04] = "";
            }

            if (chk_gtm.Checked)
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_05] = "070";
            }
            else
            {
                fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_DEVCHECK.IxNF_CD_05] = "";
            }
        }
        #endregion

        #region SQL Server
        private SqlConnection SQL_CONNECTION()
        {
            try
            {
                string sqlConnection = "server=203.228.108.30;database=PCC_Schedule;uid=sa;pwd=csiroot1128;Connection Timeout=300;";
                if (COM.ComVar.This_Factory.Equals("VJ"))
                    sqlConnection = "server=211.54.128.3;database=PCC_Schedule;uid=sa;pwd=csiroot1;Connection Timeout=300;";
                if (COM.ComVar.This_Factory.Equals("QD"))
                    sqlConnection = "server=119.119.119.18;database=PCC_Schedule;uid=sa;pwd=csiroot1;Connection Timeout=300;";

                SqlConnection conn = new SqlConnection(sqlConnection);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {

            }
        }
        private string insert_query()
        {
            string insert_query = "INSERT INTO SXC_SCH_FILE (FACTORY, FILE_CD, RAW_FILE) VALUES (@FACTORY, @FILE_CD, @RAW_FILE)";

            return insert_query;
        }
        private string select_query()
        {
            string select_query = "SELECT RAW_FILE FROM SXC_SCH_FILE WHERE FACTORY = @FACTORY AND FILE_CD = @FILE_CD";

            return select_query;
        }

        private bool INSERT_FILE(string[] arg_value, string file_name)
        {
            try
            {
                byte[] file = null;
                file = GetFile(file_name);

                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(insert_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_value[0]);
                com.Parameters.AddWithValue("@FILE_CD", arg_value[3]);
                com.Parameters.AddWithValue("@RAW_FILE", file);

                com.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        private byte[] SELECT_FILE(string arg_factory, string arg_file_cd)
        {
            try
            {
                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(select_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_factory);
                com.Parameters.AddWithValue("@FILE_CD", arg_file_cd);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds, "SXC_SCH_FILE");
                byte[] MyData = null;


                if (ds.Tables[0].Rows.Count > 0)
                {
                    MyData = (byte[])ds.Tables[0].Rows[0].ItemArray[0];
                }

                conn.Close();

                return MyData;
            }
            catch
            {
                return null;
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
        
    }
}


