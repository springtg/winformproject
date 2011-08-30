using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace FlexCosting.Costing.Frm
{

    public partial class Form_CBD_XML_Create : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();
        #endregion

        #region Constructor
        public Form_CBD_XML_Create()
        {
            InitializeComponent();
        }
        #endregion       

        #region Form Loading
        private void Form_CBD_XML_Create_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Init_Form()
        {
            //Title
            this.Text = "CBD XML Create";
            this.lbl_MainTitle.Text = "CBD XML Create";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_main.Set_Grid("SFX_CBD_XML_CREATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.ExtendLastCol = false;
            fgrid_main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            fgrid_main.Font = new Font(fgrid_main.Font.FontFamily, (float)8.5);            
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Prod_Factory_List_Cost();
            COM.ComCtl.Set_ComboList(vDT, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 0;
            vDT.Dispose();

            // Season
            ClassLib.ComFunction_Cost comFnc = new ClassLib.ComFunction_Cost();
            vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_season, 0, 1, true, false);
            cmb_season.SelectedIndex = 0;            
            vDT.Dispose();

            // Category
            vDT = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "MD02");
            COM.ComCtl.Set_ComboList(vDT, cmb_category, 1, 2, true, false);
            cmb_category.SelectedIndex = 0;
            vDT.Dispose();

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_style_cd.CharacterCasing = CharacterCasing.Upper;
            txt_bom_id.CharacterCasing = CharacterCasing.Upper;
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Display_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Display_Data()
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            string[] arg_value = new string[5];

            arg_value[0] = cmb_Factory.SelectedValue.ToString().Trim();
            arg_value[1] = cmb_season.SelectedValue.ToString().Trim();
            arg_value[2] = cmb_category.SelectedValue.ToString().Trim();
            arg_value[3] = txt_style_cd.Text.Trim();
            arg_value[4] = txt_bom_id.Text.Trim();

            DataTable dt_ret = SELECT_CBD_XML_CREATE(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();
                int row = fgrid_main.Rows.Count - 1;

                for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j];
                }

                fgrid_main.GetCellRange(row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxDIV, row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCBD_SEQ).StyleNew.BackColor = Color.White;
                fgrid_main.GetCellRange(row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCHK).StyleNew.BackColor = Color.FloralWhite;
                fgrid_main.GetCellRange(row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxDEV_FAC_V, row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxFOB_STATUS).StyleNew.BackColor = Color.White;
            } 
        }

        private DataTable SELECT_CBD_XML_CREATE(string[] arg_value)
        {
            try
            {                
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_XML_CREATE.SELECT_CBD_XML_CREATE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON";
                MyOraDB.Parameter_Name[2] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vds_ret = MyOraDB.Exe_Select_Procedure();

                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        #region ContextMenu Event
        private void mnu_create_xml_Click(object sender, EventArgs e)
        {
            try
            {
                if (Create_XML_File())
                    MessageBox.Show("Create Compelted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private bool Create_XML_File()
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) return false;
                string dialog_path = folderBrowserDialog1.SelectedPath;


                int row_cnt = 0;
                XmlDocument doc = new XmlDocument();
                string filr_path = "";

                for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
                {
                    string _chk = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCHK] == null) ? "FALSE" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCHK].ToString().Trim().ToUpper();

                    if (_chk.Equals("TRUE"))
                    {
                        string _style_cd = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxSTYLE_CD] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxSTYLE_CD].ToString().Trim().Replace("-", "");

                        if (_style_cd.Length.Equals(9))
                        {
                            if (row_cnt.Equals(0))
                            {
                                #region	XMl 만들기
                                doc = new XmlDocument();
                                string _bom_id = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxBOM_ID] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxBOM_ID].ToString().Trim();

                                filr_path = dialog_path + @"\" + _bom_id + "-" + _style_cd + ".xml";


                                FileInfo file_info = new FileInfo(filr_path);

                                if (file_info.Exists)
                                {
                                    file_info.Delete();
                                    file_info.Create().Close();
                                }
                                else
                                {
                                    file_info.Create().Close();
                                }

                                doc.Load(Application.StartupPath + @"\default.xml");
                                doc.Save(filr_path);
                                doc.Load(filr_path);
                                #endregion

                                XmlElement Pcc = doc.CreateElement("pcc");
                                XmlElement Pcc_list = doc.DocumentElement;
                                Pcc_list.AppendChild(Pcc);
                                XmlText Pcc_text = doc.CreateTextNode("DS");
                                Pcc.AppendChild(Pcc_text);
                            }


                            string[] arg_value = new string[5];
                            arg_value[0] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxDEV_FAC] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxDEV_FAC].ToString().Trim();
                            arg_value[1] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxMOID] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxMOID].ToString().Trim();
                            arg_value[2] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCBD_ID] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCBD_ID].ToString().Trim();
                            arg_value[3] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxFOB_TYPE_CD] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxFOB_TYPE_CD].ToString().Trim();
                            arg_value[4] = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCBD_SEQ] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxCBD_SEQ].ToString().Trim();


                            #region 반복부
                            DataTable dt = SELECT_CREATE_XML_HEAD(arg_value);

                            int _Data_row = 0;

                            int _col_nike_sy_sty_nbr = 0;
                            int _col_nike_sy_colr_cd_id = 1;
                            int _col_nike_xdm_dim_cd = 2;
                            int _col_nike_srf_no = 3;
                            int _col_nike_dev_code = 4;


                            XmlElement ProductCode = doc.CreateElement("ProductCode");
                            XmlElement ProductCode_list = doc.DocumentElement;
                            ProductCode_list.AppendChild(ProductCode);

                            //nike_sy_sty_nbr
                            XmlElement nike_sy_sty_nbr = doc.CreateElement("nike_sy_sty_nbr");
                            ProductCode.AppendChild(nike_sy_sty_nbr);
                            XmlText nike_sy_sty_nbr_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_sy_sty_nbr].ToString());
                            nike_sy_sty_nbr.AppendChild(nike_sy_sty_nbr_text);


                            //nike_sy_colr_cd_id
                            XmlElement nike_sy_colr_cd_id = doc.CreateElement("nike_sy_colr_cd_id");
                            ProductCode.AppendChild(nike_sy_colr_cd_id);
                            XmlText nike_sy_colr_cd_id_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_sy_colr_cd_id].ToString());
                            nike_sy_colr_cd_id.AppendChild(nike_sy_colr_cd_id_text);


                            //nike_xdm_dim_cd
                            XmlElement nike_xdm_dim_cd = doc.CreateElement("nike_xdm_dim_cd");
                            ProductCode.AppendChild(nike_xdm_dim_cd);
                            XmlText nike_xdm_dim_cd_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_xdm_dim_cd].ToString());
                            nike_xdm_dim_cd.AppendChild(nike_xdm_dim_cd_text);


                            //nike_bom_id
                            XmlElement nike_srf_no = doc.CreateElement("nike_bom_id");
                            ProductCode.AppendChild(nike_srf_no);
                            XmlText nike_srf_no_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_srf_no].ToString());
                            nike_srf_no.AppendChild(nike_srf_no_text);


                            //nike_model_offerings_id
                            XmlElement nike_dev_code = doc.CreateElement("nike_model_offering_id");
                            ProductCode.AppendChild(nike_dev_code);
                            XmlText nike_dev_code_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_dev_code].ToString());
                            nike_dev_code.AppendChild(nike_dev_code_text);

                            dt = SELECT_CREATE_XML_TAIL(arg_value);

                            int dt_row = dt.Rows.Count;
                            int dt_col = dt.Columns.Count;

                            int _col_nike_material_id = 0;
                            int _col_nike_material_by_supplier = 1;
                            int _col_nike_color_cd = 2;
                            int _col_pcc_seq_no = 3;
                            int _col_pcc_part_name = 4;
                            int _col_pcc_yield = 5;
                            int _col_pcc_loss_percent = 6;
                            int _col_pcc_usage = 7;
                            int _col_pcc_length = 8;
                            int _pcc_lengthUOM = 9;
                            int _pcc_width = 10;
                            int _col_pcc_widthUOM = 11;
                            int _col_pcc_qtyUOM = 12;

                            for (int i = 0; i < dt_row; i++)
                            {

                                //MaterialByColor
                                XmlElement MaterialByColor = doc.CreateElement("MaterialByColor");
                                ProductCode.AppendChild(MaterialByColor);

                                //nike_material_id
                                XmlElement nike_material_id = doc.CreateElement("nike_material_id");
                                MaterialByColor.AppendChild(nike_material_id);
                                XmlText nike_material_id_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_nike_material_id].ToString());
                                nike_material_id.AppendChild(nike_material_id_text);


                                //nike_material_by_supplier
                                XmlElement nike_material_by_supplier = doc.CreateElement("nike_material_by_supplier");
                                MaterialByColor.AppendChild(nike_material_by_supplier);
                                XmlText nike_material_by_supplier_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_nike_material_by_supplier].ToString());
                                nike_material_by_supplier.AppendChild(nike_material_by_supplier_text);

                                //nike_color_cd
                                XmlElement nike_color_cd = doc.CreateElement("nike_color_cd");
                                MaterialByColor.AppendChild(nike_color_cd);
                                XmlText nike_color_cd_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_nike_color_cd].ToString());
                                nike_color_cd.AppendChild(nike_color_cd_text);

                                XmlElement Part = doc.CreateElement("Part");
                                MaterialByColor.AppendChild(Part);

                                XmlElement pcc_seq_no = doc.CreateElement("pcc_seq_no");
                                Part.AppendChild(pcc_seq_no);
                                XmlText pcc_seq_no_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_seq_no].ToString());
                                pcc_seq_no.AppendChild(pcc_seq_no_text);

                                XmlElement pcc_part_name = doc.CreateElement("pcc_part_name");
                                Part.AppendChild(pcc_part_name);
                                XmlText pcc_part_name_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_part_name].ToString());
                                pcc_part_name.AppendChild(pcc_part_name_text);

                                XmlElement pcc_yield = doc.CreateElement("pcc_yield");
                                Part.AppendChild(pcc_yield);
                                XmlText pcc_yield_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_yield].ToString());
                                pcc_yield.AppendChild(pcc_yield_text);

                                XmlElement pcc_loss_percent = doc.CreateElement("pcc_loss_percent");
                                Part.AppendChild(pcc_loss_percent);
                                XmlText pcc_loss_percent_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_loss_percent].ToString());
                                pcc_loss_percent.AppendChild(pcc_loss_percent_text);

                                XmlElement pcc_usage = doc.CreateElement("pcc_usage");
                                Part.AppendChild(pcc_usage);
                                XmlText pcc_usage_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_usage].ToString());
                                pcc_usage.AppendChild(pcc_usage_text);

                                XmlElement pcc_length = doc.CreateElement("pcc_length");
                                Part.AppendChild(pcc_length);
                                XmlText pcc_length_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_length].ToString());
                                pcc_length.AppendChild(pcc_length_text);

                                XmlElement pcc_lengthUOM = doc.CreateElement("pcc_lengthUOM");
                                Part.AppendChild(pcc_lengthUOM);
                                XmlText pcc_lengthUOM_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_pcc_lengthUOM].ToString());
                                pcc_lengthUOM.AppendChild(pcc_lengthUOM_text);

                                XmlElement pcc_width = doc.CreateElement("pcc_width");
                                Part.AppendChild(pcc_width);
                                XmlText pcc_width_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_pcc_width].ToString());
                                pcc_width.AppendChild(pcc_width_text);

                                XmlElement pcc_widthUOM = doc.CreateElement("pcc_widthUOM");
                                Part.AppendChild(pcc_widthUOM);
                                XmlText pcc_widthUOM_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_widthUOM].ToString());
                                pcc_widthUOM.AppendChild(pcc_widthUOM_text);

                                XmlElement pcc_qtyUOM = doc.CreateElement("pcc_qtyUOM");
                                Part.AppendChild(pcc_qtyUOM);
                                XmlText pcc_qtyUOM_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_qtyUOM].ToString());
                                pcc_qtyUOM.AppendChild(pcc_qtyUOM_text);
                            }
                            #endregion

                            if (row_cnt.Equals(30))
                            {
                                doc.Save(filr_path);
                            }

                            row_cnt++;

                            if (row_cnt > 30)
                                row_cnt = 0;
                        }
                        else
                        {
                            string _moid = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxMOID_V] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxMOID_V].ToString().Trim();
                            string _bom_id = (fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxBOM_ID] == null) ? "" : fgrid_main[row, (int)ClassLib.TBSFX_CBD_XML_CREATE.IxBOM_ID].ToString().Trim();

                            ClassLib.ComFunction.User_Message("No Style :" + _moid + "-" + _bom_id, "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

                if (row_cnt < 30)
                    doc.Save(filr_path);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }        

        private DataTable SELECT_CREATE_XML_HEAD(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = "PKG_SFX_CBD_XML_CREATE.SELECT_CREATE_XML_HEAD";

                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private DataTable SELECT_CREATE_XML_TAIL(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = "PKG_SFX_CBD_XML_CREATE.SELECT_CREATE_XML_TAIL";

                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }       
        #endregion

        #region Control Event
        private void txt_style_cd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Display_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txt_bom_id_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Display_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        
    }
}


