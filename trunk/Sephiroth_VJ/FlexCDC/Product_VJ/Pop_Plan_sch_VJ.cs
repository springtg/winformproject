using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product_VJ
{
    public partial class Pop_Plan_sch_VJ : COM.PCHWinForm.Pop_Large_B
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService Connection
        public bool save_flg = false;
        
        private Form_Plan_sch_VJ tmp_mps = null;
        private string tmp_level = "";
        private string tmp_factory = "";
        private string tmp_ets = "";
        private string tmp_qty = "";
        private string tmp_sort_no = "";
        
        private Form_Prod_Result_OPCD_VJ tmp_prod_result = null;
        private string tmp_op = "";
        #endregion
        
        #region Resource
        public Pop_Plan_sch_VJ()
        {
            InitializeComponent();
        }       
        public Pop_Plan_sch_VJ(string arg_factory, string arg_qty, string arg_op, Form_Prod_Result_OPCD_VJ arg_prod_result)
        {
            tmp_prod_result = arg_prod_result;
            tmp_factory = arg_factory;
            tmp_qty = arg_qty;
            tmp_op = arg_op;

            InitializeComponent();
        }
        public Pop_Plan_sch_VJ(string arg_factory, string arg_ets, string arg_qty, string arg_sort_no, Form_Plan_sch_VJ arg_mps)
        {            
            tmp_mps         = arg_mps;
            tmp_factory     = arg_factory;
            tmp_ets         = arg_ets;
            tmp_qty         = arg_qty;
            tmp_sort_no     = arg_sort_no;

            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_Plan_sch_Load(object sender, EventArgs e)
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

        private void Init_Form()
        {
            //1. Title Setting
            this.Text = "PCC_MPS Data Change";
            this.lbl_MainTitle.Text = "PCC_MPS Data Change";
            ClassLib.ComFunction.SetLangDic(this);            

            //2. tbtn Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            //3. Grid Setting            
            flg_mps_pop.Set_Grid_CDC("SXG_MPS_POP_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            flg_mps_pop.Set_Action_Image(img_Action);
            flg_mps_pop.Rows.Count = flg_mps_pop.Rows.Fixed;
            flg_mps_pop.ExtendLastCol = false;

            flg_ups.Set_Grid_CDC("SXG_MPS_POP_VJ", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            flg_ups.Set_Action_Image(img_Action);
            flg_ups.Rows.Count = flg_ups.Rows.Fixed;
            flg_ups.ExtendLastCol = false;

            Grid_Data_Setting();
            
            flg_mps_pop.Select(flg_mps_pop.Rows.Fixed, (int)ClassLib.TBSXG_MPS_POP_VJ.IxMODEL);
            Grid_click(flg_mps_pop.Rows.Fixed);
            Control_Setting();
            tbtn_Search_Click(null, null);
        }

        private void Control_Setting()
        {
            if (tmp_mps != null)
            {
                txt_qty.Text = tmp_qty;

                int year  = int.Parse(tmp_ets.Substring(0, 4));
                int month = int.Parse(tmp_ets.Substring(4, 2));
                int day   = int.Parse(tmp_ets.Substring(6, 2));

                DateTime datetime = new DateTime(year, month, day);
                dtp_date.Value = datetime;

                if (tmp_level == "1")
                {
                    lbl_ets.Text = "ETS";
                }
                else
                {
                    lbl_ets.Text = flg_mps_pop[flg_mps_pop.Selection.r1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME].ToString();

                    txt_name.Enabled     = false;
                    txt_sabun.Enabled    = false;
                    txt_ups_user.Enabled = false;

                    txt_name.BackColor     = Color.WhiteSmoke;
                    txt_sabun.BackColor    = Color.WhiteSmoke;
                    txt_ups_user.BackColor = Color.WhiteSmoke;

                    flg_ups.AllowEditing = false;
                    flg_ups.Enabled      = false;
                    flg_ups.ForeColor    = Color.LightGray;
                }
            }
            else if (tmp_prod_result != null)
            {
                txt_qty.Text = tmp_qty;
                txt_qty.Enabled = false;

                dtp_date.Value = DateTime.Now;
                dtp_date.Enabled = false;

                if (tmp_op.Equals("UPS"))
                {
                    lbl_ets.Text = "재봉";
                }
                else if (tmp_op.Equals("UPC"))
                {
                    txt_sabun.Enabled = false;
                    txt_ups_user.Enabled = false;
                    txt_name.Enabled = false;
                    lbl_ets.Text = "재단";

                    flg_ups.AllowEditing = false;
                    flg_ups.Enabled = false;
                    flg_ups.ForeColor = Color.LightGray;
                }
            }


        }

        private void Grid_Data_Setting()
        {
            if (tmp_mps != null)
            {
                int[] sct_rows = tmp_mps.flg_sch.Selections;

                #region MPS
                if (tmp_mps.flg_sch[sct_rows[0], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                {
                    tmp_level = "1";
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                        {
                            #region 1 Level
                            if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() != "C")
                            {
                                flg_mps_pop.Rows.Add();

                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDIVISION]    = "";
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxMODEL]       = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxMODEL_NAME].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCOLOR_VER]   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCOLOR_VER].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxBOM_STYLE]   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxBOM_STYLECD].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxSAMPLE_TYPE] = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSAMPLE_TYPE].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUSER]        = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME]     = "ETS";
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxQTY]         = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO]      = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLINE_CD].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD]      = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD]       = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();

                                string arg_lot_no   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                                string arg_lot_seq  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                                string arg_ups_user = "";
                                for (int j = sct_rows[i]; j < tmp_mps.flg_sch.Rows.Count; j++)
                                {
                                    if (arg_lot_no == tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString() && arg_lot_seq == tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString())
                                    {
                                        if (tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() != "99")
                                        {
                                            string user = (tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME] == null) ? "" : tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString().Trim();
                                            if (user != "")
                                            {
                                                arg_ups_user = user;
                                                break;
                                            }
                                        }
                                    }
                                }

                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUPS_USER] = arg_ups_user;
                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS]  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxREMARKS].ToString(); ;

                                
                            }
                            #endregion
                        }
                    }

                    if (sct_rows.Length > 1)
                        txt_qty.Enabled = false;
                }
                else
                {
                    tmp_level = "2";

                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() != "99")
                        {
                            #region 2 Level 일때
                            if (tmp_sort_no.Equals("999"))
                            {
                                if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() != "C")
                                {
                                    flg_mps_pop.Rows.Add();

                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDIVISION]    = "";
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxMODEL]       = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxMODEL_NAME].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCOLOR_VER]   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCOLOR_VER].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxBOM_STYLE]   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxBOM_STYLECD].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxSAMPLE_TYPE] = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSAMPLE_TYPE].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUSER]        = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME]     = GET_CMP_CD(sct_rows[i]).Rows[0].ItemArray[2].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxQTY]         = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO]      = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLINE_CD].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD]      = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD]       = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUPS_USER]    = "";
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxREMARKS].ToString();
                                }
                            }
                            else
                            {
                                
                                if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() != "C")
                                {
                                    string arg_lot_no = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                                    string arg_lot_seq = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                                    string arg_ups_user = "";

                                    flg_mps_pop.Rows.Add();

                                    for (int j = tmp_mps.flg_sch.Rows.Fixed + 1; j < tmp_mps.flg_sch.Rows.Count; j++)
                                    {
                                        if (arg_lot_no == tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString() && arg_lot_seq == tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString())
                                        {
                                            if (tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                                            {
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDIVISION] = "";
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY] = tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxMODEL] = tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxMODEL_NAME].ToString();
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCOLOR_VER] = tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxCOLOR_VER].ToString();
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxBOM_STYLE] = tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_STYLECD].ToString();
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxSAMPLE_TYPE] = tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxSAMPLE_TYPE].ToString();
                                                flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUSER] = tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString();

                                            }
                                            else
                                            {
                                                string user = (tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME] == null) ? "" : tmp_mps.flg_sch[j, (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString().Trim();
                                                if (user != "")
                                                {
                                                    arg_ups_user = user;
                                                    break;
                                                }
                                            }
                                        }
                                    }

                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME] = GET_CMP_CD(sct_rows[i]).Rows[0].ItemArray[2].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxQTY]     = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO]  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ] = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ] = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD] = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLINE_CD].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD]  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD]   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();

                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUPS_USER] = arg_ups_user;
                                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS]  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxREMARKS].ToString();
                                }
                            }
                            #endregion
                        }
                    }
                }
                #endregion
            }
            else if (tmp_prod_result != null)
            {
                #region Production Result
                int sct_row_1 = tmp_prod_result.fgrid_result.Selection.r1;
                int sct_row_2 = tmp_prod_result.fgrid_result.Selection.r2;
                int sct_col = tmp_prod_result.fgrid_result.Selection.c1;

                for (int i = sct_row_1; i <= sct_row_2; i++)
                {                    
                    flg_mps_pop.Rows.Add();

                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDIVISION]    = "";
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY]     = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxFACTORY].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxMODEL]       = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxSTYLE_NAME].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCOLOR_VER]   = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxCOLOR_VER].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxBOM_STYLE]   = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxBOM_STYLE].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxSAMPLE_TYPE] = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxSAMPLE_TYPE].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUSER]        = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxCDC_DEV_NAME].ToString();
                    if(tmp_op.Equals("UPS"))
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME]     = "재봉";
                    else if (tmp_op.Equals("UPC"))
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME]     = "재단";
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO]      = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxLOT_NO].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ]     = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxLOT_SEQ].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ]     = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxDAY_SEQ].ToString();
                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD]     = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxLINE_CD].ToString();
                    if (tmp_op.Equals("UPS"))
                    {
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD] = "UP";
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD] = "UPS";
                    }
                    else if (tmp_op.Equals("UPC"))
                    {
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD] = "UP01";
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD] = "UPC"; 
                    }

                    flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUPS_USER]    = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPS_USER].ToString();
                    if (tmp_op.Equals("UPS"))
                    {
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS] = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxREMARKS].ToString();
                    }
                    else if (tmp_op.Equals("UPC"))
                    {
                        flg_mps_pop[flg_mps_pop.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS] = tmp_prod_result.fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPC_REMARKS].ToString(); 
                    }
                    
                }
                #endregion
            }
        }

        private DataTable GET_CMP_CD(int arg_row)
        {

            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_OP_CD";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = tmp_mps.flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = tmp_mps.flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
            MyOraDB.Parameter_Values[2] = "";


            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                flg_ups.Rows.Count = flg_ups.Rows.Fixed;

                //Display_Data();
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private void Display_Data()
        {
            DataTable dt_list = SELECT_UPS_USER_LIST();

            for (int i = 0; i < dt_list.Rows.Count; i++)
            {
                flg_ups.AddItem(dt_list.Rows[i].ItemArray);
            }
        }

        private DataTable SELECT_UPS_USER_LIST()
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE
            MyOraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_UPS_USER_POP";

            //02.ARGURMENT
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_NAME";
            MyOraDB.Parameter_Name[2] = "ARG_SABUN";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA
            MyOraDB.Parameter_Values[0] = tmp_factory;
            MyOraDB.Parameter_Values[1] = txt_name.Text.Trim();
            MyOraDB.Parameter_Values[2] = txt_sabun.Text.Trim();
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Grid Event
        private void flg_mps_pop_Click(object sender, EventArgs e)
        {
            int sct_row = flg_mps_pop.Selection.r1;

            Grid_click(sct_row);
        }
        private void Grid_click(int arg_row)
        {
            lbl_ets.Text      = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_NAME].ToString();

            txt_remarks.Text  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS].ToString();
            txt_ups_user.Text = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUPS_USER].ToString(); 
        }

        private void flg_ups_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = flg_ups.Selection.r1;

                string chk      = flg_ups[sct_row, 1].ToString();
                string ups_name = flg_ups[sct_row, 2].ToString().Trim();

                if (chk.Equals("True"))
                {
                    if (txt_ups_user.Text.Trim() == "")
                    {
                        txt_ups_user.Text = ups_name;
                    }
                    else
                    {
                        txt_ups_user.Text += ", ";
                        txt_ups_user.Text += ups_name;
                    }                    
                }
                else
                {
                     
                }

            }
            catch
            {
 
            }
        }
        #endregion

        #region Control Event
        private void txt_remarks_TextChanged(object sender, EventArgs e)
        {
            //flg_mps_pop[flg_mps_pop.Selection.r1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxREMARKS] = txt_remarks.Text;
        }

        private void txt_ups_user_TextChanged(object sender, EventArgs e)
        {
            //flg_mps_pop[flg_mps_pop.Selection.r1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxUPS_USER] = txt_ups_user.Text;
        }
        #endregion

        #region Save
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (tmp_mps != null)
                {
                    #region MPS 
                    string holiday = "N";
                    string confirm_date = tmp_mps.confirm_date;
                    string limit_date = tmp_mps.limit_date;
                    string select_date = dtp_date.Value.ToString("yyyyMMdd");

                    for (int i = flg_mps_pop.Rows.Fixed; i < flg_mps_pop.Rows.Count; i++)
                    {
                        if (tmp_level == "1")
                        {
                            holiday = Save_data_01(i);
                        }
                        else
                        {
                            holiday = Save_data_02(i);
                        }

                        if (holiday == "Y")
                        {
                            MessageBox.Show("This is Holiday");
                            return;
                        }
                        else
                        {
                            if (holiday == "Y")
                            {
                                MessageBox.Show("This is Holiday");
                                return;
                            }
                            Save_Setting(i);
                        }
                    }

                    save_flg = true;
                    if (tmp_level == "1")
                    {
                        save_flg = true;
                    }
                    #endregion

                }
                else if (tmp_prod_result != null)
                {

                    int sct_row = tmp_prod_result.fgrid_result.Selection.r1;
                    //Production Result 에서 띄울때
                    for (int i = flg_mps_pop.Rows.Fixed; i < flg_mps_pop.Rows.Count; i++)
                    {
                        if (tmp_op.Equals("UPS"))
                        {
                            Save_data_UPS(i);
                            tmp_prod_result.fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPS_USER] = txt_ups_user.Text;
                            tmp_prod_result.fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxREMARKS] = txt_remarks.Text;
                        }
                        else if (tmp_op.Equals("UPC"))
                        {
                            Save_data_UPS(i);
                            tmp_prod_result.fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPC_REMARKS] = txt_remarks.Text;
                        }
                    }
                    save_flg = true;
                }

                this.Close();
            }
            catch
            {
 
            }                
        }

        private void Save_Setting(int arg_row)
        {
            string lot_no     = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO].ToString();
            string lot_seq    = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ].ToString();
            string day_seq    = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ].ToString();
            string line_cd    = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD].ToString();
            string cmp_cd     = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD].ToString();
            string op_cd      = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD].ToString();
            string work_date  = dtp_date.Value.ToString("yyyyMMdd");
            string work_qty   = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxQTY].ToString();
            string remarks    = txt_remarks.Text;

            int cfm_date      = int.Parse(tmp_mps.confirm_date);
            int limit_date    = int.Parse( tmp_mps.limit_date);

            int[] sct_rows = tmp_mps.flg_sch.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                if (tmp_level == "1")
                {
                    if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                    {
                        string p_lot_no   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                        string p_lot_seq  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                        string p_day_seq  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                        string p_line_cd  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLINE_CD].ToString();
                        string p_cmp_cd   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                        string p_op_cd    = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
                        string p_old_date = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].ToString();
                        

                        if (lot_no == p_lot_no && lot_seq == p_lot_seq && day_seq == p_day_seq && line_cd == p_line_cd && cmp_cd == p_cmp_cd && op_cd == p_op_cd)
                        {
                            tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE] = work_date;
                            tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY]  = work_qty;
                            tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxREMARKS] = remarks;

                            for (int j = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1; j < tmp_mps.flg_sch.Cols.Count; j++)
                            {
                                string p_date = tmp_mps.flg_sch[tmp_mps.flg_sch.Rows.Fixed - 2, j].ToString() + tmp_mps.flg_sch[tmp_mps.flg_sch.Rows.Fixed - 1, j].ToString();


                                if (p_old_date == p_date)
                                {
                                    tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.White;
                                    tmp_mps.flg_sch[sct_rows[i], j] = "";

                                    if (int.Parse(p_old_date) <= limit_date)
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.Orange;
                                    }
                                    if (int.Parse(p_old_date) <= cfm_date)
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_confirm;
                                    }
                                }

                                if (p_date == work_date)
                                {
                                    string status = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString();
                                    string p_status = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS].ToString();

                                    if (status.Equals("C"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_confirm;
                                    }
                                    else if (status.Equals("Y") || status.Equals("U"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_nomal;
                                    }

                                    if (p_status.Equals("Y"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_ing;
                                    }
                                    else if (p_status.Equals("C"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_complete;
                                    }

                                    tmp_mps.flg_sch[sct_rows[i], j] = work_qty;
                                }
                            }
                        } 
                    }
                }
                else
                {
                    if (tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() != "99")
                    {
                        string p_lot_no   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                        string p_lot_seq  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                        string p_day_seq  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                        string p_line_cd  = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLINE_CD].ToString();
                        string p_cmp_cd   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                        string p_op_cd    = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
                        string p_old_date = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].ToString();

                        if (lot_no == p_lot_no && lot_seq == p_lot_seq && day_seq == p_day_seq && line_cd == p_line_cd && cmp_cd == p_cmp_cd && op_cd == p_op_cd)
                        {
                            tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE] = work_date;
                            tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY]  = work_qty;
                            tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxREMARKS]   = remarks;

                            for (int j = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1; j < tmp_mps.flg_sch.Cols.Count; j++)
                            {
                                string p_date = tmp_mps.flg_sch[tmp_mps.flg_sch.Rows.Fixed - 2, j].ToString() + tmp_mps.flg_sch[tmp_mps.flg_sch.Rows.Fixed - 1, j].ToString();


                                if (p_old_date == p_date)
                                {
                                    tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.WhiteSmoke;
                                    tmp_mps.flg_sch[sct_rows[i], j] = "";
                                    
                                    if (int.Parse(p_old_date) <= limit_date)
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = Color.Orange;
                                    }
                                    if (int.Parse(p_old_date) <= cfm_date)
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_confirm;
                                    }
                                }                          

                                if (p_date == work_date)
                                {
                                    string status   = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString();
                                    string p_status = tmp_mps.flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS].ToString();

                                    if(status.Equals("C"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_confirm;
                                    }
                                    else if (status.Equals("Y") || status.Equals("U"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_nomal;
                                    }

                                    if (p_status.Equals("Y"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_ing; 
                                    }
                                    else if (p_status.Equals("C"))
                                    {
                                        tmp_mps.flg_sch.GetCellRange(sct_rows[i], j).StyleNew.BackColor = tmp_mps.color_complete; 
                                    }

                                    tmp_mps.flg_sch[sct_rows[i], j] = work_qty; 
                                }
                            }
                        }
                    }
                } 
            }
        }

        private string Save_data_01(int arg_row)
        {
            MyOraDB.ReDim_Parameter(11);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_02.save_sxg_mps_lev_01";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "arg_factory"; 
            MyOraDB.Parameter_Name[1]  = "arg_lot_no";   
            MyOraDB.Parameter_Name[2]  = "arg_lot_seq";    
            MyOraDB.Parameter_Name[3]  = "arg_day_seq";     
            MyOraDB.Parameter_Name[4]  = "arg_line_cd";      
            MyOraDB.Parameter_Name[5]  = "arg_plan_ymd";     
            MyOraDB.Parameter_Name[6]  = "arg_plan_qty";     
            MyOraDB.Parameter_Name[7]  = "arg_cdc_work_name";
            MyOraDB.Parameter_Name[8]  = "arg_remarks";      
            MyOraDB.Parameter_Name[9]  = "arg_upd_user";
            MyOraDB.Parameter_Name[10] = "out_cursor";      
           
            //03. DATA TYPE 정의
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
            MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;           
            
            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[2] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[3] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD].ToString(); 
            MyOraDB.Parameter_Values[5] = dtp_date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[6] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxQTY].ToString(); 
            MyOraDB.Parameter_Values[7] = txt_ups_user.Text;
            MyOraDB.Parameter_Values[8] = txt_remarks.Text;
            MyOraDB.Parameter_Values[9] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[10] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }

        private string Save_data_02(int arg_row)
        {
            MyOraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_02.save_sxg_mps_lev_02";
        
            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "arg_division";
            MyOraDB.Parameter_Name[1]  = "arg_factory"; 
            MyOraDB.Parameter_Name[2]  = "arg_lot_no";  
            MyOraDB.Parameter_Name[3]  = "arg_lot_seq"; 
            MyOraDB.Parameter_Name[4]  = "arg_day_seq"; 
            MyOraDB.Parameter_Name[5]  = "arg_line_cd"; 
            MyOraDB.Parameter_Name[6]  = "arg_cmp_cd";  
            MyOraDB.Parameter_Name[7]  = "arg_op_cd";   
            MyOraDB.Parameter_Name[8]  = "arg_dir_ymd"; 
            MyOraDB.Parameter_Name[9]  = "arg_dir_qty"; 
            MyOraDB.Parameter_Name[10] = "arg_remarks"; 
            MyOraDB.Parameter_Name[11] = "arg_upd_user";
            MyOraDB.Parameter_Name[12] = "out_cursor";  

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0]  = "U";
            MyOraDB.Parameter_Values[1]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[2]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[3]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[4]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[5]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD].ToString();
            MyOraDB.Parameter_Values[6]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD].ToString();
            MyOraDB.Parameter_Values[7]  = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD].ToString();
            MyOraDB.Parameter_Values[8]  = dtp_date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[9]  = txt_qty.Text;
            MyOraDB.Parameter_Values[10] = txt_remarks.Text;
            MyOraDB.Parameter_Values[11] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[12] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }

        private void Save_data_UPS(int arg_row)
        {
            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_prod_01.save_sxg_prod_ups";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_lot_no";
            MyOraDB.Parameter_Name[2] = "arg_lot_seq";
            MyOraDB.Parameter_Name[3] = "arg_day_seq";
            MyOraDB.Parameter_Name[4] = "arg_line_cd";
            MyOraDB.Parameter_Name[5] = "arg_cmp_cd";
            MyOraDB.Parameter_Name[6] = "arg_op_cd";
            MyOraDB.Parameter_Name[7] = "arg_ups_user";
            MyOraDB.Parameter_Name[8] = "arg_remarks";            

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;           

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[2] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[3] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxLINE_CD].ToString();
            MyOraDB.Parameter_Values[5] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxCMP_CD].ToString();
            MyOraDB.Parameter_Values[6] = flg_mps_pop[arg_row, (int)ClassLib.TBSXG_MPS_POP_VJ.IxOP_CD].ToString();
            if (tmp_op.Equals("UPS"))
            {
                MyOraDB.Parameter_Values[7] = txt_ups_user.Text;
            }
            else if (tmp_op.Equals("UPC"))
            {
                MyOraDB.Parameter_Values[7] = ""; 
            }
            MyOraDB.Parameter_Values[8] = txt_remarks.Text;
                
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
            
        }
        #endregion

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                flg_mps_pop[flg_mps_pop.Selection.r1, (int)ClassLib.TBSXG_MPS_POP_VJ.IxQTY] = txt_qty.Text.Trim();
            }
            catch
            {
 
            }
        }
                       
    }
}

