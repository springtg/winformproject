using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Threading;


namespace FlexCDC.CDC_Bom
{
    public partial class Form_Bom_Material_List : COM.PCHWinForm.Form_Top
    {

        #region 사용자 정의 변수

        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string[] _value = null;
        public bool save_flg = false;
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        private Thread temp_thread = null;

       
        #endregion

        #region 생성자

        public Form_Bom_Material_List()
        {
            InitializeComponent();
        }
        #endregion 

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
         
            try
            {




                this.Cursor = Cursors.WaitCursor;


                _pop = new BaseInfo.Pop_BS_Shipping_List_Wait();
                temp_thread = new Thread(new ThreadStart(_pop.Start));

                if (temp_thread != null)
                {
                    temp_thread.Start();
                    Display_Data_Head();
                }


               

                this.Cursor = Cursors.WaitCursor;
               

            }
            catch
            {

            }
            finally
            {
                if (temp_thread != null)
                {
                    temp_thread.Abort();
                }

                this.Cursor = Cursors.Default;
                
                
            }
        }

        private void Display_Data_Head()
        {


           
            string[] arg_value = new string[10];

            arg_value[0] = cmb_factory.SelectedValue.ToString();
            arg_value[1] = txt_sr_no.Text.Trim();
            arg_value[2] = txt_srf_no.Text.Trim();
            arg_value[3] = txt_bom_id.Text.Trim();
            arg_value[4] = cmb_sampletype.SelectedValue.ToString();
            arg_value[5] = cmb_category.SelectedValue.ToString();
            arg_value[6] = cmb_season.SelectedValue.ToString();
            arg_value[7] = txt_style_name.Text.Trim();
            arg_value[8] = txt_style_cd.Text.Trim();
            arg_value[9] = ClassLib.ComFunction.Empty_Combo(cmb_user, "");

            DataTable dt_ret = SELECT_BOM_HEAD(arg_value);

            fgrid_model.Rows.Count = fgrid_model.Rows.Fixed;
            fgrid_part.Rows.Count = fgrid_part.Rows.Fixed;

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_model.Rows.Count = fgrid_model.Rows.Count + 1;
                for (int j = fgrid_model.Cols.Fixed; j < fgrid_model.Cols.Count; j++)
                {
                    fgrid_model[fgrid_model.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                    fgrid_model.Rows[fgrid_model.Rows.Count - 1].StyleNew.BackColor = Color.White;
                }
            }


        }



