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

        #region ���� ���� ���� �� ����


        private COM.OraDB MyOraDB = new COM.OraDB();


        #endregion

        #region �̺�Ʈ �ڵ鷯

        #region ���� �̺�Ʈ

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

        #region �׸��� �̺�Ʈ


        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ


        #endregion

        #endregion

        #region �̺�Ʈ ó��

        #region �ʱ�ȭ

        /// <summary>
        /// Inti_Form : Form Load �� �ʱ�ȭ �۾�
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

        #region ���� �̺�Ʈ

        private void ClearAll()
        {

        }

        private void Search()
        {

        }

        #endregion

        #region �׸��� �̺�Ʈ



        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ


        #endregion

        #endregion

        #region ��� ����

        #region ����



        #endregion

        #region ��ȸ



        #endregion

        #endregion
    }
}

