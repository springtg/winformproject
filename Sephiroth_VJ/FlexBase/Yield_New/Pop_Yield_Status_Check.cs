using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Status_Check : COM.PCHWinForm.Pop_Large_Light
    {
         

        #region 생성자


        public Pop_Yield_Status_Check()
        {
            InitializeComponent();


            Init_Form(); 

        }

         


        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction MyComFunction = new COM.ComFunction();

        #endregion

        #region 멤버 메서드



        private void Init_Form()
        {
            try
            {

                //Title
                this.Text = "Check Status";
                lbl_MainTitle.Text = "Check Status";

                ClassLib.ComFunction.SetLangDic(this);


                // control setting
                Init_Control();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Init_Control : textbox, combobox setting
        /// </summary>
        private void Init_Control()
        {


            // toolbar button disable setting
            tbtn_Save.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled = false;



            // 그리드 설정
            fgrid_Main.Set_Grid("SBC_YIELD_CHECK_STATUS_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Main.Font = new Font("Verdana", 8);
            fgrid_Main.Styles.Frozen.BackColor = Color.White;
            //fgrid_Main.Styles.Alternate.BackColor = Color.White;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.ExtendLastCol = false;


            dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
            dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;

            //dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd")); 
            //dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd")); 



            // 공장코드
            DataTable dt_ret = COM.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;



        }


        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {

            if (cmb_Factory.SelectedIndex == -1) return;


            //fgrid_Main.ClearAll();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


            // Value Status ComboBox Add Items 
            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, ClassLib.ComVar.This_Factory);
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxYieldStatus);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_YieldStatus, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);

        }


        /// <summary>
        /// Event_dpick_FromYMD_ValueChanged : 
        /// </summary>
        private void Event_dpick_FromYMD_ValueChanged()
        {

            dpick_ToYMD.Value = dpick_FromYMD.Value;

        }


        /// <summary>
        /// Event_dpick_ToYMD_ValueChanged : 
        /// </summary>
        private void Event_dpick_ToYMD_ValueChanged()
        {

            //fgrid_Main.ClearAll();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

        }


        /// <summary>
        /// Event_cmb_YieldStatus_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_YieldStatus_SelectedValueChanged()
        {

            //fgrid_Main.ClearAll();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

        }


        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary>
        private void Event_txt_StyleCd_KeyUp()
        {

            cmb_StyleCd.SelectedIndex = -1;
            //fgrid_Main.ClearAll();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;



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



        /// <summary>
        /// Event_cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_StyleCd_SelectedValueChanged()
        {

            //fgrid_Main.ClearAll();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
            txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();

        }




        /// <summary>
        /// Event_tbtn_New_Click : 
        /// </summary>
        private void Event_tbtn_New_Click()
        {

            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
            dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
            dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd"));
            dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd"));

            cmb_YieldStatus.SelectedIndex = -1;
            txt_StyleCd.Text = "";
            cmb_StyleCd.SelectedIndex = -1;


            //fgrid_Main.ClearAll();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


        }



        /// <summary>
        /// Event_tbtn_Search_Click : 
        /// </summary>
        private void Event_tbtn_Search_Click()
        {

            string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
            string job_date_from = dpick_FromYMD.Value.ToString("yyyyMMdd");
            string job_date_to = dpick_ToYMD.Value.ToString("yyyyMMdd");
            string yield_status = ClassLib.ComFunction.Empty_Combo(cmb_YieldStatus, " ");
            //string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");
            string style_cd = txt_StyleCd.Text.Replace("-", "");


            DataTable dt_ret = SELECT_SBC_YIELD_CHECK_STATUS(factory, job_date_from, job_date_to, yield_status, style_cd);
            fgrid_Main.Display_Grid(dt_ret, false);

             

        }




        #endregion

        #region 이벤트 처리


        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                Event_tbtn_New_Click();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                Event_tbtn_Search_Click();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                Event_cmb_Factory_SelectedValueChanged();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                Event_dpick_FromYMD_ValueChanged();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_dpick_FromYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                Event_dpick_ToYMD_ValueChanged();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_dpick_ToYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_YieldStatus_SelectedValueChanged(object sender, System.EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                Event_cmb_YieldStatus_SelectedValueChanged();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_YieldStatus_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                if (e.KeyCode != Keys.Enter) return;

                Event_txt_StyleCd_KeyUp();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                Event_cmb_StyleCd_SelectedValueChanged();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #region 디비 연결



        /// <summary>
        /// SELECT_SBC_YIELD_CHECK_STATUS : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_job_date_from"></param>
        /// <param name="arg_job_date_to"></param>
        /// <param name="arg_yield_status"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SBC_YIELD_CHECK_STATUS(string arg_factory,
            string arg_job_date_from,
            string arg_job_date_to,
            string arg_yield_status,
            string arg_style_cd)
        {


            try
            {


                MyOraDB.ReDim_Parameter(6);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD_CHECK_STATUS";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_JOB_DATE_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_JOB_DATE_TO";
                MyOraDB.Parameter_Name[3] = "ARG_YIELD_STATUS";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_job_date_from;
                MyOraDB.Parameter_Values[2] = arg_job_date_to;
                MyOraDB.Parameter_Values[3] = arg_yield_status;
                MyOraDB.Parameter_Values[4] = arg_style_cd;
                MyOraDB.Parameter_Values[5] = ""; 


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