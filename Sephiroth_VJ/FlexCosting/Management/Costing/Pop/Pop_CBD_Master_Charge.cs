using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Pop
{
    public partial class Pop_CBD_Master_Charge : COM.PCHWinForm.Pop_Large
    {
        #region 생성자 

        public Pop_CBD_Master_Charge()
        {
            InitializeComponent();
            Init_Form();
        }

        #endregion


        #region 전역변수 

        private COM.OraDB MyOraDB = new COM.OraDB();

        #endregion


        #region 이벤트 핸들러

        #region 폼 이벤트 

        private void Pop_CBD_Master_Mat_Load(object sender, EventArgs e)
        {
            tbtn_Search_Click(null, null);
        }

        #endregion

        #region 툴바 버튼 이벤트

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                ClearAll();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
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
                Search();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (Save())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        #endregion

        #region 컨트롤 이벤트

        #endregion

        #endregion


        #region 이벤트 처리

        #region 초기화

        private void Init_Form()
        {
            //Title
            this.Text = "Material Information";
            this.lbl_MainTitle.Text = "Material Information";

            Init_Grid();
            Init_Control();
            Init_Toolbar();
        }

        private void Init_Grid()
        {
            fgrid_CurMat.Set_Grid("SFX_CBD_M_MAT_CHARGE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_CurMat.Set_Action_Image(img_Action);
            fgrid_CurMat.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_CurMat.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_CurMat.AllowEditing = false;
            fgrid_CurMat.Font = new Font(fgrid_CurMat.Font.FontFamily, (float)8);
        }

        private void Init_Control()
        {

        }

        private void Init_Toolbar()
        {
            tbtn_New.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled = false;
        }

        #endregion

        #region 툴바 버튼 이벤트 처리

        private void ClearAll()
        {

        }

        private void Search()
        {
            fgrid_CurMat.ClearAll();

            string[] arg_value = new string[3];
            arg_value[0] = COM.ComVar.This_Factory;
            arg_value[1] = txt_CustCode.Text;

            DataTable vDT = SELECT_SFX_RP_LIST(arg_value);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    fgrid_CurMat.Rows.Add();

                    for (int j = fgrid_CurMat.Cols.Fixed; j < fgrid_CurMat.Cols.Count; j++)
                    {
                        fgrid_CurMat[fgrid_CurMat.Rows.Count - 1, j] = vDT.Rows[i].ItemArray[j].ToString();
                    }

                    fgrid_CurMat.GetCellRange(fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxDIV, fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxMXS_LOCATIONCODE).StyleNew.BackColor = Color.White;
                    fgrid_CurMat.GetCellRange(fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV, fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD).StyleNew.BackColor = Color.White;
                    fgrid_CurMat.GetCellRange(fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxSTATUS, fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUPD_YMD).StyleNew.BackColor = Color.White;
                    fgrid_CurMat.GetCellRange(fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC, fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS).StyleNew.BackColor = Color.FloralWhite;

                    fgrid_CurMat.GetCellRange(fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DIV, fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD).StyleNew.ForeColor = Color.Black;
                    fgrid_CurMat.GetCellRange(fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_DESC, fgrid_CurMat.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxREMARKS).StyleNew.ForeColor = Color.Black;

                }

                vDT.Dispose();
            }
        }

        private bool Save()
        {
            double dSelCharge = 0;
            string sChargeReason = "";

            foreach (int iCurRow in fgrid_CurMat.Selections)
            {
                dSelCharge += fgrid_CurMat.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                    fgrid_CurMat.GetCellRange(iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE, iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxUP_CHARGE));

                sChargeReason += fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD] == null ? "" : ", " + fgrid_CurMat[iCurRow, (int)ClassLib.TBSFX_CBD_M_MAT_RP.IxCHARGE_CD].ToString();
            }
            COM.ComVar.Parameter_PopUp = new string[] { dSelCharge.ToString(), sChargeReason };
            return true;
        }

        #endregion

        #region Properties

        public string CustCode
        {
            set
            {
                txt_CustCode.Text = value;
            }
        }

        public string CustName
        {
            set
            {
                txt_CustName.Text = value;
            }
        }

        #endregion

        #endregion


        #region 데이터베이스

        public DataTable SELECT_SFX_RP_LIST(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_M_MAT.SELECT_SFX_RP_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void fgrid_CurMat_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fgrid_CurMat_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

    }
}

