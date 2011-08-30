using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;

namespace FlexCDC.FOB
{
    public partial class  Form_EIS_MatPrice_Check_FOB : COM.APSWinForm.Form_Top
    {

        #region 생성자




        public  Form_EIS_MatPrice_Check_FOB()
        {
            InitializeComponent();

            //Init_Form();


        }





        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();
        private Thread temp_thread = null;
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;  
        
        #endregion

        #region 멤버 메서드


        #region 초기화

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {


                //Title
                this.Text = "CBD Analysis";
                lbl_MainTitle.Text = "CBD Analysis";
                ClassLib.ComFunction.SetLangDic(this);


                Init_Grid();

                Init_Control();




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Init_Grid : 
        /// </summary>
        private void Init_Grid()
        {


            fgrid_Main.Set_Grid("EIS_MATPRICE_CHECK_FOB", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.KeyActionEnter = KeyActionEnum.MoveAcross;

           // fgrid_Main.SelectionMode = SelectionModeEnum.Default;


        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {


            // Disabled tbutton
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Color.ToolTipText = "Order Quantity";

            tbtn_Save.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;


            if ((ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "C") ||
               (ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "S"))
            {
                tbtn_Save.Enabled = true;
                tbtn_Delete.Enabled = true;               
            }
           


            // plan_month from, to add items
            DataTable dt_date = new DataTable();

            DataColumn dc_date = new DataColumn("PLAN_MONTH", Type.GetType("System.String"));
            dt_date.Columns.Add(dc_date);

            for (int i = -6; i <= 6; i++)
            {

                DataRow dr_date = dt_date.NewRow();

                dr_date["PLAN_MONTH"] = System.DateTime.Now.AddMonths(i * (-1)).ToString("yyyy-MM");
                dt_date.Rows.Add(dr_date);
            }

            ClassLib.ComCtl.Set_ComboList(dt_date, cmb_PlanMonth_From, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_date, cmb_PlanMonth_To, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            dt_date.Dispose();
            cmb_PlanMonth_From.SelectedIndex = 0;
            cmb_PlanMonth_To.SelectedIndex = 0;
           


            // 공장 Setting
            // 공장 Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            if (ClassLib.ComVar.This_CDC_Factory != "DS")
            { cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory; cmb_Factory.Enabled = false; }
            else
            { cmb_Factory.SelectedValue  = "QD"; cmb_Factory.Enabled = true; }
             


            ////Order Type Setting..
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Order_Type, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Order_Type.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Order_Type);


            // Category Setting..
            dt_ret = ClassLib.ComFunction.SELECT_COMMON_CODE_LIST(ClassLib.ComVar.This_Factory, "MD02");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Category, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Category.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Category);

          
            



            // Model Setting..
            dt_ret = ClassLib.ComFunction.SELECT_MODEL_LIST(cmb_Factory.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Model.SelectedIndex = 0;
            Set_Combo_Size( 100, 210, 310, cmb_Model);
            


            //Style Setting
            Set_Style_List();

      
            // User  Setting..
            dt_ret =SELECT_FOB_USER(cmb_Factory.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_User, 0, 0, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();            
            cmb_User.SelectedIndex = 0;
            cmb_User.Splits[0].DisplayColumns[0].Width = 0;
            //cmb_User.Splits[0].DisplayColumns[1].Width = 210;
            //cmb_User.DropDownWidth = 310;

            txt_FOB_Lower.Text = "0.00";
            txt_FOB_Higher.Text = "500.00";


          


        }


       private void  Set_Combo_Size(int arg_col1, int arg_col2, int arg_col_tot, C1.Win.C1List.C1Combo arg_cmb)
       {   

            arg_cmb.SelectedIndex = 0;
            arg_cmb.Splits[0].DisplayColumns[0].Width = arg_col1;
            arg_cmb.Splits[0].DisplayColumns[1].Width = arg_col2;
            arg_cmb.DropDownWidth = arg_col_tot;

       }


        #endregion

        #region 조회



        /// <summary>
        /// Search : 
        /// </summary>
        private void Search()
        {

            try
            {


                this.Cursor = Cursors.WaitCursor;


                string this_factory = ClassLib.ComVar.This_CDC_Factory;
                string factory = cmb_Factory.SelectedValue.ToString();
                string plan_month_from =ClassLib.ComFunction.Empty_String( cmb_PlanMonth_From.SelectedValue.ToString().Replace("-", ""),"000000");
                string plan_month_to = ClassLib.ComFunction.Empty_String(cmb_PlanMonth_To.SelectedValue.ToString().Replace("-", ""), "999999");
                string order_type =ClassLib.ComFunction.Empty_Combo(cmb_Order_Type, " ");
                string order_Id = (cmb_Order_ID.SelectedText.Equals("ALL")) ? " " : cmb_Order_ID.SelectedText;                
                string category_cd = ClassLib.ComFunction.Empty_Combo(cmb_Category, " ");
                string model_cd = ClassLib.ComFunction.Empty_Combo(cmb_Model, " ");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_Style, " ");
                string new_yn = ClassLib.ComFunction.Empty_Combo(cmb_New, " ");
                string status = ClassLib.ComFunction.Empty_Combo(cmb_Status, " ");
                string upd_user = ClassLib.ComFunction.Empty_Combo(cmb_User, " ");
                string fob_lower = ClassLib.ComFunction.Empty_TextBox(txt_FOB_Lower, "0");
                string fob_higher = ClassLib.ComFunction.Empty_TextBox(txt_FOB_Higher, "0");

                DataTable dt_ret = SELECT_FOB_LIST_IN_MPS(this_factory, factory, plan_month_from, plan_month_to,
                                   order_type, order_Id, category_cd, model_cd, style_cd, new_yn, status, upd_user, fob_lower, fob_higher);

                Display_Grid(dt_ret);
                dt_ret.Dispose();




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        
           


         private void Set_Order_ID_List()
        {



            DataTable dt_ret = SELECT_FOB_OBS_LIST(ClassLib.ComFunction.Empty_Combo(cmb_Factory, " "),
                                                  cmb_PlanMonth_From.SelectedValue.ToString().Replace("-",""),
                                                 cmb_PlanMonth_To.SelectedValue.ToString().Replace("-", ""));
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Order_Type, 0, 1,true, COM.ComVar.ComboList_Visible.Code_Name);
            Set_Combo_Size(0, 210, 210, cmb_Order_Type);
            dt_ret.Dispose();


        }



        private void Set_Style_List()
        {



            DataTable dt_ret = SELECT_STYLE_LIST(ClassLib.ComFunction.Empty_Combo(cmb_Model, " "),
                                              ClassLib.ComFunction.Empty_TextBox(txt_Style, " "));

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Style, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Style.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Style);



        }


        private void Set_Model_List()
        {



            DataTable dt_ret = SELECT_MODEL_LIST(ClassLib.ComFunction.Empty_Combo(cmb_Category, " "));

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Model.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Model);



        }



        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_dt"></param>
        private void Display_Grid(DataTable arg_dt)
        {

            fgrid_Main.ClearAll();


            if (arg_dt.Rows.Count == 0) return;


            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_Main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
                fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";
      

                if (((Convert.ToInt16(fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.lxOVER_GAC].ToString()) >= -30) )
                    &&((fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFOB]== null)  || 
                        (fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFOB].ToString() == "0")))
                {
                    CellRange cr_overgac = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.lxOVER_GAC, 
                                                                   fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.lxOVER_GAC);
                    cr_overgac.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; //red
                }


