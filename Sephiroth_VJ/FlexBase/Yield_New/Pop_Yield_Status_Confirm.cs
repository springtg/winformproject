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
    public partial class Pop_Yield_Status_Confirm : COM.PCHWinForm.Pop_Small_Light
    {

        #region 생성자



        private string _Factory;
        private string _StyleCd;
        private string _YieldStatus;
        private string _YieldStatusDesc;



        public Pop_Yield_Status_Confirm(string arg_factory, string arg_stylecd, string arg_yieldstatus, string arg_yieldstatus_desc)
        {
            InitializeComponent();


            _Factory = arg_factory;
            _StyleCd = arg_stylecd;
            _YieldStatus = arg_yieldstatus;
            _YieldStatusDesc = arg_yieldstatus_desc; 

			
            Init_Form();

        }




        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();


        //return 또는 cancel 이벤트 체크
        public bool _CancelFlag = true;


        #endregion

        #region 멤버 메서드

        private void Init_Form()
        {
            try
            {
                //Title 
                this.Text = "Yield Status";
                lbl_MainTitle.Text = "Yield Status";


                ClassLib.ComFunction.SetLangDic(this);


                txt_Status.Text = _YieldStatusDesc;


                dpick_ConfirmYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
                dpick_ConfirmYMD.Text = DateTime.Now.ToString(ClassLib.ComVar.This_SetedDateType);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        /// <summary>
        /// Apply : [Apply] 버튼 이벤트
        /// </summary>
        private void Apply()
        {



            string division= "I"; 
            string factory = _Factory; 
            string style_cd = _StyleCd; 
            string yield_status_key = _YieldStatus; 
            string yield_status = _YieldStatus;
            ClassLib.ComFunction myFunction = new ClassLib.ComFunction();
            string confirm_ymd = myFunction.ConvertDate2DbType(dpick_ConfirmYMD.Text);
            string remarks = txt_Remarks.Text.Trim();


            bool save_flag = FlexBase.Yield_New.Form_BC_Yield_Status.SAVE_SBC_YIELD_STATUS(division, factory, style_cd, yield_status_key, yield_status, confirm_ymd, remarks);


            if (!save_flag)
            {
                _CancelFlag = true;
            }
            else
            {
                _CancelFlag = false;
                this.Close();
            }


        }




        #endregion

        #region 이벤트 처리

        #region 버튼클릭시 이미지변경


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            Label src = sender as Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            Label src = sender as Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Label src = sender as Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Label src = sender as Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }




        #endregion

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



        #endregion

        #region DB Connect


     


        #endregion 





    }
}