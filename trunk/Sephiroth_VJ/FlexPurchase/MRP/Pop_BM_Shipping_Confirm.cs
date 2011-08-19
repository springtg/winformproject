using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;



namespace FlexMRP.MRP
{
    public partial class Pop_BM_Shipping_Confirm : COM.PCHWinForm.Pop_Medium
    {


        private DataTable _DT = null;
      
        public Pop_BM_Shipping_Confirm( DataTable arg_DT)
        {

             InitializeComponent();

             _DT = arg_DT;
           
             
        }




      

   

        #region 멤버메쏘드
        private void Init_Form()
        {


            //Title
            this.Text = "Shipping Confirm Check";
            lbl_MainTitle.Text = "Shipping Confirm Check";
            ClassLib.ComFunction.SetLangDic(this);

            // 그리드 설정(TBSBC_FORMULAN_YIELD )
            fgrid_ship.Set_Grid("SBM_SHIP_CONFIRM_2", "4", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_ship.Set_Action_Image(img_Action);


            // factory set
            DataTable vDt;
            vDt = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
            cmb_factory.SelectedValue = _DT.Rows[0].ItemArray[0].ToString();            
            vDt.Dispose();

            txt_MRP_Ship_No.Text = _DT.Rows[0].ItemArray[1].ToString();            
            
            DisplayGrid();

        }


        private void DisplayGrid()
        {

            fgrid_ship.Rows.Count = fgrid_ship.Rows.Fixed;

            for (int i = 0; i < _DT.Rows.Count; i++)
            {

                fgrid_ship.AddItem(_DT.Rows[i].ItemArray, fgrid_ship.Rows.Count, 1);

            }

        }


        #endregion 



        #region 버튼이벤트

        private void Pop_BM_Shipping_Confirm_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}