                if  ((fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxREMARKS].ToString().Trim().ToUpper()  =="COPY FT ORDER") ||
                     (fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxREMARKS].ToString().Trim().ToUpper()  =="N"))
                {

                    CellRange cr_copy = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxREMARKS, 
                                                                   fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxREMARKS);
                    cr_copy.StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;  //blue
                }



            }
             

            //----------------------------------------------------
            // merge
            //----------------------------------------------------
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = false;
            }

            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFACTORY].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxCATEGORY_NAME].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxMODEL_NAME].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxSTYLE_CD].AllowMerging = true;
            //----------------------------------------------------



        }




        #endregion


        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {

            //cmb_PlanMonth_From.SelectedValue = System.DateTime.Now.ToString("yyyy-MM");

            fgrid_Main.ClearAll();


        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {
            try
            {

                // 조회시 필수조건 체크 
                C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_PlanMonth_From, cmb_PlanMonth_To };
                System.Windows.Forms.TextBox[] txt_array = { };
                bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
                if (!previous_check) return;


                _pop = new BaseInfo.Pop_BS_Shipping_List_Wait();
                temp_thread = new Thread(new ThreadStart(_pop.Start));

                if (temp_thread != null)
                {
                    temp_thread.Start();
                    Search();

                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "tbtn_search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (temp_thread != null)
                {
                    temp_thread.Abort();                                  
                }

                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }

        }


        /// <summary>
        /// Event_Tbtn_Save : 
        /// </summary>
        private void Event_Tbtn_Save()
        {


            // 행 수정상태 해제 
            fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, fgrid_Main.Selection.r1, fgrid_Main.Selection.c1, false);


            DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
            if (result == DialogResult.No) return;


            int top_row = fgrid_Main.Selection.r1;

         

            bool save_flag = SAVE_EBM_FOB();

            if (save_flag)
            {

                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
                Set_Clear_Flag();
                //Event_Tbtn_Search();
                fgrid_Main.TopRow = top_row;

            }
            else
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return;

            }


        }



        /// <summary>
        /// Set_Clear_Flag : 
        /// </summary>
        private void Set_Clear_Flag()
        {


            for (int i = fgrid_Main.Rows.Fixed;i<fgrid_Main.Rows.Count ; i++)
            {
                if (fgrid_Main[i, 0].ToString() == "D")
                {
                    fgrid_Main.Rows.Remove(i);
                    i--;

                }
                else
                              fgrid_Main[i, 0] = "";


            }

            //fgrid_Main.Refresh();

        }




        /// <summary>
        /// Event_Tbtn_Delete : 
        /// </summary>
        private void Event_Tbtn_Delete()
        {
            int[] vRow = fgrid_Main.Selections;
  
            //for (int i = fgrid_Main.Rows.Fixed ; i <fgrid_Main.Rows.Count   ; i++)
            //    if (fgrid_Main.Rows[i].Selected == true) fgrid_Main.Delete_Row(i);


            //for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            //    if (fgrid_Main.Rows[i].Selected == true) 
            //        fgrid_Main[0, i] = "D";
                            
            for(int i = 0; i < vRow.Length; i++)
            {
                fgrid_Main[vRow[i], 0] = "D";
            }

             


        }


        /// <summary>
        /// Event_Tbtn_Print : 
        /// </summary>
        private void Event_Tbtn_Print()
        {

            saveFileDialog1.Filter = "Excel 파일|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            if (saveFileDialog1.FileName != "")
            {

                fgrid_Main.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "FOB 사전 점검", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



        #endregion

        #region 그리드 이벤트 메서드

        private void cmb_Order_ID_TextChanged(object sender, EventArgs e)
        {

            
            //}
        }

    

        private void Event_fgrid_Main_BeforeEdit()
        {
            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
            }

        }




        private void Event_fgrid_Main_AfterEdit()
        {


            fgrid_Main.Update_Row();


            // add m_price 
            double up = 0;
            double bottom = 0;
            double m_price = 0;
            double m_ratio = 0;
            double extra = 0;
            double l_oh = 0;
            double profit = 0;
            double tooling = 0;
            double fob = 0;
            double fobdeduction = 0;
            double qd_rate = 0;
            double vj_rate = 0; 


            if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxUP] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxUP].ToString().Equals(""))
            {
                up = 0;
            }
            else
            {
                up = Convert.ToDouble(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxUP].ToString());
            }


            if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxBOTTOM] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxBOTTOM].ToString().Equals(""))
            {
                bottom = 0;
            }
            else
            {
                bottom = Convert.ToDouble(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxBOTTOM].ToString());
            }

               
            m_price = up + bottom;

            if (m_price != 0)
            {
                fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxM_PRICE] = m_price.ToString();
            }




            if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxEXTRA] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxEXTRA].ToString().Equals(""))
            {
                extra = 0;
            }
            else
            {
                extra = Convert.ToDouble(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxEXTRA].ToString());
            }


            if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxL_OH] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxL_OH].ToString().Equals(""))
            {
                l_oh = 0;
            }
            else
            {
                l_oh = Convert.ToDouble(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxL_OH].ToString());
            }


            if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxPROFIT] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxPROFIT].ToString().Equals(""))
            {
                profit = 0;
            }
            else
            {
                profit = Convert.ToDouble(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxPROFIT].ToString());
            }


            if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxTOOLING] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxTOOLING].ToString().Equals(""))
            {
                tooling = 0;
            }
            else
            {
                tooling = Convert.ToDouble(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxTOOLING].ToString());
            }



            fob = m_price + extra + l_oh + profit + tooling;

            if (fob != 0)
            {
                fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFOB] = fob.ToString();

                fobdeduction = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFACTORY].ToString() == "QD") ? (fob * qd_rate) : (fob * vj_rate);

                fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxDEDUCTION] = fobdeduction.ToString();


                if (m_price != 0)
                {
                    m_ratio = Convert.ToDouble(Math.Round((m_price / fob) * 100, 2));

                    fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxM_RATIO] = m_ratio.ToString();


                }

            }
            

 

        }


        private void fgrid_Main_DoubleClick(object sender, EventArgs e)
        {
            string vFactory = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFACTORY].ToString();
            string vModelCD = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxMODEL_CD].ToString();
            string vModelName = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxMODEL_NAME].ToString();

            Pop_EIS_MatPrice_Order_Qty vPop = new Pop_EIS_MatPrice_Order_Qty(vFactory, vModelCD, vModelName);
            vPop.ShowDialog();
           
        }
        





        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1) cmb_Factory.SelectedValue = "QD";


            if ((cmb_Factory.SelectedValue.ToString() != "JJ")  && (cmb_Factory.SelectedValue.ToString() != "QD")  &&
                (cmb_Factory.SelectedValue.ToString() != "VJ") )
                cmb_Factory.SelectedValue = "QD";


            // new yn
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxUseYN);  // "SBC00";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_New, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_New.SelectedIndex = 0;

            //// status
            //dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxEISMatFOBStatus);  // "EIS_MAT_12";
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Status, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            //cmb_Status.SelectedIndex = 0;

            //Status
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "EIS_MAT_12");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Status, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Status.SelectedIndex = 0;
            Set_Combo_Size(100, 210, 310, cmb_Status);




            Event_Tbtn_New();

          



        }




        private void cmb_Style_TextChanged(object sender, EventArgs e)
        {

            if (cmb_Style.SelectedIndex == -1) return;

            txt_Style.Text = cmb_Style.SelectedValue.ToString();

        }




        private void cmb_Model_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Model.SelectedIndex <= 0) return;
            Set_Style_List();
        }

   


        private void Event_cmb_PlanMonth_From_SelectedValueChanged()
        {

            
            //cmb_PlanMonth_To.SelectedIndex = -1;



            //if (cmb_PlanMonth_From.SelectedIndex == -1) return;

            
            //fgrid_Main.ClearAll();


            //cmb_PlanMonth_To.SelectedValue = cmb_PlanMonth_From.SelectedValue.ToString();



           

        }


        private void Event_cmb_PlanMonth_To_SelectedValueChanged()
        {

           // if (cmb_PlanMonth_To.SelectedIndex == -1) return;


            fgrid_Main.ClearAll();

           // Set_Order_ID_List();


        }


        private void Event_cmb_New_SelectedValueChanged()
        {

            if (cmb_New.SelectedIndex == -1) return;


            fgrid_Main.ClearAll();
        }



        private void Event_cmb_Status_SelectedValueChanged()
        {

            if (cmb_Status.SelectedIndex == -1) return;


            fgrid_Main.ClearAll();
        }


        private void txt_Style_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    Set_Style_List();

                }

            }
            catch
            {
            }
            
        }



        private void cmb_Category_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Category.SelectedIndex <= 0) return;

            Set_Model_List();


        }




        #endregion

        #region 컨텍스트 메뉴 이벤트 (Copy/ Paste/ Delete)


        // copy한 데이터 저장 배열
        private string[] _CopyList;


        private void Event_Click_menuItem_Copy()
        {

            int c1 = fgrid_Main.Selection.c1;
            int c2 = fgrid_Main.Selection.c2;
            int start_col = 0, end_col = 0;


            start_col = (c1 < c2) ? c1 : c2;
            end_col = (c1 > c2) ? c1 : c2;

            _CopyList = new string[end_col - start_col + 1];

            for (int i = start_col; i <= end_col; i++)
            {
                fgrid_Main[fgrid_Main.Row, i] = (fgrid_Main[fgrid_Main.Row, i] == null) ? "" : fgrid_Main[fgrid_Main.Row, i].ToString();

                _CopyList[i - start_col] = fgrid_Main[fgrid_Main.Row, i].ToString();
            }



        }

        private void Event_Click_menuItem_Paste()
        {

            int sel_col = fgrid_Main.Selection.c1;


            for (int i = 0; i < _CopyList.Length; i++)
            {
                fgrid_Main[fgrid_Main.Row, i + fgrid_Main.Col] = _CopyList[i];

                if (i + fgrid_Main.Col == fgrid_Main.Cols.Count - 1) break;

            }


            Event_fgrid_Main_AfterEdit();



        }

        private void Event_Click_menuItem_Delete()
        {

            int c1 = fgrid_Main.Selection.c1;
            int c2 = fgrid_Main.Selection.c2;
            int start_col = 0, end_col = 0;


            start_col = (c1 < c2) ? c1 : c2;
            end_col = (c1 > c2) ? c1 : c2;

            for (int i = start_col; i <= end_col; i++)
            {

                fgrid_Main[fgrid_Main.Row, i] = "0";  

            } // end for i


            Event_fgrid_Main_AfterEdit();
        }

        private void ExportXML()
        {
            FlexCDC.FOB.CBDExcel.V_1_220.XMLExporter exporter = new FlexCDC.FOB.CBDExcel.V_1_220.XMLExporter(null, null, null, null);
            string factory = null, obs_id = null, obs_type = null, style_cd = null;
            int[] sels = fgrid_Main.Selections;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                exporter.Path = fbd.SelectedPath;

                foreach (int row in sels)
                {
                    factory = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFACTORY].ToString();
                    obs_id = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxOBS_ID].ToString();
                    obs_type = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxOBS_TYPE].ToString();
                    style_cd = fgrid_Main[row, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxSTYLE_CD].ToString();
                    style_cd = style_cd.Replace("-", "");

                    exporter.Factory = factory;
                    exporter.Obs_id = obs_id;
                    exporter.Obs_type = obs_type;
                    exporter.Style_cd = style_cd;

                    exporter.ExportXML();
                }
            }
        }
        
        #endregion 

        #region 이벤트 처리

        #region 툴바 이벤트


        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {

                Event_Tbtn_Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #region 그리드 이벤트



        private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Event_fgrid_Main_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Event_fgrid_Main_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        #region 버튼 및 기타 이벤트

        private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string vFactory = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFACTORY].ToString();
            string vModelCD = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxMODEL_CD].ToString();
            string vModelName = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxMODEL_NAME].ToString();

            Pop_EIS_MatPrice_Order_Qty vPop = new Pop_EIS_MatPrice_Order_Qty(vFactory, vModelCD, vModelName);
            vPop.ShowDialog();
        }

       

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


        private void  Form_EIS_MatPrice_Check_FOB_Load(object sender, EventArgs e)
        {
            Init_Form();
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



        private void cmb_PlanMonth_From_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_PlanMonth_From_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanMonth_From_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_Order_Type_TextChanged(object sender, EventArgs e)
        {
            cmb_Order_ID.ClearItems();

            //if (cmb_Order_Type.SelectedIndex != 0)
            //{

            ClassLib.ComFunction.Set_OBSID_CmbList(cmb_Order_Type.SelectedValue.ToString(), true, cmb_Order_ID);
            cmb_Order_ID.SelectedIndex = 0;
        }

       


        private void cmb_PlanMonth_To_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_PlanMonth_To_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_PlanMonth_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_New_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_New_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_New_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_Status_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Status_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Status_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
       


        #endregion

        #region 컨텍스트 메뉴 이벤트 (Copy/ Paste/ Delete)

        private void menuItem_Copy_Click(object sender, System.EventArgs e)
        {
            try
            {
                Event_Click_menuItem_Copy();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItem_Paste_Click(object sender, System.EventArgs e)
        {
            try
            {
                Event_Click_menuItem_Paste();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItem_Delete_Click(object sender, System.EventArgs e)
        {
            try
            {
                Event_Click_menuItem_Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_exportXML_Click(object sender, EventArgs e)
        {
            try
            {
                ExportXML();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ExportXML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion 

        #endregion

        #region 디비 연결

        #region 콤보




        #endregion

        #region 조회


        /// <summary>
        /// SELECT_FOB_LIST_IN_MPS : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month_from"></param>
        /// <param name="arg_plan_month_to"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_new_yn"></param>
        /// <param name="arg_status"></param>
        /// <returns></returns>
        private DataTable SELECT_FOB_LIST_IN_MPS( string arg_this_factory, string arg_factory, 
            string arg_plan_month_from, 
            string arg_plan_month_to,
            string arg_order_type,
            string arg_order_id, 
            string arg_category_cd,
            string arg_model_cd,
            string arg_style_cd,
            string arg_new_yn,
            string arg_status,
            string arg_upd_user,
            string arg_fob_lower,
            string arg_fob_higher)
        {

            try
            {

                MyOraDB.ReDim_Parameter(15);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SELECT_FOB_LIST_IN_MPS";


                //02.ARGURMENT 명
                int i = 0;
                MyOraDB.Parameter_Name[i++] = "ARG_THIS_FACTORY";
                MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[i++] = "ARG_PLAN_YMD_FROM";
                MyOraDB.Parameter_Name[i++] = "ARG_PLAN_YMD_TO";
                MyOraDB.Parameter_Name[i++] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[i++] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[i++] = "ARG_CATEGORY_CD";
                MyOraDB.Parameter_Name[i++] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[i++] = "ARG_NEW_YN";
                MyOraDB.Parameter_Name[i++] = "ARG_STATUS";
                MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[i++] = "ARG_FOB_LOWER";
                MyOraDB.Parameter_Name[i++] = "ARG_FOB_HIGHER";
                MyOraDB.Parameter_Name[i++] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                int j = 0;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[j++] = (int)OracleType.Cursor;



                //04.DATA 정의
                int k = 0;
                MyOraDB.Parameter_Values[k++] = arg_this_factory;
                MyOraDB.Parameter_Values[k++] = arg_factory;
                MyOraDB.Parameter_Values[k++] = arg_plan_month_from;
                MyOraDB.Parameter_Values[k++] = arg_plan_month_to;
                MyOraDB.Parameter_Values[k++] = arg_order_type;
                MyOraDB.Parameter_Values[k++] = arg_order_id;
                MyOraDB.Parameter_Values[k++] = arg_category_cd;
                MyOraDB.Parameter_Values[k++] = arg_model_cd;
                MyOraDB.Parameter_Values[k++] = arg_style_cd;
                MyOraDB.Parameter_Values[k++] = arg_new_yn;
                MyOraDB.Parameter_Values[k++] = arg_status;
                MyOraDB.Parameter_Values[k++] = arg_upd_user;
                MyOraDB.Parameter_Values[k++] = arg_fob_lower;
                MyOraDB.Parameter_Values[k++] = arg_fob_higher;
                MyOraDB.Parameter_Values[k++] = "";




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





        private DataTable SELECT_STYLE_LIST(string arg_model, string arg_style)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_SDC_STYLE";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_model;
                MyOraDB.Parameter_Values[1] = arg_style;
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


        private DataTable SELECT_MODEL_LIST(string arg_category)
        {

            try
            {

                MyOraDB.ReDim_Parameter(2);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_SDC_MODEL";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_CATEGORY_CD";                
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;                
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_category;                
                MyOraDB.Parameter_Values[1] = "";




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





        private DataTable SELECT_FOB_USER(string arg_factory)
        {

            try
            {

                MyOraDB.ReDim_Parameter(2);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SELECT_FOB_USER";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";




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



        private DataTable SELECT_FOB_OBS_LIST(string arg_factory, string arg_plan_ymd_from, string arg_plan_ymd_to)
        {

            try
            {

                MyOraDB.ReDim_Parameter(4);
 

                //01.PROCEDURE명
                MyOraDB.Process_Name = "pkg_emm_price_batch_00.select_fob_obs_list";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_plan_ymd_from";
                MyOraDB.Parameter_Name[2] = "arg_plan_ymd_to";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_ymd_from;
                MyOraDB.Parameter_Values[2] = arg_plan_ymd_to;                
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

        #region 저장


        /// <summary>
        /// SAVE_EBM_FOB : 
        /// </summary>
        /// <returns></returns>
        private bool SAVE_EBM_FOB()
        {

            try
            {

                int col_ct = 18;


                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SAVE_EBM_FOB";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_UP";
                MyOraDB.Parameter_Name[6] = "ARG_BOTTOM";
                MyOraDB.Parameter_Name[7] = "ARG_M_PRICE";
                MyOraDB.Parameter_Name[8] = "ARG_M_RATIO";
                MyOraDB.Parameter_Name[9] = "ARG_EXTRA";
                MyOraDB.Parameter_Name[10] = "ARG_L_OH";
                MyOraDB.Parameter_Name[11] = "ARG_PROFIT";
                MyOraDB.Parameter_Name[12] = "ARG_TOOLING";
                MyOraDB.Parameter_Name[13] = "ARG_FOB";
               // MyOraDB.Parameter_Name[14] = "ARG_DEDUCTION";
                MyOraDB.Parameter_Name[14] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[15] = "ARG_STATUS";
                MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[17] = "ARG_THIS_FACTORY";




                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (fgrid_Main[i, 0] == null || fgrid_Main[i, 0].ToString().Equals("")) continue;

                    vList.Add(fgrid_Main[i, 0].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFACTORY].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxOBS_ID].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxOBS_TYPE].ToString());
                    vList.Add(fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxSTYLE_CD].ToString().Replace("-", ""));
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxUP] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxUP].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxBOTTOM] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxBOTTOM].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxM_PRICE] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxM_PRICE].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxM_RATIO] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxM_RATIO].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxEXTRA] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxEXTRA].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxL_OH] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxL_OH].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxPROFIT] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxPROFIT].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxTOOLING] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxTOOLING].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFOB] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxFOB].ToString());
                    //vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxDEDUCTION] == null) ? "0" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxDEDUCTION].ToString());
                    vList.Add((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxREMARKS] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.IxREMARKS].ToString());
                    vList.Add((((fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.lxSTATUS] == null) ? "False" : fgrid_Main[i, (int)ClassLib.TBEIS_FOB_LIST_IN_MPS.lxSTATUS].ToString()) == "True") ? "C" : "");
                    vList.Add(ClassLib.ComVar.This_User);
                    vList.Add(ClassLib.ComVar.This_CDC_Factory);
                    

                } //end for i



                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }



        #endregion
     
        #endregion

        





    }
}