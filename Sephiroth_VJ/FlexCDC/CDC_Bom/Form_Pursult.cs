using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;
using System.IO;





namespace FlexCDC.CDC_Bom
{
    public partial class Form_Pursult : COM.PCHWinForm.Form_Top
    {
        #region User Defina Variable
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        private COM.OraDB OraDB = new COM.OraDB();
        private int _RowFixed = 0;
        #endregion

        #region Constructor
        public Form_Pursult()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Pursult_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Init_Form()
        {
            this.Text = "PCC_Mornitoring for Korea Purchase";
            this.lbl_MainTitle.Text = "PCC_Mornitoring for Korea Purchase";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Grid();
            Init_Combo();
        }

        private void Init_Grid()
        {
            fgrid_mat.Set_Grid_CDC("SXP_MAT_RERSULT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_mat.Set_Action_Image(img_Action);
            fgrid_mat.ExtendLastCol = false;
            _RowFixed = fgrid_mat.Rows.Fixed; 
        }
        private void Init_Combo()
        {
            DataTable dt_ret = SELECT_ROUND();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_sampletype.SelectedIndex = 0;

            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            COM.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, 0, 120);
            cmb_pur_div.SelectedIndex = 0;

            try
            {
                cmb_Type.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
                cmb_Type.ClearItems();

                cmb_Type.AddItemTitles("Code;Name");

                cmb_Type.ValueMember = "Code";
                cmb_Type.DisplayMember = "Name";

                //////////////////////////////////////////////////////
                cmb_Type.AddItem("M;MRP");
                cmb_Type.AddItem("B;BOM");

                cmb_Type.SelectedIndex = -1;

                cmb_Type.MaxDropDownItems = 10;
                cmb_Type.Splits[0].DisplayColumns[0].Width = 0;
                cmb_Type.Splits[0].DisplayColumns[1].Width = 120;

                cmb_Type.ExtendRightColumn = true;
                cmb_Type.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
                cmb_Type.HScrollBar.Height = 0;

                cmb_Type.SelectedIndex = 0;
            }
            catch
            {

            }

            if (COM.ComVar.This_Factory == "DS")
                fgrid_mat.ContextMenuStrip = null;

            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Print.Enabled = true;
            tbtn_Save.Enabled = false;
            tbtn_Search.Enabled = true;
            tbtn_Create.Enabled = false;

        }

        private DataTable SELECT_ROUND()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
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
            fgrid_mat.Rows.Count = _RowFixed;

            string arg_factory     = cmb_factory.SelectedValue.ToString();
            string arg_mrp_no      = (cmb_mrp_no.SelectedValue == null) ? "" : cmb_mrp_no.SelectedValue.ToString();
            string arg_sr_no       = txt_sr_no.Text.Trim();
            string arg_srf_no      = txt_srfno.Text.Trim();
            string arg_bom_id      = txt_bomid.Text.Trim();
            string arg_nf_cd       = cmb_sampletype.SelectedValue.ToString();
            string arg_search_type = cmb_Type.SelectedValue.ToString();
            string arg_pur_div     = "";

            if (cmb_Type.SelectedValue.ToString() == "B")
                arg_pur_div = cmb_pur_div.SelectedValue.ToString();
            if (cmb_Type.SelectedValue.ToString() == "M")
                arg_pur_div = cmb_sampletype.SelectedValue.ToString();


            if (cmb_Type.SelectedValue.ToString() == "B" && arg_sr_no == "" && arg_srf_no == "" && arg_bom_id == "")
                return;
            if (cmb_Type.SelectedValue.ToString() == "M" && arg_mrp_no == "")
                return;

            string[] arg_value = new string[8];

            arg_value[0] = arg_factory;
            arg_value[1] = arg_mrp_no;
            arg_value[2] = arg_sr_no;
            arg_value[3] = arg_srf_no;
            arg_value[4] = arg_bom_id;
            arg_value[5] = arg_nf_cd;
            arg_value[6] = arg_pur_div;
            arg_value[7] = arg_search_type;

