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
    public partial class Pop_Plan_sch_Formula : COM.PCHWinForm.Pop_Large_B
    {
        #region 생성자
        public Pop_Plan_sch_Formula()
        {
            InitializeComponent();
        }
        public Pop_Plan_sch_Formula(string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            InitializeComponent();

            _factory = arg_factory;
            _lot_no  = arg_lot_no;
            _lot_seq = arg_lot_seq;
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string _factory = "";
        private string _lot_no = "";
        private string _lot_seq = "";
        private string _op_cd = "IP";
        private bool _first_flg = true;
        public bool _save_flg = false;
        private string _mcs_cd = "", _mcs_cd_to = "", _color_cd = "", _color_cd_to = "";
        #endregion

        #region Form Loading
        private void Pop_Plan_sch_Formula_Load(object sender, EventArgs e)
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
            this.Text = "Tracking Sheet";
            lbl_MainTitle.Text = "  Tracking Sheet";
            
            Init_Control();

            Display_data();

            _first_flg = false;
        }

        private void Init_Control()
        {
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXG02");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_machine, 1, 2, false, 0, 181);
            cmb_machine.SelectedIndex = 0;

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;


            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.Enabled      = false;            
            txt_bom_id.Enabled     = false;            
            txt_med_lot_no.Enabled = false;

            txt_mcs_no.Enabled    = false;
            txt_mtl_color.Enabled = false;

            txt_mix_ratio_from.Enabled = false;
            txt_mix_ratio_to.Enabled   = false;

            txt_mix_kg_s.Enabled  = false;
            txt_mix_kg_l.Enabled  = false;
            txt_mix_kg.Enabled    = false;
            txt_mix_per_s.Enabled = false;
            txt_mix_per_l.Enabled = false;
            txt_mix_per.Enabled   = false;

            txt_fa_exp_rate.Enabled  = false;
            txt_fa_exp_range.Enabled = false;

            txt_model.BackColor      = SystemColors.Control;
            txt_bom_id.BackColor     = SystemColors.Control;            
            txt_med_lot_no.BackColor = SystemColors.Control;

            txt_mcs_no.BackColor    = SystemColors.Control;
            txt_mtl_color.BackColor = SystemColors.Control;

            txt_mix_ratio_from.BackColor = SystemColors.Control;
            txt_mix_ratio_to.BackColor   = SystemColors.Control;

            txt_mix_kg_s.BackColor  = SystemColors.Control;
            txt_mix_kg_l.BackColor  = SystemColors.Control;
            txt_mix_kg.BackColor    = SystemColors.Control;
            txt_mix_per_s.BackColor = SystemColors.Control;
            txt_mix_per_l.BackColor = SystemColors.Control;
            txt_mix_per.BackColor   = SystemColors.Control;

            txt_fa_exp_rate.BackColor  = SystemColors.Control;
            txt_fa_exp_range.BackColor = SystemColors.Control;
        }

        private void Display_data()
        {
            DataTable dt_ret = Select_result_list();

            if (dt_ret.Rows.Count > 0)
            {
                txt_model.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMODEL_NAME].ToString().Trim();

                string date = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxWORK_YMD].ToString().Trim();

                try
                {
                    int date_year  = int.Parse(date.Substring(0, 4));
                    int date_month = int.Parse(date.Substring(4, 2));
                    int date_day   = int.Parse(date.Substring(6, 2));

                    DateTime dt = new DateTime(date_year, date_month, date_day);
                    dtp_date.Value = dt;
                }
                catch
                {
                    dtp_date.Value = DateTime.Now;
                }

                cmb_machine.SelectedValue = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMACHINE_TYPE].ToString().Trim();
                txt_bom_id.Text           = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxBOM_STYLE].ToString().Trim();
                txt_operator.Text         = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxOPERATOR].ToString().Trim();

                txt_mtl_s.Text     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_SMALL].ToString().Trim();
                txt_mtl_l.Text     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LARGE].ToString().Trim();
                txt_mix_per_s.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_SMALL].ToString().Trim();
                txt_mix_per_l.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LARGE].ToString().Trim();

                txt_total_kg.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_TOT_RQD].ToString().Trim();
                txt_mix_kg.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_TOT_RQD].ToString().Trim();

                txt_mcs_no.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_CD].ToString().Trim();
                _mcs_cd         = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_CD].ToString().Trim();
                _mcs_cd_to      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_CD].ToString().Trim();

                _color_cd          = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_COLOR].ToString().Trim();
                _color_cd_to       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_COLOR].ToString().Trim();
                txt_mtl_color.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_COLOR_NAME].ToString().Trim();

                txt_mtl_lot_l.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LOT_NO].ToString().Trim();
                txt_mtl_lot_s.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LOT_NO_SMALL].ToString().Trim();
                txt_med_lot_no.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMED_LOT_NO].ToString().Trim();

                txt_mtl_per_rdp.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_RATE_RQD].ToString().Trim();
                txt_mix_per.Text     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_RATE_RQD].ToString().Trim();

                try
                {
                    double mix_ratio = double.Parse(dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_FROM].ToString().Trim());
                    txt_mix_ratio_from.Text = mix_ratio.ToString("0.00#");
                }
                catch
                {
                    txt_mix_ratio_from.Text = "0";
                }

                txt_mix_ratio_to.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_TO].ToString().Trim();
                txt_mix_kg_s.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_SMALL].ToString().Trim();
                txt_mix_kg_l.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_LARGE].ToString().Trim();
                txt_fa_target_len.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_TARGET_LENGTH].ToString().Trim();
                txt_fa_measure_len.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_MESURE_LENGTH].ToString().Trim();
                txt_fa_exp_rate.Text    = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_EXP_RATE].ToString().Trim();
                txt_fa_exp_range.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_EXP_RANGTH].ToString().Trim();
                txt_press_set.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxPRESS_SET].ToString().Trim();
                txt_back_presure.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxBACK_PSR].ToString().Trim();
                txt_screw_rpm.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSCREW_RPM].ToString().Trim();
                txt_dis_prs.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxDIS_PRS].ToString().Trim();
                txt_dis_spd.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxDIS_SPD].ToString().Trim();
                txt_cmprs_prs.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxCMPRS_PRS].ToString().Trim();
                txt_cmprs_spd.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxCMPRS_SPD].ToString().Trim();
                txt_zone_01.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE1].ToString().Trim();
                txt_zone_02.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE2].ToString().Trim();
                txt_zone_03.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE3].ToString().Trim();
                txt_zone_04.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE4].ToString().Trim();
                txt_zone_05.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE5].ToString().Trim();

                string vac_chk = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxVACUUM_CHECK].ToString().Trim();

                if (vac_chk.Equals("Y"))
                    chk_vacuum.Checked = true;
                else
                    chk_vacuum.Checked = false;

                txt_vacuum.Text    = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxVACUUM_MEASURE].ToString().Trim();
                txt_lo.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_LOWER].ToString().Trim();
                txt_up.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_UPPER].ToString().Trim();
                txt_volume.Text    = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxVOLUME].ToString().Trim();
                txt_1st.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED1].ToString().Trim();
                txt_2nd.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED2].ToString().Trim();
                txt_3rd.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED3].ToString().Trim();
                txt_4th.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED4].ToString().Trim();
                txt_5th.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED5].ToString().Trim();
                txt_inj_time.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTIMES].ToString().Trim();
                txt_cure_time.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxCURE_TIME].ToString().Trim();
                txt_inj_press.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxPRESSURE].ToString().Trim();
                txt_note.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxREMARKS].ToString().Trim();
            }
            else
            {
                dt_ret = Select_result_list_load();

                if (dt_ret.Rows.Count > 0)
                {
                    txt_model.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMODEL_NAME].ToString().Trim();

                    string date = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxWORK_YMD].ToString().Trim();

                    try
                    {
                        int date_year  = int.Parse(date.Substring(0, 4));
                        int date_month = int.Parse(date.Substring(4, 2));
                        int date_day   = int.Parse(date.Substring(6, 2));

                        DateTime dt = new DateTime(date_year, date_month, date_day);
                        dtp_date.Value = dt;
                    }
                    catch
                    {
                        dtp_date.Value = DateTime.Now;
                    }

                    cmb_machine.SelectedValue = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMACHINE_TYPE].ToString().Trim();
                    txt_bom_id.Text           = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxBOM_STYLE].ToString().Trim();
                    txt_operator.Text         = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxOPERATOR].ToString().Trim();

                    txt_mtl_s.Text     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_SMALL].ToString().Trim();
                    txt_mtl_l.Text     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LARGE].ToString().Trim();
                    txt_mix_per_s.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_SMALL].ToString().Trim();
                    txt_mix_per_l.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LARGE].ToString().Trim();

                    txt_total_kg.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_TOT_RQD].ToString().Trim();
                    txt_mix_kg.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_TOT_RQD].ToString().Trim();

                    txt_mcs_no.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_CD].ToString().Trim();
                    _mcs_cd         = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_CD].ToString().Trim();
                    _mcs_cd_to      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_CD].ToString().Trim();

                    _color_cd          = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_COLOR].ToString().Trim();
                    _color_cd_to       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_COLOR].ToString().Trim();
                    txt_mtl_color.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMCS_COLOR_NAME].ToString().Trim();

                    txt_mtl_lot_l.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LOT_NO].ToString().Trim();
                    txt_mtl_lot_s.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_LOT_NO_SMALL].ToString().Trim();
                    txt_med_lot_no.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMED_LOT_NO].ToString().Trim();

                    txt_mtl_per_rdp.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_RATE_RQD].ToString().Trim();
                    txt_mix_per.Text     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMAT_RATE_RQD].ToString().Trim();

                    try
                    {
                        double mix_ratio = double.Parse(dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_FROM].ToString().Trim());
                        txt_mix_ratio_from.Text = mix_ratio.ToString("0.00#");
                    }
                    catch
                    {
                        txt_mix_ratio_from.Text = "0";
                    }

                    txt_mix_ratio_to.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_TO].ToString().Trim();
                    txt_mix_kg_s.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_SMALL].ToString().Trim();
                    txt_mix_kg_l.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxMIX_RATE_LARGE].ToString().Trim();
                    txt_fa_target_len.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_TARGET_LENGTH].ToString().Trim();
                    txt_fa_measure_len.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_MESURE_LENGTH].ToString().Trim();
                    txt_fa_exp_rate.Text    = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_EXP_RATE].ToString().Trim();
                    txt_fa_exp_range.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxADJ_EXP_RANGTH].ToString().Trim();
                    txt_press_set.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxPRESS_SET].ToString().Trim();
                    txt_back_presure.Text   = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxBACK_PSR].ToString().Trim();
                    txt_screw_rpm.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSCREW_RPM].ToString().Trim();
                    txt_dis_prs.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxDIS_PRS].ToString().Trim();
                    txt_dis_spd.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxDIS_SPD].ToString().Trim();
                    txt_cmprs_prs.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxCMPRS_PRS].ToString().Trim();
                    txt_cmprs_spd.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxCMPRS_SPD].ToString().Trim();
                    txt_zone_01.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE1].ToString().Trim();
                    txt_zone_02.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE2].ToString().Trim();
                    txt_zone_03.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE3].ToString().Trim();
                    txt_zone_04.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE4].ToString().Trim();
                    txt_zone_05.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_ZONE5].ToString().Trim();

                    string vac_chk = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxVACUUM_CHECK].ToString().Trim();

                    if (vac_chk.Equals("Y"))
                        chk_vacuum.Checked = true;
                    else
                        chk_vacuum.Checked = false;

                    txt_vacuum.Text    = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxVACUUM_MEASURE].ToString().Trim();
                    txt_lo.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_LOWER].ToString().Trim();
                    txt_up.Text        = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTEMP_UPPER].ToString().Trim();
                    txt_volume.Text    = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxVOLUME].ToString().Trim();
                    txt_1st.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED1].ToString().Trim();
                    txt_2nd.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED2].ToString().Trim();
                    txt_3rd.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED3].ToString().Trim();
                    txt_4th.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED4].ToString().Trim();
                    txt_5th.Text       = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxSPEED5].ToString().Trim();
                    txt_inj_time.Text  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxTIMES].ToString().Trim();
                    txt_cure_time.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxCURE_TIME].ToString().Trim();
                    txt_inj_press.Text = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxPRESSURE].ToString().Trim();
                    txt_note.Text      = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSXG_SPECIFIC_FORMULA.IxREMARKS].ToString().Trim();
                }
            }
        }

        private DataTable Select_result_list()
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_03_SELECT.SELECT_SPECIFIC_FORMULA";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = _lot_no;
            MyOraDB.Parameter_Values[2] = _lot_seq;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_result_list_load()
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_MPS_03_SELECT.SELECT_SPECIFIC_FORMULA_LOAD";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = _lot_no;
            MyOraDB.Parameter_Values[2] = _lot_seq;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (!CHK_SAVE())
                    return;

                DataTable dt_ret = Save_Data();


                if (dt_ret.Rows.Count > 0)
                {
                    _mcs_cd = _mcs_cd_to;
                    _color_cd = _color_cd_to;
                    txt_med_lot_no.Text = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
                    _save_flg = true;

                    MessageBox.Show("Save Completed.");
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

        private bool CHK_SAVE()
        {
            if (txt_mcs_no.Text.Trim().Equals(""))
            {
                MessageBox.Show("MCS No is Empty.");
                return false;
            }
            if (txt_mtl_color.Text.Trim().Equals(""))
            {
                MessageBox.Show("Color is Empty.");
                return false;
            }
            if (cmb_machine.SelectedIndex == -1 || cmb_machine.SelectedValue == null)
            {
                MessageBox.Show("Please Select Machine Type.");
                return false;
            }

            return true;
        }

        private DataTable Save_Data()
        {
            try
            {
                int col_ct = 55;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SXG_MPS_03.SAVE_SPECIFIC_FORMULA";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1]  = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[2]  = "ARG_LOT_SEQ";
                MyOraDB.Parameter_Name[3]  = "ARG_MCS_CD";
                MyOraDB.Parameter_Name[4]  = "ARG_MCS_COLOR";
                MyOraDB.Parameter_Name[5]  = "ARG_MCS_CD_TO";                
                MyOraDB.Parameter_Name[6]  = "ARG_MCS_COLOR_TO";
                MyOraDB.Parameter_Name[7]  = "ARG_OP_CD";
                MyOraDB.Parameter_Name[8]  = "ARG_MAT_LOT_NO";
                MyOraDB.Parameter_Name[9]  = "ARG_MAT_LOT_NO_SMALL";
                MyOraDB.Parameter_Name[10] = "ARG_MED_LOT_NO_LARGE";
                MyOraDB.Parameter_Name[11] = "ARG_WORK_YMD";
                MyOraDB.Parameter_Name[12] = "ARG_CDC_WORKER";
                MyOraDB.Parameter_Name[13] = "ARG_MACHINE_TYPE";
                MyOraDB.Parameter_Name[14] = "ARG_MAT_SMALL";
                MyOraDB.Parameter_Name[15] = "ARG_MAT_LARGE";
                MyOraDB.Parameter_Name[16] = "ARG_MAT_TOT_RQD";
                MyOraDB.Parameter_Name[17] = "ARG_MAT_RATE_RQD";
                MyOraDB.Parameter_Name[18] = "ARG_MIX_RATE_FROM";
                MyOraDB.Parameter_Name[19] = "ARG_MIX_RATE_TO";
                MyOraDB.Parameter_Name[20] = "ARG_MIX_WEIGHT_SMALL";
                MyOraDB.Parameter_Name[21] = "ARG_MIX_WEIGHT_LARGE";
                MyOraDB.Parameter_Name[22] = "ARG_ADJ_TARGET_LENGTH";
                MyOraDB.Parameter_Name[23] = "ARG_ADJ_MESURE_LENGTH";
                MyOraDB.Parameter_Name[24] = "ARG_ADJ_EXP_RATE";
                MyOraDB.Parameter_Name[25] = "ARG_ADJ_EXP_RANGTH";
                MyOraDB.Parameter_Name[26] = "ARG_PRESS_SET";
                MyOraDB.Parameter_Name[27] = "ARG_BACK_PSR";
                MyOraDB.Parameter_Name[28] = "ARG_SCREW_RPM";
                MyOraDB.Parameter_Name[29] = "ARG_DIS_PRS";
                MyOraDB.Parameter_Name[30] = "ARG_DIS_SPD";
                MyOraDB.Parameter_Name[31] = "ARG_CMPRS_PRS";
                MyOraDB.Parameter_Name[32] = "ARG_CMPRS_SPD";
                MyOraDB.Parameter_Name[33] = "ARG_TEMP_ZONE1";
                MyOraDB.Parameter_Name[34] = "ARG_TEMP_ZONE2";
                MyOraDB.Parameter_Name[35] = "ARG_TEMP_ZONE3";
                MyOraDB.Parameter_Name[36] = "ARG_TEMP_ZONE4";
                MyOraDB.Parameter_Name[37] = "ARG_TEMP_ZONE5";
                MyOraDB.Parameter_Name[38] = "ARG_VACUUM_CHECK";
                MyOraDB.Parameter_Name[39] = "ARG_VACUUM_MEASURE";
                MyOraDB.Parameter_Name[40] = "ARG_TEMP_LOWER";
                MyOraDB.Parameter_Name[41] = "ARG_TEMP_UPPER";
                MyOraDB.Parameter_Name[42] = "ARG_VOLUME";
                MyOraDB.Parameter_Name[43] = "ARG_SPEED1";
                MyOraDB.Parameter_Name[44] = "ARG_SPEED2";
                MyOraDB.Parameter_Name[45] = "ARG_SPEED3";
                MyOraDB.Parameter_Name[46] = "ARG_SPEED4";
                MyOraDB.Parameter_Name[47] = "ARG_SPEED5";
                MyOraDB.Parameter_Name[48] = "ARG_INJ_TIME";
                MyOraDB.Parameter_Name[49] = "ARG_CURE_TIME";
                MyOraDB.Parameter_Name[50] = "ARG_INJ_PRESSURE";
                MyOraDB.Parameter_Name[51] = "ARG_STATUS";
                MyOraDB.Parameter_Name[52] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[53] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[54] = "OUT_CURSOR";
                                       
                // 파라미터의 데이터 Type
                
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
                MyOraDB.Parameter_Type[36] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[37] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[38] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[39] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[40] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[41] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[42] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[43] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[44] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[45] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[46] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[47] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[48] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[49] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[50] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[51] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[52] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[53] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[54] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = _factory;
                MyOraDB.Parameter_Values[1] = _lot_no;
                MyOraDB.Parameter_Values[2] = _lot_seq;
                MyOraDB.Parameter_Values[3] = (_mcs_cd.Equals("")) ? _mcs_cd_to : _mcs_cd;
                MyOraDB.Parameter_Values[4] = (_color_cd.Equals("")) ? _color_cd_to : _color_cd;
                MyOraDB.Parameter_Values[5] = _mcs_cd_to;
                MyOraDB.Parameter_Values[6] = _color_cd_to;
                MyOraDB.Parameter_Values[7] = _op_cd;
                MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_TextBox(txt_mtl_lot_l, "");
                MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_TextBox(txt_mtl_lot_s, "");
                MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_TextBox(txt_med_lot_no, "");
                MyOraDB.Parameter_Values[11] = dtp_date.Value.ToString("yyyyMMdd");
                MyOraDB.Parameter_Values[12] = COM.ComFunction.Empty_TextBox(txt_operator, "");
                MyOraDB.Parameter_Values[13] = cmb_machine.SelectedValue.ToString();
                MyOraDB.Parameter_Values[14] = COM.ComFunction.Empty_TextBox(txt_mtl_s, "");
                MyOraDB.Parameter_Values[15] = COM.ComFunction.Empty_TextBox(txt_mtl_l, "");
                MyOraDB.Parameter_Values[16] = COM.ComFunction.Empty_TextBox(txt_total_kg, "");
                MyOraDB.Parameter_Values[17] = COM.ComFunction.Empty_TextBox(txt_mtl_per_rdp, "");
                MyOraDB.Parameter_Values[18] = COM.ComFunction.Empty_TextBox(txt_mix_ratio_from, "");
                MyOraDB.Parameter_Values[19] = COM.ComFunction.Empty_TextBox(txt_mix_ratio_to, "");
                MyOraDB.Parameter_Values[20] = COM.ComFunction.Empty_TextBox(txt_mix_kg_s, "");
                MyOraDB.Parameter_Values[21] = COM.ComFunction.Empty_TextBox(txt_mix_kg_l, "");
                MyOraDB.Parameter_Values[22] = COM.ComFunction.Empty_TextBox(txt_fa_target_len, "");
                MyOraDB.Parameter_Values[23] = COM.ComFunction.Empty_TextBox(txt_fa_measure_len, "");
                MyOraDB.Parameter_Values[24] = COM.ComFunction.Empty_TextBox(txt_fa_exp_rate, "");
                MyOraDB.Parameter_Values[25] = COM.ComFunction.Empty_TextBox(txt_fa_exp_range, "");
                MyOraDB.Parameter_Values[26] = COM.ComFunction.Empty_TextBox(txt_press_set, "");
                MyOraDB.Parameter_Values[27] = COM.ComFunction.Empty_TextBox(txt_back_presure, "");
                MyOraDB.Parameter_Values[28] = COM.ComFunction.Empty_TextBox(txt_screw_rpm, "");
                MyOraDB.Parameter_Values[29] = COM.ComFunction.Empty_TextBox(txt_dis_prs, "");
                MyOraDB.Parameter_Values[30] = COM.ComFunction.Empty_TextBox(txt_dis_spd, "");
                MyOraDB.Parameter_Values[31] = COM.ComFunction.Empty_TextBox(txt_cmprs_prs, "");
                MyOraDB.Parameter_Values[32] = COM.ComFunction.Empty_TextBox(txt_cmprs_spd, "");
                MyOraDB.Parameter_Values[33] = COM.ComFunction.Empty_TextBox(txt_zone_01, "");
                MyOraDB.Parameter_Values[34] = COM.ComFunction.Empty_TextBox(txt_zone_02, "");
                MyOraDB.Parameter_Values[35] = COM.ComFunction.Empty_TextBox(txt_zone_03, "");
                MyOraDB.Parameter_Values[36] = COM.ComFunction.Empty_TextBox(txt_zone_04, "");
                MyOraDB.Parameter_Values[37] = COM.ComFunction.Empty_TextBox(txt_zone_05, "");
                MyOraDB.Parameter_Values[38] = (chk_vacuum.Checked) ? "Y" : "N";
                MyOraDB.Parameter_Values[39] = (chk_vacuum.Checked) ? COM.ComFunction.Empty_TextBox(txt_vacuum, "") : "";
                MyOraDB.Parameter_Values[40] = COM.ComFunction.Empty_TextBox(txt_lo, "");
                MyOraDB.Parameter_Values[41] = COM.ComFunction.Empty_TextBox(txt_up, "");
                MyOraDB.Parameter_Values[42] = COM.ComFunction.Empty_TextBox(txt_volume, "");
                MyOraDB.Parameter_Values[43] = COM.ComFunction.Empty_TextBox(txt_1st, "");
                MyOraDB.Parameter_Values[44] = COM.ComFunction.Empty_TextBox(txt_2nd, "");
                MyOraDB.Parameter_Values[45] = COM.ComFunction.Empty_TextBox(txt_3rd, "");
                MyOraDB.Parameter_Values[46] = COM.ComFunction.Empty_TextBox(txt_4th, "");
                MyOraDB.Parameter_Values[47] = COM.ComFunction.Empty_TextBox(txt_5th, "");
                MyOraDB.Parameter_Values[48] = COM.ComFunction.Empty_TextBox(txt_inj_time, "");
                MyOraDB.Parameter_Values[49] = COM.ComFunction.Empty_TextBox(txt_cure_time, "");
                MyOraDB.Parameter_Values[50] = COM.ComFunction.Empty_TextBox(txt_inj_press, "");
                MyOraDB.Parameter_Values[51] = "N";
                MyOraDB.Parameter_Values[52] = COM.ComFunction.Empty_TextBox(txt_note, "");
                MyOraDB.Parameter_Values[53] = COM.ComVar.This_User;
                MyOraDB.Parameter_Values[54] = "";

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

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                string[] arg_value = new string[3];
                arg_value[0] = _factory;
                arg_value[1] = _lot_no;
                arg_value[2] = _lot_seq;
                
                string mrd_Filename = Application.StartupPath + @"\Product_Formula.mrd";
                string sPara = " /rp" + " [" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
 
            }
        }
        #endregion

        #region Control Event
        private void chk_vacuum_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_vacuum.Checked)
            {
                txt_vacuum.Enabled = true;
                txt_vacuum.BackColor = SystemColors.Window;
            }
            else
            {
                txt_vacuum.Enabled = false;
                txt_vacuum.BackColor = SystemColors.Control;
            }
        }

        private void txt_mtl_s_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double mat_s = 0;
                double mat_l = 0;
                double tot_rqd = 0;
                double mat_rqd = 0;

                try
                {
                    mat_s = double.Parse((txt_mtl_s.Text.Trim().Equals("")) ? "0" : txt_mtl_s.Text.Trim());
                }
                catch
                {
                    mat_s = 0;
                }
                try
                {
                    mat_l = double.Parse((txt_mtl_l.Text.Trim().Equals("")) ? "0" : txt_mtl_l.Text.Trim());
                }
                catch
                {
                    mat_l = 0;
                }
                try
                {
                    tot_rqd = double.Parse((txt_total_kg.Text.Trim().Equals("")) ? "0" : txt_total_kg.Text.Trim());
                }
                catch
                {
                    tot_rqd = 0;
                }
                try
                {
                    mat_rqd = double.Parse((txt_mtl_per_rdp.Text.Trim().Equals("")) ? "0" : txt_mtl_per_rdp.Text.Trim());
                }
                catch
                {
                    mat_rqd = 0;
                }

                double mix_kg_l       = -(tot_rqd * mat_rqd - (tot_rqd * mat_s)) / (mat_s - mat_l);
                double mix_kg_s       = tot_rqd - mix_kg_l;
                double mix_result     = (tot_rqd.Equals(0)) ? 0 : ((mat_s * mix_kg_s) + (mat_l * mix_kg_l)) / tot_rqd;
                double mix_ratio_from = (mix_kg_l.Equals(0)) ? 0 : mix_kg_s / mix_kg_l;
                double mix_ratio_to   = (mix_kg_l.Equals(0)) ? 0 : mix_kg_l / mix_kg_l;

                txt_mix_per_s.Text      = txt_mtl_s.Text;
                txt_mix_kg_s.Text       = mix_kg_s.ToString("#.0#");
                txt_mix_kg_l.Text       = mix_kg_l.ToString("#.0#");
                txt_mix_per.Text        = mix_result.ToString("#.0#");
                txt_mix_ratio_from.Text = mix_ratio_from.ToString("0.###");
                txt_mix_ratio_to.Text   = mix_ratio_to.ToString("0.###");
                
            }
            catch
            {
 
            }
        }

        private void txt_mtl_l_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double mat_s = 0;
                double mat_l = 0;
                double tot_rqd = 0;
                double mat_rqd = 0;

                try
                {
                    mat_s = double.Parse((txt_mtl_s.Text.Trim().Equals("")) ? "0" : txt_mtl_s.Text.Trim());
                }
                catch
                {
                    mat_s = 0;
                }
                try
                {
                    mat_l = double.Parse((txt_mtl_l.Text.Trim().Equals("")) ? "0" : txt_mtl_l.Text.Trim());
                }
                catch
                {
                    mat_l = 0;
                }
                try
                {
                    tot_rqd = double.Parse((txt_total_kg.Text.Trim().Equals("")) ? "0" : txt_total_kg.Text.Trim());
                }
                catch
                {
                    tot_rqd = 0;
                }
                try
                {
                    mat_rqd = double.Parse((txt_mtl_per_rdp.Text.Trim().Equals("")) ? "0" : txt_mtl_per_rdp.Text.Trim());
                }
                catch
                {
                    mat_rqd = 0;
                }

                double mix_kg_l       = -(tot_rqd * mat_rqd - (tot_rqd * mat_s)) / (mat_s - mat_l);
                double mix_kg_s       = tot_rqd - mix_kg_l;
                double mix_result     = (tot_rqd.Equals(0)) ? 0 : ((mat_s * mix_kg_s) + (mat_l * mix_kg_l)) / tot_rqd;
                double mix_ratio_from = (mix_kg_l.Equals(0)) ? 0 : mix_kg_s / mix_kg_l;
                double mix_ratio_to   = (mix_kg_l.Equals(0)) ? 0 : mix_kg_l / mix_kg_l;

                txt_mix_per_l.Text      = txt_mtl_l.Text;
                txt_mix_kg_s.Text       = mix_kg_s.ToString("#.0#");
                txt_mix_kg_l.Text       = mix_kg_l.ToString("#.0#");
                txt_mix_per.Text        = mix_result.ToString("#.0#");
                txt_mix_ratio_from.Text = mix_ratio_from.ToString("0.###");
                txt_mix_ratio_to.Text   = mix_ratio_to.ToString("0.###");

            }
            catch
            {

            }
        }

        private void txt_total_kg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double mat_s = 0;
                double mat_l = 0;
                double tot_rqd = 0;
                double mat_rqd = 0;

                try
                {
                    mat_s = double.Parse((txt_mtl_s.Text.Trim().Equals("")) ? "0" : txt_mtl_s.Text.Trim());
                }
                catch
                {
                    mat_s = 0;
                }
                try
                {
                    mat_l = double.Parse((txt_mtl_l.Text.Trim().Equals("")) ? "0" : txt_mtl_l.Text.Trim());
                }
                catch
                {
                    mat_l = 0;
                }
                try
                {
                    tot_rqd = double.Parse((txt_total_kg.Text.Trim().Equals("")) ? "0" : txt_total_kg.Text.Trim());
                }
                catch
                {
                    tot_rqd = 0;
                }
                try
                {
                    mat_rqd = double.Parse((txt_mtl_per_rdp.Text.Trim().Equals("")) ? "0" : txt_mtl_per_rdp.Text.Trim());
                }
                catch
                {
                    mat_rqd = 0;
                }

                double mix_kg_l       = -(tot_rqd * mat_rqd - (tot_rqd * mat_s)) / (mat_s - mat_l);
                double mix_kg_s       = tot_rqd - mix_kg_l;
                double mix_result     = (tot_rqd.Equals(0)) ? 0 : ((mat_s * mix_kg_s) + (mat_l * mix_kg_l)) / tot_rqd;
                double mix_ratio_from = (mix_kg_l.Equals(0)) ? 0 : mix_kg_s / mix_kg_l;
                double mix_ratio_to   = (mix_kg_l.Equals(0)) ? 0 : mix_kg_l / mix_kg_l;

                txt_mix_kg.Text         = txt_total_kg.Text;
                txt_mix_kg_s.Text       = mix_kg_s.ToString("#.0#");
                txt_mix_kg_l.Text       = mix_kg_l.ToString("#.0#");
                txt_mix_per.Text        = mix_result.ToString("#.0#");
                txt_mix_ratio_from.Text = mix_ratio_from.ToString("0.###");
                txt_mix_ratio_to.Text   = mix_ratio_to.ToString("0.###");
            }
            catch
            {

            }
        }

        private void txt_mtl_per_rdp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double mat_s = 0;
                double mat_l = 0;
                double tot_rqd = 0;
                double mat_rqd = 0;

                try
                {
                    mat_s = double.Parse((txt_mtl_s.Text.Trim().Equals("")) ? "0" : txt_mtl_s.Text.Trim());
                }
                catch
                {
                    mat_s = 0;
                }
                try
                {
                    mat_l = double.Parse((txt_mtl_l.Text.Trim().Equals("")) ? "0" : txt_mtl_l.Text.Trim());
                }
                catch
                {
                    mat_l = 0;
                }
                try
                {
                    tot_rqd = double.Parse((txt_total_kg.Text.Trim().Equals("")) ? "0" : txt_total_kg.Text.Trim());
                }
                catch
                {
                    tot_rqd = 0;
                }
                try
                {
                    mat_rqd = double.Parse((txt_mtl_per_rdp.Text.Trim().Equals("")) ? "0" : txt_mtl_per_rdp.Text.Trim());
                }
                catch
                {
                    mat_rqd = 0;
                }

                double mix_kg_l       = -(tot_rqd * mat_rqd - (tot_rqd * mat_s)) / (mat_s - mat_l);
                double mix_kg_s       = tot_rqd - mix_kg_l;
                double mix_result     = (tot_rqd.Equals(0)) ? 0 : ((mat_s * mix_kg_s) + (mat_l * mix_kg_l)) / tot_rqd;
                double mix_ratio_from = (mix_kg_l.Equals(0)) ? 0 : mix_kg_s / mix_kg_l;
                double mix_ratio_to   = (mix_kg_l.Equals(0)) ? 0 : mix_kg_l / mix_kg_l;

                txt_mix_kg_s.Text       = mix_kg_s.ToString("#.0#");
                txt_mix_kg_l.Text       = mix_kg_l.ToString("#.0#");
                txt_mix_per.Text        = mix_result.ToString("#.0#");
                txt_mix_ratio_from.Text = mix_ratio_from.ToString("0.###");
                txt_mix_ratio_to.Text   = mix_ratio_to.ToString("0.###");
            }
            catch
            {

            }
        }

        private void txt_fa_target_len_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double adj_target = 0;
                double adj_measure = 0;

                try
                {
                    adj_target = double.Parse((txt_fa_target_len.Text.Trim().Equals("")) ? "0" : txt_fa_target_len.Text.Trim());
                }
                catch
                {
                    adj_target = 0; 
                }
                try
                {
                    adj_measure = double.Parse((txt_fa_measure_len.Text.Trim().Equals("")) ? "0" : txt_fa_measure_len.Text.Trim());
                }
                catch
                {
                    adj_measure = 0;
                }

                double exp_rate = (adj_target.Equals(0)) ? 0 : adj_measure / adj_target * 100;

                txt_fa_exp_rate.Text = exp_rate.ToString("0.0#");
            }
            catch
            {
 
            }
        }

        private void txt_fa_measure_len_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double adj_target = 0;
                double adj_measure = 0;

                try
                {
                    adj_target = double.Parse((txt_fa_target_len.Text.Trim().Equals("")) ? "0" : txt_fa_target_len.Text.Trim());
                }
                catch
                {
                    adj_target = 0;
                }
                try
                {
                    adj_measure = double.Parse((txt_fa_measure_len.Text.Trim().Equals("")) ? "0" : txt_fa_measure_len.Text.Trim());
                }
                catch
                {
                    adj_measure = 0;
                }

                double exp_rate = (adj_target.Equals(0)) ? 0 : adj_measure / adj_target * 100;

                txt_fa_exp_rate.Text = exp_rate.ToString("0.0#");
            }
            catch
            {

            }
        }

        private void txt_mix_per_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double mix_per = 0;
                double adj_exp_rate = 0;

                try
                {
                    mix_per = double.Parse((txt_mix_per.Text.Trim().Equals("")) ? "0" : txt_mix_per.Text.Trim());
                }
                catch
                {
                    mix_per = 0;
                }

                try
                {
                    adj_exp_rate = double.Parse((txt_fa_exp_rate.Text.Trim().Equals("")) ? "0" : txt_fa_exp_rate.Text.Trim());
                }
                catch
                {
                    adj_exp_rate = 0;
                }

                double adj_exp_range = (adj_exp_rate.Equals(0)) ? 0 : mix_per / (adj_exp_rate + 1);

                txt_fa_exp_range.Text = adj_exp_range.ToString("0.0#");
            }
            catch
            {

            }
        }

        private void txt_fa_exp_rate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_first_flg)
                    return;

                double mix_per = 0;
                double adj_exp_rate = 0;

                try
                {
                    mix_per = double.Parse((txt_mix_per.Text.Trim().Equals("")) ? "0" : txt_mix_per.Text.Trim());
                }
                catch
                {
                    mix_per = 0; 
                }

                try
                {
                    adj_exp_rate = double.Parse((txt_fa_exp_rate.Text.Trim().Equals("")) ? "0" : txt_fa_exp_rate.Text.Trim());
                }
                catch
                {
                    adj_exp_rate = 0;
                }

                double adj_exp_range = (adj_exp_rate.Equals(0)) ? 0 : mix_per / (adj_exp_rate + 1);

                txt_fa_exp_range.Text = adj_exp_range.ToString("0.0#");
            }
            catch
            {
 
            }
        }

        private void btn_mcs_Click(object sender, EventArgs e)
        {
            try
            {
                string arg_mcs_no = txt_mcs_no.Text.Trim();
                string arg_color  = txt_mtl_color.Text.Trim();

                Pop_Plan_sch_MCS pop = new Pop_Plan_sch_MCS("M", arg_mcs_no, arg_color, _color_cd_to);
                pop.ShowDialog();

                txt_mcs_no.Text    = pop._mcs_no;
                _mcs_cd_to         = pop._mcs_no;

                txt_mtl_color.Text = pop._color_name;
                _color_cd_to       = pop._color_cd;
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void btn_mcs_color_Click(object sender, EventArgs e)
        {
            try
            {
                string arg_mcs_no = txt_mcs_no.Text.Trim();
                string arg_color  = txt_mtl_color.Text.Trim();

                Pop_Plan_sch_MCS pop = new Pop_Plan_sch_MCS("C", arg_mcs_no, arg_color, _color_cd_to);
                pop.ShowDialog();

                txt_mcs_no.Text    = pop._mcs_no;
                _mcs_cd_to         = pop._mcs_no;

                txt_mtl_color.Text = pop._color_name;
                _color_cd_to       = pop._color_cd;
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion
    }
}


