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
    public partial class ExcelUploader : COM.PCHWinForm.Pop_Medium
    {
        public ExcelUploader()
        {
            InitializeComponent();


            // Title 
            this.Text = "Excel Uploading";
            this.lbl_MainTitle.Text = "Excel Uploading";
            ClassLib.ComFunction.SetLangDic(this);


            SetEvent();
        }

        private Excel.Workbook workbook = null;
        private Excel.Worksheet worksheet = null;
        private Excel.Application application = null;

        private Excel.Workbook[] workbooks = null;
        private Excel.Worksheet[] worksheets = null;
        private Excel.Application[] applications = null;
        private Thread[] uploadProcThread = null;

        OpenFileDialog ofd = new OpenFileDialog();

        private string fileName = null;
        private string version = null;

        private string[] steps = new string[] {
            "0. Ready", 
            "1. Validation check", 
            "2. Create header schema", 
            "3. Read header data", 
            "4. Make xml data", 
            "5. Create detail schema", 
            "6. Read detail data", 
            "7. Inset data", 
            "8. Upload complete"
        };

        #region File 검색

        private bool SearchFile()
        {
            try
            {
                chk_all.Checked = true;

                DisposedMainExcel();
                ofd.InitialDirectory = "";

                if (ofd.ShowDialog() == DialogResult.Cancel)
                {
                    return false;
                }

                fileName = ofd.FileName;

                lbl_selFile.Text = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1);

                application = new Excel.Application();
                workbook = (Workbook)(application.Workbooks.Open(fileName, Type.Missing, Type.Missing,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                application.Visible = false;
                application.DisplayAlerts = false;

                pnl_main.Controls.Clear();
                for (int i = 1, idx = 0; i < application.Sheets.Count; i++)
                {
                    worksheet = application.Sheets[i] as Worksheet;

                    int result = 0;
                    if (int.TryParse(worksheet.Name.Replace("-", ""), out result) && !worksheet.Name.Equals("5523"))
                    {
                        System.Windows.Forms.CheckBox chk = new System.Windows.Forms.CheckBox();
                        chk.Size = new Size(100, 20);
                        chk.Location = new System.Drawing.Point(20, idx * 60);
                        chk.Text = worksheet.Name;
                        chk.Tag = worksheet.Index;
                        chk.Checked = true;
                        chk.MouseDown += new MouseEventHandler(chk_MouseDown);
                        pnl_main.Controls.Add(chk);


                        System.Windows.Forms.ProgressBar pbar = new System.Windows.Forms.ProgressBar();
                        pbar.Minimum = 0;
                        pbar.Maximum = 160;
                        pbar.Size = new Size(400, 20);
                        pbar.Location = new System.Drawing.Point(120, idx * 60);
                        pbar.Name = "prog_" + worksheet.Name;
                        pnl_main.Controls.Add(pbar);


                        System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                        lbl.Size = new Size(400, 20);
                        lbl.Location = new System.Drawing.Point(20, (idx * 60) + 25);
                        lbl.Text = steps[0];
                        lbl.BackColor = Color.Transparent;
                        lbl.Name = "lbl_" + worksheet.Name;
                        pnl_main.Controls.Add(lbl);

                        idx++;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                DisposedMainExcel();
            }
        }

        #endregion


        #region 실행

        private bool Ready()
        {
            try
            {
                DisposedSubExcels();
                ArrayList sheetIdxs = new ArrayList(20);

                int selCnt = 0;
                for (int c = 0; c < pnl_main.Controls.Count; c++)
                {
                    if (pnl_main.Controls[c] is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox cb = pnl_main.Controls[c] as System.Windows.Forms.CheckBox;

                        if (cb.Checked)
                        {
                            sheetIdxs.Add(cb.Tag);
                            selCnt++;
                        }
                    }
                }

                applications = new Excel.Application[selCnt];
                workbooks = new Excel.Workbook[selCnt];
                worksheets = new Excel.Worksheet[selCnt];
                uploadProcThread = new Thread[selCnt];

                for (int i = 0; i < selCnt; i++)
                {
                    int sheetIdx = (int)sheetIdxs[i];
                    System.IO.File.Copy(fileName, fileName + sheetIdx, true);

                    applications[i] = new Excel.Application();
                    workbooks[i] = (Workbook)(applications[i].Workbooks.Open(fileName + sheetIdx, Type.Missing, Type.Missing,
                                                                     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                    applications[i].Visible = false;
                    applications[i].DisplayAlerts = false;
                    

                    Excel.Worksheet curSheet = workbooks[i].Sheets[sheetIdx] as Excel.Worksheet;
                    worksheets[i] = curSheet;
                    workbooks[i].Title = curSheet.Name;

                    curSheet.Activate();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void LoadExcel()
        {
            try
            {
                for (int i = 0; i < applications.Length; i++)
                {
                    if (worksheets[i] == null)
                        continue;

                    int result = 0;
                    if (int.TryParse(worksheets[i].Name.Replace("-", ""), out result) && !worksheets[i].Name.Equals("5523"))
                    {
                        uploadProcThread[i] = new Thread(new ParameterizedThreadStart(ProcRun));
                        uploadProcThread[i].IsBackground = true;
                        uploadProcThread[i].Start(workbooks[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 원본 엑셀 종료
        private void DisposedMainExcel()
        {
            try
            {
                if (application != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    workbook.Close(false, workbook.FullName, null);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    application.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //RemoveWorkManagerment(application);

                application = null;
                workbook = null;
                worksheet = null;

                GC.Collect();
            }
        }

        // 작업을 위해 만들어진 엑셀 종료
        private void DisposedSubExcels()
        {
            try
            {
                if (applications != null)
                {
                    for (int i = 0; i < applications.Length; i++)
                    {
                        if (applications[i] != null)
                        {
                            string fileName = workbooks[i].FullName;

                            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheets[i]);
                            workbooks[i].Close(false, workbooks[i].FullName, null);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbooks[i]);
                            applications[i].Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(applications[i]);

                            //RemoveWorkManagerment(applications[i]);
                            RemoveFile(fileName);
                            
                            applications[i] = null;
                            workbooks[i] = null;
                            worksheets[i] = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                applications = null;
                workbooks = null;
                worksheets = null;

                GC.Collect();
            }
        }

        #endregion


        #region Thread 관련

        public delegate void ProcStatusChangedDelegate(object sender, EventArgs args);
        public delegate void ShowProcStatusDelegate(object sender, object args);
        public delegate void ProcRunDelegate(object obj);

        public ProcRunDelegate ProcRun = null;
        public ShowProcStatusDelegate ShowProcStatus = null;
        public event ProcStatusChangedDelegate ProcStatusChanged;

        private void SetEvent()
        {
            ProcStatusChanged += new ProcStatusChangedDelegate(ExcelUploader_ProcStatusChanged);

            ProcRun = new ProcRunDelegate(ExcelUploader_ProcRun);
            ShowProcStatus = new ShowProcStatusDelegate(ExcelUploader_ShowProcStatus);            
        }

        private void ExcelUploader_ProcStatusChanged(object sender, EventArgs args)
        {
            try
            {
                lock (pnl_main)
                {
                    pnl_main.Invoke(ShowProcStatus, new object[] { sender, args });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcelUploader_ShowProcStatus(object sender, object args)
        {
            System.Windows.Forms.ProgressBar pb = pnl_main.Controls["prog_" + sender.ToString()] as System.Windows.Forms.ProgressBar;
            System.Windows.Forms.Label lbl = pnl_main.Controls["lbl_" + sender.ToString()] as System.Windows.Forms.Label;
            System.Windows.Forms.Label lbl_again = pnl_main.Controls["lbl_again_" + sender.ToString()] as System.Windows.Forms.Label;

            CBDExcel.V_1_220.CBDEventArgs ar = args as CBDExcel.V_1_220.CBDEventArgs;
            
            pb.Value = 20 * ar.Step;
            lbl.Text = steps[ar.Step];

            if (ar.Status == 0)
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Black;
            }
        }
        


        private void ExcelUploader_ProcRun(object obj)
        {
            Workbook wb = obj as Workbook;

            try
            {
                CBDExcel.V_1_220.Header header = new FlexCDC.FOB.CBDExcel.V_1_220.Header();
                CBDExcel.V_1_220.Detail detail = new FlexCDC.FOB.CBDExcel.V_1_220.Detail();
                CBDExcel.V_1_220.DBMngr dbMngr = new FlexCDC.FOB.CBDExcel.V_1_220.DBMngr();

                header.Workbook = wb;
                header.Worksheet = wb.ActiveSheet as Worksheet;
                header.Version = version;
                detail.Workbook = wb;

                // 0. 실패, 1. 진행중, 2. 성공
                // 재시도 횟수 3회
                for (int runCnt = 1; runCnt < 4; runCnt++)
                {
                    // -1. 오류
                    if (ExcelUploader_ProcRun(header, detail, dbMngr) == 2)
                        break;

                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisposedSubExcel(wb);
            }
        }

        private int ExcelUploader_ProcRun(CBDExcel.V_1_220.Header header, CBDExcel.V_1_220.Detail detail, CBDExcel.V_1_220.DBMngr dbMngr)
        {
            int successCode = 2;

            try
            {
                // 0. 실패, 1. 진행중, 2. 성공
                CBDExcel.V_1_220.CBDEventArgs args = new FlexCDC.FOB.CBDExcel.V_1_220.CBDEventArgs();

                // 1. validation check
                args.Step = 1;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                if (header.CheckExcelFile())
                    args.Status = 2;
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                if (args.Status == 0) return args.Status;
                // 2. create new header data table
                args.Step = 2;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                System.Data.DataTable tempDT = header.CreateNewDateTable();
                if (tempDT != null)
                    args.Status = 2;
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                if (args.Status == 0) return args.Status;
                // 3. read header data
                args.Step = 3;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                System.Data.DataTable headDT = header.FillData(tempDT);
                if (headDT != null)
                    args.Status = 2;
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                if (args.Status == 0) return args.Status;
                // 4. create xml file 
                args.Step = 4;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                DataSet orgDS = header.ExecuteMacro();
                if (orgDS != null)
                    args.Status = 2;
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                detail.Factory = header.Factory;
                detail.Obs_01 = header.Obs_01;
                detail.Obs_02 = header.Obs_02;
                detail.Obs_03 = header.Obs_03;
                detail.Obs_type = header.Obs_type;
                detail.Style_cd = header.Style_cd;
                detail.Bom_id = header.Bom_id;

                // CFM 이전 Round 업로드를 위해 추가됨
                detail.Mo_alias = header.Mo_alias;
                detail.Fob_type = header.Fob_type;

                if (args.Status == 0) return args.Status;
                // 5. create new tail data table
                args.Step = 5;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                DataSet tempDS = detail.CreateNewDateTable();
                if (tempDS != null)
                    args.Status = 2;
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                if (args.Status == 0) return args.Status;
                // 6. read tail data
                args.Step = 6;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                DataSet tailDS = detail.FillData(orgDS, tempDS);
                if (tailDS != null)
                    args.Status = 2;
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);


                if (args.Status == 0) return args.Status;
                // 7. read tail data
                args.Step = 7;
                args.Status = 1;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                if (dbMngr.SAVE_EBM_FOB(headDT))
                {
                    if (dbMngr.SAVE_EBM_FOB_DETAIL(tailDS))
                        args.Status = 2;
                    else
                        args.Status = 0;
                }
                else
                    args.Status = 0;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);


                if (args.Status == 0) return args.Status;
                // 7. upload complete
                args.Step = 8;
                args.Status = 2;
                ProcStatusChanged.Invoke(header.Worksheet.Name, args);

                successCode = 2;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                successCode = -1;
            }

            return successCode;
        }


        // 작업을 위해 만들어진 엑셀 종료
        private void DisposedSubExcel(Workbook arg_wb)
        {
            int idx = -1;

            if (applications != null)
            {
                for (int i = 0; i < applications.Length; i++)
                {
                    try
                    {
                        if (applications[i] != null)
                        {
                            if (applications[i].Hwnd == arg_wb.Application.Hwnd)
                            {
                                idx = i;
                            }
                        }
                    }
                    catch
                    {
                        // Application 에 접근이 안되는 경우
                    }
                }

                if (idx >= 0)
                {
                    string fileName = workbooks[idx].FullName;

                    try
                    {
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheets[idx]);
                        workbooks[idx].Close(false, workbooks[idx].FullName, null);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbooks[idx]);
                        applications[idx].Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(applications[idx]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //RemoveWorkManagerment(applications[idx]);
                        RemoveFile(fileName);

                        worksheets[idx] = null;
                        workbooks[idx] = null;
                        applications[idx] = null;

                        GC.Collect();
                    }
                }
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
                int idx = -1;

                if (applications != null)
                {
                    for (idx = 0; idx < applications.Length; idx++)
                    {
                        if (applications[idx] != null)
                        {
                            runable = false;
                            break;
                        }
                    }
                }

                if (!runable)
                {
                    MessageBox.Show("실행중입니다.");
                }

                return runable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        #endregion


        #region 이벤트 핸들러

        private void chk_all_Click(object sender, EventArgs e)
        {
            try
            {
                for (int c = 0; c < pnl_main.Controls.Count; c++)
                {
                    if (pnl_main.Controls[c] is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox cb = pnl_main.Controls[c] as System.Windows.Forms.CheckBox;
                        cb.Checked = chk_all.Checked;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcelUploader_Shown(object sender, EventArgs e)
        {
            SearchFile();
        }

        private void btn_fileSearch_Click(object sender, EventArgs e)
        {
            if (Runable())
            {
                SearchFile();
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (Runable())
            {
                if (Ready())
                {
                    LoadExcel();
                }
            }
        }

        private void ExcelUploader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Runable())
            {
                DisposedMainExcel();
                DisposedSubExcels();
            }
            else
            {
                e.Cancel = true;
            }
        }

        void chk_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                System.Windows.Forms.CheckBox chk = sender as System.Windows.Forms.CheckBox;

                if (Runable())
                {
                    if (chk.Checked)
                    {
                        string str = chk.Text;
                        System.Windows.Forms.ProgressBar prog = pnl_main.Controls["prog_" + str] as System.Windows.Forms.ProgressBar;
                        prog.Value = 0;

                        System.Windows.Forms.Label txt = pnl_main.Controls["lbl_" + str] as System.Windows.Forms.Label;
                        txt.Text = steps[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        }

        #endregion

    }
}

