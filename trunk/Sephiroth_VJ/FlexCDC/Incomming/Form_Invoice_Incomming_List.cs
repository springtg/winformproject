using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Windows.Forms;

namespace FlexCDC.Incomming
{
    public partial class Form_Invoice_Incomming_List : COM.PCHWinForm.Pop_Large_B
    {

        #region 컨트롤 정의 및 리소스 정의
        public Form_Invoice_Incomming_List()
        {
            InitializeComponent();
        }

        public Form_Invoice_Incomming_List(Incomming.Form_Incomming_Manager arg_request1)
        {
            InitializeComponent();
            arg_request = arg_request1;
        }
        #endregion

        #region 사용자 정의 변수
        public Incomming.Form_Incomming_Manager arg_request = null;
        private COM.OraDB MyOraDB = new COM.OraDB();
        private bool first_flag = true;
        private bool _New_flag = true;
        DataTable dt_list;
        #endregion

        #region 공통메서드
        private void Init_Form()
        {
            this.Text = "PCC_Invoice Incomming List";
            this.lbl_MainTitle.Text = "PCC_Invoice Incomming List";
            ClassLib.ComFunction.SetLangDic(this);

            #region Button Setting
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled = false;
            #endregion

            #region ComboBox Setting
            first_flag = true;
            dtp_Std_Ymd.Value = DateTime.Today;
            dtp_Fin_Ymd.Value = DateTime.Today;

            //Ship No Setting 
            dt_list = Select_Sxs_Ship_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_shipno, true, 0, 0, 0, 160);
            cmb_shipno.SelectedIndex = 0;

            dt_list.Dispose();
            first_flag = false;
            #endregion

            #region Grid Setting
            fgrid_Main.Set_Grid_CDC("SXI_IN_LIST_INV", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Font = new Font("Verdana", 8);
            fgrid_Main.Tree.Column = (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM01;
            #endregion

            #region TextBox Setting
            txt_packing.CharacterCasing = CharacterCasing.Upper;
            txt_MatName.CharacterCasing = CharacterCasing.Upper;
            txt_packing.Focus();
            #endregion

            //Display_Grid();
        }
        private void Display_Grid()
        {
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            DataTable dt_list = Select_Sxs_Ship_List();
            for (int i = 0; i < dt_list.Rows.Count; i++)
            {

                int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString());
                fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, tree_level);

                #region Level에 따른 Edit & BackColor 설정
                if (tree_level == 1)
                {
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                }
                else if (tree_level == 2)
                {
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                }
                #endregion

                for (int j = 0; j < dt_list.Columns.Count; j++)
                {
                    fgrid_Main[fgrid_Main.Rows.Count - 1, j] = dt_list.Rows[i].ItemArray[j].ToString();
                }

            }

            fgrid_Main.Tree.Show(1);
 
        }

        private void Save_Data()
        {
            arg_request.fgrid_Main.Tree.Show(2);

            #region 중복체크
            int row_count = fgrid_Main.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString() == "True")
                {

                    if (Grid_Add_Check(i) == false)
                    {
                        if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString() == "1")
                            ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDuplication, this);

                        fgrid_Main.Rows.Remove(i);

