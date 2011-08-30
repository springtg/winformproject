using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;


namespace FlexCDC.CDC_Bom
{
    public partial class Form_Bom_Editor_New : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction comfunction = new COM.ComFunction();
        private string _form_type = "I";
        private string _file_type = "";
        private string dateType = "yyyyMMdd";
        private string _cs_gend = "";

        #region CSV File Head값 변수 지정
        public string _head_factory = null;
        public string _head_sr_no   = null;
        public string _head_srf_no  = null;
        public string _head_bom_id  = null;
        public string _head_bom_rev = null;

        public string _head_nf_cd     = null;
        public string _head_srf_seq   = null;
        public string _head_bom_state = null;
        public string _head_requestor = null;
        public string _head_ord_ymd   = null;

        public string _head_need_by  = null;
        public string _head_ets      = null;
        public string _head_mo_alias = null;
        public string _head_whq_plm  = null;
        public string _head_whq_dev  = null;

        public string _head_nlo_dev        = null;
        public string _head_silhouette     = null;
        public string _head_technology     = null;
        public string _head_lasting_method = null;
        public string _head_ms_method      = null;

        public string _head_sole_laying_method = null;
        public string _head_mto_account_name   = null;
        public string _head_bom_comment        = null;
        public string _head_factory_dv         = null;
        public string _head_sesn               = null;

        public string _head_pattern      = null;
        public string _head_last_cd      = null;
        public string _head_dev_name     = null;
        public string _head_mtl_ver      = null;
        public string _head_color_ver    = null;
        public string _head_sample_types = null;

        public string _head_sta          = null;
        public string _head_current_ipw  = null;
        public string _head_product_code = null;
        public string _head_pur_flg      = null;
        public string _head_style_cd     = null;

        public string _head_remarks       = null;
        public string _head_status        = null;
        public string _head_load_upd_user = null;
        public string _head_load_upd_ymd  = null;
        public string _head_upd_user      = null;
        public string _head_upd_ymd       = null;

        public string _head_size   = null;
        public string _head_gender = null;

        public string _head_dm_bom_flg     = null;
        public string _head_prod_ext_color = null;
        public string _head_pcc_factory    = null;
        public string _head_ss_factory     = null;
        public string _head_p_prod_factory = null;
        public string _head_s_prod_factory = null;

        public string _head_td_code = null;
        #endregion

        #region XML File Head값 변수 지정

        //Sample Request
        private string xml_samplerequest_id           = "";
        private string xml_samplerequest_type         = "";
        private string xml_samplerequest_state        = "";
        private string xml_requestor                  = "";
        private string xml_orderdate                  = "";
        private string xml_needbydate                 = "";
        private string xml_estdate                    = "";
        private string xml_samplerequest_instructions = "";
        private string xml_pattern_id                 = "";
        private string xml_modelid                    = "";
        private string xml_modelname                  = "";
        private string xml_devproj_alias              = "";
        private string xml_devproj_id                 = "";
        private string xml_season                     = "";
        private string xml_tdcode                     = "";
        private string xml_factorydirect              = "";
        private string xml_pccfcty                    = "";
        private string xml_ssfcty                     = "";
        private string xml_primprodfcty               = "";
        private string xml_secprodfcty                = "";
        private string xml_whqdeveloper               = "";
        private string xml_nlodeveloper               = "";
        private string xml_plm                        = "";
        private string xml_biz_org                    = "";
        private string xml_consumer_purpose           = "";
        private string xml_consumer_focus             = "";
        private string xml_consumer_use               = "";

        //Sample Request Destination
        private string xml_samplerequest_dest         = "";

        //Sample Request Lineitem
        private string xml_lineitem_id                = "";
        private string xml_samplerequest_gender       = "";
        private string xml_samplerequest_size         = "";
        private string xml_samplerequest_width        = "";
        private string xml_samplerequest_fit          = "";
        private string xml_samplerequest_age          = "";
        private string xml_samplerequest_attentionto  = "";
        private string xml_samplerequest_side         = "";
        private string xml_samplerequest_quantity     = "";
                                                      
        //BOM Information                             
        private string xml_bom_id                     = "";
        private string xml_bom_rev                    = "";
        private string xml_bom_state                  = "";
        private string xml_bom_dimension              = "";
        private string xml_bom_silhouette             = "";
        private string xml_bom_platform               = "";
        private string xml_bom_lastcode               = "";
        private string xml_bom_lastdim                = "";
        private string xml_bom_method                 = "";
        private string xml_bom_midsolemethod          = "";
        private string xml_bom_solemethod             = "";
        private string xml_bom_materialversion        = "";
        private string xml_bom_colorversion           = "";
        private string xml_bom_comments               = "";
        private string xml_bom_prodcolorextabbrv      = "";
        private string xml_bom_productcode            = "";
        private string xml_productid                  = "";
        private string xml_bom_inlinesizerange        = "";
        private string xml_bom_promosizerange         = "";
        private string xml_bom_currentipw             = "";
                                                      
        //Costing Material                            
        private string xml_costingmaterial_name       = "";
        private string xml_costingmaterial_type       = "";
        private string xml_costingmaterial_dutycode   = "";
        private string xml_costingmaterial_tfob       = "";
                                                      
        //Rule                                        
        private string xml_globalexclusive_type       = "";
        private string xml_globalexclusive_to         = "";
        private string xml_initiating_region          = "";
        private string xml_initiatingexclusive_type   = "";
        private string xml_initiatingexclusive_to     = "";
                                                      
        //BOM Lineitem                                
        private string xml_bom_partnumber             = "";
        private string xml_bom_partname               = "";
        private string xml_bom_parttype               = "";
        private string xml_bom_partquantity           = "";
        private string xml_bom_partcomment            = "";
        private string xml_bom_colorid                = "";
        private string xml_bom_colorname              = "";
        private string xml_bom_colorcomment           = "";
        private string xml_material_name              = "";
        private string xml_material_number            = "";
        private string xml_mcs_number                 = "";
        private string xml_mxs_number                 = "";
        private string xml_bom_materialcoment         = "";
        private string xml_supplier_name              = "";
                                                      
        //Airbag                                      
        private string xml_airbag_number              = "";
        private string xml_airbag_name                = "";
        private string xml_airbag_size                = "";
        private string xml_airbag_min                 = "";
        private string xml_airbag_max                 = "";
        private string xml_airbag_state               = "";
                                                      
        //Box                                         
        private string xml_box_number                 = "";
        private string xml_box_name                   = "";
        private string xml_box_size                   = "";
        private string xml_box_min                    = "";
        private string xml_box_max                    = "";
        private string xml_box_state                  = "";
                                                      
        //Lace                                        
        private string xml_lace_number                = "";
        private string xml_lace_name                  = "";
        private string xml_lace_type                  = "";
        private string xml_lace_length                = "";
        private string xml_lace_min                   = "";
        private string xml_lace_max                   = "";
        private string xml_lace_state                 = "";
        #endregion                                    

        private bool warning_chk = false;
        private string csv_type = "D";//D BOM, E BOM구분
        #endregion

