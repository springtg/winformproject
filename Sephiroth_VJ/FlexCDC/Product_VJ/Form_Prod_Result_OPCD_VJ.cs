using System;
using C1.Win.C1FlexGrid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;

namespace FlexCDC.Product_VJ
{
    public partial class Form_Prod_Result_OPCD_VJ : COM.PCHWinForm.Form_Top
    {
        #region Resource
        public Form_Prod_Result_OPCD_VJ()
        {
            InitializeComponent();
        }

        public Form_Prod_Result_OPCD_VJ(string arg_div, string arg_facotry, string arg_category, string arg_season, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_round, string arg_user, string arg_op_cd, string arg_date, string arg_sort)
        {
            InitializeComponent();

            tmp_div      = arg_div;
            tmp_factory  = arg_facotry;
            tmp_category = arg_category;
            tmp_season   = arg_season;
            tmp_sr_no    = arg_sr_no;
            tmp_srf_no   = arg_srf_no;
            tmp_bom_id   = arg_bom_id;
            tmp_round    = arg_round;
            tmp_user     = arg_user;
            tmp_op_cd    = arg_op_cd;
            tmp_date     = arg_date;
            tmp_sort     = arg_sort;
        }
        #endregion

        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService function
        private bool flg_resize = true;
        private DateTime date_now = DateTime.Now;
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
        
        //XML
        private DataSet ds_xml;
        private string op_setting  = "";
        private string rst_setting = "";

        //MPS
        private string tmp_div      = "";
        private string tmp_factory  = "";
        private string tmp_category = "";
        private string tmp_season   = "";
        private string tmp_sr_no    = "";
        private string tmp_srf_no   = "";
        private string tmp_bom_id   = "";
        private string tmp_round    = "";
        private string tmp_user     = "";
        private string tmp_op_cd    = "";
        private string tmp_date     = "";
        private string tmp_sort     = "";

        //user power
        private string power_level = "";
        
        private int op_col;        
        private int old_col;
        private string bar_code_scan = "";        
        private string[,] rst_yn = new string[11, 5];       
        #endregion

