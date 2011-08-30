using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexCDC.CDC_Bom
{
    public partial class Pop_Without_Bom_Spec : COM.PCHWinForm.Pop_Small
    {
        #region 사용자 정의 변수 
        private COM.OraDB MyOraDB = new COM.OraDB();
        private Form_Without_Bom without_bom = null;
        private string tmp_factory = "", tmp_unit_cd = "";
        #endregion

        #region 생성자
        public Pop_Without_Bom_Spec(Form_Without_Bom arg_without_bom, string arg_factory, string arg_unit_cd)
        {
            InitializeComponent();

            without_bom = arg_without_bom;
            tmp_factory = arg_factory;
            tmp_unit_cd = arg_unit_cd;
        }
        public Pop_Without_Bom_Spec()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_Without_Bom_Spec_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void Init_Form()
        {
            //1. Title Setting
            this.Text = "Spec Change";
            lbl_MainTitle.Text = "Spec Change";

            //2. Grid Setting
            fgrid_pop.Set_Grid_CDC("SXD_WITHOUT_BOM_POP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_pop.Rows.Count = fgrid_pop.Rows.Fixed;
                        
            DataTable dt_ret = Select_sxd_without_bom_pop();

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_pop.AddItem(dt_ret.Rows[i].ItemArray, fgrid_pop.Rows.Fixed + i, 1); 
            }

        }

        private DataTable Select_sxd_without_bom_pop()
        {
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "pkg_sxd_smf_xml_select.select_sxd_xml_pop";

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_pcc_unit_cd";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = tmp_factory;
            MyOraDB.Parameter_Values[1] = tmp_unit_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Grid Click Event
        private void fgrid_pop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_pop.Selection.r1;

                string pcc_spec_cd = fgrid_pop[sct_row, 1].ToString();
                string spec_name = fgrid_pop[sct_row, 2].ToString();

                int[] without_sct_rows = without_bom.fgrid_yield.Selections;

                for (int i = 0; i < without_sct_rows.Length; i++)
                {
                    without_bom.fgrid_yield[without_sct_rows[i], (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_SPEC] = pcc_spec_cd;
                    without_bom.fgrid_yield[without_sct_rows[i], (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_SPECNAME] = spec_name;

                    without_bom.fgrid_yield[without_sct_rows[i], (int)ClassLib.TBSXD_SMF_XML_TAIL.lxDIVISION] = "U";
                }

                this.Close();

            }
            catch
            {

            }
        }
        #endregion

    }
}

