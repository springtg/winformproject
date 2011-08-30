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
    public partial class Pop_EIS_MatPrice_Order_Qty : COM.APSWinForm.Pop_Small
    {
        public Pop_EIS_MatPrice_Order_Qty()
        {
            InitializeComponent();
        }



        
        public static string _Factory = "";
        public static string _ModelCD = "";
        public static string _ModelName = "";
        
         public  Pop_EIS_MatPrice_Order_Qty(string arg_factory, string arg_model_cd, string arg_model_name)
        {
            InitializeComponent();

            _Factory = arg_factory;
            _ModelCD = arg_model_cd;
            _ModelName = arg_model_name;

            //Init_Form();


        }







        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();


        #endregion



        
        #region 공통메쏘드

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {


                //Title
                this.Text = "Order Quantity";
                lbl_MainTitle.Text = "Order Quantity";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();

                Init_Control();




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void Init_Grid()
        {


            fgrid_Main.Set_Grid("EIS_MATPRICE_ORDER_QTY", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
          //  fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.KeyActionEnter = KeyActionEnum.MoveAcross;

            // fgrid_Main.SelectionMode = SelectionModeEnum.Default;


        }




        private void Init_Control()
        {



            // 공장 Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
            dt_ret.Dispose();
            cmb_Factory.SelectedValue = _Factory;
            txt_Model_CD.Text = _ModelCD;
            txt_Model_Name.Text = _ModelName;

            Set_Model_Order_Qty();
            
        

        }


       
        private void Set_Model_Order_Qty()
        {

            try
            {

                DataTable  vDT  = SELECT_MODEL_ORDER_QTY(ClassLib.ComFunction.Empty_Combo(cmb_Factory," "),
                                                         ClassLib.ComFunction.Empty_TextBox(txt_Model_CD," "),
                                                         ClassLib.ComFunction.Empty_TextBox(txt_Model_Name," "));

                Display_Grid(vDT);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }



        }


        private void Display_Grid(DataTable arg_dt)
        {
            double vTotQty = 0;

             fgrid_Main.ClearAll();


            if (arg_dt.Rows.Count == 0) return;


            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_Main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
                fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";

                vTotQty = vTotQty + Convert.ToDouble(fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_MATPRICE_MODEL_QTY.IxOBS_QTY].ToString());
                
                
              
            }
     
            // merge       
            fgrid_Main.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                fgrid_Main.Cols[i].AllowMerging = false;
            }

            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MODEL_QTY.IxFACTORY].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MODEL_QTY.IxMODEL_CD].AllowMerging = true;
            fgrid_Main.Cols[(int)ClassLib.TBEIS_MATPRICE_MODEL_QTY.IxMODEL_NAME].AllowMerging = true;


            lbl_TotQty.Text = "Total Quantity : " + Convert.ToString(vTotQty);
            
            
        
           

        }

        #endregion 


        #region 이벤트 처리

        private void cmb_Factory_TextChanged(object sender, EventArgs e)
        {
            //if (cmb_Factory.SelectedIndex == 0) return;

            //Set_Model_Order_Qty();
        }


        private void txt_Model_CD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Set_Model_Order_Qty();

        }

        private void txt_Model_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
         if (e.KeyChar == (char)13)
                Set_Model_Order_Qty();
        }


        #endregion



        #region db


        private DataTable SELECT_MODEL_ORDER_QTY(string arg_factory , string arg_model_cd, string arg_model_name )
        {

            try
            {

                MyOraDB.ReDim_Parameter(4);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "pkg_emm_price_batch_00.select_model_order_qty";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_model_cd";
                MyOraDB.Parameter_Name[2] = "arg_model_name";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_model_cd;
                MyOraDB.Parameter_Values[2] = arg_model_name;
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

        #endregion



        private void Pop_EIS_MatPrice_Order_Qty_Load(object sender, EventArgs e)
        {
            Init_Form();

        }

    
    
    }
}

