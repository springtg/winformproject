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
    public partial class Form_BC_Yield_Status : COM.PCHWinForm.Form_Top_Light
    {

        #region 생성자



        public Form_BC_Yield_Status()
        {

            InitializeComponent();

            Init_Form();

        }


         

        #endregion

        #region 변수 정의


        COM.OraDB MyOraDB = new COM.OraDB();
         

        #endregion

        #region 이벤트 처리



        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_StyleCd_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_StyleCd_KeyUp(e);
        }


        /// <summary>
        /// cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
        {
            Event_cmb_StyleCd_SelectedValueChanged();
        }


        /// <summary>
        /// tbtn_New_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Event_Tbtn_New_Click();
        }
         

        /// <summary>
        /// tbtn_Search_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Event_tbtn_Search_Click();
        }


        /// <summary>
        /// tbtn_Save_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Event_tbtn_Save_Click();
        }



        /// <summary>
        /// contextMenu_Main_Opening : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenu_Main_Opening(object sender, CancelEventArgs e)
        {
            Event_contextMenu_Main_Opening();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_Insert_Click(object sender, EventArgs e)
        {
            Event_menuItem_Insert_Click();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_Delete_Click(object sender, EventArgs e)
        {
            Event_menuItem_Delete_Click();
        }

        
        
        /// <summary>
        /// display depth 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rad_CheckedChanged(object sender, System.EventArgs e)
        {
            Event_rad_CheckedChanged(sender);
        }



        /// <summary>
        /// Event_fgrid_Main_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Main_Click(object sender, EventArgs e)
        {
            Event_fgrid_Main_Click();
        }



        /// <summary>
        /// fgrid_Main_StartEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Main_StartEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Main_StartEdit();
        }



        /// <summary>
        /// fgrid_Main_AfterEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Main_AfterEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Main_AfterEdit();
        }



        /// <summary>
        /// checkedListBox_Status_ItemCheck : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox_Status_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Event_checkedListBox_Status_ItemCheck(e);
        }


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
                this.Text = "Yield Status";
                lbl_MainTitle.Text = "Yield Status";

                ClassLib.ComFunction.SetLangDic(this);



                //combobox setting
                Init_Control();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private DataTable _DT_YieldStatus;


        /// <summary>
        /// Init_Control : combobox setting
        /// </summary>
        private void Init_Control()
        {

            try
            {


                // toolbar button disable setting
                tbtn_Delete.Enabled = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled = false;
                tbtn_Print.Enabled = false;



                // 그리드 설정 
                fgrid_Main.Set_Grid("SBC_YIELD_STATUS_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Main.Set_Action_Image(img_Action);
                fgrid_Main.Font = new Font("Verdana", 8);
                fgrid_Main.Styles.Frozen.BackColor = Color.White;
                fgrid_Main.Styles.Alternate.BackColor = Color.White;
                fgrid_Main.AllowSorting = AllowSortingEnum.None;


                //// yield status visible checkbox
                //checkedListBox_Status.CheckOnClick = true;
                //checkedListBox_Status.MultiColumn = true;

                //DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxYieldStatus);
                //// 1 : code, 2 : name

                //string yield_status = "";

                //for (int i = 0; i < dt_ret.Rows.Count; i++)
                //{
                     
                //    yield_status = (dt_ret.Rows[i].ItemArray[2] == null) ? "" : dt_ret.Rows[i].ItemArray[2].ToString();

                //    checkedListBox_Status.Items.Add(yield_status, CheckState.Checked);

                //} // end for i


                //_DT_YieldStatus = dt_ret;
              

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_tbtn_Search_Click : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_txt_StyleCd_KeyUp(KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode != Keys.Enter) return;

                Init_Cmb_Style();


                //// 데이터 조회
                //Event_tbtn_Search_Click();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Init_Cmb_Style : 
        /// </summary>
        private void Init_Cmb_Style()
        {



            // 기타 콘트롤 초기화 
            cmb_StyleCd.SelectedIndex = -1;
            txt_Gender.Text = "";


            string factory = "";
            string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "");


            DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SDC_STYLE(factory, style_cd);



            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
            ClassLib.ComCtl.Set_ComboList_Multi(dt_ret, cmb_StyleCd, new int[] { 0, 1, 2, 3, 4, 5 }, false);
            string[] titles = new string[] { "CODE", "NAME", "GENDER", "PRESTO", "MODEL_NAME", "YIELD_STATUS" };
            int[] width = new int[] { 80, 100, 100, 100, 100, 100 };
            bool[] visible = new bool[] { true, true, false, false, false, false };
            ClassLib.ComCtl.SetComboStyle(cmb_StyleCd, titles, width, visible, "NAME");
            cmb_StyleCd.DropDownWidth = 226;



            int exist_index = txt_StyleCd.Text.IndexOf("-", 0);

            if (exist_index == -1 && style_cd.Length == 9)
            {
                style_cd = style_cd.Substring(0, 6) + "-" + style_cd.Substring(6, 3);
            }


            cmb_StyleCd.SelectedValue = style_cd;

            dt_ret.Dispose();



        }


        /// <summary>
        /// Event_cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_StyleCd_SelectedValueChanged()
        {


            try
            {


                if (cmb_StyleCd.SelectedIndex == -1) return;


                txt_Gender.Text = "";


                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
                txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
                txt_Gender.Text = cmb_StyleCd.Columns[2].Text + " / " + ((cmb_StyleCd.Columns[3].Text == "N") ? "No" : "Yes");


                //// 데이터 조회
                //Event_tbtn_Search_Click();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_Tbtn_New_Click : 컨트롤 초기화
        /// </summary>
        private void Event_Tbtn_New_Click()
        {

            try
            {

                _DT_YieldStatus = null;
                checkedListBox_Status.Items.Clear();

                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_tbtn_Search_Click : 
        /// </summary>
        private void Event_tbtn_Search_Click()
        {

            try
            {


                if (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "") == "") return;



                int last_top_row = fgrid_Main.TopRow;
                int last_sel_row = fgrid_Main.Row;
                int last_sel_col = fgrid_Main.Col;



                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

                string factory = "";
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                string yield_status = "";

                DataTable dt_ret = SELECT_SBC_YIELD_STATUS(factory, style_cd, yield_status);

                if (dt_ret == null || dt_ret.Rows.Count == 0) return;

                fgrid_Main.Display_Grid(dt_ret, false);


                ////---------------------------------------------------
                //// merge
                ////---------------------------------------------------
                //fgrid_Main.AllowMerging = AllowMergingEnum.Free;

                //for (int i = 0; i < fgrid_Main.Cols.Count; i++)
                //{
                //    fgrid_Main.Cols[i].AllowMerging = false;
                //}

                //for (int i = (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD; i < (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY; i++)
                //{
                //    fgrid_Main.Cols[i].AllowMerging = true;
                //}
                ////---------------------------------------------------


                //---------------------------------------------------
                // subtotal
                //---------------------------------------------------
                fgrid_Main.Tree.Column = (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD;

                fgrid_Main.Subtotal(AggregateEnum.Clear);
                fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;
                
                fgrid_Main.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
                fgrid_Main.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
                fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
                fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;

                // style
                fgrid_Main.Subtotal(AggregateEnum.Max, 0, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD, "{0}");
                // factory
                fgrid_Main.Subtotal(AggregateEnum.Max, 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD, "{0}");
             
             
                // subtotal row 수정 불가 처리
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (!fgrid_Main.Rows[fgrid_Main.Row].IsNode) continue;


                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] == null
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString().Trim() == "")
                    {
                        fgrid_Main.Rows[i].AllowEditing = false;
                    }

                }
                //---------------------------------------------------

                if (rad_Style.Checked)
                {
                    fgrid_Main.Tree.Show(0);
                }
                else
                {
                    fgrid_Main.Tree.Show(-1);
                }



                //-----------------------------------
                // status 전부 표시
                //-----------------------------------
                // yield status visible checkbox

                _DT_YieldStatus = null;
                checkedListBox_Status.Items.Clear();

                checkedListBox_Status.CheckOnClick = true;
                checkedListBox_Status.MultiColumn = true;

                dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxYieldStatus);
                // 1 : code, 2 : name

                string yield_status_list = "";

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {

                    yield_status_list = (dt_ret.Rows[i].ItemArray[2] == null) ? "" : dt_ret.Rows[i].ItemArray[2].ToString();

                    checkedListBox_Status.Items.Add(yield_status_list, CheckState.Checked);

                } // end for i 

                _DT_YieldStatus = dt_ret;
                //-----------------------------------



                //-----------------------------------
                // 조회 후 focus 행 유지
                //-----------------------------------
                last_top_row = (last_top_row < fgrid_Main.Rows.Fixed) ? fgrid_Main.Rows.Fixed : last_top_row;
                last_top_row = (last_top_row >= fgrid_Main.Rows.Count) ? fgrid_Main.Rows.Count - 1 : last_top_row;

                last_sel_row = (last_sel_row < fgrid_Main.Rows.Fixed) ? fgrid_Main.Rows.Fixed : last_sel_row;
                last_sel_row = (last_sel_row >= fgrid_Main.Rows.Count) ? fgrid_Main.Rows.Count - 1 : last_sel_row;

                fgrid_Main.TopRow = last_top_row;
                fgrid_Main.Select(last_sel_row, last_sel_col, false);
                //-----------------------------------



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        // check in, out class
        // check in 일 때만 객체 생성
        ClassLib.Class_Check_InOut class_check_inout;



        /// <summary>
        /// Event_tbtn_Save_Click : 
        /// </summary>
        private void Event_tbtn_Save_Click()
        {

            try
            {


                this.Cursor = Cursors.WaitCursor;


                //-------------------------------------------------------
                // main yield register check out
                //-------------------------------------------------------
                FlexBase.Yield_New.Form_BC_Yield yield_upper_new_form;

                foreach (Form f in ClassLib.ComVar.MDI_Parent.MdiChildren)
                {


                    if (f.Name.ToString() == "Form_BC_Yield")
                    {

                        yield_upper_new_form = (FlexBase.Yield_New.Form_BC_Yield)f;

                        if (yield_upper_new_form.chk_CheckInOut.Checked)
                        {
                            f.Activate();
                            ClassLib.ComFunction.User_Message("Need Check Out [Yield Register].", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;
                        }
                    } // end if


                } // end foreach
                //-------------------------------------------------------


                // save
                //-------------------------------------------------------
                // check condition
                //-------------------------------------------------------
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (fgrid_Main[i, 0] == null || fgrid_Main[i, 0].ToString() == "")
                    {
                        continue;
                    }

                    // factory
                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY] == null
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY].ToString().Trim() == "")
                    {

                        string message = "We must input factory.";
                        ClassLib.ComFunction.User_Message(message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Main.TopRow = i - 5;
                        fgrid_Main.Select(i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY, false);
                        return;

                    }

                    // yield status
                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] == null
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString().Trim() == "")
                    {

                        string message = "We must input yield status.";
                        ClassLib.ComFunction.User_Message(message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Main.TopRow = i - 5;
                        fgrid_Main.Select(i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS, false);
                        return;

                    }

                    // confirm date
                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD] == null
                       || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD].ToString().Trim() == "")
                    {

                        string message = "We must input confirm date.";
                        ClassLib.ComFunction.User_Message(message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Main.TopRow = i - 5;
                        fgrid_Main.Select(i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD, false);
                        return;
                    }


                }
                //-------------------------------------------------------


                //-------------------------------------------------------
                // save
                //-------------------------------------------------------
                bool check_ok = false;


                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {


                    if (fgrid_Main[i, 0] == null || fgrid_Main[i, 0].ToString() == "")
                    {
                        continue;
                    }


                    string division = fgrid_Main[i, 0].ToString();
                    string factory = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY].ToString();
                    string style_cd = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD].ToString().Replace("-", "");
                    string yield_status_key = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS_KEY] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS_KEY].ToString();
                    string yield_status = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString();
                    string confirm_ymd = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD].ToString();
                    string remarks = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxREMARKS] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxREMARKS].ToString();



                    //-------------------------------------------
                    // check in
                    //-------------------------------------------
                    class_check_inout = new FlexBase.ClassLib.Class_Check_InOut();


                    //string where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd + @"' AND COMPONENT_CD LIKE 'C%'";
                    string where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd + @"'";

                    class_check_inout._CheckDivision = "I";
                    class_check_inout._CheckFactory = ClassLib.ComVar.This_Factory;
                    class_check_inout._CheckUser = ClassLib.ComVar.This_User;
                    class_check_inout._CheckRemark = "yield status";
                    class_check_inout._CheckWhere = where;
                    class_check_inout._ShowMessage = false;
                    class_check_inout._Factory = factory;
                    class_check_inout._StyleCd = style_cd;
                    class_check_inout._IncludeInfoTable = "Y";
                    class_check_inout._IncludeValueTable = "N";
                    class_check_inout._IncludeHistoryTable = "N";


                    check_ok = class_check_inout.Run_Check_InOut();

                    if (!check_ok)
                    {
                        continue;
                    }
                    //-------------------------------------------


                    //-------------------------------------------
                    // run
                    //-------------------------------------------
                    bool save_flag = FlexBase.Yield_New.Form_BC_Yield_Status.SAVE_SBC_YIELD_STATUS(division, factory, style_cd, yield_status_key, yield_status, confirm_ymd, remarks);

                    if (!save_flag)
                    {
                    }
                    else
                    {
                    }
                    //-------------------------------------------


                    //-----------------------------------------
                    // check out
                    //-----------------------------------------
                    class_check_inout._CheckDivision = "O";
                    class_check_inout._CheckRemark = "check out";

                    check_ok = class_check_inout.Run_Check_InOut();

                    if (!check_ok)
                    {
                    }
                    else
                    {
                    }
                    //-----------------------------------------



                } // end for i
                //-------------------------------------------------------


                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

                Event_tbtn_Search_Click();



                //-------------------------------------------------------
                // main yield register refresh
                //-------------------------------------------------------
                foreach (Form f in ClassLib.ComVar.MDI_Parent.MdiChildren)
                {


                    if (f.Name.ToString() == "Form_BC_Yield")
                    {

                        yield_upper_new_form = (FlexBase.Yield_New.Form_BC_Yield)f;

                        //f.Activate();
                        yield_upper_new_form.Event_txt_StyleCd_KeyUp();

                    } // end if


                } // end foreach
                //-------------------------------------------------------



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }




        /// <summary>
        /// Event_contextMenu_Main_Opening : 
        /// </summary>
        private void Event_contextMenu_Main_Opening()
        {

            try
            {

                //if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed)
                //{
                //    menuItem_Insert.Visible = true;
                //    menuItem_Update.Visible = false;
                //    menuItem_Delete.Visible = false;
                //}
                //else
                //{
                   
                //    // style level만 작업 가능
                //    if (fgrid_Main.Rows[fgrid_Main.Row].IsNode
                //        && fgrid_Main.Rows[fgrid_Main.Row].Node.Level == 0)
                //    {
                //        menuItem_New.Visible = true;
                //        menuItem_Insert.Visible = true;
                //        menuItem_Update.Visible = true;
                //        menuItem_Delete.Visible = true;
                //    }
                //    else
                //    {
                //        menuItem_New.Visible = false;
                //        menuItem_Insert.Visible = false;
                //        menuItem_Update.Visible = false;
                //        menuItem_Delete.Visible = false;
                //    }

                //}


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_contextMenu_Main_Opening", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_menuItem_Insert_Click : 
        /// </summary>
        private void Event_menuItem_Insert_Click()
        {

            try
            {
                Set_Status_Insert();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Event_menuItem_Delete_Click : 
        /// </summary>
        private void Event_menuItem_Delete_Click()
        {

            try
            {
                Set_Status_Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Set_Status_Insert : 
        /// </summary>
        private void Set_Status_Insert()
        {

            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) // 신규 등록
            {

                if (cmb_StyleCd.SelectedIndex == -1) return;


                fgrid_Main.Rows.Add();

                fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "I";

                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD] = cmb_StyleCd.SelectedValue.ToString();
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_NAME] = cmb_StyleCd.Columns[1].Text;
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxGENDER] = cmb_StyleCd.Columns[2].Text + "/ " + cmb_StyleCd.Columns[3].Text;
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxPRESTO_YN] = cmb_StyleCd.Columns[3].Text;

                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY] = "";
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxUPD_YMD] = System.DateTime.Now.ToString();
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;


            }
            else // 기존 추가
            {

                // subtotal 말고 데이터 선택해야 실행되도록
                if (fgrid_Main.Rows[fgrid_Main.Row].IsNode) return;


                int sel_row = fgrid_Main.Row;
                int insert_row = fgrid_Main.Row + 1;

                fgrid_Main.Rows.Insert(insert_row);

                fgrid_Main[insert_row, 0] = "I";
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD] = (fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD] == null) ? "" : fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD].ToString();
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_NAME] = (fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_NAME] == null) ? "" : fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_NAME].ToString();
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxGENDER] = (fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxGENDER] == null) ? "" : fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxGENDER].ToString();
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxPRESTO_YN] = (fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxPRESTO_YN] == null) ? "" : fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxPRESTO_YN].ToString();
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY] = "";
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxUPD_YMD] = System.DateTime.Now.ToString();
                fgrid_Main[insert_row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;


            } // end if


        }

        
        /// <summary>
        /// Set_Status_Update : 
        /// </summary>
        private void Set_Status_Update()
        {

            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;



            //-------------------------------------------
            // check duplication
            //-------------------------------------------
            // DB Check
            string sel_factory = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY].ToString();
            string sel_style_cd = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD].ToString();
            string sel_yield_status = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString();


            DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield_Status.SELECT_SBC_YIELD_STATUS(sel_factory, sel_style_cd, sel_yield_status);

            if (dt_ret != null && dt_ret.Rows.Count > 0)
            {

                string message = "We already input yield status.";
                ClassLib.ComFunction.User_Message(message, "Set_Status_Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fgrid_Main.TopRow = fgrid_Main.Row - 5;
                fgrid_Main.Select(fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS, false);


                if (fgrid_Main[fgrid_Main.Row, 0] != null && fgrid_Main[fgrid_Main.Row, 0].ToString() == "I")
                {
                    fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] = "";
                }
                else
                {
                    fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] = fgrid_Main.Buffer_CellData;
                }


                return;

            }


            // Grid Check
            int row_style_cd = fgrid_Main.FindRow(sel_style_cd, fgrid_Main.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD, false, true, false);
            if (row_style_cd == -1) return;

            int row_factory = fgrid_Main.FindRow(sel_factory, fgrid_Main.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY, false, true, false);
            if (row_factory == -1) return;


            string now_factory = "";
            string now_style_cd = "";
            string now_yield_status = "";


            for (int i = row_factory; i < fgrid_Main.Rows.Count; i++)
            {


                // subtotal 말고
                if (fgrid_Main.Rows[i].IsNode) continue;


                now_factory = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY].ToString();
                now_style_cd = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxSTYLE_CD].ToString();
                now_yield_status = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString();

                if (now_factory != sel_factory || now_style_cd != sel_style_cd) continue;


                if (i != fgrid_Main.Row && now_yield_status == sel_yield_status)
                {

                    string message = "We already input yield status.";
                    ClassLib.ComFunction.User_Message(message, "Set_Status_Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fgrid_Main.TopRow = fgrid_Main.Row - 5;
                    fgrid_Main.Select(fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS, false);


                    if (fgrid_Main[fgrid_Main.Row, 0] != null && fgrid_Main[fgrid_Main.Row, 0].ToString() == "I")
                    {
                        fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] = "";
                    }
                    else
                    {
                        fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] = fgrid_Main.Buffer_CellData;
                    }

                    return;

                }


            }
            //-------------------------------------------

          
            fgrid_Main.Update_Row();



        }


        /// <summary>
        /// Set_Status_Delete : 
        /// </summary>
        private void Set_Status_Delete()
        {

            if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


            for (int i = fgrid_Main.Rows.Count - 1; i >= fgrid_Main.Rows.Fixed; i--)
            {


                // subtotal 말고 데이터 선택해야 실행되도록
                if (fgrid_Main.Rows[i].IsNode) continue;

                // 선택된것만 삭제하기 위함
                if (fgrid_Main.Rows[i].Selected == false) continue;


                if (fgrid_Main[i, 0] != null && fgrid_Main[i, 0].ToString() == "I")
                {
                    fgrid_Main.Rows.Remove(i);
                }
                else
                {
                    fgrid_Main[i, 0] = "D";
                }


            } // end for i


        }
        


        /// <summary>
        /// Event_rad_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_rad_CheckedChanged(object sender)
        {

            try
            {
                RadioButton src = sender as RadioButton;

                //라디오 버튼 태그값에 레벨값 세팅
                //rad_style.tag = '0'
                //rad_all.tag = '-1'

                fgrid_Main.Tree.Show(Convert.ToInt32(src.Tag.ToString()));

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_fgrid_Main_Click : 
        /// </summary>
        private void Event_fgrid_Main_Click()
        {

            try
            {

                if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


                // subtotal 수정 불가
                bool editing_flag = false;

                if (fgrid_Main.Rows[fgrid_Main.Row].IsNode)
                {
                    editing_flag = false;
                }
                else
                { 
                    editing_flag = true;
                }
                

                fgrid_Main.Cols[(int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxFACTORY].AllowEditing = editing_flag;
                fgrid_Main.Cols[(int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].AllowEditing = editing_flag;
                fgrid_Main.Cols[(int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD].AllowEditing = editing_flag;
                fgrid_Main.Cols[(int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxREMARKS].AllowEditing = editing_flag;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_fgrid_Main_StartEdit : 
        /// </summary>
        private void Event_fgrid_Main_StartEdit()
        {

            try
            {

                fgrid_Main.Buffer_CellData = fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_StartEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Event_fgrid_Main_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Main_AfterEdit()
        {

            try
            { 
                Set_Status_Update(); 
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_checkedListBox_Status_ItemCheck : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_checkedListBox_Status_ItemCheck(ItemCheckEventArgs e)
        {
           
            try
            {

                if (_DT_YieldStatus == null) return;


                string yield_status = checkedListBox_Status.Items[e.Index].ToString();
                string yield_status_cd = "";


                for(int i = 0; i < _DT_YieldStatus.Rows.Count; i++)
                {
                    if(_DT_YieldStatus.Rows[i].ItemArray[2].ToString() == yield_status)
                    {
                        yield_status_cd = _DT_YieldStatus.Rows[i].ItemArray[1].ToString();
                        break;
                    }
                }



                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS] == null
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString() == "") continue;


                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxYIELD_STATUS].ToString() == yield_status_cd)
                    {

                        if (e.NewValue == CheckState.Checked)
                        {
                            fgrid_Main.Rows[i].Height = 18;
                        }
                        else
                        {
                            fgrid_Main.Rows[i].Height = 0;
                        }


                    } // end if


                } // end for i



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_checkedListBox_Status_ItemCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #endregion

        #region 디비 연결



        /// <summary>
        /// SELECT_SBC_YIELD_STATUS : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_yield_status"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_YIELD_STATUS(string arg_factory, string arg_style_cd, string arg_yield_status)
        {

            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD_STATUS";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_YIELD_STATUS";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_yield_status;
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


        
        /// <summary>
        /// SAVE_SBC_YIELD_STATUS : 
        /// </summary>
        /// <param name="arg_division"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_yield_status_key"></param>
        /// <param name="arg_yield_status"></param>
        /// <param name="arg_confirm_ymd"></param>
        /// <param name="arg_remarks"></param>
        /// <returns></returns>
        public static bool SAVE_SBC_YIELD_STATUS(string arg_division, 
            string arg_factory, 
            string arg_style_cd, 
            string arg_yield_status_key, 
            string arg_yield_status, 
            string arg_confirm_ymd, 
            string arg_remarks)
        {
            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(8);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_SBC_YIELD_STATUS";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_YIELD_STATUS_KEY";
                MyOraDB.Parameter_Name[4] = "ARG_YIELD_STATUS";
                MyOraDB.Parameter_Name[5] = "ARG_CONFIRM_YMD";
                MyOraDB.Parameter_Name[6] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = arg_division;
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_style_cd;
                MyOraDB.Parameter_Values[3] = arg_yield_status_key;
                MyOraDB.Parameter_Values[4] = arg_yield_status;
                MyOraDB.Parameter_Values[5] = arg_confirm_ymd;
                MyOraDB.Parameter_Values[6] = arg_remarks;
                MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

                

                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)  // error
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_YIELD_STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




        #endregion

       

    }
}