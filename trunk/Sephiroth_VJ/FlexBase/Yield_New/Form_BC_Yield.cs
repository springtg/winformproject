using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.Win.C1FlexGrid;
using Microsoft.Office.Core;


namespace FlexBase.Yield_New
{
    public partial class Form_BC_Yield : COM.PCHWinForm.Form_Top_Light
    {

        #region 생성자


        public Form_BC_Yield()
        {
            InitializeComponent();



            // 화면 그려질 때 부터 숨기기 위함
            panel_Main_Excel.Visible = false;
            panel_Main_Main_Bottom.Visible = false;


        }


        #endregion

        #region 변수 정의


        COM.OraDB MyOraDB = new COM.OraDB();


        // Grid 표시 되는 행 타입
        public string _RowType_Semigood = "S";
        public string _RowType_Component = "C";
        public string _RowType_JointMaterial = "J";
        public string _RowType_Material = "M";


        // 사이즈 자재인 경우 Specification Code 별 색깔 구분 
        private Color _Color_SizeSpecOdd = ClassLib.ComVar.ClrSel_Green;
        private Color _Color_SizeSpecEven = ClassLib.ComVar.ClrSel_Yellow;
        private Color _Color_SizeSpecCurrent;


        // component 생성 기본 범위 : 순서가 중요하므로
        private int _Component_Seq_Range = 100000;


        // 임가공 구조 중 원자재 단일 구조
        private string _JointBOM_Only_Material = "00005";

        
        // 기본 spec : 사이즈 아이템, 임가공 아이템에 적용
        private string _SpecCd_Default = "00000";
        private string _SpecName_Default = "NOTHING";


        // 아이템 선택 팝업
        FlexBase.Yield_New.Pop_Yield_Select_Material pop_select_material = null;



        // 임가공 공정 중 컬러 코드 자동 할당 제외 항목
        private string _SubLimation = "02J12000";
        private string _SubLimationPaper = "01D11000";
        private string _Printing = "02J14000";
        private string _Painting = "02J08000";
        private string _ShieldGraphic = "02J26000";
        private string _HeatTransfer = "02J24000";
        private string _PuffScreen = "02J25000";


        // 임가공 공정 중 하위 원자재 spec 그대로 적용 처리 항목
        private string _Stiker = "02J11000";
        private string _HotMelt = "02J04000";
        private string _RubberLamination = "02J10000";
        private string _BallHotMelt = "02J20000";
        private string _DotHotMelt = "02J21000";

        // 임가공 공정 중 하위 원자재 spec 모두 같을 때 적용 처리
        private string _Lamination = "02J06000";


        // 임가공 공정 중 원자재
        private string _RawMaterial = "02J13000";


        // excel loading key column index
        private int _Excel_Ix_Component = 0;          //F1
        private int _Excel_Ix_ExcelSizeStart = 1;     //F2
        private int _Excel_Ix_Material = 5;			  //F6
        private int _Excel_Ix_Material_1 = 6;		  //F7
        private int _Excel_Ix_SpecUnit = 15;		  //F16
        private int _Excel_Ix_Color = 17;			  //F18
        private int _Excel_Ix_CommonYieldValue = 23;  //F24


        // main 그리드 user data tag 표시 symbol (spec_cd | spec_name)
        private string _UserData_Spec_Symbol = @"|";


        // yield 행 정의
        private int _Value_Row_Yield = -1;
        private int _Value_Row_SpecCode = -1;
        private int _Value_Row_SpecName = -1;


        // 메인 그리드 선택 시 채산 값 보여주는 이벤트 실행 여부        
        private bool _Run_Event_Display_Value = true;

        // excel 그리드에서 마우스 이동 컬럼 저장 (checkbox 포커스 문제 때문)
        private int _MoveMouseCol;

        // 수정 들어가는 컬럼에 플래그 설정해서 excel 그리드에서 마우스 이동 컬럼 저장 못하도록
        // 한번 수정 들어가면 마우스 움직임은 의미가 없으므로
        private bool _MoveMouseAfterEdit_Start = false;


        // 재 조회 된 경우 component마다 기존 작업된 트리 뷰 옵션 설정 하기 위함
        DataTable _DT_Component_ViewDepth = null;



        #endregion

        #region 이벤트 처리


        private void Form_BC_Yield_Load(object sender, EventArgs e)
        { 
            // 초기화
            Init_Form();  
        }


        private void Form_BC_Yield_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 체크 아웃 확인
            Closing_Form(e);
        }

       


        #region 콘트롤 이벤트



        /// <summary>
        /// chk_CheckInOut_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_CheckInOut_CheckedChanged(object sender, EventArgs e)
        {

            Event_chk_CheckInOut_CheckedChanged();

        }


        /// <summary>
        /// chk_Excel_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Excel_CheckedChanged(object sender, EventArgs e)
        {

            Event_chk_Excel_CheckedChanged();

        }



        /// <summary>
        /// Event_chk_Value_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Value_CheckedChanged(object sender, EventArgs e)
        {

            Event_chk_Value_CheckedChanged();

        }




        /// <summary>
        /// 스타일 콤보박스 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter) return;