            DataTable dt = SELECT_MAT_PURSULT(arg_value);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_mat.AddItem(dt.Rows[i].ItemArray);
            }

            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxMRP_NO].Style.BackColor = Color.FromArgb(255, 213, 213);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxMRP_YMD].Style.BackColor = Color.FromArgb(255, 213, 213);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxMRP_NO].Style.ForeColor = Color.FromArgb(210, 0, 0);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxMRP_YMD].Style.ForeColor = Color.FromArgb(210, 0, 0);

            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_NO].Style.BackColor = Color.FromArgb(232, 255, 213);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_YMD].Style.BackColor = Color.FromArgb(232, 255, 213);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxETC_YMD].Style.BackColor = Color.FromArgb(232, 255, 213);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_NO].Style.ForeColor = Color.FromArgb(95, 210, 0);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_YMD].Style.ForeColor = Color.FromArgb(95, 210, 0);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxETC_YMD].Style.ForeColor = Color.FromArgb(95, 210, 0);


            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxIN_NO].Style.BackColor = Color.FromArgb(213, 226, 255);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxIN_YMD].Style.BackColor = Color.FromArgb(213, 226, 255);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxIN_NO].Style.ForeColor = Color.FromArgb(111, 0, 210);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxIN_YMD].Style.ForeColor = Color.FromArgb(111, 0, 210);

            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxSHIP_NO].Style.BackColor = Color.FromArgb(255, 213, 249);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxSHIP_YMD].Style.BackColor = Color.FromArgb(255, 213, 249);
            fgrid_mat.Cols[(int)ClassLib.TBSXP_MAT_RERSULT.IxETA_YMD].Style.BackColor = Color.FromArgb(255, 213, 249);
            
            if (COM.ComVar.This_Factory == "DS")
            {
                getDataToolStripMenuItem_Click(null, null);
            } 
        }

        private DataTable SELECT_MAT_PURSULT(string [] arg_value)
        {
            string Proc_Name = "PKG_SXD_SRF_02_SELECT.SELECT_MAT_PURSUIT_00";

            OraDB.ReDim_Parameter(9);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_MRP_NO";
            OraDB.Parameter_Name[2] = "ARG_SR_NO";
            OraDB.Parameter_Name[3] = "ARG_SRF_NO";
            OraDB.Parameter_Name[4] = "ARG_BOM_ID";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "ARG_PUR_DIV";
            OraDB.Parameter_Name[7] = "ARG_SEARCH_TYPE";
            OraDB.Parameter_Name[8] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = arg_value[3];
            OraDB.Parameter_Values[4] = arg_value[4];
            OraDB.Parameter_Values[5] = arg_value[5];
            OraDB.Parameter_Values[6] = arg_value[6];
            OraDB.Parameter_Values[7] = arg_value[7];
            OraDB.Parameter_Values[8] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Print_Data();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void Print_Data()
        {            
            string txt_Filename = "", mrd_Filename = "";

            mrd_Filename = "Korea_Material_Information.mrd";
            txt_Filename = "Korea_Material_Information.txt";


            string Para = " ";

            int iCnt = 4;
            string[] aHead = new string[iCnt];
            aHead[0] = cmb_factory.SelectedValue.ToString();
            aHead[1] = (cmb_Type.SelectedValue.ToString() == "M") ? "MRP" : "BOM";

            if (cmb_Type.SelectedValue.ToString() == "M")
            {
                aHead[2] = ClassLib.ComFunction.Empty_Combo(cmb_mrp_no, " ");
                aHead[3] = "";
            }
            if (cmb_Type.SelectedValue.ToString() == "B")
            {
                aHead[2] = "";
                aHead[3] = ClassLib.ComFunction.Empty_TextBox(txt_bomid, " ");
            }

            // aHead[4] = ClassLib.ComFunction.Empty_Combo(cmb_pur_div, " ");

            Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "V_" + i.ToString().PadLeft(2, '0').ToString() + "[" + aHead[i - 1] + "] ";
            }
            
            #region File Create
            FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
            if (!file.Exists)
            {
                file.Create().Close();
            }
            file = null;

            FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(sDatalist);


            for (int i = fgrid_mat.Rows.Fixed; i < fgrid_mat.Rows.Count; i++)
            {
                string sData = " ";


                for (int j = 0; j < fgrid_mat.Cols.Count; j++)
                {
                    if (fgrid_mat[i, j] == null)
                        sData = sData + "@";
                    else
                        if (j == (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_DIV) //purdiv
                        {
                            string vdiv = "";
                            if (fgrid_mat[i, j].ToString().Trim().Replace("\r\n", "") == "12")
                                vdiv = "Local";
                            else if (fgrid_mat[i, j].ToString().Trim().Replace("\r\n", "") == "11")
                                vdiv = "Korea";
                            else
                                vdiv = "Import";

                            sData = sData + vdiv + "@";
                        }

                        else
                            sData = sData + fgrid_mat[i, j].ToString().Trim().Replace("\r\n", "") + "@";

                }
                sw.WriteLine(sData);                
            }


            sw.Flush();
            sw.Close();
            sDatalist.Close();
            #endregion

            FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
            report.ShowDialog();
        }
        #endregion

        #region Grid Event
        private void fgrid_mat_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                    return;

                Get_Data_Grid();
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

        private void Get_Data_Grid()
        {
            int sct_row = fgrid_mat.Selection.r1;

            if (sct_row < fgrid_mat.Rows.Fixed)
                return;                      

            string[] arg_value = new string[8];

            arg_value[0] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxFACTORY].ToString();
            arg_value[1] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxMRP_NO].ToString();
            arg_value[2] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxLOT_NO].ToString();
            arg_value[3] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxLOT_SEQ].ToString();
            arg_value[4] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxPART_NO].ToString();
            arg_value[5] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxMAT_CD].ToString();
            arg_value[6] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxPCC_SPEC_CD].ToString();
            arg_value[7] = fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxCOLOR_CD].ToString();

            string pur_div = (fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_DIV] == null) ? "" : fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_DIV].ToString().Trim();

            if (pur_div.Equals("11"))
                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

            DataTable dt = SELECT_MAT_PURSULT_TAIL(arg_value);

            if (pur_div.Equals("11"))
            {
                string _factory = "";

                if (COM.ComVar.This_Factory == "VJ")
                    _factory = COM.ComVar.VJ_WebSvc_Url;
                else if (COM.ComVar.This_Factory == "QD")
                    _factory = COM.ComVar.QD_WebSvc_Url;
                else
                    _factory = COM.ComVar.DS_WebSvc_Url;

                COM.ComVar._WebSvc.Url = _factory;
            }


            if (dt.Rows.Count > 0)
            {
                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_NO] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxPUR_NO].ToString();
                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxPUR_YMD].ToString();
                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxETC_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxETC_YMD].ToString();

                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxIN_NO] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxIN_NO].ToString();
                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxIN_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxIN_YMD].ToString();

                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxSHIP_NO] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxSHIP_NO].ToString();
                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxSHIP_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxSHIP_YMD].ToString();
                fgrid_mat[sct_row, (int)ClassLib.TBSXP_MAT_RERSULT.IxETA_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxETA_YMD].ToString();
            }            
        }
        private void Open_waiting_Form()
        {
            _pop = new FlexCDC.BaseInfo.Pop_BS_Shipping_List_Wait();
            _pop.Searching_Start();
        }

        private DataTable SELECT_MAT_PURSULT_TAIL(string []  arg_value)
        {
            string Proc_Name = "PKG_SXD_SRF_02_SELECT.SELECT_MAT_PURSUIT_01";

            OraDB.ReDim_Parameter(9);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_MRP_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_NO";
            OraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[4] = "ARG_PART_NO";
            OraDB.Parameter_Name[5] = "ARG_MAT_CD";
            OraDB.Parameter_Name[6] = "ARG_SPEC_CD";
            OraDB.Parameter_Name[7] = "ARG_COLOR_CD";
            OraDB.Parameter_Name[8] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = arg_value[3];
            OraDB.Parameter_Values[4] = arg_value[4];
            OraDB.Parameter_Values[5] = arg_value[5];
            OraDB.Parameter_Values[6] = arg_value[6];
            OraDB.Parameter_Values[7] = arg_value[7];
            OraDB.Parameter_Values[8] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region ContextMenu Event
        private void getDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_mat.Rows.Count.Equals(fgrid_mat.Rows.Fixed))
                    return;

                Get_Data_Context();
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

        private void Get_Data_Context()
        {
            for (int i = fgrid_mat.Rows.Fixed; i < fgrid_mat.Rows.Count; i++)
            {
                string[] arg_value = new string[8];

                arg_value[0] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxFACTORY].ToString();
                arg_value[1] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxMRP_NO].ToString();
                arg_value[2] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxLOT_NO].ToString();
                arg_value[3] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxLOT_SEQ].ToString();
                arg_value[4] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxPART_NO].ToString();
                arg_value[5] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxMAT_CD].ToString();
                arg_value[6] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxPCC_SPEC_CD].ToString();
                arg_value[7] = fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxCOLOR_CD].ToString();

                string pur_div = (fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_DIV] == null) ? "" : fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_DIV].ToString().Trim();

                if (pur_div.Equals("11"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

                DataTable dt = SELECT_MAT_PURSULT_TAIL(arg_value);

                if (pur_div.Equals("11"))
                {
                    string _factory = "";

                    if (COM.ComVar.This_Factory == "VJ")
                        _factory = COM.ComVar.VJ_WebSvc_Url;
                    else if (COM.ComVar.This_Factory == "QD")
                        _factory = COM.ComVar.QD_WebSvc_Url;
                    else
                        _factory = COM.ComVar.DS_WebSvc_Url;

                    COM.ComVar._WebSvc.Url = _factory;
                }


                if (dt.Rows.Count > 0)
                {
                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_NO] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxPUR_NO].ToString();
                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxPUR_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxPUR_YMD].ToString();
                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxETC_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxETC_YMD].ToString();

                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxIN_NO] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxIN_NO].ToString();
                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxIN_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxIN_YMD].ToString();

                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxSHIP_NO] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxSHIP_NO].ToString();
                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxSHIP_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxSHIP_YMD].ToString();
                    fgrid_mat[i, (int)ClassLib.TBSXP_MAT_RERSULT.IxETA_YMD] = dt.Rows[0].ItemArray[(int)ClassLib.TBSELECT_MAT_PURSUIT_01.IxETA_YMD].ToString();
                }
            }
        }
        #endregion

        #region Control Event
        private void cmb_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Type_SelectChange();
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

        private void dtp_From_Date_CloseUp(object sender, EventArgs e)
        {
            try
            {
                Date_SelectChange();
            }
            catch
            {
 
            }
        }

        private void dtp_To_Date_CloseUp(object sender, EventArgs e)
        {
            try
            {
                Date_SelectChange();
            }
            catch
            {

            }
        }
        
        

        private void Type_SelectChange()
        {
            if (cmb_Type.SelectedValue.ToString() == "B")
            {
                label3.Text = "      Search BOM";
                lbl_sr_no.Text = "SR No";
                txt_sr_no.Visible = true;
                lbl_bomid.Text = "BOM ID";
                txt_bomid.Visible = true;
                cmb_mrp_no.Visible = false;

                dtp_From_Date.Visible = false;
                dtp_To_Date.Visible = false;
                lbl_Dash.Visible = false;

                lbl_sefno.Visible = true;
                txt_srfno.Visible = true;

                lbl_sampletype.Text = "Sample Types";
                DataTable dt_ret = SELECT_ROUND();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
                cmb_sampletype.SelectedIndex = 0;

                lbl_pur_div.Visible = true;
                cmb_pur_div.Visible = true;

                lbl_sampletype.Visible = true;
                cmb_sampletype.Visible = true;

                txt_sr_no.Clear();
                txt_srfno.Clear();
                txt_bomid.Clear();

                fgrid_mat.Rows.Count = fgrid_mat.Rows.Fixed;
            }
            else if (cmb_Type.SelectedValue.ToString() == "M")
            {
                label3.Text = "      Search MRP";
                lbl_sr_no.Text = "Date";
                txt_sr_no.Visible = false;
                lbl_bomid.Text = "MRP No";
                txt_bomid.Visible = false;
                cmb_mrp_no.Visible = true;

                dtp_From_Date.Visible = true;
                dtp_To_Date.Visible = true;
                lbl_Dash.Visible = true;

                lbl_sefno.Visible = false;
                txt_srfno.Visible = false;

                lbl_pur_div.Visible = false;
                cmb_pur_div.Visible = false;

                DataTable ds_ret = SELECT_MRP_NO();
                ClassLib.ComCtl.Set_ComboList(ds_ret, cmb_mrp_no, 0, 0, false, 0, 160);
                if (ds_ret.Rows.Count != 0)
                    cmb_mrp_no.SelectedIndex = 0;

                lbl_sampletype.Text = "Purchase Div.";
                ds_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
                COM.ComCtl.Set_ComboList(ds_ret, cmb_sampletype, 1, 2, true, 0, 120);
                cmb_sampletype.SelectedIndex = 0;

                fgrid_mat.Rows.Count = fgrid_mat.Rows.Fixed;
            }
 
        }
        private void Date_SelectChange()
        {
            DataTable ds_ret = SELECT_MRP_NO();
            ClassLib.ComCtl.Set_ComboList(ds_ret, cmb_mrp_no, 0, 0, false, 0, 160);
            if (ds_ret.Rows.Count != 0)
                cmb_mrp_no.SelectedIndex = 0; 
        }
        
        private DataTable SELECT_MRP_NO()
        {
            string Proc_Name = "PKG_SXD_SRF_02_SELECT.SELECT_MRP_NO";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            OraDB.Parameter_Name[2] = "ARG_TO_DATE";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = dtp_From_Date.Text;
            OraDB.Parameter_Values[2] = dtp_To_Date.Text;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion
    }
}

