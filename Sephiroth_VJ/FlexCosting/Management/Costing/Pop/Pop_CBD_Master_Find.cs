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
    public partial class Pop_CBD_Master_Find : COM.PCHWinForm.Pop_Small
    {
        #region Constructor

        public Pop_CBD_Master_Find()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion

        #region User Define Variable

        private COM.FSP _TargetGrid = null;
        private int _MatColumn = 1;

        #endregion

        #region Form Loading

        private void Pop_CBD_Master_Find_Load(object sender, EventArgs e)
        {
            Init_Control();
        }

        private void Init_Control()
        {
            DataTable vDT = new DataTable("GRID");
            vDT.Columns.Add("INDEX");
            vDT.Columns.Add("SUBJECT");

            for (int iCol = 1; iCol < _TargetGrid.Cols.Count; iCol++)
            {
                if (_TargetGrid.Cols[iCol].Visible)
                {
                    string sSubject = _TargetGrid[1, iCol].ToString();

                    DataRow vDR = vDT.NewRow();
                    vDR[0] = iCol.ToString();
                    vDR[1] = sSubject;

                    vDT.Rows.Add(vDR);
                }
            }

            COM.ComFunction.Set_ComboList(vDT, cmb_Subject, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Subject.SelectedValue = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
        }

        private void Pop_CBD_Master_Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            txt_SchText.Text = "";
            FindData();
        }
        
        private void Init_Form()
        {
            //Title
            this.Text = "Material Search";
            this.lbl_MainTitle.Text = "Material Search";
            ClassLib.ComFunction.SetLangDic(this);

            //_TargetGrid
        }

        #endregion

        #region Find data

        private void txt_MatName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindData();
            }
        }

        private void FindData()
        {
            _MatColumn = Convert.ToInt32(cmb_Subject.SelectedValue.ToString());
            string sSchMatName = txt_SchText.Text.Trim();

            for (int iRow = TargetGrid.Rows.Fixed; iRow < TargetGrid.Rows.Count; iRow++)
            {
                string sGridMatName = TargetGrid[iRow, _MatColumn] == null ? "" : TargetGrid[iRow, _MatColumn].ToString();

                if (sGridMatName.IndexOf(sSchMatName) > -1 || sSchMatName.Equals(""))
                {
                    if (TargetGrid.Rows[iRow].IsNode)
                    {
                        if (TargetGrid.Rows[iRow].Node.Level == 0)
                        {
                            for (int iTmpRow = iRow; iTmpRow <= iRow + TargetGrid.Rows[iRow].Node.Children; iTmpRow++)
                            {
                                TargetGrid.Rows[iTmpRow].Visible = true;
                            }
                        }
                    }
                    else
                    {
                        TargetGrid.Rows[iRow].Visible = true;
                    }
                }
                else
                {
                    if (TargetGrid.Rows[iRow].IsNode)
                    {
                        if (TargetGrid.Rows[iRow].Node.Level == 0)
                        {
                            for (int iTmpRow = iRow; iTmpRow <= iRow + TargetGrid.Rows[iRow].Node.Children; iTmpRow++)
                            {
                                TargetGrid.Rows[iTmpRow].Visible = false;
                            }
                        }
                    }
                    else
                    {
                        TargetGrid.Rows[iRow].Visible = false;
                    }
                }
            }

            TargetGrid.Tree.Show(1);
            TargetGrid.Tree.Show(0);
        }

        #endregion

        #region Properties

        public COM.FSP TargetGrid
        {
            set
            {
                _TargetGrid = value;
            }
            get
            {
                return _TargetGrid;
            }
        }

        #endregion

    }
}

