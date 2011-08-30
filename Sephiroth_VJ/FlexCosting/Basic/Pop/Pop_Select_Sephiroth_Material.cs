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

namespace FlexCosting.Basic.Pop
{
    public partial class Pop_Select_Sephiroth_Material : COM.APSWinForm.Pop_Large
    {


        #region 생성자


        public Pop_Select_Sephiroth_Material()
        {
            InitializeComponent();
        }


        // division 
        // 1. "" : item, spec, color 모두 선택해야 리턴 가능
        // 2. "ITEM" or "SPEC" or "COLOR" 각 항목 하나만 선택해도 리턴 가능
        private string _Division = "";
        private string _ItemCd = "";
        private string _ItemName = "";
        private string _SpecCd = "";
        private string _SpecName = "";
        private string _ColorCd = "";
        private string _ColorName = "";
        private string _Unit = "";

        public Pop_Select_Sephiroth_Material(string arg_division,
            string arg_itemcd,
            string arg_itemname,
            string arg_speccd,
            string arg_specname,
            string arg_colorcd,
            string arg_colorname,
            string arg_unit)
        {
            InitializeComponent();

            _Division = arg_division;
            _ItemCd = arg_itemcd;
            _ItemName = arg_itemname;
            _SpecCd = arg_speccd;
            _SpecName = arg_specname;
            _ColorCd = arg_colorcd;
            _ColorName = arg_colorname;
            _Unit = arg_unit;
        }


        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        //return 또는 cancel 이벤트 체크
        public bool _CancelFlag = true;




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
                this.Text = "Item / Spec/ Color";
                lbl_MainTitle.Text = "Item / Spec/ Color";
                ClassLib.ComFunction.SetLangDic(this);


                Init_Grid();
                Init_Control();



            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Init_Grid : 
        /// </summary>
        private void Init_Grid()
        {

            fgrid_Item.Set_Grid("SBC_ITEM_COMMON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Spec.Set_Grid("SBC_SPEC_COMMON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Color.Set_Grid("SBC_COLOR_COMMON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);


        }



        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {


            //tabControl1.SelectedTab = tabPage_Item;

            if (_Division == "ITEM")
            {
                tabControl1.SelectedTab = tabPage_Item;
            }
            else if (_Division == "SPEC")
            {
                tabControl1.SelectedTab = tabPage_Spec;
            }
            else if (_Division == "COLOR")
            {
                tabControl1.SelectedTab = tabPage_Color;
            }
            else
            {
                tabControl1.SelectedTab = tabPage_Item;
            }



            DataTable dt_ret;

            //그룹타입 콤보쿼리 
            dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_ItemType, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_ItemType.SelectedIndex = 0;


            // Specification Division Combo List
            dt_ret = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxSpecDiv);
            COM.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, true, COM.ComVar.ComboList_Visible.Name);

            dt_ret.Dispose();



            //초기 결과값 세팅 - 파라미터로 데이터 기존 넘어왔을 경우 위해서
            txt_Result_ItemCd.Text = _ItemCd;
            txt_Result_ItemName.Text = _ItemName;
            txt_Result_SpecCd.Text = _SpecCd;
            txt_Result_SpecName.Text = _SpecName;
            txt_Result_ColorCd.Text = _ColorCd;
            txt_Result_ColorName.Text = _ColorName;
            txt_Result_Unit.Text = _Unit;



        }






        #endregion

        #region 조회




