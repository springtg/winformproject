using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexEIS.EIS.Production
{
    public partial class Form_EIS_Production_Daily_Report : COM.APSWinForm.Form_Top
    {
        #region 생성자

        public Form_EIS_Production_Daily_Report()
        {
            InitializeComponent();

            Init_Form();  
        }

        #endregion

        #region 변수 정의

        private Pop_Production_Daily_Report_Style _stylePop = new Pop_Production_Daily_Report_Style();
        private Pop_Wait_UsingThread _waitPop = null;

        private COM.OraDB MyOraDB = new COM.OraDB();
        private Hashtable _editableLine = null;

        private object[][] _copyRange;
        private int _lastLevel, _targetIdx = 0, _resultIdx = 1, _balanceIdx = 2, _reportColumnCount = 21;
        private string _obsId = "______", _obsType = "__";

        private string[][] _totalVJ;
        private string[][] _totalQD;
        private DataTable _totalData;

        private Color[] _totalColors = new Color[]{
            Color.FromArgb(192, 192, 192),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(153, 204, 0) };

        private string _reportPath;
        private DataTable _warningDT;

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
                this.Text = "Production daily report";
                lbl_MainTitle.Text = "Production daily report";

                Init_SubGrid();
                Init_Total();
                Init_Control();

                _reportPath = Application.StartupPath + @"\Report\";
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_MainGrid()
        {
            string factory = COM.ComFunction.Empty_Combo(cmb_Factory, COM.ComVar.This_Factory);

            fgrid_Main.Set_Grid("EPM_PROD_DAILY_REPORT_" + factory, "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

            for (int col = 1; col < fgrid_Main.Cols.Count; col++)
            {
                if (fgrid_Main.Cols[col].DataType == typeof(double))
                {
                    fgrid_Main.Cols[col].Format = "#,##0.##";
                }
            }

            SetGrid_GrandTotal();

            fgrid_Main.Font = new Font("Verdana", 8);
            fgrid_Main.SelectionMode = SelectionModeEnum.CellRange;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Tree.Column = (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME;
        }

        private void Init_SubGrid()
        {
            fgrid_Total.Set_Grid("EPM_PROD_DAILY_REPORT_SUM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

            fgrid_Total.AllowDragging = AllowDraggingEnum.None;
            fgrid_Total.AllowSorting = AllowSortingEnum.None;
            fgrid_Total.ExtendLastCol = false;
        }

        private void SetGrid_GrandTotal()
        {



            fgrid_Total.ClearAll();
            int row = fgrid_Total.Rows.Count;

            for (int vidxY = 0; vidxY < _totalVJ.Length; vidxY++)
            {
                Node vNewNode = fgrid_Total.Rows.InsertNode(row + vidxY, 0);

                for (int vidxX = 0; vidxX < _totalVJ[vidxY].Length; vidxX++)
                {
                    vNewNode.Row.StyleNew.BackColor = _totalColors[vidxY];
                    vNewNode.Row[vidxX + 1] = _totalVJ[vidxY][vidxX];
                }
            }


            //fgrid_Total.ClearAll();
            //int row = fgrid_Total.Rows.Count;

            //for (int vidxY = 0; vidxY < _totalVJ.Length; vidxY++)
            //{
            //    Node vNewNode = fgrid_Total.Rows.InsertNode(row + vidxY, 0);

            //    for (int vidxX = 0; vidxX < _totalVJ[vidxY].Length; vidxX++)
            //    {
            //        vNewNode.Row.StyleNew.BackColor = _totalColors[vidxY];
            //        vNewNode.Row[vidxX + 1] = _totalVJ[vidxY][vidxX];
            //    }
            //}






        }


      

        private void Init_Total()
        {
            _totalVJ = new string[3][];
            _totalVJ[0] = new string[(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxMaxCt - 1];
            _totalVJ[1] = new string[(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxMaxCt - 1];
            _totalVJ[2] = new string[(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxMaxCt - 1];

            // plan target
            _totalVJ[_targetIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_QTY_TITLE - 1] = "Target : ";
            _totalVJ[_resultIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_QTY_TITLE - 1] = "Result : ";
            _totalVJ[_balanceIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_QTY_TITLE - 1] = "Balance : ";

            // plan amount
            _totalVJ[_targetIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_AMOUNT_TITLE - 1] = "Target : ";
            _totalVJ[_resultIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_AMOUNT_TITLE - 1] = "Actually : ";
            _totalVJ[_balanceIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_AMOUNT_TITLE - 1] = "";

            // work day
            _totalVJ[_targetIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DAY_TITLE - 1] = "Month : ";
            _totalVJ[_resultIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DAY_TITLE - 1] = "Passed : ";
            _totalVJ[_balanceIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DAY_TITLE - 1] = "";

            // work date
            _totalVJ[_targetIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DATE_TITLE - 1] = "Target : ";
            _totalVJ[_resultIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DATE_TITLE - 1] = "Actually : ";
            _totalVJ[_balanceIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DATE_TITLE - 1] = "";

            // ship target
            _totalVJ[_targetIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxSHIP_QTY_TITLE - 1] = "Ship target : ";
            _totalVJ[_resultIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxSHIP_QTY_TITLE - 1] = "Shipped : ";
            _totalVJ[_balanceIdx][(int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxSHIP_QTY_TITLE - 1] = "";
        }

        private void Init_Control()
        {
            // Factory Combobox Setting
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(vDT, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedValue = COM.ComVar.This_Factory.Equals("DS") ? "VJ" : COM.ComVar.This_Factory;
            vDT.Dispose();

            string factory = COM.ComVar.This_Factory;

            // 해외 공장에서만 구동 가능
            if ((factory.Equals("QD") || factory.Equals("VJ") || factory.Equals("JJ")) && COM.ComVar.This_PowerUser_YN.Equals("Y"))
            {
                btn_create.Enabled = true;
                btn_transmit.Enabled = true;
            }
            else
            {
                btn_create.Enabled = false;
                btn_transmit.Enabled = false;
            }

            if (factory.Equals("JJ"))
            {
                btn_actually.Visible = false;
            }

            //Dpick setting
            vDT = SELECT_LAST_PROD_DATE(cmb_Factory.SelectedValue.ToString());
            if (vDT != null && vDT.Rows.Count > 0)
            {
                int iYear = Convert.ToInt32(vDT.Rows[0][0].ToString());
                int iMonth = Convert.ToInt32(vDT.Rows[0][1].ToString());
                int iDay = Convert.ToInt32(vDT.Rows[0][2].ToString());
                dpick_from.Value = new DateTime(iYear, iMonth, iDay);
            }
            else
            {
                dpick_from.Value = System.DateTime.Now;
            }

            _lastLevel = 3;
            _editableLine = new Hashtable(fgrid_Main.Cols.Count);
            _editableLine.Add((int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxMAN_POWER, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxMAN_POWER);
            _editableLine.Add((int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_OT, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_OT);
            _editableLine.Add((int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_OT, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_OT);
            _editableLine.Add((int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPOD, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPOD);
            _editableLine.Add((int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxAVG_FOB, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxAVG_FOB);
        }

        private void Init_Toolbar()
        {
            // Disabled tbutton
            tbtn_Insert.Enabled = false;
            tbtn_Color.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트 메서드

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                ClearAll();
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
                Search();
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

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                FillZeroData();
                if (ExistData && ExeistZeroData)
                    Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (ExistData)
                    Append();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Append", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (ExistData)
                    Append();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (ExistData)
                    Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (ExistData)
                    Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 그리드 이벤트 메서드

        private void fgrid_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (ExistData)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    DataCopy(fgrid_Main);
                }
                else if (e.Control && e.KeyCode == Keys.V)
                {
                    DataPaste(fgrid_Main);
                    ClearTotal();
                    SubTotal();
                    GrandTotal();
                }
                else if (e.Control && e.KeyCode == Keys.X)
                {
                    DataCut(fgrid_Main);
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    DataDelete(fgrid_Main);
                    ClearTotal();
                    SubTotal();
                    GrandTotal();
                }
            }
        }

        private void fgrid_Main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                if (fgrid_Main.Rows[e.Row].Node.Level == _lastLevel - 1)
                {
                    int viFirstRow = e.Row + 1, viLastRow = 0;
                    Node vNNode = fgrid_Main.Rows[e.Row].Node.GetNode(NodeTypeEnum.LastChild);
                    if (vNNode != null)
                        viLastRow = vNNode.Row.Index;

                    for (int viTemp = viFirstRow; viTemp <= viLastRow; viTemp++)
                        fgrid_Main.Update_Row(viTemp);
                }
                else
                {
                    fgrid_Main.Update_Row();
                }

                ClearTotal();
                SubTotal();
                GrandTotal();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "After Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_Main_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                if (ExistData && e.Row >= fgrid_Main.Rows.Fixed)
                {
                    if (fgrid_Main.Rows[e.Row].Node.Level == _lastLevel)
                    {
                        if (_editableLine.ContainsKey(e.Col))
                            e.Cancel = true;
                    }
                    else
                    {
                        if (!_editableLine.ContainsKey(e.Col))
                            e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Before Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ExistData)
                {
                    if (fgrid_Main.Col == (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME)
                    {
                        //ModifyModel();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Model Modify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 버튼 및 기타 이벤트 메서드

        private void Form_EIS_Production_Daily_Report_Load(object sender, EventArgs e)
        {
            Init_Toolbar();
        }

        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_MainGrid();
                SearchLine();
                SearchModel();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Factory Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dpick_from_CloseUp(object sender, EventArgs e)
        {
            ClearAll();
            SearchModel();
        }

        private void cmb_obsType_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
            SearchModel();
        }

        private void cmb_LIne_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearAll();
            SearchModel();
        }

        private void lbl_viewGroup_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(1);
        }

        private void lbl_viewLine_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(2);
        }

        private void lbl_viewModel_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(3);
        }


        private void mnu_append_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExistData)
                    Append();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Append", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExistData)
                    Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_actually_Click(object sender, EventArgs e)
        {
            try
            {
                COM.ComVar.Parameter_PopUp = new string[] { "Form_EIS_Production_Daily_Target", cmb_Factory.SelectedValue.ToString(), dpick_from.Value.ToString("yyyyMM") };
                Form_EIS_Production_Daily_Target vPop = new Form_EIS_Production_Daily_Target();
                vPop.Show();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Actually report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_transmit_Click(object sender, EventArgs e)
        {
            try
            {
                string factory = COM.ComFunction.Empty_Combo(cmb_Factory, "");

                // 해외 공장에서만 구동 가능
                if ((factory.Equals("QD") || factory.Equals("VJ") || factory.Equals("JJ")) && COM.ComVar.This_PowerUser_YN.Equals("Y"))
                {
                    // 로그인 공장의 데이터만 생성 가능
                    if (factory.Equals(COM.ComVar.This_Factory))
                    {
                        for (int iRow = fgrid_Main.Rows.Fixed; iRow < fgrid_Main.Rows.Count; iRow++)
                        {
                            if (fgrid_Main[iRow, 0] != null)
                            {
                                string sDiv = fgrid_Main[iRow, 0].ToString().Trim();
                                if (!sDiv.Equals(""))
                                {
                                    if (ClassLib.ComFunction.User_Message("Do you wan't save to modified data?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        FillZeroData();
                                        if (ExistData && ExeistZeroData)
                                        {
                                            Save();
                                        }
                                        else
                                        {
                                            return;
                                        }
                                    }
                                }
                            }
                        }

                        if (ClassLib.ComFunction.User_Message("Do you wan't trans data?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _CreateThread = new Thread(new ThreadStart(this.TransmitDataCollback));
                            _CreateThread.Start();

                            timer_wait.Start();

                            _waitPop = new Pop_Wait_UsingThread();
                            _waitPop.FormClosing += new FormClosingEventHandler(_waitPop_FormClosing);
                            _waitPop.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Transmit button click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                string factory = COM.ComFunction.Empty_Combo(cmb_Factory, "");

                // 해외 공장에서만 구동 가능
                if ((factory.Equals("QD") || factory.Equals("VJ") || factory.Equals("JJ")) && COM.ComVar.This_PowerUser_YN.Equals("Y"))
                {
                    // 로그인 공장의 데이터만 생성 가능
                    if (factory.Equals(COM.ComVar.This_Factory))
                    {
                        if (ClassLib.ComFunction.User_Message("Do you wan't update data?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _CreateThread = new Thread(new ThreadStart(this.CreateBaseDataCollback));
                            _CreateThread.Start();

                            timer_wait.Start();

                            _waitPop = new Pop_Wait_UsingThread();
                            _waitPop.FormClosing += new FormClosingEventHandler(_waitPop_FormClosing);
                            _waitPop.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Create button click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Thread _CreateThread = null;

        private void timer_wait_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_CreateThread != null)
                {
                    if (_CreateThread.ThreadState != ThreadState.Running)
                    {
                        if (_waitPop != null)
                        {
                            _waitPop.Close();
                            timer_wait.Stop();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Pop Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (_waitPop != null)
                {
                    _waitPop.Close();
                    timer_wait.Stop();
                }
            }
        }

        void _waitPop_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Show();
                Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Data search after procecule run", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void TransmitDataCollback()
        {
            COM.WebSvc.OraPKG dsService = new COM.WebSvc.OraPKG();

            try
            {
                dsService.Url = COM.ComVar.DS_WebSvc_Url;
                string testMst = dsService.Test_DBConnect();

                if (testMst.IndexOf("Test is OK") > 0)
                {
                    string factory = cmb_Factory.SelectedValue.ToString();
                    string from = dpick_from.Value.ToString("yyyyMMdd");
                    string to = dpick_from.Value.ToString("yyyyMMdd");
                    string upd_user = COM.ComVar.This_User;

                    if (SYNC_EPM_PROD_DAILY_M(dsService, factory, from, to, upd_user))
                    {
                        ClassLib.ComFunction.User_Message("Transmit complete", "Transmit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ClassLib.ComFunction.User_Message("Transmit fail", "Transmit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    ClassLib.ComFunction.User_Message("Transmit fail", "Transmit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Transmit data to foreign", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateBaseDataCollback()
        {
            try
            {
                string factory = COM.ComVar.This_Factory;
                string curDate = dpick_from.Value.ToString("yyyyMMdd");//System.DateTime.Now.ToString("yyyyMMdd");
                string user = COM.ComVar.This_User;

                if (UPDATE_EPM_PROD_DAILY_M(factory, curDate, user))
                {
                    ClassLib.ComFunction.User_Message("Update complete", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ClassLib.ComFunction.User_Message("Update fail", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Update data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_Main.ClearAll();
            SetGrid_GrandTotal();
            stbar.Panels[0].Text = "";
        }

        private void Search()
        {
            ClearAll();
            Display_Grid();
        }

        private void Display_Grid()
        {
            string factory = cmb_Factory.SelectedValue.ToString();
            string dpfrom = dpick_from.Value.ToString("yyyyMM") + "01";
            string dpto = dpick_from.Value.ToString("yyyyMMdd");
            string dptoSum = dpick_from.Value.AddDays(-1).ToString("yyyyMMdd");
            string line_cd = COM.ComFunction.Empty_Combo(cmb_line, "");
            string model_cd = COM.ComFunction.Empty_Combo(cmb_model, "");
            int vGroupIdx = 1;

            if (factory.Equals("DS") || factory.Equals("SH"))
                return;

            DataSet vDS = null;
            DataTable vDT = null, vDT2 = null;

            if (SELECT_PROD_DAILY_REPORT(factory, dpfrom, dpto, null, line_cd, model_cd))
            {
                if (SELECT_PROD_DAILY_REPORT_SUM(factory, dpfrom, dpto, null, line_cd, model_cd))
                {
                    if (SELECT_SCORE_WARNING("Form_EIS_Production_Daily_Report", "EIS_PROD_03", factory, System.DateTime.Now.Year.ToString(), null))
                    {
                        vDS = SELECT_LAST_UPDATE_DATE(factory, dpto);
                    }
                }
            }

            int vTreeLevel, vCurRow;

            vDT = vDS.Tables["PKG_EPM_PROD_DAILY_REPORT.SELECT_PROD_DAILY_REPORT"];
            vDT2 = vDS.Tables["PKG_EPM_PROD_DAILY_REPORT.SELECT_LAST_UPDATE_DATE"];
            _totalData = vDS.Tables["PKG_EPM_PROD_DAILY_REPORT.SELECT_PROD_DAILY_REPORT_SUM"];
            _warningDT = vDS.Tables["PKG_EHM_COMMON.SELECT_SCORE_WARNING"];

            if (vDT != null && vDT.Rows.Count > 0)
            {
                int grow = fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 0).Row.Index;
                IEnumerator ienum = _editableLine.Values.GetEnumerator();

                // Level 0
                fgrid_Main.Rows[grow].StyleNew.BackColor = Color.FromArgb(255, 255, 153);
                fgrid_Main.Rows[grow].StyleNew.Font = new Font(fgrid_Main.Rows[grow].StyleNew.Font, FontStyle.Bold);
                for (int j = 1; j < fgrid_Main.Cols.Count; j++)
                {
                    fgrid_Main.GetCellRange(grow, j).StyleNew.ForeColor = Color.Black;
                }
                fgrid_Main.GetCellRange(grow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE).StyleNew.DataType = typeof(string);
                fgrid_Main.Rows[grow].AllowEditing = false;
                fgrid_Main[grow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME] = cmb_Factory.SelectedText;

                // Level 1 - 3
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    vTreeLevel = int.Parse(vDT.Rows[i].ItemArray[(int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLEVEL - 1].ToString());
                    vCurRow = fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, vTreeLevel).Row.Index;

                    for (int j = 0; j < vDT.Columns.Count; j++)
                    {
                        fgrid_Main[vCurRow, j + 1] = vDT.Rows[i].ItemArray[j].ToString();
                    }

                    switch (vTreeLevel)
                    {
                        case 1:
                            fgrid_Main.Rows[vCurRow].StyleNew.BackColor = Color.FromArgb(204, 255, 255);
                            fgrid_Main.Rows[vCurRow].StyleNew.Font = new Font(fgrid_Main.Rows[vCurRow].StyleNew.Font, FontStyle.Bold);
                            for (int j = 1; j < fgrid_Main.Cols.Count; j++)
                            {
                                fgrid_Main.GetCellRange(vCurRow, j).StyleNew.ForeColor = Color.Black;
                            }
                            fgrid_Main.GetCellRange(vCurRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE).StyleNew.DataType = typeof(string);
                            if (factory.Equals("VJ") || factory.Equals("JJ"))
                                fgrid_Main[vCurRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME] = fgrid_Main[vCurRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME].ToString() + vGroupIdx++;
                            fgrid_Main.Rows[vCurRow].AllowEditing = false;
                            break;

                        case 2:
                            fgrid_Main.Rows[vCurRow].StyleNew.BackColor = Color.FromArgb(236, 246, 206);
                            fgrid_Main.Rows[vCurRow].StyleNew.Font = new Font(fgrid_Main.Rows[vCurRow].StyleNew.Font, FontStyle.Bold);
                            fgrid_Main.GetCellRange(vCurRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE).StyleNew.DataType = typeof(string);
                            for (int j = 1; j < fgrid_Main.Cols.Count; j++)
                            {
                                if (_editableLine.ContainsKey(j))
                                    fgrid_Main.GetCellRange(vCurRow, j).StyleNew.ForeColor = Color.Blue;
                                else
                                    fgrid_Main.GetCellRange(vCurRow, j).StyleNew.ForeColor = Color.Black;
                            }
                            break;

                        default:
                            fgrid_Main.Rows[vCurRow].StyleNew.BackColor = Color.White;
                            while (ienum.MoveNext())
                            {
                                fgrid_Main[vCurRow, (int)ienum.Current] = null;
                            }

                            ienum.Reset();
                            break;
                    }
                }

                if (lbl_viewGroup.Checked)
                    fgrid_Main.Tree.Show(1);
                else if (lbl_viewLine.Checked)
                    fgrid_Main.Tree.Show(2);
                else
                    fgrid_Main.Tree.Show(3);

                SubTotal();
                GrandTotal();

                if (vDT2 != null && vDT2.Rows.Count > 0)
                {
                    string update = "Update : " + vDT2.Rows[0][1].ToString() + "(" + vDT2.Rows[0][0].ToString() + ")";
                    string send = "Transmit : Not transmit";
                    if (!vDT2.Rows[0][3].ToString().Trim().Equals(""))
                    {
                        send = "Transmit : " + vDT2.Rows[0][3].ToString() + "(" + vDT2.Rows[0][2].ToString() + ")";

                        btn_transmit.ImageIndex = 2;
                    }
                    else
                    {
                        btn_transmit.ImageIndex = 0;
                    }

                    stbar.Panels[0].Text = update + "      " + send;
                }
                
                vDS.Dispose();

                //SaveExcel(fgrid_Main, null);
            }
        }

        private void ClearTotal()
        {
            for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count - 1; row++)
            {
                if (fgrid_Main.Rows[row].Node.Level < _lastLevel)
                {
                    for (int col = 1; col < fgrid_Main.Cols.Count; col++)
                    {
                        if (fgrid_Main.Rows[row].Node.Level == _lastLevel - 1 && _editableLine.ContainsKey(col))
                            continue;

                        if (fgrid_Main.Cols[col].DataType.Equals(typeof(double)))
                        {
                            fgrid_Main[row, col] = 0;
                        }
                    }
                }
            }
        }

        private void SubTotal()
        {
            int vFCRow, vLCRow;
            Node vLCNode = null;

            for (int row1 = fgrid_Main.Rows.Fixed; row1 < fgrid_Main.Rows.Count - 1; row1++)
            {
                Total_ProdAmount(row1, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROD_AMOUNT);
            }
            
            for (int row2 = fgrid_Main.Rows.Fixed; row2 < fgrid_Main.Rows.Count - 1; row2++)
            {
                if (fgrid_Main.Rows[row2].Node.Level < _lastLevel)
                {
                    for (int col = 1; col < fgrid_Main.Cols.Count; col++)
                    {
                        if (fgrid_Main.Rows[row2].Node.Level == _lastLevel - 1 && _editableLine.ContainsKey(col))
                            continue;

                        if (fgrid_Main.Cols[col].DataType.Equals(typeof(double)))
                        {
                            vFCRow = row2 + 1;
                            vLCNode = getLastChild(fgrid_Main.Rows[row2].Node);
                            vLCRow = vLCNode.Row.Index;

                            fgrid_Main[row2, col] = fgrid_Main.Aggregate(AggregateEnum.Sum, vFCRow, col, vLCRow, col);
                        }
                    }
                    
                    SubTotal_POD(row2, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPOD);
                    SubTotal_AvgAmount(row2, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxAVG_FOB);
                    SubTotal_ProdRate(row2, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE);
                }
            }
        }

        // 1. Production Amount (Item Total)
        private void Total_ProdAmount(int arg_curRow, int arg_curCol)
        {
            double unitPrice = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE));
            double fgaQty = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY));
            fgrid_Main[arg_curRow, arg_curCol] = unitPrice == 0 || fgaQty == 0 ? 0 : Math.Truncate(unitPrice * fgaQty);
        }

        // 2. Production Of Development (Group Total)
        private void SubTotal_POD(int arg_curRow, int arg_curCol)
        {
            double planQty = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY));
            double manNum = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxMAN_POWER));
            fgrid_Main[arg_curRow, arg_curCol] = planQty == 0 || manNum == 0 ? 0 : Math.Round(planQty / manNum, 2);
        }

        // 3. Average Amount (Group Total)
        private void SubTotal_AvgAmount(int arg_curRow, int arg_curCol)
        {
            double prodAmount = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROD_AMOUNT));
            double fgaQty = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY));
            fgrid_Main[arg_curRow, arg_curCol] = prodAmount == 0 || fgaQty == 0 ? 0 : Math.Round(prodAmount / fgaQty, 2);
        }

        // 4. Production Rate (Group Total)
        private void SubTotal_ProdRate(int arg_curRow, int arg_curCol)
        {
            double planQty = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_QTY));
            double fgaQty = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(arg_curRow, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY));
            double prodRatio = planQty == 0 || fgaQty == 0 ? 0 : Math.Round((fgaQty / planQty) * 100, 2);
            fgrid_Main[arg_curRow, arg_curCol] = Convert.ToString(prodRatio) + "%";

            DataRow[] vDR = _warningDT.Select("ESTIMATE_LOW <= '" + prodRatio + "' AND ESTIMATE_HIGH >= '" + prodRatio + "'");
            if (vDR != null && vDR.Length > 0)
            {
                Color clr = Color.FromArgb(Convert.ToInt32(vDR[0]["WARN_COLOR"].ToString()));
                fgrid_Main.GetCellRange(arg_curRow, arg_curCol).StyleNew.BackColor = clr;
            }
        }

        // 5. Grand Total
        private void GrandTotal()
        {
            SetGrid_GrandTotal();
            InitGrandTotalData(_totalData);

            if (_totalData != null && _totalData.Rows.Count > 0)
            {
                // plan target
                double curFGA = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY));
                double sumPlan = Convert.ToDouble(_totalData.Rows[0]["R_PLAN_QTY"].ToString());
                fgrid_Total[fgrid_Total.Rows.Fixed + _resultIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_QTY_VALUE] = Math.Truncate(curFGA + sumPlan);

                // prod amount
                double curAmount = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROD_AMOUNT));
                double sumAmount = Convert.ToDouble(_totalData.Rows[0]["R_PROD_AMOUNT"].ToString());
                fgrid_Total[fgrid_Total.Rows.Fixed + _resultIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_AMOUNT_VALUE] = Math.Truncate(curAmount + sumAmount); ;

                for (int col = 2; col < fgrid_Total.Cols.Count; col++)
                {
                    if (fgrid_Total.Cols[col].DataType == typeof(double))
                    {
                        if (fgrid_Total[fgrid_Total.Rows.Fixed + _resultIdx, col] != null)
                        {
                            double result = Convert.ToDouble(fgrid_Total[fgrid_Total.Rows.Fixed + _resultIdx, col].ToString());
                            double target = Convert.ToDouble(fgrid_Total[fgrid_Total.Rows.Fixed + _targetIdx, col].ToString());

                            fgrid_Total[fgrid_Total.Rows.Fixed + _balanceIdx, col] = result - target;
                            fgrid_Total.Cols[col].StyleNew.TextAlign = TextAlignEnum.RightCenter;
                        }
                    }
                    else
                    {
                        fgrid_Total[fgrid_Total.Rows.Fixed + _balanceIdx, col] = null;
                    }
                }
            }
        }

        private void InitGrandTotalData(DataTable arg_dt)
        {
            int row = fgrid_Total.Rows.Count;

            if (arg_dt != null && arg_dt.Rows.Count > 0)
            {
                // plan target
                fgrid_Total[fgrid_Total.Rows.Fixed + _targetIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_QTY_VALUE] = arg_dt.Rows[0]["T_PLAN_QTY"].ToString();

                // plan amount
                fgrid_Total[fgrid_Total.Rows.Fixed + _targetIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxPLAN_AMOUNT_VALUE] = arg_dt.Rows[0]["T_PROD_AMOUNT"].ToString();

                // work day
                fgrid_Total[fgrid_Total.Rows.Fixed + _targetIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DAY_VALUE] = arg_dt.Rows[0]["T_WORK_DAY"].ToString();
                fgrid_Total[fgrid_Total.Rows.Fixed + _resultIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DAY_VALUE] = arg_dt.Rows[0]["R_WORK_DAY"].ToString();

                // work date
                fgrid_Total[fgrid_Total.Rows.Fixed + _targetIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DATE_VALUE] = arg_dt.Rows[0]["T_PLAN_YMD"].ToString();
                fgrid_Total[fgrid_Total.Rows.Fixed + _resultIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT_SUM_VJ.lxWORK_DATE_VALUE] = arg_dt.Rows[0]["R_PLAN_YMD"].ToString();
            }
        }

        private Node getLastChild(Node arg_node)
        {
            Node cNode = arg_node.GetNode(NodeTypeEnum.LastChild);
            if (cNode == null)
            {
                return arg_node;
            }
            else
            {
                return getLastChild(cNode);
            }
        }

        private void Save()
        {
            if (SAVE_PROD_DAILY_REPORT())
            {
                ClassLib.ComFunction.User_Message("Save Complete!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fgrid_Main.Refresh_Division();
            }
            else
            {
                ClassLib.ComFunction.User_Message("Save Fail!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Append()
        {
            int vRow = fgrid_Main.Row, vPRow = fgrid_Main.Row, vNRow = -1;

            if (fgrid_Main.Rows[vRow].Node.Level == _lastLevel)
            {
                vPRow = fgrid_Main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
            }

            if (fgrid_Main.Rows[vPRow].Node.Level == _lastLevel - 1)
            {
                Node vCNode = fgrid_Main.Rows[vPRow].Node.GetNode(NodeTypeEnum.LastChild);

                if (vCNode == null)
                {
                    vNRow = vPRow + 1;
                }
                else
                {
                    vNRow = vCNode.Row.Index + 1;
                }

                if (vNRow != -1)
                {
                    _stylePop.ModelCode = "";

                    if (_stylePop.ShowDialog() == DialogResult.OK)
                    {
                        if (!ExeistStyle(vPRow, _stylePop.ModelCode))
                        {
                            fgrid_Main.Rows.InsertNode(vNRow, _lastLevel);
                            InitData(vNRow, vPRow, _stylePop.ModelCode, _stylePop.ModelName);
                            fgrid_Main.Rows[vNRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                            fgrid_Main[vNRow, 0] = "I";
                        }
                        else
                        {
                            Append();
                        }
                    }
                }
            }
        }

        private void Insert()
        {
            int vRow = fgrid_Main.Row, vPRow = fgrid_Main.Row, vNRow = -1;

            if (fgrid_Main.Rows[vRow].Node.Level == _lastLevel)
            {
                vNRow = vRow;
                vPRow = fgrid_Main.Rows[vNRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
            }
            else if (fgrid_Main.Rows[vRow].Node.Level == _lastLevel - 1)
            {
                Node vCNode = fgrid_Main.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);

                if (vCNode == null)
                {
                    vNRow = vPRow + 1;
                }
                else
                {
                    vNRow = vCNode.Row.Index;
                }
            }

            if (vNRow != -1)
            {
                if (_stylePop.ShowDialog() == DialogResult.OK)
                {
                    if (!ExeistStyle(vPRow, _stylePop.ModelCode))
                    {
                        fgrid_Main.Rows.InsertNode(vNRow, _lastLevel);
                        InitData(vNRow, vPRow, _stylePop.ModelCode, _stylePop.ModelName);
                        fgrid_Main.Rows[vNRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                        fgrid_Main[vNRow, 0] = "I";
                    }
                    else
                    {
                        Insert();
                    }
                }
            }
        }

        private void ModifyModel()
        {
            int vRow = fgrid_Main.Row, vPRow = fgrid_Main.Row, vNRow = -1;

            if (fgrid_Main.Rows[vRow].Node.Level == _lastLevel)
            {
                vPRow = fgrid_Main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
            }

            if (fgrid_Main.Rows[vPRow].Node.Level == _lastLevel)
            {
                vNRow = vRow;

                if (vNRow != -1)
                {
                    if (_stylePop.ShowDialog() == DialogResult.OK)
                    {
                        if (!ExeistStyle(vPRow, _stylePop.ModelCode))
                        {
                            InitData(vNRow, vPRow, _stylePop.ModelCode, _stylePop.ModelName);
                            fgrid_Main.Rows[vNRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                            fgrid_Main.Update_Row(vNRow);
                        }
                        else
                        {
                            ModifyModel();
                        }
                    }
                }
            }
        }

        private void InitData(int arg_cur, int arg_parent, string arg_modelCd, string arg_modelNm)
        {
            /* LINE_NAME, STYLE_NAME, FACTORY, PLAN_YMD, LINE_CD, STYLE_CD, OBS_NU, OBS_SEQ_NU */
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME] = arg_modelNm;
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSTYLE_NAME] = arg_modelNm;
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxOBS_ID] = _obsId;
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxOBS_TYPE] = _obsType;

            // Primary key
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFACTORY] = fgrid_Main[arg_parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFACTORY];
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_YMD] = fgrid_Main[arg_parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_YMD];
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_CD] = fgrid_Main[arg_parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_CD];
            fgrid_Main[arg_cur, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSTYLE_CD] = arg_modelCd;
        }

        private void Delete()
        {
            if (fgrid_Main.Rows[fgrid_Main.Row].Node.Level == _lastLevel)
                fgrid_Main.Delete_Row();
        }

        #region 프린트

        private void Print()
        {
            string mrd_Filename = "Production_Daily_Report.mrd";
            string txt_Filename = "Production_Daily_Report.txt";

            string Para = "/rfn [" + _reportPath + txt_Filename + "]  /rv ";

            Para = " /rp ";
            Para += "[" + cmb_Factory.SelectedText + "] ";
            Para += "[" + dpick_from.Value.ToString("yyyy-MM-dd") + "] ";
            Para += "[" + COM.ComFunction.Empty_Combo(cmb_line, "") + "] ";

            #region 파일만들기

            FileInfo file = new FileInfo(_reportPath + txt_Filename);

            if (!file.Exists)
            {
                file.Create().Close();
            }

            file = null;

            FileStream fs = new FileStream(_reportPath + txt_Filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {
                    string sData = " ";

                    if (fgrid_Main.Rows[i].Node.Level == _lastLevel)
                    {
                        int parent = (int)fgrid_Main.Rows[i].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

                        sData += nullToBlank(fgrid_Main[parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxMAN_POWER]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_QTY]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_LINE]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_OT]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_QTY]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFSS_QTY]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_OT]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPOD]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[parent, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxAVG_FOB]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROD_AMOUNT]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSHIP_QTY]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main.GetCellRange(i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxISSUED_DESC).DataDisplay).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROBLEM_SOL]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_QTY_NEXT]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPPER_INV]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSOLE_INV]).Trim().Replace("\r\n", "") + "@";
                        sData += fgrid_Main.GetCellRange(i, 1).StyleDisplay.BackColor.R + "," +
                            fgrid_Main.GetCellRange(i, 1).StyleDisplay.BackColor.G + "," +
                            fgrid_Main.GetCellRange(i, 1).StyleDisplay.BackColor.B + "@";

                        // Obs Type
                        sData += nullToBlank(fgrid_Main[i, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxOBS_TYPE]).Trim().Replace("\r\n", "") + "@";

                        sw.WriteLine(sData);

                        // 마지막 열에 도달한 경우
                        if ( fgrid_Main.Rows.Count - 1 == i)
                        {
                            Node tempNode = fgrid_Main.Rows[i].Node.GetNode(NodeTypeEnum.Parent);

                            do
                            {
                                sData = getRowTotal(tempNode);
                                if (sData != null) sw.WriteLine(sData);
                            } while ((tempNode = tempNode.GetNode(NodeTypeEnum.Parent)) != null);
                        }
                    }
                    else
                    {
                        Node sibNode = fgrid_Main.Rows[i].Node.GetNode(NodeTypeEnum.PreviousSibling);
                        Node curNode = fgrid_Main.Rows[i].Node;

                        if (sibNode != null)
                        {
                            // 토탈 열중 가장 하단으로 내려감
                            for (int lev = fgrid_Main.Rows[i].Node.Level;
                                lev < _lastLevel && sibNode.GetNode(NodeTypeEnum.LastChild) != null; 
                                lev++)
                            {
                                sibNode = sibNode.GetNode(NodeTypeEnum.LastChild);
                            }

                            // 다시 위로 올라가면서 토탈 열을 표시함
                            while ((sibNode = sibNode.GetNode(NodeTypeEnum.Parent)) != null &&
                                curNode.Level <= sibNode.Level)
                            {
                                sData = getRowTotal(sibNode);
                                if (sData != null) sw.WriteLine(sData);
                            }
                        }
                    }
                }

                writeBlankLine(sw);
                writeGrandTotal(sw);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                }

                if (fs != null) 
                    fs.Close();
            }

            #endregion

            Report.Form_RdViewer report = new Report.Form_RdViewer(
                _reportPath + txt_Filename,
                _reportPath + mrd_Filename, 
                Para);
            report.ShowDialog();                    
        }

        private string getRowTotal(Node arg_node)
        {
            if (arg_node != null && arg_node.Level != _lastLevel - 1)
            {
                int arg_row = arg_node.Row.Index;

                string sData = " ";

                //sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME]).Trim().Replace("\r\n", "") + "@";
                //sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME]).Trim().Replace("\r\n", "") + "@";
                sData += "TOTAL" + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxLINE_NAME]).Trim().Replace("\r\n", "") + "@";
                sData += "TOTAL" + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_QTY]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_LINE]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_OT]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPS_QTY]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFSS_QTY]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_QTY]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxFGA_OT]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPOD]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUNIT_PRICE]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxAVG_FOB]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROD_AMOUNT]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSHIP_QTY]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxISSUED_CD]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPROBLEM_SOL]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxPLAN_QTY_NEXT]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxUPPER_INV]).Trim().Replace("\r\n", "") + "@";
                sData += nullToBlank(fgrid_Main[arg_row, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSOLE_INV]).Trim().Replace("\r\n", "") + "@";
                sData += fgrid_Main.GetCellRange(arg_row, 1).StyleDisplay.BackColor.R + "," +
                    fgrid_Main.GetCellRange(arg_row, 1).StyleDisplay.BackColor.G + "," +
                    fgrid_Main.GetCellRange(arg_row, 1).StyleDisplay.BackColor.B + "@";

                return sData;
            }

            return null;
        }

        private void writeBlankLine(StreamWriter arg_sw)
        {
            string sData = " BLANK" + "@";

            for (int col = 1; col < _reportColumnCount; col++)
            {
                sData += "@";
            }

            arg_sw.WriteLine(sData);
        }

        private void writeGrandTotal(StreamWriter arg_sw)
        {
            string sData = " ";
            int col = 1;

            for (int row = fgrid_Total.Rows.Fixed; row < fgrid_Total.Rows.Count; row++)
            {
                sData = " GRAND_TOTAL" + "@";

                for (; col < fgrid_Total.Cols.Count; col++)
                {
                    sData += nullToBlank(fgrid_Total[row, col]).Trim().Replace("\r\n", "") + "@";
                }

                for (; col < _reportColumnCount; col++)
                {
                    sData += "@";
                }

                sData += fgrid_Total.GetCellRange(row, 1).StyleDisplay.BackColor.R + "," +
                    fgrid_Total.GetCellRange(row, 1).StyleDisplay.BackColor.G + "," +
                    fgrid_Total.GetCellRange(row, 1).StyleDisplay.BackColor.B + "@";

                arg_sw.WriteLine(sData);
                col = 1;
            }
        }

        #endregion

        #endregion

        #region 그리드 이벤트

        private void DataCopy(COM.FSP arg_grid)
        {
            int rIdx = (arg_grid.Selection.r2 - arg_grid.Selection.r1) + 1;
            int cIdx = (arg_grid.Selection.c2 - arg_grid.Selection.c1) + 1;

            string copyData = "";
            _copyRange = new object[rIdx][];

            for (int idx = 0; idx < _copyRange.Length; idx++)
            {
                _copyRange[idx] = new object[cIdx];
            }

            for (int nRow = arg_grid.Selection.r1, oRow = 0; nRow <= arg_grid.Selection.r2; nRow++, oRow++)
            {
                for (int nCol = arg_grid.Selection.c1, oCol = 0; nCol <= arg_grid.Selection.c2; nCol++, oCol++)
                {
                    _copyRange[oRow][oCol] = arg_grid[nRow, nCol];
                    copyData += arg_grid[nRow, nCol] + (nCol == arg_grid.Selection.c2 ? "\n" : "\t");
                }
            }

            Clipboard.Clear();
            Clipboard.SetText(copyData);
        }

        private void DataCut(COM.FSP arg_grid)
        {
            int rIdx = (arg_grid.Selection.r2 - arg_grid.Selection.r1) + 1;
            int cIdx = (arg_grid.Selection.c2 - arg_grid.Selection.c1) + 1;

            _copyRange = new object[rIdx][];
            for (int idx = 0; idx < _copyRange.Length; idx++)
            {
                _copyRange[idx] = new object[cIdx];
            }

            for (int nRow = arg_grid.Selection.r1, oRow = 0; nRow <= arg_grid.Selection.r2; nRow++, oRow++)
            {
                for (int nCol = arg_grid.Selection.c1, oCol = 0; nCol <= arg_grid.Selection.c2; nCol++, oCol++)
                {
                    _copyRange[oRow][oCol] = arg_grid[nRow, nCol];
                    arg_grid[nRow, nCol] = null;
                    arg_grid.Update_Row(nRow);
                }
            }
        }

        private void DataPaste(COM.FSP arg_grid)
        {
            if (!ExistClipboardData) return;

            int row = arg_grid.Row, col = arg_grid.Col;
            int rowCount = _copyRange.Length;
            int colCount = _copyRange[0].Length;

            for (int nRow = row, oRow = 0; oRow < rowCount; nRow++, oRow++)
            {
                for (int nCol = col, oCol = 0; oCol < colCount; nCol++, oCol++)
                {
                    if (nRow < arg_grid.Rows.Count && nCol < arg_grid.Cols.Count)
                    {
                        arg_grid[nRow, nCol] = _copyRange[oRow][oCol];
                        arg_grid.Update_Row(nRow);
                    }
                }
            }
        }

        private void DataDelete(COM.FSP arg_grid)
        {
            arg_grid.Selection.Clear(ClearFlags.Content);
            if (fgrid_Main[fgrid_Main.Row, 0] == null)
            {
                fgrid_Main[fgrid_Main.Row, 0] = "U";
            }
            else
            {
                if (fgrid_Main[fgrid_Main.Row, 0].ToString().Equals("I"))
                {
                    fgrid_Main.RemoveItem(fgrid_Main.Row);
                }
                else if (fgrid_Main[fgrid_Main.Row, 0].ToString().Equals("U"))
                {
                    fgrid_Main.Update_Row();
                }
            }            
        }

        #endregion

        #region 버튼 및 기타 이벤트

        private void SearchLine()
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1) return;

                string factory = cmb_Factory.SelectedValue.ToString();

                DataTable dt_ret = SELECT_LINE(factory);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_line.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("SearchLine : " + ex.Message);
            }
        }

        private void SearchModel()
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1) return;

                string factory = cmb_Factory.SelectedValue.ToString();
                string line = COM.ComFunction.Empty_Combo(cmb_line, "");
                string from = dpick_from.Value.ToString("yyyyMMdd");
                string to = dpick_from.Value.ToString("yyyyMMdd");

                DataTable dt_ret = SELECT_MODEL_LIST(factory, null, line, from, to);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_model.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string nullToBlank(object obj)
        {
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region 사전체크

        private bool ExistData
        {
            get
            {
                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                    return true;
                else
                    return false;
            }
        }

        private bool ExistClipboardData
        {
            get
            {
                if (_copyRange != null)
                    return true;
                else
                    return false;
            }
        }

        private bool ExeistStyle(int arg_parent, string arg_newModel)
        {
            Node FCNode = fgrid_Main.Rows[arg_parent].Node.GetNode(NodeTypeEnum.FirstChild);
            if (FCNode == null)
                return false;

            int viStartIdx = fgrid_Main.Rows[arg_parent].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
            int viEndIdx = fgrid_Main.Rows[arg_parent].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
            int viTempIdx = viStartIdx;

            for (; viTempIdx <= viEndIdx; viTempIdx++)
            {
                string vsCurModel = fgrid_Main[viTempIdx, (int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxSTYLE_CD].ToString();

                if (vsCurModel.Equals(arg_newModel))
                {
                    ClassLib.ComFunction.User_Message("Selected Item is already exists", "Exist Item", MessageBoxButtons.OK);
                    return true;
                }
            }

            return false;
        }

        private bool ExeistZeroData
        {
            get
            {
                string sdata = "";
                double ddata = 0;

                for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                {
                    if (fgrid_Main[row, 0] != null &&
                        fgrid_Main.Rows[row].Node.Level == _lastLevel &&
                        !fgrid_Main[row, 0].ToString().Equals(""))
                    {
                        for (int col = 0; col < fgrid_Main.Cols.Count - 2; col++)
                        {
                            if (fgrid_Main.Cols[col].Visible && fgrid_Main.Cols[col].DataType == typeof(double))
                            {
                                int iDataRow = row;

                                if (_editableLine.ContainsKey(col))
                                {
                                    Node vPNode = fgrid_Main.Rows[row].Node.GetNode(NodeTypeEnum.Parent);
                                    sdata = fgrid_Main[vPNode.Row.Index, col] == null ? "-1" : fgrid_Main[vPNode.Row.Index, col].ToString();
                                    iDataRow = vPNode.Row.Index;
                                }
                                else
                                {
                                    sdata = fgrid_Main[row, col] == null ? "-1" : fgrid_Main[row, col].ToString();
                                }

                                ddata = Convert.ToDouble(sdata.Equals("") ? "-1" : sdata);

                                if (ddata < 0)
                                {
                                    fgrid_Main[iDataRow, col] = "0";
                                    //ClassLib.ComFunction.User_Message("Input data!!", "Input", MessageBoxButtons.OK);
                                    fgrid_Main.Select(row, col);
                                    return false;
                                }
                            }
                        }
                    }
                }

                return true;
            }
        }


        private void FillZeroData()
        {
            string sdata = "";
            double ddata = 0;

            for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
            {
                if (fgrid_Main.Rows[row].Node.Level == _lastLevel)
                {
                    for (int col = 0; col < fgrid_Main.Cols.Count - 2; col++)
                    {
                        if (fgrid_Main.Cols[col].Visible && fgrid_Main.Cols[col].DataType == typeof(double))
                        {
                            int iDataRow = row;

                            if (_editableLine.ContainsKey(col))
                            {
                                Node vPNode = fgrid_Main.Rows[row].Node.GetNode(NodeTypeEnum.Parent);
                                sdata = fgrid_Main[vPNode.Row.Index, col] == null ? "-1" : fgrid_Main[vPNode.Row.Index, col].ToString();
                                iDataRow = vPNode.Row.Index;
                            }
                            else
                            {
                                sdata = fgrid_Main[row, col] == null ? "-1" : fgrid_Main[row, col].ToString();
                            }

                            ddata = Convert.ToDouble(sdata.Equals("") ? "-1" : sdata);

                            if (ddata < 0)
                            {                                
                                fgrid_Main.Update_Row(row);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

        #region 디비 연결

        #region 콤보

        /// <summary>
        /// PKG_EPM_PROD_BY_LINE.SELECT_MODEL_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_MODEL_LIST(string arg_factory, string arg_obs_type, string arg_line_cd, string arg_plan_from, string arg_plan_to)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_MODEL_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_PLAN_FROM";
                MyOraDB.Parameter_Name[4] = "ARG_PLAN_TO";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_type;
                MyOraDB.Parameter_Values[2] = arg_line_cd;
                MyOraDB.Parameter_Values[3] = arg_plan_from;
                MyOraDB.Parameter_Values[4] = arg_plan_to;
                MyOraDB.Parameter_Values[5] = "";

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

        private DataTable SELECT_LINE(string arg_factory)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_BY_LINE.SELECT_LINE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory, " ");
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw new Exception("SELECT_LINE : " + ex.Message);
            }
        }

        #endregion

        #region 조회

        private bool SELECT_PROD_DAILY_REPORT(string arg_factory, string arg_month_from, string arg_month_to, string arg_obs_type, string arg_line_cd, string arg_style_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_PROD_DAILY_REPORT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
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
                MyOraDB.Parameter_Values[1] = arg_month_from;
                MyOraDB.Parameter_Values[2] = arg_month_to;
                MyOraDB.Parameter_Values[3] = arg_obs_type;
                MyOraDB.Parameter_Values[4] = arg_line_cd;
                MyOraDB.Parameter_Values[5] = arg_style_cd;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("SELECT_PROD_DAILY_REPORT : " + ex.Message);
            }
        }

        private bool SELECT_PROD_DAILY_REPORT_SUM(string arg_factory, string arg_month_from, string arg_month_to, string arg_obs_type, string arg_line_cd, string arg_style_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_PROD_DAILY_REPORT_SUM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
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
                MyOraDB.Parameter_Values[1] = arg_month_from;
                MyOraDB.Parameter_Values[2] = arg_month_to;
                MyOraDB.Parameter_Values[3] = arg_obs_type;
                MyOraDB.Parameter_Values[4] = arg_line_cd;
                MyOraDB.Parameter_Values[5] = arg_style_cd;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(false);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("SELECT_PROD_DAILY_REPORT_SUM : " + ex.Message);
            }
        }


        /// <summary>
        /// PKG_EPM_PROD_DAILY_REPORT : SAVE_PROD_DAILY_REPORT
        /// </summary>
        private bool SAVE_PROD_DAILY_REPORT()
        {
            try
            {
                MyOraDB.ReDim_Parameter(31);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SAVE_PROD_DAILY_REPORT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_LEVEL";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_NAME";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_NAME";
                MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[5] = "ARG_MAN_POWER";
                MyOraDB.Parameter_Name[6] = "ARG_PLAN_QTY";
                MyOraDB.Parameter_Name[7] = "ARG_UPS_LINE";
                MyOraDB.Parameter_Name[8] = "ARG_UPS_OT";
                MyOraDB.Parameter_Name[9] = "ARG_UPS_QTY";
                MyOraDB.Parameter_Name[10] = "ARG_FSS_QTY";
                MyOraDB.Parameter_Name[11] = "ARG_FGA_QTY";
                MyOraDB.Parameter_Name[12] = "ARG_FGA_OT";
                MyOraDB.Parameter_Name[13] = "ARG_POD";
                MyOraDB.Parameter_Name[14] = "ARG_UNIT_PRICE";
                MyOraDB.Parameter_Name[15] = "ARG_AVG_FOB";
                MyOraDB.Parameter_Name[16] = "ARG_PROD_AMOUNT";
                MyOraDB.Parameter_Name[17] = "ARG_SHIP_QTY";
                MyOraDB.Parameter_Name[18] = "ARG_ISSUED_CD";
                MyOraDB.Parameter_Name[19] = "ARG_ISSUED_DESC";
                MyOraDB.Parameter_Name[20] = "ARG_PROBLEM_SOL";
                MyOraDB.Parameter_Name[21] = "ARG_PLAN_QTY_NEXT";
                MyOraDB.Parameter_Name[22] = "ARG_UPPER_INV";
                MyOraDB.Parameter_Name[23] = "ARG_SOLE_INV";
                MyOraDB.Parameter_Name[24] = "arg_REMARKS";
                MyOraDB.Parameter_Name[25] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[26] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[27] = "ARG_PLAN_YMD";
                MyOraDB.Parameter_Name[28] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[29] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[30] = "ARG_UPD_USER";

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
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[27] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[28] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[29] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[30] = (int)OracleType.VarChar;

                //04.DATA 정의
                int vRowCount = 0, idx = 0;

                for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                {
                    if (fgrid_Main[row, 0] != null &&
                        fgrid_Main.Rows[row].Node.Level == _lastLevel &&
                        !fgrid_Main[row, 0].ToString().Equals(""))
                    {
                        vRowCount++;
                    }
                }
                  
                MyOraDB.Parameter_Values = new string[vRowCount * ((int)ClassLib.TBEPM_PROD_DAILY_REPORT.IxMaxCt)];

                for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                {
                    if (fgrid_Main[row, 0] != null && 
                        fgrid_Main.Rows[row].Node.Level == _lastLevel &&
                        !fgrid_Main[row, 0].ToString().Equals(""))
                    {
                        for (int col = 0; col < fgrid_Main.Cols.Count - 2; col++)
                        {
                            if (_editableLine.ContainsKey(col))
                            {
                                Node vPNode = fgrid_Main.Rows[row].Node.GetNode(NodeTypeEnum.Parent);
                                MyOraDB.Parameter_Values[idx++] = fgrid_Main[vPNode.Row.Index, col] == null ? "" : fgrid_Main[vPNode.Row.Index, col].ToString();
                            }
                            else
                            {
                                MyOraDB.Parameter_Values[idx++] = fgrid_Main[row, col] == null ? "" : fgrid_Main[row, col].ToString();
                            }
                        }

                        MyOraDB.Parameter_Values[idx++] = COM.ComVar.This_User;
                    }
                }

                MyOraDB.Add_Modify_Parameter(true);
                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception("SAVE_PROD_DAILY_REPORT : " + ex.Message);
            }
        }


        /// <summary>
        /// PKG_EPM_PROD_DAILY_M_QD.UPDATE_EPM_PROD_DAILY_M : 
        /// </summary>
        public bool UPDATE_EPM_PROD_DAILY_M(string arg_factory, string arg_ymd_t, string arg_upd_user)
        {
            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_M_" + COM.ComVar.This_Factory + ".UPDATE_EPM_PROD_DAILY_M";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_YMD_T";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_ymd_t;
                MyOraDB.Parameter_Values[2] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Modify_Procedure();
                if (vDS.DataSetName.Equals("ERROR"))
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_EPM_BATCH_DS.SYNC_EPM_PROD_DAILY_M : 
        /// </summary>
        public bool SYNC_EPM_PROD_DAILY_M(COM.WebSvc.OraPKG dsService, string arg_factory, string arg_ymd_f, string arg_ymd_t, string arg_upd_user)
        {
            try
            {

                int Parameter_Length = 4;

                //01.PROCEDURE명
                string Process_Name = "PKG_EPM_BATCH_DS.SYNC_EPM_PROD_DAILY_M_VER2";

                //02.ARGURMENT 명
                string[] Parameter_Name = new string[Parameter_Length];
                Parameter_Name[0] = "ARG_FACTORY";
                Parameter_Name[1] = "ARG_YMD_F";
                Parameter_Name[2] = "ARG_YMD_T";
                Parameter_Name[3] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                int[] Parameter_Type = new int[Parameter_Length];
                Parameter_Type[0] = (int)OracleType.VarChar;
                Parameter_Type[1] = (int)OracleType.VarChar;
                Parameter_Type[2] = (int)OracleType.VarChar;
                Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                string[] Parameter_Values = new string[Parameter_Length];
                Parameter_Values[0] = arg_factory;
                Parameter_Values[1] = arg_ymd_f;
                Parameter_Values[2] = arg_ymd_t;
                Parameter_Values[3] = arg_upd_user;

                DataSet DS_Run = Add_Run_Parameter(Process_Name, Parameter_Name, Parameter_Type, Parameter_Values);
                if (DS_Run != null)
                {
                    string[] RunUser = COM.ComFunction.Set_UserInfo(COM.ComVar.Log_Type.Write_File_DB);
                    DataSet resultDS = dsService.Ora_Run_Procedure(RunUser, DS_Run);
                    if (resultDS != null)
                    {
                        if (resultDS.Tables[0].Rows[0][0].ToString().Equals("1"))
                            return true;
                        else
                            return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataSet Add_Run_Parameter(string Process_Name, string[] Parameter_Name, int[] Parameter_Type, string[] Parameter_Values)
        {
            DataSet DS_Run = new DataSet();

            DataTable DT_Run = new DataTable(Process_Name);
            DataColumn[] dc = new DataColumn[3];

            try
            {
                dc[0] = new DataColumn("Parameter_Name", Type.GetType("System.String"));
                dc[1] = new DataColumn("Parameter_Type", Type.GetType("System.Int32"));
                dc[2] = new DataColumn("Parameter_Value", Type.GetType("System.String"));
                DT_Run.Columns.AddRange(dc);

                for (int i = 0; i < Parameter_Name.Length; i++)
                {
                    DataRow newRow = DT_Run.NewRow();

                    newRow["Parameter_Name"] = Parameter_Name[i];
                    newRow["Parameter_Type"] = Parameter_Type[i];
                    newRow["Parameter_Value"] = (Parameter_Values[i] == null) ? "" : Parameter_Values[i];
                    DT_Run.Rows.Add(newRow);
                }

                DS_Run.Tables.Add(DT_Run);
                return DS_Run;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message("Error: " + Process_Name + " at Add_Run_Parameter !!" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// PKG_EPM_PROD_DAILY_REPORT.SELECT_LAST_PROD_DATE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_LAST_PROD_DATE(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_LAST_PROD_DATE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

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


        /// <summary>
        /// 경고, 범위 가져오기 ( 0.점수, 1.범위(상), 2.범위(하), 3.경고메세지, 4.Module, 5.P/G, 6.Code, 7.공장, 8.일자, 9.부서 )
        /// </summary>
        /// <param name="arg_sort1">Module</param>
        /// <param name="arg_sort2">P/G</param>
        /// <param name="arg_sort3">Code</param>
        /// <param name="arg_factory">공장코드</param>
        /// <param name="arg_ymd">일자(빈값허용)</param>
        /// <param name="arg_dept_cd">부서코드(빈값허용)</param>
        /// <returns>
        /// 0.SCORE, 1.ESTIMATE_HIGH, 2.ESTIMATE_LOW, 3.WARNING, 4.SORT1, 5.SORT2, 6.SORT3, 7.FACTORY, 8.YMD, 9.DEPT_CD
        /// 0.점수, 1.범위(상), 2.범위(하), 3.경고메세지, 4.Module, 5.P/G, 6.Code, 7.공장, 8.일자, 9.부서
        /// </returns>
        public bool SELECT_SCORE_WARNING(string arg_form, string arg_code, string arg_factory, string arg_ymd, string arg_dept_cd)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);

                MyOraDB.Process_Name = "PKG_EHM_COMMON.SELECT_SCORE_WARNING";

                MyOraDB.Parameter_Name[0] = "ARG_SORT1";
                MyOraDB.Parameter_Name[1] = "ARG_SORT2";
                MyOraDB.Parameter_Name[2] = "ARG_SORT3";
                MyOraDB.Parameter_Name[3] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[4] = "ARG_YMD";
                MyOraDB.Parameter_Name[5] = "ARG_DEPT_CD";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "Production";
                MyOraDB.Parameter_Values[1] = arg_form;
                MyOraDB.Parameter_Values[2] = arg_code;
                MyOraDB.Parameter_Values[3] = arg_factory;
                MyOraDB.Parameter_Values[4] = arg_ymd == null ? "NONE" : arg_ymd;
                MyOraDB.Parameter_Values[5] = arg_dept_cd == null ? "NONE" : arg_dept_cd;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(false);
                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception("SELECT_SCORE_WARNING : " + ex.Message);
            }
        }


        /// <summary>
        /// PKG_EPM_PROD_DAILY_REPORT.SELECT_LAST_UPDATE_DATE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_LAST_UPDATE_DATE(string arg_factory, string arg_plan_ymd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_LAST_UPDATE_DATE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_plan_ymd;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(false);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret;
            }
            catch (Exception ex)
            {
                throw new Exception("SELECT_LAST_UPDATE_DATE : " + ex.Message);
            }
        }

        #endregion

        #endregion

    }
}


