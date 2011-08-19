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
    public partial class Pop_Yield_Joint_Template : COM.PCHWinForm.Pop_Small_Light
    {


        #region 생성자


        public Pop_Yield_Joint_Template()
        {
            InitializeComponent();


            Init_Form();

        }


        #endregion

        #region 변수 정의


        COM.OraDB MyOraDB = new COM.OraDB();


        //return 또는 cancel 이벤트 체크
        public bool _CancelFlag = true;

        //return 되는 joint template 구조
        public string _JointTemplate = "";
        public string _JointTemplateLoading = "";



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
                this.Text = "Select Joint Template";
                lbl_MainTitle.Text = "Select Joint Template";

                ClassLib.ComFunction.SetLangDic(this);


                //combobox setting
                Init_Control();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Init_Control : combobox setting
        /// </summary>
        private void Init_Control()
        {

            try
            {

                // 그리드 설정 
                fgrid_Main.Set_Grid("SBC_YIELD_JOINT_TEMPLATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                fgrid_Main.Font = new Font("Verdana", 8);


                string template_tree_name = "";
                string favorite_yn = (chk_Favorite.Checked) ? "Y" : "";
                DataTable dt_ret = SELECT_SBC_YIELD_JOINT_BOM_H(template_tree_name, favorite_yn);
                fgrid_Main.Display_Grid(dt_ret, false);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        #endregion

        #region 이벤트 처리


        /// <summary>
        /// txt_Name_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_Name_KeyUp(e);
        }



        /// <summary>
        /// fgrid_DoubleClick : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_DoubleClick(object sender, EventArgs e)
        {
            Event_fgrid_DoubleClick(sender);
        }



        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Event_btn_Cancel_Click();
        }



        /// <summary>
        /// Event_chk_Favorite_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Favorite_CheckedChanged(object sender, EventArgs e)
        {
            Event_chk_Favorite_CheckedChanged();
        }



        #endregion

        #region 멤버 메서드


        /// <summary>
        /// Event_txt_Name_KeyUp : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_txt_Name_KeyUp(KeyEventArgs e)
        {


            try
            {

                if (e.KeyCode != Keys.Enter) return;


                string template_tree_name = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ");
                string favorite_yn = (chk_Favorite.Checked) ? "Y" : "";
                DataTable dt_ret = SELECT_SBC_YIELD_JOINT_BOM_H(template_tree_name, favorite_yn);
                fgrid_Main.Display_Grid(dt_ret, false);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_Name_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_fgrid_DoubleClick : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_fgrid_DoubleClick(object sender)
        {


            try
            {

                COM.FSP src = sender as COM.FSP;

                _JointTemplate = (src[src.Row, (int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_HEAD_NEW.IxTEMPLATE_TREE_CD] == null) ? "" : src[src.Row, (int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_HEAD_NEW.IxTEMPLATE_TREE_CD].ToString();
                _JointTemplateLoading = (src[src.Row, (int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_HEAD_NEW.IxTEMPLATE_ORDER] == null) ? "" : src[src.Row, (int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_HEAD_NEW.IxTEMPLATE_ORDER].ToString();

                _CancelFlag = false;

                this.Close();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        private void Event_btn_Cancel_Click()
        {

            try
            {

                _CancelFlag = true;

                this.Close();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_chk_Favorite_CheckedChanged : 
        /// </summary>
        private void Event_chk_Favorite_CheckedChanged()
        {

            string template_tree_name = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ");
            string favorite_yn = (chk_Favorite.Checked) ? "Y" : "";
            DataTable dt_ret = SELECT_SBC_YIELD_JOINT_BOM_H(template_tree_name, favorite_yn);
            fgrid_Main.Display_Grid(dt_ret, false);

        }




        #endregion

        #region 디비 연결


        /// <summary>
        /// SELECT_SBC_YIELD_JOINT_BOM_H : 
        /// </summary>
        /// <param name="arg_template_tree_name"></param>
        /// <param name="arg_favorite_yn"></param>
        /// <returns></returns>
        private DataTable SELECT_SBC_YIELD_JOINT_BOM_H(string arg_template_tree_name, string arg_favorite_yn)
        {


            try
            {


                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD_JOINT_BOM_H";

                MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_NAME";
                MyOraDB.Parameter_Name[1] = "ARG_FAVORITE_YN";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_template_tree_name;
                MyOraDB.Parameter_Values[1] = arg_favorite_yn;
                MyOraDB.Parameter_Values[2] = "";


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