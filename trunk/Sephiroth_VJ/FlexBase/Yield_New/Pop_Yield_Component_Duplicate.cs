﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.Yield_New
{
    public partial class  Pop_Yield_Component_Duplicate : COM.PCHWinForm.Pop_Small_Light
    {


        #region 생성자


        DataTable _DT = null;


        public  Pop_Yield_Component_Duplicate(DataTable arg_dt)
        {
            InitializeComponent();


            _DT = arg_dt;

            Init_Form();

        }


        #endregion

        #region 변수 정의
         
         
        #endregion

        #region 멤버 메서드



        /// <summary>
        /// Init_Form : 
        /// </summary>
        private void Init_Form()
        {

            try
            {


                //Title
                this.Text = "Yield Search - duplicate component";
                lbl_MainTitle.Text = "Yield Search - duplicate component";

                ClassLib.ComFunction.SetLangDic(this);

                
                Init_Control();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Init_Control :
        /// </summary>
        private void Init_Control()
        {

            try
            {

                chk_TopMost.Checked = true;


                // 그리드 설정 
                fgrid_Main.Set_Grid("SBC_YIELD_COMPONENT_DUPLICATE_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                fgrid_Main.Font = new Font("Verdana", 8);

                fgrid_Main.Display_Grid(_DT, false);

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        #endregion

        #region 이벤트 처리


        /// <summary>
        /// btn_Cancel_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Event_btn_Cancel_Click();
        }



        /// <summary>
        /// Event_chk_TopMost_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            Event_chk_TopMost_CheckedChanged();
        }


        #endregion

        #region 멤버 메서드



        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        private void Event_btn_Cancel_Click()
        {

            try
            {

                this.Close();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_chk_TopMost_CheckedChanged : 
        /// </summary>
        private void Event_chk_TopMost_CheckedChanged()
        {

            try
            {

                if (chk_TopMost.Checked)
                {
                    this.TopMost = true;
                }
                else
                {
                    this.TopMost = false;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_chk_TopMost_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        #endregion  

        #region 디비 연결


        
        #endregion

        

    }
}