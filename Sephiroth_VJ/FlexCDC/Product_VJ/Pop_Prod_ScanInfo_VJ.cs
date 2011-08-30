using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product_VJ
{
    public partial class Pop_Prod_ScanInfo_VJ : COM.PCHWinForm.Pop_Large_Light
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성

        private string tmp_bar_code, tmp_op_cd, tmp_cmp_cd, tmp_rst_div;
        private string tmp_model, tmp_round, tmp_bom_style, tmp_qty;
        
        public bool save_flg = false;
        #endregion

        #region Resource
        public Pop_Prod_ScanInfo_VJ()
        {
            InitializeComponent();
        }

        public Pop_Prod_ScanInfo_VJ(string arg_bar_code, string arg_op_cd, string arg_cmp_cd, string arg_rtd_div, string arg_model, string arg_round, string arg_bom_style, string arg_qty)
        {
            tmp_bar_code = arg_bar_code;
            tmp_op_cd    = arg_op_cd;
            tmp_cmp_cd   = arg_cmp_cd;
            tmp_rst_div  = arg_rtd_div;
                       
            tmp_model       = arg_model;
            tmp_round       = arg_round;
            tmp_bom_style   = arg_bom_style;
            tmp_qty         = arg_qty;            

            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_Prod_Result_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {
 
            }
        }

        private void Init_Form()
        {
            this.Text = "Passcard Information";
            this.lbl_MainTitle.Text = "Passcard Information";

            #region Button Setting
            c1ToolBar1.Visible   = false;            
            #endregion

            #region Control Setting
            lbl_model.Text     = tmp_model;
            lbl_bom_style.Text = tmp_bom_style;
            lbl_round.Text     = tmp_round;
            lbl_qty.Text       = tmp_qty;
            #endregion

            Save_Data();
        }
                
        
        #endregion

        #region Save Data
        private void Save_Data()
        {
            try
            {
                DataTable dt_rst = GET_RST_YMD();

                string rst_ymd = dt_rst.Rows[0].ItemArray[0].ToString();
                string rst_hms = dt_rst.Rows[0].ItemArray[1].ToString();

                SAVE_DATA(tmp_bar_code, tmp_cmp_cd, tmp_op_cd, tmp_rst_div, rst_ymd, rst_hms, tmp_qty);
                save_flg = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
            
        }
        private System.Data.DataTable GET_RST_YMD()
        {
            string Proc_Name = "pkg_sxg_prod_01_select.get_rst_ymd";

            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }        
        private void SAVE_DATA(string arg_bar_code, string arg_cmp_cd, string arg_op_cd, string arg_rst_div, string arg_rst_ymd, string arg_rst_hms, string arg_rst_qty)
        {
            MyOraDB.ReDim_Parameter(8);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_prod_01.save_sxg_prod_pcard";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "arg_bar_code";
            MyOraDB.Parameter_Name[1] = "arg_cmp_cd";
            MyOraDB.Parameter_Name[2] = "arg_op_cd";
            MyOraDB.Parameter_Name[3] = "arg_rst_div";
            MyOraDB.Parameter_Name[4] = "arg_rst_ymd";
            MyOraDB.Parameter_Name[5] = "arg_rst_hms";
            MyOraDB.Parameter_Name[6] = "arg_rst_qty";
            MyOraDB.Parameter_Name[7] = "arg_upd_user";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

            //04. DATA 정의
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close(); 
        }
       
    }
}

