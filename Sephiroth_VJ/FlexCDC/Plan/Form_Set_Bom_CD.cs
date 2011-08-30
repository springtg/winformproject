using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Xml;
using System.IO;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Plan
{
    public partial class Form_Set_Bom_CD : COM.PCHWinForm.Form_Top
    {
        private COM.OraDB OraDB = new COM.OraDB();
        private int _project_Rowfixed = 0;
        private int _detail_Rowfixed;
        private int _bomnode_Rowfixed;
        private int _Link_Index = 0;

        private string _factory = null;
        private string _style_name = null;
        private string _lot_no = null;
        private string _lot_seq = null;

        

        public Form_Set_Bom_CD()
        {
            InitializeComponent();
        }


        public Form_Set_Bom_CD(string arg_factory, string arg_model, string arg_lot_no, string arg_lot_seq)
        {
            InitializeComponent();

            _factory = arg_factory;
            _style_name = arg_model;
            _lot_no = arg_lot_no;
            _lot_seq = arg_lot_seq;
        }

        private void Form_Set_Bom_CD_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
        }

        private void Init_Form()
        {
            this.Text = "Set Product Bom To Model";
            this.lbl_MainTitle.Text = "Set Product Bom To Model";
            ClassLib.ComFunction.SetLangDic(this);





            //bom code setting
            DataTable dt_ret = Select_BomCd_CmbList();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_bom, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code);
            cmb_p_bom.SelectedIndex = 0;


            #region Grid Setting
            flg_wsheet.Set_Grid_CDC("SXE_LOT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            flg_wsheet.Set_Action_Image(img_Action);
            flg_wsheet.Font = new Font("Verdana", 8);
            _project_Rowfixed = flg_wsheet.Rows.Count;
            #endregion

            if (ClassLib.ComVar.addf_size_X.ToString().Equals("0.75"))
            {
                sizer.Value = 1;
            }
            else if (ClassLib.ComVar.addf_size_X.ToString().Equals("1"))
            {
                sizer.Value = 2;
            }
            else if (ClassLib.ComVar.addf_size_X.ToString().Equals("1.25"))
            {
                sizer.Value = 3;
            }


            if (_factory != null)
            {
                txt_style_name.Text = _style_name;
                txt_lot_no.Text = _lot_no;
                txt_lot_seq.Text = _lot_seq;


                tbtn_Search_Click(null, null);

            }

            //addflow_BOM.Zoom = new Lassalle.Flow.Zoom(ClassLib.ComVar.addf_size_X, ClassLib.ComVar.addf_size_Y);
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        /// <summary>
        /// Select_BomCd_CmbList : BOM Code Combo List 찾기
        /// </summary>
        private DataTable Select_BomCd_CmbList()
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXB_PJ_BOM.SELECT_SXB_BOM_CD";

                OraDB.ReDim_Parameter(2);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = "DS";//cmb_factory.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];

            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Select_StdBom_List : 표준 BOM 리스트 찾기
        /// </summary>
        private DataTable Select_StdBom_List()
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXB_PJ_BOM.SELECT_STDBOM_ROUT";

                OraDB.ReDim_Parameter(4);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_BOM_CD";
                OraDB.Parameter_Name[2] = "ARG_ROUT";  //"ARG_ROUT_TYPE"; 
                OraDB.Parameter_Name[3] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = cmb_p_bom.SelectedValue.ToString();
                OraDB.Parameter_Values[2] = "";
                OraDB.Parameter_Values[3] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];

            }
            catch
            {
                return null;
            }

        }


        private DataTable Select_Bom_CD_List(string arg_factory, string arg_lot_no, string  arg_lot_seq, string arg_day_seq, string arg_style_cd, string arg_style_name, string arg_srf_no, string arg_bom_id, string arg_bom_cd, string arg_bom_chk)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_BOM_CD_LIST";

                OraDB.ReDim_Parameter(11);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOT_NO";
                OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
                OraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
                OraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                OraDB.Parameter_Name[5] = "ARG_STYLE_NAME";
                OraDB.Parameter_Name[6] = "ARG_SRF_NO";
                OraDB.Parameter_Name[7] = "ARG_BOM_ID";
                OraDB.Parameter_Name[8] = "ARG_BOM_CD";
                OraDB.Parameter_Name[9] = "ARG_BOM_CHK";
                OraDB.Parameter_Name[10] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = arg_factory;
                OraDB.Parameter_Values[1] = arg_lot_no;
                OraDB.Parameter_Values[2] = arg_lot_seq;
                OraDB.Parameter_Values[3] = arg_day_seq;
                OraDB.Parameter_Values[4] = arg_style_cd;
                OraDB.Parameter_Values[5] = arg_style_name;
                OraDB.Parameter_Values[6] = arg_srf_no;
                OraDB.Parameter_Values[7] = arg_bom_id;
                OraDB.Parameter_Values[8] = arg_bom_cd;
                OraDB.Parameter_Values[9] = arg_bom_chk;
                OraDB.Parameter_Values[10] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];

            }
            catch
            {
                return null;
            }

        }




        private void cmb_p_bom_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                fgrid_BomNode.Set_Grid_CDC("SXB_NODE_BOM", "1", 1, ClassLib.ComVar.This_Lang, true);
                fgrid_BomLink.Set_Grid_CDC("SXB_LINK_BOM", "1", 1, ClassLib.ComVar.This_Lang, true);

                ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

                DataTable dt_ret = Select_StdBom_List();

                if (dt_ret.Rows.Count > 0)
                {
                    Select_StdBom_Node_List();
                    Select_StdBom_Link_List();

                    //string Zoompoint = "1";
                    //addflow_BOM.Zoom.X = float.Parse(Zoompoint);//_Zoompoint;
                    //addflow_BOM.Zoom.Y = float.Parse(Zoompoint);//_Zoompoint;


                    addflow_BOM.Zoom = new Lassalle.Flow.Zoom(ClassLib.ComVar.addf_size_X, ClassLib.ComVar.addf_size_Y);
                }





                for (int i = _project_Rowfixed; i < flg_wsheet.Rows.Count; i++)
                {
                    if (bool.Parse(flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxSET_CHK].ToString()))
                    {
                        flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxDIVISION] = "U";
                        flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxBOM_CD] = cmb_p_bom.SelectedValue.ToString();
                    }
                    else
                    {
                        flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxDIVISION] = " ";
                    }
                }


            }
            catch
            {

            }
        }

        /// <summary>
        /// Select_StdBom_Node_List : Standard BOM Node 리스트 찾기  
        /// </summary>
        private void Select_StdBom_Node_List()
        {

            DataSet ds_ret;
            DataTable dt_ret;
            Lassalle.Flow.Node node;

            try
            {
                string process_name = "PKG_SXB_PJ_BOM.SELECT_STDBOM_NODELIST";

                OraDB.ReDim_Parameter(3);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_BOM_CD";
                OraDB.Parameter_Name[2] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = cmb_p_bom.SelectedValue.ToString();
                OraDB.Parameter_Values[2] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return;
                dt_ret = ds_ret.Tables[process_name];


                //-------------------------------------------------------------------------------- 
                fgrid_BomNode.Rows.Count = _bomnode_Rowfixed;
                fgrid_BomNode.Cols.Count = dt_ret.Columns.Count + 1;

                // Set List
                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_BomNode.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomNode.Rows.Count, 1);
                }



                for (int i = _bomnode_Rowfixed; i < fgrid_BomNode.Rows.Count; i++)
                {
                    node = new Lassalle.Flow.Node();

                    node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxLEFT].ToString()),
                        Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTOP].ToString()),
                        Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxWIDTH].ToString()),
                        Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxHEIGHT].ToString()), "");

                    //node.Text = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTEXT].ToString();
                    node.Text = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();

                    node.Tooltip = node.Text;
                    node.Tag = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();

                    ClassLib.ComFunction.Set_NodeProp(fgrid_BomNode, node, i);
                } //end for 
                //--------------------------------------------------------------------------------
            }
            catch
            {
            }
        }

        /// <summary>
        /// Select_StdBom_Link_List : Standard BOM Link 리스트 찾기 
        /// </summary>
        private void Select_StdBom_Link_List()
        {

            DataSet ds_ret;
            DataTable dt_ret;
            Lassalle.Flow.Link link;
            int org_node, dst_node;
            int max_index = _Link_Index;

            try
            {
                string process_name = "PKG_SXB_PJ_BOM.SELECT_STDBOM_LINKLIST";

                OraDB.ReDim_Parameter(3);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_BOM_CD";
                OraDB.Parameter_Name[2] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = cmb_p_bom.SelectedValue.ToString();
                OraDB.Parameter_Values[2] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return;
                dt_ret = ds_ret.Tables[process_name];


                //-------------------------------------------------------------------------------- 
                fgrid_BomLink.Rows.Count = _bomnode_Rowfixed;
                fgrid_BomLink.Cols.Count = dt_ret.Columns.Count + 1;

                // Set List
                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_BomLink.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomLink.Rows.Count, 1);
                }


                ////////////////////////////////////////////////////////////////
                for (int i = _bomnode_Rowfixed; i < fgrid_BomLink.Rows.Count; i++)
                {
                    link = new Lassalle.Flow.Link();

                    org_node = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _bomnode_Rowfixed);
                    dst_node = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _bomnode_Rowfixed);


                    link = addflow_BOM.Nodes[org_node].OutLinks.Add(addflow_BOM.Nodes[dst_node]);

                    link.Tag = fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxTAG].ToString();

                    ClassLib.ComFunction.Set_LinkProp(fgrid_BomLink, link, i);

                    if (max_index <= Convert.ToInt32(link.Tag)) max_index = Convert.ToInt32(link.Tag);


                } // end for

                _Link_Index = max_index + 1;
                //--------------------------------------------------------------------------------

            }
            catch
            {
            }

        }

        private void addflow_BOM_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
           // flg_wsheet.Select(flg_wsheet.Selection.r1, 0, flg_wsheet.Selection.r1, flg_wsheet.Cols.Count - 1, false);

            string arg_isbom_chk = (chk_bom.Checked)?"N":"Y";
            DataTable dt = Select_Bom_CD_List(cmb_factory.SelectedValue.ToString(), " ", " ", "", txt_style_cd.Text, txt_style_name.Text, txt_srf_no.Text, txt_bom_id.Text, "", arg_isbom_chk);

            flg_wsheet.Rows.Count = _project_Rowfixed;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    flg_wsheet.AddItem(dt.Rows[i].ItemArray, flg_wsheet.Rows.Count, 0);

            //    if (txt_lot_no.Text + txt_lot_seq.Text == dt.Rows[i].ItemArray[(int)ClassLib.TBSXE_LOT.IxLOT_NO].ToString() + dt.Rows[i].ItemArray[(int)ClassLib.TBSXE_LOT.IxLOT_SEQ].ToString())
            //    {
            //        flg_wsheet[flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXE_LOT.IxSET_CHK] = "True";
            //        flg_wsheet.Rows[flg_wsheet.Rows.Count-1].StyleNew.BackColor = Color.Gold;
            //    }

            //}
        }

        private void sizer_Scroll(object sender, EventArgs e)
        {
            if (sizer.Value.Equals(1))
            {
                ClassLib.ComVar.addf_size_X = (float)0.75;
                ClassLib.ComVar.addf_size_Y = (float)0.75;
            }
            else if (sizer.Value.Equals(2))
            {
                ClassLib.ComVar.addf_size_X = 1;
                ClassLib.ComVar.addf_size_Y = 1;
            }
            else if (sizer.Value.Equals(3))
            {
                ClassLib.ComVar.addf_size_X = (float)1.25;
                ClassLib.ComVar.addf_size_Y = (float)1.25;// (float)sizer.Value / 4;
            }
            
            addflow_BOM.Zoom = new Lassalle.Flow.Zoom(ClassLib.ComVar.addf_size_X, ClassLib.ComVar.addf_size_Y);
        }

        private void flg_wsheet_Click(object sender, EventArgs e)
        {
            int sct_row = flg_wsheet.Selection.r1;
            int sct_col = flg_wsheet.Selection.c1;

            if (sct_row > _project_Rowfixed && sct_col.Equals((int)ClassLib.TBSXE_LOT.IxBOM_CD))
            {
                try
                {
                    cmb_p_bom.SelectedValue = flg_wsheet[sct_row, (int)ClassLib.TBSXE_LOT.IxBOM_CD].ToString();
                }
                catch
                {
                }
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_wsheet.Select(flg_wsheet.Selection.r1, 0, flg_wsheet.Selection.r1, flg_wsheet.Cols.Count - 1, false);

            for (int i = _project_Rowfixed; i < flg_wsheet.Rows.Count; i++)
            {
                if (flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxDIVISION].Equals("U"))
                {
                    string arg_factory = flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxFACTORY].ToString();
                    string arg_lot_no = flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxLOT_NO].ToString();
                    string arg_lot_seq = flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxLOT_SEQ].ToString();
                    string arg_bom_cd = flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxBOM_CD].ToString();
                    save_sxg_mps_lot_daily(arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd);

                    //flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxDIVISION] = " ";
                    //flg_wsheet[i, (int)ClassLib.TBSXE_LOT.IxSET_CHK] = "False";

                    txt_lot_no.Text = "";
                    txt_lot_seq.Text = "";
                }
            }

            tbtn_Search_Click(null, null);
        }


        private void save_sxg_mps_lot_daily(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_bom_cd)
        {

            string Proc_Name = "pkg_sxg_mps_01.SAVE_SXD_SRF_SPECIFIC_OPCD";

            OraDB.ReDim_Parameter(5);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_BOM_CD";
            OraDB.Parameter_Name[4] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_bom_cd;
            OraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
    }
}

