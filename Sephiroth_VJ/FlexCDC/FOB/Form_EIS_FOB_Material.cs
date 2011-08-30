using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;


namespace FlexCDC.FOB
{
    public partial class Form_EIS_FOB_Material : COM.APSWinForm.Form_Top
    {
        public Form_EIS_FOB_Material()
        {
            InitializeComponent();
        }

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();

        #endregion 

        #region 공통메쏘드
        private void Init_Form()
        {

            try
            {
                //Title
                this.Text = "FOB Material Master";
                lbl_MainTitle.Text = "FOB Material Master";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                Init_Control();
                Init_Toolbar();

                ClearAll();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EIS_FOB_MATERIAL_MASTER", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
           
        }


        private void Init_Control()
        {
            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 0;
            dt_ret.Dispose();

            

            //Custname 
            dt_ret = SELECT_FOB_VENDOR(ClassLib.ComFunction.Empty_Combo(cmb_Factory,""));
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_CustName, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_CustName.SelectedIndex = 0;
            dt_ret.Dispose();

        }


        private void Init_Toolbar()
        {
            // Disabled tbutton
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled = false;
        }


        private void ClearAll()
        {
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            txt_Mat_Code.Clear();
            txt_MatName.Clear();
            cmb_CustName.SelectedIndex = 0;
            
        }


        private void Search()
        {
            string vFactory = COM.ComFunction.Empty_Combo(cmb_Factory, "");
            string vMatCode = COM.ComFunction.Empty_TextBox(txt_Mat_Code, "");
            string vMatName = COM.ComFunction.Empty_TextBox(txt_MatName, "");
            string vCustName = COM.ComFunction.Empty_Combo(cmb_CustName, "");

            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            DataTable vDT  = SELECT_FOB_MATERIAL_LIST(vFactory, vMatCode, vMatName, vCustName);

            if (vDT != null)
            {
                for (int i = 0; i<vDT.Rows.Count ; i++)
                {

                    fgrid_Main.AddItem(vDT.Rows[i].ItemArray, fgrid_Main.Rows.Count , 1);



                }
            
            }




            //----------------------------------------------------
            // merge
            ////----------------------------------------------------
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = false;

            }

            for (int i  = (int)ClassLib.TBEBM_FOB_DETAIL_LOAD.IxFACTORY ;  i  <= (int)ClassLib.TBEBM_FOB_DETAIL_LOAD.IxSUB_CLASS  ; i++)
                fgrid_Main.Cols[i].AllowMerging = true;
            


        }





        #endregion

        #region DB 컨넥트




        public DataTable SELECT_FOB_VENDOR(string arg_factory)
        {
            try
            {
                

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SELECT_FOB_VENDOR";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable SELECT_FOB_MATERIAL_LIST(string arg_factory, string arg_mat_cd, string arg_mat_name, string arg_cust_name)
        {
            try
            {
               

                MyOraDB.ReDim_Parameter(5);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_BATCH_00.SELECT_FOB_MATERIAL_MASTER";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MAT_NO";
                MyOraDB.Parameter_Name[2] = "ARG_MAT_NAME";
                MyOraDB.Parameter_Name[3] = "ARG_VENDOR";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mat_cd;
                MyOraDB.Parameter_Values[2] = arg_mat_name;
                MyOraDB.Parameter_Values[3] = arg_cust_name;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion 



        #region 버튼관리

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            cmb_Factory.SelectedIndex = 0;
            cmb_CustName.SelectedIndex = 0;
            txt_Mat_Code.Clear();
            txt_MatName.Clear();
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
        }


        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        #endregion

        private void Form_EIS_FOB_Material_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

       

      
    }
}

