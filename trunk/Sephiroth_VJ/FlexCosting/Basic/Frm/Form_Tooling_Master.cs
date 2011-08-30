using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Frm
{
    public partial class Form_Tooling_Master : COM.PCHWinForm.Form_Top
    {
        public Form_Tooling_Master()
        {
            InitializeComponent();

            Init_Form();
        }

        #region 전역 변수 선언 및 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        #endregion

        #region 이벤트 핸들러

        #region 툴바 이벤트

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                // ClearAll();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // Search();
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

        #endregion

        #region 그리드 이벤트


        #endregion

        #region 버튼 및 기타 이벤트


        #endregion

        #endregion

        #region 이벤트 처리

        #region 초기화

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {
                //Title
                this.Text = "Standard mold and tooling Info";
                this.lbl_MainTitle.Text = "Standard mold and tooling Info";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                //Init_Control();
                //Init_Toolbar();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFB_CBD_B_STD_TOOL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
        }

        private void Init_Control()
        {

        }

        private void Init_Toolbar()
        {

        }

        #endregion

        #region 툴바 이벤트

        private void ClearAll()
        {

        }

        private void Search()
        {

        }

        #endregion

        #region 그리드 이벤트



        #endregion

        #region 버튼 및 기타 이벤트


        #endregion

        #endregion

        #region 디비 연결

        #region 조건



        #endregion

        #region 조회



        #endregion

        #endregion
    }
}