        #region 생성자
        public Form_Bom_Editor_New()
        {
            InitializeComponent();
        }
        public Form_Bom_Editor_New(string arg_form_mode, string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
        {
            InitializeComponent();

            _form_type    = arg_form_mode;

			_head_factory = arg_factory;
			_head_sr_no   = arg_sr_no;
			_head_srf_no  = arg_srf_no;
			_head_bom_id  = arg_bom_id;
			_head_bom_rev = arg_bom_rev;
			_head_nf_cd   = arg_nf_cd;			
        }
        #endregion

        #region Form Loading
        private void Form_Bom_Editor_New_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;                                
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();

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
            this.Text = "PCC_Update New Bom";
            this.lbl_MainTitle.Text = "PCC_Update New Bom";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Control();
            Init_Grid();
        }
        private void Init_Grid()
        {            
            if (_form_type.Equals("I"))
            {
                #region BOM을 Uploading 할때
                fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL_LOAD", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_detail.Set_Action_Image(img_Action);
                fgrid_detail.Font = new Font("Verdana", 8);                
                fgrid_detail.Styles.Normal.WordWrap = true;

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER_LOAD", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);                
                fgrid_order.Styles.Normal.WordWrap = true;

                fgrid_desc.Set_Grid_CDC("SXD_SRF_DESC", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_desc.Set_Action_Image(img_Action);
                fgrid_desc.ExtendLastCol = false;
                fgrid_desc.AutoSizeCols();

                fgrid_vendor.Set_Grid_CDC("SXD_SRF_VENDOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_vendor.Set_Action_Image(img_Action);
                fgrid_vendor.ExtendLastCol = false;

                fgrid_rule.Set_Grid_CDC("SXD_SRF_RULE_LOAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_rule.Set_Action_Image(img_Action);
                fgrid_rule.Font = new Font("Verdana", 8);
                fgrid_rule.Styles.Normal.WordWrap = true;
                fgrid_rule.ExtendLastCol = false;            
                #endregion
            }
            else if (_form_type.Equals("S"))
            {
                #region Select BOM에서 데이터를 불러왔을때
                if (ClassLib.ComVar.This_CDCGroup_Code == "DEV")
                {
                    fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL", "6", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_detail.Set_Action_Image(img_Action);
                    fgrid_detail.Font = new Font("Verdana", 8);                    
                    fgrid_detail.Styles.Normal.WordWrap = true;
                    fgrid_detail.Tree.Column = (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ;
                    fgrid_detail.AllowEditing = true;
                }
                else
                {
                    fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_detail.Set_Action_Image(img_Action);
                    fgrid_detail.Font = new Font("Verdana", 8);                    
                    fgrid_detail.Styles.Normal.WordWrap = true;
                    fgrid_detail.Tree.Column = (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ;
                    fgrid_detail.AllowEditing = true;
                }

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);                
                fgrid_order.Styles.Normal.WordWrap = true;
                fgrid_order.Tree.Column = (int)ClassLib.TBSXD_SRF_ORDER.IxSRF_SEQ;
                fgrid_order.AllowEditing = true;

                fgrid_desc.Set_Grid_CDC("SXD_SRF_DESC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_desc.Set_Action_Image(img_Action);
                fgrid_desc.ExtendLastCol = false;
                fgrid_desc.AutoSizeCols();

                fgrid_vendor.Set_Grid_CDC("SXD_SRF_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_vendor.Set_Action_Image(img_Action);
                fgrid_vendor.ExtendLastCol = false;
                fgrid_vendor.AllowEditing = true;

                fgrid_rule.Set_Grid_CDC("SXD_SRF_RULE_LOAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_rule.Set_Action_Image(img_Action);
                fgrid_rule.Font = new Font("Verdana", 8);
                fgrid_rule.Styles.Normal.WordWrap = true;
                fgrid_rule.ExtendLastCol = false;
                #endregion
            }            
        }
        private void Init_Control()
        {
            #region ComboBox Setting
            //Sample Types
            DataTable dt_ret = SELECT_SAMPLE_TYPES();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletypes, 0, 1, false, 0, 120);

            //T_D
            dt_ret = SELECT_TD_LIST();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_td, 0, 1, false, 0, 120);

            //Gendor
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender, 1, 2, false, 0, 120);
            #endregion

            #region Color Information Setting
            lbl_part.BackColor   = Color.Red;
            lbl_mrp.BackColor    = Color.Orange;
            lbl_pend.BackColor   = Color.FromArgb(245, 173, 173);
            lbl_delete.BackColor = Color.FromArgb(110, 110, 110);
            #endregion
            
            if (_form_type.Equals("I"))
            {
                #region BOM을 Uploading 할때
                //File Loading
                lbl_srfpath.Visible = true;
                txt_Path.Visible    = true;
                lbl_level.Visible   = false;
                cmb_level.Visible   = false;
                txt_Path.Text = "";

                //Head Top
                cmb_factory.Enabled        = true;              
                cmb_sampletypes.Enabled    = true;
                txt_model_name.Enabled     = true;               
                dtp_order_date.Enabled     = true;
                dtp_need_by.Enabled        = true;
                dtp_ets.Enabled            = true;               
                txt_style_cd.Enabled       = true;
                cmb_gender.Enabled         = true;
                cmb_td.Enabled             = true;

                //Head Middle
                dtp_current_ipw.Enabled    = true;

                //Tbtn Button
                tbtn_Append.Enabled  = false;
                tbtn_Color.Enabled   = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Delete.Enabled  = false;
                tbtn_Insert.Enabled  = false;
                tbtn_New.Enabled     = false;
                tbtn_Print.Enabled   = false;
                tbtn_Save.Enabled    = true;
                tbtn_Search.Enabled  = false;
                tbtn_Create.Enabled  = false; 
                #endregion                
            }
            else if (_form_type.Equals("S"))
            {
                #region Select BOM에서 데이터를 불러왔을때
                lbl_srfpath.Visible = false;
                txt_Path.Visible    = false;
                lbl_level.Visible   = true;
                cmb_level.Visible   = true;

                lbl_srfpath.Visible = false;
                txt_Path.Visible    = false;

                tbtn_Create.Enabled  = false;
                tbtn_Append.Enabled  = false;
                tbtn_Color.Enabled   = false;
                tbtn_Confirm.Enabled = true;
                tbtn_Delete.Enabled  = false;
                tbtn_Insert.Enabled  = false;
                tbtn_New.Enabled     = false;
                tbtn_Print.Enabled   = true;
                tbtn_Save.Enabled    = true;
                tbtn_Search.Enabled  = true;

                cmb_level.Visible  = true;
                cmb_gender.Enabled = false;

                txt_srfno.Enabled          = false;
                txt_bomid.Enabled          = false;
                txt_bomrev.Enabled         = false;
                txt_srno.Enabled           = false;
                txt_factory_direct.Enabled = false;
                txt_season.Enabled         = false;
                cmb_gender.Enabled         = false;
                txt_state.Enabled          = false;


                txt_mtl_ver.ReadOnly  = true;
                txt_colo_ver.ReadOnly = true;
                txt_patten.ReadOnly   = true;

                dtp_ets.Enabled         = false;
                dtp_need_by.Enabled     = false;
                dtp_current_ipw.Enabled = false;
                #endregion
            }
                
            pnl_bottom.Height = 0;
            srf_rule.Hide();            
        }

        private DataTable SELECT_SAMPLE_TYPES()
        {            
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC_LOAD";

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
        private DataTable SELECT_TD_LIST()
        {            
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_TD_LIST";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region BOM File Loading
        private void btn_open_file_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                if (!Get_file_type()) return;

                Clear_Control();
                fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;
                fgrid_desc.Rows.Count   = fgrid_desc.Rows.Fixed;                
                fgrid_order.Rows.Count  = fgrid_order.Rows.Fixed;
                fgrid_vendor.Rows.Count = fgrid_vendor.Rows.Fixed;
                fgrid_rule.Rows.Count   = fgrid_rule.Rows.Fixed;
                
                if (_form_type == "S")
                {
                    _form_type = "I";
                    Init_Control();
                    Init_Grid();
                }

                if (_file_type.Equals("csv"))
                {
                    CSV_BOM_Reader();
                }
                else if (_file_type.Equals("xml"))
                {
                    XML_BOM_Reader(); 
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
        private void Clear_Control()
        {
            txt_srno.Clear();
            txt_srfno.Clear();
            txt_bomid.Clear();
            txt_bomrev.Clear();
            cmb_sampletypes.SelectedIndex = -1;
            cmb_sampletypes.Text = "";
            txt_model_name.Clear();
            txt_mo_id.Clear();
            txt_factory_direct.Clear();
            txt_state.Clear();
            txt_requestor.Clear();
            dtp_order_date.Value = DateTime.Now;
            dtp_need_by.Value    = DateTime.Now;
            dtp_ets.Value        = DateTime.Now;
            txt_patten.Clear();
            txt_style_cd.Clear();
            cmb_gender.SelectedIndex = -1;
            cmb_gender.Text = "";
            cmb_td.SelectedIndex = -1;
            cmb_td.Text = "";

            txt_bom_state.Clear();
            txt_silhouette.Clear();
            txt_technology.Clear();
            txt_model_name_bom.Clear();
            txt_lasting_method.Clear();
            txt_ms_method.Clear();
            txt_sole_laying_method.Clear();
            txt_last_cd.Clear();
            txt_product_code.Clear();
            dtp_current_ipw.Value = DateTime.Now;
            txt_mo_alias.Clear();
            txt_season.Clear();
            txt_mto_account_name.Clear();
            txt_whq_plm.Clear();
            txt_whq_dev.Clear();
            txt_nlo_dev.Clear();
            txt_mtl_ver.Clear();
            txt_colo_ver.Clear();
            txt_bom_comments.Clear();

            txt_sr_instruction.Clear();
            txt_demension.Clear();
            txt_platform.Clear();
            txt_last_dim.Clear();
            txt_bom_method.Clear();
            txt_prod_id.Clear();
            txt_inline_size.Clear();
            txt_promo_size.Clear();
            txt_costmat_name.Clear();
            txt_costmat_type.Clear();
            txt_costmat_duty.Clear();
            txt_costmat_tfob.Clear();            
            txt_devproj_id.Clear();
            txt_td_code.Clear();
            txt_plm.Clear();
            txt_biz_org.Clear();
            txt_cons_purpose.Clear();
            txt_cons_focus.Clear();
            txt_cons_use.Clear();
            txt_pcc_factory.Clear();
            txt_ss_factory.Clear();
            txt_p_prod_fact.Clear();
            txt_s_prod_fact.Clear();
            txt_extra_color.Clear();
        }
        private bool Get_file_type()
        {
            openFileDialog.InitialDirectory = "";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {                
                return false;
            }

            txt_Path.Text = openFileDialog.FileName;

            int point_position = txt_Path.Text.Trim().Length - 3;
            _file_type = txt_Path.Text.Trim().ToLower().Substring(point_position);

            if (_file_type != "xls" && _file_type != "csv" && _file_type != "xml") return false;
                        
            return true;
        }

        #region CSV File Loading
        private void CSV_BOM_Reader()
        {
            FileInfo file_scv = new FileInfo(txt_Path.Text.Trim());

            if (file_scv.Exists)
            {
                #region Bom 파일 읽기
                FileStream file = null;
                StreamReader sr = null;
                try
                {
                    file = new FileStream(file_scv.Name, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(file);
                }
                catch
                {
                    ClassLib.ComFunction.User_Message("Close CSV File", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string NextLine;
                char char_div   = '"';
                string div      = ",";
                string col_div  = null;
                string srf_data = null;


                string group_div = "§";
                string cols_div  = "◈";

                string line_div = "";
                bool part_type  = false;



                while ((NextLine = sr.ReadLine()) != null)
                {
                    #region D BOM 처리 부분
                    if (NextLine != "")
                    {
                        col_div = NextLine.Split(div.ToCharArray())[0].Replace(char_div.ToString(), "").Trim();
                       
                        if (col_div.Equals("########################################") || col_div.Equals("Airbag Schedule") || col_div.Equals("BOX Schedule") || col_div.Equals("Lace Schedule"))
                        {
                            break;
                        }

                        if (col_div.Equals("Sample Request#") || col_div.Equals("State") || col_div.Equals("Line Items") || col_div.Equals("BOM ID"))
                        {
                        }
                        else if (col_div.Equals("Destination") || col_div.Equals("BOM Data")) srf_data += group_div;                        
                        else if (col_div.Equals("SR Line Item ID"))
                        {
                            line_div = cols_div;

                        }
                        else if (col_div.Equals("BOM Data")) srf_data += group_div;
                        else if (col_div.Equals("Part#"))
                        {
                            srf_data += group_div;
                            part_type = true;
                        }
                        else
                        {
                            if (!part_type)
                            {
                                if (line_div.Equals(cols_div))
                                {
                                    srf_data += "$" + NextLine/*.Replace(div.ToString(), "$")*/ + line_div;
                                    line_div = "";
                                }
                                else
                                {
                                    srf_data += NextLine;
                                }
                            }
                            else
                            {                                
                                string part_end = NextLine.Substring(NextLine.Length - 1);
                                char div_1 = '"';

                                if (part_end == "," || part_end == div_1.ToString())
                                {
                                    srf_data += NextLine + "Ψ";
                                }
                                else
                                {
                                    srf_data += NextLine;
                                }
                            }
                        }
                    }
                    #endregion;
                }

                sr.Close();

                #endregion

                string[] srf_part = srf_data.Split(group_div.ToCharArray());

                if (srf_part.Length.Equals(2))          // M- Bom
                {
                    #region head 데이터 가져오기

                    #region Head 정리하기 - Comma

                    string head_line = "";
                    bool check_div   = false;
                    bool check_add   = true;
                    int col_start    = 0, col_end = 0;

                    for (int i = 0; i < srf_part[0].Length; i++)
                    {
                        char div_1 = '"';

                        if (srf_part[0].Substring(i, 1) == div_1.ToString())
                        {
                            if (check_div == false)
                            {
                                check_div = true;
                                check_add = false;
                                col_start = i;
                            }
                            else
                            {
                                check_div = false;
                                check_add = true;
                                col_end   = i;
                                head_line = head_line + srf_part[0].Substring(col_start, col_end - col_start).ToString().Replace(",", "");                                
                            }
                        }

                        if (check_add == true)
                        {
                            head_line = head_line + srf_part[0].Substring(i, 1).ToString();
                        }
                    }

                    string[] head_info = head_line.Replace(char_div.ToString(), "").Split(",".ToCharArray());

                    #endregion                                       

                    _head_factory       = cmb_factory.SelectedValue.ToString();                    
                    _head_nf_cd         = "";
                    _head_status        = "N";
                    _head_load_upd_user = ClassLib.ComVar.This_User;
                    _head_load_upd_ymd  = "";
                    _head_upd_user      = ClassLib.ComVar.This_User;


                    _head_srf_no  = head_info[4].Replace("-", "");
                    _head_bom_id  = head_info[0];
                    _head_bom_rev = (head_info[1].Trim().Length == 0) ? "0" : head_info[1].Trim();

                    //_head_nf_cd         = null;
                    _head_srf_seq   = null;
                    _head_bom_state = head_info[2];
                    _head_requestor = null;
                    _head_ord_ymd   = null;

                    _head_need_by  = null;
                    _head_ets      = null;
                    _head_mo_alias = head_info[4];
                    _head_whq_plm  = head_info[16];
                    _head_whq_dev  = head_info[17];

                    _head_nlo_dev        = head_info[18];
                    _head_silhouette     = head_info[5];
                    _head_technology     = head_info[6];
                    _head_lasting_method = null;
                    _head_ms_method      = null;

                    _head_sole_laying_method = null;
                    _head_mto_account_name   = null;

                    if (head_info.Length == 26)
                        _head_bom_comment = head_info[26].Replace("'", "");
                    else
                        _head_bom_comment = head_info[24].Replace("'", "");
                   
                    _head_sesn         = head_info[10];
                    _head_pattern      = null;
                    _head_last_cd      = head_info[15];
                    _head_dev_name     = head_info[3];
                    _head_mtl_ver      = head_info[19];
                    _head_color_ver    = head_info[20];
                    _head_sample_types = null;                    
                    _head_current_ipw  = head_info[8];
                    _head_product_code = null;
                    _head_pur_flg      = null;
                    _head_style_cd     = (head_info[7].ToString() == "NA") ? "" : head_info[7].Replace("-", "").Substring(0, 9);
                    _head_remarks      = null;                    
                    _head_size         = null;
                    _head_gender       = null;
                    _head_dm_bom_flg   = null;

                    _head_prod_ext_color = head_info[9];
                    _head_factory_dv     = head_info[21];
                    _head_pcc_factory    = head_info[22];
                    _head_ss_factory     = head_info[23];

                    if (head_info.Length == 27)
                    {
                        _head_p_prod_factory = head_info[24];
                        _head_s_prod_factory = head_info[25];
                    }
                    else
                    {
                        _head_p_prod_factory = "NA";
                        _head_s_prod_factory = "NA";
                    }

                    _head_sr_no = SELECT_CREATE_SR_NO(_head_factory, _head_srf_no, _head_bom_id, _head_bom_rev).Rows[0].ItemArray[0].ToString();

                    CSV_Head_data_setting();

                    fgrid_order.Add_Row(fgrid_order.Rows.Count - 1);

                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_NO]   = _head_sr_no;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSRF_NO]  = _head_srf_no;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_ID]  = _head_bom_id;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_REV] = _head_bom_rev;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] = "";
                    _head_size = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_TYPE]     = "NIKE";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_LINE_ITEM] = "0000000000000000000000000";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIDE_TYPE]    = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_QTY]      = "0";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxREQUESTER]    = _head_requestor;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_YMD]      = _head_ord_ymd;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNEED_BY]      = _head_need_by;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxDESTINATION]  = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxGEN_CD]       = head_info[14];
                    //_head_gender = order_line_info[2];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxWIDTH]    = head_info[13];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFIT]      = head_info[12];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxAGE]      = head_info[11];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxATTN]     = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNIKE_FLG] = "N";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSTATUS]   = "N";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;

                    fgrid_order.AutoSizeCols();

                    #region part 데이터 가져오기

                    try
                    {

                        string[] part_info = char_con(srf_part[1].Replace(char_div.ToString(), "^")).Replace("^", "").Split("Ψ".ToCharArray());

                        for (int i = 0; i < part_info.Length - 1; i++)
                        {
                            string[] part_line_info = part_info[i].Split("$".ToCharArray());

                            fgrid_detail.Add_Row(fgrid_detail.Rows.Count - 1);


                            if (!part_line_info.Length.Equals(13) && !part_line_info.Length.Equals(14))
                            {
                                fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxFACTORY,
                                    fgrid_detail.Rows.Count - 1, fgrid_detail.Cols.Count - 1).StyleNew.BackColor = Color.Crimson;

                                warning_chk = true;
                            }
                            if (part_line_info.Length.Equals(14))
                            {
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSR_NO]   = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSRF_NO]  = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_ID]  = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_REV] = _head_bom_rev;

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO]      = part_line_info[0];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE]    = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NAME]    = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_QTY]     = part_line_info[4];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_CD]      = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_DESC]    = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_NAME]    = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_CD]      = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMCS_CD]      = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_COMMENT] = part_line_info[11];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_DESC]    = part_line_info[12];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSTATUS]   = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;

                            }
                            else
                            {
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSR_NO]   = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSRF_NO]  = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_ID]  = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_REV] = _head_bom_rev;

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO]      = part_line_info[0];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE]    = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NAME]    = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_QTY]     = part_line_info[4];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_CD]      = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_DESC]    = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_NAME]    = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_CD]      = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_COMMENT] = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_DESC]    = part_line_info[11];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSTATUS]   = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;
                            }
                        }

                        fgrid_detail.AutoSizeCols();

                        if (warning_chk)
                        {
                            ClassLib.ComFunction.User_Message("Red Color Data maybe have a problem. Please Check Part No..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            warning_chk = false;
                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Part)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion
                    
                    #endregion
                }
                else if (srf_part.Length.Equals(4))    // D- Bom
                {

                    #region head 데이터 가져오기

                    try
                    {

                        string[] head_info = srf_part[0].Replace(char_div.ToString(), "").Split(",".ToCharArray());


                        _head_factory = cmb_factory.SelectedValue.ToString();
                        _head_factory_dv = cmb_factory.SelectedValue.ToString();
                        _head_nf_cd = "";
                        _head_status = "N";
                        _head_load_upd_user = ClassLib.ComVar.This_User;
                        _head_load_upd_ymd = "";
                        _head_upd_user = ClassLib.ComVar.This_User;


                        if (head_info.Length.Equals(13))
                        {
                            _head_sr_no = head_info[0];
                            _head_sample_types = head_info[1];
                            _head_dev_name = head_info[2];
                            _head_srf_no = head_info[3].Replace("-", "");
                            _head_mo_alias = head_info[3];
                            //= head_info[4];
                            _head_sta = head_info[5];
                            _head_requestor = head_info[6];
                            _head_ord_ymd = (head_info[7].Trim().Length > 0) ? DateTime.Parse(head_info[7]).ToString(dateType) : "";//System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
                            _head_need_by = (head_info[8].Trim().Length > 0) ? DateTime.Parse(head_info[8]).ToString(dateType) : "";
                            _head_ets = (head_info[9].Trim().Length > 0) ? DateTime.Parse(head_info[9]).ToString(dateType) : "";
                            _head_pattern = head_info[10];
                            _head_bom_id = head_info[11];
                            _head_bom_rev = (head_info[12].Trim().Length == 0) ? "0" : head_info[12].Trim();

                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(BOM)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {

                        string[] bom_info = char_con(srf_part[2].Replace(char_div.ToString(), "^")).Replace("^", "").Split("$".ToCharArray());

                        if (bom_info.Length.Equals(19))
                        {
                            _head_bom_state = bom_info[0];
                            _head_silhouette = bom_info[1];
                            _head_technology = bom_info[2];
                            //_head_dev_name         = bom_info[3];
                            _head_lasting_method = bom_info[4];
                            _head_ms_method = bom_info[5];
                            _head_sole_laying_method = bom_info[6];
                            _head_last_cd = bom_info[7];
                            _head_product_code = bom_info[8];
                            _head_current_ipw = (bom_info[9].Trim().Length > 0) ? DateTime.Parse(bom_info[9]).ToString(dateType) : "";//= bom_info[9];// DateTime.Parse(bom_info[9]).ToString(dateType);
                            //_head_mo_alias         = bom_info[10].Replace("-","");
                            _head_sesn = bom_info[11];
                            _head_mto_account_name = bom_info[12];
                            _head_whq_plm = bom_info[13];
                            _head_whq_dev = bom_info[14];
                            _head_nlo_dev = bom_info[15];
                            _head_mtl_ver = bom_info[16];
                            _head_color_ver = bom_info[17];
                            _head_bom_comment = bom_info[18];
                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(BOM)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmb_sampletypes.Text = _head_sample_types;







                    #endregion

                    #region order 데이터 가져오기


                    try
                    {
                        string[] order_info = char_con(srf_part[1].Replace(char_div.ToString(), "^")).Replace("^", "").Split(cols_div.ToCharArray());

                        for (int j = 0; j < order_info.Length - 1; j++)
                        {
                            string[] order_line_info = order_info[j].Split("$".ToCharArray());




                            fgrid_order.Add_Row(fgrid_order.Rows.Count - 1);
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_NO] = _head_sr_no;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSRF_NO] = _head_srf_no;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_ID] = _head_bom_id;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_REV] = _head_bom_rev;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] = order_line_info[3].Replace("'", "");
                            _head_size = order_line_info[3].Replace("'", "");
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_TYPE] = "NIKE";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_LINE_ITEM] = order_line_info[1];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIDE_TYPE] = order_line_info[8];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_QTY] = order_line_info[9];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxREQUESTER] = _head_requestor;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_YMD] = _head_ord_ymd;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNEED_BY] = _head_need_by;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxDESTINATION] = order_line_info[0];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxGEN_CD] = order_line_info[2];
                            _head_gender = order_line_info[2];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxWIDTH] = order_line_info[4];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFIT] = order_line_info[5];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxAGE] = order_line_info[6];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxATTN] = order_line_info[7];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNIKE_FLG] = "N";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSTATUS] = "N";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;


                        }

                        fgrid_order.AutoSizeCols();
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Order)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion

                    CSV_Head_data_setting();

                    #region part 데이터 가져오기

                    try
                    {

                        string[] part_info = char_con(srf_part[3].Replace(char_div.ToString(), "^")).Replace("^", "").Split("Ψ".ToCharArray());

                        for (int i = 0; i < part_info.Length - 1; i++)
                        {
                            string[] part_line_info = part_info[i].Split("$".ToCharArray());

                            fgrid_detail.Add_Row(fgrid_detail.Rows.Count - 1);


                            if (!part_line_info.Length.Equals(13) && !part_line_info.Length.Equals(14))
                            {
                                fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxFACTORY,
                                    fgrid_detail.Rows.Count - 1, fgrid_detail.Cols.Count - 1).StyleNew.BackColor = Color.Crimson;
                                //ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Part).. Please ask System", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                warning_chk = true;

                            }

                            if (part_line_info.Length.Equals(14))
                            {

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSR_NO] = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSRF_NO] = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_ID] = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_REV] = _head_bom_rev;



                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO] = (part_line_info[0] != "") ? part_line_info[0] : Convert.ToString((Convert.ToUInt64(fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO].ToString()) + 0.01));
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE] = (part_line_info[1] != "") ? part_line_info[1] : fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE].ToString();

                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO] = part_line_info[0];
                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE] = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NAME] = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_QTY] = part_line_info[4];


                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_CD] = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_DESC] = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_NAME] = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_CD] = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMCS_CD] = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_COMMENT] = part_line_info[11];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_DESC] = part_line_info[12];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSTATUS] = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;
                            }
                            else
                            {
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSR_NO] = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSRF_NO] = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_ID] = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxBOM_REV] = _head_bom_rev;



                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO] = (part_line_info[0] != "") ? part_line_info[0] : Convert.ToString((Convert.ToUInt64(fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO].ToString()) + 0.01));
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE] = (part_line_info[1] != "") ? part_line_info[1] : fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE].ToString();

                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO] = part_line_info[0];
                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE] = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NAME] = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_QTY] = part_line_info[4];


                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_CD] = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxCOLOR_DESC] = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_NAME] = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_CD] = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_COMMENT] = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxMAT_DESC] = part_line_info[11];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxSTATUS] = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;
                            }
                        }

                        fgrid_detail.AutoSizeCols();

                        if (warning_chk)
                        {
                            ClassLib.ComFunction.User_Message("Red Color Data maybe have a problem. Please Check Part No..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            warning_chk = false;
                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Part)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion
                }


                DataTable dt_td = GET_MAX_TD_CODE(cmb_factory.SelectedValue.ToString(), txt_srfno.Text.Trim());

                try
                {
                    if (dt_td.Rows.Count < 1)
                        cmb_td.SelectedIndex = 0;
                    else
                        cmb_td.SelectedValue = dt_td.Rows[0].ItemArray[0].ToString();
                }
                catch
                {
                    cmb_td.SelectedIndex = 0; 
                }
                
            }
        }
        private void CSV_Head_data_setting()
        {
            //Clear_txtbox();
            _head_factory = cmb_factory.SelectedValue.ToString();
            txt_srno.Text = _head_sr_no;
            txt_srfno.Text = _head_srf_no;
            txt_bomid.Text = _head_bom_id;
            txt_bomrev.Text = _head_bom_rev;

            txt_state.Text = _head_sta;


            txt_bom_comments.Text = _head_bom_comment;
            txt_season.Text = _head_sesn;
            txt_factory_direct.Text = _head_factory_dv;
            txt_bom_state.Text = _head_sta;

            txt_colo_ver.Text = _head_color_ver;
            txt_style_cd.Text = _head_style_cd;
            txt_patten.Text = _head_pattern;

            txt_model_name_bom.Text = _head_dev_name;
            txt_last_cd.Text = _head_last_cd;



            txt_whq_plm.Text = _head_whq_plm;
            txt_whq_dev.Text = _head_whq_dev;
            txt_nlo_dev.Text = _head_nlo_dev;

            txt_bom_state.Text = _head_bom_state;
            txt_silhouette.Text = _head_silhouette;
            txt_technology.Text = _head_technology;

            txt_lasting_method.Text = _head_lasting_method;
            txt_ms_method.Text = _head_ms_method;
            txt_sole_laying_method.Text = _head_sole_laying_method;
            txt_mto_account_name.Text = _head_mto_account_name;
            txt_bom_comments.Text = _head_bom_comment;


            txt_model_name.Text = _head_dev_name;
            txt_mo_id.Text = _head_mo_alias;
            txt_requestor.Text = _head_requestor;

            txt_mo_alias.Text = _head_mo_alias;

            txt_product_code.Text = _head_product_code;

            txt_mtl_ver.Text = _head_mtl_ver;

            try
            {
                dtp_order_date.CustomFormat = dateType;
                dtp_order_date.Text = comfunction.ConvertDate2Type(_head_ord_ymd);
            }
            catch
            {
                dtp_order_date.CustomFormat = " ";
            }


            try
            {
                dtp_need_by.CustomFormat = dateType;
                dtp_need_by.Text = comfunction.ConvertDate2Type(_head_need_by);
            }
            catch
            {
                dtp_need_by.CustomFormat = " ";
            }

            try
            {
                dtp_ets.CustomFormat = dateType;
                dtp_ets.Text = comfunction.ConvertDate2Type(_head_ets);
            }
            catch
            {
                dtp_ets.CustomFormat = " ";
            }


            try
            {
                dtp_current_ipw.CustomFormat = dateType;
                dtp_current_ipw.Text = comfunction.ConvertDate2Type(_head_current_ipw);
            }
            catch
            {
                dtp_current_ipw.CustomFormat = " ";
            }

            //Gender Setting 
            DataTable dt_list = SELECT_MAX_GENDER();

            if (dt_list.Rows[0].ItemArray[0].ToString() == "00")
            {
                string _gen = find_gender(_head_gender);

                if (_gen != null)
                {
                    cmb_gender.Text = _gen;
                    cmb_gender.SelectedValue = _cs_gend;
                }
            }
            else
            {
                cmb_gender.Text = dt_list.Rows[0].ItemArray[0].ToString();
                cmb_gender.SelectedValue = dt_list.Rows[0].ItemArray[0].ToString();
            }

            dt_list = GET_TD_CODE();

            if (dt_list.Rows.Count < 1)
                cmb_td.SelectedIndex = 0;
            else
                cmb_td.SelectedValue = dt_list.Rows[0].ItemArray[0].ToString();
        }
        private string char_con(string arg_data)
        {
            string aa_div = "^";
            bool tmp_replace = false;
            string data_tmp = "";

            if (arg_data != null)
            {

                for (int i = 0; i < arg_data.Length; i++)
                {

                    string aa = arg_data.Substring(i, 1);

                    if (arg_data.Substring(i, 1) == aa_div.ToString())
                    {
                        if (tmp_replace) tmp_replace = false;
                        else tmp_replace = true;
                    }

                    if (!tmp_replace) data_tmp += arg_data.Substring(i, 1).Replace(",", "$");
                    else data_tmp += arg_data.Substring(i, 1);
                }
            }

            return data_tmp;
        }
        private string find_gender(string arg_nike_gen)
        {
            if (arg_nike_gen != null)
            {
                if (arg_nike_gen.ToUpper() == "FEMALE")
                { _cs_gend = "WO"; }
                else if (arg_nike_gen.ToUpper() == "MALE")
                { _cs_gend = "ME"; }
                else
                { _cs_gend = arg_nike_gen.ToUpper(); }

                return _cs_gend;
            }
            else
            {
                _cs_gend = arg_nike_gen;
                return _cs_gend;
            }
        }
        
        private DataTable SELECT_CREATE_SR_NO(string arg_factory, string arg_srf_no, string arg_bom_id, string arg_bom_rev)
        {
            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_CREATE_SR_NO"; ;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[2] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_REV";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_srf_no;
            MyOraDB.Parameter_Values[2] = arg_bom_id;
            MyOraDB.Parameter_Values[3] = arg_bom_rev;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }        
        private DataTable GET_MAX_TD_CODE(string arg_factory, string arg_srf_no)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.GET_MAX_TD_CODE";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_srf_no";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_srf_no;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            return ds_ret.Tables[MyOraDB.Process_Name];

        }
        private DataTable SELECT_MAX_GENDER()
        {   
            MyOraDB.ReDim_Parameter(7);

            MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_MAX_GENDER";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
            MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";


            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _head_factory;
            MyOraDB.Parameter_Values[1] = _head_sr_no;
            MyOraDB.Parameter_Values[2] = _head_srf_no;
            MyOraDB.Parameter_Values[3] = _head_bom_id;
            MyOraDB.Parameter_Values[4] = _head_bom_rev;
            MyOraDB.Parameter_Values[5] = _head_nf_cd;
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable GET_TD_CODE()
        {            
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXC_PJ_MAST";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[2] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _head_factory;
            MyOraDB.Parameter_Values[1] = _head_srf_no;
            MyOraDB.Parameter_Values[2] = _head_bom_id;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region XML File Loading
        private void XML_BOM_Reader()
        {
            // Read XML File. 
            // Create new FileStream to read schema with. //
            System.IO.FileStream fsReadXml = new System.IO.FileStream(txt_Path.Text, System.IO.FileMode.Open);

            // Create an XmlTextReader to read the file. //
            System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

            // Read the XML document into the DataSet. //
            DataSet _newDataSet = new DataSet();
            _newDataSet.ReadXml(myXmlReader);

            // Close the XmlTextReader //
            myXmlReader.Close();

            string xml_type = "D";
            if(_newDataSet.DataSetName.Equals("nike_boms"))
                xml_type = "M";

            XML_Data_Setting(_newDataSet, xml_type);
        }
        private void XML_Data_Setting(DataSet arg_ds_xml, string arg_xml_type)
        {
            int table_cnt = arg_ds_xml.Tables.Count;

            for (int i = 0; i < table_cnt; i++)
            {
                string table_name = arg_ds_xml.Tables[i].TableName;
                
                #region D BOM
                if(arg_xml_type.Equals("D"))
                {                
                    if (table_name.Equals("nike_samplerequest"))                
                    {
                        #region Sample Requests
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if(arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_id"))
                                    xml_samplerequest_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_type"))
                                    xml_samplerequest_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_state"))
                                    xml_samplerequest_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_requestor"))
                                    xml_requestor = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_orderdate"))
                                    xml_orderdate = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_needbydate"))
                                    xml_needbydate = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_estdate"))
                                    xml_estdate = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_instructions"))
                                    xml_samplerequest_instructions = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_pattern_id"))
                                    xml_pattern_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelid"))
                                    xml_modelid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelname"))
                                    xml_modelname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_alias"))
                                    xml_devproj_alias = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_id"))
                                    xml_devproj_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_season"))
                                    xml_season = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_tdcode"))
                                    xml_tdcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_factorydirect"))
                                    xml_factorydirect = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_pccfcty"))
                                    xml_pccfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_ssfcty"))
                                    xml_ssfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_primprodfcty"))
                                    xml_primprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_secprodfcty"))
                                    xml_secprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_whqdeveloper"))
                                    xml_whqdeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_nlodeveloper"))
                                    xml_nlodeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_plm"))
                                    xml_plm = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_biz_org"))
                                    xml_biz_org = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_purpose"))
                                    xml_consumer_purpose = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_focus"))
                                    xml_consumer_focus = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_use"))
                                    xml_consumer_use = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }
                        }                    
                        #endregion                
                    }
                    else if (table_name.Equals("nike_samplerequest_destination"))
                    {
                        #region Sample Requests Destination
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_dest"))
                                    xml_samplerequest_dest = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            fgrid_order.Rows.Add();

                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxDIVISION] = "I";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxDESTINATION] = xml_samplerequest_dest;
                            
                        }
                        #endregion            
                    }
                    else if (table_name.Equals("nike_samplerequest_lineitem"))
                    {
                        #region Sample Requests Lineitem
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lineitem_id"))
                                    xml_lineitem_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_gender"))
                                    xml_samplerequest_gender = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_size"))
                                    xml_samplerequest_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_width"))
                                    xml_samplerequest_width = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_fit"))
                                    xml_samplerequest_fit = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_age"))
                                    xml_samplerequest_age = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_attentionto"))
                                    xml_samplerequest_attentionto = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_side"))
                                    xml_samplerequest_side = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_quantity"))
                                    xml_samplerequest_quantity = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSR_LINE_ITEM] = xml_lineitem_id;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxGEN_CD]       = xml_samplerequest_gender;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSIZE_CD]      = xml_samplerequest_size;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxWIDTH]        = xml_samplerequest_width;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxFIT]          = xml_samplerequest_fit;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxAGE]          = xml_samplerequest_age;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxATTN]         = xml_samplerequest_attentionto;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSIDE_TYPE]    = xml_samplerequest_side;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_QTY]      = xml_samplerequest_quantity;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_TYPE]     = "NIKE SEND";
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_bom"))
                    {
                        #region BOM Information
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_id"))
                                    xml_bom_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_rev"))
                                    xml_bom_rev = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_state"))
                                    xml_bom_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_dimension"))
                                    xml_bom_dimension = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_silhouette"))
                                    xml_bom_silhouette = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_platform"))
                                    xml_bom_platform = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastcode"))
                                    xml_bom_lastcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastdim"))
                                    xml_bom_lastdim = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_method"))
                                    xml_bom_method = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_midsolemethod"))
                                    xml_bom_midsolemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_solemethod"))
                                    xml_bom_solemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialversion"))
                                    xml_bom_materialversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorversion"))
                                    xml_bom_colorversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_comments"))
                                    xml_bom_comments = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_prodcolorextabbrv"))
                                    xml_bom_prodcolorextabbrv = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_productcode"))
                                    xml_bom_productcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_productid"))
                                    xml_productid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_inlinesizerange"))
                                    xml_bom_inlinesizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_promosizerange"))
                                    xml_bom_promosizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_currentipw"))
                                    xml_bom_currentipw = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();                               
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_costingmaterial"))
                    {
                        #region Costing Material
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_name"))
                                    xml_costingmaterial_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_type"))
                                    xml_costingmaterial_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_dutycode"))
                                    xml_costingmaterial_dutycode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_tfob"))
                                    xml_costingmaterial_tfob = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();  
                            }
                        }
                        #endregion
                    }                    
                    else if (table_name.Equals("nike_globalexclusive_type"))
                    {
                        #region Grobal Exclusive Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_type_text"))
                                {
                                    xml_globalexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                   
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_globalexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_globalexclusive_to"))
                    {
                        #region  Grobal Exclusive Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_to_text"))
                                {
                                    xml_globalexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_globalexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingregion_rule"))
                    {
                        #region Initiatingregion Rule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiating_region"))
                                {
                                    xml_initiating_region = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = xml_initiating_region;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_type"))
                    {
                        #region Initiatingregion Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_type_text"))
                                {
                                    xml_initiatingexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_initiatingexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_to"))
                    {
                        #region Initiatingregion To
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_to_text"))
                                {
                                    xml_initiatingexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_initiatingexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_bom_lineitem"))
                    {
                        #region BOM Lineitem (Part)
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partnumber"))
                                    xml_bom_partnumber = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partname"))
                                    xml_bom_partname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_parttype"))
                                    xml_bom_parttype = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partquantity"))
                                    xml_bom_partquantity = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partcomment"))
                                    xml_bom_partcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorid"))
                                    xml_bom_colorid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorname"))
                                    xml_bom_colorname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorcomment"))
                                    xml_bom_colorcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_name"))
                                    xml_material_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_number"))
                                    xml_material_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mcs_number"))
                                    xml_mcs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mxs_number"))
                                    xml_mxs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialcoment"))
                                    xml_bom_materialcoment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_supplier_name"))
                                    xml_supplier_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();                                
                            }

                            fgrid_detail.Rows.Add();

                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = xml_bom_partnumber;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = xml_bom_parttype;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = xml_bom_partname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = xml_bom_partcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = xml_bom_partquantity;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_material_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_material_name;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = xml_bom_materialcoment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = xml_bom_colorid;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = xml_bom_colorname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = xml_bom_colorcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = xml_mcs_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = xml_mxs_number;                    
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_airbag_sizeschedule"))
                    {
                        #region Airbag Siz Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_number"))
                                    xml_airbag_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_name"))
                                    xml_airbag_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_size"))
                                    xml_airbag_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_min"))
                                    xml_airbag_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_max"))
                                    xml_airbag_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_state"))
                                    xml_airbag_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int air_row = fgrid_detail.Rows.Fixed; air_row < fgrid_detail.Rows.Count; air_row++)
                            {
                                string mat_cd = fgrid_detail[air_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_airbag_number.Equals(mat_cd))
                                    row_point = air_row;
                            }

                            string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                            if(!part_no.IndexOf(".").Equals(-1))
                                part_no = part_no.Substring(0, part_no.IndexOf("."));
                            part_no = part_no + "." + Convert.ToString(row + 1);
                            string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                            string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                            string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                            string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                            fgrid_detail.Add_Row(row_point);

                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_airbag_number;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_airbag_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_airbag_size;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_airbag_min;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_airbag_max;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_airbag_state;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";    
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_box_sizeschedule"))
                    {
                        #region Box Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_number"))
                                    xml_box_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_name"))
                                    xml_box_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_size"))
                                    xml_box_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_min"))
                                    xml_box_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_max"))
                                    xml_box_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_state"))
                                    xml_box_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int box_row = fgrid_detail.Rows.Fixed; box_row < fgrid_detail.Rows.Count; box_row++)
                            {
                                string mat_cd = fgrid_detail[box_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_box_number.Equals(mat_cd))
                                    row_point = box_row;
                            }

                            string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                            if(!part_no.IndexOf(".").Equals(-1))
                                part_no = part_no.Substring(0, part_no.IndexOf("."));
                            part_no = part_no + "." + Convert.ToString(row + 1);
                            string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                            string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                            string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                            string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                            fgrid_detail.Add_Row(row_point);

                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_box_number;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_box_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_box_size;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_box_min;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_box_max;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_box_state;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_lace_sizeschedule"))
                    {
                        #region Lace Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_number"))
                                    xml_lace_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_name"))
                                    xml_lace_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_type"))
                                    xml_lace_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_length"))
                                    xml_lace_length = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_min"))
                                    xml_lace_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_max"))
                                    xml_lace_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_state"))
                                    xml_lace_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int lace_row = fgrid_detail.Rows.Fixed; lace_row < fgrid_detail.Rows.Count; lace_row++)
                            {
                                string mat_cd = fgrid_detail[lace_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_lace_number.Equals(mat_cd))
                                    row_point = lace_row;
                            }

                            string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                            if(!part_no.IndexOf(".").Equals(-1))
                                part_no = part_no.Substring(0, part_no.IndexOf("."));
                            part_no = part_no + "." + Convert.ToString(row + 1);
                            string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                            string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                            string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                            string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                            fgrid_detail.Add_Row(row_point);

                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_lace_number;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_lace_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_lace_length;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_lace_min;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_lace_max;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_lace_state;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                        }
                        #endregion
                    }
                }
                #endregion                

                #region M BOM
                if(arg_xml_type.Equals("M"))
                {   
                    if (table_name.Equals("nike_bom"))
                    {
                        #region BOM Information
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_id"))
                                    xml_bom_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_rev"))
                                    xml_bom_rev = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_state"))
                                    xml_bom_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_dimension"))
                                    xml_bom_dimension = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_silhouette"))
                                    xml_bom_silhouette = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_platform"))
                                    xml_bom_platform = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastcode"))
                                    xml_bom_lastcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastdim"))
                                    xml_bom_lastdim = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_method"))
                                    xml_bom_method = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_midsolemethod"))
                                    xml_bom_midsolemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_solemethod"))
                                    xml_bom_solemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialversion"))
                                    xml_bom_materialversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorversion"))
                                    xml_bom_colorversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_comments"))
                                    xml_bom_comments = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_prodcolorextabbrv"))
                                    xml_bom_prodcolorextabbrv = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_productcode"))
                                    xml_bom_productcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_productid"))
                                    xml_productid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_inlinesizerange"))
                                    xml_bom_inlinesizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_promosizerange"))
                                    xml_bom_promosizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_currentipw"))
                                    xml_bom_currentipw = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelid"))
                                    xml_modelid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelname"))
                                    xml_modelname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_alias"))
                                    xml_devproj_alias = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_id"))
                                    xml_devproj_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_season"))
                                    xml_season = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_tdcode"))
                                    xml_tdcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_factorydirect"))
                                    xml_factorydirect = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_pccfcty"))
                                    xml_pccfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_ssfcty"))
                                    xml_ssfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_primprodfcty"))
                                    xml_primprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_secprodfcty"))
                                    xml_secprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_whqdeveloper"))
                                    xml_whqdeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_nlodeveloper"))
                                    xml_nlodeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_plm"))
                                    xml_plm = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_biz_org"))
                                    xml_biz_org = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_purpose"))
                                    xml_consumer_purpose = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_focus"))
                                    xml_consumer_focus = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_use"))
                                    xml_consumer_use = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                               
                            }
                        }
                        #endregion
                    }  
                    else if (table_name.Equals("nike_costingmaterial"))
                    {
                        #region Costing Material
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_name"))
                                    xml_costingmaterial_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_type"))
                                    xml_costingmaterial_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_dutycode"))
                                    xml_costingmaterial_dutycode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_tfob"))
                                    xml_costingmaterial_tfob = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();  
                            }
                        }
                        #endregion
                    }                    
                    else if (table_name.Equals("nike_globalexclusive_type"))
                    {
                        #region Grobal Exclusive Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_type_text"))
                                {
                                    xml_globalexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                   
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_globalexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_globalexclusive_to"))
                    {
                        #region  Grobal Exclusive Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_to_text"))
                                {
                                    xml_globalexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_globalexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingregion_rule"))
                    {
                        #region Initiatingregion Rule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiating_region"))
                                {
                                    xml_initiating_region = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = xml_initiating_region;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_type"))
                    {
                        #region Initiatingregion Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_type_text"))
                                {
                                    xml_initiatingexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_initiatingexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_to"))
                    {
                        #region Initiatingregion To
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_to_text"))
                                {
                                    xml_initiatingexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_initiatingexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_bom_lineitem"))
                    {
                        #region BOM Lineitem (Part)
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partnumber"))
                                    xml_bom_partnumber = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partname"))
                                    xml_bom_partname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_parttype"))
                                    xml_bom_parttype = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partquantity"))
                                    xml_bom_partquantity = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partcomment"))
                                    xml_bom_partcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorid"))
                                    xml_bom_colorid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorname"))
                                    xml_bom_colorname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorcomment"))
                                    xml_bom_colorcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_name"))
                                    xml_material_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_number"))
                                    xml_material_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mcs_number"))
                                    xml_mcs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mxs_number"))
                                    xml_mxs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialcoment"))
                                    xml_bom_materialcoment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_supplier_name"))
                                    xml_supplier_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();                                
                            }

                            fgrid_detail.Rows.Add();

                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = xml_bom_partnumber;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = xml_bom_parttype;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = xml_bom_partname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = xml_bom_partcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = xml_bom_partquantity;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_material_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_material_name;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = xml_bom_materialcoment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = xml_bom_colorid;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = xml_bom_colorname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = xml_bom_colorcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = xml_mcs_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = xml_mxs_number;                    
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_airbag_sizeschedule"))
                    {
                        #region Airbag Siz Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_number"))
                                    xml_airbag_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_name"))
                                    xml_airbag_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_size"))
                                    xml_airbag_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_min"))
                                    xml_airbag_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_max"))
                                    xml_airbag_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_state"))
                                    xml_airbag_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int air_row = fgrid_detail.Rows.Fixed; air_row < fgrid_detail.Rows.Count; air_row++)
                            {
                                string mat_cd = fgrid_detail[air_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_airbag_number.Equals(mat_cd))
                                    row_point = air_row;
                            }

                            string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                            if(!part_no.IndexOf(".").Equals(-1))
                                part_no = part_no.Substring(0, part_no.IndexOf("."));
                            part_no = part_no + "." + Convert.ToString(row + 1);
                            string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                            string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                            string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                            string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                            fgrid_detail.Add_Row(row_point);

                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_airbag_number;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_airbag_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_airbag_size;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_airbag_min;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_airbag_max;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_airbag_state;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";    
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_box_sizeschedule"))
                    {
                        #region Box Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_number"))
                                    xml_box_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_name"))
                                    xml_box_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_size"))
                                    xml_box_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_min"))
                                    xml_box_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_max"))
                                    xml_box_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_state"))
                                    xml_box_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int box_row = fgrid_detail.Rows.Fixed; box_row < fgrid_detail.Rows.Count; box_row++)
                            {
                                string mat_cd = fgrid_detail[box_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_box_number.Equals(mat_cd))
                                    row_point = box_row;
                            }

                            string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                            if(!part_no.IndexOf(".").Equals(-1))
                                part_no = part_no.Substring(0, part_no.IndexOf("."));
                            part_no = part_no + "." + Convert.ToString(row + 1);
                            string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                            string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                            string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                            string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                            fgrid_detail.Add_Row(row_point);

                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_box_number;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_box_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_box_size;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_box_min;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_box_max;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_box_state;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_lace_sizeschedule"))
                    {
                        #region Lace Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_number"))
                                    xml_lace_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_name"))
                                    xml_lace_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_type"))
                                    xml_lace_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_length"))
                                    xml_lace_length = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_min"))
                                    xml_lace_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_max"))
                                    xml_lace_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_state"))
                                    xml_lace_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int lace_row = fgrid_detail.Rows.Fixed; lace_row < fgrid_detail.Rows.Count; lace_row++)
                            {
                                string mat_cd = fgrid_detail[lace_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_lace_number.Equals(mat_cd))
                                    row_point = lace_row;
                            }

                            string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                            if(!part_no.IndexOf(".").Equals(-1))
                                part_no = part_no.Substring(0, part_no.IndexOf("."));
                            part_no = part_no + "." + Convert.ToString(row + 1);
                            string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                            string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                            string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                            string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                            fgrid_detail.Add_Row(row_point);

                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_lace_number;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_lace_name;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_lace_length;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_lace_min;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_lace_max;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_lace_state;
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                            fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                        }
                        #endregion
                    }
                }
                #endregion                
            }

            if (arg_xml_type.Equals("M"))
            {
                string arg_factory = cmb_factory.SelectedValue.ToString();
                xml_samplerequest_id = SELECT_CREATE_SR_NO(arg_factory, xml_devproj_alias.Replace("-", ""), xml_bom_id, xml_bom_rev).Rows[0].ItemArray[0].ToString();

                fgrid_order.Rows.Add();

                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxDIVISION] = "I";                
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSIDE_TYPE]    = "PAIR";
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_QTY]      = "0";
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_TYPE]     = "NIKE SEND";
            }
            XML_Head_Setting();
        }
        private void XML_Head_Setting()
        {
            #region SR Information
            txt_srno.Text        = xml_samplerequest_id;
            cmb_sampletypes.Text = xml_samplerequest_type;
            txt_state.Text       = xml_samplerequest_state;
            txt_requestor.Text   = xml_requestor;
            
            try
            {
                string ord_date = xml_orderdate.Replace("/", "");
                int day   = int.Parse(ord_date.Substring(0, 2));
                int month = int.Parse(ord_date.Substring(2, 2));
                int year  = int.Parse(ord_date.Substring(4, 4));

                DateTime date_ord = new DateTime(year, month, day);
                dtp_order_date.Value = date_ord;
            }
            catch{}
            try
            {
                string needby_date = xml_needbydate.Replace("/", "");
                int day   = int.Parse(needby_date.Substring(0, 2));
                int month = int.Parse(needby_date.Substring(2, 2));
                int year  = int.Parse(needby_date.Substring(4, 4));

                DateTime date_needby = new DateTime(year, month, day);
                dtp_need_by.Value = date_needby;
            }
            catch{}
            try
            {
                string est_date = xml_estdate.Replace("/", "");
                int day   = int.Parse(est_date.Substring(0, 2));
                int month = int.Parse(est_date.Substring(2, 2));
                int year  = int.Parse(est_date.Substring(4, 4));

                DateTime date_ets = new DateTime(year, month, day);
                dtp_ets.Value = date_ets;
            }
            catch{}
                
            txt_sr_instruction.Text = xml_samplerequest_instructions;
            txt_patten.Text         = xml_pattern_id;
            txt_mo_id.Text          = xml_modelid;
            txt_model_name.Text     = xml_modelname;
            txt_model_name_bom.Text = xml_modelname;
            txt_mo_alias.Text       = xml_devproj_alias;
            txt_srfno.Text          = xml_devproj_alias.Replace("-", "");
            txt_devproj_id.Text     = xml_devproj_id;
            txt_season.Text         = xml_season;
            txt_td_code.Text        = xml_tdcode;
            txt_factory_direct.Text = xml_factorydirect;
            txt_pcc_factory.Text    = xml_pccfcty;
            txt_ss_factory.Text     = xml_ssfcty;
            txt_p_prod_fact.Text    = xml_primprodfcty;
            txt_s_prod_fact.Text    = xml_secprodfcty;
            txt_whq_dev.Text        = xml_whqdeveloper;
            txt_nlo_dev.Text        = xml_nlodeveloper;
            txt_plm.Text            = xml_plm;
            txt_biz_org.Text        = xml_biz_org;
            txt_cons_purpose.Text   = xml_consumer_purpose;
            txt_cons_focus.Text     = xml_consumer_focus;
            txt_cons_use.Text       = xml_consumer_use;
            #endregion

            #region BOM Information
            txt_bomid.Text              = xml_bom_id;
            txt_bomrev.Text             = xml_bom_rev;
            txt_bom_state.Text          = xml_bom_state;
            txt_demension.Text          = xml_bom_dimension;
            txt_silhouette.Text         = xml_bom_silhouette;
            txt_platform.Text           = xml_bom_platform;
            txt_last_cd.Text            = xml_bom_lastcode;
            txt_last_dim.Text           = xml_bom_lastdim;
            txt_bom_method.Text         = xml_bom_method;
            txt_ms_method.Text          = xml_bom_midsolemethod;
            txt_sole_laying_method.Text = xml_bom_solemethod;
            txt_mtl_ver.Text            = xml_bom_materialversion;
            txt_colo_ver.Text           = xml_bom_colorversion;
            txt_bom_comments.Text       = xml_bom_comments;
            txt_extra_color.Text        = xml_bom_prodcolorextabbrv;
            txt_style_cd.Text           = xml_bom_productcode.Replace("-", "");
            txt_product_code.Text       = xml_bom_productcode.Replace("-", "");
            txt_prod_id.Text            = xml_productid;
            txt_inline_size.Text        = xml_bom_inlinesizerange;
            txt_promo_size.Text         = xml_bom_promosizerange;

            try
            {
                string ipw_date = xml_bom_currentipw.Replace("/", "");
                int day   = int.Parse(ipw_date.Substring(0, 2));
                int month = int.Parse(ipw_date.Substring(2, 2));
                int year  = int.Parse(ipw_date.Substring(4, 4));

                DateTime date_ipw = new DateTime(year, month, day);
                dtp_current_ipw.Value = date_ipw;
            }
            catch { }
            #endregion

            #region Costing Material
            txt_costmat_name.Text = xml_costingmaterial_name;
            txt_costmat_type.Text = xml_costingmaterial_type;
            txt_costmat_duty.Text = xml_costingmaterial_dutycode;
            txt_costmat_tfob.Text = xml_costingmaterial_tfob;
            #endregion
                        
            cmb_gender.Text = xml_samplerequest_gender;
            cmb_sampletypes.Text = xml_samplerequest_type;
            cmb_td.SelectedText = xml_tdcode;

            for (int detail = fgrid_detail.Rows.Fixed; detail < fgrid_detail.Rows.Count; detail++)
            {
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSR_NO]   = xml_samplerequest_id;
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSRF_NO]  = xml_devproj_alias.Replace("-", "");
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_ID]  = xml_bom_id;
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_REV] = xml_bom_rev; 
            }
            for (int order = fgrid_order.Rows.Fixed; order < fgrid_order.Rows.Count; order++)
            {
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSR_NO]   = xml_samplerequest_id;
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSRF_NO]  = xml_devproj_alias.Replace("-", "");
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxBOM_ID]  = xml_bom_id;
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxBOM_REV] = xml_bom_rev;

                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxREQUESTER] = xml_requestor;
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_YMD]   = dtp_order_date.Value.ToString("yyyyMMdd");
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxNEED_BY]   = dtp_need_by.Value.ToString("yyyyMMdd");
            }
            for (int rule = fgrid_rule.Rows.Fixed; rule < fgrid_rule.Rows.Count; rule++)
            {
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSR_NO]   = xml_samplerequest_id;
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSRF_NO]  = xml_devproj_alias.Replace("-", "");
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_ID]  = xml_bom_id;
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_REV] = xml_bom_rev;
            }           
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정상태 해제
                fgrid_detail.Select(fgrid_detail.Selection.r1, 0, fgrid_detail.Selection.r1, fgrid_detail.Cols.Count - 1, false);
                fgrid_order.Select(fgrid_order.Selection.r1, 0, fgrid_order.Selection.r1, fgrid_order.Cols.Count - 1, false);

                if (_form_type.Equals("I"))
                {   
                    if (Insert_Data())
                    {
                                             
                    }
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
        private bool Insert_Data()
        {
            try
            {

                return true;
            }
            catch 
            {
                return false; 
            }
        }
        private bool Check_Insert_Data()
        {
            if (txt_srno.Text.Trim().Length.Equals(0))
            {
                ClassLib.ComFunction.User_Message("Input Error : SR No", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion 

        #endregion
    }
}

