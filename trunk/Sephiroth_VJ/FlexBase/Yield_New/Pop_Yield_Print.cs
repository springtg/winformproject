using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Print : COM.PCHWinForm.Pop_Small_Light
    {

        #region 생성자



        private string _Factory;
        private string _StyleCd;
        private string _StyleName;
        private string _Gender;
        private string _Presto;
        private string _PrintOption;



        public Pop_Yield_Print(string arg_factory, string arg_style_cd, string arg_style_name, string arg_gender, string arg_presto_yn, string arg_print_option)
        {
            InitializeComponent();


            _Factory = arg_factory;
            _StyleCd = arg_style_cd;
            _StyleName = arg_style_name;
            _Gender = arg_gender;
            _Presto = arg_presto_yn;
            _PrintOption = arg_print_option;
			

            Init_Form();

        }




        #endregion

        #region 멤버 메서드

        private void Init_Form()
        {
            try
            {
                //Title 
                this.Text = "Yield Print";
                lbl_MainTitle.Text = "Yield Print";


                ClassLib.ComFunction.SetLangDic(this);

                //컨트롤 세팅
                Init_Control();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Init_Control : 컨트롤 세팅
        /// </summary>
        private void Init_Control()
        {


            txt_Factory.Text = _Factory;
            txt_StyleCd.Text = _StyleCd;
            txt_StyleName.Text = _StyleName;


            DataTable dt_ret;

            // print option
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxFormulaComponent);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PrintOption, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);

            if (dt_ret != null & dt_ret.Rows.Count > 0)
            {
                cmb_PrintOption.SelectedValue = _PrintOption;
            }

            // size
            dt_ret = SELECT_SEM_GEN_SIZE(_Factory, _Gender, _Presto);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Size_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Size_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);

            if (dt_ret != null && dt_ret.Rows.Count > 0)
            {
                cmb_Size_From.SelectedIndex = 0;
                cmb_Size_To.SelectedIndex = 0;
            }

            dt_ret.Dispose();


            cmb_Size_From.Focus();


        }





        #endregion 

        #region 이벤트 처리


        private void btn_Print_Click(object sender, System.EventArgs e)
        {

            string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_BC_Yield");

            string sPara = " /rp ";


            sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_Factory, " ") + "' ";
            sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "") + "' ";
            sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_PrintOption, " ") + "' ";
            sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Size_From, " ") + "' ";
            sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Size_To, " ") + "' ";

            FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
            MyReport.Text = "Print Yield";
            MyReport.Show();


        }


        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }





        #endregion

        #region 디비 연결



        /// <summary>
        /// SELECT_SEM_GEN_SIZE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_gender"></param>
        /// <param name="arg_presto"></param>
        /// <returns></returns>
        private DataTable SELECT_SEM_GEN_SIZE(string arg_factory, string arg_gender, string arg_presto)
        {


            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SEM_COMMON.SELECT_SEM_GEN_SIZE";

                //02.ARGURMENT명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_GEN";
                MyOraDB.Parameter_Name[2] = "ARG_PST_YN";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_gender;
                MyOraDB.Parameter_Values[2] = arg_presto;
                MyOraDB.Parameter_Values[3] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }

        }





        #endregion


    }
}