using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;
using C1.Win.C1FlexGrid;

namespace FlexVJ_Common.Material_Inspection
{      
    public partial class Form_MI_Reason : COM.VJ_CommonWinForm.Pop_Large
    {
        private COM.OraDB MyOraDB = new COM.OraDB();

        public Form_MI_Reason()
        {
            InitializeComponent();

            Init_Form();
        }

        private void Form_MI_Reason_Load(object sender, EventArgs e)
        {

        }

        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = "Reason Master";
                lbl_MainTitle.Text = "Reason Master";
                ClassLib.ComFunction.SetLangDic(this);

                DataTable vDt;

                // factory set
                vDt = COM.ComFunction.Select_Factory_List();
                COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

                // 그리드 설정
                fgrid_main.Set_Grid_Comm("SMI_REASON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_main.Set_Action_Image(img_Action);
                fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcrossOut;
                // 버튼 설정
                tbtn_Delete.Enabled = false;
                tbtn_Conform.Enabled = false;


                ClassLib.ComFunction.Init_Form_Control(this);
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            addrow();
        }
        private void addrow()
        {
            fgrid_main.Rows.Add();
            fgrid_main[fgrid_main.Rows.Count - 1, 0] = "I";
            fgrid_main.TopRow = fgrid_main.Rows.Count - 1;

            int iCol = fgrid_main.Selection.c1;
            int iRow = fgrid_main.Selection.r1;

            fgrid_main.Select(fgrid_main.Rows.Count-1  , 2);
            fgrid_main[fgrid_main.Rows.Count - 1, 5] = true;
            //fgrid_main.

            //if (fgrid_Main.Rows.Count > 3)
            //    fgrid_Main[fgrid_Main.Rows.Count - 1, 1] = Convert.ToInt16(fgrid_Main[fgrid_Main.Rows.Count - 2, 1]) + 1;
            //else
            //    fgrid_Main[fgrid_Main.Rows.Count - 1, 1] = 1;
        }

        private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            fgrid_main.Update_Row();
        }

        private void Tbtn_SaveProcess()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (SAVE_SMI_REASON(true))
                {
                    fgrid_main.Refresh_Division();
                    MessageBox.Show("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tbtn_SearchProcess();
                }
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public bool SAVE_SMI_REASON(bool doExecute)
        {
            try
            {
                int save_ct = 0;
                int para_ct = 0;
                int iCount = 8;
                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SAVE_SMI_REASON";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_REA_CODE";
                MyOraDB.Parameter_Name[3] = "ARG_REA_NAME";
                MyOraDB.Parameter_Name[4] = "ARG_VALUE1";
                MyOraDB.Parameter_Name[5] = "ARG_VALUE1_NAME";
                MyOraDB.Parameter_Name[6] = "ARG_FIX_TF";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

                //				MyOraDB.Parameter_Values  = new string[6];

                for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
                    if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals(""))
                        save_ct += 1;

                save_ct += 1; // HEAD RECORD

                // 파라미터 값에 저장할 배열
                MyOraDB.Parameter_Values = new string[iCount * save_ct];

                for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
                {
                    if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals(""))
                    {
                        MyOraDB.Parameter_Values[para_ct + 0] = (fgrid_main[iRow, 0] == null) ? "" : fgrid_main[iRow, 0].ToString();
                        MyOraDB.Parameter_Values[para_ct + 1] = cmb_factory.SelectedValue.ToString();
                        MyOraDB.Parameter_Values[para_ct + 2] = (fgrid_main[iRow, 1] == null) ? "" : fgrid_main[iRow, 1].ToString();
                        MyOraDB.Parameter_Values[para_ct + 3] = (fgrid_main[iRow, 2] == null) ? "" : fgrid_main[iRow, 2].ToString();
                        MyOraDB.Parameter_Values[para_ct + 4] = (fgrid_main[iRow, 3] == null) ? "" : fgrid_main[iRow, 3].ToString();
                        MyOraDB.Parameter_Values[para_ct + 5] = (fgrid_main[iRow, 4] == null) ? "" : fgrid_main[iRow, 4].ToString();
                        if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 5]).Equals(""))
                            MyOraDB.Parameter_Values[para_ct + 6] = "Y";
                        else
                            MyOraDB.Parameter_Values[para_ct + 6] = "N";
                        //MyOraDB.Parameter_Values[para_ct + 6] = (fgrid_main[iRow, 5] == null) ? "" : fgrid_main[iRow, 5].ToString();
                        MyOraDB.Parameter_Values[para_ct + 7] = COM.ComVar.This_User;

                        para_ct += iCount;
                    }

                }

                MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가

                if (doExecute)
                {
                    if (MyOraDB.Exe_Modify_Procedure() == null)
                        return false;
                    else
                        return true;
                }

                return true;

            }
            catch
            {
                return false;
            }

        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Tbtn_SaveProcess();
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Tbtn_SearchProcess();
        }

        private void Tbtn_SearchProcess() 
        {
            DataTable vDt1 = null;
            fgrid_main.Clear();


            fgrid_main.Set_Grid("SMI_REASON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.ExtendLastCol = false;
            try
            {
                vDt1 = SELECT_MAT_REASON();

                if (vDt1.Rows.Count > 0)
                {
                    for (int i = 0; i < vDt1.Rows.Count; i++)
                    {
                        fgrid_main.AddItem(vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
                    }

                }
                else
                {
                    MessageBox.Show("No Data !!");
                    return;
                }
            }

            catch
            {

            }
        }

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            addrow();
            
        }

        private System.Data.DataTable SELECT_MAT_REASON()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SMI_MAT_INS.SEARCH_SMI_REASON";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REA_CODE";
            MyOraDB.Parameter_Name[2] = "ARG_REA_NAME";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = txt_Rea_code.Text.Trim();
            MyOraDB.Parameter_Values[2] = txt_Rea_Name.Text ;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];

        }

        private void fgrid_main_DoubleClick(object sender, EventArgs e)
        {
            COM.FSP l_Flex = (COM.FSP)sender;
            if (l_Flex.RowSel < l_Flex.Rows.Fixed) return;
            this.Tag = l_Flex[l_Flex.RowSel, 1];
            DialogResult = DialogResult.OK;
        }
     
    }
}

