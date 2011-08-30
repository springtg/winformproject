using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product_VJ
{
    public partial class Pop_Worksheet_Multi_Change_VJ : COM.PCHWinForm.Pop_Large_B
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string tmp_factory, tmp_lot_no, tmp_lot_seq;
        private Form_Worksheet_VJ tmp_ws_form = null;
        public bool save_flg = false;
        #endregion


        public Pop_Worksheet_Multi_Change_VJ()
        {
            InitializeComponent();
        }
        public Pop_Worksheet_Multi_Change_VJ(Form_Worksheet_VJ arg_ws_form, string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            tmp_ws_form = arg_ws_form;
            tmp_factory = arg_factory;
            tmp_lot_no  = arg_lot_no;
            tmp_lot_seq = arg_lot_seq;

            InitializeComponent();
        }

        private void Pop_Worksheet_Multi_Change_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Multi Change";
            this.lbl_MainTitle.Text = "PCC_Multi Change";
            
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Conform.Enabled = false;
            tbtn_Print.Enabled   = false;
            tbtn_Create.Enabled  = false;

            fgrid_worksheet.Set_Grid_CDC("SXE_WORKSHEET_POP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_worksheet.Rows.Count = fgrid_worksheet.Rows.Fixed;
            fgrid_worksheet.ExtendLastCol = false;


            Display_Data();
        }

        private void Display_Data()
        {
            DataTable dt = Select_data_list();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_worksheet.AddItem(dt.Rows[i].ItemArray);

                if (dt.Rows[i].ItemArray[(int)ClassLib.TBSXE_WORKSHEET_POP.IxLEV].ToString() == "1")
                {
                    fgrid_worksheet.Rows[fgrid_worksheet.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                    fgrid_worksheet.Rows[fgrid_worksheet.Rows.Count - 1].StyleNew.ForeColor = Color.DarkGray;
                    fgrid_worksheet.Rows[fgrid_worksheet.Rows.Count - 1].AllowEditing = false;
                }
                else
                {
                    fgrid_worksheet.Rows[fgrid_worksheet.Rows.Count - 1].StyleNew.BackColor = Color.White; 
                }
            }              
        }

        private DataTable Select_data_list()
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "pkg_sxg_mps_01_select.select_worksheet_pop";

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_lot_no";
            MyOraDB.Parameter_Name[2] = "arg_lot_seq";
            MyOraDB.Parameter_Name[3] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = tmp_factory;
            MyOraDB.Parameter_Values[1] = tmp_lot_no;
            MyOraDB.Parameter_Values[2] = tmp_lot_seq;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_worksheet.Rows.Fixed + 1; i < fgrid_worksheet.Rows.Count; i++)
                {                    
                    if (fgrid_worksheet[i, (int)ClassLib.TBSXE_WORKSHEET_POP.IxCHK].ToString() == "True")
                        Save_data(i);
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                save_flg = true;

                this.Close();
            }
        }
        private void Save_data(int arg_row)
        {
            MyOraDB.ReDim_Parameter(27);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_mps_01.save_sxd_specification_multi";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "arg_factory"; 
            MyOraDB.Parameter_Name[1]  = "arg_lot_no";  
            MyOraDB.Parameter_Name[2]  = "arg_lot_seq"; 
            MyOraDB.Parameter_Name[3]  = "arg_sample_wei";  
            MyOraDB.Parameter_Name[4]  = "arg_collar_hei";  
            MyOraDB.Parameter_Name[5]  = "arg_heel_hei";    
            MyOraDB.Parameter_Name[6]  = "arg_medial_hei";  
            MyOraDB.Parameter_Name[7]  = "arg_lateral_hei"; 
            MyOraDB.Parameter_Name[8]  = "arg_lace_len";    
            MyOraDB.Parameter_Name[9]  = "arg_ms_hardness"; 
            MyOraDB.Parameter_Name[10] = "arg_dispatch_ymd";
            MyOraDB.Parameter_Name[11] = "arg_cdc_dev";     
            MyOraDB.Parameter_Name[12] = "arg_nlo_dev";     
            MyOraDB.Parameter_Name[13] = "arg_fga_qty";     
            MyOraDB.Parameter_Name[14] = "arg_dispatch_qty";
            MyOraDB.Parameter_Name[15] = "arg_ids_length";  
            MyOraDB.Parameter_Name[16] = "arg_barcode_date";
            MyOraDB.Parameter_Name[17] = "arg_width";       
            MyOraDB.Parameter_Name[18] = "arg_fit";         
            MyOraDB.Parameter_Name[19] = "arg_upper_mat";   
            MyOraDB.Parameter_Name[20] = "arg_barcode";     
            MyOraDB.Parameter_Name[21] = "arg_lace_desc";   
            MyOraDB.Parameter_Name[22] = "arg_insole_desc"; 
            MyOraDB.Parameter_Name[23] = "arg_t_d";         
            MyOraDB.Parameter_Name[24] = "arg_ipw_date";    
            MyOraDB.Parameter_Name[25] = "arg_upd_user";
            MyOraDB.Parameter_Name[26] = "arg_tag_comment";
            
            
            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;
           

            //04. DATA 정의
            MyOraDB.Parameter_Values[0]   = fgrid_worksheet[arg_row, (int)ClassLib.TBSXE_WORKSHEET_POP.IxFACTORY].ToString();
            MyOraDB.Parameter_Values[1]   = fgrid_worksheet[arg_row, (int)ClassLib.TBSXE_WORKSHEET_POP.IxLOT_NO].ToString();
            MyOraDB.Parameter_Values[2]   = fgrid_worksheet[arg_row, (int)ClassLib.TBSXE_WORKSHEET_POP.IxLOT_SEQ].ToString();
            MyOraDB.Parameter_Values[3]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxSAMPLE_WEI].ToString();
            MyOraDB.Parameter_Values[4]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxCOLLAR_HEI].ToString();
            MyOraDB.Parameter_Values[5]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxHEEL_HEI].ToString();
            MyOraDB.Parameter_Values[6]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxMEDIAL_HEI].ToString();
            MyOraDB.Parameter_Values[7]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxLATERAL_HEI].ToString();
            MyOraDB.Parameter_Values[8]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxLACE_DESC].ToString();
            MyOraDB.Parameter_Values[9]   = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxSOLE_HARDNESS].ToString();
            MyOraDB.Parameter_Values[10]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxDISPATCH_YMD].ToString();
            MyOraDB.Parameter_Values[11]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxCDC_DEV].ToString();
            MyOraDB.Parameter_Values[12]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxNLO_DEV].ToString();
            MyOraDB.Parameter_Values[13]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxFGA_QTY].ToString();
            MyOraDB.Parameter_Values[14]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxDISPATCH_QTY].ToString();
            MyOraDB.Parameter_Values[15]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxIDS_LENGTH].ToString();
            MyOraDB.Parameter_Values[16]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxBARCODE_DATE].ToString();
            MyOraDB.Parameter_Values[17]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxWIDTH].ToString();
            MyOraDB.Parameter_Values[18]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxFIT].ToString();
            MyOraDB.Parameter_Values[19]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxUPPER_MAT].ToString();
            MyOraDB.Parameter_Values[20]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxBARCODE].ToString();
            MyOraDB.Parameter_Values[21]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxLACE_DESC].ToString();
            MyOraDB.Parameter_Values[22]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxINSOLE_DESC].ToString();
            MyOraDB.Parameter_Values[23]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxT_D].ToString();
            MyOraDB.Parameter_Values[24]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxIPW_YMD].ToString();
            MyOraDB.Parameter_Values[25]  = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[26]  = fgrid_worksheet[fgrid_worksheet.Rows.Fixed, (int)ClassLib.TBSXE_WORKSHEET_POP.IxTAG_COMMENT].ToString();              


            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        
    }
}