                        i--;
                        row_count--;
                    }

                }
            }
            #endregion

            #region Purchase List Grid Data --> Incomming Manager Grid
            row_count = fgrid_Main.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString() == "True")
                {
                    if (arg_request != null)
                    {
                        arg_request.tbtn_Save.Enabled = true;

                        Grid_List_Add(i);

                        fgrid_Main.Rows.Remove(i);

                        i--;
                        row_count--;
                    }
                }
            }
            #endregion

            arg_request.fgrid_Main.Tree.Show(1);

        }
        private bool Grid_Add_Check(int arg_rowcount) //중복검사
        {
            #region Grid Data--> 변수
            string buf_LEVEL = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString();
            string buf_BAR_CODE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString();

            #endregion

            #region 중복검사
            for (int i = arg_request.fgrid_Main.Rows.Fixed; i < arg_request.fgrid_Main.Rows.Count - 1; i++)
            {
                if (arg_request.fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() == buf_LEVEL &&
                   arg_request.fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE].ToString() == buf_BAR_CODE)
                {
                    return false;
                }
            }
            #endregion

            return true;
        }
        private void Grid_List_Add(int arg_rowcount)
        {
            if (fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString() == "1")
            {
                #region Grid Data --> 변수
                //string buf_STATUS		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxSTATUS].ToString();   	      
                string buf_Y_FLG  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString();
                string buf_LEVEL  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString();
                string buf_PUR_NO  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_NO].ToString();
                string buf_PUR_SEQ = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_SEQ].ToString();
                string buf_PUR_DIV = "";// fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_DIV].ToString();
                string buf_ITEM01 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM01].ToString();
                string buf_ITEM02 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM02].ToString();
                string buf_ITEM03 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM03].ToString();
                string buf_ITEM04 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM04].ToString();
                string buf_VALUE_PUR = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxVALUE_PUR].ToString();
                string buf_VALUE_IN = "0";
                string buf_VALUE_ADV_IN = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxVALUE_ADV_IN].ToString();
                string buf_PUR_CURRENCY = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_CURRENCY].ToString();
                string buf_PUR_PRICE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_PRICE].ToString();
                string buf_CBD_CURRENCY = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxCBD_CURRENCY].ToString();
                string buf_CBD_PRICE   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxCBD_PRICE].ToString();
                string buf_BAR_CODE    = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString();
                string buf_MRP_REQ_FLG = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxMRP_REQ_FLG].ToString();
                string buf_TRANSPORT_TYPE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxTRANSPORT_TYPE].ToString();
                string buf_VENDOR = "";
                string buf_REMARKS = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxREMARKS].ToString();
                string buf_UPD_USER = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxUPD_USER].ToString();
                #endregion

                arg_request.fgrid_Main.Rows.InsertNode(arg_request.fgrid_Main.Rows.Count, Convert.ToInt32(buf_LEVEL));
                int inst_row = arg_request.fgrid_Main.Rows.Count - 1;

                arg_request.fgrid_Main.Rows[arg_request.fgrid_Main.Rows.Count - 1].AllowEditing = true;
                arg_request.fgrid_Main.Rows[arg_request.fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                arg_request._Update_Flag = false;

                #region 변수 --> Incomming Manager FlexGrid
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION] = "I";
                //arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxSTATUS]         = buf_STATUS ;        
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxY_FLG] = buf_Y_FLG;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL] = buf_LEVEL;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_SEQ] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_DIV] = "03";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_YMD] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM01] = buf_ITEM01;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM02] = buf_ITEM02;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM03] = buf_ITEM03;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM04] = buf_ITEM04;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PUR] = buf_VALUE_PUR;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PREV_IN] = buf_VALUE_IN;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN] = buf_VALUE_ADV_IN;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBL_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxINV_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_YMD] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_CURRENCY] = buf_PUR_CURRENCY;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_PRICE] = buf_PUR_PRICE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_CURRENCY] = buf_CBD_CURRENCY;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_PRICE] = buf_CBD_PRICE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_NO] = buf_PUR_NO;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_SEQ] = buf_PUR_SEQ;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE] = buf_BAR_CODE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_DIV] = buf_PUR_DIV;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxMRP_REQ_FLG] = buf_MRP_REQ_FLG;
                //arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPRICE_YN] = buf_PRICE_YN;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxTRANSPORT_TYPE] = buf_TRANSPORT_TYPE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVENDOR] = buf_VENDOR;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS] = buf_REMARKS;
                #endregion
            }
            else
            {
                #region Grid Data --> 변수
                //string buf_STATUS		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxSTATUS].ToString();   	      
                string buf_Y_FLG = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString();
                string buf_LEVEL = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString();
                string buf_PUR_NO = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_NO].ToString();
                string buf_PUR_SEQ = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_SEQ].ToString();
                string buf_PUR_DIV = ""; //fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_DIV].ToString();
                string buf_ITEM01 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM01].ToString();
                string buf_ITEM02 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM02].ToString();
                string buf_ITEM03 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM03].ToString();
                string buf_ITEM04 = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxITEM04].ToString();
                string buf_VALUE_PUR = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxVALUE_PUR].ToString();
                string buf_VALUE_IN = "0";// fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxVALUE_IN].ToString();
                string buf_VALUE_ADV_IN = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxVALUE_ADV_IN].ToString();
                string buf_PUR_CURRENCY = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_CURRENCY].ToString();
                string buf_PUR_PRICE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPUR_PRICE].ToString();
                string buf_CBD_CURRENCY = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxCBD_CURRENCY].ToString();
                string buf_CBD_PRICE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxCBD_PRICE].ToString();
                string buf_BAR_CODE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString();
                string buf_MRP_REQ_FLG = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxMRP_REQ_FLG].ToString();
                //string buf_PRICE_YN = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxPRICE_YN].ToString();
                string buf_TRANSPORT_TYPE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxTRANSPORT_TYPE].ToString();
                string buf_VENDOR = "";// fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxVENDOR_DESC].ToString();
                string buf_REMARKS = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxREMARKS].ToString();
                string buf_UPD_USER = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_INV.IxUPD_USER].ToString();
                #endregion

                arg_request.fgrid_Main.Rows.InsertNode(arg_request.fgrid_Main.Rows.Count, Convert.ToInt32(buf_LEVEL));
                int inst_row = arg_request.fgrid_Main.Rows.Count - 1;

                arg_request.fgrid_Main.Rows[arg_request.fgrid_Main.Rows.Count - 1].AllowEditing = false;
                arg_request.fgrid_Main.Rows[arg_request.fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                arg_request._Update_Flag = false;

                #region 변수 --> Incomming Manager FlexGrid
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION] = "I";
                //arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxSTATUS]         = buf_STATUS ;        
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxY_FLG] = buf_Y_FLG;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL] = buf_LEVEL;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_SEQ] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_DIV] = "03";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_YMD] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM01] = buf_ITEM01;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM02] = buf_ITEM02;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM03] = buf_ITEM03;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM04] = buf_ITEM04;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PUR] = buf_VALUE_PUR;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PREV_IN] = buf_VALUE_IN;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN] = buf_VALUE_ADV_IN;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBL_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxINV_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_NO] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_YMD] = "";
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_CURRENCY] = buf_PUR_CURRENCY;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_PRICE] = buf_PUR_PRICE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_CURRENCY] = buf_CBD_CURRENCY;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_PRICE] = buf_CBD_PRICE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_NO] = buf_PUR_NO;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_SEQ] = buf_PUR_SEQ;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE] = buf_BAR_CODE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_DIV] = buf_PUR_DIV;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxMRP_REQ_FLG] = buf_MRP_REQ_FLG;
                //arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPRICE_YN] = buf_PRICE_YN;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxTRANSPORT_TYPE] = buf_TRANSPORT_TYPE;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVENDOR] = buf_VENDOR;
                arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS] = buf_REMARKS;

                arg_request.fgrid_Main.Rows[inst_row].AllowEditing = false;
                #endregion
            }
        }
        #endregion

        #region 이벤트 처리

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1)
                    return;

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
        private void dtp_Std_Ymd_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flag)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Fin_Ymd.Value = dtp_Std_Ymd.Value;
                }

                //Ship No Setting 
                dt_list = Select_Sxs_Ship_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_shipno, true, 0, 0, 0, 160);
                cmb_shipno.SelectedIndex = 0;

                dt_list.Dispose();


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

        private void dtp_Fin_Ymd_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flag)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Std_Ymd.Value = dtp_Fin_Ymd.Value;
                }

                //Ship No Setting 
                dt_list = Select_Sxs_Ship_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_shipno, true, 0, 0, 0, 160);
                cmb_shipno.SelectedIndex = 0;

                dt_list.Dispose();
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

        private void cmb_shipno_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_shipno.SelectedIndex == -1)
                    return;               
                    
                //Invoice Setting 
                DataTable dt_ret = Select_Sxs_Ship_Inv(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_Combo(cmb_shipno, ""));
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_invoice, true, 0, 0, 0, 160);
                cmb_invoice.SelectedIndex = 0;

                dt_ret.Dispose();
                
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
        private void fgrid_Main_BeforeEdit(object sender, RowColEventArgs e)
        {
            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                if (fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
                {
                    fgrid_Main.Buffer_CellData = "";
                }
                else
                {
                    fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
                }
            }		
        }

        private void fgrid_Main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                
                if (fgrid_Main.Selection.r1 == 0) return;


                #region Flag CheckBox 설정
                int[] selectRow = fgrid_Main.Selections;

                for (int i = 0; i < fgrid_Main.Selections.Length; i++)
                {
                    for (int j = selectRow[i]; j < fgrid_Main.Rows.Count; j++)
                    {
                        if (fgrid_Main[selectRow[i], (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString())
                            break;
                        if (fgrid_Main[selectRow[i], (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString() == "True")
                        {
                            fgrid_Main.Update_Row(j);
                            fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG] = "True";
                        }
                        else
                        {
                            fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG] = "False";
                            fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxDIVISION] = "";

                        }

                    }

                }
                #endregion
            }
            catch
            {

            }
        }

        private void fgrid_Main_Click(object sender, EventArgs e)
        {
            //try
            //{						

            //    if(fgrid_Main.Selection.r1 == 0) return;

            //    #region Flag CheckBox 설정
            //    int[] selectRow = fgrid_Main.Selections;

            //    for (int i = 0; i < fgrid_Main.Selections.Length; i++)
            //    {                    
            //        for (int j = selectRow[i]; j < fgrid_Main.Rows.Count; j++)
            //        {
            //            if (fgrid_Main[selectRow[i], (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString())
            //                break;
            //            if (fgrid_Main[selectRow[i], (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString() == "True")
            //            {
            //                fgrid_Main.Update_Row(j);
            //                fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG] = "True";
            //            }
            //            else
            //            {
            //                fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG] = "False";
            //                fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxDIVISION] = "";

            //            }
                        
            //        }                    
                        
            //    }
            //    #endregion
            //}
            //catch
            //{

            //}
        }
        private void fgrid_Main_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Space)
                {

                    if (fgrid_Main.Selection.r1 == 0) return;

                    #region Flag CheckBox 설정
                    for (int i = fgrid_Main.Selection.r1; i <= fgrid_Main.Selection.r2; i++)
                    {
                        if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG].ToString() == "True")
                        {

                            if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString() == "1")
                            {
                                fgrid_Main.Update_Row(i);
                                for (int j = i + 1; j < fgrid_Main.Rows.Count; j++)
                                {
                                    if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString())
                                        break;

                                    fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG] = "True";
                                    fgrid_Main.Update_Row(j);
                                }
                            }
                        }
                        else
                        {

                            if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxLEVEL].ToString() == "1")
                            {
                                fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxDIVISION] = "";

                                for (int j = i + 1; j < fgrid_Main.Rows.Count; j++)
                                {
                                    if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxBAR_CODE].ToString())
                                        break;

                                    fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxY_FLG] = "False";
                                    fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_INV.IxDIVISION] = "";
                                }
                            }

                        }
                    }
                    #endregion

                }
            }
            catch
            {

            }
        }
        #endregion

        #region Button Event
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (_New_flag)
            {
                fgrid_Main.Tree.Show(2);
                _New_flag = false;
            }
            else
            {
                fgrid_Main.Tree.Show(1);
                _New_flag = true;
            }
        }
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
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
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (fgrid_Main.Rows.Count == fgrid_Main.Rows.Fixed)
                    return;

                fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);
                Save_Data();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                COM.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region ContextMenu Event
        private void mnu_mat_Click(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(1);
        }

        private void mnu_bom_Click(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(2);
        }
        #endregion

        #endregion

        #region DB Connect
        private DataTable Select_Sxs_Ship_No(string arg_factory, string arg_std_ymd, string arg_fin_ymd)
        {

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXS_SHIP_NO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_Sxs_Ship_Inv(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_ship_no)
        {

            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXS_SHIP_INVOICE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = arg_ship_no;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_Sxs_Ship_List()
        {

            MyOraDB.ReDim_Parameter(8);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXS_SHIP_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[4] = "ARG_INVOICE_NO";
            MyOraDB.Parameter_Name[5] = "ARG_PACKING";
            MyOraDB.Parameter_Name[6] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dtp_Std_Ymd.Text;
            MyOraDB.Parameter_Values[2] = dtp_Fin_Ymd.Text;
            MyOraDB.Parameter_Values[3] = cmb_shipno.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_invoice.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = txt_packing.Text; ;
            MyOraDB.Parameter_Values[6] = txt_MatName.Text;
            MyOraDB.Parameter_Values[7] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        private void Form_Invoice_Incomming_List_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //factory 
                DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
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
        
    }
}

