using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.Yield_New
{
    public partial class Pop_Finder : COM.PCHWinForm.Pop_Small
    {


        #region 생성자


        private COM.FSP arg_fgrid;
        private int _startcol;
        private int _endcol;


        public Pop_Finder(COM.FSP arg_fgrid, int startcol, int endcol)
        {
            InitializeComponent();


            this.arg_fgrid = arg_fgrid;
            _startcol = startcol;
            _endcol = endcol;

            Init_Form();


        }


        #endregion

        #region 이벤트 처리


        private void cmb_Item_SelectedValueChanged(object sender, EventArgs e)
        {

            int vitemcol = int.Parse(cmb_Item.SelectedValue.ToString());
            arg_fgrid.Select(arg_fgrid.Rows.Fixed, vitemcol);

        }



        private void txt_Key_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(null, null);
            }

        }



        private void btn_Search_Click(object sender, EventArgs e)
        {

            string vkey = txt_Key.Text;
            if (cmb_Item.SelectedIndex == -1)
            {
                MessageBox.Show("Select item", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int vitemcol = int.Parse(cmb_Item.SelectedValue.ToString());
            int vstartrow = arg_fgrid.Rows.Fixed;

            if (rad_First.Checked)
            {
                vstartrow = arg_fgrid.Rows.Fixed;
            }
            else
            {
                vstartrow = (arg_fgrid.Selection.r1 < arg_fgrid.Rows.Fixed) ? arg_fgrid.Rows.Fixed : arg_fgrid.Selection.r1 + 1;
            }

            int cnt = arg_fgrid.Rows.Fixed;

            for (cnt = vstartrow; cnt < arg_fgrid.Rows.Count; cnt++)
            {
                string vdataForGrid = (arg_fgrid[cnt, vitemcol] == null) ? "" : arg_fgrid[cnt, vitemcol].ToString();

                if (vdataForGrid.IndexOf(vkey) > -1)
                {
                    arg_fgrid.Select(cnt, vitemcol);
                    break;
                }
            }

            if (cnt == arg_fgrid.Rows.Count)
            {
                for (cnt = arg_fgrid.Rows.Fixed; cnt <= vstartrow; cnt++)
                {
                    string vdataForGrid = (arg_fgrid[cnt, vitemcol] == null) ? "" : arg_fgrid[cnt, vitemcol].ToString();

                    if (vdataForGrid.IndexOf(vkey) > -1)
                    {
                        arg_fgrid.Select(cnt, vitemcol);
                        break;
                    }
                }
            }


        }



        #endregion

        #region 멤버 메서드


        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            this.Text = "Find Data";
            lbl_MainTitle.Text = "Find Data";

            ClassLib.ComFunction.SetLangDic(this);


            int vInitRow = 0;
            int size = _endcol - _startcol + 1;

            string[] codes = new string[size];
            string[] names = new string[size];

            for (int cnt = 0; cnt < size; cnt++)
            {
                codes[cnt] = _startcol + "";
                names[cnt] = arg_fgrid[1, _startcol++].ToString();

                if (names[cnt].IndexOf("Style") > -1 && vInitRow == 0)
                    vInitRow = cnt;
            }

            COM.ComCtl.Set_ComboList(makeDataTable(codes, names), cmb_Item, 0, 1, false);
            cmb_Item.SelectedIndex = vInitRow;


        }



        private DataTable makeDataTable(string[] codes, string[] names)
        {
            DataTable temp_datatable = new DataTable();
            DataRow newrow;

            try
            {
                temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                for (int i = 0; i < codes.Length; i++)
                {
                    newrow = temp_datatable.NewRow();
                    newrow["Code"] = codes[i];
                    newrow["Name"] = names[i];
                    temp_datatable.Rows.Add(newrow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return temp_datatable;
        }



        #endregion



    }
}