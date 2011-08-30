using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;


namespace FlexCDC.CDC_Bom
{
    public partial class Form_Without_Bom : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private Color Clr_Head_Red = Color.FromArgb(255, 0, 0); //light red
        private int _select_row;
        private string _Before_Data = "";

        string _Save_Dir = "", _Style = "";
        int _SelectedRow = 0; 
        #endregion

        #region 생성자
        public Form_Without_Bom()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Without_Bom_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;
            cmb_factory.Enabled = false;
        }
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {

            }
        }

        private void Init_Form()
        {
            //Title Setting 
            this.Text = "PCC_Data Without BOM";
            this.lbl_MainTitle.Text = "PCC_Data Without BOM";
            this.lbl_title.Text = "         Yield Information";
            ClassLib.ComFunction.SetLangDic(this);

            #region Button Control
            //ToolTip Setting
            tbtn_New.ToolTipText     = "Create Usage";
            tbtn_Confirm.ToolTipText = "Confirm Usage";
            tbtn_Create.ToolTipText  = "Create Usage Xml";


            tbtn_Append.Enabled  = false;
            tbtn_Color.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Insert.Enabled  = false;
            tbtn_Save.Enabled    = false;
            tbtn_Create.Enabled  = false;

            tbtn_New.Enabled     = true;
            tbtn_Search.Enabled  = true;
            tbtn_Print.Enabled   = false;

            //권한에 따른 Button Control 
            string power_level = ClassLib.ComVar.This_CDCPower_Level;
            if ((power_level.Substring(0, 1).Equals("P")) || power_level == "S00")//CDC Power Level이 PMC일때
            {
                tbtn_New.Enabled     = true;
                tbtn_Confirm.Enabled = false;
                tbtn_Save.Enabled    = true;
                tbtn_Create.Enabled  = true;
            }
            #endregion

            #region 그리드 정의
            fgrid_style.Set_Grid("SXD_SMF_WITHOUT_BOM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_style.Set_Action_Image(img_Action);
            fgrid_style.Font = new System.Drawing.Font("Verdana", 8);
            _select_row = fgrid_style.Rows.Fixed;

            fgrid_yield.Set_Grid("SXD_SMF_WITHOUT_BOM", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_yield.Set_Action_Image(img_Action);
            fgrid_yield.Font = new System.Drawing.Font("Verdana", 8);
            #endregion

            #region ComboBox Setting
            //Season			
            DataTable dt_list = Select_season();
            cmb_season_cd.Enabled = true;
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_season_cd, 0, 1, true, 0, 120);
            cmb_season_cd.SelectedIndex = 0;

            dt_list.Dispose();
            #endregion
        }

        private DataTable Select_season()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Create
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_style.Rows.Fixed; i < fgrid_style.Rows.Count; i++)
                {
                    if (fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE].ToString() == "False") continue;

                    string vFactory = fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxFACTORY].ToString();
                    string vStyle   = fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString();

                    if (!Check_Create_Yield(i)) return;

                    Save_Create_Yield(vFactory, vStyle);

                    fgrid_style[i, 0] = "";
                    fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE] = "False";
                    fgrid_style.TopRow = i;
                }


                tbtn_Search_Click(null, null);
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

        public void Save_Create_Yield(string arg_factory, string arg_style_cd)
        {
            MyOraDB.ReDim_Parameter(8);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_smf_xml.save_sxd_smf_xml_load";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_division";
            MyOraDB.Parameter_Name[1] = "arg_factory";
            MyOraDB.Parameter_Name[2] = "arg_style_cd";
            MyOraDB.Parameter_Name[3] = "arg_pcc_seq_no";
            MyOraDB.Parameter_Name[4] = "arg_pcc_yield";
            MyOraDB.Parameter_Name[5] = "arg_pcc_unit_cd";
            MyOraDB.Parameter_Name[6] = "arg_pcc_spec_cd";
            MyOraDB.Parameter_Name[7] = "arg_upd_user";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = "I";
            MyOraDB.Parameter_Values[1] = arg_factory;
            MyOraDB.Parameter_Values[2] = arg_style_cd;
            MyOraDB.Parameter_Values[3] = " ";
            MyOraDB.Parameter_Values[4] = " ";
            MyOraDB.Parameter_Values[5] = " ";
            MyOraDB.Parameter_Values[6] = " ";
            MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;


            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Search
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string arg_season_cd   = cmb_season_cd.SelectedValue.ToString();
                string arg_season_name = (cmb_season_cd.Text.Trim() == "ALL") ? "" : cmb_season_cd.Text.Trim();
                string arg_style       = txt_style.Text;

                DataTable dt_ret = Select_Style_List(arg_season_cd, arg_season_name, arg_style);

                fgrid_style.Rows.Count = fgrid_style.Rows.Fixed;
                fgrid_yield.Rows.Count = fgrid_yield.Rows.Fixed;


                if (dt_ret.Rows.Count != 0)
                {
                    Display_FlexGrid(fgrid_style, dt_ret);                    
                    //fgrid_style.TopRow = _select_row;
                    //fgrid_style.Select(_select_row, 0);

                    //Usage Data 조회하기                     
                    dt_ret = Select_Yield_List(fgrid_style[fgrid_style.Selection.r1, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString());
                    fgrid_yield.Rows.Count = fgrid_yield.Rows.Fixed;
                    Display_FlexGrid(fgrid_yield, dt_ret);
                }
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
        private void Display_FlexGrid(COM.FSP arg_grid, DataTable arg_dt)
        {                      
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {                
                arg_grid.AddItem(arg_dt.Rows[i].ItemArray, arg_grid.Rows.Fixed + i, 1);
                arg_grid[arg_grid.Rows.Count - 1, 0] = "";

                if (arg_grid.Equals(fgrid_style))
                {
                    string factory = arg_grid[arg_grid.Rows.Count - 1, (int)ClassLib.TBSXD_SMF_XML.lxFACTORY].ToString();
                    string dev_cd  = arg_grid[arg_grid.Rows.Count - 1, (int)ClassLib.TBSXD_SMF_XML.lxDEV_CD].ToString();

                    if (factory.Equals("") || dev_cd.Equals(""))
                        arg_grid.Rows[arg_grid.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.Clr_Head_Red;
                }
            }
        }

        private DataTable Select_Style_List(string arg_season_cd, string arg_season_name, string arg_style_cd)
        {
            MyOraDB.ReDim_Parameter(4);

            MyOraDB.Process_Name = "pkg_sxd_smf_xml_select.select_sxd_smf_xml_load";

            MyOraDB.Parameter_Name[0] = "arg_season_cd";
            MyOraDB.Parameter_Name[1] = "arg_season_name";
            MyOraDB.Parameter_Name[2] = "arg_style_cd";
            MyOraDB.Parameter_Name[3] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_season_cd;
            MyOraDB.Parameter_Values[1] = arg_season_name;
            MyOraDB.Parameter_Values[2] = arg_style_cd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_Yield_List(string arg_style_cd)
        {
            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "pkg_sxd_smf_xml_select.select_sxd_smf_xml_load_yield";

            MyOraDB.Parameter_Name[0] = "arg_style_cd";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_style_cd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Delete
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                for (int i = fgrid_style.Rows.Fixed; i < fgrid_style.Rows.Count; i++)
                {
                    if (fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE].ToString() == "False") continue;

                    string vFactory = COM.ComVar.This_Factory;
                    string vStyle = fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString();
                    string vNike_Dim = fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxNIKE_XDM_DIM_CD].ToString();

                    Delete_Yield(vFactory, vStyle, vNike_Dim);

                    fgrid_style[i, 0] = "";
                    fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE] = "False";
                }

                tbtn_Search_Click(null, null);
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void Delete_Yield(string arg_factory, string arg_style, string arg_style_dim)
        {
            MyOraDB.ReDim_Parameter(8);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_smf_xml.save_sxd_smf_xml_load";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_division";
            MyOraDB.Parameter_Name[1] = "arg_factory";
            MyOraDB.Parameter_Name[2] = "arg_style_cd";
            MyOraDB.Parameter_Name[3] = "arg_pcc_seq_no";
            MyOraDB.Parameter_Name[4] = "arg_pcc_yield";
            MyOraDB.Parameter_Name[5] = "arg_pcc_unit_cd";
            MyOraDB.Parameter_Name[6] = "arg_pcc_spec_cd";
            MyOraDB.Parameter_Name[7] = "arg_upd_user";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = "D";
            MyOraDB.Parameter_Values[1] = arg_factory;
            MyOraDB.Parameter_Values[2] = arg_style;
            MyOraDB.Parameter_Values[3] = " ";
            MyOraDB.Parameter_Values[4] = " ";
            MyOraDB.Parameter_Values[5] = " ";
            MyOraDB.Parameter_Values[6] = " ";
            MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;


            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Save
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;                

                Save_Yield();
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

        private void Save_Yield()
        {
            int vCol = 8;
            MyOraDB.ReDim_Parameter(vCol);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_smf_xml.save_sxd_smf_xml_load";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_division";
            MyOraDB.Parameter_Name[1] = "arg_factory";
            MyOraDB.Parameter_Name[2] = "arg_style_cd";
            MyOraDB.Parameter_Name[3] = "arg_pcc_seq_no";
            MyOraDB.Parameter_Name[4] = "arg_pcc_yield";
            MyOraDB.Parameter_Name[5] = "arg_pcc_unit_cd";
            MyOraDB.Parameter_Name[6] = "arg_pcc_spec_cd";
            MyOraDB.Parameter_Name[7] = "arg_upd_user";
 
            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

            //04.DATA 정의
            int vRow = 0;
            for (int i = fgrid_yield.Rows.Fixed; i < fgrid_yield.Rows.Count; i++)
                if (fgrid_yield[i, 0].ToString() != "") vRow++;

            int vCnt = vCol * vRow;
            MyOraDB.Parameter_Values = new string[vCnt];

            vCnt = 0;
            for (int i = fgrid_yield.Rows.Fixed; i < fgrid_yield.Rows.Count; i++)
            {
                if (fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML.lxDIVISION].ToString() == "") continue;

                MyOraDB.Parameter_Values[vCnt++] = fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxDIVISION].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[vCnt++] = fgrid_style[fgrid_style.Selection.r1, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_SEQ_NO].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_UNIT].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_SPEC].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = ClassLib.ComVar.This_User;

                fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxDIVISION] = "";
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Confirm
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_style.Rows.Fixed; i < fgrid_style.Rows.Count; i++)
                {
                    if ((fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE].ToString() == "False")) continue;

                    string vFactory  = COM.ComVar.This_Factory;
                    string vStyle    = fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString();
                    string vNike_Dim = fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxNIKE_XDM_DIM_CD].ToString();

                    Save_Confirm_Yield(vFactory, vStyle, vNike_Dim);


                    fgrid_style[i, 0] = "";
                    fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE] = "False";

                    fgrid_style.TopRow = i;
                }


                tbtn_Search_Click(null, null);
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

        private void Save_Confirm_Yield(string arg_factory, string arg_style_cd, string arg_nike_xdm_dim_cd)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxd_smf_xml.save_conform_sxd_smf_xml_load";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "arg_pcc";
            MyOraDB.Parameter_Name[1] = "arg_style_cd";
            MyOraDB.Parameter_Name[2] = "arg_nike_xdm_dim_cd";
            MyOraDB.Parameter_Name[3] = "arg_upd_user";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_style_cd;
            MyOraDB.Parameter_Values[2] = arg_nike_xdm_dim_cd;
            MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;


            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Create XML
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (Set_Folder() == false) return;

                int sct_row = fgrid_style.Selection.r1;
                int sct_col = fgrid_style.Selection.c1;

                for (int i = fgrid_style.Rows.Fixed; i < fgrid_style.Rows.Count; i++)
                {


                    if ((fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE].ToString() == "False")) continue;


                    if (fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSTATUS].ToString() != ClassLib.ComVar.ConsCFM_C)
                    {

                        ClassLib.ComFunction.User_Message("Not Comfirm Style : " + fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString(), "Confirm Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        fgrid_style[i, 0] = "";
                        fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE] = "False";
                        continue;
                    }
                    else
                    {

                        Create_Xml(fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxFACTORY].ToString(),
                                   fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSEASON_CD].ToString(),
                                   fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxDEV_CD].ToString(),
                                   fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString(),
                                   fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxNIKE_XDM_DIM_CD].ToString());


                        fgrid_style[i, 0] = "";

                    }


                    fgrid_style.TopRow = i;


                }


                ClassLib.ComFunction.User_Message("Finish making Xml File ", "Xml Job", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tbtn_Search_Click(null, null);
                fgrid_style.Select(sct_row, sct_col);
            }
            catch
            {
 
            }
        }

        private bool Set_Folder()
        {
            try
            {
                
                saveFileDialog1.InitialDirectory = @"C:\Documents and Settings\All Users\바탕 화면";
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.Filter = "XML File (*.xml)|*.xml";
                saveFileDialog1.FilterIndex = 0;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = COM.ComVar.This_Factory; // txt_srfno.Text + "-" + txt_bomid.Text;

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return false;

                //int vLenghSatart  =  saveFileDialog1.FileName.Length;
                int vLenghEnd = saveFileDialog1.FileName.Length - 7;


                _Save_Dir = saveFileDialog1.FileName.Substring(0, vLenghEnd);



                return true;
            }
            catch
            {
                return false;

            }


        }
        private bool Create_Xml(string arg_factory, string arg_season, string arg_dev_cd, string arg_style_cd, string arg_style_dim)
        {

            try
            {

                #region XML위한 폴더 만들기

                if (!Directory.Exists(_Save_Dir))
                {
                    Directory.CreateDirectory(_Save_Dir);

                }

                if (!Directory.Exists(_Save_Dir))
                {
                    Directory.CreateDirectory(_Save_Dir);
                }


                #endregion

                #region XML 파일 생성 준비

                //XML 속성 정의
                XmlDocument doc = new XmlDocument();
                string v_xmlfilename = null;
                string v_xmlfullname = null;

                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "", "yes");
                doc.PrependChild(dec);

                StringWriter writerString = new StringWriter();
                XmlTextWriter writer = new XmlTextWriter(writerString);


                //XML 파일생성, Document Start
                v_xmlfilename = arg_season + arg_dev_cd + "-" + arg_style_cd + ".XML";
                v_xmlfullname = _Save_Dir + "\\" + v_xmlfilename;


                //파일존재 유무 확인
                FileInfo file_info = new FileInfo(v_xmlfullname);

                if (file_info.Exists)
                {
                    file_info.Delete();
                    file_info.Create().Close();
                }
                else
                {
                    file_info.Create().Close();
                }


                //XML작업준비 
                writer = new XmlTextWriter(v_xmlfullname, Encoding.Unicode);
                writer.WriteStartDocument(true);




                #endregion

                #region 채산값 XML만들기


                string v_fieldName = "";
                string v_fieldData = "";

                DataSet dt_set;
                dt_set = Select_Create_Sdd_Smf_Xml(arg_style_cd);

                for (int i = 0; i < dt_set.Tables[0].Rows.Count; i++)
                {

                    if (i == 0)
                    {
                        //1level 처리하기
                        writer.WriteStartElement("Root", "");

                        //2level 처리하기   
                        writer.WriteElementString("pcc", "CS");
                        writer.WriteStartElement("ProductCode", "");
                        for (int j = (int)ClassLib.TBSXD_SMF_XML_CREATE.lxNIKE_SY_STY_NBR - 1; j <= (int)ClassLib.TBSXD_SMF_XML_CREATE.lxNIKE_MODEL_OFFERING_ID - 1; j++)
                        {

                            v_fieldName = dt_set.Tables[0].Columns[j].ColumnName.ToString().ToLower();
                            v_fieldData = dt_set.Tables[0].Rows[i].ItemArray[j].ToString() == null ? "null" : dt_set.Tables[0].Rows[i].ItemArray[j].ToString();

                            writer.WriteElementString(v_fieldName, v_fieldData);
                        }

                    }


                    //3level 처리하기
                    writer.WriteStartElement("MaterialByColor", "");
                    for (int j = (int)ClassLib.TBSXD_SMF_XML_CREATE.lxNIKE_MATERIAL_ID - 1; j <= (int)ClassLib.TBSXD_SMF_XML_CREATE.lxNIKE_COLOR_CD - 1; j++)
                    {

                        v_fieldName = dt_set.Tables[0].Columns[j].ColumnName.ToString().ToLower();
                        v_fieldData = dt_set.Tables[0].Rows[i].ItemArray[j].ToString() == "" ? " " : dt_set.Tables[0].Rows[i].ItemArray[j].ToString();
                        //v_fieldData = dt_set.Tables[0].Rows[i].ItemArray[j].ToString() == null ? " " : dt_set.Tables[0].Rows[i].ItemArray[j].ToString();
                        writer.WriteElementString(v_fieldName, v_fieldData);


                        //4level 처리하기

                        if (j == (int)ClassLib.TBSXD_SMF_XML_CREATE.lxNIKE_COLOR_CD - 1)
                        {
                            writer.WriteStartElement("Part", "");
                            for (int k = (int)ClassLib.TBSXD_SMF_XML_CREATE.lxPCC_SEQ_NO - 1; k <= (int)ClassLib.TBSXD_SMF_XML_CREATE.lxPCC_QTYUOM - 1; k++)
                            {

                                v_fieldName = dt_set.Tables[0].Columns[k].ColumnName.ToString().ToLower().Replace("uom", "UOM");
                                v_fieldData = dt_set.Tables[0].Rows[i].ItemArray[k].ToString() == "" ? " " : dt_set.Tables[0].Rows[i].ItemArray[k].ToString();

                                writer.WriteElementString(v_fieldName, v_fieldData);
                            }

                            writer.WriteEndElement();   //5레벨 마무리
                            writer.Flush();
                        }

                    }

                    //3level 마무리하기 
                    writer.WriteEndElement();
                    writer.Flush();


                    if (i == dt_set.Tables[0].Rows.Count - 1)
                    {

                        //2level 마무리하기 
                        writer.WriteEndElement();
                        writer.Flush();

                        //1level 마무리하기 
                        writer.WriteEndElement();
                        writer.Flush();
                        writer.Close();
                    }

                }



                #endregion


                #region Xml Flag 수정하기

                if (Save_Xml_Flag(arg_factory, arg_style_cd, arg_style_dim) != true) return false;

                #endregion


                return true;

            }
            catch
            {
                return false;
                //ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.Use(ex.Message, "Creat XlM : " + arg_style_cd , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private DataSet Select_Create_Sdd_Smf_Xml(string arg_style_cd)
        {

            try
            {

                DataSet ds_ret;


                string process_name = "PKG_SXD_SMF_XML_SELECT. select_create_sxd_smf_xml_load";

                MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_style_cd";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_style_cd;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;


            }
            catch
            {
                return null;

            }


        }

        public bool Save_Xml_Flag(string arg_factory, string arg_style_cd, string arg_style_dim)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXD_SMF_XML.save_load_sxd_smf_xml_load";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "arg_pcc";
                MyOraDB.Parameter_Name[1] = "arg_style_cd";
                MyOraDB.Parameter_Name[2] = "arg_nike_xdm_dim_cd";
                MyOraDB.Parameter_Name[3] = "arg_upd_user";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_style_dim;
                MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;


                MyOraDB.Add_Modify_Parameter(true);

                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Print
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                //Report.Form_SD_Report_Viewer viewer = null;
                //string report_file_name = null;


                //report_file_name = @"\report\XML_Create_List.mrd";


                //viewer = new FlexDevelop.Report.Form_SD_Report_Viewer(Application.StartupPath + report_file_name, "/rp [" + cmb_factory.SelectedValue.ToString() + "] [" + cmb_season_cd.SelectedValue.ToString() + "]  [" + txt_style.Text.ToUpper() + "]");
                //viewer.ShowDialog();

            }
            catch
            {


            }
            finally
            {

            }
        }
        #endregion

        #region Grid Event
        private void fgrid_style_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //temp table에 데이타가 있으면 조회하기-----------------------------   
                //하단 자동 조회
                _select_row = fgrid_style.Selection.r1;

                string vFactory = fgrid_style[fgrid_style.Selection.r1, (int)ClassLib.TBSXD_SMF_XML.lxFACTORY].ToString();
                string vStyle   = fgrid_style[fgrid_style.Selection.r1, (int)ClassLib.TBSXD_SMF_XML.lxSTYLE_CD].ToString();


                DataTable dt_ret = Select_Yield_List(vStyle);
                fgrid_yield.Rows.Count = fgrid_yield.Rows.Fixed;

                if (dt_ret.Rows.Count != 0)
                {
                    Display_FlexGrid(fgrid_yield, dt_ret);
                }
                else
                {
                    if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to make Usage Data?", "Usage", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        //Usage Data 만들기
                        

                        if (Check_Create_Yield(_select_row) != true) return;
                        Save_Create_Yield(vFactory, vStyle);

                        fgrid_style[fgrid_style.Selection.r1, 0] = "";

                        dt_ret = Select_Yield_List(vStyle);

                        if (dt_ret.Rows.Count > 0)
                        {
                            fgrid_yield.Rows.Count = fgrid_yield.Rows.Fixed;
                            Display_FlexGrid(fgrid_yield, dt_ret);

                            fgrid_style[fgrid_style.Selection.r1, (int)ClassLib.TBSXD_SMF_XML.lxSTATUS] = "C";
                            fgrid_style[fgrid_style.Selection.r1, (int)ClassLib.TBSXD_SMF_XML.lxSTATUS_DESC] = "Loaded";
                        }
                    }
                }

                
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

        private void fgrid_yield_EnterCell(object sender, EventArgs e)
        {
            try
            {
                _Before_Data = fgrid_yield[fgrid_yield.Selection.r1, fgrid_yield.Selection.c1].ToString();
            }
            catch
            {

            }
        }
        private void fgrid_yield_AfterEdit(object sender, RowColEventArgs e)
        {
            int sct_row = fgrid_yield.Selection.r1;

            if (Check_Yield_Change(sct_row) == false) return;

            fgrid_yield.Update_Row(sct_row);
            Change_Col_Data(sct_row);
        }
        private void fgrid_yield_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_yield.Selection.r1;
                int sct_col = fgrid_yield.Selection.c1;

                if (sct_col != (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_SPECNAME) return;

                string arg_factory = COM.ComVar.This_Factory;
                string arg_unit_cd = fgrid_yield[sct_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_UNIT].ToString();

                Pop_Without_Bom_Spec pop = new Pop_Without_Bom_Spec(this, arg_factory, arg_unit_cd);
                pop.ShowDialog();
            }
            catch
            {
 
            }
        }
        

        private bool Check_Create_Yield(int arg_row)
        {

            if (fgrid_style[arg_row, (int)ClassLib.TBSXD_SMF_XML.lxFACTORY].ToString() == "")
            {
                ClassLib.ComFunction.User_Message("Not Factory", "Check_Create_Yield", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (fgrid_style[arg_row, (int)ClassLib.TBSXD_SMF_XML.lxDEV_CD].ToString() == "")
            {
                ClassLib.ComFunction.User_Message("Not DevCode", "Check_Create_Yield", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }
        private bool Check_Yield_Change(int arg_row)
        {
            try
            {
                if (fgrid_yield.Selection.c1 == (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD)
                    if ((fgrid_yield[arg_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD] == null) ||
                        (fgrid_yield[arg_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD].ToString() == "0"))
                    {
                        ClassLib.ComFunction.User_Message("Value Error", "Yield Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        fgrid_yield[arg_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD] = _Before_Data;
                        return false;
                    }

                return true;

            }
            catch
            {
                return false;

            }



        }
        private void Change_Col_Data(int arg_row)
        {
            switch (fgrid_yield.Selection.c1)
            {
                case (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_UNIT:
                    {
                        for (int i = fgrid_yield.Rows.Fixed; i < fgrid_yield.Rows.Count; i++)
                            if (fgrid_yield.Rows[i].Selected == true)
                            {
                                fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_UNIT]
                                    = fgrid_yield[arg_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_UNIT].ToString();

                                fgrid_yield.Update_Row(i);
                            }
                        break;
                    }

                case (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD:
                    {
                        for (int i = fgrid_yield.Rows.Fixed; i < fgrid_yield.Rows.Count; i++)
                            if (fgrid_yield.Rows[i].Selected == true)
                            {
                                fgrid_yield[i, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD]
                                    = fgrid_yield[arg_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_YIELD].ToString();

                                fgrid_yield.Update_Row(i);
                            }
                        break;
                    }
            }
        }        
        #endregion

        #region ContextMenu Event
        private void mnu_all_check_Click(object sender, EventArgs e)
        {
            if (fgrid_style[fgrid_style.Rows.Fixed, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE].ToString() == "False")
            {
                for (int i = fgrid_style.Rows.Fixed; i < fgrid_style.Rows.Count; i++)
                    fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE] = "True";
            }
            else
            {
                for (int i = fgrid_style.Rows.Fixed; i < fgrid_style.Rows.Count; i++)
                    fgrid_style[i, (int)ClassLib.TBSXD_SMF_XML.lxXML_CREATE] = "False";
            }
        }

        private void mnu_spec_change_Click(object sender, EventArgs e)
        {
            int sct_row = fgrid_yield.Selection.r1;
            int sct_col = fgrid_yield.Selection.c1;

            string arg_factory = COM.ComVar.This_Factory;
            string arg_unit_cd = fgrid_yield[sct_row, (int)ClassLib.TBSXD_SMF_XML_TAIL.lxPCC_UNIT].ToString();
            
            Pop_Without_Bom_Spec pop = new Pop_Without_Bom_Spec(this, arg_factory, arg_unit_cd);
            pop.ShowDialog();
        } 
        #endregion
                
    }
}

