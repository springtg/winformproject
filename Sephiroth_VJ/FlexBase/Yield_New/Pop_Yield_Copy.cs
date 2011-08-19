using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Copy : COM.PCHWinForm.Pop_Medium
    {

        
        #region 생성자


        private string _Factory = "";
        private string _StyleCd = "";


        public Pop_Yield_Copy(string arg_factory, string arg_style_cd)
        {
            
            InitializeComponent();


            _Factory = arg_factory;
            _StyleCd = arg_style_cd;



            panel_Main.Visible = false;
            

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(350, 150);


            Init_Form();

        }


        #endregion

        #region 변수 정의


        COM.OraDB MyOraDB = new COM.OraDB();


        // semigood level
        private int _RowLevel_SG = 0;


        #endregion

        #region 멤버 메서드


        /// <summary>
        /// Init_Form : 
        /// </summary>
        private void Init_Form()
        {

            try
            {

                //Title
                this.Text = "Yield Copy";
                lbl_MainTitle.Text = "Yield Copy";

                ClassLib.ComFunction.SetLangDic(this);



                //combobox setting
                Init_Control();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Init_Control : combobox setting
        /// </summary>
        private void Init_Control()
        {

            try
            {


                // default : grid hide
                chk_Component.CheckState = CheckState.Unchecked;
                Event_chk_Component_CheckedChanged();


                rad_Comp.Checked = true;


                // 그리드 설정 
                // "SBC_YIELD_COMPONENT_NEW"
                fgrid_Main.Set_Grid("SBC_YIELD_COPY_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Main.Font = new Font("Verdana", 8);
                fgrid_Main.Styles.Frozen.BackColor = Color.White;
                fgrid_Main.Styles.Alternate.BackColor = Color.White;


                // 공장코드
                DataTable dt_ret = COM.ComFunction.Select_Factory_List();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_Source, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_Target, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);

                if (dt_ret != null && dt_ret.Rows.Count > 0)
                {
                    cmb_Factory_Source.SelectedValue = _Factory;
                    cmb_Factory_Target.SelectedValue = cmb_Factory_Source.SelectedValue.ToString();
                }


                dt_ret.Dispose();


                // soruce 스타일 코드 세팅
                txt_StyleCd_Source.Text = _StyleCd;

                Init_Cmb_Style(txt_StyleCd_Source);


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }





        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_cmb_Factory_SelectedValueChanged(object sender)
        {

            try
            {


                C1.Win.C1List.C1Combo src = sender as C1.Win.C1List.C1Combo;


                if (src.SelectedIndex == -1) return;


                if (src == cmb_Factory_Source)
                {

                    txt_StyleCd_Source.Text = "";
                    cmb_StyleCd_Source.SelectedIndex = -1;
                    txt_Gender_Source.Text = "";

                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

                }
                else if (src == cmb_Factory_Target)
                {

                    txt_StyleCd_Target.Text = "";
                    cmb_StyleCd_Target.SelectedIndex = -1;
                    txt_Gender_Target.Text = "";

                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_cmb_StyleCd_SelectedValueChanged(object sender)
        {


            try
            {


                C1.Win.C1List.C1Combo src = sender as C1.Win.C1List.C1Combo;


                if (src == cmb_StyleCd_Source)
                {

                    if (cmb_Factory_Source.SelectedIndex == -1 || cmb_StyleCd_Source.SelectedIndex == -1) return;


                    txt_Gender_Source.Text = "";
                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


                    //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
                    txt_StyleCd_Source.Text = cmb_StyleCd_Source.SelectedValue.ToString();
                    txt_Gender_Source.Text = cmb_StyleCd_Source.Columns[2].Text + " / " + ((cmb_StyleCd_Source.Columns[3].Text == "N") ? "No" : "Yes");


                    // 데이터 조회
                    Display_Yield_Detail();


                }
                else if (src == cmb_StyleCd_Target)
                {

                    if (cmb_Factory_Target.SelectedIndex == -1 || cmb_StyleCd_Target.SelectedIndex == -1) return;


                    txt_Gender_Target.Text = "";


                    //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
                    txt_StyleCd_Target.Text = cmb_StyleCd_Target.SelectedValue.ToString();
                    txt_Gender_Target.Text = cmb_StyleCd_Target.Columns[2].Text + " / " + ((cmb_StyleCd_Target.Columns[3].Text == "N") ? "No" : "Yes");


                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_txt_StyleCd_KeyUp : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            try
            {

                if (e.KeyCode != Keys.Enter) return;


                System.Windows.Forms.TextBox src = sender as System.Windows.Forms.TextBox;


                Init_Cmb_Style(src);



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Init_Cmb_Style : 
        /// </summary>
        /// <param name="sender"></param>
        private void Init_Cmb_Style(object sender)
        {



            System.Windows.Forms.TextBox src = sender as System.Windows.Forms.TextBox;
            C1.Win.C1List.C1Combo cmb_style = (src == txt_StyleCd_Source) ? cmb_StyleCd_Source : cmb_StyleCd_Target;


            string factory = "";
            string style_cd = "";
            int exist_index = -1;


            if (src == txt_StyleCd_Source)
            {

                if (cmb_Factory_Source.SelectedIndex == -1) return;

                // 기타 콘트롤 초기화 
                cmb_StyleCd_Source.SelectedIndex = -1;
                txt_Gender_Source.Text = "";
                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


                factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory_Source, " ");
                style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd_Source, " ");


            }
            else if (src == txt_StyleCd_Target)
            {

                if (cmb_Factory_Target.SelectedIndex == -1) return;

                // 기타 콘트롤 초기화 
                cmb_StyleCd_Target.SelectedIndex = -1;
                txt_Gender_Target.Text = "";


                factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory_Target, " ");
                style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd_Target, " ");


            }



            DataTable dt_ret = FlexBase.Yield_New.Form_BC_Yield.SELECT_SDC_STYLE(factory, style_cd);




            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name, 5 : yield status
            ClassLib.ComCtl.Set_ComboList_Multi(dt_ret, cmb_style, new int[] { 0, 1, 2, 3, 4, 5 }, false);
            string[] titles = new string[] { "CODE", "NAME", "GENDER", "PRESTO", "MODEL_NAME", "YIELD_STATUS" };
            int[] width = new int[] { 80, 100, 100, 100, 100, 100 };
            bool[] visible = new bool[] { true, true, false, false, false, false };
            ClassLib.ComCtl.SetComboStyle(cmb_style, titles, width, visible, "NAME");
            cmb_style.DropDownWidth = 226;



            style_cd = src.Text.Trim();
            exist_index = src.Text.IndexOf("-", 0);

            if (exist_index == -1 && style_cd.Length == 9)
            {
                style_cd = style_cd.Substring(0, 6) + "-" + style_cd.Substring(6, 3);
            }


            cmb_style.SelectedValue = style_cd;



            dt_ret.Dispose();



        }



        /// <summary>
        /// Event_chk_Component_CheckedChanged : 
        /// </summary>
        private void Event_chk_Component_CheckedChanged()
        {

            try
            {

                panel_Main.Visible = chk_Component.Checked;


                if (chk_Component.Checked)
                {
                    this.Size = new Size(700, 500);

                    groupBox_Depth.Visible = true;

                }
                else
                {
                    this.Size = new Size(700, 260);

                    groupBox_Depth.Visible = false;
                
                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_chk_Component_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Display_Yield_Detail : 
        /// </summary>
        private void Display_Yield_Detail()
        {

            try
            {

                if (cmb_Factory_Source.SelectedIndex == -1 || cmb_StyleCd_Source.SelectedIndex == -1) return;

                string factory = cmb_Factory_Source.SelectedValue.ToString();
                string style_cd = cmb_StyleCd_Source.SelectedValue.ToString().Replace("-", "");

                DataTable dt_ret = SELECT_SBC_YIELD_COPY(factory, style_cd);

                if (dt_ret == null || dt_ret.Rows.Count == 0) return;

                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;



                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {

                    fgrid_Main.Rows.Add();

                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].IsNode = true;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].Node.Level = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_LEVEL - 1] == null) ? 0 : Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_LEVEL - 1].ToString());


                    for (int j = 0; j < dt_ret.Columns.Count; j++)
                    {
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = (dt_ret.Rows[i].ItemArray[j] == null) ? "" : dt_ret.Rows[i].ItemArray[j].ToString();
                    } // end for j





                    fgrid_Main.SetCellCheck(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC, CheckEnum.Unchecked);


                    string row_type = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE - 1] == null) ? "" : dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE - 1].ToString();

                    if (row_type == "S" || row_type == "C")
                    {
                        fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, 1, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = Color.WhiteSmoke;
                    }


                    string size_yn = (dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSIZE_YN - 1] == null) ? "" : dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSIZE_YN - 1].ToString();

                    if (size_yn == "Y")
                    {
                        fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, 1, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
                    }
                    else
                    {
                        fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, 1, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
                    }


                } // end for i



                fgrid_Main.Tree.Column = (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC;
                //fgrid_Main.Tree.Show(-1);


                if (rad_SG.Checked)
                {
                    fgrid_Main.Tree.Show(Convert.ToInt32(rad_SG.Tag.ToString()));
                }
                else if (rad_Comp.Checked)
                {
                    fgrid_Main.Tree.Show(Convert.ToInt32(rad_Comp.Tag.ToString()));
                }
                else if (rad_All.Checked)
                {
                    fgrid_Main.Tree.Show(Convert.ToInt32(rad_All.Tag.ToString()));
                }



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Display_Yield_Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Event_fgrid_Main_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Main_AfterEdit()
        {

            try
            {

                bool check = (fgrid_Main.GetCellCheck(fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC) == CheckEnum.Checked) ? true : false;

                Check_Child(fgrid_Main.Row, check);

                if (Convert.ToInt32(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_LEVEL].ToString()) > _RowLevel_SG)
                {
                    Check_Parent(fgrid_Main.Row, check);
                }


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /// <summary>
        /// Check_Child : 체크표시
        /// </summary>
        /// <param name="arg_row">component row</param>
        private void Check_Child(int arg_row, bool arg_check)
        {
        
            int start_row = -1;
            int end_row = -1;

            C1.Win.C1FlexGrid.Node node = null;

            start_row = arg_row;

            node = fgrid_Main.Rows[arg_row].Node;

            if (node.Children == 0)
            {
                end_row = arg_row;
            }
            else
            {
                end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

                while (true)
                {
                    node = fgrid_Main.Rows[end_row].Node;

                    if (node.Children == 0) break;

                    end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

                } // end while 

            } // end if 





            for (int i = end_row; i >= start_row; i--)
            {
                fgrid_Main.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC, (arg_check) ? CheckEnum.Checked : CheckEnum.Unchecked);

            } // end for i




        }


        /// <summary>
        /// Check_Parent : 상위 체크
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_check"></param>
        private void Check_Parent(int arg_row, bool arg_check)
        {
         
            int parent_row = -1;
            C1.Win.C1FlexGrid.Node node = null;

            parent_row = arg_row;

            while (true)
            {
                node = fgrid_Main.Rows[parent_row].Node;

                if (arg_check)
                {
                    fgrid_Main.SetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC, CheckEnum.Checked);
                }
                else
                {
                    //다른 하위 노드에 check 있으면 check 상태 유지  

                    // true : 다른 하위 노드 체크 되어 있는 경우 -> 상위는 체크 해제하지 않음
                    bool other_check = Check_Other_Item(parent_row);

                    if (other_check) break;

                    fgrid_Main.SetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC, CheckEnum.Unchecked);

                }

                if (node.Level == _RowLevel_SG) break;

                parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index;

            } // end while  
        }



        /// <summary>
        /// Check_Other_Item : 다른 하위 노드 체크 여부
        /// </summary>
        /// <param name="arg_row"></param>
        /// <returns>true : 다른 하위 노드 체크 되어 있는 경우</returns>
        private bool Check_Other_Item(int arg_row)
        {
            int start_row = -1;
            int end_row = -1;
            int check_count = 0;

            C1.Win.C1FlexGrid.Node node = null;

            start_row = arg_row;

            node = fgrid_Main.Rows[arg_row].Node;

            if (node.Children == 0)
            {
                end_row = arg_row;
            }
            else
            {
                end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

                while (true)
                {
                    node = fgrid_Main.Rows[end_row].Node;

                    if (node.Children == 0) break;

                    end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

                } // end while 

            } // end if


            for (int i = start_row; i <= end_row; i++)
            {
                // template_level = 1 이고, 현재 선택 반영했던 행 제외하고, 체크된 노드가 있을 경우
                // 상위 체크는 해제 할 수 없도록 처리
                if (Convert.ToInt32(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxTEMPLATE_LEVEL].ToString()) == 1
                    && i != arg_row
                    && fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Checked))
                {
                    check_count++;
                }

            } // end for i


            if (check_count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }




        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        private void Event_btn_Apply_Click()
        {

            try
            {

                Run_Copy_Yield();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);


                //-------------------------------------------
                // check out
                //-------------------------------------------
                 
                if (class_check_inout_source != null)
                {

                    class_check_inout_source._CheckDivision = "O";
                    class_check_inout_source._CheckRemark = "check out";

                    bool check_ok = class_check_inout_source.Run_Check_InOut();

                    if (!check_ok) return;

                }


                if (class_check_inout_target != null)
                {
                    class_check_inout_target._CheckDivision = "O";
                    class_check_inout_target._CheckRemark = "check out";

                    bool check_ok = class_check_inout_target.Run_Check_InOut();

                    if (!check_ok) return;

                }
                //-------------------------------------------


            }

        }


        // check in, out class
        // check in 일 때만 객체 생성
        ClassLib.Class_Check_InOut class_check_inout_source;
        ClassLib.Class_Check_InOut class_check_inout_target;


        /// <summary>
        /// Run_Copy_Yield : 
        /// </summary>
        private void Run_Copy_Yield()
        {


            //-------------------------------------------
            // check condition
            //-------------------------------------------
            if (cmb_Factory_Target.SelectedIndex == -1)
            {
                ClassLib.ComFunction.User_Message("Factory should be selected.");
                return;
            }

            if (cmb_StyleCd_Target.SelectedIndex == -1)
            {
                ClassLib.ComFunction.User_Message("Style should be selected.");
                return;
            }

            if (cmb_Factory_Source.SelectedValue.ToString() == cmb_Factory_Target.SelectedValue.ToString()
                && cmb_StyleCd_Source.SelectedValue.ToString().Replace("-", "") == cmb_StyleCd_Target.SelectedValue.ToString().Replace("-", ""))
            {
                ClassLib.ComFunction.User_Message("Copy should not be same style.");
                return;
            }
            //-------------------------------------------



            //-------------------------------------------
            // check duplicate - component 로 확인
            //-------------------------------------------
            string factory = cmb_Factory_Target.SelectedValue.ToString();
            string style_cd = cmb_StyleCd_Target.SelectedValue.ToString().Replace("-", "");
            string component_cd = "";
            string row_type = "";

            // component_cd 조합
            int check_count = 0;

            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {

                row_type = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE].ToString();

                if (row_type != "C") continue;

                if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Unchecked))
                {
                    continue;
                }

                check_count++;

            } // end for i



            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {

                row_type = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE].ToString();

                if (row_type != "C") continue;


                if (chk_Component.Checked && check_count != 0)
                {
                    if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Unchecked))
                    {
                        continue;
                    }
                } // end if (chk_Component.Checked)


                if (component_cd == "")
                {
                    component_cd = @"'" + ((fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD].ToString()) + @"'";
                }
                else
                {
                    component_cd += ", " + @"'" + ((fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD].ToString()) + @"'";
                }

            } // end for i



            DataTable dt_ret = CHECK_SBC_YIELD_COPY_COMPONENT(factory, style_cd, component_cd);

            DialogResult dr;

            if (dt_ret == null || dt_ret.Rows.Count == 0)
            {
                dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
            }
            else
            {

                FlexBase.Yield_New.Pop_Yield_Copy_Duplicate pop_form = new FlexBase.Yield_New.Pop_Yield_Copy_Duplicate(dt_ret);
                pop_form.ShowDialog();


                string msg = "Would you remove old yield data and insert new yield data ?";
                dr = ClassLib.ComFunction.User_Message(msg, "Copy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }



            if (dr == DialogResult.No) return;
            //-------------------------------------------


            //-------------------------------------------
            // check in
            //-------------------------------------------
            // source style
            class_check_inout_source = new FlexBase.ClassLib.Class_Check_InOut();

            factory = cmb_Factory_Source.SelectedValue.ToString();
            style_cd = cmb_StyleCd_Source.SelectedValue.ToString().Replace("-", "");

            string where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd + @"' AND COMPONENT_CD LIKE 'C%'";

            class_check_inout_source._CheckDivision = "I";
            class_check_inout_source._CheckFactory = ClassLib.ComVar.This_Factory;
            class_check_inout_source._CheckUser = ClassLib.ComVar.This_User;
            class_check_inout_source._CheckRemark = "copy (yield register) - source";
            class_check_inout_source._CheckWhere = where;
            class_check_inout_source._ShowMessage = false;
            class_check_inout_source._Factory = factory;
            class_check_inout_source._StyleCd = style_cd;
            // 소스 스타일은 체크인만 걸고, 수정은 일어나지 않았으므로 전송 적용 하지 않음
            class_check_inout_source._IncludeInfoTable = "N";
            class_check_inout_source._IncludeValueTable = "N";
            class_check_inout_source._IncludeHistoryTable = "N";

            bool check_ok = class_check_inout_source.Run_Check_InOut();

            if (!check_ok)
            {
                //ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
                ClassLib.ComFunction.Data_Message("Check in - soruce", ClassLib.ComVar.MgsDoNotRun, this);
                return;
            }


            // target style
            class_check_inout_target = new FlexBase.ClassLib.Class_Check_InOut();

            factory = cmb_Factory_Target.SelectedValue.ToString();
            style_cd = cmb_StyleCd_Target.SelectedValue.ToString().Replace("-", "");

            where = @"FACTORY = '" + factory + @"' AND STYLE_CD = '" + style_cd + @"' AND COMPONENT_CD LIKE 'C%'";

            class_check_inout_target._CheckDivision = "I";
            class_check_inout_target._CheckFactory = ClassLib.ComVar.This_Factory;
            class_check_inout_target._CheckUser = ClassLib.ComVar.This_User;
            class_check_inout_target._CheckRemark = "copy (yield register) - target";
            class_check_inout_target._CheckWhere = where;
            class_check_inout_target._ShowMessage = false;
            class_check_inout_target._Factory = factory;
            class_check_inout_target._StyleCd = style_cd;
            class_check_inout_target._IncludeInfoTable = "Y";
            class_check_inout_target._IncludeValueTable = "Y";
            class_check_inout_target._IncludeHistoryTable = "Y";

            check_ok = class_check_inout_target.Run_Check_InOut();

            if (!check_ok)
            {
                //ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
                ClassLib.ComFunction.Data_Message("Check in - target", ClassLib.ComVar.MgsDoNotRun, this);
                return;
            }
            //-------------------------------------------


            //-------------------------------------------
            // copy
            //-------------------------------------------
            bool run_flag = RUN_SBC_YIELD_COPY();


            if (!run_flag)
            {
                ClassLib.ComFunction.Data_Message("Apply", ClassLib.ComVar.MgsDoNotRun, this);
            }
            else
            {

                ClassLib.ComFunction.Data_Message("Apply", ClassLib.ComVar.MgsEndRun, this);

            } // end if 
            //-------------------------------------------


            //-------------------------------------------
            // check out
            //-------------------------------------------
            // source style
            class_check_inout_source._CheckDivision = "O";
            class_check_inout_source._CheckRemark = "check out";

            check_ok = class_check_inout_source.Run_Check_InOut();

            if (!check_ok)
            {
            }


            // target style
            class_check_inout_target._CheckDivision = "O";
            class_check_inout_target._CheckRemark = "check out";

            check_ok = class_check_inout_target.Run_Check_InOut();

            if (!check_ok)
            {
            }
            //-------------------------------------------



        }




        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        private void Event_btn_Cancel_Click()
        {

            try
            {

                this.Close();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Event_rad_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        private void Event_rad_CheckedChanged(object sender)
        {

            try
            {
                RadioButton src = sender as RadioButton;

                //라디오 버튼 태그값에 레벨값 세팅
                //rad_semi.tag = '0'
                //rad_cmp.tag = '1'
                //rad_all.tag = '-1'

                fgrid_Main.Tree.Show(Convert.ToInt32(src.Tag.ToString()));


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #endregion

        #region 이벤트 처리


        /// <summary>
        /// cmb_Factory_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {

            Event_cmb_Factory_SelectedValueChanged(sender);

        }



        /// <summary>
        /// cmb_StyleCd_SelectedValueChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
        {

            Event_cmb_StyleCd_SelectedValueChanged(sender);

        }


        /// <summary>
        /// 스타일 콤보박스 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            Event_txt_StyleCd_KeyUp(sender, e);

        }



        /// <summary>
        /// chk_Component_CheckedChanged : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Component_CheckedChanged(object sender, EventArgs e)
        {
            Event_chk_Component_CheckedChanged();
        }



        /// <summary>
        /// fgrid_Main_AfterEdit : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fgrid_Main_AfterEdit(object sender, RowColEventArgs e)
        {
            Event_fgrid_Main_AfterEdit();
        }



        /// <summary>
        /// Event_btn_Apply_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Event_btn_Apply_Click();
        }



        /// <summary>
        /// Event_btn_Cancel_Click : 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Event_btn_Cancel_Click();
        }


        /// <summary>
        /// display depth 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rad_CheckedChanged(object sender, System.EventArgs e)
        {

            Event_rad_CheckedChanged(sender);

        }




        #endregion

        #region 디비 연결



        /// <summary>
        /// SELECT_SBC_YIELD_COPY : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SBC_YIELD_COPY(string arg_factory, string arg_style_cd)
        {


            try
            {


                MyOraDB.ReDim_Parameter(3);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.SELECT_SBC_YIELD_COPY";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }

        }




        /// <summary>
        /// CHECK_SBC_YIELD_COPY_COMPONENT : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_component_cd"></param>
        /// <returns></returns>
        private DataTable CHECK_SBC_YIELD_COPY_COMPONENT(string arg_factory, string arg_style_cd, string arg_component_cd)
        {


            try
            {


                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.CHECK_SBC_YIELD_COPY_COMPONENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_COMPONENT_CD";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_component_cd;
                MyOraDB.Parameter_Values[3] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }

        }



        /// <summary>
        /// RUN_SBC_YIELD_COPY : 
        /// </summary>
        /// <returns></returns>
        private bool RUN_SBC_YIELD_COPY()
        {


            try
            {


                int col_ct = 15;

                MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_NEW.RUN_SBC_YIELD_COPY";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_COPY_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_FACTORY_S";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD_S";
                MyOraDB.Parameter_Name[4] = "ARG_GENDER_S";
                MyOraDB.Parameter_Name[5] = "ARG_PRESTO_YN_S";
                MyOraDB.Parameter_Name[6] = "ARG_SEMI_GOOD_CD_S";
                MyOraDB.Parameter_Name[7] = "ARG_COMPONENT_CD_S";
                MyOraDB.Parameter_Name[8] = "ARG_TEMPLATE_SEQ_S";
                MyOraDB.Parameter_Name[9] = "ARG_FACTORY_T";
                MyOraDB.Parameter_Name[10] = "ARG_STYLE_CD_T";
                MyOraDB.Parameter_Name[11] = "ARG_GENDER_T";
                MyOraDB.Parameter_Name[12] = "ARG_PRESTO_YN_T";
                MyOraDB.Parameter_Name[13] = "ARG_UPD_FACTORY";
                MyOraDB.Parameter_Name[14] = "ARG_UPD_USER";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();


                string factory_s = cmb_Factory_Source.SelectedValue.ToString();
                string style_cd_s = cmb_StyleCd_Source.SelectedValue.ToString().Replace("-", "");
                string[] token_s = txt_Gender_Source.Text.Split("/".ToCharArray());
                string gender_s = token_s[0].Trim();
                string presto_yn_s = token_s[1].Trim().Substring(0, 1);
                string factory_t = cmb_Factory_Target.SelectedValue.ToString();
                string style_cd_t = cmb_StyleCd_Target.SelectedValue.ToString().Replace("-", "");
                string[] token_t = txt_Gender_Target.Text.Split("/".ToCharArray());
                string gender_t = token_t[0].Trim();
                string presto_yn_t = token_t[1].Trim().Substring(0, 1);

                string copy_type = "";
                string semi_good_cd_s = "";
                string component_cd_s = "";
                string template_seq_s = "";


                //-------------------------
                // component check count : 0 이면 style copy
                //-------------------------
                int check_count = 0;

                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {

                    string row_type = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE].ToString();

                    if (row_type != "C") continue;

                    if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Unchecked))
                    {
                        continue;
                    }

                    check_count++;

                } // end for i
                //-------------------------


                //-------------------------
                // delete
                //-------------------------
                if (chk_Component.Checked && check_count != 0)
                {

                    copy_type = "C";


                    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    {

                        string row_type = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE].ToString();
                        if (row_type != "C") continue;

                        if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Unchecked)) continue;


                        semi_good_cd_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSEMI_GOOD_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSEMI_GOOD_CD].ToString();
                        component_cd_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD].ToString();
                        

                        vList.Add("D"); // "ARG_DIVISION";
                        vList.Add(copy_type); // "ARG_COPY_TYPE";
                        vList.Add(factory_s); // "ARG_FACTORY_S";
                        vList.Add(style_cd_s); // "ARG_STYLE_CD_S";
                        vList.Add(gender_s); // "ARG_GENDER_S";
                        vList.Add(presto_yn_s); // "ARG_PRESTO_YN_S";
                        vList.Add(semi_good_cd_s); // "ARG_SEMI_GOOD_CD_S";
                        vList.Add(component_cd_s); // "ARG_COMPONENT_CD_S";
                        vList.Add(""); // "ARG_TEMPLATE_SEQ_S";
                        vList.Add(factory_t); // "ARG_FACTORY_T";
                        vList.Add(style_cd_t); // "ARG_STYLE_CD_T";
                        vList.Add(gender_t); // "ARG_GENDER_T";
                        vList.Add(presto_yn_t); // "ARG_PRESTO_YN_T";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";



                    } // end for i



                }
                else
                {

                    copy_type = "S";


                    vList.Add("D"); // "ARG_DIVISION";
                    vList.Add(copy_type); // "ARG_COPY_TYPE";
                    vList.Add(factory_s); // "ARG_FACTORY_S";
                    vList.Add(style_cd_s); // "ARG_STYLE_CD_S";
                    vList.Add(gender_s); // "ARG_GENDER_S";
                    vList.Add(presto_yn_s); // "ARG_PRESTO_YN_S";
                    vList.Add(""); // "ARG_SEMI_GOOD_CD_S";
                    vList.Add(""); // "ARG_COMPONENT_CD_S";
                    vList.Add(""); // "ARG_TEMPLATE_SEQ_S";
                    vList.Add(factory_t); // "ARG_FACTORY_T";
                    vList.Add(style_cd_t); // "ARG_STYLE_CD_T";
                    vList.Add(gender_t); // "ARG_GENDER_T";
                    vList.Add(presto_yn_t); // "ARG_PRESTO_YN_T";
                    vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                    vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                } // end if (chk_Component.Checked)
                //-------------------------


                //-------------------------
                // insert
                //-------------------------
                if (chk_Component.Checked && check_count != 0)
                {

                    copy_type = "C";


                    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    {

                        string row_type = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE].ToString();
                        //if (row_type != "C") continue;

                        if (row_type == "S" || row_type == "C") continue;


                        // row_type = "M" or "J" 인 경우 template_level = 1 로만 template_seq 계산
                        string template_level = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxTEMPLATE_LEVEL] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxTEMPLATE_LEVEL].ToString();

                        if (template_level != "1") continue;



                        if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Unchecked)) continue;


                        semi_good_cd_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSEMI_GOOD_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSEMI_GOOD_CD].ToString();
                        component_cd_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD].ToString();
                        template_seq_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxTEMPLATE_SEQ] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxTEMPLATE_SEQ].ToString();


                        vList.Add("I"); // "ARG_DIVISION";
                        vList.Add(copy_type); // "ARG_COPY_TYPE";
                        vList.Add(factory_s); // "ARG_FACTORY_S";
                        vList.Add(style_cd_s); // "ARG_STYLE_CD_S";
                        vList.Add(gender_s); // "ARG_GENDER_S";
                        vList.Add(presto_yn_s); // "ARG_PRESTO_YN_S";
                        vList.Add(semi_good_cd_s); // "ARG_SEMI_GOOD_CD_S";
                        vList.Add(component_cd_s); // "ARG_COMPONENT_CD_S";
                        vList.Add(template_seq_s); // "ARG_TEMPLATE_SEQ_S";
                        vList.Add(factory_t); // "ARG_FACTORY_T";
                        vList.Add(style_cd_t); // "ARG_STYLE_CD_T";
                        vList.Add(gender_t); // "ARG_GENDER_T";
                        vList.Add(presto_yn_t); // "ARG_PRESTO_YN_T";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";



                    } // end for i



                }
                else
                {

                    copy_type = "S";


                    vList.Add("I"); // "ARG_DIVISION";
                    vList.Add(copy_type); // "ARG_COPY_TYPE";
                    vList.Add(factory_s); // "ARG_FACTORY_S";
                    vList.Add(style_cd_s); // "ARG_STYLE_CD_S";
                    vList.Add(gender_s); // "ARG_GENDER_S";
                    vList.Add(presto_yn_s); // "ARG_PRESTO_YN_S";
                    vList.Add(""); // "ARG_SEMI_GOOD_CD_S";
                    vList.Add(""); // "ARG_COMPONENT_CD_S";
                    vList.Add(""); // "ARG_TEMPLATE_SEQ_S";
                    vList.Add(factory_t); // "ARG_FACTORY_T";
                    vList.Add(style_cd_t); // "ARG_STYLE_CD_T";
                    vList.Add(gender_t); // "ARG_GENDER_T";
                    vList.Add(presto_yn_t); // "ARG_PRESTO_YN_T";
                    vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                    vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                } // end if (chk_Component.Checked)
                //-------------------------


                if (chk_Component.Checked && check_count != 0)
                {

                    copy_type = "C";


                    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    {

                        string row_type = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxROW_TYPE].ToString();
                        if (row_type != "C") continue;

                        if (fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxDISPLAY_DESC).Equals(CheckEnum.Unchecked)) continue;


                        semi_good_cd_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSEMI_GOOD_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxSEMI_GOOD_CD].ToString();
                        component_cd_s = (fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD] == null) ? "" : fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_COPY_NEW.IxCOMPONENT_CD].ToString();


                        vList.Add("H"); // "ARG_DIVISION";
                        vList.Add(copy_type); // "ARG_COPY_TYPE";
                        vList.Add(factory_s); // "ARG_FACTORY_S";
                        vList.Add(style_cd_s); // "ARG_STYLE_CD_S";
                        vList.Add(gender_s); // "ARG_GENDER_S";
                        vList.Add(presto_yn_s); // "ARG_PRESTO_YN_S";
                        vList.Add(semi_good_cd_s); // "ARG_SEMI_GOOD_CD_S";
                        vList.Add(component_cd_s); // "ARG_COMPONENT_CD_S";
                        vList.Add(""); // "ARG_TEMPLATE_SEQ_S";
                        vList.Add(factory_t); // "ARG_FACTORY_T";
                        vList.Add(style_cd_t); // "ARG_STYLE_CD_T";
                        vList.Add(gender_t); // "ARG_GENDER_T";
                        vList.Add(presto_yn_t); // "ARG_PRESTO_YN_T";
                        vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                        vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";



                    } // end for i



                }
                else
                {

                    copy_type = "S";


                    vList.Add("H"); // "ARG_DIVISION";
                    vList.Add(copy_type); // "ARG_COPY_TYPE";
                    vList.Add(factory_s); // "ARG_FACTORY_S";
                    vList.Add(style_cd_s); // "ARG_STYLE_CD_S";
                    vList.Add(gender_s); // "ARG_GENDER_S";
                    vList.Add(presto_yn_s); // "ARG_PRESTO_YN_S";
                    vList.Add(""); // "ARG_SEMI_GOOD_CD_S";
                    vList.Add(""); // "ARG_COMPONENT_CD_S";
                    vList.Add(""); // "ARG_TEMPLATE_SEQ_S";
                    vList.Add(factory_t); // "ARG_FACTORY_T";
                    vList.Add(style_cd_t); // "ARG_STYLE_CD_T";
                    vList.Add(gender_t); // "ARG_GENDER_T";
                    vList.Add(presto_yn_t); // "ARG_PRESTO_YN_T";
                    vList.Add(ClassLib.ComVar.This_Factory); // "ARG_UPD_FACTORY";
                    vList.Add(ClassLib.ComVar.This_User); // "ARG_UPD_USER";


                } // end if (chk_Component.Checked)
                //-------------------------



                  

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                if (ds_ret == null)  // error
                {
                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "RUN_SBC_YIELD_COPY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }




        #endregion

      
       
    }
}