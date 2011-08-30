using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;

namespace FlexCDC.CDC_Bom
{
    public partial class Form_Korea_Material_List : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수 
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        private COM.OraDB MyOraDB = new COM.OraDB();
        #endregion

        public Form_Korea_Material_List()
        {
            InitializeComponent();
        }
        
        private void Form_Korea_Material_List_Load(object sender, EventArgs e)
        {
            try
            {
                //factory 
                DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_list, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = "DS";
                cmb_factory.Enabled = false;
            }
            catch
            {

            }		
        }
        
        #region 공통 메서드
        private void Init_Form()
        {
            this.Text = "PCC_Material List In Korea";
            this.lbl_MainTitle.Text = "PCC_Material List In Korea";
            ClassLib.ComFunction.SetLangDic(this);

            //Search_Type();
            //control_setting();

            #region ComboBox Setting
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, 0, 120);
            cmb_pur_div.SelectedIndex = 0;

            dt_ret = Select_round();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 2, true, 0, 120);
            cmb_round.SelectedIndex = 0;

            dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
            cmb_category.SelectedIndex = 0;

            dt_ret = Select_season();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
            cmb_season.SelectedIndex = 0;

            dt_ret = Select_loaduser();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 120);                
            cmb_user.SelectedIndex = 0;
            
            #endregion

            #region Grid Setting
            fgrid_main.Set_Grid_CDC("SXD_MATERIAL_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            //fgrid_main.ExtendLastCol = false;
            fgrid_main.Tree.Column = (int)ClassLib.TBSXD_MATERIAL_LIST.IxITEM_01;	
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
            #endregion

            #region Button Setting 
            tbtn_New.Enabled     = false;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Insert.Enabled  = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Print.Enabled   = false;
            tbtn_Append.Enabled  = false;
            tbtn_Create.Enabled  = false;

            tbtn_Search.Enabled  = true;
            #endregion 

            #region TextBox Setting
            txt_bom_id.CharacterCasing   = CharacterCasing.Upper;
            txt_material.CharacterCasing = CharacterCasing.Upper;
            txt_model.CharacterCasing    = CharacterCasing.Upper;
            txt_sr_no.CharacterCasing    = CharacterCasing.Upper;
            txt_srf_no.CharacterCasing   = CharacterCasing.Upper;

            txt_material.Focus();
            #endregion
        }  
        private void Open_waiting_Form()
        {
            _pop = new FlexCDC.BaseInfo.Pop_BS_Shipping_List_Wait();
            _pop.Searching_Start();
        }
        #endregion 

        #region 이벤트 처리
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                #region 조회조건
                string arg_factory   = cmb_factory.SelectedValue.ToString();
                string arg_category  = cmb_category.SelectedValue.ToString();
                string arg_season    = cmb_season.SelectedValue.ToString();
                string arg_sr_no     = txt_sr_no.Text.Trim();
                string arg_srf_no    = txt_srf_no.Text.Trim();
                string arg_bom_id    = txt_bom_id.Text.Trim();
                string arg_nf_cd     = cmb_round.SelectedValue.ToString();                
                string arg_model     = txt_model.Text.Trim();
                string arg_load_user = cmb_user.SelectedValue.ToString();
                string arg_pur_div   = cmb_pur_div.SelectedValue.ToString();
                string arg_mat_name  = txt_material.Text.Trim();
                #endregion

                #region Connect DS
                Thread vCreate = new Thread(new ThreadStart(Open_waiting_Form));
                vCreate.Start();                
                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

                DataTable dt = Select_material_list(arg_factory, arg_category, arg_season, arg_sr_no, arg_srf_no, arg_bom_id, arg_nf_cd, arg_model, arg_load_user, arg_pur_div, arg_mat_name);
                
                if (COM.ComVar.This_Factory == "VJ")
                    COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                if (COM.ComVar.This_Factory == "QD")
                    COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                #endregion

                bool first_flg = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string div      = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_MATERIAL_LIST.IxPUR_DIV].ToString();
                    string div_prev = (first_flg)?div : dt.Rows[i - 1].ItemArray[(int)ClassLib.TBSXD_MATERIAL_LIST.IxPUR_DIV].ToString();
                    string div_name = (div == "11") ? "Korea" : "Local";
                    if (div == "21")
                        div_name = "Import";

                    if (div != div_prev || first_flg)
                    {
                        fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, 1);

                        fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXD_MATERIAL_LIST.IxITEM_01] = div_name;
                        fgrid_main.Rows[fgrid_main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        fgrid_main.Rows[fgrid_main.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                        first_flg = false;
                    }
                    int tree_level = int.Parse(dt.Rows[i].ItemArray[1].ToString()) + 1;
                    fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, tree_level);	

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();
                    }

                    if (tree_level == 2)
                    {
                        fgrid_main.Rows[fgrid_main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        fgrid_main.Rows[fgrid_main.Rows.Count - 1].StyleNew.ForeColor = Color.Blue;
                    }
                    else if(tree_level == 3)
                    {
                        fgrid_main.Rows[fgrid_main.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                        fgrid_main.Rows[fgrid_main.Rows.Count - 1].StyleNew.ForeColor = Color.Black;
                    }
                }
                fgrid_main.Tree.Show(2);                
                vCreate.Abort();

                this.Cursor = Cursors.Default; 
            }
            catch
            {
                this.Cursor = Cursors.Default; 
            }
        }
        
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_Form();
            }
            catch
            {

            }

        }
                        
        private void mnu_pur_div_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(1);
        }
        private void mnu_material_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(2);
        }
        private void mnu_bom_Click(object sender, EventArgs e)
        {
            fgrid_main.Tree.Show(3);
        }
        #endregion

        #region DB Connect
        private DataTable Select_round()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "pkg_sxd_srf_00_select.select_sxb_nf_desc";

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_season()
        {
            MyOraDB.ReDim_Parameter(2); 

            MyOraDB.Process_Name = "pkg_sxd_order_01.select_season";                   

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_loaduser()
        {          

            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "pkg_sxd_srf_01_select.select_sxd_srf_loaduser";

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_material_list(string arg_factory, string arg_category, string arg_season, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_nf_cd, string arg_model, string arg_load_user, string arg_pur_div, string arg_mat_name)
        {
            MyOraDB.ReDim_Parameter(12);

            MyOraDB.Process_Name = "pkg_sxd_srf_02_select.select_material_list";

            
            MyOraDB.Parameter_Name[0]  = "arg_factory";
            MyOraDB.Parameter_Name[1]  = "arg_category";
            MyOraDB.Parameter_Name[2]  = "arg_season";
            MyOraDB.Parameter_Name[3]  = "arg_sr_no";
            MyOraDB.Parameter_Name[4]  = "arg_srf_no";
            MyOraDB.Parameter_Name[5]  = "arg_bom_id";
            MyOraDB.Parameter_Name[6]  = "arg_nf_cd";            
            MyOraDB.Parameter_Name[7]  = "arg_model";
            MyOraDB.Parameter_Name[8]  = "arg_load_user";
            MyOraDB.Parameter_Name[9]  = "arg_pur_div";
            MyOraDB.Parameter_Name[10] = "arg_mat_name";
            MyOraDB.Parameter_Name[11] = "out_cursor";

            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0]  = arg_factory;
            MyOraDB.Parameter_Values[1]  = arg_category;
            MyOraDB.Parameter_Values[2]  = arg_season;
            MyOraDB.Parameter_Values[3]  = arg_sr_no;
            MyOraDB.Parameter_Values[4]  = arg_srf_no;
            MyOraDB.Parameter_Values[5]  = arg_bom_id;
            MyOraDB.Parameter_Values[6]  = arg_nf_cd;
            MyOraDB.Parameter_Values[7]  = arg_model;
            MyOraDB.Parameter_Values[8]  = arg_load_user;
            MyOraDB.Parameter_Values[9]  = arg_pur_div;
            MyOraDB.Parameter_Values[10] = arg_mat_name;
            MyOraDB.Parameter_Values[11] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name]; 
        }
        #endregion  
        
    }
}

