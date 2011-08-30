using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Ctl
{
    public partial class TextSearch : UserControl
    {
        private COM.FSP grid = null;

        public TextSearch()
        {
            InitializeComponent();
        }

        public TextSearch(COM.FSP grid)
        {
            this.grid = grid;
        }



        private void txt_schText_KeyUp(object sender, KeyEventArgs e)
        {
            string sSchText = txt_schText.Text;

            if (!sSchText.Trim().Equals(""))
            {
                for (int iRow = grid.Rows.Fixed; iRow < grid.Rows.Count; iRow++)
                {
                    for (int iCol = 1; iCol < grid.Cols.Count; iCol++)
                    {
                        if (grid.Cols[iCol].Visible)
                        {
                            string sCurData = grid[iRow, iCol] != null ? "" : grid[iRow, iCol].ToString();

                            if (sCurData.IndexOf(sSchText) > -1)
                            {
                                grid.Select(iRow, iCol);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
