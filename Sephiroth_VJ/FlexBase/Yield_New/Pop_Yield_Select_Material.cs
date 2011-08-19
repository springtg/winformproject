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
    public partial class Pop_Yield_Select_Material : COM.PCHWinForm.Pop_Large
    {

        #region 생성자


        public Pop_Yield_Select_Material()
        {
            InitializeComponent();
        }



        public FlexBase.Yield_New.Form_BC_Yield _Parent_Form;
        public string _ItemCd = "";
        public string _ItemName = "";
        public string _Unit = "";
        public string _SizeYN = "";
        public string _SpecCd = "";
        public string _SpecName = "";
        public string _ColorCd = "";
        public string _ColorName = "";
        public string _DefaultTabPage = "";
        public int _GridSelectRow = -1;



        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg_parent_form"></param>
        /// <param name="arg_itemcd"></param>
        /// <param name="arg_itemname"></param>
        /// <param name="arg_speccd"></param>
        /// <param name="arg_specname"></param>
        /// <param name="arg_colorcd"></param>
        /// <param name="arg_colorname"></param>
        /// <param name="arg_unit"></param>
        /// <param name="arg_sizeyn"></param>
        /// <param name="arg_default_tabpage"></param>
        /// <param name="arg_grid_select_row"></param>
        public Pop_Yield_Select_Material(FlexBase.Yield_New.Form_BC_Yield arg_parent_form,
			string arg_itemcd, 
			string arg_itemname,
			string arg_speccd, 
			string arg_specname, 
			string arg_colorcd, 
			string arg_colorname, 
			string arg_unit,
			string arg_sizeyn,
            string arg_default_tabpage,
            int arg_grid_select_row)
        {

            InitializeComponent();


            _Parent_Form = arg_parent_form;

            _ItemCd = arg_itemcd;
            _ItemName = arg_itemname;
            _SpecCd = arg_speccd;
            _SpecName = arg_specname;
            _ColorCd = arg_colorcd;
            _ColorName = arg_colorname;
            _Unit = arg_unit;
            _SizeYN = arg_sizeyn;
            _DefaultTabPage = arg_default_tabpage;
            _GridSelectRow = arg_grid_select_row;

            
            //Init_Form();  


        }

         

        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();

        //사이즈 Item 선택되었을 때 Specification Division을 [사이즈]로 고정시키기 위해서
        private string _Size_SpecDiv = "1";

        //return 또는 cancel 이벤트 체크
        private bool _CancelFlag = true;


        #endregion

        #region 멤버 메서드

        /// <summary>
        /// Init_Form : 
        /// </summary>
        public void Init_Form()
        {
            try
            {
                //Title
                this.Text = "Select Material";
                lbl_MainTitle.Text = "Select Material";

                //영문변환 사용
                ClassLib.ComFunction.SetLangDic(this);

                // 그리드 설정 
                fgrid_Item.Set_Grid("SBC_ITEM_COMMON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                fgrid_Spec.Set_Grid("SBC_SPEC_COMMON", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false);
                fgrid_Color.Set_Grid("SBC_COLOR_COMMON", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false);

                fgrid_Item.Styles.Alternate.BackColor = Color.Empty;
                fgrid_Spec.Styles.Alternate.BackColor = Color.Empty;
                fgrid_Color.Styles.Alternate.BackColor = Color.Empty;

                
                // 콤보박스 세팅
                Init_Control();


                chk_Use_Item.Checked = true;
                chk_Use_Spec.Checked = true;
                chk_Use_Color.Checked = true;


                if (ClassLib.ComVar.This_PowerUser_YN == "Y")
                {
                    btn_AddNewItem.Visible = true;
                }
                else
                {
                    btn_AddNewItem.Visible = false;
                }


                //------------------------------------------------------------
                //초기 결과값 세팅 - 파라미터로 데이터 기존 넘어왔을 경우 위해서
                //------------------------------------------------------------
                txt_Result_ItemCode.Text = _ItemCd;
                txt_Result_ItemName.Text = _ItemName;
                txt_Result_SpecCode.Text = _SpecCd;
                txt_Result_SpecName.Text = _SpecName;
                txt_Result_ColorCode.Text = _ColorCd;
                txt_Result_ColorName.Text = _ColorName;
                txt_Result_ItemUnit.Text = _Unit;
                txt_Result_ItemSize.Text = (_SizeYN == "Y") ? "Yes" : "No";


                if (_DefaultTabPage == "Item")
                {
                    tabControl_Main.SelectedTab = tabPage_Item;
                    txt_ItemName.Focus();
                }
                else if (_DefaultTabPage == "Spec")
                {

                    tabControl_Main.SelectedTab = tabPage_Spec;
                    txt_SpecName.Focus();
                }
                else if (_DefaultTabPage == "Color")
                {
                    tabControl_Main.SelectedTab = tabPage_Color;
                    txt_ColorName.Focus();
                }
                else
                {
                    //show default

                    if (txt_Result_ItemCode.Text.Trim() != "" && txt_Result_ItemName.Text.Trim() != "")
                    {
                        tabControl_Main.SelectedTab = tabPage_Spec;
                        txt_SpecName.Focus();
                    }
                    else
                    {
                        tabControl_Main.SelectedTab = tabPage_Item;
                        txt_ItemName.Focus();
                    }

                }
                //------------------------------------------------------------


                //------------------------------------------------------------
                // 결과데이터를 조회부에도 표시
                //------------------------------------------------------------
                txt_ItemName.Text = _ItemName;

                if (!_SpecCd.Trim().Equals(""))
                {
                    cmb_SpecDiv.SelectedValue = _SpecCd.Substring(0, 1);
                    txt_SpecName.Text = _SpecName;
                }

                txt_ColorName.Text = _ColorName;
                //------------------------------------------------------------


                //------------------------------------------------------------
                // item에 대한 default spec 정보 조회
                //------------------------------------------------------------ 
                if (txt_Result_ItemCode.Text.Trim() != "" && txt_Result_ItemName.Text.Trim() != "")
                {
                    Search_Default_Spec();
                }
                //------------------------------------------------------------





            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Init_Control : 콤보박스 세팅
        /// </summary>
        private void Init_Control()
        {
           
            //그룹타입 콤보쿼리 
            DataTable  dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemType, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_ItemType.SelectedValue = "01";

            // Spec Division Combo List
            dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, true, ClassLib.ComVar.ComboList_Visible.Name);


            dt_ret.Dispose();

        }



        /// <summary>
        /// item에 대한 default specification 정보 조회 
        /// </summary>
        private void Search_Default_Spec()
        {

            string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_Result_ItemCode, " ");

            DataTable dt_ret = Select_SBC_SPEC_MASTER(item_cd);
            fgrid_Spec.Display_Grid(dt_ret, false);

            dt_ret.Dispose();

        }



        /// <summary>
        /// Select_Item : Item Master 조회
        /// </summary>
        private void Select_Item()
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                string group_cd = ClassLib.ComFunction.Empty_Combo(cmb_ItemType, " ") + ClassLib.ComFunction.Empty_Combo(cmb_ItemGroup, " ");
                string item_name = ClassLib.ComFunction.Empty_TextBox(txt_ItemName, " ");
                string use_yn = (chk_Use_Item.Checked) ? "Y" : " ";

                DataTable dt_ret = SELECT_SBC_ITEM_POPUP(group_cd, item_name, use_yn);

                fgrid_Item.Display_Grid(dt_ret, false);

                for (int i = fgrid_Item.Rows.Fixed; i < fgrid_Item.Rows.Count; i++)
                {
                  
                    if (fgrid_Item[i, (int)ClassLib.TBSBC_ITEM_COMMON.IxUSE_YN] != null
                        && fgrid_Item[i, (int)ClassLib.TBSBC_ITEM_COMMON.IxUSE_YN].ToString() == "False")
                    {
                        fgrid_Item.Rows[i].StyleNew.ForeColor = Color.Red;
                    }


                }


                dt_ret.Dispose();




                //------------------------------------------------------------------------------------------------------------------------
                // 정확하게 일치하는 항목으로 결과값 할당
                //------------------------------------------------------------------------------------------------------------------------
                string diff_item = "";
                string current_item = "";

                for (int i = 0; i < fgrid_Item.Rows.Count; i++)
                {

                    if (!txt_ItemName.Text.Trim().Equals(""))
                    {
                        diff_item = txt_ItemName.Text.Trim().ToUpper();
                        current_item = fgrid_Item[i, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_NAME1].ToString().Trim().ToUpper();
                    }


                    if (diff_item == "" || current_item == "") break;

                    if (diff_item == current_item)
                    {

                        fgrid_Item.TopRow = i;
                        fgrid_Item.Select(i, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_NAME1, true);


                        Set_Return_Item();
                        break;
                    }


                }
                //------------------------------------------------------------------------------------------------------------------------

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        /// <summary>
        /// Select_Specification : Specification Master 조회
        /// </summary>
        private void Select_Specification()
        {
            try
            {
                
                this.Cursor = Cursors.WaitCursor;

                string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
                string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, " ");
                string use_yn = (chk_Use_Spec.Checked) ? "Y" : " ";

                DataTable dt_ret = SELECT_SBC_SPEC_POPUP(spec_div, spec_name, use_yn);


                fgrid_Spec.Display_Grid(dt_ret, false);

                for (int i = fgrid_Spec.Rows.Fixed; i < fgrid_Spec.Rows.Count; i++)
                {

                    if (fgrid_Spec[i, (int)ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN] != null
                        && fgrid_Spec[i, (int)ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN].ToString() == "False")
                    {
                        fgrid_Spec.Rows[i].StyleNew.ForeColor = Color.Red;
                    }


                }

                dt_ret.Dispose();



                //------------------------------------------------------------------------------------------------------------------------
                // 정확하게 일치하는 항목으로 결과값 할당
                //------------------------------------------------------------------------------------------------------------------------
                string diff_item = "";
                string current_item = "";

                for (int i = 0; i < fgrid_Spec.Rows.Count; i++)
                {

                    if (!txt_SpecName.Text.Trim().Equals(""))
                    {
                        diff_item = txt_SpecName.Text.Trim().ToUpper();
                        current_item = fgrid_Spec[i, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].ToString().Trim().ToUpper();

                    }

                    if (diff_item == "" || current_item == "") break;

                    if (diff_item == current_item)
                    {
                        fgrid_Spec.TopRow = i;
                        fgrid_Spec.Select(i, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME, true);


                        Set_Return_Spec();
                        break;

                    }


                }
                //------------------------------------------------------------------------------------------------------------------------




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Specification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        /// <summary>
        /// Select_Color : Color Master 조회
        /// </summary>
        private void Select_Color()
        {
            try
            {
               
                this.Cursor = Cursors.WaitCursor;

                string color_name = ClassLib.ComFunction.Empty_TextBox(txt_ColorName, " ");
                string use_yn = (chk_Use_Color.Checked) ? "Y" : " ";

                DataTable dt_ret = SELECT_SBC_COLOR_POPUP(color_name, use_yn);

                fgrid_Color.Display_Grid(dt_ret, false);

                for (int i = fgrid_Color.Rows.Fixed; i < fgrid_Color.Rows.Count; i++)
                {

                    if (fgrid_Color[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxUSE_YN] != null
                        && fgrid_Color[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxUSE_YN].ToString() == "False")
                    {
                        fgrid_Color.Rows[i].StyleNew.ForeColor = Color.Red;
                    }


                }

                dt_ret.Dispose();


                //------------------------------------------------------------------------------------------------------------------------
                // 정확하게 일치하는 항목으로 결과값 할당
                //------------------------------------------------------------------------------------------------------------------------
                string diff_item = "";
                string current_cd = "";
                string current_name = "";

                for (int i = 0; i < fgrid_Color.Rows.Count; i++)
                {

                    if (!txt_ColorName.Text.Trim().Equals(""))
                    {
                        diff_item = txt_ColorName.Text.Trim().ToUpper();
                        current_cd = fgrid_Color[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD].ToString().Trim().ToUpper();
                        current_name = fgrid_Color[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME].ToString().Trim().ToUpper();
                    }


                    if (diff_item == "" || current_cd == "" || current_name == "") break;

                    if (diff_item == current_cd || diff_item == current_name)
                    {
                        fgrid_Color.TopRow = i;
                        fgrid_Color.Select(i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME, true);


                        Set_Return_Color();
                        break;

                    }


                }
                //------------------------------------------------------------------------------------------------------------------------




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        /// <summary>
        /// Joint_Color : Color 조합
        /// </summary>
        private void Joint_Color()
        {
            try
            {
               
                FlexBase.MaterialBase.Pop_Color popup = new FlexBase.MaterialBase.Pop_Color(false);
                popup.ShowDialog();

                string result = popup._ColorName;
                popup.Dispose();


                if (result.Trim().Equals("")) return;

                txt_ColorName.Text = result;
                Select_Color();




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Joint_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Set_Return_Item : Item Select
        /// </summary>
        private void Set_Return_Item()
        {

            if (fgrid_Item.Rows.Count == 0) return;



            txt_Result_ItemCode.Text = fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_CD].ToString();
            txt_Result_ItemName.Text = fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_NAME1].ToString();
            txt_Result_ItemUnit.Text = fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxMNG_UNIT].ToString();
            txt_Result_ItemSize.Text = (Convert.ToBoolean(fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxSIZE_YN].ToString())) ? "Yes" : "No";


            tabControl_Main.SelectedTab = tabPage_Spec;
            txt_SpecName.Focus();


            // item에 대한 default specification 정보 조회
            Search_Default_Spec();


        }



        /// <summary>
        /// Set_Return_Spec : Specification Select
        /// </summary>
        private void Set_Return_Spec()
        {

            if (fgrid_Spec.Rows.Count == 0) return;


            txt_Result_SpecCode.Text = fgrid_Spec[fgrid_Spec.Row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].ToString().ToString();
            txt_Result_SpecName.Text = fgrid_Spec[fgrid_Spec.Row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].ToString().ToString();


            tabControl_Main.SelectedTab = tabPage_Color;
            txt_ColorName.Focus();



        }



        /// <summary>
        /// Set_Return_Color : Color Select
        /// </summary>
        private void Set_Return_Color()
        {

            if (fgrid_Color.Rows.Count == 0) return;


            txt_Result_ColorCode.Text = fgrid_Color[fgrid_Color.Row, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD].ToString().ToString();
            txt_Result_ColorName.Text = fgrid_Color[fgrid_Color.Row, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME].ToString().ToString();

            btn_Return.Focus();


        }



        /// <summary>
        /// Return_Item_Data : 
        /// </summary>
        private void Return_Item_Data()
        {

            if (_DefaultTabPage.Trim().Equals(""))
            {

                if (txt_Result_ItemCode.Text.Trim() == "")
                {
                    COM.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_Result_SpecCode.Text.Trim() == "")
                {
                    COM.ComFunction.User_Message("Select Sepcification", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_Result_ColorCode.Text.Trim() == "")
                {
                    COM.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }


            //-------------------------------------------------------------
            // return


            //if (_DefaultTabPage.Equals(""))
            //{

                if (!txt_Result_ItemCode.Text.Trim().Equals("") && !txt_Result_SpecCode.Text.Trim().Equals(""))
                {

                    // SBC_SPEC_MASTER SAVE
                    bool save_flag = Save_SBC_SPEC_MASTER(txt_Result_ItemCode.Text, txt_Result_SpecCode.Text, "I");


                    if (!save_flag)
                    {
                        ClassLib.ComFunction.Data_Message("Save Specification Master", ClassLib.ComVar.MgsDoNotSave, this);
                    }
                } // end if save spec



                if (_Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] == null
                    || _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION].ToString().Equals(""))
                {
                    _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                }

                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = txt_Result_ItemName.Text;
                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = txt_Result_ItemCode.Text;

                
                // 원자재 일 때만 적용, 임가공명은 자동으로 생성됨으로
                if (_Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] != null
                    && _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE].ToString() == _Parent_Form._RowType_Material)
                {
                    _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = txt_Result_ItemName.Text;
                    _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = txt_Result_ItemName.Text;
                }


                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = txt_Result_SpecCode.Text;
                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = txt_Result_SpecName.Text;
                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = txt_Result_ColorCode.Text;
                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = txt_Result_ColorName.Text;
                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = txt_Result_ItemUnit.Text;
                _Parent_Form.fgrid_Yield[_GridSelectRow, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = (txt_Result_ItemSize.Text.Trim().Length == 0) ? "N" : txt_Result_ItemSize.Text.Substring(0, 1);


                // 사이즈 자재 여부에 따른 채산값 재 설정
                // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                _Parent_Form.Reset_Size_Material(_GridSelectRow);

                // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
                _Parent_Form.Reset_Joint_BOM(_GridSelectRow);


            //} // end if(_DefaultTabPage.Equals("") )

            //-------------------------------------------------------------




            //초기화
            Clear_All();


            this.Hide();



        }
         

        private void Clear_All()
        {

            cmb_ItemType.SelectedIndex = -1;
            cmb_ItemGroup.SelectedIndex = -1;
            txt_ItemName.Text = "";
            cmb_SpecDiv.SelectedIndex = -1;
            txt_SpecName.Text = "";
            txt_ColorName.Text = "";
            txt_Result_ItemCode.Text = "";
            txt_Result_ItemName.Text = "";
            txt_Result_SpecCode.Text = "";
            txt_Result_SpecName.Text = "";
            txt_Result_ColorCode.Text = "";
            txt_Result_ColorName.Text = "";
            txt_Result_ItemUnit.Text = "";
            txt_Result_ItemSize.Text = "";

        }


        #endregion

        #region 이벤트 처리


        #region 버튼클릭시 이미지변경


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            //Label src = sender as Label;

            ////image index default : 0, 2, 4
            //if (src.ImageIndex % 2 == 0)
            //{
            //    src.ImageIndex = src.ImageIndex + 1;
            //}

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            //Label src = sender as Label;

            ////image index default : 1, 3, 5
            //if (src.ImageIndex % 2 == 1)
            //{
            //    src.ImageIndex = src.ImageIndex - 1;
            //}

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Label src = sender as Label;

            ////image index default : 0, 2, 4
            //if (src.ImageIndex % 2 == 0)
            //{
            //    src.ImageIndex = src.ImageIndex + 1;
            //}
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Label src = sender as Label;

            ////image index default : 1, 3, 5
            //if (src.ImageIndex % 2 == 1)
            //{
            //    src.ImageIndex = src.ImageIndex - 1;
            //}
        }




        #endregion


        private void Pop_Select_Material_Load(object sender, EventArgs e)
        {

            Init_Form();

        }


        private void cmb_ItemType_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cmb_ItemType.SelectedIndex == -1) return;


                // Item Group First Class Combo List

                DataTable dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_ItemType.SelectedValue.ToString());
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemGroup, 0, 1, true, 0, 130);

                dt_ret.Dispose();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cmb_ItemType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Item Master 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_item_Click(object sender, System.EventArgs e)
        {
            Select_Item();
        }


        /// <summary>
        /// Specification Master 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchSpec_Click(object sender, System.EventArgs e)
        {
            Select_Specification();
        }



        /// <summary>
        /// Color Master 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchColor_Click(object sender, System.EventArgs e)
        {
            Select_Color();
        }



        /// <summary>
        /// Color 코드 조합 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_JointColor_Click(object sender, System.EventArgs e)
        {
            Joint_Color();
        }


        private void fgrid_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;



                COM.FSP src = sender as COM.FSP;


                if (src == fgrid_Item)
                {

                    Set_Return_Item();

                }
                else if (src == fgrid_Spec)
                {

                    Set_Return_Spec();

                }
                else if (src == fgrid_Color)
                {

                    Set_Return_Color();

                }



            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "fgrid_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }



        private void fgrid_MouseMove(object sender, MouseEventArgs e)
        {
            Event_fgrid_MouseMove_Tooltip(sender, e);
        }




        // show tooltip if the text is too long to fit the cell
        System.Windows.Forms.ToolTip _ttip;
        int _lastRow = 0;
        int _lastCol = 0;



        /// <summary>
        /// Event_fgrid_Yield_MouseMove_Tooltip : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_fgrid_MouseMove_Tooltip(object sender, MouseEventArgs e)
        {

            try
            {

                COM.FSP fgrid = sender as COM.FSP;

                string text = null;
                if (e.Button == MouseButtons.None)
                {
                    // get mouse coordinates
                    int row = fgrid.MouseRow;
                    int col = fgrid.MouseCol;

                    // save work if we can
                    if (row == _lastRow && col == _lastCol)
                        return;

                    // save info for next time
                    _lastRow = row;
                    _lastCol = col;

                    // get text for tooltip
                    if (row > -1 && col > -1)
                    {
                        // get display text
                        text = fgrid.GetDataDisplay(row, col);

                        // get display rectangle
                        Rectangle rc = fgrid.GetCellRect(row, col, false);
                        rc.Intersect(fgrid.ClientRectangle);

                        // measure text
                        using (Graphics g = fgrid.CreateGraphics())
                        {
                            C1.Win.C1FlexGrid.CellStyle s = fgrid.GetCellStyleDisplay(row, col);
                            float wid = g.MeasureString(text, s.Font).Width;

                            wid += s.Margins.Left + s.Margins.Right + s.Border.Width + 50;  // 50 : 앞 공백 계산

                            if (wid < rc.Width) text = null;
                        }
                    }


                }

                // create tooltip if we need it
                if (text != null && _ttip == null)
                {
                    _ttip = new ToolTip();
                }

                // set tooltip text
                if (_ttip != null && _ttip.GetToolTip(fgrid) != text)
                    _ttip.SetToolTip(fgrid, text);


            }
            catch
            {
            }

        }




        /// <summary>
        /// return and close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Return_Click(object sender, System.EventArgs e)
        {
            _CancelFlag = false;


            // yield 화면에서 연결 되었을 경우에는 모든 항목 리턴하기 위함
            if (_Parent_Form != null)
            {
                _DefaultTabPage = "";
            }


            Return_Item_Data();

        }


        /// <summary>
        /// close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            _CancelFlag = true;
            //this.Close();	


            Clear_All();

            this.Hide();
        }




        private void Pop_Select_Material_FormClosing(object sender, FormClosingEventArgs e)
        {

            _CancelFlag = true;
            //this.Close();		

            Clear_All();

            this.Hide();
            e.Cancel = true;

        }

       


        private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;


                if (tabControl_Main.SelectedTab.Equals(tabPage_Item))
                {
                    Select_Item();
                }
                else if (tabControl_Main.SelectedTab.Equals(tabPage_Spec))
                {
                    Select_Specification();
                }
                else if (tabControl_Main.SelectedTab.Equals(tabPage_Color))
                {

                    Select_Color();
                }





            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void btn_AddNewItem_Click(object sender, System.EventArgs e)
        {
            try
            {


                if (tabControl_Main.SelectedTab.Equals(tabPage_Item))
                {
                    Add_New_Item();
                }
                else if (tabControl_Main.SelectedTab.Equals(tabPage_Spec))
                {
                    Add_New_Specification();
                }
                else if (tabControl_Main.SelectedTab.Equals(tabPage_Color))
                {

                    Add_New_Color();
                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_AddNewItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Add_New_Item : 
        /// </summary>
        private void Add_New_Item()
        {

            ClassLib.ComVar.Parameter_PopUp = new string[4];
            ClassLib.ComVar.Parameter_PopUp[0] = "I";
            ClassLib.ComVar.Parameter_PopUp[1] = "";  // item_cd
            ClassLib.ComVar.Parameter_PopUp[2] = ClassLib.ComFunction.Empty_Combo(cmb_ItemType, "");
            ClassLib.ComVar.Parameter_PopUp[3] = "";  // group_l


            FlexBase.MaterialBase.Pop_Item_Show pop_form = new FlexBase.MaterialBase.Pop_Item_Show(true);
            pop_form.ShowDialog();

            if (!pop_form._Close_Save) return;


            txt_ItemName.Text = ClassLib.ComVar.Parameter_PopUp[1];

            txt_Result_ItemCode.Text = ClassLib.ComVar.Parameter_PopUp[0];
            txt_Result_ItemName.Text = ClassLib.ComVar.Parameter_PopUp[1];
            txt_Result_ItemSize.Text = (ClassLib.ComVar.Parameter_PopUp[2] == "Y") ? "Yes" : "No";
            txt_Result_ItemUnit.Text = ClassLib.ComVar.Parameter_PopUp[3];


        }



        /// <summary>
        /// Add_New_Specification : 
        /// </summary>
        private void Add_New_Specification()
        {


            ClassLib.ComVar.Parameter_PopUp = null;

            FlexBase.MaterialBase.Form_BC_Spec pop_form = new FlexBase.MaterialBase.Form_BC_Spec(true);
            pop_form.ShowDialog();

            if (ClassLib.ComVar.Parameter_PopUp == null) return;

            cmb_SpecDiv.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0].Substring(0, 1);
            txt_SpecName.Text = ClassLib.ComVar.Parameter_PopUp[1];

            txt_Result_SpecCode.Text = ClassLib.ComVar.Parameter_PopUp[0];
            txt_Result_SpecName.Text = ClassLib.ComVar.Parameter_PopUp[1];

        }



        /// <summary>
        /// Add_New_Color : 
        /// </summary>
        private void Add_New_Color()
        {

            ClassLib.ComVar.Parameter_PopUp = null;

            FlexBase.MaterialBase.Form_BC_Color pop_form = new FlexBase.MaterialBase.Form_BC_Color(true);
            pop_form.ShowDialog();

            if (ClassLib.ComVar.Parameter_PopUp == null) return;

            txt_ColorName.Text = ClassLib.ComVar.Parameter_PopUp[1];

            txt_Result_ColorCode.Text = ClassLib.ComVar.Parameter_PopUp[0];
            txt_Result_ColorName.Text = ClassLib.ComVar.Parameter_PopUp[1];


        }



        private void menuItem_UseSpecDel_Click(object sender, System.EventArgs e)
        {


            try
            {

                if (fgrid_Spec.Rows.Count <= fgrid_Spec.Rows.Fixed) return;

                // SBC_SPEC_MASTER SAVE
                string spec_cd = fgrid_Spec[fgrid_Spec.Row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].ToString();

                bool save_flag = Save_SBC_SPEC_MASTER(txt_Result_ItemCode.Text, spec_cd, "D");

                if (!save_flag)
                {
                    ClassLib.ComFunction.Data_Message("Delete Specification Master", ClassLib.ComVar.MgsDoNotDelete, this);
                }
                else
                {
                    fgrid_Spec.Rows.Remove(fgrid_Spec.Row);
                    ClassLib.ComFunction.Data_Message("Delete Specification Master", ClassLib.ComVar.MgsEndDelete, this);


                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "menuItem_UseSpecDel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        #endregion

        #region DB Connect



        /// <summary>
        /// Select_SBC_SPEC_MASTER : item에 대한 default specification 정보 조회 
        /// </summary>
        /// <param name="arg_itemcd"></param>
        /// <returns></returns>
        private DataTable Select_SBC_SPEC_MASTER(string arg_itemcd)
        {
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC_MASTER";

            MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_itemcd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];

        }



        /// <summary>
        /// SELECT_SBC_ITEM_POPUP : Item LIST Combo
        /// </summary>
        /// <param name="arg_groupcd"></param>
        /// <param name="arg_itemname1"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_ITEM_POPUP(string arg_groupcd, string arg_itemname1, string arg_useyn)
        {

            COM.OraDB OraDB = new COM.OraDB();

            DataSet ds_ret;

            OraDB.ReDim_Parameter(4);

            OraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_ITEM_POPUP";

            OraDB.Parameter_Name[0] = "ARG_GROUP_CD";
            OraDB.Parameter_Name[1] = "ARG_ITEM_NAME1";
            OraDB.Parameter_Name[2] = "ARG_USE_YN";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_groupcd;
            OraDB.Parameter_Values[1] = arg_itemname1;
            OraDB.Parameter_Values[2] = arg_useyn;
            OraDB.Parameter_Values[3] = "";


            OraDB.Add_Select_Parameter(true);

            ds_ret = OraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[OraDB.Process_Name];
        }




        /// <summary>
        /// SELECT_SBC_SPEC_POPUP : Sepcification LIST Combo
        /// </summary>
        /// <param name="arg_specdiv"></param>
        /// <param name="arg_specname"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_SPEC_POPUP(string arg_specdiv, string arg_specname, string arg_useyn)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(4);

            MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_SPEC_POPUP";

            MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
            MyOraDB.Parameter_Name[1] = "ARG_SPEC_NAME";
            MyOraDB.Parameter_Name[2] = "ARG_USE_YN";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_specdiv;
            MyOraDB.Parameter_Values[1] = arg_specname;
            MyOraDB.Parameter_Values[2] = arg_useyn;
            MyOraDB.Parameter_Values[3] = "";


            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }



        /// <summary>
        /// SELECT_SBC_COLOR_POPUP : Color LIST Combo
        /// </summary>
        /// <param name="arg_colorname"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_COLOR_POPUP(string arg_colorname, string arg_useyn)
        {
            DataSet ds_ret;
            COM.OraDB MyOraDB = new COM.OraDB();

            MyOraDB.ReDim_Parameter(3);

            MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_COLOR_POPUP";

            MyOraDB.Parameter_Name[0] = "ARG_COLOR_NAME";
            MyOraDB.Parameter_Name[1] = "ARG_USE_YN";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_colorname;
            MyOraDB.Parameter_Values[1] = arg_useyn;
            MyOraDB.Parameter_Values[2] = "";


            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }


        /// <summary>
        /// SBC_SPEC_MASTER SAVE : 
        /// </summary>
        /// <param name="arg_itemcd"></param>
        /// <param name="arg_speccd"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns> 
        private bool Save_SBC_SPEC_MASTER(string arg_itemcd, string arg_speccd, string arg_division)
        {

            try
            {
                DataSet ds_ret;

                int col_ct = 8;

                MyOraDB.ReDim_Parameter(col_ct);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBC_SPEC.SAVE_SBC_SPEC_MASTER";

                //02.ARGURMENT명
                MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[1] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MCS_NO";
                MyOraDB.Parameter_Name[3] = "ARG_LAST_DATE";
                MyOraDB.Parameter_Name[4] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[5] = "ARG_SEND_CHK";
                MyOraDB.Parameter_Name[6] = "ARG_SEND_YMD";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                //03.DATA TYPE
                for (int i = 0; i < col_ct; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

                //04.DATA 정의  
                MyOraDB.Parameter_Values[0] = arg_itemcd;
                MyOraDB.Parameter_Values[1] = arg_speccd;
                MyOraDB.Parameter_Values[2] = "";
                MyOraDB.Parameter_Values[3] = "";
                MyOraDB.Parameter_Values[4] = "";
                MyOraDB.Parameter_Values[5] = arg_division; // delete, insert division
                MyOraDB.Parameter_Values[6] = "";
                MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)
                {
                    ds_ret.Dispose();
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }

        }




        #endregion 

      
        


    }
}