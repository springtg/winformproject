using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Incomming
{
    public partial class Form_Incomming_Analysis : COM.PCHWinForm.Form_Top
    {
        public Form_Incomming_Analysis()
        {
            InitializeComponent();
        }

        #region 사용자 정의 변수 
        private COM.OraDB MyOraDB = new COM.OraDB();
        private bool _first_flg = true;
        #endregion

        #region 공통메서드 
        private void Init_Form()
        {
            this.Text = "PCC_Incoming Analysis";
            this.lbl_MainTitle.Text = "PCC_Incoming Analysis";
            this.lbl_title.Text = "      Incoming Information";
            ClassLib.ComFunction.SetLangDic(this);


            #region Button Setting
            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Confirm.Enabled = false;

            tbtn_Print.Enabled = true;
            tbtn_Search.Enabled = true;
            #endregion

            #region ComboBox Setting
            _first_flg = true;
            dtp_Std_Ymd.Value = DateTime.Today;
            dtp_Fin_Ymd.Value = DateTime.Today;


            //IN. User Setting
            DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
            cmb_InUser.Enabled = true;
            COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 200);
            cmb_InUser.SelectedIndex = 0;

            //Pur. Division Setting
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            COM.ComCtl.Set_ComboList(dt_ret, cmb_PurDiv, 1, 2, true, 0, 200);
            cmb_PurDiv.SelectedIndex = 0;

            //IN. Division Setting 
            dt_ret = COM.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Incomming_In_Div);
            COM.ComCtl.Set_ComboList(dt_ret, cmb_InDiv, 1, 2, true, 0, 200);
            cmb_InDiv.SelectedIndex = 0;            

            //Print Type
            dt_ret = COM.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Incomming_Print);
            COM.ComCtl.Set_ComboList(dt_ret, cmb_print, 1, 2, false, 0, 200);
            cmb_print.SelectedIndex = 0;
            dt_ret.Dispose();
            _first_flg = false;
            #endregion

            #region Grid Setting
            fgrid_Main.Set_Grid_CDC("SXI_IN_LIST_ANALYSIS", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            //fgrid_Main.Tree.Column = (int)ClassLib.TBSXI_IN_LIST.IxITEM01;
            #endregion

        }
        private void Display_Data()
        {

            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            DataTable dt_list = Select_SXI_In_List();

            int rowcnt = dt_list.Rows.Count;

            for (int i = 0; i < rowcnt; i++)
            {
                fgrid_Main.AddItem(dt_list.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
            }          

            string _in_div = cmb_InDiv.SelectedValue.ToString();
            //fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            #region Display Datalist
            //DataTable dt_list = Select_SXI_In_List();


            //for (int i = 0; i < dt_list.Rows.Count; i++)
            //{

            //    int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXI_IN_LIST_ANA.IxLEVEL].ToString());
            //    fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, tree_level);

            //    #region Level에 따른 Grid Edit & BackColor 설정
            //    if (tree_level == 1)
            //    {
            //        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;
            //        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.White;
            //    }
            //    else if (tree_level == 2)
            //    {
            //        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
            //        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
            //    }

            //    #endregion                

            //}
            #endregion

            //fgrid_Main.Tree.Show(1);			
             
        }

        #endregion

        #region 이벤트 처리

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1)
                    return;

                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

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
        private void cmb_InUser_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InUser.SelectedIndex == -1)
                    return;

                //IN. Number Setting
                DataTable dt_ret = Select_Get_In_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, cmb_InUser.SelectedValue.ToString());
                COM.ComCtl.Set_ComboList(dt_ret, cmb_InNo, 0, 0, true, 0, 200);
                cmb_InNo.SelectedIndex = 0;

                dt_ret.Dispose();

            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSelect, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void cmb_InNo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InNo.SelectedIndex == -1)
                    return;

                //Vendor Setting 
                DataTable dt_ret = Select_SXI_In_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_Combo(cmb_InNo, ""), ClassLib.ComFunction.Empty_Combo(cmb_InUser, ""));
                COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, 0, 200);
                cmb_Vendor.SelectedIndex = 0;

                dt_ret.Dispose();


            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSelect, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void dtp_Std_Ymd_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (_first_flg)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Fin_Ymd.Value = dtp_Std_Ymd.Value;
                }

                //IN. User Setting
                DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
                cmb_InUser.Enabled = true;
                COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 200);
                cmb_InUser.SelectedIndex = 0;

            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSelect, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void dtp_Fin_Ymd_CloseUp(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (_first_flg)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Std_Ymd.Value = dtp_Fin_Ymd.Value;
                }

                //IN. User Setting
                DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
                cmb_InUser.Enabled = true;
                COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 200);
                cmb_InUser.SelectedIndex = 0;
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSelect, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #endregion

        #region Button Event
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                Display_Data();
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
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";

                if (cmb_print.SelectedValue.ToString() == "M")//Incoming Inspection By Material
                {
                    mrd_Filename = Application.StartupPath + "\\Incoming_List_Mat" + ".mrd";
                    sPara = " /rp " + "[" + cmb_Factory.SelectedValue.ToString() + "]" + " [" + dtp_Std_Ymd.Text + "]" + " [" + dtp_Fin_Ymd.Text + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_InNo, "") + "]"
                                    + " [" + ClassLib.ComFunction.Empty_Combo(cmb_Vendor, "") + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_InDiv, "") + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_PurDiv, "") + "]"
                                    + " [" + ClassLib.ComFunction.Empty_Combo(cmb_InUser, "") + "]" + " [" + ClassLib.ComFunction.Empty_TextBox(txt_mat_name, "") + "]";
                                      
                }
                if (cmb_print.SelectedValue.ToString() == "D")//Incoming Inspection By Incoming Date
                {
                    mrd_Filename = Application.StartupPath + "\\Incoming_List_Date" + ".mrd";
                    sPara = " /rp " + "[" + cmb_Factory.SelectedValue.ToString() + "]" + " [" + dtp_Std_Ymd.Text + "]" + " [" + dtp_Fin_Ymd.Text + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_InNo, "") + "]"
                                    + " [" + ClassLib.ComFunction.Empty_Combo(cmb_Vendor, "") + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_InDiv, "") + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_PurDiv, "") + "]"
                                    + " [" + ClassLib.ComFunction.Empty_Combo(cmb_InUser, "") + "]" + " [" + ClassLib.ComFunction.Empty_TextBox(txt_mat_name, "") + "]";
                }

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();	

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

        #endregion

        #region DB Connect
        private DataTable Select_SXI_In_User(string arg_factory, string arg_std_ymd, string arg_fin_ymd)
        {

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_ANALYSIS_IN_USER";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;
            return DS_Ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable Select_Pur_Div(string arg_factory, string arg_com_cd)
        {


            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_PUR_DIV";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_com_cd;
            MyOraDB.Parameter_Values[2] = "";


            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_Get_In_No(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_in_user)
        {


            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_ANALYSIS_IN_NO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_IN_USER";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = arg_in_user;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }

        private DataTable Select_SXI_In_Vendor(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_in_no, string arg_in_user)
        {


            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_ANALYSIS_IN_VENDOR";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[4] = "ARG_IN_USER";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = arg_in_no;
            MyOraDB.Parameter_Values[4] = arg_in_user;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_SXI_In_List()
        {

            MyOraDB.ReDim_Parameter(10);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_ANALYSIS_IN_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VENDOR";
            MyOraDB.Parameter_Name[5] = "ARG_IN_DIV";
            MyOraDB.Parameter_Name[6] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[7] = "ARG_IN_USER";
            MyOraDB.Parameter_Name[8] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dtp_Std_Ymd.Text;
            MyOraDB.Parameter_Values[2] = dtp_Fin_Ymd.Text;
            MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_InNo, "");
            MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_Vendor, "");
            MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_InDiv, "");
            MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(cmb_PurDiv,"");
            MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_Combo(cmb_InUser, "");
            MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_TextBox(txt_mat_name, "");
            MyOraDB.Parameter_Values[9] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        private void Form_Incomming_Analysis_Load(object sender, EventArgs e)
        {
            try
            {
                //factory 
                DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }		

        }

        
        
    }
}

