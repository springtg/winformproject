using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace FlexCDC.FOB.CBDExcel
{
    public partial class ExcelUpload_5523 : COM.PCHWinForm.Form_Top
    {
        public ExcelUpload_5523()
        {
            InitializeComponent();
            Init_Form();
        }

        private Microsoft.Office.Interop.Excel.Workbook workbook = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        private Microsoft.Office.Interop.Excel.Application application = null;

        private int iTick = 1;
        private Thread TH_Search = null;
        private OpenFileDialog ofd = new OpenFileDialog();
        private string fileName = null;
        private DataSet vHDS = new DataSet("Header");
        private DataSet vTDS = new DataSet("Detail");

        #region Event 

        private void ExcelUpload_5523_Shown(object sender, EventArgs e)
        {
            //if (!timer_search.Enabled)
            //{
            //    if (SearchFile())
            //    {
            //        fgrid_head.ClearAll();
            //        fgrid_tail.ClearAll();

            //        TH_Search = new Thread(new ThreadStart(LoadExcel));
            //        TH_Search.Start();
            //        timer_search.Start();
            //    }
            //}
        }

        private void ExcelUpload_5523_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TH_Search != null)
            {
                if (TH_Search.ThreadState == ThreadState.Running)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (COM.ComFunction.Empty_Combo(cmb_fobType, " ").Equals(" "))
            {
                MessageBox.Show(this, "Select fob type", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!timer_search.Enabled)
            {
                if (SearchFile())
                {
                    fgrid_head.ClearAll();
                    fgrid_tail.ClearAll();

                    TH_Search = new Thread(new ThreadStart(LoadExcel));
                    TH_Search.Start();
                    timer_search.Start();
                }
            }
            
            //LoadExcel();
        }

        private void fgrid_head_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_head.Rows.Fixed <= fgrid_head.Rows.Count && fgrid_head.Row >= fgrid_head.Rows.Fixed)
                    DisplayTail(vTDS);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (!timer_search.Enabled)
                {
                    FOB.CBDExcel.V_1_220.DBMngr mngr = new FlexCDC.FOB.CBDExcel.V_1_220.DBMngr();
                    if (mngr.DEL_EBM_FOB_5523(fgrid_head))
                    {
                        if (mngr.SAVE_EBM_FOB_5523_HEAD(fgrid_head))
                        {
                            mngr.SAVE_EBM_FOB_5523_TAIL(fgrid_head, vTDS);
                        }
                    }

                    ClassLib.ComFunction.User_Message("Save complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_head_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (fgrid_head[e.Row, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxDETAIL_YN] == null)
            {
                e.Cancel = true;
                return;
            }

            if (fgrid_head[e.Row, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxDETAIL_YN].ToString().Equals("N"))
            {
                e.Cancel = true;
                return;
            }
        }

        private void timer_search_Tick(object sender, EventArgs e)
        {
            try
            {
                if (TH_Search.ThreadState != ThreadState.Running)
                {
                    cmb_fobType.Enabled = true;
                    timer_search.Stop();
                    DisplayHead(vHDS);
                    iTick = 0;
                }
                else
                {
                    string dot = "".PadLeft(iTick % 5, '.');

                    this.Text = "Loading" + dot + " (" + iTick++ + ")";
                    //prog_1.PerformStep();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Timer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event process

        #region 초기화

        private void Init_Form()
        {
            this.Text = "5523";
            this.lbl_MainTitle.Text = "5523";

            fgrid_head.Set_Grid("EBM_FOB_5523_HEAD", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_head.ExtendLastCol = false;

            fgrid_tail.Set_Grid("EBM_FOB_5523_TAIL", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_tail.ExtendLastCol = false;
            fgrid_tail.AllowEditing = false;

            timer_search.Stop();

            System.Data.DataTable vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_fobType, 1, 2, true, false);
            cmb_fobType.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
            vDT.Dispose();

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

                application = new Microsoft.Office.Interop.Excel.Application();
                workbook = (Workbook)(application.Workbooks.Open(fileName, Type.Missing, Type.Missing,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                application.Visible = false;
                application.DisplayAlerts = false;

                cmb_fobType.Enabled = false;
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

        private void LoadExcel()
        {
            try
            {
                vHDS.Tables.Clear();
                vTDS.Tables.Clear();

                CBDExcel.V_1_220.Header_5523 header = new FlexCDC.FOB.CBDExcel.V_1_220.Header_5523();
                header.Workbook = workbook;
                header.Fob_type = COM.ComFunction.Empty_Combo(cmb_fobType, "");

                if (header.CheckFormat())
                {
                    DataSet[] vDS = header.FillHeadData();

                    if (vDS.Length == 2)
                    {
                        vHDS = vDS[0];
                        vTDS = vDS[1];
                    }
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

        private void DisplayHead(DataSet vDS)
        {
            fgrid_head.ClearAll();
            foreach (System.Data.DataTable vDT in vDS.Tables)
            {
                // Sheet
                C1.Win.C1FlexGrid.Row newRow = fgrid_head.Rows.Add();
                newRow[(int)ClassLib.TBEBM_FOB_5523_HEAD.IxREGION] = vDT.TableName;
                newRow[(int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD] = vDT.TableName;
                newRow.IsNode = true;
                newRow.Node.Level = 0;

                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;

                fgrid_head.Display_Grid_Add(vDT, false);
            }

            for (int iRow = fgrid_head.Rows.Fixed; iRow < fgrid_head.Rows.Count; iRow++)
            {
                if (!fgrid_head.Rows[iRow].IsNode)
                {
                    fgrid_head.Rows[iRow].IsNode = true;
                    fgrid_head.Rows[iRow].Node.Level = 1;
                    if (fgrid_head[iRow, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxDETAIL_YN].ToString().Equals("N"))
                    {
                        fgrid_head.Rows[iRow].AllowEditing = false;
                        fgrid_head.Rows[iRow].StyleNew.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        fgrid_head.Rows[iRow].StyleNew.BackColor = Color.White;
                    }
                }
            }

            fgrid_head.Tree.Column = (int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD;
        }

        private void DisplayTail(DataSet vDS)
        {
            fgrid_tail.ClearAll();

            string sBOMID = fgrid_head[fgrid_head.Row, 5] == null ? "" : fgrid_head[fgrid_head.Row, 5].ToString();
            string sRegion = fgrid_head[fgrid_head.Row, 4] == null ? "" : fgrid_head[fgrid_head.Row, 4].ToString();
            string sStyleCD = fgrid_head[fgrid_head.Row, 3] == null ? "" : fgrid_head[fgrid_head.Row, 3].ToString();

            if (sRegion.Equals(sStyleCD))
            {
                foreach (System.Data.DataTable vDT in vDS.Tables)
                {
                    if (vDT.TableName.StartsWith(sRegion))
                        fgrid_tail.Display_Grid_Add(vDT, false);
                }
            }
            else
            {
                foreach (System.Data.DataTable vDT in vDS.Tables)
                {
                    if (vDT.TableName.Equals(sRegion + "_" + sBOMID))
                        fgrid_tail.Display_Grid(vDT, false);
                }
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
        private void RemoveWorkManagerment(Microsoft.Office.Interop.Excel.Application arg_app)
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

        public string Round
        {
            set
            {
                cmb_fobType.SelectedValue = value;

                if (cmb_fobType.SelectedIndex == -1)
                    cmb_fobType.SelectedIndex = 0;
            }
        }

        #endregion


        #endregion

    }
}

