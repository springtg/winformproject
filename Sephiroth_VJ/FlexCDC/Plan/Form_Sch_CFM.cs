using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Threading;
using System.Globalization;


namespace FlexCDC.Plan
{
    public partial class Form_Sch_CFM : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private bool change_flg = false;

        private COM.WebSvc.OraPKG VJ_WebSvc = null;
        private COM.WebSvc.OraPKG QD_WebSvc = null;
        private COM.WebSvc.OraPKG JJ_WebSvc = null;
        private COM.WebSvc.OraPKG DS_WebSvc = null;

        private COM.WebSvc.OraPKG My_WebSvc = null;

        private string[][] _UserList = null;
        #endregion

        #region Constructor
        public Form_Sch_CFM()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Sch_CFM_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
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
        
        private void Init_Form()
        {
            this.Text = "PCC_CFM Schedule";
            this.lbl_MainTitle.Text = "PCC_CFM Schedule";
            ClassLib.ComFunction.SetLangDic(this);
            
            Init_Control();
            Init_Grid();
            Init_WebSvc();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid_CDC("SXC_SCH_CFM", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;

            string sAut = GetAuthor();

            if (sAut.Equals("01"))
            {
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD).StyleNew.BackColor = Color.LightPink;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD).StyleNew.ForeColor = Color.Black;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT).StyleNew.BackColor = Color.LightPink;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT).StyleNew.ForeColor = Color.Black;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER).StyleNew.BackColor = Color.LightPink;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER).StyleNew.ForeColor = Color.Black;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS).StyleNew.BackColor = Color.LightGreen;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS).StyleNew.ForeColor = Color.Black;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.BackColor = Color.Orange;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.ForeColor = Color.Black;
                //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.BackColor = Color.Orange;
                //fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.ForeColor = Color.Black;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS).StyleNew.BackColor = Color.LightPink;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS).StyleNew.ForeColor = Color.Black;

                fgrid_main.ContextMenuStrip = ctmnu_01;
            }
            else if (sAut.Equals("02"))
            {
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER].AllowEditing = false;
                //fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD].AllowEditing = true;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS].AllowEditing = false;
                //fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD].AllowEditing = true;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS].AllowEditing = false;

                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS).StyleNew.BackColor = Color.LightGreen;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS).StyleNew.ForeColor = Color.Black;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.BackColor = Color.Orange;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.ForeColor = Color.Black;

                fgrid_main.ContextMenuStrip = null;
            }
            else
            {
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS].AllowEditing = false;
                fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS].AllowEditing = false;

                fgrid_main.ContextMenuStrip = null;
                tbtn_Save.Enabled = false;
            }
        }

        private string GetAuthor()
        {
            if (_UserList != null)
            {
                for (int iIdx = 0; iIdx < _UserList.Length; iIdx++)
                {
                    string[] saTmp = _UserList[iIdx];

                    if (saTmp[0].Equals(COM.ComVar.This_User))
                    {
                        return saTmp[1];
                    }
                }
            }

            return "00";
        }

        private void Init_Control()
        {
            change_flg = true;

            // factory
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(vDT, cmb_factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;
            vDT.Dispose();

            // category 
            vDT = ClassLib.ComFunction.Select_Com_List(COM.ComVar.This_Factory, COM.ComVar.CxCategory);
            ClassLib.ComCtl.Set_Factory_List(vDT, cmb_category, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;
            vDT.Dispose();

            // user setting 
            vDT = ClassLib.ComFunction.Select_Com_List(COM.ComVar.This_Factory, "SBC55");
            if (vDT != null && vDT.Rows.Count > 0)
            {
                _UserList = new string[vDT.Rows.Count][];
                for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
                {
                    _UserList[iIdx] = new string[] { vDT.Rows[iIdx].ItemArray[1].ToString(), vDT.Rows[iIdx].ItemArray[2].ToString() };
                }
                vDT.Dispose();
            }

            Ship_Date_Setting();
            OBS_ID_Setting();

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;
            txt_style_cd.CharacterCasing = CharacterCasing.Upper;

            change_flg = false;
        }

        private void Ship_Date_Setting()
        {            
            if (cmb_factory.SelectedValue == null)
                return;

            string arg_factory = cmb_factory.SelectedValue.ToString().Trim();
            DataTable dt_ret = SELECT_SXC_SHIP_DATE(arg_factory);

            if (dt_ret.Rows.Count > 0)
            {
                string arg_ship_date = dt_ret.Rows[0].ItemArray[0].ToString().Trim();

                try
                {
                    int year  = int.Parse(arg_ship_date.Substring(0, 4));
                    int month = int.Parse(arg_ship_date.Substring(4, 2));
                    int day   = int.Parse(arg_ship_date.Substring(6, 2));

                    DateTime ship_date = new DateTime(year, month, day);

                    dpk_get_from.Value = DateTime.Now.AddDays(-14);
                    dpk_get_to.Value = ship_date;
                }
                catch
                {
                    dpk_get_from.Value = DateTime.Now.AddDays(-14);
                    dpk_get_to.Value = DateTime.Now;  
                }
            }
            else
            {
                dpk_get_from.Value = DateTime.Now.AddDays(-14);
                dpk_get_to.Value = DateTime.Now; 
            }
        }
        private void OBS_ID_Setting()
        {
            if (cmb_factory.SelectedValue == null)
                return;

            string[] arg_value = new string[3];

            arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");

            DataTable dt_ret = SELECT_SXC_OBS_ID(arg_value);

            if (dt_ret.Rows.Count > 0)
            {
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_dpo_from, 0, 0, false, 0, 90);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_dpo_to, 0, 0, false, 0, 90);

                try
                {
                    cmb_dpo_from.SelectedIndex = 0;
                    cmb_dpo_to.SelectedIndex = dt_ret.Rows.Count - 1;
                }
                catch
                {
                    cmb_dpo_from.SelectedIndex = 0;
                    cmb_dpo_to.SelectedIndex = 0; 
                }
            }
        }
        private DataTable SELECT_SXC_SHIP_DATE(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_CFM_SELECT.SELECT_SXC_SHIP_DATE";

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
        private DataTable SELECT_SXC_OBS_ID(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_CFM_SELECT.SELECT_SXC_OBS_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SHIP_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SHIP_TO";
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
        private void Init_WebSvc()
        {
            My_WebSvc = COM.ComVar._WebSvc;

            if (COM.ComVar.This_Factory.Equals("DS"))
            {
                QD_WebSvc = new COM.WebSvc.OraPKG();
                VJ_WebSvc = new COM.WebSvc.OraPKG();
                JJ_WebSvc = new COM.WebSvc.OraPKG();

                QD_WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                VJ_WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                JJ_WebSvc.Url = COM.ComVar.JJ_WebSvc_Url;
            }
            else
            {
                DS_WebSvc = new COM.WebSvc.OraPKG();
                DS_WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
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
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            string[] arg_value = new string[8];

            arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();            
            arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            arg_value[3] = (cmb_dpo_from.SelectedValue == null) ? "" : cmb_dpo_from.SelectedValue.ToString();
            arg_value[4] = (cmb_dpo_to.SelectedValue == null) ? "" : cmb_dpo_to.SelectedValue.ToString();
            arg_value[5] = cmb_category.SelectedValue.ToString().Trim();
            arg_value[6] = txt_model.Text.Trim();
            arg_value[7] = txt_style_cd.Text.Trim().Replace("-", "");

            DataTable dt = SELECT_SXC_SCH_CFM(arg_value);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    fgrid_main.Rows.Add();

                    for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                    }

                    Grid_StyleSetting(fgrid_main.Rows.Count - 1);
                }

                
            }
        }

        private void Grid_StyleSetting(int arg_row)
        {
            string status = (fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] == null) ? "" : fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS].ToString().Trim();
                        
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV,       arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxFACTORY_V).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.White;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD,  arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.White;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD  ).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDPO,       arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxGEN      ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.White;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT,       arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT      ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.FloralWhite;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT,       arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT      ).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxQTY,       arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDD_YN    ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.White;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.FloralWhite;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxYIELD,     arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxYIELD    ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.White;

            // Ship Date
            string ship_ymd_style = arg_row.ToString() + "-" + Convert.ToString((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD);
            CellStyle cellst = fgrid_main.Styles.Add(ship_ymd_style);
            cellst.DataType = typeof(DateTime);
            cellst.Format = "MMdd";
            cellst.BackColor = (status.Equals("D")) ? Color.LightGray : Color.Honeydew;
            cellst.ForeColor = Color.Black;
            cellst.TextAlign = TextAlignEnum.CenterCenter;

            CellRange cellrg = fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD);
            cellrg.Style = fgrid_main.Styles[ship_ymd_style];
            string ship_ymd = (fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD] == null) ? "" : fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD].ToString().Trim();

            try
            {
                if (!ship_ymd.Equals(""))
                {
                    int s_ship_year = int.Parse(ship_ymd.Substring(0, 4));
                    int s_ship_month = int.Parse(ship_ymd.Substring(4, 2));
                    int s_ship_day = int.Parse(ship_ymd.Substring(6, 2));

                    DateTime date = new DateTime(s_ship_year, s_ship_month, s_ship_day);
                    fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD] = date;
                }
            }
            catch
            {

            }

            // S Plan Date
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.Honeydew;

            string s_plan_stlye = arg_row.ToString() + "-" + Convert.ToString((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD);
            cellst = fgrid_main.Styles.Add(s_plan_stlye);
            cellst.DataType = typeof(DateTime);
            cellst.Format = "MMdd";
            cellst.BackColor = (status.Equals("D")) ? Color.LightGray : Color.Honeydew;
            cellst.ForeColor = Color.Black;
            cellst.TextAlign = TextAlignEnum.CenterCenter;

            cellrg = fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD);
            cellrg.Style = fgrid_main.Styles[s_plan_stlye];
            string s_plan_ymd = (fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD] == null) ? "" : fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD].ToString().Trim();

            try
            {
                if (!s_plan_ymd.Equals(""))
                {
                    int s_plan_year = int.Parse(s_plan_ymd.Substring(0, 4));
                    int s_plan_month = int.Parse(s_plan_ymd.Substring(4, 2));
                    int s_plan_day = int.Parse(s_plan_ymd.Substring(6, 2));

                    DateTime date = new DateTime(s_plan_year, s_plan_month, s_plan_day);
                    fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD] = date;
                }
            }
            catch
            {

            }


            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.Honeydew;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS).StyleNew.ForeColor = Color.Black;


            // C Plan Date
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.LemonChiffon;
            
            string c_plan_stlye = arg_row.ToString() + "-" + Convert.ToString((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD);
            cellst = fgrid_main.Styles.Add(c_plan_stlye);
            cellst.DataType = typeof(DateTime);
            cellst.Format = "MMdd";
            cellst.BackColor = (status.Equals("D")) ? Color.LightGray : Color.LemonChiffon;
            cellst.ForeColor = Color.Black;
            cellst.TextAlign = TextAlignEnum.CenterCenter;            

            cellrg = fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD);
            cellrg.Style = fgrid_main.Styles[c_plan_stlye];
            string c_plan_ymd = (fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD] == null) ? "" : fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD].ToString().Trim();

            try
            {
                if (!c_plan_ymd.Equals(""))
                {
                    int c_plan_year = int.Parse(c_plan_ymd.Substring(0, 4));
                    int c_plan_month = int.Parse(c_plan_ymd.Substring(4, 2));
                    int c_plan_day = int.Parse(c_plan_ymd.Substring(6, 2));

                    DateTime date = new DateTime(c_plan_year, c_plan_month, c_plan_day);
                    fgrid_main[arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD] = date;
                }
            }
            catch
            {

            }



            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.LemonChiffon;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxASSEMBLY, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxASSEMBLY).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray : Color.White;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS,  arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray :Color.FloralWhite;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS,  arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS ).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxUPD_USER, arg_row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxUPD_YMD ).StyleNew.BackColor = (status.Equals("D")) ? Color.LightGray :Color.White;

            if (status.Equals("D"))
                fgrid_main.Rows[arg_row].AllowEditing = false;
            else
                fgrid_main.Rows[arg_row].AllowEditing = true;
        }


        private DataTable SELECT_SXC_SCH_CFM(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_CFM_SELECT.SELECT_SXC_SCH_CFM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SHIP_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SHIP_TO";
                MyOraDB.Parameter_Name[3] = "ARG_DPO_FROM";
                MyOraDB.Parameter_Name[4] = "ARG_DPO_TO";
                MyOraDB.Parameter_Name[5] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[6] = "ARG_MODEL";
                MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";                
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;                
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = arg_value[7];                
                MyOraDB.Parameter_Values[8] = "";

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
                Save_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                COM.ComVar._WebSvc = My_WebSvc;
            }
        }

        private void Save_Data()
        {
            fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1, fgrid_main.Selection.r1, fgrid_main.Selection.c1, false);
            if (SAVE_SXC_SCH_CFM())
            {
                Save_After_Grid_Style();
                MessageBox.Show("Save Complete!!");
            }
            else
            {
                MessageBox.Show("Save Complete!!");
            }

            //if (COM.ComVar.This_Factory.Equals("DS"))
            //{
            //    COM.ComVar._WebSvc = QD_WebSvc;
            //    if (SAVE_SXC_SCH_CFM())
            //    {
            //        COM.ComVar._WebSvc = VJ_WebSvc;
            //        if (SAVE_SXC_SCH_CFM())
            //        {
            //            COM.ComVar._WebSvc = JJ_WebSvc;
            //            if (SAVE_SXC_SCH_CFM())
            //            {
            //                COM.ComVar._WebSvc = My_WebSvc;
            //                if (SAVE_SXC_SCH_CFM())
            //                {
            //                    Save_After_Grid_Style();
            //                }
            //            }
            //        }                    
            //    }
            //}
            //else
            //{
            //    COM.ComVar._WebSvc = DS_WebSvc;
            //    if (SAVE_SXC_SCH_CFM())
            //    {
            //        COM.ComVar._WebSvc = My_WebSvc;
            //        if (SAVE_SXC_SCH_CFM())
            //        {
            //            Save_After_Grid_Style();
            //        }
            //    }
            //}
        }

        private void Save_After_Grid_Style()
        {
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string div = (fgrid_main[i, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV].ToString().Trim();

                if (!div.Equals(""))
                {
                    Grid_StyleSetting(i); 
                }
            }

            fgrid_main.ClearFlags(); 
        }
        private bool SAVE_SXC_SCH_CFM()
        {
            int vcnt = 27;
            MyOraDB.ReDim_Parameter(vcnt);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXC_SCH_CFM.SAVE_SXC_SCH_CFM";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID";
            MyOraDB.Parameter_Name[3]  = "ARG_OBS_TYPE";
            MyOraDB.Parameter_Name[4]  = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[5]  = "ARG_ORD_QTY";
            MyOraDB.Parameter_Name[6] = "ARG_LOSS_QTY";
            MyOraDB.Parameter_Name[7]  = "ARG_FIRST_SHIP_YMD";
            MyOraDB.Parameter_Name[8]  = "ARG_ARRIVAL_YMD";
            MyOraDB.Parameter_Name[9]  = "ARG_PACKING";
            MyOraDB.Parameter_Name[10]  = "ARG_MODEL_NAME";
            MyOraDB.Parameter_Name[11]  = "ARG_GENDER";
            MyOraDB.Parameter_Name[12] = "ARG_CATEGORY_DESC";
            MyOraDB.Parameter_Name[13] = "ARG_CDC_DEV";
            MyOraDB.Parameter_Name[14] = "ARG_YIELD_STATUS";
            MyOraDB.Parameter_Name[15] = "ARG_S_TGT_YMD";
            MyOraDB.Parameter_Name[16] = "ARG_S_PLAN_YMD";
            MyOraDB.Parameter_Name[17] = "ARG_S_STATUS";
            MyOraDB.Parameter_Name[18] = "ARG_C_TGT_YMD";
            MyOraDB.Parameter_Name[19] = "ARG_C_PLAN_YMD";
            MyOraDB.Parameter_Name[20] = "ARG_C_STATUS";
            MyOraDB.Parameter_Name[21] = "ARG_ASSEMBLY_SCH";
            MyOraDB.Parameter_Name[22] = "ARG_DD_YN";
            MyOraDB.Parameter_Name[23] = "ARG_CFM_DIV";
            MyOraDB.Parameter_Name[24] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[25] = "ARG_STATUS";
            MyOraDB.Parameter_Name[26] = "ARG_UPD_USER";
            

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _div = (fgrid_main[i, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV].ToString().Trim();

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
                string _div = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxFACTORY    ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxFACTORY    ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxOBS_ID     ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxOBS_ID     ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxOBS_TYPE   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxOBS_TYPE   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTYLE_CD   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTYLE_CD   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxQTY        ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxQTY        ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxLOSS       ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxLOSS       ].ToString().Trim();
                //MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = Get_DateToString(row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSHIP_YMD);
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxARRIVAL_YMD] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxARRIVAL_YMD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxPK_NO      ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxPK_NO      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxMODEL      ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxMODEL      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxGEN        ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxGEN        ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT        ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT        ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER  ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxYIELD      ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxYIELD      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD  ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = Get_DateToString(row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD);
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD  ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD  ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = Get_DateToString(row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD);
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxASSEMBLY   ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxASSEMBLY   ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDD_YN      ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDD_YN      ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCFM_DIV    ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCFM_DIV    ].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS    ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS    ].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS     ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS     ].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet vDS = MyOraDB.Exe_Modify_Procedure();

            if (vDS == null) return false;
            return true;
        }

        private string Get_DateToString(int arg_row, int arg_col)
        {
            try
            {
                string value = (fgrid_main[arg_row, arg_col] == null) ? "" : Convert.ToDateTime(fgrid_main[arg_row, arg_col]).ToString("yyyyMMdd");

                return value;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Print_Data()
        {
            string mrd_Filename = Application.StartupPath + @"\Report\CFM_Schedule.mrd";


            string[] arg_value = new string[8];

            arg_value[0] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            arg_value[3] = (cmb_dpo_from.SelectedValue == null) ? "" : cmb_dpo_from.SelectedValue.ToString();
            arg_value[4] = (cmb_dpo_to.SelectedValue == null) ? "" : cmb_dpo_to.SelectedValue.ToString();
            arg_value[5] = cmb_category.SelectedValue.ToString().Trim();
            arg_value[6] = txt_model.Text.Trim();
            arg_value[7] = txt_style_cd.Text.Trim().Replace("-", "");


            string sPara = " /rp " + " [" + arg_value[0] + "]"
                                   + " [" + arg_value[1] + "]"
                                   + " [" + arg_value[2] + "]"
                                   + " [" + arg_value[3] + "]"
                                   + " [" + arg_value[4] + "]"
                                   + " [" + arg_value[5] + "]"
                                   + " [" + arg_value[6] + "]"
                                   + " [" + arg_value[7] + "]";

            FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
            report.ShowDialog(); 
        }
        #endregion

        #region Grid Event
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                Grid_AfterEdit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void Grid_AfterEdit()
        {
            int[] sct_rows = fgrid_main.Selections;
            int sct_row = fgrid_main.Selection.r1;
            int sct_col = fgrid_main.Selection.c1;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_main[sct_rows[i], sct_col] = fgrid_main[sct_row, sct_col];

                string div = (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] == null) ? "" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV].ToString().Trim();

                if (div.Equals(""))
                {
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] = "U";
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] = "Y";
                }
            }

        }
        private void fgrid_main_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                e.Cancel = Grid_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Grid_BeforeEdit()
        {
            int iRow = fgrid_main.Row, iCol = fgrid_main.Col;

            string sAut = GetAuthor();

            if (sAut.Equals("02"))
            {
                string sStatus = "";

                if (iCol == (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_TGT_YMD || iCol == (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD)
                {
                    sStatus = fgrid_main[iRow, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS] == null ? "N" : fgrid_main[iRow, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS].ToString();
                }
                else if (iCol == (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_TGT_YMD || iCol == (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD)
                {
                    sStatus = fgrid_main[iRow, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS] == null ? "N" : fgrid_main[iRow, (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS].ToString();
                }

                if (sStatus.ToUpper().Trim().Equals("OK"))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region Control Event
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (change_flg)
                    return;

                Ship_Date_Setting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
        private void dpk_get_from_CloseUp(object sender, EventArgs e)
        {
            try
            {
                if (change_flg)
                    return;

                OBS_ID_Setting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }      
        }

        private void dpk_get_to_CloseUp(object sender, EventArgs e)
        {
            try
            {
                if (change_flg)
                    return;

                OBS_ID_Setting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }      
        }
        private void txt_model_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;

                    Display_Data();
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

        private void txt_style_cd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;

                    Display_Data();
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
        #endregion

        #region ContextMenu Event
        private void mnu_delete_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Data_Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mnu_release_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Data_Release();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mnu_data_clear_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenu_Data_Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void ContextMenu_Data_Delete()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int sct_row = fgrid_main.Selection.r1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            int[] sct_rows = fgrid_main.Selections;
            int sct_col = fgrid_main.Selection.c1;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                string status = (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] == null) ? "" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS].ToString().Trim();

                if (status.Equals("D"))
                    continue;

                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] = "D";
                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] = "D";

            }
        }
        private void ContextMenu_Data_Release()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int sct_row = fgrid_main.Selection.r1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            int[] sct_rows = fgrid_main.Selections;
            int sct_col = fgrid_main.Selection.c1;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                string status = (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] == null) ? "" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS].ToString().Trim();

                if (!status.Equals("D"))
                    continue;

                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] = "U";
                fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] = "Y";
            }
        }
        private void ContextMenu_Data_Clear()
        {
            if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            int sct_row = fgrid_main.Selection.r1;

            if (sct_row < fgrid_main.Rows.Fixed)
                return;

            int[] sct_rows = fgrid_main.Selections;
            int sct_col = fgrid_main.Selection.c1;

            if (sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxCAT) ||
               sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDEVELOPER) ||
               sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_PLAN_YMD) ||
               sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxS_STATUS) ||
               sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_PLAN_YMD) ||
               sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxC_STATUS) ||
               sct_col.Equals((int)ClassLib.TBSXC_SCH_CFM_SHOE.IxREMARKS))
            {

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string div = (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] == null) ? "" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV].ToString().Trim();
                    string status = (fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] == null) ? "" : fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS].ToString().Trim();

                    if (status.Equals("D"))
                        continue;

                    fgrid_main[sct_rows[i], sct_col] = null;

                    if (div.Equals(""))
                    {
                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxDIV] = "U";
                        fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_CFM_SHOE.IxSTATUS] = "Y";
                    }
                }
            }
        }
        #endregion


    }
}