        private DataTable SELECT_BOM_HEAD(string []  arg_value)
        {
            MyOraDB.ReDim_Parameter(11);
            MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXE_LOT";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_ROUND";
            MyOraDB.Parameter_Name[5] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[6] = "ARG_SEASON";
            MyOraDB.Parameter_Name[7] = "ARG_STYLE_NAME";
            MyOraDB.Parameter_Name[8] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[9] = "ARG_USER";
            MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = arg_value[8];
            MyOraDB.Parameter_Values[9] = arg_value[9];
            MyOraDB.Parameter_Values[10] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

       

        #endregion

        #region Grid Event
        private void fgrid_model_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;


                _pop = new BaseInfo.Pop_BS_Shipping_List_Wait();
                temp_thread = new Thread(new ThreadStart(_pop.Start));

                if (temp_thread != null)
                {
                    temp_thread.Start();
                    Display_Data_Tail();
                }



               this.Cursor = Cursors.WaitCursor;
               

            }
            catch
            {

            }
            finally
            {
                if (temp_thread != null)
                {
                    temp_thread.Abort();
                }

                this.Cursor = Cursors.Default; 
                

            }
        }

        private void Display_Data_Tail()
        {

            

                int sct_row = fgrid_model.Selection.r1;                
                _value = new string[15];

                _value[0]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxFACTORY].ToString();
                _value[1]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxCATEGORY].ToString();
                _value[2]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxSEASON_CD].ToString();
                _value[3]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxSEASON].ToString();
                _value[4]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxSRF_NO].ToString();
                _value[5]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxBOM_ID].ToString();
                _value[6]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxSTYLE_CD].ToString();
                _value[7]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxSTYLE_NAME].ToString();
                _value[8]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxNF_CD].ToString();
                _value[9]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxNIKE_DEV].ToString();
                _value[10]  = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxCDC_DEV].ToString();
                _value[11] = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxLOT_NO].ToString();
                _value[12] = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxLOT_SEQ].ToString();

                _value[13] = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxSR_NO].ToString();
                _value[14] = fgrid_model[sct_row, (int)ClassLib.TBSXP_PUR_REQ_POP_HEAD.IxBOM_REV].ToString();
                

                DataTable dt_ret = SELECT_BOM_TAIL();




                fgrid_part.Rows.Count = fgrid_part.Rows.Fixed;
                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_part.Rows.Add();

                    for (int j = fgrid_part.Cols.Fixed; j < fgrid_part.Cols.Count; j++)
                    {
                        fgrid_part[fgrid_part.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                        fgrid_part.Rows[fgrid_part.Rows.Count - 1].StyleNew.BackColor = Color.White;
                    }
                }




        }
        private DataTable SELECT_BOM_TAIL()
        {
            MyOraDB.ReDim_Parameter(7);
            MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_TAIL";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
            MyOraDB.Parameter_Name[5] = "ARG_ROUND";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _value[0];
            MyOraDB.Parameter_Values[1] = _value[13];
            MyOraDB.Parameter_Values[2] = _value[4];
            MyOraDB.Parameter_Values[3] = _value[5];
            MyOraDB.Parameter_Values[4] = _value[14];
            MyOraDB.Parameter_Values[5] = _value[8];
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

       
        #endregion

        #region Form Loading

        private void Form_Bom_Material_List_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;


                cmb_factory.ReadOnly = false;
                cmb_factory.Enabled = true;
				

            }
            catch
            {

            }
            finally
            {

            }
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                




                #region Connect Webservice

                if (cmb_factory.SelectedValue.ToString() == "VJ")
                    COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                if (cmb_factory.SelectedValue.ToString() == "QD")
                    COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                if (cmb_factory.SelectedValue.ToString() == "DS")
                    COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;


                #endregion


                Init_Form();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Init_Form()
        {





            this.Text = "PCC_Material By Model";
            this.lbl_MainTitle.Text = "PCC_Material By Model";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            DataTable dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
            cmb_season.SelectedIndex = 0;

            dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
            cmb_category.SelectedIndex = 0;

            dt_ret = SELECT_ROUND();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0, 2, true, 0, 120);
            cmb_sampletype.SelectedIndex = 0;

            string _power_lev = COM.ComVar.This_CDCPower_Level;

            lbl_user.Visible = false;
            cmb_user.Visible = false;

            //if (_power_lev.Equals("S00") || _power_lev.Equals("P01"))
            //{
            //    dt_ret = SELECT_USER();
            //    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 120);
            //    cmb_user.SelectedIndex = 0;
            //}
            //else
            //{
            //    cmb_user.Enabled = false;

            //    DataTable user_datatable = new DataTable("UserList");
            //    DataRow newrow;

            //    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
            //    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

            //    newrow = user_datatable.NewRow();
            //    newrow["Code"] = ClassLib.ComVar.This_User;
            //    newrow["Name"] = ClassLib.ComVar.This_User;

            //    user_datatable.Rows.Add(newrow);
            //    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, 0, 120);
            //    cmb_user.SelectedValue = ClassLib.ComVar.This_User;
            //}
            #endregion

            #region Grid Setting
            fgrid_model.Set_Grid_CDC("SXD_SRF_SELECT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_model.Set_Action_Image(img_Action);
            fgrid_model.ExtendLastCol = false;

            fgrid_part.Set_Grid_CDC("SXD_SRF_SELECT", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_part.Set_Action_Image(img_Action);
            fgrid_part.ExtendLastCol = false;
            #endregion            

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled   = false;
            tbtn_Create.Enabled  = false;


            cmb_factory.Enabled = true;


        }

        private DataTable SELECT_SEASON()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable SELECT_ROUND()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable SELECT_USER()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "XY_PKG_SXP_REQ_01_SELECT.SELECT_REQ_POP_USER";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        #endregion                
       
    }
}

