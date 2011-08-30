using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Plan
{
    public partial class Pop_Create_Lot : COM.PCHWinForm.Pop_Large_B
    {

        private COM.OraDB OraDB = new COM.OraDB();
        private COM.ComFunction comfunction = new COM.ComFunction();
        private int _RowFixed;
        private string dateType = "yyyyMMdd";


        private string arg_factory = "";
        private string arg_sr_no = "";
        private string arg_srf_no = "";
        private string arg_bom_id = "";
        private string arg_nf_cd = "";
        private string arg_upload_user = "";


        public Pop_Create_Lot()
        {
            InitializeComponent();
        }


        public Pop_Create_Lot(string _factory, string _sr_no, string _srf_no, string _bom_id, string arg_bom_rev, string _nf_cd, string _upload_user)
        {
            InitializeComponent();


            arg_factory = _factory;
            arg_sr_no = _sr_no;
            arg_srf_no = _srf_no;
            arg_bom_id = _bom_id;
            arg_nf_cd = _nf_cd;
            arg_upload_user = _upload_user;
        }

        private void Pop_Create_Lot_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            //COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
        {


            this.Text = "PCC_Create Lot For Production";
            this.lbl_MainTitle.Text = "PCC_Create Lot For Production";
            ClassLib.ComFunction.SetLangDic(this);

            //			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            //			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            //			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;


            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_c_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_c_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;


            dt_ret = Select_sdc_pj_tail_season();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_season.SelectedIndex = 0;

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_c_season, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_c_season.SelectedIndex = 0;

            dt_ret = dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_c_category, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
            cmb_c_category.SelectedIndex = 0;

            dt_ret = Select_sdc_nf_desc();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_sampletype.SelectedIndex = 0;


            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_c_nf_cd, 0, 2, false, COM.ComVar.ComboList_Visible.Name);
            cmb_c_nf_cd.SelectedIndex = 0;



            dt_ret = Select_sdc_nf_desc_option();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_c_nf_cd_option, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_c_nf_cd_option.SelectedIndex = -1;



            dt_ret = Select_sdd_srf_loaduser();

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;


            fgrid_lot.Set_Grid_CDC("SXE_RECV_LOT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_lot.Set_Action_Image(img_Action);
            fgrid_lot.ExtendLastCol = false;
            _RowFixed = fgrid_lot.Rows.Fixed;


            txt_bomid.Focus();



            if(!arg_factory.Equals(""))
            {
                cmb_factory.SelectedValue = arg_factory;
                txt_sr_no.Text = arg_sr_no;
                txt_srfno.Text = arg_srf_no;
                txt_bomid.Text = arg_bom_id;
                cmb_sampletype.SelectedValue = arg_nf_cd;
                cmb_user.SelectedValue = arg_upload_user;

                btn_sch_Click(null, null);
            }



        }



        private void cmb_c_nf_cd_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cmb_c_nf_cd.SelectedIndex == 0) return;

            DataTable  dt_ret;

            dt_ret = Select_sdc_nf_desc_option();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_c_nf_cd_option,false, 0, 2,0,140);
           // ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_c_nf_cd_option, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
            //cmb_c_nf_cd_option.SelectedIndex = 0;
        }






        private DataTable Select_sdd_srf_loaduser()
        {
            string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXD_SRF_LOADUSER";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_sdc_nf_desc()
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



        private DataTable Select_sdc_nf_desc_option()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC_OPTION";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_nf_cd";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_c_nf_cd, " ");
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }




        



        private DataTable Select_sdc_pj_tail_season()
        {
            string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_source_bom()
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.SELECT_SOURCE_BOM";

            OraDB.ReDim_Parameter(11);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_NF_CD";
            OraDB.Parameter_Name[5] = "ARG_CATEGORY";
            OraDB.Parameter_Name[6] = "ARG_SEASON_CD";
            OraDB.Parameter_Name[7] = "ARG_STYLE_CD";
            OraDB.Parameter_Name[8] = "ARG_STYLE_NAME";
            OraDB.Parameter_Name[9] = "ARG_LOAD_UPD_USER";
            OraDB.Parameter_Name[10] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[10] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_sr_no.Text.Trim().ToUpper();
            OraDB.Parameter_Values[2] = txt_srfno.Text.Trim().ToUpper();
            OraDB.Parameter_Values[3] = txt_bomid.Text.Trim().ToUpper();
            OraDB.Parameter_Values[4] = cmb_sampletype.SelectedValue.ToString();
            OraDB.Parameter_Values[5] = cmb_category.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = cmb_season.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = txt_stylecode.Text.Trim();
            OraDB.Parameter_Values[8] = txt_stylename.Text.Trim().ToUpper();
            OraDB.Parameter_Values[9] = cmb_user.SelectedValue.ToString();
            OraDB.Parameter_Values[10] = "";



            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        private DataTable Save_lot()
        {
            string Proc_Name = "PKG_SXG_MPS_01.SAVE_LOT";

            OraDB.ReDim_Parameter(31);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "ARG_BOM_ID";
            OraDB.Parameter_Name[3] = "ARG_BOM_REV";
            OraDB.Parameter_Name[4] = "ARG_NF_CD";

            OraDB.Parameter_Name[5] = "ARG_S_FACTORY";
            OraDB.Parameter_Name[6] = "ARG_S_SR_NO";
            OraDB.Parameter_Name[7] = "ARG_S_SRF_NO";
            OraDB.Parameter_Name[8] = "ARG_S_BOM_ID";
            OraDB.Parameter_Name[9] = "ARG_S_BOM_REV";

            OraDB.Parameter_Name[10] = "ARG_S_NF_CD";
            OraDB.Parameter_Name[11] = "ARG_CATEGORY";
            OraDB.Parameter_Name[12] = "ARG_SEASON_CD";
            OraDB.Parameter_Name[13] = "ARG_STYLE_CD";
            OraDB.Parameter_Name[14] = "ARG_STYLE_NAME";

            OraDB.Parameter_Name[15] = "ARG_ORD_YMD";
            OraDB.Parameter_Name[16] = "ARG_NEED_BY";
            OraDB.Parameter_Name[17] = "ARG_ETS";
            OraDB.Parameter_Name[18] = "ARG_LOT_QTY";
            OraDB.Parameter_Name[19] = "ARG_LOSS_QTY";

            OraDB.Parameter_Name[20] = "ARG_WHQ_PLM";
            OraDB.Parameter_Name[21] = "ARG_WHQ_DEV";
            OraDB.Parameter_Name[22] = "ARG_NLO_DEV";
            OraDB.Parameter_Name[23] = "ARG_CDC_DEV";
            OraDB.Parameter_Name[24] = "ARG_CDC_DEV_SABUN";

            OraDB.Parameter_Name[25] = "ARG_CDC_DEV_NAME";
            OraDB.Parameter_Name[26] = "ARG_COLOR_VER";
            OraDB.Parameter_Name[27] = "ARG_LOAD_UPD_USER";
            OraDB.Parameter_Name[28] = "ARG_SIZE_CD";
            OraDB.Parameter_Name[29] = "ARG_UPD_USER";
            OraDB.Parameter_Name[30] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[13] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[14] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[15] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[16] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[17] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[18] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[19] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[20] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[21] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[22] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[23] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[24] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[25] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[26] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[27] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[28] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[29] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[30] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_c_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_c_srf_no.Text.Trim().ToUpper();
            OraDB.Parameter_Values[2] = txt_c_bom_id.Text.Trim().ToUpper();
            OraDB.Parameter_Values[3] = txt_c_bom_rev.Text.Trim().ToUpper();
            OraDB.Parameter_Values[4] = cmb_c_nf_cd_option.SelectedValue.ToString(); 
            OraDB.Parameter_Values[5] = txt_s_factory.Text;
            OraDB.Parameter_Values[6] = txt_s_sr_no.Text;
            OraDB.Parameter_Values[7] = txt_s_srf_no.Text;
            OraDB.Parameter_Values[8] = txt_s_bom_id.Text;
            OraDB.Parameter_Values[9] = txt_s_bom_rev.Text;
            OraDB.Parameter_Values[10] = cmb_c_nf_cd.SelectedValue.ToString();
            OraDB.Parameter_Values[11] = cmb_c_category.SelectedValue.ToString();
            OraDB.Parameter_Values[12] = cmb_c_season.SelectedValue.ToString();
            OraDB.Parameter_Values[13] = txt_c_style_code.Text.Trim().ToUpper();
            OraDB.Parameter_Values[14] = txt_c_style_name.Text.Trim().ToUpper();
            OraDB.Parameter_Values[15] = dpk_c_ord_ymd.Value.ToString("yyyyMMdd");
            OraDB.Parameter_Values[16] = dpk_c_need_by.Value.ToString("yyyyMMdd");
            OraDB.Parameter_Values[17] = dpk_c_ets.Value.ToString("yyyyMMdd");
            OraDB.Parameter_Values[18] = txt_c_lot_qty.Text.Trim().ToUpper();
            OraDB.Parameter_Values[19] = txt_c_loss_qty.Text.Trim().ToUpper();
            OraDB.Parameter_Values[20] = txt_c_whq_plm.Text.Trim();
            OraDB.Parameter_Values[21] = txt_c_whq_dev.Text.Trim();
            OraDB.Parameter_Values[22] = txt_c_nlo_dev.Text.Trim();
            OraDB.Parameter_Values[23] = txt_c_cdc_dev.Text.Trim();
            OraDB.Parameter_Values[24] = txt_c_dev_sabun.Text.Trim().ToUpper();
            OraDB.Parameter_Values[25] = txt_c_dev_name.Text.Trim();
            OraDB.Parameter_Values[26] = txt_c_color_ver.Text.Trim();
            OraDB.Parameter_Values[27] = txt_c_upload_user.Text.Trim();
            OraDB.Parameter_Values[28] = txt_c_size_cd.Text.Trim();
            OraDB.Parameter_Values[29] = COM.ComVar.This_User;
            OraDB.Parameter_Values[30] = "";



            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private void btn_sch_Click(object sender, EventArgs e)
        {
            fgrid_lot.Rows.Count = _RowFixed;
            DataTable dt = Select_source_bom();
            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;
            if (dt_rows > 0)
            {
                for (int i = 0; i < dt_rows; i++)
                {
                    fgrid_lot.AddItem(dt.Rows[i].ItemArray, fgrid_lot.Rows.Count, 0);
                }
            }
        }

        private void fgrid_lot_DoubleClick(object sender, EventArgs e)
        {
            int sct_row = fgrid_lot.Selection.r1;
            int sct_col = fgrid_lot.Selection.c1;


            if (sct_row >= _RowFixed)
            {
                cmb_c_factory.SelectedValue = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxFACTORY].ToString();
                txt_c_srf_no.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxSRF_NO].ToString();
                txt_c_bom_id.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxBOM_ID].ToString();
                txt_c_bom_rev.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxBOM_REV].ToString();
                cmb_c_nf_cd.SelectedValue = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxNF_CD].ToString();

                txt_s_factory.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxS_FACTORY].ToString();
                txt_s_sr_no.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxS_SR_NO].ToString();
                txt_s_srf_no.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxS_SRF_NO].ToString();
                txt_s_bom_id.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxS_BOM_ID].ToString();
                txt_s_bom_rev.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxBOM_REV].ToString();
                txt_s_nf_cd.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxS_NF_CD].ToString();

                cmb_c_category.SelectedValue = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxCATEGORY].ToString();
                cmb_c_season.SelectedValue = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxSEASON_CD].ToString();
                txt_c_style_code.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxSTYLE_CD].ToString();
                txt_c_style_name.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxSTYLE_NAME].ToString();



                cmb_sampletype.Enabled = false;
                
                dpk_c_ord_ymd.CustomFormat = dateType;
                try
                {
                    dpk_c_ord_ymd.Text = comfunction.ConvertDate2Type(fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxORD_YMD].ToString());
                }
                catch
                {
                    dpk_c_ord_ymd.Text = "";
                }

                dpk_c_need_by.CustomFormat = dateType;

                try
                {
                    dpk_c_need_by.Text = comfunction.ConvertDate2Type(fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxNEED_BY].ToString());
                }
                catch
                {
                    dpk_c_need_by.Text = "";
                }

                dpk_c_ets.CustomFormat = dateType;

                try
                {
                    dpk_c_ets.Text = comfunction.ConvertDate2Type(fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxETS].ToString());
                }
                catch
                {
                    dpk_c_ets.Text = "";
                }

                txt_c_lot_qty.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxLOT_QTY].ToString();
                txt_c_loss_qty.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxLOSS_QTY].ToString();

                txt_c_whq_plm.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxWHQ_PLM].ToString();
                txt_c_whq_dev.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxWHQ_DEV].ToString();
                txt_c_nlo_dev.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxNLO_DEV].ToString();
                txt_c_cdc_dev.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxCDC_DEV].ToString();
                txt_c_dev_sabun.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxCDC_DEV_SABUN].ToString();
                txt_c_dev_name.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxCDC_DEV_NAME].ToString();
                txt_c_color_ver.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxCOLOR_VER].ToString();
                txt_c_upload_user.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxLOAD_UPD_USER].ToString();
                txt_c_size_cd.Text = fgrid_lot[sct_row, (int)ClassLib.TBSXE_RECV_LOT.IxSIZE_CD].ToString();


                txt_lot_no.Text = "----------";
                txt_lot_seq.Text = "--";
            }

        }

        private void btn_crt_Click(object sender, EventArgs e)
        {
                
            if (dpk_c_ets.CustomFormat == " ")
            {
                ClassLib.ComFunction.User_Message("Input Error : ETC", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dpk_c_need_by.Focus();
                return;
            }


            if (cmb_c_nf_cd_option.SelectedValue==null)
            {
                ClassLib.ComFunction.User_Message("Input Error : Sample Type - Option ", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_c_nf_cd_option.Focus();
                return;
            }

            //else if (!dpk_c_ets.Value.CompareTo(DateTime.Now.AddDays(-1)).Equals(1))
            //{
            ////    ClassLib.ComFunction.User_Message("Input Error : ETC be earlier more then today", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    dpk_c_ets.Focus();
            ////    return;
            //}





            DataTable dt = Save_lot();
            txt_lot_no.Text = dt.Rows[0].ItemArray[1].ToString();
            txt_lot_seq.Text = dt.Rows[0].ItemArray[2].ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            txt_s_factory.Text = "";
            txt_s_sr_no.Text = "";
            txt_s_bom_id.Text = "";
            txt_s_bom_rev.Text = "";
            txt_s_nf_cd.Text = "";


            DataTable dt = Save_lot();
            txt_lot_no.Text = dt.Rows[0].ItemArray[1].ToString();
            txt_lot_seq.Text = dt.Rows[0].ItemArray[2].ToString();
        }

        private void cmb_c_nf_cd_option_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_c_nf_cd_option.SelectedValue == null) return;
            txt_s_nf_c_option.Text = cmb_c_nf_cd_option.SelectedValue.ToString();

        }


       


    }
}