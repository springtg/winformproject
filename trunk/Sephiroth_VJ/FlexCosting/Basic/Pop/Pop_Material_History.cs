using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Basic.Pop
{
    public partial class Pop_Material_History : Form
    {
        public Pop_Material_History()
        {
            InitializeComponent();

            Init_Form();
        }

        #region ���� ���� ���� �� ����


        private COM.OraDB MyOraDB = new COM.OraDB();

        private string _factory = null, _matCode = null;


        #endregion

        #region �̺�Ʈ �ڵ鷯

        public new DialogResult ShowDialog()
        {
            DataTable vDT = SELECT_SFB_CBD_B_MAT_HIS(_factory, _matCode);

            if (vDT != null && vDT.Rows.Count > 0)
            {
                fgrid_main.Display_Grid(vDT, false);
            }

            return base.ShowDialog();
        }

        #endregion

        #region �̺�Ʈ ó��

        #region �ʱ�ȭ

        /// <summary>
        /// Inti_Form : Form Load �� �ʱ�ȭ �۾�
        /// </summary>
        private void Init_Form()
        {

            try
            {
                //Title
                this.Text = "";
                // serach.lbl_MainTitle.Text = "";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();
                //Init_Control();
                //Init_Toolbar();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFB_CBD_B_MAT_HIS", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
        }

        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ

        public string Factory
        {
            set
            {
                _factory = value;
            }
        }

        public string MatCode
        {
            set
            {
                _matCode = value;
            }
        }

        #endregion

        #endregion

        #region ��� ����

        #region ��ȸ

        /// <summary>
        /// PKG_SXD_SRF_M_MAT.SELECT_SFB_CBD_B_MAT_HIS : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFB_CBD_B_MAT_HIS(string arg_factory, string arg_mat_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_SXD_SRF_M_MAT.SELECT_SFB_CBD_B_MAT_HIS";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA ����
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_mat_cd;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        #endregion

        #endregion

    }
}