        #region Form Loading
        private void Form_Prod_Result_OPCD_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_factory = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_factory, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {
            }
        }
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cmb_factory.SelectedIndex == -1)
                    return;


                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_form();

                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Init_form()
        {            
            //1. Title Setting
            this.Text = "PCC_Production Result by Operation";
            this.lbl_MainTitle.Text = "PCC_Production Result by Operation";
            ClassLib.ComFunction.SetLangDic(this);

            //2. XML Read
            Read_XML();

            #region 3. tbtn Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
            #endregion

            #region 4. Grid Setting
            fgrid_result.Set_Grid_CDC("SXG_PROD_WS_RESULT_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_result.Set_Action_Image(img_Action);
            fgrid_result.Rows.Count = fgrid_result.Rows.Fixed;
            fgrid_result.ExtendLastCol = false; 
            fgrid_result.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxBOM_STYLE, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxBOM_STYLE).StyleNew.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN).StyleNew.BackColor = Color.LightPink;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN).StyleNew.ForeColor = Color.Black;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN, fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN).StyleNew.BackColor = Color.LightPink;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN, fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN).StyleNew.ForeColor = Color.Black;
            
            
            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxCATEGORY].Visible  = false;
            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSEASON_CD].Visible = false;
            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxGEN_SIZE].Visible  = false;
            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIPW_YMD].Visible   = false;
            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].Visible  = false;

            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_DIR).StyleNew.TextAlign =  C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_DIR).StyleNew.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR).StyleNew.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR).StyleNew.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN, fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN).StyleNew.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;           
            #endregion

            //5.ComboBox Setting
            Control_Setting();

            //6. Color Infomation
            lbl_normal.BackColor   = Color.White;
            lbl_ing.BackColor      = Color.Yellow;
            lbl_complete.BackColor = Color.Aqua;
            lbl_close.BackColor    = Color.DarkGray;

            timer_01.Enabled = false;

            Grid_Style_Setting();

            //8. RadioButton Setting
            if (!op_setting.Equals("workshop"))
            {
                RadioButton_Change(op_setting);
                fgrid_result.ContextMenuStrip = null;
            }
        }
        
        private void Grid_Style_Setting()
        {
            #region Power Level
            try
            {
                power_level = ClassLib.ComVar.This_CDCPower_Level.ToString();

                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK].Visible = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].Visible = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].Visible = false;

                if (op_setting.Equals("workshop"))
                {
                    if (power_level.Substring(0, 1) == "W" || power_level == "S00")
                    {
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].AllowEditing = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].AllowEditing    = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].AllowEditing     = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].AllowEditing = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].AllowEditing = true;

                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER,    fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS,     fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);


                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD).StyleNew.BackColor = Color.FromArgb(-3181363);

                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD).StyleNew.BackColor = Color.FromArgb(-3181363);


                    }
                    if (power_level == "P00" || power_level == "S00")
                    {
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD).StyleNew.BackColor = Color.FromArgb(-3181363);

                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD).StyleNew.BackColor = Color.FromArgb(-3181363);

                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK).StyleNew.BackColor = Color.FromArgb(-3181363);                                                                        
                    }
                }
                else
                {
                    if (power_level == "E02")
                    {
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD].Visible = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD].Visible = false;

                        if (op_setting.Equals("UPS"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].AllowEditing = true;
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].AllowEditing = true;

                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER).StyleNew.BackColor = Color.FromArgb(-3181363);
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                        if (op_setting.Equals("UPE"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].AllowEditing = true;
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                        if (op_setting.Equals("UPC"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].AllowEditing = true;
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                        if (op_setting.Equals("FGA") && rst_setting.Equals("P"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].AllowEditing = true;
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                    }
                }
            }
            catch
            {
                power_level = "";
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].AllowEditing    = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].AllowEditing     = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].AllowEditing = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].AllowEditing = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].AllowEditing     = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].AllowEditing      = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK].AllowEditing   = false;
            }
            #endregion
        }

        private void Grid_StyleSetting()
        {
            #region Power Level
            try
            {
                power_level = ClassLib.ComVar.This_CDCPower_Level.ToString();

                if (op_setting.Equals("workshop"))
                {
                    if (power_level.Substring(0, 1) == "W" || power_level == "S00")
                    {
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].AllowEditing = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].AllowEditing    = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].AllowEditing     = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].AllowEditing = true;
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].AllowEditing = true;

                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER,    fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS,     fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);                                                                        
                    }
                    if (power_level == "P00" || power_level == "S00")
                    {
                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD).StyleNew.BackColor = Color.FromArgb(-3181363);

                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD).StyleNew.BackColor = Color.FromArgb(-3181363);

                        fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK].AllowEditing = true;
                        fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK).StyleNew.BackColor = Color.FromArgb(-3181363);                                                                        
                    }
                }
                else
                {
                    if (power_level == "E02")
                    {
                        if (op_setting.Equals("UPS"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].AllowEditing = true;
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].AllowEditing = true;

                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER).StyleNew.BackColor = Color.FromArgb(-3181363);
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                        if (op_setting.Equals("UPE"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].AllowEditing = true;
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                        if (op_setting.Equals("UPC"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].AllowEditing = true;
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                        if (op_setting.Equals("FGA") && rst_setting.Equals("P"))
                        {
                            fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].AllowEditing = true;
                            fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS, fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS).StyleNew.BackColor = Color.FromArgb(-3181363);
                        }
                    }
                }
            }
            catch
            {
                power_level = "";
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].AllowEditing    = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].AllowEditing     = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].AllowEditing = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].AllowEditing = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].AllowEditing     = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].AllowEditing      = false;
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK].AllowEditing   = false;
            }
            #endregion
        }

        private void Read_XML()
        {
            try
            {
                ds_xml = new DataSet("New DataSet");
                
                string file_path = @"C:\op_setting.xml";

                FileInfo fi = new FileInfo(file_path);
                if (!fi.Exists)
                {
                    op_setting = "workshop";
                    rst_setting = "";
                }
                else
                {
                    // ÆÄÀÏÀ» ÀÐ¾î ½ºÆ®¸²À¸·Î ¸¸µé±â
                    System.IO.FileStream fsReadXml = new System.IO.FileStream(file_path, System.IO.FileMode.Open);

                    // Create an XmlTextReader to read the file. //
                    System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

                    // Read the XML document into the DataSet. //
                    ds_xml.ReadXml(myXmlReader);

                    // Close the XmlTextReader //
                    myXmlReader.Close();

                    op_setting  = ds_xml.Tables[0].Rows[0].ItemArray[0].ToString();
                    rst_setting = ds_xml.Tables[0].Rows[0].ItemArray[1].ToString();
                }

                string op_rst = (op_setting.Equals("workshop")) ? "" : op_setting;
                DataTable dt_rst_yn = Get_rst_yn(op_rst);

                for (int i = 0; i < dt_rst_yn.Rows.Count; i++)
                {
                    for (int j = 0; j < dt_rst_yn.Columns.Count; j++)
                    {
                        rst_yn[i, j] = dt_rst_yn.Rows[i].ItemArray[j].ToString();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please ask System Department");
            }

        }
        private void Control_Setting()
        {
            if (!tmp_div.Equals("MPS"))
            {
                #region MPS­ Loading
                //Category
                DataTable dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
                cmb_category.SelectedIndex = 0;

                //Season
                dt_ret = Select_season();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
                cmb_season.SelectedIndex = 0;

                //Round
                dt_ret = Select_round();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 170);
                cmb_round.SelectedIndex = 0;

                //op cd
                dt_ret = Select_op_cd();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_opcd, 0, 1, false, 0, 120);
                                

                //Dev User
                dt_ret = Select_user();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 120);
                cmb_user.SelectedIndex = 0;

                //Sort
                dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_OutSch_Order_type);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sort, 1, 2, false, 0, 120);
                cmb_sort.SelectedIndex = 1;

                //³¯Â¥ Setting 
                dtp_from.Value = DateTime.Now.AddDays(-10);
                dtp_to.Value = DateTime.Now.AddDays(20);

                if (op_setting.Equals("workshop"))
                {                    
                    cmb_factory.Enabled  = true;
                    cmb_category.Enabled = true;
                    cmb_season.Enabled   = true;
                    cmb_round.Enabled    = true;
                    cmb_user.Enabled     = true;
                    cmb_sort.Enabled     = true;
                    
                    cmb_opcd.SelectedIndex = 0;
                    cmb_opcd.Enabled     = true;

                    txt_bom_id.Enabled   = true;
                    txt_sr_no.Enabled    = true;
                    txt_srf_no.Enabled   = true;
                    txt_stlye_cd.Enabled = true;                    
                }
                else
                {
                    cmb_factory.Enabled  = false;
                    cmb_category.Enabled = false;
                    cmb_season.Enabled   = false;
                    cmb_round.Enabled    = false;
                    cmb_user.Enabled     = false;
                    cmb_sort.Enabled     = false;

                    cmb_opcd.SelectedValue = op_setting;
                    cmb_opcd.Enabled     = false;
                    
                    //txt_bom_id.Enabled   = false;
                    txt_sr_no.Enabled    = false;
                    txt_srf_no.Enabled   = false;
                    //txt_stlye_cd.Enabled = false;

                    //dtp_from.Enabled     = false;
                    //dtp_to.Enabled       = false;

                    //txt_bom_id.BackColor   = SystemColors.Control;
                    txt_sr_no.BackColor    = SystemColors.Control;
                    txt_srf_no.BackColor   = SystemColors.Control;
                    //txt_stlye_cd.BackColor = SystemColors.Control;

                    chk_refresh.Checked = true;

                    tbtn_Search_Click(null, null);

                }
                dt_ret.Dispose();
                #endregion
            }
            else
            {
                #region Loading½Ã
                //Category
                DataTable dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
                cmb_category.SelectedValue = tmp_category;

                //Season
                dt_ret = Select_season();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
                cmb_season.SelectedValue = tmp_season;

                //Round
                dt_ret = Select_round();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 120);
                cmb_round.SelectedValue = tmp_round;

                //op cd
                dt_ret = Select_op_cd();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_opcd, 0, 1, false, 0, 120);                
                cmb_opcd.SelectedValue = tmp_op_cd;

                if (op_setting.Equals("workshop"))
                {
                    cmb_opcd.Enabled = true;
                }
                else
                {
                    cmb_opcd.SelectedValue = op_setting;
                    cmb_opcd.Enabled = false;
                }

                //Dev User
                dt_ret = Select_user();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 120);
                cmb_user.SelectedValue = tmp_user;

                //Sort
                dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_OutSch_Order_type);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sort, 1, 2, false, 0, 120);
                cmb_sort.SelectedValue = tmp_sort;

                //³¯Â¥ Setting              
                DateTime date  = new DateTime(int.Parse(tmp_date.Substring(0, 4)), int.Parse(tmp_date.Substring(4, 2)), int.Parse(tmp_date.Substring(6, 2)));
                dtp_from.Value = date;
                dtp_to.Value   = date;

                if (op_setting.Equals("workshop"))
                {                    
                    cmb_factory.Enabled  = true;
                    cmb_category.Enabled = true;
                    cmb_season.Enabled   = true;
                    cmb_round.Enabled    = true;
                    cmb_user.Enabled     = true;
                    cmb_sort.Enabled     = true;
                    
                    cmb_opcd.Enabled     = true;

                    txt_bom_id.Enabled   = true;
                    txt_sr_no.Enabled    = true;
                    txt_srf_no.Enabled   = true;
                    txt_stlye_cd.Enabled = true;                    
                }
                else
                {
                    cmb_factory.Enabled  = false;
                    cmb_category.Enabled = false;
                    cmb_season.Enabled   = false;
                    cmb_round.Enabled    = false;
                    cmb_user.Enabled     = false;
                    cmb_sort.Enabled     = false;

                    cmb_opcd.Enabled     = false;
                    
                    txt_sr_no.Enabled    = false;
                    txt_srf_no.Enabled   = false;
                    
                    txt_sr_no.BackColor    = SystemColors.Control;
                    txt_srf_no.BackColor   = SystemColors.Control;                    

                    chk_refresh.Checked = true;
                }

                dt_ret.Dispose();

                tbtn_Search_Click(null, null);
                #endregion
            }
        }
        private void RadioButton_Change(string arg_op_cd)
        {
            string rst_i = "";
            string rst_t = "";
            string rst_p = "";
            string rst_o = "";

            if (op_setting.Equals("workshop"))
            {
                #region Operation Setting
                for (int i = 0; i < 11; i++)
                {
                    string op_yn = rst_yn[i, 0];
                    if (arg_op_cd.Equals(op_yn))
                    {
                        rst_i = rst_yn[i, 1];
                        rst_t = rst_yn[i, 2];
                        rst_p = rst_yn[i, 3];
                        rst_o = rst_yn[i, 4];

                        if (rst_o.Equals("Y"))
                        {
                            rdbtn_o.Enabled = true;
                            rdbtn_o.Checked = true;
                            rdbtn_o_CheckedChanged(null, null);
                        }
                        else
                        {
                            rdbtn_o.Enabled = false;
                            rdbtn_o.Checked = false;
                            rdbtn_o.BackColor = Color.Gray;
                        }
                        if (rst_p.Equals("Y"))
                        {
                            rdbtn_p.Enabled = true;
                            rdbtn_p.Checked = true;
                            rdbtn_p_CheckedChanged(null, null);
                        }
                        else
                        {
                            rdbtn_p.Enabled = false;
                            rdbtn_p.Checked = false;
                            rdbtn_p.BackColor = Color.Gray;
                        }
                        if (rst_t.Equals("Y"))
                        {
                            rdbtn_t.Enabled = true;
                            rdbtn_t.Checked = true;
                            rdbtn_t_CheckedChanged(null, null);
                        }
                        else
                        {
                            rdbtn_t.Enabled = false;
                            rdbtn_t.Checked = false;
                            rdbtn_t.BackColor = Color.Gray;
                        }
                        if (rst_i.Equals("Y"))
                        {
                            rdbtn_i.Enabled = true;
                            rdbtn_i.Checked = true;
                            rdbtn_i_CheckedChanged(null, null);
                        }
                        else
                        {
                            rdbtn_i.Enabled = false;
                            rdbtn_i.Checked = false;
                            rdbtn_i.BackColor = Color.Gray;
                        }

                        break;
                    }
                }
                #endregion
            }
            else
            {
                #region User
                rst_i = rst_yn[0, 1];
                rst_t = rst_yn[0, 2];
                rst_p = rst_yn[0, 3];
                rst_o = rst_yn[0, 4];

                if (rst_o.Equals("Y"))
                {
                    rdbtn_o.Enabled = true;
                    rdbtn_o.Checked = true;
                    rdbtn_o_CheckedChanged(null, null);
                }
                else
                {
                    rdbtn_o.Enabled = false;
                    rdbtn_o.Checked = false;
                    rdbtn_o.BackColor = Color.Gray;
                }
                if (rst_p.Equals("Y"))
                {
                    rdbtn_p.Enabled = true;
                    rdbtn_p.Checked = true;
                    rdbtn_p_CheckedChanged(null, null);
                }
                else
                {
                    rdbtn_p.Enabled = false;
                    rdbtn_p.Checked = false;
                    rdbtn_p.BackColor = Color.Gray;
                }
                if (rst_t.Equals("Y"))
                {
                    rdbtn_t.Enabled = true;
                    rdbtn_t.Checked = true;
                    rdbtn_t_CheckedChanged(null, null);
                }
                else
                {
                    rdbtn_t.Enabled = false;
                    rdbtn_t.Checked = false;
                    rdbtn_t.BackColor = Color.Gray;
                }
                if (rst_i.Equals("Y"))
                {
                    rdbtn_i.Enabled = true;
                    rdbtn_i.Checked = true;
                    rdbtn_i_CheckedChanged(null, null);
                }
                else
                {
                    rdbtn_i.Enabled = false;
                    rdbtn_i.Checked = false;
                    rdbtn_i.BackColor = Color.Gray;
                }
                if (!rst_setting.Equals(""))
                {
                    if (rst_setting.Equals("I"))
                    {
                        rdbtn_i.Enabled = true;
                        rdbtn_t.Enabled = false;
                        rdbtn_p.Enabled = false;
                        rdbtn_o.Enabled = false;

                        rdbtn_i.Checked = true;
                        rdbtn_t.BackColor = Color.Gray;
                        rdbtn_p.BackColor = Color.Gray;
                        rdbtn_o.BackColor = Color.Gray;
                    }
                    else if (rst_setting.Equals("T"))
                    {
                        rdbtn_i.Enabled = false;
                        rdbtn_t.Enabled = true;
                        rdbtn_p.Enabled = false;
                        rdbtn_o.Enabled = false;

                        rdbtn_i.BackColor = Color.Gray;
                        rdbtn_t.Checked = true;
                        rdbtn_p.BackColor = Color.Gray;
                        rdbtn_o.BackColor = Color.Gray;
                    }
                    else if (rst_setting.Equals("P"))
                    {
                        rdbtn_i.Enabled = false;
                        rdbtn_t.Enabled = false;
                        rdbtn_p.Enabled = true;
                        rdbtn_o.Enabled = false;

                        rdbtn_i.BackColor = Color.Gray;
                        rdbtn_t.BackColor = Color.Gray;
                        rdbtn_p.Checked = true;
                        rdbtn_o.BackColor = Color.Gray;
                    }
                    else if (rst_setting.Equals("O"))
                    {
                        rdbtn_i.Enabled = false;
                        rdbtn_t.Enabled = false;
                        rdbtn_p.Enabled = false;
                        rdbtn_o.Enabled = true;

                        rdbtn_i.BackColor = Color.Gray;
                        rdbtn_t.BackColor = Color.Gray;
                        rdbtn_p.BackColor = Color.Gray;
                        rdbtn_o.Checked = true;
                    }
                }
                #endregion
            }
        }
                
        #region DB Connect
        private DataTable Select_season()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            //02.ARGURMENT ¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_round()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_SAMPLE_TYPES";

            //02.ARGURMENT ¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_op_cd()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_OP_CD_ADD_ETS";

            //02.ARGURMENT ¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_user()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_USER";

            //02.ARGURMENT ¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Get_rst_yn(string arg_op_cd)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.GET_RST_YN";

            //02.ARGURMENT ¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = arg_op_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }        
        #endregion
        #endregion
        
        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //1. Grid Clear
                fgrid_result.Rows.Count = fgrid_result.Rows.Fixed;

                //2. Search Condition
                string[] arg_value = new string[14];
                arg_value[0]  = cmb_factory.SelectedValue.ToString();
                arg_value[1]  = cmb_category.SelectedValue.ToString().Trim();
                arg_value[2]  = cmb_season.SelectedValue.ToString().Trim();
                arg_value[3]  = txt_sr_no.Text.Trim();
                arg_value[4]  = txt_srf_no.Text.Trim();
                arg_value[5]  = txt_bom_id.Text.Trim();
                arg_value[6]  = cmb_round.SelectedValue.ToString().Trim();
                arg_value[7]  = cmb_user.SelectedValue.ToString().Trim();
                arg_value[8]  = (cmb_opcd.SelectedIndex == 0)? "ALL": cmb_opcd.SelectedValue.ToString().Trim();
                arg_value[9]  = dtp_from.Value.ToString("yyyyMMdd");
                arg_value[10] = dtp_to.Value.ToString("yyyyMMdd");
                arg_value[11] = cmb_sort.SelectedValue.ToString().Trim();
                arg_value[12] = txt_stlye_cd.Text;

                //3. Data Search (BOM Info)
                DataTable dt_list = Select_result_list(arg_value);
                Display_grid(dt_list, fgrid_result);

                dt_list.Dispose();
            }
            catch
            {                
                ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
        }
        private DataTable Select_result_list(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(14);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_RESULT_VJ";

            //02.ARGURMENT ¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON";
            MyOraDB.Parameter_Name[3] = "ARG_SR_NO";
            MyOraDB.Parameter_Name[4] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[6] = "ARG_ROUND";
            MyOraDB.Parameter_Name[7] = "ARG_DEV_USER";
            MyOraDB.Parameter_Name[8] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[9] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[10] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[11] = "ARG_SORT";
            MyOraDB.Parameter_Name[12] = "ARG_STYLE_CD";            
            MyOraDB.Parameter_Name[13] = "OUT_CURSOR";

            //03. DATA TYPE
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
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.Cursor;

            //04. DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = arg_value[0];//arg_factory
            MyOraDB.Parameter_Values[1] = arg_value[1];//arg_category
            MyOraDB.Parameter_Values[2] = arg_value[2];//arg_season
            MyOraDB.Parameter_Values[3] = arg_value[3];//arg_sr_no
            MyOraDB.Parameter_Values[4] = arg_value[4];//arg_srf_no
            MyOraDB.Parameter_Values[5] = arg_value[5];//arg_bom_id
            MyOraDB.Parameter_Values[6] = arg_value[6];//arg_sample_type
            MyOraDB.Parameter_Values[7] = arg_value[7];//arg_dev_user
            MyOraDB.Parameter_Values[8] = arg_value[8];//arg_op_cd
            MyOraDB.Parameter_Values[9] = arg_value[9];//arg_cutting_from
            MyOraDB.Parameter_Values[10] = arg_value[10];//arg_cutting_to
            MyOraDB.Parameter_Values[11] = arg_value[11];//arg_sort
            MyOraDB.Parameter_Values[12] = arg_value[12];//arg_style_cd
            MyOraDB.Parameter_Values[13] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private void Display_grid(DataTable arg_list, COM.FSP arg_grid)
        {
            #region Grid
            for (int i = 0; i < arg_list.Rows.Count; i++)
            {
                arg_grid.Rows.Add();

                for (int j = 0; j < arg_list.Columns.Count; j++)
                {
                    if (j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD || j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD || j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD || j == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD)
                    {
                        string ymd = arg_list.Rows[i].ItemArray[j].ToString();
                                                
                        try
                        {
                            int year = int.Parse(ymd.Substring(0, 4));
                            int month = int.Parse(ymd.Substring(4, 2));
                            int day = int.Parse(ymd.Substring(6, 2));

                            DateTime date = new DateTime(year, month, day);

                            arg_grid.GetCellRange(arg_grid.Rows.Count - 1, j).StyleNew.DataType = typeof(DateTime);
                            arg_grid.GetCellRange(arg_grid.Rows.Count - 1, j).StyleNew.Format = "yyyyMMdd";

                            arg_grid[arg_grid.Rows.Count - 1, j] = date;
                        }
                        catch
                        {
                            arg_grid.GetCellRange(arg_grid.Rows.Count - 1, j).StyleNew.DataType = typeof(String);
                            arg_grid[arg_grid.Rows.Count - 1, j] = ymd; 
                        }
                    }
                    else
                    {
                        arg_grid.GetCellRange(arg_grid.Rows.Count - 1, j).StyleNew.DataType = typeof(String);
                        arg_grid[arg_grid.Rows.Count - 1, j] = arg_list.Rows[i].ItemArray[j].ToString().Trim();
                    }
                }                
                arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
            }
            #endregion

            #region Grid Style Setting

            if (op_setting.Equals("workshop"))
            {
                #region Management È­¸é ÀÏ‹š
                for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                {
                    //Request Date ¿¬µµ ÀÚ¸£°í º¸¿©ÁÖ±â.
                    string req_ymd = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD].ToString().Substring(5, arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD].ToString().Length - 5).Replace("-", "/");
                    arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD] = req_ymd;

                    string lot_seq = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_SEQ].ToString();

                    if(lot_seq.Equals("00"))
                        arg_grid.GetCellRange(i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTYLE_NAME).StyleNew.ForeColor = Color.Red;


                    //UPS User, Remarks ´Ù½Ã ¼³Á¤
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].StyleNew.BackColor    = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].StyleNew.BackColor     = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN].StyleNew.BackColor  = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN].StyleNew.BackColor  = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].StyleNew.BackColor = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].StyleNew.BackColor = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].StyleNew.BackColor = Color.White;

                    for (int j = (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR; j <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR; j++)
                    {
                        arg_grid.Cols[j].AllowMerging = false; //³¯Â¥ ºÎºÐ¸¸ º´ÇÕ ÇÏÁö ¾Ê±â.

                        if (arg_grid[i, j + 1].ToString() == "1")
                        {
                            arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                        }
                        else if (arg_grid[i, j + 1].ToString() == "2")
                        {
                            arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                        }
                        else if (arg_grid[i, j + 1].ToString() == "3")
                        {
                            arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;
                        }
                    }

                    string status = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTATUS].ToString();

                    if (status.Equals("X"))
                        arg_grid.GetCellRange(i, arg_grid.Cols.Fixed, i, arg_grid.Cols.Count - 1).StyleNew.BackColor = Color.DarkGray;

                    string ups_remain = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN].ToString().Trim();
                    string fga_remain = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN].ToString().Trim();

                    if(!ups_remain.Equals("0"))
                        arg_grid.GetCellRange(i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN).StyleNew.ForeColor = Color.Red;
                    if (!fga_remain.Equals("0"))
                        arg_grid.GetCellRange(i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN).StyleNew.ForeColor = Color.Red;
                }
                #endregion
            }
            else
            {
                #region ÇöÀå °øÁ¤ PCÀÏ¶§
                for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
                {
                    //Request Date ¿¬µµ ÀÚ¸£°í º¸¿©ÁÖ±â.
                    string req_ymd = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD].ToString().Substring(5, arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD].ToString().Length - 5).Replace("-", "/");
                    arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREQ_YMD] = req_ymd;

                    //UPS User, Remarks ´Ù½Ã ¼³Á¤
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].StyleNew.BackColor    = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].StyleNew.BackColor     = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN].StyleNew.BackColor  = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN].StyleNew.BackColor  = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].StyleNew.BackColor = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].StyleNew.BackColor = Color.White;
                    arg_grid.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].StyleNew.BackColor = Color.White;

                    for (int j = (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR; j <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR; j++)
                    {
                        arg_grid.Cols[j].AllowMerging = false; //³¯Â¥ ºÎºÐ¸¸ º´ÇÕ ÇÏÁö ¾Ê±â.
                        string op_cd = fgrid_result[arg_grid.Rows.Fixed - 1, j + 5].ToString();

                        if (op_setting.Equals(op_cd))
                        {
                            int point = 1;

                            if (arg_grid[i, j + point].ToString() == "1")
                            {
                                arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                            }
                            else if (arg_grid[i, j + point].ToString() == "2")
                            {
                                arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                            }
                            else if (arg_grid[i, j + point].ToString() == "3")
                            {
                                arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;
                            }

                            arg_grid.GetCellRange(arg_grid.Rows.Fixed - 1, j).StyleNew.BackColor = Color.Red;
                            op_col = j;
                        }
                        else
                        {
                            if (arg_grid[i, j + 1].ToString() == "1")
                            {
                                arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                            }
                            else if (arg_grid[i, j + 1].ToString() == "2")
                            {
                                arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                            }
                            else if (arg_grid[i, j + 1].ToString() == "3")
                            {
                                arg_grid.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;
                            }
                            
                            arg_grid.GetCellRange(i, j, i, j).StyleNew.ForeColor = Color.LightGray;
                        }
                    }

                    string status = arg_grid[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTATUS].ToString();

                    if (status.Equals("X"))
                        arg_grid.GetCellRange(i, arg_grid.Cols.Fixed, i, arg_grid.Cols.Count - 1).StyleNew.BackColor = Color.DarkGray;

                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region Grid Event
        private void fgrid_result_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                #region
                if (flg_resize)
                {
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxCATEGORY].Visible  = false;
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSEASON_CD].Visible = false;                    
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxGEN_SIZE].Visible  = false;
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIPW_YMD].Visible   = false;

                    flg_resize = false;
                }
                else
                {
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxCATEGORY].Visible  = true;
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSEASON_CD].Visible = true;                    
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxGEN_SIZE].Visible  = true;
                    fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIPW_YMD].Visible   = true;

                    flg_resize = true;
                }
                #endregion
            }            
            else
            {
                int sct_row = fgrid_result.Selection.r1;
                int sct_col = fgrid_result.Selection.c1;
                
                if (old_col.Equals(sct_col))
                    return;

                old_col = sct_col;
                fgrid_result.ContextMenuStrip = null;

                if (power_level != "S00" && power_level.Substring(0, 1) != "W" && power_level != "E02")
                {
                    if (power_level.Substring(0, 1) == "P")
                    {
                        if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK)
                        {
                            fgrid_result.ContextMenuStrip = ctmnu_01;
                            mnu_complete.Visible = false;
                            mnu_cancel.Visible   = false;
                            mnu_pop_up.Visible   = false;
                            mnu_clear.Visible    = true;
                        }
                    }

                    return;
                }

                string arg_op_cd = fgrid_result[fgrid_result.Rows.Fixed - 1, sct_col + 1].ToString();

                if (op_setting.Equals("workshop"))
                {
                    #region 
                    if (sct_col >= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR && sct_col <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_RST)
                    {
                        if (fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTATUS].ToString() != "X")
                        {
                            fgrid_result.ContextMenuStrip = ctmnu_01;
                            mnu_complete.Visible = true;
                            mnu_cancel.Visible = true;
                            mnu_pop_up.Visible = false;
                            
                        }

                        mnu_clear.Visible = false;

                        for (int i = (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR; i <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_RST; i++)
                        {
                            if(i == sct_col)
                                fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, i).StyleNew.BackColor = Color.Red;
                            else
                                fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, i).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color; 
                        }

                        RadioButton_Change(arg_op_cd);
                    }
                    else
                    {
                        if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS)
                        {
                            fgrid_result.ContextMenuStrip = ctmnu_01;
                            mnu_complete.Visible = false;
                            mnu_cancel.Visible = false;
                            mnu_pop_up.Visible = true;
                            mnu_clear.Visible = false;
                        }
                        else if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD)
                        {
                            if (power_level.Substring(0, 1) == "P" || power_level.Equals("S00"))
                            {
                                fgrid_result.ContextMenuStrip = ctmnu_01;
                                mnu_complete.Visible = false;
                                mnu_cancel.Visible = false;
                                mnu_pop_up.Visible = false;
                                mnu_clear.Visible = true;                                
                            }
                        }
                        else
                        {
                            fgrid_result.ContextMenuStrip = null; 
                        }
                    }
                    #endregion
                }
                else
                {
                    if (arg_op_cd.Equals(op_setting))
                    {
                        fgrid_result.ContextMenuStrip = ctmnu_01;
                        mnu_complete.Visible = true;
                        mnu_cancel.Visible   = true;
                        mnu_pop_up.Visible   = false;
                        mnu_clear.Visible = false;

                    }
                    else
                    {
                        fgrid_result.ContextMenuStrip = null;
                    }
                }
            }
        }
        private void fgrid_result_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int sct_row  = fgrid_result.Selection.r1;
                int sct_col  = fgrid_result.Selection.c1;
                int scroll_x = fgrid_result.ScrollPosition.X;
                int scroll_y = fgrid_result.ScrollPosition.Y;

                if (power_level.Substring(0, 1) != "W" && power_level != "S00" && power_level != "E02")
                    return;
                if(sct_row < fgrid_result.Rows.Fixed)
                    return;
                if (fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTATUS].ToString() == "X")
                    return;

                if (sct_col >= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR && sct_col <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_RST)
                {
                    if (fgrid_result[sct_row, sct_col].ToString().Equals("X"))
                        return;
                    if (!op_setting.Equals("workshop"))
                    {
                        if (fgrid_result[fgrid_result.Rows.Fixed - 1, sct_col + 1].ToString() != op_setting)
                            return;
                    }

                    #region
                    string arg_pcard_id = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxPCARD_ID].ToString();
                    string arg_op_cd    = fgrid_result[fgrid_result.Rows.Fixed - 1, sct_col + 1].ToString();
                    string arg_op_name  = fgrid_result[fgrid_result.Rows.Fixed - 1, sct_col].ToString();
                    string arg_cmp_cd   = get_cmp_cd(arg_op_cd).Rows[0].ItemArray[1].ToString();
                    
                    string arg_rst_qty  = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_QTY].ToString();
                    string arg_rst_div  = "";

                    string arg_factory_name = cmb_factory.Text;                    
                    string arg_category     = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxCATEGORY].ToString();
                    string arg_season       = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSEASON_CD].ToString();
                    string arg_model        = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTYLE_NAME].ToString();
                    string arg_color        = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxCOLOR_VER].ToString();
                    string arg_sample_type  = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSAMPLE_TYPE].ToString();

                    string sms_op_status    = fgrid_result[sct_row, sct_col + 1].ToString();
                    string arg_factory      = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFACTORY].ToString();
                    string arg_lot_no       = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_NO].ToString();
                    string arg_lot_seq      = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_SEQ].ToString();
 
                    if (rdbtn_i.Checked)
                    {
                        arg_op_name = arg_op_name + " Incoming";
                        arg_rst_div = "I";
                    }
                    else if (rdbtn_t.Checked)
                    {
                        arg_op_name = arg_op_name + " Input";
                        arg_rst_div = "T";
                    }
                    else if (rdbtn_p.Checked)
                    {
                        arg_op_name = arg_op_name + " Prod";
                        arg_rst_div = "P";
                    }
                    else if (rdbtn_o.Checked)
                    {
                        arg_op_name = arg_op_name + " Outgoing";
                        arg_rst_div = "O";
                    }
                    #endregion

                    #region
                    if (!arg_op_cd.Equals("FGA"))
                    {
                        if (double.Parse(arg_rst_qty) <= 12)
                        {
                            Click_Save(arg_pcard_id, arg_cmp_cd, arg_op_cd, arg_rst_div);

                            DataTable dt_rst = get_save_result(arg_pcard_id, arg_cmp_cd, arg_op_cd, arg_rst_div);
                            string save_result_point = dt_rst.Rows[0].ItemArray[0].ToString();
                            string save_result = dt_rst.Rows[0].ItemArray[1].ToString();

                            int point = 1;

                            if (rdbtn_i.Checked)
                                point = 2;
                            if (rdbtn_t.Checked)
                                point = 3;
                            if (rdbtn_p.Checked)
                                point = 4;
                            if (rdbtn_o.Checked)
                                point = 5;

                            fgrid_result[sct_row, sct_col + point] = save_result_point;
                            fgrid_result[sct_row, sct_col + 1] = save_result;

                            if (save_result.Equals("1"))
                                fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.BackColor = Color.White;
                            else if (save_result.Equals("2"))
                                fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.BackColor = Color.Yellow;
                            else if (save_result.Equals("3"))
                                fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.BackColor = Color.Aqua;

                            //SMS Service
                            if (arg_op_cd.Equals("UPC") || arg_op_cd.Equals("FGA"))
                            {
                                if (arg_rst_div.Equals("I") || arg_rst_div.Equals("T"))
                                {
                                    Send_Message(arg_factory, arg_lot_no, arg_lot_seq, arg_op_name);
                                }
                            }

                            return;
                        }

                    }
                    #endregion

                    #region
                    Pop_Prod_Result_VJ pop = new Pop_Prod_Result_VJ(arg_pcard_id, arg_op_cd, arg_rst_div, arg_op_name, arg_factory_name, arg_category, arg_season, arg_model, arg_color, arg_sample_type, this);
                    pop.ShowDialog();

                    if (pop.save_flg)
                    {              
                        DataTable dt_rst = get_save_result(arg_pcard_id, arg_cmp_cd, arg_op_cd, arg_rst_div);
                        string save_result_point = dt_rst.Rows[0].ItemArray[0].ToString();
                        string save_result       = dt_rst.Rows[0].ItemArray[1].ToString();
                        string save_result_qty   = dt_rst.Rows[0].ItemArray[2].ToString();

                        int point = 1;

                        if (rdbtn_i.Checked)
                            point = 2;
                        if (rdbtn_t.Checked)
                            point = 3;
                        if (rdbtn_p.Checked)
                            point = 4;
                        if (rdbtn_o.Checked)
                            point = 5;

                        fgrid_result[sct_row, sct_col + point] = save_result_point;
                        fgrid_result[sct_row, sct_col + 1]     = save_result;
                        if (arg_op_cd.Equals("UPS"))
                        {
                            if (rdbtn_p.Checked)
                            {
                                fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_REMAIN] = save_result_qty; 
                            }
                        }
                        else if (arg_op_cd.Equals("FGA"))
                        {
                            if (rdbtn_p.Checked)
                            {
                                fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMAIN] = save_result_qty;
                            }
                        }


                        if (save_result.Equals("1"))
                            fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.BackColor = Color.White;
                        else if (save_result.Equals("2"))
                            fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.BackColor = Color.Yellow;
                        else if (save_result.Equals("3"))
                            fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.BackColor = Color.Aqua;

                        

                        //SMS Service
                        if (arg_op_cd.Equals("UPC") || arg_op_cd.Equals("FGA"))
                        {
                            if (arg_rst_div.Equals("I") || arg_rst_div.Equals("T"))
                            {
                                Send_Message(arg_factory, arg_lot_no, arg_lot_seq, arg_op_name);
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
        private void fgrid_result_KeyPress(object sender, KeyPressEventArgs e)
        {           
            string bar = e.KeyChar.ToString();

            try
            {
                int check = int.Parse(bar);

                bar_code_scan += bar;

                if (bar_code_scan.Length == 15)
                {
                    txt_barcode.Text = bar_code_scan;
                    bar_code_scan = "";
                }
            }
            catch
            {
                bar_code_scan = "";
            }
        }
        private void fgrid_result_EnterCell(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_result.Selection.r1;
                int sct_col = fgrid_result.Selection.c1;

                if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD)
                {
                    fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.DataType = typeof(DateTime);
                    fgrid_result.GetCellRange(sct_row, sct_col).StyleNew.Format = "yyyyMMdd"; 
                }
            }
            catch
            {
 
            }
        }
        private void fgrid_result_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int arg_row = fgrid_result.Selection.r1;
                Save_grid_data(arg_row);

                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Save_grid_data(int arg_row)
        {
            MyOraDB.ReDim_Parameter(15);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_PROD_01.SAVE_SXG_PROD_GRID_VJ";
           
            //02.ARGURMENT¸í
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
            MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
            MyOraDB.Parameter_Name[5] = "ARG_UPS_USER";
            MyOraDB.Parameter_Name[6] = "ARG_UPS_RMK";
            MyOraDB.Parameter_Name[7] = "ARG_UPC_RMK";
            MyOraDB.Parameter_Name[8] = "ARG_FGA_RMK";
            MyOraDB.Parameter_Name[9] = "ARG_UPE_RMK";
            MyOraDB.Parameter_Name[10] = "ARG_MAT_DATE";
            MyOraDB.Parameter_Name[11] = "ARG_IN_DATE";
            MyOraDB.Parameter_Name[12] = "ARG_IN_RMK";
            MyOraDB.Parameter_Name[13] = "ARG_SBOOK_YMD";
            MyOraDB.Parameter_Name[14] = "ARG_YIELD_YMD";

            //03. DATA TYPE Á¤ÀÇ
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
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;

            //04. DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[2] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[3] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxDAY_SEQ].ToString();
            MyOraDB.Parameter_Values[4] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLINE_CD].ToString();
            MyOraDB.Parameter_Values[5] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER].ToString();
            MyOraDB.Parameter_Values[6] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS].ToString();
            MyOraDB.Parameter_Values[7] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS].ToString();
            MyOraDB.Parameter_Values[8] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_REMARKS].ToString();
            MyOraDB.Parameter_Values[9] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPE_REMARKS].ToString();
            try
            {
                if (fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD] == null)
                    MyOraDB.Parameter_Values[10] = "";
                else
                    MyOraDB.Parameter_Values[10] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].ToString().Substring(0, 4) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].ToString().Substring(5, 2) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].ToString().Substring(8, 2);
                
            }
            catch
            {
                MyOraDB.Parameter_Values[10] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxMAT_YMD].ToString();
                
            }
            try
            {
                if (fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD] == null)
                    MyOraDB.Parameter_Values[11] = "";
                else
                    MyOraDB.Parameter_Values[11] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].ToString().Substring(0, 4) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].ToString().Substring(5, 2) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].ToString().Substring(8, 2);
            }
            catch
            {
                MyOraDB.Parameter_Values[11] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_YMD].ToString();
            }

            if (fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK] == null)
                MyOraDB.Parameter_Values[12] = "";
            else
                MyOraDB.Parameter_Values[12] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxIN_REMARK].ToString();

            try
            {
                if (fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD] == null)
                    MyOraDB.Parameter_Values[13] = "";
                else
                    MyOraDB.Parameter_Values[13] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD].ToString().Substring(0, 4) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD].ToString().Substring(5, 2) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD].ToString().Substring(8, 2);

            }
            catch
            {
                MyOraDB.Parameter_Values[13] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSBOOK_YMD].ToString();

            }

            try
            {
                if (fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD] == null)
                    MyOraDB.Parameter_Values[14] = "";
                else
                    MyOraDB.Parameter_Values[14] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD].ToString().Substring(0, 4) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD].ToString().Substring(5, 2) + fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD].ToString().Substring(8, 2);

            }
            catch
            {
                MyOraDB.Parameter_Values[14] = fgrid_result[arg_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxYIELD_YMD].ToString();

            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Control Event
        private void chk_refresh_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_refresh.Checked)
                timer_01.Enabled = true;
            else
                timer_01.Enabled = false;
        }
        private void timer_01_Tick(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_result.Selection.r1;
                int sct_col = fgrid_result.Selection.c1;
                int scroll_x = fgrid_result.ScrollPosition.X;
                int scroll_y = fgrid_result.ScrollPosition.Y;

                tbtn_Search_Click(null, null);
                fgrid_result.ScrollPosition = new System.Drawing.Point(scroll_x, scroll_y);
                fgrid_result.Select(sct_row, sct_col);
            }
            catch
            {
 
            }
        }
        private void timer_scan_Tick(object sender, EventArgs e)
        {
            bar_code_scan = "";
        }

        private void Grid_change_byRadioBtn(int arg_point)
        {          
            int sct_row = fgrid_result.Selection.r1;
            int sct_col = fgrid_result.Selection.c1;

            if (op_setting.Equals("workshop"))
            {
                
                for (int i = fgrid_result.Rows.Fixed; i < fgrid_result.Rows.Count; i++)
                {
                    string status = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTATUS].ToString();

                    if (!status.Equals("X"))
                    {
                        for (int j = (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR; j <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR; j++)
                        {
                            if (sct_col == j)
                            {
                                fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, j).StyleNew.BackColor = Color.Red;

                                if (fgrid_result[i, j + arg_point].ToString() == "1")
                                {
                                    fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                                }
                                else if (fgrid_result[i, j + arg_point].ToString() == "2")
                                {
                                    fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                                }
                                else if (fgrid_result[i, j + arg_point].ToString() == "3")
                                {
                                    fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;
                                }
                            }
                            else
                            {
                                fgrid_result.GetCellRange(fgrid_result.Rows.Fixed - 1, j).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;

                                if (fgrid_result[i, j + 1].ToString() == "1")
                                {
                                    fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                                }
                                else if (fgrid_result[i, j + 1].ToString() == "2")
                                {
                                    fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                                }
                                else if (fgrid_result[i, j + 1].ToString() == "3")
                                {
                                    fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;
                                }
                            }
                        }
                    }
                }
            }
            else
            {

                for (int i = fgrid_result.Rows.Fixed; i < fgrid_result.Rows.Count; i++)
                {
                    string status = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxSTATUS].ToString();

                    if (!status.Equals("X"))
                    {
                        if (fgrid_result[i, op_col + arg_point].ToString() == "1")
                        {
                            fgrid_result.GetCellRange(i, op_col).StyleNew.BackColor = Color.White;
                        }
                        else if (fgrid_result[i, op_col + arg_point].ToString() == "2")
                        {
                            fgrid_result.GetCellRange(i, op_col).StyleNew.BackColor = Color.Yellow;
                        }
                        else if (fgrid_result[i, op_col + arg_point].ToString() == "3")
                        {
                            fgrid_result.GetCellRange(i, op_col).StyleNew.BackColor = Color.Aqua;
                        }
                    }
                } 
            }

            fgrid_result.Select(sct_row, sct_col);
        }

        private void timer_barcode_Tick(object sender, EventArgs e)
        {
            if (!op_setting.Equals("workshop"))
            {
                txt_barcode.Focus(); 
            }
        }

        #region Radio Button Event
        private void rdbtn_i_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_i.Checked)
            {
                rdbtn_i.BackColor = Color.Orange;

                //Grid_change_byRadioBtn(2);
            }
            else
            {
                rdbtn_i.BackColor = Color.WhiteSmoke; 
            }
        }

        private void rdbtn_t_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_t.Checked)
            {
                rdbtn_t.BackColor = Color.Orange;

                //Grid_change_byRadioBtn(3);
            }
            else
            {
                rdbtn_t.BackColor = Color.WhiteSmoke;
            }

        }

        private void rdbtn_p_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_p.Checked)
            {
                rdbtn_p.BackColor = Color.Orange;

                //Grid_change_byRadioBtn(4);
            }
            else
            {
                rdbtn_p.BackColor = Color.WhiteSmoke;
            }

        }

        private void rdbtn_o_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_o.Checked)
            {
                rdbtn_o.BackColor = Color.Orange;

                //Grid_change_byRadioBtn(5);
            }
            else
            {
                rdbtn_o.BackColor = Color.WhiteSmoke;
            }

        }

        private void rdbtn_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bar = e.KeyChar.ToString();

            try
            {
                int check = int.Parse(bar);

                bar_code_scan += bar;

                if (bar_code_scan.Length == 15)
                {
                    txt_barcode.Text = bar_code_scan;
                    bar_code_scan = "";
                }
            }
            catch
            {
                bar_code_scan = "";
            }
        }

        private void rdbtn_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bar = e.KeyChar.ToString();

            try
            {
                int check = int.Parse(bar);

                bar_code_scan += bar;

                if (bar_code_scan.Length == 15)
                {
                    txt_barcode.Text = bar_code_scan;
                    bar_code_scan = "";
                }
            }
            catch
            {
                bar_code_scan = "";
            }
        }

        private void rdbtn_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bar = e.KeyChar.ToString();

            try
            {
                int check = int.Parse(bar);

                bar_code_scan += bar;

                if (bar_code_scan.Length == 15)
                {
                    txt_barcode.Text = bar_code_scan;
                    bar_code_scan = "";
                }
            }
            catch
            {
                bar_code_scan = "";
            }
        }

        private void rdbtn_o_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bar = e.KeyChar.ToString();

            try
            {
                int check = int.Parse(bar);

                bar_code_scan += bar;

                if (bar_code_scan.Length == 15)
                {
                    txt_barcode.Text = bar_code_scan;
                    bar_code_scan = "";
                }
            }
            catch
            {
                bar_code_scan = "";
            }
        }
        #endregion

        #endregion

        #region Save Data
        private void txt_barcode_TextChanged(object sender, EventArgs e)
       {
           try
           {
               if (txt_barcode.Text.Length == 15)
               {
                   string bar_code = txt_barcode.Text;

                   string op_cd = op_setting;
                   if (op_setting.Equals("workshop"))
                   {
                       if (fgrid_result.Selection.c1 >= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR && fgrid_result.Selection.c1 <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR)
                       {
                           op_cd = fgrid_result[fgrid_result.Rows.Fixed - 1, fgrid_result.Selection.c1 + 1].ToString();
                       }
                       else
                       {
                           return;
                       }

                   }

                   string rst_div = "";
                   int point = 1;
                   if (rdbtn_i.Checked)
                   {
                       rst_div = "I";
                       point = 2;
                   }
                   else if (rdbtn_t.Checked)
                   {
                       rst_div = "T";
                       point = 3;
                   }
                   else if (rdbtn_p.Checked)
                   {
                       rst_div = "P";
                       point = 4;
                   }
                   else if (rdbtn_o.Checked)
                   {
                       rst_div = "O";
                       point = 5;
                   }

                   #region
                   if (op_cd.Equals("FGA"))
                   {
                       #region Assembly
                       DataTable dt_rst = get_bar_code_info_pop(bar_code, op_cd);

                       if (dt_rst.Rows.Count == 0)
                       {
                           MessageBox.Show("This Barcode is not exist");
                           txt_barcode.Text = "";
                           return;
                       }

                       string pcard_id  = dt_rst.Rows[0].ItemArray[0].ToString();
                       string model     = dt_rst.Rows[0].ItemArray[1].ToString();                       
                       string round     = dt_rst.Rows[0].ItemArray[2].ToString();
                       string bom_style = dt_rst.Rows[0].ItemArray[3].ToString();
                       string qty       = dt_rst.Rows[0].ItemArray[4].ToString();
                       string cmp_cd    = dt_rst.Rows[0].ItemArray[5].ToString();


                       Pop_Prod_ScanInfo_VJ pop = new Pop_Prod_ScanInfo_VJ(bar_code, op_cd, cmp_cd, rst_div, model, round, bom_style, qty);
                       pop.ShowDialog();

                       if (pop.save_flg)
                       {
                           #region Pop Save
                           for (int i = fgrid_result.Rows.Fixed; i < fgrid_result.Rows.Count; i++)
                           {
                               string grid_pcard_id = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxPCARD_ID].ToString();

                               if (pcard_id == grid_pcard_id)
                               {
                                   for (int j = (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR; j <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR; j++)
                                   {
                                       string grd_op_cd = fgrid_result[fgrid_result.Rows.Fixed - 1, j + 1].ToString();

                                       if (op_cd == grd_op_cd)
                                       {
                                           dt_rst = get_save_result(pcard_id, cmp_cd, op_cd, rst_div);
                                           string save_result_point = dt_rst.Rows[0].ItemArray[0].ToString();
                                           string save_result = dt_rst.Rows[0].ItemArray[1].ToString();

                                           fgrid_result[i, j + point] = save_result_point;
                                           fgrid_result[i, j + 1] = save_result;

                                           if (save_result.Equals("1"))
                                               fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                                           else if (save_result.Equals("2"))
                                               fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                                           else if (save_result.Equals("3"))
                                               fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;

                                           //SMS Service
                                           if (rst_div.Equals("T"))
                                           {
                                               string arg_factory = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFACTORY].ToString();
                                               string arg_lot_no = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_NO].ToString();
                                               string arg_lot_seq = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_SEQ].ToString();
                                               string arg_op_name = "Assembly Input";

                                               Send_Message(arg_factory, arg_lot_no, arg_lot_seq, arg_op_name);
                                           }


                                           fgrid_result.TopRow = i;
                                           fgrid_result.Select(-1, -1);
                                           break;
                                       }
                                   }
                                   break;
                               }
                           }
                           #endregion

                       }
                       #endregion
                   }
                   else
                   {
                       #region 
                       DataTable dt_rst = get_bar_code_info(bar_code, op_cd);

                       if (dt_rst.Rows.Count == 0)
                       {
                           MessageBox.Show("This Barcode is not exist");
                           txt_barcode.Text = "";
                           return;
                       }

                       //string rst_qty = dt_rst.Rows[0].ItemArray[0].ToString();
                       //string pcard_id = dt_rst.Rows[0].ItemArray[1].ToString();
                       //string rst_ymd = dt_rst.Rows[0].ItemArray[2].ToString();
                       //string rst_hms = dt_rst.Rows[0].ItemArray[3].ToString();
                       //string factory = dt_rst.Rows[0].ItemArray[4].ToString();
                       //string lot_no = dt_rst.Rows[0].ItemArray[5].ToString();
                       //string lot_seq = dt_rst.Rows[0].ItemArray[6].ToString();
                       //string op_name = dt_rst.Rows[0].ItemArray[7].ToString();
                       //string sms_status = dt_rst.Rows[0].ItemArray[8].ToString();
                       //string cmp_cd = get_cmp_cd(op_cd).Rows[0].ItemArray[1].ToString();

                       //if (rdbtn_i.Checked)
                       //    op_name = op_name + " Incoming";
                       //else if (rdbtn_t.Checked)
                       //    op_name = op_name + " Input";
                       //else if (rdbtn_p.Checked)
                       //    op_name = op_name + " Product";
                       //else if (rdbtn_o.Checked)
                       //    op_name = op_name + " Outgoing";

                       //Save_data(bar_code, cmp_cd, op_cd, rst_div, rst_ymd, rst_hms, rst_qty);

                       string pcard_id = dt_rst.Rows[0].ItemArray[0].ToString();
                       string model = dt_rst.Rows[0].ItemArray[1].ToString();
                       string round = dt_rst.Rows[0].ItemArray[2].ToString();
                       string bom_style = dt_rst.Rows[0].ItemArray[3].ToString();
                       string qty = dt_rst.Rows[0].ItemArray[4].ToString();
                       string cmp_cd = dt_rst.Rows[0].ItemArray[5].ToString();


                       Pop_Prod_ScanInfo_VJ pop = new Pop_Prod_ScanInfo_VJ(bar_code, op_cd, cmp_cd, rst_div, model, round, bom_style, qty);
                       pop.ShowDialog();

                       if (pop.save_flg)
                       {
                           for (int i = fgrid_result.Rows.Fixed; i < fgrid_result.Rows.Count; i++)
                           {
                               string grid_pcard_id = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxPCARD_ID].ToString();

                               if (pcard_id == grid_pcard_id)
                               {
                                   for (int j = (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_DIR; j <= (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_DIR; j++)
                                   {
                                       string grd_op_cd = fgrid_result[fgrid_result.Rows.Fixed - 1, j + 1].ToString();

                                       if (op_cd == grd_op_cd)
                                       {
                                           dt_rst = get_save_result(pcard_id, cmp_cd, op_cd, rst_div);
                                           string save_result_point = dt_rst.Rows[0].ItemArray[0].ToString();
                                           string save_result = dt_rst.Rows[0].ItemArray[1].ToString();

                                           fgrid_result[i, j + point] = save_result_point;
                                           fgrid_result[i, j + 1] = save_result;

                                           if (save_result.Equals("1"))
                                               fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.White;
                                           else if (save_result.Equals("2"))
                                               fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Yellow;
                                           else if (save_result.Equals("3"))
                                               fgrid_result.GetCellRange(i, j).StyleNew.BackColor = Color.Aqua;

                                           //SMS Service
                                           if (op_cd.Equals("UPC") && rst_div.Equals("I"))
                                           {
                                               string arg_factory = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFACTORY].ToString();
                                               string arg_lot_no  = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_NO].ToString();
                                               string arg_lot_seq = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxLOT_SEQ].ToString();
                                               string arg_op_name = "Cutting Incoming";

                                               Send_Message(arg_factory, arg_lot_no, arg_lot_seq, arg_op_name);
                                           }

                                           fgrid_result.TopRow = i;
                                           fgrid_result.Select(-1, -1);
                                           break;
                                       }
                                   }
                                   break;
                               }


                           }
                       }

                       #endregion
                   }
                   
                   #endregion
                                          
                   txt_barcode.Text = "";                   
                   txt_barcode.Focus();
                   
               }
               
           }
           catch
           {

           }
        }

        private void Click_Save(string arg_pcard_id, string arg_cmp_cd, string arg_op_cd, string arg_rst_div)
        {
            DataTable dt_rst = get_bar_code(arg_pcard_id, arg_cmp_cd, arg_op_cd);
                           
            if (dt_rst.Rows.Count > 0)
            {
                for (int j = 0; j < dt_rst.Rows.Count; j++)
                {
                    string bar_code = dt_rst.Rows[j].ItemArray[0].ToString();
                    string rst_qty  = dt_rst.Rows[j].ItemArray[1].ToString();
                    string rst_ymd  = dt_rst.Rows[j].ItemArray[2].ToString();
                    string rst_hms  = dt_rst.Rows[j].ItemArray[3].ToString();

                    Save_data(bar_code, arg_cmp_cd, arg_op_cd, arg_rst_div, rst_ymd, rst_hms, rst_qty);
                }
            }
        }

        private DataTable get_bar_code_info(string arg_bar_code, string arg_op_cd)
        {
            string Proc_Name = "pkg_sxg_prod_01_select.get_bar_code_info";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_bar_code";
            MyOraDB.Parameter_Name[1] = "arg_op_cd";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_op_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable get_bar_code_info_pop(string arg_bar_code, string arg_op_cd)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.GET_BAR_CODE_INFO";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_op_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable get_cmp_cd(string arg_op_cd)
        {
            string Proc_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_OP_CD";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = arg_op_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private DataTable get_bar_code(string arg_pcard_id, string arg_cmp_cd, string arg_op_cd)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.GET_BAR_CODE";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_PCARD_ID";
            MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
            MyOraDB.Parameter_Name[2] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_pcard_id;
            MyOraDB.Parameter_Values[1] = arg_cmp_cd;
            MyOraDB.Parameter_Values[2] = arg_op_cd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private DataTable get_save_result(string arg_pcard_id, string arg_cmp_cd, string arg_op_cd, string arg_rst_div)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.GET_SAVE_RESULT";

            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_PCARD_ID";
            MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
            MyOraDB.Parameter_Name[2] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[3] = "ARG_RST_DIV";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_pcard_id;
            MyOraDB.Parameter_Values[1] = arg_cmp_cd;
            MyOraDB.Parameter_Values[2] = arg_op_cd;
            MyOraDB.Parameter_Values[3] = arg_rst_div;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private void Save_data(string arg_bar_code, string arg_cmp_cd, string arg_op_cd, string arg_rst_div, string arg_rst_ymd, string arg_rst_hms, string arg_rst_qty)
        {
            MyOraDB.ReDim_Parameter(8);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_PROD_01.SAVE_SXG_PROD_PCARD";

            //02.ARGURMENT¸í
            MyOraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
            MyOraDB.Parameter_Name[2] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[3] = "ARG_RST_DIV";
            MyOraDB.Parameter_Name[4] = "ARG_RST_YMD";
            MyOraDB.Parameter_Name[5] = "ARG_RST_HMS";
            MyOraDB.Parameter_Name[6] = "ARG_RST_QTY";
            MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

            //03. DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

            //04. DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_cmp_cd;
            MyOraDB.Parameter_Values[2] = arg_op_cd;
            MyOraDB.Parameter_Values[3] = arg_rst_div;
            MyOraDB.Parameter_Values[4] = arg_rst_ymd;
            MyOraDB.Parameter_Values[5] = arg_rst_hms;
            MyOraDB.Parameter_Values[6] = arg_rst_qty;
            MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;


                string[] arg_value = new string[14];

                //string[] arg_value = new string[14];
                //arg_value[0] = cmb_factory.SelectedValue.ToString();
                //arg_value[1] = cmb_category.SelectedValue.ToString().Trim();
                //arg_value[2] = cmb_season.SelectedValue.ToString().Trim();
                //arg_value[3] = txt_sr_no.Text.Trim();
                //arg_value[4] = txt_srf_no.Text.Trim();
                //arg_value[5] = txt_bom_id.Text.Trim();
                //arg_value[6] = cmb_round.SelectedValue.ToString().Trim();
                //arg_value[7] = cmb_user.SelectedValue.ToString().Trim();
                //arg_value[8] = (cmb_opcd.SelectedIndex == 0) ? "ALL" : cmb_opcd.SelectedValue.ToString().Trim();
                //arg_value[9] = dtp_from.Value.ToString("yyyyMMdd");
                //arg_value[10] = dtp_to.Value.ToString("yyyyMMdd");
                //arg_value[11] = cmb_sort.SelectedValue.ToString().Trim();
                //arg_value[12] = txt_stlye_cd.Text;

                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = cmb_category.SelectedValue.ToString().Trim();
                arg_value[2] = cmb_season.SelectedValue.ToString().Trim();
                arg_value[3] = txt_sr_no.Text.Trim();
                arg_value[4] = txt_srf_no.Text.Trim();
                arg_value[5] = txt_bom_id.Text.Trim();
                arg_value[6] = cmb_round.SelectedValue.ToString().Trim();
                arg_value[7] = cmb_user.SelectedValue.ToString().Trim();
                arg_value[8] = dtp_from.Value.ToString("yyyyMMdd");
                arg_value[9] = dtp_to.Value.ToString("yyyyMMdd");
                arg_value[10] = txt_stlye_cd.Text;
                arg_value[11] = (cmb_opcd.SelectedValue.ToString().Trim().Equals("")) ? "ALL" : cmb_opcd.SelectedValue.ToString().Trim();
                arg_value[12] = cmb_sort.SelectedValue.ToString().Trim();

                Product_VJ.Pop_Prod_PrintOption_VJ pop = new FlexCDC.Product_VJ.Pop_Prod_PrintOption_VJ("PRODUCT", arg_value, this);
                pop.ShowDialog();
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

        #region Context Menu Event
        private void mnu_complete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_result.Selections;

                string rst_div = "";
                int point = 1;

                string op_cd   = fgrid_result[fgrid_result.Rows.Fixed - 1, fgrid_result.Selection.c1 + 1].ToString();
                string op_name = fgrid_result[fgrid_result.Rows.Fixed - 1, fgrid_result.Selection.c1].ToString();
                string cmp_cd  = get_cmp_cd(op_cd).Rows[0].ItemArray[1].ToString();
                string factory    = "";
                string lot_no     = "";
                string lot_seq    = "";
                string sms_status = "";

                if (rdbtn_i.Checked)
                {
                    rst_div = "I";
                    op_name = op_name + " Incoming";
                    point = 2;
                }
                else if (rdbtn_t.Checked)
                {
                    rst_div = "T";
                    op_name = op_name + " Input";
                    point = 3;
                }
                else if (rdbtn_p.Checked)
                {
                    rst_div = "P";
                    op_name = op_name + " Product";
                    point = 4;
                }
                else if (rdbtn_o.Checked)
                {
                    rst_div = "O";
                    op_name = op_name + " Outgoing";
                    point = 5;
                } 

                DataTable dt_rst = null;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (fgrid_result[sct_rows[i], fgrid_result.Selection.c1].ToString() != "X")
                    {
                        string pcard_id = fgrid_result[sct_rows[i], (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxPCARD_ID].ToString();
                        dt_rst = get_bar_code(pcard_id, cmp_cd, op_cd);

                        if (dt_rst.Rows.Count > 0)
                        {
                            factory    = dt_rst.Rows[0].ItemArray[4].ToString();
                            lot_no     = dt_rst.Rows[0].ItemArray[5].ToString();
                            lot_seq    = dt_rst.Rows[0].ItemArray[6].ToString();
                            sms_status = dt_rst.Rows[0].ItemArray[7].ToString();                            

                            for (int j = 0; j < dt_rst.Rows.Count; j++)
                            {
                                string bar_code = dt_rst.Rows[j].ItemArray[0].ToString();
                                string rst_qty  = dt_rst.Rows[j].ItemArray[1].ToString();
                                string rst_ymd  = dt_rst.Rows[j].ItemArray[2].ToString();
                                string rst_hms  = dt_rst.Rows[j].ItemArray[3].ToString();

                                Save_data(bar_code, cmp_cd, op_cd, rst_div, rst_ymd, rst_hms, rst_qty);
                            }
                        }

                        dt_rst = get_save_result(pcard_id, cmp_cd, op_cd, rst_div);
                        string save_result_point = dt_rst.Rows[0].ItemArray[0].ToString();
                        string save_result       = dt_rst.Rows[0].ItemArray[1].ToString();

                        fgrid_result[sct_rows[i], fgrid_result.Selection.c1 + point] = save_result_point;
                        fgrid_result[sct_rows[i], fgrid_result.Selection.c1 + 1]     = save_result;

                        if (save_result.Equals("1"))
                            fgrid_result.GetCellRange(sct_rows[i], fgrid_result.Selection.c1).StyleNew.BackColor = Color.White;
                        else if (save_result.Equals("2"))
                            fgrid_result.GetCellRange(sct_rows[i], fgrid_result.Selection.c1).StyleNew.BackColor = Color.Yellow;
                        else if (save_result.Equals("3"))
                            fgrid_result.GetCellRange(sct_rows[i], fgrid_result.Selection.c1).StyleNew.BackColor = Color.Aqua;

                        //SMS Service
                        if (op_cd.Equals("UPC") || op_cd.Equals("FGA") || op_cd.Equals("UPS") || op_cd.Equals("PHC"))
                        {
                            if (sms_status.Equals("N") && (rst_div.Equals("I") || rst_div.Equals("T")))
                            {
                                Send_Message(factory, lot_no, lot_seq, op_name);
                            }
                        }
                    }


                }

                this.Cursor = Cursors.Default; 
            }
            catch
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void mnu_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_result.Selections;

                string rst_div = "";
                int point = 1;

                if (rdbtn_i.Checked)
                {
                    rst_div = "I";
                    point = 2;
                }
                else if (rdbtn_t.Checked)
                {
                    rst_div = "T";
                    point = 3;
                }
                else if (rdbtn_p.Checked)
                {
                    rst_div = "P";
                    point = 4;
                }
                else if (rdbtn_o.Checked)
                {
                    rst_div = "O";
                    point = 5;
                }

                string op_cd  = fgrid_result[fgrid_result.Rows.Fixed - 1, fgrid_result.Selection.c1 + 1].ToString();
                string cmp_cd = get_cmp_cd(op_cd).Rows[0].ItemArray[1].ToString();

                DataTable dt_rst = null;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (fgrid_result[sct_rows[i], fgrid_result.Selection.c1].ToString() != "X")
                    {
                        string pcard_id = fgrid_result[sct_rows[i], (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxPCARD_ID].ToString();

                        dt_rst = get_bar_code(pcard_id, cmp_cd, op_cd);

                        if (dt_rst.Rows.Count > 0)
                        {
                            for (int j = 0; j < dt_rst.Rows.Count; j++)
                            {
                                string bar_code = dt_rst.Rows[j].ItemArray[0].ToString();
                                string rst_ymd  = dt_rst.Rows[j].ItemArray[2].ToString();
                                string rst_hms  = dt_rst.Rows[j].ItemArray[3].ToString();

                                Save_data(bar_code, cmp_cd, op_cd, rst_div, rst_ymd, rst_hms, "0");
                            }

                            dt_rst = get_save_result(pcard_id, cmp_cd, op_cd, rst_div);
                            string save_result_point = dt_rst.Rows[0].ItemArray[0].ToString();
                            string save_result       = dt_rst.Rows[0].ItemArray[1].ToString();

                            fgrid_result[sct_rows[i], fgrid_result.Selection.c1 + point] = save_result_point;
                            fgrid_result[sct_rows[i], fgrid_result.Selection.c1 + 1]     = save_result;

                            if (save_result.Equals("1"))
                                fgrid_result.GetCellRange(sct_rows[i], fgrid_result.Selection.c1).StyleNew.BackColor = Color.White;
                            else if (save_result.Equals("2"))
                                fgrid_result.GetCellRange(sct_rows[i], fgrid_result.Selection.c1).StyleNew.BackColor = Color.Yellow;
                            else if (save_result.Equals("3"))
                                fgrid_result.GetCellRange(sct_rows[i], fgrid_result.Selection.c1).StyleNew.BackColor = Color.Aqua;
                        }
                    }

                }

                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void mnu_pop_up_Click(object sender, EventArgs e)
        {
            int sct_row = fgrid_result.Selection.r1;
            int sct_col = fgrid_result.Selection.c1;

            if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_USER || sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxREMARKS)
            {
                if (fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPS_DIR].ToString() == "X")
                {
                    MessageBox.Show("UPS Oepration is empty");
                    return;
                }

                string arg_factory = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFACTORY].ToString();
                string arg_qty = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_QTY].ToString();

                Pop_Plan_sch_VJ pop = new Pop_Plan_sch_VJ(arg_factory, arg_qty, "UPS", this);
                pop.ShowDialog();
            }
            if (sct_col == (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxUPC_REMARKS)
            {
                string arg_factory = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFACTORY].ToString();
                string arg_qty = fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP_VJ.IxFGA_QTY].ToString();

                Pop_Plan_sch_VJ pop = new Pop_Plan_sch_VJ(arg_factory, arg_qty, "UPC", this);
                pop.ShowDialog();
            }            
        }
        private void mnu_clear_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    int arg_row = fgrid_result.Selection.r1;
                    int arg_col = fgrid_result.Selection.c1;

                    fgrid_result[arg_row, arg_col] = null;

                    Save_grid_data(arg_row);

                    this.Cursor = Cursors.Default;
                }
                catch
                {
                    this.Cursor = Cursors.Default;
                }
            }
            catch
            {
 
            }
        }
        #endregion       
        
        #region SMS Service
        private void Send_Message(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_op_name)
        {
            try
            {
                                                
                DataTable dt_ret = get_dev_info(arg_factory, arg_lot_no, arg_lot_seq);

                string arg_sms_msg = arg_op_name + "-" + dt_ret.Rows[0].ItemArray[2].ToString().Replace(" ", "");
                string dev_name = dt_ret.Rows[0].ItemArray[0].ToString();
                string phone_num = dt_ret.Rows[0].ItemArray[1].ToString().Replace(" ", "");

                INSERT_SMS_DATA(arg_op_name, dev_name, phone_num, arg_sms_msg, "");

                //Option Service
                string opt_1_sabun = dt_ret.Rows[0].ItemArray[3].ToString().Replace(" ", "");

                if (!opt_1_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_1_sabun);
                    string name_01  = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
 
                }

                string opt_2_sabun = dt_ret.Rows[0].ItemArray[4].ToString().Replace(" ", "");

                if (!opt_2_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_2_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }

                string opt_3_sabun = dt_ret.Rows[0].ItemArray[5].ToString().Replace(" ", "");

                if (!opt_3_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_3_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }
                //----------------------new-------------------------
                string opt_4_sabun = dt_ret.Rows[0].ItemArray[7].ToString().Replace(" ", "");

                if (!opt_4_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_4_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }
                string opt_5_sabun = dt_ret.Rows[0].ItemArray[8].ToString().Replace(" ", "");

                if (!opt_5_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_5_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }
                string opt_6_sabun = dt_ret.Rows[0].ItemArray[9].ToString().Replace(" ", "");

                if (!opt_6_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_6_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }
                string opt_7_sabun = dt_ret.Rows[0].ItemArray[10].ToString().Replace(" ", "");

                if (!opt_7_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_7_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }
                string opt_8_sabun = dt_ret.Rows[0].ItemArray[11].ToString().Replace(" ", "");

                if (!opt_8_sabun.Equals("000000000"))
                {
                    DataTable dt_huser = get_huser_info(COM.ComVar.This_Factory, opt_8_sabun);
                    string name_01 = dt_huser.Rows[0].ItemArray[0].ToString();
                    string phone_01 = dt_huser.Rows[0].ItemArray[1].ToString();

                    INSERT_SMS_DATA(arg_op_name, name_01, phone_01, arg_sms_msg, "");
                }

            /*************************************************************************************
             ************************Send SMS to CE Team***************************************
             ***********************************************************************************/
                //INSERT_SMS_DATA(arg_op_name, "HM.LIM", "0909541158", arg_sms_msg, "");   


                //INSERT_SMS_DATA(arg_op_name, "HM.LIM", "0909541158", arg_sms_msg, "");
                //INSERT_SMS_DATA(arg_op_name, "Billy.Kim", "0902887485", arg_sms_msg, "");
                //INSERT_SMS_DATA(arg_op_name, "BJ. KIM", "0902709429", arg_sms_msg, "");
                //INSERT_SMS_DATA(arg_op_name, "SH.Kang", "0955676800", arg_sms_msg, "");               

                
            }
            catch
            {
 
            }
        }

        private DataTable get_dev_info(string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.GET_DEV_INFO";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_lot_no;
            MyOraDB.Parameter_Values[2] = arg_lot_seq;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private DataTable get_huser_info(string arg_factory, string arg_user_sabun)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.GET_HUSER_INFO";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_USER_SABUN";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_user_sabun;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private DataTable get_nike_info(string arg_factory, string arg_com_seq)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.GET_NIKE_INFO";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_COM_SEQ";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_com_seq;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private void INSERT_SMS_DATA(string arg_subject, string arg_dev_name, string arg_phone, string arg_sms_msg, string arg_call_back)
        {
            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE¸í
            MyOraDB.Process_Name = "PKG_SXG_PROD_01.INSERT_SDK_SEND_MSG_02";

            //02.ARGURMENT¸í
            MyOraDB.Parameter_Name[0] = "ARG_SUBJECT";
            MyOraDB.Parameter_Name[1] = "ARG_DEV_NAME";
            MyOraDB.Parameter_Name[2] = "ARG_PHONE_NO";
            MyOraDB.Parameter_Name[3] = "ARG_SMS_MSG";
            MyOraDB.Parameter_Name[4] = "ARG_CALL_BACK";
            
            //03. DATA TYPE Á¤ÀÇ
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
           
            //04. DATA Á¤ÀÇ
            MyOraDB.Parameter_Values[0] = arg_subject;
            MyOraDB.Parameter_Values[1] = arg_dev_name;
            MyOraDB.Parameter_Values[2] = arg_phone;
            MyOraDB.Parameter_Values[3] = arg_sms_msg;
            MyOraDB.Parameter_Values[4] = arg_call_back;
            
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }       
        #endregion        
    }
}

