using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;

namespace FlexCDC.Product
{
    public partial class Form_Product_Manager : COM.PCHWinForm.Form_Top
    {
        public Form_Product_Manager()
        {
            InitializeComponent();
        }

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성        
        #endregion

        #region Form Loading
        private void Form_Product_Manager_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_factory = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_factory, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {
            }
        }        
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cmb_factory.SelectedIndex == -1)
                    return;


                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_form();

                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Init_form()
        {
            //1. Title Setting
            this.Text = "PCC_Production Manager";
            this.lbl_MainTitle.Text = "PCC_Production Manager";
            ClassLib.ComFunction.SetLangDic(this);            

            #region 2. ComboBox Setting
            //Category
            DataTable dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
            cmb_category.SelectedIndex = 0;

            //Season
            dt_ret = Select_season();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
            cmb_season.SelectedIndex = 0;

            //Round
            dt_ret = Select_round();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 120);
            cmb_round.SelectedIndex = 0;

            //op cd
            dt_ret = Select_op_cd();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_opcd, 0, 1, false, 0, 120);
            cmb_opcd.SelectedValue = "FGA";

            //Dev User
            dt_ret = Select_user();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 120);
            cmb_user.SelectedIndex = 0;           

            dt_ret = Select_max_date();
            string max_date = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
            DateTime date = new DateTime(int.Parse(max_date.Substring(0, 4)), int.Parse(max_date.Substring(4, 2)), int.Parse(max_date.Substring(6, 2)));

            dtp_to.Value = date.AddMonths(1);
            dtp_from.Value = date.AddMonths(-1);

            dt_ret.Dispose();
            #endregion  

            //3. tbtn Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            //4. Grid Setting            
            fgrid_product.Set_Grid_CDC("SXG_PROD_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_product.Set_Action_Image(img_Action);
            fgrid_product.Rows.Count = fgrid_product.Rows.Fixed;
            fgrid_product.ExtendLastCol = false;
            fgrid_product.Tree.Column = (int)ClassLib.TBSXG_PROD_MANAGER.IxCOL_02;
            //fgrid_product.Font = new Font("Verdana", 11 , FontStyle.Regular);            
        }

        #region DB Connect
        private DataTable Select_season()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_order_01.select_season";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_round()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_01_select.select_sample_types";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_op_cd()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_02_select.select_op_cd";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_user()
        {            
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_srf_01_select.select_sxd_srf_loaduser";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_max_date()
        {
            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_02_select.get_sxg_max_date";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //1. Grid 초기화
                fgrid_product.Rows.Count = fgrid_product.Rows.Fixed;

                //2. 조회조건
                string [] arg_value = new string[11];
                arg_value[0]  = cmb_factory.SelectedValue.ToString();
                arg_value[1]  = cmb_category.SelectedValue.ToString();
                arg_value[2]  = cmb_season.SelectedValue.ToString();
                arg_value[3]  = txt_sr_no.Text;
                arg_value[4]  = txt_srf_no.Text;
                arg_value[5]  = txt_bom_id.Text;
                arg_value[6]  = cmb_round.SelectedValue.ToString();
                arg_value[7]  = cmb_user.SelectedValue.ToString();
                arg_value[8]  = cmb_opcd.SelectedValue.ToString();
                arg_value[9]  = dtp_from.Value.ToString("yyyyMMdd");
                arg_value[10] = dtp_to.Value.ToString("yyyyMMdd");

                //3. Data Search (BOM Info)
                DataTable dt_list = Select_product_list(arg_value);
                Display_grid(dt_list, fgrid_product);
                
                fgrid_product.Tree.Show(3);
                dt_list.Dispose();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
            }
        }
        
        private void Display_grid(DataTable arg_list, COM.FSP arg_grid)
        {
            // Grid에 Data 입력
            for (int i = 0; i < arg_list.Rows.Count; i++)
            {
                int tree_level = int.Parse(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXG_PROD_MANAGER.IxT_LEVEL].ToString());
                arg_grid.Rows.InsertNode(arg_grid.Rows.Count, tree_level);

                for (int j = 0; j < arg_list.Columns.Count; j++)
                {
                    arg_grid[arg_grid.Rows.Count - 1, j] = arg_list.Rows[i].ItemArray[j].ToString();
                }

                if (tree_level.Equals(1))
                {
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.BackColor = Color.White;
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.ForeColor = Color.Black;
                }
                if (tree_level.Equals(2))
                {
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.BackColor = Color.White;
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                }
                if (tree_level.Equals(3))
                {
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.BackColor = Color.White;
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.ForeColor = Color.Black;
                }
                if (tree_level.Equals(4))
                {
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                    arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.ForeColor = Color.Black;
                }
            }
        }
        
        private DataTable Select_product_list(string [] arg_value)
        {
            MyOraDB.ReDim_Parameter(12);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_prod_01_select.select_sxg_prod_manager";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0]  = "arg_factory";
            MyOraDB.Parameter_Name[1]  = "arg_category";
            MyOraDB.Parameter_Name[2]  = "arg_season";
            MyOraDB.Parameter_Name[3]  = "arg_sr_no";
            MyOraDB.Parameter_Name[4]  = "arg_srf_no";
            MyOraDB.Parameter_Name[5]  = "arg_bom_id";
            MyOraDB.Parameter_Name[6]  = "arg_round";
            MyOraDB.Parameter_Name[7]  = "arg_dev_user";
            MyOraDB.Parameter_Name[8]  = "arg_op_cd";
            MyOraDB.Parameter_Name[9]  = "arg_from_date";
            MyOraDB.Parameter_Name[10] = "arg_to_date";
            MyOraDB.Parameter_Name[11] = "out_cursor";
            
            //03. DATA TYPE 정의
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

            //04. DATA 정의
            MyOraDB.Parameter_Values[0]  = arg_value[0];//arg_factory
            MyOraDB.Parameter_Values[1]  = arg_value[1];//arg_category
            MyOraDB.Parameter_Values[2]  = arg_value[2];//arg_season
            MyOraDB.Parameter_Values[3]  = arg_value[3];//arg_sr_no
            MyOraDB.Parameter_Values[4]  = arg_value[4];//arg_srf_no
            MyOraDB.Parameter_Values[5]  = arg_value[5];//arg_bom_id
            MyOraDB.Parameter_Values[6]  = arg_value[6];//arg_sample_type
            MyOraDB.Parameter_Values[7]  = arg_value[7];//arg_dev_user
            MyOraDB.Parameter_Values[8]  = arg_value[8];//arg_op_cd
            MyOraDB.Parameter_Values[9]  = arg_value[9];//arg_cutting_from
            MyOraDB.Parameter_Values[10] = arg_value[10];//arg_cutting_to
            MyOraDB.Parameter_Values[11] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }        
        #endregion

        #region Context Menu
        private void mnu_bom_Click(object sender, EventArgs e)
        {
            fgrid_product.Tree.Show(1);
        }
        private void mnu_day_seq_Click(object sender, EventArgs e)
        {
            fgrid_product.Tree.Show(2);
        }
        private void mnu_op_Click(object sender, EventArgs e)
        {
            fgrid_product.Tree.Show(3);
        }
        private void mnu_product_Click(object sender, EventArgs e)
        {
            fgrid_product.Tree.Show(4);
        }
        #endregion

        #region Grid Event
        private void fgrid_product_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        private void fgrid_product_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }        
        #endregion

        

       
    }
}

