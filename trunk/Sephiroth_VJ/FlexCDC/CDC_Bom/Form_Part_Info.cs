using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace FlexCDC.CDC_Bom
{
    public partial class Form_Part_Info : COM.PCHWinForm.Form_Top
    {

        #region 사용자 정의 변수 
        private COM.OraDB OraDB = new COM.OraDB();
        private int _RowFixed_Bom = 0;
        private int _RowFixed_part = 0;

        private int show_level = 0;
        #endregion

        public Form_Part_Info()
        {
            InitializeComponent();
        }

        private void Form_Part_Info_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {
 
            }
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


        #region 공통 메서드
        private void Init_Form()
        {
            this.Text = "PCC_PART Information";
            this.lbl_MainTitle.Text = "PCC_PART Information";
            ClassLib.ComFunction.SetLangDic(this);
            
            //ComboBox Setting
            DataTable dt = Select_sxd_mo_name();
            ClassLib.ComCtl.Set_ComboList(dt, cmb_model, 0, 0, false, false);
            cmb_model.SelectedIndex = -1;

            #region Grid Setting
            flg_bom.Set_Grid_CDC("SXD_PART_INFO", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_bom.Set_Action_Image(img_Action);
            flg_bom.ExtendLastCol = false;
            _RowFixed_Bom = flg_bom.Rows.Fixed;

            flg_part_info.Set_Grid_CDC("SXD_PART_INFO", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_part_info.Set_Action_Image(img_Action);
            flg_part_info.ExtendLastCol = false;
            _RowFixed_part = flg_part_info.Rows.Fixed;
            #endregion

            #region Button Setting
            tbtn_Append.Enabled  = false;
            tbtn_Color.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Insert.Enabled  = false;
            tbtn_New.Enabled     = false;            
            tbtn_Save.Enabled    = false;

            tbtn_Search.Enabled  = true;
            tbtn_Print.Enabled = true;
            #endregion

            flg_part_info.Tree.Column = (int)ClassLib.TBSXD_PART_INFO1.IxCOL1;
            txt_mo_name.Text = "";
            txt_mo_name.CharacterCasing = CharacterCasing.Upper;

        }
        #endregion

        #region 이벤트 처리

        #region Button Event
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                //Check 된 Row를 업데이트
                for (int i = _RowFixed_Bom; i < flg_bom.Rows.Count; i++)
                {
                    string arg_factory = flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxFACTORY].ToString();
                    string arg_sr_no = flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxSR_NO].ToString();
                    string arg_srf_no = flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxSRF_NO].ToString();
                    string arg_bom_id = flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxBOM_ID].ToString();
                    string arg_bom_rev = flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxBOM_REV].ToString();
                    string arg_nf_cd = flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxNF_CD].ToString();
                    string arg_chk_flg = ((flg_bom[i, (int)ClassLib.TBSXD_PART_INFO.IxCHK].Equals(true)) ? "Y" : "N");
                    Change_chk_flg(arg_factory, arg_sr_no, arg_srf_no, arg_bom_id, arg_bom_rev, arg_nf_cd, arg_chk_flg);
                }

                flg_part_info.Rows.Count = _RowFixed_part;


                if (!cmb_model.SelectedIndex.Equals(-1))
                {
                    string arg_factory = cmb_factory.SelectedValue.ToString();
                    string arg_dev_name = cmb_model.SelectedValue.ToString();
                    string arg_sct_tyep = "P";

                    if (rad_part.Checked)
                    {
                        flg_part_info.Set_Grid_CDC("SXD_PART_INFO", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                        flg_part_info.Set_Action_Image(img_Action);
                        flg_part_info.ExtendLastCol = false;
                        _RowFixed_part = flg_part_info.Rows.Fixed;

                        contextMenuStrip1.Items[0].Text = "Part";
                        contextMenuStrip1.Items[1].Text = "BOM";

                        arg_sct_tyep = "P";

                        flg_part_info.Tree.Column = (int)ClassLib.TBSXD_PART_INFO1.IxCOL1;
                        DataTable dt = Select_part_in(arg_factory, arg_dev_name, arg_sct_tyep);

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_PART_INFO1.IxT_LEV].ToString());
                                flg_part_info.Rows.InsertNode(flg_part_info.Rows.Count, t_level);

                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    flg_part_info[flg_part_info.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                                    if (j == (int)ClassLib.TBSXD_PART_INFO1.IxT_LEV)
                                    {
                                        if (dt.Rows[i].ItemArray[j].Equals("0"))
                                        {
                                            flg_part_info.Rows[flg_part_info.Rows.Count - 1].AllowEditing = true;
                                        }
                                        else
                                        {
                                            flg_part_info.Rows[flg_part_info.Rows.Count - 1].AllowEditing = false;
                                            flg_part_info.Rows[flg_part_info.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                                        }
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        flg_part_info.Set_Grid_CDC("SXD_PART_INFO", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                        flg_part_info.Set_Action_Image(img_Action);
                        flg_part_info.ExtendLastCol = false;
                        _RowFixed_part = flg_part_info.Rows.Fixed;

                        contextMenuStrip1.Items[0].Text = "BOM";
                        contextMenuStrip1.Items[1].Text = "Part";

                        arg_sct_tyep = "B";

                        flg_part_info.Tree.Column = (int)ClassLib.TBSXD_PART_INFO2.IxCOL1;
                        DataTable dt = Select_part_in(arg_factory, arg_dev_name, arg_sct_tyep);

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_PART_INFO2.IxT_LEV].ToString());
                                flg_part_info.Rows.InsertNode(flg_part_info.Rows.Count, t_level);

                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    flg_part_info[flg_part_info.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                                    if (j == (int)ClassLib.TBSXD_PART_INFO2.IxT_LEV)
                                    {
                                        if (dt.Rows[i].ItemArray[j].Equals("0"))
                                        {
                                            flg_part_info.Rows[flg_part_info.Rows.Count - 1].AllowEditing = true;
                                        }
                                        else
                                        {
                                            flg_part_info.Rows[flg_part_info.Rows.Count - 1].AllowEditing = false;
                                            flg_part_info.Rows[flg_part_info.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    flg_part_info.Tree.Show(show_level);
                }
            }
            catch
            {
 
            }
        }
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";
                string factory = cmb_factory.SelectedValue.ToString();
                string dev_name = cmb_model.SelectedValue.ToString();

                if (rad_part.Checked)
                {
                    mrd_Filename = Application.StartupPath + @"\Part_Information_P" + ".mrd";
                    sPara = " /rp " + "[" + factory + "]" + " [" + dev_name + "]" + " [P]";
                }
                else if (rad_bom.Checked)
                {
                    mrd_Filename = Application.StartupPath + @"\Part_Information_B" + ".mrd";
                    sPara = " /rp " + "[" + factory + "]" + " [" + dev_name + "]" + " [B]";
                }

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotPrint, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #endregion

        #region Control Event
        private void txt_mo_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Select_sxd_mo_name();
                ClassLib.ComCtl.Set_ComboList(dt, cmb_model, 0, 0, false, false);
                cmb_model.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void cmb_model_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_model.SelectedIndex.Equals(-1))
            {
                tbtn_Search.Enabled = false;
                tbtn_Print.Enabled = false;
            }
            else
            {
                tbtn_Search.Enabled = true;
                tbtn_Print.Enabled = true;

                
                flg_bom.Rows.Count = _RowFixed_Bom;

                DataTable dt = Select_sxd_srf_head();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    flg_bom.AddItem(dt.Rows[i].ItemArray);
                }
                
            }
        }
        private void fgrid_detail_MouseEnter(object sender, EventArgs e)
        {
            //flg_bom
            flg_bom.Height = flg_bom.Height + flg_part_info.Height + 8;
            flg_part_info.Width = pnl_SearchImage.Width;
        }
       
        private void flg_bom_MouseLeave(object sender, EventArgs e)
        {
            flg_bom.Height = pnl_SearchImage.Height;
            flg_part_info.Width = flg_bom.Width + flg_part_info.Width + 8;
        }
        #endregion

        #region Context Menu Event
        private void mnu_part_Click(object sender, EventArgs e)
        {
            show_level = 0;
            flg_part_info.Tree.Show(show_level);
        }
        private void mnu_bom_Click(object sender, EventArgs e)
        {
            show_level = 1;
            flg_part_info.Tree.Show(show_level);
        }        
        #endregion


        #endregion

        #region DB Connect
        private DataTable Select_sxd_mo_name()
        {
            string Proc_Name = "PKG_SXD_SRF_02_SELECT.SELECT_SXD_DEV_NAME";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_dev_name";
            OraDB.Parameter_Name[2] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_mo_name.Text.Trim().ToUpper();
            OraDB.Parameter_Values[2] = "";



            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private void Change_chk_flg(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_chk_flg)
        {
            string Proc_Name = "pkg_sxd_srf_02.update_sxd_part_info_chk";

            OraDB.ReDim_Parameter(7);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "arg_chk_flg";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_sr_no;
            OraDB.Parameter_Values[2] = arg_srf_no;
            OraDB.Parameter_Values[3] = arg_bom_id;
            OraDB.Parameter_Values[4] = arg_bom_rev;
            OraDB.Parameter_Values[5] = arg_nf_cd;
            OraDB.Parameter_Values[6] = arg_chk_flg;


            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

        }
        private DataTable Select_sxd_srf_head()
        {
            string Proc_Name = "PKG_SXD_SRF_02_SELECT.SELECT_SXD_SRF_HEAD";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_dev_name";
            OraDB.Parameter_Name[2] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = cmb_model.SelectedValue.ToString();
            OraDB.Parameter_Values[2] = "";



            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_part_in(string arg_factory, string arg_dev_name, string arg_sct_type)
        {
            string Proc_Name = "PKG_SXD_SRF_02_SELECT.SELECT_SXD_PART_INFO";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_dev_name";
            OraDB.Parameter_Name[2] = "arg_sct_type";
            OraDB.Parameter_Name[3] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_dev_name;
            OraDB.Parameter_Values[2] = arg_sct_type;
            OraDB.Parameter_Values[3] = "";


            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion
    }
}