        /// <summary>
        /// Select_Item : 
        /// </summary>
        private void Select_Item()
        {



            string item_cd = COM.ComFunction.Empty_TextBox(txt_ItemCd, " ");
            string group_cd = COM.ComFunction.Empty_Combo(cmb_ItemType, " ") + COM.ComFunction.Empty_Combo(cmb_ItemGroup, " ");
            string item_name = COM.ComFunction.Empty_TextBox(txt_ItemName, " ");
            string use_yn = "Y";

            DataTable dt_ret = Select_SBC_ITEM_COMMON(item_cd, group_cd, item_name, use_yn);

            fgrid_Item.Display_Grid(dt_ret, false);


            dt_ret.Dispose();




            //------------------------------------------------------------------------------------------------------------------------
            // 정확하게 일치하는 항목으로 결과값 할당
            //------------------------------------------------------------------------------------------------------------------------
            string diff_item = "";
            string current_item = "";

            for (int i = 0; i < fgrid_Item.Rows.Count; i++)
            {

                if (!txt_ItemCd.Text.Trim().Equals(""))
                {
                    diff_item = txt_ItemCd.Text.Trim().ToUpper();
                    current_item = fgrid_Item[i, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_CD].ToString().Trim().ToUpper();

                }
                else if (!txt_ItemName.Text.Trim().Equals(""))
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


        /// <summary>
        /// Select_Spec : 
        /// </summary>
        private void Select_Spec()
        {


            DataTable dt_ret;

            string spec_div = COM.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
            string spec_cd = COM.ComFunction.Empty_TextBox(txt_SpecCd, " ");
            string spec_name = COM.ComFunction.Empty_TextBox(txt_SpecName, " ");
            string use_yn = "Y";

            dt_ret = Select_SBC_SPEC_CD_COMMON(spec_div, spec_cd, spec_name, use_yn);


            fgrid_Spec.Display_Grid(dt_ret, false);

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


        /// <summary>
        /// Select_Color : 
        /// </summary>
        private void Select_Color()
        {


            DataTable dt_ret;


            string color_cd = COM.ComFunction.Empty_TextBox(txt_ColorCd, " ");
            string color_name = COM.ComFunction.Empty_TextBox(txt_ColorName, " ");
            string use_yn = "Y";

            dt_ret = Select_SBC_COLOR_COMMON(color_cd, color_name, use_yn);

            fgrid_Color.Display_Grid(dt_ret, false);

            dt_ret.Dispose();


            //------------------------------------------------------------------------------------------------------------------------
            // 정확하게 일치하는 항목으로 결과값 할당
            //------------------------------------------------------------------------------------------------------------------------
            string diff_item = "";
            string current_item = "";

            for (int i = 0; i < fgrid_Color.Rows.Count; i++)
            {

                if (!txt_ColorCd.Text.Trim().Equals(""))
                {
                    diff_item = txt_ColorCd.Text.Trim().ToUpper();
                    current_item = fgrid_Color[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD].ToString().Trim().ToUpper();

                }
                else if (!txt_ColorName.Text.Trim().Equals(""))
                {
                    diff_item = txt_ColorName.Text.Trim().ToUpper();
                    current_item = fgrid_Color[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME].ToString().Trim().ToUpper();
                }


                if (diff_item == "" || current_item == "") break;

                if (diff_item == current_item)
                {
                    fgrid_Color.TopRow = i;
                    fgrid_Color.Select(i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME, true);


                    Set_Return_Color();
                    break;

                }


            }
            //------------------------------------------------------------------------------------------------------------------------




        }



        /// <summary>
        /// item에 대한 default specification 정보 조회 
        /// </summary>
        private void Search_Default_Spec()
        {

            DataTable dt_ret;

            string item_cd = COM.ComFunction.Empty_TextBox(txt_Result_ItemCd, " ");

            dt_ret = Select_SBC_SPEC_MASTER(item_cd);
            fgrid_Spec.Display_Grid(dt_ret, false);

            dt_ret.Dispose();

        }




        /// <summary>
        /// Set_Return_Item : Item Select
        /// </summary>
        private void Set_Return_Item()
        {

            if (fgrid_Item.Rows.Count == 0) return;



            txt_Result_ItemCd.Text = fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_CD].ToString().ToString();
            txt_Result_ItemName.Text = fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_NAME1].ToString().ToString();
            txt_Result_Unit.Text = fgrid_Item[fgrid_Item.Row, (int)ClassLib.TBSBC_ITEM_COMMON.IxMNG_UNIT].ToString().ToString();


            tabControl1.SelectedTab = tabPage_Spec;


            // item에 대한 default specification 정보 조회
            Search_Default_Spec();


        }



        /// <summary>
        /// Set_Return_Spec : Specification Select
        /// </summary>
        private void Set_Return_Spec()
        {

            if (fgrid_Spec.Rows.Count == 0) return;


            txt_Result_SpecCd.Text = fgrid_Spec[fgrid_Spec.Row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].ToString().ToString();
            txt_Result_SpecName.Text = fgrid_Spec[fgrid_Spec.Row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].ToString().ToString();


            tabControl1.SelectedTab = tabPage_Color;



        }



        /// <summary>
        /// Set_Return_Color : Color Select
        /// </summary>
        private void Set_Return_Color()
        {

            if (fgrid_Color.Rows.Count == 0) return;


            txt_Result_ColorCd.Text = fgrid_Color[fgrid_Color.Row, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD].ToString().ToString();
            txt_Result_ColorName.Text = fgrid_Color[fgrid_Color.Row, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME].ToString().ToString();

            btn_Apply.Focus();


        }



        /// <summary>
        /// Return_Item_Data : 
        /// </summary>
        private void Return_Item_Data()
        {

            if (_Division.Trim().Equals(""))
            {

                if (txt_Result_ItemCd.Text.Trim() == "")
                {
                    COM.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_Result_SpecCd.Text.Trim() == "")
                {
                    COM.ComFunction.User_Message("Select Sepcification", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_Result_ColorCd.Text.Trim() == "")
                {
                    COM.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }


            this.Close();

        }




        #endregion

        #region 툴바 이벤트 메서드




        #endregion

        #region 그리드 이벤트 메서드



        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// Event_cmb_ItemType_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_ItemType_SelectedValueChanged()
        {

            if (cmb_ItemType.SelectedIndex == -1) return;


            // Item Group First Class Combo List

            DataTable dt_ret;

            dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_ItemType.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(dt_ret, cmb_ItemGroup, 0, 1, true, COM.ComVar.ComboList_Visible.Name);

            dt_ret.Dispose();


        }



        /// <summary>
        /// Event_btn_Search_Click : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_btn_Search_Click(object sender)
        {

            Label src = sender as Label;


            if (src == btn_SearchItem)
            {

                Select_Item();

            }
            else if (src == btn_SearchSpec)
            {

                Select_Spec();

            }
            else if (src == btn_SearchColor)
            {

                Select_Color();

            }




        }



        /// <summary>
        /// Event_fgrid_DoubleClick : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_fgrid_DoubleClick(object sender)
        {

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



        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        private void Event_btn_Apply_Click()
        {

            _CancelFlag = false;
            Return_Item_Data();


        }


        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        private void Event_btn_Cancel_Click()
        {

            _CancelFlag = true;
            this.Close();


        }



        /// <summary>
        /// Event_txt_KeyUp : 
        /// </summary>
        private void Event_txt_KeyUp()
        {



            if (tabControl1.SelectedTab.Equals(tabPage_Item))
            {
                Select_Item();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage_Spec))
            {
                Select_Spec();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage_Color))
            {

                Select_Color();
            }




        }



        /// <summary>
        /// Event_Pop_Select_Sephiroth_Material_FormClosing : 
        /// </summary>
        private void Event_Pop_Select_Sephiroth_Material_FormClosing()
        {


            if (_CancelFlag)
            {

            }
            else
            {
                COM.ComVar.Parameter_PopUp = new string[]
					{
						txt_Result_ItemCd.Text,
						txt_Result_ItemName.Text,
						txt_Result_SpecCd.Text,
						txt_Result_SpecName.Text,
						txt_Result_ColorCd.Text,
						txt_Result_ColorName.Text,
						txt_Result_Unit.Text
					};



            } // end if


        }






        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드




        #endregion



        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트



        #endregion

        #region 그리드 이벤트


        #endregion

        #region 버튼 및 기타 이벤트


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


        private void Pop_Select_Sephiroth_Material_Load(object sender, EventArgs e)
        {
            Init_Form();
        }



        private void cmb_ItemType_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_ItemType_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_cmb_ItemType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        private void btn_Search_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Search_Click(sender);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        private void fgrid_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_DoubleClick(sender);
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_fgrid_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }


        private void btn_Apply_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Apply_Click();
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_Cancel_Click();
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }



