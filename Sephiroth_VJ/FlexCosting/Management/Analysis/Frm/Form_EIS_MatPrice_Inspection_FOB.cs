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

namespace FlexCosting.Management.Analysis.Frm
{
    public partial class Form_EIS_MatPrice_Inspection_FOB : COM.APSWinForm.Form_Top
    {

        #region ������




        public  Form_EIS_MatPrice_Inspection_FOB()
        {
            InitializeComponent();

            //Init_Form();


        }


        #endregion

        #region ���� ����


        private COM.OraDB MyOraDB = new COM.OraDB();

        
        #endregion

        #region ��� �޼���


        #region �ʱ�ȭ

        /// <summary>
        /// Inti_Form : Form Load �� �ʱ�ȭ �۾�
        /// </summary>
        private void Init_Form()
        {

            try
            {


                ////Title
                //this.Text = "���� FOB�� ���� FOB ��";
                //lbl_MainTitle.Text = "���� FOB�� ���� FOB ��";


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


            fgrid_Main.Set_Grid("EIS_MATPRICE_FOB_INSPECTION", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.KeyActionEnter = KeyActionEnum.MoveAcross;



        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {


            // Disabled tbutton
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;



            rad_Before.Checked = true;



            // month combobox add items
            DataTable dt_month = new DataTable();
            DataColumn dc_month = new DataColumn("MONTH", Type.GetType("System.String"));
            dt_month.Columns.Add(dc_month);

            for (int i = 0; i < 12; i++)
            {

                DataRow dr_month = dt_month.NewRow();

                dr_month["MONTH"] = Convert.ToString(i + 1).PadLeft(2, '0');
                dt_month.Rows.Add(dr_month);
            }


            ClassLib.ComFunction.Set_ComboList(dt_month, cmb_PlanMonth_From, 0, 0, false, COM.ComVar.ComboList_Visible.Code);
            ClassLib.ComFunction.Set_ComboList(dt_month, cmb_PlanMonth_To, 0, 0, false, COM.ComVar.ComboList_Visible.Code);



            // plan_year ����
            string factory = "";
            string poweruser_yn = "Y"; // ClassLib.ComVar.This_PowerUser_YN;

            DataTable dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_YEAR(factory, poweruser_yn);
            //0 : year, 1 : month_from, 2 : month_to
            ClassLib.ComFunction.Set_ComboList_Multi(dt_ret, cmb_Year, new int[] { 0, 1, 2 }, false);
            string[] titles = new string[] { "Year", "Month from", "Month to" };
            int[] width = new int[] { 150, 100, 100 };
            bool[] visible = new bool[] { true, false, false };
            ClassLib.ComFunction.SetComboStyle(cmb_Year, titles, width, visible, "Year");
            cmb_Year.DropDownWidth = 150;

            if (dt_ret != null && dt_ret.Rows.Count > 0)
            {
                cmb_Year.SelectedIndex = 0;
            }



            // Factory Combobox Add Items
            dt_ret = ClassLib.ComFunction.SELECT_MATPRICE_COMBO_FACTORY();
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();



            //cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
            cmb_Factory.SelectedValue = ClassLib.ComFunction.Set_Default_Factory();




        }


        /// <summary>
        /// Init_Control_cmb_ModelCd : 
        /// </summary>
        private void Init_Control_cmb_ModelCd()
        {


            // �ʼ����� üũ 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_Year, cmb_PlanMonth_From, cmb_PlanMonth_To };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;



            //-------------------------------------------------------------------------
            // ��Ÿ ��Ʈ�� �ʱ�ȭ 
            Event_Tbtn_New();

            txt_StyleCd.Text = "";
            cmb_StyleCd.SelectedIndex = -1;

            cmb_ModelCd.SelectedIndex = -1;
            //-------------------------------------------------------------------------


            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_year = cmb_Year.SelectedValue.ToString();
            string plan_month_from = cmb_PlanMonth_From.SelectedValue.ToString();
            string plan_month_to = cmb_PlanMonth_To.SelectedValue.ToString();
            string category = ClassLib.ComFunction.Empty_Combo(cmb_Category, " ");
            string model_cd = ClassLib.ComFunction.Empty_TextBox(txt_ModelCd, " ");
            string division = (rad_Before.Checked) ? "BEFORE" : "AFTER";



            DataTable dt_ret = SELECT_FOB_COST_VS_TRADE_MODEL(factory, plan_year, plan_month_from, plan_month_to, category, model_cd, division);
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_ModelCd, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_ModelCd.Splits[0].DisplayColumns["Code"].Width = 70;
            cmb_ModelCd.Splits[0].DisplayColumns["Name"].Width = 200;
            cmb_ModelCd.DropDownWidth = 300;
            dt_ret.Dispose();





        }



        /// <summary>
        /// set combo : style list
        /// </summary>
        private void Init_Control_cmb_StyleCd()
        {


            // �ʼ����� üũ 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_Year, cmb_PlanMonth_From, cmb_PlanMonth_To };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string plan_year = cmb_Year.SelectedValue.ToString();
            string plan_month_from = cmb_PlanMonth_From.SelectedValue.ToString();
            string plan_month_to = cmb_PlanMonth_To.SelectedValue.ToString();
            string category = ClassLib.ComFunction.Empty_Combo(cmb_Category, " ");
            string model_cd = ClassLib.ComFunction.Empty_TextBox(txt_ModelCd, " ");
            string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
            string division = (rad_Before.Checked) ? "BEFORE" : "AFTER";

            DataTable dt_ret = SELECT_FOB_COST_VS_TRADE_STYLE(factory, plan_year, plan_month_from, plan_month_to, category, model_cd, style_cd, division);
               

            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model_cd, 5 : model name
            ClassLib.ComFunction.Set_ComboList_Multi(dt_ret, cmb_StyleCd, new int[] { 0, 1, 2, 3, 4, 5 }, true);
            string[] titles = new string[] { "Code", "Name", "Gender", "Presto", "Model", "Model Name"};
            int[] width = new int[] { 90, 200, 100, 100, 100, 100 };
            bool[] visible = new bool[] { true, true, false, false, false, false };
            ClassLib.ComFunction.SetComboStyle(cmb_StyleCd, titles, width, visible, "Name");
            cmb_StyleCd.DropDownWidth = 320;

            dt_ret.Dispose();

        }

         



        #endregion

        #region ��ȸ



        /// <summary>
        /// Search : 
        /// </summary>
        private void Search()
        {

            try
            {


                this.Cursor = Cursors.WaitCursor;


                string factory = cmb_Factory.SelectedValue.ToString();
                string plan_year = cmb_Year.SelectedValue.ToString();
                string plan_month_from = cmb_PlanMonth_From.SelectedValue.ToString();
                string plan_month_to = cmb_PlanMonth_To.SelectedValue.ToString();
                string category = ClassLib.ComFunction.Empty_Combo(cmb_Category, " ");
                string model_cd = ClassLib.ComFunction.Empty_TextBox(txt_ModelCd, " ");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
                string poweruser_yn = ClassLib.ComVar.This_PowerUser_YN;
                string division = (rad_Before.Checked) ? "BEFORE" : "AFTER";

                DataTable dt_ret = SELECT_FOB_COST_VS_TRADE(factory, plan_year, plan_month_from, plan_month_to, category, model_cd, style_cd, poweruser_yn, division);
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
              
            }
             

            //----------------------------------------------------
            // merge
            //----------------------------------------------------
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = false;
            }

           
            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxCATEGORY_NAME].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxMODEL_CD].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxMODEL_NAME].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxSTYLE_CD].AllowMerging = true;
            //----------------------------------------------------



        }




        #endregion


        #endregion

        #region ���� �̺�Ʈ �޼���



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {
         
            fgrid_Main.ClearAll();

        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {


            // ��ȸ�� �ʼ����� üũ 
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_Year, cmb_PlanMonth_From, cmb_PlanMonth_To };
            System.Windows.Forms.TextBox[] txt_array = { };
            bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            if (!previous_check) return;


            Search();



        }


        
        /// <summary>
        /// Event_Tbtn_Print : 
        /// </summary>
        private void Event_Tbtn_Print()
        {

            saveFileDialog1.Filter = "Excel ����|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            if (saveFileDialog1.FileName != "")
            {

                fgrid_Main.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "���� FOB�� ���� FOB ��", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



        #endregion

        #region �׸��� �̺�Ʈ �޼���




        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ �޼���



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {
             
            Event_Tbtn_New();

            if (cmb_Factory.SelectedIndex == -1) return;



            // category ����
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxCategory);  // "MD02";
            ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Category, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);


            // model ����
            Init_Control_cmb_ModelCd();

        }


        /// <summary>
        /// Event_cmb_Year_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Year_SelectedValueChanged()
        {

            if (cmb_Year.SelectedIndex == -1) return;


            Event_Tbtn_New();


            //cmb_PlanMonth_From.SelectedValue = cmb_Year.Columns[1].Text;
            cmb_PlanMonth_From.SelectedValue = cmb_Year.Columns[2].Text;
            cmb_PlanMonth_To.SelectedValue = cmb_Year.Columns[2].Text;


        }

        /// <summary>
        /// Event_cmb_PlanMonth_From_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_PlanMonth_From_SelectedValueChanged()
        {


            if (cmb_PlanMonth_From.SelectedIndex == -1) return;


            Event_Tbtn_New();

            cmb_PlanMonth_To.SelectedValue = cmb_PlanMonth_From.SelectedValue.ToString();


        }



        /// <summary>
        /// Event_cmb_PlanMonth_To_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_PlanMonth_To_SelectedValueChanged()
        {


            if (cmb_PlanMonth_To.SelectedIndex == -1) return;


            Event_Tbtn_New();


        }



        /// <summary>
        /// Event_rad_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_rad_CheckedChanged(object sender)
        {


            //RadioButton src = sender as RadioButton;

            Event_Tbtn_New();

        }


        /// <summary>
        /// Event_cmb_Category_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Category_SelectedValueChanged()
        {


            if (cmb_Category.SelectedIndex == -1) return;


            txt_ModelCd.Text = "";
            Event_txt_ModelCd_KeyUp();
            Event_txt_StyleCd_KeyUp();

        }



        /// <summary>
        /// Event_txt_ModelCd_KeyUp : 
        /// </summary>
        private void Event_txt_ModelCd_KeyUp()
        {

            //-------------------------------------------------------------------------
            // ��Ÿ ��Ʈ�� �ʱ�ȭ  
            Event_Tbtn_New();

            txt_StyleCd.Text = "";
            cmb_StyleCd.SelectedIndex = -1;

            cmb_ModelCd.SelectedIndex = -1;
            //-------------------------------------------------------------------------


            // set combo : model list
            Init_Control_cmb_ModelCd();



            string modelcd = "";
            modelcd = txt_ModelCd.Text.Trim();
            cmb_ModelCd.SelectedValue = modelcd;





        }



        /// <summary>
        /// Event_cmb_ModelCd_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_ModelCd_SelectedValueChanged()
        {



            if (cmb_Factory.SelectedIndex == -1 || cmb_ModelCd.SelectedIndex == -1) return;

            txt_ModelCd.Text = cmb_ModelCd.SelectedValue.ToString();


            // style ����
            txt_StyleCd.Text = "";
            cmb_StyleCd.SelectedIndex = -1;
            Init_Control_cmb_StyleCd();



        }




        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary>
        private void Event_txt_StyleCd_KeyUp()
        {

            //-------------------------------------------------------------------------
            // ��Ÿ ��Ʈ�� �ʱ�ȭ 
            Event_Tbtn_New();

            cmb_StyleCd.SelectedIndex = -1;
            //-------------------------------------------------------------------------


            // set combo : style list
            Init_Control_cmb_StyleCd();



            string stylecd = "";
            int exist_index = -1;

            stylecd = txt_StyleCd.Text.Trim();

            exist_index = txt_StyleCd.Text.IndexOf("-", 0);

            if (exist_index == -1 && stylecd.Length == 9)
            {
                stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
            }

            cmb_StyleCd.SelectedValue = stylecd;



        }



        /// <summary>
        /// Event_cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_StyleCd_SelectedValueChanged()
        {



            if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;



            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model_cd, 5 : model name, 6 : plan_ymd_from, 7 : plan_ymd_to
            txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();


        }


        /// <summary>
        /// Event_btn_WarningRange_Click : 
        /// </summary>
        private void Event_btn_WarningRange_Click()
        {

            Display_Row();

        }


        // <summary>
        /// Event_chk_WarningRange_CheckedChanged : 
        /// </summary>
        private void Event_chk_WarningRange_CheckedChanged()
        {

            Display_Row();

        }


        /// <summary>
        /// Display_Row : 
        /// </summary>
        private void Display_Row()
        {


            if (txt_WarningRange1.Text.Trim() == "" && txt_WarningRange2.Text.Trim() == "")
            {

                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {
                    fgrid_Main.Rows[i].Visible = true;
                } // end for i


            }
            else
            {


                double warning_range1 = Convert.ToDouble(ClassLib.ComFunction.Empty_TextBox(txt_WarningRange1, "0"));
                double warning_range2 = Convert.ToDouble(ClassLib.ComFunction.Empty_TextBox(txt_WarningRange2, "0"));
                double balance = 0;



                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {



                    if (fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxBALANCE] == null
                        || fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxBALANCE].ToString().Trim() == "")
                    {
                        balance = 0;
                    }
                    else
                    {
                        balance = Convert.ToDouble(fgrid_Main[i, (int)ClassLib.TBEIS_MATPRICE_FOB_INSPECTION.IxBALANCE].ToString());
                    } // end if




                    if (txt_WarningRange1.Text.Trim() != "" && txt_WarningRange2.Text.Trim() == "")
                    {

                        if (balance > warning_range1)
                        {
                            fgrid_Main.Rows[i].Visible = true;
                        }
                        else
                        {
                            fgrid_Main.Rows[i].Visible = false;
                        }


                    }
                    else if (txt_WarningRange1.Text.Trim() == "" && txt_WarningRange2.Text.Trim() != "")
                    {

                        if (balance < warning_range2)
                        {
                            fgrid_Main.Rows[i].Visible = true;
                        }
                        else
                        {
                            fgrid_Main.Rows[i].Visible = false;
                        }

                    }
                    else if (txt_WarningRange1.Text.Trim() != "" && txt_WarningRange2.Text.Trim() != "")
                    {


                        if (balance > warning_range1 && balance < warning_range2)
                        {

                            if (chk_WarningRange.Checked) // ���� �����ϰ� ��ȸ : exclude
                            {
                                fgrid_Main.Rows[i].Visible = false;
                            }
                            else  // ���� ��ȸ : include
                            {
                                fgrid_Main.Rows[i].Visible = true;
                            }


                        }
                        else
                        {

                            if (chk_WarningRange.Checked) // ���� �����ϰ� ��ȸ : exclude
                            {
                                fgrid_Main.Rows[i].Visible = true;
                            }
                            else  // ���� ��ȸ : include
                            {
                                fgrid_Main.Rows[i].Visible = false;
                            }

                        }




                    }



                } // end for i


            } // end if (txt_WarningRange1.Text.Trim() == "" && txt_WarningRange2.Text.Trim() == "")



        }




        #endregion 

        #region �̺�Ʈ ó��

        #region ���� �̺�Ʈ


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

        #region �׸��� �̺�Ʈ


         
        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ


        #region ��ưŬ���� �̹�������


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


        private void  Form_EIS_MatPrice_Inspection_FOB_Load(object sender, EventArgs e)
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


        private void cmb_Year_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Year_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Year_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void rad_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_rad_CheckedChanged(sender);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void cmb_Category_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Category_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Category_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        private void txt_ModelCd_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyCode != Keys.Enter) return;

                Event_txt_ModelCd_KeyUp();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_ModelCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_ModelCd_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_ModelCd_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_ModelCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void txt_StyleCd_KeyUp(object sender, KeyEventArgs e)
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


        private void cmb_StyleCd_SelectedValueChanged(object sender, EventArgs e)
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

        private void btn_WarningRange_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_WarningRange_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_WarningRange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        private void chk_WarningRange_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_chk_WarningRange_CheckedChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_chk_WarningRange_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        #endregion

        #endregion

        #region ��� ����



        #region Combo


        /// <summary>
        /// SELECT_FOB_COST_VS_TRADE_MODEL : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_year"></param>
        /// <param name="arg_plan_month_from"></param>
        /// <param name="arg_plan_month_to"></param>
        /// <param name="arg_category"></param>
        /// <param name="arg_model_cd"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns>
        private DataTable SELECT_FOB_COST_VS_TRADE_MODEL(string arg_factory,
            string arg_plan_year,
            string arg_plan_month_from,
            string arg_plan_month_to,
            string arg_category,
            string arg_model_cd,
            string arg_division)
        {

            try
            {

                MyOraDB.ReDim_Parameter(8);


                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH_ANALYSIS.SELECT_FOB_COST_VS_TRADE_MODEL";


                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YEAR";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_MONTH_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_PLAN_MONTH_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[6] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";



                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;



                //04.DATA ����
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_year;
                MyOraDB.Parameter_Values[2] = arg_plan_month_from;
                MyOraDB.Parameter_Values[3] = arg_plan_month_to;
                MyOraDB.Parameter_Values[4] = arg_category;
                MyOraDB.Parameter_Values[5] = arg_model_cd;
                MyOraDB.Parameter_Values[6] = arg_division;
                MyOraDB.Parameter_Values[7] = "";



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
        /// SELECT_FOB_COST_VS_TRADE_STYLE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_year"></param>
        /// <param name="arg_plan_month_from"></param>
        /// <param name="arg_plan_month_to"></param>
        /// <param name="arg_category"></param>
        /// <param name="arg_model_cd"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns>
        private DataTable SELECT_FOB_COST_VS_TRADE_STYLE(string arg_factory,
            string arg_plan_year,
            string arg_plan_month_from,
            string arg_plan_month_to,
            string arg_category,
            string arg_model_cd,
            string arg_style_cd,
            string arg_division)
        {

            try
            {

                MyOraDB.ReDim_Parameter(9);


                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH_ANALYSIS.SELECT_FOB_COST_VS_TRADE_STYLE";


                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YEAR";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_MONTH_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_PLAN_MONTH_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[7] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";



                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;



                //04.DATA ����
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_year;
                MyOraDB.Parameter_Values[2] = arg_plan_month_from;
                MyOraDB.Parameter_Values[3] = arg_plan_month_to;
                MyOraDB.Parameter_Values[4] = arg_category;
                MyOraDB.Parameter_Values[5] = arg_model_cd;
                MyOraDB.Parameter_Values[6] = arg_style_cd;
                MyOraDB.Parameter_Values[7] = arg_division;
                MyOraDB.Parameter_Values[8] = "";



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

        #region ��ȸ

        
        /// <summary>
        /// SELECT_FOB_COST_VS_TRADE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_year"></param>
        /// <param name="arg_plan_month_from"></param>
        /// <param name="arg_plan_month_to"></param>
        /// <param name="arg_category"></param>
        /// <param name="arg_model_cd"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_poweruser_yn"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns>
        private DataTable SELECT_FOB_COST_VS_TRADE( string arg_factory,
            string arg_plan_year,
            string arg_plan_month_from, 
            string arg_plan_month_to, 
            string arg_category,
            string arg_model_cd,
            string arg_style_cd,
            string arg_poweruser_yn,
            string arg_division)
        {

            try
            {

                MyOraDB.ReDim_Parameter(10);


                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH_ANALYSIS.SELECT_FOB_NEW_COST_VS_TRADE";


                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YEAR";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_MONTH_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_PLAN_MONTH_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL_CD";
                MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[7] = "ARG_POWERUSER_YN";
                MyOraDB.Parameter_Name[8] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[9] = "OUT_CURSOR";



                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;     



                //04.DATA ����
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_year;
                MyOraDB.Parameter_Values[2] = arg_plan_month_from;
                MyOraDB.Parameter_Values[3] = arg_plan_month_to;
                MyOraDB.Parameter_Values[4] = arg_category;
                MyOraDB.Parameter_Values[5] = arg_model_cd;
                MyOraDB.Parameter_Values[6] = arg_style_cd;
                MyOraDB.Parameter_Values[7] = arg_poweruser_yn;
                MyOraDB.Parameter_Values[8] = arg_division;
                MyOraDB.Parameter_Values[9] = "";



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

       
     
        #endregion

       





    }
}