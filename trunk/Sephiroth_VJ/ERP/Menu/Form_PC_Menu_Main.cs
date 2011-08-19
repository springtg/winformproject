using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ERP.Menu
{
    public partial class Form_PC_Menu_Main : COM.APSWinForm.Form_Top
    {

        #region 생성자


        public Form_PC_Menu_Main()
        {
            InitializeComponent();

            //Init_Form();
        }

        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        // 메뉴 type
        private string _TypeRoot = "R";
        private string _TypeMenu = "M";
        private string _TypeSubmenu = "S";
        private string _TypeSeparator = "B";
        private string _TypeProgram = "P";

        private string _RootMenuKey = "-1";


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


                ////Title
                //this.Text = "메뉴";
                //lbl_MainTitle.Text = "메뉴";


                Init_Grid();

                Init_Control();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// 
        /// </summary>
        private void Init_Grid()
        {


            fgrid_Program_Main.Set_Grid("SCM_MENU_MAIN_PROJECT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Program_Main.ExtendLastCol = false;
            fgrid_Program_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Program_Main.AllowDragging = AllowDraggingEnum.None;


            // program 신규로 추가
            fgrid_Program_Main.DragMode = DragModeEnum.Manual;



            fgrid_Menu_Main.Set_Grid("SCM_MENU_MAIN", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            //fgrid_Menu_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Menu_Main.ExtendLastCol = false;
            fgrid_Menu_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Menu_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Menu_Main.Set_Action_Image(img_Action);


            // program 신규로 추가
            fgrid_Menu_Main.DropMode = DropModeEnum.Manual;

            // menu 이동
            fgrid_Menu_Main.SelectionMode = SelectionModeEnum.Row;
            fgrid_Menu_Main.DropMode = DropModeEnum.Manual;


        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {




            // Disabled tbutton
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Color.Enabled = false;



            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_Main, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();

            cmb_Factory_Main.SelectedValue = ClassLib.ComVar.This_Factory;



        }






        #endregion

        #region 조회





        /// <summary>
        /// Display_Grid_Main : 
        /// </summary>
        /// <param name="arg_fgrid"></param>
        /// <param name="arg_dt"></param>
        private void Display_Grid_Main(COM.FSP arg_fgrid, DataTable arg_dt)
        {


            arg_fgrid.ClearAll();


            arg_fgrid.Tree.Column = (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TEXT;
            arg_fgrid.Tree.Style = TreeStyleFlags.Complete;
            arg_fgrid.Tree.Show(-1);



            // root 영역 표시
            arg_fgrid.Rows.InsertNode(arg_fgrid.Rows.Fixed, 0);

            for (int j = 0; j < arg_fgrid.Cols.Count; j++)
            {
                arg_fgrid[arg_fgrid.Rows.Fixed, j] = "";
            }

            arg_fgrid[arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_LEVEL] = "0";
            arg_fgrid[arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TEXT] = "Root";
            arg_fgrid[arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE] = "R";
            arg_fgrid[arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_KEY] = "-1";
            arg_fgrid[arg_fgrid.Rows.Fixed, (int)ClassLib.TBSCM_MENU_MAIN.IxPARENT_MENU_KEY] = "-1";




            int level = 0;

            // data 표시
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {

                level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_MENU_MAIN.IxMENU_LEVEL - 1].ToString());

                arg_fgrid.Rows.InsertNode(i + (arg_fgrid.Rows.Fixed + 1), level);

                arg_fgrid[i + (arg_fgrid.Rows.Fixed + 1), (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION] = "";

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[i + (arg_fgrid.Rows.Fixed + 1), j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

            } // end for i





        }







        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {

            fgrid_Program_Main.ClearAll();
            fgrid_Menu_Main.ClearAll();

        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search(string arg_division)
        {


            string factory_main = cmb_Factory_Main.SelectedValue.ToString();
            string lang_cd_main = cmb_LangCd_Main.SelectedValue.ToString();
            string project_main = ClassLib.ComFunction.Empty_Combo(cmb_Project_Main, " ");


            DataSet ds_ret_main = SELECT_SCM_MENU(factory_main, lang_cd_main, project_main);
            DataTable dt_project_main = ds_ret_main.Tables[0];
            DataTable dt_menu_main = ds_ret_main.Tables[1];



            if (arg_division == "Program")
            {
                fgrid_Program_Main.Display_Grid(dt_project_main, false);
            }
            else if (arg_division == "Menu")
            {
                Display_Grid_Main(fgrid_Menu_Main, dt_menu_main);
            }
            else
            {
                fgrid_Program_Main.Display_Grid(dt_project_main, false);
                Display_Grid_Main(fgrid_Menu_Main, dt_menu_main);
            }



            dt_project_main.Dispose();
            dt_menu_main.Dispose();
            ds_ret_main.Dispose();


        }



        /// <summary>
        /// Event_Tbtn_Save : 
        /// </summary>
        private void Event_Tbtn_Save()
        {


            bool save_flag_main = MyOraDB.Save_FlexGird("PKG_SCM_MENU.SAVE_SCM_MENU", fgrid_Menu_Main);



            if (!save_flag_main)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
            }
            else
            {
                Event_Tbtn_Search("Menu");
            }


        }





        #endregion

        #region 그리드 이벤트 메서드



        #region program 신규 추가



        // menu 이동
        private static bool _Flag_MenuMove;




        /// <summary>
        /// Event_fgrid_Program_Main_BeforeMouseDown : 
        /// </summary>
        private void Event_fgrid_Program_Main_BeforeMouseDown(C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
        {

            _Flag_MenuMove = false;



            // start dragging when the user clicks the row headers 
            HitTestInfo hti = fgrid_Program_Main.HitTest(e.X, e.Y);

            // select the row
            int index = hti.Row;

            if (index < fgrid_Program_Main.Rows.Fixed) return;


            //// set cursor and highlight node
            //// styles 


            //CellStyle cs = fgrid_Program.Styles.Add("SourceNode");
            //cs.BackColor = Color.Yellow;
            //cs.Font = new Font(fgrid_Program.Font, FontStyle.Bold);
            //fgrid_Program.SetCellStyle(index, fgrid_Program.Cols.Count - 1, cs);



            fgrid_Program_Main.Select(index, 0, index, fgrid_Program_Main.Cols.Count - 1, false);





            // do drag drop
            DragDropEffects dd = fgrid_Program_Main.DoDragDrop(fgrid_Program_Main.Clip, DragDropEffects.Move);




        }


        /// <summary>
        /// Event_fgrid_Menu_Main_DragOver : 
        /// </summary>
        private void Event_fgrid_Menu_Main_DragOver(DragEventArgs e)
        {

            // check that we have the type of data we want
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;



            }


        }


        /// <summary>
        /// Event_fgrid_Menu_Main_DragDrop : 
        /// </summary>
        private void Event_fgrid_Menu_Main_DragDrop(DragEventArgs e)
        {

            // find the drop position 
            Point pt = fgrid_Menu_Main.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = fgrid_Menu_Main.HitTest(pt.X, pt.Y);

            int index = hti.Row;              // after fixed row


            if (index == -1 || index > fgrid_Menu_Main.Rows.Count) return;

            // root 만 있을 경우는 program 바로 추가 할 수 없음
            if (fgrid_Menu_Main.Rows.Count == fgrid_Menu_Main.Rows.Fixed) return;  // + 1 : Root


            if (_Flag_MenuMove)
            {


            }
            // 프로그램 메뉴 생성
            else
            {

                C1.Win.C1FlexGrid.Node node = fgrid_Menu_Main.Rows[index].Node;


                int current_row = 0;


                if (fgrid_Menu_Main[index, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeProgram
                    || fgrid_Menu_Main[index, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSeparator)
                {

                    node.AddNode(NodeTypeEnum.NextSibling, "");

                    current_row = node.GetNode(NodeTypeEnum.NextSibling).Row.Index;

                }
                else
                {

                    node.AddNode(NodeTypeEnum.LastChild, "");

                    current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;


                }

                string menu_pg = fgrid_Program_Main[fgrid_Program_Main.Row, (int)ClassLib.TBSCM_DATA_DIC_MENU.IxPG_PROJ].ToString()
                       + "." + fgrid_Program_Main[fgrid_Program_Main.Row, (int)ClassLib.TBSCM_DATA_DIC_MENU.IxPG_ID].ToString();


                string menu_text = fgrid_Program_Main[fgrid_Program_Main.Row, (int)ClassLib.TBSCM_DATA_DIC_MENU.IxPG_TITLE].ToString();



                string next_menu_key = "";

                string factory = cmb_Factory_Main.SelectedValue.ToString();
                string lang_cd = cmb_LangCd_Main.SelectedValue.ToString();
                string menu_type = _TypeProgram;
                string upd_user = ClassLib.ComVar.This_User;


                DataTable dt_ret = SELECT_SCM_MENU_KEY(factory, lang_cd, menu_type, upd_user);

                if (dt_ret == null || dt_ret.Rows.Count == 0)
                {
                    next_menu_key = factory + lang_cd + menu_type + "00000";
                }
                else
                {
                    next_menu_key = dt_ret.Rows[0].ItemArray[0].ToString();
                }



                C1.Win.C1FlexGrid.Node parent_node = fgrid_Menu_Main.Rows[current_row].Node.GetNode(NodeTypeEnum.Parent);
                string parent_menu_key = fgrid_Menu_Main[parent_node.Row.Index, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_KEY].ToString();


                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION] = "I";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_LEVEL] = "";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxFACTORY] = cmb_Factory_Main.SelectedValue.ToString();
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxLANG_CD] = cmb_LangCd_Main.SelectedValue.ToString();
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_KEY] = next_menu_key;
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxPARENT_MENU_KEY] = parent_menu_key;
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE] = _TypeProgram;
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TEXT] = menu_text;
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_PG] = menu_pg;
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD] = "";

                fgrid_Menu_Main.GetCellRange(current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxUSE_YN,
                    current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_PRINT_YN).StyleNew.DataType = typeof(bool);

                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxUSE_YN] = "True";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_NONE_YN] = "False";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_ALL_YN] = "True";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_SEARCH_YN] = "True";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_SAVE_YN] = "True";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_PRINT_YN] = "True";

                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxPERSION_IN_CHARGE] = "";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxREMARKS] = "";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD_BEFORE] = "";
                fgrid_Menu_Main[current_row, (int)ClassLib.TBSCM_MENU_MAIN.IxUPD_USER] = "";




                //fgrid_Menu.TopRow = current_row;



            } // end if (_Flag_MenuMove)




            Set_MenuOrd();


        }


        #endregion

        #region menu 이동


        // to handle node dragging
        internal struct DRAG_INFO
        {
            public bool dragging;	// currently dragging
            public bool checkDrag;	// currently checking mouse to start dragging
            public int row;		// index of row being dragged
            public Point mouseDown;	// mouse down position
        }



        // drag and drop
        private DRAG_INFO _DragInfo;
        private const int _DragTol = 5;	// mouse movement before dragging starts



        /// <summary>
        /// Event_fgrid_Menu_Main_MouseDown : 
        /// </summary>
        private void Event_fgrid_Menu_Main_MouseDown(MouseEventArgs e)
        {



            _DragInfo.checkDrag = false;



            if (e.Button != MouseButtons.Left) return;
            if (_DragInfo.dragging) return;
            if (fgrid_Menu_Main.MouseRow <= fgrid_Menu_Main.Rows.Fixed) return;  // + 1 : root row



            // save current row and mouse position
            _DragInfo.row = fgrid_Menu_Main.Row;
            _DragInfo.mouseDown = new Point(e.X, e.Y);



            // start checking
            _DragInfo.checkDrag = true;







        }



        /// <summary>
        /// Event_fgrid_Menu_Main_MouseMove : 
        /// </summary>
        private void Event_fgrid_Menu_Main_MouseMove(MouseEventArgs e)
        {


            if (!_DragInfo.checkDrag || e.Button != MouseButtons.Left) return;
            if (Math.Abs(e.X - _DragInfo.mouseDown.X) + Math.Abs(e.Y - _DragInfo.mouseDown.Y) <= _DragTol) return;



            // update flags
            _DragInfo.dragging = true;




            //// set cursor and highlight node
            //// styles 

            //CellStyle cs = fgrid_Menu_Main.Styles.Add("SourceNode");
            //cs.BackColor = Color.Yellow;
            //cs.Font = new Font(fgrid_Menu_Main.Font, FontStyle.Bold);
            //fgrid_Menu_Main.Cursor = Cursors.NoMove2D;
            //fgrid_Menu_Main.SetCellStyle(_DragInfo.row, fgrid_Menu_Main.Selection.c1, cs);




            // check whether we can drop here
            Cursor c = (NoDropHere()) ? Cursors.No : Cursors.NoMove2D;
            if (c != fgrid_Menu_Main.Cursor) fgrid_Menu_Main.Cursor = c;



        }



        /// <summary>
        /// NoDropHere : 
        /// </summary>
        /// <returns></returns>
        private bool NoDropHere()
        {
            if (fgrid_Menu_Main.MouseRow < fgrid_Menu_Main.Rows.Fixed) return true;  // + 1 : root row
            if (fgrid_Menu_Main.MouseCol < fgrid_Menu_Main.Cols.Fixed) return true;
            return false;
        }



        /// <summary>
        /// Event_fgrid_Menu_Main_MouseUp : 
        /// </summary>
        private void Event_fgrid_Menu_Main_MouseUp(MouseEventArgs e)
        {


            // we're not checking until the mouse goes down again
            _DragInfo.checkDrag = false;



            // not dragging? we're done
            if (!_DragInfo.dragging) return;



            // stop dragging
            _DragInfo.dragging = false;

            //CellStyle cs = null;

            //fgrid_Menu_Main.SetCellStyle(_DragInfo.row, fgrid_Menu_Main.Selection.c1, cs);





            fgrid_Menu_Main.Cursor = Cursors.Default;

            // test whether the drop is allowed
            if (NoDropHere()) return;



            // move node into new parent node
            Node ndSrc = fgrid_Menu_Main.Rows[_DragInfo.row].Node;
            Node ndDst = fgrid_Menu_Main.Rows[fgrid_Menu_Main.Row].Node;


            //ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
            //ndSrc.Select();



            if (fgrid_Menu_Main[_DragInfo.row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeMenu)
            {


                if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeRoot)
                {

                    ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
                    ndSrc.Select();


                }
                else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeMenu)
                {

                    ndSrc.Move(NodeMoveEnum.Down);
                    ndSrc.Select();

                }


            }
            else if (fgrid_Menu_Main[_DragInfo.row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSubmenu)
            {


                if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeMenu)
                {

                    ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
                    ndSrc.Select();


                }
                else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSubmenu)
                {

                    ndSrc.Move(NodeMoveEnum.Down);
                    ndSrc.Select();

                }



            }
            else // program, separator
            {


                if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeMenu)
                {

                    ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
                    ndSrc.Select();


                }
                else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSubmenu)
                {

                    ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
                    ndSrc.Select();

                }
                else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeProgram
                || fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSeparator)
                {

                    ndSrc.Move(NodeMoveEnum.Down);
                    ndSrc.Select();

                }


            } // end if ndSrc type








            // 메뉴 순번 구성
            Set_MenuOrd();


        }




        #endregion

        #region update

        /// <summary>
        /// Event_fgrid_Menu_Main_BeforeEdit : 
        /// </summary>
        private void Event_fgrid_Menu_Main_BeforeEdit()
        {

            if ((fgrid_Menu_Main.Rows.Fixed > 0) && (fgrid_Menu_Main.Row >= fgrid_Menu_Main.Rows.Fixed))
            {
                if (fgrid_Menu_Main.Cols[fgrid_Menu_Main.Col].DataType == typeof(bool))
                {
                    fgrid_Menu_Main.Buffer_CellData = "";
                }
                else
                {
                    fgrid_Menu_Main.Buffer_CellData = (fgrid_Menu_Main[fgrid_Menu_Main.Row, fgrid_Menu_Main.Col] == null) ? "" : fgrid_Menu_Main[fgrid_Menu_Main.Row, fgrid_Menu_Main.Col].ToString();
                }
            }



            //CellStyle cs = fgrid_Menu_Main.Styles.Add("SelectionNode");
            //cs.BackColor = Color.FromKnownColor(KnownColor.Window);
            //fgrid_Menu_Main.SetCellStyle(fgrid_Menu_Main.Row, fgrid_Menu_Main.Col, cs);






        }



        /// <summary>
        /// Event_fgrid_Menu_Main_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Menu_Main_AfterEdit()
        {

            fgrid_Menu_Main.Update_Row();

            // 상위 버튼 권한 수정시, 하위 버튼 권한 일괄 수정
            Update_ButtonRole();


        }



        /// <summary>
        /// Update_ButtonRole : 상위 버튼 권한 수정시, 하위 버튼 권한 일괄 수정
        /// </summary>
        private void Update_ButtonRole()
        {

            int sel_row = fgrid_Menu_Main.Row;
            int sel_col = fgrid_Menu_Main.Col;


            if (sel_col < (int)ClassLib.TBSCM_MENU_MAIN.IxUSE_YN || sel_col > (int)ClassLib.TBSCM_MENU_MAIN.IxREMARKS) return;

            string new_yn = fgrid_Menu_Main[sel_row, sel_col].ToString();

            //하위 레벨 그룹 모두 처리 

            int current_row = sel_row;
            int child_row1 = sel_row;



            while (true)
            {
                C1.Win.C1FlexGrid.Node node = null;

                node = fgrid_Menu_Main.Rows[current_row].Node;


                if (node.Children == 0) break;

                current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

            } // end while

            int child_row2 = current_row;


            for (int i = child_row2; i >= child_row1; i--)
            {
                fgrid_Menu_Main[i, sel_col] = new_yn;

                if (fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION].ToString() != "I")
                {
                    fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION] = "U";
                }

            }




        }


        #endregion



        #endregion

        #region 버튼 및 기타 이벤트 메서드


        /// <summary>
        /// Event_cmb_Factory_Main_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_Main_SelectedValueChanged()
        {


            Event_Tbtn_New();


            if (cmb_Factory_Main.SelectedIndex == -1) return;



            // Language 코드
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory_Main.SelectedValue.ToString(), ClassLib.ComVar.CxLangCode); // "DA02"
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LangCd_Main, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_LangCd_Main.SelectedValue = ClassLib.ComVar.This_Lang;





        }


        /// <summary>
        /// Event_LangCd_Main_SelectedValueChanged : 
        /// </summary>
        private void Event_LangCd_Main_SelectedValueChanged()
        {


            Event_Tbtn_New();


            if (cmb_Factory_Main.SelectedIndex == -1 || cmb_LangCd_Main.SelectedIndex == -1) return;


            string factory = cmb_Factory_Main.SelectedValue.ToString();
            string lang_cd = cmb_LangCd_Main.SelectedValue.ToString();


            DataTable dt_ret = SELECT_SCM_DATA_DIC_PROJ(factory, lang_cd);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Project_Main, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name);

            if (dt_ret.Rows.Count > 0)
            {
                cmb_Project_Main.SelectedIndex = 0;  // ALL
            }
            else
            {
                cmb_Project_Main.SelectedIndex = -1;
            }



            dt_ret.Dispose();




            Event_Tbtn_Search("Menu");



        }


        /// <summary>
        /// Event_cmb_Project_Main_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Project_Main_SelectedValueChanged()
        {




            if (cmb_Factory_Main.SelectedIndex == -1 || cmb_LangCd_Main.SelectedIndex == -1 || cmb_Project_Main.SelectedIndex == -1) return;


            Event_Tbtn_Search("Program");




        }



        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드


        /// <summary>
        /// Event_cmenu_Main_Opening : 
        /// </summary>
        private void Event_cmenu_Main_Opening()
        {

            // root 만 있을 경우 
            if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeRoot)
            {
                menuItem_Add_Menu.Enabled = true;
                menuItem_Add_Submenu.Enabled = false;
                menuItem_Add_Separator.Enabled = false;
                menuItem_Delete.Enabled = false;

            }
            else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeMenu)
            {
                menuItem_Add_Menu.Enabled = true;
                menuItem_Add_Submenu.Enabled = true;
                menuItem_Add_Separator.Enabled = true;
                menuItem_Delete.Enabled = true;
            }
            else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSubmenu)
            {
                menuItem_Add_Menu.Enabled = false;
                menuItem_Add_Submenu.Enabled = true;
                menuItem_Add_Separator.Enabled = true;
                menuItem_Delete.Enabled = true;
            }
            else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeProgram)
            {
                menuItem_Add_Menu.Enabled = false;
                menuItem_Add_Submenu.Enabled = false;
                menuItem_Add_Separator.Enabled = true;
                menuItem_Delete.Enabled = true;
            }
            else if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeSeparator)
            {
                menuItem_Add_Menu.Enabled = false;
                menuItem_Add_Submenu.Enabled = false;
                menuItem_Add_Separator.Enabled = false;
                menuItem_Delete.Enabled = true;
            }



        }


        /// <summary>
        /// Event_menuItem_Add_Menu_Click : 
        /// </summary>
        private void Event_menuItem_Add_Menu_Click()
        {


            if (cmb_Factory_Main.SelectedIndex == -1 || cmb_LangCd_Main.SelectedIndex == -1) return;



            C1.Win.C1FlexGrid.Node node = fgrid_Menu_Main.Rows[fgrid_Menu_Main.Row].Node;



            int current_row = -1;

            if (fgrid_Menu_Main[fgrid_Menu_Main.Row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE].ToString() == _TypeMenu)
            {

                node.AddNode(NodeTypeEnum.LastSibling, "");
                current_row = node.GetNode(NodeTypeEnum.LastSibling).Row.Index;
            }
            else
            {

                node.AddNode(NodeTypeEnum.LastChild, "");
                current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
            }


            string menu_type = _TypeMenu;

            string next_menu_key = "";

            Set_NewData(current_row, next_menu_key, menu_type);


        }


        /// <summary>
        /// menuItem_Add_Submenu_Click : 
        /// </summary>
        private void Event_menuItem_Add_Submenu_Click()
        {


            if (cmb_Factory_Main.SelectedIndex == -1 || cmb_LangCd_Main.SelectedIndex == -1) return;



            C1.Win.C1FlexGrid.Node node = fgrid_Menu_Main.Rows[fgrid_Menu_Main.Row].Node;

            int current_row = -1;



            node.AddNode(NodeTypeEnum.LastChild, "");
            current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;


            string menu_type = _TypeSubmenu;

            string next_menu_key = "";

            Set_NewData(current_row, next_menu_key, menu_type);


        }


        /// <summary>
        /// Event_menuItem_Add_Separator_Click : 
        /// </summary>
        private void Event_menuItem_Add_Separator_Click()
        {


            C1.Win.C1FlexGrid.Node node = fgrid_Menu_Main.Rows[fgrid_Menu_Main.Row].Node;

            int current_row = -1;


            node.AddNode(NodeTypeEnum.NextSibling, "");
            current_row = node.GetNode(NodeTypeEnum.NextSibling).Row.Index;

            string menu_type = _TypeSeparator;

            string next_menu_key = "";

            Set_NewData(current_row, next_menu_key, menu_type);



        }


        /// <summary>
        /// Event_menuItem_Delete_Click : 
        /// </summary>
        private void Event_menuItem_Delete_Click()
        {

            //하위 레벨 그룹 모두 처리

            int current_row = fgrid_Menu_Main.Row;
            int child_row1 = fgrid_Menu_Main.Row;



            while (true)
            {
                C1.Win.C1FlexGrid.Node node = null;

                node = fgrid_Menu_Main.Rows[current_row].Node;


                if (node.Children == 0) break;

                current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

            } // end while

            int child_row2 = current_row;


            for (int i = child_row2; i >= child_row1; i--)
            {
                if (fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION].ToString() == "I")
                {
                    fgrid_Menu_Main.Rows.Remove(i);
                }
                else
                {
                    fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION] = "D";
                }

            }


        }



        /// <summary>
        /// Set_NewData : 그리드에 기본값 세팅
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_level"></param>
        /// <param name="arg_menukey"></param>
        /// <param name="arg_menutype"></param>
        private void Set_NewData(int arg_row, string arg_menukey, string arg_menutype)
        {




            string factory = cmb_Factory_Main.SelectedValue.ToString();
            string lang_cd = cmb_LangCd_Main.SelectedValue.ToString();
            string menu_type = arg_menutype;
            string upd_user = ClassLib.ComVar.This_User;


            DataTable dt_ret = SELECT_SCM_MENU_KEY(factory, lang_cd, menu_type, upd_user);

            if (dt_ret == null || dt_ret.Rows.Count == 0)
            {
                arg_menukey = factory + lang_cd + menu_type + "00000";
            }
            else
            {
                arg_menukey = dt_ret.Rows[0].ItemArray[0].ToString();
            }






            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION] = "I";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_LEVEL] = "";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxFACTORY] = cmb_Factory_Main.SelectedValue.ToString();
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxLANG_CD] = cmb_LangCd_Main.SelectedValue.ToString();


            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_KEY] = arg_menukey;


            C1.Win.C1FlexGrid.Node node = fgrid_Menu_Main.Rows[arg_row].Node.GetNode(NodeTypeEnum.Parent);
            string parent_menu_key = fgrid_Menu_Main[node.Row.Index, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_KEY].ToString();
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxPARENT_MENU_KEY] = parent_menu_key;


            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TYPE] = arg_menutype;

            if (arg_menutype == _TypeSeparator)
            {
                fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TEXT] = "-";
            }
            else
            {
                fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_TEXT] = "";
            }






            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_PG] = "";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD] = "";

            fgrid_Menu_Main.GetCellRange(arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxUSE_YN,
                                        arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_PRINT_YN).StyleNew.DataType = typeof(bool);

            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxUSE_YN] = "True";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_NONE_YN] = "False";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_ALL_YN] = "True";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_SEARCH_YN] = "True";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_SAVE_YN] = "True";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxTB_PRINT_YN] = "True";

            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxPERSION_IN_CHARGE] = "";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxREMARKS] = "";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD_BEFORE] = "";
            fgrid_Menu_Main[arg_row, (int)ClassLib.TBSCM_MENU_MAIN.IxUPD_USER] = "";



            // 메뉴 순번 구성
            Set_MenuOrd();

            fgrid_Menu_Main.TopRow = arg_row;

        }



        /// <summary>
        /// Set_MenuOrd : 메뉴 순번 구성
        /// </summary>
        private void Set_MenuOrd()
        {


            int node_ct = 1;


            fgrid_Menu_Main[fgrid_Menu_Main.Rows.Fixed, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD] = _RootMenuKey.ToString();


            for (int i = fgrid_Menu_Main.Rows.Fixed + 1; i < fgrid_Menu_Main.Rows.Count; i++)
            {


                fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD] = node_ct.ToString();
                node_ct++;


                // menu 순서 변화 없으면 업데이트 하지 않음
                if (fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD].ToString()
                    != fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxMENU_ORD_BEFORE].ToString())
                {

                    if (fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION].ToString() == "I") continue;

                    fgrid_Menu_Main[i, (int)ClassLib.TBSCM_MENU_MAIN.IxDIVISION] = "U";

                }




            } // end for i


        }



        #endregion



        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트


        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
                Event_Tbtn_Search("");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }




        #endregion

        #region 그리드 이벤트


        private void fgrid_Program_Main_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Program_Main_BeforeMouseDown(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Program_Main_BeforeMouseDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        

        private void fgrid_Menu_Main_DragOver(object sender, DragEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_DragOver(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_DragOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_Menu_Main_DragDrop(object sender, DragEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_DragDrop(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_DragDrop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_Menu_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_Menu_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void fgrid_Menu_Main_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_MouseDown(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_MouseDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        private void fgrid_Menu_Main_MouseMove(object sender, MouseEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_MouseMove(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_MouseMove", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void fgrid_Menu_Main_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_fgrid_Menu_Main_MouseUp(e);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Menu_Main_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }



        #endregion

        #region 버튼 및 기타 이벤트


        #region 버튼클릭시 이미지변경


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }




        #endregion


        private void Form_EIS_Menu_Main_Load(object sender, EventArgs e)
        {
            Init_Form();
        }


        private void cmb_Factory_Main_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Factory_Main_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_Main_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_LangCd_Main_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_LangCd_Main_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_LangCd_Main_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void cmb_Project_Main_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Project_Main_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Project_Main_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #region 컨텍스트 메뉴 이벤트


        private void cmenu_Main_Opening(object sender, CancelEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmenu_Main_Opening();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmenu_Main_Opening", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void menuItem_Add_Menu_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_Add_Menu_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_Add_Menu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void menuItem_Add_Submenu_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_Add_Submenu_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_Add_Submenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void menuItem_Add_Separator_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_Add_Separator_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_Add_Separator_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void menuItem_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_menuItem_Delete_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }






        #endregion

        #endregion

        #region 디비 연결


        #region 콤보


        /// <summary>
        /// SELECT_SCM_DATA_DIC_PROJ : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SCM_DATA_DIC_PROJ(string arg_factory, string arg_lang_cd)
        {

            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_DATA_DIC_PROJ";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
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




        #endregion

        #region 조회


        /// <summary>
        /// SELECT_SCM_MENU_KEY : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <param name="arg_menu_type"></param>
        /// <param name="arg_upd_user"></param>
        /// <returns></returns>
        private DataTable SELECT_SCM_MENU_KEY(string arg_factory,
            string arg_lang_cd,
            string arg_menu_type,
            string arg_upd_user)
        {

            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_MENU_KEY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MENU_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";




                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;




                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = arg_menu_type;
                MyOraDB.Parameter_Values[3] = arg_upd_user;
                MyOraDB.Parameter_Values[4] = "";




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
        /// SELECT_SCM_MENU : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <param name="arg_project"></param>
        /// <returns></returns>
        private DataSet SELECT_SCM_MENU(string arg_factory, string arg_lang_cd, string arg_project)
        {

            try
            {


                #region scm_data_dic 에서 program list 조회



                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_DATA_DIC_PROGRAM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "ARG_PG_PROJ";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = arg_project;
                MyOraDB.Parameter_Values[3] = "";



                MyOraDB.Add_Select_Parameter(true);



                #endregion

                #region scm_menu 에서 menu list 조회


                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SCM_MENU.SELECT_SCM_MENU";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = "";



                MyOraDB.Add_Select_Parameter(false);


                #endregion


                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;


            }
            catch
            {
                return null;
            }


        }






        #endregion

      


        #endregion

    }
}