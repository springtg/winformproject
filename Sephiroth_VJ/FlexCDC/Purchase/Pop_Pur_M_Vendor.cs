using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Purchase
{
    public partial class Pop_Pur_M_Vendor : COM.PCHWinForm.Pop_Small
    {
        #region 사용자정의 변수
        private COM.OraDB OraDB = new COM.OraDB();
        private string _mat_cd = null;
        #endregion 

        #region 생성자
        public Pop_Pur_M_Vendor()
        {
            InitializeComponent();
        }

        public Pop_Pur_M_Vendor(string arg_mat_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_mat_cd = arg_mat_cd;

        }
        #endregion

        #region Form Loading
        private void Pop_Pur_M_Vendor_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Init_Form();
            }

            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Init_Form()
        {
            this.Text = "PCC_Vendor List";
            this.lbl_MainTitle.Text = "PCC_Vendor List";
            ClassLib.ComFunction.SetLangDic(this);
                        
            fgrid_Vendor.Set_Grid_CDC("SXO_PUR_VENDOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Vendor.Set_Action_Image(img_Action);

            DataTable dt = SELECT_SXD_M_VENDOR();

            fgrid_Vendor.Rows.Count = fgrid_Vendor.Rows.Fixed;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_Vendor.AddItem(dt.Rows[i].ItemArray, fgrid_Vendor.Rows.Count, 1);
            }
        }

        private DataTable SELECT_SXD_M_VENDOR()
        {
            string Proc_Name = "Pkg_SXP_PUR_02_Select.SELECT_SXD_VENDOR_LIKE";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_mat_cd";
            OraDB.Parameter_Name[2] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;
            OraDB.Parameter_Values[1] = _mat_cd;
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion


        #region 공통메쏘드
        


        private void fgrid_Vendor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int vRow = fgrid_Vendor.Selection.r1;
                int vCol = fgrid_Vendor.Selection.c1;

                if (vRow >= fgrid_Vendor.Rows.Fixed)
                {
                    COM.ComVar.This_Return = fgrid_Vendor[vRow, (int)ClassLib.TBSXP_PUR_M_VENDOR.IxVENDOR_DESC].ToString();
                }

                this.Close();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        #endregion 


        #region DB컨넥트
        


        #endregion 

        

       
    }
}

