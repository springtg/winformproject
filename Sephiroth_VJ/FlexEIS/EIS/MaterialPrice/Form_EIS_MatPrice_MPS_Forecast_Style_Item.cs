using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;


namespace FlexEIS.EIS.MaterialPrice
{
    public partial class  Form_EIS_MatPrice_MPS_Forecast_Style_Item : COM.APSWinForm.Form_Top
    {


        #region 생성자


        private System.IO.MemoryStream _memoryStream;



        public  Form_EIS_MatPrice_MPS_Forecast_Style_Item()
        {
            InitializeComponent();


            //Init_Form();
             
        }



        public static string _Factory = "";
        public static string _PlanMonth = "";
        public static string _LineGroup = "";
        public static string _LineCd = "";
        public static string _StyleCd = "";
        public static string _OBSId = "";
        public static string _OBSType = "";



        public Form_EIS_MatPrice_MPS_Forecast_Style_Item(string arg_factory, 
            string arg_plan_month, 
            string arg_line_group, 
            string arg_line_cd,
            string arg_style_cd,
            string arg_obs_id,
            string arg_obs_type)
        {
            InitializeComponent();


            //Init_Form();


            _Factory = arg_factory;
            _PlanMonth = arg_plan_month;
            _LineGroup = arg_line_group;
            _LineCd = arg_line_cd;
            _StyleCd = arg_style_cd;
            _OBSId = arg_obs_id;
            _OBSType = arg_obs_type;


        }



        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();

        


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


                ////Title
                //this.Text = "스타일별 차월 자재비 예측 - 아이템";
                //lbl_MainTitle.Text = "스타일별 차월 자재비 예측 - 아이템";


                Init_Grid();