        private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;


                Event_txt_KeyUp();


            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_txt_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void Pop_Select_Sephiroth_Material_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {

                Event_Pop_Select_Sephiroth_Material_FormClosing();


            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "Event_Pop_Select_Sephiroth_Material_FormClosing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        #endregion

        #region 컨텍스트 메뉴 이벤트





        #endregion

        #endregion

        #region 디비 연결


        #region 콤보


        #endregion

        #region 조회



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
        /// Select_SBC_ITEM_COMMON : Item LIST Combo
        /// </summary>
        /// <param name="arg_itemcd"></param>
        /// <param name="arg_groupcd"></param>
        /// <param name="arg_itemname1"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable Select_SBC_ITEM_COMMON(string arg_itemcd, string arg_groupcd, string arg_itemname1, string arg_useyn)
        {

            COM.OraDB OraDB = new COM.OraDB();

            DataSet ds_ret;

            OraDB.ReDim_Parameter(5);

            OraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_COMMON";

            OraDB.Parameter_Name[0] = "ARG_ITEM_CD";
            OraDB.Parameter_Name[1] = "ARG_GROUP_CD";
            OraDB.Parameter_Name[2] = "ARG_ITEM_NAME1";
            OraDB.Parameter_Name[3] = "ARG_USE_YN";
            OraDB.Parameter_Name[4] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_itemcd;
            OraDB.Parameter_Values[1] = arg_groupcd;
            OraDB.Parameter_Values[2] = arg_itemname1;
            OraDB.Parameter_Values[3] = arg_useyn;
            OraDB.Parameter_Values[4] = "";


            OraDB.Add_Select_Parameter(true);

            ds_ret = OraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[OraDB.Process_Name];
        }



        /// <summary>
        /// Select_SBC_SPEC_COMMON : Sepcification LIST Combo
        /// </summary>
        /// <param name="arg_specdiv"></param>
        /// <param name="arg_specname"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable Select_SBC_SPEC_COMMON(string arg_specdiv, string arg_specname, string arg_useyn)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(4);

            MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC_COMMON";

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
        /// Select_SBC_SPEC_COMMON : Sepcification LIST Combo
        /// </summary>
        /// <param name="arg_specdiv"></param>
        /// <param name="arg_specname"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable Select_SBC_SPEC_CD_COMMON(string arg_specdiv, string arg_speccd, string arg_specname, string arg_useyn)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(5);

            MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC_CD_COMMON";

            MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
            MyOraDB.Parameter_Name[1] = "ARG_SPEC_CD";
            MyOraDB.Parameter_Name[2] = "ARG_SPEC_NAME";
            MyOraDB.Parameter_Name[3] = "ARG_USE_YN";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_specdiv;
            MyOraDB.Parameter_Values[1] = arg_speccd;
            MyOraDB.Parameter_Values[2] = arg_specname;
            MyOraDB.Parameter_Values[3] = arg_useyn;
            MyOraDB.Parameter_Values[4] = "";


            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }



        /// <summary>
        /// Select_SBC_COLOR_COMMON : Color LIST Combo
        /// </summary>
        /// <param name="arg_colorcd"></param>
        /// <param name="arg_colorname"></param>
        /// <param name="arg_useyn"></param>
        /// <returns></returns>
        public static DataTable Select_SBC_COLOR_COMMON(string arg_colorcd, string arg_colorname, string arg_useyn)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(4);

            MyOraDB.Process_Name = "PKG_SBC_COLOR.SELECT_SBC_COLOR_COMMON";

            MyOraDB.Parameter_Name[0] = "ARG_COLOR_CD";
            MyOraDB.Parameter_Name[1] = "ARG_COLOR_NAME";
            MyOraDB.Parameter_Name[2] = "ARG_USE_YN";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_colorcd;
            MyOraDB.Parameter_Values[1] = arg_colorname;
            MyOraDB.Parameter_Values[2] = arg_useyn;
            MyOraDB.Parameter_Values[3] = "";


            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }






        #endregion




        #endregion





    }
}

