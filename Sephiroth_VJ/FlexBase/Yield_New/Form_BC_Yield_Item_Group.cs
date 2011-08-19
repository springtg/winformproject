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
    public partial class Form_BC_Yield_Item_Group : COM.PCHWinForm.Form_Top_Light
    {

        #region 생성자



        public Form_BC_Yield_Item_Group()
        {

            InitializeComponent();

            Init_Form();

        }



        private string _Factory = "";
        private string _StyleCd = "";
        private string _ItemCd = "";
        private string _ItemName = "";
        private string _SizeYN = "";
        private string _Unit = "";


        public Form_BC_Yield_Item_Group(string arg_factory, 
            string arg_style_cd, 
            string arg_item_cd,
            string arg_item_name,
            string arg_size, 
            string arg_unit)
        {

            InitializeComponent();


            _Factory = arg_factory;
            _StyleCd = arg_style_cd;
            _ItemCd = arg_item_cd;
            _ItemName = arg_item_name;
            _SizeYN = arg_size;
            _Unit = arg_unit;


            Init_Form();

        }

        #endregion

        #region 변수 정의


        COM.OraDB MyOraDB = new COM.OraDB();

        private string _RowDivisionValue = "YIELD_VALUE";
        private string _RowDivisionSpecCd = "SPEC_CODE";
        private string _RowDivisionSpecName = "SPEC_NAME";


        #endregion

        #region 이벤트 처리


        /// <summary>
        /// cmb_ItemGroup_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_ItemGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            Event_cmb_ItemGroup_SelectedValueChanged();
        }


        /// <summary>
        /// btn_GroupSearch_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GroupSearch_Click(object sender, EventArgs e)
        {
            Event_btn_GroupSearch_Click();
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
        /// btn_Add_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Event_btn_Add_Click();
        }


        /// <summary>
        /// btn_Delete_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Event_btn_Delete_Click();
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Main_MouseUp(object sender, MouseEventArgs e)
        {
            Event_fgrid_Main_MouseUp(e);
        }




        /// <summary>
        /// fgrid_Main_AfterResizeColumn : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Main_AfterResizeColumn(object sender, RowColEventArgs e)
        {
            Event_fgrid_Main_AfterResizeColumn(e);
        }



        /// <summary>
        /// chk_UseAllStyles_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_UseAllStyles_CheckedChanged(object sender, EventArgs e)
        {
            Event_chk_UseAllStyles_CheckedChanged();
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
                this.Text = "Item Size Group";
                lbl_MainTitle.Text = "Item Size Group";

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


                // toolbar button disable setting
                tbtn_Delete.Enabled = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled = false;
                tbtn_Print.Enabled = false;



                // 그리드 설정 
                fgrid_Main.Set_Grid("SBC_YIELD_ITEM_GROUP_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Main.Set_Action_Image(img_Action);
                fgrid_Main.Font = new Font("Verdana", 8);
                fgrid_Main.Styles.Frozen.BackColor = Color.White;
                fgrid_Main.Styles.Alternate.BackColor = Color.White;
                fgrid_Main.AllowSorting = AllowSortingEnum.None;
                fgrid_Main.SelectionMode = SelectionModeEnum.CellRange;
                fgrid_Main.AllowMerging = AllowMergingEnum.Free;



                fgrid_Main.Cols[0].AllowMerging = false;

                for(int i = 1; i < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i++)
                {
                    fgrid_Main.Cols[i].AllowMerging = true;
                }




                //그룹타입 콤보쿼리 
                DataTable dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemGroup, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 


                txt_StyleCd.Text = _StyleCd;



                // create size header
                dt_ret = ClassLib.ComFunction.Select_SIZE_COLHEAD_ALL(ClassLib.ComVar.This_Factory);
                fgrid_Main.Display_CrossTab_Head(dt_ret, 60, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START);
                dt_ret.Dispose();


                for (int i = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
                {

                    fgrid_Main.Cols[i].AllowEditing = false;

                } // end for i



                // item_cd 세팅 되어 있으면 바로 ADD 해서 추가 할 수 있도록 처리
                if (! _ItemCd.Trim().Equals(""))
                {

                    Event_btn_Add_Click();


                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = _ItemCd;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = _ItemCd;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = _ItemCd;
                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = _ItemName;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = _ItemName;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = _ItemName;
                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = _SizeYN;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = _SizeYN;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = _SizeYN;
                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = _Unit;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = _Unit;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = _Unit;


                    if (_SizeYN == "Y")
                    {

                        for (int a = fgrid_Main.Rows.Count - 3; a <= fgrid_Main.Rows.Count - 1; a++)
                        {

                            for (int i = 1; i < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i++)
                            {

                                CellStyle cs_size_yn = fgrid_Main.Styles.Add("SIZE_Y_" + a.ToString() + i.ToString(), fgrid_Main.GetCellRange(a, i).Style);
                                cs_size_yn.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
                                fgrid_Main.SetCellStyle(a, i, "SIZE_Y_" + a.ToString() + i.ToString());

                            } // end for i

                        } // end for a


                    } // end if (_SizeYN == "Y")


                    if (_StyleCd == "______")
                    {
                        chk_UseAllStyles.Checked = true;
                    } // end if (_StyleCd == "______")


                }



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        } 



        private string _itemGroupCode = " "; 


        /// <summary>
        /// Event_cmb_ItemGroup_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_ItemGroup_SelectedValueChanged()
        {

            try
            {

                if (cmb_ItemGroup.SelectedIndex != -1)
                {
                    btn_GroupSearch.Enabled = true;
                    txt_ItemGroup.Text = "";
                    _itemGroupCode = cmb_ItemGroup.SelectedValue.ToString();

                }
                else
                {

                    btn_GroupSearch.Enabled = false;
                    txt_ItemGroup.Text = "";
                    _itemGroupCode = " ";
                }

                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_ItemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_btn_GroupSearch_Click : 
        /// </summary>
        private void Event_btn_GroupSearch_Click()
        {

            try
            {

                string item_group = cmb_ItemGroup.SelectedValue.ToString();

                FlexBase.MaterialBase.Pop_GroupSearchAll pop_form = new FlexBase.MaterialBase.Pop_GroupSearchAll(item_group);
                pop_form.ShowDialog();

                _itemGroupCode = COM.ComVar.Parameter_PopUp[3];
                txt_ItemGroup.Text = COM.ComVar.Parameter_PopUp[4];

                pop_form.Dispose();


                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_GroupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_Tbtn_New_Click : 컨트롤 초기화
        /// </summary>
        private void Event_Tbtn_New_Click()
        {

            try
            {
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


                if (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "") == ""
                    && ClassLib.ComFunction.Empty_TextBox(txt_Item, "") == "") return;


                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


                string factory = "__"; // 공장 구분 없이 공통되게 사용되므로 default로 조회
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "-1");
                string group_cd = _itemGroupCode;
                string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_Item, "");

                DataTable dt_ret = SELECT_SBC_YIELD_ITEM_GROUP(factory, style_cd, group_cd, item_cd);

                if (dt_ret == null || dt_ret.Rows.Count == 0) return;

                Display_Grid(dt_ret);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_dt"></param>
        private void Display_Grid(DataTable arg_dt)
        {

            string factory = "";
            string style_cd = "";
            string item_cd = "";
            string item_name = "";
            string mng_unit = "";
            string size_yn = "";
            string cs_size_from = "";
            string cs_size_to = "";
            string spec_cd = "";
            string spec_name = "";
            string yield_m = "";

            string before_data = "";
            string now_data = "";

            string now_cs_size = "";
            int cs_size_from_col = -1;
            int cs_size_to_col = -1;
                      

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                factory = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_FACTORY] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_FACTORY].ToString();
                style_cd = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_STYLE_CD] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_STYLE_CD].ToString();
                item_cd = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_ITEM_CD] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_ITEM_CD].ToString();
                item_name = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_ITEM_NAME] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_ITEM_NAME].ToString();
                mng_unit = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_MNG_UNIT] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_MNG_UNIT].ToString();
                size_yn = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_SIZE_YN] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_SIZE_YN].ToString();
                


                now_data = factory + style_cd + item_cd;


                // display header
                if (before_data != now_data)
                {


                    fgrid_Main.Rows.InsertRange(fgrid_Main.Rows.Count, 3);


                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "";
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "";
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "";

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] = _RowDivisionValue;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] = _RowDivisionSpecCd;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] = _RowDivisionSpecName;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY] = factory;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY] = factory;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY] = factory;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] = style_cd;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] = style_cd;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] = style_cd;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = item_cd;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = item_cd;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = item_cd;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = item_name;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = item_name;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = item_name;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = mng_unit;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = mng_unit;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = mng_unit;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = size_yn;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = size_yn;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = size_yn;

                    fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDESCRIPTION] = "Value";
                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDESCRIPTION] = "SPEC_CD";
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDESCRIPTION] = "Spec";



                    // value 값은 사용하지 않기로 함
                    //CellStyle cellst = fgrid_Main.Styles.Add("NUMBER", fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].Style);
                    //cellst.DataType = typeof(double);
                    //cellst.Format = "#,##0.##########";
                    ////fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].Style = fgrid_Main.Styles["NUMBER"];

                    //for (int a = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; a < fgrid_Main.Cols.Count; a++)
                    //{
                    //    fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 3, a, "NUMBER");
                    //}

                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].Visible = false;

                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 2].Visible = false;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].TextAlign = TextAlignEnum.RightCenter;


                    // 채산값만 수정 가능하도록
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].AllowEditing = false;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 2].AllowEditing = false;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;


                    //// 아이템 그룹 표시
                    //fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;
                    //fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.Border.Color = Color.Blue;



                    // 사이즈 아이템 표시
                    if (size_yn == "Y")
                    {

                        for (int a = 1; a < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; a++)
                        {

                            CellStyle cs_size_yn = fgrid_Main.Styles.Add("SIZE_Y_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString(), fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 3, a).Style);
                            cs_size_yn.ForeColor = ClassLib.ComVar.ClrYield_SizeY;

                            fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 3, a, "SIZE_Y_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString());
                            fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 2, a, "SIZE_Y_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString());
                            fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 1, a, "SIZE_Y_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString());

                        } // end for i


                    } 
                    else
                    {

                        for (int a = 1; a < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; a++)
                        {

                            CellStyle cs_size_yn = fgrid_Main.Styles.Add("SIZE_N_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString(), fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 3, a).Style);
                            cs_size_yn.ForeColor = Color.Black;

                            fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 3, a, "SIZE_N_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString());
                            fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 2, a, "SIZE_N_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString());
                            fgrid_Main.SetCellStyle(fgrid_Main.Rows.Count - 1, a, "SIZE_N_" + Convert.ToString(fgrid_Main.Rows.Count - 3) + a.ToString());

                        } // end for i


                    } // end if size_yn == "Y"




                    before_data = now_data;


                } // end if display header


                cs_size_from = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_CS_SIZE_FROM] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_CS_SIZE_FROM].ToString();
                cs_size_to = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_CS_SIZE_TO] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_CS_SIZE_TO].ToString();
                spec_cd = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_SPEC_CD] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_SPEC_CD].ToString();
                spec_name = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_SPEC_NAME] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_SPEC_NAME].ToString();
                yield_m = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_YIELD_M] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDB_YIELD_M].ToString();



                //---------------------
                // size 시작 ~ 끝 컬럼 계산
                for (int a = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; a < fgrid_Main.Cols.Count; a++)
                {
                    now_cs_size = (fgrid_Main[1, a] == null) ? "" : fgrid_Main[1, a].ToString();

                    if (now_cs_size == cs_size_from)
                    {
                        cs_size_from_col = a;
                        break;
                    }

                }

                cs_size_from_col = (cs_size_from_col == -1) ? (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START : cs_size_from_col;

                for (int a = cs_size_from_col; a < fgrid_Main.Cols.Count; a++)
                {
                    now_cs_size = (fgrid_Main[1, a] == null) ? "" : fgrid_Main[1, a].ToString();

                    if (now_cs_size == cs_size_to)
                    {
                        cs_size_to_col = a;
                        break;
                    }

                }

                cs_size_to_col = (cs_size_to_col == -1) ? fgrid_Main.Cols.Count - 1 : cs_size_to_col;
                //---------------------


                //---------------------
                // 채산값, spec 표시
                for (int a = cs_size_from_col; a <= cs_size_to_col; a++)
                {

                    fgrid_Main[fgrid_Main.Rows.Count - 3, a] = yield_m;
                    fgrid_Main[fgrid_Main.Rows.Count - 2, a] = spec_cd;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, a] = spec_name;

                }
                //---------------------


                //---------------------
                // 사이즈 자재 표시 가능
                if (size_yn == "Y" && cs_size_to_col == fgrid_Main.Cols.Count - 1)
                {
                    Display_Size_Material(fgrid_Main.Rows.Count - 3, fgrid_Main.Rows.Count - 2, fgrid_Main.Rows.Count - 1);
                }
                //---------------------


            } // end for i


        }




        /// <summary>
        /// Display_Size_Material : 
        /// </summary>
        /// <param name="arg_row_value"></param>
        /// <param name="arg_row_spec_cd"></param>
        /// <param name="arg_row_spec_name"></param>
        private void Display_Size_Material(int arg_row_value, int arg_row_spec_cd, int arg_row_spec_name)
        {

            try
            {

                Color color_SizeSpecOdd = ClassLib.ComVar.ClrSel_Green;
                Color color_SizeSpecEven = ClassLib.ComVar.ClrSel_Yellow;
                Color color_SizeSpecCurrent;

                
                string before_spec = "";
                string now_spec = "";
                int size_from_col = -1;
                int size_to_col = -1;



                color_SizeSpecCurrent = color_SizeSpecEven;


                size_from_col = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START;


                while (true)
                {

                    before_spec = (fgrid_Main[arg_row_spec_cd, size_from_col] == null) ? "" : fgrid_Main[arg_row_spec_cd, size_from_col].ToString();


                    for (int k = size_from_col; k < fgrid_Main.Cols.Count; k++)
                    {

                        now_spec = (fgrid_Main[arg_row_spec_cd, k] == null) ? "" : fgrid_Main[arg_row_spec_cd, k].ToString();

                        if (before_spec == now_spec)
                        {
                            size_to_col = k;
                        }
                        else
                        {
                            break;
                        }

                    }


                    //SPEC CODE 별 색깔 표시
                    if (color_SizeSpecCurrent.Equals(color_SizeSpecOdd))
                    {
                        color_SizeSpecCurrent = color_SizeSpecEven;
                    }
                    else
                    {
                        color_SizeSpecCurrent = color_SizeSpecOdd;
                    }



                    for (int i = size_from_col; i <= size_to_col; i++)
                    {

                        CellStyle cs_spec_value = fgrid_Main.Styles.Add("SPEC_COLOR_VALUE_" + Convert.ToString(arg_row_value) + i.ToString(), fgrid_Main.GetCellRange(arg_row_value, i).Style);
                        cs_spec_value.BackColor = color_SizeSpecCurrent;
                        fgrid_Main.SetCellStyle(arg_row_value, i, "SPEC_COLOR_VALUE_" + Convert.ToString(arg_row_value) + i.ToString());

                        CellStyle cs_spec_spec_cd = fgrid_Main.Styles.Add("SPEC_COLOR_SPEC_CD_" + Convert.ToString(arg_row_spec_cd) + i.ToString(), fgrid_Main.GetCellRange(arg_row_spec_cd, i).Style);
                        cs_spec_spec_cd.BackColor = color_SizeSpecCurrent;
                        fgrid_Main.SetCellStyle(arg_row_spec_cd, i, "SPEC_COLOR_SPEC_CD_" + Convert.ToString(arg_row_spec_cd) + i.ToString());


                        CellStyle cs_spec_spec_name = fgrid_Main.Styles.Add("SPEC_COLOR_NAME_" + Convert.ToString(arg_row_spec_name) + i.ToString(), fgrid_Main.GetCellRange(arg_row_spec_name, i).Style);
                        cs_spec_spec_name.BackColor = color_SizeSpecCurrent;
                        fgrid_Main.SetCellStyle(arg_row_spec_name, i, "SPEC_COLOR_NAME_" + Convert.ToString(arg_row_spec_name) + i.ToString());


                    }



                    size_from_col = size_to_col + 1;


                    if (size_from_col == fgrid_Main.Cols.Count) break;


                } // end while


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Display_Size_Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        /// <summary>
        /// Event_tbtn_Save_Click : 
        /// </summary>
        private void Event_tbtn_Save_Click()
        {

            try
            {


                //----------------------------------------
                // check condition : 아이템 할당 확인
                //----------------------------------------
                string item_cd = "";

                for (int a = fgrid_Main.Rows.Fixed; a < fgrid_Main.Rows.Count; a++)
                {

                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] != null
                        && fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I")
                    {

                        item_cd = (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] == null) ? "" : fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString();

                        if (item_cd == "")
                        {

                            string message = "We must input item.";
                            ClassLib.ComFunction.User_Message(message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;

                        }


                    } // end if division = "I"

                } // end for a
                //----------------------------------------


                // 값은 저장 하지 않기로 함
                ////----------------------------------------
                //// check condition : 모두 값 할당 확인
                ////----------------------------------------
                //string value = "";

                //for (int a = fgrid_Main.Rows.Fixed; a < fgrid_Main.Rows.Count; a++)
                //{

                //    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] == null
                //        || fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION].ToString() != _RowDivisionValue) continue;



                //    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] != null
                //        && fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I")
                //    {


                //        for (int i = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
                //        {

                //            value = (fgrid_Main[a, i] == null) ? "" : fgrid_Main[a, i].ToString();

                //            if (value == "")
                //            {

                //                string message = "Unsuitable yield value.";
                //                ClassLib.ComFunction.User_Message(message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //                fgrid_Main.LeftCol = i - 1;
                //                fgrid_Main.Select(a, i, true);

                //                return;

                //            }

                //        } // end for i


                //    } // end if division = "I"

                //} // end for a
                ////----------------------------------------


                //----------------------------------------
                // check condition : 모두 spec 할당 확인
                //----------------------------------------
                string spec_cd = "";

                for (int a = fgrid_Main.Rows.Fixed; a < fgrid_Main.Rows.Count; a++)
                {

                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] == null
                        || fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION].ToString() != _RowDivisionSpecCd) continue;


                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] != null
                        && fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I")
                    {


                        for (int i = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
                        {

                            spec_cd = (fgrid_Main[a, i] == null) ? "" : fgrid_Main[a, i].ToString();

                            if (spec_cd == "")
                            {

                                string message = "Unsuitable yield spec.";
                                ClassLib.ComFunction.User_Message(message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                fgrid_Main.LeftCol = i - 1;
                                fgrid_Main.Select(a, i, true);

                                return;

                            }

                        } // end for i


                    } // end if division = "I"

                } // end for a
                //----------------------------------------


                bool save_flag = SAVE_SBC_YIELD_ITEM_GROUP();


                if (!save_flag)
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                }
                else
                {

                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

                    Event_tbtn_Search_Click();

                } // end if 



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_Add_Click : 
        /// </summary>
        private void Event_btn_Add_Click()
        {

            try
            {

                if (txt_StyleCd.Text.Trim() == "") return;
                if (txt_StyleCd.Text.Trim().Length != 6) return;


                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] != null
                        && fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I")
                    {

                        if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] == null
                            || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString().Trim() == "")
                        {
                            return;
                        }

                    } // end if

                } // end for i




                fgrid_Main.Rows.InsertRange(fgrid_Main.Rows.Count, 3);


                fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "I";
                fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "I";
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "I";

                fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] = _RowDivisionValue;
                fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] = _RowDivisionSpecCd;
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] = _RowDivisionSpecName;

                fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY] = "__";  // 공장 구분 없이 공통되게 사용되므로 default로 조회
                fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY] = "__";
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY] = "__";

                fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] = txt_StyleCd.Text;
                fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] = txt_StyleCd.Text;
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] = txt_StyleCd.Text;

                fgrid_Main[fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDESCRIPTION] = "Value";
                fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDESCRIPTION] = "SPEC_CD";
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDESCRIPTION] = "Spec";


                //// value 값은 사용하지 않기로 함
                //CellStyle cellst = fgrid_Main.Styles.Add("NUMBER", fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].Style);
                //cellst.DataType = typeof(double);
                //cellst.Format = "#,##0.##########";
                //fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].Style = fgrid_Main.Styles["NUMBER"];

                fgrid_Main.Rows[fgrid_Main.Rows.Count - 3].Visible = false;

                fgrid_Main.Rows[fgrid_Main.Rows.Count - 2].Visible = false;
                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].TextAlign = TextAlignEnum.RightCenter;


                //// 아이템 그룹 표시
                //fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;
                //fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.Border.Color = Color.Blue;


                fgrid_Main.LeftCol = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME - 1;


                // default spec nothing
                CellRange cr_value = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 3, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START, fgrid_Main.Rows.Count - 3, fgrid_Main.Cols.Count - 1);
                cr_value.Data = "0";

                CellRange cr_spec_cd = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START, fgrid_Main.Rows.Count - 2, fgrid_Main.Cols.Count - 1);
                cr_spec_cd.Data = "00000";

                CellRange cr_spec_name = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1);
                cr_spec_name.Data = "NOTHING";


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Add_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_Delete_Click :  
        /// </summary>
        private void Event_btn_Delete_Click()
        {
            try
            {


                if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


                //-------------------------------------------
                // item row set
                //-------------------------------------------
                int first_row = -1;
                int last_row = -1;

                string sel_row_type = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION].ToString();

                if (sel_row_type == _RowDivisionValue)
                {
                    first_row = fgrid_Main.Row;
                    last_row = fgrid_Main.Row + 2;
                }
                else if (sel_row_type == _RowDivisionSpecCd)
                {
                    first_row = fgrid_Main.Row - 1;
                    last_row = fgrid_Main.Row + 1;
                }
                else if (sel_row_type == _RowDivisionSpecName)
                {
                    first_row = fgrid_Main.Row - 2;
                    last_row = fgrid_Main.Row;
                }
                //-------------------------------------------


                for (int a = last_row; a >= first_row; a--)
                {

                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] != null
                        && fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I")
                    {
                        fgrid_Main.Rows.Remove(a);
                    }
                    else
                    {
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "D";
                    }


                } // end for a


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


                if (fgrid_Main.Col == (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME)
                {

                    Select_GridCombo_Item();

                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Select_GridCombo_Item : 
        /// </summary>
        private void Select_GridCombo_Item()
        {


            string not_assign_style_name = "NOT_ASSIGN_" + Convert.ToString(fgrid_Main.Row) + Convert.ToString((int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME);
            CellStyle cs_not_assign = fgrid_Main.Styles.Add(not_assign_style_name);
            cs_not_assign.ForeColor = Color.Green;

            string assign_style_name = "ASSIGN_" + Convert.ToString(fgrid_Main.Row) + Convert.ToString((int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME);
            CellStyle cs_assign = fgrid_Main.Styles.Add(assign_style_name);
            cs_assign.ForeColor = Color.Black;


            //-------------------------------------------
            // item row set
            //-------------------------------------------
            int first_row = -1;
            int last_row = -1;

            string sel_row_type = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION].ToString();

            if (sel_row_type == _RowDivisionValue)
            {
                first_row = fgrid_Main.Row;
                last_row = fgrid_Main.Row + 2;
            }
            else if (sel_row_type == _RowDivisionSpecCd)
            {
                first_row = fgrid_Main.Row - 1;
                last_row = fgrid_Main.Row + 1;
            }
            else if (sel_row_type == _RowDivisionSpecName)
            {
                first_row = fgrid_Main.Row - 2;
                last_row = fgrid_Main.Row;
            }
            //-------------------------------------------



            try
            {

                
                string item = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();

                if (item.Trim().Equals("")) return;

                // default : [process] group type
                string group_cd = "01";

                // code로 조회 할 때는 해당 코드만 바로 리스트에 올라오도록 처리하기 위함
                // code는 모두 정수이고, 이름 검색할때는 문자, 숫자 조합으로 한다는 가정하에 처리
                string code_div = "";

                try
                {
                    int code = Convert.ToInt32(item);
                    code_div = "Y";
                }
                catch
                {
                    code_div = "N";
                }

                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_ITEM_COMBO(group_cd, item, code_div);

               

                FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                string[] key_string = new string[] { "ITEM_CD" };
                string[] value_string = new string[] { "ITEM_NAME1", "MNG_UNIT", "SIZE_YN" };

                grid_combo._JobDivision = "ITEM";
                grid_combo._ItemCD = item;
                grid_combo.ShowData(dt_ret, key_string, value_string, true, item);
                grid_combo.StartPosition = FormStartPosition.CenterParent;


                if (grid_combo.ShowDialog() != DialogResult.OK)
                {

                    for (int a = first_row; a <= last_row; a++)
                    {

                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = "";
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = item;
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = "";
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = "";



                        fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD, not_assign_style_name);
                        fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME, not_assign_style_name);
                        fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT, not_assign_style_name);
                        fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN, not_assign_style_name);

                    }

                    return;
                }



                //-------------------------------------------------------------
                // 중복 확인
                // 저장 된 데이터 (DB), 저장 전 데이터 (Grid) 모두 체크 필요
                //-------------------------------------------------------------
                string factory = "__";  // 공장 구분 없이 공통되게 사용되므로 default로 조회
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                string item_cd = (grid_combo.VRow[0] == null) ? "" : grid_combo.VRow[0].ToString();
                string item_name = (grid_combo.VRow[1] == null) ? "" : grid_combo.VRow[1].ToString();


                // DB 확인
                bool duplicate_flag = Check_Duplicate_Item(factory, style_cd, item_cd);


                if (duplicate_flag)
                {

                    string message = "We have already item size group : [" + item_name + "]";
                    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Item", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    for (int a = first_row; a <= last_row; a++)
                    {

                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = "";
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = item;
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = "";
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = "";

                    }

                    return;

                }
                //-------------------------------------------------------------



                for (int a = first_row; a <= last_row; a++)
                {

                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = (grid_combo.VRow[0] == null) ? "" : grid_combo.VRow[0].ToString();
                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = (grid_combo.VRow[1] == null) ? "" : grid_combo.VRow[1].ToString();
                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = (grid_combo.VRow[2] == null) ? "" : grid_combo.VRow[2].ToString();
                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = (grid_combo.VRow[3] == null) ? "" : grid_combo.VRow[3].ToString();


                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] == null
                        || fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "")
                    {
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "U";
                    }


                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD, assign_style_name);
                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME, assign_style_name);
                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT, assign_style_name);
                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN, assign_style_name);


                    // 사이즈 아이템 표시
                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] != null
                        && fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN].ToString() == "Y")
                    {

                        for (int i = 1; i < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i++)
                        {

                            CellStyle cs_size_yn = fgrid_Main.Styles.Add("SIZE_Y_" + a.ToString() + i.ToString(), fgrid_Main.GetCellRange(a, i).Style);
                            cs_size_yn.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
                            fgrid_Main.SetCellStyle(a, i, "SIZE_Y_" + a.ToString() + i.ToString());

                        } // end for i


                    } // end if size_yn == "Y"


                }




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Item", MessageBoxButtons.OK, MessageBoxIcon.Information);



                for (int a = first_row; a <= last_row; a++)
                {

                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] = "";
                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME] = fgrid_Main.Buffer_CellData;
                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT] = "";
                    fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] = "";



                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD, not_assign_style_name);
                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_NAME, not_assign_style_name);
                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxMNG_UNIT, not_assign_style_name);
                    fgrid_Main.SetCellStyle(a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN, not_assign_style_name);

                } // end for a

            }



        }



        /// <summary>
        /// Check_Duplicate_Item : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_item_cd"></param>
        /// <returns></returns>
        private bool Check_Duplicate_Item(string arg_factory, string arg_style_cd, string arg_item_cd)
        {


            try
            {



                bool duplicate_flag = false;


                // DB 확인
                duplicate_flag = CHECK_SBC_YIELD_ITEM_GROUP(arg_factory, arg_style_cd, arg_item_cd);

                if (duplicate_flag)
                {
                    return duplicate_flag;
                }



                // Grid 확인
                duplicate_flag = false;

                string now_division = "";
                string now_style_cd = "";
                string now_item_cd = "";

                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {


                    now_division = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString();
                    now_style_cd = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD].ToString();
                    now_item_cd = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString();


                    if (now_style_cd != arg_style_cd) continue;


                    // 삭제 될 예정이므로 중복 체크 대상에서 제외
                    if (now_division == "D") continue;


                    if (now_item_cd == arg_item_cd)
                    {
                        duplicate_flag = true;
                        break;
                    }


                } // end for i


                return duplicate_flag;



            }
            catch
            {
                return false;
            }


        }



        /// <summary>
        /// Event_fgrid_Main_MouseUp : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_fgrid_Main_MouseUp(MouseEventArgs e)
        {
            try
            {

                if (fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;


                if (e.Button != MouseButtons.Right) return;


                if (fgrid_Main.Col < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START) return;


                // item, spec, color 없으면 설정 할 수 없음
                if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD] == null
                    || fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString() == "")
                {
                    return;
                }


                //-------------------------------------------
                // item row set
                //-------------------------------------------
                int row_value = -1;
                int row_spec_cd = -1;
                int row_spec_name = -1;

                string sel_row_type = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION].ToString();

                if (sel_row_type == _RowDivisionValue)
                {
                    row_value = fgrid_Main.Row;
                    row_spec_cd = fgrid_Main.Row + 1;
                    row_spec_name = fgrid_Main.Row + 2;

                }
                else if (sel_row_type == _RowDivisionSpecCd)
                {
                    row_value = fgrid_Main.Row - 1;
                    row_spec_cd = fgrid_Main.Row;
                    row_spec_name = fgrid_Main.Row + 1;
                }
                else if (sel_row_type == _RowDivisionSpecName)
                {
                    row_value = fgrid_Main.Row - 2;
                    row_spec_cd = fgrid_Main.Row - 1;
                    row_spec_name = fgrid_Main.Row;
                }
                //-------------------------------------------

                if (chk_SizeSpec.Checked)
                {
                    Set_Spec_MouseUp(row_value, row_spec_cd, row_spec_name);
                }
                else // popup
                {
                    Set_Spec_PopUp(row_value, row_spec_cd, row_spec_name);
                }



                if (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] != null
                    && fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN].ToString() == "Y")
                {
                    Display_Size_Material(row_value, row_spec_cd, row_spec_name);
                }


                for (int a = row_value; a <= row_spec_name; a++)
                {

                    if (fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] != null
                        && fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I")
                    {
                        continue;
                    }
                    else
                    {
                        fgrid_Main[a, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] = "U";
                    }


                } // end for a



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Set_Spec_MouseUp : 
        /// </summary>
        /// <param name="arg_row_value"></param>
        /// <param name="arg_row_spec_cd"></param>
        /// <param name="arg_row_spec_name"></param>
        private void Set_Spec_MouseUp(int arg_row_value, int arg_row_spec_cd, int arg_row_spec_name)
        {

            
            // 마우스 업 한 부분 사이즈 스펙 자동 할당
            // 하지 않은 부분 nothing 으로 처리?, 사이즈런으로 처리?

            int size_f = fgrid_Main.Selection.c1;
            int size_t = fgrid_Main.Selection.c2;

            string spec_name = fgrid_Main[1, size_f].ToString().Trim() + "-" + fgrid_Main[1, size_t].ToString().Trim();
            string spec_cd = FlexBase.Yield_New.Form_BC_Yield.CHECK_SBC_YIELD_SPEC_NAME(spec_name);

            for (int i = size_f; i <= size_t; i++)
            {
                fgrid_Main[arg_row_spec_cd, i] = spec_cd;
                fgrid_Main[arg_row_spec_name, i] = spec_name;
            }


        }




        /// <summary>
        /// Set_Spec_PopUp : 
        /// </summary>
        /// <param name="arg_row_value"></param>
        /// <param name="arg_row_spec_cd"></param>
        /// <param name="arg_row_spec_name"></param>
        private void Set_Spec_PopUp(int arg_row_value, int arg_row_spec_cd, int arg_row_spec_name)
        {


            string size_yn = (fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] == null) ? "" : fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN].ToString();

            string cs_size_f = fgrid_Main[1, fgrid_Main.Selection.c1].ToString();
            string cs_size_t = fgrid_Main[1, fgrid_Main.Selection.c2].ToString();
            string yield_value = (fgrid_Main[arg_row_value, fgrid_Main.Col] == null) ? "0" : fgrid_Main[arg_row_value, fgrid_Main.Col].ToString();
            string spec_cd = (fgrid_Main[arg_row_spec_cd, fgrid_Main.Col] == null) ? "" : fgrid_Main[arg_row_spec_cd, fgrid_Main.Col].ToString();
            string spec_name = (fgrid_Main[arg_row_spec_name, fgrid_Main.Col] == null) ? "" : fgrid_Main[arg_row_spec_name, fgrid_Main.Col].ToString();


            FlexBase.Yield_New.Pop_Yield_Input_Value pop_form = new Pop_Yield_Input_Value(cs_size_f, cs_size_t, yield_value, spec_cd, spec_name);
            pop_form.ShowDialog();


            //cancel 했을 경우
            if (pop_form._CancelFlag) return;


            //apply 했을 경우
            for (int i = fgrid_Main.Selection.c1; i <= fgrid_Main.Selection.c2; i++)
            {
                fgrid_Main[arg_row_value, i] = pop_form._Return_Value;
                fgrid_Main[arg_row_spec_cd, i] = pop_form._Return_SpecCode;
                fgrid_Main[arg_row_spec_name, i] = pop_form._Return_SpecName;
            }




        }




        /// <summary>
        /// Event_fgrid_Main_AfterResizeColumn : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_fgrid_Main_AfterResizeColumn(RowColEventArgs e)
        {

            try
            {

                if (e.Col < (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START) return;


                for (int i = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
                {
                    fgrid_Main.Cols[i].Width = fgrid_Main.Cols[e.Col].Width;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterResizeColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_chk_UseAllStyles_CheckedChanged : 
        /// </summary>
        private void Event_chk_UseAllStyles_CheckedChanged()
        {
          
            try
            {

                if (chk_UseAllStyles.Checked)
                {
                    txt_StyleCd.Text = "______";
                    txt_StyleCd.ReadOnly = true;
                    txt_StyleCd.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    txt_StyleCd.Text = _StyleCd;
                    txt_StyleCd.ReadOnly = false;
                    txt_StyleCd.BackColor = Color.White;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_chk_UseAllStyles_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #endregion

        #region 디비 연결



        /// <summary>
        /// SELECT_SBC_YIELD_ITEM_GROUP : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_group_cd"></param>
        /// <param name="arg_item_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SBC_YIELD_ITEM_GROUP(string arg_factory, string arg_style_cd, string arg_group_cd, string arg_item_cd)
        {

            try
            {


                MyOraDB.ReDim_Parameter(5);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD_ITEM_GROUP";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_GROUP_CD";
                MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_group_cd;
                MyOraDB.Parameter_Values[3] = arg_item_cd;
                MyOraDB.Parameter_Values[4] = "";


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
        /// CHECK_SBC_YIELD_ITEM_GROUP : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_item_cd"></param>
        /// <returns></returns>
        private bool CHECK_SBC_YIELD_ITEM_GROUP(string arg_factory, string arg_style_cd, string arg_item_cd)
        {

            try
            {


                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.CHECK_SBC_YIELD_ITEM_GROUP";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_item_cd;
                MyOraDB.Parameter_Values[3] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return false;

                return (ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString() == "Y") ? true : false;


            }
            catch
            {
                return false;
            }


        }



        /// <summary>
        /// SAVE_SBC_YIELD_ITEM_GROUP : 
        /// </summary>
        /// <returns></returns>
        private bool SAVE_SBC_YIELD_ITEM_GROUP()
        {


            try
            {


                int col_ct = 9;

                MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_SBC_YIELD_ITEM_GROUP";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE_FROM";
                MyOraDB.Parameter_Name[4] = "ARG_CS_SIZE_TO";
                MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[6] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[7] = "ARG_YIELD_M";
                MyOraDB.Parameter_Name[8] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                int row_value = -1;
                int row_spec_cd = -1;
                int row_spec_name = -1;
                string before_spec = "";
                string now_spec = "";
                int size_f = -1;
                int size_t = -1;



                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION] == null
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "") continue;


                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION] == null
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxROW_DIVISION].ToString() != _RowDivisionValue) continue;


                    row_value = i;
                    row_spec_cd = i + 1;
                    row_spec_name = i + 2;


                    if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "I"
                        || fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "U")
                    {


                        // delete -> insert
                        vList.Add("D"); // "ARG_DIVISION";
                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY].ToString()); // "ARG_FACTORY";
                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD].ToString()); // "ARG_STYLE_CD";
                        vList.Add(""); // "ARG_CS_SIZE_FROM";
                        vList.Add(""); // "ARG_CS_SIZE_TO";
                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString()); // "ARG_ITEM_CD";
                        vList.Add(""); // "ARG_SPEC_CD";
                        vList.Add(""); // "ARG_YIELD_M";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";




                        size_f = (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxCS_SIZE_START;


                        if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN] != null
                            && fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSIZE_YN].ToString() == "Y") // 사이즈 아이템일 경우, spec으로 사이즈 그룹 구분
                        {


                            while (true)
                            {

                                before_spec = (fgrid_Main[row_spec_cd, size_f] == null) ? "" : fgrid_Main[row_spec_cd, size_f].ToString();


                                for (int k = size_f; k < fgrid_Main.Cols.Count; k++)
                                {

                                    now_spec = (fgrid_Main[row_spec_cd, k] == null) ? "" : fgrid_Main[row_spec_cd, k].ToString();


                                    if (before_spec == now_spec)
                                    {
                                        size_t = k;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }



                                vList.Add("I"); // "ARG_DIVISION";
                                vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY].ToString()); // "ARG_FACTORY";
                                vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD].ToString()); // "ARG_STYLE_CD";
                                vList.Add(fgrid_Main[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                                vList.Add(fgrid_Main[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                                vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString()); // "ARG_ITEM_CD";
                                vList.Add((fgrid_Main[row_spec_cd, size_f] == null) ? "" : fgrid_Main[row_spec_cd, size_f].ToString()); // "ARG_SPEC_CD";
                                vList.Add((fgrid_Main[row_value, size_f] == null) ? "0" : fgrid_Main[row_value, size_f].ToString()); // "ARG_YIELD_M";
                                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";



                                size_f = size_t + 1;

                                if (size_f == fgrid_Main.Cols.Count) break;

                            } // end while



                        }
                        else // 사이즈 아이템 아닐 경우, value로 사이즈 그룹 구분
                        {


                            while (true)
                            {

                                before_spec = (fgrid_Main[row_value, size_f] == null) ? "0" : fgrid_Main[row_value, size_f].ToString();

                                for (int k = size_f; k < fgrid_Main.Cols.Count; k++)
                                {

                                    now_spec = (fgrid_Main[row_value, k] == null) ? "0" : fgrid_Main[row_value, k].ToString();


                                    if (before_spec == now_spec)
                                    {
                                        size_t = k;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }


                                vList.Add("I"); // "ARG_DIVISION";
                                vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY].ToString()); // "ARG_FACTORY";
                                vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD].ToString()); // "ARG_STYLE_CD";
                                vList.Add(fgrid_Main[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                                vList.Add(fgrid_Main[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                                vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString()); // "ARG_ITEM_CD";
                                vList.Add((fgrid_Main[row_spec_cd, size_f] == null) ? "" : fgrid_Main[row_spec_cd, size_f].ToString()); // "ARG_SPEC_CD";
                                vList.Add((fgrid_Main[row_value, size_f] == null) ? "0" : fgrid_Main[row_value, size_f].ToString()); // "ARG_YIELD_M";
                                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                                size_f = size_t + 1;

                                if (size_f == fgrid_Main.Cols.Count) break;

                            } // end while



                        }


                    }
                    else if (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString() == "D")
                    {

                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxDIVISION].ToString()); // "ARG_DIVISION";
                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxFACTORY].ToString()); // "ARG_FACTORY";
                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxSTYLE_CD].ToString()); // "ARG_STYLE_CD";
                        vList.Add(""); // "ARG_CS_SIZE_FROM";
                        vList.Add(""); // "ARG_CS_SIZE_TO";
                        vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_ITEM_GROUP_NEW.IxITEM_CD].ToString()); // "ARG_ITEM_CD";
                        vList.Add(""); // "ARG_SPEC_CD";
                        vList.Add(""); // "ARG_YIELD_M";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";

                    } 


                } // end for i

                
               

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

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

                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_YIELD_ITEM_GROUP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }




        #endregion

        



    }
}