                Init_Control();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// 
        /// </summary>
        private void Init_Grid()
        {


            fgrid_DM.Set_Grid("EIS_MATPRICE_MPS_FORECAST_STYLE_DM", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_DM.Styles.Alternate.BackColor = Color.Empty;
            fgrid_DM.ExtendLastCol = false;
            fgrid_DM.AllowSorting = AllowSortingEnum.None;
            fgrid_DM.AllowDragging = AllowDraggingEnum.None;
            fgrid_DM.Font = new Font("Verdana", 8);

            fgrid_Item.Set_Grid("EIS_MATPRICE_MPS_FORECAST_STYLE_ITEM", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Item.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Item.ExtendLastCol = false;
            fgrid_Item.AllowSorting = AllowSortingEnum.None;
            fgrid_Item.AllowDragging = AllowDraggingEnum.None;
            fgrid_Item.Font = new Font("Verdana", 8);
          


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



            // Last update 조회
            Display_LastUpdateDate();




            // item group type
            DataTable dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

            // import division
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxLocalLLTDivision);  // "SBP13";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ImportDiv, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Name);



            dt_ret.Dispose();


        }




        /// <summary>
        /// Display_LastUpdateDate : Last update 조회
        /// </summary>
        private void Display_LastUpdateDate()
        {


            string table_string = "EMM_MPS_FORECAST_USAGE";

            string where_string = @"FACTORY = '" + _Factory + @"'"
                                + @" AND SUBSTR(PLAN_YMD, 1, 6) = '" + _PlanMonth.Replace("-", "") + @"'";


            lbl_LastUpdate2.Text = ClassLib.ComFunction.Display_LastUpdateDate(table_string, where_string);

        }





        #endregion

        #region 조회


         


        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {

            //cmb_itemGroup.SelectedIndex = -1;
            //txt_itemGroup.Text = "";
            //txt_itemCode.Text = "";
            //txt_itemName.Text = "";


            fgrid_DM.ClearAll();
            fgrid_Item.ClearAll();

        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {


            string item_group = _itemGroupCode;
            string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
            string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
            string import_div = ClassLib.ComFunction.Empty_Combo(cmb_ImportDiv, " ");

            

            DataSet ds_ret = SELECT_MPS_FORECAST_STYLE_ITEM(_Factory, _PlanMonth, _LineGroup, _LineCd, _StyleCd, _OBSId, _OBSType, item_group, item_cd, item_name, import_div);
            DataTable dt_dm = ds_ret.Tables[0];
            DataTable dt_item = ds_ret.Tables[1];

            fgrid_DM.Display_Grid(dt_dm, false);
            fgrid_Item.Display_Grid(dt_item, false);




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

                fgrid_Item.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "스타일별 차월 자재비 예측 - 아이템", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



        #endregion

        #region 그리드 이벤트 메서드


         
        #endregion

        #region 버튼 및 기타 이벤트 메서드



        /// <summary>
        /// _itemGroupCode : 
        /// </summary>
        private string _itemGroupCode = " ";

        /// <summary>
        /// Event_cmb_itemGroup_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_itemGroup_SelectedValueChanged()
        {

            if (cmb_itemGroup.SelectedIndex != -1)
            {
                btn_groupSearch.Enabled = true;
                txt_itemGroup.Text = "";
                _itemGroupCode = cmb_itemGroup.SelectedValue.ToString();

            }
            else
            {

                btn_groupSearch.Enabled = false;
                txt_itemGroup.Text = "";
                _itemGroupCode = " ";
            }

        }



        /// <summary>
        /// Event_btn_groupSearch_Click : 
        /// </summary>
        private void Event_btn_groupSearch_Click()
        {
            string item_group = cmb_itemGroup.SelectedValue.ToString();

            EIS.Common.Pop_ItemGroupSearchAll pop_form = new EIS.Common.Pop_ItemGroupSearchAll(item_group);
            pop_form.ShowDialog();

            _itemGroupCode = COM.ComVar.Parameter_PopUp[3];
            txt_itemGroup.Text = COM.ComVar.Parameter_PopUp[4];

            pop_form.Dispose();
        }



        private void Event_cmb_ImportDiv_SelectedValueChanged()
        {
        }



        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드


 

        #endregion



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
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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

 

        #endregion

        #region 버튼 및 기타 이벤트


        #region 버튼클릭시 이미지변경


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }




        #endregion


        private void  Form_EIS_MatPrice_MPS_Forecast_Style_Item_Load(object sender, EventArgs e)
        {
            Init_Form();
        }


        private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_itemGroup_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }




        private void btn_groupSearch_Click(object sender, System.EventArgs e)
        {

            try
            {
                Event_btn_groupSearch_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cmb_ImportDiv_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Event_cmb_ImportDiv_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_ImportDiv_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// SELECT_MPS_FORECAST_STYLE_ITEM : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_month"></param>
        /// <param name="arg_line_group"></param>
        /// <param name="arg_line_cd"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_obs_id"></param>
        /// <param name="arg_obs_type"></param>
        /// <param name="arg_item_group"></param>
        /// <param name="arg_item_cd"></param>
        /// <param name="arg_item_name"></param>
        /// <param name="arg_import_div"></param>
        /// <returns></returns>
        private DataSet SELECT_MPS_FORECAST_STYLE_ITEM(string arg_factory, 
            string arg_plan_month,
            string arg_line_group, 
            string arg_line_cd,
            string arg_style_cd, 
            string arg_obs_id, 
            string arg_obs_type, 
            string arg_item_group, 
            string arg_item_cd, 
            string arg_item_name,
            string arg_import_div)
        {
            try
            {


                #region MPS 표준원가 예측 데이터 조회 - DM 현황 조회


                MyOraDB.ReDim_Parameter(8);



                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_STYLE_DM";



                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";


                

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_line_group;
                MyOraDB.Parameter_Values[3] = arg_line_cd;
                MyOraDB.Parameter_Values[4] = arg_style_cd;
                MyOraDB.Parameter_Values[5] = arg_obs_id;
                MyOraDB.Parameter_Values[6] = arg_obs_type;
                MyOraDB.Parameter_Values[7] = "";


                MyOraDB.Add_Select_Parameter(true);



                #endregion

                #region MPS 표준원가 예측 데이터 조회 - item 단가 조회


                MyOraDB.ReDim_Parameter(12);



                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_STYLE_ITEM";



                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[7] = "ARG_GROUP_CD";
                MyOraDB.Parameter_Name[8] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[9] = "ARG_ITEM_NAME";
                MyOraDB.Parameter_Name[10] = "ARG_IMPORT_DIV";
                MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

               


                //03.DATA TYPE 정의
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
                MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_month;
                MyOraDB.Parameter_Values[2] = arg_line_group;
                MyOraDB.Parameter_Values[3] = arg_line_cd;
                MyOraDB.Parameter_Values[4] = arg_style_cd;
                MyOraDB.Parameter_Values[5] = arg_obs_id;
                MyOraDB.Parameter_Values[6] = arg_obs_type;
                MyOraDB.Parameter_Values[7] = arg_item_group;
                MyOraDB.Parameter_Values[8] = arg_item_cd;
                MyOraDB.Parameter_Values[9] = arg_item_name;
                MyOraDB.Parameter_Values[10] = arg_import_div;
                MyOraDB.Parameter_Values[11] = "";



                MyOraDB.Add_Select_Parameter(false);

              

                #endregion


                
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;


            }
            catch
            {
                return null;
            }

        }
      



        /// <summary>
        /// SELECT_MPS_FORECAST_STYLE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_plan_ymd"></param>
        /// <param name="arg_line_gorup"></param>
        /// <param name="arg_line_cd"></param>
        /// <param name="arg_obs_type"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_MPS_FORECAST_STYLE(string arg_factory, 
            string arg_plan_ymd, 
            string arg_line_gorup, 
            string arg_line_cd,
            string arg_obs_type,
            string arg_style_cd)
        {

            try
            {

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_FORECAST.SELECT_MPS_FORECAST_STYLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

              

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_ymd;
                MyOraDB.Parameter_Values[2] = arg_line_gorup;
                MyOraDB.Parameter_Values[3] = arg_line_cd;
                MyOraDB.Parameter_Values[4] = arg_obs_type;
                MyOraDB.Parameter_Values[5] = arg_style_cd;
                MyOraDB.Parameter_Values[6] = "";


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

