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
    public partial class Pop_Yield_MultiChange_Material : COM.PCHWinForm.Pop_Large_Light
    {
         

        #region 생성자


        private string _Division;
        private string _Factory;
        private string _StyleCd;
        private string _StyleName;
        private string _Gender;
        private string _PrestoYN;
        private string _SgCd;
        private string _ComponentCd;
        private string _ComponentName;
        private string _TemplateSeq;
        private string _TemplateLevel;
        private string _ItemCd;
        private string _ItemName;
        private string _Unit;
        private string _SizeYN;
        private string _SpecCd;
        private string _SpecName;
        private string _ColorCd;
        private string _ColorName;



        public Pop_Yield_MultiChange_Material(string[] arg_parameter)
        {
            InitializeComponent();


            _Division = arg_parameter[0];
            _Factory = arg_parameter[1];
            _StyleCd = arg_parameter[2];
            _StyleName = arg_parameter[3];
            _Gender = arg_parameter[4];
            _PrestoYN = arg_parameter[5];
            _SgCd = arg_parameter[6];
            _ComponentCd = arg_parameter[7];
            _ComponentName = arg_parameter[8];
            _TemplateSeq = arg_parameter[9];
            _TemplateLevel = arg_parameter[10];
            _ItemCd = arg_parameter[11];
            _ItemName = arg_parameter[12];
            _Unit = arg_parameter[13];
            _SizeYN = arg_parameter[14];
            _SpecCd = arg_parameter[15];
            _SpecName = arg_parameter[16];
            _ColorCd = arg_parameter[17];
            _ColorName = arg_parameter[18];


            panel_SearchOption.Visible = false;



            Init_Form(); 


        }

         


        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();


        // yield 행 정의
        private int _Value_Row_Yield = -1;
        private int _Value_Row_SpecCode = -1;
        private int _Value_Row_SpecName = -1;



        // 임가공 구조 중 원자재 단일 구조
        private string _JointBOM_Only_Material = "00005";

        // 임가공 공정 중 원자재
        private string _RawMaterial = "02J13000";



        //return 또는 cancel 이벤트 체크
        public bool _CancelFlag = true;


        #endregion

        #region 멤버 메서드


        #region 초기화


        /// <summary>
        /// Init_Form : 
        /// </summary>
        private void Init_Form()
        {
            try
            {

                //Title 
                if (_Division == "I")
                {
                    this.Text = "Change Material - Insert";
                    lbl_MainTitle.Text = "Change Material - Insert";
                }
                else if (_Division == "D")
                {
                    this.Text = "Change Material - Delete";
                    lbl_MainTitle.Text = "Change Material - Delete";
                }
                else if (_Division == "U")
                {
                    this.Text = "Change Material - Update";
                    lbl_MainTitle.Text = "Change Material - Update";
                } // end if division    



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


                if (ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
                {
                    btn_GetSpecBySize.Enabled = true;
                    btn_GetSizeGroup.Enabled = true;
                    btn_GetSpecGroup.Enabled = true;
                }
                else
                {
                    btn_GetSpecBySize.Enabled = false;
                    btn_GetSizeGroup.Enabled = false;
                    btn_GetSpecGroup.Enabled = false;
                }



                // 그리드 설정 
                if (_Division == "I")
                {
                    fgrid_Style.Set_Grid("SBC_YIELD_CHANGE_INSERT_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                }
                else if (_Division == "D")
                {
                    fgrid_Style.Set_Grid("SBC_YIELD_CHANGE_UPDATE_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                }
                else if (_Division == "U")
                {
                    fgrid_Style.Set_Grid("SBC_YIELD_CHANGE_UPDATE_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                } // end if division    


                fgrid_Style.Font = new Font("Verdana", 8);
                fgrid_Style.Styles.Frozen.BackColor = Color.White;
                fgrid_Style.Styles.Alternate.BackColor = Color.White;


                fgrid_Value.Set_Grid("SBC_YIELD_VALUE_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Value.Font = new Font("Verdana", 8);
                fgrid_Value.Styles.Frozen.BackColor = Color.White;
                fgrid_Value.Styles.Alternate.BackColor = Color.White;
                fgrid_Value.AllowSorting = AllowSortingEnum.None;
                fgrid_Value.SelectionMode = SelectionModeEnum.CellRange;

                //size 세팅
                int col_size_start = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START;
                int col_width = 60;
                fgrid_Value.Display_Size_ColHead(_Factory, _StyleCd.Replace("-", ""), col_width, col_size_start);

                //value size row 생성
                Set_Yield_Value_Row();



                txt_SG.Text = _SgCd;
                txt_Component.Text = _ComponentName;
                txt_Item.Text = _ItemName;
                txt_Unit.Text = _Unit;
                txt_Size.Text = (_SizeYN == "Y") ? "Yes" : "No";
                txt_Spec.Text = _SpecName;
                txt_Color.Text = _ColorName;



                if (_Division == "I")
                {


                    panel_SearchOption.Visible = false;
                    chk_ChangeOnlyYield.Visible = false;


                    if (_ComponentCd == "")
                    {
                        txt_Component.Focus();
                    }
                    else
                    {
                        txt_Component.ReadOnly = true;
                        txt_Component.BackColor = Color.WhiteSmoke;

                        txt_Item.Focus();
                    }



                    // style, value 조회
                    Display_Insert_Style_Value();


                }
                else if (_Division == "D")
                {


                    panel_SearchOption.Visible = true;
                    chk_Component.Checked = true;
                    chk_Item.Checked = true;
                    chk_Spec.Checked = false;
                    chk_Color.Checked = false;

                    chk_ChangeOnlyYield.Visible = false;



                    txt_Component.ReadOnly = true;
                    txt_Item.ReadOnly = true;
                    txt_Unit.ReadOnly = true;
                    txt_Size.ReadOnly = true;
                    txt_Spec.ReadOnly = true;
                    txt_Color.ReadOnly = true;

                    txt_Component.BackColor = Color.WhiteSmoke;
                    txt_Item.BackColor = Color.WhiteSmoke;
                    txt_Unit.BackColor = Color.WhiteSmoke;
                    txt_Size.BackColor = Color.WhiteSmoke;
                    txt_Spec.BackColor = Color.WhiteSmoke;
                    txt_Color.BackColor = Color.WhiteSmoke;

                    fgrid_Style.Focus();



                    // style, value 조회
                    Display_Update_Style_Value();


                }
                else if (_Division == "U")
                {


                    panel_SearchOption.Visible = true;
                    chk_Component.Checked = true;
                    chk_Item.Checked = true;
                    chk_Spec.Checked = false;
                    chk_Color.Checked = false;

                    chk_ChangeOnlyYield.Visible = true;


                    txt_Component.ReadOnly = true;
                    txt_Component.BackColor = Color.WhiteSmoke;

                    txt_Item.Focus();



                    // style, value 조회
                    Display_Update_Style_Value();


                } // end if division                



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        #endregion

        #region 조회



        /// <summary>
        /// Set_Yield_Value_Row : value size row 생성
        /// </summary>
        private void Set_Yield_Value_Row()
        {


            fgrid_Value.Rows.Count = fgrid_Value.Rows.Fixed;
            fgrid_Value.Rows.InsertRange(fgrid_Value.Rows.Count, 3);

            _Value_Row_Yield = fgrid_Value.Rows.Count - 3;
            _Value_Row_SpecCode = fgrid_Value.Rows.Count - 2;
            _Value_Row_SpecName = fgrid_Value.Rows.Count - 1;

            fgrid_Value[_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDESCRIPTION] = "Value";
            fgrid_Value[_Value_Row_SpecCode, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDESCRIPTION] = "SPEC_CD";
            fgrid_Value[_Value_Row_SpecName, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDESCRIPTION] = "Spec";



            CellStyle cellst = fgrid_Value.Styles.Add("NUMBER", fgrid_Value.Rows[_Value_Row_Yield].Style);
            cellst.DataType = typeof(double);
            cellst.Format = "#,##0.##########";
            fgrid_Value.Rows[_Value_Row_Yield].Style = fgrid_Value.Styles["NUMBER"];



            fgrid_Value.Cols.Fixed = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START;
            fgrid_Value.Cols[0].Visible = false;
            fgrid_Value.Rows[_Value_Row_SpecCode].Visible = false;
            fgrid_Value.Rows[_Value_Row_SpecName].TextAlign = TextAlignEnum.RightCenter;
            fgrid_Value.Rows[_Value_Row_SpecName].AllowEditing = false;


        }




        /// <summary>
        /// Display_Insert_Style_Value : 
        /// </summary>
        private void Display_Insert_Style_Value()
        {

            string factory = _Factory;
            string style_cd = _StyleCd.Replace("-", "");
            string semi_good_cd = _SgCd;
            string component_cd = _ComponentCd;
            string template_seq = (_TemplateSeq.Trim().Equals("")) ? "-1" : _TemplateSeq;
            string template_level = (_TemplateLevel.Trim().Equals("")) ? "-1" : _TemplateLevel;

            DataSet ds_ret = SELECT_CHANGE_MAT_INSERT(factory, style_cd, semi_good_cd, component_cd, template_seq, template_level);
            DataTable dt_ret_style = ds_ret.Tables[0];
            DataTable dt_ret_value = ds_ret.Tables[1];


            //-----------------------------------------------------
            // style 조회
            //-----------------------------------------------------
            fgrid_Style.Rows.Count = fgrid_Style.Rows.Fixed;

            if (dt_ret_style == null || dt_ret_style.Rows.Count == 0) return;

            fgrid_Style.Display_Grid(dt_ret_style, false);

            for (int i = fgrid_Style.Rows.Fixed; i < fgrid_Style.Rows.Count; i++)
            {

                fgrid_Style.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTYLE_CD, CheckEnum.Unchecked);

            } // end for i

            //-----------------------------------------------------


            //-----------------------------------------------------
            // value 조회
            //-----------------------------------------------------
            if (_ItemCd == "") return;

            Display_Value(dt_ret_value);
            

        }



        /// <summary>
        /// Display_Update_Style_Value : 
        /// </summary>
        private void Display_Update_Style_Value()
        {

            string factory = _Factory;
            string style_cd = _StyleCd.Replace("-", "");
            string semi_good_cd = _SgCd;
            string component_cd = _ComponentCd;
            string template_seq = (_TemplateSeq.Trim().Equals("")) ? "-1" : _TemplateSeq;
            string template_level = (_TemplateLevel.Trim().Equals("")) ? "-1" : _TemplateLevel;
            string item_cd = _ItemCd;
            string spec_cd = _SpecCd;
            string color_cd = _ColorCd;
            string where_component_yn = (chk_Component.Checked) ? "Y" : "";
            string where_item_yn = (chk_Item.Checked) ? "Y" : "";
            string where_spec_yn = (chk_Spec.Checked) ? "Y" : "";
            string where_color_yn = (chk_Color.Checked) ? "Y" : "";


            DataSet ds_ret = SELECT_CHANGE_MAT_UPDATE(factory, style_cd, semi_good_cd, component_cd, template_seq, template_level, 
                item_cd, spec_cd, color_cd, where_component_yn, where_item_yn, where_spec_yn, where_color_yn);
            DataTable dt_ret_style = ds_ret.Tables[0];
            DataTable dt_ret_value = ds_ret.Tables[1];


            //-----------------------------------------------------
            // style 조회
            //-----------------------------------------------------
            fgrid_Style.Rows.Count = fgrid_Style.Rows.Fixed;

            if (dt_ret_style == null || dt_ret_style.Rows.Count == 0) return;

            fgrid_Style.Display_Grid(dt_ret_style, false);

            for (int i = fgrid_Style.Rows.Fixed; i < fgrid_Style.Rows.Count; i++)
            {

                fgrid_Style.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTYLE_CD, CheckEnum.Unchecked);

            } // end for i

            //-----------------------------------------------------


            //-----------------------------------------------------
            // value 조회
            //-----------------------------------------------------
            if (_ItemCd == "") return;

            Display_Value(dt_ret_value);


        }



        /// <summary>
        /// Display_Value : 
        /// </summary>
        /// <param name="arg_dt"></param>
        private void Display_Value(DataTable arg_dt)
        {


            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                string size_from_order = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SIZE_ORDER_FROM] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SIZE_ORDER_FROM].ToString();
                string size_to_order = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SIZE_ORDER_TO] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SIZE_ORDER_TO].ToString();
                string yield_value = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_YIELD_M] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_YIELD_M].ToString();
                string spec_cd = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SPEC_CD] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SPEC_CD].ToString();
                string spec_name = (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SPEC_NAME] == null) ? "" : arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxDB_SPEC_NAME].ToString();

                string now_size_order = "";
                int size_from_col = -1;
                int size_to_col = -1;

                //---------------------
                // size 시작 ~ 끝 컬럼 계산
                for (int a = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; a < fgrid_Value.Cols.Count; a++)
                {
                    now_size_order = (fgrid_Value[0, a] == null) ? "0" : fgrid_Value[0, a].ToString();

                    if (now_size_order == size_from_order)
                    {
                        size_from_col = a;
                        break;
                    }

                }

                size_from_col = (size_from_col == -1) ? (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START : size_from_col;

                for (int a = size_from_col; a < fgrid_Value.Cols.Count; a++)
                {
                    now_size_order = (fgrid_Value[0, a] == null) ? "0" : fgrid_Value[0, a].ToString();

                    if (now_size_order == size_to_order)
                    {
                        size_to_col = a;
                        break;
                    }

                }

                size_to_col = (size_to_col == -1) ? fgrid_Value.Cols.Count - 1 : size_to_col;
                //---------------------


                //---------------------
                // 채산값, spec 표시
                for (int a = size_from_col; a <= size_to_col; a++)
                {
                    fgrid_Value[_Value_Row_Yield, a] = yield_value;
                    fgrid_Value[_Value_Row_SpecCode, a] = spec_cd;
                    fgrid_Value[_Value_Row_SpecName, a] = spec_name;
                }
                //---------------------


            } // end for i
            //-----------------------------------------------------


            //-----------------------------------------------------
            // value 사이즈 자재 표시
            //-----------------------------------------------------
            Display_Size_Material_Value(_SizeYN);


            fgrid_Value.LeftCol = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START - 1;
            fgrid_Value.Select(_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START, true);


            if (_SizeYN == "Y")
            {
                fgrid_Value.Rows[_Value_Row_Yield].AllowEditing = false;
            }
            else
            {
                fgrid_Value.Rows[_Value_Row_Yield].AllowEditing = true;
            }
            //-----------------------------------------------------



        }



        /// <summary>
        /// Display_Size_Material_Value : 
        /// </summary>
        /// <param name="arg_size_yn"></param>
        private void Display_Size_Material_Value(string arg_size_yn)
        {

            Color color_SizeSpecOdd = ClassLib.ComVar.ClrSel_Green;
            Color color_SizeSpecEven = ClassLib.ComVar.ClrSel_Yellow;
            Color color_SizeSpecCurrent;


            string before_spec = "";
            string now_spec = "";
            int size_from_col = -1;
            int size_to_col = -1;


            if (arg_size_yn != "Y") return;


            color_SizeSpecCurrent = color_SizeSpecEven;


            size_from_col = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START;


            while (true)
            {

                before_spec = (fgrid_Value[_Value_Row_SpecCode, size_from_col] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_from_col].ToString();


                for (int k = size_from_col; k < fgrid_Value.Cols.Count; k++)
                {

                    now_spec = (fgrid_Value[_Value_Row_SpecCode, k] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, k].ToString();

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

                    CellStyle cs_spec = fgrid_Value.Styles.Add("SPEC_COLOR" + i.ToString());
                    cs_spec.BackColor = color_SizeSpecCurrent;
                    fgrid_Value.SetCellStyle(_Value_Row_Yield, i, "SPEC_COLOR" + i.ToString());
                    fgrid_Value.SetCellStyle(_Value_Row_SpecCode, i, "SPEC_COLOR" + i.ToString());
                    fgrid_Value.SetCellStyle(_Value_Row_SpecName, i, "SPEC_COLOR" + i.ToString());

                }



                size_from_col = size_to_col + 1;


                if (size_from_col == fgrid_Value.Cols.Count) break;


            } // end while



        }




        #endregion

        #region 이벤트 멤버 메서드


        /// <summary>
        /// Event_txt_Component_KeyUp : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_txt_Component_KeyUp(KeyEventArgs e)
        {

            try
            {

                if (e.KeyCode != Keys.Enter) return;

                if (txt_Component.ReadOnly) return;


                Select_GridCombo_Component();


                if (_ComponentCd.Trim().Equals("")) return;

                txt_Item.Focus();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_Component_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_txt_Item_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {

                if (e.KeyCode != Keys.Enter) return;

                if (txt_Item.ReadOnly) return;


                Select_GridCombo_Item();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_Item_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_txt_Spec_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {

                if (e.KeyCode != Keys.Enter) return;

                if (txt_Spec.ReadOnly) return;


                Select_GridCombo_Spec(_ItemCd);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_Spec_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_txt_Color_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {

                if (e.KeyCode != Keys.Enter) return;

                if (txt_Color.ReadOnly) return;


                Select_GridCombo_Color();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_Color_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        #region 그리드 콤보


        /// <summary>
        /// Select_GridCombo_Component : 
        /// </summary>
        private void Select_GridCombo_Component()
        {


            try
            {

                string component = txt_Component.Text;

                if (component.Trim().Equals("")) return;

                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_COMPONENT_COMBO(component);

                //if (dt_ret == null || dt_ret.Rows.Count == 0)
                //{

                //    _ComponentCd = "";
                //    txt_Component.Text = component;

                //    string message = "We have not component : [" + component + "]";
                //    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Component", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    return;
                //}


                FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                string[] key_string = new string[] { "COMPONENT_CD" };
                string[] value_string = new string[] { "COMPONENT_NAME" };

                grid_combo._JobDivision = "COMPONENT";
                grid_combo.ShowData(dt_ret, key_string, value_string, false, component);
                grid_combo.StartPosition = FormStartPosition.CenterParent;

                //grid_combo.StartPosition = FormStartPosition.Manual;
                //grid_combo.Location = new Point(MousePosition.X, MousePosition.Y);


                if (grid_combo.ShowDialog() != DialogResult.OK)
                {

                    _ComponentCd = "";
                    txt_Component.Text = component;

                    string message = "We must input component : [" + component + "]";
                    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Component", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    return;
                }




                // 0 : component_cd, 1 : component_name
                _ComponentCd = grid_combo.VRow[0].ToString();
                txt_Component.Text = grid_combo.VRow[1].ToString();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Component", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ComponentCd = "";
                txt_Component.Text = "";

            }

        }





        /// <summary>
        /// Select_GridCombo_Item : 
        /// </summary>
        private void Select_GridCombo_Item()
        {

            bool item_set_flag = false; 


            try
            {

                string item = txt_Item.Text;

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

                //if (dt_ret == null || dt_ret.Rows.Count == 0)
                //{

                //    _ItemCd = "";
                //    _ItemName = "";
                //    _Unit = "";
                //    _SizeYN = "";

                //    txt_Item.Text = item;
                //    txt_Unit.Text = "";
                //    txt_Size.Text = "";

                //    txt_Item.ForeColor = Color.Green;
                //    txt_Unit.ForeColor = Color.Green;
                //    txt_Size.ForeColor = Color.Green;

                //    string message = "We have not material : [" + item + "]";
                //    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Item", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //    item_set_flag = false;


                //    return;
                //}



                //// 정확하게 일치하는 아이템이 있는 경우 바로 세팅, 없으면 리스트 표시
                //// ITEM_CD, ITEM_NAME1, MNG_UNIT, SIZE_YN, CORRECT_ITEM_FLAG
                //if (((dt_ret.Rows[0].ItemArray[4] == null) ? "" : dt_ret.Rows[0].ItemArray[4].ToString()) == "Y")
                //{


                //    _ItemCd = (dt_ret.Rows[0].ItemArray[0] == null) ? "" : dt_ret.Rows[0].ItemArray[0].ToString();
                //    _ItemName = (dt_ret.Rows[0].ItemArray[1] == null) ? "" : dt_ret.Rows[0].ItemArray[1].ToString();
                //    _Unit = (dt_ret.Rows[0].ItemArray[2] == null) ? "" : dt_ret.Rows[0].ItemArray[2].ToString();
                //    _SizeYN = (dt_ret.Rows[0].ItemArray[3] == null) ? "" : dt_ret.Rows[0].ItemArray[3].ToString();

                //    txt_Item.Text = (dt_ret.Rows[0].ItemArray[1] == null) ? "" : dt_ret.Rows[0].ItemArray[1].ToString();
                //    txt_Unit.Text = (dt_ret.Rows[0].ItemArray[2] == null) ? "" : dt_ret.Rows[0].ItemArray[2].ToString();
                //    txt_Size.Text = (dt_ret.Rows[0].ItemArray[3] == null) ? "" : dt_ret.Rows[0].ItemArray[3].ToString();

                //    txt_Item.ForeColor = Color.Black;
                //    txt_Unit.ForeColor = Color.Black;
                //    txt_Size.ForeColor = Color.Black;


                //    item_set_flag = true;

                //}
                //else
                //{

                    FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                    string[] key_string = new string[] { "ITEM_CD" };
                    string[] value_string = new string[] { "ITEM_NAME1", "MNG_UNIT", "SIZE_YN" };

                    grid_combo._JobDivision = "ITEM";
                    grid_combo._ItemCD = item;
                    grid_combo.ShowData(dt_ret, key_string, value_string, true, item);
                    grid_combo.StartPosition = FormStartPosition.CenterParent;

                    //grid_combo.StartPosition = FormStartPosition.Manual;
                    //grid_combo.Location = new Point(MousePosition.X, MousePosition.Y);


                    if (grid_combo.ShowDialog() != DialogResult.OK)
                    {

                        _ItemCd = "";
                        _ItemName = "";
                        _Unit = "";
                        _SizeYN = "";

                        txt_Item.Text = item;
                        txt_Unit.Text = "";
                        txt_Size.Text = "";

                        txt_Item.ForeColor = Color.Green;
                        txt_Unit.ForeColor = Color.Green;
                        txt_Size.ForeColor = Color.Green;


                        string message = "We must input material : [" + item + "]";
                        ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Item", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        item_set_flag = false;

                        return;
                    }



                    _ItemCd = grid_combo.VRow[0].ToString();
                    _ItemName = grid_combo.VRow[1].ToString();
                    _Unit = grid_combo.VRow[2].ToString();
                    _SizeYN = grid_combo.VRow[3].ToString();

                    txt_Item.Text = grid_combo.VRow[1].ToString();
                    txt_Unit.Text = grid_combo.VRow[2].ToString();
                    txt_Size.Text = grid_combo.VRow[3].ToString();

                    txt_Item.ForeColor = Color.Black;
                    txt_Unit.ForeColor = Color.Black;
                    txt_Size.ForeColor = Color.Black;


                    item_set_flag = true;

                //}


                //-----------------------------------------------------
                // 아이템이 선택 된 경우 spec list grid combo 자동 표시
                //-----------------------------------------------------
                if (item_set_flag)
                {
                    Select_GridCombo_Spec(_ItemCd);
                } // end if
                //-----------------------------------------------------



                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }



                // 사이즈 자재 여부에 따른 채산값 재 설정
                // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                Reset_Size_Material(_SizeYN);


                if (_SizeYN == "Y")
                {
                    btn_GetSpecBySize.Enabled = true;
                }
                else
                {
                    btn_GetSpecBySize.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ItemCd = "";
                _ItemName = "";
                _Unit = "";
                _SizeYN = "";

                txt_Item.Text = "";
                txt_Unit.Text = "";
                txt_Size.Text = "";

                txt_Item.ForeColor = Color.Green;
                txt_Unit.ForeColor = Color.Green;
                txt_Size.ForeColor = Color.Green;

            } // end catch



        }



        /// <summary>
        /// Select_GridCombo_Spec : 
        /// </summary>
        /// <param name="arg_item"></param>
        private void Select_GridCombo_Spec(string arg_item)
        {


            bool spec_set_flag = false;


            try
            {


                string spec = "";
                DataTable dt_ret = null;


                if (arg_item.Trim() == "")
                {

                    spec = txt_Spec.Text;

                    if (spec.Trim().Equals("")) return;

                    dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_SPEC_COMBO("", spec);

                }
                else
                {
                    dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_ITEM_SPEC_COMBO(arg_item);
                }  

                

                //if (dt_ret == null || dt_ret.Rows.Count == 0)
                //{

                //    _SpecCd = "";
                //    _SpecName = "";

                //    txt_Spec.Text = spec;

                //    txt_Spec.ForeColor = Color.Green;


                //    string message = "We have not spec : [" + spec + "]";
                //    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Spec", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //    spec_set_flag = false;

                //    return;
                //}



                // 정확하게 일치하는 아이템이 있는 경우 바로 세팅, 없으면 리스트 표시
                // SPEC_CD, SPEC_NAME, CORRECT_ITEM_FLAG
                if (((dt_ret.Rows[0].ItemArray[2] == null) ? "" : dt_ret.Rows[0].ItemArray[2].ToString()) == "Y")
                {


                    _SpecCd = (dt_ret.Rows[0].ItemArray[0] == null) ? "" : dt_ret.Rows[0].ItemArray[0].ToString();
                    _SpecName = (dt_ret.Rows[0].ItemArray[1] == null) ? "" : dt_ret.Rows[0].ItemArray[1].ToString();

                    txt_Spec.Text = (dt_ret.Rows[0].ItemArray[1] == null) ? "" : dt_ret.Rows[0].ItemArray[1].ToString();

                    txt_Spec.ForeColor = Color.Black;


                    spec_set_flag = true;

                }
                else
                {

                    FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                    string[] key_string = new string[] { "SPEC_CD" };
                    string[] value_string = new string[] { "SPEC_NAME" };

                    grid_combo._JobDivision = "SPEC";
                    grid_combo._ItemCD = arg_item;
                    grid_combo.ShowData(dt_ret, key_string, value_string, true, spec);
                    grid_combo.StartPosition = FormStartPosition.CenterParent;

                    //grid_combo.StartPosition = FormStartPosition.Manual;
                    //grid_combo.Location = new Point(MousePosition.X, MousePosition.Y);


                    if (grid_combo.ShowDialog() != DialogResult.OK)
                    {

                        _SpecCd = "";
                        _SpecName = "";

                        txt_Spec.Text = spec;

                        txt_Spec.ForeColor = Color.Black;

                        string message = "We must input spec : [" + spec + "]";
                        ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Spec", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        spec_set_flag = false;


                        return;
                    }



                    _SpecCd = grid_combo.VRow[0].ToString();
                    _SpecName = grid_combo.VRow[1].ToString();

                    txt_Spec.Text = grid_combo.VRow[1].ToString();

                    txt_Spec.ForeColor = Color.Black;


                    spec_set_flag = true;


                }


                //-----------------------------------------------------
                // 스펙이 선택 된 경우 spec list 저장
                //-----------------------------------------------------
                if (spec_set_flag)
                {

                    if (_ItemCd != "" && _SpecCd != "")
                    {
                        FlexBase.Yield_New.Form_BC_Yield.SAVE_SBC_ITEM_SPEC_COMBO(_ItemCd, _SpecCd, "I");
                    }

                    // color로 focus 이동
                    txt_Color.Focus();

                } // end if
                //-----------------------------------------------------



                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }



                // 사이즈 자재 여부에 따른 채산값 재 설정
                // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                Reset_Size_Material(_SizeYN);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Spec", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _SpecCd = "";
                _SpecName = "";

                txt_Spec.Text = "";

                txt_Spec.ForeColor = Color.Green;

            } // end catch


        }



        /// <summary>
        /// Select_GridCombo_Color : 
        /// </summary>
        private void Select_GridCombo_Color()
        {



            try
            {


                string color = txt_Color.Text;

                if (color.Trim().Equals("")) return;

                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_COLOR_COMBO(color);

                //if (dt_ret == null || dt_ret.Rows.Count == 0)
                //{

                //    _ColorCd = "";
                //    _ColorName = "";

                //    txt_Color.Text = color;

                //    txt_Color.ForeColor = Color.Green;


                //    string message = "We have not color : [" + color + "]";
                //    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Color", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //    return;
                //}



                // 정확하게 일치하는 아이템이 있는 경우 바로 세팅, 없으면 리스트 표시
                // COLOR_CD, COLOR_NAME, CORRECT_ITEM_FLAG
                if (((dt_ret.Rows[0].ItemArray[2] == null) ? "" : dt_ret.Rows[0].ItemArray[2].ToString()) == "Y")
                {


                    _ColorCd = (dt_ret.Rows[0].ItemArray[0] == null) ? "" : dt_ret.Rows[0].ItemArray[0].ToString();
                    _ColorName = (dt_ret.Rows[0].ItemArray[1] == null) ? "" : dt_ret.Rows[0].ItemArray[1].ToString();

                    txt_Color.Text = (dt_ret.Rows[0].ItemArray[1] == null) ? "" : dt_ret.Rows[0].ItemArray[1].ToString();

                    txt_Color.ForeColor = Color.Black;


                }
                else
                {

                    FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                    string[] key_string = new string[] { "COLOR_CD" };
                    string[] value_string = new string[] { "COLOR_NAME" };

                    grid_combo._JobDivision = "COLOR";
                    grid_combo.ShowData(dt_ret, key_string, value_string, true, color);
                    grid_combo.StartPosition = FormStartPosition.CenterParent;

                    //grid_combo.StartPosition = FormStartPosition.Manual;
                    //grid_combo.Location = new Point(MousePosition.X, MousePosition.Y);


                    if (grid_combo.ShowDialog() != DialogResult.OK)
                    {

                        _ColorCd = "";
                        _ColorName = "";

                        txt_Color.Text = color;

                        txt_Color.ForeColor = Color.Green;
                        string message = "We must input color : [" + color + "]";
                        ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Color", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        return;
                    }



                    _ColorCd = grid_combo.VRow[0].ToString();
                    _ColorName = grid_combo.VRow[1].ToString();

                    txt_Color.Text = grid_combo.VRow[1].ToString();

                    txt_Color.ForeColor = Color.Black;



                }


                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }



                // 사이즈 자재 여부에 따른 채산값 재 설정
                // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                Reset_Size_Material(_SizeYN);


                fgrid_Value.Focus();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Color", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ColorCd = "";
                _ColorName = "";

                txt_Color.Text = "";

                txt_Color.ForeColor = Color.Green;


            } // end catch



        }




        /// <summary>
        /// Reset_Size_Material : 
        /// </summary>
        /// <param name="size_yn"></param>
        private void Reset_Size_Material(string size_yn)
        {


            try
            {


                if (size_yn != "Y")
                {


                    for (int i = 1; i < (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; i++)
                    {

                        CellStyle cs_size_yn = fgrid_Value.Styles.Add("SIZE_N_" + i.ToString(), fgrid_Value.GetCellRange(_Value_Row_Yield, i).Style);
                        cs_size_yn.ForeColor = Color.Black;
                        fgrid_Value.SetCellStyle(_Value_Row_Yield, i, "SIZE_N_" + i.ToString());


                    } // end for i


                    //---------------------------------------------------------------
                    // detail spec 재 설정 : 사이즈 아이템 아닐 경우 헤더 spec 상속
                    //---------------------------------------------------------------
                    for (int i = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                    {

                        CellRange cr = fgrid_Value.GetCellRange(_Value_Row_Yield, i, _Value_Row_SpecName, i);
                        cr.StyleNew.BackColor = Color.White;

                        fgrid_Value[_Value_Row_SpecCode, i] = _SpecCd;
                        fgrid_Value[_Value_Row_SpecName, i] = _SpecName;

                    }
                    //---------------------------------------------------------------


                    fgrid_Value.Rows[_Value_Row_Yield].AllowEditing = true;


                }
                else
                {


                    fgrid_Value.Rows[_Value_Row_Yield].AllowEditing = false;

                    Display_Size_Material_Value(size_yn);

                } // if size_yn = "N"


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Reset_Size_Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        #endregion



        /// <summary>
        /// Event_fgrid_Value_AfterResizeColumn : 
        /// </summary>
        private void Event_fgrid_Value_AfterResizeColumn(RowColEventArgs e)
        {

            try
            {

                for (int i = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                {
                    fgrid_Value.Cols[i].Width = fgrid_Value.Cols[e.Col].Width;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Value_AfterResizeColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_fgrid_Value_StartEdit : 
        /// </summary>
        private void Event_fgrid_Value_StartEdit()
        {

            try
            {

                fgrid_Value.Buffer_CellData = fgrid_Value[fgrid_Value.Row, fgrid_Value.Col] == null ? "" : fgrid_Value[fgrid_Value.Row, fgrid_Value.Col].ToString();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Value_StartEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_fgrid_Value_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Value_AfterEdit()
        {

            try
            {

                if (fgrid_Value.Rows.Count <= fgrid_Value.Rows.Fixed) return;


                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }


                // 채산값 등록
                if (_SizeYN == "Y") return;


                for (int i = fgrid_Value.Selection.c1; i <= fgrid_Value.Selection.c2; i++)
                {
                    fgrid_Value[_Value_Row_Yield, i] = fgrid_Value[_Value_Row_Yield, fgrid_Value.Col];
                    fgrid_Value[_Value_Row_SpecCode, i] = _SpecCd;
                    fgrid_Value[_Value_Row_SpecName, i] = _SpecName;

                } // end for i



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Value_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }




        /// <summary>
        /// Event_fgrid_Value_MouseUp : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_fgrid_Value_MouseUp(MouseEventArgs e)
        {
            try
            {

                if (e.Button != MouseButtons.Right) return;


                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }


                //// 채산값 등록
                //if (_SizeYN != "Y") return;


                string cs_size_f = fgrid_Value[1, fgrid_Value.Selection.c1].ToString();
                string cs_size_t = fgrid_Value[1, fgrid_Value.Selection.c2].ToString();
                string yield_value = (fgrid_Value[_Value_Row_Yield, fgrid_Value.Col] == null) ? "0" : fgrid_Value[_Value_Row_Yield, fgrid_Value.Col].ToString();
                string spec_cd = (fgrid_Value[_Value_Row_SpecCode, fgrid_Value.Col] == null) ? "0" : fgrid_Value[_Value_Row_SpecCode, fgrid_Value.Col].ToString();
                string spec_name = (fgrid_Value[_Value_Row_SpecName, fgrid_Value.Col] == null) ? "0" : fgrid_Value[_Value_Row_SpecName, fgrid_Value.Col].ToString();


                FlexBase.Yield_New.Pop_Yield_Input_Value pop_form = new Pop_Yield_Input_Value(cs_size_f, cs_size_t, yield_value, spec_cd, spec_name);
                pop_form.ShowDialog();


                //cancel 했을 경우
                if (pop_form._CancelFlag) return;


                //apply 했을 경우
                for (int i = fgrid_Value.Selection.c1; i <= fgrid_Value.Selection.c2; i++)
                {
                    fgrid_Value[_Value_Row_Yield, i] = pop_form._Return_Value;
                    fgrid_Value[_Value_Row_SpecCode, i] = pop_form._Return_SpecCode;
                    fgrid_Value[_Value_Row_SpecName, i] = pop_form._Return_SpecName;
                }


                Display_Size_Material_Value(_SizeYN);




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Value_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_txt_AllSizeValue_KeyUp : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_txt_AllSizeValue_KeyUp(KeyEventArgs e)
        {

            try
            {

                if (e.KeyCode != Keys.Enter) return;

                if (txt_AllSizeValue.Text.Trim() == "") return;


                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }


                CellRange cr = fgrid_Value.GetCellRange(_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START, _Value_Row_Yield, fgrid_Value.Cols.Count - 1);
                cr.Data = txt_AllSizeValue.Text;


                txt_AllSizeValue.Text = "";



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_AllSizeValue_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        /// <summary>
        /// Event_btn_GetSpecBySize_Click : 사이즈 문대마다 사이즈 Spec, Group 구성
        /// </summary>
        private void Event_btn_GetSpecBySize_Click()
        {

            try
            {


                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {
                    return;
                }


                int size_f = -1;
                int size_t = -1;
                string spec_cd = "";
                string spec_name = "";


                size_f = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START;

                while (true)
                {

                    // 사이즈 문대마다 sepc grouping  
                    size_t = size_f;


                    spec_name = fgrid_Value[1, size_f].ToString().Trim() + "-" + fgrid_Value[1, size_t].ToString().Trim();
                    spec_cd = FlexBase.Yield_New.Form_BC_Yield.CHECK_SBC_YIELD_SPEC_NAME(spec_name);

                     
                    for (int i = size_f; i <= size_t; i++)
                    {

                        fgrid_Value[_Value_Row_SpecCode, i] = spec_cd;
                        fgrid_Value[_Value_Row_SpecName, i] = spec_name;
                    }


                    size_f = size_t + 1;

                    if (size_f == fgrid_Value.Cols.Count) break;

                } // end while



                // 그룹 표시
                Display_Size_Material_Value(_SizeYN);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_chk_GetSpecBySize_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_btn_GetSizeGroup_Click : 
        /// </summary>
        private void Event_btn_GetSizeGroup_Click()
        {

            try
            {
                Get_Item_Size_Group(btn_GetSizeGroup);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_GetSizeGroup_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_btn_GetSizeGroup_Item_Click : 
        /// </summary>
        private void Event_btn_GetSizeGroup_Item_Click()
        {

            try
            {
                Get_Item_Size_Group(btn_GetSizeGroup_Item);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_GetSizeGroup_Item_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_GetSpecGroup_Click : 
        /// </summary>
        private void Event_btn_GetSpecGroup_Click()
        {

            try
            {
                Get_Item_Size_Group(btn_GetSpecGroup);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_GetSpecGroup_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


         

        /// <summary>
        /// Get_Item_Size_Group : 
        /// </summary>
        /// <param name="arg_division"></param>
        private void Get_Item_Size_Group(System.Windows.Forms.Button arg_button)
        {


            // 원자재 모두 입력되었는지 확인
            // item, spec, color 없으면 설정 할 수 없음
            if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
            {
                return;
            }


            string style_factory = _Factory;
            string style_gender = _Gender;
            string style_presto = _PrestoYN;


            string factory = "";
            string style_cd = "";
            string item_cd = "";

            DataTable dt_ret = null;


            if (arg_button == btn_GetSizeGroup)
            {

                // style 6자리, item 일치 데이터
                //factory = _Factory;
                factory = "__"; // 공장 구분 없이 공통되게 사용되므로 default로 조회
                style_cd = _StyleCd.Replace("-", "").Substring(0, 6);
                item_cd = _ItemCd;

            }
            else if (arg_button == btn_GetSizeGroup_Item)
            {

                factory = "__";
                style_cd = "______";
                item_cd = _ItemCd;

            }
            else if (arg_button == btn_GetSpecGroup)
            {

                factory = _Factory;
                style_cd = "-1";
                item_cd = _ItemCd;

            }

            dt_ret = FlexBase.Yield_New.Form_BC_Yield.GET_SBC_YIELD_ITEM_GROUP_IN(factory, style_cd, item_cd, style_factory, style_gender, style_presto);


            if (dt_ret == null || dt_ret.Rows.Count == 0)
            {


                string message = "";
                DialogResult result;


                if (arg_button == btn_GetSizeGroup || arg_button == btn_GetSizeGroup_Item)
                {

                    message = "We have not item group : [" + _ItemName + "]" + "\r\n\r\n" + "Do you want to input new item size group?";

                    result = ClassLib.ComFunction.User_Message(message, "Get_Item_Size_Group", MessageBoxButtons.YesNo, MessageBoxIcon.Information);



                    if (result == DialogResult.Yes)  // master 프로그램 열어서 직접 신규로 등록
                    {

                        if (arg_button == btn_GetSizeGroup)
                        {

                            if (style_cd != "" && style_cd.Length > 6)
                            {
                                style_cd = style_cd.Substring(0, 6);
                            }
                        }
                        else
                        {
                            style_cd = "______";
                        }


                        FlexBase.Yield_New.Form_BC_Yield_Item_Group pop_form = new FlexBase.Yield_New.Form_BC_Yield_Item_Group(factory, style_cd, item_cd, _ItemName, _SizeYN, _Unit);
                        pop_form.WindowState = FormWindowState.Normal;
                        pop_form.StartPosition = FormStartPosition.CenterParent;
                        pop_form.ShowDialog();

                    }


                }
                else if (arg_button == btn_GetSpecGroup)
                {

                    message = "We have not item group : [" + _ItemName + "]" + "\r\n\r\n" + "Do you want to input new item size group?";

                    result = ClassLib.ComFunction.User_Message(message, "Get_Item_Size_Group", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                    if (result == DialogResult.Yes)  // master 프로그램 열어서 직접 신규로 등록
                    {

                        FlexBase.Yield.Form_BC_Yield_Size_Group pop_form = new FlexBase.Yield.Form_BC_Yield_Size_Group();
                        pop_form.WindowState = FormWindowState.Normal;
                        pop_form.StartPosition = FormStartPosition.CenterParent;
                        pop_form.ShowDialog();

                    }



                } // end if (arg_button == btn_GetSizeGroup)


                return;


            }



            int col_cs_size = -1;
            string db_size = "";
            string grid_size = "";
            string spec_cd = "";
            string spec_name = "";
            string yield_m = "";



            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {


                col_cs_size = -1;


                db_size = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxCS_SIZE] == null) ? "" : dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxCS_SIZE].ToString();
                spec_cd = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxSPEC_CD] == null) ? "" : dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxSPEC_CD].ToString();
                spec_name = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxSPEC_NAME] == null) ? "" : dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxSPEC_NAME].ToString();
                yield_m = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxYIELD_M] == null) ? "" : dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxYIELD_M].ToString();


                for (int a = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; a < fgrid_Value.Cols.Count; a++)
                {

                    grid_size = (fgrid_Value[1, a] == null) ? "" : fgrid_Value[1, a].ToString();

                    if (db_size == grid_size)
                    {
                        fgrid_Value[_Value_Row_Yield, a] = yield_m;
                        fgrid_Value[_Value_Row_SpecCode, a] = spec_cd;
                        fgrid_Value[_Value_Row_SpecName, a] = spec_name;

                        break;
                    }

                } // end for a

            } // end for i



            Display_Size_Material_Value(_SizeYN);


        }



        private void Event_btn_Search_Click()
        {

            try
            {
            
                // style, value 조회
                Display_Update_Style_Value();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        private void Event_btn_Apply_Click()
        {

            try
            {

                if (_Division == "I")
                {
                    Run_Change_Material_Insert();
                }
                else if (_Division == "D")
                {
                    Run_Change_Material_Update(_Division);
                }
                else if (_Division == "U")
                {
                    Run_Change_Material_Update(_Division);
                } // end if division    


                _CancelFlag = false;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _CancelFlag = true;
            }


        }



        // check in, out class
        // check in 일 때만 객체 생성
        ClassLib.Class_Check_InOut class_check_inout;



        /// <summary>
        /// Run_Change_Material_Insert : 
        /// </summary>
        private void Run_Change_Material_Insert()
        {


            if(fgrid_Style.Rows.Count <= fgrid_Style.Rows.Fixed) return;



            // 필수 항목 확인
            bool check_flag = Check_Save_Condition();
            if (!check_flag) return;


            DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
            if (dr == DialogResult.No) return;


            // 선택 행만 실행
            for (int i = fgrid_Style.Rows.Fixed; i < fgrid_Style.Rows.Count; i++)
            {


                if (fgrid_Style.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTYLE_CD).Equals(CheckEnum.Unchecked))
                {
                    continue;
                }


                //fgrid_Style.TopRow = i;
                fgrid_Style.Select(i, 0, true);
                System.Windows.Forms.Application.DoEvents();


                string factory = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxFACTORY].ToString();
                string style_cd = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTYLE_CD].ToString().Replace("-", "");
                string gender = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxGENDER].ToString();
                string presto_yn = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxPRESTO_YN].ToString();



                //-------------------------------------------
                // check in
                //-------------------------------------------
                class_check_inout = new FlexBase.ClassLib.Class_Check_InOut();


                string where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd 
                             + @"' AND SEMI_GOOD_CD = '" + _SgCd + "' AND COMPONENT_CD = '" + _ComponentCd + "'";

                
                //'FACTORY = '''            || ARG_FACTORY        || '''' ||
                //'AND STYLE_CD = '''       || ARG_STYLE_CD       || '''' ||
                //'AND SEMI_GOOD_CD = '''   || V_SEMI_GOOD_CD     || '''' ||
                //'AND COMPONENT_CD = '''   || ARG_COMPONENT_CD   || '''' ||
                //'AND TEMPLATE_SEQ = '''   || V_TEMPLATE_SEQ     || '''' ||
                //'AND TEMPLATE_LEVEL = ''' || ARG_TEMPLATE_LEVEL || '''',
                                                                        

                class_check_inout._CheckDivision = "I";
                class_check_inout._CheckFactory = ClassLib.ComVar.This_Factory;
                class_check_inout._CheckUser = ClassLib.ComVar.This_User;
                class_check_inout._CheckRemark = "change material - insert";
                class_check_inout._CheckWhere = where;
                class_check_inout._ShowMessage = false;
                class_check_inout._Factory = factory;
                class_check_inout._StyleCd = style_cd;
                class_check_inout._IncludeInfoTable = "Y";
                class_check_inout._IncludeValueTable = "Y";
                class_check_inout._IncludeHistoryTable = "Y";

                bool check_ok = class_check_inout.Run_Check_InOut();

                if (!check_ok)
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTATUS] = "Check In Fail";
                    continue;
                }
                //-------------------------------------------
                

                //-------------------------------------------
                // run insert
                //-------------------------------------------
                bool save_flag = SAVE_CHANGE_MAT_INSERT(factory, style_cd, gender, presto_yn);

                if (!save_flag)
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTATUS] = "Error apply"; 
                }
                else
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTATUS] = "Complate";
                }
                //-------------------------------------------


                //-------------------------------------------
                // check out
                //-------------------------------------------
                class_check_inout._CheckDivision = "O";
                class_check_inout._CheckRemark = "check out";

                check_ok = class_check_inout.Run_Check_InOut();

                if (!check_ok)
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTATUS] += "/ Check Out Fail";
                }
                else
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW.IxSTATUS] += "/ Check Out";
                }
                //-------------------------------------------
                 


            } // end for i


            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);


        }



        /// <summary>
        /// Run_Change_Material_Update : 
        /// </summary>
        /// <param name="arg_division"></param>
        private void Run_Change_Material_Update(string arg_division)
        {



            if (fgrid_Style.Rows.Count <= fgrid_Style.Rows.Fixed) return;



            // 필수 항목 확인
            bool check_flag = Check_Save_Condition();
            if (!check_flag) return;


            DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
            if (dr == DialogResult.No) return;


            // 선택 행만 실행
            for (int i = fgrid_Style.Rows.Fixed; i < fgrid_Style.Rows.Count; i++)
            {


                if (fgrid_Style.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTYLE_CD).Equals(CheckEnum.Unchecked))
                {
                    continue;
                }


                //fgrid_Style.TopRow = i;
                fgrid_Style.Select(i, 0, true);
                System.Windows.Forms.Application.DoEvents();


                string factory = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxFACTORY].ToString();
                string style_cd = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTYLE_CD].ToString().Replace("-", "");
                string gender = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxGENDER].ToString();
                string presto_yn = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxPRESTO_YN].ToString();
                string semi_good_cd = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSEMI_GOOD_CD].ToString();
                string component_cd = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxCOMPONENT_CD].ToString();
                string template_seq = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxTEMPLATE_SEQ].ToString();
                string template_level = fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxTEMPLATE_LEVEL].ToString();
                string item_cd = (chk_ChangeOnlyYield.Checked) ? fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxITEM_CD].ToString() : _ItemCd;
                string spec_cd = (chk_ChangeOnlyYield.Checked) ? fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSPEC_CD].ToString() : _SpecCd;
                string color_cd = (chk_ChangeOnlyYield.Checked) ? fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxCOLOR_CD].ToString() : _ColorCd;


                string where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd
                             + @"' AND SEMI_GOOD_CD = '" + semi_good_cd + "' AND COMPONENT_CD = '" + component_cd 
                             + @"' AND TEMPLATE_SEQ = '" + template_seq + "' AND TEMPLATE_LEVEL = '" + template_level + "'";


                //'FACTORY = '''            || ARG_FACTORY        || '''' ||
                //'AND STYLE_CD = '''       || ARG_STYLE_CD       || '''' ||
                //'AND SEMI_GOOD_CD = '''   || V_SEMI_GOOD_CD     || '''' ||
                //'AND COMPONENT_CD = '''   || ARG_COMPONENT_CD   || '''' ||
                //'AND TEMPLATE_SEQ = '''   || V_TEMPLATE_SEQ     || '''' ||
                //'AND TEMPLATE_LEVEL = ''' || ARG_TEMPLATE_LEVEL || '''',


                
                //-------------------------------------------
                // check in
                //-------------------------------------------
                class_check_inout = new FlexBase.ClassLib.Class_Check_InOut();

                class_check_inout._CheckDivision = "I";
                class_check_inout._CheckFactory = ClassLib.ComVar.This_Factory;
                class_check_inout._CheckUser = ClassLib.ComVar.This_User;

                if (_Division == "U")
                {
                    class_check_inout._CheckRemark = "change material - update";
                }
                else if (_Division == "D")
                {
                    class_check_inout._CheckRemark = "change material - delete";
                }

                class_check_inout._CheckWhere = where;
                class_check_inout._ShowMessage = false;
                class_check_inout._Factory = factory;
                class_check_inout._StyleCd = style_cd;
                class_check_inout._IncludeInfoTable = "Y";
                class_check_inout._IncludeValueTable = "Y";
                class_check_inout._IncludeHistoryTable = "Y";

                bool check_ok = class_check_inout.Run_Check_InOut();

                if (!check_ok)
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTATUS] = "Check In Fail";
                    continue;
                }
                //-------------------------------------------


                //-------------------------------------------
                // run insert
                //-------------------------------------------
                bool save_flag = false;

                if (_Division == "U")
                {
                    save_flag = SAVE_CHANGE_MAT_UPDATE(factory, style_cd, gender, presto_yn, semi_good_cd, component_cd, template_seq, template_level, item_cd, spec_cd, color_cd);
                }
                else if (_Division == "D")
                {
                    save_flag = SAVE_CHANGE_MAT_DELETE(factory, style_cd, gender, presto_yn, semi_good_cd, component_cd, template_seq, template_level);
                }

                if (!save_flag)
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTATUS] = "Error apply";
                }
                else
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTATUS] = "Complate";
                }
                //-------------------------------------------


                //-------------------------------------------
                // check out
                //-------------------------------------------
                class_check_inout._CheckDivision = "O";
                class_check_inout._CheckRemark = "check out";

                check_ok = class_check_inout.Run_Check_InOut();

                if (!check_ok)
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTATUS] += "/ Check Out Fail";
                }
                else
                {
                    fgrid_Style[i, (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW.IxSTATUS] += "/ Check Out";
                }
                //-------------------------------------------



            } // end for i


            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);



        }



        /// <summary>
        /// Check_Save_Condition : 
        /// </summary>
        /// <returns></returns>
        private bool Check_Save_Condition()
        {


            try
            {



                // component 없으면 설정 할 수 없음
                if (_ComponentCd == "")
                {

                    string message = "We must input component.";
                    ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_Component.Focus();

                    return false;

                }

                // item, spec, color 없으면 설정 할 수 없음
                if (_ItemCd == "" || _SpecCd == "" || _ColorCd == "")
                {

                    string message = "We must input material.";
                    ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_Item.Focus();

                    return false;
                }

                // 사이즈 spec 없으면 설정 할 수 없음
                string value = "";


                for (int i = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                {

                    value = (fgrid_Value[_Value_Row_SpecCode, i] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, i].ToString();

                    if (value == "")
                    {

                        string message = "We must input size spec.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return false;

                    }

                } // end for i

                // 사이즈 채산값 없으면 설정 할 수 없음
                for (int i = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                {

                    value = (fgrid_Value[_Value_Row_Yield, i] == null) ? "" : fgrid_Value[_Value_Row_Yield, i].ToString();

                    if (value == "")
                    {

                        string message = "Unsuitable yield value.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return false;

                    }

                } // end for i





                return true;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }






        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        private void Event_btn_Cancel_Click()
        {
            try
            {

                if (_CancelFlag != false)
                {
                    _CancelFlag = true;
                }

                this.Close();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        #endregion


        #endregion

        #region 이벤트 처리


        /// <summary>
        /// txt_Component_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Component_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_Component_KeyUp(e);
        }


        /// <summary>
        /// txt_Item_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Item_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_Item_KeyUp(sender, e);
        }


        /// <summary>
        /// txt_Spec_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Spec_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_Spec_KeyUp(sender, e);
        }


        /// <summary>
        /// txt_Color_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Color_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_Color_KeyUp(sender, e);
        }



        /// <summary>
        /// Event_fgrid_Value_AfterResizeColumn : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Value_AfterResizeColumn(object sender, RowColEventArgs e)
        {
            Event_fgrid_Value_AfterResizeColumn(e);
        }



        /// <summary>
        /// Event_fgrid_Value_StartEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Value_StartEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Value_StartEdit();
        }



        /// <summary>
        /// Event_fgrid_Value_AfterEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Value_AfterEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Value_AfterEdit();
        }



        /// <summary>
        /// fgrid_Value_MouseUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Value_MouseUp(object sender, MouseEventArgs e)
        {
            Event_fgrid_Value_MouseUp(e);
        }



        /// <summary>
        /// txt_AllSizeValue_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_AllSizeValue_KeyUp(object sender, KeyEventArgs e)
        {
            Event_txt_AllSizeValue_KeyUp(e);
        }


        /// <summary>
        /// Event_btn_GetSpecBySize_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetSpecBySize_Click(object sender, EventArgs e)
        {
            Event_btn_GetSpecBySize_Click();
        }


        /// <summary>
        /// Event_btn_GetSizeGroup_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetSizeGroup_Click(object sender, EventArgs e)
        {
            Event_btn_GetSizeGroup_Click();
        }


        /// <summary>
        /// btn_GetSizeGroup_Item_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetSizeGroup_Item_Click(object sender, EventArgs e)
        {
            Event_btn_GetSizeGroup_Item_Click();
        }


        /// <summary>
        /// btn_GetSpecGroup_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetSpecGroup_Click(object sender, EventArgs e)
        {
            Event_btn_GetSpecGroup_Click();
        }



        /// <summary>
        /// btn_Search_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Event_btn_Search_Click();
        }


        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Event_btn_Apply_Click();
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




        #endregion

        #region 디비 연결


        /// <summary>
        /// SELECT_CHANGE_MAT_INSERT : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_semi_good_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <param name="arg_template_seq"></param>
        /// <param name="arg_template_level"></param>
        /// <returns></returns>
        private DataSet SELECT_CHANGE_MAT_INSERT(string arg_factory,
            string arg_style_cd,
            string arg_semi_good_cd,
            string arg_component_cd,
            string arg_template_seq,
            string arg_template_level)
        {


            try
            {



                MyOraDB.ReDim_Parameter(8);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_CHANGE_MAT_INSERT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_LEVEL";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR_STYLE";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR_VALUE";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
                MyOraDB.Parameter_Values[3] = arg_component_cd;
                MyOraDB.Parameter_Values[4] = arg_template_seq;
                MyOraDB.Parameter_Values[5] = arg_template_level;
                MyOraDB.Parameter_Values[6] = "";
                MyOraDB.Parameter_Values[7] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return null;

                return ds_ret;

                // STYLE : ds_ret.Tables[0];
                // VALUE : ds_ret.Tables[1];


            }
            catch
            {
                return null;
            }

        }




        /// <summary>
        /// SAVE_CHANGE_MAT_INSERT : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_gender"></param>
        /// <param name="arg_presto_yn"></param>
        /// <returns></returns>
        private bool SAVE_CHANGE_MAT_INSERT(string arg_factory, string arg_style_cd, string arg_gender, string arg_presto_yn)
        {


            try
            {


                int col_ct = 23;

                MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_CHANGE_MAT_INSERT";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[4] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_LEVEL";
                MyOraDB.Parameter_Name[7] = "ARG_TEMPLATE_TREE_CD";
                MyOraDB.Parameter_Name[8] = "ARG_TEMPLATE_CD";
                MyOraDB.Parameter_Name[9] = "ARG_TEMPLATE_NAME";
                MyOraDB.Parameter_Name[10] = "ARG_COMPONENT_SEQ";
                MyOraDB.Parameter_Name[11] = "ARG_CS_SIZE_FROM";
                MyOraDB.Parameter_Name[12] = "ARG_CS_SIZE_TO";
                MyOraDB.Parameter_Name[13] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[14] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[15] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[16] = "ARG_YIELD_M";
                MyOraDB.Parameter_Name[17] = "ARG_GENDER";
                MyOraDB.Parameter_Name[18] = "ARG_PRESTO_YN";
                MyOraDB.Parameter_Name[19] = "ARG_UPD_FACTORY";
                MyOraDB.Parameter_Name[20] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[21] = "ARG_ACTION_FLAG";
                MyOraDB.Parameter_Name[22] = "ARG_HISTORY_REMARKS";
                

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                // ARG_COMPONENT_SEQ, ARG_TEMPLATE_SEQ : 프로시저에서 계산

                //-----------------------------------------------
                // component, item, spec, color 일치 데이터 삭제
                //-----------------------------------------------
                vList.Add("D"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(_SgCd); // "ARG_SEMI_GOOD_CD";
                vList.Add(_ComponentCd); // "ARG_COMPONENT_CD";
                vList.Add(""); // "ARG_TEMPLATE_SEQ";
                vList.Add("1"); // "ARG_TEMPLATE_LEVEL";  // 원자재 추가이므로 무조건 1
                vList.Add(_JointBOM_Only_Material); // "ARG_TEMPLATE_TREE_CD";
                vList.Add(_RawMaterial); // "ARG_TEMPLATE_CD";
                vList.Add(""); // "ARG_TEMPLATE_NAME";
                vList.Add(""); // "ARG_COMPONENT_SEQ";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(_ItemCd); // "ARG_ITEM_CD";
                vList.Add(_SpecCd); // "ARG_SPEC_CD";
                vList.Add(_ColorCd); // "ARG_COLOR_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(""); // "ARG_GENDER";
                vList.Add(""); // "ARG_PRESTO_YN";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add(""); // "ARG_ACTION_FLAG";
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------

                //-----------------------------------------------
                // value
                //-----------------------------------------------
                string before_spec = "";
                string now_spec = "";
                int size_f = -1;
                int size_t = -1;


                size_f = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START;


                if (_SizeYN == "Y") // 사이즈 아이템일 경우, spec으로 사이즈 그룹 구분
                {


                    while (true)
                    {

                        before_spec = (fgrid_Value[_Value_Row_SpecCode, size_f] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_f].ToString();


                        for (int k = size_f; k < fgrid_Value.Cols.Count; k++)
                        {

                            now_spec = (fgrid_Value[_Value_Row_SpecCode, k] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, k].ToString();


                            if (before_spec == now_spec)
                            {
                                size_t = k;
                            }
                            else
                            {
                                break;
                            }

                        }
                                          

      
                        vList.Add("V"); // "ARG_DIVISION";
                        vList.Add(arg_factory); // "ARG_FACTORY";
                        vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                        vList.Add(_SgCd); // "ARG_SEMI_GOOD_CD";
                        vList.Add(_ComponentCd); // "ARG_COMPONENT_CD";
                        vList.Add(""); // "ARG_TEMPLATE_SEQ";
                        vList.Add("1"); // "ARG_TEMPLATE_LEVEL";  // 원자재 추가이므로 무조건 1
                        vList.Add(_JointBOM_Only_Material); // "ARG_TEMPLATE_TREE_CD";
                        vList.Add(_RawMaterial); // "ARG_TEMPLATE_CD";
                        vList.Add(""); // "ARG_TEMPLATE_NAME";
                        vList.Add(""); // "ARG_COMPONENT_SEQ";
                        vList.Add(fgrid_Value[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                        vList.Add(fgrid_Value[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                        vList.Add(_ItemCd); // "ARG_ITEM_CD";
                        vList.Add((fgrid_Value[_Value_Row_SpecCode, size_f] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_f].ToString()); // "ARG_SPEC_CD";
                        vList.Add(_ColorCd); // "ARG_COLOR_CD";
                        vList.Add((fgrid_Value[_Value_Row_Yield, size_f] == null) ? "0" : fgrid_Value[_Value_Row_Yield, size_f].ToString()); // "ARG_YIELD_M";
                        vList.Add(_Gender); // "ARG_GENDER";
                        vList.Add(_PrestoYN); // "ARG_PRESTO_YN";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        vList.Add(""); // "ARG_ACTION_FLAG";
                        vList.Add(""); // "ARG_HISTORY_REMARKS"; 


                        
                        
                        size_f = size_t + 1;

                        if (size_f == fgrid_Value.Cols.Count) break;

                    } // end while



                }
                else // 사이즈 아이템 아닐 경우, value로 사이즈 그룹 구분
                {


                    while (true)
                    {

                        before_spec = (fgrid_Value[_Value_Row_Yield, size_f] == null) ? "0" : fgrid_Value[_Value_Row_Yield, size_f].ToString();

                        for (int k = size_f; k < fgrid_Value.Cols.Count; k++)
                        {

                            now_spec = (fgrid_Value[_Value_Row_Yield, k] == null) ? "0" : fgrid_Value[_Value_Row_Yield, k].ToString();


                            if (before_spec == now_spec)
                            {
                                size_t = k;
                            }
                            else
                            {
                                break;
                            }

                        }


                        vList.Add("V"); // "ARG_DIVISION";
                        vList.Add(arg_factory); // "ARG_FACTORY";
                        vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                        vList.Add(_SgCd); // "ARG_SEMI_GOOD_CD";
                        vList.Add(_ComponentCd); // "ARG_COMPONENT_CD";
                        vList.Add(""); // "ARG_TEMPLATE_SEQ";
                        vList.Add("1"); // "ARG_TEMPLATE_LEVEL";  // 원자재 추가이므로 무조건 1
                        vList.Add(_JointBOM_Only_Material); // "ARG_TEMPLATE_TREE_CD";
                        vList.Add(_RawMaterial); // "ARG_TEMPLATE_CD";
                        vList.Add(""); // "ARG_TEMPLATE_NAME";
                        vList.Add(""); // "ARG_COMPONENT_SEQ";
                        vList.Add(fgrid_Value[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                        vList.Add(fgrid_Value[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                        vList.Add(_ItemCd); // "ARG_ITEM_CD";
                        vList.Add((fgrid_Value[_Value_Row_SpecCode, size_f] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_f].ToString()); // "ARG_SPEC_CD";
                        vList.Add(_ColorCd); // "ARG_COLOR_CD";
                        vList.Add((fgrid_Value[_Value_Row_Yield, size_f] == null) ? "0" : fgrid_Value[_Value_Row_Yield, size_f].ToString()); // "ARG_YIELD_M";
                        vList.Add(_Gender); // "ARG_GENDER";
                        vList.Add(_PrestoYN); // "ARG_PRESTO_YN";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        vList.Add(""); // "ARG_ACTION_FLAG";
                        vList.Add(""); // "ARG_HISTORY_REMARKS"; 



                        size_f = size_t + 1;

                        if (size_f == fgrid_Value.Cols.Count) break;

                    } // end while



                }
                //-----------------------------------------------

                //-----------------------------------------------
                // history
                //-----------------------------------------------
                vList.Add("H"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(_SgCd); // "ARG_SEMI_GOOD_CD";
                vList.Add(_ComponentCd); // "ARG_COMPONENT_CD";
                vList.Add(""); // "ARG_TEMPLATE_SEQ";
                vList.Add("1"); // "ARG_TEMPLATE_LEVEL";  // 원자재 추가이므로 무조건 1
                vList.Add(_JointBOM_Only_Material); // "ARG_TEMPLATE_TREE_CD";
                vList.Add(_RawMaterial); // "ARG_TEMPLATE_CD";
                vList.Add(""); // "ARG_TEMPLATE_NAME";
                vList.Add(""); // "ARG_COMPONENT_SEQ";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(_ItemCd); // "ARG_ITEM_CD";
                vList.Add(_SpecCd); // "ARG_SPEC_CD";
                vList.Add(_ColorCd); // "ARG_COLOR_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(""); // "ARG_GENDER";
                vList.Add(""); // "ARG_PRESTO_YN";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add("I"); // "ARG_ACTION_FLAG"; 
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------

                //-----------------------------------------------
                // info
                //-----------------------------------------------
                vList.Add("I"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(_SgCd); // "ARG_SEMI_GOOD_CD";
                vList.Add(_ComponentCd); // "ARG_COMPONENT_CD";
                vList.Add(""); // "ARG_TEMPLATE_SEQ";
                vList.Add("1"); // "ARG_TEMPLATE_LEVEL";  // 원자재 추가이므로 무조건 1
                vList.Add(_JointBOM_Only_Material); // "ARG_TEMPLATE_TREE_CD";
                vList.Add(_RawMaterial); // "ARG_TEMPLATE_CD";
                vList.Add(""); // "ARG_TEMPLATE_NAME";
                vList.Add(""); // "ARG_COMPONENT_SEQ";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(_ItemCd); // "ARG_ITEM_CD";
                vList.Add(_SpecCd); // "ARG_SPEC_CD";
                vList.Add(_ColorCd); // "ARG_COLOR_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(""); // "ARG_GENDER";
                vList.Add(""); // "ARG_PRESTO_YN";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add(""); // "ARG_ACTION_FLAG";
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------



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
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_CHANGE_MAT_INSERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }




        /// <summary>
        /// SELECT_CHANGE_MAT_UPDATE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_semi_good_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <param name="arg_template_seq"></param>
        /// <param name="arg_template_level"></param>
        /// <param name="arg_item_cd"></param>
        /// <param name="arg_spec_cd"></param>
        /// <param name="arg_color_cd"></param>
        /// <param name="arg_where_component_yn"></param>
        /// <param name="arg_where_item_yn"></param>
        /// <param name="arg_where_spec_yn"></param>
        /// <param name="arg_where_color_yn"></param>
        /// <returns></returns>
        private DataSet SELECT_CHANGE_MAT_UPDATE(string arg_factory,
            string arg_style_cd,
            string arg_semi_good_cd,
            string arg_component_cd,
            string arg_template_seq,
            string arg_template_level,
            string arg_item_cd,
            string arg_spec_cd, 
            string arg_color_cd, 
            string arg_where_component_yn, 
            string arg_where_item_yn, 
            string arg_where_spec_yn, 
            string arg_where_color_yn)
        {


            try
            {



                MyOraDB.ReDim_Parameter(15);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_CHANGE_MAT_UPDATE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_LEVEL";
                MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[7] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[8] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[9] = "ARG_WHERE_COMPONENT_YN";
                MyOraDB.Parameter_Name[10] = "ARG_WHERE_ITEM_YN";
                MyOraDB.Parameter_Name[11] = "ARG_WHERE_SPEC_YN";
                MyOraDB.Parameter_Name[12] = "ARG_WHERE_COLOR_YN";
                MyOraDB.Parameter_Name[13] = "OUT_CURSOR_STYLE";
                MyOraDB.Parameter_Name[14] = "OUT_CURSOR_VALUE";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[14] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
                MyOraDB.Parameter_Values[3] = arg_component_cd;
                MyOraDB.Parameter_Values[4] = arg_template_seq;
                MyOraDB.Parameter_Values[5] = arg_template_level;
                MyOraDB.Parameter_Values[6] = arg_item_cd;
                MyOraDB.Parameter_Values[7] = arg_spec_cd;
                MyOraDB.Parameter_Values[8] = arg_color_cd;
                MyOraDB.Parameter_Values[9] = arg_where_component_yn;
                MyOraDB.Parameter_Values[10] = arg_where_item_yn;
                MyOraDB.Parameter_Values[11] = arg_where_spec_yn;
                MyOraDB.Parameter_Values[12] = arg_where_color_yn;
                MyOraDB.Parameter_Values[13] = "";
                MyOraDB.Parameter_Values[14] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return null;

                return ds_ret;

                // STYLE : ds_ret.Tables[0];
                // VALUE : ds_ret.Tables[1];


            }
            catch
            {
                return null;
            }

        }




        /// <summary>
        /// SAVE_CHANGE_MAT_UPDATE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_gender"></param>
        /// <param name="arg_presto_yn"></param>
        /// <param name="arg_semi_good_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <param name="arg_template_seq"></param>
        /// <param name="arg_template_level"></param>
        /// <param name="arg_item_cd"></param>
        /// <param name="arg_spec_cd"></param>
        /// <param name="arg_color_cd"></param>
        /// <returns></returns>
        private bool SAVE_CHANGE_MAT_UPDATE(string arg_factory, 
            string arg_style_cd, 
            string arg_gender, 
            string arg_presto_yn, 
            string arg_semi_good_cd, 
            string arg_component_cd,
            string arg_template_seq, 
            string arg_template_level,
            string arg_item_cd,
            string arg_spec_cd,
            string arg_color_cd)
        {

            try
            {


                int col_ct = 19;

                MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_CHANGE_MAT_UPDATE";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[4] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_LEVEL";
                MyOraDB.Parameter_Name[7] = "ARG_CS_SIZE_FROM";
                MyOraDB.Parameter_Name[8] = "ARG_CS_SIZE_TO";
                MyOraDB.Parameter_Name[9] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[10] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[11] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[12] = "ARG_YIELD_M";
                MyOraDB.Parameter_Name[13] = "ARG_GENDER";
                MyOraDB.Parameter_Name[14] = "ARG_PRESTO_YN";
                MyOraDB.Parameter_Name[15] = "ARG_UPD_FACTORY";
                MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[17] = "ARG_ACTION_FLAG";
                MyOraDB.Parameter_Name[18] = "ARG_HISTORY_REMARKS";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                // ARG_COMPONENT_SEQ, ARG_TEMPLATE_SEQ : 프로시저에서 계산

                //-----------------------------------------------
                // component, item, spec, color 일치 데이터 삭제
                //-----------------------------------------------
                vList.Add("D"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(arg_semi_good_cd); // "ARG_SEMI_GOOD_CD";
                vList.Add(arg_component_cd); // "ARG_COMPONENT_CD";
                vList.Add(arg_template_seq); // "ARG_TEMPLATE_SEQ";
                vList.Add(arg_template_level); // "ARG_TEMPLATE_LEVEL";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                vList.Add(arg_spec_cd); // "ARG_SPEC_CD";
                vList.Add(arg_color_cd); // "ARG_COLOR_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(""); // "ARG_GENDER";
                vList.Add(""); // "ARG_PRESTO_YN";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add(""); // "ARG_ACTION_FLAG";
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------

                //-----------------------------------------------
                // value
                //-----------------------------------------------
                string before_spec = "";
                string now_spec = "";
                int size_f = -1;
                int size_t = -1;


                size_f = (int)ClassLib.TBSBC_YIELD_CHANGE_MAT_VALUE_NEW.IxCS_SIZE_START;


                if (_SizeYN == "Y") // 사이즈 아이템일 경우, spec으로 사이즈 그룹 구분
                {


                    while (true)
                    {

                        before_spec = (fgrid_Value[_Value_Row_SpecCode, size_f] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_f].ToString();


                        for (int k = size_f; k < fgrid_Value.Cols.Count; k++)
                        {

                            now_spec = (fgrid_Value[_Value_Row_SpecCode, k] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, k].ToString();


                            if (before_spec == now_spec)
                            {
                                size_t = k;
                            }
                            else
                            {
                                break;
                            }

                        }



                        vList.Add("V"); // "ARG_DIVISION";
                        vList.Add(arg_factory); // "ARG_FACTORY";
                        vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                        vList.Add(arg_semi_good_cd); // "ARG_SEMI_GOOD_CD";
                        vList.Add(arg_component_cd); // "ARG_COMPONENT_CD";
                        vList.Add(arg_template_seq); // "ARG_TEMPLATE_SEQ";
                        vList.Add(arg_template_level); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(fgrid_Value[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                        vList.Add(fgrid_Value[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                        vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                        vList.Add((fgrid_Value[_Value_Row_SpecCode, size_f] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_f].ToString()); // "ARG_SPEC_CD";
                        vList.Add(arg_color_cd); // "ARG_COLOR_CD";
                        vList.Add((fgrid_Value[_Value_Row_Yield, size_f] == null) ? "0" : fgrid_Value[_Value_Row_Yield, size_f].ToString()); // "ARG_YIELD_M";
                        vList.Add(_Gender); // "ARG_GENDER";
                        vList.Add(_PrestoYN); // "ARG_PRESTO_YN";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        vList.Add(""); // "ARG_ACTION_FLAG";
                        vList.Add(""); // "ARG_HISTORY_REMARKS"; 




                        size_f = size_t + 1;

                        if (size_f == fgrid_Value.Cols.Count) break;

                    } // end while



                }
                else // 사이즈 아이템 아닐 경우, value로 사이즈 그룹 구분
                {


                    while (true)
                    {

                        before_spec = (fgrid_Value[_Value_Row_Yield, size_f] == null) ? "0" : fgrid_Value[_Value_Row_Yield, size_f].ToString();

                        for (int k = size_f; k < fgrid_Value.Cols.Count; k++)
                        {

                            now_spec = (fgrid_Value[_Value_Row_Yield, k] == null) ? "0" : fgrid_Value[_Value_Row_Yield, k].ToString();


                            if (before_spec == now_spec)
                            {
                                size_t = k;
                            }
                            else
                            {
                                break;
                            }

                        }


                        vList.Add("V"); // "ARG_DIVISION";
                        vList.Add(arg_factory); // "ARG_FACTORY";
                        vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                        vList.Add(arg_semi_good_cd); // "ARG_SEMI_GOOD_CD";
                        vList.Add(arg_component_cd); // "ARG_COMPONENT_CD";
                        vList.Add(arg_template_seq); // "ARG_TEMPLATE_SEQ";
                        vList.Add(arg_template_level); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(fgrid_Value[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                        vList.Add(fgrid_Value[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                        vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                        //vList.Add((fgrid_Value[_Value_Row_SpecCode, size_f] == null) ? "" : fgrid_Value[_Value_Row_SpecCode, size_f].ToString()); // "ARG_SPEC_CD";
                        // size 아이템이 아닌 경우, 사이즈 spec은 헤더 spec과 동일하므로
                        vList.Add(arg_spec_cd); // "ARG_SPEC_CD";
                        vList.Add(arg_color_cd); // "ARG_COLOR_CD";
                        vList.Add((fgrid_Value[_Value_Row_Yield, size_f] == null) ? "0" : fgrid_Value[_Value_Row_Yield, size_f].ToString()); // "ARG_YIELD_M";
                        vList.Add(_Gender); // "ARG_GENDER";
                        vList.Add(_PrestoYN); // "ARG_PRESTO_YN";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        vList.Add(""); // "ARG_ACTION_FLAG";
                        vList.Add(""); // "ARG_HISTORY_REMARKS"; 



                        size_f = size_t + 1;

                        if (size_f == fgrid_Value.Cols.Count) break;

                    } // end while



                }
                //-----------------------------------------------

                //-----------------------------------------------
                // history
                //-----------------------------------------------
                vList.Add("H"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(arg_semi_good_cd); // "ARG_SEMI_GOOD_CD";
                vList.Add(arg_component_cd); // "ARG_COMPONENT_CD";
                vList.Add(arg_template_seq); // "ARG_TEMPLATE_SEQ";
                vList.Add(arg_template_level); // "ARG_TEMPLATE_LEVEL";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                vList.Add(arg_spec_cd); // "ARG_SPEC_CD";
                vList.Add(arg_color_cd); // "ARG_COLOR_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(""); // "ARG_GENDER";
                vList.Add(""); // "ARG_PRESTO_YN";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add("U"); // "ARG_ACTION_FLAG"; 
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------

                //-----------------------------------------------
                // info
                //-----------------------------------------------
                vList.Add("I"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(arg_semi_good_cd); // "ARG_SEMI_GOOD_CD";
                vList.Add(arg_component_cd); // "ARG_COMPONENT_CD";
                vList.Add(arg_template_seq); // "ARG_TEMPLATE_SEQ";
                vList.Add(arg_template_level); // "ARG_TEMPLATE_LEVEL";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                vList.Add(arg_spec_cd); // "ARG_SPEC_CD";
                vList.Add(arg_color_cd); // "ARG_COLOR_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(""); // "ARG_GENDER";
                vList.Add(""); // "ARG_PRESTO_YN";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add(""); // "ARG_ACTION_FLAG";
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------



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
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_CHANGE_MAT_UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }




        /// <summary>
        /// SAVE_CHANGE_MAT_DELETE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_gender"></param>
        /// <param name="arg_presto_yn"></param>
        /// <param name="arg_semi_good_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <param name="arg_template_seq"></param>
        /// <param name="arg_template_level"></param>
        /// <returns></returns>
        private bool SAVE_CHANGE_MAT_DELETE(string arg_factory, string arg_style_cd, string arg_gender, string arg_presto_yn, string arg_semi_good_cd, string arg_component_cd, string arg_template_seq, string arg_template_level)
        {

            try
            {


                int col_ct = 11;

                MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_CHANGE_MAT_DELETE";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[4] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_LEVEL";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_FACTORY";
                MyOraDB.Parameter_Name[8] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[9] = "ARG_ACTION_FLAG";
                MyOraDB.Parameter_Name[10] = "ARG_HISTORY_REMARKS";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();



                //-----------------------------------------------
                // 데이터 삭제
                //-----------------------------------------------
                vList.Add("D"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(arg_semi_good_cd); // "ARG_SEMI_GOOD_CD";
                vList.Add(arg_component_cd); // "ARG_COMPONENT_CD";
                vList.Add(arg_template_seq); // "ARG_TEMPLATE_SEQ";
                vList.Add(arg_template_level); // "ARG_TEMPLATE_LEVEL";
                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                vList.Add("D"); // "ARG_ACTION_FLAG";
                vList.Add(""); // "ARG_HISTORY_REMARKS"; 
                //-----------------------------------------------


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
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_CHANGE_MAT_DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }



        #endregion

       


    }
}