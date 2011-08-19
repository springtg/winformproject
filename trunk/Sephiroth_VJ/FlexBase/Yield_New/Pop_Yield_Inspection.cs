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
    public partial class Pop_Yield_Inspection : COM.PCHWinForm.Pop_Small_Light
    {

        #region 생성자



        private string _Factory;
        private string _StyleCd;



        public Pop_Yield_Inspection(string arg_factory, string arg_stylecd)
        {
            InitializeComponent();


            _Factory = arg_factory;
            _StyleCd = arg_stylecd;
			
            Init_Form();

        }




        #endregion

        #region 멤버 메서드

        private void Init_Form()
        {
            try
            {
                //Title 
                this.Text = "Yield Inspection";
                lbl_MainTitle.Text = "Yield Inspection";


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


            DataTable dt_ret;

            /// 공장코드
            dt_ret = COM.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = _Factory;


            // Style Code
            if (_StyleCd != "")
            {
                dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_String(_StyleCd, " "));
                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
                ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200);
                cmb_StyleCd.SelectedValue = _StyleCd;
                txt_StyleCd.Text = _StyleCd;
            }


            dt_ret.Dispose();




        }





        #endregion 

        #region 이벤트 처리


        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1) return;

                txt_StyleCd.Text = "";
                cmb_StyleCd.SelectedIndex = -1;
                txt_Gender.Text = "";


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        /// <summary>
        /// 스타일 콤보박스 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;



                //-------------------------------------------------------------------------
                // 기타 콘트롤 초기화 
                cmb_StyleCd.SelectedIndex = -1;
                txt_Gender.Text = "";
                //-------------------------------------------------------------------------

                DataTable dt_ret;

                dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " "));

                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
                ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200);

                string stylecd = "";
                int exist_index = -1;

                stylecd = txt_StyleCd.Text.Trim();

                exist_index = txt_StyleCd.Text.IndexOf("-", 0);

                if (exist_index == -1 && stylecd.Length == 9)
                {
                    stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
                }

                cmb_StyleCd.SelectedValue = stylecd;

                dt_ret.Dispose();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;



                //---------------------------------------------------------------------------------------------------
                // 기타 콘트롤 초기화 
                txt_Gender.Text = ""; 
                //---------------------------------------------------------------------------------------------------



                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

                txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
                txt_Gender.Text = cmb_StyleCd.Columns[2].Text + " / " + ((cmb_StyleCd.Columns[3].Text == "N") ? "No" : "Yes");


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_Print_Click(object sender, System.EventArgs e)
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

                bool check_flag = ClassLib.ComFunction.Check_Decimal(txt_Quantity.Text.Trim());
                if (!check_flag) return;


                string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_BC_Yield_Expend");

                string sPara = " /rp ";


                sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ") + "' ";
                sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "") + "' ";
                sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_Quantity, " ") + "' ";

                FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
                MyReport.Text = "Yield Inspection";
                MyReport.Show();




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }




        #endregion   


    }
}