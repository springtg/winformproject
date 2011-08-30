using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Excel;

namespace FlexCDC.FOB.CBDExcel
{
    public partial class ExcelUpload_MEOF : COM.PCHWinForm.Form_Top
    {
        public ExcelUpload_MEOF()
        {
            InitializeComponent();
            Init_Form();
        }

        private Excel.Workbook workbook = null;
        private Excel.Worksheet worksheet = null;
        private Excel.Application application = null;
        private COM.OraDB MyOraDB = new COM.OraDB();

        private Thread TH_Search = null;
        private OpenFileDialog ofd = new OpenFileDialog();
        private string fileName = null;

        #region Event 

        private void ExcelUpload_MEOF_Shown(object sender, EventArgs e)
        {
            if (SearchFile())
            {
                ClearAll();
                LoadExcel();
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (SearchFile())
            {
                ClearAll();
                LoadExcel();
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                FOB.CBDExcel.V_1_220.DBMngr mngr = new FlexCDC.FOB.CBDExcel.V_1_220.DBMngr();

                if (mngr.DEL_EBM_FOB_MEOF(txt_factory.Text, txt_moid.Text))
                {
                    if (mngr.SAVE_EBM_FOB_MEOF_HEAD(fgrid_head))
                    {
                        if (!mngr.SAVE_EBM_FOB_MEOF_TAIL(fgrid_head, fgrid_size, txt_factory.Text, txt_moid.Text))
                        {
                            ClassLib.ComFunction.User_Message("Save fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                
                ClassLib.ComFunction.User_Message("Save complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event process

        #region 초기화

        private void Init_Form()
        {
            this.Text = "MEOF";
            this.lbl_MainTitle.Text = "MEOF"; 
            ClassLib.ComFunction.SetLangDic(this);

            fgrid_head.Set_Grid("EBM_FOB_MEOF_HEAD", "1", 4, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_head.ExtendLastCol = false;
            fgrid_head.Rows[1].Visible = fgrid_head.Rows[2].Visible = fgrid_head.Rows[3].Visible = fgrid_head.Rows[4].Visible = false;

            System.Data.DataTable vDT = MyOraDB.Select_GridHead("EBM_FOB_MEOF_HEAD", "2");
            for (int iRIdx = 0; iRIdx < vDT.Rows.Count; iRIdx++)
            {
                string sColName = vDT.Rows[iRIdx]["col_name"].ToString();
                string sHead1 = vDT.Rows[iRIdx]["head_desc1"].ToString();
                string sHead2 = vDT.Rows[iRIdx]["head_desc2"].ToString();
                string sHead3 = vDT.Rows[iRIdx]["lan_head_desc1"].ToString();
                string sHead4 = vDT.Rows[iRIdx]["lan_head_desc2"].ToString();

                C1.Win.C1FlexGrid.Row newRow = fgrid_head.Rows.Add();

                newRow[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxROW_NAME] = sColName;
                newRow[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxSUBJECT] = sHead1;
                newRow[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW] = sHead3;
                newRow[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_COL] = sHead4;
            }

            fgrid_size.Set_Grid("EBM_FOB_MEOF_TAIL", "1", 3, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_size.ExtendLastCol = false;
            fgrid_size.AllowEditing = false;
            fgrid_size.Rows[2].Visible = fgrid_size.Rows[3].Visible = false;

            tbtn_New.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Print.Enabled = false;
        }

        #endregion


        #region File 검색

        private bool SearchFile()
        {
            try
            {
                DisposedMainExcel();
                ofd.InitialDirectory = "";

                if (ofd.ShowDialog() == DialogResult.Cancel)
                {
                    return false;
                }

                fileName = ofd.FileName;

                application = new Excel.Application();
                workbook = (Workbook)(application.Workbooks.Open(fileName, Type.Missing, Type.Missing,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                application.Visible = false;
                application.DisplayAlerts = false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion


        #region 실행

        private void ClearAll()
        {
            fgrid_head.GetCellRange(fgrid_head.Rows.Fixed, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_1,
                fgrid_head.Rows.Count - 1, fgrid_head.Cols.Count - 1).Clear(C1.Win.C1FlexGrid.ClearFlags.Content);

            fgrid_size.ClearAll();
        }

        private void LoadExcel()
        {
            try
            {
                CBDExcel.V_1_220.Header_MEOF header = new FlexCDC.FOB.CBDExcel.V_1_220.Header_MEOF();
                header.Workbook = workbook;

                if (header.CheckFormat())
                {
                    header.FillHeadData(fgrid_head);
                    header.FillTailData(fgrid_head, fgrid_size);

                    txt_factory.Text = header.Factory;
                    txt_moid.Text = header.MOID;
                    txt_season.Text = header.Season;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisposedMainExcel();
            }
        }

        // 원본 엑셀 종료
        private void DisposedMainExcel()
        {
            try
            {
                if (application != null)
                {
                    if (worksheet != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    if (workbook != null)
                    {
                        workbook.Close(false, workbook.FullName, null);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    }
                    if (application == null)
                    {
                        application.Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                application = null;
                workbook = null;
                worksheet = null;

                GC.Collect();
            }
        }

        #endregion


        #region 기타

        // 작업관리자 정리
        private void RemoveWorkManagerment(Excel.Application arg_app)
        {
            try
            {
                if (arg_app != null)
                {
                    int wndNo = arg_app.Hwnd;

                    System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("EXCEL");

                    for (int i = 0; i < procs.Length; i++)
                    {
                        if (procs[i].MainModule.BaseAddress.ToInt32() == wndNo)
                        {
                            procs[i].Kill();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 작업관리자 정리
        private void RemoveFile(string arg_fileName)
        {
            try
            {
                if (arg_fileName != null && !arg_fileName.Equals(""))
                {
                    if (System.IO.File.Exists(arg_fileName))
                    {
                        System.IO.File.Delete(arg_fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 실행 중인지 여부 검사
        private bool Runable()
        {
            try
            {
                bool runable = true;


                return runable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion


        #endregion

    }
}

