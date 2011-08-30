using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Pop
{
    public partial class Pop_Type_And_Search_Part : Form
    {
        public Pop_Type_And_Search_Part()
        {
            InitializeComponent();
            SetGrid();
        }

        #region 전역 변수

        private DataTable vDT;
        private string[] sKey;
        private string[] sValue;
        private bool bVisibleKey;
        private C1.Win.C1FlexGrid.Row vRow = null;

        public C1.Win.C1FlexGrid.Row VRow
        {
            get { return vRow; }
        }

        public int GridWidth
        {
            get { return fgrid_main.Width; }
        }

        #endregion


        #region 이벤트

        private void fgrid_main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
                {
                    this.DialogResult = DialogResult.OK;
                    vRow = fgrid_main.Rows[fgrid_main.Row];
                }
            }
        }

        private void fgrid_main_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
            {
                this.DialogResult = DialogResult.OK; 
                vRow = fgrid_main.Rows[fgrid_main.Row];                
            }
        }

        #endregion


        #region 이벤트 처리

        private void SetGrid()
        {
            fgrid_main.Set_Grid("SFM_CBD_PART", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Font = new Font(fgrid_main.Font.FontFamily, (float)8);
            fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            fgrid_main.ExtendLastCol = true;
            fgrid_main.AllowEditing = false;
            fgrid_main.AutoResize = true;
        }

        public void ShowData(DataTable arg_DT)
        {
            fgrid_main.ClearAll();

            vDT = arg_DT;
            if (vDT != null && vDT.Rows.Count > 0)
            {
                DisplayData();
                fgrid_main.Select();
            }
        }

        private void Init_Form()
        {
            if (sKey != null)
            {
                for (int idx1 = 0; idx1 < sKey.Length; idx1++)
                {
                    C1.Win.C1FlexGrid.Column col = fgrid_main.Cols.Add();
                    col.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
                    col.Name = sKey[idx1];
                    col.Visible = bVisibleKey;
                }
            }

            if (sValue != null)
            {
                for (int idx2 = 0; idx2 < sValue.Length; idx2++)
                {
                    C1.Win.C1FlexGrid.Column col = fgrid_main.Cols.Add();
                    col.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
                    col.Name = sValue[idx2];
                }
            }
        }

        private void DisplayData()
        {
            for (int idx1 = 0; idx1 < vDT.Rows.Count; idx1++)
            {
                C1.Win.C1FlexGrid.Row row = fgrid_main.Rows.Add();
                for (int col = 1; col < fgrid_main.Cols.Count; col++)
                {
                    row[col] = vDT.Rows[idx1][col - 1];
                }
            }
        }

        #endregion

    }
}