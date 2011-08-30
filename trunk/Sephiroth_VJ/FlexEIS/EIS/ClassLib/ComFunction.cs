using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid; 

namespace FlexEIS.ClassLib
{
	/// <summary>
	/// ComFuntion에 대한 요약 설명입니다.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{

		}


        #region EIS Default Factory 설정 : Webservice URL 이용



        /// <summary>
        /// Set_Default_Factory : EIS Default Factory 설정 : Webservice URL 이용
        /// </summary>
        /// <returns></returns>
        public static string Set_Default_Factory()
        {


            string webservice_url = COM.ComVar._WebSvc.Url;
            string return_factory = COM.ComVar.DSFactory;
            string this_factory = COM.ComVar.This_Factory;



            if (webservice_url == COM.ComVar.DS_WebSvc_Url)
            {
                return_factory = COM.ComVar.ConsFactoryVJ;
            }
            else if (webservice_url == COM.ComVar.QD_WebSvc_Url)
            {
                return_factory = COM.ComVar.ConsFactoryQD;
            }
            else if (webservice_url == COM.ComVar.VJ_WebSvc_Url)
            {
                return_factory = COM.ComVar.ConsFactoryVJ;
            }
            else if (webservice_url == COM.ComVar.JJ_WebSvc_Url)
            {
                return_factory = COM.ComVar.ConsFactoryJJ;
            }



            return return_factory;





        }



        #endregion

        #region [Window] menuitem 추가

        /// <summary>
        /// Delete_Window_Menu : 
        /// </summary>
        /// <param name="arg_menupg"></param> 
        public static void Add_Window_Menu(string arg_menutext, string arg_menupg, bool arg_existyn)
        {


            string menu_key = "";
            string parent_menu_key = "-1";
            //string role_id = "EIS_WINDOW";
            string window_text = "WINDOW";

            COM.MyItem parent_Menuitem = null;


            foreach (COM.MyItem item in COM.ComVar.MDI_Parent.Menu.MenuItems)
            {
                //if(item._RoleID == role_id)
                //{
                //    parent_Menuitem = item;

                //    break;

                //}

                if (item._MenuText.ToUpper().Trim() == window_text.ToUpper().Trim())
                {
                    parent_Menuitem = item;

                    break;

                }



            } // end foreach





            if (!arg_existyn)   // 신규
            {

                COM.MyItem menuitem = new COM.MyItem(menu_key, parent_menu_key, arg_menutext, arg_menupg, "");



                parent_Menuitem.MenuItems.Add(menuitem);

                menuitem.Click += new EventHandler(Menu_Click);

                foreach (COM.MyItem child_item in parent_Menuitem.MenuItems)
                {
                    child_item.Checked = false;
                }

                menuitem.Checked = true;




            }
            else
            {


                foreach (COM.MyItem child_item in parent_Menuitem.MenuItems)
                {
                    if (child_item._MenuPG == arg_menupg)
                    {
                        child_item.Checked = true;
                    }
                    else
                    {
                        child_item.Checked = false;
                    }

                }




            } // end if (!arg_existyn)



        }


        /// <summary>
        ///  해당 메뉴를 클릭시 폼 활성화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Menu_Click(object sender, EventArgs e)
        {

            COM.MyItem sel_menu = (COM.MyItem)sender;

            string menu_pg = sel_menu._MenuPG;

            OpenFormByName(menu_pg);


        }


        #endregion

        #region [Window] menuitem 삭제

        /// <summary>
        /// Delete_Window_Menu : 
        /// </summary>
        /// <param name="arg_menupg"></param> 
        public static void Delete_Window_Menu(System.Windows.Forms.Form arg_parent_form, string arg_menupg)
        {


            string window_text = "WINDOW";

            COM.MyItem parent_Menuitem = null;


            if (arg_parent_form == null) return;


            // parent menuitem 찾기
            foreach (MenuItem item in arg_parent_form.Menu.MenuItems)
            {
                COM.MyItem myitem = (COM.MyItem)item;

                //if(myitem._RoleID == role_id)
                //{
                //    parent_Menuitem = myitem;

                //    break;

                //}


                if (myitem._MenuText.ToUpper().Trim() == window_text.ToUpper().Trim())
                {
                    parent_Menuitem = myitem;

                    break;

                }


            } // end foreach




            // 닫혀진 창에 대한 menuitem 삭제 처리
            foreach (COM.MyItem child_item in parent_Menuitem.MenuItems)
            {
                if (child_item._MenuPG == arg_menupg)
                {
                    parent_Menuitem.MenuItems.Remove(child_item);

                    break;
                }

            }



            ////			// 삭제 된 후 다음 활성화된 창에 대한 menuitem 체크 처리
            //
            ////			string active_menupg = arg_parent_form.ActiveMdiChild.GetType().ToString();
            ////
            ////			foreach(COM.MyItem child_item in parent_Menuitem.MenuItems)
            ////			{
            ////				if(child_item._MenuPG == active_menupg)
            ////				{
            ////					child_item.Checked = true;  
            ////				} 
            ////				else
            ////				{
            ////					child_item.Checked = false; 
            ////				}
            ////
            ////			}


            //			foreach(COM.MyItem child_item in parent_Menuitem.MenuItems)
            //			{
            //				child_item.Checked = false;  
            //			} 
            //
            //
            //			if(parent_Menuitem.MenuItems.Count == 0) return;
            //			parent_Menuitem.MenuItems[parent_Menuitem.MenuItems.Count - 1].Checked = true;
            // 


        }


        #endregion

        #region Open menuitem


        public static void OpenFormByName(string arg_menu_pg)
        {

            // 네임스페이스.폼명으로 폼 객체 생성
            string[] token = arg_menu_pg.Split('.');
            string project = token[0];

            Assembly asm = Assembly.Load(project);

            Type t = asm.GetType(arg_menu_pg);

            // 중복 체크
            bool exist_yn = false;
            Form exist_form = null;
            string menu_text = "";
            string menu_pg = "";


            foreach (Form f in COM.ComVar.MDI_Parent.MdiChildren)
            {
                // 중복
                if (f.GetType().Equals(t))
                {
                    exist_yn = true;
                    exist_form = f;
                    break;
                }

            } // end foreach  


            //if (exist_yn)
            //{

            //    exist_form.Activate();

            //    menu_text = "";
            //    menu_pg = exist_form.GetType().ToString();

            //}
            //else
            //{

            //    Form frm = (Form)Activator.CreateInstance(t);


            //    frm.MdiParent = COM.ComVar.MDI_Parent;
            //    frm.Show();


            //    //if (frm.WindowState.Equals(System.Windows.Forms.FormWindowState.Normal))
            //    //{
            //    //    frm.WindowState = FormWindowState.Normal;
            //    //}


            //    menu_text = frm.Text.ToString();
            //    menu_pg = frm.GetType().ToString();

            //}



            if (exist_yn)
            {
                exist_form.Close();
                exist_yn = false;
            }


            Form frm = (Form)Activator.CreateInstance(t);

            frm.MdiParent = COM.ComVar.MDI_Parent;
            frm.Show();

            menu_text = frm.Text.ToString();
            menu_pg = frm.GetType().ToString();



            Add_Window_Menu(menu_text, menu_pg, exist_yn);


        }


        #endregion 


        #region 컬럼 5개 콤보리스트 세팅


        /// <summary>
        /// Set_ComboList_5 : 5개짜리 콤보리스트 -> 채산에서 스타일 콤보 세팅
        /// </summary> 
        public static void Set_ComboList_5(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb,
            int arg_1_pos, int arg_2_pos, int arg_3_pos, int arg_4_pos, int arg_5_pos,
            bool arg_emptyrow, int arg_1_width, int arg_2_width)
        {
            DataSet temp_dataset = new System.Data.DataSet();
            DataTable temp_datatable;
            DataRow newrow;

            temp_datatable = temp_dataset.Tables.Add("Combo List");
            temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("Gender", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("Presto", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("ModelName", Type.GetType("System.String")));


            if (arg_emptyrow)
            {
                newrow = temp_datatable.NewRow();
                newrow[0] = " ";
                newrow[1] = " ";
                newrow[2] = " ";
                newrow[3] = " ";
                newrow[4] = " ";
                temp_datatable.Rows.Add(newrow);
            }


            for (int i = 0; i < dtcmb_list.Rows.Count; i++)
            {
                newrow = temp_datatable.NewRow();
                newrow[0] = dtcmb_list.Rows[i].ItemArray[arg_1_pos];
                newrow[1] = dtcmb_list.Rows[i].ItemArray[arg_2_pos];
                newrow[2] = dtcmb_list.Rows[i].ItemArray[arg_3_pos];
                newrow[3] = dtcmb_list.Rows[i].ItemArray[arg_4_pos];
                newrow[4] = dtcmb_list.Rows[i].ItemArray[arg_5_pos];
                temp_datatable.Rows.Add(newrow);
            }



            arg_cmb.DataSource = temp_datatable;

            arg_cmb.ValueMember = "Code";
            arg_cmb.DisplayMember = "Name";

            arg_cmb.SelectedIndex = -1;

            arg_cmb.MaxDropDownItems = 10;

            int dropdownwidth = arg_1_width + arg_2_width;
            if (arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width;
            arg_cmb.DropDownWidth = dropdownwidth;

            arg_cmb.Splits[0].DisplayColumns["Code"].Width = arg_1_width;
            arg_cmb.Splits[0].DisplayColumns["Name"].Width = arg_2_width - 25;
            arg_cmb.Splits[0].DisplayColumns[2].Visible = false;
            arg_cmb.Splits[0].DisplayColumns[3].Visible = false;
            arg_cmb.Splits[0].DisplayColumns[4].Visible = false;

            arg_cmb.ExtendRightColumn = true;
            arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

        }




        #endregion

        #region 공통쿼리 (Material price factory, month, season, model, style)



        /// <summary>
        /// SELECT_MATPRICE_COMBO_FACTORY : 
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_MATPRICE_COMBO_FACTORY()
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(1);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EFI_BEP_SIMULATION.SELECT_FACTORY_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = "";


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
        /// SELECT_MATPRICE_COMBO_MONTH : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_poweruser_yn"></param>
        /// <returns></returns>
        public static DataTable SELECT_MATPRICE_COMBO_MONTH(string arg_factory, string arg_poweruser_yn)
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH.SELECT_COMBO_MONTH";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_POWERUSER_YN";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_poweruser_yn;
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

        #region 공통 쿼리 (Production Line, Op list)



        /// <summary>
        /// SELECT_PRODUCT_LINE_INFO : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_line_group"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns>
        public static DataTable SELECT_PRODUCT_LINE_INFO(string arg_factory, string arg_line_group, string arg_division)
        {

            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_PRODUCT_LINE_INFO";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LINE_GROUP";
                MyOraDB.Parameter_Name[2] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_line_group;
                MyOraDB.Parameter_Values[2] = arg_division;
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
        /// SELECT_PRODUCT_OPCD_INFO : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_op_group"></param>
        /// <param name="arg_cmp_cd"></param>
        /// <param name="arg_division"></param>
        /// <returns></returns>
        public static DataTable SELECT_PRODUCT_OPCD_INFO(string arg_factory, string arg_op_group, string arg_cmp_cd, string arg_division)
        {

            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_PRODUCT_OPCD_INFO";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OP_GROUP";
                MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
                MyOraDB.Parameter_Name[3] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_op_group;
                MyOraDB.Parameter_Values[2] = arg_cmp_cd;
                MyOraDB.Parameter_Values[3] = arg_division;
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




        #endregion

        #region 공통 쿼리 (item, item group list)


        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupTypeCode()
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "SEPHIROTH.PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TYPE";

            oraDB.ReDim_Parameter(1);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupLCode(string arg_group_type)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_L";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_group_type;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }




        #endregion

        #region Last update



        /// <summary>
        /// Display_LastUpdateDate : Last update 조회
        /// </summary>
        public static string Display_LastUpdateDate(string arg_table_string, string arg_where_string)
        {


            DataTable dt_ret = null;


            if (arg_where_string.Trim().Equals(""))
            {
                dt_ret = ClassLib.ComFunction.Select_LastUpdate_Date(arg_table_string);
            }
            else
            {
                dt_ret = ClassLib.ComFunction.Select_LastUpdate_Date(arg_table_string, arg_where_string);
            }



            if (dt_ret == null || dt_ret.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt_ret.Rows[0].ItemArray[0].ToString();
            }


        }



        /// <summary>
        /// Select_LastUpdate_Date : Last update 조회
        /// </summary>
        /// <param name="arg_table_string"></param>
        /// <returns></returns>
        public static DataTable Select_LastUpdate_Date(string arg_table_string)
        {

            try
            {

                COM.OraDB oraDB = new COM.OraDB();

                oraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                oraDB.Process_Name = "PKG_ECM_COMMON.SELECT_LAST_UPDATE_DATE";

                //02.ARGURMENT 명
                oraDB.Parameter_Name[0] = "ARG_TABLE_STRING";
                oraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                oraDB.Parameter_Values[0] = arg_table_string;
                oraDB.Parameter_Values[1] = "";

                oraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = oraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;
                return DS_Ret.Tables[oraDB.Process_Name];

            }
            catch
            {
                return null;
            }


        }




        /// <summary>
        /// Select_LastUpdate_Date : Last update 조회
        /// </summary>
        /// <param name="arg_table_string"></param>
        /// <param name="arg_where_string"></param>
        /// <returns></returns>
        public static DataTable Select_LastUpdate_Date(string arg_table_string, string arg_where_string)
        {

            try
            {

                COM.OraDB oraDB = new COM.OraDB();

                oraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                oraDB.Process_Name = "PKG_ECM_COMMON.SELECT_LAST_UPDATE_DATE";

                //02.ARGURMENT 명
                oraDB.Parameter_Name[0] = "ARG_TABLE_STRING";
                oraDB.Parameter_Name[1] = "ARG_WHERE_STRING";
                oraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                oraDB.Parameter_Values[0] = arg_table_string;
                oraDB.Parameter_Values[1] = arg_where_string;
                oraDB.Parameter_Values[2] = "";

                oraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = oraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;
                return DS_Ret.Tables[oraDB.Process_Name];

            }
            catch
            {
                return null;
            }


        }




        #endregion

        #region 필수 항목 체크


        public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt)
        {
            if (arg_cmb != null)
            {
                for (int i = 0; i < arg_cmb.Length; i++)
                {
                    if (arg_cmb[i].SelectedIndex < 0)
                    {
                        ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        arg_cmb[i].Focus();
                        return false;
                    }
                }
            }
            if (arg_txt != null)
            {
                for (int i = 0; i < arg_txt.Length; i++)
                {
                    if (arg_txt[i].Text == "")
                    {
                        ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        arg_txt[i].Focus();
                        return false;
                    }
                }
            }
            return true;
        }


        #endregion


    }
}
