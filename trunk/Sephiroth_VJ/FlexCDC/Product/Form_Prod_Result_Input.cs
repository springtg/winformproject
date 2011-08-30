using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;


namespace FlexCDC.Product
{
    public partial class Form_Prod_Result_Input : COM.PCHWinForm.Form_Top
    {
        private COM.OraDB OraDB = new COM.OraDB();
        private int _RowFixed = 0;
        private string settingfile = @"C:\sephroth_setting.ini";
        public Form_Prod_Result_Input()
        {
            InitializeComponent();
        }

        private void Form_Prod_Result_Input_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            //Init_Form();
        }

        private void Init_Form()
        {
            this.Text = "PCC_Outgoing Manager";
            this.lbl_MainTitle.Text = "PCC_Outgoing Manager";
            ClassLib.ComFunction.SetLangDic(this);








            dpk_dpk_work.Value = DateTime.Now;


            //get_out_no();


            flg_result.Set_Grid_CDC("SXG_PROD_RESULT_INPU", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_result.Set_Action_Image(img_Action);
            flg_result.ExtendLastCol = false;
            flg_result.Font = new Font("Verdana", 15, FontStyle.Bold);
            _RowFixed = flg_result.Rows.Count;


            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Search.Enabled = true;



            try
            {

                FileInfo settingFile = new FileInfo(settingfile);

                if (settingFile.Exists)
                {


                    string fullname = settingfile;
                    FileStream file = new FileStream(fullname, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);

                    string[] value = sr.ReadLine().Split(":".ToCharArray());

                    sr.Close();
                    file.Close();



                    txt_op_cd.Text = value[1];
                    txt_op_name.Text = value[2];


                }
                else
                {
                    MessageBox.Show("환경 파일이 없습니다. 설정 해 주십시요.");

                    Pop_OP_Setting opSetting = new Pop_OP_Setting(this);
                    opSetting.ShowDialog();

                }
            }
            catch
            {
                MessageBox.Show("환경 파일문제가 있습니다. 다시 설정 해 주십시요.");

                Pop_OP_Setting opSetting = new Pop_OP_Setting(this);
                opSetting.ShowDialog();
            }
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            
            flg_result.Rows.Count = _RowFixed;
            string arg_factory = cmb_factory.SelectedValue.ToString();
            string arg_set_date = dpk_dpk_work.Value.ToString("yyyyMMdd");
            string arg_op_cd = txt_op_cd.Text;


            DataTable dt = Select_sxg_prod_op_list(arg_factory, arg_set_date, arg_op_cd);


            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            if (dt_rows > 0)
            {
                for (int i = 0; i < dt_rows; i++)
                {
                    flg_result.AddItem(dt.Rows[i].ItemArray, flg_result.Rows.Count, 0);

                    if (flg_result[flg_result.Rows.Count-1, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxRST_YMD].Equals("No Scan"))
                    {
                        flg_result.GetCellRange(flg_result.Rows.Count - 1, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxRST_YMD, flg_result.Rows.Count - 1, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxRST_YMD).StyleNew.ForeColor = Color.Red;
                    }
                    //else
                    //{
                    //}
                }
            }
        }

        private DataTable Select_sxg_prod_op_list(string arg_factory, string arg_set_date, string arg_op_cd)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_OP_LIST";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SET_DATE";
            OraDB.Parameter_Name[2] = "ARG_OP_CD";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_set_date;
            OraDB.Parameter_Values[2] = arg_op_cd;
            OraDB.Parameter_Values[3] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }

        private void flg_result_AfterEdit(object sender, RowColEventArgs e)
        {
            int sct_row = flg_result.Selection.r1;
            int sct_col = flg_result.Selection.c1;
            flg_result.Update_Row(sct_row);
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_result.Select(flg_result.Selection.r1, 0, flg_result.Selection.r1, flg_result.Cols.Count - 1, false);

            for (int i = _RowFixed; i < flg_result.Rows.Count; i++)
            {
                if (flg_result[i, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxDIVISION].ToString().Equals("U"))
                {
                    string arg_bar_code = flg_result[i, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxBAR_CODE].ToString();
                    string arg_op_cd = flg_result[i, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxOP_CD].ToString();
                    string arg_op_qty = flg_result[i, (int)ClassLib.DBSELECT_SXG_PROD_OP_LIST.IxRST_QTY].ToString();

                    save_sxg_prod_result(arg_bar_code, arg_op_cd, arg_op_qty);
                }
            }


            tbtn_Search_Click(null, null);
        }

        private void save_sxg_prod_result(string arg_bar_code, string arg_op_cd, string arg_op_qty)
        {

            string Proc_Name = "PKG_SXG_PROD_01.SAVE_SXG_PROD_RESULT";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "ARG_OP_QTY";
            OraDB.Parameter_Name[3] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_bar_code;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = arg_op_qty;
            OraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private void btn_stting_Click(object sender, EventArgs e)
        {
            Pop_OP_Setting opSetting = new Pop_OP_Setting(this);
            opSetting.ShowDialog();
        }
    }
}

