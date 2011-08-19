using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Input_Value : COM.PCHWinForm.Pop_Small_Light
    {


        #region 생성자


        private string _Cs_SizeF;
        private string _Cs_SizeT;
        private string _YieldValue;
        private string _SpecCd;
        private string _SpecName;


        public Pop_Yield_Input_Value(string arg_size_from, string arg_size_to, string arg_yield_value, string arg_spec, string arg_spec_name)
        {

            InitializeComponent();


            _Cs_SizeF = arg_size_from;
            _Cs_SizeT = arg_size_to;
            _YieldValue = arg_yield_value;
            _SpecCd = arg_spec;
            _SpecName = arg_spec_name;


            Init_Form();

        }


        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();


        //return 또는 cancel 이벤트 체크
        public bool _CancelFlag = true;

        //return 값
        public string _Return_Value = "";
        public string _Return_SpecCode = "";
        public string _Return_SpecName = "";


        #endregion

        #region 멤버 메서드


        private void Init_Form()
        {
            try
            {

                ClassLib.ComFunction.SetLangDic(this);

                //Title
                this.Text = "Yield Value";
                lbl_MainTitle.Text = "Yield Value";


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

            txt_SizeF.Text = _Cs_SizeF;
            txt_SizeT.Text = _Cs_SizeT;
            txt_YieldValue.Text = _YieldValue;
            txt_SpecName.Text = _SpecName;



            // Specification Division Combo List
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, true, ClassLib.ComVar.ComboList_Visible.Name);
            dt_ret.Dispose();


            Set_Spec_Combo();

        }



        /// <summary>
        /// Show_Spec_Popup : Specification Master 폼을 팝업으로 표시
        /// </summary>
        private void Show_Spec_Popup()
        {
            try
            {
                FlexBase.MaterialBase.Form_BC_Spec pop_form = new FlexBase.MaterialBase.Form_BC_Spec();
                pop_form.ShowDialog();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Show_Spec_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         



        /// <summary>
        /// Apply : [Apply] 버튼 이벤트
        /// </summary>
        private void Apply()
        {
            // 숫자형만 입력되도록 처리
            //bool check_flag = ClassLib.ComFunction.Set_NumberTextBox(txt_YieldValue, 18, ""); 

            bool check_flag = ClassLib.ComFunction.Check_Decimal(txt_YieldValue.Text.Trim());

            if (!check_flag) return;

            // specification 필수 조건 처리
            if (cmb_Spec.SelectedIndex == -1)
            {
                check_flag = false;
            }

            if (!check_flag)
            {
                ClassLib.ComFunction.User_Message("Select Specification", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 사이즈 그룹 스펙으로 선택한 경우, From~To 사이즈런과 선택한 스펙이 다를 경우 저장 할 수 없음
            if (cmb_Spec.SelectedValue.ToString().Substring(0, 1) == "1")
            {

                string size_from_to = txt_SizeF.Text.Trim() + "-" + txt_SizeT.Text.Trim();
                string spec_name = cmb_Spec.Columns[1].Text.Trim();

                if (size_from_to != spec_name)
                {
                    check_flag = false;
                }

                if (!check_flag)
                {
                    ClassLib.ComFunction.User_Message("Invaild size spec.", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_SpecName.Focus();
                    return;
                }


            }


            _CancelFlag = false;
            this.Close();
        }



        /// <summary>
        /// Set_Return_Parameter : 리턴 파라미터 설정
        /// </summary>
        private void Set_Return_Parameter()
        {
            try
            {

                if (_CancelFlag)
                {

                    _Return_Value = "";
                    _Return_SpecCode = "";
                    _Return_SpecName = "";

                }
                else
                {

                    _Return_Value = txt_YieldValue.Text;
					_Return_SpecCode = cmb_Spec.SelectedValue.ToString();
                    _Return_SpecName = cmb_Spec.Columns[1].Text;

                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Set_Return_Parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        #region 이벤트 처리


        private void txt_YieldValue_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;

                Apply();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_SpecName_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_SpecName_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;

                Set_Spec_Combo();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_SpecName_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void Set_Spec_Combo()
        {


            string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
            string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, " ");
            string use_yn = "Y";


            //Select_SBC_SPEC_COMMON(spec div, spec name, ues_yn)
            DataTable dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_SPEC_COMMON(spec_div, spec_name, use_yn);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Spec, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
            dt_ret.Dispose();

            if (cmb_Spec.ListCount == 0)
            {
                //cmb_Spec.SelectedIndex = -1;
                cmb_Spec.SelectedText = "";
            }
            else
            {
                cmb_Spec.SelectedIndex = cmb_Spec.FindStringExact(txt_SpecName.Text.Trim(), 0, 1);
            }
            

        }



        private void cmb_SpecDiv_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
               
                if (cmb_SpecDiv.SelectedIndex == -1) return;

               Set_Spec_Combo();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cmb_SpecDiv_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_SearchSpec_Click(object sender, System.EventArgs e)
        {
            Show_Spec_Popup();
        }



        private void btn_Apply_Click(object sender, System.EventArgs e)
        {
            try
            {
                Apply();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            _CancelFlag = true;
            this.Close();
        }


        private void Pop_Input_Value_New_FormClosing(object sender, FormClosingEventArgs e)
        {
            Set_Return_Parameter();
        }


        #endregion

       
    }
}