            Event_txt_StyleCd_KeyUp(); 

        } 


        /// <summary>
        /// cmb_Factory_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {

            Event_cmb_Factory_SelectedValueChanged(); 

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
        /// display depth 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rad_CheckedChanged(object sender, System.EventArgs e)
        {

            Event_rad_CheckedChanged(sender); 
            
        }



        /// <summary>
        /// Event_btn_FileOpen_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FileOpen_Click(object sender, EventArgs e)
        {

            Event_btn_FileOpen_Click(); 

        }



        /// <summary>
        /// Event_btn_ExcelCondition_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExcelCondition_Click(object sender, EventArgs e)
        {

            Event_btn_ExcelCondition_Click(); 

        }




        /// <summary>
        /// btn_StatusConfirm_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StatusConfirm_Click(object sender, EventArgs e)
        {

            Event_btn_StatusConfirm_Click(); 

        }



        /// <summary>
        /// btn_Copy_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Event_btn_Copy_Click();
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
        /// btn_ViewHistory_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewHistory_Click(object sender, EventArgs e)
        {
            Event_btn_ViewHistory_Click();
        }


        /// <summary>
        /// 
        /// </summary>btn_CheckStatus_Click : 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CheckStatus_Click(object sender, EventArgs e)
        {
            Event_btn_CheckStatus_Click();
        }


        /// <summary>
        /// btn_CheckYield_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CheckYield_Click(object sender, EventArgs e)
        {
            Event_btn_CheckYield_Click();
        }


        /// <summary>
        /// btn_YieldInspection_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_YieldInspection_Click(object sender, EventArgs e)
        {
            Event_btn_YieldInspection_Click();
        }


        /// <summary>
        /// Event_btn_BackupData_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BackupData_Click(object sender, EventArgs e)
        {
            Event_btn_BackupData_Click();
        }


        /// <summary>
        /// btn_RestoreData_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RestoreData_Click(object sender, EventArgs e)
        {
            Event_btn_RestoreData_Click();
        }


       
        #endregion 

        #region 툴바 이벤트


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
            Event_tbtn_Search_Click(true, true);
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
        /// tbtn_Print_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Event_tbtn_Print_Click();
        }



        #endregion

        #region 그리드 이벤트


        /// <summary>
        /// Event_fgrid_Yield_MouseMove_Tooltip : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_MouseMove(object sender, MouseEventArgs e)
        {
            Event_fgrid_Yield_MouseMove_Tooltip(sender, e);
        } 


        /// <summary>
        /// fgrid_Yield_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_Click(object sender, EventArgs e)
        {
            Event_fgrid_Yield_Click();
        }



        /// <summary>
        /// fgrid_Yield_AfterCollapse : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_AfterCollapse(object sender, RowColEventArgs e)
        {
            Event_fgrid_Yield_AfterCollapse(e);
        }



        /// <summary>
        /// fgrid_Yield_StartEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_StartEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Yield_StartEdit();
        }


        /// <summary>
        /// fgrid_Yield_AfterEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_AfterEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Yield_AfterEdit();
        }



        /// <summary>
        /// fgrid_Yield_KeyDown : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_KeyDown(object sender, KeyEventArgs e)
        {
            Event_fgrid_Yield_KeyDown(e);
        }



        /// <summary>
        /// Event_fgrid_Yield_AfterSelChange : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_AfterSelChange(object sender, RangeEventArgs e)
        {
            Event_fgrid_Yield_AfterSelChange(e);
        }



        /// <summary>
        /// Event_fgrid_Yield_AfterResizeColumn : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Yield_AfterResizeColumn(object sender, RowColEventArgs e)
        {
            Event_fgrid_Yield_AfterResizeColumn(e);
        }




        /// <summary>
        /// fgrid_Excel_MouseHoverCell : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Excel_MouseHoverCell(object sender, EventArgs e)
        {
            Event_fgrid_Excel_MouseHoverCell();
        }


        /// <summary>
        /// Event_fgrid_Excel_StartEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Excel_StartEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Excel_StartEdit();
        }



        /// <summary>
        /// Event_fgrid_Excel_AfterEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Excel_AfterEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Excel_AfterEdit();
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

    


        #endregion

        #region 컨텍스트 메뉴



        /// <summary>
        /// contextMenu_Yield_Opening : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenu_Yield_Opening(object sender, CancelEventArgs e)
        {
            Event_contextMenu_Yield_Opening();
        }


        /// <summary>
        /// menuItem_InsertComponent_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_InsertComponent_Click(object sender, EventArgs e)
        {
            Event_menuItem_InsertComponent_Click();
        }


        /// <summary>
        /// menuItem_InsertRawMat_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_InsertRawMat_Click(object sender, EventArgs e)
        {
            Event_menuItem_InsertRawMat_Click();
        }



        /// <summary>
        /// menuItem_InsertJointRaw_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_InsertJointRaw_Click(object sender, EventArgs e)
        {
            Event_menuItem_InsertJointRaw_Click();
        }



        /// <summary>
        /// menuItem_SetComp_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_SetComp_Click(object sender, EventArgs e)
        {
            Event_menuItem_SetComp_Click();
        }

    

        /// <summary>
        /// menuItem_SetMat_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_SetMat_Click(object sender, EventArgs e)
        {
            Event_menuItem_SetMat_Click();
        }



        /// <summary>
        /// Event_menuItem_DeleteMat_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_DeleteMat_Click(object sender, EventArgs e)
        {
            Event_menuItem_DeleteMat_Click();
        }


        /// <summary>
        /// Event_menuItem_DeleteCancelMat_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_DeleteCancelMat_Click(object sender, EventArgs e)
        {
            Event_menuItem_DeleteCancelMat_Click();
        }



        /// <summary>
        /// Event_menuItem_InsertRawMat_Excel_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_InsertRawMat_Excel_Click(object sender, EventArgs e)
        {
            Event_menuItem_InsertRawMat_Excel_Click();
        }



        /// <summary>
        /// Event_menuItem_InsertJointMat_Excel_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_InsertJointMat_Excel_Click(object sender, EventArgs e)
        {
            Event_menuItem_InsertJointMat_Excel_Click();
        }



        /// <summary>
        /// Event_menuItem_CutComponent_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_CutComponent_Click(object sender, EventArgs e)
        {
            Event_menuItem_CutComponent_Click();
        }



        /// <summary>
        /// Event_menuItem_PasteComponent_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_PasteComponent_Click(object sender, EventArgs e)
        {
            Event_menuItem_PasteComponent_Click();
        }



        /// <summary>
        /// menuItem_CopyYieldValue_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_CopyYieldValue_Click(object sender, EventArgs e)
        {
            Event_menuItem_CopyYieldValue_Click();
        }



        /// <summary>
        /// menuItem_PasteYieldValue_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_PasteYieldValue_Click(object sender, EventArgs e)
        {
            Event_menuItem_PasteYieldValue_Click();
        }



        /// <summary>
        /// menuItem_CopyComponent_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_CopyComponent_Click(object sender, EventArgs e)
        {
            Event_menuItem_CopyComponent_Click();
        }



        /// <summary>
        /// menuItem_DeleteCopyComponent_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_DeleteCopyComponent_Click(object sender, EventArgs e)
        {
            Event_menuItem_DeleteCopyComponent_Click();
        }



        /// <summary>
        /// menuItem_ChangeMatInsert_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_ChangeMatInsert_Click(object sender, EventArgs e)
        {
            Event_menuItem_ChangeMatInsert_Click();
        }



        /// <summary>
        /// menuItem_ChangeMatUpdate_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_ChangeMatUpdate_Click(object sender, EventArgs e)
        {
            Event_menuItem_ChangeMatUpdate_Click();
        }



        /// <summary>
        /// menuItem_ChangeMatDelete_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_ChangeMatDelete_Click(object sender, EventArgs e)
        {
            Event_menuItem_ChangeMatDelete_Click();
        }




        #endregion


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


                //#region 메모리 정리

                //ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
                //ClassLib.MemoryManagement.FlushMemory();

                //#endregion



                //Title
                this.Text = "Yield Register";
                lbl_MainTitle.Text = "Yield Register";

                ClassLib.ComFunction.SetLangDic(this);



                // Check In/Out 에 대한 콘트롤 권한 부여
                if (chk_CheckInOut.Checked)
                {
                    Control_Enable(true);
                }
                else
                {
                    Control_Enable(false);
                }

                 
                //combobox setting
                Init_Control();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 


        /// <summary>
        /// Control_Enable : Check In/Out 에 대한 콘트롤 권한 부여
        /// </summary>
        /// <param name="arg_enable"></param>
        private void Control_Enable(bool arg_enable)
        {


            try
            {


                cmb_Factory.Enabled = !arg_enable;
                txt_StyleCd.Enabled = !arg_enable;
                cmb_StyleCd.Enabled = !arg_enable;


                //fgrid_Yield.AllowEditing = arg_enable;
                fgrid_Value.AllowEditing = arg_enable;


                btn_Copy.Enabled = arg_enable;


                chk_Excel.CheckState = CheckState.Unchecked;

                
                if (arg_enable)
                {
                    cmb_Factory.EditorBackColor = Color.FromKnownColor(KnownColor.Control);
                    cmb_StyleCd.EditorBackColor = Color.FromKnownColor(KnownColor.Control);


                    if (ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
                    {
                        chk_Excel.Visible = arg_enable;
                        cmb_YieldStatus.Enabled = arg_enable;
                        btn_StatusConfirm.Visible = arg_enable;

                        btn_GetSpecBySize.Enabled = arg_enable;
                        btn_GetSizeGroup.Enabled = arg_enable;
                        btn_GetSizeGroup_Item.Enabled = arg_enable;
                        btn_GetSpecGroup.Enabled = arg_enable;

                    }
                    else
                    {
                        chk_Excel.Visible = !arg_enable;
                        cmb_YieldStatus.Enabled = !arg_enable;
                        btn_StatusConfirm.Visible = !arg_enable;

                        btn_GetSpecBySize.Enabled = !arg_enable;
                        btn_GetSizeGroup.Enabled = !arg_enable;
                        btn_GetSizeGroup_Item.Enabled = !arg_enable;
                        btn_GetSpecGroup.Enabled = !arg_enable;

                    }


                }
                else
                {
                    cmb_Factory.EditorBackColor = Color.FromKnownColor(KnownColor.Window);
                    cmb_StyleCd.EditorBackColor = Color.FromKnownColor(KnownColor.Window);

                    chk_Excel.Visible = arg_enable;
                    cmb_YieldStatus.Enabled = arg_enable;
                    btn_StatusConfirm.Visible = arg_enable;

                    btn_BackupData.Enabled = arg_enable;
                    btn_RestoreData.Enabled = arg_enable;
                    btn_CheckStatus.Enabled = arg_enable;

                    btn_GetSpecBySize.Enabled = arg_enable;
                    btn_GetSizeGroup.Enabled = arg_enable;
                    btn_GetSizeGroup_Item.Enabled = arg_enable;
                    btn_GetSpecGroup.Enabled = arg_enable;


                } // end if (arg_enable)




                if (tbtn_Save.Enabled)
                {
                    chk_CheckInOut.Visible = true;
                }
                else
                {
                    chk_CheckInOut.Visible = false;
                }



                if (ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
                {

                    fgrid_Yield.AllowEditing = arg_enable;

                    btn_BackupData.Visible = true;
                    btn_RestoreData.Visible = true;
                    //btn_CheckStatus.Visible = true;

                    btn_BackupData.Enabled = true;
                    btn_RestoreData.Enabled = true;
                    //btn_CheckStatus.Enabled = true;

                }
                else
                {

                    // [set material] context menu로만 material 추가 시키기 위함
                    fgrid_Yield.AllowEditing = false;
                    
                    btn_BackupData.Visible = false;
                    btn_RestoreData.Visible = false;
                    //btn_CheckStatus.Visible = false;

                    btn_BackupData.Enabled = false;
                    btn_RestoreData.Enabled = false;
                    //btn_CheckStatus.Enabled = false;


                }



                txt_AllSizeValue.Enabled = arg_enable;
                //btn_GetSpecBySize.Enabled = arg_enable;
                //btn_GetSizeGroup.Enabled = arg_enable;
                //btn_GetSizeGroup_Item.Enabled = arg_enable;
                //btn_GetSpecGroup.Enabled = arg_enable;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Control_Enable", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                tbtn_New.Enabled = false;
                tbtn_Delete.Enabled = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled = false;


                // default : grid hide
                chk_Value.CheckState = CheckState.Unchecked;

                // default : display component level
                rad_Comp.Checked = true;



                // 그리드 설정 
                fgrid_Yield.Set_Grid("SBC_YIELD_NEW", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Yield.Font = new Font("Verdana", 8);
                fgrid_Yield.Styles.Frozen.BackColor = Color.White;
                fgrid_Yield.Styles.Alternate.BackColor = Color.White;
                fgrid_Yield.KeyActionEnter = KeyActionEnum.MoveAcross;
                fgrid_Yield.KeyActionTab = KeyActionEnum.MoveAcross;
                fgrid_Yield.AllowDragging = AllowDraggingEnum.None;
                fgrid_Yield.AllowSorting = AllowSortingEnum.None;
                fgrid_Yield.ExtendLastCol = false;
                fgrid_Yield.Rows[2].Visible = false;
                Set_Action_Image();


                //SBC_YIELD_EXCEL_NEW
                fgrid_Excel.Set_Grid("SBC_YIELD_LOADING_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                fgrid_Excel.Font = new Font("Verdana", 8);
                fgrid_Excel.Styles.Frozen.BackColor = Color.White;
                fgrid_Excel.Styles.Alternate.BackColor = Color.White;
                fgrid_Excel.KeyActionEnter = KeyActionEnum.MoveAcross;
                fgrid_Excel.KeyActionTab = KeyActionEnum.MoveAcross;
                fgrid_Excel.AllowDragging = AllowDraggingEnum.None;
                fgrid_Excel.AllowSorting = AllowSortingEnum.None;
                fgrid_Excel.ExtendLastCol = false;
                fgrid_Excel.Set_Action_Image(img_Action);


                fgrid_Value.Set_Grid("SBC_YIELD_VALUE_NEW", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Value.Font = new Font("Verdana", 8);
                fgrid_Value.Styles.Frozen.BackColor = Color.White;
                fgrid_Value.Styles.Alternate.BackColor = Color.White;
                fgrid_Value.AllowSorting = AllowSortingEnum.None;
                fgrid_Value.SelectionMode = SelectionModeEnum.CellRange;
                fgrid_Value.AllowDragging = AllowDraggingEnum.None;
                fgrid_Value.AllowSorting = AllowSortingEnum.None;
                fgrid_Value.ExtendLastCol = false;
                fgrid_Value.Rows[2].Visible = false;

                 


                DataTable dt_ret = null;

                // 공장코드
                dt_ret = COM.ComFunction.Select_Factory_List();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

                // Value Status ComboBox Add Items 
                dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxYieldStatus);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_YieldStatus, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Name);
                //cmb_YieldStatus.SelectedValue = style 정보와 함께 세팅
                

                dt_ret.Dispose(); 



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Set_Action_Image : 
        /// </summary>
        /// <returns></returns>
        private Hashtable Set_Action_Image()
        {

            Hashtable Imgmap = new Hashtable();

            try
            {
                
                Imgmap.Clear();

                Imgmap.Add("I", img_Action.Images[0]);
                Imgmap.Add("D", img_Action.Images[1]);
                Imgmap.Add("U", img_Action.Images[2]);
                Imgmap.Add("M", img_Action.Images[3]);


                fgrid_Yield.Cols[0].ImageMap = Imgmap;
                fgrid_Yield.Cols[0].ImageAndText = false;

                return Imgmap;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Set_Action_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }



        /// <summary>
        /// Closing_Form : 체크 아웃 확인
        /// </summary>
        private void Closing_Form(FormClosingEventArgs e)
        {

            try
            {

                bool exist_modify = Check_NotSave_Data("Close");
                
                if (exist_modify)
                {
                    e.Cancel = true;
                }


                if (chk_CheckInOut.Checked)
                {
                    ClassLib.ComFunction.User_Message("Need Check Out.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Closing_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                e.Cancel = true;
            }

        }




        #endregion

        #region 콘트롤 이벤트


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


        // check in, out class
        // check in 일 때만 객체 생성
        ClassLib.Class_Check_InOut class_check_inout;

        // check box로 처리되므로 이벤트 실행 하지 않기 위함
        private bool _CheckInFail = false;
        private bool _CheckOutFail = false;


        /// <summary>
        /// Event_chk_CheckInOut_CheckedChanged : 
        /// </summary>
        private void Event_chk_CheckInOut_CheckedChanged()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1)
                {
                    chk_CheckInOut.CheckState = CheckState.Unchecked;
                    return;
                }



                // check box로 처리되므로 이벤트 실행 하지 않기 위함
                if (chk_CheckInOut.Checked)  // check in
                {
                    if (_CheckOutFail) return;
                }
                else
                {
                    if (_CheckInFail) return;
                }


                //---------------------------------------------------------------------------
                // check out 일 경우 저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
                //---------------------------------------------------------------------------
                if (!chk_CheckInOut.Checked)
                {


                    bool exist_modify = Check_NotSave_Data("Check Out");

                    if (exist_modify)
                    {
                        _CheckOutFail = true;

                        chk_CheckInOut.CheckState = CheckState.Checked;

                        return;
                    }

                }
                //---------------------------------------------------------------------------


                this.Cursor = Cursors.WaitCursor;


                //ClassLib.Class_Check_InOut class_check_inout = new FlexBase.ClassLib.Class_Check_InOut();

                if (chk_CheckInOut.Checked)  // check in
                {
                    class_check_inout = new FlexBase.ClassLib.Class_Check_InOut();
                }


                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
                string where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd + @"' AND COMPONENT_CD LIKE 'C%'";

                class_check_inout._CheckDivision = (chk_CheckInOut.Checked) ? "I" : "O";
                class_check_inout._CheckFactory = ClassLib.ComVar.This_Factory;
                class_check_inout._CheckUser = ClassLib.ComVar.This_User;
                class_check_inout._CheckRemark = (chk_CheckInOut.Checked) ? "main (yield register)" : "check out";
                class_check_inout._CheckWhere = where;
                class_check_inout._ShowMessage = true;
                class_check_inout._Factory = factory;
                class_check_inout._StyleCd = style_cd;
                class_check_inout._IncludeInfoTable = "Y";
                class_check_inout._IncludeValueTable = "Y";
                class_check_inout._IncludeHistoryTable = "Y";

                bool check_ok = class_check_inout.Run_Check_InOut();


                if (chk_CheckInOut.Checked)  // check in
                {

                    if (check_ok)
                    {
                        Control_Enable(true);

                        _CheckInFail = false;

                    }
                    else
                    {
                        Control_Enable(false);

                        _CheckInFail = true;

                        chk_CheckInOut.CheckState = CheckState.Unchecked;
                    }


                }
                else  // check out
                {

                    if (check_ok)
                    {
                        Control_Enable(false);

                        _CheckOutFail = false;
                    }
                    else
                    {
                        Control_Enable(true);

                        _CheckOutFail = true;

                        chk_CheckInOut.CheckState = CheckState.Checked;
                    }

                } // end if



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_chk_CheckInOut_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (chk_CheckInOut.Checked)  // check in
                {

                    Control_Enable(false);

                    _CheckInFail = true;

                    chk_CheckInOut.CheckState = CheckState.Unchecked;

                }
                else  // check out
                {

                    Control_Enable(true);

                    _CheckOutFail = true;

                    chk_CheckInOut.CheckState = CheckState.Checked;

                } // end if


            }
            finally
            {
                this.Cursor = Cursors.Default;

            }


        }



        /// <summary>
        /// Event_chk_Excel_CheckedChanged : 
        /// </summary>
        private void Event_chk_Excel_CheckedChanged()
        {

            //txt_File.Text = "";
            //fgrid_Excel.Rows.Count = fgrid_Excel.Rows.Fixed;
            //fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;

            panel_Main_Excel.Visible = chk_Excel.Checked;

        }



        /// <summary>
        /// Event_chk_Value_CheckedChanged : 
        /// </summary>
        private void Event_chk_Value_CheckedChanged()
        {

            panel_Main_Main_Bottom.Visible = chk_Value.Checked;

        }



        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary> 
        public void Event_txt_StyleCd_KeyUp()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1) return;


                //-------------------------------------------------------------------------
                // 기타 콘트롤 초기화 
                cmb_StyleCd.SelectedIndex = -1;
                txt_Gender.Text = "";

                txt_File.Text = "";
                fgrid_Excel.Rows.Count = fgrid_Excel.Rows.Fixed;
                fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
                fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START;
                //-------------------------------------------------------------------------

                string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ");

                DataTable dt_ret = SELECT_SDC_STYLE(factory, style_cd);

                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
                ClassLib.ComCtl.Set_ComboList_Multi(dt_ret, cmb_StyleCd, new int[] { 0, 1, 2, 3, 4, 5 }, false);
                string[] titles = new string[] { "CODE", "NAME", "GENDER", "PRESTO", "MODEL_NAME", "YIELD_STATUS" };
                int[] width = new int[] { 80, 100, 100, 100, 100, 100 };
                bool[] visible = new bool[] { true, true, false, false, false, false };
                ClassLib.ComCtl.SetComboStyle(cmb_StyleCd, titles, width, visible, "NAME");
                cmb_StyleCd.DropDownWidth = 226;



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
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1) return;


                txt_StyleCd.Text = "";
                cmb_StyleCd.SelectedIndex = -1;
                txt_Gender.Text = "";
                cmb_YieldStatus.SelectedIndex = -1;

                txt_File.Text = "";
                fgrid_Excel.Rows.Count = fgrid_Excel.Rows.Fixed;
                fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
                fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_StyleCd_SelectedValueChanged()
        {


            try
            {


                _DT_Component_ViewDepth = null;

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


                //---------------------------------------------------------------------------------------------------
                // 기타 콘트롤 초기화 
                txt_Gender.Text = "";
                cmb_YieldStatus.SelectedIndex = -1;

                txt_File.Text = "";
                fgrid_Excel.Rows.Count = fgrid_Excel.Rows.Fixed;
                fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
                fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START;

                //---------------------------------------------------------------------------------------------------


                //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
                txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
                txt_Gender.Text = cmb_StyleCd.Columns[2].Text + " / " + ((cmb_StyleCd.Columns[3].Text == "N") ? "No" : "Yes");
                cmb_YieldStatus.SelectedValue = cmb_StyleCd.Columns[5].Text;



                //size 세팅
                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
                int col_width = 60;
                
                //main size header
                int col_size_start = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START;
                Display_Size_Head(fgrid_Yield, factory, style_cd, col_width, col_size_start);


                // number 형 셀타입 설정 (예 : 1,234,567.001)
                for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                {
                    fgrid_Yield.Set_CellStyle_Number(i);

                    fgrid_Yield.Cols[i].AllowEditing = false;
                }




                //---------------------------------------------
                //value size header
                //---------------------------------------------
                fgrid_Value.Set_Grid("SBC_YIELD_VALUE_NEW", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Value.Font = new Font("Verdana", 8);
                fgrid_Value.Styles.Frozen.BackColor = Color.White;
                fgrid_Value.Styles.Alternate.BackColor = Color.White;
                fgrid_Value.AllowSorting = AllowSortingEnum.None;
                fgrid_Value.SelectionMode = SelectionModeEnum.CellRange;
                fgrid_Value.AllowDragging = AllowDraggingEnum.None;
                fgrid_Value.AllowSorting = AllowSortingEnum.None;
                fgrid_Value.ExtendLastCol = false;
                fgrid_Value.Rows[2].Visible = false;


                col_size_start = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START;
                Display_Size_Head(fgrid_Value, factory, style_cd, col_width, col_size_start);

                //value size row 생성
                Set_Yield_Value_Row();
                //---------------------------------------------

                
                // 데이터 조회
                Event_tbtn_Search_Click(true, true);


                //---------------------------------------------
                // 재 조회 된 경우 component마다 기존 작업된 트리 뷰 옵션 설정 하기 위함
                // style code 바껴서 첫번째 조회 될 때 생성
                //---------------------------------------------
                _DT_Component_ViewDepth = new DataTable();

                _DT_Component_ViewDepth.Columns.Add(new DataColumn("COMPONENT_CD", typeof(string)));
                _DT_Component_ViewDepth.Columns.Add(new DataColumn("ACTION_FLAG", typeof(string)));
                _DT_Component_ViewDepth.Columns.Add(new DataColumn("COLLAPSED", typeof(bool)));


                DataRow dr = null;


                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {

                    if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;

                    dr = _DT_Component_ViewDepth.NewRow();

                    dr["COMPONENT_CD"] = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    dr["ACTION_FLAG"] = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    dr["COLLAPSED"] = fgrid_Yield.Rows[i].Node.Collapsed;

                    _DT_Component_ViewDepth.Rows.Add(dr);


                } // end for i
                //---------------------------------------------


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Display_Size_Head : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_col_width"></param>
        /// <param name="arg_col_size_start"></param>
        private void Display_Size_Head(COM.FSP arg_fgrid, string arg_factory, string arg_style_cd, int arg_col_width, int arg_col_size_start)
        {


            arg_fgrid.Cols.Count = arg_col_size_start;


            DataTable dt_ret = SELECT_SIZE_HEAD(arg_factory, arg_style_cd);

            if (dt_ret == null || dt_ret.Rows.Count == 0) return;


            arg_fgrid.Cols.Count = arg_fgrid.Cols.Count + dt_ret.Rows.Count;



            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {

                // cs_size 넘버로 표시
                arg_fgrid[0, arg_col_size_start + i] = dt_ret.Rows[i].ItemArray[1];	// col_num (TO_NUMBER(CS_SIZE))
                
                // cs_size 표시
                arg_fgrid[arg_fgrid.Cols.Fixed + 1, arg_col_size_start + i] = dt_ret.Rows[i].ItemArray[0];  // cs_size
                arg_fgrid.Cols[arg_col_size_start + i].Width = arg_col_width;

                // cs_size cm 길이로 order by 해 놓은 cs_size 의 순서
                // 엑셀 로딩할 때 사용하기 위함
                arg_fgrid[2, arg_col_size_start + i] = dt_ret.Rows[i].ItemArray[2];	// col_order

            }



            ////--------------------------------------------------------------------------
            //// cs_size cm 길이로 order by 해 놓은 cs_size 의 순서
            //// 엑셀 로딩할 때 사용하기 위함
            ////-------------------------------------------------------------------------- 
            //string expression = ""; // where
            //string sortOrder = "COL_ORDER"; // order by DESC 아닌 ASC 임
            //DataRow[] foundRows; // 결과는 Row 로 리턴 됨

            //foundRows = dt_ret.Select(expression, sortOrder);


            //for (int i = 0; i < foundRows.Length; i++)
            //{
            //    arg_fgrid[2, arg_col_size_start + i] = foundRows[i][2];	// col_order
            //}
            ////-------------------------------------------------------------------------- 



            arg_fgrid.Rows[arg_fgrid.Cols.Fixed + 1].TextAlign = TextAlignEnum.CenterCenter;



        }



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

            fgrid_Value[_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxDESCRIPTION] = "Value";
            fgrid_Value[_Value_Row_SpecCode, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxDESCRIPTION] = "SPEC_CD";
            fgrid_Value[_Value_Row_SpecName, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxDESCRIPTION] = "Spec";



            CellStyle cellst = fgrid_Value.Styles.Add("NUMBER", fgrid_Value.Rows[_Value_Row_Yield].Style);
            cellst.DataType = typeof(double);
            cellst.Format = "#,##0.##########";
            fgrid_Value.Rows[_Value_Row_Yield].Style = fgrid_Value.Styles["NUMBER"];



            fgrid_Value.Cols.Fixed = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START;
            fgrid_Value.Cols[0].Visible = false;
            fgrid_Value.Rows[_Value_Row_SpecCode].Visible = false;
            fgrid_Value.Rows[_Value_Row_SpecName].TextAlign = TextAlignEnum.RightCenter;
            fgrid_Value.Rows[_Value_Row_SpecName].AllowEditing = false;


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
                //rad_semi.tag = '0'
                //rad_cmp.tag = '1'
                //rad_all.tag = '-1'

                fgrid_Yield.Tree.Show(Convert.ToInt32(src.Tag.ToString()));
                fgrid_Excel.Tree.Show(Convert.ToInt32(src.Tag.ToString()));


                // value 그리드 초기화
                Set_Yield_Value_Row();
                

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_FileOpen_Click : 
        /// </summary>
        private void Event_btn_FileOpen_Click()
        {

            try
            {

                if (openFileDialog_Loading.ShowDialog() == DialogResult.Cancel) return;


                this.Cursor = Cursors.WaitCursor;


                txt_File.Text = openFileDialog_Loading.FileName;



                // excel loading
                Run_Excel_Loading();


                



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_FileOpen_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }


        }



        /// <summary>
        /// Run_Excel_Loading : 
        /// </summary>
        private void Run_Excel_Loading()
        {


            #region 1. Excel Upload -> DataTable


            DataTable step_1_dt = ExcelLoading_Step_1();

            if (step_1_dt == null) return;

            #endregion  

            #region 2. 데이터 시작 부분 추출


            int first_data_row = ExcelLoading_Step_2(step_1_dt);


            #endregion

            #region 3. 채산값 사이즈 시작, 끝 컬럼 추출


            int[] size_col = ExcelLoading_Step_3(step_1_dt, first_data_row);

            int size_start_col = size_col[0];
            int size_end_col = size_col[1];


            #endregion

            #region 4. 주석행 등 필요없는 행 정리 후 데이터 부분 재추출


            DataTable step_4_dt = ExcelLoading_Step_4(step_1_dt, first_data_row, size_start_col, size_end_col);



            #endregion

            #region 5. 윗실, 아랫실 같은 경우 Material 부분으로 재 설정


            DataTable step_5_dt = ExcelLoading_Step_5(step_4_dt);


            #endregion

            #region 6. 필요없는 컬럼 정리 후 데이터 부분 재추출


            //DataTable result_dt = ExcelLoading_Step_6(step_5_dt, size_start_col, size_end_col);

            DataTable result_dt = ExcelLoading_Step_6_1(step_5_dt, size_start_col, size_end_col);


            #endregion

            #region 7. 그리드 조회


            ExcelLoading_Step_7(step_1_dt, result_dt, size_start_col, size_end_col, first_data_row + 1);


            #endregion


            result_dt.Dispose();
            step_5_dt.Dispose();
            step_4_dt.Dispose();
            step_1_dt.Dispose();


        }



        #region Run_Excel_Loading()



        /// <summary>
        /// ExcelLoading_Step_1 : 1. Excel Upload -> DataTable
        /// </summary>
        /// <returns></returns>
        private DataTable ExcelLoading_Step_1()
        {

            string path = txt_File.Text.Trim();
            DataSet ds_ret = ClassLib.ComFunction.Read_Excel(path);
            if (ds_ret == null) return null;


            DataTable dt_ret = ds_ret.Tables[0];
            DataTable dt_new = new DataTable();
            DataRow dr;


            for (int i = 0; i < dt_ret.Columns.Count; i++)
            {
                dt_new.Columns.Add(new DataColumn(i.ToString(), typeof(string)));

            } // end for i



            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                dr = dt_new.NewRow();

                for (int j = 0; j < dt_ret.Columns.Count; j++)
                {
                    dr[j] = dt_ret.Rows[i].ItemArray[j].ToString();
                }

                dt_new.Rows.Add(dr);
            }

            return dt_new;

        }


        /// <summary>
        /// ExcelLoading_Step1 : 2. 데이터 시작 부분 추출
        /// </summary>
        /// <param name="arg_dt"></param>
        /// <returns></returns>
        private int ExcelLoading_Step_2(DataTable arg_dt)
        {

            string first_desc = "COMPONENT";
            string now_desc = "";
            int first_row = 0;


            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                now_desc = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();

                if (now_desc == first_desc)
                {
                    first_row = i;
                    break;
                }


            } // end for i

            return first_row;

        }


        /// <summary>
        /// ExcelLoading_Step_3 : 3. 채산값 사이즈 시작, 끝 컬럼 추출
        /// </summary>
        /// <param name="arg_first_data_row"></param>
        /// <param name="arg_dt"></param>
        /// <returns></returns>
        private int[] ExcelLoading_Step_3(DataTable arg_dt, int arg_first_data_row)
        {

            int allsize_row = arg_first_data_row + 1;

            int size_start_col = 0;
            int size_end_col = 0;


            for (int i = _Excel_Ix_ExcelSizeStart; i < arg_dt.Columns.Count; i++)
            {

                if (arg_dt.Rows[allsize_row].ItemArray[i].ToString().Trim().Equals("")) continue;

                size_start_col = i;
                break;

            } // end for i



            for (int i = size_start_col; i < arg_dt.Columns.Count; i++)
            {

              
                if (i == arg_dt.Columns.Count - 1 && size_end_col == 0)
                {

                    size_end_col = arg_dt.Columns.Count - 1;

                }


                if (!arg_dt.Rows[allsize_row].ItemArray[i].ToString().Trim().Equals("")) continue;

                size_end_col = i - 1;


                break;

            } // end for i




            int[] return_col = new int[2];

            return_col[0] = size_start_col;
            return_col[1] = size_end_col;

            return return_col;


        }



        /// <summary>
        /// ExcelLoading_Step_4 : 4. 주석행 등 필요없는 행 정리 후 데이터 부분 재추출
        /// </summary>
        /// <param name="arg_dt"></param>
        /// <param name="arg_first_data_row"></param> 
        /// <returns></returns>
        private DataTable ExcelLoading_Step_4(DataTable arg_dt, int arg_first_data_row, int arg_size_start_col, int arg_size_end_col)
        {

            string component = "";
            string spec_unit = "";
            string material = "";
            string material_1 = "";
            string common_yield_value = "";

            double temp = 0;
            bool exist_yield = false;
            string first_yield = "";



            DataTable dt_ret = arg_dt.Clone();

            DataRow dr;



            for (int i = arg_first_data_row; i < arg_dt.Rows.Count; i++)
            {

                component = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString().Trim();
                spec_unit = arg_dt.Rows[i].ItemArray[_Excel_Ix_SpecUnit].ToString().Trim();
                material = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material].ToString().Trim();
                material_1 = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material_1].ToString().Trim();

                common_yield_value = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString().Trim();



                // 자재는 없고, 숫자값이 하나라도 있으면 구성.

                temp = 0;
                exist_yield = false;


                for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                {

                    try // 숫자형 : 채산값 행으로 간주 
                    {
                        temp = Convert.ToDouble(arg_dt.Rows[i].ItemArray[j].ToString().Trim());
                        exist_yield = true;
                        first_yield = temp.ToString();
                        break;
                    }
                    catch
                    {
                    }
                }




                if (common_yield_value.Equals("") && (material.Equals("") || material.Substring(0, 1).Equals("*")) && (!exist_yield)) continue;




                dr = dt_ret.NewRow();

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {

                    dr[j] = arg_dt.Rows[i].ItemArray[j].ToString();

                    if (j >= arg_size_start_col && j <= arg_size_end_col)
                    {
                        if (material.Equals("") && material_1.Equals("") && arg_dt.Rows[i].ItemArray[arg_size_start_col].ToString().Trim().Equals("") && exist_yield)
                        {
                            dr[j] = first_yield;
                        }

                    }

                } // end for j



                dt_ret.Rows.Add(dr);


            } // end for i


            return dt_ret;


        }



        /// <summary>
        /// ExcelLoading_Step_5 : 5. 윗실, 아랫실 같은 경우 Material 부분으로 재 설정
        /// </summary>
        /// <param name="arg_dt"></param>
        /// <returns></returns>
        private DataTable ExcelLoading_Step_5(DataTable arg_dt)
        {

            DataTable dt_ret = arg_dt.Clone();

            DataRow dr;


            string material_1 = "";

            string material = "";
            string spec_unit = "";
            string common_yield_value = "";


            double temp = 0;
            bool numeric = true;
            //bool joint_material = false;



            // title 추가
            for (int i = 0; i < 2; i++)
            {

                dr = dt_ret.NewRow();

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {

                    dr[j] = arg_dt.Rows[i].ItemArray[j].ToString();

                } // end for j

                dt_ret.Rows.Add(dr);
            }




            bool duplicate = false;

            string color = "";

            string component = "";
            string before_component = "";

            string before_material = "";
            string before_color = "";


            // title 제외
            for (int i = 2; i < arg_dt.Rows.Count; i++)
            {



                component = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString().Trim();
                material = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material].ToString().Trim();
                material_1 = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material_1].ToString().Trim();
                spec_unit = arg_dt.Rows[i].ItemArray[_Excel_Ix_SpecUnit].ToString().Trim();
                color = arg_dt.Rows[i].ItemArray[_Excel_Ix_Color].ToString().Trim();
                common_yield_value = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString().Trim();


                if (!material_1.Equals(""))
                {
                    // 숫자형 아니면
                    // material_col 으로 데이터 이동
                    try
                    {
                        temp = Convert.ToDouble(material_1);

                        numeric = true;
                        duplicate = false;
                    }
                    catch
                    {

                        numeric = false;


                        // 윗실, 밑실인 경우
                        // 중복 체크해서 채산값 합계 처리 작업 해 주기 위해서 중복 체크
                        // 나머지 경우는 모두 중복 아님으로 처리 

                        before_material = dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Excel_Ix_Material].ToString().Trim();
                        before_color = dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Excel_Ix_Color].ToString().Trim();

                        if (component.Equals(""))
                        {
                            component = before_component;
                        }

                        if (before_component + before_material + before_color == component + material_1 + color)
                        {
                            duplicate = true;
                        }
                        else
                        {
                            duplicate = false;
                        }


                    }
                }





                //if (material.Equals("") && (!spec_unit.Equals("")) && (!common_yield_value.Equals("")))
                //{
                //    joint_material = true;
                //}
                //else
                //{
                //    joint_material = false;
                //}




                if (duplicate)
                {


                    DataRow dr_temp;

                    double sum_common_yield_value = 0;
                    double before_yield_value = 0;
                    double now_yield_value = 0;
                    string one_common_yield_value = "";

                    one_common_yield_value = (dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Excel_Ix_CommonYieldValue].ToString() == "") ? "0" : dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Excel_Ix_CommonYieldValue].ToString();

                    try
                    {
                        before_yield_value = Convert.ToSingle(one_common_yield_value);
                    }
                    catch
                    {
                        before_yield_value = 0;
                    }


                    common_yield_value = (common_yield_value.Trim() == "") ? "0" : common_yield_value;

                    try
                    {
                        now_yield_value = Convert.ToSingle(common_yield_value);
                    }
                    catch
                    {
                        now_yield_value = 0;
                    }


                    sum_common_yield_value = before_yield_value + now_yield_value;

                    dr_temp = dt_ret.Rows[dt_ret.Rows.Count - 1];
                    dr_temp[_Excel_Ix_CommonYieldValue] = Convert.ToSingle(sum_common_yield_value).ToString();


                }
                else
                {


                    dr = dt_ret.NewRow();




                    for (int j = 0; j < arg_dt.Columns.Count; j++)
                    {

                        dr[j] = arg_dt.Rows[i].ItemArray[j].ToString();

                    } // end for j 


                    if (numeric == false)
                    {
                        dr[_Excel_Ix_Material] = material_1;
                    }


                    //if (joint_material == true)
                    //{
                    //    dr[_Excel_Ix_Material] = spec_unit;
                        
                    //}


                    dt_ret.Rows.Add(dr);


                }


                numeric = true;
                duplicate = false;



                // Material 에 대한 컴포넌트
                if (!component.Equals(""))
                {
                    before_component = component;
                }



            } // end for i 


            return dt_ret;


        }



        /// <summary>
        /// ExcelLoading_Step_6 : 6. 필요없는 컬럼 정리 후 데이터 부분 재추출
        /// </summary>
        /// <param name="arg_dt"></param>
        /// <param name="arg_size_start_col"></param>
        /// <param name="arg_size_end_col"></param>
        /// <returns></returns>
        private DataTable ExcelLoading_Step_6(DataTable arg_dt, int arg_size_start_col, int arg_size_end_col)
        {



            string first_yield_value = "";
            double temp = 0;
            bool before_numeric = false;

            DataRow dr = null;


            //--------------------------------------------------------------------------------------------
            // create return table
            //--------------------------------------------------------------------------------------------
            DataTable result_ret = new DataTable();

            result_ret.Columns.Add(new DataColumn("COMPONENT", typeof(string)));
            result_ret.Columns.Add(new DataColumn("ITEM_CD", typeof(string)));
            result_ret.Columns.Add(new DataColumn("MNG_UNIT", typeof(string)));
            result_ret.Columns.Add(new DataColumn("SIZE_YN", typeof(string)));
            result_ret.Columns.Add(new DataColumn("SPEC_CD", typeof(string)));
            result_ret.Columns.Add(new DataColumn("COLOR_CD", typeof(string)));
            result_ret.Columns.Add(new DataColumn("MATERIAL_USE", typeof(string)));
            result_ret.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            result_ret.Columns.Add(new DataColumn("SPEC_UNIT", typeof(string)));
            result_ret.Columns.Add(new DataColumn("COLOR", typeof(string)));
            result_ret.Columns.Add(new DataColumn("COMMON_YIELD_VALUE", typeof(string)));

            for (int i = arg_size_start_col; i <= arg_size_end_col; i++)
            {
                result_ret.Columns.Add(new DataColumn("SIZE_YIELD_VALUE" + i.ToString(), typeof(string)));

            } // end for i
            //--------------------------------------------------------------------------------------------


            string before_component = "";
            string before_material = "";
            string before_spec_unit = "";
            string before_color = "";
            string before_common_yield_value = "";


            DataRow dr_temp;
            int insert_row = -1;
            int start_row = -1;



            for (int i = 2; i < arg_dt.Rows.Count; i++)
            {

                first_yield_value = arg_dt.Rows[i].ItemArray[arg_size_start_col].ToString();


                // 숫자형 : 채산값 행으로 간주 
                try
                {
                    temp = Convert.ToDouble(first_yield_value);


                    if (before_numeric)
                    {



                        // component row
                        for (int a = result_ret.Rows.Count - 1; a >= 0; a--)
                        {

                            if (before_component == result_ret.Rows[a].ItemArray[_Excel_Ix_Component].ToString())
                            {
                                start_row = a;
                                break;
                            }

                        } // end for a




                        for (int a = result_ret.Rows.Count - 1; a >= start_row; a--)
                        {


                            if (result_ret.Rows[a].ItemArray[_Excel_Ix_Material].ToString().Trim().Equals("")) continue;



                            dr = result_ret.NewRow();

                            dr["COMPONENT"] = "";
                            dr["ITEM_CD"] = "";
                            dr["MNG_UNIT"] = "";
                            dr["SIZE_YN"] = "";
                            dr["SPEC_CD"] = "";
                            dr["COLOR_CD"] = "";
                            dr["MATERIAL_USE"] = "FALSE";
                            dr["MATERIAL"] = ""; // result_ret.Rows[start_row].ItemArray[_Excel_Ix_Material].ToString();
                            dr["SPEC_UNIT"] = ""; // result_ret.Rows[start_row].ItemArray[_Excel_Ix_SpecUnit].ToString();
                            dr["COLOR"] = ""; // result_ret.Rows[start_row].ItemArray[_Excel_Ix_Color].ToString();
                            dr["COMMON_YIELD_VALUE"] = "";  //result_ret.Rows[start_row].ItemArray[_Excel_Ix_CommonYieldValue].ToString();


                            for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                            {
                                dr["SIZE_YIELD_VALUE" + j.ToString()] = "";

                            } // end for j


                            //result_ret.Rows.Add(dr);
                            result_ret.Rows.InsertAt(dr, a + 1);

                            dr_temp = result_ret.Rows[a + 1];


                            // datarow 로 구성 후 업데이트 가능

                            // "COMMON_YIELD_VALUE"
                            dr_temp[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COMMON_YIELD_VALUE] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();

                            for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                            {

                                dr_temp[((int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START - 1) + (j - arg_size_start_col)] = arg_dt.Rows[i].ItemArray[j].ToString();


                            } // end for j   


                        } // end for a (한 콤포넌트 아래 모든 자재에 일괄 적용)




                    }


                    before_numeric = true;

                   

                }
                catch
                {


                    // component row

                    dr = result_ret.NewRow();

                    dr["COMPONENT"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();
                    dr["ITEM_CD"] = "";
                    dr["MNG_UNIT"] = "";
                    dr["SIZE_YN"] = "";
                    dr["SPEC_CD"] = "";
                    dr["COLOR_CD"] = "";
                    dr["MATERIAL_USE"] = "FALSE";
                    dr["MATERIAL"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material].ToString();
                    dr["SPEC_UNIT"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_SpecUnit].ToString();
                    dr["COLOR"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Color].ToString();
                    dr["COMMON_YIELD_VALUE"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString();


                    for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                    {
                        dr["SIZE_YIELD_VALUE" + j.ToString()] = "";

                    } // end for j


                    result_ret.Rows.Add(dr);




                    //-------------------------------------------------------------------------------------------------------------------------------
                    // yield value setting
                    //-------------------------------------------------------------------------------------------------------------------------------
                    double temp_1 = 0;
                    int value_row = -1;
                    string now_component = "";

                    insert_row = -1;

                    for (int j = i + 1; j < arg_dt.Rows.Count; j++)
                    {

                        try
                        {
                            temp_1 = Convert.ToDouble(arg_dt.Rows[j].ItemArray[arg_size_start_col].ToString());
                            value_row = j;
                            break;
                        }
                        catch
                        {
                        }

                    }



                    if (value_row != -1)
                    {


                        for (int j = value_row - 1; j >= 0; j--)
                        {

                            if (!arg_dt.Rows[j].ItemArray[_Excel_Ix_Component].ToString().Trim().Equals(""))
                            {
                                insert_row = j;
                                break;
                            }

                        }

                        insert_row = (insert_row == -1) ? i : insert_row;


                        if (arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString().Equals(""))
                        {
                            now_component = before_component;
                        }
                        else
                        {
                            now_component = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();
                        }

                        if (now_component == arg_dt.Rows[insert_row].ItemArray[_Excel_Ix_Component].ToString())
                        {


                            // datarow 로 구성 후 업데이트 가능
                            dr_temp = result_ret.Rows[result_ret.Rows.Count - 1];


                            // "COMMON_YIELD_VALUE"
                            dr_temp[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COMMON_YIELD_VALUE] = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString();



                            for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                            {

                                dr_temp[((int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START - 1) + (j - arg_size_start_col)] = arg_dt.Rows[value_row].ItemArray[j].ToString();

                            } // end for j  

                        } // end if (equal component)


                    } // end if(value_row != -1)
                    //-------------------------------------------------------------------------------------------------------------------------------




                    //------------------------------------------------------------------------------------------------------------------------------- 
                    // before head data
                    //-------------------------------------------------------------------------------------------------------------------------------
                    if (!arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString().Trim().Equals(""))
                    {
                        before_component = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();
                    }

                    if (!arg_dt.Rows[i].ItemArray[_Excel_Ix_Material].ToString().Trim().Equals(""))
                    {
                        before_material = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material].ToString();
                    }

                    if (!arg_dt.Rows[i].ItemArray[_Excel_Ix_SpecUnit].ToString().Trim().Equals(""))
                    {
                        before_spec_unit = arg_dt.Rows[i].ItemArray[_Excel_Ix_SpecUnit].ToString();
                    }

                    if (!arg_dt.Rows[i].ItemArray[_Excel_Ix_Color].ToString().Trim().Equals(""))
                    {
                        before_color = arg_dt.Rows[i].ItemArray[_Excel_Ix_Color].ToString();
                    }

                    if (!arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString().Trim().Equals(""))
                    {
                        before_common_yield_value = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString();
                    }
                    //-------------------------------------------------------------------------------------------------------------------------------


                    before_numeric = false;



                } // end try~catch



            } // end for i



            return result_ret;


        }




        /// <summary>
        /// ExcelLoading_Step_6 : 6. 필요없는 컬럼 정리 후 데이터 부분 재추출
        /// </summary>
        /// <param name="arg_dt"></param>
        /// <param name="arg_size_start_col"></param>
        /// <param name="arg_size_end_col"></param>
        /// <returns></returns>
        private DataTable ExcelLoading_Step_6_1(DataTable arg_dt, int arg_size_start_col, int arg_size_end_col)
        {


            double temp = 0;
            bool before_numeric = false;
            int component_row = -1;
            string before_component = "";
            string before_material = "";
            DataRow dr = null;
            DataRow dr_temp;



            //--------------------------------------------------------------------------------------------
            // create return table
            //--------------------------------------------------------------------------------------------
            DataTable result_ret = new DataTable();

            result_ret.Columns.Add(new DataColumn("COMPONENT", typeof(string)));
            result_ret.Columns.Add(new DataColumn("ITEM_CD", typeof(string)));
            result_ret.Columns.Add(new DataColumn("MNG_UNIT", typeof(string)));
            result_ret.Columns.Add(new DataColumn("SIZE_YN", typeof(string)));
            result_ret.Columns.Add(new DataColumn("SPEC_CD", typeof(string)));
            result_ret.Columns.Add(new DataColumn("COLOR_CD", typeof(string)));
            result_ret.Columns.Add(new DataColumn("MATERIAL_USE", typeof(string)));
            result_ret.Columns.Add(new DataColumn("MATERIAL", typeof(string)));
            result_ret.Columns.Add(new DataColumn("SPEC_UNIT", typeof(string)));
            result_ret.Columns.Add(new DataColumn("COLOR", typeof(string)));
            result_ret.Columns.Add(new DataColumn("DESCRIPTION", typeof(string)));
            result_ret.Columns.Add(new DataColumn("COMMON_YIELD_VALUE", typeof(string)));
            
            for (int i = arg_size_start_col; i <= arg_size_end_col; i++)
            {
                result_ret.Columns.Add(new DataColumn("SIZE_YIELD_VALUE" + i.ToString(), typeof(string)));

            } // end for i
            //--------------------------------------------------------------------------------------------

            

            for (int i = 2; i < arg_dt.Rows.Count; i++)
            {
 

                if (Empty_String(arg_dt.Rows[i].ItemArray[_Excel_Ix_Material], "") == "") continue;


                // 숫자형 : 채산값 행
                try
                {

                    temp = Convert.ToDouble(Empty_String(arg_dt.Rows[i].ItemArray[arg_size_start_col], ""));


                    // component row
                    for (int a = result_ret.Rows.Count - 1; a >= 0; a--)
                    {

                        if (before_component == result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COMPONENT].ToString().Trim())
                        {
                            component_row = a;
                            break;
                        }

                    } // end for a


                    
                    if (before_numeric)
                    {

                        before_material = "";

                        // 아이템 행 추가해서 채산값 행 함께 표시
                        
                        for (int a = result_ret.Rows.Count - 1; a >= component_row; a--)
                        {

                            if (before_material == result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_MATERIAL].ToString()) continue;



                            dr = result_ret.NewRow();

                            dr["COMPONENT"] = "";
                            dr["ITEM_CD"] = "";
                            dr["MNG_UNIT"] = "";
                            dr["SIZE_YN"] = "";
                            dr["SPEC_CD"] = "";
                            dr["COLOR_CD"] = "";
                            dr["MATERIAL_USE"] = "FALSE";
                            dr["MATERIAL"] = result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_MATERIAL].ToString();
                            dr["SPEC_UNIT"] = result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_SPEC_UNIT].ToString();
                            dr["COLOR"] = result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COLOR].ToString();
                            dr["DESCRIPTION"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();
                            dr["COMMON_YIELD_VALUE"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString();


                            for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                            {
                                dr["SIZE_YIELD_VALUE" + j.ToString()] = arg_dt.Rows[i].ItemArray[j].ToString();

                            } // end for j


                            before_material = Empty_String(result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_MATERIAL], "");


                            result_ret.Rows.InsertAt(dr, a + 1);



                        } // end for a


                    }
                    else
                    {
                       
                        // 채산값 이미 있는 아이템 행에 표시

                        for (int a = result_ret.Rows.Count - 1; a >= component_row; a--)
                        {

                            // 첫번재 사이즈 값
                            if (Empty_String(result_ret.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COMMON_YIELD_VALUE + 1], "") != "") continue;


                            // datarow 로 구성 후 업데이트 가능
                            dr_temp = result_ret.Rows[a];


                            // component desc
                            dr_temp[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_DESCRIPTION] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();


                            //// "COMMON_YIELD_VALUE"
                            //dr_temp[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COMMON_YIELD_VALUE] = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString();


                            for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                            {

                                dr_temp[((int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START - 1) + (j - arg_size_start_col)] = arg_dt.Rows[i].ItemArray[j].ToString();

                            } // end for j  


                        } // end for i


                    } // end if (before_numeric)


                    before_numeric = true;


                }
                catch
                {


                    dr = result_ret.NewRow();

                    dr["COMPONENT"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString();
                    dr["ITEM_CD"] = "";
                    dr["MNG_UNIT"] = "";
                    dr["SIZE_YN"] = "";
                    dr["SPEC_CD"] = "";
                    dr["COLOR_CD"] = "";
                    dr["MATERIAL_USE"] = "FALSE";
                    dr["MATERIAL"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Material].ToString();
                    dr["SPEC_UNIT"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_SpecUnit].ToString();
                    dr["COLOR"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_Color].ToString();
                    dr["DESCRIPTION"] = "";
                    dr["COMMON_YIELD_VALUE"] = arg_dt.Rows[i].ItemArray[_Excel_Ix_CommonYieldValue].ToString();

                    
                    for (int j = arg_size_start_col; j <= arg_size_end_col; j++)
                    {
                        dr["SIZE_YIELD_VALUE" + j.ToString()] = "";

                    } // end for j


                    result_ret.Rows.Add(dr);


                    if (Empty_String(arg_dt.Rows[i].ItemArray[_Excel_Ix_Component], "") != "")
                    {
                        before_component = Empty_String(arg_dt.Rows[i].ItemArray[_Excel_Ix_Component], "");
                    }

                    before_numeric = false;


                }


            } // end for i


           

            return result_ret;


        }





        /// <summary>
        /// ExcelLoading_Step_7 : 7. 그리드 조회
        /// </summary>
        /// <param name="arg_step_1_dt"></param>
        /// <param name="arg_result_dt"></param>
        /// <param name="arg_size_start_col"></param>
        /// <param name="arg_size_end_col"></param>
        /// <param name="arg_allsize_row"></param>
        private void ExcelLoading_Step_7(DataTable arg_step_1_dt,
            DataTable arg_result_dt,
            int arg_size_start_col,
            int arg_size_end_col,
            int arg_allsize_row)
        {

            string parent_component = "";
            string component = "";

            int new_row_count = 0;



            fgrid_Excel.Set_Grid("SBC_YIELD_LOADING_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Excel.Font = new Font("Verdana", 8);
            fgrid_Excel.Styles.Frozen.BackColor = Color.White;
            fgrid_Excel.Styles.Alternate.BackColor = Color.White;
            fgrid_Excel.KeyActionEnter = KeyActionEnum.MoveAcross;
            fgrid_Excel.KeyActionTab = KeyActionEnum.MoveAcross;
            fgrid_Excel.ExtendLastCol = false;
            fgrid_Excel.Set_Action_Image(img_Action);


            fgrid_Excel.Cols.Count = arg_result_dt.Columns.Count + 1;


            fgrid_Excel.Cols[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START - 1].Format = "#,##0.0000";

            for (int i = arg_size_start_col; i <= arg_size_end_col; i++)
            {

                fgrid_Excel[1, (i - arg_size_start_col) +  (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START] = arg_step_1_dt.Rows[arg_allsize_row].ItemArray[i].ToString();
                fgrid_Excel.Cols[(i - arg_size_start_col) + (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START].Width = 60;
                fgrid_Excel.Cols[(i - arg_size_start_col) + (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START].Format = "#,##0.0000";

            }

            for (int i = 0; i < arg_result_dt.Rows.Count; i++)
            {

                component = arg_result_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString().Trim();


                if (!component.Equals(""))
                {

                    parent_component = component;


                    // component
                    fgrid_Excel.Rows.Insert(new_row_count + fgrid_Excel.Rows.Fixed);
                    fgrid_Excel.Rows[new_row_count + fgrid_Excel.Rows.Fixed].IsNode = true;
                    fgrid_Excel.Rows[new_row_count + fgrid_Excel.Rows.Fixed].Node.Level = 1;
                    

                    fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT] = "";
                    fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL] = arg_result_dt.Rows[i].ItemArray[_Excel_Ix_Component].ToString().Trim();
                    

                    for (int j = (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_SPEC_UNIT; j < arg_result_dt.Columns.Count; j++)
                    {
                        fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, j + 1] = "";

                    } // end for j



                    fgrid_Excel.Rows[new_row_count + fgrid_Excel.Rows.Fixed].StyleNew.BackColor = Color.WhiteSmoke;

                    new_row_count++;
                     

                }



                // item 추가
                fgrid_Excel.Rows.Insert(new_row_count + fgrid_Excel.Rows.Fixed);
                fgrid_Excel.Rows[new_row_count + fgrid_Excel.Rows.Fixed].IsNode = true;
                fgrid_Excel.Rows[new_row_count + fgrid_Excel.Rows.Fixed].Node.Level = 2;


                fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT] = "";


                for (int j = (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_MATERIAL_USE; j < arg_result_dt.Columns.Count; j++)
                {



                    if (j >= (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxEX_COMMON_YIELD_VALUE)
                    {

                        double temp = 0;


                        // 숫자형 아니면 
                        try
                        {
                            temp = Convert.ToDouble(arg_result_dt.Rows[i].ItemArray[j].ToString().Trim());

                            fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, j + 1] = Convert.ToString(Math.Round(Convert.ToDouble(arg_result_dt.Rows[i].ItemArray[j].ToString().Trim()), 4));

                        }
                        catch
                        {

                            fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, j + 1] = arg_result_dt.Rows[i].ItemArray[j].ToString().Trim();
                        }


                    }
                    else
                    {

                        fgrid_Excel[new_row_count + fgrid_Excel.Rows.Fixed, j + 1] = arg_result_dt.Rows[i].ItemArray[j].ToString().Trim();
                        


                    }





                } // end for j


                new_row_count++;



            } // end for i


            fgrid_Excel.Cols[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE].AllowEditing = true;
            fgrid_Excel.Cols[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL].AllowEditing = true;
            fgrid_Excel.Cols[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT].AllowEditing = true;
            fgrid_Excel.Cols[(int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR].AllowEditing = true;
            fgrid_Excel.Tree.Column = (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL;
            fgrid_Excel.Tree.Style = TreeStyleFlags.Complete;
            //fgrid_Excel.Tree.Show(1);
            //rad_Comp.Checked = true;

            if (rad_SG.Checked)
            {
                fgrid_Excel.Tree.Show(Convert.ToInt32(rad_SG.Tag.ToString()));
            }
            else if (rad_Comp.Checked)
            {
                fgrid_Excel.Tree.Show(Convert.ToInt32(rad_Comp.Tag.ToString()));
            }
            else if (rad_All.Checked)
            {
                fgrid_Excel.Tree.Show(Convert.ToInt32(rad_All.Tag.ToString()));
            }


        }





        #endregion



        /// <summary>
        /// Event_btn_ExcelCondition_Click : 
        /// </summary>
        private void Event_btn_ExcelCondition_Click()
        {

            try
            {
                 
                int[] pop_parameter = new int[] { _Excel_Ix_Component, 
                                                    _Excel_Ix_ExcelSizeStart, 
                                                    _Excel_Ix_Material, 
                                                    _Excel_Ix_Material_1, 
                                                    _Excel_Ix_SpecUnit, 
                                                    _Excel_Ix_Color, 
                                                    _Excel_Ix_CommonYieldValue };


                FlexBase.Yield_New.Pop_Yield_Loading_Condition pop_form = new FlexBase.Yield_New.Pop_Yield_Loading_Condition(pop_parameter);
                pop_form.ShowDialog();


                if (pop_form._CancelFlag) return;



                if (txt_File.Text.Trim().Equals(""))
                {

                    if (openFileDialog_Loading.ShowDialog() == DialogResult.Cancel) return;

                    txt_File.Text = openFileDialog_Loading.FileName;

                } 


                this.Cursor = Cursors.WaitCursor;




                _Excel_Ix_Component = pop_form._Ix_Component;
                _Excel_Ix_ExcelSizeStart = pop_form._Ix_ExcelSizeStart;
                _Excel_Ix_Material = pop_form._Ix_Material;
                _Excel_Ix_Material_1 = pop_form._Ix_Material_1;
                _Excel_Ix_SpecUnit = pop_form._Ix_SpecUnit;
                _Excel_Ix_Color = pop_form._Ix_Color;
                _Excel_Ix_CommonYieldValue = pop_form._Ix_CommonYieldValue;



                // excel loading
                Run_Excel_Loading();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_ExcelCondition_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }


        }




        /// <summary>
        /// Event_btn_StatusConfirm_Click : 
        /// </summary>
        private void Event_btn_StatusConfirm_Click()
        {


            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldStatus.SelectedIndex == -1) return;


                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
                string yield_status = cmb_YieldStatus.SelectedValue.ToString();
                string yield_status_desc = cmb_YieldStatus.Columns[1].Text;



                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield_Status.SELECT_SBC_YIELD_STATUS(factory, style_cd, yield_status);

                if (dt_ret.Rows.Count == 0)
                {

                    FlexBase.Yield_New.Pop_Yield_Status_Confirm pop_form = new FlexBase.Yield_New.Pop_Yield_Status_Confirm(factory, style_cd, yield_status, yield_status_desc);
                    pop_form.ShowDialog();


                    // 수정 전 값 그대로
                    if (pop_form._CancelFlag)
                    {
                        cmb_YieldStatus.SelectedValue = cmb_StyleCd.Columns[5].Text;
                    }


                }
                else
                {

                    string user = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxUPD_USER - 1].ToString();

                    COM.ComFunction MyComFunction = new COM.ComFunction();
                    string confirm_date = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_STATUS_NEW.IxCONFIRM_YMD - 1].ToString());

                    string message = "Already Confirm [ " + yield_status_desc + " ] "
                        + "\r\n\r\n" + "User : " + user
                        + "\r\n\r\n" + "Confirm Date : " + confirm_date;

                    ClassLib.ComFunction.User_Message(message, "Yield Status Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_StatusConfirm_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }

        }



        /// <summary>
        /// Event_btn_Copy_Click : 
        /// </summary>
        private void Event_btn_Copy_Click()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString();


                FlexBase.Yield_New.Pop_Yield_Copy pop_form = new Pop_Yield_Copy(factory, style_cd);
                pop_form.ShowDialog();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Copy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;
                if (e.KeyCode != Keys.Enter) return;

                if (txt_AllSizeValue.Text.Trim() == "") return;


                // semigood, component 실행 하지 않음
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Semigood
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component) return;

                // material 없는 경우 실행 하지 않음
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "") return;


                CellRange cr = fgrid_Value.GetCellRange(_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START, _Value_Row_Yield, fgrid_Value.Cols.Count - 1);
                cr.Data = txt_AllSizeValue.Text;

               

                //-----------------------------------
                // main update
                //-----------------------------------
                bool condition_flag = Check_Input_Yield_Condition(true);

                if (condition_flag)
                {

                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                    {
                        fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                    }


                    for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                    {
                        fgrid_Yield[fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START] = Empty_String(fgrid_Value[_Value_Row_Yield, i], "");

                    } // end for i



                    Display_Grid_Yield_Size_Material(fgrid_Yield.Row);


                }
                //-----------------------------------


                //-----------------------------------
                // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
                //-----------------------------------
                Reset_Joint_BOM(fgrid_Yield.Row);
                //-----------------------------------


                //-----------------------------------
                // 임가공 구조일 때 임가공 채산값 등록 하면 원자재 모두 적용
                //-----------------------------------
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_JointMaterial)
                {
                    Input_Yield_Value_Joint();
                }
                //-----------------------------------


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

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                // semigood, component 실행 하지 않음
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Semigood
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component)
                {
                    return;
                }


                // material 없는 경우 실행 하지 않음
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                {
                    return;
                }



                int size_f = -1;
                int size_t = -1;
                string spec_cd = "";
                string spec_name = "";


                size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

                while (true)
                {

                    // 사이즈 문대마다 sepc grouping  
                    size_t = size_f;


                    spec_name = fgrid_Value[1, size_f].ToString().Trim() + "-" + fgrid_Value[1, size_t].ToString().Trim();
                    spec_cd = CHECK_SBC_YIELD_SPEC_NAME(spec_name);


                    for (int i = size_f; i <= size_t; i++)
                    {

                        fgrid_Value[_Value_Row_SpecCode, i] = spec_cd;
                        fgrid_Value[_Value_Row_SpecName, i] = spec_name;
                    }


                    size_f = size_t + 1;

                    if (size_f == fgrid_Value.Cols.Count) break;

                } // end while




                // 그룹 표시
                Display_Grid_Yield_Size_Material_Value("Y");


                //-----------------------------------
                // main update
                //-----------------------------------
                bool condition_flag = Check_Input_Yield_Condition(true);

                if (condition_flag)
                {

                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                    {
                        fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                    }


                    for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                    {

                        // value
                        fgrid_Yield[fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START] = Empty_String(fgrid_Value[_Value_Row_Yield, i], "");

                        // spec
                        CellRange cr = fgrid_Yield.GetCellRange(fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START);

                        spec_cd = Empty_String(fgrid_Value[_Value_Row_SpecCode, i], "");
                        spec_name = Empty_String(fgrid_Value[_Value_Row_SpecName, i], "");

                        cr.UserData = spec_cd + _UserData_Spec_Symbol + spec_name;


                    } // end for i



                    Display_Grid_Yield_Size_Material(fgrid_Yield.Row);

                }
                //-----------------------------------



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_GetSpecBySize_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


            // semigood, component 실행 하지 않음
            if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Semigood
                || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component)
            {
                return;
            }


            // material 없는 경우 실행 하지 않음
            if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
            {
                return;
            }




            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
            string style_factory = cmb_Factory.SelectedValue.ToString();
            string style_gender = cmb_StyleCd.Columns[2].Text;
            string style_presto = cmb_StyleCd.Columns[3].Text;


            string factory = "";
            string style_cd = "";
            string item_cd = "";


            DataTable dt_ret = null;

            if (arg_button == btn_GetSizeGroup)
            {

                // style 6자리, item 일치 데이터
                //factory = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "");
                factory = "__"; // 공장 구분 없이 공통되게 사용되므로 default로 조회
                style_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "").Substring(0, 6);
                item_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "");

            }
            else if (arg_button == btn_GetSizeGroup_Item)
            {

                //factory = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "");
                factory = "__"; // 공장 구분 없이 공통되게 사용되므로 default로 조회
                style_cd = "______";
                item_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "");

            }
            else if (arg_button == btn_GetSpecGroup)
            {

                factory = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "");
                style_cd = "-1";
                item_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "");

            }


            dt_ret = GET_SBC_YIELD_ITEM_GROUP_IN(factory, style_cd, item_cd, style_factory, style_gender, style_presto);

            if (dt_ret == null || dt_ret.Rows.Count == 0)
            {


                string item_name = "";

                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD], "") == _RawMaterial)
                {
                    item_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1], "");
                }
                else
                {
                    item_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2], "");
                }


                

                string message = "";
                DialogResult result;


                if (arg_button == btn_GetSizeGroup || arg_button == btn_GetSizeGroup_Item)
                {

                    message = "We have not item group : [" + item_name + "]"
                     + "\r\n\r\n" + "Do you want to input new item size group?"
                     +"\r\n\r\n" + "[Yes] directly input new item size group"
                     + "\r\n" + "[No] auto move to item size group";

                    result = ClassLib.ComFunction.User_Message(message, "Get_Item_Size_Group", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);



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


                        string size = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
                        string unit = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT], "");


                        FlexBase.Yield_New.Form_BC_Yield_Item_Group pop_form = new FlexBase.Yield_New.Form_BC_Yield_Item_Group(factory, style_cd, item_cd, item_name, size, unit);
                        pop_form.WindowState = FormWindowState.Normal;
                        pop_form.StartPosition = FormStartPosition.CenterParent;
                        pop_form.ShowDialog();

                    }
                    else if (result == DialogResult.No)  // 자동으로 master에 밀어 넣어 줌
                    {


                        bool value_condition_flag = Check_Input_Yield_Condition(true);

                        if (value_condition_flag)
                        {

                           
                            if (arg_button == btn_GetSizeGroup)
                            {
                                factory = "__";
                                style_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD].ToString().Substring(0, 6);
                                item_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD].ToString();
                            }
                            else
                            {
                                factory = "__";
                                style_cd = "______";
                                item_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD].ToString();
                            }


                            bool run_flag = SAVE_SBC_YIELD_ITEM_GROUP_IN(factory, style_cd, item_cd);

                            if (!run_flag)
                            {
                                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
                            }
                            else
                            {

                                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
                                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);

                            } // end if 

                        } // end if (condition_flag)



                    } // end if (result == DialogResult.Yes) 



                }
                else if (arg_button == btn_GetSpecGroup)
                {

                    message = "We have not item group : [" + item_name + "]" + "\r\n\r\n" + "Do you want to input new item size group?";

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


            } // end if (dt_ret == null || dt_ret.Rows.Count == 0)



            int col_cs_size = -1;
            string db_size = "";
            string grid_size = "";
            string spec_cd = "";
            string spec_name = "";


 

            //-----------------------------------------
            // size column
            //-----------------------------------------
            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {


                col_cs_size = -1;


                db_size = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxCS_SIZE], "");
                spec_cd = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxSPEC_CD], "");
                spec_name = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxSPEC_NAME], "");
                //yield_m = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW.IxYIELD_M], "0");


                for (int a = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; a < fgrid_Value.Cols.Count; a++)
                {

                    grid_size = Empty_String(fgrid_Value[1, a], "");

                    if (db_size == grid_size)
                    {
                        //fgrid_Value[_Value_Row_Yield, a] = yield_m;

                        if (Empty_String(fgrid_Value[_Value_Row_Yield, a], "") == "")
                        {
                            fgrid_Value[_Value_Row_Yield, a] = 0;
                        }

                        fgrid_Value[_Value_Row_SpecCode, a] = spec_cd;
                        fgrid_Value[_Value_Row_SpecName, a] = spec_name;

                        break;
                    }

                } // end for a

            } // end for i
            //-----------------------------------------


            // 그룹 표시
            Display_Grid_Yield_Size_Material_Value(Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], ""));


            //-----------------------------------
            // main update
            //-----------------------------------
            bool condition_flag = Check_Input_Yield_Condition(true);


            if (condition_flag)
            {

                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                {
                    fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                }


                for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                {

                    //// value
                    //fgrid_Yield[fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START] = Empty_String(fgrid_Value[_Value_Row_Yield, i], "");


                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "") == "Y")
                    {

                        // spec
                        CellRange cr = fgrid_Yield.GetCellRange(fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START);

                        spec_cd = Empty_String(fgrid_Value[_Value_Row_SpecCode, i], "");
                        spec_name = Empty_String(fgrid_Value[_Value_Row_SpecName, i], "");

                        cr.UserData = spec_cd + _UserData_Spec_Symbol + spec_name;

                    } // end if size_yn


                } // end for i



                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "") == "Y")
                {
                    Display_Grid_Yield_Size_Material(fgrid_Yield.Row);
                }


            }
            else
            {

                // 잘못된 경우이므로 다시 옮기기 전 값으로 수정
                fgrid_Yield.Select(fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, true);

            }
            //-----------------------------------


            //-----------------------------------
            // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
            //-----------------------------------
            Reset_Joint_BOM(fgrid_Yield.Row);
            //-----------------------------------


            //-----------------------------------
            // 임가공 구조일 때 임가공 채산값 등록 하면 원자재 모두 적용
            //-----------------------------------
            if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_JointMaterial)
            {
                Input_Yield_Value_Joint();
            }
            //-----------------------------------


        }





        /// <summary>
        /// Event_btn_ViewHistory_Click : 
        /// </summary>
        private void Event_btn_ViewHistory_Click()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

                //popup 창 파라미터 구성 
                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString();

                FlexBase.Yield.Pop_BC_Yield_History pop_form = new FlexBase.Yield.Pop_BC_Yield_History(factory, style_cd, "M");
                pop_form.MdiParent = ClassLib.ComVar.MDI_Parent;
                pop_form.Show();  


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_ViewHistory_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_CheckStatus_Click : 
        /// </summary>
        private void Event_btn_CheckStatus_Click()
        {

            try
            {

                FlexBase.Yield_New.Pop_Yield_Status_Check pop_form = new FlexBase.Yield_New.Pop_Yield_Status_Check();
                pop_form.Show();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_CheckStatus_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_btn_CheckYield_Click : 
        /// </summary>
        private void Event_btn_CheckYield_Click()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

                string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_BC_Yield_Item_Check");

                string sPara = " /rp ";


                sPara += "'" + cmb_Factory.SelectedValue.ToString() + "' ";
                sPara += "'" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "") + "' ";
                sPara += "'" + "M" + "' ";

                FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
                MyReport.Text = "Yield Item Check";
                MyReport.Show();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_CheckYield_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_btn_YieldInspection_Click : 
        /// </summary>
        private void Event_btn_YieldInspection_Click()
        {

            try
            {

                string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, "");

                FlexBase.Yield_New.Pop_Yield_Inspection pop_form = new FlexBase.Yield_New.Pop_Yield_Inspection(factory, style_cd);
                pop_form.Show(); 

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_YieldInspection_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private string _BackupDirectoryName = null;
        private string _BackupFileName = null;


        /// <summary>
        /// Event_btn_BackupData_Click : 
        /// </summary>
        private void Event_btn_BackupData_Click()
        {

            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

                this.Cursor = Cursors.WaitCursor;


                bool exist_modify = Check_NotSave_Data("Continue Backup");

                if (exist_modify) // No
                {
                    return;
                }
                else // Yes :  backup 진행한다는 의미
                {


                    Event_tbtn_Save_Click();


                    // 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
                    string start_path = Application.StartupPath.ToString() + "\\" + "Yield_Backup" + "\\";
                    string directory_name = cmb_Factory.SelectedValue.ToString() + "_" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
                    string directory_full_name = start_path + directory_name;


                    if (!System.IO.Directory.Exists(directory_full_name))
                    {
                        System.IO.Directory.CreateDirectory(directory_full_name);
                    }



                    _BackupDirectoryName = directory_full_name;



                    // xml 생성
                    bool run_flag = Run_XML_Create();

                    if (run_flag)
                    {

                        // zip 생성, xml 삭제
                        run_flag = Run_Zip_Create();

                        if (run_flag)
                        {
                            ClassLib.ComFunction.User_Message("Backup Complete.", "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ClassLib.ComFunction.User_Message("ZIP Generate Failed.", "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else
                    {
                        ClassLib.ComFunction.User_Message("XML Generate Failed.", "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                } // end if backup 실행

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_BackupData_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        #region Backup data



        /// <summary>
        /// Run_XML_Create : xml 생성
        /// </summary>
        /// <returns></returns>
        private bool Run_XML_Create()
        {



            try
            {


                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                string v_xmlfilename = null;
                string v_xmlfullname = null;


                System.Xml.XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "", "yes");
                doc.PrependChild(dec);

                System.IO.StringWriter writerString = new System.IO.StringWriter();
                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(writerString);


                //XML 파일이름
                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");

                v_xmlfilename = factory + "_" + style_cd + System.DateTime.Now.ToString("_yyyyMMdd_HHmmss") + "_" + System.DateTime.Now.Millisecond.ToString("000") + ".XML";


                //XML 파일생성, Document Start
                v_xmlfullname = _BackupDirectoryName + "\\" + v_xmlfilename;

                _BackupFileName = v_xmlfullname;




                writer = new XmlTextWriter(v_xmlfullname, System.Text.Encoding.Unicode);
                writer.WriteStartDocument(true);

                //XML File 시작 루트명
                writer.WriteStartElement("CSInc", "");


                string table_name = "";
                string where = "";
                DataSet ds_ret = null;
                bool xml_create_flag = false;



                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                table_name = "SBC_YIELD_INFO";
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                where = @"FACTORY = '" + cmb_Factory.SelectedValue.ToString() + @"' AND STYLE_CD = '" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "") + @"' " + @" AND COMPONENT_CD LIKE 'C%' ";
                // DB 로 부터 실제 데이터 추출
                ds_ret = Get_Backup_Data(table_name, where);

                if (ds_ret == null)
                {

                    writer.Close();

                    // xml 삭제
                    if (File.Exists(_BackupFileName))
                    {
                        File.Delete(_BackupFileName);
                    }

                    return false;

                }


                // 데이터 값들을 엘리먼트로 생성
                xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);

                if (!xml_create_flag)
                {

                    writer.Close();

                    // xml 삭제
                    if (File.Exists(_BackupFileName))
                    {
                        File.Delete(_BackupFileName);
                    }

                    return false;

                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------


                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                table_name = "SBC_YIELD_VALUE";
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                // DB 로 부터 실제 데이터 추출
                ds_ret = Get_Backup_Data(table_name, where);

                if (ds_ret == null)
                {

                    writer.Close();

                    // xml 삭제
                    if (File.Exists(_BackupFileName))
                    {
                        File.Delete(_BackupFileName);
                    }

                    return false;

                }



                // 데이터 값들을 엘리먼트로 생성
                xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);


                if (!xml_create_flag)
                {

                    writer.Close();

                    // xml 삭제
                    if (File.Exists(_BackupFileName))
                    {
                        File.Delete(_BackupFileName);
                    }

                    return false;

                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------


                // history 테이블은 리스토어 하더라도 기존대로 남아야 하므로, 백업 생성하지 않음
                ////-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                //table_name = "SBC_YIELD_HISTORY";
                ////-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                //// DB 로 부터 실제 데이터 추출
                //ds_ret = Get_Backup_Data(table_name, where);

                //if (ds_ret == null)
                //{

                //    writer.Close();

                //    // xml 삭제
                //    if (File.Exists(_BackupFileName))
                //    {
                //        File.Delete(_BackupFileName);
                //    }

                //    return false;

                //}



                //// 데이터 값들을 엘리먼트로 생성
                //xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);

                //if (!xml_create_flag)
                //{

                //    writer.Close();

                //    // xml 삭제
                //    if (File.Exists(_BackupFileName))
                //    {
                //        File.Delete(_BackupFileName);
                //    }

                //    return false;

                //}
                ////-----------------------------------------------------------------------------------------------------------------------------------------------------------------


                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                table_name = "SBC_YIELD_STATUS";
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                where = @"FACTORY = '" + cmb_Factory.SelectedValue.ToString() + @"' AND STYLE_CD = '" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "") + @"' ";
                // DB 로 부터 실제 데이터 추출
                ds_ret = Get_Backup_Data(table_name, where);

                if (ds_ret == null)
                {

                    writer.Close();

                    // xml 삭제
                    if (File.Exists(_BackupFileName))
                    {
                        File.Delete(_BackupFileName);
                    }

                    return false;

                }



                // 데이터 값들을 엘리먼트로 생성
                xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);

                if (!xml_create_flag)
                {

                    writer.Close();

                    // xml 삭제
                    if (File.Exists(_BackupFileName))
                    {
                        File.Delete(_BackupFileName);
                    }

                    return false;

                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------




                writer.Close();




                return true;
            }
            catch
            {
                return false;
            }


        }



        /// <summary>
        /// Get_Backup_Data : DB 로 부터 실제 데이터 추출
        /// </summary>
        /// <param name="arg_table_name"></param>
        /// <param name="arg_where"></param>
        /// <returns></returns>
        private DataSet Get_Backup_Data(string arg_table_name, string arg_where)
        {


            try
            {

                string sql = " SELECT * "
                           + "   FROM " + arg_table_name
                           + "  WHERE " + arg_where;

                DataSet ds_ret = MyOraDB.Exe_Select_Query(sql);


                if (ds_ret == null)
                {
                    return null;
                }
                else
                {
                    return ds_ret;
                }

            }
            catch
            {
                return null;
            }


        }



        /// <summary>
        /// Set_Backup_Data_XML_Element : 데이터 값들을 엘리먼트로 생성
        /// </summary>
        /// <param name="arg_writer"></param>
        /// <param name="arg_ds_ret"></param>
        /// <param name="arg_table_name"></param>
        /// <param name="arg_where"></param>
        /// <returns></returns>
        private bool Set_Backup_Data_XML_Element(System.Xml.XmlTextWriter arg_writer, DataSet arg_ds_ret, string arg_table_name, string arg_where)
        {

            try
            {

                arg_writer.WriteStartElement(arg_table_name, "");
                arg_writer.WriteAttributeString("WHERE", arg_where);


                // 데이터 값들을 엘리먼트로 생성
                for (int i = 0; i < arg_ds_ret.Tables[0].Rows.Count; i++)
                {

                    arg_ds_ret.Tables[0].TableName = arg_table_name.ToString();

                    arg_writer.WriteStartElement(arg_table_name, "");

                    for (int j = 0; j < arg_ds_ret.Tables[0].Columns.Count; j++)
                    {

                        string v_fieldName = arg_ds_ret.Tables[0].Columns[j].ColumnName.ToString();
                        string v_fieldType = arg_ds_ret.Tables[0].Columns[j].DataType.ToString();
                        string v_fieldData = arg_ds_ret.Tables[0].Rows[i].ItemArray[j].ToString() == null ? "null" : arg_ds_ret.Tables[0].Rows[i].ItemArray[j].ToString();

                        arg_writer.WriteElementString(v_fieldName, v_fieldType, v_fieldData);
                    }

                    arg_writer.WriteEndElement();
                    arg_writer.Flush();

                } // end for i



                arg_writer.WriteEndElement();
                arg_writer.Flush();

                return true;
            }
            catch
            {
                return false;
            }


        }



        /// <summary>
        /// Run_Zip_Create : zip 생성, xml 삭제
        /// </summary>
        /// <returns></returns>
        private bool Run_Zip_Create()
        {

            try
            {

                //  zip 생성
                C1.C1Zip.C1ZipFile zipFile = new C1.C1Zip.C1ZipFile();
                zipFile.Create(_BackupFileName.Replace(".XML", "") + ".ZIP");
                zipFile.Entries.Add(_BackupFileName);


                // xml 삭제
                if (File.Exists(_BackupFileName))
                {
                    File.Delete(_BackupFileName);
                }



                return true;

            }
            catch
            {
                return false;
            }


        }




        #endregion


        /// <summary>
        /// Event_btn_RestoreData_Click : 
        /// </summary>
        private void Event_btn_RestoreData_Click()
        {

            try
            {


                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

                if (!chk_CheckInOut.Checked) return;


                this.Cursor = Cursors.WaitCursor;



                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString(); //.Replace("-", "");
                string style_name = cmb_StyleCd.Columns[1].Text;


                FlexBase.Yield_New.Pop_Yield_Backup_Restore pop_form = new FlexBase.Yield_New.Pop_Yield_Backup_Restore(factory, style_cd, style_name);
                pop_form.ShowDialog(); 


                //--------------------------------------------------------------------------
                // 복구 완료 후 xml 파일은 모두 삭제 처리
                //--------------------------------------------------------------------------
                // 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
                string start_path = Application.StartupPath.ToString() + "\\" + "Yield_Backup" + "\\";
                string directory_name = factory + "_" + style_cd.Replace("-", "");
                string directory_full_name = start_path + directory_name;


                if (!System.IO.Directory.Exists(directory_full_name))
                {
                    System.IO.Directory.CreateDirectory(directory_full_name);
                }




                if (Directory.Exists(directory_full_name))
                {

                    ArrayList extensions_array = new ArrayList();
                    extensions_array.Add(".XML");
                    RecursiveFileExplorer.FileExplorer file_explorer = new RecursiveFileExplorer.FileExplorer(directory_full_name, extensions_array, true);

                    if (file_explorer.FileList.Count > 0)
                    {

                        DirectoryInfo dir = new DirectoryInfo(directory_full_name);

                        foreach (FileSystemInfo entry in dir.GetFileSystemInfos())
                        {

                            if (entry.Extension == "" || entry.Extension != ".XML") continue;

                            if (File.Exists(entry.FullName))
                            {
                                File.Delete(entry.FullName);
                            }



                        } // end foreach

                    } // end if(file_explorer.FileList.Count > 0) 

                } // if( Directory.Exists(  ) )


                //--------------------------------------------------------------------------


                Event_tbtn_Search_Click(false, false);

                //---------------------------------------------
                // 재 조회 된 경우 component마다 기존 작업된 트리 뷰 옵션 설정 하기 위함
                // style code 바껴서 첫번째 조회 될 때 생성
                //---------------------------------------------
                _DT_Component_ViewDepth = new DataTable();

                _DT_Component_ViewDepth.Columns.Add(new DataColumn("COMPONENT_CD", typeof(string)));
                _DT_Component_ViewDepth.Columns.Add(new DataColumn("ACTION_FLAG", typeof(string)));
                _DT_Component_ViewDepth.Columns.Add(new DataColumn("COLLAPSED", typeof(bool)));


                DataRow dr = null;


                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {

                    if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;

                    dr = _DT_Component_ViewDepth.NewRow();

                    dr["COMPONENT_CD"] = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    dr["ACTION_FLAG"] = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    dr["COLLAPSED"] = fgrid_Yield.Rows[i].Node.Collapsed;

                    _DT_Component_ViewDepth.Rows.Add(dr);


                } // end for i
                //---------------------------------------------



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_RestoreData_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #region 툴바 이벤트


        /// <summary>
        /// Event_Tbtn_New_Click : 컨트롤 초기화
        /// </summary>
        private void Event_Tbtn_New_Click()
        {

            try
            {
                // 완전 초기화
                Init_Form();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        /// <summary>
        /// Event_tbtn_Search_Click : 채산값 조회
        /// </summary>
        /// <param name="arg_show_notsave_message">true : 메세지 표시</param>
        /// <param name="arg_view_depth">true : view depth 그대로 유지</param>
        private void Event_tbtn_Search_Click(bool arg_show_notsave_message, bool arg_view_depth)
        {
            
            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;


                int last_top_row = fgrid_Yield.TopRow;
                int last_sel_row = fgrid_Yield.Row;
                int last_sel_col = fgrid_Yield.Col;


                //-----------------------------------------------------------------------------------------------
                //저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
                if (arg_show_notsave_message)
                {
                    bool exist_modify = Check_NotSave_Data("Search");
                    if (exist_modify) return;
                }
                //-----------------------------------------------------------------------------------------------


         
                string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

                DataSet ds_ret = SELECT_SBC_YIELD(factory, style_cd);

                DataTable dt_ret = ds_ret.Tables[0];
                DataTable dt_ret_component = ds_ret.Tables[1];


                fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;


                if (dt_ret == null || dt_ret.Rows.Count == 0)
                {
                    return;
                }


                Display_Grid_Yield(dt_ret);


                //-----------------------------------
                // 조회 후 view depth 유지
                //-----------------------------------
                if (arg_view_depth)
                {

                    if (_DT_Component_ViewDepth == null || _DT_Component_ViewDepth.Rows.Count == 0)
                    {

                        if (rad_SG.Checked)
                        {
                            fgrid_Yield.Tree.Show(Convert.ToInt32(rad_SG.Tag.ToString()));
                        }
                        else if (rad_Comp.Checked)
                        {
                            fgrid_Yield.Tree.Show(Convert.ToInt32(rad_Comp.Tag.ToString()));
                        }
                        else if (rad_All.Checked)
                        {
                            fgrid_Yield.Tree.Show(Convert.ToInt32(rad_All.Tag.ToString()));
                        }

                    }
                    else
                    {

                        for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                        {

                            if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;

                            string condition = @"COMPONENT_CD = '" + Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "") + "'";

                            DataRow[] findrow = _DT_Component_ViewDepth.Select(condition);

                            if (findrow.Length == 0) continue;

                            fgrid_Yield.Rows[i].Node.Collapsed = (bool)findrow[0][2];

                        } // end for i


                    }



                }
                //-----------------------------------



                //-----------------------------------
                // 조회 후 focus 행 유지
                //-----------------------------------
                last_top_row = (last_top_row < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : last_top_row;
                last_top_row = (last_top_row >= fgrid_Yield.Rows.Count) ? fgrid_Yield.Rows.Count - 1 : last_top_row;

                last_sel_row = (last_sel_row < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : last_sel_row;
                last_sel_row = (last_sel_row >= fgrid_Yield.Rows.Count) ? fgrid_Yield.Rows.Count - 1 : last_sel_row;

                fgrid_Yield.TopRow = last_top_row;
                fgrid_Yield.Select(last_sel_row, last_sel_col, false);
                //-----------------------------------




                // 컴포넌트 중복 여부 조사
                if (dt_ret_component == null || dt_ret_component.Rows.Count == 0)
                {
                    return;
                }



                FlexBase.Yield_New.Pop_Yield_Component_Duplicate pop_form = new FlexBase.Yield_New.Pop_Yield_Component_Duplicate(dt_ret_component);
                pop_form.Show();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }

        }



        /// <summary>
        /// Event_tbtn_Save_Click : 
        /// </summary>
        private void Event_tbtn_Save_Click()
        {

            try
            {

                if (! chk_CheckInOut.Checked) return;


                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;


                // 행 수정상태 해제 
                fgrid_Yield.Select(fgrid_Yield.Row, fgrid_Yield.Col, false);


                // 필수 항목 확인
                bool check_flag = Check_Save_Condition();
                if (!check_flag) return;


                DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
                if (dr == DialogResult.No) return;



                bool save_flag = SAVE_SBC_YIELD_VALUE(true);

                if (!save_flag)
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                    return;
                }
                else
                {
                    save_flag = SAVE_SBC_YIELD_INFO(false);

                    if (!save_flag)
                    {
                        ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                        return;
                    }
                    else
                    {
                        save_flag = SAVE_SBC_YIELD_COMPONENT_SEQ(false);

                        if (!save_flag)
                        {
                            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                            return;
                        }
                        else
                        {

                            DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                            if (ds_ret == null)  // error
                            {

                                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                                return;

                            }
                            else
                            {

                                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
                                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

                                // 재조회
                                Event_tbtn_Search_Click(false, true);

                            } // end if MyOraDB.Exe_Modify_Procedure()


                        } // end if 


                    }  // end if 


                } // end if 


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }

        }



        /// <summary>
        /// Event_tbtn_Print_Click : 
        /// </summary>
        private void Event_tbtn_Print_Click()
        {
           
            try
            {

                if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


                string factory = cmb_Factory.SelectedValue.ToString();
                string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
                string style_name = cmb_StyleCd.Columns[1].Text;
                string[] token = txt_Gender.Text.Split("/".ToCharArray());
                string gender = token[0].Trim();
                string presto_yn = token[1].Trim().Substring(0, 1);
                string print_option = "C";


                FlexBase.Yield_New.Pop_Yield_Print pop_Form = new FlexBase.Yield_New.Pop_Yield_Print(factory, style_cd, style_name, gender, presto_yn, print_option);
                pop_Form.ShowDialog();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #region Event_tbtn_Search_Click()



        /// <summary>
        /// Empty_String : 
        /// </summary>
        /// <param name="arg_value"></param>
        /// <param name="arg_empty_value"></param>
        /// <returns></returns>
        private string Empty_String(object arg_value, string arg_empty_value)
        {

            try
            {

                if ((arg_value == null) || (arg_value.ToString().Trim() == ""))
                {
                    return arg_empty_value;
                }
                else
                {
                    return arg_value.ToString().Trim();
                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Empty_String", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return arg_empty_value;
            }


        }




        /// <summary>
        /// Check_NotSave_Data : 저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
        /// </summary>
        private bool Check_NotSave_Data(string arg_part_message)
        {

            try
            {

                bool exist_modify = false;

                if (fgrid_Yield.Rows.Fixed < fgrid_Yield.Rows.Count)
                {

                    string temp = fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Fixed, 0, fgrid_Yield.Rows.Count - 1, 0).Clip.Replace("\r", "");

                    if (temp.Length > 0)
                    {
                        if (MessageBox.Show(this, "Exist modify data. Do you want " + arg_part_message + "?", arg_part_message, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            exist_modify = true;
                        }
                    }// end if (temp.Length > 0)
                }


                return exist_modify;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Check_NotSave_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

        }



        /// <summary>
        /// Display_Grid_Yield : 
        /// </summary>
        private void Display_Grid_Yield(DataTable arg_dt)
        {

            string display_level = "";
            string factory = "";
            string style_cd = "";
            string semi_good_cd = "";
            string component_cd = "";
            string template_seq = "";
            string template_level = "";
            string row_type = "";

            string before_data = "";
            string now_data = "";

            string size_from_order = "";
            string size_to_order = "";
            string yield_value = "";
            string now_size_order = "";
            int size_from_col = -1;
            int size_to_col = -1;

            string size_yn = "";
            string spec_cd = "";
            string spec_name = "";



            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                display_level = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL - 1], "");
                factory = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY - 1], "");
                style_cd = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD - 1], "");
                semi_good_cd = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD - 1], "");
                component_cd = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD - 1], "");
                template_seq = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ - 1], "");
                template_level = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL - 1], "");
                row_type = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE - 1], "");

                now_data = display_level + factory + style_cd + semi_good_cd + component_cd + template_seq + template_level;


                // display header
                if (before_data != now_data)
                {

                    //---------------------
                    // grid 행 생성
                    fgrid_Yield.Rows.Add();
                    fgrid_Yield.Rows[fgrid_Yield.Rows.Count - 1].IsNode = true;
                    fgrid_Yield.Rows[fgrid_Yield.Rows.Count - 1].Node.Level = (display_level == "") ? 0 : Convert.ToInt32(display_level);

                    //if (row_type == _RowType_Semigood)
                    //{
                    //    fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Count - 1, 1, fgrid_Yield.Rows.Count - 1, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                    //}
                    //else if (row_type == _RowType_Component)
                    //{
                    //    fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Count - 1, 1, fgrid_Yield.Rows.Count - 1, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
                    //}

                    if (row_type == _RowType_Semigood || row_type == _RowType_Component)
                    {
                        fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Count - 1, 1, fgrid_Yield.Rows.Count - 1, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;
                    }

                    //---------------------


                    //---------------------
                    // grid 값 표시
                    fgrid_Yield[fgrid_Yield.Rows.Count - 1, 0] = "";

                    for (int a = 1; a < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a++)
                    {
                        fgrid_Yield[fgrid_Yield.Rows.Count - 1, a] = Empty_String(arg_dt.Rows[i].ItemArray[a - 1], "");

                        // 컬럼별 기능 부여 하기 때문에 컬럼 단위로 적용
                        fgrid_Yield.Cols[a].AllowEditing = false;
                    }
                    //---------------------


                    //fgrid_Yield.Rows[fgrid_Yield.Rows.Count - 1].AllowEditing = false;


                    before_data = now_data;


                } // end if display header



                //---------------------
                // display detail
                if (row_type == _RowType_Semigood || row_type == _RowType_Component)
                {
                    // 타입(M, J) 이 아니면 수정 불가 처리
                    fgrid_Yield.Rows[fgrid_Yield.Rows.Count - 1].AllowEditing = false;
                    continue;
                }


                size_from_order = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxDB_SIZE_ORDER_FROM], "");
                size_to_order = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxDB_SIZE_ORDER_TO], "");
                yield_value = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxDB_YIELD_M], "");
                size_yn = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN - 1], "");
                spec_cd = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxDB_SPEC_CD], "");
                spec_name = Empty_String(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_NEW.IxDB_SPEC_NAME], "");

                //---------------------
                // size 시작 ~ 끝 컬럼 계산
                for (int a = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a < fgrid_Yield.Cols.Count; a++)
                {
                    now_size_order = Empty_String(fgrid_Yield[0, a], "0");

                    if (now_size_order == size_from_order)
                    {
                        size_from_col = a;
                        break;
                    }

                }

                size_from_col = (size_from_col == -1) ? (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START : size_from_col;

                for (int a = size_from_col; a < fgrid_Yield.Cols.Count; a++)
                {
                    now_size_order = Empty_String(fgrid_Yield[0, a], "0");

                    if (now_size_order == size_to_order)
                    {
                        size_to_col = a;
                        break;
                    }

                }

                size_to_col = (size_to_col == -1) ? fgrid_Yield.Cols.Count - 1 : size_to_col;
                //---------------------


                //---------------------
                // 채산값, spec 표시
                for (int a = size_from_col; a <= size_to_col; a++)
                {
                    fgrid_Yield[fgrid_Yield.Rows.Count - 1, a] = yield_value;

                    CellRange cr = fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Count - 1, a);
                    //cr.UserData = spec_cd;

                    cr.UserData = spec_cd + _UserData_Spec_Symbol + spec_name;

                }
                //---------------------


                //---------------------
                // 사이즈 자재 표시 가능
                if (size_to_col == fgrid_Yield.Cols.Count - 1)
                {
                    Display_Grid_Yield_Size_Material(fgrid_Yield.Rows.Count - 1);
                }
                //---------------------



            } // end for (int i = 0; i < arg_dt.Rows.Count; i++)



            fgrid_Yield.Tree.Column = (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC;
            //fgrid_Yield.Tree.Show(1);
            //rad_Comp.Checked = true;

            
            //if (rad_SG.Checked)
            //{
            //    fgrid_Yield.Tree.Show(Convert.ToInt32(rad_SG.Tag.ToString()));
            //}
            //else if (rad_Comp.Checked)
            //{
            //    fgrid_Yield.Tree.Show(Convert.ToInt32(rad_Comp.Tag.ToString()));
            //}
            //else if (rad_All.Checked)
            //{
            //    fgrid_Yield.Tree.Show(Convert.ToInt32(rad_All.Tag.ToString()));
            //}



        }


        /// <summary>
        /// Display_Grid_Yield_Size_Material : 
        /// </summary>
        private void Display_Grid_Yield_Size_Material(int arg_row)
        {

            string before_spec = "";
            string now_spec = "";
            int size_from_col = -1;
            int size_to_col = -1;


            _Color_SizeSpecCurrent = _Color_SizeSpecEven;


            if (Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "") != "Y") return;



            for (int i = 1; i < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i++)
            {
                //fgrid_Yield.GetCellRange(arg_row, i).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;

                CellStyle cs_size_yn = fgrid_Yield.Styles.Add("SIZE_Y_" + arg_row.ToString() + i.ToString(), fgrid_Yield.GetCellRange(arg_row, i).Style);
                cs_size_yn.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
                fgrid_Yield.SetCellStyle(arg_row, i, "SIZE_Y_" + arg_row.ToString() + i.ToString());


            }


            size_from_col = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START;

            CellRange cr = fgrid_Yield.GetCellRange(arg_row, size_from_col);
            if (fgrid_Yield[arg_row, size_from_col] == null || cr.UserData == null) return;


            string[] token = null;


            while (true)
            {

                CellRange cr_b = fgrid_Yield.GetCellRange(arg_row, size_from_col);

                if (cr_b.UserData == null)
                {
                    before_spec = "";
                }
                else
                {
                    token = cr_b.UserData.ToString().Split(_UserData_Spec_Symbol.ToCharArray());
                    before_spec = token[0];
                }



                for (int k = size_from_col; k < fgrid_Yield.Cols.Count; k++)
                {
                    CellRange cr_n = fgrid_Yield.GetCellRange(arg_row, k);

                    if (cr_n.UserData == null)
                    {
                        now_spec = "";
                    }
                    else
                    {
                        token = cr_n.UserData.ToString().Split(_UserData_Spec_Symbol.ToCharArray());
                        now_spec = token[0];
                    }


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
                if (_Color_SizeSpecCurrent.Equals(_Color_SizeSpecOdd))
                {
                    _Color_SizeSpecCurrent = _Color_SizeSpecEven;
                }
                else
                {
                    _Color_SizeSpecCurrent = _Color_SizeSpecOdd;
                }



                for (int i = size_from_col; i <= size_to_col; i++)
                {
                    //fgrid_Yield.GetCellRange(arg_row, i).StyleNew.BackColor = _Color_SizeSpecCurrent;

                    CellStyle cs_spec = fgrid_Yield.Styles.Add("SPEC_" + arg_row.ToString() + i.ToString());
                    cs_spec.BackColor = _Color_SizeSpecCurrent;
                    fgrid_Yield.SetCellStyle(arg_row, i, "SPEC_" + arg_row.ToString() + i.ToString());

                }



                size_from_col = size_to_col + 1;


                if (size_from_col == fgrid_Yield.Cols.Count) break;


            } // end while



        }




        /// <summary>
        /// Display_Grid_Yield_Size_Material_Value : 
        /// </summary>
        /// <param name="arg_size_yn"></param>
        private void Display_Grid_Yield_Size_Material_Value(string arg_size_yn)
        {

            string before_spec = "";
            string now_spec = "";
            int size_from_col = -1;
            int size_to_col = -1;


            if (arg_size_yn != "Y") return;


            _Color_SizeSpecCurrent = _Color_SizeSpecEven;


            size_from_col = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START;


            while (true)
            {

                before_spec = Empty_String(fgrid_Value[_Value_Row_SpecCode, size_from_col], "");


                for (int k = size_from_col; k < fgrid_Value.Cols.Count; k++)
                {

                    now_spec = Empty_String(fgrid_Value[_Value_Row_SpecCode, k], "");

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
                if (_Color_SizeSpecCurrent.Equals(_Color_SizeSpecOdd))
                {
                    _Color_SizeSpecCurrent = _Color_SizeSpecEven;
                }
                else
                {
                    _Color_SizeSpecCurrent = _Color_SizeSpecOdd;
                }



                for (int i = size_from_col; i <= size_to_col; i++)
                {

                    CellStyle cs_spec = fgrid_Value.Styles.Add("SPEC_COLOR" + i.ToString());
                    cs_spec.BackColor = _Color_SizeSpecCurrent;
                    fgrid_Value.SetCellStyle(_Value_Row_Yield, i, "SPEC_COLOR" + i.ToString());
                    fgrid_Value.SetCellStyle(_Value_Row_SpecCode, i, "SPEC_COLOR" + i.ToString());
                    fgrid_Value.SetCellStyle(_Value_Row_SpecName, i, "SPEC_COLOR" + i.ToString());

                }



                size_from_col = size_to_col + 1;


                if (size_from_col == fgrid_Value.Cols.Count) break;


            } // end while



        }





        /// <summary>
        /// Reset_Size_Material : 사이즈 자재 여부에 따른 채산값 재 설정
        /// </summary>
        /// <param name="arg_row"></param>
        public void Reset_Size_Material(int arg_row)
        {


            try
            {


                if (Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "") != "Y")
                {


                    for (int i = 1; i < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i++)
                    {

                        CellStyle cs_size_yn = fgrid_Yield.Styles.Add("SIZE_N_" + arg_row.ToString() + i.ToString(), fgrid_Yield.GetCellRange(arg_row, i).Style);
                        cs_size_yn.ForeColor = Color.Black;
                        fgrid_Yield.SetCellStyle(arg_row, i, "SIZE_N_" + arg_row.ToString() + i.ToString());


                    } // end for i


                    //---------------------------------------------------------------
                    // detail spec 재 설정 : 사이즈 아이템 아닐 경우 헤더 spec 상속
                    //---------------------------------------------------------------
                    string spec_cd_head = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
                    string spec_name_head = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");
                    
                    if (spec_cd_head != "")
                    {
                        
                        for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                        {

                            CellRange cr = fgrid_Yield.GetCellRange(arg_row, i);
                            //cr.UserData = spec_cd_head;
                            cr.UserData = spec_cd_head + _UserData_Spec_Symbol + spec_name_head;
                            cr.StyleNew.BackColor = Color.White;

                        }
                    } // end if (spec_cd_head != "")
                    //---------------------------------------------------------------


                }
                else
                {


                    //---------------------------------------------------------------
                    // detail spec 재 설정 : default로 사이즈 아이템 일 경우 헤더 spec 상속
                    //---------------------------------------------------------------
                    CellRange cr_first = fgrid_Yield.GetCellRange(arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START);

                    if (Empty_String(cr_first.UserData, "") == "")
                    {

                        string spec_cd_head = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
                        string spec_name_head = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");

                        if (spec_cd_head != "")
                        {

                            for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                            {

                                CellRange cr = fgrid_Yield.GetCellRange(arg_row, i);
                                //cr.UserData = spec_cd_head;
                                cr.UserData = spec_cd_head + _UserData_Spec_Symbol + spec_name_head;
                                cr.StyleNew.BackColor = Color.White;

                            }
                        } // end if (spec_cd_head != "")

                    }
                    //---------------------------------------------------------------


                    Display_Grid_Yield_Size_Material(arg_row);

                } // if size_yn = "N"



                //fgrid_Yield.Select(arg_row, 0, false);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Reset_Size_Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        #endregion

        #region Event_tbtn_Save_Click()


        /// <summary>
        /// Check_Save_Condition : 
        /// </summary>
        /// <returns></returns>
        private bool Check_Save_Condition()
        {


            try
            {


                string division = "";
                string row_type = "";

                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {

                    division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    if (division == null || division == "") continue;
                    if (division != "I" && division != "U") continue;

                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    if (row_type == _RowType_Semigood || row_type == _RowType_Component) continue;


                    // component 없으면 설정 할 수 없음
                    if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "") == "")
                    {

                        string message = "We must input component.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Yield.TopRow = i - 5;
                        fgrid_Yield.Select(i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, false);

                        return false;
                    }

                    // item, spec, color 없으면 설정 할 수 없음
                    if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == "" 
                        || Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                        || Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                    {

                        string message = "We must input material.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Yield.TopRow = i - 5;
                        fgrid_Yield.Select(i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, false);

                        return false;
                    }

                    // 사이즈 spec 없으면 설정 할 수 없음
                    string spec_cd_detail = Empty_String(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START).UserData, "");
                    if (spec_cd_detail == "")
                    {
                        string message = "We must input size yield value.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Yield.TopRow = i - 5;
                        fgrid_Yield.Select(i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, false);

                        return false;
                    }

                    // 사이즈 채산값 없으면 설정 할 수 없음
                    string spec_yield_detail = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START], "");
                    if(spec_yield_detail == "")
                    {
                        string message = "We must input size yield value.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fgrid_Yield.TopRow = i - 5;
                        fgrid_Yield.Select(i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, false);

                        return false;
                    }


                } // end for i


                // excel 작업 중이던 것 남아 있으면 저장 할 수 없음
                for (int i = fgrid_Excel.Rows.Fixed; i < fgrid_Excel.Rows.Count; i++)
                {

                    if (fgrid_Excel.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Checked))
                    {

                        string message = "We have not yet move excel data.";
                        ClassLib.ComFunction.User_Message(message, "Check_Save_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (!chk_Excel.Checked)
                        {
                            chk_Excel.Checked = true;
                        }

                        fgrid_Excel.TopRow = i - 5;
                        fgrid_Excel.Select(i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, false);

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
        /// SAVE_SBC_YIELD_VALUE : 
        /// </summary>
        /// <param name="arg_clear_argument"></param>
        /// <returns></returns>
        private bool SAVE_SBC_YIELD_VALUE(bool arg_clear_argument)
        {

            try
            {


                int col_ct = 19;

                MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_SBC_YIELD_VALUE";


                // 파라미터 이름 설정
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


                string division = "";
                string factory = "";
                string style_cd = "";
                string semi_good_cd = "";
                string component_cd = "";
                string template_seq = "";
                string template_level = "";
                string item_cd = "";
                string spec_cd = "";
                string color_cd = "";
                string row_type = "";
                string size_yn = "";
                string before_spec = "";
                string now_spec = "";
                int size_f = -1;
                int size_t = -1;
                double yield_value = 0;
                string[] token = null;
                string action_flag = "";
                string before_semi_good_cd = "";
                string history_remarks = ""; // semi_good_cd + component_cd + template_seq + template_level


                token = txt_Gender.Text.Split("/".ToCharArray());
                string gender = token[0].Trim();
                string presto_yn = token[1].Trim().Substring(0, 1);


                //-----------------------------------------------------------------------
                // MAKE Webservice parameter
                //-----------------------------------------------------------------------
                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {


                    division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    if (division == null || division == "") continue;


                    factory = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "");
                    style_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "");
                    semi_good_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                    component_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    template_seq = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "");
                    template_level = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "");
                    item_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "");
                    spec_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
                    color_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "");
                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    size_yn = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");


                    if (division == "I" || division == "U")
                    {
                        
                        if (row_type == _RowType_Semigood || row_type == _RowType_Component) continue;


                        #region INSERT, UPDATE : DELETE -> INSERT


                        vList.Add("D"); // "ARG_DIVISION";
                        vList.Add(factory); // "ARG_FACTORY";
                        vList.Add(style_cd); // "ARG_STYLE_CD";
                        vList.Add(semi_good_cd); // "ARG_SEMI_GOOD_CD";
                        vList.Add(component_cd); // "ARG_COMPONENT_CD";
                        vList.Add(template_seq); // "ARG_TEMPLATE_SEQ";
                        vList.Add(template_level); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(""); // "ARG_CS_SIZE_FROM";
                        vList.Add(""); // "ARG_CS_SIZE_TO";
                        vList.Add(""); // "ARG_ITEM_CD";
                        vList.Add(""); // "ARG_SPEC_CD";
                        vList.Add(""); // "ARG_COLOR_CD";
                        vList.Add(""); // "ARG_YIELD_M";
                        vList.Add(""); // "ARG_GENDER";
                        vList.Add(""); // "ARG_PRESTO_YN";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        vList.Add(""); // "ARG_ACTION_FLAG";
                        vList.Add(""); // "ARG_HISTORY_REMARKS";



                        #region INSERT size group
                        
                        
                        size_f = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START;


                        if(size_yn == "Y") // 사이즈 아이템일 경우, spec으로 사이즈 그룹 구분
                        {


                            while (true)
                            {

                                CellRange cr_b = fgrid_Yield.GetCellRange(i, size_f);

                                if (cr_b.UserData == null)
                                {
                                    before_spec = "";
                                }
                                else
                                {
                                    token = cr_b.UserData.ToString().Split(_UserData_Spec_Symbol.ToCharArray());
                                    before_spec = token[0];
                                }


                                for (int k = size_f; k < fgrid_Yield.Cols.Count; k++)
                                {
                                    CellRange cr_n = fgrid_Yield.GetCellRange(i, k);

                                    if (cr_n.UserData == null)
                                    {
                                        now_spec = "";
                                    }
                                    else
                                    {
                                        token = cr_n.UserData.ToString().Split(_UserData_Spec_Symbol.ToCharArray());
                                        now_spec = token[0];
                                    }


                                    if (before_spec == now_spec)
                                    {
                                        size_t = k;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }


                                spec_cd = before_spec;
                                yield_value = Convert.ToDouble(Empty_String(fgrid_Yield[i, size_f], "0"));


                                vList.Add("I"); // "ARG_DIVISION";
                                vList.Add(factory); // "ARG_FACTORY";
                                vList.Add(style_cd); // "ARG_STYLE_CD";
                                vList.Add(semi_good_cd); // "ARG_SEMI_GOOD_CD";
                                vList.Add(component_cd); // "ARG_COMPONENT_CD";
                                vList.Add(template_seq); // "ARG_TEMPLATE_SEQ";
                                vList.Add(template_level); // "ARG_TEMPLATE_LEVEL";
                                vList.Add(fgrid_Yield[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                                vList.Add(fgrid_Yield[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                                vList.Add(item_cd); // "ARG_ITEM_CD";
                                vList.Add(spec_cd); // "ARG_SPEC_CD";
                                vList.Add(color_cd); // "ARG_COLOR_CD";
                                vList.Add(yield_value.ToString()); // "ARG_YIELD_M";
                                vList.Add(gender); // "ARG_GENDER";
                                vList.Add(presto_yn); // "ARG_PRESTO_YN";
                                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                                vList.Add(""); // "ARG_ACTION_FLAG";
                                vList.Add(""); // "ARG_HISTORY_REMARKS";


                                size_f = size_t + 1;

                                if (size_f == fgrid_Yield.Cols.Count) break;

                            } // end while



                        }
                        else // 사이즈 아이템 아닐 경우, value로 사이즈 그룹 구분
                        {


                            while (true)
                            {

                                before_spec = Empty_String(fgrid_Yield[i, size_f], "0");

                                for (int k = size_f; k < fgrid_Yield.Cols.Count; k++)
                                {

                                    now_spec = Empty_String(fgrid_Yield[i, k], "0");


                                    if (before_spec == now_spec)
                                    {
                                        size_t = k;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }



                                CellRange cr_b = fgrid_Yield.GetCellRange(i, size_f);
                                
                                if (cr_b.UserData == null)
                                {
                                    spec_cd = "";
                                }
                                else
                                {
                                    token = cr_b.UserData.ToString().Split(_UserData_Spec_Symbol.ToCharArray());
                                    spec_cd = token[0];
                                }

                                yield_value = Convert.ToDouble(Empty_String(fgrid_Yield[i, size_f], "0"));


                                vList.Add("I"); // "ARG_DIVISION";
                                vList.Add(factory); // "ARG_FACTORY";
                                vList.Add(style_cd); // "ARG_STYLE_CD";
                                vList.Add(semi_good_cd); // "ARG_SEMI_GOOD_CD";
                                vList.Add(component_cd); // "ARG_COMPONENT_CD";
                                vList.Add(template_seq); // "ARG_TEMPLATE_SEQ";
                                vList.Add(template_level); // "ARG_TEMPLATE_LEVEL";
                                vList.Add(fgrid_Yield[1, size_f].ToString()); // "ARG_CS_SIZE_FROM";
                                vList.Add(fgrid_Yield[1, size_t].ToString()); // "ARG_CS_SIZE_TO";
                                vList.Add(item_cd); // "ARG_ITEM_CD";
                                vList.Add(spec_cd); // "ARG_SPEC_CD";
                                vList.Add(color_cd); // "ARG_COLOR_CD";
                                vList.Add(yield_value.ToString()); // "ARG_YIELD_M";
                                vList.Add(gender); // "ARG_GENDER";
                                vList.Add(presto_yn); // "ARG_PRESTO_YN";
                                vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                                vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                                vList.Add(""); // "ARG_ACTION_FLAG";
                                vList.Add(""); // "ARG_HISTORY_REMARKS";


                                size_f = size_t + 1;

                                if (size_f == fgrid_Yield.Cols.Count) break;

                            } // end while



                        }



                        #endregion


                        #endregion

                    }
                    else if (division == "D")
                    {

                        if (row_type == _RowType_Semigood || row_type == _RowType_Component) continue;


                        #region DELETE


                        history_remarks = semi_good_cd + component_cd + template_seq + template_level;


                        vList.Add(division); // "ARG_DIVISION";
                        vList.Add(factory); // "ARG_FACTORY";
                        vList.Add(style_cd); // "ARG_STYLE_CD";
                        vList.Add(semi_good_cd); // "ARG_SEMI_GOOD_CD";
                        vList.Add(component_cd); // "ARG_COMPONENT_CD";
                        vList.Add(template_seq); // "ARG_TEMPLATE_SEQ";
                        vList.Add(template_level); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(""); // "ARG_CS_SIZE_FROM";
                        vList.Add(""); // "ARG_CS_SIZE_TO";
                        vList.Add(""); // "ARG_ITEM_CD";
                        vList.Add(""); // "ARG_SPEC_CD";
                        vList.Add(""); // "ARG_COLOR_CD";
                        vList.Add(""); // "ARG_YIELD_M";
                        vList.Add(""); // "ARG_GENDER";
                        vList.Add(""); // "ARG_PRESTO_YN";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        vList.Add(division); // "ARG_ACTION_FLAG";
                        vList.Add(history_remarks); // "ARG_HISTORY_REMARKS";


                        #endregion

                    }
                    else if (division == "M")
                    {


                        // SEMI_GOOD 이동 할 때에도 COMPONENT는 유일해야 함으로 조건에서 빠져도 무방
                        // 다시 DELETE -> INSERT 되기 때문에


                        //// move는 component 단위 이므로 material 데이터는 불필요
                        //if (row_type != _RowType_Component) continue;


                        ////---------------------------------------------------------------------------
                        //// 현재 SG 안에서 M division이 아닌 다른 division의 component가 있을 경우에는,
                        //// 옮겨진 component로 삭제 (키가 같으므로 함께 삭제 됨) 후 추가 되므로 작업 불필요
                        ////---------------------------------------------------------------------------                       
                        //int semi_good_row = fgrid_Yield.FindRow(semi_good_cd, fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD, false, true, false);
                        //string move_component_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                        //string now_component_cd = "";
                        //bool duplicate_flag = false;

                        //for (int a = semi_good_row; a < fgrid_Yield.Rows.Count; a++)
                        //{

                        //    if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;
                        //    if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "M") continue;

                        //    now_component_cd = Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

                        //    if (now_component_cd == move_component_cd)
                        //    {
                        //        duplicate_flag = true;
                        //        break;
                        //    }

                        //} // end for a


                        //if (duplicate_flag) continue;
                        ////---------------------------------------------------------------------------


                        #region MOVE

                        //// 옮겨지기 전 component DELETE 작업 하기 위함
                        //// MOVE : 이전 데이터 DELETE -> 신규로 INSERT 처리 됨으로, 
                        ////        history는 INSERT 에서 처리하고, DELETE는 history 남기지 않음


                        //vList.Add(division); // "ARG_DIVISION";
                        //vList.Add(factory); // "ARG_FACTORY";
                        //vList.Add(style_cd); // "ARG_STYLE_CD";
                        //vList.Add(semi_good_cd); // "ARG_SEMI_GOOD_CD";
                        //vList.Add(component_cd); // "ARG_COMPONENT_CD";
                        //vList.Add(""); // "ARG_TEMPLATE_SEQ";
                        //vList.Add(""); // "ARG_TEMPLATE_LEVEL";
                        //vList.Add(""); // "ARG_CS_SIZE_FROM";
                        //vList.Add(""); // "ARG_CS_SIZE_TO";
                        //vList.Add(""); // "ARG_ITEM_CD";
                        //vList.Add(""); // "ARG_SPEC_CD";
                        //vList.Add(""); // "ARG_COLOR_CD";
                        //vList.Add(""); // "ARG_YIELD_M";
                        //vList.Add(""); // "ARG_GENDER";
                        //vList.Add(""); // "ARG_PRESTO_YN";
                        //vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        //vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";
                        //vList.Add(""); // "ARG_ACTION_FLAG";
                        //vList.Add(""); // "ARG_HISTORY_REMARKS";


                        #endregion


                    } // end if division



                } //end for i


                #region HISTORY


                // history : I, U 일때만 따로 구성, D 는 내부적으로 Delete 할때 함께 처리됨
                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {

                    division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    if (division == null || division == "") continue;
                    if (division != "I" && division != "U") continue;


                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    if (row_type == _RowType_Semigood || row_type == _RowType_Component) continue;


                    factory = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "");
                    style_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "");
                    semi_good_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                    component_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    template_seq = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "");
                    template_level = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "");

                    history_remarks = semi_good_cd + component_cd + template_seq + template_level;


                    vList.Add("H"); // "ARG_DIVISION";
                    vList.Add(factory); // "ARG_FACTORY";
                    vList.Add(style_cd); // "ARG_STYLE_CD";
                    vList.Add(semi_good_cd); // "ARG_SEMI_GOOD_CD";
                    vList.Add(component_cd); // "ARG_COMPONENT_CD";
                    vList.Add(template_seq); // "ARG_TEMPLATE_SEQ";
                    vList.Add(template_level); // "ARG_TEMPLATE_LEVEL";
                    vList.Add(""); // "ARG_CS_SIZE_FROM";
                    vList.Add(""); // "ARG_CS_SIZE_TO";
                    vList.Add(""); // "ARG_ITEM_CD";
                    vList.Add(""); // "ARG_SPEC_CD";
                    vList.Add(""); // "ARG_COLOR_CD";
                    vList.Add(""); // "ARG_YIELD_M";
                    vList.Add(""); // "ARG_GENDER";
                    vList.Add(""); // "ARG_PRESTO_YN";
                    vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                    vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                    if (division == "I")
                    {

                        CellRange cr_sg = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD);
                        before_semi_good_cd = Empty_String(cr_sg.UserData, "");

                        if (before_semi_good_cd == "") // insert
                        {
                            action_flag = "I";
                            history_remarks = semi_good_cd + component_cd + template_seq + template_level;
                        }
                        else // move
                        {
                            action_flag = "M";
                            history_remarks = before_semi_good_cd + component_cd + template_seq + template_level;
                        } // end if (before_semi_good_cd == "")

                    }
                    else if (division == "U")
                    {
                        action_flag = "U";
                        history_remarks = semi_good_cd + component_cd + template_seq + template_level;
                    }


                    vList.Add(action_flag); // "ARG_ACTION_FLAG";
                    vList.Add(history_remarks); // "ARG_HISTORY_REMARKS";



                } // end for i


                #endregion

                //-----------------------------------------------------------------------



                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(arg_clear_argument);		// 파라미터 데이터를 DataSet에 추가  


                return true;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_YIELD_VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        /// <summary>
        /// SAVE_SBC_YIELD_INFO : 
        /// </summary>
        /// <param name="arg_clear_argument"></param>
        /// <returns></returns>
        private bool SAVE_SBC_YIELD_INFO(bool arg_clear_argument)
        {

            try
            {

                int col_ct = 30;

                MyOraDB.ReDim_Parameter(col_ct);
                
                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_SBC_YIELD_INFO";


                // 파라미터 이름 설정
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
                MyOraDB.Parameter_Name[10] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[11] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[12] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[13] = "ARG_STYLE_ITEM_DIV";
                MyOraDB.Parameter_Name[14] = "ARG_COMMON_YN";
                MyOraDB.Parameter_Name[15] = "ARG_SHIP_YN";
                MyOraDB.Parameter_Name[16] = "ARG_PUR_SHIP_YN";
                MyOraDB.Parameter_Name[17] = "ARG_PUR_IMPORT_YN";
                MyOraDB.Parameter_Name[18] = "ARG_PUR_LOCAL_YN";
                MyOraDB.Parameter_Name[19] = "ARG_PROD_YN";
                MyOraDB.Parameter_Name[20] = "ARG_PROD_OP_CD";
                MyOraDB.Parameter_Name[21] = "ARG_PROD_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[22] = "ARG_OUISIDE_IN_YN";
                MyOraDB.Parameter_Name[23] = "ARG_OUTSIDE_OUT_YN";
                MyOraDB.Parameter_Name[24] = "ARG_SHIP_LOSS_RATE";
                MyOraDB.Parameter_Name[25] = "ARG_PUR_LOSS_RATE";
                MyOraDB.Parameter_Name[26] = "ARG_PROD_LOSS_RATE";
                MyOraDB.Parameter_Name[27] = "ARG_COMPONENT_SEQ";
                MyOraDB.Parameter_Name[28] = "ARG_UPD_FACTORY";
                MyOraDB.Parameter_Name[29] = "ARG_UPD_USER";

                // YIELD_STATUS, YIELD_VERSION 은 DB 에서 최신 데이터로 업데이트

        
                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                string division = "";
                string row_type = "";

                //-----------------------------------------------------------------------
                // MAKE Webservice parameter
                //-----------------------------------------------------------------------
                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {


                    division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    if (division == null || division == "") continue;


                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    

                    if (division == "I" || division == "U")
                    {

                        if (row_type == _RowType_Semigood || row_type == _RowType_Component) continue;


                        #region INSERT, UPDATE : DELETE -> INSERT


                        vList.Add("D"); // "ARG_DIVISION";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "")); // "ARG_FACTORY";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "")); // "ARG_STYLE_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "")); // "ARG_SEMI_GOOD_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "")); // "ARG_COMPONENT_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "")); // "ARG_TEMPLATE_SEQ";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "")); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(""); // "ARG_TEMPLATE_TREE_CD";
                        vList.Add(""); // "ARG_TEMPLATE_CD";
                        vList.Add(""); // "ARG_TEMPLATE_NAME";
                        vList.Add(""); // "ARG_ITEM_CD";
                        vList.Add(""); // "ARG_SPEC_CD";
                        vList.Add(""); // "ARG_COLOR_CD";
                        vList.Add(""); // "ARG_STYLE_ITEM_DIV";
                        vList.Add(""); // "ARG_COMMON_YN";
                        vList.Add(""); // "ARG_SHIP_YN";
                        vList.Add(""); // "ARG_PUR_SHIP_YN";
                        vList.Add(""); // "ARG_PUR_IMPORT_YN";
                        vList.Add(""); // "ARG_PUR_LOCAL_YN";
                        vList.Add(""); // "ARG_PROD_YN";
                        vList.Add(""); // "ARG_PROD_OP_CD";
                        vList.Add(""); // "ARG_PROD_SEMI_GOOD_CD";
                        vList.Add(""); // "ARG_OUISIDE_IN_YN";
                        vList.Add(""); // "ARG_OUTSIDE_OUT_YN";
                        vList.Add(""); // "ARG_SHIP_LOSS_RATE";
                        vList.Add(""); // "ARG_PUR_LOSS_RATE";
                        vList.Add(""); // "ARG_PROD_LOSS_RATE";
                        vList.Add(""); // "ARG_COMPONENT_SEQ";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";



                        vList.Add("I"); // "ARG_DIVISION";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "")); // "ARG_FACTORY";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "")); // "ARG_STYLE_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "")); // "ARG_SEMI_GOOD_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "")); // "ARG_COMPONENT_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "")); // "ARG_TEMPLATE_SEQ";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "")); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD], "")); // "ARG_TEMPLATE_TREE_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD], "")); // "ARG_TEMPLATE_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME], "")); // "ARG_TEMPLATE_NAME";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "")); // "ARG_ITEM_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "")); // "ARG_SPEC_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "")); // "ARG_COLOR_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_ITEM_DIV], "")); // "ARG_STYLE_ITEM_DIV";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMMON_YN], "")); // "ARG_COMMON_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSHIP_YN], "")); // "ARG_SHIP_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPUR_SHIP_YN], "")); // "ARG_PUR_SHIP_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPUR_IMPORT_YN], "")); // "ARG_PUR_IMPORT_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPUR_LOCAL_YN], "")); // "ARG_PUR_LOCAL_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPROD_YN], "")); // "ARG_PROD_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPROD_OP_CD], "")); // "ARG_PROD_OP_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPROD_SEMI_GOOD_CD], "")); // "ARG_PROD_SEMI_GOOD_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxOUISIDE_IN_YN], "")); // "ARG_OUISIDE_IN_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxOUTSIDE_OUT_YN], "")); // "ARG_OUTSIDE_OUT_YN";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSHIP_LOSS_RATE], "")); // "ARG_SHIP_LOSS_RATE";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPUR_LOSS_RATE], "")); // "ARG_PUR_LOSS_RATE";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxPROD_LOSS_RATE], "")); // "ARG_PROD_LOSS_RATE";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "")); // "ARG_COMPONENT_SEQ";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";



                        #endregion

                    }
                    else if (division == "D")
                    {
                        

                        if (row_type == _RowType_Semigood || row_type == _RowType_Component) continue;


                        #region DELETE


                        vList.Add(division); // "ARG_DIVISION";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "")); // "ARG_FACTORY";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "")); // "ARG_STYLE_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "")); // "ARG_SEMI_GOOD_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "")); // "ARG_COMPONENT_CD";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "")); // "ARG_TEMPLATE_SEQ";
                        vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "")); // "ARG_TEMPLATE_LEVEL";
                        vList.Add(""); // "ARG_TEMPLATE_TREE_CD";
                        vList.Add(""); // "ARG_TEMPLATE_CD";
                        vList.Add(""); // "ARG_TEMPLATE_NAME";
                        vList.Add(""); // "ARG_ITEM_CD";
                        vList.Add(""); // "ARG_SPEC_CD";
                        vList.Add(""); // "ARG_COLOR_CD";
                        vList.Add(""); // "ARG_STYLE_ITEM_DIV";
                        vList.Add(""); // "ARG_COMMON_YN";
                        vList.Add(""); // "ARG_SHIP_YN";
                        vList.Add(""); // "ARG_PUR_SHIP_YN";
                        vList.Add(""); // "ARG_PUR_IMPORT_YN";
                        vList.Add(""); // "ARG_PUR_LOCAL_YN";
                        vList.Add(""); // "ARG_PROD_YN";
                        vList.Add(""); // "ARG_PROD_OP_CD";
                        vList.Add(""); // "ARG_PROD_SEMI_GOOD_CD";
                        vList.Add(""); // "ARG_OUISIDE_IN_YN";
                        vList.Add(""); // "ARG_OUTSIDE_OUT_YN";
                        vList.Add(""); // "ARG_SHIP_LOSS_RATE";
                        vList.Add(""); // "ARG_PUR_LOSS_RATE";
                        vList.Add(""); // "ARG_PROD_LOSS_RATE";
                        vList.Add(""); // "ARG_COMPONENT_SEQ";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                        #endregion

                    }
                    else if (division == "M")
                    {



                        // SEMI_GOOD 이동 할 때에도 COMPONENT는 유일해야 함으로 조건에서 빠져도 무방
                        // 다시 DELETE -> INSERT 되기 때문에



                        //// move는 component 단위 이므로 material 데이터는 불필요
                        //if (row_type != _RowType_Component) continue;


                        ////---------------------------------------------------------------------------
                        //// 현재 SG 안에서 M division이 아닌 다른 division의 component가 있을 경우에는,
                        //// 옮겨진 component로 삭제 (키가 같으므로 함께 삭제 됨) 후 추가 되므로 작업 불필요
                        ////---------------------------------------------------------------------------   
                        //string semi_good_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                        //int semi_good_row = fgrid_Yield.FindRow(semi_good_cd, fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD, false, true, false);
                        //string move_component_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                        //string now_component_cd = "";
                        //bool duplicate_flag = false;

                        //for (int a = semi_good_row; a < fgrid_Yield.Rows.Count; a++)
                        //{

                        //    if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;
                        //    if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "M") continue;

                        //    now_component_cd = Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

                        //    if (now_component_cd == move_component_cd)
                        //    {
                        //        duplicate_flag = true;
                        //        break;
                        //    }

                        //} // end for a


                        //if (duplicate_flag) continue;
                        ////---------------------------------------------------------------------------



                        #region MOVE


                        //vList.Add(division); // "ARG_DIVISION";
                        //vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY], "")); // "ARG_FACTORY";
                        //vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD], "")); // "ARG_STYLE_CD";
                        //vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "")); // "ARG_SEMI_GOOD_CD";
                        //vList.Add(Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "")); // "ARG_COMPONENT_CD";
                        //vList.Add(""); // "ARG_TEMPLATE_SEQ";
                        //vList.Add(""); // "ARG_TEMPLATE_LEVEL";
                        //vList.Add(""); // "ARG_TEMPLATE_TREE_CD";
                        //vList.Add(""); // "ARG_TEMPLATE_CD";
                        //vList.Add(""); // "ARG_TEMPLATE_NAME";
                        //vList.Add(""); // "ARG_ITEM_CD";
                        //vList.Add(""); // "ARG_SPEC_CD";
                        //vList.Add(""); // "ARG_COLOR_CD";
                        //vList.Add(""); // "ARG_STYLE_ITEM_DIV";
                        //vList.Add(""); // "ARG_COMMON_YN";
                        //vList.Add(""); // "ARG_SHIP_YN";
                        //vList.Add(""); // "ARG_PUR_SHIP_YN";
                        //vList.Add(""); // "ARG_PUR_IMPORT_YN";
                        //vList.Add(""); // "ARG_PUR_LOCAL_YN";
                        //vList.Add(""); // "ARG_PROD_YN";
                        //vList.Add(""); // "ARG_PROD_OP_CD";
                        //vList.Add(""); // "ARG_PROD_SEMI_GOOD_CD";
                        //vList.Add(""); // "ARG_OUISIDE_IN_YN";
                        //vList.Add(""); // "ARG_OUTSIDE_OUT_YN";
                        //vList.Add(""); // "ARG_SHIP_LOSS_RATE";
                        //vList.Add(""); // "ARG_PUR_LOSS_RATE";
                        //vList.Add(""); // "ARG_PROD_LOSS_RATE";
                        //vList.Add(""); // "ARG_COMPONENT_SEQ";
                        //vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        //vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                        #endregion


                    } // end if division



                } //end for i
                //-----------------------------------------------------------------------



                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(arg_clear_argument);		// 파라미터 데이터를 DataSet에 추가  


                return true;



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_YIELD_INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        /// <summary>
        /// SAVE_SBC_YIELD_COMPONENT_SEQ : 
        /// </summary>
        /// <param name="arg_clear_argument">true : 웹서비스 파라미터 초기화, false : 오라클 트랜잭션 위해서 파라미터 초기화 하지 않음</param>
        /// <returns></returns>
        private bool SAVE_SBC_YIELD_COMPONENT_SEQ(bool arg_clear_argument)
        {

            try
            {

                ////-----------------------------------------------------------------------
                //// MOVE 된 component 없을 경우 순번 재 설정 필요 없으므로 작업 하지 않음
                ////-----------------------------------------------------------------------
                //int row_component_move = fgrid_Yield.FindRow("M", fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION, false, true, false);
                //if (row_component_move == -1) return true;
                ////-----------------------------------------------------------------------


                //-----------------------------------------------------------------------
                // MAKE Webservice parameter
                //-----------------------------------------------------------------------
                int col_ct = 7;

                MyOraDB.ReDim_Parameter(col_ct);
                
                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_SBC_YIELD_COMPONENT_SEQ";


                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
                MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[4] = "ARG_COMPONENT_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_UPD_FACTORY";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                string row_type = "";
                int first_row = -1;
                int last_row = -1;
                //bool move_flag = false;
                int now_component_seq = 0;


                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {


                    ////------------------------------------------------
                    //// semi_good 중에서 move 된 component 있으면 실행
                    ////------------------------------------------------
                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    if (row_type != _RowType_Semigood) continue;

                    // component 하나도 없으면 실행 하지 않음
                    if (fgrid_Yield.Rows[i].Node.Children == 0) continue;


                    first_row = fgrid_Yield.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    last_row = fgrid_Yield.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                    // 같은 component 나올 때 까지 반복
                    string sel_component_cd = Empty_String(fgrid_Yield[last_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    string now_component_cd = "";

                    for (int a = last_row; a < fgrid_Yield.Rows.Count; a++)
                    {

                        now_component_cd = Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

                        if (sel_component_cd == now_component_cd) continue;

                        last_row = a - 1;
                        break;

                    } // end for i



                    //// semi_good 중에서 move 된 component 있는지 확인
                    //move_flag = false;


                    //for (int a = first_row; a <= last_row; a++)
                    //{

                    //    row_type = Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    //    if (row_type != _RowType_Component) continue;

                    //    if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "M")
                    //    {
                    //        move_flag = true;
                    //        break;
                    //    }


                    //} // end for a


                    //if (!move_flag) continue;
                    ////------------------------------------------------


                    //------------------------------------------------
                    // MAKE Webservice parameter
                    //------------------------------------------------
                    now_component_seq = 0;

                    for (int a = first_row; a <= last_row; a++)
                    {


                        // delete, move는 제외
                        if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "D"
                             || Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "M")
                        {
                            continue;
                        }


                        if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component)
                        {
                            now_component_seq += _Component_Seq_Range;
                        }


                        fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = now_component_seq.ToString();


                        vList.Add(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY].ToString()); // "ARG_FACTORY";
                        vList.Add(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD].ToString()); // "ARG_STYLE_CD";
                        vList.Add(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD].ToString()); // "ARG_SEMI_GOOD_CD";
                        vList.Add(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD].ToString()); // "ARG_COMPONENT_CD";
                        vList.Add(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ].ToString()); // "ARG_COMPONENT_SEQ";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                    } // end for a
                    //------------------------------------------------


                } //end for i


                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(arg_clear_argument);		// 파라미터 데이터를 DataSet에 추가  


                return true;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_YIELD_COMPONENT_SEQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        #endregion


        #endregion

        #region 그리드 이벤트


        // show tooltip if the text is too long to fit the cell
        System.Windows.Forms.ToolTip _ttip;
        int _lastRow = 0;
        int _lastCol = 0;



        /// <summary>
        /// Event_fgrid_Yield_MouseMove_Tooltip : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_fgrid_Yield_MouseMove_Tooltip(object sender, MouseEventArgs e)
        {

            try
            {

                string text = null;
                if (e.Button == MouseButtons.None)
                {
                    // get mouse coordinates
                    int row = fgrid_Yield.MouseRow;
                    int col = fgrid_Yield.MouseCol;

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
                        text = fgrid_Yield.GetDataDisplay(row, col);

                        // get display rectangle
                        Rectangle rc = fgrid_Yield.GetCellRect(row, col, false);
                        rc.Intersect(fgrid_Yield.ClientRectangle);

                        // measure text
                        using (Graphics g = fgrid_Yield.CreateGraphics())
                        {
                            CellStyle s = fgrid_Yield.GetCellStyleDisplay(row, col);
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
                if (_ttip != null && _ttip.GetToolTip(fgrid_Yield) != text)
                    _ttip.SetToolTip(fgrid_Yield, text);


            }
            catch
            {
            }

        }



        /// <summary>
        /// Event_fgrid_Yield_Click : 
        /// </summary>
        private void Event_fgrid_Yield_Click()
        {

            try
            {

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                // component 생성 
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "I"
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component
                    && fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC)
                {
                    fgrid_Yield.Cols[fgrid_Yield.Col].AllowEditing = true;
                    return;
                }
                else
                {
                    fgrid_Yield.Cols[fgrid_Yield.Col].AllowEditing = false;
                }



                // material 생성, 수정
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Semigood
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component
                    && (fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC
                        || fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD
                        || fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME))
                {
                    //fgrid_Yield.Cols[fgrid_Yield.Col].AllowEditing = true;
                    //return;


                    // 임가공 아이템 명은 자동 생성 되고 수정하지 않지만,
                    // 임가공의 스펙, 컬러명은 수정 될 수 있음
                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_JointMaterial
                        && fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC)
                    {
                        fgrid_Yield.Cols[fgrid_Yield.Col].AllowEditing = false;
                    }
                    else
                    {
                        fgrid_Yield.Cols[fgrid_Yield.Col].AllowEditing = true;
                        return;
                    }

                }
                else
                {
                    fgrid_Yield.Cols[fgrid_Yield.Col].AllowEditing = false;
                }



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_fgrid_Yield_AfterCollapse : 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private void Event_fgrid_Yield_AfterCollapse(RowColEventArgs e)
        {

            try
            { 

                Set_Component_ViewDepth(e.Row);

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_AfterCollapse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Set_Component_ViewDepth : 
        /// </summary>
        /// <param name="arg_row"></param>
        private void Set_Component_ViewDepth(int arg_row)
        {



            if (_DT_Component_ViewDepth == null) return;

            if (arg_row == -1) return;

            if (Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) return;


            string condition = @"COMPONENT_CD = '" + Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "") + "'";
                
            DataRow[] findrow = _DT_Component_ViewDepth.Select(condition);


            if (findrow.Length == 0)  // 신규추가
            {

                DataRow dr = _DT_Component_ViewDepth.NewRow();

                dr["COMPONENT_CD"] = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                dr["ACTION_FLAG"] = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                dr["COLLAPSED"] = fgrid_Yield.Rows[arg_row].Node.Collapsed;

                _DT_Component_ViewDepth.Rows.Add(dr);

            }
            else
            {
                findrow[0][0] = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                findrow[0][1] = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                findrow[0][2] = fgrid_Yield.Rows[arg_row].Node.Collapsed;
            }



        }




        /// <summary>
        /// Event_fgrid_Yield_StartEdit : 
        /// </summary>
        private void Event_fgrid_Yield_StartEdit()
        {

            try
            {

                fgrid_Yield.Buffer_CellData = fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col] == null ? "" : fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col].ToString();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_StartEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_fgrid_Yield_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Yield_AfterEdit()
        {

            try
            {

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;

                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col], "") == "") return;



                // component 신규 추가
                if (fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component)
                {

                    Select_GridCombo_Component(fgrid_Yield, 
                        (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC,
                        (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD,
                        (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME,
                        false);

                }
                else if (fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC // item 생성, 수정 
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Semigood
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component)
                {

                    Select_GridCombo_Item(fgrid_Yield,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME);

                }
                else if (fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD // spec 생성, 수정
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Semigood
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component)
                {

                    Select_GridCombo_Spec(fgrid_Yield,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME,
                           "");

                }
                else if (fgrid_Yield.Col == (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME // color 생성, 수정 
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Semigood
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component)
                {

                    Select_GridCombo_Color(fgrid_Yield,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD,
                           (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME);

                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        #region Grid combo




        /// <summary>
        /// Select_GridCombo_Component : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_col_desc"></param>
        /// <param name="arg_col_code"></param>
        /// <param name="arg_col_name"></param>
        /// <param name="arg_auto_run"></param>
        private void Select_GridCombo_Component(COM.FSP arg_fgrid, 
            int arg_col_desc, 
            int arg_col_code, 
            int arg_col_name,
            bool arg_auto_run)
        {


            CellRange cr = arg_fgrid.GetCellRange(arg_fgrid.Row, 1, arg_fgrid.Row, arg_fgrid.Cols.Count - 1);


            try
            {

                string component = "";
                bool component_set_flag = false;
                string return_component_cd = "";
                string return_component_name = "";
                DataTable dt_ret = null;


                if (arg_auto_run)
                {

                    dt_ret = null;

                }
                else
                {

                    if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_code], "") != ""
                    && arg_fgrid.Buffer_CellData == Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "")) return;

                    component = Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "");

                    if (component.Trim().Equals("")) return;

                    dt_ret = SELECT_SBC_COMPONENT_COMBO(component);

                }


                


                FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                string[] key_string = new string[] { "COMPONENT_CD" };
                string[] value_string = new string[] { "COMPONENT_NAME" };

                grid_combo._JobDivision = "COMPONENT";
                grid_combo.ShowData(dt_ret, key_string, value_string, false, component);
                grid_combo.StartPosition = FormStartPosition.CenterScreen;


                if (grid_combo.ShowDialog() != DialogResult.OK)
                {

                    if (arg_fgrid == fgrid_Excel)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_desc] = (arg_fgrid.Buffer_CellData.Trim() == "") ? component : arg_fgrid.Buffer_CellData;
                        arg_fgrid[arg_fgrid.Row, arg_col_code] = "";

                        cr.StyleNew.ForeColor = Color.Black;

                    }
                    else if (arg_fgrid == fgrid_Yield)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_desc] = (arg_fgrid.Buffer_CellData.Trim() == "") ? component : arg_fgrid.Buffer_CellData;
                        arg_fgrid[arg_fgrid.Row, arg_col_code] = "";
                        arg_fgrid[arg_fgrid.Row, arg_col_name] = "";

                        cr.StyleNew.ForeColor = Color.Green;

                    }


                    //string message = "We must input component : [" + component + "]";
                    //ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Component", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    component_set_flag = false;

                }
                else
                {

                    return_component_cd = grid_combo.VRow[0].ToString();
                    return_component_name = grid_combo.VRow[1].ToString();


                    component_set_flag = true;

                }


                if (component_set_flag == false)
                {
                    arg_fgrid.Select(arg_fgrid.Row, arg_col_desc - 1, true);

                    return;
                }


                //-------------------------------------------------------------
                // component 신규 추가 중복 확인
                // 저장 된 데이터 (DB), 저장 전 데이터 (Grid) 모두 체크 필요
                //-------------------------------------------------------------
                string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                string component_cd = return_component_cd;
                string component_name = return_component_name;


                // DB 확인
                bool duplicate_flag = Check_Duplicate_Component(factory, style_cd, component_cd, false, arg_fgrid.Row);


                if (duplicate_flag)
                {

                    string message = "We have already component : [" + component_name + "]";
                    ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Component", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (arg_fgrid == fgrid_Excel)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_desc] = (arg_fgrid.Buffer_CellData.Trim() == "") ? component : arg_fgrid.Buffer_CellData;
                        arg_fgrid[arg_fgrid.Row, arg_col_code] = "";

                        cr.StyleNew.ForeColor = Color.Black;

                    }
                    else if (arg_fgrid == fgrid_Yield)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_desc] = (arg_fgrid.Buffer_CellData.Trim() == "") ? component : arg_fgrid.Buffer_CellData;
                        arg_fgrid[arg_fgrid.Row, arg_col_code] = "";
                        arg_fgrid[arg_fgrid.Row, arg_col_name] = "";

                        cr.StyleNew.ForeColor = Color.Green;

                    } 


                    return;

                }
                //-------------------------------------------------------------


                // 0 : component_cd, 1 : component_name


                if (arg_fgrid == fgrid_Excel)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_desc] = return_component_name;
                    arg_fgrid[arg_fgrid.Row, arg_col_code] = return_component_cd;

                    cr.StyleNew.ForeColor = Color.Red;

                    arg_fgrid.Select(arg_fgrid.Row + 1, arg_col_desc - 1, true);

                }
                else if (arg_fgrid == fgrid_Yield)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_desc] = return_component_name;
                    arg_fgrid[arg_fgrid.Row, arg_col_code] = return_component_cd;
                    arg_fgrid[arg_fgrid.Row, arg_col_name] = return_component_name;

                    cr.StyleNew.ForeColor = Color.Black;



                    // component view depth
                    Set_Component_ViewDepth(arg_fgrid.Row);



                }






            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Component", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

              
                if (arg_fgrid == fgrid_Excel)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_desc] = arg_fgrid.Buffer_CellData;
                    arg_fgrid[arg_fgrid.Row, arg_col_code] = "";

                    cr.StyleNew.ForeColor = Color.Black;

                }
                else if (arg_fgrid == fgrid_Yield)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_desc] = arg_fgrid.Buffer_CellData;
                    arg_fgrid[arg_fgrid.Row, arg_col_code] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_name] = "";

                    cr.StyleNew.ForeColor = Color.Green;

                } 




            }

        }




        /// <summary>
        /// Select_GridCombo_Item : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_col_desc"></param>
        /// <param name="arg_col_item_cd"></param>
        /// <param name="arg_col_item_name1"></param>
        /// <param name="arg_col_item_name2"></param>
        /// <param name="arg_col_unit"></param>
        /// <param name="arg_col_size"></param>
        /// <param name="arg_col_spec_cd"></param>
        /// <param name="arg_col_spec_name"></param>
        /// <param name="arg_col_color_cd"></param>
        /// <param name="arg_col_color_name"></param>
        private void Select_GridCombo_Item(COM.FSP arg_fgrid, 
            int arg_col_desc, 
            int arg_col_item_cd, 
            int arg_col_item_name1,
            int arg_col_item_name2, 
            int arg_col_unit, 
            int arg_col_size,
            int arg_col_spec_cd, 
            int arg_col_spec_name,
            int arg_col_color_cd,
            int arg_col_color_name)
        {


            if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_item_cd], "") != ""
                  && arg_fgrid.Buffer_CellData == Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "")) return;



            string not_assign_style_name = "";
            string assign_style_name = "";
            CellStyle cs_not_assign;
            CellStyle cs_assign;
                

            if (arg_fgrid == fgrid_Excel)
            {

                not_assign_style_name = "NOT_ASSIGN_EXCEL_ITEM_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_item_cd);
                cs_not_assign = arg_fgrid.Styles.Add(not_assign_style_name);
                cs_not_assign.ForeColor = Color.Black;
                //cs_not_assign.BackColor = Color.White;

                assign_style_name = "ASSIGN_EXCEL_ITEM_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_item_cd);
                cs_assign = arg_fgrid.Styles.Add(assign_style_name);
                cs_assign.ForeColor = Color.Red;
                //cs_assign.BackColor = Color.SeaShell;

            }
            else if (arg_fgrid == fgrid_Yield)
            {

                not_assign_style_name = "NOT_ASSIGN_YIELD_ITEM_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_item_cd);
                cs_not_assign = arg_fgrid.Styles.Add(not_assign_style_name);
                cs_not_assign.ForeColor = Color.Green;

                assign_style_name = "ASSIGN_YIELD_ITEM_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_item_cd);
                cs_assign = arg_fgrid.Styles.Add(assign_style_name);
                cs_assign.ForeColor = Color.Black;

            }



            bool item_set_flag = false;



            try
            {

                string item = Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "");

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

                DataTable dt_ret = SELECT_SBC_ITEM_COMBO(group_cd, item, code_div);

                

                FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                string[] key_string = new string[] { "ITEM_CD" };
                string[] value_string = new string[] { "ITEM_NAME1", "MNG_UNIT", "SIZE_YN" };

                grid_combo._JobDivision = "ITEM";
                grid_combo._ItemCD = item;
                grid_combo._KeyString = item;
                grid_combo.ShowData(dt_ret, key_string, value_string, true, item);
                grid_combo.StartPosition = FormStartPosition.CenterScreen;


                if (grid_combo.ShowDialog() != DialogResult.OK)
                {

                    //// 한번도 할당 안된 경우만 취소
                    //if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_item_cd], "").Trim() == "")
                    //{

                        if (arg_fgrid == fgrid_Excel)
                        {

                            arg_fgrid[arg_fgrid.Row, arg_col_desc] = (arg_fgrid.Buffer_CellData.Trim() == "") ? item : arg_fgrid.Buffer_CellData;
                            arg_fgrid[arg_fgrid.Row, arg_col_item_cd] = "";
                            arg_fgrid[arg_fgrid.Row, arg_col_unit] = "";
                            arg_fgrid[arg_fgrid.Row, arg_col_size] = "";

                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_desc, not_assign_style_name);


                        }
                        else if (arg_fgrid == fgrid_Yield)
                        {

                            arg_fgrid[arg_fgrid.Row, arg_col_desc] = (arg_fgrid.Buffer_CellData.Trim() == "") ? item : arg_fgrid.Buffer_CellData;
                            arg_fgrid[arg_fgrid.Row, arg_col_item_cd] = "";
                            arg_fgrid[arg_fgrid.Row, arg_col_item_name1] = "";
                            arg_fgrid[arg_fgrid.Row, arg_col_item_name2] = "";
                            arg_fgrid[arg_fgrid.Row, arg_col_unit] = "";
                            arg_fgrid[arg_fgrid.Row, arg_col_size] = "";

                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_desc, not_assign_style_name);
                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_unit, not_assign_style_name);

                        }


                        item_set_flag = false;

                    //}
                    //else
                    //{
                    //    item_set_flag = true;
                    //}

                }
                else
                {

                    if (arg_fgrid == fgrid_Excel)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_desc] = grid_combo.VRow[1];
                        arg_fgrid[arg_fgrid.Row, arg_col_item_cd] = grid_combo.VRow[0];
                        arg_fgrid[arg_fgrid.Row, arg_col_unit] = grid_combo.VRow[2];
                        arg_fgrid[arg_fgrid.Row, arg_col_size] = grid_combo.VRow[3];

                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_desc, assign_style_name);

                    }
                    else if (arg_fgrid == fgrid_Yield)
                    {


                        // 원자재만 작업 대상이 됨으로 display_desc에 item_name1 적용
                        arg_fgrid[arg_fgrid.Row, arg_col_desc] = grid_combo.VRow[1];
                        arg_fgrid[arg_fgrid.Row, arg_col_item_cd] = grid_combo.VRow[0];
                        arg_fgrid[arg_fgrid.Row, arg_col_item_name1] = grid_combo.VRow[1];
                        arg_fgrid[arg_fgrid.Row, arg_col_item_name2] = grid_combo.VRow[1];
                        arg_fgrid[arg_fgrid.Row, arg_col_unit] = grid_combo.VRow[2];
                        arg_fgrid[arg_fgrid.Row, arg_col_size] = grid_combo.VRow[3];

                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_desc, assign_style_name);
                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_unit, assign_style_name);

                        if (Empty_String(arg_fgrid[arg_fgrid.Row, 0], "") != "I")
                        {
                            arg_fgrid[arg_fgrid.Row, 0] = "U";
                        }

                    }


                    item_set_flag = true;

                }


                //-----------------------------------------------------
                // 아이템이 선택 된 경우 spec list grid combo 자동 표시
                //-----------------------------------------------------
                if (item_set_flag)
                {

                    //arg_fgrid.Select(arg_fgrid.Row, arg_col_spec_name, true);
                    arg_fgrid.Buffer_CellData = Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_spec_name], "");

                    Select_GridCombo_Spec(arg_fgrid,
                        arg_col_item_cd,
                        arg_col_item_name1,
                        arg_col_spec_cd,
                        arg_col_spec_name,
                        arg_col_color_cd,
                        arg_col_color_name,
                        Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_item_cd], ""));


                }
                else
                {
                    arg_fgrid.Select(arg_fgrid.Row, arg_col_desc - 1, true);

                    if (arg_fgrid == fgrid_Excel)
                    {
                        // un check
                        arg_fgrid.SetCellCheck(arg_fgrid.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);
                    }

                    //return;

                } // end if
                //-----------------------------------------------------


             
            }
            catch (Exception ex)
            {
               
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (arg_fgrid == fgrid_Excel)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_desc] = arg_fgrid.Buffer_CellData;
                    arg_fgrid[arg_fgrid.Row, arg_col_item_cd] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_unit] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_size] = "";

                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_desc, not_assign_style_name);


                }
                else if (arg_fgrid == fgrid_Yield)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_desc] = arg_fgrid.Buffer_CellData;
                    arg_fgrid[arg_fgrid.Row, arg_col_item_cd] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_item_name1] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_item_name2] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_unit] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_size] = "";

                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_desc, not_assign_style_name);
                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_unit, not_assign_style_name);

                } 


            }



        }



        
        /// <summary>
        /// Select_GridCombo_Spec : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_col_item_cd"></param>
        /// <param name="arg_col_item_name1"></param>
        /// <param name="arg_col_spec_cd"></param>
        /// <param name="arg_col_spec_name"></param>
        /// <param name="arg_col_color_cd"></param>
        /// <param name="arg_col_color_name"></param>
        /// <param name="arg_item_cd"></param>
        private void Select_GridCombo_Spec(COM.FSP arg_fgrid,
            int arg_col_item_cd, 
            int arg_col_item_name1,
            int arg_col_spec_cd, 
            int arg_col_spec_name,
            int arg_col_color_cd,
            int arg_col_color_name,
            string arg_item_cd)
        {


            if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_spec_cd], "") != ""
                  && fgrid_Yield.Buffer_CellData == Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "")) return;



            string not_assign_style_name = "";
            string assign_style_name = "";
            CellStyle cs_not_assign;
            CellStyle cs_assign;


            if (arg_fgrid == fgrid_Excel)
            {

                not_assign_style_name = "NOT_ASSIGN_EXCEL_SPEC_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_spec_cd);
                cs_not_assign = arg_fgrid.Styles.Add(not_assign_style_name);
                cs_not_assign.ForeColor = Color.Black;
                //cs_not_assign.BackColor = Color.White;

                assign_style_name = "ASSIGN_EXCEL_SPEC_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_spec_cd);
                cs_assign = arg_fgrid.Styles.Add(assign_style_name);
                cs_assign.ForeColor = Color.Red;
                //cs_assign.BackColor = Color.SeaShell;

            }
            else if (arg_fgrid == fgrid_Yield)
            {

                not_assign_style_name = "NOT_ASSIGN_YIELD_SPEC_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_spec_cd);
                cs_not_assign = arg_fgrid.Styles.Add(not_assign_style_name);
                cs_not_assign.ForeColor = Color.Green;

                assign_style_name = "ASSIGN_YIELD_SPEC_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_spec_cd);
                cs_assign = arg_fgrid.Styles.Add(assign_style_name);
                cs_assign.ForeColor = Color.Black;

            }



            bool spec_set_flag = false;

            try
            {


                string spec = "";
                DataTable dt_ret = null;


                if (arg_item_cd.Trim() == "")
                {

                    spec = Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "");

                    if (spec.Trim().Equals("")) return;

                    dt_ret = SELECT_SBC_SPEC_COMBO("", spec);

                }
                else
                {
                    dt_ret = SELECT_SBC_ITEM_SPEC_COMBO(arg_item_cd);
                }



              

                // 정확하게 일치하는 아이템이 있는 경우 바로 세팅, 없으면 리스트 표시
                // SPEC_CD, SPEC_NAME, CORRECT_ITEM_FLAG
                if (dt_ret != null && dt_ret.Rows.Count > 0 && Empty_String(dt_ret.Rows[0].ItemArray[2], "") == "Y")
                {


                    if (arg_fgrid == fgrid_Excel)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = Empty_String(dt_ret.Rows[0].ItemArray[0], "");
                        arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = Empty_String(dt_ret.Rows[0].ItemArray[1], "");

                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, assign_style_name);

                    }
                    else if (arg_fgrid == fgrid_Yield)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = Empty_String(dt_ret.Rows[0].ItemArray[0], "");
                        arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = Empty_String(dt_ret.Rows[0].ItemArray[1], "");

                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, assign_style_name);

                        if (Empty_String(arg_fgrid[arg_fgrid.Row, 0], "") != "I")
                        {
                            arg_fgrid[arg_fgrid.Row, 0] = "U";
                        }

                    } 



                    spec_set_flag = true;


                }
                else
                {

                    FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                    string[] key_string = new string[] { "SPEC_CD" };
                    string[] value_string = new string[] { "SPEC_NAME" };

                    grid_combo._JobDivision = "SPEC";
                    grid_combo._ItemCD = arg_item_cd;
                    grid_combo._KeyString = spec;
                    grid_combo.ShowData(dt_ret, key_string, value_string, true, spec);
                    grid_combo.StartPosition = FormStartPosition.CenterScreen;



                    if (grid_combo.ShowDialog() != DialogResult.OK)
                    {

                        //// 한번도 할당 안된 경우만 취소
                        //if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_spec_cd], "").Trim() == "")
                        //{
                            if (arg_fgrid == fgrid_Excel)
                            {

                                arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = "";
                                arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = (arg_fgrid.Buffer_CellData.Trim() == "") ? spec : arg_fgrid.Buffer_CellData;

                                arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, not_assign_style_name);

                            }
                            else if (arg_fgrid == fgrid_Yield)
                            {

                                arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = "";
                                arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = (arg_fgrid.Buffer_CellData.Trim() == "") ? spec : arg_fgrid.Buffer_CellData;

                                arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, not_assign_style_name);

                            }


                            spec_set_flag = false;

                        //}
                        //else
                        //{
                        //    spec_set_flag = true;
                        //}

                    }
                    else
                    {

                        if (arg_fgrid == fgrid_Excel)
                        {

                            arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = grid_combo.VRow[0];
                            arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = grid_combo.VRow[1];

                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, assign_style_name);

                        }
                        else if (arg_fgrid == fgrid_Yield)
                        {

                            arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = grid_combo.VRow[0];
                            arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = grid_combo.VRow[1];

                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, assign_style_name);

                            if (Empty_String(arg_fgrid[arg_fgrid.Row, 0], "") != "I")
                            {
                                arg_fgrid[arg_fgrid.Row, 0] = "U";
                            }

                        }



                        spec_set_flag = true;

                    } // if grid combo OK return


                } // if 정확하게 일치하는 아이템 



                //-----------------------------------------------------
                // Item, Spec 모두 할당 되어 있는 경우
                //-----------------------------------------------------
                if (spec_set_flag)
                {

                    if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_item_cd], "") != ""
                        && Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_spec_cd], "") != "")
                    {

                        // spec list 저장
                        SAVE_SBC_ITEM_SPEC_COMBO(Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_item_cd], ""), Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_spec_cd], ""), "I");


                        // Color 조회 대상 있을 경우 Color 자동 실행
                        if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_color_name], "") != "")
                        {

                            arg_fgrid.Select(arg_fgrid.Row, arg_col_color_name, true);
                            //arg_fgrid.Buffer_CellData = Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_color_name], "");

                            Select_GridCombo_Color(arg_fgrid,
                                arg_col_item_cd,
                                arg_col_item_name1,
                                arg_col_spec_cd,
                                arg_col_spec_name,
                                arg_col_color_cd,
                                arg_col_color_name);
                             
                        }
                        else
                        {
                            arg_fgrid.Select(arg_fgrid.Row, arg_col_color_name - 1, true);
                        }


                    }  // end if Item, Spec 모두 할당 되어 있는 경우

                }
                else
                {
                    arg_fgrid.Select(arg_fgrid.Row, arg_col_spec_name - 1, true);

                    if (arg_fgrid == fgrid_Excel)
                    {
                        // un check
                        arg_fgrid.SetCellCheck(arg_fgrid.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);
                    }

                    //return;

                } // end if
                //----------------------------------------------------- 



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Spec", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (arg_fgrid == fgrid_Excel)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = arg_fgrid.Buffer_CellData;

                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, not_assign_style_name);

                }
                else if (arg_fgrid == fgrid_Yield)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_spec_cd] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_spec_name] = arg_fgrid.Buffer_CellData;

                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_spec_name, not_assign_style_name);

                } 


            }


        }



        
        /// <summary>
        /// Select_GridCombo_Color : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_col_item_cd"></param>
        /// <param name="arg_col_item_name1"></param>
        /// <param name="arg_col_spec_cd"></param>
        /// <param name="arg_col_spec_name"></param>
        /// <param name="arg_col_color_cd"></param>
        /// <param name="arg_col_color_name"></param>
        private void Select_GridCombo_Color(COM.FSP arg_fgrid,
            int arg_col_item_cd,
            int arg_col_item_name1,
            int arg_col_spec_cd,
            int arg_col_spec_name,
            int arg_col_color_cd,
            int arg_col_color_name)
        {


            if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_color_cd], "") != ""
                 && fgrid_Yield.Buffer_CellData == Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "")) return;



            string not_assign_style_name = "";
            string assign_style_name = "";
            CellStyle cs_not_assign;
            CellStyle cs_assign;


            if (arg_fgrid == fgrid_Excel)
            {

                not_assign_style_name = "NOT_ASSIGN_EXCEL_COLOR_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_color_cd);
                cs_not_assign = arg_fgrid.Styles.Add(not_assign_style_name);
                cs_not_assign.ForeColor = Color.Black;
                //cs_not_assign.BackColor = Color.White;

                assign_style_name = "ASSIGN_EXCEL_COLOR_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_color_cd);
                cs_assign = arg_fgrid.Styles.Add(assign_style_name);
                cs_assign.ForeColor = Color.Red;
                //cs_assign.BackColor = Color.SeaShell;

            }
            else if (arg_fgrid == fgrid_Yield)
            {

                not_assign_style_name = "NOT_ASSIGN_YIELD_COLOR_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_color_cd);
                cs_not_assign = arg_fgrid.Styles.Add(not_assign_style_name);
                cs_not_assign.ForeColor = Color.Green;

                assign_style_name = "ASSIGN_YIELD_COLOR_" + Convert.ToString(arg_fgrid.Row) + Convert.ToString(arg_col_color_cd);
                cs_assign = arg_fgrid.Styles.Add(assign_style_name);
                cs_assign.ForeColor = Color.Black;

            }



            bool color_set_flag = false;

            try
            {


                string color = Empty_String(arg_fgrid[arg_fgrid.Row, arg_fgrid.Col], "");

                if (color.Trim().Equals("")) return;

                DataTable dt_ret = SELECT_SBC_COLOR_COMBO(color);

                

                // 정확하게 일치하는 아이템이 있는 경우 바로 세팅, 없으면 리스트 표시
                // COLOR_CD, COLOR_NAME, CORRECT_ITEM_FLAG
                if (dt_ret != null && dt_ret.Rows.Count > 0 && Empty_String(dt_ret.Rows[0].ItemArray[2], "") == "Y")
                {


                    if (arg_fgrid == fgrid_Excel)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = Empty_String(dt_ret.Rows[0].ItemArray[0], "");
                        arg_fgrid[arg_fgrid.Row, arg_col_color_name] = Empty_String(dt_ret.Rows[0].ItemArray[1], "");

                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, assign_style_name);


                    }
                    else if (arg_fgrid == fgrid_Yield)
                    {

                        arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = Empty_String(dt_ret.Rows[0].ItemArray[0], "");
                        arg_fgrid[arg_fgrid.Row, arg_col_color_name] = Empty_String(dt_ret.Rows[0].ItemArray[1], "");

                        arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, assign_style_name);

                        if (Empty_String(arg_fgrid[arg_fgrid.Row, 0], "") != "I")
                        {
                            arg_fgrid[arg_fgrid.Row, 0] = "U";
                        }

                    }


                    color_set_flag = true;

                }
                else
                {

                    FlexBase.Yield_New.Pop_Yield_Grid_Combo grid_combo = new Pop_Yield_Grid_Combo();

                    string[] key_string = new string[] { "COLOR_CD" };
                    string[] value_string = new string[] { "COLOR_NAME" };

                    grid_combo._JobDivision = "COLOR";
                    grid_combo._KeyString = color;
                    grid_combo.ShowData(dt_ret, key_string, value_string, true, color);
                    grid_combo.StartPosition = FormStartPosition.CenterScreen;



                    if (grid_combo.ShowDialog() != DialogResult.OK)
                    {

                        //// 한번도 할당 안된 경우만 취소
                        //if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_color_cd], "").Trim() == "")
                        //{

                            if (arg_fgrid == fgrid_Excel)
                            {

                                arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = "";
                                arg_fgrid[arg_fgrid.Row, arg_col_color_name] = (arg_fgrid.Buffer_CellData.Trim() == "") ? color : arg_fgrid.Buffer_CellData;

                                arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, not_assign_style_name);

                            }
                            else if (arg_fgrid == fgrid_Yield)
                            {

                                arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = "";
                                arg_fgrid[arg_fgrid.Row, arg_col_color_name] = (arg_fgrid.Buffer_CellData.Trim() == "") ? color : arg_fgrid.Buffer_CellData;

                                arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, not_assign_style_name);

                            }


                            color_set_flag = false;

                        //}
                        //else
                        //{

                        //    color_set_flag = true;
                        //}

                        

                    }
                    else
                    {

                        if (arg_fgrid == fgrid_Excel)
                        {

                            arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = grid_combo.VRow[0];
                            arg_fgrid[arg_fgrid.Row, arg_col_color_name] = grid_combo.VRow[1];

                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, assign_style_name);

                        }
                        else if (arg_fgrid == fgrid_Yield)
                        {

                            arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = grid_combo.VRow[0];
                            arg_fgrid[arg_fgrid.Row, arg_col_color_name] = grid_combo.VRow[1];

                            arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, assign_style_name);

                            if (Empty_String(arg_fgrid[arg_fgrid.Row, 0], "") != "I")
                            {
                                arg_fgrid[arg_fgrid.Row, 0] = "U";
                            }


                        }
                        
                        color_set_flag = true;


                    } // if grid combo OK return


                } // if 정확하게 일치하는 아이템 



                //-----------------------------------------------------
                // color 설정 되지 않은 경우
                //-----------------------------------------------------
                if (color_set_flag == false)
                {

                    arg_fgrid.Select(arg_fgrid.Row, arg_col_color_name - 1, true);

                    if (arg_fgrid == fgrid_Excel)
                    {
                        // un check
                        arg_fgrid.SetCellCheck(arg_fgrid.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);
                    }

                    return;

                }
                //-----------------------------------------------------


                //-----------------------------------------------------
                // 원자재 모두 입력되었는지 확인
                // item, spec, color 없으면 설정 할 수 없음
                if (Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_item_cd], "") == ""
                    || Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_spec_cd], "") == ""
                    || Empty_String(arg_fgrid[arg_fgrid.Row, arg_col_color_cd], "") == "")
                {

                    if (arg_fgrid == fgrid_Excel)
                    {
                        // un check
                        arg_fgrid.SetCellCheck(arg_fgrid.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);

                    }

                    return;
                }
                //-----------------------------------------------------



                if (arg_fgrid == fgrid_Excel)
                {

                    // check
                    arg_fgrid.SetCellCheck(arg_fgrid.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Checked);


                    if (arg_fgrid.Row == arg_fgrid.Rows.Count - 1)
                    {
                        arg_fgrid.Select(arg_fgrid.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, true);
                    }
                    else
                    {
                        arg_fgrid.Select(arg_fgrid.Row + 1, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, true);
                    }


                }
                else if (arg_fgrid == fgrid_Yield)
                {

                    // 사이즈 자재 여부에 따른 채산값 재 설정
                    // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                    Reset_Size_Material(arg_fgrid.Row);

                    // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
                    Reset_Joint_BOM(arg_fgrid.Row);


                    arg_fgrid.Select(arg_fgrid.Row, arg_col_color_name - 1, true);

                }




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_GridCombo_Color", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (arg_fgrid == fgrid_Excel)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_color_name] = arg_fgrid.Buffer_CellData;

                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, not_assign_style_name);

                }
                else if (arg_fgrid == fgrid_Yield)
                {

                    arg_fgrid[arg_fgrid.Row, arg_col_color_cd] = "";
                    arg_fgrid[arg_fgrid.Row, arg_col_color_name] = arg_fgrid.Buffer_CellData;

                    arg_fgrid.SetCellStyle(arg_fgrid.Row, arg_col_color_name, not_assign_style_name);

                } 


            }



        }





        #endregion



        /// <summary>
        /// Check_Duplicate_Component : component 신규 추가 중복 확인, 저장 된 데이터 (DB), 저장 전 데이터 (Grid) 모두 체크 필요
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <param name="arg_db_check"></param>
        /// <param name="arg_sel_row"></param>
        /// <returns></returns>
        private bool Check_Duplicate_Component(string arg_factory, string arg_style_cd, string arg_component_cd, bool arg_db_check, int arg_sel_row)
        {


            try
            {



                bool duplicate_flag = false;


                // DB 확인
                if (arg_db_check)
                {

                    duplicate_flag = CHECK_SBC_YIELD_COMPONENT(arg_factory, arg_style_cd, arg_component_cd);

                    if (duplicate_flag)
                    {
                        return duplicate_flag;
                    }

                }



                // Grid 확인
                // (arg_db_check == true) insert 표시 된 것만, 다른 것은 이미 저장 된 데이터 이므로 DB 확인에서 처리 됨
                duplicate_flag = false;

                string now_division = "";
                string now_row_type = "";
                string now_component_cd = "";

                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {


                    now_division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                    now_row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                    now_component_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");


                    // component 아니면 제외
                    if (now_row_type != _RowType_Component) continue;

                    //// 현재 수정 중인 I division 제외
                    //if (i == arg_sel_row && now_division == "I") continue;

                    // 삭제 될 예정이므로 중복 체크 대상에서 제외
                    if (now_division == "D" || now_division == "M") continue;

                    // 현재 작업 중인 행 제외
                    if (i != -1 && i == arg_sel_row) continue;

                    if (now_component_cd == arg_component_cd)
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
        /// Event_fgrid_Yield_KeyDown : 
        /// </summary>
        /// <param name="e"></param>
        private void Event_fgrid_Yield_KeyDown(KeyEventArgs e)
        {

            try
            {


                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                if (e.Control && e.KeyCode == Keys.F)
                {
                    Show_Find_Material();
                }



                // check in 되어야만 가능한 작업
                if (!chk_CheckInOut.Checked) return;



                //if (e.Control && e.KeyCode == Keys.C)
                //{
                //    //Data_Copy_Cut("COPY");
                //}
                //else if (e.Control && e.KeyCode == Keys.V)
                //{
                //    Data_Paste();
                //}
                //else if (e.Control && e.KeyCode == Keys.X)
                //{
                //    Data_Copy_Cut("CUT");
                //} 



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_KeyDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #region copy, paste, cut

        
        // 이동되어지는 행 정보
        System.Collections.ArrayList _Data_Copy_Array;


        // 이동되어지는 타입 : COPY, PASTE, CUT
        private string _Data_Move_Type = "";


        /// <summary>
        /// Set_Default_BorderColor : 
        /// </summary>
        private void Set_Default_BorderColor()
        {

            if (_Data_Copy_Array == null) return;


            foreach (C1.Win.C1FlexGrid.Row row in _Data_Copy_Array)
            {
                row.Style.Border.Color = Color.FromArgb(255, 236, 233, 216);
                row.Style.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Both;
            }


        }



        /// <summary>
        /// Data_Copy : 
        /// </summary>
        private void Data_Copy_Cut(string arg_data_move_type)
        {


            Set_Default_BorderColor();

            _Data_Copy_Array = new System.Collections.ArrayList();
            _Data_Move_Type = arg_data_move_type;


            //string row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

            //if (row_type != _RowType_Component) return;


            ////------------------------------------------
            //// component 처음과 마지막 행 계산
            ////------------------------------------------
            //string sel_component = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
            //string now_component = "";
            //string now_division = "";


            //for (int i = fgrid_Yield.Row; i < fgrid_Yield.Rows.Count; i++)
            //{

            //    // Move 되어 이동되어 진 후에 삭제 될 division은 제외, 같은 데이터 I로 추가 되어 있는 상태임
            //    now_division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
            //    if (now_division == "M") continue;


            //    now_component = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

            //    if (sel_component != now_component)
            //    {
            //        break;
            //    }

            //    fgrid_Yield.Rows[i].Selected = true;


            //} // end for i
            ////------------------------------------------

            string row_type = "";
            string now_division = "";
            string sel_component = "";
            string now_component = "";

            //------------------------------------------
            // 선택 구간 설정
            //------------------------------------------
            int[] sel_row_range = fgrid_Yield.Selections;


            // component 밑에 원자재 구조까지 모두 선택하게 하기 위함

            foreach (int sel_row in sel_row_range)
            {

                row_type = Empty_String(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

                // component row 일때,
                if (row_type != _RowType_Component) continue;

                // component 아래 아이템들이 있을때,
                if (fgrid_Yield.Rows[sel_row].Node.Children == 0) continue;


                sel_component = Empty_String(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

                for (int i = sel_row; i < fgrid_Yield.Rows.Count; i++)
                {

                    // Move 되어 이동되어 진 후에 삭제 될 division은 제외, 같은 데이터 I로 추가 되어 있는 상태임
                    now_division = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");

                    if (now_division == "M")
                    {
                        fgrid_Yield.Rows[i].Selected = false;
                        continue;
                    }


                    now_component = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

                    if (sel_component != now_component)
                    {
                        break;
                    }

                    fgrid_Yield.Rows[i].Selected = true;


                } // end for i



            } // end foreach

            sel_row_range = fgrid_Yield.Selections;
            //------------------------------------------


            //------------------------------------------
            // copy data array
            //------------------------------------------
            _Run_Event_Display_Value = false;


            sel_row_range = fgrid_Yield.Selections;

            foreach (int sel_row in sel_row_range)
            {


                _Data_Copy_Array.Add(fgrid_Yield.Rows[sel_row]);


                if (_Data_Move_Type == "COPY")
                {
                    fgrid_Yield.Rows[sel_row].StyleNew.Border.Color = Color.Blue;
                }
                else if (_Data_Move_Type == "CUT")
                {
                    fgrid_Yield.Rows[sel_row].StyleNew.Border.Color = Color.Red;
                }

                fgrid_Yield.Rows[sel_row].StyleNew.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;


            } // end foreach
            

            _Run_Event_Display_Value = true;
            //------------------------------------------


        }



        /// <summary>
        /// Data_Paste : 
        /// </summary>
        private void Data_Paste()
        {


            try
            {

                this.Cursor = Cursors.WaitCursor;



                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;

                if (_Data_Copy_Array == null) return;



                //----------------------------------------------------------------
                // 추가 행 선택, component_seq 계산
                //----------------------------------------------------------------
                string sel_row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                string now_row_type = "";
                string sel_semi_good = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                int sel_row = fgrid_Yield.Row;

                int insert_row = -1;
                int next_component_seq = 0;



                if (sel_row_type != _RowType_Semigood && sel_row_type != _RowType_Component)
                {
                    string message = "Semigood or Component should be selected.";
                    ClassLib.ComFunction.User_Message(message, "Data_Paste", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }


                

                //if (_Data_Move_Type == "CUT")
                //{

                //    foreach (C1.Win.C1FlexGrid.Row row in _Data_Copy_Array)
                //    {

                //        row[(int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "M";

                //        //row.Visible = false;
                //        row.Height = 0;

                //    } // end foreach

                //}




                insert_row = Get_Next_Insert_Row(sel_row, true);


                int copy_count = 0;


                foreach (C1.Win.C1FlexGrid.Row row in _Data_Copy_Array)
                {


                    now_row_type = Empty_String(row[(int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");


                    if (now_row_type == _RowType_Component)
                    {


                        // component seq 계산
                        next_component_seq = Get_Next_Component_Seq(sel_row, true);



                        // 다음 component 그룹 seq 계산하기 위함
                        sel_row_type = _RowType_Component;
                        sel_row = insert_row + copy_count;



                        // component 중복 확인
                        string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                        string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                        string component_cd = Empty_String(row[(int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                        string component_name = Empty_String(row[(int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");

                        //bool duplicate_flag = Check_Duplicate_Component(factory, style_cd, component_cd, false, -1);

                        //선택한 행 제외하고 중복 검사
                        bool duplicate_flag = Check_Duplicate_Component(factory, style_cd, component_cd, false, row.Index);


                        if (duplicate_flag)
                        {

                            string message = "We have already component : [" + component_name + "]";
                            ClassLib.ComFunction.User_Message(message, "Select_GridCombo_Component_for_Yield", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;

                        }


                    } // end if (row_type == _RowType_Component)



                    //-------------------------------------------------
                    // 기존 데이터 숨김
                    //-------------------------------------------------
                    row[(int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "M";

                    //row.Visible = false;
                    row.Height = 0;
                    //-------------------------------------------------


                    fgrid_Yield.Rows.Insert(insert_row + copy_count);
                    fgrid_Yield.Rows[insert_row + copy_count].IsNode = true;
                    fgrid_Yield.Rows[insert_row + copy_count].Node.Level = Convert.ToInt32(Empty_String(row[(int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL], "0"));

                    if (now_row_type == _RowType_Component)
                    {
                        fgrid_Yield.GetCellRange(insert_row + copy_count, 1, insert_row + copy_count, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;
                    }



                    //-------------------------------------------------
                    // 데이터 이동
                    //-------------------------------------------------
                    for (int i = 0; i < fgrid_Yield.Cols.Count; i++)
                    {

                        fgrid_Yield[insert_row + copy_count, i] = Empty_String(row[i], "");


                        // spec 정보 이동
                        if (i >= (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START)
                        {

                            CellRange cr = fgrid_Yield.GetCellRange(insert_row + copy_count, i);
                            cr.UserData = Empty_String(fgrid_Yield.GetCellRange(row.Index, i).UserData, "");

                        }

                    } // end for i
                    //-------------------------------------------------

                    //-------------------------------------------------
                    // 데이터 이동 후 수정
                    //-------------------------------------------------
                    fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";

                    // semi_good userdata 에 옮기기 전 semi_good 정보 기록 : history 저장 위함
                    CellRange cr_sg = fgrid_Yield.GetCellRange(insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD);
                    cr_sg.UserData = Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");

                    // 옮겨진 semi_good 으로 업데이트
                    fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = sel_semi_good;


                    fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = next_component_seq.ToString();
                    //-------------------------------------------------

                    //-------------------------------------------------
                    // 사이즈 자재 표시
                    //-------------------------------------------------
                    // 원자재 모두 입력되었는지 확인
                    // item, spec, color 없으면 설정 할 수 없음
                    string not_assign_style_name = "NOT_ASSIGN_SECOND_" + Convert.ToString(insert_row + copy_count) + Convert.ToString((int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC);
                    CellStyle cs_not_assign = fgrid_Yield.Styles.Add(not_assign_style_name);
                    cs_not_assign.ForeColor = Color.Green;


                    if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component)
                    {

                        if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == "")
                        {
                            fgrid_Yield.SetCellStyle(insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, not_assign_style_name);
                            fgrid_Yield.SetCellStyle(insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT, not_assign_style_name);
                        }

                        if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == "")
                        {
                            fgrid_Yield.SetCellStyle(insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD, not_assign_style_name);
                        }

                        if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                        {
                            fgrid_Yield.SetCellStyle(insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME, not_assign_style_name);
                        }


                        // 원자재 모두 입력 된 경우
                        if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") != ""
                            && Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") != ""
                            && Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") != "")
                        {

                            Display_Grid_Yield_Size_Material(insert_row + copy_count);

                        }


                    } // end if (now_row_type != _RowType_Component)


                    //if (now_row_type != _RowType_Component
                    //    && (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                    //        || Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                    //        || Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == ""))
                    //{

                    //    if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == "")
                    //    {
                    //        fgrid_Yield.SetCellStyle(fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, not_assign_style_name);
                    //        fgrid_Yield.SetCellStyle(fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT, not_assign_style_name);
                    //    }
                    //    else if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == "")
                    //    {
                    //        fgrid_Yield.SetCellStyle(fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD, not_assign_style_name);
                    //    }
                    //    else if (Empty_String(fgrid_Yield[insert_row + copy_count, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                    //    {
                    //        fgrid_Yield.SetCellStyle(fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME, not_assign_style_name);
                    //    }


                    //    continue;
                    //}


                    //if (now_row_type != _RowType_Component)
                    //{
                    //    Display_Grid_Yield_Size_Material(insert_row + copy_count);
                    //}
                    //-------------------------------------------------



                    copy_count++;



                } // end foreach (C1.Win.C1FlexGrid.Row row in _Data_Copy_Array) 
                //-------------------------------------------------

 


                
                //if (rad_SG.Checked)
                //{
                //    fgrid_Yield.Tree.Show(Convert.ToInt32(rad_SG.Tag.ToString()));
                //}
                //else if (rad_Comp.Checked)
                //{
                //    fgrid_Yield.Tree.Show(Convert.ToInt32(rad_Comp.Tag.ToString()));
                //}
                //else
                //{
                //    fgrid_Yield.Tree.Show(Convert.ToInt32(rad_All.Tag.ToString()));
                //}

                //-----------------------------------
                // 조회 후 view depth 유지
                //-----------------------------------
                for (int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
                {

                    if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;

                    string condition = @"COMPONENT_CD = '" + Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "") + "'";

                    DataRow[] findrow = _DT_Component_ViewDepth.Select(condition);

                    if (findrow.Length == 0) continue;

                    fgrid_Yield.Rows[i].Node.Collapsed = (bool)findrow[0][2];

                }
                //-----------------------------------



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Data_Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }




        #endregion



        /// <summary>
        /// Show_Find_Material : find popup
        /// </summary>
        private void Show_Find_Material()
        {

            try
            {

                FlexBase.Yield_New.Pop_Finder pop_form = new FlexBase.Yield_New.Pop_Finder(fgrid_Yield, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC);
                pop_form.Location = new Point(MousePosition.X, MousePosition.Y);
                pop_form.Show();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Show_Find_Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

         
         
        /// <summary>
        /// Event_fgrid_Yield_AfterSelChange : 
        /// </summary>
        private void Event_fgrid_Yield_AfterSelChange(RangeEventArgs e)
        {

            try
            {


                if (!_Run_Event_Display_Value) return;



                // value size row 생성
                Set_Yield_Value_Row();



                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                string row_type = Empty_String(fgrid_Yield[e.NewRange.r1, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                string size_yn = Empty_String(fgrid_Yield[e.NewRange.r1, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
                

                if (row_type != _RowType_Material && row_type != _RowType_JointMaterial) return;


                string[] token = null;
                string spec_cd = "";
                string spec_name = "";


                // item, spec, color 설정 하기 전
                string spec_cd_detail = Empty_String(fgrid_Yield.GetCellRange(e.NewRange.r1, (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START).UserData, "");
                if (spec_cd_detail == "") return;
                

                // item, spec, color 설정 된 상태에서 신규일 때, (채산값 입력 해야 할 때)
                string spec_yield_detail = Empty_String(fgrid_Yield[e.NewRange.r1, (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START], "");

                if (spec_yield_detail == "")
                {

                    for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                    {
                       
                        fgrid_Value[_Value_Row_SpecCode, (i - (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START]
                         = Empty_String(fgrid_Yield[e.NewRange.r1, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");

                        fgrid_Value[_Value_Row_SpecName, (i - (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START]
                            = Empty_String(fgrid_Yield[e.NewRange.r1, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");

                      
                    } // end for i

                }
                else
                {

                    for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                    {

                        // - 3 : value
                        fgrid_Value[_Value_Row_Yield, (i - (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START]
                            = Empty_String(fgrid_Yield[e.NewRange.r1, i], "");


                        if (fgrid_Yield.GetCellRange(e.NewRange.r1, i).UserData == null)
                        {
                            spec_cd = "";
                            spec_name = "";
                        }
                        else
                        {
                            token = fgrid_Yield.GetCellRange(e.NewRange.r1, i).UserData.ToString().Split(_UserData_Spec_Symbol.ToCharArray());
                            spec_cd = token[0];
                            spec_name = token[1];
                        }

                        // -2 : spec_name
                        fgrid_Value[_Value_Row_SpecCode, (i - (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START] = spec_cd;

                        // -1 : spec_cd
                        fgrid_Value[_Value_Row_SpecName, (i - (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START] = spec_name;



                    } // end for i



                } // end if (spec_yield_detail == "")




                // 사이즈 자재 표시
                Display_Grid_Yield_Size_Material_Value(size_yn);


                fgrid_Value.LeftCol = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START - 1;
                fgrid_Value.Select(_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START, true);


                if (size_yn == "Y")
                {
                    fgrid_Value.Rows[_Value_Row_Yield].AllowEditing = false;

                    if (chk_CheckInOut.Checked)
                    {
                        btn_GetSpecBySize.Enabled = true;
                    }
                    else
                    {
                        btn_GetSpecBySize.Enabled = false;
                    }
                }
                else
                {
                    fgrid_Value.Rows[_Value_Row_Yield].AllowEditing = true;
                    btn_GetSpecBySize.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_AfterSelChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_fgrid_Yield_AfterResizeColumn : 
        /// </summary>
        private void Event_fgrid_Yield_AfterResizeColumn(RowColEventArgs e)
        {

            try
            {


                if (e.Col < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START) return;



                for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                {
                    fgrid_Yield.Cols[i].Width = fgrid_Yield.Cols[e.Col].Width;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_AfterResizeColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_fgrid_Excel_MouseHoverCell : 
        /// </summary>
        private void Event_fgrid_Excel_MouseHoverCell()
        {
          
            try
            {

                if (! _MoveMouseAfterEdit_Start)
                {
                    _MoveMouseCol = fgrid_Excel.MouseCol;
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Excel_MouseHoverCell", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Event_fgrid_Excel_StartEdit : 
        /// </summary>
        private void Event_fgrid_Excel_StartEdit()
        {

            try
            {


                _MoveMouseAfterEdit_Start = true;


                fgrid_Excel.Buffer_CellData = fgrid_Excel[fgrid_Excel.Row, fgrid_Excel.Col] == null ? "" : fgrid_Excel[fgrid_Excel.Row, fgrid_Excel.Col].ToString();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Excel_StartEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_fgrid_Excel_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Excel_AfterEdit()
        {

            try
            {





                if (fgrid_Excel.Rows.Count <= fgrid_Excel.Rows.Fixed)
                {
                    _MoveMouseAfterEdit_Start = false;
                    return;
                }


                if (fgrid_Excel.Col != _MoveMouseCol)
                {
                    _MoveMouseAfterEdit_Start = false;
                    return;
                }


                if (Empty_String(fgrid_Excel[fgrid_Excel.Row, fgrid_Excel.Col], "") == "")
                {
                    _MoveMouseAfterEdit_Start = false;
                    return;
                }




                // component 이름 지정
                if (fgrid_Excel.Col == (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL
                    && fgrid_Excel.Rows[fgrid_Excel.Row].Node.Level == 1)
                {

                    Select_GridCombo_Component(fgrid_Excel,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT,
                           -1,
                           false);

                }
                else if (fgrid_Excel.Col == (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL
                         && fgrid_Excel.Rows[fgrid_Excel.Row].Node.Level == 2)
                {

                    Select_GridCombo_Item(fgrid_Excel,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD,
                           -1,
                           -1,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMNG_UNIT,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSIZE_YN,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR);


                }
                else if (fgrid_Excel.Col == (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT
                         && fgrid_Excel.Rows[fgrid_Excel.Row].Node.Level == 2)
                {

                    Select_GridCombo_Spec(fgrid_Excel,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD,
                           -1,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR,
                           "");

                }
                else if (fgrid_Excel.Col == (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR
                         && fgrid_Excel.Rows[fgrid_Excel.Row].Node.Level == 2)
                {

                    Select_GridCombo_Color(fgrid_Excel,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD,
                           -1,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD,
                           (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR);

                }



                _MoveMouseAfterEdit_Start = false;


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Excel_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_fgrid_Value_AfterResizeColumn : 
        /// </summary>
        private void Event_fgrid_Value_AfterResizeColumn(RowColEventArgs e)
        {

            try
            {


                if (e.Col < (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) return;


                for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
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

                string size_yn = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
                string row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");


                // 채산값 등록
                if (size_yn != "Y")
                {
                    Input_Yield_Value_Size_No();


                    // 임가공 구조일 때 임가공 채산값 등록 하면 원자재 모두 적용
                    if (row_type == _RowType_JointMaterial)
                    {
                        Input_Yield_Value_Joint();
                    }

                } // end if


                

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


                if (!chk_CheckInOut.Checked) return;


                if (e.Button != MouseButtons.Right) return;

                string size_yn = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
                string row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");


                // 채산값 등록
                if (size_yn == "Y")
                {
                    Input_Yield_Value_Size_Yes();


                    // 임가공 구조일 때 임가공 채산값 등록 하면 원자재 모두 적용
                    if (row_type == _RowType_JointMaterial)
                    {
                        Input_Yield_Value_Joint();
                    }

                }



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Value_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Check_Input_Yield_Condition : 모두 입력되면 메인으로 적용해 주기 위함, 오류 체크
        /// </summary>
        /// <param name="arg_show_message"></param>
        /// <returns></returns>
        private bool Check_Input_Yield_Condition(bool arg_show_message)
        {



            // 모두 값 할당 확인
            string value = "";

            for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
            {

                value = Empty_String(fgrid_Value[_Value_Row_Yield, i], "");

                if (value == "")
                {

                    //if (arg_show_message)
                    //{
                    //    string message = "Unsuitable yield value.";
                    //    ClassLib.ComFunction.User_Message(message, "Check_Input_Yield_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                    fgrid_Value.LeftCol = i - 1;
                    fgrid_Value.Select(_Value_Row_Yield, i, true);

                    return false;

                }

            } // end for i



            // 값 범위 초과 확인
            // min, max 채산값 벗어나는 사이즈런 있을 경우 선택 메세지 표시
            // yes : 계속 진행 (저장)
            // no : 저장하지 않고, 벗어난 사이즈 문대로 포커스 이동


            //double min_value = Convert.ToDouble(fgrid_Value[_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START].ToString());
            //double max_value = Convert.ToDouble(fgrid_Value[_Value_Row_Yield, fgrid_Value.Cols.Count - 1].ToString());

            double min_value = 0;
            double max_value = 0;
            double now_value = 0;


            //-------------------
            // 첫번째 사이즈 값 : order 순서 무조건 1부터 시작하므로 order 순서가 1인 사이즈의 값
            for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
            {

                if (Empty_String(fgrid_Value[2, i], "") == "1")
                {
                    min_value = Convert.ToDouble(fgrid_Value[_Value_Row_Yield, i].ToString());
                    break;
                }


            } // end for i


            // 마지막 사이즈 값
            int now_order = -1;
            int max_order = -1;
            int max_col = -1;


            for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
            {

                now_order = Convert.ToInt32(Empty_String(fgrid_Value[2, i], "0"));

                if (max_order < now_order)
                {
                    max_order = now_order;
                    max_col = i;
                }


            } // end for i

            max_value = Convert.ToDouble(fgrid_Value[_Value_Row_Yield, max_col].ToString());
            //-------------------


            for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
            {

                now_value = Convert.ToDouble(fgrid_Value[_Value_Row_Yield, i].ToString());

                if (now_value < min_value || now_value > max_value)
                {


                    if (arg_show_message)
                    {
                        string message = "Unsuitable yield value." + "\r\n" + "Do you continue work ?";
                        DialogResult result = ClassLib.ComFunction.User_Message(message, "Check_Input_Yield_Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {

                            return true;

                        }
                        else
                        {

                            fgrid_Value.LeftCol = i - 1;
                            fgrid_Value.Select(_Value_Row_Yield, i, true);

                            return false;
                        }

                    }
                    else
                    {
                        
                        // 메세지 표시 안할 때는 무조건 계속 진행으로 처리
                        return true;

                    } // end if (arg_show_message)


                }
            } // end for i



            // 모두 spec 할당 확인
            string spec_cd = "";

            for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
            {

                spec_cd = Empty_String(fgrid_Value[_Value_Row_SpecCode, i], "");

                if (spec_cd == "")
                {
                     
                    if (arg_show_message)
                    {
                        string message = "Unsuitable yield value.";
                        ClassLib.ComFunction.User_Message(message, "Check_Input_Yield_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    fgrid_Value.LeftCol = i - 1;
                    fgrid_Value.Select(_Value_Row_SpecName, i, true);

                    return false;

                }

            } // end for i


            

            
            // 사이즈 그룹 스펙으로 선택한 경우, From~To 사이즈런과 선택한 스펙이 다를 경우 저장 할 수 없음
            if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "") == "Y")
            {

                string before_spec = "";
                string now_spec = "";
                int size_f = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START;
                int size_t = -1;

                while (true)
                {


                    before_spec = Empty_String(fgrid_Value[_Value_Row_SpecCode, size_f], "");


                    for (int k = size_f; k < fgrid_Value.Cols.Count; k++)
                    {

                        now_spec = Empty_String(fgrid_Value[_Value_Row_SpecCode, k], "");


                        if (before_spec == now_spec)
                        {
                            size_t = k;
                        }
                        else
                        {
                            break;
                        }

                    }


                    if (before_spec.Substring(0, 1) == "1")
                    {

                        string size_from_to = fgrid_Value[1, size_f].ToString() + "-" + fgrid_Value[1, size_t].ToString();
                        string spec_name = Empty_String(fgrid_Value[_Value_Row_SpecName, size_f], "");

                        if (size_from_to != spec_name)
                        {

                            if (arg_show_message)
                            {
                                string message = "Invaild size spec.";
                                ClassLib.ComFunction.User_Message(message, "Check_Input_Yield_Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }


                            fgrid_Value.LeftCol = size_f - 1;
                            fgrid_Value.Select(_Value_Row_SpecName, size_f, true);

                            return false;

                        } // end if (size_from_to != spec_name)

                    } // end if (before_spec.Substring(0, 1) == "1")



                    size_f = size_t + 1;

                    if (size_f == fgrid_Value.Cols.Count) break;





                } // end while

            } // end if size_yn = 'Y'




            return true;


        }




        /// <summary>
        /// Input_Yield_Value_Size_No : 채산값 등록
        /// </summary>
        private void Input_Yield_Value_Size_No()
        {


            try
            {

                // item, spec, color 없으면 설정 할 수 없음
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                {
                    return;
                }



                for (int i = fgrid_Value.Selection.c1; i <= fgrid_Value.Selection.c2; i++)
                {
                    fgrid_Value[_Value_Row_Yield, i] = fgrid_Value[_Value_Row_Yield, fgrid_Value.Col];

                } // end for i


                // 사이즈 자재가 아닐 때, spec_cd_head 를 일괄 설정
                CellRange cr = fgrid_Value.GetCellRange(_Value_Row_SpecCode, fgrid_Value.Selection.c1, _Value_Row_SpecCode, fgrid_Value.Selection.c2);
                cr.Data = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD].ToString();

                cr = fgrid_Value.GetCellRange(_Value_Row_SpecName, fgrid_Value.Selection.c1, _Value_Row_SpecName, fgrid_Value.Selection.c2);
                cr.Data = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD].ToString();


                //-----------------------------------
                // main update
                //-----------------------------------
                bool condition_flag = Check_Input_Yield_Condition(true);

                if (condition_flag)
                {

                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                    {
                        fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                    }


                    for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                    {
                        fgrid_Yield[fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START] = Empty_String(fgrid_Value[_Value_Row_Yield, i],  "");

                    } // end for i

                }
                //-----------------------------------


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Input_Yield_Value_Size_No", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        /// <summary>
        /// Input_Yield_Value_Size_Yes : 채산값 등록
        /// </summary>
        private void Input_Yield_Value_Size_Yes()
        {


            try
            {

                // item, spec, color 없으면 설정 할 수 없음
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                    || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                {
                    return;
                }




                string cs_size_f = fgrid_Value[1, fgrid_Value.Selection.c1].ToString();
                string cs_size_t = fgrid_Value[1, fgrid_Value.Selection.c2].ToString();
                string yield_value = Empty_String(fgrid_Value[_Value_Row_Yield, fgrid_Value.Col], "0");
                string spec_cd = Empty_String(fgrid_Value[_Value_Row_SpecCode, fgrid_Value.Col], "");
                string spec_name = Empty_String(fgrid_Value[_Value_Row_SpecName, fgrid_Value.Col], "");
                

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


                Display_Grid_Yield_Size_Material_Value("Y");



                //-----------------------------------
                // main update
                //-----------------------------------
                bool condition_flag = Check_Input_Yield_Condition(true);

                if (condition_flag)
                {

                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                    {
                        fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                    }


                    for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                    {

                        // value
                        fgrid_Yield[fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START] = Empty_String(fgrid_Value[_Value_Row_Yield, i], "");

                        // spec
                        CellRange cr = fgrid_Yield.GetCellRange(fgrid_Yield.Row, (i - (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START) + (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START);

                        spec_cd = Empty_String(fgrid_Value[_Value_Row_SpecCode, i], "");
                        spec_name = Empty_String(fgrid_Value[_Value_Row_SpecName, i], "");

                        cr.UserData = spec_cd + _UserData_Spec_Symbol + spec_name;


                    } // end for i



                    Display_Grid_Yield_Size_Material(fgrid_Yield.Row);
                
                }
                //-----------------------------------


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Input_Yield_Value_Size_Yes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }




        /// <summary>
        /// Input_Yield_Value_Joint : 
        /// </summary>
        private void Input_Yield_Value_Joint()
        {



            // 선택한 임가공 채산값 모두 할당 확인
            bool condition_flag = Check_Input_Yield_Condition(false);

            if (!condition_flag) return;



            //-------------------------------------------------------------------------------------------------------------------
            // 임가공 전체 구조 처음, 마지막 행
            //-------------------------------------------------------------------------------------------------------------------
            int[] template_row = Search_Joint_Bom_Range(fgrid_Yield.Row);
            if (template_row == null) return;

            int template_first_row = template_row[0];
            int template_last_row = template_row[1];
            //-------------------------------------------------------------------------------------------------------------------



            string row_type = "";
            string joint_level = "";
            string now_level = "";
            int joint_length = 0;
            int now_length = 0;
            bool finish_flag = false;


            // 수정한 임가공 레벨부터 시작
            for (int i = fgrid_Yield.Row; i <= template_last_row; i++)
            {


                row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

                if (row_type != _RowType_JointMaterial) continue;


                joint_level = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString();
                joint_length = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;


                if (fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Stiker
                    || fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _HotMelt
                    || fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _RubberLamination
                    || fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _BallHotMelt
                    || fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _DotHotMelt
                    || fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Lamination)
                {


                    // 임가공 밑 한 세트
                    for (int a = i + 1; a <= template_last_row; a++)
                    {

                        now_level = fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString();
                        now_length = fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;


                        if (now_length < joint_length)
                        {
                            finish_flag = true;
                            break;
                            //return;
                        }

                        if (now_level.Substring(0, joint_length) != joint_level)
                        {
                            finish_flag = true;
                            break;
                            //return;
                        }


                        for (int b = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; b < fgrid_Yield.Cols.Count; b++)
                        {

                            fgrid_Yield[a, b] = fgrid_Yield[i, b];

                        } // end for b
                            

                    } // end for a


                } // end if


                if (finish_flag)
                {
                    break;
                }
                    

            } // end for i



            // 구조 전체 업데이트 처리
            for (int i = template_first_row; i <= template_last_row; i++)
            {

                if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                {
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                }

            } // end for i child




        }



        #endregion

        #region 컨텍스트메뉴




        /// <summary>
        /// Event_contextMenu_Yield_Opening : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
        /// </summary>
        private void Event_contextMenu_Yield_Opening()
        {

            try
            {

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;

                if (!chk_CheckInOut.Checked)
                {

                    menuItem_InsertComponent.Visible = false;
                    menuItem_InsertRawMat.Visible = false;
                    menuItem_InsertJointRaw.Visible = false;
                    menuItem_SetComp.Visible = false;
                    menuItem_SetMat.Visible = false;
                    menuItem_division1.Visible = false;
                    menuItem_DeleteMat.Visible = false;
                    menuItem_DeleteCancelMat.Visible = false;
                    menuItem_division2.Visible = false;
                    menuItem_ChangeMatInsert.Visible = false;
                    menuItem_ChangeMatUpdate.Visible = false;
                    menuItem_ChangeMatDelete.Visible = false;
                    menuItem_division3.Visible = false;
                    menuItem_CutComponent.Visible = false;
                    menuItem_PasteComponent.Visible = false;
                    menuItem_division4.Visible = false;
                    menuItem_PasteYieldValue.Visible = false;

                    return;

                }
                else
                {

                    menuItem_InsertComponent.Visible = true;
                    menuItem_InsertRawMat.Visible = true;
                    menuItem_SetComp.Visible = true;
                    menuItem_SetMat.Visible = true;
                    menuItem_division1.Visible = true;
                    menuItem_DeleteMat.Visible = true;
                    menuItem_DeleteCancelMat.Visible = true;
                    menuItem_division2.Visible = true;
                    menuItem_ChangeMatInsert.Visible = true;
                    menuItem_ChangeMatUpdate.Visible = true;
                    menuItem_ChangeMatDelete.Visible = true;
                    menuItem_division3.Visible = true;
                    menuItem_CutComponent.Visible = true;
                    menuItem_PasteComponent.Visible = true;


                    if (ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
                    {
                        menuItem_InsertJointRaw.Visible = true;
                        menuItem_division4.Visible = true;
                        menuItem_PasteYieldValue.Visible = true;
                    }
                    else
                    {
                        menuItem_InsertJointRaw.Visible = false;
                        menuItem_division4.Visible = false;
                        menuItem_PasteYieldValue.Visible = false;
                    }

                }


                string row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                string template_tree_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD], "");

                if (row_type == _RowType_Semigood)
                {

                    menuItem_InsertComponent.Enabled = true;
                    menuItem_InsertRawMat.Enabled = false;
                    menuItem_InsertJointRaw.Enabled = false;
                    menuItem_SetComp.Enabled = false;
                    menuItem_SetMat.Enabled = false;
                    menuItem_DeleteMat.Enabled = true;
                    menuItem_DeleteCancelMat.Enabled = true;
                    menuItem_ChangeMatInsert.Enabled = true;
                    menuItem_ChangeMatUpdate.Enabled = false;
                    menuItem_ChangeMatDelete.Enabled = false;
                    menuItem_CutComponent.Enabled = false;
                    menuItem_PasteComponent.Enabled = true;
                    menuItem_PasteYieldValue.Enabled = false;

                }
                else if (row_type == _RowType_Component)
                {

                    menuItem_InsertComponent.Enabled = true;
                    menuItem_InsertRawMat.Enabled = true;
                    menuItem_InsertJointRaw.Enabled = true;
                    menuItem_SetComp.Enabled = true;
                    menuItem_SetMat.Enabled = false;
                    menuItem_DeleteMat.Enabled = true;
                    menuItem_DeleteCancelMat.Enabled = true;
                    menuItem_ChangeMatInsert.Enabled = true;
                    menuItem_ChangeMatUpdate.Enabled = false;
                    menuItem_ChangeMatDelete.Enabled = false;
                    menuItem_CutComponent.Enabled = true;
                    menuItem_PasteComponent.Enabled = true;
                    menuItem_PasteYieldValue.Enabled = false;

                }
                else if (row_type == _RowType_JointMaterial)
                {

                    menuItem_InsertComponent.Enabled = false;
                    menuItem_InsertRawMat.Enabled = true;
                    menuItem_InsertJointRaw.Enabled = true;
                    menuItem_SetComp.Enabled = false;
                    menuItem_SetMat.Enabled = true;
                    menuItem_DeleteMat.Enabled = true;
                    menuItem_DeleteCancelMat.Enabled = true; 
                    menuItem_ChangeMatInsert.Enabled = false;
                    menuItem_ChangeMatUpdate.Enabled = false;
                    menuItem_ChangeMatDelete.Enabled = false; 
                    menuItem_CutComponent.Enabled = false;
                    menuItem_PasteComponent.Enabled = false;
                    menuItem_PasteYieldValue.Enabled = true;

                }
                else if (row_type == _RowType_Material)
                {

                    menuItem_InsertComponent.Enabled = false;
                    menuItem_InsertRawMat.Enabled = true;
                    menuItem_InsertJointRaw.Enabled = true;
                    menuItem_SetComp.Enabled = false;
                    menuItem_SetMat.Enabled = true;
                    menuItem_DeleteMat.Enabled = true;
                    menuItem_DeleteCancelMat.Enabled = true;

                    if (template_tree_cd == _JointBOM_Only_Material)
                    {
                        menuItem_ChangeMatInsert.Enabled = true;
                        menuItem_ChangeMatUpdate.Enabled = true;
                        menuItem_ChangeMatDelete.Enabled = true;
                    }
                    else
                    {
                        menuItem_ChangeMatInsert.Enabled = false;
                        menuItem_ChangeMatUpdate.Enabled = false;
                        menuItem_ChangeMatDelete.Enabled = false;
                    }

                    menuItem_CutComponent.Enabled = false;
                    menuItem_PasteComponent.Enabled = false;
                    menuItem_PasteYieldValue.Enabled = true;


                } // end if


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_contextMenu_Yield_Opening", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        /// <summary>
        /// Get_Next_Component_Seq : 
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_direct">true : 선택 컴포넌트 바로 밑에 작업 (ex : data paste)</param>
        /// <returns></returns>
        private int Get_Next_Component_Seq(int arg_row, bool arg_direct)
        {

            try
            {

                int next_component_seq = -1;

                string row_type = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

                
                if (row_type == _RowType_Semigood)
                {

                    // semigood 첫번째 component 추가 일 때,
                    if (fgrid_Yield.Rows[arg_row].Node.Children == 0)
                    {
                        next_component_seq = _Component_Seq_Range;
                    }
                    // semigood에 component 들이 있는 경우, 마지막 component 다음에 추가
                    else
                    {

                        if (arg_direct)
                        {
                            int component_seq_1 = 0;
                            int component_seq_2 = Convert.ToInt32(Empty_String(fgrid_Yield[fgrid_Yield.Rows[arg_row].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "0"));

                            next_component_seq = component_seq_1 + ((component_seq_2 - component_seq_1) / 2);

                        }
                        else
                        {
                            next_component_seq = Convert.ToInt32(Empty_String(fgrid_Yield[fgrid_Yield.Rows[arg_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "0")) + _Component_Seq_Range;
                        }

                    }

                }
                else// if (row_type == _RowType_Component)
                {

                    // 같은 semigood 의 component 중에서 선택한 다음 component_seq 검색
                    int find_next_component_row = -1;

                    string sel_semi_good_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                    string now_semi_good_cd = ""; 

                    for (int i = arg_row + 1; i < fgrid_Yield.Rows.Count; i++)
                    {

                        if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;


                        now_semi_good_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");

                        if (sel_semi_good_cd != now_semi_good_cd) break;

                        find_next_component_row = i;
                        break;

                    } // end for i


                    // 선택한 component가 동일한 semigood 마지막인 경우
                    if (find_next_component_row == -1)
                    {
                        next_component_seq = Convert.ToInt32(Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "0")) + _Component_Seq_Range;
                    }
                    else
                    {
                        int component_seq_1 = Convert.ToInt32(Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "0"));
                        int component_seq_2 = Convert.ToInt32(Empty_String(fgrid_Yield[find_next_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "0"));

                        next_component_seq = component_seq_1 + ((component_seq_2 - component_seq_1) / 2);

                    }


                } // end if(row_type)


                return next_component_seq;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Get_Next_Component_Seq", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }




        /// <summary>
        /// Get_Next_Insert_Row : 
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_direct">true : 선택 컴포넌트 바로 밑에 작업 (ex : data paste)</param>
        /// <returns></returns>
        private int Get_Next_Insert_Row(int arg_row, bool arg_direct)
        {

            try
            {

                int next_insert_row = -1;

                string row_type = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");



                if (row_type == _RowType_Semigood)
                {

                    if (arg_direct)
                    {
                        next_insert_row = arg_row + 1;
                    }
                    else
                    {

                        // semigood 첫번째 component 추가 일 때,
                        if (fgrid_Yield.Rows[arg_row].Node.Children == 0)
                        {
                            next_insert_row = arg_row + 1;
                        }
                        // semigood에 component 들이 있는 경우, 마지막 component 다음에 추가
                        // => 마지막 component의 마지막 아이템 다음에 추가
                        else
                        {

                            int row = fgrid_Yield.Rows[arg_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                            while (true)
                            {

                                if (fgrid_Yield.Rows[row].Node.Children == 0)
                                {
                                    next_insert_row = row + 1;
                                    break;
                                }

                                row++;

                            } // end while

                        } // if (chlid == 0)

                    }
                           
                    

                }
                else if (row_type == _RowType_Component)
                {

                    // 같은 semigood 의 component 중에서 선택한 다음 component_seq 검색
                    int find_next_component_row = -1;

                    string sel_semi_good_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                    string now_semi_good_cd = "";

                    for (int i = arg_row + 1; i < fgrid_Yield.Rows.Count; i++)
                    {

                        if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component) continue;


                        now_semi_good_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");

                        if (sel_semi_good_cd != now_semi_good_cd) break;

                        find_next_component_row = i;
                        break;

                    } // end for i


                    // 선택한 component가 동일한 semigood 마지막인 경우
                    if (find_next_component_row == -1)
                    {

                        // 마지막 component 일 때,
                        if (fgrid_Yield.Rows[arg_row].Node.Children == 0)
                        {
                            next_insert_row = arg_row + 1;
                        }
                        // semigood에 component 들이 있는 경우, 마지막 component 다음에 추가
                        // => 마지막 component의 마지막 아이템 다음에 추가
                        else
                        {

                            //int row = fgrid_Yield.Rows[arg_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

                            //while (true)
                            //{

                            //    if (fgrid_Yield.Rows[row].Node.Children == 0)
                            //    {
                            //        next_insert_row = row + 1;
                            //        break;
                            //    }

                            //    row++;

                            //} // end while

                            // 같은 component 나올 때 까지 반복
                            string sel_component_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                            string now_component_cd = "";

                            for (int i = arg_row; i < fgrid_Yield.Rows.Count; i++)
                            {

                                now_component_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");

                                if (sel_component_cd == now_component_cd) continue;

                                next_insert_row = i;
                                break;

                            } // end for i

                            next_insert_row = (next_insert_row == -1) ? fgrid_Yield.Rows.Count : next_insert_row;
                            

                        } // if (chlid == 0)

                    }
                    else
                    {
                        next_insert_row = find_next_component_row;
                    }


                } // end if(row_type)


                return next_insert_row;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Get_Next_Insert_Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }



        /// <summary>
        /// Event_menuItem_InsertComponent_Click : 
        /// </summary>
        private void Event_menuItem_InsertComponent_Click()
        {

            try
            {


                // semigood 선택하면 마지막에 생성
                // component 선택하면 그 밑에 구조 아래 생성

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                int insert_row = Get_Next_Insert_Row(fgrid_Yield.Row, false);
                int next_component_seq = Get_Next_Component_Seq(fgrid_Yield.Row, false);  



                fgrid_Yield.Rows.Insert(insert_row);
                fgrid_Yield.Rows[insert_row].IsNode = true;
                fgrid_Yield.Rows[insert_row].Node.Level = 1;
                fgrid_Yield.GetCellRange(insert_row, 1, insert_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;
                //fgrid_Yield.GetCellRange(insert_row, 1, insert_row, fgrid_Yield.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;


                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = fgrid_Yield.Rows[insert_row].Node.Level.ToString();
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = "";
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = "";
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = "";
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = _RowType_Component;
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = next_component_seq.ToString();
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxYIELD_STATUS] = ClassLib.ComFunction.Empty_Combo(cmb_YieldStatus, "");

              
                fgrid_Yield.TopRow = ((insert_row - 5) < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : (insert_row - 5);
                fgrid_Yield.Select(insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, true);



                //// component 신규 추가
                //Select_GridCombo_Component(fgrid_Yield,
                //   (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC,
                //   (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD,
                //   (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME,
                //   true);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_InsertComponent_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_menuItem_InsertRawMat_Click : 
        /// </summary>
        private void Event_menuItem_InsertRawMat_Click()
        {

            try
            {

                // component 마지막에 생성
                // component 선택하면 신규 생성
                // material 선택하면 복사 생성

                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                string component_cd = "";
                string component_name = "";
                string division = "";
                string row_type = "";
                string template_tree_cd = "";
                string template_seq = "";
                int insert_row = -1;


                component_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                component_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");
                division = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                template_tree_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD], "");




                //----------------------------------------------------------------
                // component가 선행 입력 되어야 함
                //----------------------------------------------------------------

                if (component_cd == "")
                {

                    string message = "We must input component";  // : [" + component_name + "]";
                    ClassLib.ComFunction.User_Message(message, "Event_menuItem_InsertRawMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }
                //----------------------------------------------------------------


                //----------------------------------------------------------------
                // 등록되어져 있는 원자재 구조인 material 선택하면 복사 생성하는 경우 제약 조건
                //----------------------------------------------------------------
                if (row_type == _RowType_Material && template_tree_cd == _JointBOM_Only_Material)
                {

                    // item, spec, color 모두 설정 되어 있어야 함
                    if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                        || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                        || Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                    {

                        string message = "We must input material";
                        ClassLib.ComFunction.User_Message(message, "Event_menuItem_InsertRawMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }



                    // 채산값 모두 설정 되어 있어야 함
                    string value = "";

                    for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                    {

                        value = Empty_String(fgrid_Yield[fgrid_Yield.Row, i], "");

                        if (value == "")
                        {

                            string message = "Unsuitable yield value.";
                            ClassLib.ComFunction.User_Message(message, "Event_menuItem_InsertRawMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;

                        }

                    } // end for i


                } // end if (row_type == _RowType_Material && template_tree_cd == _JointBOM_Only_Material)
                //----------------------------------------------------------------


                //----------------------------------------------------------------
                // 추가 행 선택
                //----------------------------------------------------------------

                for (int i = fgrid_Yield.Row + 1; i < fgrid_Yield.Rows.Count; i++)
                {

                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

                    if (row_type == _RowType_Semigood || row_type == _RowType_Component)
                    {
                        insert_row = i;
                        break;
                    }

                    if (i == fgrid_Yield.Rows.Count - 1)
                    {
                        insert_row = fgrid_Yield.Rows.Count;
                        break;
                    }


                } // end for i


                insert_row = (insert_row == -1) ? fgrid_Yield.Row + 1 : insert_row;
                //----------------------------------------------------------------



                fgrid_Yield.Rows.Insert(insert_row);
                fgrid_Yield.Rows[insert_row].IsNode = true;
                fgrid_Yield.Rows[insert_row].Node.Level = 2;


                division = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "");
                row_type = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                template_tree_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD], "");

                template_seq = Empty_String(fgrid_Yield[insert_row - 1, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "0");
                
               
                // 등록되어져 있는 원자재 구조인 material 선택하면 복사 생성 
                if (row_type == _RowType_Material && template_tree_cd == _JointBOM_Only_Material)
                {
                  

                    string copy_clip = fgrid_Yield.GetCellRange(fgrid_Yield.Row, 0, fgrid_Yield.Row, fgrid_Yield.Cols.Count - 1).Clip;

                    // 신규 생성 행 선택하기 전, 복사 원본 행 저장
                    int source_row = fgrid_Yield.Row;

                    fgrid_Yield.Select(insert_row, 0, insert_row, fgrid_Yield.Cols.Count - 1, false);
                    fgrid_Yield.Clip = copy_clip;
                    fgrid_Yield.Select(insert_row, 0, false);


                    string source_spec;
                    CellRange target_cr;

                    for (int i = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
                    {

                        source_spec = fgrid_Yield.GetCellRange(source_row, i).UserData.ToString();

                        target_cr = fgrid_Yield.GetCellRange(insert_row, i);
                        target_cr.UserData = source_spec;

                    }


                    // 사이즈 자재 표시
                    Display_Grid_Yield_Size_Material(insert_row);

                }
                else
                {

                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = fgrid_Yield.Rows[insert_row].Node.Level.ToString();
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = _RowType_Material;
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "");
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL] = "1";  // 원자재 레벨
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD] = _JointBOM_Only_Material;  // 원자재 구조
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD] = "02J13000";  // 원자재 임가공 명
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = "";
                    fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_PROPERTY] = "";



                }  // end if (row_type == _RowType_Material)


                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";
                fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ] = Convert.ToString(Convert.ToInt32(template_seq) + 1);


                //for (int a = 0; a < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a++)
                //{
                //    CellStyle cs_edit = fgrid_Yield.Styles.Add("EDIT_COLOR" + a.ToString());
                //    cs_edit.ForeColor = ClassLib.ComVar.ClrImportant;
                //    fgrid_Yield.SetCellStyle(insert_row, a, "EDIT_COLOR" + a.ToString());

                //}


                // display_desc, item, spec, color 등록 필요
                // component_seq 설정 고려


                fgrid_Yield.TopRow = ((insert_row - 5) < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : (insert_row - 5);
                fgrid_Yield.Select(insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, true);


                ////----------------------------------------
                //// material popup : double click 하면 실행되게 하고, 바로 입력 가능하도록 처리
                ////----------------------------------------
                //if (row_type == _RowType_Component)
                //{

                //    Show_Popup_Material_Select(insert_row, "");

                //}
                ////----------------------------------------



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_InsertRawMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_menuItem_InsertJointRaw_Click : 
        /// </summary>
        private void Event_menuItem_InsertJointRaw_Click()
        {

            try
            {


                string component_cd = "";
                string component_name = "";
                string row_type = "";
                int insert_row = -1;


                //----------------------------------------------------------------
                // component가 선행 입력 되어야 함
                //----------------------------------------------------------------

                component_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                component_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");


                if (component_cd == "")
                {

                    string message = "We must input component";  // : [" + component_name + "]";
                    ClassLib.ComFunction.User_Message(message, "Event_menuItem_InsertRawMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }
                //----------------------------------------------------------------


                //----------------------------------------------------------------
                // 추가 행 선택
                //----------------------------------------------------------------

                for (int i = fgrid_Yield.Row + 1; i < fgrid_Yield.Rows.Count; i++)
                {

                    row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

                    if (row_type == _RowType_Semigood || row_type == _RowType_Component)
                    {
                        insert_row = i;
                        break;
                    }


                    if (i == fgrid_Yield.Rows.Count - 1)
                    {
                        insert_row = fgrid_Yield.Rows.Count;
                        break;
                    }


                } // end for i


                insert_row = (insert_row == -1) ? fgrid_Yield.Row + 1 : insert_row;
                //----------------------------------------------------------------



                string template_seq = Empty_String(fgrid_Yield[insert_row - 1, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "0");
                


                // 팝업에서 구조 찾고, null 리턴하면 작업 취소
                // favorite 구조 10개 지정

                FlexBase.Yield_New.Pop_Yield_Joint_Template pop_form = new FlexBase.Yield_New.Pop_Yield_Joint_Template();
                pop_form.ShowDialog();


                // template 구조 조회
                if (pop_form._CancelFlag) return;


                DataTable dt_ret = SELECT_SBC_YIELD_JOINT_BOM(pop_form._JointTemplate);

                if (dt_ret == null || dt_ret.Rows.Count == 0) return;

           
                fgrid_Yield.Rows.InsertRange(insert_row, dt_ret.Rows.Count);


                int template_level_length = 0;

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {

                    fgrid_Yield.Rows[insert_row + i].IsNode = true;

                    template_level_length = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_LEVEL], "0").Length - 1;
                    fgrid_Yield.Rows[insert_row + i].Node.Level = 2 + template_level_length;

                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I"; 
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = 2 + template_level_length;
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_NAME], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxROW_TYPE], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ] = Convert.ToString(Convert.ToInt32(template_seq) + 1);
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_LEVEL], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_TREE_CD], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_CD], "");

                    // 임가공 구조 중 원자재
                    if (Empty_String(fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD], "") == _RawMaterial)
                    {
                        fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = "";
                    }
                    else
                    {
                        fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_NAME], "");
                    }

                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = "";
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxMNG_UNIT], "");
                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxSIZE_YN], "");

                    string property_model = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_MODEL], "");
                    string property_style = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_STYLE], "");
                    string property_component = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_COMPONENT], "");
                    string property_gender = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_GENDER], "");
                    string property_prefix = Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_PREFIX], "");
                    string property = property_model + property_style + property_component + property_gender + property_prefix;

                    fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_PROPERTY] = property;
                    //----------------------------------------


                    for (int a = 1; a < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a++)
                    {

                        //CellStyle cs_size_yn = fgrid_Yield.Styles.Add("RAW_MATERIAL_" + Convert.ToString(insert_row + i) + a.ToString());
                        //cs_size_yn.BackColor = Color.Lavender;
                        //fgrid_Yield.SetCellStyle(insert_row + i, a, "RAW_MATERIAL_" + Convert.ToString(insert_row + i) + a.ToString());


                        if (Empty_String(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxROW_TYPE], "") == _RowType_Material)
                        {
                            fgrid_Yield[insert_row + i, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = "";
                        }


                    } // end for a



                    // size 자재 표시
                    Display_Grid_Yield_Size_Material(insert_row + i);


                } // end for i



                fgrid_Yield.TopRow = ((insert_row - 5) < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : (insert_row - 5);
                fgrid_Yield.Select(insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, true);




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_InsertJointRaw_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Create_Joint_Process: 
        /// </summary>
        /// <param name="arg_row"></param>
        private void Create_Joint_Process(int arg_row)
        {

            try
            {


                if (fgrid_Yield.Rows.Count < fgrid_Yield.Rows.Fixed) return;


                //// 신규가 아닌 데이터 일 때, 구조에 대한 기타 정보 
                //if (Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                //{

                //    Search_Joint_Bom(arg_row);

                //}


                // 원자재 모두 입력되었는지 확인
                bool check_ok = Check_Create_Joint_Condition(arg_row, false);
                if (!check_ok) return;


                // 임가공 이름, 컬러명, spec명 생성
                Create_Joint_Material_Name(arg_row);


                // 임가공, 컬러 신규 등록
                Create_Joint_Material(arg_row);



                // 구조의 헤더값이 변경 된 경우는 채산값 재 생성 필요 없음
                if (fgrid_Yield.Col >= (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START)
                {

                    // 임가공 아이템의 채산 값 할당 (Unit 이 같은 원자재의 채산값으로 할당)
                    Create_Joint_YieldValue(arg_row);

                }



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Create_Joint_Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #region Create_Joint_Process



        /// <summary>
        /// Search_Joint_Bom_Range : 임가공 전체 구조 처음, 마지막 행 계산
        /// </summary>
        /// <param name="arg_row"></param>
        /// <returns></returns>
        private int[] Search_Joint_Bom_Range(int arg_row)
        {


            try
            {


                int template_first_row = -1;
                int template_last_row = -1;

                string sel_template_seq = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "");
                string now_template_seq = "";

                for (int i = arg_row - 1; i >= fgrid_Yield.Rows.Fixed; i--)
                {
                    now_template_seq = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "");

                    if (now_template_seq != sel_template_seq)
                    {
                        template_first_row = i + 1;
                        break;
                    }

                }

                for (int i = arg_row + 1; i < fgrid_Yield.Rows.Count; i++)
                {
                    now_template_seq = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "");

                    if (now_template_seq != sel_template_seq)
                    {
                        template_last_row = i - 1;
                        break;
                    }

                }


                template_first_row = (template_first_row == -1) ? fgrid_Yield.Rows.Fixed : template_first_row;
                template_last_row = (template_last_row == -1) ? fgrid_Yield.Rows.Count - 1 : template_last_row;


                int[] return_row = new int[] { template_first_row, template_last_row };

                return return_row;


            }
            catch
            {
                return null;
            }

        }



        ///// <summary>
        ///// Search_Joint_Bom : 신규가 아닌 데이터 일 때, 구조에 대한 기타 정보 
        ///// </summary>
        ///// <param name="arg_row"></param>
        //private void Search_Joint_Bom(int arg_row)
        //{


        //    string joint_template = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD], "");
        //    DataTable dt_ret = SELECT_SBC_YIELD_JOINT_BOM(joint_template);

        //    if (dt_ret == null || dt_ret.Rows.Count == 0) return;


        //    //-------------------------------------------------------------------------------------------------------------------
        //    // 임가공 전체 구조 처음, 마지막 행
        //    //-------------------------------------------------------------------------------------------------------------------
        //    int[] template_row = Search_Joint_Bom_Range(arg_row);
        //    if (template_row == null) return;

        //    int template_first_row = template_row[0];
        //    int template_last_row = template_row[1];
        //    //-------------------------------------------------------------------------------------------------------------------


        //    string template_level = "";
        //    string condition = "";
        //    DataRow[] findrow = null;

        //    for (int i = template_first_row; i <= template_last_row; i++)
        //    {


        //        template_level = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "");
        //        condition = "TEMPLATE_LEVEL = '" + template_level + "'";
        //        findrow = dt_ret.Select(condition);


        //        // template_level 은 유일하므로 무조건 findrow[0] 임
        //        fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_NAME], "");
        //        fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD] = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_CD], "");

        //        string property_model = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_MODEL], "");
        //        string property_style = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_STYLE], "");
        //        string property_component = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_COMPONENT], "");
        //        string property_gender = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_GENDER], "");
        //        string property_prefix = Empty_String(findrow[0].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_PREFIX], "");
        //        string property = property_model + property_style + property_component + property_gender + property_prefix;

        //        fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_PROPERTY] = property;


        //    } // end for i
             
             

        //}



        /// <summary>
        /// Check_Create_Joint_Condition : 원자재 모두 입력되었는지 확인
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_flag">true : 임가공까지 체크, false : 임가공 제외 체크</param>
        /// <returns></returns>
        private bool Check_Create_Joint_Condition(int arg_row, bool arg_flag)
        {


            //-------------------------------------------------------------------------------------------------------------------
            // 임가공 전체 구조 처음, 마지막 행
            //-------------------------------------------------------------------------------------------------------------------
            int[] template_row = Search_Joint_Bom_Range(arg_row);
            if (template_row == null) return false;

            int template_first_row = template_row[0];
            int template_last_row = template_row[1];
            //-------------------------------------------------------------------------------------------------------------------


            for (int i = template_first_row; i <= template_last_row; i++)
            {

                // 임가공 명 만들때는 임가공 행은 필수 검사 안하기 위함
                if (! arg_flag)
                {
                    if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Material) continue;
                }
               

                // item, spec, color 없으면 설정 할 수 없음
                if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "") == ""
                    || Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "") == ""
                    || Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "") == "")
                {
                    
                    //fgrid_Yield.Select(i, 0, i, fgrid_Yield.Cols.Count - 1, false);

                    return false;
                }


            } // end for i


            return true;
        }



        /// <summary>
        /// Create_Joint_Material_Name : 임가공 이름, 컬러명, spec명 생성
        /// </summary>
        /// <param name="arg_row"></param>
        private void Create_Joint_Material_Name(int arg_row)
        {


            string item_name1 = "";
            string item_name2 = "";
            string color_name = "";



            // 임가공 처음 구분자
            // 처음일때는 대괄호 포함하지 않기 위해서
            bool first_joint = true;


            // 레벨 하위부터 실행되어야 하므로 길이 계산
            int max_level_length = 0;
            int now_level_length = 0;


            // 이름 구성 할 세트 계산하기 위한 상위 레벨
            string before_parent_level = "";
            string now_parent_level = "";


            // 이름 구성 할 세트
            int start_row = -1;
            int end_row = -1;
            int parent_row = -1;


            //-------------------------------------------------------------------------------------------------------------------
            // 임가공 전체 구조 처음, 마지막 행
            //-------------------------------------------------------------------------------------------------------------------
            int[] template_row = Search_Joint_Bom_Range(arg_row);
            if (template_row == null) return;

            int template_first_row = template_row[0];
            int template_last_row = template_row[1];
            //-------------------------------------------------------------------------------------------------------------------



            //-------------------------------------------------------------------------------------------------------------------
            // 레벨 하위부터 실행되어야 하므로 길이 계산
            //-------------------------------------------------------------------------------------------------------------------
            for (int i = template_first_row; i <= template_last_row; i++)
            {

                now_level_length = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;

                max_level_length = (max_level_length < now_level_length) ? now_level_length : max_level_length;

            
            }
            //-------------------------------------------------------------------------------------------------------------------



            //-------------------------------------------------------------------------------------------------------------------
            // 레벨 계산 후 값 생성
            //-------------------------------------------------------------------------------------------------------------------
            now_level_length = 0;


            // a > 1 인 이유는 하위 레벨로 상위 임가공 명 만들기 때문에 1 레벨은 11 레벨에서 자동 처리 되므로
            for (int a = max_level_length; a > 1; a--)
            {
            

                // 선택 레벨의 시작과 끝, 상위 임가공 위치 지정
                // 상위 레벨이 같은 것이 한 세트 이므로 한 세트씩 처리

                for (int b = template_first_row; b <= template_last_row; b++)
                {

                    item_name1 = "";
                    item_name2 = "";
                    color_name = "";


                    // 선택 레벨 계산
                    now_level_length = fgrid_Yield[b, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;
                    if (now_level_length != a) continue;


                    // 상위 레벨 계산
                    now_parent_level = fgrid_Yield[b, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Substring(0, now_level_length - 1);
                    if (before_parent_level == now_parent_level) continue;



                    C1.Win.C1FlexGrid.Node node = fgrid_Yield.Rows[b].Node;

                    start_row = node.GetNode(NodeTypeEnum.Parent).GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    end_row = node.GetNode(NodeTypeEnum.Parent).GetNode(NodeTypeEnum.LastChild).Row.Index;
                    parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index;



                    // child 중에 임가공 공정이 하나라도 있을때
                    // 임가공 처음 구분자
                    // 처음일때는 대괄호 포함하지 않기 위해서
                    for (int j = start_row; j <= end_row; j++)
                    {
                        
                        if (fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE].ToString() != _RowType_Material)
                        {
                            first_joint = false;
                            break;
                        }
                        else
                        {
                            first_joint = true;
                        }
                    } // end for j




                    
                    //-------------------------------------------------------------------------------------------------------------------
                    // item_name2
                    //-------------------------------------------------------------------------------------------------------------------
                    string[] token = null;
                    string item_name = "";


                    for (int j = start_row; j <= end_row; j++)
                    {

                        now_level_length = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;
                        if (now_level_length != a) continue;


                        // 하위 중에 임가공 이름이 있는데 그것이 종속성을 가질 때는 그것을 제외한 나머지 이름으로 생성
                        token = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2].ToString().Split(@"@".ToCharArray());
                        item_name = token[0];


                        if (item_name2.Equals(""))
                        { 
                            item_name2 = item_name;
                            color_name = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME].ToString();
                        }
                        else
                        {
                            item_name2 += "+" + item_name;
                            color_name += "/" + fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME].ToString();
                        }

                    } // end for j 
                    //-------------------------------------------------------------------------------------------------------------------


                    //-------------------------------------------------------------------------------------------------------------------
                    // item_name2 만든 후 임가공명 추가
                    //-------------------------------------------------------------------------------------------------------------------
                    if (first_joint == false)
                    {
                        item_name2 = "[" + item_name2 + "]" + "<" + fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME].ToString() + ">";
                    }
                    else
                    {
                        item_name2 += "<" + fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME].ToString() + ">";
                    }
                    //-------------------------------------------------------------------------------------------------------------------


                    //-------------------------------------------------------------------------------------------------------------------
                    // model, style, component, gender 종속 여부 item_name2 에 추가
                    // item_name1 생성
                    // 조합 순서 : [model name][style code][gender][component code]
                    //------------------------------------------------------------------------------------------------------------------- 
                    // 종속 이름 연결할때 구분자 이용
                    string property = Empty_String(fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_PROPERTY], "");
                    string property_prefix = (property.Length <= 4) ? "" : property.Substring(4);


                    // item_name2 연결자 추가
                    if (property != null && !property.Trim().Equals("") && property.Substring(0, 4) != "NNNN")
                    {
                        item_name2 += @"@";
                    }

                    // style combobox 컬럼
                    //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status


                    // property
                    if (property_prefix != null && ! property_prefix.Trim().Equals(""))
                    {
                        item_name1 = property_prefix;
                    }

                   
                    // model
                    if (property != null && ! property.Trim().Equals("") && property.Substring(0, 1) == "Y")
                    {
                        item_name1 += "[" + cmb_StyleCd.Columns[4].Text + "]";
                        item_name2 += "[" + cmb_StyleCd.Columns[4].Text + "]";
                    }

                    // style
                    if (property != null && !property.Trim().Equals("") && property.Substring(1, 1) == "Y")
                    {
                        item_name1 += "[" + cmb_StyleCd.Columns[0].Text.Replace("-", "").Substring(0, 6) + "-" + cmb_StyleCd.Columns[0].Text.Replace("-", "").Substring(6) + "]";
                        item_name2 += "[" + cmb_StyleCd.Columns[0].Text.Replace("-", "").Substring(0, 6) + "-" + cmb_StyleCd.Columns[0].Text.Replace("-", "").Substring(6) + "]";
                    }

                    // gender
                    if (property != null && !property.Trim().Equals("") && property.Substring(3, 1) == "Y")
                    {
                        item_name1 += "[" + cmb_StyleCd.Columns[2].Text + "]";
                        item_name2 += "[" + cmb_StyleCd.Columns[2].Text + "]";
                    }

                    // component
                    if (property != null && !property.Trim().Equals("") && property.Substring(2, 1) == "Y")
                    {
                        item_name1 += "[" + fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME].ToString() + "]";
                        item_name2 += "[" + fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME].ToString() + "]";
                    }



                    // item_name1 은 마지막에 임가공 프로세스 이름 추가
                    item_name1 += "[" + fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME].ToString() + "]"; 
                    //-------------------------------------------------------------------------------------------------------------------



                    //-------------------------------------------------------------------------------------------------------------------
                    // 그리드에 값 설정
                    //-------------------------------------------------------------------------------------------------------------------
                    fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = item_name2;
                    fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = item_name1;
                    fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = item_name2;
                    //-------------------------------------------------------------------------------------------------------------------



                    //-------------------------------------------------------------------------------------------------------------------
                    // color code 자동 할당
                    //-------------------------------------------------------------------------------------------------------------------
                    if (fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _SubLimation
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _SubLimationPaper
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Printing
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Painting
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _ShieldGraphic
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _HeatTransfer
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _PuffScreen)
                    {
                    }
                    // color code 자동 할당
                    else
                    {

                        fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = color_name;

                    }
                    //-------------------------------------------------------------------------------------------------------------------

                    
                    //-------------------------------------------------------------------------------------------------------------------
                    // spec code 자동 할당
                    // 적용되어 있는 spec이 있는 경우 작업 하지 않음
                    //-------------------------------------------------------------------------------------------------------------------
                    string now_parent_spec = Empty_String(fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");

                    if (now_parent_spec == "")
                    {

                        // 하위 원자재 (첫번째 원자재) spec 적용
                        if (fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Stiker
                            || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _HotMelt
                            || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _RubberLamination
                            || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _BallHotMelt
                            || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _DotHotMelt)
                        {

                            fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = Empty_String(fgrid_Yield[start_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
                            fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = Empty_String(fgrid_Yield[start_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");

                        }
                        // 하위 원자재 모두 spec 이 동일한 경우 원자재 spec 할당
                        else if (fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Lamination)
                        {


                            int count_not_equal_spec = 0;
                            string before_spec = fgrid_Yield[start_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD].ToString();
                            string now_spec = "";


                            for (int j = start_row; j <= end_row; j++)
                            {

                                now_spec = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD].ToString();

                                if (before_spec != now_spec)
                                {
                                    count_not_equal_spec++;
                                }

                                before_spec = now_spec;

                            } // end for j 


                            // 하위 원자재 spec 모두 동일한 경우
                            if (count_not_equal_spec == 0)
                            {

                                fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = Empty_String(fgrid_Yield[start_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
                                fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = Empty_String(fgrid_Yield[start_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");

                            }
                            else
                            {

                                fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = _SpecCd_Default;
                                fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = _SpecName_Default;

                            }


                        }
                        else
                        {

                            fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = _SpecCd_Default;
                            fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = _SpecName_Default;

                        }

                    } // end if(now_parent_spec == "") // 적용되어 있는 spec이 있는 경우 작업 하지 않음
                    //-------------------------------------------------------------------------------------------------------------------


                    //-------------------------------------------------------------------------------------------------------------------
                    // update 표시
                    //-------------------------------------------------------------------------------------------------------------------
                    if (Empty_String(fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                    {
                       
                        for (int i = template_first_row; i <= template_last_row; i++)
                        {

                            fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";

                        } // end for i child

                    }
                    //-------------------------------------------------------------------------------------------------------------------


                    // 다음 세트 준비
                    if (first_joint == true) first_joint = false;

                    before_parent_level = now_parent_level;



                } // end int b 세트


            } // end for a 하위 레벨부터 상위 임가공 명 만들어가면서 처리
            //-------------------------------------------------------------------------------------------------------------------

             

        }








        /// <summary>
        /// Create_Joint_Color_Name : 임가공 컬러가 바뀐 경우 그 상위 컬러명 다시 생성
        /// </summary>
        /// <param name="arg_row"></param>
        private void Create_Joint_Color_Name(int arg_row)
        {


            string color_name = "";



            // 레벨 하위부터 실행되어야 하므로 길이 계산
            int max_level_length = 0;
            int now_level_length = 0;


            // 이름 구성 할 세트 계산하기 위한 상위 레벨
            string before_parent_level = "";
            string now_parent_level = "";


            // 이름 구성 할 세트
            int start_row = -1;
            int end_row = -1;
            int parent_row = -1;


            //-------------------------------------------------------------------------------------------------------------------
            // 임가공 전체 구조 처음, 마지막 행
            //-------------------------------------------------------------------------------------------------------------------
            int[] template_row = Search_Joint_Bom_Range(arg_row);
            if (template_row == null) return;

            int template_first_row = template_row[0];
            int template_last_row = template_row[1];
            //-------------------------------------------------------------------------------------------------------------------


            //-------------------------------------------------------------------------------------------------------------------
            // 선택 임가공 레벨은 강제 설정하였고, 그 윗 레벨부터 실행되어야 하므로 길이 계산
            //-------------------------------------------------------------------------------------------------------------------
            max_level_length = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;
            //-------------------------------------------------------------------------------------------------------------------


            //-------------------------------------------------------------------------------------------------------------------
            // 레벨 계산 후 값 생성
            //-------------------------------------------------------------------------------------------------------------------
            now_level_length = 0;


            // a > 1 인 이유는 하위 레벨로 상위 임가공 명 만들기 때문에 1 레벨은 11 레벨에서 자동 처리 되므로
            for (int a = max_level_length; a > 1; a--)
            {


                // 선택 레벨의 시작과 끝, 상위 임가공 위치 지정
                // 상위 레벨이 같은 것이 한 세트 이므로 한 세트씩 처리

                for (int b = template_first_row; b <= template_last_row; b++)
                {

                    color_name = "";


                    // 선택 레벨 계산
                    now_level_length = fgrid_Yield[b, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;
                    if (now_level_length != a) continue;


                    // 상위 레벨 계산
                    now_parent_level = fgrid_Yield[b, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Substring(0, now_level_length - 1);
                    if (before_parent_level == now_parent_level) continue;



                    C1.Win.C1FlexGrid.Node node = fgrid_Yield.Rows[b].Node;

                    start_row = node.GetNode(NodeTypeEnum.Parent).GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    end_row = node.GetNode(NodeTypeEnum.Parent).GetNode(NodeTypeEnum.LastChild).Row.Index;
                    parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index;



                    //-------------------------------------------------------------------------------------------------------------------
                    // color_name
                    //-------------------------------------------------------------------------------------------------------------------
                    string[] token = null;
                    string item_name = "";


                    for (int j = start_row; j <= end_row; j++)
                    {

                        now_level_length = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL].ToString().Length;
                        if (now_level_length != a) continue;


                        if (color_name.Equals(""))
                        {
                            color_name = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME].ToString();
                        }
                        else
                        {
                            color_name += "/" + fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME].ToString();
                        }

                    } // end for j 
                    //-------------------------------------------------------------------------------------------------------------------


                    //-------------------------------------------------------------------------------------------------------------------
                    // color code 자동 할당
                    //-------------------------------------------------------------------------------------------------------------------
                    if (fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _SubLimation
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _SubLimationPaper
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Printing
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _Painting
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _ShieldGraphic
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _HeatTransfer
                        || fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD].ToString() == _PuffScreen)
                    {
                    }
                    // color code 자동 할당
                    else
                    {

                        fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = color_name;

                    }
                    //-------------------------------------------------------------------------------------------------------------------


                    //-------------------------------------------------------------------------------------------------------------------
                    // update 표시
                    //-------------------------------------------------------------------------------------------------------------------
                    if (Empty_String(fgrid_Yield[parent_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                    {

                        for (int i = template_first_row; i <= template_last_row; i++)
                        {

                            fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";

                        } // end for i child

                    }
                    //-------------------------------------------------------------------------------------------------------------------


                    before_parent_level = now_parent_level;



                } // end int b 세트


            } // end for a 하위 레벨부터 상위 임가공 명 만들어가면서 처리
            //-------------------------------------------------------------------------------------------------------------------



        }



        /// <summary>
        /// Create_Joint_Material : 임가공 동일 구조 확인 및 임가공, 컬러 신규 등록
        /// </summary>
        /// <param name="arg_row"></param>
        private void Create_Joint_Material(int arg_row)
        {
 
            
            //-------------------------------------------------------------------------------------------------------------------
            // 임가공 전체 구조 처음, 마지막 행
            //-------------------------------------------------------------------------------------------------------------------
            int[] template_row = Search_Joint_Bom_Range(arg_row);
            if (template_row == null) return;

            int template_first_row = template_row[0];
            int template_last_row = template_row[1];
            //-------------------------------------------------------------------------------------------------------------------

            string row_type = "";
            string item_name1 = "";
            string item_name2 = "";
            string color_name = "";
            string template_cd = "";
            string mng_unit = "";
            string size_yn = "";
            string upd_user = ""; 


            //-------------------------------------------------------------------------------------------------------------------
            // 임가공명, 컬러 조합 코드 확인
            // 동일명 없을 경우 신규 코드로 등록 되어야 함
            //-------------------------------------------------------------------------------------------------------------------
            for (int i = template_first_row; i <= template_last_row; i++)
            {


                row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

                if (row_type != _RowType_JointMaterial) continue;


                item_name1 = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1], "");
                item_name2 = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2], "");
                color_name = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME], "");
                template_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD], "");
                mng_unit = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT], "");
                size_yn = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
                upd_user = ClassLib.ComVar.This_User; 
                


                DataTable dt_ret = CHECK_SBC_YIELD_JOINT_MAT(item_name1, item_name2, color_name, template_cd, mng_unit, size_yn, upd_user);


                if(dt_ret == null || dt_ret.Rows.Count == 0) 
                {
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = "";
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = "";
                }
                else
                {
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = Empty_String(dt_ret.Rows[0].ItemArray[0], "");
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = Empty_String(dt_ret.Rows[0].ItemArray[1], "");
                }


                // 임가공 구조 중 컬러를 상속받지 못하는 임가공이 있는 경우,
                // 컬러 이름 처음에 / 나오면 신규 컬러 추가 하지 않고, 수정 후 작업되도록 하기 위함
                if (color_name.Length > 0 && color_name.Substring(0, 1) == "/")
                {
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = "";
                    continue;
                }



            } // end for i


        }



        /// <summary>
        /// Reset_Joint_BOM : 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
        /// </summary>
        /// <param name="arg_row"></param>
        public void Reset_Joint_BOM(int arg_row)
        {

            // 선택한 아이템의 template_tree_cd 가 00005가 아니면 임가공 구조임
            string template_tree_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD], "");
            if (template_tree_cd == _JointBOM_Only_Material) return; // 원자재 구조임

            
            
            // 원자재 모두 입력되었는지 확인
            bool check_ok = Check_Create_Joint_Condition(arg_row, false);
            if (!check_ok) return;



            // 임가공 구조 다시 생성
            //// 원자재 수정 될 때만 재 생성
            string row_type = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

            if (row_type != _RowType_Material)
            {   

                // 임가공 컬러가 바뀐 경우 그 상위 컬러명 다시 생성
                Create_Joint_Color_Name(arg_row);

                // 임가공 동일 구조 확인 및 임가공, 컬러 신규 등록
                Create_Joint_Material(arg_row);

            }
            else
            {
                
                Create_Joint_Process(arg_row);

            }



        }



        /// <summary>
        /// Create_Joint_YieldValue : 임가공 아이템의 채산 값 할당 (Unit 이 같은 원자재의 채산값으로 할당)
        /// </summary>
        private void Create_Joint_YieldValue(int arg_row)
        {


            //-------------------------------------------------------------------------------------------------------------------
            // 임가공 전체 구조 처음, 마지막 행
            //-------------------------------------------------------------------------------------------------------------------
            int[] template_row = Search_Joint_Bom_Range(arg_row);
            if (template_row == null) return;

            int template_first_row = template_row[0];
            int template_last_row = template_row[1];
            //-------------------------------------------------------------------------------------------------------------------


            string row_type = "";
            string size_yn = "";
            string spec_cd = "";
            string spec_name = "";
            string mng_unit_joint = "";
            string mng_unit_material = "";


            for (int i = template_first_row; i <= template_last_row; i++)
            {

                row_type = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");
                size_yn = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
                spec_cd = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
                spec_name = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");

                if (row_type != _RowType_JointMaterial) continue;

                mng_unit_joint = Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT], "");


                int first_row = fgrid_Yield.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
                int last_row = fgrid_Yield.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
                int child_row = -1;


                // 원자재 중 unit 이 같은 리스트 찾기
                for (int a = first_row; a <= last_row; a++)
                {


                    if (Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Material) continue;


                    mng_unit_material = Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT], "");


                    if (mng_unit_material != mng_unit_joint) continue;

                    child_row = a;

                    break;


                } // end for a




                for (int a = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a < fgrid_Yield.Cols.Count; a++)
                {


                    // value
                    if (child_row != -1)
                    {
                        fgrid_Yield[i, a] = fgrid_Yield[child_row, a];
                    }


                    // spec 세팅 안 되어 있는 신규일 경우에는
                    // 사이즈 아닌 아이템은 헤더 spec 설정,
                    // 사이즈 아이템은 복사되는 행의 사이즈 spec 설정

                    CellRange cr = fgrid_Yield.GetCellRange(i, a);


                    if (size_yn == "Y")
                    {

                        if (child_row != -1)
                        {
                            cr.UserData = Empty_String(fgrid_Yield.GetCellRange(child_row, a).UserData, "");
                        }
                        else
                        {
                            cr.UserData = _SpecCd_Default + _UserData_Spec_Symbol + _SpecName_Default;
                        }

                    }
                    else
                    {
                        cr.UserData = spec_cd + _UserData_Spec_Symbol + spec_name;
                    } // end if (size_yn == "Y")



                } // end for a


                // 생성된 임가공 사이즈 그룹 표시
                Reset_Size_Material(i);


            } // end for i




        }




        #endregion



        /// <summary>
        /// Event_menuItem_SetComp_Click : 
        /// </summary>
        private void Event_menuItem_SetComp_Click()
        {

            try
            {


                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                // select component
                if (fgrid_Yield.Col < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "I"
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "") == "")
                {

                    // component 신규 추가
                    Select_GridCombo_Component(fgrid_Yield,
                       (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC,
                       (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD,
                       (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME,
                       true);

                } // end select material

                


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_menuItem_SetMat_Click : 
        /// </summary>
        private void Event_menuItem_SetMat_Click()
        {

            try
            {


                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


                // 임가공 구조일 경우에는 component 종속 이름이 만들어 지지 않기 때문에,
                // component 가 정해져 있지 않으면 실행 할 수 없음 

                // select material
                if (fgrid_Yield.Col < (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Semigood
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Component
                    && Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "") != "")
                {

                    Show_Popup_Material_Select(fgrid_Yield.Row, "");

                } // end select material




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Yield_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }






        /// <summary>
        /// Show_Popup_Material_Select : 
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_default_tabpage"></param>
        private void Show_Popup_Material_Select(int arg_row, string arg_default_tabpage)
        {


            string item_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "");
            string item_name1 = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1], "");
            string item_name2 = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2], "");
            string row_type = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "");

            string item_name = "";

            if (row_type == _RowType_JointMaterial)
            {
                item_name = item_name2;
            }
            else
            {
                item_name = item_name1;
            }

            string spec_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
            string spec_name = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");
            string color_cd = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "");
            string color_name = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME], "");
            string unit = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT], "");
            string size_yn = Empty_String(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
            string default_tabpage = arg_default_tabpage;
            int grid_select_row = arg_row;


            if (pop_select_material == null)
            {

                pop_select_material = new Pop_Yield_Select_Material(this, item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn, default_tabpage, grid_select_row);

            }
            else
            {


                pop_select_material._Parent_Form = this;

                pop_select_material._ItemCd = item_cd;
                pop_select_material._ItemName = item_name;
                pop_select_material._SpecCd = spec_cd;
                pop_select_material._SpecName = spec_name;
                pop_select_material._ColorCd = color_cd;
                pop_select_material._ColorName = color_name;
                pop_select_material._Unit = unit;
                pop_select_material._SizeYN = size_yn;
                pop_select_material._DefaultTabPage = "";
                pop_select_material._GridSelectRow = arg_row;

                pop_select_material.Init_Form();


            }


            pop_select_material.Show();

        }





        /// <summary>
        /// Event_menuItem_DeleteMat_Click : 
        /// </summary>
        private void Event_menuItem_DeleteMat_Click()
        {

            try
            {

                Delete_Material("D");

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_DeleteMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_menuItem_DeleteCancelMat_Click : 
        /// </summary>
        private void Event_menuItem_DeleteCancelMat_Click()
        {

            try
            {

                Delete_Material("");

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_DeleteCancelMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Delete_Material : 
        /// </summary>
        /// <param name="arg_division"></param>
        private void Delete_Material(string arg_division)
        {


            _Run_Event_Display_Value = false;


            //------------------------------------------------------
            // 선택 구간 설정
            //------------------------------------------------------
            int[] sel_row_range = fgrid_Yield.Selections;



            foreach (int sel_row in sel_row_range)
            {

                if (Empty_String(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Semigood)
                {

                    if (fgrid_Yield.Rows[sel_row].Node.Children == 0)
                    {
                        //fgrid_Yield.Rows[sel_row].Selected = true;

                        // semigood은 delete 표시 안함
                        fgrid_Yield.Rows[sel_row].Selected = false;
                    }
                    else
                    {

                        // semigood은 delete 표시 안함
                        fgrid_Yield.Rows[sel_row].Selected = false;


                        // semigood 밑에 마지막 component까지 선택
                        int last_component_row = fgrid_Yield.Rows[sel_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

                        for (int i = sel_row + 1; i <= last_component_row; i++)
                        {
                            fgrid_Yield.Rows[i].Selected = true;
                        }


                        //// component 밑에 마지막 아이템까지 선택
                        if (fgrid_Yield.Rows[last_component_row].Node.Children > 0)
                        {

                            int last_item_row = fgrid_Yield.Rows[last_component_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

                            for (int i = sel_row + 1; i <= last_item_row; i++)
                            {
                                fgrid_Yield.Rows[i].Selected = true;
                            }


                            // 마지막 아이템 임가공 전체 구조 처음, 마지막 행
                            int[] template_row = Search_Joint_Bom_Range(last_item_row);

                            if (template_row != null)
                            {
                                for (int i = template_row[0]; i <= template_row[1]; i++)
                                {
                                    fgrid_Yield.Rows[i].Selected = true;
                                }
                            }

                        } // end if (fgrid_Yield.Rows[last_component_row].Node.Children > 0)


                    } // end if


                }
                else if (Empty_String(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_Component)
                {

                    if (fgrid_Yield.Rows[sel_row].Node.Children == 0)
                    {
                        fgrid_Yield.Rows[sel_row].Selected = true;
                    }
                    else
                    {


                        //// component 밑에 마지막 아이템까지 선택
                        for (int i = sel_row + 1; i <= fgrid_Yield.Rows[sel_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index; i++)
                        {
                            fgrid_Yield.Rows[i].Selected = true;
                        }


                        // 마지막 아이템 임가공 전체 구조 처음, 마지막 행
                        int[] template_row = Search_Joint_Bom_Range(fgrid_Yield.Rows[sel_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index);

                        if (template_row != null)
                        {
                            for (int i = template_row[0]; i <= template_row[1]; i++)
                            {
                                fgrid_Yield.Rows[i].Selected = true;
                            }
                        }




                    } // end if

                }
                else
                {

                    // 임가공 전체 구조 처음, 마지막 행
                    int[] template_row = Search_Joint_Bom_Range(sel_row);

                    if (template_row != null)
                    {
                        for (int i = template_row[0]; i <= template_row[1]; i++)
                        {
                            fgrid_Yield.Rows[i].Selected = true;
                        }
                    }


                    // 원자재 및 임가공 삭제 하는 경우, 하위 모두 삭제될 때 (구조 하나뿐인 경우)
                    // component 함께 삭제 되어야 함

                    // 선택 구조의 첫번째 (template_level = 1) 행의 부모 행이 component 임
                    int component_row = fgrid_Yield.Rows[template_row[0]].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

                    // component 마지막 자식 행의 마지막 구조 행이 component 마지막 행임
                    int component_last_child_row = fgrid_Yield.Rows[component_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

                    int[] last_template_row = Search_Joint_Bom_Range(component_last_child_row);

                    if (last_template_row == null) continue;


                    int undelete_child_count = 0;

                    for (int i = component_row + 1; i <= last_template_row[1]; i++)
                    {
                        if (fgrid_Yield.Rows[i].Selected) continue;

                        undelete_child_count++;
                    }

                    if (undelete_child_count == 0)
                    {
                        fgrid_Yield.Rows[component_row].Selected = true;
                    }




                } // end if row_type
                    


            } // end foreach


            sel_row_range = fgrid_Yield.Selections;
            //------------------------------------------------------



            for (int i = fgrid_Yield.Rows.Count - 1; i >= fgrid_Yield.Rows.Fixed; i--)
            {


                if (fgrid_Yield.Rows[i].Selected == false) continue;

                // component 이동 후 지워질 데이터 이지만, history 남겨야 하므로 M 유지
                if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "M")
                {
                    fgrid_Yield.Rows[i].Selected = false;
                    continue;
                }


                if (Empty_String(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") == "I")
                {
                    if (arg_division == "D")
                    {
                        fgrid_Yield.Rows.Remove(i);
                    }
                }
                else
                {
                    fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = arg_division;

                    fgrid_Yield.Rows[i].Selected = false;
                }


            } // end for i


            _Run_Event_Display_Value = true;

        }




        /// <summary>
        /// Event_menuItem_InsertRawMat_Excel_Click : 
        /// </summary>
        private void Event_menuItem_InsertRawMat_Excel_Click()
        {

            try
            {

                
                string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                string semi_good_cd = "UP";
                string component_cd = "";
                string component_name = "";
                string template_seq = "";
                int child_first_row = -1;
                int child_last_row = -1;
                int find_semigood_row = -1;
                int find_component_row = -1;
                int insert_row = -1; 
                int insert_order = 0;
                int now_order = 0;
                int component_seq = 0;
                int check_item_count = 0;
                int insert_row_material = 0;



                // check 된 아이템 component 단위로 처리
                for (int i = fgrid_Excel.Rows.Fixed; i < fgrid_Excel.Rows.Count; i++)
                {


                    check_item_count = 0;


                    if (fgrid_Excel.Rows[i].Node.Children == 0) continue;



                    child_first_row = fgrid_Excel.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    child_last_row = fgrid_Excel.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                    //---------------------------------------
                    // check 된 아이템 없는 경우 적용 대상에서 제외
                    //---------------------------------------
                    for (int a = child_first_row; a <= child_last_row; a++)
                    {

                        // ITEM SETTING 한 것만 이동
                        if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                        // CHECK된 아이템만 이동
                        if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;


                        check_item_count++;
                    }


                    if (check_item_count == 0) continue;
                    //---------------------------------------


                    //---------------------------------------
                    // component 중복 확인
                    //---------------------------------------
                    component_cd = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT], "");
                    component_name = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");


                    if (component_cd == "")
                    {

                        //string message = "We must input component : [" + component_name + "]";
                        //ClassLib.ComFunction.User_Message(message, "Insert_Material_Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        continue;

                    }


                    // component 체크
                    bool duplicate_flag = Check_Duplicate_Component(factory, style_cd, component_cd, false, -1);


                    // 이미 component 있으면 SKIP
                    if (duplicate_flag)
                    {

                        string message = "We have already component : [" + component_name + "]";
                        ClassLib.ComFunction.User_Message(message, "Insert_Material_Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        continue;
                    }
                    //---------------------------------------



                    //---------------------------------------
                    // component 추가 위치 계산
                    //---------------------------------------
                    // UP 맨 아래에 추가하기 위함
                    find_semigood_row = fgrid_Yield.FindRow(semi_good_cd, fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD, false, true, false);
                    find_semigood_row = (find_semigood_row == -1) ? fgrid_Yield.Rows.Count - 1 : find_semigood_row;


                    // excel ordering 번호로 순서 맞춰서 추가
                    // 현재 order 보다 큰 행 위에 insert
                    insert_order = i;
                    now_order = 0;
                    find_component_row = -1;



                    for (int a = find_semigood_row; a < fgrid_Yield.Rows.Count; a++)
                    {

                        now_order = Convert.ToInt32(Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER], "0"));

                        if (insert_order < now_order)
                        {
                            find_component_row = a;
                            break;
                        }

                    } // end for a


                    find_component_row = (find_component_row == -1) ? fgrid_Yield.Rows.Count : find_component_row;


                    component_seq = Get_Next_Component_Seq(find_component_row - 1, true);
                    //---------------------------------------



                    // insert component row
                    fgrid_Yield.Rows.Insert(find_component_row);

                    fgrid_Yield.Rows[find_component_row].IsNode = true;
                    fgrid_Yield.Rows[find_component_row].Node.Level = 1;
                    fgrid_Yield.GetCellRange(find_component_row, 1, find_component_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;


                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = 1;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = factory;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = style_cd;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = semi_good_cd;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT], "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = _RowType_Component;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = component_seq.ToString();
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxYIELD_STATUS] = ClassLib.ComFunction.Empty_Combo(cmb_YieldStatus, "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER] = insert_order.ToString();


                    CellRange cr = fgrid_Excel.GetCellRange(i, 1, i, fgrid_Excel.Cols.Count - 1);
                    cr.StyleNew.ForeColor = Color.Blue;
                    //cr.StyleNew.BackColor = Color.WhiteSmoke; //.Lavender;



                    // component view depth
                    Set_Component_ViewDepth(find_component_row);



                    insert_row = find_component_row + 1;



                    fgrid_Yield.Rows.InsertRange(insert_row, check_item_count);

                    insert_row_material = 0;



                    for (int a = child_first_row; a <= child_last_row; a++)
                    {


                        // ITEM SETTING 한 것만 이동
                        if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                        // CHECK된 아이템만 이동
                        if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;

                        // CHECK 해제
                        fgrid_Excel.SetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);



                        // 입력 행 위에 template_seq 로 증가시켜야 함으로
                        template_seq = Empty_String(fgrid_Yield[(insert_row + insert_row_material - 1), (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "0");


                        fgrid_Yield.Rows[insert_row + insert_row_material].IsNode = true;
                        fgrid_Yield.Rows[insert_row + insert_row_material].Node.Level = 2;


                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = 2;
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = factory;
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = style_cd;
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = Empty_String(fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = Empty_String(fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = Empty_String(fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = _RowType_Material;
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = Empty_String(fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ] = Convert.ToString(Convert.ToInt32(template_seq) + 1);
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL] = "1";  // 원자재 레벨
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD] = _JointBOM_Only_Material;  // 원자재 구조
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = "";
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD] = "02J13000";  // 원자재 임가공 명
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMNG_UNIT], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSIZE_YN], "");
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_PROPERTY] = "";
                        fgrid_Yield[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER] = Empty_String(fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER], "");


                        //------------------------------------------------------
                        // excel 채산값을 grid 로 이동
                        Set_MovetoExcel_YieldValue(a, insert_row + insert_row_material);


                        // 사이즈 자재 여부에 따른 채산값 재 설정
                        // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                        Reset_Size_Material(insert_row + insert_row_material);


                        // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
                        Reset_Joint_BOM(insert_row + insert_row_material);
                        //------------------------------------------------------


                        insert_row_material++;



                        cr = fgrid_Excel.GetCellRange(a, 1, a, fgrid_Excel.Cols.Count - 1);
                        cr.StyleNew.ForeColor = Color.Blue;
                        //cr.StyleNew.BackColor = Color.WhiteSmoke; //.Lavender;



                    } // end for a


                    fgrid_Yield.TopRow = ((insert_row - 5) < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : (insert_row - 5);
                    fgrid_Yield.Select(insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, true);

                     

                } // end for i
                 
              

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_InsertRawMat_Excel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Set_MovetoExcel_YieldValue : excel 채산값을 grid 로 이동
        /// </summary>
        /// <param name="arg_row_excel"></param>
        /// <param name="arg_row_grid"></param>
        private void Set_MovetoExcel_YieldValue(int arg_row_excel, int arg_row_grid)
        {


            //------------------------------------------------------
            // 초기화
            //------------------------------------------------------
            for (int a = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a < fgrid_Yield.Cols.Count; a++)
            {
                fgrid_Yield[arg_row_grid, a] = "-1";

            } // end for a


            //------------------------------------------------------
            // 사이즈 채산값 세팅 
            // 우선순위 : 사이즈 채산값 -> 공통 채산값
            //------------------------------------------------------
            // 공통 채산값
            if (Empty_String(fgrid_Excel[arg_row_excel, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START], "") == "")
            {

                try
                {


                    double yield_value_common = Convert.ToDouble(fgrid_Excel[arg_row_excel, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMMON_YIELD_VALUE].ToString());


                    for (int a = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a < fgrid_Yield.Cols.Count; a++)
                    {
                        fgrid_Yield[arg_row_grid, a] = yield_value_common;

                    } // end for a


                }
                catch // 숫자형이 아니기 때문에 채산값 아니므로 할당 할 필요 없음
                {

                    for (int a = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a < fgrid_Yield.Cols.Count; a++)
                    {
                        fgrid_Yield[arg_row_grid, a] = "";

                    } // end for a

                }

            }
            // 사이즈 채산값
            else
            {


                string excel_size = "";
                string yield_size = "";
                string yield_value = "";

                for (int a = (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCS_SIZE_START; a < fgrid_Excel.Cols.Count; a++)
                {

                    excel_size = Empty_String(fgrid_Excel[1, a], "");
                    yield_value = Empty_String(fgrid_Excel[arg_row_excel, a], "-1");


                    // 동일 사이즈 문대 찾아서 표시
                    for (int b = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; b < fgrid_Yield.Cols.Count; b++)
                    {

                        yield_size = Empty_String(fgrid_Yield[1, b], "");

                        if (excel_size == yield_size)
                        {

                            fgrid_Yield[arg_row_grid, b] = yield_value;

                            break;
                        }

                    } // end for b


                } // end for a

            }
            //------------------------------------------------------ 

            //------------------------------------------------------
            // 중간 미할당된 사이즈 채산값 세팅 (바로 전(이전 문대 사이즈) 사이즈 채산값으로 할당)
            //------------------------------------------------------
            for (int a = (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; a < fgrid_Yield.Cols.Count; a++)
            {

                // 초기화에서 -1 로 미리 세팅 해 놓았기 때문에, null 체크 필요 없음
                // -1 이 아니면 채산값 할당 된 상태임
                if (fgrid_Yield[arg_row_grid, a].ToString() != "-1") continue;


                //// 첫 컬럼부터 데이터 없는 경우
                //if (a == (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START)
                //{

                //    for (int b = a; b < fgrid_Yield.Cols.Count; b++)
                //    {

                //        if (fgrid_Yield[arg_row_grid, b].ToString() == "-1") continue;


                //        for (int c = a; c < b; c++)
                //        {
                //            fgrid_Yield[arg_row_grid, c] = fgrid_Yield[arg_row_grid, b].ToString();
                //        } // end for c


                //        break;

                //    } // end for b

                //}
                //else
                //{

                //    fgrid_Yield[arg_row_grid, a] = fgrid_Yield[arg_row_grid, a - 1].ToString();

                //}


                int sel_order = Convert.ToInt32(Empty_String(fgrid_Yield[2, a], "0"));
                int now_order = -1;
                int copy_col = -1;


                for (int b = a; b >= (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START; b--)
                {

                    if (fgrid_Yield[arg_row_grid, b].ToString() == "-1") continue;

                    now_order = Convert.ToInt32(Empty_String(fgrid_Yield[2, b], "0"));
                    copy_col = b;

                    break;
                }


                if (a == (int)ClassLib.TBSBC_YIELD_NEW.IxCS_SIZE_START || sel_order < now_order)
                {

                    for (int b = a; b < fgrid_Yield.Cols.Count; b++)
                    {

                        if (fgrid_Yield[arg_row_grid, b].ToString() == "-1") continue;

                        now_order = Convert.ToInt32(Empty_String(fgrid_Yield[2, b], "0"));
                        copy_col = b;

                        break;
                    }

                }


                fgrid_Yield[arg_row_grid, a] = fgrid_Yield[arg_row_grid, copy_col].ToString();


            } // end for a
            //------------------------------------------------------


        }
         


        /// <summary>
        /// Event_menuItem_InsertJointMat_Excel_Click : 
        /// </summary>
        private void Event_menuItem_InsertJointMat_Excel_Click()
        {

            try
            {


                string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                string semi_good_cd = "UP";
                string component_cd = "";
                string component_name = "";
                int template_seq = 0;
                int template_level_length = 0;
                int child_first_row = -1;
                int child_last_row = -1;
                int find_semigood_row = -1;
                int find_component_row = -1;
                int insert_row = -1;
                int insert_order = 0;
                int now_order = 0;
                int component_seq = 0;
                int check_item_count = 0;
                int first_row = -1;
                int last_row = -1;



                // 구조 찾기 전에 체크 하나도 없는 경우 실행 하지 않음
                for (int i = fgrid_Excel.Rows.Fixed; i < fgrid_Excel.Rows.Count; i++)
                {

                    if (fgrid_Excel.Rows[i].Node.Children == 0) continue;


                    child_first_row = fgrid_Excel.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    child_last_row = fgrid_Excel.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                    //---------------------------------------
                    // check 된 아이템 없는 경우 적용 대상에서 제외
                    //---------------------------------------
                    for (int a = child_first_row; a <= child_last_row; a++)
                    {

                        // ITEM SETTING 한 것만 이동
                        if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                        // CHECK된 아이템만 이동
                        if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;


                        check_item_count++;
                    } 
                    //---------------------------------------


                }


                if (check_item_count == 0) return;


                
                //------------------------------------------------------
                // 임가공 구조 찾는 팝업 실행
                //------------------------------------------------------
                FlexBase.Yield_New.Pop_Yield_Joint_Template pop_form = new FlexBase.Yield_New.Pop_Yield_Joint_Template();
                pop_form.ShowDialog();


                // template 구조 조회
                if (pop_form._CancelFlag) return;


                DataTable dt_ret = SELECT_SBC_YIELD_JOINT_BOM(pop_form._JointTemplate);

                if (dt_ret == null || dt_ret.Rows.Count == 0) return;
                //------------------------------------------------------






                // check 된 아이템 component 단위로 처리
                for (int i = fgrid_Excel.Rows.Fixed; i < fgrid_Excel.Rows.Count; i++)
                {


                    check_item_count = 0;


                    if (fgrid_Excel.Rows[i].Node.Children == 0) continue;



                    child_first_row = fgrid_Excel.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    child_last_row = fgrid_Excel.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                    //---------------------------------------
                    // check 된 아이템 없는 경우 적용 대상에서 제외
                    //---------------------------------------
                    for (int a = child_first_row; a <= child_last_row; a++)
                    {

                        // ITEM SETTING 한 것만 이동
                        if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                            || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                        // CHECK된 아이템만 이동
                        if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;


                        check_item_count++;
                    }


                    if (check_item_count == 0) continue;
                    //---------------------------------------


                    //---------------------------------------
                    // component 중복 확인
                    //---------------------------------------
                    component_cd = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT], "");
                    component_name = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");


                    if (component_cd == "")
                    {

                        //string message = "We must input component : [" + component_name + "]";
                        //ClassLib.ComFunction.User_Message(message, "Insert_Material_Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        continue;

                    }


                    // component 체크
                    bool duplicate_flag = Check_Duplicate_Component(factory, style_cd, component_cd, false, -1);


                    // 이미 component 있으면 아이템만 추가
                    if (duplicate_flag)
                    {

                        string message = "We have already component : [" + component_name + "]";
                        ClassLib.ComFunction.User_Message(message, "Insert_Material_Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        continue;
                    }
                    //---------------------------------------



                    //---------------------------------------
                    // component 추가 위치 계산
                    //---------------------------------------
                    // UP 맨 아래에 추가하기 위함
                    find_semigood_row = fgrid_Yield.FindRow(semi_good_cd, fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD, false, true, false);
                    find_semigood_row = (find_semigood_row == -1) ? fgrid_Yield.Rows.Count - 1 : find_semigood_row;


                    // excel ordering 번호로 순서 맞춰서 추가
                    // 현재 order 보다 큰 행 위에 insert
                    insert_order = i;
                    now_order = 0;
                    find_component_row = -1;



                    for (int a = find_semigood_row; a < fgrid_Yield.Rows.Count; a++)
                    {

                        now_order = Convert.ToInt32(Empty_String(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER], "0"));

                        if (insert_order < now_order)
                        {
                            find_component_row = a;
                            break;
                        }

                    } // end for a


                    find_component_row = (find_component_row == -1) ? fgrid_Yield.Rows.Count : find_component_row;

                    component_seq = Get_Next_Component_Seq(find_component_row - 1, true);
                    //---------------------------------------

                     

                    // insert component row
                    fgrid_Yield.Rows.Insert(find_component_row);
                    fgrid_Yield.Rows[find_component_row].IsNode = true;
                    fgrid_Yield.Rows[find_component_row].Node.Level = 1;
                    fgrid_Yield.GetCellRange(find_component_row, 1, find_component_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;


                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = 1;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = factory;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = style_cd;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = semi_good_cd;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT], "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = Empty_String(fgrid_Excel[i, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = _RowType_Component;
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = component_seq.ToString();
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxYIELD_STATUS] = ClassLib.ComFunction.Empty_Combo(cmb_YieldStatus, "");
                    fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER] = insert_order.ToString();



                    CellRange cr = fgrid_Excel.GetCellRange(i, 1, i, fgrid_Excel.Cols.Count - 1);
                    cr.StyleNew.ForeColor = Color.Blue;
                    //cr.StyleNew.BackColor = Color.WhiteSmoke; //.Lavender;



                    // component view depth
                    Set_Component_ViewDepth(find_component_row);




                    insert_row = find_component_row + 1;

 

                    //------------------------------------------------------
                    // joint 구조
                    //------------------------------------------------------
                    template_seq = Convert.ToInt32(Empty_String(fgrid_Yield[insert_row - 1, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "0"));


                    fgrid_Yield.Rows.InsertRange(insert_row, dt_ret.Rows.Count);


                    for (int j = 0; j < dt_ret.Rows.Count; j++)
                    {

                        fgrid_Yield.Rows[insert_row + j].IsNode = true;

                        template_level_length = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_LEVEL], "0").Length - 1;
                        fgrid_Yield.Rows[insert_row + j].Node.Level = 2 + template_level_length;

                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "I";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_LEVEL] = 2 + template_level_length;
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_NAME], "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxFACTORY] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxSTYLE_CD] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD] = semi_good_cd;
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD] = component_cd;
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME] = component_name;
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxROW_TYPE], "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_SEQ] = Convert.ToString(component_seq);
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ] = Convert.ToString(template_seq + 1);
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_LEVEL], "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_TREE_CD] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_TREE_CD], "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_CD], "");

                        // 임가공 구조 중 원자재
                        if (Empty_String(fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_CD], "") == _RawMaterial)
                        {
                            fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = "";
                        }
                        else
                        {
                            fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_NAME] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxTEMPLATE_NAME], "");
                        }

                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = "";
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxMNG_UNIT], "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxSIZE_YN], "");
                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER] = Empty_String(fgrid_Yield[find_component_row, (int)ClassLib.TBSBC_YIELD_NEW.IxEXCEL_COMPONENT_ORDER], "");


                        string property_model = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_MODEL], "");
                        string property_style = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_STYLE], "");
                        string property_component = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_COMPONENT], "");
                        string property_gender = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_GENDER], "");
                        string property_prefix = Empty_String(dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_JOINT_TEMPLATE_NEW.IxPROPERTY_PREFIX], "");
                        string property = property_model + property_style + property_component + property_gender + property_prefix;

                        fgrid_Yield[insert_row + j, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_PROPERTY] = property;


                    } // end for j
                    //------------------------------------------------------


                    
                    //------------------------------------------------------
                    // U, B 속성 읽어서 기본 구조에 원자재, 채산값 세팅 해 줌
                    //------------------------------------------------------ 

                    //------------------------------------------------------
                    // 임가공 전체 구조 처음, 마지막 행
                    //------------------------------------------------------
                    int[] template_row = Search_Joint_Bom_Range(insert_row);
                    if (template_row == null) return;

                    int template_first_row = template_row[0];
                    int template_last_row = template_row[1];
                    //------------------------------------------------------


                    // first_row : component_row
                    // first_row + 1: material_row

                    first_row = i;
                    last_row = child_last_row;

                    first_row = first_row + 1;



                    for (int j = template_first_row; j <= template_last_row; j++)
                    {

                        if (Empty_String(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") != _RowType_Material) continue;



                        fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = "";



                        if (pop_form._JointTemplateLoading == "B")
                        {

                            for (int a = last_row; a >= first_row; a--)
                            {


                                // ITEM SETTING 한 것만 이동
                                if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                                    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                                    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                                // CHECK된 아이템만 이동
                                if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;

                                // CHECK 해제
                                fgrid_Excel.SetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);


                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMNG_UNIT], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSIZE_YN], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR], "");


                                //------------------------------------------------------
                                // excel 채산값을 grid 로 이동
                                Set_MovetoExcel_YieldValue(a, j);


                                // 사이즈 자재 여부에 따른 채산값 재 설정
                                // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                                Reset_Size_Material(j);

                                // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
                                Reset_Joint_BOM(j);
                                //------------------------------------------------------


                                cr = fgrid_Excel.GetCellRange(a, 1, a, fgrid_Excel.Cols.Count - 1);
                                cr.StyleNew.ForeColor = Color.Blue;
                                //cr.StyleNew.BackColor = Color.WhiteSmoke; //.Lavender; 


                                last_row = a - 1;

                                break;

                            } // end for j 


                        }
                        else
                        {


                            for (int a = first_row; a <= last_row; a++)
                            {


                                // ITEM SETTING 한 것만 이동
                                if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                                    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                                    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                                // CHECK된 아이템만 이동
                                if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;
                                
                                // CHECK 해제
                                fgrid_Excel.SetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);


                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME2] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMNG_UNIT], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSIZE_YN], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_UNIT], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "");
                                fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME] = Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR], "");


                                //------------------------------------------------------
                                // excel 채산값을 grid 로 이동
                                Set_MovetoExcel_YieldValue(a, j);


                                // 사이즈 자재 여부에 따른 채산값 재 설정
                                // if 사이즈 자재 였다가 사이즈 자재 아닌것으로 수정 된 경우, spec 도 모두 변경 되어야 함
                                Reset_Size_Material(j);

                                // 임가공 구조 내의 아이템이었다면, 구조 모두 수정되어야 함
                                Reset_Joint_BOM(j);
                                //------------------------------------------------------


                                cr = fgrid_Excel.GetCellRange(a, 1, a, fgrid_Excel.Cols.Count - 1);
                                cr.StyleNew.ForeColor = Color.Blue;
                                //cr.StyleNew.BackColor = Color.WhiteSmoke; //.Lavender; 


                                first_row = a + 1;

                                break;

                            } // end for j 



                        } // end if (pop_form._JointTemplateLoading == "B")




                    } // end for j




                    fgrid_Yield.TopRow = ((insert_row - 5) < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : (insert_row - 5);
                    fgrid_Yield.Select(insert_row, (int)ClassLib.TBSBC_YIELD_NEW.IxDISPLAY_DESC, true);



                } // end for i 
                 


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_InsertJointMat_Excel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_menuItem_CutComponent_Click : 
        /// </summary>
        private void Event_menuItem_CutComponent_Click()
        {

            try
            {
                Data_Copy_Cut("CUT");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_CutComponent_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_menuItem_PasteComponent_Click : 
        /// </summary>
        private void Event_menuItem_PasteComponent_Click()
        {

            try
            {
                Data_Paste();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_PasteComponent_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_menuItem_CopyYieldValue_Click : 
        /// </summary>
        /// <returns></returns>
        private void Event_menuItem_CopyYieldValue_Click()
        {
            try
            {

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_CopyYieldValue_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_menuItem_PasteYieldValue_Click : 
        /// </summary>
        private void Event_menuItem_PasteYieldValue_Click()
        {
            try
            {

                
                if (fgrid_Excel.Rows.Count <= fgrid_Excel.Rows.Fixed) return;
                if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;



                // excel 채산값을 grid 로 이동
                Set_MovetoExcel_YieldValue(fgrid_Excel.Row, fgrid_Yield.Row);


                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION], "") != "I")
                {
                    fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxDIVISION] = "U";
                }



                fgrid_Yield.Select(fgrid_Yield.Row, 0, false);

                

                // 임가공 구조일 때 임가공 채산값 등록 하면 원자재 모두 적용
                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxROW_TYPE], "") == _RowType_JointMaterial)
                {
                    Input_Yield_Value_Joint();
                }




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_PasteYieldValue_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_menuItem_CopyComponent_Click : 
        /// </summary>
        private void Event_menuItem_CopyComponent_Click()
        {

            try
            {


                //------------------------------------------------------
                // 선택 구간 설정
                //------------------------------------------------------
                int[] sel_row_range = fgrid_Excel.Selections;


                // component 밑에 원자재 구조까지 모두 선택하게 하기 위함

                foreach (int sel_row in sel_row_range)
                {

                    if (fgrid_Excel.Rows[sel_row].Node.Children == 0)
                    {
                        fgrid_Excel.Rows[fgrid_Excel.Rows[sel_row].Node.GetNode(NodeTypeEnum.Parent).Row.Index].Selected = true;
                    }
                    else
                    {
                        for (int i = sel_row + 1; i <= sel_row + fgrid_Excel.Rows[sel_row].Node.Children; i++)
                        {
                            fgrid_Excel.Rows[i].Selected = true;
                        }
                    }

                } // end foreach

                sel_row_range = fgrid_Excel.Selections;
                //------------------------------------------------------


                int check_item_count = 0;
                int child_first_row = 0;
                int child_last_row = 0;
                int insert_row = 0;
                int insert_row_material = 0;


                foreach (int sel_row in sel_row_range)
                {


                    check_item_count = 0;


                    if (fgrid_Excel.Rows[sel_row].Node.Children == 0) continue;


                    child_first_row = fgrid_Excel.Rows[sel_row].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
                    child_last_row = fgrid_Excel.Rows[sel_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                    for (int a = child_first_row; a <= child_last_row; a++)
                    {

                        //// ITEM SETTING 한 것만 이동
                        //if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                        //    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                        //    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;

                        // CHECK된 아이템만 이동
                        if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;


                        check_item_count++;
                    }


                    if (check_item_count == 0)
                    {
                        continue;
                    }



                    // insert component row
                    fgrid_Excel.Rows.Insert(child_last_row + 1);

                    fgrid_Excel.Rows[child_last_row + 1].IsNode = true;
                    fgrid_Excel.Rows[child_last_row + 1].Node.Level = 1;
                    fgrid_Excel.GetCellRange(child_last_row + 1, 1, child_last_row + 1, fgrid_Excel.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;


                    for (int a = 0; a < fgrid_Excel.Cols.Count; a++)
                    {
                        fgrid_Excel[child_last_row + 1, a] = fgrid_Excel[sel_row, a];
                    } // end for a


                    CellRange cr = fgrid_Excel.GetCellRange(child_last_row + 1, 1, child_last_row + 1, fgrid_Excel.Cols.Count - 1);
                    cr.StyleNew.ForeColor = Color.DarkGreen;
                    cr.StyleNew.BackColor = Color.MintCream;

                    // copy division 추가
                    fgrid_Excel[child_last_row + 1, 0] = "C";



                    // component 선택되어 있는 경우 check 표시, 색깔 표시
                    if (Empty_String(fgrid_Excel[child_last_row + 1, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOMPONENT], "").Trim() != "")
                    {
                        cr = fgrid_Excel.GetCellRange(child_last_row + 1, 1, child_last_row + 1, fgrid_Excel.Cols.Count - 1);
                        cr.StyleNew.ForeColor = Color.Red;
                        cr.StyleNew.BackColor = Color.White;
                    }




                    // insert material row
                    insert_row = (child_last_row + 1) + 1;


                    fgrid_Excel.Rows.InsertRange(insert_row, check_item_count);

                    insert_row_material = 0;



                    for (int a = child_first_row; a <= child_last_row; a++)
                    {


                        //// ITEM SETTING 한 것만 이동
                        //if (Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "") == ""
                        //    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "") == ""
                        //    || Empty_String(fgrid_Excel[a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "") == "") continue;


                        // CHECK된 아이템만 이동
                        if (fgrid_Excel.GetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE).Equals(CheckEnum.Unchecked)) continue;

                        // CHECK 해제
                        fgrid_Excel.SetCellCheck(a, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL_USE, CheckEnum.Unchecked);

                        // copy 된 대상은 회색으로 표시
                        cr = fgrid_Excel.GetCellRange(a, 1, a, fgrid_Excel.Cols.Count - 1);
                        cr.StyleNew.ForeColor = Color.Gray;



                        fgrid_Excel.Rows[insert_row + insert_row_material].IsNode = true;
                        fgrid_Excel.Rows[insert_row + insert_row_material].Node.Level = 2;


                        for (int b = 0; b < fgrid_Excel.Cols.Count; b++)
                        {
                            fgrid_Excel[insert_row + insert_row_material, b] = fgrid_Excel[a, b];
                        } // end for a



                        cr = fgrid_Excel.GetCellRange(insert_row + insert_row_material, 1, insert_row + insert_row_material, fgrid_Excel.Cols.Count - 1);
                        cr.StyleNew.ForeColor = Color.DarkGreen;
                        cr.StyleNew.BackColor = Color.MintCream;


                        // copy division 추가
                        fgrid_Excel[insert_row + insert_row_material, 0] = "C";


                        // item, spec, color 모두 선택되어 있는 경우 check 표시, 색깔 표시
                        if (Empty_String(fgrid_Excel[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxITEM_CD], "").Trim() != ""
                            && Empty_String(fgrid_Excel[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxSPEC_CD], "").Trim() != ""
                            && Empty_String(fgrid_Excel[insert_row + insert_row_material, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxCOLOR_CD], "").Trim() != "")
                        {
                            cr = fgrid_Excel.GetCellRange(insert_row + insert_row_material, 1, insert_row + insert_row_material, fgrid_Excel.Cols.Count - 1);
                            cr.StyleNew.ForeColor = Color.Red;
                            cr.StyleNew.BackColor = Color.White;
                        }



                        insert_row_material++;



                    } // end for a


                    fgrid_Excel.TopRow = ((fgrid_Excel.Row - 5) < fgrid_Excel.Rows.Fixed) ? fgrid_Excel.Rows.Fixed : (fgrid_Excel.Row - 5);
                    fgrid_Excel.Select(fgrid_Excel.Row, (int)ClassLib.TBSBC_YIELD_EXCEL_LOADING_NEW.IxMATERIAL, true);



                } // end foreach




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_CopyComponent_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        /// <summary>
        /// Event_menuItem_DeleteCopyComponent_Click : 
        /// </summary>
        private void Event_menuItem_DeleteCopyComponent_Click()
        {

            try
            {

                //------------------------------------------------------
                // 선택 구간 설정
                //------------------------------------------------------
                int[] sel_row_range = fgrid_Excel.Selections;


                // component 밑에 원자재 구조까지 모두 선택하게 하기 위함

                foreach (int sel_row in sel_row_range)
                {

                    if (fgrid_Excel.Rows[sel_row].Node.Children == 0)
                    {
                        fgrid_Excel.Rows[fgrid_Excel.Rows[sel_row].Node.GetNode(NodeTypeEnum.Parent).Row.Index].Selected = true;
                    }
                    else
                    {
                        for (int i = sel_row + 1; i <= sel_row + fgrid_Excel.Rows[sel_row].Node.Children; i++)
                        {
                            fgrid_Excel.Rows[i].Selected = true;
                        }
                    }

                } // end foreach

                sel_row_range = fgrid_Excel.Selections;
                //------------------------------------------------------


                foreach (int sel_row in sel_row_range)
                {


                    if (fgrid_Excel.Rows[sel_row].Node.Children == 0) continue;


                    // copy된 component만 삭제 가능
                    if (Empty_String(fgrid_Excel[sel_row, 0], "") != "C") continue;


                    // component 1 + child node count
                    fgrid_Excel.Rows.RemoveRange(sel_row, 1 + fgrid_Excel.Rows[sel_row].Node.Children);


                } // end foreach


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_DeleteCopyComponent_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        /// <summary>
        /// Event_menuItem_ChangeMatInsert_Click : 
        /// </summary>
        private void Event_menuItem_ChangeMatInsert_Click()
        {

            try
            {
                Change_Material("I");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ChangeMatInsert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Event_menuItem_ChangeMatUpdate_Click : 
        /// </summary>
        private void Event_menuItem_ChangeMatUpdate_Click()
        {

            try
            {
                Change_Material("U");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ChangeMatUpdate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_menuItem_ChangeMatDelete_Click : 
        /// </summary>
        private void Event_menuItem_ChangeMatDelete_Click()
        {

            try
            {
                Change_Material("D");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ChangeMatDelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Change_Material : 
        /// </summary>
        /// <param name="arg_division"></param>
        private void Change_Material(string arg_division)
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

            if (fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;


            // 행 수정상태 해제 
            fgrid_Yield.Select(fgrid_Yield.Row, fgrid_Yield.Col, false);


            //--------------------------------------------------------------------------------------------------
            //popup 창 파라미터 구성 
            //--------------------------------------------------------------------------------------------------
            string factory = cmb_Factory.SelectedValue.ToString();

            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
            string style_cd = cmb_StyleCd.SelectedValue.ToString();
            string style_name = cmb_StyleCd.Columns[1].Text;
            string gender = cmb_StyleCd.Columns[2].Text;
            string presto_yn = cmb_StyleCd.Columns[3].Text;
            
            string sg_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSEMI_GOOD_CD], "");
            string component_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_CD], "");
            string component_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOMPONENT_NAME], "");
            string template_seq = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_SEQ], "");
            string template_level = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxTEMPLATE_LEVEL], "");
            string item_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_CD], "");
            string item_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxITEM_NAME1], "");
            string unit = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxMNG_UNIT], "");
            string size_yn = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "");
            string spec_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_CD_HEAD], "");
            string spec_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSPEC_NAME_HEAD], "");
            string color_cd = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_CD], "");
            string color_name = Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxCOLOR_NAME], "");


            string[] pop_parameter = new string[] { arg_division, 
													  factory, 
													  style_cd, 
                                                      style_name,
                                                      gender,
                                                      presto_yn,
													  sg_cd, 
													  component_cd, 
                                                      component_name,
                                                      template_seq,
                                                      template_level,
													  item_cd, 
													  item_name,
													  unit, 
													  size_yn, 
													  spec_cd, 
													  spec_name,
													  color_cd, 
													  color_name };

            //-------------------------------------------------------------------------------------------------- 

            FlexBase.Yield_New.Pop_Yield_MultiChange_Material pop_form = new FlexBase.Yield_New.Pop_Yield_MultiChange_Material(pop_parameter);
            pop_form.ShowDialog();


            if (pop_form._CancelFlag) return;


            // 완료 된 후 다시 조회
            Event_tbtn_Search_Click(false, true);


        }




        #endregion


        #endregion

        #region 디비 연결


        #region 콤보


        /// <summary>
        /// SELECT_SDC_STYLE : 스타일 리스트, 스타일 채산 상태 포함
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        public static DataTable SELECT_SDC_STYLE(string arg_factory, string arg_style_cd)
        {


            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SDC_STYLE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
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



        /// <summary>
        /// SELECT_SBC_COMPONENT_COMBO : 
        /// </summary>
        /// <param name="arg_component"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_COMPONENT_COMBO(string arg_component)
        {


            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_COMPONENT_COMBO";

                MyOraDB.Parameter_Name[0] = "ARG_COMPONENT";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_component;
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




        /// <summary>
        /// CHECK_SBC_YIELD_COMPONENT : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <returns>duplicate : true</returns>
        private bool CHECK_SBC_YIELD_COMPONENT(string arg_factory, string arg_style_cd, string arg_component_cd)
        {

            try
            {


                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.CHECK_SBC_YIELD_COMPONENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_component_cd;
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
        /// SELECT_SBC_ITEM_COMBO : 
        /// </summary>
        /// <param name="arg_group_cd"></param>
        /// <param name="arg_item"></param>
        /// <param name="arg_code_div"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_ITEM_COMBO(string arg_group_cd, string arg_item, string arg_code_div)
        {


            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_ITEM_COMBO";

                MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD";
                MyOraDB.Parameter_Name[1] = "ARG_ITEM";
                MyOraDB.Parameter_Name[2] = "ARG_CODE_DIV";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_group_cd;
                MyOraDB.Parameter_Values[1] = arg_item;
                MyOraDB.Parameter_Values[2] = arg_code_div;
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
        /// SELECT_SBC_SPEC_COMBO : 
        /// </summary>
        /// <param name="arg_spec_div"></param>
        /// <param name="arg_spec"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_SPEC_COMBO(string arg_spec_div, string arg_spec)
        {


            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_SPEC_COMBO";

                MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
                MyOraDB.Parameter_Name[1] = "ARG_SPEC";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_spec_div;
                MyOraDB.Parameter_Values[1] = arg_spec;
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



        /// <summary>
        /// SELECT_SBC_COLOR_COMBO : 
        /// </summary>
        /// <param name="arg_color"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_COLOR_COMBO(string arg_color)
        {


            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_COLOR_COMBO";

                MyOraDB.Parameter_Name[0] = "ARG_COLOR";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_color;
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



        /// <summary>
        /// SELECT_SBC_ITEM_SPEC_COMBO : item에 대한 default specification 정보 조회 
        /// </summary>
        /// <param name="arg_item_cd"></param>
        /// <returns></returns>
        public static DataTable SELECT_SBC_ITEM_SPEC_COMBO(string arg_item_cd)
        {

            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_ITEM_SPEC_COMBO";

                MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_item_cd;
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



        /// <summary>
        /// SAVE_SBC_ITEM_SPEC_COMBO : 
        /// </summary>
        /// <param name="arg_item_cd"></param>
        /// <param name="arg_spec_cd"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns>
        public static bool SAVE_SBC_ITEM_SPEC_COMBO(string arg_item_cd, string arg_spec_cd, string arg_division)
        {

            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SAVE_SBC_ITEM_SPEC_COMBO";

                //02.ARGURMENT명
                MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[1] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[2] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

                //03.DATA TYPE
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의  
                MyOraDB.Parameter_Values[0] = arg_item_cd;
                MyOraDB.Parameter_Values[1] = arg_spec_cd;
                MyOraDB.Parameter_Values[2] = arg_division;
                MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;



                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

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

        #region 조회



        /// <summary>
        /// SELECT_SIZE_HEAD : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SIZE_HEAD(string arg_factory, string arg_style_cd)
        {


            try
            {


                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
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



        /// <summary>
        /// SELECT_SBC_YIELD : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataSet SELECT_SBC_YIELD(string arg_factory, string arg_style_cd)
        {


            try
            {


                // 1. yield main
                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = "";


                MyOraDB.Add_Select_Parameter(true);


                // 2. yield duplicate component
                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.CHECK_SBC_YIELD_COMPONENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = "";


                MyOraDB.Add_Select_Parameter(false);






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
        /// SELECT_SBC_YIELD_JOINT_BOM : 
        /// </summary>
        /// <param name="arg_template_tree_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SBC_YIELD_JOINT_BOM(string arg_template_tree_cd)
        {


            try
            {


                MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD_JOINT_BOM";

                MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_template_tree_cd;
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



        /// <summary>
        /// CHECK_SBC_YIELD_JOINT_MAT : 
        /// </summary>
        /// <param name="arg_item_name1"></param>
        /// <param name="arg_item_name2"></param>
        /// <param name="arg_color_name"></param>
        /// <param name="arg_template_cd"></param>
        /// <param name="arg_mng_unit"></param>
        /// <param name="arg_size_yn"></param>
        /// <param name="arg_upd_user"></param>
        /// <returns></returns>
        private DataTable CHECK_SBC_YIELD_JOINT_MAT(string arg_item_name1,
            string arg_item_name2,
            string arg_color_name,
            string arg_template_cd,
            string arg_mng_unit,
            string arg_size_yn,
            string arg_upd_user)
        {


            try
            {


                MyOraDB.ReDim_Parameter(8);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.CHECK_SBC_YIELD_JOINT_MAT";

                MyOraDB.Parameter_Name[0] = "ARG_ITEM_NAME1";
                MyOraDB.Parameter_Name[1] = "ARG_ITEM_NAME2";
                MyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
                MyOraDB.Parameter_Name[3] = "ARG_TEMPLATE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_MNG_UNIT";
                MyOraDB.Parameter_Name[5] = "ARG_SIZE_YN";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_item_name1;
                MyOraDB.Parameter_Values[1] = arg_item_name2;
                MyOraDB.Parameter_Values[2] = arg_color_name;
                MyOraDB.Parameter_Values[3] = arg_template_cd;
                MyOraDB.Parameter_Values[4] = arg_mng_unit;
                MyOraDB.Parameter_Values[5] = arg_size_yn;
                MyOraDB.Parameter_Values[6] = arg_upd_user;
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
        /// GET_SBC_YIELD_ITEM_GROUP_IN : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_item_cd"></param>
        /// <param name="arg_style_factory"></param>
        /// <param name="arg_style_gender"></param>
        /// <param name="arg_style_presto_yn"></param>
        /// <returns></returns>
        public static DataTable GET_SBC_YIELD_ITEM_GROUP_IN(string arg_factory, 
            string arg_style_cd, 
            string arg_item_cd,
            string arg_style_factory,
            string arg_style_gender,
            string arg_style_presto_yn)
        {


            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(7);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.GET_SBC_YIELD_ITEM_GROUP_IN";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_FACTORY";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_GENDER";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_PRESTO_YN";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";


                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;


                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_item_cd;
                MyOraDB.Parameter_Values[3] = arg_style_factory;
                MyOraDB.Parameter_Values[4] = arg_style_gender;
                MyOraDB.Parameter_Values[5] = arg_style_presto_yn;
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



        /// <summary>
        /// SAVE_SBC_YIELD_ITEM_GROUP_IN : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_item_cd"></param>
        /// <returns></returns>
        private bool SAVE_SBC_YIELD_ITEM_GROUP_IN(string arg_factory, string arg_style_cd, string arg_item_cd)
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


                string before_spec = "";
                string now_spec = "";
                int size_f = -1;
                int size_t = -1;



                // delete -> insert
                vList.Add("D"); // "ARG_DIVISION";
                vList.Add(arg_factory); // "ARG_FACTORY";
                vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                vList.Add(""); // "ARG_CS_SIZE_FROM";
                vList.Add(""); // "ARG_CS_SIZE_TO";
                vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                vList.Add(""); // "ARG_SPEC_CD";
                vList.Add(""); // "ARG_YIELD_M";
                vList.Add(ClassLib.ComVar.This_User + "-move"); // "ARG_UPD_USER";




                //-----------------------------------------------
                // gender 상관없이 all size 모두 포함되어야 하므로 빈 size 계산 
                //-----------------------------------------------
                // result_ret
                // row 0 : cs_size
                // row 1 : yield_value
                // row 2 : spec_cd

                int result_dt_row_cs_size = 0;
                int result_dt_row_value = 1;
                int result_dt_row_spec_cd = 2;


                DataTable dt_ret_allsize = ClassLib.ComFunction.Select_SIZE_COLHEAD_ALL(ClassLib.ComVar.This_Factory);


                // create return table
                DataTable result_ret = new DataTable(); 


                for (int i = 0; i < dt_ret_allsize.Rows.Count; i++)
                {
                    result_ret.Columns.Add(new DataColumn("CS_SIZE" + i.ToString(), typeof(string)));

                } // end for i


                // cs_size
                DataRow dr_cs_size = result_ret.NewRow();

                for (int i = 0; i < dt_ret_allsize.Rows.Count; i++)
                {
                    dr_cs_size["CS_SIZE" + i.ToString()] = dt_ret_allsize.Rows[i].ItemArray[0].ToString();

                } // end for i

                result_ret.Rows.Add(dr_cs_size);



                // style value 이동
                string cs_size_value = "";
                string cs_size_all = "";


                DataRow dr_value = result_ret.NewRow();
                DataRow dr_spec_cd = result_ret.NewRow();


                for (int i = (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START; i < fgrid_Value.Cols.Count; i++)
                {

                    cs_size_value = Empty_String(fgrid_Value[1, i], "");


                    for (int j = 0; j < result_ret.Columns.Count; j++)
                    {

                        cs_size_all = Empty_String(result_ret.Rows[0].ItemArray[j], "");

                        if (cs_size_value == cs_size_all)
                        {

                            dr_value["CS_SIZE" + j.ToString()] = Empty_String(fgrid_Value[_Value_Row_Yield, i], "");
                            dr_spec_cd["CS_SIZE" + j.ToString()] = Empty_String(fgrid_Value[_Value_Row_SpecCode, i], "");
 
                            break;
                        }


                    } // end for j


                } // end for i


                result_ret.Rows.Add(dr_value);
                result_ret.Rows.Add(dr_spec_cd);



                // all size 공백 부분 NOTHING 적용
                for (int i = 0; i < result_ret.Columns.Count; i++)
                {

                    if(Empty_String(result_ret.Rows[result_dt_row_spec_cd].ItemArray[i], "") != "") continue;

                    dr_value[i] = Empty_String(fgrid_Value[_Value_Row_Yield, (int)ClassLib.TBSBC_YIELD_VALUE_NEW.IxCS_SIZE_START], "");
                    dr_spec_cd[i] = _SpecCd_Default;

                } // end for i
                //-----------------------------------------------




                size_f = 0;


                if (Empty_String(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_NEW.IxSIZE_YN], "") == "Y") // 사이즈 아이템일 경우, spec으로 사이즈 그룹 구분
                {


                    while (true)
                    {

                        before_spec = (result_ret.Rows[result_dt_row_spec_cd].ItemArray[size_f] == null) ? "" : result_ret.Rows[result_dt_row_spec_cd].ItemArray[size_f].ToString();


                        for (int k = size_f; k < result_ret.Columns.Count; k++)
                        {

                            now_spec = (result_ret.Rows[result_dt_row_spec_cd].ItemArray[k] == null) ? "" : result_ret.Rows[result_dt_row_spec_cd].ItemArray[k].ToString();


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
                        vList.Add(arg_factory); // "ARG_FACTORY";
                        vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                        vList.Add(result_ret.Rows[result_dt_row_cs_size].ItemArray[size_f].ToString()); // "ARG_CS_SIZE_FROM";
                        vList.Add(result_ret.Rows[result_dt_row_cs_size].ItemArray[size_t].ToString()); // "ARG_CS_SIZE_TO";
                        vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                        vList.Add((result_ret.Rows[result_dt_row_spec_cd].ItemArray[size_f] == null) ? "" : result_ret.Rows[result_dt_row_spec_cd].ItemArray[size_f].ToString()); // "ARG_SPEC_CD";
                        //vList.Add((result_ret.Rows[result_dt_row_value].ItemArray[size_f] == null) ? "0" : result_ret.Rows[result_dt_row_value].ItemArray[size_f].ToString()); // "ARG_YIELD_M";
                        vList.Add("0"); // "ARG_YIELD_M";
                        vList.Add(ClassLib.ComVar.This_User + "-move"); // "ARG_UPD_USER";


                        size_f = size_t + 1;

                        if (size_f == result_ret.Columns.Count) break;

                    } // end while



                }
                else // 사이즈 아이템 아닐 경우, value로 사이즈 그룹 구분
                {


                    while (true)
                    {

                        before_spec = (result_ret.Rows[result_dt_row_value].ItemArray[size_f] == null) ? "0" : result_ret.Rows[result_dt_row_value].ItemArray[size_f].ToString();

                        for (int k = size_f; k < result_ret.Columns.Count; k++)
                        {

                            now_spec = (result_ret.Rows[result_dt_row_value].ItemArray[k] == null) ? "0" : result_ret.Rows[result_dt_row_value].ItemArray[k].ToString();


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
                        vList.Add(arg_factory); // "ARG_FACTORY";
                        vList.Add(arg_style_cd); // "ARG_STYLE_CD";
                        vList.Add(result_ret.Rows[result_dt_row_cs_size].ItemArray[size_f].ToString()); // "ARG_CS_SIZE_FROM";
                        vList.Add(result_ret.Rows[result_dt_row_cs_size].ItemArray[size_t].ToString()); // "ARG_CS_SIZE_TO";
                        vList.Add(arg_item_cd); // "ARG_ITEM_CD";
                        vList.Add((result_ret.Rows[result_dt_row_spec_cd].ItemArray[size_f] == null) ? "" : result_ret.Rows[result_dt_row_spec_cd].ItemArray[size_f].ToString()); // "ARG_SPEC_CD";
                        //vList.Add((result_ret.Rows[result_dt_row_value].ItemArray[size_f] == null) ? "0" : result_ret.Rows[result_dt_row_value].ItemArray[size_f].ToString()); // "ARG_YIELD_M";
                        vList.Add("0"); // "ARG_YIELD_M";
                        vList.Add(ClassLib.ComVar.This_User + "-move"); // "ARG_UPD_USER";


                        size_f = size_t + 1;

                        if (size_f == result_ret.Columns.Count) break;

                    } // end while



                }





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

                ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_YIELD_ITEM_GROUP_IN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }





        /// <summary>
        /// CHECK_SBC_YIELD_SPEC_NAME : 
        /// </summary>
        /// <param name="arg_spec_name"></param>
        /// <returns></returns>
        public static string CHECK_SBC_YIELD_SPEC_NAME(string arg_spec_name)
        {

            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.CHECK_SBC_YIELD_SPEC_NAME";

                MyOraDB.Parameter_Name[0] = "ARG_SPEC_NAME";
                MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                MyOraDB.Parameter_Values[0] = arg_spec_name;
                MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
                MyOraDB.Parameter_Values[2] = ""; 



                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

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