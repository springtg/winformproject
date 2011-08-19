using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Grid_Combo : Form
    {
        public Pop_Yield_Grid_Combo()
        {
            InitializeComponent();


            panel_Item.Visible = false;
            panel_Spec.Visible = false;
            panel_Color.Visible = false;
            panel_Component.Visible = false;


            // button 권한
            btn_AddNewItem.Visible = false;




            SetGrid();

        }

        #region 전역 변수

        // COMPONENT : component, ITEM : item, SPEC : Spec, COLOR : Color
        public string _JobDivision = "";
        public string _ItemCD = "";
        public string _KeyString = "";



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



        // show tooltip if the text is too long to fit the cell
        System.Windows.Forms.ToolTip _ttip;
        int _lastRow = 0;
        int _lastCol = 0;


        private void fgrid_main_MouseMove(object sender, MouseEventArgs e)
        {

            try
            {

                COM.FSP fgrid = sender as COM.FSP;

                string text = null;
                if (e.Button == MouseButtons.None)
                {
                    // get mouse coordinates
                    int row = fgrid.MouseRow;
                    int col = fgrid.MouseCol;

                    // save work if we can
                    if (row == _lastRow && col == _lastCol)
                        return;

                    // save info for next time
                    _lastRow = row;
                    _lastCol = col;

                    // get text for tooltip
                    if (row > -1 && col > -1)
                    {
                        // get display text
                        text = fgrid.GetDataDisplay(row, col);

                        // get display rectangle
                        Rectangle rc = fgrid.GetCellRect(row, col, false);
                        rc.Intersect(fgrid.ClientRectangle);

                        // measure text
                        using (Graphics g = fgrid.CreateGraphics())
                        {
                            C1.Win.C1FlexGrid.CellStyle s = fgrid.GetCellStyleDisplay(row, col);
                            float wid = g.MeasureString(text, s.Font).Width;

                            wid += s.Margins.Left + s.Margins.Right + s.Border.Width + 50;  // 50 : 앞 공백 계산

                            if (wid < rc.Width) text = null;
                        }
                    }


                }

                // create tooltip if we need it
                if (text != null && _ttip == null)
                {
                    _ttip = new ToolTip();
                }

                // set tooltip text
                if (_ttip != null && _ttip.GetToolTip(fgrid) != text)
                    _ttip.SetToolTip(fgrid, text);


            }
            catch
            {
            }

        }

      


        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
            {
                this.DialogResult = DialogResult.OK;
                vRow = fgrid_main.Rows[fgrid_main.Row];
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
            
            if (_JobDivision == "COMPONENT")
            {
                Add_New_Component();
            }
            else if (_JobDivision == "ITEM")
            {
                Add_New_Item();
            }
            else if (_JobDivision == "SPEC")
            {
                Add_New_Specification();
            }
            else if (_JobDivision == "COLOR")
            {
                Add_New_Color();
            }

        }

        private void menuItem_UseSpecDel_Click(object sender, System.EventArgs e)
        {


            try
            {

                if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed) return;

                // SBC_SPEC_MASTER SAVE
                string spec_cd = fgrid_main[fgrid_main.Row, 0].ToString();

                bool save_flag = FlexBase.Yield_New.Form_BC_Yield.SAVE_SBC_ITEM_SPEC_COMBO(_ItemCD, spec_cd, "D");

                if (!save_flag)
                {
                    ClassLib.ComFunction.Data_Message("Delete Specification Master", ClassLib.ComVar.MgsDoNotDelete, this);
                }
                else
                {
                    fgrid_main.Rows.Remove(fgrid_main.Row);
                    ClassLib.ComFunction.Data_Message("Delete Specification Master", ClassLib.ComVar.MgsEndDelete, this);
                }

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "menuItem_UseSpecDel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void cmb_ItemType_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cmb_ItemType.SelectedIndex == -1) return;


                // Item Group First Class Combo List

                DataTable dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_ItemType.SelectedValue.ToString());
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemGroup, 0, 1, true, 0, 130);

                dt_ret.Dispose();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cmb_ItemType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        private void btn_Search_Item_Click(object sender, EventArgs e)
        {
            Select_Item();
        }

        private void btn_Search_Spec_Click(object sender, EventArgs e)
        {
            Select_Spec();
        }

        private void btn_Search_Color_Click(object sender, EventArgs e)
        {
            Select_Color();
        }

        private void btn_Search_Component_Click(object sender, EventArgs e)
        {
            Select_Component();
        }

        private void txt_ItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            
            Select_Item();
        }

        private void txt_SpecName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            Select_Spec();
        }

        private void txt_ColorName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            Select_Color();
        }

        private void txt_Component_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            Select_Component();
        }

        private void btn_JointColor_Click(object sender, EventArgs e)
        {
            Select_Joint_Color();
        }


        private void Select_Item()
        {

            try
            {
                string group_cd = ClassLib.ComFunction.Empty_Combo(cmb_ItemType, " ") + ClassLib.ComFunction.Empty_Combo(cmb_ItemGroup, " ");


                // code로 조회 할 때는 해당 코드만 바로 리스트에 올라오도록 처리하기 위함
                // code는 모두 정수이고, 이름 검색할때는 문자, 숫자 조합으로 한다는 가정하에 처리
                string code_div = "";

                try
                {
                    int code = Convert.ToInt32(txt_ItemName.Text);
                    code_div = "Y";
                }
                catch
                {
                    code_div = "N";
                }

                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_ITEM_COMBO(group_cd, txt_ItemName.Text, code_div);

                fgrid_main.Select();

                DisplayData(dt_ret, txt_ItemName.Text);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Select_Spec()
        {

            try
            {
                string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");

                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_SPEC_COMBO(spec_div, txt_SpecName.Text);

                fgrid_main.Select();

                DisplayData(dt_ret, txt_SpecName.Text);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Spec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Select_Color()
        {

            try
            {
                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_COLOR_COMBO(txt_ColorName.Text);

                fgrid_main.Select();

                DisplayData(dt_ret, txt_ColorName.Text);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Select_Component()
        {

            try
            {
                DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SBC_COMPONENT_COMBO(txt_Component.Text);

                fgrid_main.Select();

                DisplayData(dt_ret, txt_Component.Text);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Select_Joint_Color()
        {
            try
            {

                FlexBase.MaterialBase.Pop_Color popup = new FlexBase.MaterialBase.Pop_Color(false);
                popup.ShowDialog();

                string result = popup._ColorName;
                popup.Dispose();


                if (result.Trim().Equals("")) return;

                txt_ColorName.Text = result;

                Select_Color();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select_Joint_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion


        #region 이벤트 처리

        private void SetGrid()
        {
            fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            fgrid_main.ExtendLastCol = true;
            fgrid_main.AllowEditing = false;
            fgrid_main.AutoResize = true;
            fgrid_main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            fgrid_main.Styles.EmptyArea.BackColor = Color.White; 
            

        }

        public void ShowData(DataTable arg_DT, string[] arg_key, string[] arg_value, bool arg_visible_key, string arg_keyword)
        {
            
            fgrid_main.Rows.Count = fgrid_main.Cols.Count = 0;

            vDT = arg_DT;
            sKey = arg_key;
            sValue = arg_value;
            bVisibleKey = arg_visible_key;

            Init_Form();


            fgrid_main.Select();


            if (vDT != null && vDT.Rows.Count > 0)
            {
                
                //Init_Form();

                DisplayData(vDT, arg_keyword); 
            }


        }


        private void Init_Form()
        {

            //----------------------------------
            // grid
            //----------------------------------
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
            //----------------------------------


            //----------------------------------
            // title, contextmenu, search panel
            //----------------------------------
            C1.Win.C1FlexGrid.Row row;
            DataTable dt_ret;

            if (_JobDivision == "COMPONENT")
            {
                row = fgrid_main.Rows.Add();
                row[0] = "CODE";
                row[1] = "NAME";

                fgrid_main.Cols[0].Width = 120;
                fgrid_main.Cols[1].Width = 300;

                panel_Component.Visible = true;

                txt_Component.Text = _KeyString;

            }
            else if (_JobDivision == "ITEM")
            {
                row = fgrid_main.Rows.Add();
                row[0] = "CODE";
                row[1] = "NAME";
                row[2] = "UNIT";
                row[3] = "SIZE";


                fgrid_main.Cols[0].Width = 60;
                fgrid_main.Cols[1].Width = 290;
                fgrid_main.Cols[2].Width = 35;
                fgrid_main.Cols[3].Width = 35;


                panel_Item.Visible = true;


                // Item Group Combo List
                dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemType, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_ItemType.SelectedValue = "01";

                txt_ItemName.Text = _KeyString;



            }
            else if (_JobDivision == "SPEC")
            {
                row = fgrid_main.Rows.Add();
                row[0] = "CODE";
                row[1] = "NAME";

                fgrid_main.Cols[0].Width = 60;
                fgrid_main.Cols[1].Width = 360;


                if (_ItemCD.Trim() != "")
                {
                    fgrid_main.ContextMenuStrip = contextMenu_Spec;
                }
                else
                {
                    fgrid_main.ContextMenuStrip = null;
                }


                panel_Spec.Visible = true;

                // Spec Division Combo List
                dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, true, ClassLib.ComVar.ComboList_Visible.Name);

                //if (_KeyString.Length > 0)
                //{
                //    cmb_SpecDiv.SelectedValue = _KeyString.Substring(0, 1);
                //}

                txt_SpecName.Text = _KeyString;


            }
            else if (_JobDivision == "COLOR")
            {
                row = fgrid_main.Rows.Add();
                row[0] = "CODE";
                row[1] = "NAME";

                fgrid_main.Cols[0].Width = 60;
                fgrid_main.Cols[1].Width = 360;


                panel_Color.Visible = true;

                txt_ColorName.Text = _KeyString;

            }

            fgrid_main.Rows.Fixed = 1;
            //----------------------------------


            //----------------------------------
            // button 권한
            //----------------------------------
            if (ClassLib.ComVar.This_PowerUser_YN == "Y")
            {
                btn_AddNewItem.Visible = true;
            } 
            //----------------------------------


        }

        private void DisplayData(DataTable arg_dt, string arg_keyword)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;


                //int col_width = 20;  // scroll size

                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;


                for (int idx1 = 0; idx1 < arg_dt.Rows.Count; idx1++)
                {
                    C1.Win.C1FlexGrid.Row row = fgrid_main.Rows.Add();
                    //row.Height = 20;

                    for (int col = 0; col < fgrid_main.Cols.Count; col++)
                    {
                        if (arg_dt.Columns.Contains(fgrid_main.Cols[col].Name))
                        {
                            row[col] = arg_dt.Rows[idx1][fgrid_main.Cols[col].Name];
                        }

                    } // end col

                    
                    //// size_yn = 'Y'
                    //if (_JobDivision == "ITEM")
                    //{
                    //    if (row[3] == null || row[3].ToString().Trim() != "Y") continue;

                    //    row.StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;

                    //} // end if item


                } // end row


                //fgrid_main.AutoSizeCols();



                int find_row = fgrid_main.FindRow(arg_keyword, 0, 1, false, true, false);

                if (find_row != -1)
                {
                    fgrid_main.TopRow = find_row;
                    fgrid_main.Select(find_row, 1, true);
                }
                else
                {
                    fgrid_main.TopRow = fgrid_main.Rows.Fixed;
                }




                //for (int col = 0; col < fgrid_main.Cols.Count; col++)
                //{

                //    // grid width
                //    if (fgrid_main.Cols[col].Visible)
                //    {
                //        col_width += (fgrid_main.Cols[col].Width > 300) ? 300 : fgrid_main.Cols[col].Width;
                //    }


                //} // end col


                //this.Size = new Size((col_width > 1000) ? 1000 : col_width, fgrid_main.Height);

                //// dock = fill
                ////fgrid_main.Size = new Size(col_width, fgrid_main.Height);

            }
            catch
            {
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }



        #region Add New


        /// <summary>
        /// Add_New_Component : 
        /// </summary>
        private void Add_New_Component()
        {

            ClassLib.ComVar.Parameter_PopUp = null;
            FlexBase.MaterialBase.Form_BC_Component pop_form = new FlexBase.MaterialBase.Form_BC_Component(true);
            pop_form.ShowDialog();


            if (ClassLib.ComVar.Parameter_PopUp == null) return;


            fgrid_main.Select();

            C1.Win.C1FlexGrid.Row row = fgrid_main.Rows.Add();
            //row.Height = 20;

            row[0] = ClassLib.ComVar.Parameter_PopUp[0];
            row[1] = ClassLib.ComVar.Parameter_PopUp[1];

            vRow = row;

            fgrid_main.TopRow = row.Index;
            fgrid_main.Select(row.Index, 1, true);

            //fgrid_main.AutoSizeCols();


        }




        /// <summary>
        /// Add_New_Item : 
        /// </summary>
        private void Add_New_Item()
        {

            ClassLib.ComVar.Parameter_PopUp = new string[4];
            ClassLib.ComVar.Parameter_PopUp[0] = "I";
            ClassLib.ComVar.Parameter_PopUp[1] = "";  // item_cd
            ClassLib.ComVar.Parameter_PopUp[2] = "";
            ClassLib.ComVar.Parameter_PopUp[3] = "";  // group_l


            FlexBase.MaterialBase.Pop_Item_Show pop_form = new FlexBase.MaterialBase.Pop_Item_Show(true);
            pop_form.ShowDialog();

            if (!pop_form._Close_Save) return;
            if (ClassLib.ComVar.Parameter_PopUp == null) return;


            fgrid_main.Select();

            //string[] key_string = new string[] { "ITEM_CD" };
            //string[] value_string = new string[] { "ITEM_NAME1", "MNG_UNIT", "SIZE_YN" };


            C1.Win.C1FlexGrid.Row row = fgrid_main.Rows.Add();
            //row.Height = 20;

            row[0] = ClassLib.ComVar.Parameter_PopUp[0];
            row[1] = ClassLib.ComVar.Parameter_PopUp[1];
            row[2] = ClassLib.ComVar.Parameter_PopUp[3];
            row[3] = ClassLib.ComVar.Parameter_PopUp[2];

            vRow = row;

            fgrid_main.TopRow = row.Index;
            fgrid_main.Select(row.Index, 1, true);

            //fgrid_main.AutoSizeCols();


        }



        /// <summary>
        /// Add_New_Specification : 
        /// </summary>
        private void Add_New_Specification()
        {


            ClassLib.ComVar.Parameter_PopUp = null;

            FlexBase.MaterialBase.Form_BC_Spec pop_form = new FlexBase.MaterialBase.Form_BC_Spec(true);
            pop_form.ShowDialog();


            if (ClassLib.ComVar.Parameter_PopUp == null) return;


            fgrid_main.Select();

            C1.Win.C1FlexGrid.Row row = fgrid_main.Rows.Add();
            //row.Height = 20;

            row[0] = ClassLib.ComVar.Parameter_PopUp[0];
            row[1] = ClassLib.ComVar.Parameter_PopUp[1];

            vRow = row;

            fgrid_main.TopRow = row.Index;
            fgrid_main.Select(row.Index, 1, true);

            //fgrid_main.AutoSizeCols();


            cmb_SpecDiv.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0].Substring(0, 1);


        }



        /// <summary>
        /// Add_New_Color : 
        /// </summary>
        private void Add_New_Color()
        {

            ClassLib.ComVar.Parameter_PopUp = null;

            FlexBase.MaterialBase.Form_BC_Color pop_form = new FlexBase.MaterialBase.Form_BC_Color(true);
            pop_form.ShowDialog();


            if (ClassLib.ComVar.Parameter_PopUp == null) return;


            fgrid_main.Select();

            C1.Win.C1FlexGrid.Row row = fgrid_main.Rows.Add();
            //row.Height = 20;

            row[0] = ClassLib.ComVar.Parameter_PopUp[0];
            row[1] = ClassLib.ComVar.Parameter_PopUp[1];

            vRow = row;

            fgrid_main.TopRow = row.Index;
            fgrid_main.Select(row.Index, 1, true);

            //fgrid_main.AutoSizeCols();

        }



        #endregion

    
        #endregion

       




    }
}